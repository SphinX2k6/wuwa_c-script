using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.AutoPilot
{
	// Token: 0x02004843 RID: 18499
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotNavBtnView : UiPanelBase
	{
		// Token: 0x17007906 RID: 30982
		// (get) Token: 0x06030683 RID: 198275 RVA: 0x00B3C7EB File Offset: 0x00B3A9EB
		// (set) Token: 0x06030684 RID: 198276 RVA: 0x00B3C7F3 File Offset: 0x00B3A9F3
		public Action OnBtnClickCallback { get; set; }

		// Token: 0x06030685 RID: 198277 RVA: 0x00B3C7FC File Offset: 0x00B3A9FC
		[NullableContext(1)]
		public AutoPilotNavBtnView(WorldMapSecondaryUiAutoPilotContext context)
		{
			this.Context = context;
		}

		// Token: 0x06030686 RID: 198278 RVA: 0x00B3C80C File Offset: 0x00B3AA0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(AutoPilotNavBtnView.EComponents.Button, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(AutoPilotNavBtnView.EComponents.ButtonText, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(AutoPilotNavBtnView.EComponents.RedDot, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(AutoPilotNavBtnView.EComponents.Icon, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(AutoPilotNavBtnView.EComponents.Tips, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(AutoPilotNavBtnView.EComponents.TipsText, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(AutoPilotNavBtnView.EComponents.Button, new Action(this.OnBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030687 RID: 198279 RVA: 0x00B3C952 File Offset: 0x00B3AB52
		private void OnBtnClick()
		{
			Action onBtnClickCallback = this.OnBtnClickCallback;
			if (onBtnClickCallback != null)
			{
				onBtnClickCallback();
			}
			this.RefreshUi(true, true);
		}

		// Token: 0x06030688 RID: 198280 RVA: 0x00B3C970 File Offset: 0x00B3AB70
		public void RefreshUi(bool isAutoPilotTracked, bool isInteractive = true)
		{
			UUIButtonComponent button = base.GetButton(AutoPilotNavBtnView.EComponents.Button);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!isAutoPilotTracked);
			}
			UUIButtonComponent button2 = base.GetButton(AutoPilotNavBtnView.EComponents.Button);
			if (button2 != null)
			{
				button2.SetSelfInteractive(isInteractive);
			}
			UUIItem item = base.GetItem(AutoPilotNavBtnView.EComponents.Tips);
			if (item != null)
			{
				item.SetUIActive(isAutoPilotTracked);
			}
			if (!isAutoPilotTracked)
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(AutoPilotNavBtnView.EComponents.ButtonText), this.Context.IsNeedCustomMarkCreate() ? AutoPilotDefine.EAutoPilotTextId.TextMarkToGuide : AutoPilotDefine.EAutoPilotTextId.TextAutoPilotTrack, Array.Empty<object>());
			}
		}

		// Token: 0x06030689 RID: 198281 RVA: 0x00B3CA08 File Offset: 0x00B3AC08
		public bool GetIsInteractive()
		{
			if (this.RootItem == null)
			{
				return false;
			}
			if (!this.RootItem.IsUIActiveSelf())
			{
				return false;
			}
			UUIButtonComponent button = base.GetButton(AutoPilotNavBtnView.EComponents.Button);
			return button != null && button.GetSelfInteractive();
		}

		// Token: 0x0401A057 RID: 106583
		[Nullable(1)]
		private readonly WorldMapSecondaryUiAutoPilotContext Context;

		// Token: 0x0200AB22 RID: 43810
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04034019 RID: 213017
			public static readonly int Button = 0;

			// Token: 0x0403401A RID: 213018
			public static readonly int ButtonText = 1;

			// Token: 0x0403401B RID: 213019
			public static readonly int RedDot = 2;

			// Token: 0x0403401C RID: 213020
			public static readonly int Icon = 3;

			// Token: 0x0403401D RID: 213021
			public static readonly int Tips = 4;

			// Token: 0x0403401E RID: 213022
			public static readonly int TipsText = 5;
		}
	}
}
