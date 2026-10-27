using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EA9 RID: 7849
	[NullableContext(1)]
	[Nullable(0)]
	public class ISplineWayPoint
	{
		// Token: 0x0600A7E8 RID: 42984 RVA: 0x0017B478 File Offset: 0x00179678
		private ISplineWayPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineWayPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineWayPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineWayPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x0017B4B0 File Offset: 0x001796B0
		public static ISplineWayPoint Create([Nullable(2)] ISplineWayPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineWayPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7EA RID: 42986 RVA: 0x0017B4C3 File Offset: 0x001796C3
		public static ISplineWayPoint CreateFromSetValue([Nullable(2)] ISplineWayPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineWayPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7EB RID: 42987 RVA: 0x0017B4D6 File Offset: 0x001796D6
		public ISplineWayPoint_SetValue ToSetValue()
		{
			return new ISplineWayPoint_SetValue
			{
				Spline = this.Spline,
				PointId = this.PointId
			};
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600A7EC RID: 42988 RVA: 0x0017B4F5 File Offset: 0x001796F5
		// (set) Token: 0x0600A7ED RID: 42989 RVA: 0x0017B520 File Offset: 0x00179720
		public virtual int Spline
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Spline;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Spline;
			}
			set
			{
				this.GetOrCreatePoco().Spline = value;
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600A7EE RID: 42990 RVA: 0x0017B52E File Offset: 0x0017972E
		// (set) Token: 0x0600A7EF RID: 42991 RVA: 0x0017B559 File Offset: 0x00179759
		public virtual int PointId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PointId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PointId;
			}
			set
			{
				this.GetOrCreatePoco().PointId = value;
			}
		}

		// Token: 0x04006415 RID: 25621
		[Nullable(2)]
		protected ISplineWayPoint FbInstance;

		// Token: 0x04006416 RID: 25622
		[Nullable(2)]
		protected ISplineWayPoint_SetValue PocoInterface;
	}
}
