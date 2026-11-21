using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
	// Token: 0x02004349 RID: 17225
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionView : UiViewBase
	{
		// Token: 0x0602B7F3 RID: 178163 RVA: 0x00C38C5A File Offset: 0x00C36E5A
		public NetworkDetectionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B7F4 RID: 178164 RVA: 0x00C38C84 File Offset: 0x00C36E84
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

		// Token: 0x0602B7F5 RID: 178165 RVA: 0x00C38E38 File Offset: 0x00C37038
		protected override UniTask OnBeforeStartAsync()
		{
			NetworkDetectionView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NetworkDetectionView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B7F6 RID: 178166 RVA: 0x00C38E7C File Offset: 0x00C3707C
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

		// Token: 0x0602B7F7 RID: 178167 RVA: 0x00C38F43 File Offset: 0x00C37143
		protected override void OnBeforeShow()
		{
			this.DetectionViewState = EDetectionViewState.Idle;
			this.CheckAndInitServerSelection();
			this.UpdateSelectServer();
			EventSystem.Instance.Add(EEventName.OnConfirmNetworkDetectionItem, new Action(this.OnConfirmSelectServer));
		}

		// Token: 0x0602B7F8 RID: 178168 RVA: 0x00C38F71 File Offset: 0x00C37171
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Remove(EEventName.OnConfirmNetworkDetectionItem, new Action(this.OnConfirmSelectServer));
		}

		// Token: 0x0602B7F9 RID: 178169 RVA: 0x00C38F8C File Offset: 0x00C3718C
		private unsafe void CheckAndInitServerSelection()
		{
			bool flag = LauncherNetworkDetectionController.Instance.IsGlobalPlayer();
			bool flag2 = flag;
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

		// Token: 0x0602B7FA RID: 178170 RVA: 0x00C39080 File Offset: 0x00C37280
		private NetworkDetectionItem InitContentLayoutItem()
		{
			NetworkDetectionItem networkDetectionItem = new NetworkDetectionItem();
			this.ContentLayoutItemList.Add(networkDetectionItem);
			return networkDetectionItem;
		}

		// Token: 0x0602B7FB RID: 178171 RVA: 0x00C390A0 File Offset: 0x00C372A0
		protected override void OnBeforeHide()
		{
			NetworkDetectionModel.Instance.ResetInterruptDetectionCheckTime();
		}

		// Token: 0x0602B7FC RID: 178172 RVA: 0x00C390AC File Offset: 0x00C372AC
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

		// Token: 0x0602B7FD RID: 178173 RVA: 0x00C3911C File Offset: 0x00C3731C
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

		// Token: 0x0602B7FE RID: 178174 RVA: 0x00C3918C File Offset: 0x00C3738C
		private void OnSelectServerBtnClick()
		{
			if (this.DetectionViewState == EDetectionViewState.Detecting || this.DetectionViewState == EDetectionViewState.Uploading)
			{
				this.NetworkDetectionTips.ShowTip("NetworkDetection_Ing");
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.NetworkDetectionSelectServerView, null, null);
		}

		// Token: 0x0602B7FF RID: 178175 RVA: 0x00C391C4 File Offset: 0x00C373C4
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

		// Token: 0x0602B800 RID: 178176 RVA: 0x00C3920C File Offset: 0x00C3740C
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

		// Token: 0x0602B801 RID: 178177 RVA: 0x00C39258 File Offset: 0x00C37458
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

		// Token: 0x0602B802 RID: 178178 RVA: 0x00C3939C File Offset: 0x00C3759C
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

		// Token: 0x0602B803 RID: 178179 RVA: 0x00C393EC File Offset: 0x00C375EC
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

		// Token: 0x0602B804 RID: 178180 RVA: 0x00C3947C File Offset: 0x00C3767C
		private void OnLogUploadFinish()
		{
			this.DetectionViewState = EDetectionViewState.UpLoadComplete;
			global::KuroSdkController.Instance.OpenCustomerService(EKuroSdkOpenCustomerServerType.Login);
			this.NetworkDetectionUploadLogTips.Hide(null);
			base.CloseMe(null);
		}

		// Token: 0x0602B805 RID: 178181 RVA: 0x00C394A4 File Offset: 0x00C376A4
		private UniTask ProceedDetection()
		{
			NetworkDetectionView.<ProceedDetection>d__28 <ProceedDetection>d__;
			<ProceedDetection>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProceedDetection>d__.<>4__this = this;
			<ProceedDetection>d__.<>1__state = -1;
			<ProceedDetection>d__.<>t__builder.Start<NetworkDetectionView.<ProceedDetection>d__28>(ref <ProceedDetection>d__);
			return <ProceedDetection>d__.<>t__builder.Task;
		}

		// Token: 0x040177F6 RID: 96246
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<NetworkDetectionItem, INetworkDetectionItemData> ContentLayout;

		// Token: 0x040177F7 RID: 96247
		private readonly List<NetworkDetectionItem> ContentLayoutItemList = new List<NetworkDetectionItem>();

		// Token: 0x040177F8 RID: 96248
		[Nullable(2)]
		private NetworkDetectionLogUploadHandle NetworkDetectionLogUploadHandle;

		// Token: 0x040177F9 RID: 96249
		private EDetectionViewState DetectionViewState;

		// Token: 0x040177FA RID: 96250
		[Nullable(2)]
		private ButtonItem RightButtonItem;

		// Token: 0x040177FB RID: 96251
		[Nullable(2)]
		private NetworkDetectionTips NetworkDetectionUploadLogTips;

		// Token: 0x040177FC RID: 96252
		[Nullable(2)]
		private NetworkDetectionTips NetworkDetectionTips;

		// Token: 0x040177FD RID: 96253
		private string DetectionTraceText = "";

		// Token: 0x040177FE RID: 96254
		private string TraceId = "";

		// Token: 0x0200A007 RID: 40967
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04031B82 RID: 203650
			PnlServer,
			// Token: 0x04031B83 RID: 203651
			TxtServer,
			// Token: 0x04031B84 RID: 203652
			BtnFunctionD,
			// Token: 0x04031B85 RID: 203653
			ScrollView,
			// Token: 0x04031B86 RID: 203654
			NetInfoItem,
			// Token: 0x04031B87 RID: 203655
			BtnLeft,
			// Token: 0x04031B88 RID: 203656
			BtnRight,
			// Token: 0x04031B89 RID: 203657
			NetInfoContent,
			// Token: 0x04031B8A RID: 203658
			TexTips
		}
	}
}
