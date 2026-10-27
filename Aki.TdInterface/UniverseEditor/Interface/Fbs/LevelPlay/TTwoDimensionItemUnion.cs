using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004621 RID: 17953
	public class TTwoDimensionItemUnion
	{
		// Token: 0x17007F75 RID: 32629
		// (get) Token: 0x0601B315 RID: 111381 RVA: 0x003DF678 File Offset: 0x003DD878
		// (set) Token: 0x0601B316 RID: 111382 RVA: 0x003DF680 File Offset: 0x003DD880
		public TTwoDimensionItem Type { get; set; }

		// Token: 0x17007F76 RID: 32630
		// (get) Token: 0x0601B317 RID: 111383 RVA: 0x003DF689 File Offset: 0x003DD889
		// (set) Token: 0x0601B318 RID: 111384 RVA: 0x003DF691 File Offset: 0x003DD891
		public object Value { get; set; }

		// Token: 0x0601B319 RID: 111385 RVA: 0x003DF69A File Offset: 0x003DD89A
		public TTwoDimensionItemUnion()
		{
			this.Type = TTwoDimensionItem.NONE;
			this.Value = null;
		}

		// Token: 0x0601B31A RID: 111386 RVA: 0x003DF6B0 File Offset: 0x003DD8B0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B31B RID: 111387 RVA: 0x003DF6C2 File Offset: 0x003DD8C2
		public IDangoBrawlBagT AsIDangoBrawlBag()
		{
			return this.As<IDangoBrawlBagT>();
		}

		// Token: 0x0601B31C RID: 111388 RVA: 0x003DF6CA File Offset: 0x003DD8CA
		public static TTwoDimensionItemUnion FromIDangoBrawlBag(IDangoBrawlBagT _idangobrawlbag)
		{
			return new TTwoDimensionItemUnion
			{
				Type = TTwoDimensionItem.IDangoBrawlBag,
				Value = _idangobrawlbag
			};
		}

		// Token: 0x0601B31D RID: 111389 RVA: 0x003DF6DF File Offset: 0x003DD8DF
		public IDangoBrawlItemT AsIDangoBrawlItem()
		{
			return this.As<IDangoBrawlItemT>();
		}

		// Token: 0x0601B31E RID: 111390 RVA: 0x003DF6E7 File Offset: 0x003DD8E7
		public static TTwoDimensionItemUnion FromIDangoBrawlItem(IDangoBrawlItemT _idangobrawlitem)
		{
			return new TTwoDimensionItemUnion
			{
				Type = TTwoDimensionItem.IDangoBrawlItem,
				Value = _idangobrawlitem
			};
		}

		// Token: 0x0601B31F RID: 111391 RVA: 0x003DF6FC File Offset: 0x003DD8FC
		public IMarbleCommonItemT AsIMarbleCommonItem()
		{
			return this.As<IMarbleCommonItemT>();
		}

		// Token: 0x0601B320 RID: 111392 RVA: 0x003DF704 File Offset: 0x003DD904
		public static TTwoDimensionItemUnion FromIMarbleCommonItem(IMarbleCommonItemT _imarblecommonitem)
		{
			return new TTwoDimensionItemUnion
			{
				Type = TTwoDimensionItem.IMarbleCommonItem,
				Value = _imarblecommonitem
			};
		}

		// Token: 0x0601B321 RID: 111393 RVA: 0x003DF719 File Offset: 0x003DD919
		public IMarbleSpawnPointT AsIMarbleSpawnPoint()
		{
			return this.As<IMarbleSpawnPointT>();
		}

		// Token: 0x0601B322 RID: 111394 RVA: 0x003DF721 File Offset: 0x003DD921
		public static TTwoDimensionItemUnion FromIMarbleSpawnPoint(IMarbleSpawnPointT _imarblespawnpoint)
		{
			return new TTwoDimensionItemUnion
			{
				Type = TTwoDimensionItem.IMarbleSpawnPoint,
				Value = _imarblespawnpoint
			};
		}

		// Token: 0x0601B323 RID: 111395 RVA: 0x003DF738 File Offset: 0x003DD938
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
