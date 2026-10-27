using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200682D RID: 26669
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPauseView : UiViewBase
	{
		// Token: 0x060428F1 RID: 272625 RVA: 0x0102CE32 File Offset: 0x0102B032
		public DangoBrawlPauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060428F2 RID: 272626 RVA: 0x0102CE3C File Offset: 0x0102B03C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickContinue));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickReStart));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickExit));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickSaveExit));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060428F3 RID: 272627 RVA: 0x0102D100 File Offset: 0x0102B300
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPauseView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPauseView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060428F4 RID: 272628 RVA: 0x0102D143 File Offset: 0x0102B343
		private DangoBrawlProgressItem CreateBrawlProgressItem()
		{
			return new DangoBrawlProgressItem();
		}

		// Token: 0x060428F5 RID: 272629 RVA: 0x0102D14A File Offset: 0x0102B34A
		private DangoBrawlRoundAddProgressItem CreateRoundAddProgressItem()
		{
			return new DangoBrawlRoundAddProgressItem();
		}

		// Token: 0x060428F6 RID: 272630 RVA: 0x0102D151 File Offset: 0x0102B351
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x060428F7 RID: 272631 RVA: 0x0102D158 File Offset: 0x0102B358
		protected override void OnStart()
		{
			object openParam = this.OpenParam;
			if (openParam is EDangoBrawlPauseViewFrom)
			{
				EDangoBrawlPauseViewFrom edangoBrawlPauseViewFrom = (EDangoBrawlPauseViewFrom)openParam;
				if (edangoBrawlPauseViewFrom != EDangoBrawlPauseViewFrom.BattlePanel)
				{
				}
			}
			this.RefreshInfo();
		}

		// Token: 0x060428F8 RID: 272632 RVA: 0x0102D188 File Offset: 0x0102B388
		protected override void OnBeforeShow()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPauseByView(true, "DangoBrawlPauseView");
		}

		// Token: 0x060428F9 RID: 272633 RVA: 0x0102D1A5 File Offset: 0x0102B3A5
		protected override void OnBeforeHide()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPauseByView(false, "DangoBrawlPauseView");
		}

		// Token: 0x060428FA RID: 272634 RVA: 0x0102D1C4 File Offset: 0x0102B3C4
		private void RefreshInfo()
		{
			DangoBrawlInstBaseNotify instBase = ActivityDangoBrawlController.Instance.MyActivityData.InstBase;
			int id = (instBase != null) ? instBase.ChallengeId : 0;
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(id);
			int num = (instBase != null) ? instBase.WinCount : 0;
			int usedCount = (instBase != null) ? instBase.LoseCount : 0;
			int num2 = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().AdditionRound : 0;
			int maxHp = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().HpCount : 0;
			int num3 = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().WinCount : 0;
			GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> retryItemLayout = this.RetryItemLayout;
			if (retryItemLayout != null)
			{
				retryItemLayout.RefreshByData(DangoBrawlUtil.BuildRetryHeartList(maxHp, usedCount, false), null, false);
			}
			bool flag = num2 > 0 && num >= num3;
			base.GetHorizontalLayout(4).RootUIComp.Get().SetUIActive(!flag);
			base.GetItem(6).SetUIActive(flag);
			if (!flag)
			{
				List<DangoBrawlProgressItemData> data = this.BuildBrawlProgressItemDataList(num3, num, false);
				GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> normalBrawlProgressItemLayout = this.NormalBrawlProgressItemLayout;
				if (normalBrawlProgressItemLayout == null)
				{
					return;
				}
				normalBrawlProgressItemLayout.RefreshByData(data, null, false);
				return;
			}
			else
			{
				int currentCount = num - num3;
				List<DangoBrawlProgressItemData> data2 = this.BuildBrawlProgressItemDataList(num3, num, false);
				List<DangoBrawlProgressItemData> data3 = this.BuildBrawlProgressItemDataList(num2, currentCount, true);
				GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> normalBrawlWithAddProgressItemLayout = this.NormalBrawlWithAddProgressItemLayout;
				if (normalBrawlWithAddProgressItemLayout != null)
				{
					normalBrawlWithAddProgressItemLayout.RefreshByData(data2, null, false);
				}
				GenericLayout<DangoBrawlRoundAddProgressItem, DangoBrawlProgressItemData> addBrawlProgressItemLayout = this.AddBrawlProgressItemLayout;
				if (addBrawlProgressItemLayout == null)
				{
					return;
				}
				addBrawlProgressItemLayout.RefreshByData(data3, null, false);
				return;
			}
		}

		// Token: 0x060428FB RID: 272635 RVA: 0x0102D338 File Offset: 0x0102B538
		public List<DangoBrawlProgressItemData> BuildBrawlProgressItemDataList(int totalCount, int currentCount, bool isAdd = false)
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
				list.Add(dangoBrawlProgressItemData);
			}
			return list;
		}

		// Token: 0x060428FC RID: 272636 RVA: 0x0102D382 File Offset: 0x0102B582
		private void OnClickContinue()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager != null)
			{
				battleManager.SetIsLeavingBattle(false);
			}
			base.CloseMe(null);
		}

		// Token: 0x060428FD RID: 272637 RVA: 0x0102D3A4 File Offset: 0x0102B5A4
		private void OnClickReStart()
		{
			if (ActivityDangoBrawlController.Instance.TryLeaveIfActivityClosed())
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoBrawlReStartConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				ActivityDangoBrawlController.Instance.RestartInstanceDungeon(true).Forget();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060428FE RID: 272638 RVA: 0x0102D400 File Offset: 0x0102B600
		private void OnClickExit()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager != null)
			{
				battleManager.SetIsLeavingBattle(true);
			}
			if (battleManager == null)
			{
				return;
			}
			DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
			if (battleFsm == null)
			{
				return;
			}
			battleFsm.ChangeState(EDangoBrawlFsmState.FinalSettle).Then(delegate()
			{
			}).Forget();
		}

		// Token: 0x060428FF RID: 272639 RVA: 0x0102D464 File Offset: 0x0102B664
		private void OnClickSaveExit()
		{
			AfterLeaveInstanceDungeonOpenViewParam openParam = new AfterLeaveInstanceDungeonOpenViewParam
			{
				OpenViewName = EDangoBrawlViewName.MainView
			};
			ActivityDangoBrawlController.Instance.RequestLeaveInstanceDungeon(openParam).Forget<bool>();
		}

		// Token: 0x04022ACD RID: 142029
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> NormalBrawlProgressItemLayout;

		// Token: 0x04022ACE RID: 142030
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRoundAddProgressItem, DangoBrawlProgressItemData> AddBrawlProgressItemLayout;

		// Token: 0x04022ACF RID: 142031
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> NormalBrawlWithAddProgressItemLayout;

		// Token: 0x04022AD0 RID: 142032
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> RetryItemLayout;

		// Token: 0x04022AD1 RID: 142033
		[Nullable(2)]
		private DangoBrawlPauseViewCaptionPanel CaptionPanel;

		// Token: 0x0200C9DA RID: 51674
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CFAF RID: 249775
			BtnExit,
			// Token: 0x0403CFB0 RID: 249776
			BtnRestart,
			// Token: 0x0403CFB1 RID: 249777
			BtnContinue,
			// Token: 0x0403CFB2 RID: 249778
			BtnSaveExit,
			// Token: 0x0403CFB3 RID: 249779
			NormalLayout,
			// Token: 0x0403CFB4 RID: 249780
			NormalItem,
			// Token: 0x0403CFB5 RID: 249781
			AddNode,
			// Token: 0x0403CFB6 RID: 249782
			AddLayout,
			// Token: 0x0403CFB7 RID: 249783
			AddItem,
			// Token: 0x0403CFB8 RID: 249784
			NormalLayoutWithAdd,
			// Token: 0x0403CFB9 RID: 249785
			NormalItemWithAdd,
			// Token: 0x0403CFBA RID: 249786
			RetryItemLayout,
			// Token: 0x0403CFBB RID: 249787
			RetryItem,
			// Token: 0x0403CFBC RID: 249788
			PanelSelf,
			// Token: 0x0403CFBD RID: 249789
			PnlCaption
		}
	}
}
