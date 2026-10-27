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
	// Token: 0x02005441 RID: 21569
	[NullableContext(1)]
	[Nullable(0)]
	public class VulkanSetView : UiViewBase
	{
		// Token: 0x06037121 RID: 225569 RVA: 0x00D0D179 File Offset: 0x00D0B379
		public VulkanSetView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037122 RID: 225570 RVA: 0x00D0D1AC File Offset: 0x00D0B3AC
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

		// Token: 0x06037123 RID: 225571 RVA: 0x00D0D234 File Offset: 0x00D0B434
		protected override UniTask OnBeforeStartAsync()
		{
			VulkanSetView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VulkanSetView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037124 RID: 225572 RVA: 0x00D0D278 File Offset: 0x00D0B478
		private ISetItemData[] InitData()
		{
			List<ISetItemData> list = new List<ISetItemData>();
			int num = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.Vulkan, 0, true);
			MenuConfig value = MenuBaseConfig.Instance.GetMenuConfigByFunctionId(20360).Value;
			string[] array = value.OptionsName();
			int[] array2 = value.OptionsValue();
			int num2 = array2.ToList<int>().IndexOf(num);
			if (num2 < 0)
			{
				num = value.OptionsDefault;
				num2 = array2.ToList<int>().IndexOf(num);
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

		// Token: 0x06037125 RID: 225573 RVA: 0x00D0D350 File Offset: 0x00D0B550
		protected override void OnBeforeShow()
		{
			base.GetItem(4).SetUIActive(this.IsNeedTipsActive());
			this.ScrollView.SelectGridProxy(this.CurrentIndex, false);
		}

		// Token: 0x06037126 RID: 225574 RVA: 0x00D0D376 File Offset: 0x00D0B576
		private SetItem InitSetItem()
		{
			return new SetItem
			{
				CallbackClickItem = new Action<ISetItemData>(this.OnClickItemToggle)
			};
		}

		// Token: 0x06037127 RID: 225575 RVA: 0x00D0D38F File Offset: 0x00D0B58F
		private void OnClickItemToggle(ISetItemData data)
		{
			this.SelectValue = data.Value;
			this.ScrollView.SelectGridProxy(data.Index, false);
			base.GetItem(4).SetUIActive(this.IsNeedTipsActive());
		}

		// Token: 0x06037128 RID: 225576 RVA: 0x00D0D3C1 File Offset: 0x00D0B5C1
		private void OnClickCancel(int _)
		{
			base.CloseMe(null);
		}

		// Token: 0x06037129 RID: 225577 RVA: 0x00D0D3CA File Offset: 0x00D0B5CA
		private void OnClickConfirm(int _)
		{
			if (this.SelectValue < 0)
			{
				return;
			}
			GameSettingsManager.Instance.HandleValueChange(EFunction.Vulkan, this.SelectValue, EGameSettingsApplyReason.WhenUi);
			base.CloseMe(null);
		}

		// Token: 0x0603712A RID: 225578 RVA: 0x00D0D3F4 File Offset: 0x00D0B5F4
		private bool IsNeedTipsActive()
		{
			string a = this.mobileRhiNameList[this.SelectValue];
			string rhiname = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIName();
			return a != rhiname;
		}

		// Token: 0x0401D0E4 RID: 119012
		private const EFunction vulkanFunctionId = EFunction.Vulkan;

		// Token: 0x0401D0E5 RID: 119013
		private string[] mobileRhiNameList = new string[]
		{
			"OpenGL",
			"Vulkan"
		};

		// Token: 0x0401D0E6 RID: 119014
		private int CurrentIndex = -1;

		// Token: 0x0401D0E7 RID: 119015
		private int SelectValue = -1;

		// Token: 0x0401D0E8 RID: 119016
		[Nullable(2)]
		private ButtonItem BtnCancel;

		// Token: 0x0401D0E9 RID: 119017
		[Nullable(2)]
		private ButtonItem BtnConfirm;

		// Token: 0x0401D0EA RID: 119018
		[Nullable(2)]
		private TipsItem ItemTips;

		// Token: 0x0401D0EB RID: 119019
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SetItem, ISetItemData> ScrollView;
	}
}
