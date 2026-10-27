using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200463D RID: 17981
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTimeDilation : Singleton
	{
		// Token: 0x170075F1 RID: 30193
		// (get) Token: 0x0602E5D4 RID: 189908 RVA: 0x00AB6908 File Offset: 0x00AB4B08
		// (set) Token: 0x0602E5D5 RID: 189909 RVA: 0x00AB6910 File Offset: 0x00AB4B10
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

		// Token: 0x170075F2 RID: 30194
		// (get) Token: 0x0602E5D6 RID: 189910 RVA: 0x00AB6919 File Offset: 0x00AB4B19
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

		// Token: 0x170075F3 RID: 30195
		// (get) Token: 0x0602E5D7 RID: 189911 RVA: 0x00AB6934 File Offset: 0x00AB4B34
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

		// Token: 0x170075F4 RID: 30196
		// (get) Token: 0x0602E5D8 RID: 189912 RVA: 0x00AB694C File Offset: 0x00AB4B4C
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

		// Token: 0x170075F5 RID: 30197
		// (get) Token: 0x0602E5D9 RID: 189913 RVA: 0x00AB6972 File Offset: 0x00AB4B72
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

		// Token: 0x0602E5DA RID: 189914 RVA: 0x00AB6990 File Offset: 0x00AB4B90
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

		// Token: 0x0602E5DB RID: 189915 RVA: 0x00AB69F0 File Offset: 0x00AB4BF0
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

		// Token: 0x0602E5DC RID: 189916 RVA: 0x00AB6B98 File Offset: 0x00AB4D98
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

		// Token: 0x0602E5DD RID: 189917 RVA: 0x00AB6D40 File Offset: 0x00AB4F40
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

		// Token: 0x0602E5DE RID: 189918 RVA: 0x00AB6DB4 File Offset: 0x00AB4FB4
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

		// Token: 0x0602E5DF RID: 189919 RVA: 0x00AB6E4C File Offset: 0x00AB504C
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

		// Token: 0x0602E5E0 RID: 189920 RVA: 0x00AB6FD4 File Offset: 0x00AB51D4
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

		// Token: 0x0602E5E1 RID: 189921 RVA: 0x00AB7088 File Offset: 0x00AB5288
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

		// Token: 0x0602E5E2 RID: 189922 RVA: 0x00AB7118 File Offset: 0x00AB5318
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

		// Token: 0x0602E5E3 RID: 189923 RVA: 0x00AB727C File Offset: 0x00AB547C
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

		// Token: 0x0602E5E4 RID: 189924 RVA: 0x00AB7408 File Offset: 0x00AB5608
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

		// Token: 0x0602E5E5 RID: 189925 RVA: 0x00AB7430 File Offset: 0x00AB5630
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

		// Token: 0x0602E5E6 RID: 189926 RVA: 0x00AB74AD File Offset: 0x00AB56AD
		private bool InMultiplayerWorld()
		{
			return GameModeModel.Instance != null && GameModeModel.Instance.IsMulti;
		}

		// Token: 0x0602E5E7 RID: 189927 RVA: 0x00AB74C4 File Offset: 0x00AB56C4
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

		// Token: 0x170075F6 RID: 30198
		// (get) Token: 0x0602E5E8 RID: 189928 RVA: 0x00AB757A File Offset: 0x00AB577A
		private bool IsUiTimeDilationGamePause
		{
			get
			{
				return this.TimeDilationData != null && (double)this.TimeDilationData.TimeDilation < 0.0001;
			}
		}

		// Token: 0x170075F7 RID: 30199
		// (get) Token: 0x0602E5E9 RID: 189929 RVA: 0x00AB759D File Offset: 0x00AB579D
		public bool IsUiTimeDilated
		{
			get
			{
				return this.TimeDilationData != null && this.TimeDilationData.TimeDilation < 1f;
			}
		}

		// Token: 0x0602E5EA RID: 189930 RVA: 0x00AB75BC File Offset: 0x00AB57BC
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

		// Token: 0x0602E5EB RID: 189931 RVA: 0x00AB7654 File Offset: 0x00AB5854
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

		// Token: 0x0602E5EC RID: 189932 RVA: 0x00AB76C6 File Offset: 0x00AB58C6
		private void DeleteServerConnectTag()
		{
			this.DeleteWaitSetTimeDilationTag("ServerConnect");
		}

		// Token: 0x0602E5ED RID: 189933 RVA: 0x00AB76D3 File Offset: 0x00AB58D3
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

		// Token: 0x0602E5EE RID: 189934 RVA: 0x00AB76FD File Offset: 0x00AB58FD
		private void AddLoadingTag()
		{
			this.AddWaitSetTimeDilationTag("Loading");
		}

		// Token: 0x0602E5EF RID: 189935 RVA: 0x00AB770A File Offset: 0x00AB590A
		private void RemoveLoadingTag()
		{
			this.DeleteWaitSetTimeDilationTag("Loading");
		}

		// Token: 0x0602E5F0 RID: 189936 RVA: 0x00AB7717 File Offset: 0x00AB5917
		private void AddLevelLoadingTag()
		{
			this.AddWaitSetTimeDilationTag("LevelLoading");
		}

		// Token: 0x0602E5F1 RID: 189937 RVA: 0x00AB7724 File Offset: 0x00AB5924
		private void RemoveLevelLoadingTag()
		{
			this.DeleteWaitSetTimeDilationTag("LevelLoading");
		}

		// Token: 0x0602E5F2 RID: 189938 RVA: 0x00AB7731 File Offset: 0x00AB5931
		private void AddRogueLevelLoadingTag()
		{
			this.AddWaitSetTimeDilationTag("RogueLevelLoading");
		}

		// Token: 0x0602E5F3 RID: 189939 RVA: 0x00AB773E File Offset: 0x00AB593E
		private void RemoveRogueLevelLoadingTag()
		{
			this.DeleteWaitSetTimeDilationTag("RogueLevelLoading");
		}

		// Token: 0x0602E5F4 RID: 189940 RVA: 0x00AB774C File Offset: 0x00AB594C
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

		// Token: 0x0602E5F5 RID: 189941 RVA: 0x00AB77A4 File Offset: 0x00AB59A4
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

		// Token: 0x0602E5F6 RID: 189942 RVA: 0x00AB77DC File Offset: 0x00AB59DC
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

		// Token: 0x0602E5F7 RID: 189943 RVA: 0x00AB78A4 File Offset: 0x00AB5AA4
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

		// Token: 0x0602E5F8 RID: 189944 RVA: 0x00AB79B8 File Offset: 0x00AB5BB8
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

		// Token: 0x0602E5F9 RID: 189945 RVA: 0x00AB7ADB File Offset: 0x00AB5CDB
		private bool InWaitTimeDilation()
		{
			return this.WaitSetTimeDilationTagSet.Count > 0;
		}

		// Token: 0x0602E5FA RID: 189946 RVA: 0x00AB7AEC File Offset: 0x00AB5CEC
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

		// Token: 0x0602E5FB RID: 189947 RVA: 0x00AB7BDD File Offset: 0x00AB5DDD
		private void ClearCurrentData()
		{
			this.InTimeFlowViewId = null;
			this.CacheTimeDilationData = null;
			this.TimeDilationData = null;
			this.TimeDilationMap = new Dictionary<int, UiViewInfoForTimeDilation>();
			this.ViewIdList = new List<int>();
			this.WaitSetTimeDilationTagSet = new HashSet<string>();
		}

		// Token: 0x0602E5FC RID: 189948 RVA: 0x00AB7C1C File Offset: 0x00AB5E1C
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

		// Token: 0x0602E5FD RID: 189949 RVA: 0x00AB7CA4 File Offset: 0x00AB5EA4
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

		// Token: 0x0602E5FE RID: 189950 RVA: 0x00AB7D38 File Offset: 0x00AB5F38
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

		// Token: 0x0602E5FF RID: 189951 RVA: 0x00AB7E50 File Offset: 0x00AB6050
		public void TemporarySaveData()
		{
			Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "[OpenView]指定Plot层级打开界面,临时进行数据快照,重置时停表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CreateSnapShotData();
			this.ClearCurrentData();
			GameModeController.Instance.SetGamePaused(false, "UiTimeDilation", 1f);
		}

		// Token: 0x0602E600 RID: 189952 RVA: 0x00AB7EA0 File Offset: 0x00AB60A0
		public void RestoreSaveData()
		{
			Log.Instance.Info(ELogModule.UiTimeDilation, ELogAuthor.XXJ, "[CloseView]指定Plot层级关闭界面,还原数据快照,设置时停表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RestoreSnapShotData();
			if (this.TimeDilationData != null)
			{
				this.SetGameTimeDilation(this.TimeDilationData);
			}
		}

		// Token: 0x0602E601 RID: 189953 RVA: 0x00AB7EE7 File Offset: 0x00AB60E7
		private bool InSnapShotWaitTimeDilation()
		{
			return this.SnapShotData != null && this.SnapShotData.WaitSetTimeDilationTagSet.Count > 0;
		}

		// Token: 0x0602E602 RID: 189954 RVA: 0x00AB7F08 File Offset: 0x00AB6108
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

		// Token: 0x170075F8 RID: 30200
		// (get) Token: 0x0602E603 RID: 189955 RVA: 0x00AB7FB3 File Offset: 0x00AB61B3
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

		// Token: 0x0602E604 RID: 189956 RVA: 0x00AB7FD6 File Offset: 0x00AB61D6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E605 RID: 189957 RVA: 0x00AB7FD8 File Offset: 0x00AB61D8
		public static void ResetStaticDefaultValue()
		{
			UiTimeDilation instance = UiTimeDilation._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiTimeDilation._instance = null;
		}

		// Token: 0x0602E606 RID: 189958 RVA: 0x00AB7FF1 File Offset: 0x00AB61F1
		static UiTimeDilation()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiTimeDilation.CreateStaticDefaultValue), new Action(UiTimeDilation.ResetStaticDefaultValue));
		}

		// Token: 0x04018DA7 RID: 101799
		public bool Enable = true;

		// Token: 0x04018DA8 RID: 101800
		private bool GmSwitchInternal;

		// Token: 0x04018DA9 RID: 101801
		private int? InTimeFlowViewId;

		// Token: 0x04018DAA RID: 101802
		private bool IsHookInHighLevel;

		// Token: 0x04018DAB RID: 101803
		[Nullable(2)]
		private UiViewInfoForTimeDilation CacheTimeDilationData;

		// Token: 0x04018DAC RID: 101804
		[Nullable(2)]
		private UiViewInfoForTimeDilation TimeDilationData;

		// Token: 0x04018DAD RID: 101805
		private float PanelQteTimeScale = 1f;

		// Token: 0x04018DAE RID: 101806
		[Nullable(2)]
		private SnapshotData SnapShotData;

		// Token: 0x04018DAF RID: 101807
		private List<int> ViewIdList = new List<int>();

		// Token: 0x04018DB0 RID: 101808
		private Dictionary<int, UiViewInfoForTimeDilation> TimeDilationMap = new Dictionary<int, UiViewInfoForTimeDilation>();

		// Token: 0x04018DB1 RID: 101809
		private HashSet<string> WaitSetTimeDilationTagSet = new HashSet<string>();

		// Token: 0x04018DB2 RID: 101810
		[Nullable(2)]
		private static UiTimeDilation _instance;
	}
}
