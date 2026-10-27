using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200757E RID: 30078
	public class IVisualNovelDisplayItemBase_UnionUnion
	{
		// Token: 0x1700E41C RID: 58396
		// (get) Token: 0x06036B76 RID: 224118 RVA: 0x0076DDD1 File Offset: 0x0076BFD1
		// (set) Token: 0x06036B77 RID: 224119 RVA: 0x0076DDD9 File Offset: 0x0076BFD9
		public IVisualNovelDisplayItemBase_Union Type { get; set; }

		// Token: 0x1700E41D RID: 58397
		// (get) Token: 0x06036B78 RID: 224120 RVA: 0x0076DDE2 File Offset: 0x0076BFE2
		// (set) Token: 0x06036B79 RID: 224121 RVA: 0x0076DDEA File Offset: 0x0076BFEA
		public object Value { get; set; }

		// Token: 0x06036B7A RID: 224122 RVA: 0x0076DDF3 File Offset: 0x0076BFF3
		public IVisualNovelDisplayItemBase_UnionUnion()
		{
			this.Type = IVisualNovelDisplayItemBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036B7B RID: 224123 RVA: 0x0076DE09 File Offset: 0x0076C009
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036B7C RID: 224124 RVA: 0x0076DE1B File Offset: 0x0076C01B
		public IVisualNovelDisplayItemBaseT AsIVisualNovelDisplayItemBase()
		{
			return this.As<IVisualNovelDisplayItemBaseT>();
		}

		// Token: 0x06036B7D RID: 224125 RVA: 0x0076DE23 File Offset: 0x0076C023
		public static IVisualNovelDisplayItemBase_UnionUnion FromIVisualNovelDisplayItemBase(IVisualNovelDisplayItemBaseT _ivisualnoveldisplayitembase)
		{
			return new IVisualNovelDisplayItemBase_UnionUnion
			{
				Type = IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemBase,
				Value = _ivisualnoveldisplayitembase
			};
		}

		// Token: 0x06036B7E RID: 224126 RVA: 0x0076DE38 File Offset: 0x0076C038
		public IVisualNovelDisplayItemImageT AsIVisualNovelDisplayItemImage()
		{
			return this.As<IVisualNovelDisplayItemImageT>();
		}

		// Token: 0x06036B7F RID: 224127 RVA: 0x0076DE40 File Offset: 0x0076C040
		public static IVisualNovelDisplayItemBase_UnionUnion FromIVisualNovelDisplayItemImage(IVisualNovelDisplayItemImageT _ivisualnoveldisplayitemimage)
		{
			return new IVisualNovelDisplayItemBase_UnionUnion
			{
				Type = IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemImage,
				Value = _ivisualnoveldisplayitemimage
			};
		}

		// Token: 0x06036B80 RID: 224128 RVA: 0x0076DE55 File Offset: 0x0076C055
		public IVisualNovelDisplayItemPrefabT AsIVisualNovelDisplayItemPrefab()
		{
			return this.As<IVisualNovelDisplayItemPrefabT>();
		}

		// Token: 0x06036B81 RID: 224129 RVA: 0x0076DE5D File Offset: 0x0076C05D
		public static IVisualNovelDisplayItemBase_UnionUnion FromIVisualNovelDisplayItemPrefab(IVisualNovelDisplayItemPrefabT _ivisualnoveldisplayitemprefab)
		{
			return new IVisualNovelDisplayItemBase_UnionUnion
			{
				Type = IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemPrefab,
				Value = _ivisualnoveldisplayitemprefab
			};
		}

		// Token: 0x06036B82 RID: 224130 RVA: 0x0076DE72 File Offset: 0x0076C072
		public IVisualNovelDisplayItemCloseT AsIVisualNovelDisplayItemClose()
		{
			return this.As<IVisualNovelDisplayItemCloseT>();
		}

		// Token: 0x06036B83 RID: 224131 RVA: 0x0076DE7A File Offset: 0x0076C07A
		public static IVisualNovelDisplayItemBase_UnionUnion FromIVisualNovelDisplayItemClose(IVisualNovelDisplayItemCloseT _ivisualnoveldisplayitemclose)
		{
			return new IVisualNovelDisplayItemBase_UnionUnion
			{
				Type = IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemClose,
				Value = _ivisualnoveldisplayitemclose
			};
		}

		// Token: 0x06036B84 RID: 224132 RVA: 0x0076DE90 File Offset: 0x0076C090
		public static int Pack(FlatBufferBuilder builder, IVisualNovelDisplayItemBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemBase:
				return IVisualNovelDisplayItemBase.Pack(builder, _o.AsIVisualNovelDisplayItemBase()).Value;
			case IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemImage:
				return IVisualNovelDisplayItemImage.Pack(builder, _o.AsIVisualNovelDisplayItemImage()).Value;
			case IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemPrefab:
				return IVisualNovelDisplayItemPrefab.Pack(builder, _o.AsIVisualNovelDisplayItemPrefab()).Value;
			case IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemClose:
				return IVisualNovelDisplayItemClose.Pack(builder, _o.AsIVisualNovelDisplayItemClose()).Value;
			default:
				return 0;
			}
		}
	}
}
