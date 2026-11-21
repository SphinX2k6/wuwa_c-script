using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002344 RID: 9028
[NullableContext(2)]
[Nullable(0)]
public class SkillBehaviorBatchBulletTask
{
	// Token: 0x0601636F RID: 90991 RVA: 0x00679D62 File Offset: 0x00677F62
	public float GetInterval()
	{
		return this.Interval;
	}

	// Token: 0x06016370 RID: 90992 RVA: 0x00679D6A File Offset: 0x00677F6A
	public BaseSkillComponent GetSkillComponent()
	{
		return this.SkillComponent;
	}

	// Token: 0x06016371 RID: 90993 RVA: 0x00679D72 File Offset: 0x00677F72
	public TsBaseCharacter GetOwner()
	{
		return this.Owner;
	}

	// Token: 0x06016372 RID: 90994 RVA: 0x00679D7A File Offset: 0x00677F7A
	public int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x06016373 RID: 90995 RVA: 0x00679D84 File Offset: 0x00677F84
	[NullableContext(1)]
	public static SkillBehaviorBatchBulletTask Create(Entity owner, TSoftObjectPtr<UPrimaryDataAsset> configSoftPtr, int skillId)
	{
		DAC_BatchCreateBullet_C dac_BatchCreateBullet_C = ResourceSystem.Instance.Load<DAC_BatchCreateBullet_C>(configSoftPtr.ToAssetPathName(), "js_undefined");
		SSkillBehaviorBatchBullet @base = dac_BatchCreateBullet_C.Base;
		SkillBehaviorBatchBulletTask skillBehaviorBatchBulletTask = new SkillBehaviorBatchBulletTask();
		skillBehaviorBatchBulletTask.SkillId = skillId;
		SkillBehaviorBatchBulletTask skillBehaviorBatchBulletTask2 = skillBehaviorBatchBulletTask;
		CharacterActorComponent component = owner.GetComponent<CharacterActorComponent>();
		skillBehaviorBatchBulletTask2.Owner = ((component != null) ? component.Actor : null);
		if (GameplayTagUtils.IsValidTag(new FGameplayTag?(@base.ContinueWithTag)))
		{
			skillBehaviorBatchBulletTask.TagComponent = owner.GetComponent<BaseTagComponent>();
		}
		skillBehaviorBatchBulletTask.SkillComponent = owner.GetComponent<BaseSkillComponent>();
		skillBehaviorBatchBulletTask.StopOnSkillEnd = @base.StopOnSkillEnd;
		CharacterCustomValueComponent component2 = owner.GetComponent<CharacterCustomValueComponent>();
		skillBehaviorBatchBulletTask.ContinueWithTagId = @base.ContinueWithTag.TagId();
		skillBehaviorBatchBulletTask.Id = new string[@base.Id.Num()];
		for (int i = 0; i < @base.Id.Num(); i++)
		{
			skillBehaviorBatchBulletTask.Id[i] = @base.Id.Get(i);
		}
		skillBehaviorBatchBulletTask.Interval = @base.Interval;
		skillBehaviorBatchBulletTask.Number = @base.Number;
		if (dac_BatchCreateBullet_C.BeginPos == EBatchBulletPosition.DotMatrix)
		{
			DAC_BatchCreateBulletDotMatrix_C dac_BatchCreateBulletDotMatrix_C = dac_BatchCreateBullet_C as DAC_BatchCreateBulletDotMatrix_C;
			skillBehaviorBatchBulletTask.Shape = BatchBulletPositionDotMatrix.Create(component2, dac_BatchCreateBulletDotMatrix_C.Shape);
		}
		else if (dac_BatchCreateBullet_C.BeginPos == EBatchBulletPosition.Circle)
		{
			DAC_BatchCreateBulletCircle_C dac_BatchCreateBulletCircle_C = dac_BatchCreateBullet_C as DAC_BatchCreateBulletCircle_C;
			skillBehaviorBatchBulletTask.Shape = BatchBulletPositionCircle.Create(component2, dac_BatchCreateBulletCircle_C.Shape);
			BatchBulletPositionCircle batchBulletPositionCircle = skillBehaviorBatchBulletTask.Shape as BatchBulletPositionCircle;
			if (Math.Abs(batchBulletPositionCircle.AngleInterval) < 1E-08)
			{
				batchBulletPositionCircle.AngleInterval = (double)(360 / skillBehaviorBatchBulletTask.Number);
			}
		}
		else if (dac_BatchCreateBullet_C.BeginPos == EBatchBulletPosition.Spline)
		{
			DAC_BatchCreateBulletSpline_C dac_BatchCreateBulletSpline_C = dac_BatchCreateBullet_C as DAC_BatchCreateBulletSpline_C;
			skillBehaviorBatchBulletTask.Shape = BatchBulletPositionSpline.Create(component2, dac_BatchCreateBulletSpline_C.Shape, skillBehaviorBatchBulletTask);
		}
		skillBehaviorBatchBulletTask.StartMoveAfterAllCreate = (@base.StartMoving == EBatchBulletMoveStartMode.所有生成才移动);
		return skillBehaviorBatchBulletTask;
	}

	// Token: 0x06016374 RID: 90996 RVA: 0x00679F64 File Offset: 0x00678164
	public UniTask StartAsync()
	{
		SkillBehaviorBatchBulletTask.<StartAsync>d__19 <StartAsync>d__;
		<StartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartAsync>d__.<>4__this = this;
		<StartAsync>d__.<>1__state = -1;
		<StartAsync>d__.<>t__builder.Start<SkillBehaviorBatchBulletTask.<StartAsync>d__19>(ref <StartAsync>d__);
		return <StartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016375 RID: 90997 RVA: 0x00679FA8 File Offset: 0x006781A8
	private void Start()
	{
		bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
		if (this.Shape.GetDelay() > 0f && !this.IsCreateContinue())
		{
			this.Shape.OnBreak();
			return;
		}
		this.BulletEntityId = new List<int>();
		if (this.Interval > 0f)
		{
			this.Action(0f);
			this.TimerHandle = TimerSystem.Instance.Loop(new TTimerAction(this.Action), this.Interval * 1000f, this.Number - 1, 1f, null, "[批量生成子弹]", true);
			return;
		}
		int num = 0;
		while (num < this.Number && (this.TagComponent == null || this.TagComponent.HasTag(this.ContinueWithTagId)) && (this.SkillId == 0 || !this.StopOnSkillEnd || (this.SkillComponent.CurrentSkill != null && this.SkillComponent.CurrentSkill.SkillId == this.SkillId)))
		{
			int num2 = this.CreateBullet(num);
			if (num2 != 0)
			{
				this.BulletEntityId.Add(num2);
			}
			num++;
		}
	}

	// Token: 0x06016376 RID: 90998 RVA: 0x0067A0C0 File Offset: 0x006782C0
	private void Action(float delta = 0f)
	{
		if (this.IsCreateContinue())
		{
			int num = this.CreateBullet(this.Counter);
			if (num != 0)
			{
				this.BulletEntityId.Add(num);
				if (this.StartMoveAfterAllCreate)
				{
					BulletController.Instance.SetBulletSpeedRatio(num, 0f);
					BulletController.Instance.SetBulletLiveRatio(num, 0f);
				}
			}
			else
			{
				Log.Instance.Error(ELogModule.Bullet, ELogAuthor.HCW, "批量生成子弹失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.Counter++;
			if (this.StartMoveAfterAllCreate && this.Counter >= this.Number)
			{
				for (int i = 0; i < this.Number; i++)
				{
					int id = this.BulletEntityId[i];
					BulletController.Instance.SetBulletSpeedRatio(id, 1f);
					BulletController.Instance.SetBulletLiveRatio(id, 1f);
				}
				this.Shape.OnEnd();
				return;
			}
		}
		else
		{
			TimerHandle timerHandle = this.TimerHandle;
			if (timerHandle == null || !timerHandle.Remove())
			{
				Log.Instance.Error(ELogModule.Bullet, ELogAuthor.HCW, "停止批量生成子弹失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.Shape.OnBreak();
			if (this.Shape.IsDestroyOnEnd())
			{
				for (int j = 0; j < this.Number; j++)
				{
					BulletController.Instance.DestroyBullet(this.BulletEntityId[j], this.Shape.IsSummonChildBullet(), EBulletDestroyReason.Normal, false);
				}
				return;
			}
			if (this.StartMoveAfterAllCreate)
			{
				for (int k = 0; k < this.Number; k++)
				{
					BulletController.Instance.SetBulletSpeedRatio(this.BulletEntityId[k], 1f);
				}
			}
		}
	}

	// Token: 0x06016377 RID: 90999 RVA: 0x0067A26C File Offset: 0x0067846C
	private int CreateBullet(int index)
	{
		string bulletRowName = this.Id[index % this.Id.Length];
		Transform transform = this.Shape.ToTransform(index);
		if (transform == null)
		{
			return 0;
		}
		BaseSkillComponent skillComponent = this.SkillComponent;
		Skill skill = (skillComponent != null) ? skillComponent.GetSkill(this.SkillId) : null;
		long? preContextId = (skill != null && skill.SkillBehaviorAnimNotifyMessageId != null) ? ((skill != null) ? skill.SkillBehaviorAnimNotifyMessageId : null) : ((skill != null) ? skill.CombatMessageId : null);
		Vector vector = this.Shape.ToTargetLocation(transform);
		return BulletUtil.CreateBulletFromAN(this.Owner, bulletRowName, new FTransformDouble?(transform.ToUeTransform()), this.SkillId, false, preContextId, (vector != null) ? new FVectorDouble?(vector.ToUeVector(false)) : null, null, null);
	}

	// Token: 0x06016378 RID: 91000 RVA: 0x0067A354 File Offset: 0x00678554
	private bool IsCreateContinue()
	{
		return (this.TagComponent == null || this.TagComponent.HasTag(this.ContinueWithTagId)) && (!this.StopOnSkillEnd || (this.SkillComponent.CurrentSkill != null && this.SkillComponent.CurrentSkill.SkillId == this.SkillId));
	}

	// Token: 0x0400BB64 RID: 47972
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] Id;

	// Token: 0x0400BB65 RID: 47973
	private float Interval;

	// Token: 0x0400BB66 RID: 47974
	private int Number;

	// Token: 0x0400BB67 RID: 47975
	private IBatchBulletPositionShape Shape;

	// Token: 0x0400BB68 RID: 47976
	private bool StartMoveAfterAllCreate;

	// Token: 0x0400BB69 RID: 47977
	private int ContinueWithTagId;

	// Token: 0x0400BB6A RID: 47978
	private BaseTagComponent TagComponent;

	// Token: 0x0400BB6B RID: 47979
	private BaseSkillComponent SkillComponent;

	// Token: 0x0400BB6C RID: 47980
	private TsBaseCharacter Owner;

	// Token: 0x0400BB6D RID: 47981
	private int SkillId;

	// Token: 0x0400BB6E RID: 47982
	private bool StopOnSkillEnd;

	// Token: 0x0400BB6F RID: 47983
	private int Counter;

	// Token: 0x0400BB70 RID: 47984
	private List<int> BulletEntityId;

	// Token: 0x0400BB71 RID: 47985
	private TimerHandle TimerHandle;
}
