using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200271D RID: 10013
[NullableContext(2)]
[Nullable(0)]
public class GameplayAbilityVisionSummon : GameplayAbilityVisionBase
{
	// Token: 0x060191E3 RID: 102883 RVA: 0x007A80B9 File Offset: 0x007A62B9
	[NullableContext(1)]
	public GameplayAbilityVisionSummon(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x060191E4 RID: 102884 RVA: 0x007A80C4 File Offset: 0x007A62C4
	protected override void OnCreate()
	{
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.BulletDestroy, new Action<BulletInfo>(this.OnBulletDestroy));
		EventSystem.Instance.Add(EEventName.CharStopAllSkills, new Action<int, string>(this.OnStopSkills));
		EventSystem.Instance.Add(EEventName.CharStopGroup1Skill, new Action<int, string>(this.OnStopSkills));
	}

	// Token: 0x060191E5 RID: 102885 RVA: 0x007A8128 File Offset: 0x007A6328
	protected override void OnDestroy()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.BulletDestroy, new Action<BulletInfo>(this.OnBulletDestroy));
		EventSystem.Instance.Remove(EEventName.CharStopAllSkills, new Action<int, string>(this.OnStopSkills));
		EventSystem.Instance.Remove(EEventName.CharStopGroup1Skill, new Action<int, string>(this.OnStopSkills));
		this.EndAllTask();
	}

	// Token: 0x060191E6 RID: 102886 RVA: 0x007A8190 File Offset: 0x007A6390
	protected override bool OnActivateAbility()
	{
		if (!this.PreSummon())
		{
			return false;
		}
		if (!this.IsAirSkill())
		{
			base.BuffComponent.AddBuff(1900000014L, new AddBuffParam
			{
				InstigatorId = base.BuffComponent.CreatureDataId,
				Reason = "幻象召唤时触发子弹、镜头和特效"
			});
		}
		long? contextId = null;
		CharacterSkillComponent component = base.Entity.GetComponent<CharacterSkillComponent>();
		if (component != null && component.Valid)
		{
			foreach (Skill skill in component.GetAllActivatedSkill())
			{
				bool flag = false;
				using (IEnumerator<ESkillGenre> enumerator2 = skill.SkillGenres.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == ESkillGenre.战斗幻象技9)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					contextId = skill.CombatMessageId;
					break;
				}
			}
		}
		for (int i = 0; i < this.VisionData.葫芦轨迹子弹列表.Num(); i++)
		{
			string bulletRowName = this.VisionData.葫芦轨迹子弹列表.Get(i).ToString();
			BulletEntity bulletEntity = BulletController.Instance.CreateBulletCustomTarget(base.Entity, bulletRowName, new FTransformDouble?(base.ActorComponent.ActorTransform), new BulletController.BulletCreateParams(), contextId, EBulletCreateSource.Others);
			if (bulletEntity != null)
			{
				this.SummonBulletId = bulletEntity.Id;
				break;
			}
		}
		return true;
	}

	// Token: 0x060191E7 RID: 102887 RVA: 0x007A8308 File Offset: 0x007A6508
	private bool PreSummon()
	{
		this.VisionEntity = PhantomUtil.GetSummonedEntity(this.VisionComponent.Entity, ESummonType.ConcomitantVision, 1);
		EntityHandle visionEntity = this.VisionEntity;
		if (visionEntity == null || !visionEntity.Valid || !this.VisionEntity.IsInit || this.VisionEntity.Entity == null)
		{
			return false;
		}
		if (this.VisionEntity.Entity.Active)
		{
			return false;
		}
		this.VisionData = PhantomUtil.GetVisionData(this.VisionComponent.GetVisionId(null));
		if (this.VisionData == null)
		{
			return false;
		}
		this.VisionActorComponent = this.VisionEntity.Entity.GetComponent<CharacterActorComponent>();
		this.VisionSkillComponent = this.VisionEntity.Entity.GetComponent<CharacterSkillComponent>();
		this.VisionGameplayTagComponent = this.VisionEntity.Entity.GetComponent<BaseTagComponent>();
		this.VisionBuffComponent = this.VisionEntity.Entity.GetComponent<CharacterBuffComponent>();
		this.VisionCueComponent = this.VisionEntity.Entity.GetComponent<CharacterGameplayCueComponent>();
		return true;
	}

	// Token: 0x060191E8 RID: 102888 RVA: 0x007A8412 File Offset: 0x007A6612
	private bool IsAirSkill()
	{
		return this.VisionData.空中能否释放 && base.GameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]);
	}

	// Token: 0x060191E9 RID: 102889 RVA: 0x007A843D File Offset: 0x007A663D
	[NullableContext(1)]
	private void OnBulletDestroy(BulletInfo bulletInfo)
	{
		if (bulletInfo.BulletEntityId == this.SummonBulletId)
		{
			this.SummonBegin(bulletInfo.MoveInfo.LastFramePosition.ToUeVector(false));
		}
	}

	// Token: 0x060191EA RID: 102890 RVA: 0x007A8464 File Offset: 0x007A6664
	private void SummonBegin(FVectorDouble location)
	{
		Vector commonTempVector = MathUtils.Instance.CommonTempVector;
		base.MoveComponent.GravityUp.Multiply((double)this.VisionActorComponent.ScaledHalfHeight, commonTempVector);
		BaseActorComponent visionActorComponent = this.VisionActorComponent;
		FVectorDouble fvectorDouble = commonTempVector.ToUeVector(false);
		visionActorComponent.SetActorLocationAndRotation(location + fvectorDouble, base.ActorComponent.ActorRotation, "召唤幻象生成位置", false, null);
		this.IsActivating = true;
		this.SetVisionEnable(true);
		base.GameplayTagComponent.AddTag(new int?(GameplayAbilityVisionMisc.summonTag));
		if (this.WaitSummonTagRemoveTask == null)
		{
			this.WaitSummonTagRemoveTask = base.GameplayTagComponent.ListenForTagAddOrRemove(new int?(GameplayAbilityVisionMisc.summonTag), delegate(int tagId, bool tagExist)
			{
				if (!tagExist)
				{
					Log.Instance.Info(ELogModule.Battle, ELogAuthor.HXY, "召唤幻象正常结束", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.SummonEnd();
				}
			}, null);
		}
		this.VisionGameplayTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["幻象.Common.现身中"]));
		this.VisionBuffComponent.AddBuff(1900000015L, new AddBuffParam
		{
			InstigatorId = this.VisionBuffComponent.CreatureDataId,
			Reason = "召唤系幻象的出生特效"
		});
		this.VisionSkillComponent.SetSkillAcceptInput(true);
		int 技能ID = this.VisionData.技能ID;
		if (技能ID > 0)
		{
			BaseSkillComponent visionSkillComponent = this.VisionSkillComponent;
			int skillId = 技能ID;
			SkillParam skillParam = new SkillParam();
			EntityHandle skillTarget = base.SkillComponent.SkillTarget;
			skillParam.Target = ((skillTarget != null) ? skillTarget.Entity : null);
			skillParam.SocketName = base.SkillComponent.SkillTargetSocket;
			skillParam.Reason = "GameplayAbilityVisionSummon.BeginSkill";
			visionSkillComponent.BeginSkill(skillId, skillParam);
		}
		RoleAudioController.Instance.PlayRoleAudio(base.Entity, ERoleAudioType.VisionSummon, null);
	}

	// Token: 0x060191EB RID: 102891 RVA: 0x007A85F3 File Offset: 0x007A67F3
	private void SummonEnd()
	{
		this.EndAllTask();
		this.PlayEndEffect();
	}

	// Token: 0x060191EC RID: 102892 RVA: 0x007A8601 File Offset: 0x007A6801
	private void EndAllTask()
	{
		if (this.WaitSummonTagRemoveTask != null)
		{
			this.WaitSummonTagRemoveTask.EndTask();
			this.WaitSummonTagRemoveTask = null;
		}
	}

	// Token: 0x060191ED RID: 102893 RVA: 0x007A8620 File Offset: 0x007A6820
	private void PlayEndEffect()
	{
		TimerHandle capturedVisionHiddenTimer = null;
		CharacterGameplayCueComponent visionCueComponent = this.VisionCueComponent;
		if (visionCueComponent != null)
		{
			visionCueComponent.AddCue(19000000162L, new GameplayCueParam?(new GameplayCueParam
			{
				Sync = new bool?(true),
				Instant = true
			}));
		}
		this.CueHandle = this.VisionCueComponent.AddCue(19000000181L, new GameplayCueParam?(new GameplayCueParam
		{
			EndCallback = delegate()
			{
				if (capturedVisionHiddenTimer != null && TimerSystem.Instance.Has(capturedVisionHiddenTimer))
				{
					TimerSystem.Instance.Remove(capturedVisionHiddenTimer);
					capturedVisionHiddenTimer = null;
					this.VisionDisable();
				}
			},
			Sync = new bool?(true)
		}));
		capturedVisionHiddenTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.HXY, "幻象消失材质没有正常结束，被保底", default(ReadOnlySpan<ValueTuple<string, object>>));
			capturedVisionHiddenTimer = null;
			this.VisionDisable();
		}, 1000f, null, null, true, 1f);
	}

	// Token: 0x060191EE RID: 102894 RVA: 0x007A86F0 File Offset: 0x007A68F0
	private void VisionDisable()
	{
		EntityHandle visionEntity = this.VisionEntity;
		if (visionEntity != null && visionEntity.Valid)
		{
			BulletController.Instance.CreateBulletCustomTarget(this.VisionEntity.Entity, "210000004", null, null, null, EBulletCreateSource.Others);
			this.IsActivating = false;
			this.SetVisionEnable(false);
			CharacterGameplayCueComponent visionCueComponent = this.VisionCueComponent;
			if (visionCueComponent != null)
			{
				visionCueComponent.RemoveCueByHandle((long)this.CueHandle);
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.EndVisionSkill, this.VisionComponent.GetVisionId(null));
	}

	// Token: 0x060191EF RID: 102895 RVA: 0x007A878C File Offset: 0x007A698C
	[NullableContext(1)]
	private void OnStopSkills(int entityId, string reason)
	{
		if (this.IsActivating)
		{
			EntityHandle visionEntity = this.VisionEntity;
			if (visionEntity != null && visionEntity.Valid && entityId == this.VisionEntity.Id)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.HXY;
				string message = "技能被全部打断，结束召唤幻象技能";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.SummonEnd();
				return;
			}
		}
	}

	// Token: 0x060191F0 RID: 102896 RVA: 0x007A87F4 File Offset: 0x007A69F4
	protected void SetVisionEnable(bool enable)
	{
		CreatureController.Instance.SetEntityEnable(this.VisionEntity.Entity, enable, "GameplayAbilityVisionSummon.SetVisionEnable", true);
		EventSystem.Instance.Emit<bool>(EEventName.OnPhantomEnableStateChange, enable);
	}

	// Token: 0x0400DB57 RID: 56151
	private EntityHandle VisionEntity;

	// Token: 0x0400DB58 RID: 56152
	private SVisionData VisionData;

	// Token: 0x0400DB59 RID: 56153
	private int SummonBulletId;

	// Token: 0x0400DB5A RID: 56154
	private CharacterActorComponent VisionActorComponent;

	// Token: 0x0400DB5B RID: 56155
	private CharacterSkillComponent VisionSkillComponent;

	// Token: 0x0400DB5C RID: 56156
	private BaseTagComponent VisionGameplayTagComponent;

	// Token: 0x0400DB5D RID: 56157
	private CharacterBuffComponent VisionBuffComponent;

	// Token: 0x0400DB5E RID: 56158
	private CharacterGameplayCueComponent VisionCueComponent;

	// Token: 0x0400DB5F RID: 56159
	private ITagTask WaitSummonTagRemoveTask;

	// Token: 0x0400DB60 RID: 56160
	private int CueHandle;

	// Token: 0x0400DB61 RID: 56161
	private bool IsActivating;
}
