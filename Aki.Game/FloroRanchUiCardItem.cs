using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001068 RID: 4200
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUiCardItem : FloroRanchUiItemBase
{
	// Token: 0x0600A6E4 RID: 42724 RVA: 0x00312BB0 File Offset: 0x00310DB0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A6E5 RID: 42725 RVA: 0x00312CDF File Offset: 0x00310EDF
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x0600A6E6 RID: 42726 RVA: 0x00312CFC File Offset: 0x00310EFC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchUiCardItem.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchUiCardItem.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6E7 RID: 42727 RVA: 0x00312D40 File Offset: 0x00310F40
	public void FollowPosition(FTransform transform)
	{
		FVector location = transform.GetLocation();
		location.Z -= 40f;
		this.OriginalPosition = location;
		base.GetRootItem().SetUIWorldLocation(this.OriginalPosition);
	}

	// Token: 0x0600A6E8 RID: 42728 RVA: 0x00312D80 File Offset: 0x00310F80
	public override UniTask RefreshItem()
	{
		FloroRanchUiCardItem.<RefreshItem>d__21 <RefreshItem>d__;
		<RefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItem>d__.<>4__this = this;
		<RefreshItem>d__.<>1__state = -1;
		<RefreshItem>d__.<>t__builder.Start<FloroRanchUiCardItem.<RefreshItem>d__21>(ref <RefreshItem>d__);
		return <RefreshItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6E9 RID: 42729 RVA: 0x00312DC4 File Offset: 0x00310FC4
	public void RefreshEvolveItem()
	{
		FloroRanchCardDataComponent floroRanchCardDataComponent = this.Entity.CheckGetComponent<FloroRanchCardDataComponent>();
		this.EvolveItem.Refresh(floroRanchCardDataComponent.EvolveData);
		this.EvolveItem.GetRootItem().SetAnchorOffsetY((float)floroRanchCardDataComponent.CardData.GetEvolveItemOffsetY());
	}

	// Token: 0x0600A6EA RID: 42730 RVA: 0x00312E0C File Offset: 0x0031100C
	public void RefreshRemainTimeItem()
	{
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = this.Entity.CheckGetComponent<FloroRanchEntityDataComponent>();
		this.RemainTimeItem.Refresh(floroRanchEntityDataComponent.GetMinRemindDayBuff());
	}

	// Token: 0x0600A6EB RID: 42731 RVA: 0x00312E38 File Offset: 0x00311038
	public void RefreshSpecialEffect()
	{
		EFloroRanchSpecialEffectType cardSpecialEffect = this.Entity.CheckGetComponent<FloroRanchCardDataComponent>().CardData.GetCardSpecialEffect();
		base.GetUiNiagara(4).SetUIActive(cardSpecialEffect == EFloroRanchSpecialEffectType.Blue);
		base.GetUiNiagara(5).SetUIActive(cardSpecialEffect == EFloroRanchSpecialEffectType.Red);
	}

	// Token: 0x0600A6EC RID: 42732 RVA: 0x00312E7B File Offset: 0x0031107B
	public void RefreshDebugInfo()
	{
	}

	// Token: 0x0600A6ED RID: 42733 RVA: 0x00312E80 File Offset: 0x00311080
	public override UniTask PlayShowAnim()
	{
		FloroRanchUiCardItem.<PlayShowAnim>d__26 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayShowAnim>d__26>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6EE RID: 42734 RVA: 0x00312EC4 File Offset: 0x003110C4
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiCardItem.<PlayHideAnim>d__27 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayHideAnim>d__27>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6EF RID: 42735 RVA: 0x00312F08 File Offset: 0x00311108
	public override void ShowCoinNiagara(long count)
	{
		UUINiagara uiNiagara = base.GetUiNiagara(6);
		UUINiagara uiNiagara2 = base.GetUiNiagara(7);
		uiNiagara.SetUIActive(false);
		uiNiagara2.SetUIActive(false);
		if (count >= 1000L)
		{
			uiNiagara2.SetUIActive(true);
			return;
		}
		if (count >= 100L)
		{
			uiNiagara.SetUIActive(true);
		}
	}

	// Token: 0x0600A6F0 RID: 42736 RVA: 0x00312F54 File Offset: 0x00311154
	public override UniTask ShowUiItem()
	{
		FloroRanchUiCardItem.<ShowUiItem>d__29 <ShowUiItem>d__;
		<ShowUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowUiItem>d__.<>4__this = this;
		<ShowUiItem>d__.<>1__state = -1;
		<ShowUiItem>d__.<>t__builder.Start<FloroRanchUiCardItem.<ShowUiItem>d__29>(ref <ShowUiItem>d__);
		return <ShowUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6F1 RID: 42737 RVA: 0x00312F98 File Offset: 0x00311198
	public override UniTask HideUiItem()
	{
		FloroRanchUiCardItem.<HideUiItem>d__30 <HideUiItem>d__;
		<HideUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideUiItem>d__.<>4__this = this;
		<HideUiItem>d__.<>1__state = -1;
		<HideUiItem>d__.<>t__builder.Start<FloroRanchUiCardItem.<HideUiItem>d__30>(ref <HideUiItem>d__);
		return <HideUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6F2 RID: 42738 RVA: 0x00312FDB File Offset: 0x003111DB
	public override void Pause()
	{
		this.UiLevelSequence.PauseSequence();
		base.GetSpine(1).SetTimeScale(0f);
	}

	// Token: 0x0600A6F3 RID: 42739 RVA: 0x00312FF9 File Offset: 0x003111F9
	public override void Resume()
	{
		this.UiLevelSequence.ResumeSequence();
		base.GetSpine(1).SetTimeScale(1f);
	}

	// Token: 0x0600A6F4 RID: 42740 RVA: 0x00313018 File Offset: 0x00311218
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiCardItem.<PlayNormalAnim>d__33 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayNormalAnim>d__33>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6F5 RID: 42741 RVA: 0x0031305C File Offset: 0x0031125C
	public override UniTask MoveToItem(UUIItem targetItem)
	{
		FloroRanchUiCardItem.<MoveToItem>d__34 <MoveToItem>d__;
		<MoveToItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveToItem>d__.<>4__this = this;
		<MoveToItem>d__.targetItem = targetItem;
		<MoveToItem>d__.<>1__state = -1;
		<MoveToItem>d__.<>t__builder.Start<FloroRanchUiCardItem.<MoveToItem>d__34>(ref <MoveToItem>d__);
		return <MoveToItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6F6 RID: 42742 RVA: 0x003130A8 File Offset: 0x003112A8
	public override UniTask MoveToOriginalPosition()
	{
		FloroRanchUiCardItem.<MoveToOriginalPosition>d__35 <MoveToOriginalPosition>d__;
		<MoveToOriginalPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveToOriginalPosition>d__.<>4__this = this;
		<MoveToOriginalPosition>d__.<>1__state = -1;
		<MoveToOriginalPosition>d__.<>t__builder.Start<FloroRanchUiCardItem.<MoveToOriginalPosition>d__35>(ref <MoveToOriginalPosition>d__);
		return <MoveToOriginalPosition>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6F7 RID: 42743 RVA: 0x003130EC File Offset: 0x003112EC
	public override void MoveToOriginalPositionImmediate()
	{
		base.GetRootItem().SetUIWorldLocation(this.OriginalPosition);
		this.TargetRotator.Set(0f, 0f, 0f);
		UUIItem item = base.GetItem(0);
		FRotator frotator = this.TargetRotator.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x0600A6F8 RID: 42744 RVA: 0x0031313E File Offset: 0x0031133E
	public override FTransform? GetRewardPopTransform()
	{
		return new FTransform?(this.RootActor.GetTransform());
	}

	// Token: 0x0600A6F9 RID: 42745 RVA: 0x00313150 File Offset: 0x00311350
	public override UniTask PlayEatAnim()
	{
		FloroRanchUiCardItem.<PlayEatAnim>d__38 <PlayEatAnim>d__;
		<PlayEatAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayEatAnim>d__.<>4__this = this;
		<PlayEatAnim>d__.<>1__state = -1;
		<PlayEatAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayEatAnim>d__38>(ref <PlayEatAnim>d__);
		return <PlayEatAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6FA RID: 42746 RVA: 0x00313194 File Offset: 0x00311394
	public override UniTask PlayBeEatAnim()
	{
		FloroRanchUiCardItem.<PlayBeEatAnim>d__39 <PlayBeEatAnim>d__;
		<PlayBeEatAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayBeEatAnim>d__.<>4__this = this;
		<PlayBeEatAnim>d__.<>1__state = -1;
		<PlayBeEatAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayBeEatAnim>d__39>(ref <PlayBeEatAnim>d__);
		return <PlayBeEatAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6FB RID: 42747 RVA: 0x003131D8 File Offset: 0x003113D8
	public override UniTask PlaySacrificeAnim()
	{
		FloroRanchUiCardItem.<PlaySacrificeAnim>d__40 <PlaySacrificeAnim>d__;
		<PlaySacrificeAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySacrificeAnim>d__.<>4__this = this;
		<PlaySacrificeAnim>d__.<>1__state = -1;
		<PlaySacrificeAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlaySacrificeAnim>d__40>(ref <PlaySacrificeAnim>d__);
		return <PlaySacrificeAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6FC RID: 42748 RVA: 0x0031321C File Offset: 0x0031141C
	public override UniTask PlayFusionHideAnim()
	{
		FloroRanchUiCardItem.<PlayFusionHideAnim>d__41 <PlayFusionHideAnim>d__;
		<PlayFusionHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFusionHideAnim>d__.<>4__this = this;
		<PlayFusionHideAnim>d__.<>1__state = -1;
		<PlayFusionHideAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayFusionHideAnim>d__41>(ref <PlayFusionHideAnim>d__);
		return <PlayFusionHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6FD RID: 42749 RVA: 0x00313260 File Offset: 0x00311460
	public override UniTask PlayFusionShowAnim()
	{
		FloroRanchUiCardItem.<PlayFusionShowAnim>d__42 <PlayFusionShowAnim>d__;
		<PlayFusionShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFusionShowAnim>d__.<>4__this = this;
		<PlayFusionShowAnim>d__.<>1__state = -1;
		<PlayFusionShowAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayFusionShowAnim>d__42>(ref <PlayFusionShowAnim>d__);
		return <PlayFusionShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6FE RID: 42750 RVA: 0x003132A4 File Offset: 0x003114A4
	public override UniTask PlayEvolveUpAnim()
	{
		FloroRanchUiCardItem.<PlayEvolveUpAnim>d__43 <PlayEvolveUpAnim>d__;
		<PlayEvolveUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayEvolveUpAnim>d__.<>4__this = this;
		<PlayEvolveUpAnim>d__.<>1__state = -1;
		<PlayEvolveUpAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayEvolveUpAnim>d__43>(ref <PlayEvolveUpAnim>d__);
		return <PlayEvolveUpAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6FF RID: 42751 RVA: 0x003132E8 File Offset: 0x003114E8
	private Rotator GetSpineItemDirection(Vector currentLocation, Vector targetLocation)
	{
		this.TempRotator.Set(0f, 0f, 0f);
		EFloroRanchCardDirection cardDefaultDirection = this.Entity.CheckGetComponent<FloroRanchCardDataComponent>().CardData.GetCardDefaultDirection();
		if (cardDefaultDirection == EFloroRanchCardDirection.Center)
		{
			return this.TempRotator;
		}
		targetLocation.Subtraction(currentLocation, this.TempVector);
		EFloroRanchCardDirection efloroRanchCardDirection = (this.TempVector.X > 0.0) ? EFloroRanchCardDirection.Right : EFloroRanchCardDirection.Left;
		if (cardDefaultDirection == efloroRanchCardDirection)
		{
			return this.TempRotator;
		}
		this.TempRotator.Set(180f, 0f, 0f);
		return this.TempRotator;
	}

	// Token: 0x0600A700 RID: 42752 RVA: 0x00313384 File Offset: 0x00311584
	private void OnTick(float deltaTime)
	{
		if (FloroRanchGamePlayModel.Instance.IsSkip)
		{
			this.MoveToOriginalPositionImmediate();
			this.ClearTimerHandle();
			return;
		}
		this.TickTime += deltaTime;
		this.MoveDirection.Multiply((double)this.CardMoveCurve.GetFloatValue(this.TickTime / 500f), this.TempVector);
		this.StartPosition.Addition(this.TempVector, this.TempVector2);
		UUIItem rootItem = base.GetRootItem();
		FVector fvector = this.TempVector2.ToUeVectorOld();
		rootItem.SetUIWorldLocation(fvector);
		if (this.TickTime >= 500f)
		{
			UUIItem rootItem2 = base.GetRootItem();
			fvector = this.TargetPosition.ToUeVectorOld();
			rootItem2.SetUIWorldLocation(fvector);
			UUIItem item = base.GetItem(0);
			FRotator frotator = this.TargetRotator.ToUeRotator();
			item.SetUIRelativeRotation(frotator);
			this.ClearTimerHandle();
		}
	}

	// Token: 0x0600A701 RID: 42753 RVA: 0x00313459 File Offset: 0x00311659
	protected override void OnBeforeDestroy()
	{
		base.GetSpine(1).AnimationComplete.Remove(new Action<UTrackEntry>(this.OnSpineAnimationComplete));
		this.ClearTimerHandle();
	}

	// Token: 0x0600A702 RID: 42754 RVA: 0x00313480 File Offset: 0x00311680
	private void ClearTimerHandle()
	{
		if (FloroRanchGamePlayModel.Instance.FloroRanchTimerSystem.Has(this.TimerHandle))
		{
			FloroRanchGamePlayModel.Instance.FloroRanchTimerSystem.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		if (this.WaitPromise != null)
		{
			this.WaitPromise.SetResult(null);
			this.WaitPromise = null;
		}
	}

	// Token: 0x0600A703 RID: 42755 RVA: 0x003134DC File Offset: 0x003116DC
	public void BindMoveCurve(UCurveFloat curve)
	{
		this.CardMoveCurve = curve;
	}

	// Token: 0x0600A704 RID: 42756 RVA: 0x003134E5 File Offset: 0x003116E5
	[NullableContext(2)]
	private void OnSpineAnimationComplete(UTrackEntry entry)
	{
		if (entry == null)
		{
			return;
		}
		if (entry.getAnimationName() == "eat")
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(1);
			spine.SetAnimation(0, "idle", true);
			spine.SetTimeScale(1f);
		}
	}

	// Token: 0x0600A705 RID: 42757 RVA: 0x0031351C File Offset: 0x0031171C
	private void OnHideAnimationComplete(string sequenceName)
	{
		base.GetRootItem().SetUIWorldLocation(this.OriginalPosition);
		base.GetRootItem().SetUIActive(false);
		base.GetSpine(1).ClearTracks();
	}

	// Token: 0x0400616E RID: 24942
	private FloroRanchEvolveItem EvolveItem;

	// Token: 0x0400616F RID: 24943
	private FloroRanchBuffRemindDayItem RemainTimeItem;

	// Token: 0x04006170 RID: 24944
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x04006171 RID: 24945
	private FVector OriginalPosition;

	// Token: 0x04006172 RID: 24946
	private UCurveFloat CardMoveCurve;

	// Token: 0x04006173 RID: 24947
	private TimerHandle TimerHandle;

	// Token: 0x04006174 RID: 24948
	private CustomPromise<object> WaitPromise;

	// Token: 0x04006175 RID: 24949
	private FloroRanchEntityDebugInfoItem DebugInfoItem;

	// Token: 0x04006176 RID: 24950
	private readonly Vector MoveDirection = Vector.Create();

	// Token: 0x04006177 RID: 24951
	private readonly Vector StartPosition = Vector.Create();

	// Token: 0x04006178 RID: 24952
	private Vector TargetPosition = Vector.Create();

	// Token: 0x04006179 RID: 24953
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400617A RID: 24954
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x0400617B RID: 24955
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0400617C RID: 24956
	private readonly Rotator TargetRotator = Rotator.Create();

	// Token: 0x0400617D RID: 24957
	private float TickTime;

	// Token: 0x020072DA RID: 29402
	[NullableContext(0)]
	private class EItemComponentDefine
	{
		// Token: 0x04025670 RID: 153200
		public const int SpineItem = 0;

		// Token: 0x04025671 RID: 153201
		public const int Spine = 1;

		// Token: 0x04025672 RID: 153202
		public const int EvolveItem = 2;

		// Token: 0x04025673 RID: 153203
		public const int RemainTimeItem = 3;

		// Token: 0x04025674 RID: 153204
		public const int NiagaraBlue = 4;

		// Token: 0x04025675 RID: 153205
		public const int NiagaraRed = 5;

		// Token: 0x04025676 RID: 153206
		public const int NiagaraReward = 6;

		// Token: 0x04025677 RID: 153207
		public const int NiagaraMoreReward = 7;
	}
}
