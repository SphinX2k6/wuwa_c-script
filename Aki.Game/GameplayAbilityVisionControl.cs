using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.Vision;

// Token: 0x020031A8 RID: 12712
public class GameplayAbilityVisionControl : GameplayAbilityVisionBase, IStaticVariableResetter
{
	// Token: 0x0601B654 RID: 112212 RVA: 0x0077D3A6 File Offset: 0x0077B5A6
	static GameplayAbilityVisionControl()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameplayAbilityVisionControl.CreateStaticDefaultValue), new Action(GameplayAbilityVisionControl.ResetStaticDefaultValue));
	}

	// Token: 0x0601B655 RID: 112213 RVA: 0x0077D3C5 File Offset: 0x0077B5C5
	[NullableContext(1)]
	public GameplayAbilityVisionControl(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x0601B656 RID: 112214 RVA: 0x0077D3D0 File Offset: 0x0077B5D0
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

	// Token: 0x0601B657 RID: 112215 RVA: 0x0077D4B8 File Offset: 0x0077B6B8
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

	// Token: 0x0601B658 RID: 112216 RVA: 0x0077D57C File Offset: 0x0077B77C
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

	// Token: 0x0601B659 RID: 112217 RVA: 0x0077D618 File Offset: 0x0077B818
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

	// Token: 0x0601B65A RID: 112218 RVA: 0x0077D660 File Offset: 0x0077B860
	private void SetSummonerVisionControlCreatureDataId(long? id)
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity(base.CreatureDataComponent.GetSummonerId());
		if (entity != null)
		{
			entity.Entity.GetComponent<CreatureDataComponent>().VisionControlCreatureDataId = id;
		}
	}

	// Token: 0x0601B65B RID: 112219 RVA: 0x0077D698 File Offset: 0x0077B898
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

	// Token: 0x0601B65C RID: 112220 RVA: 0x0077D708 File Offset: 0x0077B908
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

	// Token: 0x0601B65D RID: 112221 RVA: 0x0077D750 File Offset: 0x0077B950
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

	// Token: 0x0601B65E RID: 112222 RVA: 0x0077D79C File Offset: 0x0077B99C
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

	// Token: 0x0601B65F RID: 112223 RVA: 0x0077D870 File Offset: 0x0077BA70
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

	// Token: 0x0601B660 RID: 112224 RVA: 0x0077D929 File Offset: 0x0077BB29
	public static void CreateStaticDefaultValue()
	{
		GameplayAbilityVisionControl.VisionControlHandle = null;
	}

	// Token: 0x0601B661 RID: 112225 RVA: 0x0077D931 File Offset: 0x0077BB31
	public static void ResetStaticDefaultValue()
	{
		GameplayAbilityVisionControl.VisionControlHandle = null;
	}

	// Token: 0x0400D68B RID: 54923
	[Nullable(2)]
	private ITagTask WaitDisableHideActorTagRemoveTask;

	// Token: 0x0400D68C RID: 54924
	private ETeamGroupType? LastGroupType;

	// Token: 0x0400D68D RID: 54925
	[Nullable(2)]
	public static EntityHandle VisionControlHandle;

	// Token: 0x0400D68E RID: 54926
	private int CueHandle;

	// Token: 0x0400D68F RID: 54927
	private bool IsEnding;
}
