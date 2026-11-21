using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A89 RID: 19081
	public class TTwoDimensionItemUnion
	{
		// Token: 0x170085B6 RID: 34230
		// (get) Token: 0x0601CAEA RID: 117482 RVA: 0x0040B914 File Offset: 0x00409B14
		// (set) Token: 0x0601CAEB RID: 117483 RVA: 0x0040B91C File Offset: 0x00409B1C
		public TTwoDimensionItem Type { get; set; }

		// Token: 0x170085B7 RID: 34231
		// (get) Token: 0x0601CAEC RID: 117484 RVA: 0x0040B925 File Offset: 0x00409B25
		// (set) Token: 0x0601CAED RID: 117485 RVA: 0x0040B92D File Offset: 0x00409B2D
		public object Value { get; set; }

		// Token: 0x0601CAEE RID: 117486 RVA: 0x0040B936 File Offset: 0x00409B36
		public TTwoDimensionItemUnion()
		{
			this.Type = TTwoDimensionItem.NONE;
			this.Value = null;
		}

		// Token: 0x0601CAEF RID: 117487 RVA: 0x0040B94C File Offset: 0x00409B4C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CAF0 RID: 117488 RVA: 0x0040B95E File Offset: 0x00409B5E
		public IDangoBrawlBagT AsIDangoBrawlBag()
		{
			return this.As<IDangoBrawlBagT>();
		}

		// Token: 0x0601CAF1 RID: 117489 RVA: 0x0040B966 File Offset: 0x00409B66
		public static TTwoDimensionItemUnion FromIDangoBrawlBag(IDangoBrawlBagT _idangobrawlbag)
		{
			return new TTwoDimensionItemUnion
			{
				Type = TTwoDimensionItem.IDangoBrawlBag,
				Value = _idangobrawlbag
			};
		}

		// Token: 0x0601CAF2 RID: 117490 RVA: 0x0040B97B File Offset: 0x00409B7B
		public IDangoBrawlItemT AsIDangoBrawlItem()
		{
			return this.As<IDangoBrawlItemT>();
		}

		// Token: 0x0601CAF3 RID: 117491 RVA: 0x0040B983 File Offset: 0x00409B83
		public static TTwoDimensionItemUnion FromIDangoBrawlItem(IDangoBrawlItemT _idangobrawlitem)
		{
			return new TTwoDimensionItemUnion
			{
				Type = TTwoDimensionItem.IDangoBrawlItem,
				Value = _idangobrawlitem
			};
		}

		// Token: 0x0601CAF4 RID: 117492 RVA: 0x0040B998 File Offset: 0x00409B98
		public IMarbleCommonItemT AsIMarbleCommonItem()
		{
			return this.As<IMarbleCommonItemT>();
		}

		// Token: 0x0601CAF5 RID: 117493 RVA: 0x0040B9A0 File Offset: 0x00409BA0
		public static TTwoDimensionItemUnion FromIMarbleCommonItem(IMarbleCommonItemT _imarblecommonitem)
		{
			return new TTwoDimensionItemUnion
			{
				Type = TTwoDimensionItem.IMarbleCommonItem,
				Value = _imarblecommonitem
			};
		}

		// Token: 0x0601CAF6 RID: 117494 RVA: 0x0040B9B5 File Offset: 0x00409BB5
		public IMarbleSpawnPointT AsIMarbleSpawnPoint()
		{
			return this.As<IMarbleSpawnPointT>();
		}

		// Token: 0x0601CAF7 RID: 117495 RVA: 0x0040B9BD File Offset: 0x00409BBD
		public static TTwoDimensionItemUnion FromIMarbleSpawnPoint(IMarbleSpawnPointT _imarblespawnpoint)
		{
			return new TTwoDimensionItemUnion
			{
				Type = TTwoDimensionItem.IMarbleSpawnPoint,
				Value = _imarblespawnpoint
			};
		}

		// Token: 0x0601CAF8 RID: 117496 RVA: 0x0040B9D4 File Offset: 0x00409BD4
		public static int Pack(FlatBufferBuilder builder, TTwoDimensionItemUnion _o)
		{
			switch (_o.Type)
			{
			case TTwoDimensionItem.IDangoBrawlBag:
				return IDangoBrawlBag.Pack(builder, _o.AsIDangoBrawlBag()).Value;
			case TTwoDimensionItem.IDangoBrawlItem:
				return IDangoBrawlItem.Pack(builder, _o.AsIDangoBrawlItem()).Value;
			case TTwoDimensionItem.IMarbleCommonItem:
				return IMarbleCommonItem.Pack(builder, _o.AsIMarbleCommonItem()).Value;
			case TTwoDimensionItem.IMarbleSpawnPoint:
				return IMarbleSpawnPoint.Pack(builder, _o.AsIMarbleSpawnPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
