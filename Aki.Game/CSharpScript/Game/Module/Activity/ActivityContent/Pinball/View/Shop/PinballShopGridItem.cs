using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Shop
{
	// Token: 0x02005268 RID: 21096
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballShopGridItem : PinballShopItem, IGridProxy<PinballShopItemProxy>
	{
		// Token: 0x1700660B RID: 26123
		// (get) Token: 0x0603483B RID: 215099 RVA: 0x00EB1A22 File Offset: 0x00EAFC22
		// (set) Token: 0x0603483C RID: 215100 RVA: 0x00EB1A2A File Offset: 0x00EAFC2A
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

		// Token: 0x1700660C RID: 26124
		// (get) Token: 0x0603483D RID: 215101 RVA: 0x00EB1A33 File Offset: 0x00EAFC33
		// (set) Token: 0x0603483E RID: 215102 RVA: 0x00EB1A3B File Offset: 0x00EAFC3B
		public int GridIndex { get; set; }

		// Token: 0x1700660D RID: 26125
		// (get) Token: 0x0603483F RID: 215103 RVA: 0x00EB1A44 File Offset: 0x00EAFC44
		// (set) Token: 0x06034840 RID: 215104 RVA: 0x00EB1A4C File Offset: 0x00EAFC4C
		public int DisplayIndex { get; set; }

		// Token: 0x06034841 RID: 215105 RVA: 0x00EB1A55 File Offset: 0x00EAFC55
		public void Refresh(PinballShopItemProxy data, bool isSelected, int gridIndex)
		{
			base.RefreshByData(data);
		}

		// Token: 0x06034842 RID: 215106 RVA: 0x00EB1A5E File Offset: 0x00EAFC5E
		public void Clear()
		{
		}

		// Token: 0x06034843 RID: 215107 RVA: 0x00EB1A60 File Offset: 0x00EAFC60
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06034844 RID: 215108 RVA: 0x00EB1A62 File Offset: 0x00EAFC62
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06034845 RID: 215109 RVA: 0x00EB1A64 File Offset: 0x00EAFC64
		public object GetKey(PinballShopItemProxy data, int gridIndex)
		{
			return gridIndex;
		}
	}
}
