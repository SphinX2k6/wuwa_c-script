using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004CC RID: 1228
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftMoveCurve
	{
		// Token: 0x060018F0 RID: 6384 RVA: 0x0004A3B8 File Offset: 0x000485B8
		private ILiftMoveCurve_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftMoveCurve 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftMoveCurve_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftMoveCurve_SetValue());
			}
			return result;
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0004A3F0 File Offset: 0x000485F0
		public static ILiftMoveCurve Create([Nullable(2)] ILiftMoveCurve instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveCurve
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0004A403 File Offset: 0x00048603
		public static ILiftMoveCurve CreateFromSetValue([Nullable(2)] ILiftMoveCurve_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftMoveCurve
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0004A416 File Offset: 0x00048616
		public ILiftMoveCurve_SetValue ToSetValue()
		{
			return new ILiftMoveCurve_SetValue
			{
				Curve = this.Curve,
				Time = this.Time
			};
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0004A435 File Offset: 0x00048635
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0004A460 File Offset: 0x00048660
		public virtual string Curve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Curve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Curve;
			}
			set
			{
				this.GetOrCreatePoco().Curve = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0004A46E File Offset: 0x0004866E
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0004A49D File Offset: 0x0004869D
		public virtual float Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x0400126B RID: 4715
		[Nullable(2)]
		protected ILiftMoveCurve FbInstance;

		// Token: 0x0400126C RID: 4716
		[Nullable(2)]
		protected ILiftMoveCurve_SetValue PocoInterface;
	}
}
