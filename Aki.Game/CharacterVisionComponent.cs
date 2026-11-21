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

// Token: 0x02002714 RID: 10004
[NullableContext(1)]
[Nullable(0)]
public class CharacterVisionComponent : EntityComponent
{
	// Token: 0x06019144 RID: 102724 RVA: 0x007A47E4 File Offset: 0x007A29E4
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

	// Token: 0x06019145 RID: 102725 RVA: 0x007A4934 File Offset: 0x007A2B34
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

	// Token: 0x06019146 RID: 102726 RVA: 0x007A49FC File Offset: 0x007A2BFC
	protected override void OnTick(float delta)
	{
		foreach (GameplayAbilityVisionBase gameplayAbilityVisionBase in this.GameplayAbilityVisionMap.Values)
		{
			gameplayAbilityVisionBase.Tick(delta);
		}
	}

	// Token: 0x06019147 RID: 102727 RVA: 0x007A4A54 File Offset: 0x007A2C54
	public void SetVisionData(VisionSkillChangeNotify data)
	{
		this.VisionInformationList = new List<VisionSkillInformation>(data.VisionSkillInfos);
		this.VisionControlSkillInfo = data.PhantomSkillInfo;
		this.RefreshVisionIdList();
	}

	// Token: 0x06019148 RID: 102728 RVA: 0x007A4A7C File Offset: 0x007A2C7C
	public int GetVisionLevel()
	{
		int currentPosition = this.GetCurrentPosition();
		if (this.VisionInformationList == null || currentPosition < 0 || currentPosition >= this.VisionInformationList.Count)
		{
			return 0;
		}
		return this.VisionInformationList[currentPosition].Quality;
	}

	// Token: 0x06019149 RID: 102729 RVA: 0x007A4AC0 File Offset: 0x007A2CC0
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

	// Token: 0x0601914A RID: 102730 RVA: 0x007A4B3C File Offset: 0x007A2D3C
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

	// Token: 0x0601914B RID: 102731 RVA: 0x007A4BB8 File Offset: 0x007A2DB8
	[NullableContext(2)]
	public SVisionData GetVisionData(int visionId)
	{
		if (Array.IndexOf<int>(this.VisionIdList, visionId) < 0)
		{
			return null;
		}
		return PhantomUtil.GetVisionData(visionId);
	}

	// Token: 0x0601914C RID: 102732 RVA: 0x007A4BD4 File Offset: 0x007A2DD4
	public bool ActivateAbilityVision(EVisionType visionType)
	{
		GameplayAbilityVisionBase valueOrDefault = this.GameplayAbilityVisionMap.GetValueOrDefault(visionType);
		GameplayAbilityVisionMorph gameplayAbilityVisionMorph = valueOrDefault as GameplayAbilityVisionMorph;
		if (gameplayAbilityVisionMorph != null)
		{
			this.TryInterruptConflictMorph(gameplayAbilityVisionMorph);
		}
		bool flag = valueOrDefault != null && valueOrDefault.ActivateAbility();
		if (flag && (visionType == EVisionType.召唤 || visionType == EVisionType.变身 || visionType == EVisionType.驻场))
		{
			SceneTeamController.Instance.EmitEvent<int>(base.Entity, EEventName.ActivateAbilityVision, this.GetVisionId(new int?(0)));
			this.VisionTriggerPush(this.GetVisionId(new int?(0)));
		}
		return flag;
	}

	// Token: 0x0601914D RID: 102733 RVA: 0x007A4C4B File Offset: 0x007A2E4B
	public bool EndAbilityVision(EVisionType visionType)
	{
		return this.GameplayAbilityVisionMap.ContainsKey(visionType) && this.GameplayAbilityVisionMap[visionType].EndAbility();
	}

	// Token: 0x0601914E RID: 102734 RVA: 0x007A4C70 File Offset: 0x007A2E70
	public int GetVisionId(int? pos = null)
	{
		int num = pos ?? this.GetCurrentPosition();
		if (num < 0 || num >= this.VisionIdList.Length)
		{
			return 0;
		}
		return this.VisionIdList[num];
	}

	// Token: 0x0601914F RID: 102735 RVA: 0x007A4CB1 File Offset: 0x007A2EB1
	public int GetVisionControlSkillId()
	{
		VisionSkillInformation visionControlSkillInfo = this.VisionControlSkillInfo;
		if (visionControlSkillInfo == null)
		{
			return 0;
		}
		return visionControlSkillInfo.SkillId;
	}

	// Token: 0x06019150 RID: 102736 RVA: 0x007A4CC4 File Offset: 0x007A2EC4
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

	// Token: 0x06019151 RID: 102737 RVA: 0x007A4D24 File Offset: 0x007A2F24
	public void SetCurrentPosition(int pos)
	{
		if (this.Position != pos)
		{
			this.Position = pos;
			EventSystem.Instance.EmitWithTarget<int>(base.Entity, EEventName.EntityVisionPosChanged, pos);
		}
	}

	// Token: 0x06019152 RID: 102738 RVA: 0x007A4D4D File Offset: 0x007A2F4D
	public int GetCurrentPosition()
	{
		return this.Position;
	}

	// Token: 0x06019153 RID: 102739 RVA: 0x007A4D58 File Offset: 0x007A2F58
	public long GetVisionCreatureDataId()
	{
		int currentPosition = this.GetCurrentPosition();
		if (this.VisionInformationList == null || currentPosition < 0 || currentPosition >= this.VisionInformationList.Count)
		{
			return 0L;
		}
		return MathUtils.Instance.LongToNumber(this.VisionInformationList[currentPosition].VisionEntityId);
	}

	// Token: 0x06019154 RID: 102740 RVA: 0x007A4DA4 File Offset: 0x007A2FA4
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

	// Token: 0x06019155 RID: 102741 RVA: 0x007A4E88 File Offset: 0x007A3088
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

	// Token: 0x06019156 RID: 102742 RVA: 0x007A4F60 File Offset: 0x007A3160
	[NullableContext(2)]
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

	// Token: 0x06019157 RID: 102743 RVA: 0x007A5080 File Offset: 0x007A3280
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

	// Token: 0x06019158 RID: 102744 RVA: 0x007A50CC File Offset: 0x007A32CC
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

	// Token: 0x06019159 RID: 102745 RVA: 0x007A5132 File Offset: 0x007A3332
	private void RemoveVisionInputLayer()
	{
		if (this.InputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(this.InputLayer);
			this.InputLayer.Clear();
			this.InputLayer = null;
		}
	}

	// Token: 0x0601915A RID: 102746 RVA: 0x007A5160 File Offset: 0x007A3360
	public void InitAbilityVision(EVisionType visionType)
	{
		if (this.GameplayAbilityVisionMap.ContainsKey(visionType))
		{
			return;
		}
		Func<CharacterVisionComponent, GameplayAbilityVisionBase> func = null;
		foreach (ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>> valueTuple in visionTypes.Value)
		{
			EVisionType item = valueTuple.Item1;
			Func<CharacterVisionComponent, GameplayAbilityVisionBase> item2 = valueTuple.Item2;
			if (item == visionType)
			{
				func = item2;
				break;
			}
		}
		if (func == null)
		{
			return;
		}
		this.GameplayAbilityVisionMap[visionType] = GameplayAbilityVisionBase.Spawn(func, this);
	}

	// Token: 0x0601915B RID: 102747 RVA: 0x007A51C8 File Offset: 0x007A33C8
	private void TryInterruptConflictMorph(GameplayAbilityVisionMorph incoming)
	{
		foreach (GameplayAbilityVisionBase gameplayAbilityVisionBase in this.GameplayAbilityVisionMap.Values)
		{
			if (gameplayAbilityVisionBase != incoming && gameplayAbilityVisionBase is GameplayAbilityVisionMorph)
			{
				GameplayAbilityVisionMorph gameplayAbilityVisionMorph = gameplayAbilityVisionBase as GameplayAbilityVisionMorph;
				if (gameplayAbilityVisionMorph.IsMorphActivating && (gameplayAbilityVisionMorph.CanInterruptMorph() || incoming.CanInterruptMorph()))
				{
					gameplayAbilityVisionMorph.InterruptMorph();
				}
			}
		}
	}

	// Token: 0x0601915C RID: 102748 RVA: 0x007A524C File Offset: 0x007A344C
	private void VisionTriggerPush(int visionId)
	{
		VisionTriggerPush visionTriggerPush = Aki.Protocol.VisionTriggerPush.Create();
		visionTriggerPush.NumberId = visionId;
		CombatNet.Instance.Send(EPushMessageId.VisionTriggerPush, base.Entity, visionTriggerPush, null, null, null);
	}

	// Token: 0x0601915D RID: 102749 RVA: 0x007A5298 File Offset: 0x007A3498
	[NullableContext(2)]
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

	// Token: 0x0601915E RID: 102750 RVA: 0x007A52C4 File Offset: 0x007A34C4
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterVisionComponent characterVisionComponent = (CharacterVisionComponent)componentTemplate;
		if (characterVisionComponent.VisionInformationList == null)
		{
			this.VisionInformationList = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VisionInformationList), "VisionInformationList"))
		{
			return false;
		}
		if (characterVisionComponent.VisionControlSkillInfo == null)
		{
			this.VisionControlSkillInfo = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VisionControlSkillInfo), "VisionControlSkillInfo"))
		{
			return false;
		}
		if (characterVisionComponent.GameplayAbilityVisionMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.GameplayAbilityVisionMap), "GameplayAbilityVisionMap"))
		{
			return false;
		}
		if (characterVisionComponent.VisionIdList == null)
		{
			this.VisionIdList = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VisionIdList), "VisionIdList"))
		{
			return false;
		}
		if (characterVisionComponent.InputLayer == null)
		{
			this.InputLayer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputLayer), "InputLayer"))
		{
			return false;
		}
		if (characterVisionComponent.VisionTriggerTask == null)
		{
			this.VisionTriggerTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VisionTriggerTask), "VisionTriggerTask"))
		{
			return false;
		}
		this.Position = characterVisionComponent.Position;
		return true;
	}

	// Token: 0x170027D2 RID: 10194
	// (get) Token: 0x0601915F RID: 102751 RVA: 0x007A53E9 File Offset: 0x007A35E9
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027D3 RID: 10195
	// (get) Token: 0x06019160 RID: 102752 RVA: 0x007A53EC File Offset: 0x007A35EC
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027D4 RID: 10196
	// (get) Token: 0x06019161 RID: 102753 RVA: 0x007A53EF File Offset: 0x007A35EF
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DB09 RID: 56073
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<VisionSkillInformation> VisionInformationList;

	// Token: 0x0400DB0A RID: 56074
	[Nullable(2)]
	private VisionSkillInformation VisionControlSkillInfo;

	// Token: 0x0400DB0B RID: 56075
	private readonly Dictionary<EVisionType, GameplayAbilityVisionBase> GameplayAbilityVisionMap = new Dictionary<EVisionType, GameplayAbilityVisionBase>();

	// Token: 0x0400DB0C RID: 56076
	private int[] VisionIdList = new int[0];

	// Token: 0x0400DB0D RID: 56077
	[Nullable(2)]
	private VisionInputLayer InputLayer;

	// Token: 0x0400DB0E RID: 56078
	[Nullable(2)]
	private ITagTask VisionTriggerTask;

	// Token: 0x0400DB0F RID: 56079
	private int Position = -1;
}
