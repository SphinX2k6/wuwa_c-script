using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA9 RID: 7081
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUiCardItem : FloroRanchUiItemBase
{
	// Token: 0x0600D2D3 RID: 53971 RVA: 0x00307AD0 File Offset: 0x00305CD0
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

	// Token: 0x0600D2D4 RID: 53972 RVA: 0x00307BFF File Offset: 0x00305DFF
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x0600D2D5 RID: 53973 RVA: 0x00307C1C File Offset: 0x00305E1C
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchUiCardItem.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchUiCardItem.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2D6 RID: 53974 RVA: 0x00307C60 File Offset: 0x00305E60
	public void FollowPosition(FTransform transform)
	{
		FVector location = transform.GetLocation();
		location.Z -= 40f;
		this.OriginalPosition = location;
		base.GetRootItem().SetUIWorldLocation(this.OriginalPosition);
	}

	// Token: 0x0600D2D7 RID: 53975 RVA: 0x00307CA0 File Offset: 0x00305EA0
	public override UniTask RefreshItem()
	{
		FloroRanchUiCardItem.<RefreshItem>d__21 <RefreshItem>d__;
		<RefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItem>d__.<>4__this = this;
		<RefreshItem>d__.<>1__state = -1;
		<RefreshItem>d__.<>t__builder.Start<FloroRanchUiCardItem.<RefreshItem>d__21>(ref <RefreshItem>d__);
		return <RefreshItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2D8 RID: 53976 RVA: 0x00307CE4 File Offset: 0x00305EE4
	public void RefreshEvolveItem()
	{
		FloroRanchCardDataComponent floroRanchCardDataComponent = this.Entity.CheckGetComponent<FloroRanchCardDataComponent>();
		this.EvolveItem.Refresh(floroRanchCardDataComponent.EvolveData);
		this.EvolveItem.GetRootItem().SetAnchorOffsetY((float)floroRanchCardDataComponent.CardData.GetEvolveItemOffsetY());
	}

	// Token: 0x0600D2D9 RID: 53977 RVA: 0x00307D2C File Offset: 0x00305F2C
	public void RefreshRemainTimeItem()
	{
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = this.Entity.CheckGetComponent<FloroRanchEntityDataComponent>();
		this.RemainTimeItem.Refresh(floroRanchEntityDataComponent.GetMinRemindDayBuff());
	}

	// Token: 0x0600D2DA RID: 53978 RVA: 0x00307D58 File Offset: 0x00305F58
	public void RefreshSpecialEffect()
	{
		EFloroRanchSpecialEffectType cardSpecialEffect = this.Entity.CheckGetComponent<FloroRanchCardDataComponent>().CardData.GetCardSpecialEffect();
		base.GetUiNiagara(4).SetUIActive(cardSpecialEffect == EFloroRanchSpecialEffectType.Blue);
		base.GetUiNiagara(5).SetUIActive(cardSpecialEffect == EFloroRanchSpecialEffectType.Red);
	}

	// Token: 0x0600D2DB RID: 53979 RVA: 0x00307D9B File Offset: 0x00305F9B
	public void RefreshDebugInfo()
	{
	}

	// Token: 0x0600D2DC RID: 53980 RVA: 0x00307DA0 File Offset: 0x00305FA0
	public override UniTask PlayShowAnim()
	{
		FloroRanchUiCardItem.<PlayShowAnim>d__26 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayShowAnim>d__26>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2DD RID: 53981 RVA: 0x00307DE4 File Offset: 0x00305FE4
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiCardItem.<PlayHideAnim>d__27 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayHideAnim>d__27>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2DE RID: 53982 RVA: 0x00307E28 File Offset: 0x00306028
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

	// Token: 0x0600D2DF RID: 53983 RVA: 0x00307E74 File Offset: 0x00306074
	public override UniTask ShowUiItem()
	{
		FloroRanchUiCardItem.<ShowUiItem>d__29 <ShowUiItem>d__;
		<ShowUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowUiItem>d__.<>4__this = this;
		<ShowUiItem>d__.<>1__state = -1;
		<ShowUiItem>d__.<>t__builder.Start<FloroRanchUiCardItem.<ShowUiItem>d__29>(ref <ShowUiItem>d__);
		return <ShowUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2E0 RID: 53984 RVA: 0x00307EB8 File Offset: 0x003060B8
	public override UniTask HideUiItem()
	{
		FloroRanchUiCardItem.<HideUiItem>d__30 <HideUiItem>d__;
		<HideUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideUiItem>d__.<>4__this = this;
		<HideUiItem>d__.<>1__state = -1;
		<HideUiItem>d__.<>t__builder.Start<FloroRanchUiCardItem.<HideUiItem>d__30>(ref <HideUiItem>d__);
		return <HideUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2E1 RID: 53985 RVA: 0x00307EFB File Offset: 0x003060FB
	public override void Pause()
	{
		this.UiLevelSequence.PauseSequence();
		base.GetSpine(1).SetTimeScale(0f);
	}

	// Token: 0x0600D2E2 RID: 53986 RVA: 0x00307F19 File Offset: 0x00306119
	public override void Resume()
	{
		this.UiLevelSequence.ResumeSequence();
		base.GetSpine(1).SetTimeScale(1f);
	}

	// Token: 0x0600D2E3 RID: 53987 RVA: 0x00307F38 File Offset: 0x00306138
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiCardItem.<PlayNormalAnim>d__33 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayNormalAnim>d__33>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2E4 RID: 53988 RVA: 0x00307F7C File Offset: 0x0030617C
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

	// Token: 0x0600D2E5 RID: 53989 RVA: 0x00307FC8 File Offset: 0x003061C8
	public override UniTask MoveToOriginalPosition()
	{
		FloroRanchUiCardItem.<MoveToOriginalPosition>d__35 <MoveToOriginalPosition>d__;
		<MoveToOriginalPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveToOriginalPosition>d__.<>4__this = this;
		<MoveToOriginalPosition>d__.<>1__state = -1;
		<MoveToOriginalPosition>d__.<>t__builder.Start<FloroRanchUiCardItem.<MoveToOriginalPosition>d__35>(ref <MoveToOriginalPosition>d__);
		return <MoveToOriginalPosition>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2E6 RID: 53990 RVA: 0x0030800C File Offset: 0x0030620C
	public override void MoveToOriginalPositionImmediate()
	{
		base.GetRootItem().SetUIWorldLocation(this.OriginalPosition);
		this.TargetRotator.Set(0f, 0f, 0f);
		UUIItem item = base.GetItem(0);
		FRotator frotator = this.TargetRotator.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x0600D2E7 RID: 53991 RVA: 0x0030805E File Offset: 0x0030625E
	public override FTransform? GetRewardPopTransform()
	{
		return new FTransform?(this.RootActor.GetTransform());
	}

	// Token: 0x0600D2E8 RID: 53992 RVA: 0x00308070 File Offset: 0x00306270
	public override UniTask PlayEatAnim()
	{
		FloroRanchUiCardItem.<PlayEatAnim>d__38 <PlayEatAnim>d__;
		<PlayEatAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayEatAnim>d__.<>4__this = this;
		<PlayEatAnim>d__.<>1__state = -1;
		<PlayEatAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayEatAnim>d__38>(ref <PlayEatAnim>d__);
		return <PlayEatAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2E9 RID: 53993 RVA: 0x003080B4 File Offset: 0x003062B4
	public override UniTask PlayBeEatAnim()
	{
		FloroRanchUiCardItem.<PlayBeEatAnim>d__39 <PlayBeEatAnim>d__;
		<PlayBeEatAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayBeEatAnim>d__.<>4__this = this;
		<PlayBeEatAnim>d__.<>1__state = -1;
		<PlayBeEatAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayBeEatAnim>d__39>(ref <PlayBeEatAnim>d__);
		return <PlayBeEatAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2EA RID: 53994 RVA: 0x003080F8 File Offset: 0x003062F8
	public override UniTask PlaySacrificeAnim()
	{
		FloroRanchUiCardItem.<PlaySacrificeAnim>d__40 <PlaySacrificeAnim>d__;
		<PlaySacrificeAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySacrificeAnim>d__.<>4__this = this;
		<PlaySacrificeAnim>d__.<>1__state = -1;
		<PlaySacrificeAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlaySacrificeAnim>d__40>(ref <PlaySacrificeAnim>d__);
		return <PlaySacrificeAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2EB RID: 53995 RVA: 0x0030813C File Offset: 0x0030633C
	public override UniTask PlayFusionHideAnim()
	{
		FloroRanchUiCardItem.<PlayFusionHideAnim>d__41 <PlayFusionHideAnim>d__;
		<PlayFusionHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFusionHideAnim>d__.<>4__this = this;
		<PlayFusionHideAnim>d__.<>1__state = -1;
		<PlayFusionHideAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayFusionHideAnim>d__41>(ref <PlayFusionHideAnim>d__);
		return <PlayFusionHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2EC RID: 53996 RVA: 0x00308180 File Offset: 0x00306380
	public override UniTask PlayFusionShowAnim()
	{
		FloroRanchUiCardItem.<PlayFusionShowAnim>d__42 <PlayFusionShowAnim>d__;
		<PlayFusionShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFusionShowAnim>d__.<>4__this = this;
		<PlayFusionShowAnim>d__.<>1__state = -1;
		<PlayFusionShowAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayFusionShowAnim>d__42>(ref <PlayFusionShowAnim>d__);
		return <PlayFusionShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2ED RID: 53997 RVA: 0x003081C4 File Offset: 0x003063C4
	public override UniTask PlayEvolveUpAnim()
	{
		FloroRanchUiCardItem.<PlayEvolveUpAnim>d__43 <PlayEvolveUpAnim>d__;
		<PlayEvolveUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayEvolveUpAnim>d__.<>4__this = this;
		<PlayEvolveUpAnim>d__.<>1__state = -1;
		<PlayEvolveUpAnim>d__.<>t__builder.Start<FloroRanchUiCardItem.<PlayEvolveUpAnim>d__43>(ref <PlayEvolveUpAnim>d__);
		return <PlayEvolveUpAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2EE RID: 53998 RVA: 0x00308208 File Offset: 0x00306408
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

	// Token: 0x0600D2EF RID: 53999 RVA: 0x003082A4 File Offset: 0x003064A4
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

	// Token: 0x0600D2F0 RID: 54000 RVA: 0x00308379 File Offset: 0x00306579
	protected override void OnBeforeDestroy()
	{
		base.GetSpine(1).AnimationComplete.Remove(new Action<UTrackEntry>(this.OnSpineAnimationComplete));
		this.ClearTimerHandle();
	}

	// Token: 0x0600D2F1 RID: 54001 RVA: 0x003083A0 File Offset: 0x003065A0
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

	// Token: 0x0600D2F2 RID: 54002 RVA: 0x003083FC File Offset: 0x003065FC
	public void BindMoveCurve(UCurveFloat curve)
	{
		this.CardMoveCurve = curve;
	}

	// Token: 0x0600D2F3 RID: 54003 RVA: 0x00308405 File Offset: 0x00306605
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

	// Token: 0x0600D2F4 RID: 54004 RVA: 0x0030843C File Offset: 0x0030663C
	private void OnHideAnimationComplete(string sequenceName)
	{
		base.GetRootItem().SetUIWorldLocation(this.OriginalPosition);
		base.GetRootItem().SetUIActive(false);
		base.GetSpine(1).ClearTracks();
	}

	// Token: 0x0400609F RID: 24735
	private FloroRanchEvolveItem EvolveItem;

	// Token: 0x040060A0 RID: 24736
	private FloroRanchBuffRemindDayItem RemainTimeItem;

	// Token: 0x040060A1 RID: 24737
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x040060A2 RID: 24738
	private FVector OriginalPosition;

	// Token: 0x040060A3 RID: 24739
	private UCurveFloat CardMoveCurve;

	// Token: 0x040060A4 RID: 24740
	private TimerHandle TimerHandle;

	// Token: 0x040060A5 RID: 24741
	private CustomPromise<object> WaitPromise;

	// Token: 0x040060A6 RID: 24742
	private FloroRanchEntityDebugInfoItem DebugInfoItem;

	// Token: 0x040060A7 RID: 24743
	private readonly Vector MoveDirection = Vector.Create();

	// Token: 0x040060A8 RID: 24744
	private readonly Vector StartPosition = Vector.Create();

	// Token: 0x040060A9 RID: 24745
	private Vector TargetPosition = Vector.Create();

	// Token: 0x040060AA RID: 24746
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x040060AB RID: 24747
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x040060AC RID: 24748
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x040060AD RID: 24749
	private readonly Rotator TargetRotator = Rotator.Create();

	// Token: 0x040060AE RID: 24750
	private float TickTime;

	// Token: 0x0200814C RID: 33100
	[NullableContext(0)]
	private class EItemComponentDefine
	{
		// Token: 0x0402A33C RID: 172860
		public const int SpineItem = 0;

		// Token: 0x0402A33D RID: 172861
		public const int Spine = 1;

		// Token: 0x0402A33E RID: 172862
		public const int EvolveItem = 2;

		// Token: 0x0402A33F RID: 172863
		public const int RemainTimeItem = 3;

		// Token: 0x0402A340 RID: 172864
		public const int NiagaraBlue = 4;

		// Token: 0x0402A341 RID: 172865
		public const int NiagaraRed = 5;

		// Token: 0x0402A342 RID: 172866
		public const int NiagaraReward = 6;

		// Token: 0x0402A343 RID: 172867
		public const int NiagaraMoreReward = 7;
	}
}
