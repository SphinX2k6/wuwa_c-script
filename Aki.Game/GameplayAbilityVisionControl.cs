using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.Vision;

// Token: 0x02002717 RID: 10007
public class GameplayAbilityVisionControl : GameplayAbilityVisionBase, IStaticVariableResetter
{
	// Token: 0x06019182 RID: 102786 RVA: 0x007A5686 File Offset: 0x007A3886
	static GameplayAbilityVisionControl()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameplayAbilityVisionControl.CreateStaticDefaultValue), new Action(GameplayAbilityVisionControl.ResetStaticDefaultValue));
	}

	// Token: 0x06019183 RID: 102787 RVA: 0x007A56A5 File Offset: 0x007A38A5
	[NullableContext(1)]
	public GameplayAbilityVisionControl(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x06019184 RID: 102788 RVA: 0x007A56B0 File Offset: 0x007A38B0
	protected override void OnCreate()
	{
		if (base.CreatureDataComponent.SummonType == ESummonType.ConcomitantPhantomRole)
		{
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.HXY, "GameplayAbilityVisionControl.OnCreate", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetSummonerVisionControlCreatureDataId(new long?(base.CreatureDataComponent.GetCreatureDataId()));
			base.AttributeComponent.AddListener(GameplayAbilityVisionMisc.controlVisionEnergy, new Action<EAttributeType, float, float>(this.OnAttributeChanged), null);
			int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
			CreatureDataComponent component = base.EntityHandle.Entity.GetComponent<CreatureDataComponent>();
			int roleId = component.GetRoleId();
			SceneTeamRole sceneTeamRole = new SceneTeamRole
			{
				CreatureDataId = component.GetCreatureDataId(),
				RoleId = roleId
			};
			SceneTeamModel.Instance.UpdateGroupData(valueOrDefault, new UpdateGroupParams
			{
				GroupType = ETeamGroupType.VisionControl,
				GroupRoleList = new SceneTeamRole[]
				{
					sceneTeamRole
				},
				CurrentRoleId = roleId
			});
		}
	}

	// Token: 0x06019185 RID: 102789 RVA: 0x007A5798 File Offset: 0x007A3998
	protected override void OnDestroy()
	{
		if (base.CreatureDataComponent.SummonType == ESummonType.ConcomitantPhantomRole)
		{
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.HXY, "GameplayAbilityVisionControl.OnDestroy", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetSummonerVisionControlCreatureDataId(null);
			base.AttributeComponent.RemoveListener(GameplayAbilityVisionMisc.controlVisionEnergy, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
			this.EndSummonerVisionControl();
			int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
			SceneTeamModel.Instance.UpdateGroupData(valueOrDefault, new UpdateGroupParams
			{
				GroupType = ETeamGroupType.VisionControl,
				GroupRoleList = Array.Empty<SceneTeamRole>(),
				CurrentRoleId = 0
			});
		}
		if (this.WaitDisableHideActorTagRemoveTask != null)
		{
			this.WaitDisableHideActorTagRemoveTask.EndTask();
			this.WaitDisableHideActorTagRemoveTask = null;
		}
	}

	// Token: 0x06019186 RID: 102790 RVA: 0x007A585C File Offset: 0x007A3A5C
	protected override bool OnActivateAbility()
	{
		Log.Instance.Info(ELogModule.Battle, ELogAuthor.HXY, "GameplayAbilityVisionControl.OnActivateAbility", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (GameplayAbilityVisionControl.VisionControlHandle != null)
		{
			return false;
		}
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(base.Entity, ESummonType.ConcomitantPhantomRole, 1);
		if (summonedEntity == null)
		{
			return false;
		}
		RoleTeamComponent roleTeamComponent = summonedEntity.Entity.CheckGetComponent<RoleTeamComponent>();
		if (roleTeamComponent != null)
		{
			roleTeamComponent.SetTeamTag(ETeamState.UnderStage);
		}
		GameplayAbilityVisionControl.VisionControlHandle = summonedEntity;
		this.Recover(summonedEntity);
		this.LastGroupType = SceneTeamModel.Instance.CurrentGroupType;
		int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
		SceneTeamModel.Instance.SwitchGroup(valueOrDefault, ETeamGroupType.VisionControl, true, false);
		return true;
	}

	// Token: 0x06019187 RID: 102791 RVA: 0x007A58F8 File Offset: 0x007A3AF8
	protected override bool OnEndAbility()
	{
		Log.Instance.Info(ELogModule.Battle, ELogAuthor.HXY, "GameplayAbilityVisionControl.OnEndAbility", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (GameplayAbilityVisionControl.VisionControlHandle == null || this.IsEnding)
		{
			return false;
		}
		this.IsEnding = true;
		this.PlayEndEffect();
		return true;
	}

	// Token: 0x06019188 RID: 102792 RVA: 0x007A5940 File Offset: 0x007A3B40
	private void SetSummonerVisionControlCreatureDataId(long? id)
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity(base.CreatureDataComponent.GetSummonerId());
		if (entity != null)
		{
			entity.Entity.GetComponent<CreatureDataComponent>().VisionControlCreatureDataId = id;
		}
	}

	// Token: 0x06019189 RID: 102793 RVA: 0x007A5978 File Offset: 0x007A3B78
	private void OnAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		if (newValue < 1.1754944E-38f)
		{
			RoleTeamComponent teamComponent = base.TeamComponent;
			if (teamComponent != null)
			{
				teamComponent.SetTeamTag(ETeamState.OnStageWithoutControl);
			}
			if (base.GameplayTagComponent.HasTag(GameplayAbilityVisionMisc.skillTag))
			{
				if (this.WaitDisableHideActorTagRemoveTask == null)
				{
					this.WaitDisableHideActorTagRemoveTask = base.GameplayTagComponent.ListenForTagAddOrRemove(new int?(GameplayAbilityVisionMisc.skillTag), delegate(int tagId, bool tagExist)
					{
						if (!tagExist)
						{
							ITagTask waitDisableHideActorTagRemoveTask = this.WaitDisableHideActorTagRemoveTask;
							if (waitDisableHideActorTagRemoveTask != null)
							{
								waitDisableHideActorTagRemoveTask.EndTask();
							}
							this.WaitDisableHideActorTagRemoveTask = null;
							this.EndSummonerVisionControl();
						}
					}, null);
					return;
				}
			}
			else
			{
				this.EndSummonerVisionControl();
			}
		}
	}

	// Token: 0x0601918A RID: 102794 RVA: 0x007A59E8 File Offset: 0x007A3BE8
	private void EndSummonerVisionControl()
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity(base.CreatureDataComponent.GetSummonerId());
		if (entity != null && entity.Valid)
		{
			entity.Entity.GetComponent<CharacterVisionComponent>().EndAbilityVision(EVisionType.操控);
			return;
		}
		GameplayAbilityVisionControl.VisionControlHandle = null;
	}

	// Token: 0x0601918B RID: 102795 RVA: 0x007A5A30 File Offset: 0x007A3C30
	[NullableContext(1)]
	private void Recover(EntityHandle handle)
	{
		if (handle.Valid)
		{
			CharacterBuffComponent component = handle.Entity.GetComponent<CharacterBuffComponent>();
			component.AddBuff(9100000020002L, new AddBuffParam
			{
				InstigatorId = component.CreatureDataId,
				Reason = "操控幻象回满能量"
			});
		}
	}

	// Token: 0x0601918C RID: 102796 RVA: 0x007A5A7C File Offset: 0x007A3C7C
	private void PlayEndEffect()
	{
		TimerHandle capturedVisionHiddenTimer = null;
		capturedVisionHiddenTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.HXY, "幻象消失材质没有正常结束，被保底", default(ReadOnlySpan<ValueTuple<string, object>>));
			capturedVisionHiddenTimer = null;
			this.SwitchBackToRole();
		}, 1000f, null, null, true, 1f);
		CharacterGameplayCueComponent component = GameplayAbilityVisionControl.VisionControlHandle.Entity.GetComponent<CharacterGameplayCueComponent>();
		if (component != null)
		{
			component.AddCue(19000000182L, new GameplayCueParam?(new GameplayCueParam
			{
				Sync = new bool?(true),
				Instant = true
			}));
		}
		this.CueHandle = component.AddCue(19000000181L, new GameplayCueParam?(new GameplayCueParam
		{
			EndCallback = delegate()
			{
				if (capturedVisionHiddenTimer != null && TimerSystem.Instance.Has(capturedVisionHiddenTimer))
				{
					TimerSystem.Instance.Remove(capturedVisionHiddenTimer);
					capturedVisionHiddenTimer = null;
					this.SwitchBackToRole();
				}
			},
			Sync = new bool?(true)
		}));
	}

	// Token: 0x0601918D RID: 102797 RVA: 0x007A5B50 File Offset: 0x007A3D50
	private void SwitchBackToRole()
	{
		this.IsEnding = false;
		base.CueComponent.AddCue(19000000201L, new GameplayCueParam?(new GameplayCueParam
		{
			Sync = new bool?(true),
			Instant = true
		}));
		int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
		SceneTeamModel.Instance.SwitchGroup(valueOrDefault, this.LastGroupType.GetValueOrDefault(ETeamGroupType.Battle), false, false);
		this.LastGroupType = null;
		EntityHandle visionControlHandle = GameplayAbilityVisionControl.VisionControlHandle;
		object obj;
		if (visionControlHandle == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = visionControlHandle.Entity;
			obj = ((entity != null) ? entity.GetComponent<CharacterGameplayCueComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.RemoveCueByHandle((long)this.CueHandle);
		}
		GameplayAbilityVisionControl.VisionControlHandle = null;
	}

	// Token: 0x0601918E RID: 102798 RVA: 0x007A5C09 File Offset: 0x007A3E09
	public static void CreateStaticDefaultValue()
	{
		GameplayAbilityVisionControl.VisionControlHandle = null;
	}

	// Token: 0x0601918F RID: 102799 RVA: 0x007A5C11 File Offset: 0x007A3E11
	public static void ResetStaticDefaultValue()
	{
		GameplayAbilityVisionControl.VisionControlHandle = null;
	}

	// Token: 0x0400DB11 RID: 56081
	[Nullable(2)]
	private ITagTask WaitDisableHideActorTagRemoveTask;

	// Token: 0x0400DB12 RID: 56082
	private ETeamGroupType? LastGroupType;

	// Token: 0x0400DB13 RID: 56083
	[Nullable(2)]
	public static EntityHandle VisionControlHandle;

	// Token: 0x0400DB14 RID: 56084
	private int CueHandle;

	// Token: 0x0400DB15 RID: 56085
	private bool IsEnding;
}
