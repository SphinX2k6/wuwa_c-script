using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200804F RID: 32847
	public class TVisualNovelDisplayItemUnion
	{
		// Token: 0x1700F357 RID: 62295
		// (get) Token: 0x0603B153 RID: 242003 RVA: 0x007EE394 File Offset: 0x007EC594
		// (set) Token: 0x0603B154 RID: 242004 RVA: 0x007EE39C File Offset: 0x007EC59C
		public TVisualNovelDisplayItem Type { get; set; }

		// Token: 0x1700F358 RID: 62296
		// (get) Token: 0x0603B155 RID: 242005 RVA: 0x007EE3A5 File Offset: 0x007EC5A5
		// (set) Token: 0x0603B156 RID: 242006 RVA: 0x007EE3AD File Offset: 0x007EC5AD
		public object Value { get; set; }

		// Token: 0x0603B157 RID: 242007 RVA: 0x007EE3B6 File Offset: 0x007EC5B6
		public TVisualNovelDisplayItemUnion()
		{
			this.Type = TVisualNovelDisplayItem.NONE;
			this.Value = null;
		}

		// Token: 0x0603B158 RID: 242008 RVA: 0x007EE3CC File Offset: 0x007EC5CC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B159 RID: 242009 RVA: 0x007EE3DE File Offset: 0x007EC5DE
		public IVisualNovelDisplayItemCloseT AsIVisualNovelDisplayItemClose()
		{
			return this.As<IVisualNovelDisplayItemCloseT>();
		}

		// Token: 0x0603B15A RID: 242010 RVA: 0x007EE3E6 File Offset: 0x007EC5E6
		public static TVisualNovelDisplayItemUnion FromIVisualNovelDisplayItemClose(IVisualNovelDisplayItemCloseT _ivisualnoveldisplayitemclose)
		{
			return new TVisualNovelDisplayItemUnion
			{
				Type = TVisualNovelDisplayItem.IVisualNovelDisplayItemClose,
				Value = _ivisualnoveldisplayitemclose
			};
		}

		// Token: 0x0603B15B RID: 242011 RVA: 0x007EE3FB File Offset: 0x007EC5FB
		public IVisualNovelDisplayItemImageT AsIVisualNovelDisplayItemImage()
		{
			return this.As<IVisualNovelDisplayItemImageT>();
		}

		// Token: 0x0603B15C RID: 242012 RVA: 0x007EE403 File Offset: 0x007EC603
		public static TVisualNovelDisplayItemUnion FromIVisualNovelDisplayItemImage(IVisualNovelDisplayItemImageT _ivisualnoveldisplayitemimage)
		{
			return new TVisualNovelDisplayItemUnion
			{
				Type = TVisualNovelDisplayItem.IVisualNovelDisplayItemImage,
				Value = _ivisualnoveldisplayitemimage
			};
		}

		// Token: 0x0603B15D RID: 242013 RVA: 0x007EE418 File Offset: 0x007EC618
		public IVisualNovelDisplayItemPrefabT AsIVisualNovelDisplayItemPrefab()
		{
			return this.As<IVisualNovelDisplayItemPrefabT>();
		}

		// Token: 0x0603B15E RID: 242014 RVA: 0x007EE420 File Offset: 0x007EC620
		public static TVisualNovelDisplayItemUnion FromIVisualNovelDisplayItemPrefab(IVisualNovelDisplayItemPrefabT _ivisualnoveldisplayitemprefab)
		{
			return new TVisualNovelDisplayItemUnion
			{
				Type = TVisualNovelDisplayItem.IVisualNovelDisplayItemPrefab,
				Value = _ivisualnoveldisplayitemprefab
			};
		}

		// Token: 0x0603B15F RID: 242015 RVA: 0x007EE438 File Offset: 0x007EC638
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
