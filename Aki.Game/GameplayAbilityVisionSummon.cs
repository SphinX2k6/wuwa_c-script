using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020031AE RID: 12718
[NullableContext(2)]
[Nullable(0)]
public class GameplayAbilityVisionSummon : GameplayAbilityVisionBase
{
	// Token: 0x0601B6B0 RID: 112304 RVA: 0x0077FD75 File Offset: 0x0077DF75
	[NullableContext(1)]
	public GameplayAbilityVisionSummon(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x0601B6B1 RID: 112305 RVA: 0x0077FD80 File Offset: 0x0077DF80
	protected override void OnCreate()
	{
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.BulletDestroy, new Action<BulletInfo>(this.OnBulletDestroy));
		EventSystem.Instance.Add(EEventName.CharStopAllSkills, new Action<int, string>(this.OnStopSkills));
		EventSystem.Instance.Add(EEventName.CharStopGroup1Skill, new Action<int, string>(this.OnStopSkills));
	}

	// Token: 0x0601B6B2 RID: 112306 RVA: 0x0077FDE4 File Offset: 0x0077DFE4
	protected override void OnDestroy()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.BulletDestroy, new Action<BulletInfo>(this.OnBulletDestroy));
		EventSystem.Instance.Remove(EEventName.CharStopAllSkills, new Action<int, string>(this.OnStopSkills));
		EventSystem.Instance.Remove(EEventName.CharStopGroup1Skill, new Action<int, string>(this.OnStopSkills));
		this.EndAllTask();
	}

	// Token: 0x0601B6B3 RID: 112307 RVA: 0x0077FE4C File Offset: 0x0077E04C
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
				if (skill.SkillGenres.Contains(ESkillGenre.战斗幻象技9))
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

	// Token: 0x0601B6B4 RID: 112308 RVA: 0x0077FF88 File Offset: 0x0077E188
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

	// Token: 0x0601B6B5 RID: 112309 RVA: 0x00780092 File Offset: 0x0077E292
	private bool IsAirSkill()
	{
		return this.VisionData.空中能否释放 && base.GameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]);
	}

	// Token: 0x0601B6B6 RID: 112310 RVA: 0x007800BD File Offset: 0x0077E2BD
	[NullableContext(1)]
	private void OnBulletDestroy(BulletInfo bulletInfo)
	{
		if (bulletInfo.BulletEntityId == this.SummonBulletId)
		{
			this.SummonBegin(bulletInfo.MoveInfo.LastFramePosition.ToUeVector(false));
		}
	}

	// Token: 0x0601B6B7 RID: 112311 RVA: 0x007800E4 File Offset: 0x0077E2E4
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

	// Token: 0x0601B6B8 RID: 112312 RVA: 0x00780273 File Offset: 0x0077E473
	private void SummonEnd()
	{
		this.EndAllTask();
		this.PlayEndEffect();
	}

	// Token: 0x0601B6B9 RID: 112313 RVA: 0x00780281 File Offset: 0x0077E481
	private void EndAllTask()
	{
		if (this.WaitSummonTagRemoveTask != null)
		{
			this.WaitSummonTagRemoveTask.EndTask();
			this.WaitSummonTagRemoveTask = null;
		}
	}

	// Token: 0x0601B6BA RID: 112314 RVA: 0x007802A0 File Offset: 0x0077E4A0
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

	// Token: 0x0601B6BB RID: 112315 RVA: 0x00780370 File Offset: 0x0077E570
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

	// Token: 0x0601B6BC RID: 112316 RVA: 0x0078040C File Offset: 0x0077E60C
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

	// Token: 0x0601B6BD RID: 112317 RVA: 0x00780474 File Offset: 0x0077E674
	protected void SetVisionEnable(bool enable)
	{
		CreatureController.Instance.SetEntityEnable(this.VisionEntity.Entity, enable, "GameplayAbilityVisionSummon.SetVisionEnable", true);
		EventSystem.Instance.Emit<bool>(EEventName.OnPhantomEnableStateChange, enable);
	}

	// Token: 0x0400D6D0 RID: 54992
	private EntityHandle VisionEntity;

	// Token: 0x0400D6D1 RID: 54993
	private SVisionData VisionData;

	// Token: 0x0400D6D2 RID: 54994
	private int SummonBulletId;

	// Token: 0x0400D6D3 RID: 54995
	private CharacterActorComponent VisionActorComponent;

	// Token: 0x0400D6D4 RID: 54996
	private CharacterSkillComponent VisionSkillComponent;

	// Token: 0x0400D6D5 RID: 54997
	private BaseTagComponent VisionGameplayTagComponent;

	// Token: 0x0400D6D6 RID: 54998
	private CharacterBuffComponent VisionBuffComponent;

	// Token: 0x0400D6D7 RID: 54999
	private CharacterGameplayCueComponent VisionCueComponent;

	// Token: 0x0400D6D8 RID: 55000
	private ITagTask WaitSummonTagRemoveTask;

	// Token: 0x0400D6D9 RID: 55001
	private int CueHandle;

	// Token: 0x0400D6DA RID: 55002
	private bool IsActivating;
}
