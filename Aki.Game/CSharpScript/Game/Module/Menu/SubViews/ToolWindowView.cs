using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005434 RID: 21556
	[NullableContext(2)]
	[Nullable(0)]
	public class ToolWindowView : UiViewBase
	{
		// Token: 0x060370CE RID: 225486 RVA: 0x00D0B885 File Offset: 0x00D09A85
		[NullableContext(1)]
		public ToolWindowView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060370CF RID: 225487 RVA: 0x00D0B890 File Offset: 0x00D09A90
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

		// Token: 0x060370D0 RID: 225488 RVA: 0x00D0B918 File Offset: 0x00D09B18
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

		// Token: 0x060370D1 RID: 225489 RVA: 0x00D0BB28 File Offset: 0x00D09D28
		private void OpenLogUpload()
		{
			LogUploadOpenParam param = new LogUploadOpenParam
			{
				OpenSourceType = new EKuroSdkOpenCustomerServerType?(EKuroSdkOpenCustomerServerType.Login),
				AutoStartUpload = new bool?(false)
			};
			UiManager.Instance.OpenView(EUiViewName.LogUploadView, param, null);
		}

		// Token: 0x060370D2 RID: 225490 RVA: 0x00D0BB64 File Offset: 0x00D09D64
		private void FixPatch()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ClearHotPatchConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, new Action(ToolWindowView.<FixPatch>g__ConfirmCallback|8_0));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060370D3 RID: 225491 RVA: 0x00D0BBA0 File Offset: 0x00D09DA0
		private void NetworkDetection()
		{
			UiManager.Instance.OpenView(EUiViewName.NetworkDetectionView, null, null);
		}

		// Token: 0x060370D4 RID: 225492 RVA: 0x00D0BBB3 File Offset: 0x00D09DB3
		private void OnClickVulkan()
		{
			UiManager.Instance.OpenView(EUiViewName.VulkanSetView, null, null);
		}

		// Token: 0x060370D9 RID: 225497 RVA: 0x00D0BC00 File Offset: 0x00D09E00
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

		// Token: 0x0401D0C9 RID: 118985
		private ToolWindowButtonItem ButtonLogUpload;

		// Token: 0x0401D0CA RID: 118986
		private ToolWindowButtonItem ButtonFixPatch;

		// Token: 0x0401D0CB RID: 118987
		private ToolWindowButtonItem ButtonNetworkDetection;

		// Token: 0x0401D0CC RID: 118988
		private ToolWindowButtonItem ButtonVulkan;
	}
}
