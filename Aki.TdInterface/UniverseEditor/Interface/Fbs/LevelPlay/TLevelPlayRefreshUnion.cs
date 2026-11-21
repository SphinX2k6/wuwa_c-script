using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A74 RID: 19060
	public class TLevelPlayRefreshUnion
	{
		// Token: 0x170085A8 RID: 34216
		// (get) Token: 0x0601CA74 RID: 117364 RVA: 0x0040AD84 File Offset: 0x00408F84
		// (set) Token: 0x0601CA75 RID: 117365 RVA: 0x0040AD8C File Offset: 0x00408F8C
		public TLevelPlayRefresh Type { get; set; }

		// Token: 0x170085A9 RID: 34217
		// (get) Token: 0x0601CA76 RID: 117366 RVA: 0x0040AD95 File Offset: 0x00408F95
		// (set) Token: 0x0601CA77 RID: 117367 RVA: 0x0040AD9D File Offset: 0x00408F9D
		public object Value { get; set; }

		// Token: 0x0601CA78 RID: 117368 RVA: 0x0040ADA6 File Offset: 0x00408FA6
		public TLevelPlayRefreshUnion()
		{
			this.Type = TLevelPlayRefresh.NONE;
			this.Value = null;
		}

		// Token: 0x0601CA79 RID: 117369 RVA: 0x0040ADBC File Offset: 0x00408FBC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CA7A RID: 117370 RVA: 0x0040ADCE File Offset: 0x00408FCE
		public IChildDestroyOrAwardedRefreshT AsIChildDestroyOrAwardedRefresh()
		{
			return this.As<IChildDestroyOrAwardedRefreshT>();
		}

		// Token: 0x0601CA7B RID: 117371 RVA: 0x0040ADD6 File Offset: 0x00408FD6
		public static TLevelPlayRefreshUnion FromIChildDestroyOrAwardedRefresh(IChildDestroyOrAwardedRefreshT _ichilddestroyorawardedrefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.IChildDestroyOrAwardedRefresh,
				Value = _ichilddestroyorawardedrefresh
			};
		}

		// Token: 0x0601CA7C RID: 117372 RVA: 0x0040ADEB File Offset: 0x00408FEB
		public IChildDestroyRefreshT AsIChildDestroyRefresh()
		{
			return this.As<IChildDestroyRefreshT>();
		}

		// Token: 0x0601CA7D RID: 117373 RVA: 0x0040ADF3 File Offset: 0x00408FF3
		public static TLevelPlayRefreshUnion FromIChildDestroyRefresh(IChildDestroyRefreshT _ichilddestroyrefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.IChildDestroyRefresh,
				Value = _ichilddestroyrefresh
			};
		}

		// Token: 0x0601CA7E RID: 117374 RVA: 0x0040AE08 File Offset: 0x00409008
		public ICompletedRefreshT AsICompletedRefresh()
		{
			return this.As<ICompletedRefreshT>();
		}

		// Token: 0x0601CA7F RID: 117375 RVA: 0x0040AE10 File Offset: 0x00409010
		public static TLevelPlayRefreshUnion FromICompletedRefresh(ICompletedRefreshT _icompletedrefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.ICompletedRefresh,
				Value = _icompletedrefresh
			};
		}

		// Token: 0x0601CA80 RID: 117376 RVA: 0x0040AE25 File Offset: 0x00409025
		public ICustomOnlineRefreshT AsICustomOnlineRefresh()
		{
			return this.As<ICustomOnlineRefreshT>();
		}

		// Token: 0x0601CA81 RID: 117377 RVA: 0x0040AE2D File Offset: 0x0040902D
		public static TLevelPlayRefreshUnion FromICustomOnlineRefresh(ICustomOnlineRefreshT _icustomonlinerefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.ICustomOnlineRefresh,
				Value = _icustomonlinerefresh
			};
		}

		// Token: 0x0601CA82 RID: 117378 RVA: 0x0040AE42 File Offset: 0x00409042
		public ICustomRefreshT AsICustomRefresh()
		{
			return this.As<ICustomRefreshT>();
		}

		// Token: 0x0601CA83 RID: 117379 RVA: 0x0040AE4A File Offset: 0x0040904A
		public static TLevelPlayRefreshUnion FromICustomRefresh(ICustomRefreshT _icustomrefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.ICustomRefresh,
				Value = _icustomrefresh
			};
		}

		// Token: 0x0601CA84 RID: 117380 RVA: 0x0040AE5F File Offset: 0x0040905F
		public IFixedDateTimeRefreshT AsIFixedDateTimeRefresh()
		{
			return this.As<IFixedDateTimeRefreshT>();
		}

		// Token: 0x0601CA85 RID: 117381 RVA: 0x0040AE67 File Offset: 0x00409067
		public static TLevelPlayRefreshUnion FromIFixedDateTimeRefresh(IFixedDateTimeRefreshT _ifixeddatetimerefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.IFixedDateTimeRefresh,
				Value = _ifixeddatetimerefresh
			};
		}

		// Token: 0x0601CA86 RID: 117382 RVA: 0x0040AE7C File Offset: 0x0040907C
		public INoneRefreshT AsINoneRefresh()
		{
			return this.As<INoneRefreshT>();
		}

		// Token: 0x0601CA87 RID: 117383 RVA: 0x0040AE84 File Offset: 0x00409084
		public static TLevelPlayRefreshUnion FromINoneRefresh(INoneRefreshT _inonerefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.INoneRefresh,
				Value = _inonerefresh
			};
		}

		// Token: 0x0601CA88 RID: 117384 RVA: 0x0040AE9C File Offset: 0x0040909C
		public static int Pack(FlatBufferBuilder builder, TLevelPlayRefreshUnion _o)
		{
			switch (_o.Type)
			{
			case TLevelPlayRefresh.IChildDestroyOrAwardedRefresh:
				return IChildDestroyOrAwardedRefresh.Pack(builder, _o.AsIChildDestroyOrAwardedRefresh()).Value;
			case TLevelPlayRefresh.IChildDestroyRefresh:
				return IChildDestroyRefresh.Pack(builder, _o.AsIChildDestroyRefresh()).Value;
			case TLevelPlayRefresh.ICompletedRefresh:
				return ICompletedRefresh.Pack(builder, _o.AsICompletedRefresh()).Value;
			case TLevelPlayRefresh.ICustomOnlineRefresh:
				return ICustomOnlineRefresh.Pack(builder, _o.AsICustomOnlineRefresh()).Value;
			case TLevelPlayRefresh.ICustomRefresh:
				return ICustomRefresh.Pack(builder, _o.AsICustomRefresh()).Value;
			case TLevelPlayRefresh.IFixedDateTimeRefresh:
				return IFixedDateTimeRefresh.Pack(builder, _o.AsIFixedDateTimeRefresh()).Value;
			case TLevelPlayRefresh.INoneRefresh:
				return INoneRefresh.Pack(builder, _o.AsINoneRefresh()).Value;
			default:
				return 0;
			}
		}
	}
}
