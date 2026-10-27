using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004513 RID: 17683
	public class ILevelPlayRefresh_UnionUnion
	{
		// Token: 0x17007D5D RID: 32093
		// (get) Token: 0x0601A91D RID: 108829 RVA: 0x003CB582 File Offset: 0x003C9782
		// (set) Token: 0x0601A91E RID: 108830 RVA: 0x003CB58A File Offset: 0x003C978A
		public ILevelPlayRefresh_Union Type { get; set; }

		// Token: 0x17007D5E RID: 32094
		// (get) Token: 0x0601A91F RID: 108831 RVA: 0x003CB593 File Offset: 0x003C9793
		// (set) Token: 0x0601A920 RID: 108832 RVA: 0x003CB59B File Offset: 0x003C979B
		public object Value { get; set; }

		// Token: 0x0601A921 RID: 108833 RVA: 0x003CB5A4 File Offset: 0x003C97A4
		public ILevelPlayRefresh_UnionUnion()
		{
			this.Type = ILevelPlayRefresh_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A922 RID: 108834 RVA: 0x003CB5BA File Offset: 0x003C97BA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A923 RID: 108835 RVA: 0x003CB5CC File Offset: 0x003C97CC
		public ILevelPlayRefreshT AsILevelPlayRefresh()
		{
			return this.As<ILevelPlayRefreshT>();
		}

		// Token: 0x0601A924 RID: 108836 RVA: 0x003CB5D4 File Offset: 0x003C97D4
		public static ILevelPlayRefresh_UnionUnion FromILevelPlayRefresh(ILevelPlayRefreshT _ilevelplayrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.ILevelPlayRefresh,
				Value = _ilevelplayrefresh
			};
		}

		// Token: 0x0601A925 RID: 108837 RVA: 0x003CB5E9 File Offset: 0x003C97E9
		public INoneRefreshT AsINoneRefresh()
		{
			return this.As<INoneRefreshT>();
		}

		// Token: 0x0601A926 RID: 108838 RVA: 0x003CB5F1 File Offset: 0x003C97F1
		public static ILevelPlayRefresh_UnionUnion FromINoneRefresh(INoneRefreshT _inonerefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.INoneRefresh,
				Value = _inonerefresh
			};
		}

		// Token: 0x0601A927 RID: 108839 RVA: 0x003CB606 File Offset: 0x003C9806
		public ICompletedRefreshT AsICompletedRefresh()
		{
			return this.As<ICompletedRefreshT>();
		}

		// Token: 0x0601A928 RID: 108840 RVA: 0x003CB60E File Offset: 0x003C980E
		public static ILevelPlayRefresh_UnionUnion FromICompletedRefresh(ICompletedRefreshT _icompletedrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.ICompletedRefresh,
				Value = _icompletedrefresh
			};
		}

		// Token: 0x0601A929 RID: 108841 RVA: 0x003CB623 File Offset: 0x003C9823
		public IChildDestroyRefreshT AsIChildDestroyRefresh()
		{
			return this.As<IChildDestroyRefreshT>();
		}

		// Token: 0x0601A92A RID: 108842 RVA: 0x003CB62B File Offset: 0x003C982B
		public static ILevelPlayRefresh_UnionUnion FromIChildDestroyRefresh(IChildDestroyRefreshT _ichilddestroyrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.IChildDestroyRefresh,
				Value = _ichilddestroyrefresh
			};
		}

		// Token: 0x0601A92B RID: 108843 RVA: 0x003CB640 File Offset: 0x003C9840
		public IChildDestroyOrAwardedRefreshT AsIChildDestroyOrAwardedRefresh()
		{
			return this.As<IChildDestroyOrAwardedRefreshT>();
		}

		// Token: 0x0601A92C RID: 108844 RVA: 0x003CB648 File Offset: 0x003C9848
		public static ILevelPlayRefresh_UnionUnion FromIChildDestroyOrAwardedRefresh(IChildDestroyOrAwardedRefreshT _ichilddestroyorawardedrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.IChildDestroyOrAwardedRefresh,
				Value = _ichilddestroyorawardedrefresh
			};
		}

		// Token: 0x0601A92D RID: 108845 RVA: 0x003CB65D File Offset: 0x003C985D
		public IFixedDateTimeRefreshT AsIFixedDateTimeRefresh()
		{
			return this.As<IFixedDateTimeRefreshT>();
		}

		// Token: 0x0601A92E RID: 108846 RVA: 0x003CB665 File Offset: 0x003C9865
		public static ILevelPlayRefresh_UnionUnion FromIFixedDateTimeRefresh(IFixedDateTimeRefreshT _ifixeddatetimerefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.IFixedDateTimeRefresh,
				Value = _ifixeddatetimerefresh
			};
		}

		// Token: 0x0601A92F RID: 108847 RVA: 0x003CB67A File Offset: 0x003C987A
		public ICustomRefreshT AsICustomRefresh()
		{
			return this.As<ICustomRefreshT>();
		}

		// Token: 0x0601A930 RID: 108848 RVA: 0x003CB682 File Offset: 0x003C9882
		public static ILevelPlayRefresh_UnionUnion FromICustomRefresh(ICustomRefreshT _icustomrefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.ICustomRefresh,
				Value = _icustomrefresh
			};
		}

		// Token: 0x0601A931 RID: 108849 RVA: 0x003CB697 File Offset: 0x003C9897
		public ICustomOnlineRefreshT AsICustomOnlineRefresh()
		{
			return this.As<ICustomOnlineRefreshT>();
		}

		// Token: 0x0601A932 RID: 108850 RVA: 0x003CB69F File Offset: 0x003C989F
		public static ILevelPlayRefresh_UnionUnion FromICustomOnlineRefresh(ICustomOnlineRefreshT _icustomonlinerefresh)
		{
			return new ILevelPlayRefresh_UnionUnion
			{
				Type = ILevelPlayRefresh_Union.ICustomOnlineRefresh,
				Value = _icustomonlinerefresh
			};
		}

		// Token: 0x0601A933 RID: 108851 RVA: 0x003CB6B4 File Offset: 0x003C98B4
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
