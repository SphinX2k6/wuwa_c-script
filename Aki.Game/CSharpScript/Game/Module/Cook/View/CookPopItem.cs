using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AFE RID: 19198
	[NullableContext(1)]
	[Nullable(0)]
	public class CookPopItem : UiPanelBase
	{
		// Token: 0x0603002F RID: 196655 RVA: 0x00D64B12 File Offset: 0x00D62D12
		public CookPopItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06030030 RID: 196656 RVA: 0x00D64B28 File Offset: 0x00D62D28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(delegate()
			{
				this.OnClick();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030031 RID: 196657 RVA: 0x00D64C12 File Offset: 0x00D62E12
		public void Update(ICookPopItem data)
		{
			this.ItemData = data;
			this.SetIcon();
			this.SetQuality();
			this.SetCount();
		}

		// Token: 0x06030032 RID: 196658 RVA: 0x00D64C30 File Offset: 0x00D62E30
		private void SetIcon()
		{
			base.SetItemIcon(base.GetTexture(4), this.ItemData.ItemId, null, null);
		}

		// Token: 0x06030033 RID: 196659 RVA: 0x00D64C60 File Offset: 0x00D62E60
		private void SetQuality()
		{
			base.SetItemQualityIcon(base.GetSprite(5), this.ItemData.ItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x06030034 RID: 196660 RVA: 0x00D64C90 File Offset: 0x00D62E90
		private void SetCount()
		{
			base.GetText(8).SetText(this.ItemData.ItemNum.ToString(), true);
		}

		// Token: 0x06030035 RID: 196661 RVA: 0x00D64CBD File Offset: 0x00D62EBD
		private void OnClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemData.ItemId, true, null, false);
		}

		// Token: 0x0401977F RID: 104319
		[Nullable(2)]
		private ICookPopItem ItemData;
	}
}
