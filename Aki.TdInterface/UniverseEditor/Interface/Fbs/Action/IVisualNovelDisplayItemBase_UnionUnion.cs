using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D74 RID: 32116
	public class IVisualNovelDisplayItemBase_UnionUnion
	{
		// Token: 0x1700F04C RID: 61516
		// (get) Token: 0x06039F9E RID: 237470 RVA: 0x007D1375 File Offset: 0x007CF575
		// (set) Token: 0x06039F9F RID: 237471 RVA: 0x007D137D File Offset: 0x007CF57D
		public IVisualNovelDisplayItemBase_Union Type { get; set; }

		// Token: 0x1700F04D RID: 61517
		// (get) Token: 0x06039FA0 RID: 237472 RVA: 0x007D1386 File Offset: 0x007CF586
		// (set) Token: 0x06039FA1 RID: 237473 RVA: 0x007D138E File Offset: 0x007CF58E
		public object Value { get; set; }

		// Token: 0x06039FA2 RID: 237474 RVA: 0x007D1397 File Offset: 0x007CF597
		public IVisualNovelDisplayItemBase_UnionUnion()
		{
			this.Type = IVisualNovelDisplayItemBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039FA3 RID: 237475 RVA: 0x007D13AD File Offset: 0x007CF5AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039FA4 RID: 237476 RVA: 0x007D13BF File Offset: 0x007CF5BF
		public IVisualNovelDisplayItemBaseT AsIVisualNovelDisplayItemBase()
		{
			return this.As<IVisualNovelDisplayItemBaseT>();
		}

		// Token: 0x06039FA5 RID: 237477 RVA: 0x007D13C7 File Offset: 0x007CF5C7
		public static IVisualNovelDisplayItemBase_UnionUnion FromIVisualNovelDisplayItemBase(IVisualNovelDisplayItemBaseT _ivisualnoveldisplayitembase)
		{
			return new IVisualNovelDisplayItemBase_UnionUnion
			{
				Type = IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemBase,
				Value = _ivisualnoveldisplayitembase
			};
		}

		// Token: 0x06039FA6 RID: 237478 RVA: 0x007D13DC File Offset: 0x007CF5DC
		public IVisualNovelDisplayItemImageT AsIVisualNovelDisplayItemImage()
		{
			return this.As<IVisualNovelDisplayItemImageT>();
		}

		// Token: 0x06039FA7 RID: 237479 RVA: 0x007D13E4 File Offset: 0x007CF5E4
		public static IVisualNovelDisplayItemBase_UnionUnion FromIVisualNovelDisplayItemImage(IVisualNovelDisplayItemImageT _ivisualnoveldisplayitemimage)
		{
			return new IVisualNovelDisplayItemBase_UnionUnion
			{
				Type = IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemImage,
				Value = _ivisualnoveldisplayitemimage
			};
		}

		// Token: 0x06039FA8 RID: 237480 RVA: 0x007D13F9 File Offset: 0x007CF5F9
		public IVisualNovelDisplayItemPrefabT AsIVisualNovelDisplayItemPrefab()
		{
			return this.As<IVisualNovelDisplayItemPrefabT>();
		}

		// Token: 0x06039FA9 RID: 237481 RVA: 0x007D1401 File Offset: 0x007CF601
		public static IVisualNovelDisplayItemBase_UnionUnion FromIVisualNovelDisplayItemPrefab(IVisualNovelDisplayItemPrefabT _ivisualnoveldisplayitemprefab)
		{
			return new IVisualNovelDisplayItemBase_UnionUnion
			{
				Type = IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemPrefab,
				Value = _ivisualnoveldisplayitemprefab
			};
		}

		// Token: 0x06039FAA RID: 237482 RVA: 0x007D1416 File Offset: 0x007CF616
		public IVisualNovelDisplayItemCloseT AsIVisualNovelDisplayItemClose()
		{
			return this.As<IVisualNovelDisplayItemCloseT>();
		}

		// Token: 0x06039FAB RID: 237483 RVA: 0x007D141E File Offset: 0x007CF61E
		public static IVisualNovelDisplayItemBase_UnionUnion FromIVisualNovelDisplayItemClose(IVisualNovelDisplayItemCloseT _ivisualnoveldisplayitemclose)
		{
			return new IVisualNovelDisplayItemBase_UnionUnion
			{
				Type = IVisualNovelDisplayItemBase_Union.IVisualNovelDisplayItemClose,
				Value = _ivisualnoveldisplayitemclose
			};
		}

		// Token: 0x06039FAC RID: 237484 RVA: 0x007D1434 File Offset: 0x007CF634
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
