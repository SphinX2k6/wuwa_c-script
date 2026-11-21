using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A47 RID: 19015
	public class ITwoDimensionItemBase_UnionUnion
	{
		// Token: 0x1700856B RID: 34155
		// (get) Token: 0x0601C900 RID: 116992 RVA: 0x00407D87 File Offset: 0x00405F87
		// (set) Token: 0x0601C901 RID: 116993 RVA: 0x00407D8F File Offset: 0x00405F8F
		public ITwoDimensionItemBase_Union Type { get; set; }

		// Token: 0x1700856C RID: 34156
		// (get) Token: 0x0601C902 RID: 116994 RVA: 0x00407D98 File Offset: 0x00405F98
		// (set) Token: 0x0601C903 RID: 116995 RVA: 0x00407DA0 File Offset: 0x00405FA0
		public object Value { get; set; }

		// Token: 0x0601C904 RID: 116996 RVA: 0x00407DA9 File Offset: 0x00405FA9
		public ITwoDimensionItemBase_UnionUnion()
		{
			this.Type = ITwoDimensionItemBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C905 RID: 116997 RVA: 0x00407DBF File Offset: 0x00405FBF
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C906 RID: 116998 RVA: 0x00407DD1 File Offset: 0x00405FD1
		public ITwoDimensionItemBaseT AsITwoDimensionItemBase()
		{
			return this.As<ITwoDimensionItemBaseT>();
		}

		// Token: 0x0601C907 RID: 116999 RVA: 0x00407DD9 File Offset: 0x00405FD9
		public static ITwoDimensionItemBase_UnionUnion FromITwoDimensionItemBase(ITwoDimensionItemBaseT _itwodimensionitembase)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.ITwoDimensionItemBase,
				Value = _itwodimensionitembase
			};
		}

		// Token: 0x0601C908 RID: 117000 RVA: 0x00407DEE File Offset: 0x00405FEE
		public IMarbleItemLevelBaseT AsIMarbleItemLevelBase()
		{
			return this.As<IMarbleItemLevelBaseT>();
		}

		// Token: 0x0601C909 RID: 117001 RVA: 0x00407DF6 File Offset: 0x00405FF6
		public static ITwoDimensionItemBase_UnionUnion FromIMarbleItemLevelBase(IMarbleItemLevelBaseT _imarbleitemlevelbase)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IMarbleItemLevelBase,
				Value = _imarbleitemlevelbase
			};
		}

		// Token: 0x0601C90A RID: 117002 RVA: 0x00407E0B File Offset: 0x0040600B
		public IMarbleCommonItemT AsIMarbleCommonItem()
		{
			return this.As<IMarbleCommonItemT>();
		}

		// Token: 0x0601C90B RID: 117003 RVA: 0x00407E13 File Offset: 0x00406013
		public static ITwoDimensionItemBase_UnionUnion FromIMarbleCommonItem(IMarbleCommonItemT _imarblecommonitem)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IMarbleCommonItem,
				Value = _imarblecommonitem
			};
		}

		// Token: 0x0601C90C RID: 117004 RVA: 0x00407E28 File Offset: 0x00406028
		public IMarbleSpawnPointT AsIMarbleSpawnPoint()
		{
			return this.As<IMarbleSpawnPointT>();
		}

		// Token: 0x0601C90D RID: 117005 RVA: 0x00407E30 File Offset: 0x00406030
		public static ITwoDimensionItemBase_UnionUnion FromIMarbleSpawnPoint(IMarbleSpawnPointT _imarblespawnpoint)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IMarbleSpawnPoint,
				Value = _imarblespawnpoint
			};
		}

		// Token: 0x0601C90E RID: 117006 RVA: 0x00407E45 File Offset: 0x00406045
		public IDangoBrawlObjectBaseT AsIDangoBrawlObjectBase()
		{
			return this.As<IDangoBrawlObjectBaseT>();
		}

		// Token: 0x0601C90F RID: 117007 RVA: 0x00407E4D File Offset: 0x0040604D
		public static ITwoDimensionItemBase_UnionUnion FromIDangoBrawlObjectBase(IDangoBrawlObjectBaseT _idangobrawlobjectbase)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IDangoBrawlObjectBase,
				Value = _idangobrawlobjectbase
			};
		}

		// Token: 0x0601C910 RID: 117008 RVA: 0x00407E62 File Offset: 0x00406062
		public IDangoBrawlBagT AsIDangoBrawlBag()
		{
			return this.As<IDangoBrawlBagT>();
		}

		// Token: 0x0601C911 RID: 117009 RVA: 0x00407E6A File Offset: 0x0040606A
		public static ITwoDimensionItemBase_UnionUnion FromIDangoBrawlBag(IDangoBrawlBagT _idangobrawlbag)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IDangoBrawlBag,
				Value = _idangobrawlbag
			};
		}

		// Token: 0x0601C912 RID: 117010 RVA: 0x00407E7F File Offset: 0x0040607F
		public IDangoBrawlItemT AsIDangoBrawlItem()
		{
			return this.As<IDangoBrawlItemT>();
		}

		// Token: 0x0601C913 RID: 117011 RVA: 0x00407E87 File Offset: 0x00406087
		public static ITwoDimensionItemBase_UnionUnion FromIDangoBrawlItem(IDangoBrawlItemT _idangobrawlitem)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IDangoBrawlItem,
				Value = _idangobrawlitem
			};
		}

		// Token: 0x0601C914 RID: 117012 RVA: 0x00407E9C File Offset: 0x0040609C
		public static int Pack(FlatBufferBuilder builder, ITwoDimensionItemBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITwoDimensionItemBase_Union.ITwoDimensionItemBase:
				return ITwoDimensionItemBase.Pack(builder, _o.AsITwoDimensionItemBase()).Value;
			case ITwoDimensionItemBase_Union.IMarbleItemLevelBase:
				return IMarbleItemLevelBase.Pack(builder, _o.AsIMarbleItemLevelBase()).Value;
			case ITwoDimensionItemBase_Union.IMarbleCommonItem:
				return IMarbleCommonItem.Pack(builder, _o.AsIMarbleCommonItem()).Value;
			case ITwoDimensionItemBase_Union.IMarbleSpawnPoint:
				return IMarbleSpawnPoint.Pack(builder, _o.AsIMarbleSpawnPoint()).Value;
			case ITwoDimensionItemBase_Union.IDangoBrawlObjectBase:
				return IDangoBrawlObjectBase.Pack(builder, _o.AsIDangoBrawlObjectBase()).Value;
			case ITwoDimensionItemBase_Union.IDangoBrawlBag:
				return IDangoBrawlBag.Pack(builder, _o.AsIDangoBrawlBag()).Value;
			case ITwoDimensionItemBase_Union.IDangoBrawlItem:
				return IDangoBrawlItem.Pack(builder, _o.AsIDangoBrawlItem()).Value;
			default:
				return 0;
			}
		}
	}
}
