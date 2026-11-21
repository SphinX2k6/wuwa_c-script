using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.AutoPilot
{
	// Token: 0x02003775 RID: 14197
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotTrackBtnGroup : UiPanelBase
	{
		// Token: 0x17004BC4 RID: 19396
		// (get) Token: 0x06024E5A RID: 151130 RVA: 0x00A6CC21 File Offset: 0x00A6AE21
		// (set) Token: 0x06024E5B RID: 151131 RVA: 0x00A6CC29 File Offset: 0x00A6AE29
		public Action BtnGoQuickCallback { get; set; }

		// Token: 0x17004BC5 RID: 19397
		// (get) Token: 0x06024E5C RID: 151132 RVA: 0x00A6CC32 File Offset: 0x00A6AE32
		// (set) Token: 0x06024E5D RID: 151133 RVA: 0x00A6CC3A File Offset: 0x00A6AE3A
		public Action BtnCancelCallback { get; set; }

		// Token: 0x06024E5E RID: 151134 RVA: 0x00A6CC44 File Offset: 0x00A6AE44
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

		// Token: 0x06024E5F RID: 151135 RVA: 0x00A6CD0D File Offset: 0x00A6AF0D
		private void OnBtnCancel()
		{
			Action btnCancelCallback = this.BtnCancelCallback;
			if (btnCancelCallback == null)
			{
				return;
			}
			btnCancelCallback();
		}

		// Token: 0x06024E60 RID: 151136 RVA: 0x00A6CD1F File Offset: 0x00A6AF1F
		private void OnBtnGoQuick()
		{
			Action btnGoQuickCallback = this.BtnGoQuickCallback;
			if (btnGoQuickCallback == null)
			{
				return;
			}
			btnGoQuickCallback();
		}

		// Token: 0x06024E61 RID: 151137 RVA: 0x00A6CD31 File Offset: 0x00A6AF31
		public void SetBtnGoQuickEnable(bool isEnable)
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(isEnable);
		}

		// Token: 0x020094D1 RID: 38097
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E79A RID: 190362
			public const int BtnCancel = 0;

			// Token: 0x0402E79B RID: 190363
			public const int BtnGoQuick = 1;
		}
	}
}
