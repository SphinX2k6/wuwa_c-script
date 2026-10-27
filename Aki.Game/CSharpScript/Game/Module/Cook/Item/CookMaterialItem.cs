using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.Item
{
	// Token: 0x02005B2F RID: 23343
	public class CookMaterialItem : UiPanelBase
	{
		// Token: 0x0603B1B0 RID: 242096 RVA: 0x00E187EE File Offset: 0x00E169EE
		[NullableContext(1)]
		public void BindOnClickedCallback(Action<ISingleItemInfo, int> onClicked)
		{
			this.OnClickedCallback = null;
			this.OnClickedCallback = onClicked;
		}

		// Token: 0x0603B1B1 RID: 242097 RVA: 0x00E18800 File Offset: 0x00E16A00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B1B2 RID: 242098 RVA: 0x00E18848 File Offset: 0x00E16A48
		protected override void OnStart()
		{
			this.ContentItem = new CookMaterialItemContent();
			this.ContentItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
			this.ContentItem.ClickDelegate = null;
			this.ContentItem.ClickDelegate = new Action(this.OnClick);
		}

		// Token: 0x0603B1B3 RID: 242099 RVA: 0x00E1889B File Offset: 0x00E16A9B
		[NullableContext(1)]
		public void Update(ISingleItemInfo data, int index)
		{
			this.CookItemData = data;
			this.ContentItem.Update(data);
			this.Index = index;
		}

		// Token: 0x0603B1B4 RID: 242100 RVA: 0x00E188B7 File Offset: 0x00E16AB7
		private void OnClick()
		{
			Action<ISingleItemInfo, int> onClickedCallback = this.OnClickedCallback;
			if (onClickedCallback == null)
			{
				return;
			}
			onClickedCallback(this.CookItemData, this.Index);
		}

		// Token: 0x0603B1B5 RID: 242101 RVA: 0x00E188D5 File Offset: 0x00E16AD5
		public void UpdateSelectedState(int index)
		{
			if (index == this.Index)
			{
				this.ContentItem.SetSelect();
				return;
			}
			this.ContentItem.SetDelect();
		}

		// Token: 0x0603B1B6 RID: 242102 RVA: 0x00E188F7 File Offset: 0x00E16AF7
		public void RefreshNeed(int num = 1)
		{
			this.ContentItem.RefreshNeed(num);
		}

		// Token: 0x0603B1B7 RID: 242103 RVA: 0x00E18905 File Offset: 0x00E16B05
		protected override void OnBeforeDestroy()
		{
			this.ContentItem.Destroy(null);
		}

		// Token: 0x0401ED09 RID: 126217
		[Nullable(2)]
		private CookMaterialItemContent ContentItem;

		// Token: 0x0401ED0A RID: 126218
		private int Index;

		// Token: 0x0401ED0B RID: 126219
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ISingleItemInfo, int> OnClickedCallback;

		// Token: 0x0401ED0C RID: 126220
		[Nullable(2)]
		private ISingleItemInfo CookItemData;

		// Token: 0x0200BD6A RID: 48490
		private enum ECookMaterialItemWrapComponents
		{
			// Token: 0x0403922F RID: 234031
			ContentItem
		}
	}
}
