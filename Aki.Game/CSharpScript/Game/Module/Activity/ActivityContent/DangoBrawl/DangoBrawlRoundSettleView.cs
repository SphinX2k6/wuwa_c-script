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
	// Token: 0x02005787 RID: 22407
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRoundSettleView : UiViewBase
	{
		// Token: 0x060374C8 RID: 226504 RVA: 0x00F713AB File Offset: 0x00F6F5AB
		public DangoBrawlRoundSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060374C9 RID: 226505 RVA: 0x00F713B4 File Offset: 0x00F6F5B4
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

		// Token: 0x060374CA RID: 226506 RVA: 0x00F717F4 File Offset: 0x00F6F9F4
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlRoundSettleView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlRoundSettleView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060374CB RID: 226507 RVA: 0x00F71837 File Offset: 0x00F6FA37
		private DangoBrawlProgressItem CreateBrawlProgressItem()
		{
			return new DangoBrawlProgressItem();
		}

		// Token: 0x060374CC RID: 226508 RVA: 0x00F7183E File Offset: 0x00F6FA3E
		private DangoBrawlRoundAddProgressItem CreateRoundAddProgressItem()
		{
			return new DangoBrawlRoundAddProgressItem();
		}

		// Token: 0x060374CD RID: 226509 RVA: 0x00F71845 File Offset: 0x00F6FA45
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x060374CE RID: 226510 RVA: 0x00F7184C File Offset: 0x00F6FA4C
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

		// Token: 0x060374CF RID: 226511 RVA: 0x00F71887 File Offset: 0x00F6FA87
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlRoundSettleStateChanged, true);
			this.SetUiBlurEnabled(true);
		}

		// Token: 0x060374D0 RID: 226512 RVA: 0x00F718A1 File Offset: 0x00F6FAA1
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlRoundSettleStateChanged, false);
			this.SetUiBlurEnabled(false);
		}

		// Token: 0x060374D1 RID: 226513 RVA: 0x00F718BB File Offset: 0x00F6FABB
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlRoundSettleRecover, new Action(this.OnRoundSettleRecover));
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlRoundSettleClosed);
		}

		// Token: 0x060374D2 RID: 226514 RVA: 0x00F718E9 File Offset: 0x00F6FAE9
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

		// Token: 0x060374D3 RID: 226515 RVA: 0x00F71914 File Offset: 0x00F6FB14
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

		// Token: 0x060374D4 RID: 226516 RVA: 0x00F71A18 File Offset: 0x00F6FC18
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

		// Token: 0x060374D5 RID: 226517 RVA: 0x00F71A78 File Offset: 0x00F6FC78
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

		// Token: 0x060374D6 RID: 226518 RVA: 0x00F71D40 File Offset: 0x00F6FF40
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

		// Token: 0x060374D7 RID: 226519 RVA: 0x00F71DA5 File Offset: 0x00F6FFA5
		private void InitUiBlur()
		{
			AUIBaseActor rootActor = this.RootActor;
			this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
		}

		// Token: 0x060374D8 RID: 226520 RVA: 0x00F71DCE File Offset: 0x00F6FFCE
		private void SetUiBlurEnabled(bool enabled)
		{
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur == null)
			{
				return;
			}
			uiBlur.SetEnableUiBlur(enabled);
		}

		// Token: 0x060374D9 RID: 226521 RVA: 0x00F71DE1 File Offset: 0x00F6FFE1
		private void OnClickBtnHide()
		{
			base.Hide(null);
		}

		// Token: 0x060374DA RID: 226522 RVA: 0x00F71DEA File Offset: 0x00F6FFEA
		private void OnClickBtnLeave()
		{
			this.RequestFightOver(false, false).Forget();
		}

		// Token: 0x060374DB RID: 226523 RVA: 0x00F71DF9 File Offset: 0x00F6FFF9
		private void OnRoundSettleRecover()
		{
			base.Show(null);
		}

		// Token: 0x060374DC RID: 226524 RVA: 0x00F71E04 File Offset: 0x00F70004
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

		// Token: 0x060374DD RID: 226525 RVA: 0x00F71E48 File Offset: 0x00F70048
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

		// Token: 0x060374DE RID: 226526 RVA: 0x00F71EA1 File Offset: 0x00F700A1
		private void OnClickBtnMask()
		{
			this.RequestFightOver(false, false).Forget();
		}

		// Token: 0x060374DF RID: 226527 RVA: 0x00F71EB0 File Offset: 0x00F700B0
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

		// Token: 0x0401D364 RID: 119652
		private DangoBrawlBattleManager Manager;

		// Token: 0x0401D365 RID: 119653
		private DangoBrawlRoundSettleView.EDangoBrawlRoundSettleState CurrentState;

		// Token: 0x0401D366 RID: 119654
		private bool CanEnterAdditional;

		// Token: 0x0401D367 RID: 119655
		private bool IsLastRoundWin;

		// Token: 0x0401D368 RID: 119656
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> NormalBrawlProgressItemLayout;

		// Token: 0x0401D369 RID: 119657
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRoundAddProgressItem, DangoBrawlProgressItemData> AddBrawlProgressItemLayout;

		// Token: 0x0401D36A RID: 119658
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> NormalBrawlWithAddProgressItemLayout;

		// Token: 0x0401D36B RID: 119659
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> RetryItemLayout;

		// Token: 0x0401D36C RID: 119660
		[Nullable(2)]
		private TsUiBlur UiBlur;

		// Token: 0x0401D36D RID: 119661
		private const string SeqEventTrophyStart = "Trophy_Start";

		// Token: 0x0401D36E RID: 119662
		private const string SeqEventLose = "Lose";

		// Token: 0x0200B3C3 RID: 46019
		[NullableContext(0)]
		protected enum EDangoBrawlRoundSettleState
		{
			// Token: 0x04037943 RID: 227651
			None,
			// Token: 0x04037944 RID: 227652
			NormalRound,
			// Token: 0x04037945 RID: 227653
			NormalRoundFinal,
			// Token: 0x04037946 RID: 227654
			AddRound
		}

		// Token: 0x0200B3C4 RID: 46020
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037948 RID: 227656
			TipsTxtRound,
			// Token: 0x04037949 RID: 227657
			TxtRound,
			// Token: 0x0403794A RID: 227658
			PnlStateA,
			// Token: 0x0403794B RID: 227659
			NormalLayout,
			// Token: 0x0403794C RID: 227660
			NormalItem,
			// Token: 0x0403794D RID: 227661
			AddNode,
			// Token: 0x0403794E RID: 227662
			AddLayout,
			// Token: 0x0403794F RID: 227663
			AddItem,
			// Token: 0x04037950 RID: 227664
			NormalLayoutWithAdd,
			// Token: 0x04037951 RID: 227665
			NormalItemWithAdd,
			// Token: 0x04037952 RID: 227666
			RetryItemLayout,
			// Token: 0x04037953 RID: 227667
			RetryItem,
			// Token: 0x04037954 RID: 227668
			BtnHide,
			// Token: 0x04037955 RID: 227669
			PnlBonusBtn,
			// Token: 0x04037956 RID: 227670
			BtnLeave,
			// Token: 0x04037957 RID: 227671
			BtnAdditional,
			// Token: 0x04037958 RID: 227672
			PnlCloseBtn,
			// Token: 0x04037959 RID: 227673
			BtnMask,
			// Token: 0x0403795A RID: 227674
			BtnExit,
			// Token: 0x0403795B RID: 227675
			PnlHideArea,
			// Token: 0x0403795C RID: 227676
			PnlNextArea,
			// Token: 0x0403795D RID: 227677
			BtnRecover,
			// Token: 0x0403795E RID: 227678
			BtnNextRoundInHide,
			// Token: 0x0403795F RID: 227679
			BtnLeaveInHide,
			// Token: 0x04037960 RID: 227680
			TxtAddRoundNum
		}
	}
}
