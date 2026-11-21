using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;

// Token: 0x02002702 RID: 9986
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillLili : SpecialSkillBase
{
	// Token: 0x06019054 RID: 102484 RVA: 0x0079E54E File Offset: 0x0079C74E
	[NullableContext(1)]
	public SpecialSkillLili(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06019055 RID: 102485 RVA: 0x0079E56C File Offset: 0x0079C76C
	public override void OnStart()
	{
		this.Entity = this.SpecialSkillComponent.Entity;
		this.AbilityComponent = this.Entity.GetComponent<BaseAbilityComponent>();
		this.TagComponent = this.Entity.GetComponent<RoleTagComponent>();
		this.ActorComponent = this.Entity.GetComponent<BaseActorComponent>();
		CreatureDataComponent component = this.Entity.GetComponent<CreatureDataComponent>();
		this.IsAutonomous = (CreatureModel.Instance.GetPlayerId() == component.GetPlayerId());
		if (this.IsAutonomous)
		{
			if (this.TagComponent != null)
			{
				this.UltraSkillTag = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"]);
				this.ForegroundTag = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]);
				this.InFightTag = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
				this.HasCooldownTag = this.TagComponent.HasTag(SpecialSkillLili.InteractCdTag);
				this.ListenTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltraSkillTagChanged));
				this.ListenTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"], new BaseTagComponent.TTagSwitchedCallback(this.OnForegroundTagChanged));
				this.ListenTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"], new BaseTagComponent.TTagSwitchedCallback(this.OnInFightTagChanged));
				this.ListenTag(SpecialSkillLili.InteractCdTag, new BaseTagComponent.TTagSwitchedCallback(this.OnInteractCdTagChanged));
			}
			EventSystem.Instance.Add<int>(EEventName.UltraSkillInteract, new Action<int>(this.OnUltraSkillInteract));
		}
	}

	// Token: 0x06019056 RID: 102486 RVA: 0x0079E703 File Offset: 0x0079C903
	public override void OnActivate()
	{
		this.InitSummonedEntity();
	}

	// Token: 0x06019057 RID: 102487 RVA: 0x0079E70C File Offset: 0x0079C90C
	public override void OnEnd()
	{
		this.Entity = null;
		this.ClearAllTagTask();
		if (this.IsAutonomous)
		{
			EventSystem.Instance.Remove<int>(EEventName.UltraSkillInteract, new Action<int>(this.OnUltraSkillInteract));
		}
		this.RemoveCooldownTimer();
		this.RemoveCheckDistanceTimer();
		this.RemoveSyncLocationTimer();
		this.RemoveAddInteractTimer();
	}

	// Token: 0x06019058 RID: 102488 RVA: 0x0079E764 File Offset: 0x0079C964
	private void InitSummonedEntity()
	{
		if (!this.IsAutonomous)
		{
			return;
		}
		this.SummonedEntity = PhantomUtil.GetSummonedEntity(this.Entity, ESummonType.ConcomitantCustom, 1);
		EntityHandle summonedEntity = this.SummonedEntity;
		if (summonedEntity == null || !summonedEntity.Valid)
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, this.Entity, "LiLiStar获取伴生物失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PawnInteractNewComponent = this.SummonedEntity.Entity.GetComponent<PawnInteractNewComponent>();
		this.SummonedEntityActorComp = this.SummonedEntity.Entity.GetComponent<BaseActorComponent>();
		CreatureController.Instance.SetEntityEnable(this.SummonedEntity.Entity, false, "莉莉丝初始化", false);
		CreatureController.Instance.SetActorVisible(this.SummonedEntity.Entity, false, false, false, "莉莉丝Activate", false);
	}

	// Token: 0x06019059 RID: 102489 RVA: 0x0079E82A File Offset: 0x0079CA2A
	private void OnUltraSkillTagChanged(int tagId, bool tagExist)
	{
		this.UltraSkillTag = tagExist;
		this.SyncSummonedEntityLocation();
		this.RefreshInteractState();
		this.RefreshCheckdDistance();
		if (!tagExist)
		{
			this.InteractCount = 0;
		}
	}

	// Token: 0x0601905A RID: 102490 RVA: 0x0079E850 File Offset: 0x0079CA50
	private void SyncSummonedEntityLocation()
	{
		if (this.UltraSkillTag && this.SummonedEntityActorComp != null && this.ActorComponent != null)
		{
			if (this.ActorComponent.ActorLocationProxy.Equals(this.SummonedEntityActorComp.ActorLocationProxy, 9.999999747378752E-05))
			{
				return;
			}
			this.SummonedEntityActorComp.SetActorLocation(this.ActorComponent.ActorLocation, "莉莉丝大招同步伴生物位置", true);
		}
	}

	// Token: 0x0601905B RID: 102491 RVA: 0x0079E8B9 File Offset: 0x0079CAB9
	private void OnForegroundTagChanged(int tagId, bool tagExist)
	{
		this.ForegroundTag = tagExist;
		this.RefreshInteractState();
	}

	// Token: 0x0601905C RID: 102492 RVA: 0x0079E8C8 File Offset: 0x0079CAC8
	private void OnInFightTagChanged(int tagId, bool tagExist)
	{
		this.InFightTag = tagExist;
		this.RefreshInteractState();
	}

	// Token: 0x0601905D RID: 102493 RVA: 0x0079E8D7 File Offset: 0x0079CAD7
	private void OnInteractCdTagChanged(int tagId, bool tagExist)
	{
		if (this.HasCooldownTag == tagExist)
		{
			return;
		}
		this.HasCooldownTag = tagExist;
		if (!tagExist)
		{
			this.AddCooldownTimer(3000f);
		}
		this.RefreshInteractState();
	}

	// Token: 0x0601905E RID: 102494 RVA: 0x0079E900 File Offset: 0x0079CB00
	private void RefreshInteractState()
	{
		bool flag = this.UltraSkillTag && !this.ForegroundTag && !this.InFightTag && !this.HasCooldownTag && !this.InCooldown;
		if (this.IsAddInteract == flag)
		{
			return;
		}
		this.IsAddInteract = flag;
		if (flag)
		{
			CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, this.Entity, "添加莉莉大招交互", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.SummonedEntity != null)
			{
				CreatureController.Instance.SetEntityEnable(this.SummonedEntity.Entity, true, "添加莉莉大招交互", false);
			}
			this.AddInteractTimer = TimerSystem.Instance.Next(delegate(float _)
			{
				this.AddInteractTimer = null;
				this.RefreshInteractState();
				if (!this.IsAddInteract || this.Entity == null)
				{
					return;
				}
				string tidContent = (this.InteractCount < 3) ? "Text_Lili_Interact_Content_1" : "Text_Lili_Interact_Content_2";
				PawnInteractNewComponent pawnInteractNewComponent2 = this.PawnInteractNewComponent;
				int? num;
				if (pawnInteractNewComponent2 == null)
				{
					num = null;
				}
				else
				{
					PawnInteractController interactController2 = pawnInteractNewComponent2.GetInteractController();
					num = ((interactController2 != null) ? new int?(interactController2.AddClientInteractOption(new UltraSkillInteract(), null, new EDoInteract?(EDoInteract.Direct), new float?(500f), tidContent, new ECustomOptionType?(ECustomOptionType.None), null, null)) : null);
				}
				int? num2 = num;
				this.InteractHandle = num2.GetValueOrDefault();
			}, null, null);
			return;
		}
		this.RemoveAddInteractTimer();
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, this.Entity, "移除莉莉大招交互", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.SummonedEntity != null)
		{
			CreatureController.Instance.SetEntityEnable(this.SummonedEntity.Entity, false, "移除莉莉大招交互", false);
		}
		if (this.InteractHandle != -1)
		{
			PawnInteractNewComponent pawnInteractNewComponent = this.PawnInteractNewComponent;
			if (pawnInteractNewComponent != null)
			{
				PawnInteractController interactController = pawnInteractNewComponent.GetInteractController();
				if (interactController != null)
				{
					interactController.RemoveClientInteractOption(this.InteractHandle);
				}
			}
			this.InteractHandle = -1;
		}
	}

	// Token: 0x0601905F RID: 102495 RVA: 0x0079EA2C File Offset: 0x0079CC2C
	private void RemoveAddInteractTimer()
	{
		if (this.AddInteractTimer != null)
		{
			TimerSystem.Instance.Remove(this.AddInteractTimer);
			this.AddInteractTimer = null;
		}
	}

	// Token: 0x06019060 RID: 102496 RVA: 0x0079EA50 File Offset: 0x0079CC50
	private void OnUltraSkillInteract(int entityId)
	{
		if (this.SummonedEntity == null || this.SummonedEntity.Id != entityId)
		{
			return;
		}
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, this.Entity, "触发莉莉大招交互", default(ReadOnlySpan<ValueTuple<string, object>>));
		int tagId = (this.InteractCount < 3) ? SpecialSkillLili.InteractTag1 : SpecialSkillLili.InteractTag2;
		this.InteractCount++;
		BaseAbilityComponent abilityComponent = this.AbilityComponent;
		if (abilityComponent != null)
		{
			abilityComponent.SendGameplayEventToActor(GameplayTagUtils.GetGameplayTagById(tagId).Value, null);
		}
		this.AddCooldownTimer(1000f);
		this.RefreshInteractState();
	}

	// Token: 0x06019061 RID: 102497 RVA: 0x0079EAE8 File Offset: 0x0079CCE8
	private void AddCooldownTimer(float interval)
	{
		this.RemoveCooldownTimer();
		this.InCooldown = true;
		this.CooldownTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.InCooldown = false;
			this.CooldownTimer = null;
			this.RefreshInteractState();
		}, interval, null, null, true, 1f);
	}

	// Token: 0x06019062 RID: 102498 RVA: 0x0079EB1C File Offset: 0x0079CD1C
	private void RemoveCooldownTimer()
	{
		if (this.CooldownTimer != null)
		{
			TimerSystem.Instance.Remove(this.CooldownTimer);
			this.CooldownTimer = null;
		}
		this.InCooldown = false;
	}

	// Token: 0x06019063 RID: 102499 RVA: 0x0079EB45 File Offset: 0x0079CD45
	private void RefreshCheckdDistance()
	{
		if (this.UltraSkillTag)
		{
			this.AddCheckDistanceTimer();
			this.AddSyncLocationTimer();
			return;
		}
		this.RemoveCheckDistanceTimer();
		this.RemoveSyncLocationTimer();
	}

	// Token: 0x06019064 RID: 102500 RVA: 0x0079EB68 File Offset: 0x0079CD68
	private void AddCheckDistanceTimer()
	{
		this.RemoveCheckDistanceTimer();
		this.CheckDistanceTimer = TimerSystem.Instance.Forever(delegate(float _)
		{
			this.CheckDistance();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06019065 RID: 102501 RVA: 0x0079EB9C File Offset: 0x0079CD9C
	private void CheckDistance()
	{
		if (!this.IsAutonomous || this.ForegroundTag)
		{
			return;
		}
		if (this.ActorComponent == null)
		{
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Vector vector;
		if (baseCharacter == null)
		{
			vector = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
		}
		Vector vector2 = vector;
		if (vector2 == null)
		{
			return;
		}
		if (Vector.DistSquared(this.ActorComponent.ActorLocationProxy, vector2) > 12250000.0)
		{
			BaseAbilityComponent abilityComponent = this.AbilityComponent;
			if (abilityComponent == null)
			{
				return;
			}
			abilityComponent.SendGameplayEventToActor(GameplayTagUtils.GetGameplayTagById(SpecialSkillLili.FarTag).Value, null);
		}
	}

	// Token: 0x06019066 RID: 102502 RVA: 0x0079EC24 File Offset: 0x0079CE24
	private void RemoveCheckDistanceTimer()
	{
		if (this.CheckDistanceTimer != null)
		{
			TimerSystem.Instance.Remove(this.CheckDistanceTimer);
			this.CheckDistanceTimer = null;
		}
	}

	// Token: 0x06019067 RID: 102503 RVA: 0x0079EC46 File Offset: 0x0079CE46
	private void AddSyncLocationTimer()
	{
		this.RemoveSyncLocationTimer();
		this.SyncLocationTimer = TimerSystem.Instance.Forever(delegate(float _)
		{
			this.SyncSummonedEntityLocation();
		}, 100f, 1f, null, null, true);
	}

	// Token: 0x06019068 RID: 102504 RVA: 0x0079EC77 File Offset: 0x0079CE77
	private void RemoveSyncLocationTimer()
	{
		if (this.SyncLocationTimer != null)
		{
			TimerSystem.Instance.Remove(this.SyncLocationTimer);
			this.SyncLocationTimer = null;
		}
	}

	// Token: 0x06019069 RID: 102505 RVA: 0x0079EC9C File Offset: 0x0079CE9C
	[NullableContext(1)]
	private void ListenTag(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
	{
		RoleTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		ITagTask item = tagComponent.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null);
		this.TagTaskList.Add(item);
	}

	// Token: 0x0601906A RID: 102506 RVA: 0x0079ECD0 File Offset: 0x0079CED0
	private void ClearAllTagTask()
	{
		if (this.TagTaskList != null)
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}
	}

	// Token: 0x0400DA20 RID: 55840
	private const float INTERACT_RANGE = 500f;

	// Token: 0x0400DA21 RID: 55841
	[Nullable(1)]
	private const string INTERACT_CONTENT_1 = "Text_Lili_Interact_Content_1";

	// Token: 0x0400DA22 RID: 55842
	[Nullable(1)]
	private const string INTERACT_CONTENT_2 = "Text_Lili_Interact_Content_2";

	// Token: 0x0400DA23 RID: 55843
	private const float CHECK_DISTANCE_INTERVAL = 1000f;

	// Token: 0x0400DA24 RID: 55844
	private const float SYNC_LOCATION_INTERVAL = 100f;

	// Token: 0x0400DA25 RID: 55845
	private const float MAX_DISTANCE_SQUARED = 12250000f;

	// Token: 0x0400DA26 RID: 55846
	private const int INTERACT_COUNT_CHANGE = 3;

	// Token: 0x0400DA27 RID: 55847
	private static readonly int InteractTag1 = GameplayTagDefine.EGameplayTagId["角色.R2T1LiliMd10011.逻辑标识.莉莉大招睡眠交互"];

	// Token: 0x0400DA28 RID: 55848
	private static readonly int InteractTag2 = GameplayTagDefine.EGameplayTagId["角色.R2T1LiliMd10011.逻辑标识.莉莉大招睡眠戳戳"];

	// Token: 0x0400DA29 RID: 55849
	private static readonly int InteractCdTag = GameplayTagDefine.EGameplayTagId["角色.R2T1LiliMd10011.逻辑标识.莉莉大招交互CD中"];

	// Token: 0x0400DA2A RID: 55850
	private static readonly int FarTag = GameplayTagDefine.EGameplayTagId["角色.R2T1LiliMd10011.逻辑标识.距离前台角色过远"];

	// Token: 0x0400DA2B RID: 55851
	private Entity Entity;

	// Token: 0x0400DA2C RID: 55852
	private EntityHandle SummonedEntity;

	// Token: 0x0400DA2D RID: 55853
	private BaseAbilityComponent AbilityComponent;

	// Token: 0x0400DA2E RID: 55854
	private RoleTagComponent TagComponent;

	// Token: 0x0400DA2F RID: 55855
	private BaseActorComponent ActorComponent;

	// Token: 0x0400DA30 RID: 55856
	private PawnInteractNewComponent PawnInteractNewComponent;

	// Token: 0x0400DA31 RID: 55857
	private BaseActorComponent SummonedEntityActorComp;

	// Token: 0x0400DA32 RID: 55858
	private bool IsAutonomous;

	// Token: 0x0400DA33 RID: 55859
	[Nullable(1)]
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400DA34 RID: 55860
	private bool UltraSkillTag;

	// Token: 0x0400DA35 RID: 55861
	private bool ForegroundTag;

	// Token: 0x0400DA36 RID: 55862
	private bool InFightTag;

	// Token: 0x0400DA37 RID: 55863
	private bool HasCooldownTag;

	// Token: 0x0400DA38 RID: 55864
	private bool IsAddInteract;

	// Token: 0x0400DA39 RID: 55865
	private int InteractHandle = -1;

	// Token: 0x0400DA3A RID: 55866
	private bool InCooldown;

	// Token: 0x0400DA3B RID: 55867
	private TimerHandle CooldownTimer;

	// Token: 0x0400DA3C RID: 55868
	private TimerHandle CheckDistanceTimer;

	// Token: 0x0400DA3D RID: 55869
	private TimerHandle SyncLocationTimer;

	// Token: 0x0400DA3E RID: 55870
	private TimerHandle AddInteractTimer;

	// Token: 0x0400DA3F RID: 55871
	private int InteractCount;
}
