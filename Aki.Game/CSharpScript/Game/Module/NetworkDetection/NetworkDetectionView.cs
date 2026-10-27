using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.LogUpload;
using CSharpScript.Launcher.NetworkDetection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02005366 RID: 21350
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionView : UiViewBase
	{
		// Token: 0x060368AD RID: 223405 RVA: 0x00CE9DD2 File Offset: 0x00CE7FD2
		public NetworkDetectionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060368AE RID: 223406 RVA: 0x00CE9DFC File Offset: 0x00CE7FFC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnSelectServerBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnLeftBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060368AF RID: 223407 RVA: 0x00CE9FB0 File Offset: 0x00CE81B0
		protected override UniTask OnBeforeStartAsync()
		{
			NetworkDetectionView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NetworkDetectionView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060368B0 RID: 223408 RVA: 0x00CE9FF4 File Offset: 0x00CE81F4
		protected override void OnStart()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.OnLeftBtnClick));
			}
			IUiPopFrameInterface childPopView2 = this.ChildPopView;
			if (childPopView2 != null)
			{
				childPopView2.PopItem.SetMaskResponsibleState(false);
			}
			this.RightButtonItem = new ButtonItem(base.GetItem(6));
			this.RightButtonItem.SetFunction(new Action<int>(this.OnRightBtnClick));
			this.ContentLayout = new GenericLayout<NetworkDetectionItem, INetworkDetectionItemData>(base.GetVerticalLayout(7), new Func<NetworkDetectionItem>(this.InitContentLayoutItem), null, false, true);
			List<INetworkDetectionItemData> networkDetectionLayoutItemData = this.GetNetworkDetectionLayoutItemData();
			this.ContentLayout.RefreshByData(networkDetectionLayoutItemData, null, false);
			this.NetworkDetectionLogUploadHandle = new NetworkDetectionLogUploadHandle();
			this.NetworkDetectionLogUploadHandle.LogUploadFinishCallBack = new TNetworkDetectionLogUploadFinishCallBack(this.OnLogUploadFinish);
		}

		// Token: 0x060368B1 RID: 223409 RVA: 0x00CEA0BB File Offset: 0x00CE82BB
		protected override void OnBeforeShow()
		{
			this.DetectionViewState = EDetectionViewState.Idle;
			this.CheckAndInitServerSelection();
			this.UpdateSelectServer();
			EventSystem.Instance.Add(EEventName.OnConfirmNetworkDetectionItem, new Action(this.OnConfirmSelectServer));
		}

		// Token: 0x060368B2 RID: 223410 RVA: 0x00CEA0E9 File Offset: 0x00CE82E9
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Remove(EEventName.OnConfirmNetworkDetectionItem, new Action(this.OnConfirmSelectServer));
		}

		// Token: 0x060368B3 RID: 223411 RVA: 0x00CEA104 File Offset: 0x00CE8304
		private unsafe void CheckAndInitServerSelection()
		{
			bool flag = LauncherNetworkDetectionController.Instance.IsGlobalPlayer();
			bool isPlayInEditor = Info.Instance.IsPlayInEditor;
			bool flag2 = flag || isPlayInEditor;
			base.GetItem(0).SetUIActive(flag2);
			this.RightButtonItem.SetEnableClick(!flag2);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "网络检测->Login阶段初始化";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isGlobalPlayer", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("needSelectServer", flag2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (!flag2)
			{
				List<ILoginServersData> loginServersByClientRegion = LoginServerModel.Instance.GetLoginServersByClientRegion();
				if (loginServersByClientRegion != null && loginServersByClientRegion.Count > 0)
				{
					NetworkDetectionModel.Instance.CurrentSelectServerData = loginServersByClientRegion[0];
					this.OnConfirmSelectServer();
					return;
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Login;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "网络检测->初始化服务器数据失败，服务器列表为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("serverList", loginServersByClientRegion);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x060368B4 RID: 223412 RVA: 0x00CEA204 File Offset: 0x00CE8404
		private NetworkDetectionItem InitContentLayoutItem()
		{
			NetworkDetectionItem networkDetectionItem = new NetworkDetectionItem();
			this.ContentLayoutItemList.Add(networkDetectionItem);
			return networkDetectionItem;
		}

		// Token: 0x060368B5 RID: 223413 RVA: 0x00CEA224 File Offset: 0x00CE8424
		protected override void OnBeforeHide()
		{
			NetworkDetectionModel.Instance.ResetInterruptDetectionCheckTime();
		}

		// Token: 0x060368B6 RID: 223414 RVA: 0x00CEA230 File Offset: 0x00CE8430
		protected override void OnBeforeDestroy()
		{
			NetworkDetectionTips networkDetectionUploadLogTips = this.NetworkDetectionUploadLogTips;
			if (networkDetectionUploadLogTips != null)
			{
				networkDetectionUploadLogTips.Destroy(null);
			}
			NetworkDetectionTips networkDetectionTips = this.NetworkDetectionTips;
			if (networkDetectionTips != null)
			{
				networkDetectionTips.Destroy(null);
			}
			this.RightButtonItem.Destroy(null);
			if (this.ContentLayout != null)
			{
				this.ContentLayout.ClearChildren();
				this.ContentLayout = null;
			}
			this.NetworkDetectionLogUploadHandle.InterruptUploadLog();
			LauncherNetworkDetectionController.Instance.ForceStopDomainDetect();
		}

		// Token: 0x060368B7 RID: 223415 RVA: 0x00CEA2A0 File Offset: 0x00CE84A0
		public List<INetworkDetectionItemData> GetNetworkDetectionLayoutItemData()
		{
			List<INetworkDetectionItemData> list = new List<INetworkDetectionItemData>();
			foreach (INetworkDetectionEntry entryData in LauncherNetworkDetectionModel.GetDetectionDataList())
			{
				NetworkDetectionItemData item = new NetworkDetectionItemData
				{
					EntryData = entryData,
					Proceed = false
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060368B8 RID: 223416 RVA: 0x00CEA310 File Offset: 0x00CE8510
		private void OnSelectServerBtnClick()
		{
			if (this.DetectionViewState == EDetectionViewState.Detecting || this.DetectionViewState == EDetectionViewState.Uploading)
			{
				this.NetworkDetectionTips.ShowTip("NetworkDetection_Ing");
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.NetworkDetectionSelectServerView, null, null);
		}

		// Token: 0x060368B9 RID: 223417 RVA: 0x00CEA348 File Offset: 0x00CE8548
		private void UpdateSelectServer()
		{
			ILoginServersData currentSelectServerData = NetworkDetectionModel.Instance.CurrentSelectServerData;
			if (currentSelectServerData == null)
			{
				base.GetText(1).SetText("", true);
			}
			else
			{
				base.GetText(1).SetText(currentSelectServerData.name, true);
			}
			this.UpdateButtonState();
		}

		// Token: 0x060368BA RID: 223418 RVA: 0x00CEA390 File Offset: 0x00CE8590
		private void OnConfirmSelectServer()
		{
			ILoginServersData currentSelectServerData = NetworkDetectionModel.Instance.CurrentSelectServerData;
			if (currentSelectServerData != null)
			{
				if (LauncherNetworkDetectionController.Instance.SetDetectionConfig(currentSelectServerData))
				{
					this.UpdateSelectServer();
					return;
				}
				NetworkDetectionModel.Instance.CurrentSelectServerData = null;
				this.NetworkDetectionTips.ShowTip("NetworkDetection_Error");
			}
		}

		// Token: 0x060368BB RID: 223419 RVA: 0x00CEA3DC File Offset: 0x00CE85DC
		private void UpdateButtonState()
		{
			ILoginServersData currentSelectServerData = NetworkDetectionModel.Instance.CurrentSelectServerData;
			this.RightButtonItem.SetEnableClick(currentSelectServerData != null && this.DetectionViewState != EDetectionViewState.Detecting);
			switch (this.DetectionViewState)
			{
			case EDetectionViewState.Idle:
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "NetworkDetection_Start_Tips", Array.Empty<object>());
				this.RightButtonItem.SetLocalTextNew("NetworkDetection_Start", Array.Empty<object>());
				return;
			case EDetectionViewState.Detecting:
				base.GetText(8).SetText("", true);
				this.RightButtonItem.SetLocalTextNew("NetworkDetection_Ing", Array.Empty<object>());
				return;
			case EDetectionViewState.DetectComplete:
			{
				string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("NetworkDetection_Trace_Id");
				string text = LauncherNetworkDetectionModel.GenerateTraceCode();
				this.TraceId = text;
				this.DetectionTraceText = multiTextByKey + " " + text;
				base.GetText(8).SetText(this.DetectionTraceText, true);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Login;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "网络检测->开始检测";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("检测编码:(traceId)", text);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.RightButtonItem.SetLocalTextNew("NetworkDetection_Submit", Array.Empty<object>());
				return;
			}
			default:
				this.RightButtonItem.SetLocalTextNew("NetworkDetection_Start", Array.Empty<object>());
				return;
			}
		}

		// Token: 0x060368BC RID: 223420 RVA: 0x00CEA520 File Offset: 0x00CE8720
		private void OnLeftBtnClick()
		{
			if ((this.DetectionViewState == EDetectionViewState.Detecting || this.DetectionViewState == EDetectionViewState.Uploading) && NetworkDetectionModel.Instance.NeedInterruptDetectionDoubleCheckTips())
			{
				this.NetworkDetectionTips.ShowTip("NetworkDetection_tips");
				NetworkDetectionModel.Instance.ConfirmInterruptDetection();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x060368BD RID: 223421 RVA: 0x00CEA570 File Offset: 0x00CE8770
		private void OnRightBtnClick(int _)
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
				IReadOnlyList<INetworkDetectionItemData> datas = this.ContentLayout.GetDatas();
				string finalErrorCodeString = NetworkDetectionModel.Instance.GetFinalErrorCodeString(datas);
				ULGUIBPLibrary.ClipBoardCopy(this.DetectionTraceText + "\n" + finalErrorCodeString);
				this.NetworkDetectionUploadLogTips.Show(null);
				this.NetworkDetectionUploadLogTips.SetTipsLocalText("NetworkDetection_Submiting");
				this.NetworkDetectionLogUploadHandle.UploadLog();
				this.DetectionViewState = EDetectionViewState.Uploading;
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x060368BE RID: 223422 RVA: 0x00CEA600 File Offset: 0x00CE8800
		private void OnLogUploadFinish()
		{
			this.DetectionViewState = EDetectionViewState.UpLoadComplete;
			global::KuroSdkController.Instance.OpenCustomerService(EKuroSdkOpenCustomerServerType.Login);
			this.NetworkDetectionUploadLogTips.Hide(null);
			base.CloseMe(null);
		}

		// Token: 0x060368BF RID: 223423 RVA: 0x00CEA628 File Offset: 0x00CE8828
		private UniTask ProceedDetection()
		{
			NetworkDetectionView.<ProceedDetection>d__28 <ProceedDetection>d__;
			<ProceedDetection>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProceedDetection>d__.<>4__this = this;
			<ProceedDetection>d__.<>1__state = -1;
			<ProceedDetection>d__.<>t__builder.Start<NetworkDetectionView.<ProceedDetection>d__28>(ref <ProceedDetection>d__);
			return <ProceedDetection>d__.<>t__builder.Task;
		}

		// Token: 0x0401CD62 RID: 118114
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<NetworkDetectionItem, INetworkDetectionItemData> ContentLayout;

		// Token: 0x0401CD63 RID: 118115
		private readonly List<NetworkDetectionItem> ContentLayoutItemList = new List<NetworkDetectionItem>();

		// Token: 0x0401CD64 RID: 118116
		[Nullable(2)]
		private NetworkDetectionLogUploadHandle NetworkDetectionLogUploadHandle;

		// Token: 0x0401CD65 RID: 118117
		private EDetectionViewState DetectionViewState;

		// Token: 0x0401CD66 RID: 118118
		[Nullable(2)]
		private ButtonItem RightButtonItem;

		// Token: 0x0401CD67 RID: 118119
		[Nullable(2)]
		private NetworkDetectionTips NetworkDetectionUploadLogTips;

		// Token: 0x0401CD68 RID: 118120
		[Nullable(2)]
		private NetworkDetectionTips NetworkDetectionTips;

		// Token: 0x0401CD69 RID: 118121
		private string DetectionTraceText = "";

		// Token: 0x0401CD6A RID: 118122
		private string TraceId = "";

		// Token: 0x0200B5CE RID: 46542
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403712A RID: 225578
			PnlServer,
			// Token: 0x0403712B RID: 225579
			TxtServer,
			// Token: 0x0403712C RID: 225580
			BtnFunctionD,
			// Token: 0x0403712D RID: 225581
			ScrollView,
			// Token: 0x0403712E RID: 225582
			NetInfoItem,
			// Token: 0x0403712F RID: 225583
			BtnLeft,
			// Token: 0x04037130 RID: 225584
			BtnRight,
			// Token: 0x04037131 RID: 225585
			NetInfoContent,
			// Token: 0x04037132 RID: 225586
			TexTips
		}
	}
}
