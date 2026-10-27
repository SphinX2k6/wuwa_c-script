using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007811 RID: 30737
	public class TVisualNovelDisplayItemUnion
	{
		// Token: 0x1700E6F9 RID: 59129
		// (get) Token: 0x06037BAE RID: 228270 RVA: 0x00788A1C File Offset: 0x00786C1C
		// (set) Token: 0x06037BAF RID: 228271 RVA: 0x00788A24 File Offset: 0x00786C24
		public TVisualNovelDisplayItem Type { get; set; }

		// Token: 0x1700E6FA RID: 59130
		// (get) Token: 0x06037BB0 RID: 228272 RVA: 0x00788A2D File Offset: 0x00786C2D
		// (set) Token: 0x06037BB1 RID: 228273 RVA: 0x00788A35 File Offset: 0x00786C35
		public object Value { get; set; }

		// Token: 0x06037BB2 RID: 228274 RVA: 0x00788A3E File Offset: 0x00786C3E
		public TVisualNovelDisplayItemUnion()
		{
			this.Type = TVisualNovelDisplayItem.NONE;
			this.Value = null;
		}

		// Token: 0x06037BB3 RID: 228275 RVA: 0x00788A54 File Offset: 0x00786C54
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037BB4 RID: 228276 RVA: 0x00788A66 File Offset: 0x00786C66
		public IVisualNovelDisplayItemCloseT AsIVisualNovelDisplayItemClose()
		{
			return this.As<IVisualNovelDisplayItemCloseT>();
		}

		// Token: 0x06037BB5 RID: 228277 RVA: 0x00788A6E File Offset: 0x00786C6E
		public static TVisualNovelDisplayItemUnion FromIVisualNovelDisplayItemClose(IVisualNovelDisplayItemCloseT _ivisualnoveldisplayitemclose)
		{
			return new TVisualNovelDisplayItemUnion
			{
				Type = TVisualNovelDisplayItem.IVisualNovelDisplayItemClose,
				Value = _ivisualnoveldisplayitemclose
			};
		}

		// Token: 0x06037BB6 RID: 228278 RVA: 0x00788A83 File Offset: 0x00786C83
		public IVisualNovelDisplayItemImageT AsIVisualNovelDisplayItemImage()
		{
			return this.As<IVisualNovelDisplayItemImageT>();
		}

		// Token: 0x06037BB7 RID: 228279 RVA: 0x00788A8B File Offset: 0x00786C8B
		public static TVisualNovelDisplayItemUnion FromIVisualNovelDisplayItemImage(IVisualNovelDisplayItemImageT _ivisualnoveldisplayitemimage)
		{
			return new TVisualNovelDisplayItemUnion
			{
				Type = TVisualNovelDisplayItem.IVisualNovelDisplayItemImage,
				Value = _ivisualnoveldisplayitemimage
			};
		}

		// Token: 0x06037BB8 RID: 228280 RVA: 0x00788AA0 File Offset: 0x00786CA0
		public IVisualNovelDisplayItemPrefabT AsIVisualNovelDisplayItemPrefab()
		{
			return this.As<IVisualNovelDisplayItemPrefabT>();
		}

		// Token: 0x06037BB9 RID: 228281 RVA: 0x00788AA8 File Offset: 0x00786CA8
		public static TVisualNovelDisplayItemUnion FromIVisualNovelDisplayItemPrefab(IVisualNovelDisplayItemPrefabT _ivisualnoveldisplayitemprefab)
		{
			return new TVisualNovelDisplayItemUnion
			{
				Type = TVisualNovelDisplayItem.IVisualNovelDisplayItemPrefab,
				Value = _ivisualnoveldisplayitemprefab
			};
		}

		// Token: 0x06037BBA RID: 228282 RVA: 0x00788AC0 File Offset: 0x00786CC0
		public static int Pack(FlatBufferBuilder builder, TVisualNovelDisplayItemUnion _o)
		{
			switch (_o.Type)
			{
			case TVisualNovelDisplayItem.IVisualNovelDisplayItemClose:
				return IVisualNovelDisplayItemClose.Pack(builder, _o.AsIVisualNovelDisplayItemClose()).Value;
			case TVisualNovelDisplayItem.IVisualNovelDisplayItemImage:
				return IVisualNovelDisplayItemImage.Pack(builder, _o.AsIVisualNovelDisplayItemImage()).Value;
			case TVisualNovelDisplayItem.IVisualNovelDisplayItemPrefab:
				return IVisualNovelDisplayItemPrefab.Pack(builder, _o.AsIVisualNovelDisplayItemPrefab()).Value;
			default:
				return 0;
			}
		}
	}
}
