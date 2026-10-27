using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.AutoPilot
{
	// Token: 0x02004844 RID: 18500
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotTrackBtnGroup : UiPanelBase
	{
		// Token: 0x17007907 RID: 30983
		// (get) Token: 0x0603068A RID: 198282 RVA: 0x00B3CA39 File Offset: 0x00B3AC39
		// (set) Token: 0x0603068B RID: 198283 RVA: 0x00B3CA41 File Offset: 0x00B3AC41
		public Action BtnGoQuickCallback { get; set; }

		// Token: 0x17007908 RID: 30984
		// (get) Token: 0x0603068C RID: 198284 RVA: 0x00B3CA4A File Offset: 0x00B3AC4A
		// (set) Token: 0x0603068D RID: 198285 RVA: 0x00B3CA52 File Offset: 0x00B3AC52
		public Action BtnCancelCallback { get; set; }

		// Token: 0x0603068E RID: 198286 RVA: 0x00B3CA5C File Offset: 0x00B3AC5C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnCancel));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnGoQuick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603068F RID: 198287 RVA: 0x00B3CB25 File Offset: 0x00B3AD25
		private void OnBtnCancel()
		{
			Action btnCancelCallback = this.BtnCancelCallback;
			if (btnCancelCallback == null)
			{
				return;
			}
			btnCancelCallback();
		}

		// Token: 0x06030690 RID: 198288 RVA: 0x00B3CB37 File Offset: 0x00B3AD37
		private void OnBtnGoQuick()
		{
			Action btnGoQuickCallback = this.BtnGoQuickCallback;
			if (btnGoQuickCallback == null)
			{
				return;
			}
			btnGoQuickCallback();
		}

		// Token: 0x06030691 RID: 198289 RVA: 0x00B3CB49 File Offset: 0x00B3AD49
		public void SetBtnGoQuickEnable(bool isEnable)
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(isEnable);
		}

		// Token: 0x0200AB23 RID: 43811
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0403401F RID: 213023
			public const int BtnCancel = 0;

			// Token: 0x04034020 RID: 213024
			public const int BtnGoQuick = 1;
		}
	}
}
