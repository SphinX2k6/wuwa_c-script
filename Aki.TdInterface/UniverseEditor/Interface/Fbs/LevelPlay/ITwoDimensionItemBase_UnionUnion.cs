using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045DF RID: 17887
	public class ITwoDimensionItemBase_UnionUnion
	{
		// Token: 0x17007F2A RID: 32554
		// (get) Token: 0x0601B12B RID: 110891 RVA: 0x003DBAEB File Offset: 0x003D9CEB
		// (set) Token: 0x0601B12C RID: 110892 RVA: 0x003DBAF3 File Offset: 0x003D9CF3
		public ITwoDimensionItemBase_Union Type { get; set; }

		// Token: 0x17007F2B RID: 32555
		// (get) Token: 0x0601B12D RID: 110893 RVA: 0x003DBAFC File Offset: 0x003D9CFC
		// (set) Token: 0x0601B12E RID: 110894 RVA: 0x003DBB04 File Offset: 0x003D9D04
		public object Value { get; set; }

		// Token: 0x0601B12F RID: 110895 RVA: 0x003DBB0D File Offset: 0x003D9D0D
		public ITwoDimensionItemBase_UnionUnion()
		{
			this.Type = ITwoDimensionItemBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B130 RID: 110896 RVA: 0x003DBB23 File Offset: 0x003D9D23
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B131 RID: 110897 RVA: 0x003DBB35 File Offset: 0x003D9D35
		public ITwoDimensionItemBaseT AsITwoDimensionItemBase()
		{
			return this.As<ITwoDimensionItemBaseT>();
		}

		// Token: 0x0601B132 RID: 110898 RVA: 0x003DBB3D File Offset: 0x003D9D3D
		public static ITwoDimensionItemBase_UnionUnion FromITwoDimensionItemBase(ITwoDimensionItemBaseT _itwodimensionitembase)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.ITwoDimensionItemBase,
				Value = _itwodimensionitembase
			};
		}

		// Token: 0x0601B133 RID: 110899 RVA: 0x003DBB52 File Offset: 0x003D9D52
		public IMarbleItemLevelBaseT AsIMarbleItemLevelBase()
		{
			return this.As<IMarbleItemLevelBaseT>();
		}

		// Token: 0x0601B134 RID: 110900 RVA: 0x003DBB5A File Offset: 0x003D9D5A
		public static ITwoDimensionItemBase_UnionUnion FromIMarbleItemLevelBase(IMarbleItemLevelBaseT _imarbleitemlevelbase)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IMarbleItemLevelBase,
				Value = _imarbleitemlevelbase
			};
		}

		// Token: 0x0601B135 RID: 110901 RVA: 0x003DBB6F File Offset: 0x003D9D6F
		public IMarbleCommonItemT AsIMarbleCommonItem()
		{
			return this.As<IMarbleCommonItemT>();
		}

		// Token: 0x0601B136 RID: 110902 RVA: 0x003DBB77 File Offset: 0x003D9D77
		public static ITwoDimensionItemBase_UnionUnion FromIMarbleCommonItem(IMarbleCommonItemT _imarblecommonitem)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IMarbleCommonItem,
				Value = _imarblecommonitem
			};
		}

		// Token: 0x0601B137 RID: 110903 RVA: 0x003DBB8C File Offset: 0x003D9D8C
		public IMarbleSpawnPointT AsIMarbleSpawnPoint()
		{
			return this.As<IMarbleSpawnPointT>();
		}

		// Token: 0x0601B138 RID: 110904 RVA: 0x003DBB94 File Offset: 0x003D9D94
		public static ITwoDimensionItemBase_UnionUnion FromIMarbleSpawnPoint(IMarbleSpawnPointT _imarblespawnpoint)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IMarbleSpawnPoint,
				Value = _imarblespawnpoint
			};
		}

		// Token: 0x0601B139 RID: 110905 RVA: 0x003DBBA9 File Offset: 0x003D9DA9
		public IDangoBrawlObjectBaseT AsIDangoBrawlObjectBase()
		{
			return this.As<IDangoBrawlObjectBaseT>();
		}

		// Token: 0x0601B13A RID: 110906 RVA: 0x003DBBB1 File Offset: 0x003D9DB1
		public static ITwoDimensionItemBase_UnionUnion FromIDangoBrawlObjectBase(IDangoBrawlObjectBaseT _idangobrawlobjectbase)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IDangoBrawlObjectBase,
				Value = _idangobrawlobjectbase
			};
		}

		// Token: 0x0601B13B RID: 110907 RVA: 0x003DBBC6 File Offset: 0x003D9DC6
		public IDangoBrawlBagT AsIDangoBrawlBag()
		{
			return this.As<IDangoBrawlBagT>();
		}

		// Token: 0x0601B13C RID: 110908 RVA: 0x003DBBCE File Offset: 0x003D9DCE
		public static ITwoDimensionItemBase_UnionUnion FromIDangoBrawlBag(IDangoBrawlBagT _idangobrawlbag)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IDangoBrawlBag,
				Value = _idangobrawlbag
			};
		}

		// Token: 0x0601B13D RID: 110909 RVA: 0x003DBBE3 File Offset: 0x003D9DE3
		public IDangoBrawlItemT AsIDangoBrawlItem()
		{
			return this.As<IDangoBrawlItemT>();
		}

		// Token: 0x0601B13E RID: 110910 RVA: 0x003DBBEB File Offset: 0x003D9DEB
		public static ITwoDimensionItemBase_UnionUnion FromIDangoBrawlItem(IDangoBrawlItemT _idangobrawlitem)
		{
			return new ITwoDimensionItemBase_UnionUnion
			{
				Type = ITwoDimensionItemBase_Union.IDangoBrawlItem,
				Value = _idangobrawlitem
			};
		}

		// Token: 0x0601B13F RID: 110911 RVA: 0x003DBC00 File Offset: 0x003D9E00
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
