using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x0200607E RID: 24702
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachinePauseView : UiViewBase
	{
		// Token: 0x0603B470 RID: 242800 RVA: 0x010C6204 File Offset: 0x010C4404
		[NullableContext(1)]
		public DollGrabMachinePauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B471 RID: 242801 RVA: 0x010C6210 File Offset: 0x010C4410
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnExitButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnGotoButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B472 RID: 242802 RVA: 0x010C644C File Offset: 0x010C464C
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabMachinePauseView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabMachinePauseView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B473 RID: 242803 RVA: 0x010C6490 File Offset: 0x010C4690
		protected override void OnStart()
		{
			this.GenericLayout = new GenericLayout<DollGrabMachinePauseItem, IGrabItemData>(base.GetHorizontalLayout(1), new Func<DollGrabMachinePauseItem>(this.CreateDollGrabPauseItem), null, false, true);
			this.PnlEmptyReward = base.GetItem(3);
			this.PnlReward = base.GetItem(6);
			this.PnlEndlessModel = base.GetItem(7);
			this.EndlessCurrentScore = base.GetText(8);
			this.EndlessTotalScore = base.GetText(9);
			this.EndlessSpriteCheck = base.GetSprite(10);
			this.EndlessTxtDescri02 = base.GetText(11);
		}

		// Token: 0x0603B474 RID: 242804 RVA: 0x010C651C File Offset: 0x010C471C
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DollGrabMachinePauseView.<OnBeforeShowAsyncImplementImplement>d__13 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DollGrabMachinePauseView.<OnBeforeShowAsyncImplementImplement>d__13>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603B475 RID: 242805 RVA: 0x010C6560 File Offset: 0x010C4760
		private UniTask RefreshNormalMode()
		{
			DollGrabMachinePauseView.<RefreshNormalMode>d__14 <RefreshNormalMode>d__;
			<RefreshNormalMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNormalMode>d__.<>4__this = this;
			<RefreshNormalMode>d__.<>1__state = -1;
			<RefreshNormalMode>d__.<>t__builder.Start<DollGrabMachinePauseView.<RefreshNormalMode>d__14>(ref <RefreshNormalMode>d__);
			return <RefreshNormalMode>d__.<>t__builder.Task;
		}

		// Token: 0x0603B476 RID: 242806 RVA: 0x010C65A4 File Offset: 0x010C47A4
		private void RefreshEndlessMode()
		{
			UUIItem pnlEmptyReward = this.PnlEmptyReward;
			if (pnlEmptyReward != null)
			{
				pnlEmptyReward.SetUIActive(false);
			}
			UUIItem pnlReward = this.PnlReward;
			if (pnlReward != null)
			{
				pnlReward.SetUIActive(false);
			}
			UUIItem pnlEndlessModel = this.PnlEndlessModel;
			if (pnlEndlessModel != null)
			{
				pnlEndlessModel.SetUIActive(true);
			}
			IDollGrabInfiniteRewardData endlessRewardData = DollGrabMachineController.Instance.EndlessRewardData;
			UUIText endlessCurrentScore = this.EndlessCurrentScore;
			if (endlessCurrentScore != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int?>((endlessRewardData != null) ? new int?(endlessRewardData.CurrentScore) : null);
				endlessCurrentScore.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIText endlessTotalScore = this.EndlessTotalScore;
			if (endlessTotalScore != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int?>((endlessRewardData != null) ? new int?(endlessRewardData.CurrentAccumulatedScore) : null);
				endlessTotalScore.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUISprite endlessSpriteCheck = this.EndlessSpriteCheck;
			if (endlessSpriteCheck != null)
			{
				endlessSpriteCheck.SetUIActive(endlessRewardData != null && endlessRewardData.IsFinalReward);
			}
			LguiUtil.Instance.SetLocalTextNew(this.EndlessTxtDescri02, "KClaw_Infinite_Requirement", new <>z__ReadOnlySingleElementList<object>((endlessRewardData != null) ? endlessRewardData.TargetAccumulatedScore : "0"));
		}

		// Token: 0x0603B477 RID: 242807 RVA: 0x010C66C4 File Offset: 0x010C48C4
		private void OnExitButtonClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DollGrabMachineExitConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				base.CloseMe(null);
				DollGrabMachineController.Instance.PreExitDollGrabMachine(EDollGrabMachineEndReason.Exit, true);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603B478 RID: 242808 RVA: 0x010C6700 File Offset: 0x010C4900
		private void OnGotoButtonClick()
		{
			base.CloseMe(null);
			DollGrabMachineController.Instance.ResumeDollGrabMachine();
		}

		// Token: 0x0603B479 RID: 242809 RVA: 0x010C6713 File Offset: 0x010C4913
		[NullableContext(1)]
		private DollGrabMachinePauseItem CreateDollGrabPauseItem()
		{
			return new DollGrabMachinePauseItem();
		}

		// Token: 0x0401F35E RID: 127838
		private UUIItem PnlReward;

		// Token: 0x0401F35F RID: 127839
		private UUIItem PnlEmptyReward;

		// Token: 0x0401F360 RID: 127840
		private DollGrabMachinePauseCaptionPanel CaptionPanel;

		// Token: 0x0401F361 RID: 127841
		private UUIItem PnlEndlessModel;

		// Token: 0x0401F362 RID: 127842
		private UUIText EndlessCurrentScore;

		// Token: 0x0401F363 RID: 127843
		private UUIText EndlessTotalScore;

		// Token: 0x0401F364 RID: 127844
		private UUISprite EndlessSpriteCheck;

		// Token: 0x0401F365 RID: 127845
		private UUIText EndlessTxtDescri02;

		// Token: 0x0401F366 RID: 127846
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DollGrabMachinePauseItem, IGrabItemData> GenericLayout;
	}
}
