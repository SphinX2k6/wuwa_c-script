using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000525 RID: 1317
	public class ILiftMoveCurve
	{
		// Token: 0x06001A8A RID: 6794 RVA: 0x0004E100 File Offset: 0x0004C300
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

		// Token: 0x06001A8B RID: 6795 RVA: 0x0004E138 File Offset: 0x0004C338
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

		// Token: 0x06001A8C RID: 6796 RVA: 0x0004E14B File Offset: 0x0004C34B
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

		// Token: 0x06001A8D RID: 6797 RVA: 0x0004E15E File Offset: 0x0004C35E
		public ILiftMoveCurve_SetValue ToSetValue()
		{
			return new ILiftMoveCurve_SetValue
			{
				Curve = this.Curve,
				Time = this.Time
			};
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x0004E17D File Offset: 0x0004C37D
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x0004E1A8 File Offset: 0x0004C3A8
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

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0004E1B6 File Offset: 0x0004C3B6
		// (set) Token: 0x06001A91 RID: 6801 RVA: 0x0004E1E5 File Offset: 0x0004C3E5
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

		// Token: 0x0400138D RID: 5005
		[Nullable(2)]
		protected ILiftMoveCurve FbInstance;

		// Token: 0x0400138E RID: 5006
		[Nullable(2)]
		protected ILiftMoveCurve_SetValue PocoInterface;
	}
}
