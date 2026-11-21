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
	// Token: 0x02003774 RID: 14196
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotNavBtnView : UiPanelBase
	{
		// Token: 0x17004BC3 RID: 19395
		// (get) Token: 0x06024E53 RID: 151123 RVA: 0x00A6C9D3 File Offset: 0x00A6ABD3
		// (set) Token: 0x06024E54 RID: 151124 RVA: 0x00A6C9DB File Offset: 0x00A6ABDB
		public Action OnBtnClickCallback { get; set; }

		// Token: 0x06024E55 RID: 151125 RVA: 0x00A6C9E4 File Offset: 0x00A6ABE4
		[NullableContext(1)]
		public AutoPilotNavBtnView(WorldMapSecondaryUiAutoPilotContext context)
		{
			this.Context = context;
		}

		// Token: 0x06024E56 RID: 151126 RVA: 0x00A6C9F4 File Offset: 0x00A6ABF4
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

		// Token: 0x06024E57 RID: 151127 RVA: 0x00A6CB3A File Offset: 0x00A6AD3A
		private void OnBtnClick()
		{
			Action onBtnClickCallback = this.OnBtnClickCallback;
			if (onBtnClickCallback != null)
			{
				onBtnClickCallback();
			}
			this.RefreshUi(true, true);
		}

		// Token: 0x06024E58 RID: 151128 RVA: 0x00A6CB58 File Offset: 0x00A6AD58
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

		// Token: 0x06024E59 RID: 151129 RVA: 0x00A6CBF0 File Offset: 0x00A6ADF0
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

		// Token: 0x0401470B RID: 83723
		[Nullable(1)]
		private readonly WorldMapSecondaryUiAutoPilotContext Context;

		// Token: 0x020094D0 RID: 38096
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E794 RID: 190356
			public static readonly int Button = 0;

			// Token: 0x0402E795 RID: 190357
			public static readonly int ButtonText = 1;

			// Token: 0x0402E796 RID: 190358
			public static readonly int RedDot = 2;

			// Token: 0x0402E797 RID: 190359
			public static readonly int Icon = 3;

			// Token: 0x0402E798 RID: 190360
			public static readonly int Tips = 4;

			// Token: 0x0402E799 RID: 190361
			public static readonly int TipsText = 5;
		}
	}
}
