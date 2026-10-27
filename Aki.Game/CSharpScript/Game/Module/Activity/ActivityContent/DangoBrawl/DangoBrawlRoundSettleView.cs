using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006837 RID: 26679
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRoundSettleView : UiViewBase
	{
		// Token: 0x06042974 RID: 272756 RVA: 0x0102FE9F File Offset: 0x0102E09F
		public DangoBrawlRoundSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042975 RID: 272757 RVA: 0x0102FEA8 File Offset: 0x0102E0A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 25;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickBtnHide));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickBtnLeave));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.ShowConfirmBoxToAdditional));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnClickBtnMask));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.ShowConfirmBoxToFinalSettle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042976 RID: 272758 RVA: 0x010302E8 File Offset: 0x0102E4E8
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlRoundSettleView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlRoundSettleView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042977 RID: 272759 RVA: 0x0103032B File Offset: 0x0102E52B
		private DangoBrawlProgressItem CreateBrawlProgressItem()
		{
			return new DangoBrawlProgressItem();
		}

		// Token: 0x06042978 RID: 272760 RVA: 0x01030332 File Offset: 0x0102E532
		private DangoBrawlRoundAddProgressItem CreateRoundAddProgressItem()
		{
			return new DangoBrawlRoundAddProgressItem();
		}

		// Token: 0x06042979 RID: 272761 RVA: 0x01030339 File Offset: 0x0102E539
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x0604297A RID: 272762 RVA: 0x01030340 File Offset: 0x0102E540
		protected override void OnStart()
		{
			this.Manager = DangoBrawlModel.Instance.GetBattleManager(true);
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnStartSequenceEvent));
			}
			this.RefreshView();
		}

		// Token: 0x0604297B RID: 272763 RVA: 0x0103037B File Offset: 0x0102E57B
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlRoundSettleStateChanged, true);
			this.SetUiBlurEnabled(true);
		}

		// Token: 0x0604297C RID: 272764 RVA: 0x01030395 File Offset: 0x0102E595
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlRoundSettleStateChanged, false);
			this.SetUiBlurEnabled(false);
		}

		// Token: 0x0604297D RID: 272765 RVA: 0x010303AF File Offset: 0x0102E5AF
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlRoundSettleRecover, new Action(this.OnRoundSettleRecover));
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlRoundSettleClosed);
		}

		// Token: 0x0604297E RID: 272766 RVA: 0x010303DD File Offset: 0x0102E5DD
		private void OnStartSequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Trophy_Start")
			{
				this.PlayProgressTrophyAnim();
			}
			if (eventName == "Lose")
			{
				this.PlayRetryLoseAnim();
			}
		}

		// Token: 0x0604297F RID: 272767 RVA: 0x01030408 File Offset: 0x0102E608
		private void PlayProgressTrophyAnim()
		{
			if (this.CurrentState == DangoBrawlRoundSettleView.EDangoBrawlRoundSettleState.AddRound)
			{
				if (this.NormalBrawlWithAddProgressItemLayout != null)
				{
					foreach (DangoBrawlProgressItem dangoBrawlProgressItem in this.NormalBrawlWithAddProgressItemLayout.GetLayoutItemList())
					{
						dangoBrawlProgressItem.PlayAnim();
					}
				}
				if (this.AddBrawlProgressItemLayout == null)
				{
					return;
				}
				using (List<DangoBrawlRoundAddProgressItem>.Enumerator enumerator2 = this.AddBrawlProgressItemLayout.GetLayoutItemList().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						DangoBrawlRoundAddProgressItem dangoBrawlRoundAddProgressItem = enumerator2.Current;
						dangoBrawlRoundAddProgressItem.PlayAnim();
					}
					return;
				}
			}
			if (this.NormalBrawlProgressItemLayout != null)
			{
				foreach (DangoBrawlProgressItem dangoBrawlProgressItem2 in this.NormalBrawlProgressItemLayout.GetLayoutItemList())
				{
					dangoBrawlProgressItem2.PlayAnim();
				}
			}
		}

		// Token: 0x06042980 RID: 272768 RVA: 0x0103050C File Offset: 0x0102E70C
		private void PlayRetryLoseAnim()
		{
			if (this.RetryItemLayout == null)
			{
				return;
			}
			foreach (DangoBrawlRetryCountItem dangoBrawlRetryCountItem in this.RetryItemLayout.GetLayoutItemList())
			{
				dangoBrawlRetryCountItem.PlayAnim();
			}
		}

		// Token: 0x06042981 RID: 272769 RVA: 0x0103056C File Offset: 0x0102E76C
		private void RefreshView()
		{
			DangoBrawlInstBaseNotify instBase = ActivityDangoBrawlController.Instance.MyActivityData.InstBase;
			int id = (instBase != null) ? instBase.ChallengeId : 0;
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(id);
			bool valueOrDefault = this.Manager.IsWin.GetValueOrDefault();
			int num = (instBase != null) ? instBase.WinCount : 0;
			int num2 = (instBase != null) ? instBase.LoseCount : 0;
			int num3 = num;
			int num4 = num2;
			int num5 = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().AdditionRound : 0;
			int maxHp = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().HpCount : 0;
			int num6 = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().WinCount : 0;
			if (valueOrDefault)
			{
				num3 = num + 1;
			}
			else
			{
				num4 = num2 + 1;
			}
			int num7 = num3 + num4;
			GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> retryItemLayout = this.RetryItemLayout;
			if (retryItemLayout != null)
			{
				retryItemLayout.RefreshByData(DangoBrawlUtil.BuildRetryHeartList(maxHp, num4, !valueOrDefault), null, false);
			}
			if (num3 >= num6)
			{
				this.CurrentState = ((num >= num6 && num5 > 0) ? DangoBrawlRoundSettleView.EDangoBrawlRoundSettleState.AddRound : DangoBrawlRoundSettleView.EDangoBrawlRoundSettleState.NormalRoundFinal);
			}
			else
			{
				this.CurrentState = DangoBrawlRoundSettleView.EDangoBrawlRoundSettleState.NormalRound;
			}
			bool flag = this.CurrentState == DangoBrawlRoundSettleView.EDangoBrawlRoundSettleState.AddRound;
			bool flag2 = this.CurrentState == DangoBrawlRoundSettleView.EDangoBrawlRoundSettleState.NormalRound;
			bool flag3 = this.CurrentState == DangoBrawlRoundSettleView.EDangoBrawlRoundSettleState.NormalRoundFinal;
			bool flag4 = flag2 || flag3;
			this.CanEnterAdditional = (num5 > 0 && flag3);
			this.IsLastRoundWin = (valueOrDefault && num3 >= num6 + num5);
			base.GetItem(2).SetUIActive(!flag);
			base.GetItem(5).SetUIActive(flag);
			base.GetButton(18).RootUIComp.Get().SetUIActive(flag);
			base.GetItem(13).SetUIActive(this.CanEnterAdditional);
			base.GetItem(16).SetUIActive(!this.CanEnterAdditional);
			string textStringId = "";
			if (flag4)
			{
				textStringId = "DangoBrawlGeneral_1018";
				List<DangoBrawlProgressItemData> data = this.BuildBrawlProgressItemDataList(num6, num3, false, valueOrDefault);
				GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> normalBrawlProgressItemLayout = this.NormalBrawlProgressItemLayout;
				if (normalBrawlProgressItemLayout != null)
				{
					normalBrawlProgressItemLayout.RefreshByData(data, null, false);
				}
			}
			else if (flag)
			{
				textStringId = "DangoBrawlGeneral_1019";
				int currentCount = num3 - num6;
				List<DangoBrawlProgressItemData> data2 = this.BuildBrawlProgressItemDataList(num6, num3, false, false);
				List<DangoBrawlProgressItemData> data3 = this.BuildBrawlProgressItemDataList(num5, currentCount, true, valueOrDefault);
				GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> normalBrawlWithAddProgressItemLayout = this.NormalBrawlWithAddProgressItemLayout;
				if (normalBrawlWithAddProgressItemLayout != null)
				{
					normalBrawlWithAddProgressItemLayout.RefreshByData(data2, null, false);
				}
				GenericLayout<DangoBrawlRoundAddProgressItem, DangoBrawlProgressItemData> addBrawlProgressItemLayout = this.AddBrawlProgressItemLayout;
				if (addBrawlProgressItemLayout != null)
				{
					addBrawlProgressItemLayout.RefreshByData(data3, null, false);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, new <>z__ReadOnlySingleElementList<object>(num7));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlySingleElementList<object>(num7));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(24), "DangoBrawlBattleUIText_054", new <>z__ReadOnlySingleElementList<object>(num5));
		}

		// Token: 0x06042982 RID: 272770 RVA: 0x01030834 File Offset: 0x0102EA34
		public List<DangoBrawlProgressItemData> BuildBrawlProgressItemDataList(int totalCount, int currentCount, bool isAdd = false, bool markNewestWin = false)
		{
			List<DangoBrawlProgressItemData> list = new List<DangoBrawlProgressItemData>(totalCount);
			for (int i = 0; i < totalCount; i++)
			{
				DangoBrawlProgressItemData dangoBrawlProgressItemData = new DangoBrawlProgressItemData(i);
				if (i < currentCount)
				{
					dangoBrawlProgressItemData.IsWin = true;
				}
				if (!isAdd && i == totalCount - 1)
				{
					dangoBrawlProgressItemData.IsLast = true;
				}
				dangoBrawlProgressItemData.NeedAnim = (markNewestWin && dangoBrawlProgressItemData.IsWin && i == currentCount - 1);
				list.Add(dangoBrawlProgressItemData);
			}
			return list;
		}

		// Token: 0x06042983 RID: 272771 RVA: 0x01030899 File Offset: 0x0102EA99
		private void InitUiBlur()
		{
			AUIBaseActor rootActor = this.RootActor;
			this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
		}

		// Token: 0x06042984 RID: 272772 RVA: 0x010308C2 File Offset: 0x0102EAC2
		private void SetUiBlurEnabled(bool enabled)
		{
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur == null)
			{
				return;
			}
			uiBlur.SetEnableUiBlur(enabled);
		}

		// Token: 0x06042985 RID: 272773 RVA: 0x010308D5 File Offset: 0x0102EAD5
		private void OnClickBtnHide()
		{
			base.Hide(null);
		}

		// Token: 0x06042986 RID: 272774 RVA: 0x010308DE File Offset: 0x0102EADE
		private void OnClickBtnLeave()
		{
			this.RequestFightOver(false, false).Forget();
		}

		// Token: 0x06042987 RID: 272775 RVA: 0x010308ED File Offset: 0x0102EAED
		private void OnRoundSettleRecover()
		{
			base.Show(null);
		}

		// Token: 0x06042988 RID: 272776 RVA: 0x010308F8 File Offset: 0x0102EAF8
		private void ShowConfirmBoxToAdditional()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoBrawlEnterAdditionalConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.RequestFightOver(true, false).Forget();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06042989 RID: 272777 RVA: 0x0103093C File Offset: 0x0102EB3C
		private void ShowConfirmBoxToFinalSettle()
		{
			if (this.IsLastRoundWin)
			{
				this.RequestFightOver(false, false).Forget();
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoBrawlEnterFinalSettleConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.RequestFightOver(false, true).Forget();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0604298A RID: 272778 RVA: 0x01030995 File Offset: 0x0102EB95
		private void OnClickBtnMask()
		{
			this.RequestFightOver(false, false).Forget();
		}

		// Token: 0x0604298B RID: 272779 RVA: 0x010309A4 File Offset: 0x0102EBA4
		private UniTask RequestFightOver(bool isAdditionalRound = false, bool needDirectEnterSettle = false)
		{
			DangoBrawlRoundSettleView.<RequestFightOver>d__36 <RequestFightOver>d__;
			<RequestFightOver>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestFightOver>d__.<>4__this = this;
			<RequestFightOver>d__.isAdditionalRound = isAdditionalRound;
			<RequestFightOver>d__.needDirectEnterSettle = needDirectEnterSettle;
			<RequestFightOver>d__.<>1__state = -1;
			<RequestFightOver>d__.<>t__builder.Start<DangoBrawlRoundSettleView.<RequestFightOver>d__36>(ref <RequestFightOver>d__);
			return <RequestFightOver>d__.<>t__builder.Task;
		}

		// Token: 0x04022B07 RID: 142087
		private DangoBrawlBattleManager Manager;

		// Token: 0x04022B08 RID: 142088
		private DangoBrawlRoundSettleView.EDangoBrawlRoundSettleState CurrentState;

		// Token: 0x04022B09 RID: 142089
		private bool CanEnterAdditional;

		// Token: 0x04022B0A RID: 142090
		private bool IsLastRoundWin;

		// Token: 0x04022B0B RID: 142091
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> NormalBrawlProgressItemLayout;

		// Token: 0x04022B0C RID: 142092
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRoundAddProgressItem, DangoBrawlProgressItemData> AddBrawlProgressItemLayout;

		// Token: 0x04022B0D RID: 142093
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> NormalBrawlWithAddProgressItemLayout;

		// Token: 0x04022B0E RID: 142094
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> RetryItemLayout;

		// Token: 0x04022B0F RID: 142095
		[Nullable(2)]
		private TsUiBlur UiBlur;

		// Token: 0x04022B10 RID: 142096
		private const string SeqEventTrophyStart = "Trophy_Start";

		// Token: 0x04022B11 RID: 142097
		private const string SeqEventLose = "Lose";

		// Token: 0x0200C9F7 RID: 51703
		[NullableContext(0)]
		protected enum EDangoBrawlRoundSettleState
		{
			// Token: 0x0403D05A RID: 249946
			None,
			// Token: 0x0403D05B RID: 249947
			NormalRound,
			// Token: 0x0403D05C RID: 249948
			NormalRoundFinal,
			// Token: 0x0403D05D RID: 249949
			AddRound
		}

		// Token: 0x0200C9F8 RID: 51704
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403D05F RID: 249951
			TipsTxtRound,
			// Token: 0x0403D060 RID: 249952
			TxtRound,
			// Token: 0x0403D061 RID: 249953
			PnlStateA,
			// Token: 0x0403D062 RID: 249954
			NormalLayout,
			// Token: 0x0403D063 RID: 249955
			NormalItem,
			// Token: 0x0403D064 RID: 249956
			AddNode,
			// Token: 0x0403D065 RID: 249957
			AddLayout,
			// Token: 0x0403D066 RID: 249958
			AddItem,
			// Token: 0x0403D067 RID: 249959
			NormalLayoutWithAdd,
			// Token: 0x0403D068 RID: 249960
			NormalItemWithAdd,
			// Token: 0x0403D069 RID: 249961
			RetryItemLayout,
			// Token: 0x0403D06A RID: 249962
			RetryItem,
			// Token: 0x0403D06B RID: 249963
			BtnHide,
			// Token: 0x0403D06C RID: 249964
			PnlBonusBtn,
			// Token: 0x0403D06D RID: 249965
			BtnLeave,
			// Token: 0x0403D06E RID: 249966
			BtnAdditional,
			// Token: 0x0403D06F RID: 249967
			PnlCloseBtn,
			// Token: 0x0403D070 RID: 249968
			BtnMask,
			// Token: 0x0403D071 RID: 249969
			BtnExit,
			// Token: 0x0403D072 RID: 249970
			PnlHideArea,
			// Token: 0x0403D073 RID: 249971
			PnlNextArea,
			// Token: 0x0403D074 RID: 249972
			BtnRecover,
			// Token: 0x0403D075 RID: 249973
			BtnNextRoundInHide,
			// Token: 0x0403D076 RID: 249974
			BtnLeaveInHide,
			// Token: 0x0403D077 RID: 249975
			TxtAddRoundNum
		}
	}
}
