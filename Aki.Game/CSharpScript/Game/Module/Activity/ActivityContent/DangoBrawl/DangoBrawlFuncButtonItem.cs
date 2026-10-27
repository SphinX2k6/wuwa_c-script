using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006822 RID: 26658
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlFuncButtonItem : UiPanelBase
	{
		// Token: 0x0604285C RID: 272476 RVA: 0x0102A61C File Offset: 0x0102881C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604285D RID: 272477 RVA: 0x0102A6C2 File Offset: 0x010288C2
		public void SetOnClick(Action onClick)
		{
			this.OnClickInternal = onClick;
		}

		// Token: 0x0604285E RID: 272478 RVA: 0x0102A6CB File Offset: 0x010288CB
		public void SetFunctionId(int functionId)
		{
			this.FunctionId = functionId;
		}

		// Token: 0x0604285F RID: 272479 RVA: 0x0102A6D4 File Offset: 0x010288D4
		public void SetButtonState()
		{
			if (this.FunctionId <= 0)
			{
				base.SetUiActive(true);
				return;
			}
			base.SetUiActive(FunctionModel.Instance.IsOpen(this.FunctionId));
		}

		// Token: 0x06042860 RID: 272480 RVA: 0x0102A6FD File Offset: 0x010288FD
		public void SetRedDotVisible(bool value)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(value);
		}

		// Token: 0x06042861 RID: 272481 RVA: 0x0102A711 File Offset: 0x01028911
		public void BindRedDot(object _, int? __ = null)
		{
		}

		// Token: 0x06042862 RID: 272482 RVA: 0x0102A713 File Offset: 0x01028913
		public void UnBindRedDot()
		{
		}

		// Token: 0x06042863 RID: 272483 RVA: 0x0102A715 File Offset: 0x01028915
		private void OnClick()
		{
			this.OnClickInternal();
		}

		// Token: 0x04022A9B RID: 141979
		private int FunctionId;

		// Token: 0x04022A9C RID: 141980
		private Action OnClickInternal = delegate()
		{
		};

		// Token: 0x0200C9BE RID: 51646
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x0403CF2E RID: 249646
			RedDot,
			// Token: 0x0403CF2F RID: 249647
			Btn
		}
	}
}
