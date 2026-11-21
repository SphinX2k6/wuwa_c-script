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
	// Token: 0x02004424 RID: 17444
	[NullableContext(1)]
	[Nullable(0)]
	public class VulkanSetView : UiViewBase
	{
		// Token: 0x0602C06A RID: 180330 RVA: 0x00C5C599 File Offset: 0x00C5A799
		public VulkanSetView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602C06B RID: 180331 RVA: 0x00C5C5CC File Offset: 0x00C5A7CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x0602C06C RID: 180332 RVA: 0x00C5C654 File Offset: 0x00C5A854
		protected override UniTask OnBeforeStartAsync()
		{
			VulkanSetView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VulkanSetView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C06D RID: 180333 RVA: 0x00C5C698 File Offset: 0x00C5A898
		private ISetItemData[] InitData()
		{
			List<ISetItemData> list = new List<ISetItemData>();
			int num = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.Vulkan, 0, true);
			MenuConfig value = MenuBaseConfig.Instance.GetMenuConfigByFunctionId(20360).Value;
			string[] array = value.OptionsName();
			int[] array2 = value.OptionsValue();
			int num2 = Array.IndexOf<int>(array2, num);
			if (num2 < 0)
			{
				num = value.OptionsDefault;
				num2 = Array.IndexOf<int>(array2, num);
			}
			this.CurrentIndex = num2;
			this.SelectValue = num;
			for (int i = 0; i < array.Length; i++)
			{
				list.Add(new SetItemData
				{
					Index = i,
					Value = array2[i],
					Name = ((array2[i] == 0) ? "ToolsImageSetOpenGLES_Text" : "ToolsImageSetVulkan_Text")
				});
			}
			return list.ToArray();
		}

		// Token: 0x0602C06E RID: 180334 RVA: 0x00C5C766 File Offset: 0x00C5A966
		protected override void OnBeforeShow()
		{
			base.GetItem(4).SetUIActive(this.IsNeedTipsActive());
			this.ScrollView.SelectGridProxy(this.CurrentIndex, false);
		}

		// Token: 0x0602C06F RID: 180335 RVA: 0x00C5C78C File Offset: 0x00C5A98C
		private SetItem InitSetItem()
		{
			return new SetItem
			{
				CallbackClickItem = new Action<ISetItemData>(this.OnClickItemToggle)
			};
		}

		// Token: 0x0602C070 RID: 180336 RVA: 0x00C5C7A5 File Offset: 0x00C5A9A5
		private void OnClickItemToggle(ISetItemData data)
		{
			this.SelectValue = data.Value;
			this.ScrollView.SelectGridProxy(data.Index, false);
			base.GetItem(4).SetUIActive(this.IsNeedTipsActive());
		}

		// Token: 0x0602C071 RID: 180337 RVA: 0x00C5C7D7 File Offset: 0x00C5A9D7
		private void OnClickCancel(int _)
		{
			base.CloseMe(null);
		}

		// Token: 0x0602C072 RID: 180338 RVA: 0x00C5C7E0 File Offset: 0x00C5A9E0
		private void OnClickConfirm(int _)
		{
			if (this.SelectValue < 0)
			{
				return;
			}
			GameSettingsManager.Instance.HandleValueChange(EFunction.Vulkan, this.SelectValue, EGameSettingsApplyReason.WhenUi);
			base.CloseMe(null);
		}

		// Token: 0x0602C073 RID: 180339 RVA: 0x00C5C80C File Offset: 0x00C5AA0C
		private bool IsNeedTipsActive()
		{
			string a = this.mobileRhiNameList[this.SelectValue];
			string rhiname = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIName();
			return a != rhiname;
		}

		// Token: 0x04017B7D RID: 97149
		private const EFunction vulkanFunctionId = EFunction.Vulkan;

		// Token: 0x04017B7E RID: 97150
		private string[] mobileRhiNameList = new string[]
		{
			"OpenGL",
			"Vulkan"
		};

		// Token: 0x04017B7F RID: 97151
		private int CurrentIndex = -1;

		// Token: 0x04017B80 RID: 97152
		private int SelectValue = -1;

		// Token: 0x04017B81 RID: 97153
		[Nullable(2)]
		private ButtonItem BtnCancel;

		// Token: 0x04017B82 RID: 97154
		[Nullable(2)]
		private ButtonItem BtnConfirm;

		// Token: 0x04017B83 RID: 97155
		[Nullable(2)]
		private TipsItem ItemTips;

		// Token: 0x04017B84 RID: 97156
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SetItem, ISetItemData> ScrollView;
	}
}
