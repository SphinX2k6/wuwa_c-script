using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005785 RID: 22405
	public class DangoBrawlFailureSettleView : UiViewBase
	{
		// Token: 0x060374B5 RID: 226485 RVA: 0x00F70CCA File Offset: 0x00F6EECA
		[NullableContext(1)]
		public DangoBrawlFailureSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060374B6 RID: 226486 RVA: 0x00F70CD4 File Offset: 0x00F6EED4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnClickBackpackDetail));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action<EToggleState>(this.OnClickAdjustRole));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060374B7 RID: 226487 RVA: 0x00F70ECC File Offset: 0x00F6F0CC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlFailureSettleView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlFailureSettleView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060374B8 RID: 226488 RVA: 0x00F70F0F File Offset: 0x00F6F10F
		protected override void OnStart()
		{
			this.InitLevelInfo();
			this.RefreshInfo();
		}

		// Token: 0x060374B9 RID: 226489 RVA: 0x00F70F1D File Offset: 0x00F6F11D
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			this.PostDefeatedAudio();
		}

		// Token: 0x060374BA RID: 226490 RVA: 0x00F70F2C File Offset: 0x00F6F12C
		private void PostDefeatedAudio()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			int id = (battleManager != null) ? battleManager.GetDangoId(true) : 0;
			DangoBrawlRole? dangoBrawlRole;
			string text = (DangoBrawlConfig.Instance.GetRoleConfigById(id) != null) ? dangoBrawlRole.GetValueOrDefault().AudioSettleDefeated : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			AudioSystem.Instance.PostEvent(text);
		}

		// Token: 0x060374BB RID: 226491 RVA: 0x00F70F8F File Offset: 0x00F6F18F
		protected override void OnBeforeDestroy()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager != null)
			{
				DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
				if (battleFsm != null)
				{
					battleFsm.ChangeState(EDangoBrawlFsmState.GameExit).Forget();
				}
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x060374BC RID: 226492 RVA: 0x00F70FBE File Offset: 0x00F6F1BE
		[NullableContext(1)]
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x060374BD RID: 226493 RVA: 0x00F70FC8 File Offset: 0x00F6F1C8
		private void InitLevelInfo()
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			DangoBrawlInstBaseNotify dangoBrawlInstBaseNotify = (myActivityData != null) ? myActivityData.InstBase : null;
			this.CurrentLevelId = ((dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.ChallengeId : 0);
			this.CurrentRoleId = ((dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.RoleId : 0);
			ActivityDangoBrawlData myActivityData2 = ActivityDangoBrawlController.Instance.MyActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (myActivityData2 != null) ? myActivityData2.GetOutGameData() : null;
			DangoBrawlLevelData dangoBrawlLevelData = (dangoBrawlOutGameData != null) ? dangoBrawlOutGameData.GetLevelData(this.CurrentLevelId) : null;
			this.IsNormalMode = (dangoBrawlLevelData == null || dangoBrawlLevelData.IsNormalMode);
		}

		// Token: 0x060374BE RID: 226494 RVA: 0x00F7104C File Offset: 0x00F6F24C
		private void RefreshInfo()
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			DangoBrawlInstBaseNotify dangoBrawlInstBaseNotify = (myActivityData != null) ? myActivityData.InstBase : null;
			int levelId = (dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.ChallengeId : 0;
			ActivityDangoBrawlData myActivityData2 = ActivityDangoBrawlController.Instance.MyActivityData;
			DangoBrawlOutGameData dangoBrawlOutGameData = (myActivityData2 != null) ? myActivityData2.GetOutGameData() : null;
			object obj = (dangoBrawlOutGameData != null) ? dangoBrawlOutGameData.GetLevelData(levelId) : null;
			int value = (dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.WinCount : 0;
			int usedCount = (dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.LoseCount : 0;
			object obj2 = obj;
			int maxHp = (obj2 != null) ? obj2.MaxRetryCount : 0;
			int value2 = (obj2 != null) ? obj2.WinCount : 0;
			string textStringId = ((obj2 != null) ? obj2.PassConditionDesc : null) ?? "";
			UUIText text = base.GetText(0);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			ValueTuple<string, int> valueTuple = (dangoBrawlOutGameData != null) ? dangoBrawlOutGameData.GetLevelModeInfo(levelId) : new ValueTuple<string, int>("", 0);
			string item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "DangoBrawlBattleUIText_042", new <>z__ReadOnlyArray<object>(new object[]
			{
				item,
				item2
			}));
			GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> heartLayout = this.HeartLayout;
			if (heartLayout != null)
			{
				heartLayout.RefreshByData(DangoBrawlUtil.BuildRetryHeartList(maxHp, usedCount, false), null, false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, Array.Empty<object>());
		}

		// Token: 0x060374BF RID: 226495 RVA: 0x00F711BC File Offset: 0x00F6F3BC
		private void OnClickBack()
		{
			AfterLeaveInstanceDungeonOpenViewParam openParam = new AfterLeaveInstanceDungeonOpenViewParam
			{
				OpenViewName = EDangoBrawlViewName.MainView
			};
			ActivityDangoBrawlController.Instance.RequestLeaveInstanceDungeon(openParam).Forget<bool>();
		}

		// Token: 0x060374C0 RID: 226496 RVA: 0x00F711EC File Offset: 0x00F6F3EC
		private void OnClickRetry()
		{
			if (ActivityDangoBrawlController.Instance.TryLeaveIfActivityClosed())
			{
				return;
			}
			if (this.IsAdjustRoleEnabled)
			{
				AfterLeaveInstanceDungeonOpenViewParam openParam = new AfterLeaveInstanceDungeonOpenViewParam
				{
					OpenViewName = EDangoBrawlViewName.RoleSelectView,
					LevelId = this.CurrentLevelId
				};
				ActivityDangoBrawlController.Instance.RequestLeaveInstanceDungeon(openParam).Forget<bool>();
				return;
			}
			ActivityDangoBrawlController.Instance.RestartInstanceDungeon(false).Forget();
		}

		// Token: 0x060374C1 RID: 226497 RVA: 0x00F7124D File Offset: 0x00F6F44D
		private void OnClickAdjustRole(EToggleState state)
		{
			this.IsAdjustRoleEnabled = (state == EToggleState.ETT_Checked);
		}

		// Token: 0x060374C2 RID: 226498 RVA: 0x00F71259 File Offset: 0x00F6F459
		private void OnClickBackpackDetail(EToggleState state)
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlSettleRoleBagDetailView, null, null);
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401D35B RID: 119643
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> HeartLayout;

		// Token: 0x0401D35C RID: 119644
		[Nullable(2)]
		private DangoBrawlFinalSettleButton BackBtn;

		// Token: 0x0401D35D RID: 119645
		[Nullable(2)]
		private DangoBrawlFinalSettleButton RetryBtn;

		// Token: 0x0401D35E RID: 119646
		private int CurrentLevelId;

		// Token: 0x0401D35F RID: 119647
		private int CurrentRoleId;

		// Token: 0x0401D360 RID: 119648
		private bool IsNormalMode;

		// Token: 0x0401D361 RID: 119649
		private bool IsAdjustRoleEnabled;

		// Token: 0x0200B3C0 RID: 46016
		private enum EComponent
		{
			// Token: 0x04037930 RID: 227632
			TxtNum,
			// Token: 0x04037931 RID: 227633
			PnlHeartLayout,
			// Token: 0x04037932 RID: 227634
			SprHeart,
			// Token: 0x04037933 RID: 227635
			SvInfo,
			// Token: 0x04037934 RID: 227636
			TxtWinConditionDesc,
			// Token: 0x04037935 RID: 227637
			BtnBack,
			// Token: 0x04037936 RID: 227638
			BtnNext,
			// Token: 0x04037937 RID: 227639
			TogDetail,
			// Token: 0x04037938 RID: 227640
			TogTabG,
			// Token: 0x04037939 RID: 227641
			UIView_BrawlSettlementFailure,
			// Token: 0x0403793A RID: 227642
			TxtTitle
		}
	}
}
