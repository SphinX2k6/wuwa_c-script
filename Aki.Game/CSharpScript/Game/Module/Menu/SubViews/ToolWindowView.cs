using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004417 RID: 17431
	[NullableContext(2)]
	[Nullable(0)]
	public class ToolWindowView : UiViewBase
	{
		// Token: 0x0602C017 RID: 180247 RVA: 0x00C5ACA5 File Offset: 0x00C58EA5
		[NullableContext(1)]
		public ToolWindowView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602C018 RID: 180248 RVA: 0x00C5ACB0 File Offset: 0x00C58EB0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x0602C019 RID: 180249 RVA: 0x00C5AD38 File Offset: 0x00C58F38
		protected override void OnStart()
		{
			base.GetText(0).ShowTextNew("PrefabTextItem_HotfixTool_Text");
			this.ButtonFixPatch = new ToolWindowButtonItem(base.GetItem(1));
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_HotfixTool_clear_Text", null);
			this.ButtonFixPatch.SetText(localTextNew);
			this.ButtonFixPatch.BindCallback(new Action(this.FixPatch));
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_Tool_Clean");
			this.ButtonFixPatch.RefreshIcon(resourcePath, delegate(bool result)
			{
				this.ButtonFixPatch.SetIconVisible(true);
			});
			this.ButtonLogUpload = new ToolWindowButtonItem(base.GetItem(2));
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_HotfixTool_upload_Text", null);
			this.ButtonLogUpload.SetText(localTextNew2);
			this.ButtonLogUpload.BindCallback(new Action(this.OpenLogUpload));
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_Tool_Upload");
			this.ButtonLogUpload.RefreshIcon(resourcePath2, delegate(bool result)
			{
				this.ButtonLogUpload.SetIconVisible(true);
			});
			this.ButtonNetworkDetection = new ToolWindowButtonItem(base.GetItem(3));
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("NetworkDetection_Title");
			this.ButtonNetworkDetection.SetText(multiTextByKey);
			this.ButtonNetworkDetection.BindCallback(new Action(this.NetworkDetection));
			string resourcePath3 = UiResourceConfig.Instance.GetResourcePath("SP_IconNet");
			this.ButtonNetworkDetection.RefreshIcon(resourcePath3, delegate(bool result)
			{
				this.ButtonNetworkDetection.SetIconVisible(true);
			});
			MenuConfig? menuConfigByFunctionId = MenuBaseConfig.Instance.GetMenuConfigByFunctionId(20360);
			bool item = GameSettingsManager.Instance.CheckConfigValidByCheckList(menuConfigByFunctionId.Value).Item1;
			base.GetItem(4).SetUIActive(item);
			if (item)
			{
				this.ButtonVulkan = new ToolWindowButtonItem(base.GetItem(4));
				string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey("ToolsImageSet_Text");
				this.ButtonVulkan.SetText(multiTextByKey2);
				this.ButtonVulkan.BindCallback(new Action(this.OnClickVulkan));
				string resourcePath4 = UiResourceConfig.Instance.GetResourcePath("SP_IconVulkan");
				this.ButtonVulkan.RefreshIcon(resourcePath4, delegate(bool result)
				{
					this.ButtonVulkan.SetIconVisible(true);
				});
			}
		}

		// Token: 0x0602C01A RID: 180250 RVA: 0x00C5AF48 File Offset: 0x00C59148
		private void OpenLogUpload()
		{
			LogUploadOpenParam param = new LogUploadOpenParam
			{
				OpenSourceType = new EKuroSdkOpenCustomerServerType?(EKuroSdkOpenCustomerServerType.Login),
				AutoStartUpload = new bool?(false)
			};
			UiManager.Instance.OpenView(EUiViewName.LogUploadView, param, null);
		}

		// Token: 0x0602C01B RID: 180251 RVA: 0x00C5AF84 File Offset: 0x00C59184
		private void FixPatch()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ClearHotPatchConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, new Action(ToolWindowView.<FixPatch>g__ConfirmCallback|8_0));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602C01C RID: 180252 RVA: 0x00C5AFC0 File Offset: 0x00C591C0
		private void NetworkDetection()
		{
			UiManager.Instance.OpenView(EUiViewName.NetworkDetectionView, null, null);
		}

		// Token: 0x0602C01D RID: 180253 RVA: 0x00C5AFD3 File Offset: 0x00C591D3
		private void OnClickVulkan()
		{
			UiManager.Instance.OpenView(EUiViewName.VulkanSetView, null, null);
		}

		// Token: 0x0602C022 RID: 180258 RVA: 0x00C5B020 File Offset: 0x00C59220
		[CompilerGenerated]
		internal static void <FixPatch>g__ConfirmCallback|8_0()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PatchCleanProcessing);
			confirmBoxDataNew.SetAfterShowFunction(delegate
			{
				HotPatch.Instance.ClearPatch();
			});
			confirmBoxDataNew.SetCloseFunction(delegate
			{
				HotPatch.Instance.ClearPatch();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x04017B62 RID: 97122
		private ToolWindowButtonItem ButtonLogUpload;

		// Token: 0x04017B63 RID: 97123
		private ToolWindowButtonItem ButtonFixPatch;

		// Token: 0x04017B64 RID: 97124
		private ToolWindowButtonItem ButtonNetworkDetection;

		// Token: 0x04017B65 RID: 97125
		private ToolWindowButtonItem ButtonVulkan;
	}
}
