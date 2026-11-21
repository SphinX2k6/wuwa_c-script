using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000799 RID: 1945
	public class ISpeedCurveMotion
	{
		// Token: 0x06002988 RID: 10632 RVA: 0x0006DC94 File Offset: 0x0006BE94
		private ISpeedCurveMotion_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpeedCurveMotion 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpeedCurveMotion_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpeedCurveMotion_SetValue());
			}
			return result;
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x0006DCCC File Offset: 0x0006BECC
		public static ISpeedCurveMotion Create([Nullable(2)] ISpeedCurveMotion instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpeedCurveMotion
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x0006DCDF File Offset: 0x0006BEDF
		public static ISpeedCurveMotion CreateFromSetValue([Nullable(2)] ISpeedCurveMotion_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpeedCurveMotion
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x0006DCF2 File Offset: 0x0006BEF2
		public ISpeedCurveMotion_SetValue ToSetValue()
		{
			return new ISpeedCurveMotion_SetValue
			{
				SpeedCurve = this.SpeedCurve
			};
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x0006DD05 File Offset: 0x0006BF05
		// (set) Token: 0x0600298D RID: 10637 RVA: 0x0006DD2C File Offset: 0x0006BF2C
		[Nullable(2)]
		public virtual string SpeedCurve
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpeedCurve;
				}
				ISpeedCurveMotion_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpeedCurve;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SpeedCurve = value;
			}
		}

		// Token: 0x04001C10 RID: 7184
		[Nullable(2)]
		protected ISpeedCurveMotion FbInstance;

		// Token: 0x04001C11 RID: 7185
		[Nullable(2)]
		protected ISpeedCurveMotion_SetValue PocoInterface;
	}
}
