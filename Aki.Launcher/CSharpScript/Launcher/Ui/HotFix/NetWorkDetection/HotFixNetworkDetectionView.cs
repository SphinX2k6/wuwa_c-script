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
	// Token: 0x020000FE RID: 254
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectionView : LaunchComponentsAction
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x0003F9B0 File Offset: 0x0003DBB0
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

		// Token: 0x06000867 RID: 2151 RVA: 0x0003F9FC File Offset: 0x0003DBFC
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

		// Token: 0x06000868 RID: 2152 RVA: 0x0003FAF0 File Offset: 0x0003DCF0
		private HotFixNetworkDetectionEntryItem CreateDetectionLayoutEntryItem()
		{
			HotFixNetworkDetectionEntryItem hotFixNetworkDetectionEntryItem = new HotFixNetworkDetectionEntryItem();
			this.DetectionLayoutItemList.Add(hotFixNetworkDetectionEntryItem);
			return hotFixNetworkDetectionEntryItem;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0003FB10 File Offset: 0x0003DD10
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

		// Token: 0x0600086A RID: 2154 RVA: 0x0003FB69 File Offset: 0x0003DD69
		protected override void OnHide()
		{
			HotFixNetworkDetectionModel.Instance.ResetInterruptDetectionCheckTime();
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0003FB75 File Offset: 0x0003DD75
		protected override void OnBeforeDestroy()
		{
			NetworkDetectionLogUploadHandle networkDetectionLogUploadHandle = this.NetworkDetectionLogUploadHandle;
			if (networkDetectionLogUploadHandle != null)
			{
				networkDetectionLogUploadHandle.InterruptUploadLog();
			}
			HotPatchInputManager.Instance.UnRegisterInputAxis("手柄右摇杆垂直方向", new TInputAxis(this.InputAxis));
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0003FBA4 File Offset: 0x0003DDA4
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

		// Token: 0x0600086D RID: 2157 RVA: 0x0003FC87 File Offset: 0x0003DE87
		protected void OnBackBtnClick()
		{
			if (this.DetectionViewState == EDetectionViewState.Detecting)
			{
				this.HotFixNetworkDetectionTips.ShowTip("NetworkDetection_Ing");
				return;
			}
			this.CloseMe();
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0003FCA9 File Offset: 0x0003DEA9
		private void SetServerSelectItemActive(bool value)
		{
			base.GetElement<HotFixNetworkDetectSelectView>(101).SetActive(value);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0003FCB9 File Offset: 0x0003DEB9
		private void SetUploadLogTipsItemActive(bool value)
		{
			base.GetElement<HotFixNetworkDetectionTips>(102).SetActive(value);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0003FCC9 File Offset: 0x0003DEC9
		private void OnSelectServerBtnClick()
		{
			if (this.DetectionViewState == EDetectionViewState.Detecting || this.DetectionViewState == EDetectionViewState.Uploading)
			{
				this.HotFixNetworkDetectionTips.ShowTip("NetworkDetection_Ing");
				return;
			}
			this.SetServerSelectItemActive(true);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0003FCF8 File Offset: 0x0003DEF8
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

		// Token: 0x06000872 RID: 2162 RVA: 0x0003FD4C File Offset: 0x0003DF4C
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

		// Token: 0x06000873 RID: 2163 RVA: 0x0003FE78 File Offset: 0x0003E078
		protected void OnLeftBtnClick()
		{
			if (this.DetectionViewState == EDetectionViewState.Detecting)
			{
				this.HotFixNetworkDetectionTips.ShowTip("NetworkDetection_Ing");
				return;
			}
			this.CloseMe();
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0003FE9A File Offset: 0x0003E09A
		private void CloseMe()
		{
			base.SetActive(false);
			this.SetUploadLogTipsItemActive(false);
			this.HotFixNetworkDetectionTips.SetActive(false);
			this.NetworkDetectionLogUploadHandle.InterruptUploadLog();
			LauncherNetworkDetectionController.Instance.ForceStopDomainDetect();
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0003FECC File Offset: 0x0003E0CC
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

		// Token: 0x06000876 RID: 2166 RVA: 0x0003FF58 File Offset: 0x0003E158
		private UniTask ProceedDetection()
		{
			HotFixNetworkDetectionView.<ProceedDetection>d__26 <ProceedDetection>d__;
			<ProceedDetection>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProceedDetection>d__.<>4__this = this;
			<ProceedDetection>d__.<>1__state = -1;
			<ProceedDetection>d__.<>t__builder.Start<HotFixNetworkDetectionView.<ProceedDetection>d__26>(ref <ProceedDetection>d__);
			return <ProceedDetection>d__.<>t__builder.Task;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0003FF9C File Offset: 0x0003E19C
		private void OnLogUploadFinish()
		{
			this.DetectionViewState = EDetectionViewState.UpLoadComplete;
			this.SetUploadLogTipsItemActive(false);
			LauncherLog.Instance.Debug("网络检测->上传日志完成，热更阶段不打开客服界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CloseMe();
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
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

		// Token: 0x06000879 RID: 2169 RVA: 0x0004002D File Offset: 0x0003E22D
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

		// Token: 0x040004E5 RID: 1253
		private HotFixLayout<HotFixNetworkDetectionEntryItem, IHotFixNetworkDetectionLayoutItemData> DetectionLayout;

		// Token: 0x040004E6 RID: 1254
		private readonly List<HotFixNetworkDetectionEntryItem> DetectionLayoutItemList = new List<HotFixNetworkDetectionEntryItem>();

		// Token: 0x040004E7 RID: 1255
		[Nullable(2)]
		private NetworkDetectionLogUploadHandle NetworkDetectionLogUploadHandle;

		// Token: 0x040004E8 RID: 1256
		private EDetectionViewState DetectionViewState;

		// Token: 0x040004E9 RID: 1257
		[Nullable(2)]
		private HotFixButtonItem RightButtonItem;

		// Token: 0x040004EA RID: 1258
		private string DetectionTraceText = "";

		// Token: 0x040004EB RID: 1259
		private string TraceId = "";

		// Token: 0x040004EC RID: 1260
		[Nullable(2)]
		private HotFixNetworkDetectionTips HotFixNetworkDetectionUploadLogTips;

		// Token: 0x040004ED RID: 1261
		[Nullable(2)]
		private HotFixNetworkDetectionTips HotFixNetworkDetectionTips;

		// Token: 0x0200039E RID: 926
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040012D1 RID: 4817
			public const int BtnMask = 0;

			// Token: 0x040012D2 RID: 4818
			public const int BtnBack = 1;

			// Token: 0x040012D3 RID: 4819
			public const int TxtTitle = 2;

			// Token: 0x040012D4 RID: 4820
			public const int PnlServer = 3;

			// Token: 0x040012D5 RID: 4821
			public const int TxtServer = 4;

			// Token: 0x040012D6 RID: 4822
			public const int BtnFunctionD = 5;

			// Token: 0x040012D7 RID: 4823
			public const int ScrollView = 6;

			// Token: 0x040012D8 RID: 4824
			public const int NetInfoItem = 7;

			// Token: 0x040012D9 RID: 4825
			public const int BtnLeft = 8;

			// Token: 0x040012DA RID: 4826
			public const int BtnRight = 9;

			// Token: 0x040012DB RID: 4827
			public const int NetInfoContent = 10;

			// Token: 0x040012DC RID: 4828
			public const int TextTips = 11;

			// Token: 0x040012DD RID: 4829
			public const int SelServerPop = 101;

			// Token: 0x040012DE RID: 4830
			public const int UploadLogTips = 102;

			// Token: 0x040012DF RID: 4831
			public const int Tips = 103;
		}
	}
}
