using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.Item
{
	// Token: 0x02004B10 RID: 19216
	public class CookMaterialItem : UiPanelBase
	{
		// Token: 0x06030122 RID: 196898 RVA: 0x00D69506 File Offset: 0x00D67706
		[NullableContext(1)]
		public void BindOnClickedCallback(Action<ISingleItemInfo, int> onClicked)
		{
			this.OnClickedCallback = null;
			this.OnClickedCallback = onClicked;
		}

		// Token: 0x06030123 RID: 196899 RVA: 0x00D69518 File Offset: 0x00D67718
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

		// Token: 0x06030124 RID: 196900 RVA: 0x00D69560 File Offset: 0x00D67760
		protected override void OnStart()
		{
			this.ContentItem = new CookMaterialItemContent();
			this.ContentItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
			this.ContentItem.ClickDelegate = null;
			this.ContentItem.ClickDelegate = new Action(this.OnClick);
		}

		// Token: 0x06030125 RID: 196901 RVA: 0x00D695B3 File Offset: 0x00D677B3
		[NullableContext(1)]
		public void Update(ISingleItemInfo data, int index)
		{
			this.CookItemData = data;
			this.ContentItem.Update(data);
			this.Index = index;
		}

		// Token: 0x06030126 RID: 196902 RVA: 0x00D695CF File Offset: 0x00D677CF
		private void OnClick()
		{
			Action<ISingleItemInfo, int> onClickedCallback = this.OnClickedCallback;
			if (onClickedCallback == null)
			{
				return;
			}
			onClickedCallback(this.CookItemData, this.Index);
		}

		// Token: 0x06030127 RID: 196903 RVA: 0x00D695ED File Offset: 0x00D677ED
		public void UpdateSelectedState(int index)
		{
			if (index == this.Index)
			{
				this.ContentItem.SetSelect();
				return;
			}
			this.ContentItem.SetDelect();
		}

		// Token: 0x06030128 RID: 196904 RVA: 0x00D6960F File Offset: 0x00D6780F
		public void RefreshNeed(int num = 1)
		{
			this.ContentItem.RefreshNeed(num);
		}

		// Token: 0x06030129 RID: 196905 RVA: 0x00D6961D File Offset: 0x00D6781D
		protected override void OnBeforeDestroy()
		{
			this.ContentItem.Destroy(null);
		}

		// Token: 0x040197C5 RID: 104389
		[Nullable(2)]
		private CookMaterialItemContent ContentItem;

		// Token: 0x040197C6 RID: 104390
		private int Index;

		// Token: 0x040197C7 RID: 104391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ISingleItemInfo, int> OnClickedCallback;

		// Token: 0x040197C8 RID: 104392
		[Nullable(2)]
		private ISingleItemInfo CookItemData;

		// Token: 0x0200A773 RID: 42867
		private enum ECookMaterialItemWrapComponents
		{
			// Token: 0x04033BFB RID: 211963
			ContentItem
		}
	}
}
