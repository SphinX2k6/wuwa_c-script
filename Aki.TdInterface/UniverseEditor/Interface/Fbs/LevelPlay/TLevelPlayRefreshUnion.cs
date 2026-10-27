using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200460C RID: 17932
	public class TLevelPlayRefreshUnion
	{
		// Token: 0x17007F67 RID: 32615
		// (get) Token: 0x0601B29F RID: 111263 RVA: 0x003DEAE8 File Offset: 0x003DCCE8
		// (set) Token: 0x0601B2A0 RID: 111264 RVA: 0x003DEAF0 File Offset: 0x003DCCF0
		public TLevelPlayRefresh Type { get; set; }

		// Token: 0x17007F68 RID: 32616
		// (get) Token: 0x0601B2A1 RID: 111265 RVA: 0x003DEAF9 File Offset: 0x003DCCF9
		// (set) Token: 0x0601B2A2 RID: 111266 RVA: 0x003DEB01 File Offset: 0x003DCD01
		public object Value { get; set; }

		// Token: 0x0601B2A3 RID: 111267 RVA: 0x003DEB0A File Offset: 0x003DCD0A
		public TLevelPlayRefreshUnion()
		{
			this.Type = TLevelPlayRefresh.NONE;
			this.Value = null;
		}

		// Token: 0x0601B2A4 RID: 111268 RVA: 0x003DEB20 File Offset: 0x003DCD20
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B2A5 RID: 111269 RVA: 0x003DEB32 File Offset: 0x003DCD32
		public IChildDestroyOrAwardedRefreshT AsIChildDestroyOrAwardedRefresh()
		{
			return this.As<IChildDestroyOrAwardedRefreshT>();
		}

		// Token: 0x0601B2A6 RID: 111270 RVA: 0x003DEB3A File Offset: 0x003DCD3A
		public static TLevelPlayRefreshUnion FromIChildDestroyOrAwardedRefresh(IChildDestroyOrAwardedRefreshT _ichilddestroyorawardedrefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.IChildDestroyOrAwardedRefresh,
				Value = _ichilddestroyorawardedrefresh
			};
		}

		// Token: 0x0601B2A7 RID: 111271 RVA: 0x003DEB4F File Offset: 0x003DCD4F
		public IChildDestroyRefreshT AsIChildDestroyRefresh()
		{
			return this.As<IChildDestroyRefreshT>();
		}

		// Token: 0x0601B2A8 RID: 111272 RVA: 0x003DEB57 File Offset: 0x003DCD57
		public static TLevelPlayRefreshUnion FromIChildDestroyRefresh(IChildDestroyRefreshT _ichilddestroyrefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.IChildDestroyRefresh,
				Value = _ichilddestroyrefresh
			};
		}

		// Token: 0x0601B2A9 RID: 111273 RVA: 0x003DEB6C File Offset: 0x003DCD6C
		public ICompletedRefreshT AsICompletedRefresh()
		{
			return this.As<ICompletedRefreshT>();
		}

		// Token: 0x0601B2AA RID: 111274 RVA: 0x003DEB74 File Offset: 0x003DCD74
		public static TLevelPlayRefreshUnion FromICompletedRefresh(ICompletedRefreshT _icompletedrefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.ICompletedRefresh,
				Value = _icompletedrefresh
			};
		}

		// Token: 0x0601B2AB RID: 111275 RVA: 0x003DEB89 File Offset: 0x003DCD89
		public ICustomOnlineRefreshT AsICustomOnlineRefresh()
		{
			return this.As<ICustomOnlineRefreshT>();
		}

		// Token: 0x0601B2AC RID: 111276 RVA: 0x003DEB91 File Offset: 0x003DCD91
		public static TLevelPlayRefreshUnion FromICustomOnlineRefresh(ICustomOnlineRefreshT _icustomonlinerefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.ICustomOnlineRefresh,
				Value = _icustomonlinerefresh
			};
		}

		// Token: 0x0601B2AD RID: 111277 RVA: 0x003DEBA6 File Offset: 0x003DCDA6
		public ICustomRefreshT AsICustomRefresh()
		{
			return this.As<ICustomRefreshT>();
		}

		// Token: 0x0601B2AE RID: 111278 RVA: 0x003DEBAE File Offset: 0x003DCDAE
		public static TLevelPlayRefreshUnion FromICustomRefresh(ICustomRefreshT _icustomrefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.ICustomRefresh,
				Value = _icustomrefresh
			};
		}

		// Token: 0x0601B2AF RID: 111279 RVA: 0x003DEBC3 File Offset: 0x003DCDC3
		public IFixedDateTimeRefreshT AsIFixedDateTimeRefresh()
		{
			return this.As<IFixedDateTimeRefreshT>();
		}

		// Token: 0x0601B2B0 RID: 111280 RVA: 0x003DEBCB File Offset: 0x003DCDCB
		public static TLevelPlayRefreshUnion FromIFixedDateTimeRefresh(IFixedDateTimeRefreshT _ifixeddatetimerefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.IFixedDateTimeRefresh,
				Value = _ifixeddatetimerefresh
			};
		}

		// Token: 0x0601B2B1 RID: 111281 RVA: 0x003DEBE0 File Offset: 0x003DCDE0
		public INoneRefreshT AsINoneRefresh()
		{
			return this.As<INoneRefreshT>();
		}

		// Token: 0x0601B2B2 RID: 111282 RVA: 0x003DEBE8 File Offset: 0x003DCDE8
		public static TLevelPlayRefreshUnion FromINoneRefresh(INoneRefreshT _inonerefresh)
		{
			return new TLevelPlayRefreshUnion
			{
				Type = TLevelPlayRefresh.INoneRefresh,
				Value = _inonerefresh
			};
		}

		// Token: 0x0601B2B3 RID: 111283 RVA: 0x003DEC00 File Offset: 0x003DCE00
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
