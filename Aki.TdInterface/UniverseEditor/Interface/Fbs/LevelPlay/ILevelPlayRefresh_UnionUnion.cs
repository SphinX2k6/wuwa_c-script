using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200497B RID: 18811
	public class ILevelPlayRefresh_UnionUnion
	{
		// Token: 0x1700839E RID: 33694
		// (get) Token: 0x0601C0F2 RID: 114930 RVA: 0x003F781E File Offset: 0x003F5A1E
		// (set) Token: 0x0601C0F3 RID: 114931 RVA: 0x003F7826 File Offset: 0x003F5A26
		public ILevelPlayRefresh_Union Type { get; set; }

		// Token: 0x1700839F RID: 33695
		// (get) Token: 0x0601C0F4 RID: 114932 RVA: 0x003F782F File Offset: 0x003F5A2F
		// (set) Token: 0x0601C0F5 RID: 114933 RVA: 0x003F7837 File Offset: 0x003F5A37
		public object Value { get; set; }

		// Token: 0x0601C0F6 RID: 114934 RVA: 0x003F7840 File Offset: 0x003F5A40
		public ILevelPlayRefresh_UnionUnion()
		{
			this.Type = ILevelPlayRefresh_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C0F7 RID: 114935 RVA: 0x003F7856 File Offset: 0x003F5A56
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C0F8 RID: 114936 RVA: 0x003F7868 File Offset: 0x003F5A68
		public ILevelPlayRefreshT AsILevelPlayRefresh()
		{
			return this.As<ILevelPlayRefreshT>();
		}

		// Token: 0x0601C0F9 RID: 114937 RVA: 0x003F7870 File Offset: 0x003F5A70
		public static ILevelPlayRefresh_UnionUnion FromILevelPlayRefresh(ILevelPlayRefreshT _ilevelplayrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.ILevelPlayRefresh,
				Value = _ilevelplayrefresh
			};
		}

		// Token: 0x0601C0FA RID: 114938 RVA: 0x003F7885 File Offset: 0x003F5A85
		public INoneRefreshT AsINoneRefresh()
		{
			return this.As<INoneRefreshT>();
		}

		// Token: 0x0601C0FB RID: 114939 RVA: 0x003F788D File Offset: 0x003F5A8D
		public static ILevelPlayRefresh_UnionUnion FromINoneRefresh(INoneRefreshT _inonerefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.INoneRefresh,
				Value = _inonerefresh
			};
		}

		// Token: 0x0601C0FC RID: 114940 RVA: 0x003F78A2 File Offset: 0x003F5AA2
		public ICompletedRefreshT AsICompletedRefresh()
		{
			return this.As<ICompletedRefreshT>();
		}

		// Token: 0x0601C0FD RID: 114941 RVA: 0x003F78AA File Offset: 0x003F5AAA
		public static ILevelPlayRefresh_UnionUnion FromICompletedRefresh(ICompletedRefreshT _icompletedrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.ICompletedRefresh,
				Value = _icompletedrefresh
			};
		}

		// Token: 0x0601C0FE RID: 114942 RVA: 0x003F78BF File Offset: 0x003F5ABF
		public IChildDestroyRefreshT AsIChildDestroyRefresh()
		{
			return this.As<IChildDestroyRefreshT>();
		}

		// Token: 0x0601C0FF RID: 114943 RVA: 0x003F78C7 File Offset: 0x003F5AC7
		public static ILevelPlayRefresh_UnionUnion FromIChildDestroyRefresh(IChildDestroyRefreshT _ichilddestroyrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.IChildDestroyRefresh,
				Value = _ichilddestroyrefresh
			};
		}

		// Token: 0x0601C100 RID: 114944 RVA: 0x003F78DC File Offset: 0x003F5ADC
		public IChildDestroyOrAwardedRefreshT AsIChildDestroyOrAwardedRefresh()
		{
			return this.As<IChildDestroyOrAwardedRefreshT>();
		}

		// Token: 0x0601C101 RID: 114945 RVA: 0x003F78E4 File Offset: 0x003F5AE4
		public static ILevelPlayRefresh_UnionUnion FromIChildDestroyOrAwardedRefresh(IChildDestroyOrAwardedRefreshT _ichilddestroyorawardedrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.IChildDestroyOrAwardedRefresh,
				Value = _ichilddestroyorawardedrefresh
			};
		}

		// Token: 0x0601C102 RID: 114946 RVA: 0x003F78F9 File Offset: 0x003F5AF9
		public IFixedDateTimeRefreshT AsIFixedDateTimeRefresh()
		{
			return this.As<IFixedDateTimeRefreshT>();
		}

		// Token: 0x0601C103 RID: 114947 RVA: 0x003F7901 File Offset: 0x003F5B01
		public static ILevelPlayRefresh_UnionUnion FromIFixedDateTimeRefresh(IFixedDateTimeRefreshT _ifixeddatetimerefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.IFixedDateTimeRefresh,
				Value = _ifixeddatetimerefresh
			};
		}

		// Token: 0x0601C104 RID: 114948 RVA: 0x003F7916 File Offset: 0x003F5B16
		public ICustomRefreshT AsICustomRefresh()
		{
			return this.As<ICustomRefreshT>();
		}

		// Token: 0x0601C105 RID: 114949 RVA: 0x003F791E File Offset: 0x003F5B1E
		public static ILevelPlayRefresh_UnionUnion FromICustomRefresh(ICustomRefreshT _icustomrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.ICustomRefresh,
				Value = _icustomrefresh
			};
		}

		// Token: 0x0601C106 RID: 114950 RVA: 0x003F7933 File Offset: 0x003F5B33
		public ICustomOnlineRefreshT AsICustomOnlineRefresh()
		{
			return this.As<ICustomOnlineRefreshT>();
		}

		// Token: 0x0601C107 RID: 114951 RVA: 0x003F793B File Offset: 0x003F5B3B
		public static ILevelPlayRefresh_UnionUnion FromICustomOnlineRefresh(ICustomOnlineRefreshT _icustomonlinerefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.ICustomOnlineRefresh,
				Value = _icustomonlinerefresh
			};
		}

		// Token: 0x0601C108 RID: 114952 RVA: 0x003F7950 File Offset: 0x003F5B50
		public static int Pack(FlatBufferBuilder builder, ILevelPlayRefresh_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILevelPlayRefresh_Union.ILevelPlayRefresh:
				return ILevelPlayRefresh.Pack(builder, _o.AsILevelPlayRefresh()).Value;
			case ILevelPlayRefresh_Union.INoneRefresh:
				return INoneRefresh.Pack(builder, _o.AsINoneRefresh()).Value;
			case ILevelPlayRefresh_Union.ICompletedRefresh:
				return ICompletedRefresh.Pack(builder, _o.AsICompletedRefresh()).Value;
			case ILevelPlayRefresh_Union.IChildDestroyRefresh:
				return IChildDestroyRefresh.Pack(builder, _o.AsIChildDestroyRefresh()).Value;
			case ILevelPlayRefresh_Union.IChildDestroyOrAwardedRefresh:
				return IChildDestroyOrAwardedRefresh.Pack(builder, _o.AsIChildDestroyOrAwardedRefresh()).Value;
			case ILevelPlayRefresh_Union.IFixedDateTimeRefresh:
				return IFixedDateTimeRefresh.Pack(builder, _o.AsIFixedDateTimeRefresh()).Value;
			case ILevelPlayRefresh_Union.ICustomRefresh:
				return ICustomRefresh.Pack(builder, _o.AsICustomRefresh()).Value;
			case ILevelPlayRefresh_Union.ICustomOnlineRefresh:
				return ICustomOnlineRefresh.Pack(builder, _o.AsICustomOnlineRefresh()).Value;
			default:
				return 0;
			}
		}
	}
}
