using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E2 RID: 8418
	public class ISplineWayPoint
	{
		// Token: 0x0600B2B8 RID: 45752 RVA: 0x00191418 File Offset: 0x0018F618
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

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x00191450 File Offset: 0x0018F650
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

		// Token: 0x0600B2BA RID: 45754 RVA: 0x00191463 File Offset: 0x0018F663
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

		// Token: 0x0600B2BB RID: 45755 RVA: 0x00191476 File Offset: 0x0018F676
		public ISplineWayPoint_SetValue ToSetValue()
		{
			return new ISplineWayPoint_SetValue
			{
				Spline = this.Spline,
				PointId = this.PointId
			};
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600B2BC RID: 45756 RVA: 0x00191495 File Offset: 0x0018F695
		// (set) Token: 0x0600B2BD RID: 45757 RVA: 0x001914C0 File Offset: 0x0018F6C0
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

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600B2BE RID: 45758 RVA: 0x001914CE File Offset: 0x0018F6CE
		// (set) Token: 0x0600B2BF RID: 45759 RVA: 0x001914F9 File Offset: 0x0018F6F9
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

		// Token: 0x04006A03 RID: 27139
		[Nullable(2)]
		protected ISplineWayPoint FbInstance;

		// Token: 0x04006A04 RID: 27140
		[Nullable(2)]
		protected ISplineWayPoint_SetValue PocoInterface;
	}
}
