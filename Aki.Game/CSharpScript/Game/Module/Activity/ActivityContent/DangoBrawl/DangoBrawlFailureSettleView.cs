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
	// Token: 0x02006835 RID: 26677
	public class DangoBrawlFailureSettleView : UiViewBase
	{
		// Token: 0x06042961 RID: 272737 RVA: 0x0102F7BE File Offset: 0x0102D9BE
		[NullableContext(1)]
		public DangoBrawlFailureSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042962 RID: 272738 RVA: 0x0102F7C8 File Offset: 0x0102D9C8
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

		// Token: 0x06042963 RID: 272739 RVA: 0x0102F9C0 File Offset: 0x0102DBC0
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlFailureSettleView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlFailureSettleView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042964 RID: 272740 RVA: 0x0102FA03 File Offset: 0x0102DC03
		protected override void OnStart()
		{
			this.InitLevelInfo();
			this.RefreshInfo();
		}

		// Token: 0x06042965 RID: 272741 RVA: 0x0102FA11 File Offset: 0x0102DC11
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			this.PostDefeatedAudio();
		}

		// Token: 0x06042966 RID: 272742 RVA: 0x0102FA20 File Offset: 0x0102DC20
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

		// Token: 0x06042967 RID: 272743 RVA: 0x0102FA83 File Offset: 0x0102DC83
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

		// Token: 0x06042968 RID: 272744 RVA: 0x0102FAB2 File Offset: 0x0102DCB2
		[NullableContext(1)]
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x06042969 RID: 272745 RVA: 0x0102FABC File Offset: 0x0102DCBC
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

		// Token: 0x0604296A RID: 272746 RVA: 0x0102FB40 File Offset: 0x0102DD40
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

		// Token: 0x0604296B RID: 272747 RVA: 0x0102FCB0 File Offset: 0x0102DEB0
		private void OnClickBack()
		{
			AfterLeaveInstanceDungeonOpenViewParam openParam = new AfterLeaveInstanceDungeonOpenViewParam
			{
				OpenViewName = EDangoBrawlViewName.MainView
			};
			ActivityDangoBrawlController.Instance.RequestLeaveInstanceDungeon(openParam).Forget<bool>();
		}

		// Token: 0x0604296C RID: 272748 RVA: 0x0102FCE0 File Offset: 0x0102DEE0
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

		// Token: 0x0604296D RID: 272749 RVA: 0x0102FD41 File Offset: 0x0102DF41
		private void OnClickAdjustRole(EToggleState state)
		{
			this.IsAdjustRoleEnabled = (state == EToggleState.ETT_Checked);
		}

		// Token: 0x0604296E RID: 272750 RVA: 0x0102FD4D File Offset: 0x0102DF4D
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

		// Token: 0x04022AFE RID: 142078
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> HeartLayout;

		// Token: 0x04022AFF RID: 142079
		[Nullable(2)]
		private DangoBrawlFinalSettleButton BackBtn;

		// Token: 0x04022B00 RID: 142080
		[Nullable(2)]
		private DangoBrawlFinalSettleButton RetryBtn;

		// Token: 0x04022B01 RID: 142081
		private int CurrentLevelId;

		// Token: 0x04022B02 RID: 142082
		private int CurrentRoleId;

		// Token: 0x04022B03 RID: 142083
		private bool IsNormalMode;

		// Token: 0x04022B04 RID: 142084
		private bool IsAdjustRoleEnabled;

		// Token: 0x0200C9F4 RID: 51700
		private enum EComponent
		{
			// Token: 0x0403D047 RID: 249927
			TxtNum,
			// Token: 0x0403D048 RID: 249928
			PnlHeartLayout,
			// Token: 0x0403D049 RID: 249929
			SprHeart,
			// Token: 0x0403D04A RID: 249930
			SvInfo,
			// Token: 0x0403D04B RID: 249931
			TxtWinConditionDesc,
			// Token: 0x0403D04C RID: 249932
			BtnBack,
			// Token: 0x0403D04D RID: 249933
			BtnNext,
			// Token: 0x0403D04E RID: 249934
			TogDetail,
			// Token: 0x0403D04F RID: 249935
			TogTabG,
			// Token: 0x0403D050 RID: 249936
			UIView_BrawlSettlementFailure,
			// Token: 0x0403D051 RID: 249937
			TxtTitle
		}
	}
}
