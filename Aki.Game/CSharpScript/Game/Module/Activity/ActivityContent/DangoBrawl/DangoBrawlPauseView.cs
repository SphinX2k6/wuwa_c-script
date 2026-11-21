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
	// Token: 0x0200577D RID: 22397
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPauseView : UiViewBase
	{
		// Token: 0x06037445 RID: 226373 RVA: 0x00F6E36E File Offset: 0x00F6C56E
		public DangoBrawlPauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037446 RID: 226374 RVA: 0x00F6E378 File Offset: 0x00F6C578
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

		// Token: 0x06037447 RID: 226375 RVA: 0x00F6E63C File Offset: 0x00F6C83C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPauseView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPauseView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037448 RID: 226376 RVA: 0x00F6E67F File Offset: 0x00F6C87F
		private DangoBrawlProgressItem CreateBrawlProgressItem()
		{
			return new DangoBrawlProgressItem();
		}

		// Token: 0x06037449 RID: 226377 RVA: 0x00F6E686 File Offset: 0x00F6C886
		private DangoBrawlRoundAddProgressItem CreateRoundAddProgressItem()
		{
			return new DangoBrawlRoundAddProgressItem();
		}

		// Token: 0x0603744A RID: 226378 RVA: 0x00F6E68D File Offset: 0x00F6C88D
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x0603744B RID: 226379 RVA: 0x00F6E694 File Offset: 0x00F6C894
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

		// Token: 0x0603744C RID: 226380 RVA: 0x00F6E6C4 File Offset: 0x00F6C8C4
		protected override void OnBeforeShow()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPauseByView(true, "DangoBrawlPauseView");
		}

		// Token: 0x0603744D RID: 226381 RVA: 0x00F6E6E1 File Offset: 0x00F6C8E1
		protected override void OnBeforeHide()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPauseByView(false, "DangoBrawlPauseView");
		}

		// Token: 0x0603744E RID: 226382 RVA: 0x00F6E700 File Offset: 0x00F6C900
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

		// Token: 0x0603744F RID: 226383 RVA: 0x00F6E874 File Offset: 0x00F6CA74
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

		// Token: 0x06037450 RID: 226384 RVA: 0x00F6E8BE File Offset: 0x00F6CABE
		private void OnClickContinue()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager != null)
			{
				battleManager.SetIsLeavingBattle(false);
			}
			base.CloseMe(null);
		}

		// Token: 0x06037451 RID: 226385 RVA: 0x00F6E8E0 File Offset: 0x00F6CAE0
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

		// Token: 0x06037452 RID: 226386 RVA: 0x00F6E93C File Offset: 0x00F6CB3C
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

		// Token: 0x06037453 RID: 226387 RVA: 0x00F6E9A0 File Offset: 0x00F6CBA0
		private void OnClickSaveExit()
		{
			AfterLeaveInstanceDungeonOpenViewParam openParam = new AfterLeaveInstanceDungeonOpenViewParam
			{
				OpenViewName = EDangoBrawlViewName.MainView
			};
			ActivityDangoBrawlController.Instance.RequestLeaveInstanceDungeon(openParam).Forget<bool>();
		}

		// Token: 0x0401D32A RID: 119594
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> NormalBrawlProgressItemLayout;

		// Token: 0x0401D32B RID: 119595
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRoundAddProgressItem, DangoBrawlProgressItemData> AddBrawlProgressItemLayout;

		// Token: 0x0401D32C RID: 119596
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> NormalBrawlWithAddProgressItemLayout;

		// Token: 0x0401D32D RID: 119597
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> RetryItemLayout;

		// Token: 0x0401D32E RID: 119598
		[Nullable(2)]
		private DangoBrawlPauseViewCaptionPanel CaptionPanel;

		// Token: 0x0200B3A6 RID: 45990
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037899 RID: 227481
			BtnExit,
			// Token: 0x0403789A RID: 227482
			BtnRestart,
			// Token: 0x0403789B RID: 227483
			BtnContinue,
			// Token: 0x0403789C RID: 227484
			BtnSaveExit,
			// Token: 0x0403789D RID: 227485
			NormalLayout,
			// Token: 0x0403789E RID: 227486
			NormalItem,
			// Token: 0x0403789F RID: 227487
			AddNode,
			// Token: 0x040378A0 RID: 227488
			AddLayout,
			// Token: 0x040378A1 RID: 227489
			AddItem,
			// Token: 0x040378A2 RID: 227490
			NormalLayoutWithAdd,
			// Token: 0x040378A3 RID: 227491
			NormalItemWithAdd,
			// Token: 0x040378A4 RID: 227492
			RetryItemLayout,
			// Token: 0x040378A5 RID: 227493
			RetryItem,
			// Token: 0x040378A6 RID: 227494
			PanelSelf,
			// Token: 0x040378A7 RID: 227495
			PnlCaption
		}
	}
}
