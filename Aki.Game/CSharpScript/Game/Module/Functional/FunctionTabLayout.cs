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
	// Token: 0x02005A1E RID: 23070
	public class FunctionTabLayout : UiPanelBase
	{
		// Token: 0x0603A832 RID: 239666 RVA: 0x00DEC965 File Offset: 0x00DEAB65
		[NullableContext(1)]
		public FunctionTabLayout(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603A833 RID: 239667 RVA: 0x00DEC984 File Offset: 0x00DEAB84
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

		// Token: 0x0603A834 RID: 239668 RVA: 0x00DEC9ED File Offset: 0x00DEABED
		protected override void OnStart()
		{
			this.TabLayout = new GenericLayoutNew<FunctionTabItem>(base.GetLayoutBase(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FunctionTabItem>(this.InitTabItem), base.GetItem(1));
		}

		// Token: 0x0603A835 RID: 239669 RVA: 0x00DECA14 File Offset: 0x00DEAC14
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

		// Token: 0x0603A836 RID: 239670 RVA: 0x00DECA40 File Offset: 0x00DEAC40
		protected override void OnBeforeDestroy()
		{
			this.TabLayout.ClearChildren();
		}

		// Token: 0x0603A837 RID: 239671 RVA: 0x00DECA4D File Offset: 0x00DEAC4D
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

		// Token: 0x0603A838 RID: 239672 RVA: 0x00DECA7C File Offset: 0x00DEAC7C
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

		// Token: 0x0401E7A0 RID: 124832
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<FunctionTabItem> TabLayout;

		// Token: 0x0401E7A1 RID: 124833
		private int CurrentSelect = -1;

		// Token: 0x0401E7A2 RID: 124834
		private int ShowNum;

		// Token: 0x0200BC93 RID: 48275
		private class EFunctionTabLayoutDefine
		{
			// Token: 0x04038E3C RID: 233020
			public const int TabRoot = 0;

			// Token: 0x04038E3D RID: 233021
			public const int TabItem = 1;
		}
	}
}
