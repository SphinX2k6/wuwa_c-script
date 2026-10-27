using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Teleport;
using Google.Protobuf.Collections;

// Token: 0x020031A5 RID: 12709
[NullableContext(2)]
[Nullable(0)]
public class CharacterVisionComponent : EntityComponent
{
	// Token: 0x0601B61B RID: 112155 RVA: 0x0077C5A8 File Offset: 0x0077A7A8
	protected override bool OnStart()
	{
		EntityComponentPb valueOrDefault = base.Entity.GetComponent<CreatureDataComponent>().ComponentDataMap.GetValueOrDefault("VisionSkillComponent");
		VisionSkillComponentPb visionSkillComponentPb = (valueOrDefault != null) ? valueOrDefault.VisionSkillComponent : null;
		RepeatedField<VisionSkillInformation> repeatedField = (visionSkillComponentPb != null) ? visionSkillComponentPb.VisionSkillInfos : null;
		VisionSkillInformation visionControlSkillInfo = (visionSkillComponentPb != null) ? visionSkillComponentPb.PhantomSkillInfo : null;
		if (this.VisionInformationList == null)
		{
			this.VisionInformationList = ((repeatedField != null) ? new List<VisionSkillInformation>(repeatedField) : new List<VisionSkillInformation>());
		}
		if (this.VisionControlSkillInfo == null)
		{
			this.VisionControlSkillInfo = visionControlSkillInfo;
		}
		this.RefreshVisionIdList();
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component != null)
		{
			this.VisionTriggerTask = component.ListenForTagAnyCountChanged(visionTriggerTag.Value, delegate(int newCount, int tagId, int exactTagId, int oldCount)
			{
				if (newCount > oldCount)
				{
					SceneTeamController.Instance.EmitEvent<int>(base.Entity, EEventName.ActivateAbilityVision, exactTagId);
				}
			});
		}
		foreach (ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>> valueTuple in visionTypes.Value)
		{
			EVisionType item = valueTuple.Item1;
			Func<CharacterVisionComponent, GameplayAbilityVisionBase> item2 = valueTuple.Item2;
			this.GameplayAbilityVisionMap[item] = GameplayAbilityVisionBase.Spawn(item2, this);
		}
		EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharSkillTargetChanged, new Action<EntityHandle, string>(this.OnSkillTargetChanged));
		this.AddVisionInputLayer();
		return true;
	}

	// Token: 0x0601B61C RID: 112156 RVA: 0x0077C6F8 File Offset: 0x0077A8F8
	protected override bool OnEnd()
	{
		foreach (GameplayAbilityVisionBase gameplayAbilityVisionBase in this.GameplayAbilityVisionMap.Values)
		{
			gameplayAbilityVisionBase.Destroy();
		}
		if (this.VisionTriggerTask != null)
		{
			this.VisionTriggerTask.EndTask();
		}
		EventSystem.Instance.Remove(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Remove(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharSkillTargetChanged, new Action<EntityHandle, string>(this.OnSkillTargetChanged));
		this.RemoveVisionInputLayer();
		return true;
	}

	// Token: 0x0601B61D RID: 112157 RVA: 0x0077C7C0 File Offset: 0x0077A9C0
	protected override void OnTick(float delta)
	{
		foreach (GameplayAbilityVisionBase gameplayAbilityVisionBase in this.GameplayAbilityVisionMap.Values)
		{
			gameplayAbilityVisionBase.Tick(delta);
		}
	}

	// Token: 0x0601B61E RID: 112158 RVA: 0x0077C818 File Offset: 0x0077AA18
	[NullableContext(1)]
	public void SetVisionData(VisionSkillChangeNotify data)
	{
		this.VisionInformationList = new List<VisionSkillInformation>(data.VisionSkillInfos);
		this.VisionControlSkillInfo = data.PhantomSkillInfo;
		this.RefreshVisionIdList();
	}

	// Token: 0x0601B61F RID: 112159 RVA: 0x0077C840 File Offset: 0x0077AA40
	public int GetVisionLevel()
	{
		int currentPosition = this.GetCurrentPosition();
		if (this.VisionInformationList == null || currentPosition < 0 || currentPosition >= this.VisionInformationList.Count)
		{
			return 0;
		}
		return this.VisionInformationList[currentPosition].Quality;
	}

	// Token: 0x0601B620 RID: 112160 RVA: 0x0077C884 File Offset: 0x0077AA84
	public int GetVisionLevelByBuffId(long buffId)
	{
		if (this.VisionInformationList != null)
		{
			foreach (VisionSkillInformation visionSkillInformation in this.VisionInformationList)
			{
				if (visionSkillInformation.Quality > 0 && PhantomUtil.GetSkillBuffIds(visionSkillInformation.SkillId).Contains(buffId))
				{
					return visionSkillInformation.Quality;
				}
			}
			return -1;
		}
		return -1;
	}

	// Token: 0x0601B621 RID: 112161 RVA: 0x0077C900 File Offset: 0x0077AB00
	public int GetVisionLevelByDamageId(long damageId)
	{
		if (this.VisionInformationList != null)
		{
			foreach (VisionSkillInformation visionSkillInformation in this.VisionInformationList)
			{
				if (visionSkillInformation.Quality > 0 && PhantomUtil.GetSkillSettleIds(visionSkillInformation.SkillId).Contains(damageId))
				{
					return visionSkillInformation.Quality;
				}
			}
			return -1;
		}
		return -1;
	}

	// Token: 0x0601B622 RID: 112162 RVA: 0x0077C97C File Offset: 0x0077AB7C
	public SVisionData GetVisionData(int visionId)
	{
		if (Array.IndexOf<int>(this.VisionIdList, visionId) < 0)
		{
			return null;
		}
		return PhantomUtil.GetVisionData(visionId);
	}

	// Token: 0x0601B623 RID: 112163 RVA: 0x0077C998 File Offset: 0x0077AB98
	public bool ActivateAbilityVision(EVisionType visionType)
	{
		bool flag = this.GameplayAbilityVisionMap.ContainsKey(visionType) && this.GameplayAbilityVisionMap[visionType].ActivateAbility();
		if (flag && (visionType == EVisionType.召唤 || visionType == EVisionType.变身 || visionType == EVisionType.驻场))
		{
			SceneTeamController.Instance.EmitEvent<int>(base.Entity, EEventName.ActivateAbilityVision, this.GetVisionId(new int?(0)));
			this.VisionTriggerPush(this.GetVisionId(new int?(0)));
		}
		return flag;
	}

	// Token: 0x0601B624 RID: 112164 RVA: 0x0077CA08 File Offset: 0x0077AC08
	public bool EndAbilityVision(EVisionType visionType)
	{
		return this.GameplayAbilityVisionMap.ContainsKey(visionType) && this.GameplayAbilityVisionMap[visionType].EndAbility();
	}

	// Token: 0x0601B625 RID: 112165 RVA: 0x0077CA2C File Offset: 0x0077AC2C
	public int GetVisionId(int? pos = null)
	{
		int num = pos ?? this.GetCurrentPosition();
		if (num < 0 || num >= this.VisionIdList.Length)
		{
			return 0;
		}
		return this.VisionIdList[num];
	}

	// Token: 0x0601B626 RID: 112166 RVA: 0x0077CA6D File Offset: 0x0077AC6D
	public int GetVisionControlSkillId()
	{
		VisionSkillInformation visionControlSkillInfo = this.VisionControlSkillInfo;
		if (visionControlSkillInfo == null)
		{
			return 0;
		}
		return visionControlSkillInfo.SkillId;
	}

	// Token: 0x0601B627 RID: 112167 RVA: 0x0077CA80 File Offset: 0x0077AC80
	public bool HandlePress(AkiClient.Game.Aki.Character.Input.Enum.EInputAction action, float time)
	{
		using (Dictionary<EVisionType, GameplayAbilityVisionBase>.ValueCollection.Enumerator enumerator = this.GameplayAbilityVisionMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.HandlePress(action, time))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0601B628 RID: 112168 RVA: 0x0077CAE0 File Offset: 0x0077ACE0
	public void SetCurrentPosition(int pos)
	{
		if (this.Position != pos)
		{
			this.Position = pos;
			EventSystem.Instance.EmitWithTarget<int>(base.Entity, EEventName.EntityVisionPosChanged, pos);
		}
	}

	// Token: 0x0601B629 RID: 112169 RVA: 0x0077CB09 File Offset: 0x0077AD09
	public int GetCurrentPosition()
	{
		return this.Position;
	}

	// Token: 0x0601B62A RID: 112170 RVA: 0x0077CB14 File Offset: 0x0077AD14
	public long GetVisionCreatureDataId()
	{
		int currentPosition = this.GetCurrentPosition();
		if (this.VisionInformationList == null || currentPosition < 0 || currentPosition >= this.VisionInformationList.Count)
		{
			return 0L;
		}
		return MathUtils.Instance.LongToNumber(this.VisionInformationList[currentPosition].VisionEntityId);
	}

	// Token: 0x0601B62B RID: 112171 RVA: 0x0077CB60 File Offset: 0x0077AD60
	private void RefreshVisionIdList()
	{
		VisionSkillInformation visionSkillInformation = null;
		int currentPosition = -1;
		if (this.VisionInformationList != null)
		{
			for (int i = 0; i < this.VisionInformationList.Count; i++)
			{
				VisionSkillInformation visionSkillInformation2 = this.VisionInformationList[i];
				if (visionSkillInformation2.Index == 0)
				{
					visionSkillInformation = visionSkillInformation2;
					currentPosition = i;
					break;
				}
			}
			this.VisionIdList = new int[this.VisionInformationList.Count];
			for (int j = 0; j < this.VisionInformationList.Count; j++)
			{
				this.VisionIdList[j] = this.VisionInformationList[j].SkillId;
			}
		}
		else
		{
			this.VisionIdList = new int[0];
		}
		if (visionSkillInformation == null)
		{
			this.SetCurrentPosition(-1);
			return;
		}
		this.SetCurrentPosition(currentPosition);
		CharacterSkillCdComponent component = base.Entity.GetComponent<CharacterSkillCdComponent>();
		if (component == null)
		{
			return;
		}
		component.ModifyCdInfo(PhantomUtil.GetSkillGroupId(visionSkillInformation.SkillId), (float)PhantomUtil.GetSkillCd(visionSkillInformation.SkillId));
	}

	// Token: 0x0601B62C RID: 112172 RVA: 0x0077CC44 File Offset: 0x0077AE44
	private void OnTeleportStart(bool loading)
	{
		foreach (GameplayAbilityVisionBase gameplayAbilityVisionBase in this.GameplayAbilityVisionMap.Values)
		{
			gameplayAbilityVisionBase.TeleportStart();
		}
		if (loading && this.VisionInformationList != null)
		{
			foreach (VisionSkillInformation visionSkillInformation in this.VisionInformationList)
			{
				long visionEntityId = visionSkillInformation.VisionEntityId;
				EntityHandle entity = CreatureModel.Instance.GetEntity(MathUtils.Instance.LongToNumber(visionEntityId));
				if (entity != null && entity.Valid)
				{
					CreatureController.Instance.SetEntityEnable(entity.Entity, false, "OnTeleportStart.SetVisionEnable", false);
				}
			}
		}
	}

	// Token: 0x0601B62D RID: 112173 RVA: 0x0077CD1C File Offset: 0x0077AF1C
	private void OnTeleportComplete(TeleportContext teleportContext)
	{
		if (this.VisionInformationList == null)
		{
			return;
		}
		foreach (VisionSkillInformation visionSkillInformation in this.VisionInformationList)
		{
			SVisionData visionData = PhantomUtil.GetVisionData(visionSkillInformation.SkillId);
			if (visionData != null && visionData.类型 == EVisionType.驻场)
			{
				long visionEntityId = visionSkillInformation.VisionEntityId;
				EntityHandle entity = CreatureModel.Instance.GetEntity(MathUtils.Instance.LongToNumber(visionEntityId));
				if (entity != null && entity.Valid)
				{
					CreatureDataComponent creatureDataComponent;
					if (entity == null)
					{
						creatureDataComponent = null;
					}
					else
					{
						WorldEntity entity2 = entity.Entity;
						creatureDataComponent = ((entity2 != null) ? entity2.GetComponent<CreatureDataComponent>() : null);
					}
					CreatureDataComponent creatureDataComponent2 = creatureDataComponent;
					if (creatureDataComponent2 != null)
					{
						SummonCfg? config = ConfigSummonCfgById.GetConfig(creatureDataComponent2.SummonCfgId, true);
						if (config != null && config.GetValueOrDefault().InitVisiable)
						{
							CreatureController.Instance.SetEntityEnable(entity.Entity, true, "OnTeleportComplete.SetVisionEnable", false);
						}
					}
				}
			}
		}
	}

	// Token: 0x0601B62E RID: 112174 RVA: 0x0077CE3C File Offset: 0x0077B03C
	[NullableContext(1)]
	private void OnSkillTargetChanged([Nullable(2)] EntityHandle skillTarget, string skillTargetSocket)
	{
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(base.Entity, ESummonType.ConcomitantVision, 1);
		CharacterSkillComponent characterSkillComponent;
		if (summonedEntity == null)
		{
			characterSkillComponent = null;
		}
		else
		{
			WorldEntity entity = summonedEntity.Entity;
			characterSkillComponent = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
		}
		CharacterSkillComponent characterSkillComponent2 = characterSkillComponent;
		if (characterSkillComponent2 != null && characterSkillComponent2.Valid)
		{
			characterSkillComponent2.SkillTarget = skillTarget;
			characterSkillComponent2.SkillTargetSocket = skillTargetSocket;
		}
	}

	// Token: 0x0601B62F RID: 112175 RVA: 0x0077CE88 File Offset: 0x0077B088
	private void AddVisionInputLayer()
	{
		this.InputLayer = (InputController.Instance.CreateInputLayer(EInputLayer.Vision) as VisionInputLayer);
		if (this.InputLayer != null)
		{
			EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(base.Entity);
			if (handleByEntity != null)
			{
				this.InputLayer.Init(handleByEntity);
				InputController.Instance.AddInputLayer(base.Entity.Id, this.InputLayer);
			}
		}
	}

	// Token: 0x0601B630 RID: 112176 RVA: 0x0077CEEE File Offset: 0x0077B0EE
	private void RemoveVisionInputLayer()
	{
		if (this.InputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(this.InputLayer);
			this.InputLayer.Clear();
			this.InputLayer = null;
		}
	}

	// Token: 0x0601B631 RID: 112177 RVA: 0x0077CF1C File Offset: 0x0077B11C
	private void VisionTriggerPush(int visionId)
	{
		VisionTriggerPush visionTriggerPush = Aki.Protocol.VisionTriggerPush.Create();
		visionTriggerPush.NumberId = visionId;
		CombatNet.Instance.Send(EPushMessageId.VisionTriggerPush, base.Entity, visionTriggerPush, null, null, null);
	}

	// Token: 0x0601B632 RID: 112178 RVA: 0x0077CF68 File Offset: 0x0077B168
	[CombatListen(ENotifyMessageId.VisionTriggerNotify, true, false)]
	public static void VisionTriggerNotify(Entity entity, [Nullable(1)] VisionTriggerNotify data, CombatCommon combatCommon = null)
	{
		if (entity == null)
		{
			return;
		}
		int numberId = data.NumberId;
		SceneTeamController.Instance.EmitEvent<int>(entity, EEventName.ActivateAbilityVision, numberId);
	}

	// Token: 0x0601B633 RID: 112179 RVA: 0x0077CF94 File Offset: 0x0077B194
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterVisionComponent characterVisionComponent = (CharacterVisionComponent)componentTemplate;
		if (base.CanResetComponentProperty("VisionInformationList"))
		{
			if (characterVisionComponent.VisionInformationList == null)
			{
				this.VisionInformationList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<VisionSkillInformation>>(this.VisionInformationList), "VisionInformationList"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("VisionControlSkillInfo"))
		{
			if (characterVisionComponent.VisionControlSkillInfo == null)
			{
				this.VisionControlSkillInfo = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VisionSkillInformation>(this.VisionControlSkillInfo), "VisionControlSkillInfo"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("GameplayAbilityVisionMap") && characterVisionComponent.GameplayAbilityVisionMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EVisionType, GameplayAbilityVisionBase>>(this.GameplayAbilityVisionMap), "GameplayAbilityVisionMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("VisionIdList"))
		{
			if (characterVisionComponent.VisionIdList == null)
			{
				this.VisionIdList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int[]>(this.VisionIdList), "VisionIdList"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InputLayer"))
		{
			if (characterVisionComponent.InputLayer == null)
			{
				this.InputLayer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VisionInputLayer>(this.InputLayer), "InputLayer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("VisionTriggerTask"))
		{
			if (characterVisionComponent.VisionTriggerTask == null)
			{
				this.VisionTriggerTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.VisionTriggerTask), "VisionTriggerTask"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("Position"))
		{
			this.Position = characterVisionComponent.Position;
		}
		return true;
	}

	// Token: 0x0400D683 RID: 54915
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<VisionSkillInformation> VisionInformationList;

	// Token: 0x0400D684 RID: 54916
	private VisionSkillInformation VisionControlSkillInfo;

	// Token: 0x0400D685 RID: 54917
	[Nullable(1)]
	private readonly Dictionary<EVisionType, GameplayAbilityVisionBase> GameplayAbilityVisionMap = new Dictionary<EVisionType, GameplayAbilityVisionBase>();

	// Token: 0x0400D686 RID: 54918
	[Nullable(1)]
	private int[] VisionIdList = new int[0];

	// Token: 0x0400D687 RID: 54919
	private VisionInputLayer InputLayer;

	// Token: 0x0400D688 RID: 54920
	private ITagTask VisionTriggerTask;

	// Token: 0x0400D689 RID: 54921
	private int Position = -1;
}
