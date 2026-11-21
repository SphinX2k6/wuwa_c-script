using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005772 RID: 22386
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlFuncButtonItem : UiPanelBase
	{
		// Token: 0x060373B0 RID: 226224 RVA: 0x00F6BB58 File Offset: 0x00F69D58
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

		// Token: 0x060373B1 RID: 226225 RVA: 0x00F6BBFE File Offset: 0x00F69DFE
		public void SetOnClick(Action onClick)
		{
			this.OnClickInternal = onClick;
		}

		// Token: 0x060373B2 RID: 226226 RVA: 0x00F6BC07 File Offset: 0x00F69E07
		public void SetFunctionId(int functionId)
		{
			this.FunctionId = functionId;
		}

		// Token: 0x060373B3 RID: 226227 RVA: 0x00F6BC10 File Offset: 0x00F69E10
		public void SetButtonState()
		{
			if (this.FunctionId <= 0)
			{
				base.SetUiActive(true);
				return;
			}
			base.SetUiActive(FunctionModel.Instance.IsOpen(this.FunctionId));
		}

		// Token: 0x060373B4 RID: 226228 RVA: 0x00F6BC39 File Offset: 0x00F69E39
		public void SetRedDotVisible(bool value)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(value);
		}

		// Token: 0x060373B5 RID: 226229 RVA: 0x00F6BC4D File Offset: 0x00F69E4D
		public void BindRedDot(object _, int? __ = null)
		{
		}

		// Token: 0x060373B6 RID: 226230 RVA: 0x00F6BC4F File Offset: 0x00F69E4F
		public void UnBindRedDot()
		{
		}

		// Token: 0x060373B7 RID: 226231 RVA: 0x00F6BC51 File Offset: 0x00F69E51
		private void OnClick()
		{
			this.OnClickInternal();
		}

		// Token: 0x0401D2F8 RID: 119544
		private int FunctionId;

		// Token: 0x0401D2F9 RID: 119545
		private Action OnClickInternal = delegate()
		{
		};

		// Token: 0x0200B38A RID: 45962
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x04037818 RID: 227352
			RedDot,
			// Token: 0x04037819 RID: 227353
			Btn
		}
	}
}
