using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200356E RID: 13678
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTimeDilation : Singleton
	{
		// Token: 0x170048AD RID: 18605
		// (get) Token: 0x06022D1E RID: 142622 RVA: 0x009E3F48 File Offset: 0x009E2148
		// (set) Token: 0x06022D1F RID: 142623 RVA: 0x009E3F50 File Offset: 0x009E2150
		public bool GmSwitch
		{
			get
			{
				return this.GmSwitchInternal;
			}
			set
			{
				this.GmSwitchInternal = value;
			}
		}

		// Token: 0x170048AE RID: 18606
		// (get) Token: 0x06022D20 RID: 142624 RVA: 0x009E3F59 File Offset: 0x009E2159
		private float TimeDilation
		{
			get
			{
				if (this.TimeDilationData == null)
				{
					return 1f;
				}
				return this.TimeDilationData.TimeDilation;
			}
		}

		// Token: 0x170048AF RID: 18607
		// (get) Token: 0x06022D21 RID: 142625 RVA: 0x009E3F74 File Offset: 0x009E2174
		private int ViewId
		{
			get
			{
				if (this.TimeDilationData == null)
				{
					return 0;
				}
				return this.TimeDilationData.ViewId;
			}
		}

		// Token: 0x170048B0 RID: 18608
		// (get) Token: 0x06022D22 RID: 142626 RVA: 0x009E3F8C File Offset: 0x009E218C
		private EUiViewName? DebugName
		{
			get
			{
				UiViewInfoForTimeDilation timeDilationData = this.TimeDilationData;
				if (timeDilationData == null)
				{
					return null;
				}
				return timeDilationData.DebugName;
			}
		}

		// Token: 0x170048B1 RID: 18609
		// (get) Token: 0x06022D23 RID: 142627 RVA: 0x009E3FB2 File Offset: 0x009E21B2
		private string Reason
		{
			get
			{
				if (this.TimeDilationData == null)
				{
					return "UiTimeDilation";
				}
				return this.TimeDilationData.Reason;
			}
		}

		// Token: 0x06022D24 RID: 142628 RVA: 0x009E3FD0 File Offset: 0x009E21D0
		[NullableContext(2)]
		public IUiViewInfoForTimeDilation GetTimeDilationDataCopy()
		{
			if (this.TimeDilationData != null)
			{
				UiViewInfoForTimeDilation uiViewInfoForTimeDilation = new UiViewInfoForTimeDilation();
				uiViewInfoForTimeDilation.TimeDilation = this.TimeDilationData.TimeDilation;
				uiViewInfoForTimeDilation.ViewId = this.TimeDilationData.ViewId;
				uiViewInfoForTimeDilation.DebugName = this.TimeDilationData.DebugName;
				uiViewInfoForTimeDilation.Reason = this.TimeDilationData.Reason;
			}
			return null;
		}

		// Token: 0x06022D25 RID: 142629 RVA: 0x009E4030 File Offset: 0x009E2230
		public void Init()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.SetTimeFlowView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.ResetTimeFlowView));
			EventSystem.Instance.Add(EEventName.ResetModuleAfterResetToBattleView, new Action(this.ResetTimeDilation));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.ResetTimeDilation));
			EventSystem.Instance.Add(EEventName.ChangeMode, new Action(this.ForceResetTimeDilation));
			EventSystem.Instance.Add(EEventName.UpdatePanelQteWorldTimeDilation, new Action<float>(this.UpdatePanelQteTimeDilation));
			EventSystem.Instance.Add(EEventName.ReConnectSuccess, new Action(this.DeleteServerConnectTag));
			EventSystem.Instance.Add<bool, string>(EEventName.OnSequenceCameraStatus, new Action<bool, string>(this.HandleCameraSequenceTag));
			EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.DeleteServerConnectTag));
			EventSystem.Instance.Add(EEventName.OnStartLoadingState, new Action(this.AddLoadingTag));
			EventSystem.Instance.Add(EEventName.OnFinishLoadingState, new Action(this.RemoveLoadingTag));
			EventSystem.Instance.Add(EEventName.AddLevelLoadingTimeDilationTag, new Action(this.AddLevelLoadingTag));
			EventSystem.Instance.Add(EEventName.RemoveLevelLoadingTimeDilationTag, new Action(this.RemoveLevelLoadingTag));
			EventSystem.Instance.Add(EEventName.RogueLevelLoadingLockTimeDilation, new Action(this.AddRogueLevelLoadingTag));
			EventSystem.Instance.Add(EEventName.RogueLevelLoadingUnlockTimeDilation, new Action(this.RemoveRogueLevelLoadingTag));
		}

		// Token: 0x06022D26 RID: 142630 RVA: 0x009E41D8 File Offset: 0x009E23D8
		public void Destroy()
		{
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.SetTimeFlowView));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.ResetTimeFlowView));
			EventSystem.Instance.Remove(EEventName.ResetModuleAfterResetToBattleView, new Action(this.ResetTimeDilation));
			EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.ResetTimeDilation));
			EventSystem.Instance.Remove(EEventName.ChangeMode, new Action(this.ForceResetTimeDilation));
			EventSystem.Instance.Remove(EEventName.UpdatePanelQteWorldTimeDilation, new Action<float>(this.UpdatePanelQteTimeDilation));
			EventSystem.Instance.Remove(EEventName.ReConnectSuccess, new Action(this.DeleteServerConnectTag));
			EventSystem.Instance.Remove(EEventName.OnSequenceCameraStatus, new Action<bool, string>(this.HandleCameraSequenceTag));
			EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.DeleteServerConnectTag));
			EventSystem.Instance.Remove(EEventName.OnStartLoadingState, new Action(this.AddLoadingTag));
			EventSystem.Instance.Remove(EEventName.OnFinishLoadingState, new Action(this.RemoveLoadingTag));
			EventSystem.Instance.Remove(EEventName.AddLevelLoadingTimeDilationTag, new Action(this.AddLevelLoadingTag));
			EventSystem.Instance.Remove(EEventName.RemoveLevelLoadingTimeDilationTag, new Action(this.RemoveLevelLoadingTag));
			EventSystem.Instance.Remove(EEventName.RogueLevelLoadingLockTimeDilation, new Action(this.AddRogueLevelLoadingTag));
			EventSystem.Instance.Remove(EEventName.RogueLevelLoadingUnlockTimeDilation, new Action(this.RemoveRogueLevelLoadingTag));
		}

		// Token: 0x06022D27 RID: 142631 RVA: 0x009E4380 File Offset: 0x009E2580
		private unsafe void PrintDebugReason(float dilation, string debugReason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiTimeDilation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "输出外部调用时停原因";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("原因", debugReason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("是否触发真时停", (double)dilation < 0.0001);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06022D28 RID: 142632 RVA: 0x009E43F4 File Offset: 0x009E25F4
		private unsafe void SaveCacheTimeDilationData(UiViewInfoForTimeDilation viewInfo)
		{
			if (this.CacheTimeDilationData == null || this.CacheTimeDilationData.TimeDilation == 1f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiTimeDilation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "缓存数据添加";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("触发界面", viewInfo.DebugName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("界面Id", viewInfo.ViewId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.CacheTimeDilationData = viewInfo;
			}
		}

		// Token: 0x06022D29 RID: 142633 RVA: 0x009E448C File Offset: 0x009E268C
		private unsafe bool SetGameTimeDilationPrivate(UiViewInfoForTimeDilation viewInfo)
		{
			if (GameModeModel.Instance == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiTimeDilation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "GameModeModel不存在,不允许设置界面时停";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("触发界面", viewInfo.DebugName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("界面Id", viewInfo.ViewId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (this.InMultiplayerWorld())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiTimeDilation;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "联机状态,不允许设置界面时停";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("触发界面", viewInfo.DebugName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("界面Id", viewInfo.ViewId);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			this.TrySetTimeDilation(viewInfo);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.UiTimeDilation;
			ELogAuthor author3 = ELogAuthor.XXJ;
			string message3 = "界面时停设置";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("触发界面", viewInfo.DebugName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("设置流速", viewInfo.TimeDilation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("界面Id", viewInfo.ViewId);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return true;
		}

		// Token: 0x06022D2A RID: 142634 RVA: 0x009E4614 File Offset: 0x009E2814
		private void TrySetTimeDilation(UiViewInfoForTimeDilation viewInfo)
		{
			float timeDilation = viewInfo.TimeDilation;
			this.TimeDilationData = ((timeDilation != 1f) ? viewInfo : null);
			this.PrintDebugReason(timeDilation, viewInfo.Reason);
			if (this.IsHookInHighLevel)
			{
				Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "界面时停被更高级别时停影响，实际未生效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.GmSwitch)
			{
				GameModeController.Instance.SetTimeDilation(timeDilation * this.PanelQteTimeScale, ETimeDilationType.Default);
				return;
			}
			if ((double)timeDilation < 0.0001)
			{
				GameModeController.Instance.SetGamePaused(true, "UiTimeDilation", 1f);
				return;
			}
			GameModeController.Instance.SetGamePaused(false, "UiTimeDilation", timeDilation * this.PanelQteTimeScale);
		}

		// Token: 0x06022D2B RID: 142635 RVA: 0x009E46C8 File Offset: 0x009E28C8
		private void SetTimeFlowView(EUiViewName viewName, int viewId)
		{
			UiViewBase view = UiManager.Instance.GetView(viewId);
			if (view == null)
			{
				return;
			}
			float timeDilation = view.GetTimeDilation();
			this.AddViewData(viewName, viewId, timeDilation);
			if (this.InTimeFlowViewId != null)
			{
				return;
			}
			if (Math.Abs(timeDilation - 1f) < 1E-06f)
			{
				return;
			}
			if (this.SetGameTimeDilation(new UiViewInfoForTimeDilation
			{
				ViewId = viewId,
				TimeDilation = timeDilation,
				DebugName = new EUiViewName?(viewName),
				Reason = "UiTimeDilation"
			}))
			{
				this.InTimeFlowViewId = new int?(viewId);
			}
		}

		// Token: 0x06022D2C RID: 142636 RVA: 0x009E4758 File Offset: 0x009E2958
		public unsafe bool SetGameTimeDilation(UiViewInfoForTimeDilation viewInfo)
		{
			if (!Net.Instance.IsServerConnected())
			{
				this.AddWaitSetTimeDilationTag("ServerConnect");
			}
			if (this.InSnapShotWaitTimeDilation())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiTimeDilation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "指定Plot层级,有需要等待设置时停的tag,不允许设置界面时停";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("触发界面", viewInfo.DebugName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("界面Id", viewInfo.ViewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Tag", this.WaitSetTimeDilationTagSet);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.SnapShotSaveCacheTimeDilationData(viewInfo);
				return false;
			}
			if (this.InWaitTimeDilation())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiTimeDilation;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "有需要等待设置时停的tag,不允许设置界面时停";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("触发界面", viewInfo.DebugName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("界面Id", viewInfo.ViewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Tag", this.WaitSetTimeDilationTagSet);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				this.SaveCacheTimeDilationData(viewInfo);
				return false;
			}
			return this.SetGameTimeDilationPrivate(viewInfo);
		}

		// Token: 0x06022D2D RID: 142637 RVA: 0x009E48BC File Offset: 0x009E2ABC
		private unsafe void ResetTimeFlowView(EUiViewName name, int viewId)
		{
			this.RemoveSnapShopViewData(viewId);
			this.RemoveViewData(viewId);
			int? inTimeFlowViewId;
			if (this.CacheTimeDilationData != null && this.CacheTimeDilationData.ViewId == viewId)
			{
				this.CacheTimeDilationData = null;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiTimeDilation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "缓存的数据清除";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("恢复界面", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("界面Id", viewId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				inTimeFlowViewId = this.InTimeFlowViewId;
				if (inTimeFlowViewId.GetValueOrDefault() == viewId & inTimeFlowViewId != null)
				{
					this.InTimeFlowViewId = null;
				}
				return;
			}
			inTimeFlowViewId = this.InTimeFlowViewId;
			if (!(viewId == inTimeFlowViewId.GetValueOrDefault() & inTimeFlowViewId != null))
			{
				return;
			}
			if (this.SetGameTimeDilation(new UiViewInfoForTimeDilation
			{
				ViewId = viewId,
				TimeDilation = 1f,
				DebugName = new EUiViewName?(name),
				Reason = "UiTimeDilation"
			}))
			{
				this.InTimeFlowViewId = null;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiTimeDilation;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "界面时停恢复";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("恢复界面", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("界面Id", viewId);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				this.SetNextViewTimeDilation();
			}
		}

		// Token: 0x06022D2E RID: 142638 RVA: 0x009E4A48 File Offset: 0x009E2C48
		private void ResetTimeDilation()
		{
			if (GameModeModel.Instance == null)
			{
				return;
			}
			if (this.InMultiplayerWorld())
			{
				return;
			}
			if (!Net.Instance.IsServerConnected())
			{
				return;
			}
			this.ForceResetTimeDilation();
		}

		// Token: 0x06022D2F RID: 142639 RVA: 0x009E4A70 File Offset: 0x009E2C70
		private void ForceResetTimeDilation()
		{
			this.TimeDilationData = null;
			Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "时停强制重置为1", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!this.GmSwitch)
			{
				GameModeController.Instance.SetGamePaused(false, "UiTimeDilation", 1f);
			}
			else
			{
				GameModeController.Instance.SetTimeDilation(1f, ETimeDilationType.Default);
			}
			this.CacheTimeDilationData = null;
			this.InTimeFlowViewId = null;
			this.SnapShotData = null;
		}

		// Token: 0x06022D30 RID: 142640 RVA: 0x009E4AED File Offset: 0x009E2CED
		private bool InMultiplayerWorld()
		{
			return GameModeModel.Instance != null && GameModeModel.Instance.IsMulti;
		}

		// Token: 0x06022D31 RID: 142641 RVA: 0x009E4B04 File Offset: 0x009E2D04
		public unsafe void SetTimeDilationHighLevel(float timeDilation, string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiTimeDilation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "设置高级别时停";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("时停参数", timeDilation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.IsHookInHighLevel = true;
			if (this.GmSwitch)
			{
				GameModeController.Instance.SetTimeDilation(timeDilation, ETimeDilationType.Default);
				return;
			}
			if ((double)timeDilation < 0.0001)
			{
				GameModeController.Instance.SetGamePaused(true, reason, 1f);
				return;
			}
			GameModeController.Instance.SetGamePaused(false, "UiTimeDilation", timeDilation);
		}

		// Token: 0x170048B2 RID: 18610
		// (get) Token: 0x06022D32 RID: 142642 RVA: 0x009E4BBA File Offset: 0x009E2DBA
		private bool IsUiTimeDilationGamePause
		{
			get
			{
				return this.TimeDilationData != null && (double)this.TimeDilationData.TimeDilation < 0.0001;
			}
		}

		// Token: 0x170048B3 RID: 18611
		// (get) Token: 0x06022D33 RID: 142643 RVA: 0x009E4BDD File Offset: 0x009E2DDD
		public bool IsUiTimeDilated
		{
			get
			{
				return this.TimeDilationData != null && this.TimeDilationData.TimeDilation < 1f;
			}
		}

		// Token: 0x06022D34 RID: 142644 RVA: 0x009E4BFC File Offset: 0x009E2DFC
		public void ResetTimeDilationHighLevel(string reason)
		{
			Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "恢复高级别时停", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsHookInHighLevel = false;
			GameModeController.Instance.SetGamePaused(this.IsUiTimeDilationGamePause, "UiTimeDilation", 1f);
			float timeDilation = this.TimeDilation;
			if (this.GmSwitch)
			{
				GameModeController.Instance.SetTimeDilation(timeDilation, ETimeDilationType.Default);
				return;
			}
			if ((double)timeDilation < 0.0001)
			{
				GameModeController.Instance.SetGamePaused(false, reason, 1f);
				return;
			}
			GameModeController.Instance.SetGamePaused(false, reason, timeDilation);
		}

		// Token: 0x06022D35 RID: 142645 RVA: 0x009E4C94 File Offset: 0x009E2E94
		private void UpdatePanelQteTimeDilation(float scale)
		{
			if (this.PanelQteTimeScale == scale)
			{
				return;
			}
			this.PanelQteTimeScale = scale;
			if (this.TimeDilation != 0f)
			{
				UiViewInfoForTimeDilation uiViewInfoForTimeDilation;
				if ((uiViewInfoForTimeDilation = this.TimeDilationData) == null)
				{
					UiViewInfoForTimeDilation uiViewInfoForTimeDilation2 = new UiViewInfoForTimeDilation();
					uiViewInfoForTimeDilation2.ViewId = this.ViewId;
					uiViewInfoForTimeDilation2.TimeDilation = this.TimeDilation;
					uiViewInfoForTimeDilation2.DebugName = this.DebugName;
					uiViewInfoForTimeDilation = uiViewInfoForTimeDilation2;
					uiViewInfoForTimeDilation2.Reason = this.Reason;
				}
				UiViewInfoForTimeDilation viewInfo = uiViewInfoForTimeDilation;
				this.TrySetTimeDilation(viewInfo);
			}
		}

		// Token: 0x06022D36 RID: 142646 RVA: 0x009E4D06 File Offset: 0x009E2F06
		private void DeleteServerConnectTag()
		{
			this.DeleteWaitSetTimeDilationTag("ServerConnect");
		}

		// Token: 0x06022D37 RID: 142647 RVA: 0x009E4D13 File Offset: 0x009E2F13
		private void HandleCameraSequenceTag(bool bInCameraSequence, string cameraName)
		{
			if (cameraName != "MainCamera")
			{
				return;
			}
			if (bInCameraSequence)
			{
				this.AddWaitSetTimeDilationTag("CameraSequence");
				return;
			}
			this.DeleteWaitSetTimeDilationTag("CameraSequence");
		}

		// Token: 0x06022D38 RID: 142648 RVA: 0x009E4D3D File Offset: 0x009E2F3D
		private void AddLoadingTag()
		{
			this.AddWaitSetTimeDilationTag("Loading");
		}

		// Token: 0x06022D39 RID: 142649 RVA: 0x009E4D4A File Offset: 0x009E2F4A
		private void RemoveLoadingTag()
		{
			this.DeleteWaitSetTimeDilationTag("Loading");
		}

		// Token: 0x06022D3A RID: 142650 RVA: 0x009E4D57 File Offset: 0x009E2F57
		private void AddLevelLoadingTag()
		{
			this.AddWaitSetTimeDilationTag("LevelLoading");
		}

		// Token: 0x06022D3B RID: 142651 RVA: 0x009E4D64 File Offset: 0x009E2F64
		private void RemoveLevelLoadingTag()
		{
			this.DeleteWaitSetTimeDilationTag("LevelLoading");
		}

		// Token: 0x06022D3C RID: 142652 RVA: 0x009E4D71 File Offset: 0x009E2F71
		private void AddRogueLevelLoadingTag()
		{
			this.AddWaitSetTimeDilationTag("RogueLevelLoading");
		}

		// Token: 0x06022D3D RID: 142653 RVA: 0x009E4D7E File Offset: 0x009E2F7E
		private void RemoveRogueLevelLoadingTag()
		{
			this.DeleteWaitSetTimeDilationTag("RogueLevelLoading");
		}

		// Token: 0x06022D3E RID: 142654 RVA: 0x009E4D8C File Offset: 0x009E2F8C
		public void AddViewData(EUiViewName name, int viewId, float timeDilation)
		{
			if (timeDilation < 1f)
			{
				this.ViewIdList.Add(viewId);
				this.TimeDilationMap[viewId] = new UiViewInfoForTimeDilation
				{
					ViewId = viewId,
					TimeDilation = timeDilation,
					DebugName = new EUiViewName?(name),
					Reason = "UiTimeDilation"
				};
			}
		}

		// Token: 0x06022D3F RID: 142655 RVA: 0x009E4DE4 File Offset: 0x009E2FE4
		public void RemoveViewData(int viewId)
		{
			if (this.TimeDilationMap.Remove(viewId))
			{
				int num = this.ViewIdList.IndexOf(viewId);
				if (num >= 0)
				{
					this.ViewIdList.RemoveAt(num);
				}
			}
		}

		// Token: 0x06022D40 RID: 142656 RVA: 0x009E4E1C File Offset: 0x009E301C
		public unsafe void SetNextViewTimeDilation()
		{
			if (this.ViewIdList.Count == 0)
			{
				return;
			}
			int num = this.ViewIdList[0];
			this.ViewIdList.RemoveAt(0);
			if (num == 0)
			{
				return;
			}
			UiViewInfoForTimeDilation uiViewInfoForTimeDilation = null;
			this.TimeDilationMap.TryGetValue(num, out uiViewInfoForTimeDilation);
			if (uiViewInfoForTimeDilation != null && this.SetGameTimeDilation(uiViewInfoForTimeDilation))
			{
				this.InTimeFlowViewId = new int?(num);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiTimeDilation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "界面时停设置下个数据";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("界面", uiViewInfoForTimeDilation.DebugName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("界面Id", num);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06022D41 RID: 142657 RVA: 0x009E4EE4 File Offset: 0x009E30E4
		public void AddWaitSetTimeDilationTag(string tag)
		{
			if (this.SnapShotData != null)
			{
				this.SnapShotData.WaitSetTimeDilationTagSet.Add(tag);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiTimeDilation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "指定Plot层级,添加等待设置时停的tag";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				this.WaitSetTimeDilationTagSet.Add(tag);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiTimeDilation;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "添加等待设置时停的tag";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Tag", tag);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			if (this.TimeDilationData == null)
			{
				return;
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.UiTimeDilation;
			ELogAuthor author3 = ELogAuthor.XXJ;
			string message3 = "目前存在界面正在时停中,缓存并且临时恢复";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Tag", tag);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			this.SaveCacheTimeDilationData(this.TimeDilationData);
			this.SetGameTimeDilationPrivate(new UiViewInfoForTimeDilation
			{
				ViewId = this.TimeDilationData.ViewId,
				TimeDilation = 1f,
				DebugName = this.TimeDilationData.DebugName,
				Reason = this.TimeDilationData.Reason
			});
		}

		// Token: 0x06022D42 RID: 142658 RVA: 0x009E4FF8 File Offset: 0x009E31F8
		public void DeleteWaitSetTimeDilationTag(string tag)
		{
			if (this.SnapShotData != null)
			{
				if (this.SnapShotData.CacheTimeDilationTagSet.Contains(tag))
				{
					if (this.SnapShotData.CacheTimeDilationTagSet.Remove(tag))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.UiTimeDilation;
						ELogAuthor author = ELogAuthor.XXJ;
						string message = "指定Plot层级,缓存数据中删除等待设置时停的tag";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
						instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
				else if (this.SnapShotData.WaitSetTimeDilationTagSet.Remove(tag))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiTimeDilation;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "指定Plot层级,删除等待设置时停的tag";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Tag", tag);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				this.SnapShotData.WaitSetTimeDilationTagSet.Remove(tag);
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiTimeDilation;
				ELogAuthor author3 = ELogAuthor.XXJ;
				string message3 = "指定Plot层级,删除等待设置时停的tag";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Tag", tag);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
			else if (this.WaitSetTimeDilationTagSet.Remove(tag))
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.UiTimeDilation;
				ELogAuthor author4 = ELogAuthor.XXJ;
				string message4 = "删除等待设置时停的tag";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("Tag", tag);
				instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			}
			this.TriggerCacheTimeDilationData();
		}

		// Token: 0x06022D43 RID: 142659 RVA: 0x009E511B File Offset: 0x009E331B
		private bool InWaitTimeDilation()
		{
			return this.WaitSetTimeDilationTagSet.Count > 0;
		}

		// Token: 0x06022D44 RID: 142660 RVA: 0x009E512C File Offset: 0x009E332C
		private unsafe void TriggerCacheTimeDilationData()
		{
			if (this.CacheTimeDilationData == null)
			{
				return;
			}
			if (this.InTimeFlowViewId != null)
			{
				int? inTimeFlowViewId = this.InTimeFlowViewId;
				int viewId = this.CacheTimeDilationData.ViewId;
				if (!(inTimeFlowViewId.GetValueOrDefault() == viewId & inTimeFlowViewId != null))
				{
					this.CacheTimeDilationData = null;
					return;
				}
			}
			if (this.SetGameTimeDilation(this.CacheTimeDilationData))
			{
				this.InTimeFlowViewId = new int?(this.CacheTimeDilationData.ViewId);
				EUiViewName? debugName = this.CacheTimeDilationData.DebugName;
				this.CacheTimeDilationData = null;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiTimeDilation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "缓存数据设置成功";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("界面", debugName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("界面Id", this.InTimeFlowViewId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06022D45 RID: 142661 RVA: 0x009E521D File Offset: 0x009E341D
		private void ClearCurrentData()
		{
			this.InTimeFlowViewId = null;
			this.CacheTimeDilationData = null;
			this.TimeDilationData = null;
			this.TimeDilationMap = new Dictionary<int, UiViewInfoForTimeDilation>();
			this.ViewIdList = new List<int>();
			this.WaitSetTimeDilationTagSet = new HashSet<string>();
		}

		// Token: 0x06022D46 RID: 142662 RVA: 0x009E525C File Offset: 0x009E345C
		private void CreateSnapShotData()
		{
			if (this.SnapShotData != null)
			{
				return;
			}
			this.SnapShotData = new SnapshotData();
			this.SnapShotData.InTimeFlowViewId = this.InTimeFlowViewId;
			this.SnapShotData.CacheTimeDilationData = this.CacheTimeDilationData;
			this.SnapShotData.TimeDilationData = this.TimeDilationData;
			this.SnapShotData.TimeDilationMap = this.TimeDilationMap;
			this.SnapShotData.ViewIdList = this.ViewIdList;
			this.SnapShotData.CacheTimeDilationTagSet = this.WaitSetTimeDilationTagSet;
		}

		// Token: 0x06022D47 RID: 142663 RVA: 0x009E52E4 File Offset: 0x009E34E4
		private void RestoreSnapShotData()
		{
			if (this.SnapShotData != null)
			{
				if (this.SnapShotData.InTimeFlowViewId != null)
				{
					this.InTimeFlowViewId = this.SnapShotData.InTimeFlowViewId;
				}
				this.CacheTimeDilationData = this.SnapShotData.CacheTimeDilationData;
				this.TimeDilationData = this.SnapShotData.TimeDilationData;
				this.TimeDilationMap = this.SnapShotData.TimeDilationMap;
				this.ViewIdList = this.SnapShotData.ViewIdList;
				this.WaitSetTimeDilationTagSet = this.SnapShotData.CacheTimeDilationTagSet;
				this.SnapShotData = null;
			}
		}

		// Token: 0x06022D48 RID: 142664 RVA: 0x009E5378 File Offset: 0x009E3578
		private void RemoveSnapShopViewData(int viewId)
		{
			if (this.SnapShotData == null)
			{
				return;
			}
			if (this.SnapShotData.TimeDilationMap.Remove(viewId))
			{
				int num = this.SnapShotData.ViewIdList.IndexOf(viewId);
				if (num >= 0)
				{
					this.SnapShotData.ViewIdList.RemoveAt(num);
					Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "时停数据快照期间时停集合数据被删除", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			if (this.SnapShotData.CacheTimeDilationData != null && this.SnapShotData.CacheTimeDilationData.ViewId == viewId)
			{
				Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "时停数据快照期间时停缓存时停数据被删除", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.SnapShotData.CacheTimeDilationData = null;
			}
			int? inTimeFlowViewId = this.SnapShotData.InTimeFlowViewId;
			if (inTimeFlowViewId.GetValueOrDefault() == viewId & inTimeFlowViewId != null)
			{
				Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "时停数据快照期间第一个触发时停界面数据被删除", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.SnapShotData.TimeDilationData = null;
				this.SnapShotData.InTimeFlowViewId = null;
			}
		}

		// Token: 0x06022D49 RID: 142665 RVA: 0x009E5490 File Offset: 0x009E3690
		public void TemporarySaveData()
		{
			Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "[OpenView]指定Plot层级打开界面,临时进行数据快照,重置时停表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CreateSnapShotData();
			this.ClearCurrentData();
			GameModeController.Instance.SetGamePaused(false, "UiTimeDilation", 1f);
		}

		// Token: 0x06022D4A RID: 142666 RVA: 0x009E54E0 File Offset: 0x009E36E0
		public void RestoreSaveData()
		{
			Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "[CloseView]指定Plot层级关闭界面,还原数据快照,设置时停表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RestoreSnapShotData();
			if (this.TimeDilationData != null)
			{
				this.SetGameTimeDilation(this.TimeDilationData);
			}
		}

		// Token: 0x06022D4B RID: 142667 RVA: 0x009E5527 File Offset: 0x009E3727
		private bool InSnapShotWaitTimeDilation()
		{
			return this.SnapShotData != null && this.SnapShotData.WaitSetTimeDilationTagSet.Count > 0;
		}

		// Token: 0x06022D4C RID: 142668 RVA: 0x009E5548 File Offset: 0x009E3748
		private unsafe void SnapShotSaveCacheTimeDilationData(UiViewInfoForTimeDilation viewInfo)
		{
			if (this.SnapShotData == null)
			{
				return;
			}
			if (this.SnapShotData.CacheTimeDilationData == null || this.SnapShotData.CacheTimeDilationData.TimeDilation == 1f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiTimeDilation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "指定Plot层级,缓存数据添加";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("触发界面", viewInfo.DebugName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("界面Id", viewInfo.ViewId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.CacheTimeDilationData = viewInfo;
			}
		}

		// Token: 0x170048B4 RID: 18612
		// (get) Token: 0x06022D4D RID: 142669 RVA: 0x009E55F3 File Offset: 0x009E37F3
		public static UiTimeDilation Instance
		{
			get
			{
				if (UiTimeDilation._instance == null)
				{
					UiTimeDilation._instance = new UiTimeDilation();
					UiTimeDilation._instance.OnInit();
				}
				return UiTimeDilation._instance;
			}
		}

		// Token: 0x06022D4E RID: 142670 RVA: 0x009E5616 File Offset: 0x009E3816
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022D4F RID: 142671 RVA: 0x009E5618 File Offset: 0x009E3818
		public static void ResetStaticDefaultValue()
		{
			UiTimeDilation instance = UiTimeDilation._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiTimeDilation._instance = null;
		}

		// Token: 0x06022D50 RID: 142672 RVA: 0x009E5631 File Offset: 0x009E3831
		static UiTimeDilation()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiTimeDilation.CreateStaticDefaultValue), new Action(UiTimeDilation.ResetStaticDefaultValue));
		}

		// Token: 0x04013400 RID: 78848
		public bool Enable = true;

		// Token: 0x04013401 RID: 78849
		private bool GmSwitchInternal;

		// Token: 0x04013402 RID: 78850
		private int? InTimeFlowViewId;

		// Token: 0x04013403 RID: 78851
		private bool IsHookInHighLevel;

		// Token: 0x04013404 RID: 78852
		[Nullable(2)]
		private UiViewInfoForTimeDilation CacheTimeDilationData;

		// Token: 0x04013405 RID: 78853
		[Nullable(2)]
		private UiViewInfoForTimeDilation TimeDilationData;

		// Token: 0x04013406 RID: 78854
		private float PanelQteTimeScale = 1f;

		// Token: 0x04013407 RID: 78855
		[Nullable(2)]
		private SnapshotData SnapShotData;

		// Token: 0x04013408 RID: 78856
		private List<int> ViewIdList = new List<int>();

		// Token: 0x04013409 RID: 78857
		private Dictionary<int, UiViewInfoForTimeDilation> TimeDilationMap = new Dictionary<int, UiViewInfoForTimeDilation>();

		// Token: 0x0401340A RID: 78858
		private HashSet<string> WaitSetTimeDilationTagSet = new HashSet<string>();

		// Token: 0x0401340B RID: 78859
		[Nullable(2)]
		private static UiTimeDilation _instance;
	}
}
