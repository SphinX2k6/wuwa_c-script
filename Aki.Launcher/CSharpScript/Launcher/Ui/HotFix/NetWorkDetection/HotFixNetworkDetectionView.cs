using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.LogUpload;
using CSharpScript.Launcher.NetworkDetection;
using CSharpScript.Launcher.PlayerInput;
using CSharpScript.Launcher.Ui.HotFix.NetWorkDetection.SelectServer;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000FA RID: 250
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectionView : LaunchComponentsAction
	{
		// Token: 0x06000832 RID: 2098 RVA: 0x0003D610 File Offset: 0x0003B810
		public UniTask LoadAsync(UObject worldContext)
		{
			HotFixNetworkDetectionView.<LoadAsync>d__10 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadAsync>d__.<>4__this = this;
			<LoadAsync>d__.worldContext = worldContext;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<HotFixNetworkDetectionView.<LoadAsync>d__10>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0003D65C File Offset: 0x0003B85C
		protected override void OnStart()
		{
			base.GetButton(1).OnClickCallBack.Bind(new Action(this.OnBackBtnClick));
			base.GetButton(5).OnClickCallBack.Bind(new Action(this.OnSelectServerBtnClick));
			HotFixManager.SetLocalText(base.GetText(2), "NetworkDetection_Title", Array.Empty<string>());
			this.RightButtonItem = base.AttachElement<HotFixButtonItem>(9);
			this.RightButtonItem.BindClickCallback(new Action(this.OnRightBtnClick));
			HotFixButtonItem hotFixButtonItem = base.AttachElement<HotFixButtonItem>(8);
			hotFixButtonItem.SetLocalText("NetworkDetection_Cancel");
			hotFixButtonItem.BindClickCallback(new Action(this.OnLeftBtnClick));
			UUILayoutBase layout = base.GetLayout(10);
			AUIBaseActor gridActor = base.GetItem(7).GetOwner() as AUIBaseActor;
			this.DetectionLayout = new HotFixLayout<HotFixNetworkDetectionEntryItem, IHotFixNetworkDetectionLayoutItemData>(layout, new Func<HotFixNetworkDetectionEntryItem>(this.CreateDetectionLayoutEntryItem), gridActor);
			HotPatchInputManager.Instance.RegisterInputAxis("手柄右摇杆垂直方向", new TInputAxis(this.InputAxis));
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0003D750 File Offset: 0x0003B950
		private HotFixNetworkDetectionEntryItem CreateDetectionLayoutEntryItem()
		{
			HotFixNetworkDetectionEntryItem hotFixNetworkDetectionEntryItem = new HotFixNetworkDetectionEntryItem();
			this.DetectionLayoutItemList.Add(hotFixNetworkDetectionEntryItem);
			return hotFixNetworkDetectionEntryItem;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0003D770 File Offset: 0x0003B970
		protected override void OnShow()
		{
			this.DetectionViewState = EDetectionViewState.Idle;
			List<IHotFixNetworkDetectionLayoutItemData> networkDetectionLayoutItemData = HotFixNetworkDetectionModel.Instance.GetNetworkDetectionLayoutItemData();
			this.DetectionLayout.RefreshByData(networkDetectionLayoutItemData);
			this.NetworkDetectionLogUploadHandle = new NetworkDetectionLogUploadHandle();
			this.NetworkDetectionLogUploadHandle.LogUploadFinishCallBack = new TNetworkDetectionLogUploadFinishCallBack(this.OnLogUploadFinish);
			this.CheckAndInitServerSelection();
			this.UpdateSelectServer();
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0003D7C9 File Offset: 0x0003B9C9
		protected override void OnHide()
		{
			HotFixNetworkDetectionModel.Instance.ResetInterruptDetectionCheckTime();
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0003D7D5 File Offset: 0x0003B9D5
		protected override void OnBeforeDestroy()
		{
			NetworkDetectionLogUploadHandle networkDetectionLogUploadHandle = this.NetworkDetectionLogUploadHandle;
			if (networkDetectionLogUploadHandle != null)
			{
				networkDetectionLogUploadHandle.InterruptUploadLog();
			}
			HotPatchInputManager.Instance.UnRegisterInputAxis("手柄右摇杆垂直方向", new TInputAxis(this.InputAxis));
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0003D804 File Offset: 0x0003BA04
		private unsafe void CheckAndInitServerSelection()
		{
			bool flag = LauncherNetworkDetectionController.Instance.IsGlobalPlayer();
			bool flag2 = flag;
			base.GetItem(3).SetUIActive(flag2);
			this.RightButtonItem.SetEnableClick(!flag2);
			LauncherLog instance = LauncherLog.Instance;
			string message = "网络检测->Launcher阶段初始化";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isGlobalPlayer", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("needSelectServer", flag2);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (!flag2)
			{
				List<ILoginServersData> loginServersByClientRegion = HotFixNetworkDetectionModel.Instance.GetLoginServersByClientRegion();
				if (loginServersByClientRegion != null && loginServersByClientRegion.Count > 0)
				{
					HotFixNetworkDetectionModel.Instance.CurrentSelectServerData = loginServersByClientRegion[0];
					return;
				}
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "网络检测->初始化服务器数据失败，服务器列表为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("serverList", loginServersByClientRegion);
				instance2.Error(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0003D8E7 File Offset: 0x0003BAE7
		protected void OnBackBtnClick()
		{
			if (this.DetectionViewState == EDetectionViewState.Detecting)
			{
				this.HotFixNetworkDetectionTips.ShowTip("NetworkDetection_Ing");
				return;
			}
			this.CloseMe();
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0003D909 File Offset: 0x0003BB09
		private void SetServerSelectItemActive(bool value)
		{
			base.GetElement<HotFixNetworkDetectSelectView>(101).SetActive(value);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0003D919 File Offset: 0x0003BB19
		private void SetUploadLogTipsItemActive(bool value)
		{
			base.GetElement<HotFixNetworkDetectionTips>(102).SetActive(value);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0003D929 File Offset: 0x0003BB29
		private void OnSelectServerBtnClick()
		{
			if (this.DetectionViewState == EDetectionViewState.Detecting || this.DetectionViewState == EDetectionViewState.Uploading)
			{
				this.HotFixNetworkDetectionTips.ShowTip("NetworkDetection_Ing");
				return;
			}
			this.SetServerSelectItemActive(true);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0003D958 File Offset: 0x0003BB58
		private void UpdateSelectServer()
		{
			ILoginServersData currentSelectServerData = HotFixNetworkDetectionModel.Instance.CurrentSelectServerData;
			if (currentSelectServerData == null)
			{
				base.GetText(4).SetText("", true);
			}
			else
			{
				base.GetText(4).SetText(currentSelectServerData.name, true);
				LauncherNetworkDetectionController.Instance.SetDetectionConfig(currentSelectServerData);
			}
			this.UpdateButtonState();
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0003D9AC File Offset: 0x0003BBAC
		private void UpdateButtonState()
		{
			ILoginServersData currentSelectServerData = HotFixNetworkDetectionModel.Instance.CurrentSelectServerData;
			base.GetButton(9).SetSelfInteractive(currentSelectServerData != null && this.DetectionViewState != EDetectionViewState.Detecting);
			switch (this.DetectionViewState)
			{
			case EDetectionViewState.Idle:
				HotFixManager.SetLocalText(base.GetText(11), "NetworkDetection_Start_Tips", Array.Empty<string>());
				this.RightButtonItem.SetLocalText("NetworkDetection_Start");
				return;
			case EDetectionViewState.Detecting:
				base.GetText(11).SetText("", true);
				this.RightButtonItem.SetLocalText("NetworkDetection_Ing");
				return;
			case EDetectionViewState.DetectComplete:
			{
				string hotPatchText = LauncherConfigLib.Instance.GetHotPatchText("NetworkDetection_Trace_Id");
				string text = LauncherNetworkDetectionModel.GenerateTraceCode();
				this.TraceId = text;
				this.DetectionTraceText = hotPatchText + " " + text;
				base.GetText(11).SetText(this.DetectionTraceText, true);
				LauncherLog instance = LauncherLog.Instance;
				string message = "网络检测->检测完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("检测编码:(traceId)", text);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.RightButtonItem.SetLocalText("NetworkDetection_Hotfix_Submit");
				return;
			}
			default:
				this.RightButtonItem.SetLocalText("NetworkDetection_Start");
				return;
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0003DAD8 File Offset: 0x0003BCD8
		protected void OnLeftBtnClick()
		{
			if (this.DetectionViewState == EDetectionViewState.Detecting)
			{
				this.HotFixNetworkDetectionTips.ShowTip("NetworkDetection_Ing");
				return;
			}
			this.CloseMe();
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0003DAFA File Offset: 0x0003BCFA
		private void CloseMe()
		{
			base.SetActive(false);
			this.SetUploadLogTipsItemActive(false);
			this.HotFixNetworkDetectionTips.SetActive(false);
			this.NetworkDetectionLogUploadHandle.InterruptUploadLog();
			LauncherNetworkDetectionController.Instance.ForceStopDomainDetect();
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0003DB2C File Offset: 0x0003BD2C
		private void OnRightBtnClick()
		{
			switch (this.DetectionViewState)
			{
			case EDetectionViewState.Idle:
				this.ProceedDetection().Forget();
				return;
			case EDetectionViewState.Detecting:
				return;
			case EDetectionViewState.DetectComplete:
			{
				IReadOnlyList<IHotFixNetworkDetectionLayoutItemData> dataList = this.DetectionLayout.GetDataList();
				string finalErrorCodeString = HotFixNetworkDetectionModel.Instance.GetFinalErrorCodeString(dataList);
				ULGUIBPLibrary.ClipBoardCopy(this.DetectionTraceText + "\n" + finalErrorCodeString);
				this.HotFixNetworkDetectionTips.SetTipsLocalText("NetworkDetection_Submiting");
				this.SetUploadLogTipsItemActive(true);
				this.NetworkDetectionLogUploadHandle.UploadLog();
				this.DetectionViewState = EDetectionViewState.Uploading;
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0003DBB8 File Offset: 0x0003BDB8
		private UniTask ProceedDetection()
		{
			HotFixNetworkDetectionView.<ProceedDetection>d__26 <ProceedDetection>d__;
			<ProceedDetection>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProceedDetection>d__.<>4__this = this;
			<ProceedDetection>d__.<>1__state = -1;
			<ProceedDetection>d__.<>t__builder.Start<HotFixNetworkDetectionView.<ProceedDetection>d__26>(ref <ProceedDetection>d__);
			return <ProceedDetection>d__.<>t__builder.Task;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0003DBFC File Offset: 0x0003BDFC
		private void OnLogUploadFinish()
		{
			this.DetectionViewState = EDetectionViewState.UpLoadComplete;
			this.SetUploadLogTipsItemActive(false);
			LauncherLog.Instance.Debug("网络检测->上传日志完成，热更阶段不打开客服界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CloseMe();
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0003DC38 File Offset: 0x0003BE38
		private void OnSelectServerCallBack()
		{
			ILoginServersData currentUiSelectSeverData = HotFixNetworkDetectionModel.Instance.CurrentUiSelectSeverData;
			if (currentUiSelectSeverData != null)
			{
				if (LauncherNetworkDetectionController.Instance.SetDetectionConfig(currentUiSelectSeverData))
				{
					HotFixNetworkDetectionModel.Instance.CurrentSelectServerData = currentUiSelectSeverData;
					this.UpdateSelectServer();
					return;
				}
				HotFixNetworkDetectionModel.Instance.CurrentSelectServerData = null;
				this.HotFixNetworkDetectionTips.ShowTip("NetworkDetection_Error");
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0003DC8D File Offset: 0x0003BE8D
		private void InputAxis(float value, string axisName)
		{
			if (value == 0f)
			{
				return;
			}
			if ("手柄右摇杆垂直方向" == axisName)
			{
				base.GetUiScrollViewWithScrollBar(6).SetVelocity(value * 800f);
			}
		}

		// Token: 0x040004AA RID: 1194
		private HotFixLayout<HotFixNetworkDetectionEntryItem, IHotFixNetworkDetectionLayoutItemData> DetectionLayout;

		// Token: 0x040004AB RID: 1195
		private readonly List<HotFixNetworkDetectionEntryItem> DetectionLayoutItemList = new List<HotFixNetworkDetectionEntryItem>();

		// Token: 0x040004AC RID: 1196
		[Nullable(2)]
		private NetworkDetectionLogUploadHandle NetworkDetectionLogUploadHandle;

		// Token: 0x040004AD RID: 1197
		private EDetectionViewState DetectionViewState;

		// Token: 0x040004AE RID: 1198
		[Nullable(2)]
		private HotFixButtonItem RightButtonItem;

		// Token: 0x040004AF RID: 1199
		private string DetectionTraceText = "";

		// Token: 0x040004B0 RID: 1200
		private string TraceId = "";

		// Token: 0x040004B1 RID: 1201
		[Nullable(2)]
		private HotFixNetworkDetectionTips HotFixNetworkDetectionUploadLogTips;

		// Token: 0x040004B2 RID: 1202
		[Nullable(2)]
		private HotFixNetworkDetectionTips HotFixNetworkDetectionTips;

		// Token: 0x02000391 RID: 913
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0400125B RID: 4699
			public const int BtnMask = 0;

			// Token: 0x0400125C RID: 4700
			public const int BtnBack = 1;

			// Token: 0x0400125D RID: 4701
			public const int TxtTitle = 2;

			// Token: 0x0400125E RID: 4702
			public const int PnlServer = 3;

			// Token: 0x0400125F RID: 4703
			public const int TxtServer = 4;

			// Token: 0x04001260 RID: 4704
			public const int BtnFunctionD = 5;

			// Token: 0x04001261 RID: 4705
			public const int ScrollView = 6;

			// Token: 0x04001262 RID: 4706
			public const int NetInfoItem = 7;

			// Token: 0x04001263 RID: 4707
			public const int BtnLeft = 8;

			// Token: 0x04001264 RID: 4708
			public const int BtnRight = 9;

			// Token: 0x04001265 RID: 4709
			public const int NetInfoContent = 10;

			// Token: 0x04001266 RID: 4710
			public const int TextTips = 11;

			// Token: 0x04001267 RID: 4711
			public const int SelServerPop = 101;

			// Token: 0x04001268 RID: 4712
			public const int UploadLogTips = 102;

			// Token: 0x04001269 RID: 4713
			public const int Tips = 103;
		}
	}
}
