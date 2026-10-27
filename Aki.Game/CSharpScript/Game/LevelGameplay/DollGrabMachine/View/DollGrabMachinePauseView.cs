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
	// Token: 0x02006EFE RID: 28414
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachinePauseView : UiViewBase
	{
		// Token: 0x060452C7 RID: 283335 RVA: 0x0111C474 File Offset: 0x0111A674
		[NullableContext(1)]
		public DollGrabMachinePauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060452C8 RID: 283336 RVA: 0x0111C480 File Offset: 0x0111A680
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
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

		// Token: 0x060452C9 RID: 283337 RVA: 0x0111C698 File Offset: 0x0111A898
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

		// Token: 0x060452CA RID: 283338 RVA: 0x0111C724 File Offset: 0x0111A924
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DollGrabMachinePauseView.<OnBeforeShowAsyncImplementImplement>d__11 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DollGrabMachinePauseView.<OnBeforeShowAsyncImplementImplement>d__11>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060452CB RID: 283339 RVA: 0x0111C768 File Offset: 0x0111A968
		private UniTask RefreshNormalMode()
		{
			DollGrabMachinePauseView.<RefreshNormalMode>d__12 <RefreshNormalMode>d__;
			<RefreshNormalMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNormalMode>d__.<>4__this = this;
			<RefreshNormalMode>d__.<>1__state = -1;
			<RefreshNormalMode>d__.<>t__builder.Start<DollGrabMachinePauseView.<RefreshNormalMode>d__12>(ref <RefreshNormalMode>d__);
			return <RefreshNormalMode>d__.<>t__builder.Task;
		}

		// Token: 0x060452CC RID: 283340 RVA: 0x0111C7AC File Offset: 0x0111A9AC
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

		// Token: 0x060452CD RID: 283341 RVA: 0x0111C8CC File Offset: 0x0111AACC
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

		// Token: 0x060452CE RID: 283342 RVA: 0x0111C908 File Offset: 0x0111AB08
		private void OnGotoButtonClick()
		{
			base.CloseMe(null);
			DollGrabMachineController.Instance.ResumeDollGrabMachine();
		}

		// Token: 0x060452CF RID: 283343 RVA: 0x0111C91B File Offset: 0x0111AB1B
		[NullableContext(1)]
		private DollGrabMachinePauseItem CreateDollGrabPauseItem()
		{
			return new DollGrabMachinePauseItem();
		}

		// Token: 0x040240AA RID: 147626
		private UUIItem PnlReward;

		// Token: 0x040240AB RID: 147627
		private UUIItem PnlEmptyReward;

		// Token: 0x040240AC RID: 147628
		private UUIItem PnlEndlessModel;

		// Token: 0x040240AD RID: 147629
		private UUIText EndlessCurrentScore;

		// Token: 0x040240AE RID: 147630
		private UUIText EndlessTotalScore;

		// Token: 0x040240AF RID: 147631
		private UUISprite EndlessSpriteCheck;

		// Token: 0x040240B0 RID: 147632
		private UUIText EndlessTxtDescri02;

		// Token: 0x040240B1 RID: 147633
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DollGrabMachinePauseItem, IGrabItemData> GenericLayout;
	}
}
