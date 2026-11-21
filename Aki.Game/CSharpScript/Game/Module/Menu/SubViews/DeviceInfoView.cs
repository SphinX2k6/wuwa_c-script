using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x020043FB RID: 17403
	public class DeviceInfoView : UiViewBase
	{
		// Token: 0x0602BF93 RID: 180115 RVA: 0x00C58BE8 File Offset: 0x00C56DE8
		[NullableContext(1)]
		public DeviceInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BF94 RID: 180116 RVA: 0x00C58BF4 File Offset: 0x00C56DF4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602BF95 RID: 180117 RVA: 0x00C58C50 File Offset: 0x00C56E50
		protected override UniTask OnBeforeStartAsync()
		{
			DeviceInfoView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeviceInfoView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BF96 RID: 180118 RVA: 0x00C58C94 File Offset: 0x00C56E94
		private UniTask InitCaptionItem()
		{
			DeviceInfoView.<InitCaptionItem>d__6 <InitCaptionItem>d__;
			<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptionItem>d__.<>4__this = this;
			<InitCaptionItem>d__.<>1__state = -1;
			<InitCaptionItem>d__.<>t__builder.Start<DeviceInfoView.<InitCaptionItem>d__6>(ref <InitCaptionItem>d__);
			return <InitCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602BF97 RID: 180119 RVA: 0x00C58CD7 File Offset: 0x00C56ED7
		private void InitScrollView()
		{
			this.ScrollView = new GenericScrollViewNew<DeviceInfoItem, DeviceInfoItemData>(base.GetScrollViewWithScrollbar(1), new Func<DeviceInfoItem>(this.CreateDeviceInfoItem), null, false, null);
		}

		// Token: 0x0602BF98 RID: 180120 RVA: 0x00C58CFA File Offset: 0x00C56EFA
		[NullableContext(1)]
		private DeviceInfoItem CreateDeviceInfoItem()
		{
			return new DeviceInfoItem();
		}

		// Token: 0x0602BF99 RID: 180121 RVA: 0x00C58D01 File Offset: 0x00C56F01
		protected override void OnStart()
		{
			this.RefreshDeviceInfo();
		}

		// Token: 0x0602BF9A RID: 180122 RVA: 0x00C58D0C File Offset: 0x00C56F0C
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
			scrollView.RefreshByData(list, null, true);
		}

		// Token: 0x0602BF9B RID: 180123 RVA: 0x00C58DB0 File Offset: 0x00C56FB0
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

		// Token: 0x04017AF8 RID: 97016
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DeviceInfoItem, DeviceInfoItemData> ScrollView;

		// Token: 0x04017AF9 RID: 97017
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0200A0E3 RID: 41187
		public class EComponent
		{
			// Token: 0x04031FCF RID: 204751
			public const int CaptionItem = 0;

			// Token: 0x04031FD0 RID: 204752
			public const int ScrollView = 1;

			// Token: 0x04031FD1 RID: 204753
			public const int InfoItem = 2;
		}
	}
}
