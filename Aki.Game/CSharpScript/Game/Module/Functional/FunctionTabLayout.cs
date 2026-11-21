using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x020049FA RID: 18938
	public class FunctionTabLayout : UiPanelBase
	{
		// Token: 0x0602F77B RID: 194427 RVA: 0x00D3CEF5 File Offset: 0x00D3B0F5
		[NullableContext(1)]
		public FunctionTabLayout(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602F77C RID: 194428 RVA: 0x00D3CF14 File Offset: 0x00D3B114
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602F77D RID: 194429 RVA: 0x00D3CF7D File Offset: 0x00D3B17D
		protected override void OnStart()
		{
			this.TabLayout = new GenericLayoutNew<FunctionTabItem>(base.GetLayoutBase(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FunctionTabItem>(this.InitTabItem), base.GetItem(1));
		}

		// Token: 0x0602F77E RID: 194430 RVA: 0x00D3CFA4 File Offset: 0x00D3B1A4
		[NullableContext(1)]
		private ILayoutItem<FunctionTabItem> InitTabItem(object data, UUIItem uiItem, int index)
		{
			FunctionTabItem value = new FunctionTabItem(uiItem);
			return new LayoutItem<FunctionTabItem>
			{
				Key = index,
				Value = value
			};
		}

		// Token: 0x0602F77F RID: 194431 RVA: 0x00D3CFD0 File Offset: 0x00D3B1D0
		protected override void OnBeforeDestroy()
		{
			this.TabLayout.ClearChildren();
		}

		// Token: 0x0602F780 RID: 194432 RVA: 0x00D3CFDD File Offset: 0x00D3B1DD
		public void RefreshTab(int showNum)
		{
			this.ShowNum = showNum;
			if (showNum > 1)
			{
				this.SetActive(true);
				this.TabLayout.RebuildLayoutByDataNew<FunctionTabItem>(null, new int?(showNum));
				return;
			}
			this.SetActive(false);
		}

		// Token: 0x0602F781 RID: 194433 RVA: 0x00D3D00C File Offset: 0x00D3B20C
		public void SetToggleSelectByIndex(int index)
		{
			if (this.ShowNum <= 1)
			{
				return;
			}
			if (this.CurrentSelect == index)
			{
				return;
			}
			if (this.CurrentSelect != -1)
			{
				this.TabLayout.GetLayoutItemByKey(this.CurrentSelect).SetToggleState(false);
			}
			this.TabLayout.GetLayoutItemByKey(index).SetToggleState(true);
			this.CurrentSelect = index;
		}

		// Token: 0x04019247 RID: 102983
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<FunctionTabItem> TabLayout;

		// Token: 0x04019248 RID: 102984
		private int CurrentSelect = -1;

		// Token: 0x04019249 RID: 102985
		private int ShowNum;

		// Token: 0x0200A69C RID: 42652
		private class EFunctionTabLayoutDefine
		{
			// Token: 0x04033807 RID: 210951
			public const int TabRoot = 0;

			// Token: 0x04033808 RID: 210952
			public const int TabItem = 1;
		}
	}
}
