using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Shop
{
	// Token: 0x020062EA RID: 25322
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballShopGridItem : PinballShopItem, IGridProxy<PinballShopItemProxy>
	{
		// Token: 0x170092A9 RID: 37545
		// (get) Token: 0x0603FB7A RID: 260986 RVA: 0x00F6AAC5 File Offset: 0x00F68CC5
		// (set) Token: 0x0603FB7B RID: 260987 RVA: 0x00F6AACD File Offset: 0x00F68CCD
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<PinballShopItemProxy>, PinballShopItemProxy> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x170092AA RID: 37546
		// (get) Token: 0x0603FB7C RID: 260988 RVA: 0x00F6AAD6 File Offset: 0x00F68CD6
		// (set) Token: 0x0603FB7D RID: 260989 RVA: 0x00F6AADE File Offset: 0x00F68CDE
		public int GridIndex { get; set; }

		// Token: 0x170092AB RID: 37547
		// (get) Token: 0x0603FB7E RID: 260990 RVA: 0x00F6AAE7 File Offset: 0x00F68CE7
		// (set) Token: 0x0603FB7F RID: 260991 RVA: 0x00F6AAEF File Offset: 0x00F68CEF
		public int DisplayIndex { get; set; }

		// Token: 0x0603FB80 RID: 260992 RVA: 0x00F6AAF8 File Offset: 0x00F68CF8
		public void Refresh(PinballShopItemProxy data, bool isSelected, int gridIndex)
		{
			base.RefreshByData(data);
		}

		// Token: 0x0603FB81 RID: 260993 RVA: 0x00F6AB01 File Offset: 0x00F68D01
		public void Clear()
		{
		}

		// Token: 0x0603FB82 RID: 260994 RVA: 0x00F6AB03 File Offset: 0x00F68D03
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603FB83 RID: 260995 RVA: 0x00F6AB05 File Offset: 0x00F68D05
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603FB84 RID: 260996 RVA: 0x00F6AB07 File Offset: 0x00F68D07
		public object GetKey(PinballShopItemProxy data, int gridIndex)
		{
			return gridIndex;
		}
	}
}
