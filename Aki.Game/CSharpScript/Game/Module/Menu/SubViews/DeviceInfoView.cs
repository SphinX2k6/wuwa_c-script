using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005418 RID: 21528
	public class DeviceInfoView : UiViewBase
	{
		// Token: 0x0603704A RID: 225354 RVA: 0x00D097C0 File Offset: 0x00D079C0
		[NullableContext(1)]
		public DeviceInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603704B RID: 225355 RVA: 0x00D097CC File Offset: 0x00D079CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603704C RID: 225356 RVA: 0x00D09828 File Offset: 0x00D07A28
		protected override UniTask OnBeforeStartAsync()
		{
			DeviceInfoView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeviceInfoView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603704D RID: 225357 RVA: 0x00D0986C File Offset: 0x00D07A6C
		private UniTask InitCaptionItem()
		{
			DeviceInfoView.<InitCaptionItem>d__6 <InitCaptionItem>d__;
			<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptionItem>d__.<>4__this = this;
			<InitCaptionItem>d__.<>1__state = -1;
			<InitCaptionItem>d__.<>t__builder.Start<DeviceInfoView.<InitCaptionItem>d__6>(ref <InitCaptionItem>d__);
			return <InitCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603704E RID: 225358 RVA: 0x00D098AF File Offset: 0x00D07AAF
		private void InitScrollView()
		{
			this.ScrollView = new GenericScrollViewNew<DeviceInfoItem, DeviceInfoItemData>(base.GetScrollViewWithScrollbar(1), new Func<DeviceInfoItem>(this.CreateDeviceInfoItem), null, false, null);
		}

		// Token: 0x0603704F RID: 225359 RVA: 0x00D098D2 File Offset: 0x00D07AD2
		[NullableContext(1)]
		private DeviceInfoItem CreateDeviceInfoItem()
		{
			return new DeviceInfoItem();
		}

		// Token: 0x06037050 RID: 225360 RVA: 0x00D098D9 File Offset: 0x00D07AD9
		protected override void OnStart()
		{
			this.RefreshDeviceInfo();
		}

		// Token: 0x06037051 RID: 225361 RVA: 0x00D098E4 File Offset: 0x00D07AE4
		private void RefreshDeviceInfo()
		{
			IReadOnlyList<DeviceInfo> configList = ConfigDeviceInfoAll.GetConfigList(true);
			if (configList == null)
			{
				return;
			}
			Dictionary<EDeviceInfo, Func<ValueTuple<string, bool>>> dictionary = this.CreateFunctionMap();
			List<DeviceInfoItemData> list = new List<DeviceInfoItemData>();
			foreach (DeviceInfo deviceInfo in configList)
			{
				Func<ValueTuple<string, bool>> getInfoFunction;
				if (dictionary.TryGetValue((EDeviceInfo)deviceInfo.Id, out getInfoFunction))
				{
					DeviceInfoItemData item = new DeviceInfoItemData(deviceInfo.Id, deviceInfo.Name, deviceInfo.LowTips, getInfoFunction);
					list.Add(item);
				}
			}
			GenericScrollViewNew<DeviceInfoItem, DeviceInfoItemData> scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshByData(list.ToList<DeviceInfoItemData>(), null, true);
		}

		// Token: 0x06037052 RID: 225362 RVA: 0x00D09990 File Offset: 0x00D07B90
		[return: Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		private Dictionary<EDeviceInfo, Func<ValueTuple<string, bool>>> CreateFunctionMap()
		{
			Dictionary<EDeviceInfo, Func<ValueTuple<string, bool>>> dictionary = new Dictionary<EDeviceInfo, Func<ValueTuple<string, bool>>>();
			dictionary.Add(EDeviceInfo.CPU, () => GameSettingsDeviceRender.Instance.GetCPUInformation());
			dictionary.Add(EDeviceInfo.GPU, () => GameSettingsDeviceRender.Instance.GetGPUInformation());
			dictionary.Add(EDeviceInfo.GraphicDriverVersion, () => GameSettingsDeviceRender.Instance.GetGraphicDriverVersion());
			dictionary.Add(EDeviceInfo.GraphicAPI, () => GameSettingsDeviceRender.Instance.GetGraphicAPI());
			dictionary.Add(EDeviceInfo.Memory, () => GameSettingsDeviceRender.Instance.GetMemoryInformation());
			dictionary.Add(EDeviceInfo.VideoMemory, () => GameSettingsDeviceRender.Instance.GetVideoMemoryInformation());
			dictionary.Add(EDeviceInfo.GameInstallPath, () => GameSettingsDeviceRender.Instance.GetGameInstallPath());
			dictionary.Add(EDeviceInfo.WindowsVersion, () => GameSettingsDeviceRender.Instance.GetWindowsVersion());
			return dictionary;
		}

		// Token: 0x0401D05F RID: 118879
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DeviceInfoItem, DeviceInfoItemData> ScrollView;

		// Token: 0x0401D060 RID: 118880
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0200B6AB RID: 46763
		public class EComponent
		{
			// Token: 0x0403757A RID: 226682
			public const int CaptionItem = 0;

			// Token: 0x0403757B RID: 226683
			public const int ScrollView = 1;

			// Token: 0x0403757C RID: 226684
			public const int InfoItem = 2;
		}
	}
}
