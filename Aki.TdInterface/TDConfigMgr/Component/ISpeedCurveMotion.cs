using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F8 RID: 1784
	[NullableContext(2)]
	[Nullable(0)]
	public class ISpeedCurveMotion
	{
		// Token: 0x06002668 RID: 9832 RVA: 0x00066C24 File Offset: 0x00064E24
		[NullableContext(1)]
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

		// Token: 0x06002669 RID: 9833 RVA: 0x00066C5C File Offset: 0x00064E5C
		[NullableContext(1)]
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

		// Token: 0x0600266A RID: 9834 RVA: 0x00066C6F File Offset: 0x00064E6F
		[NullableContext(1)]
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

		// Token: 0x0600266B RID: 9835 RVA: 0x00066C82 File Offset: 0x00064E82
		[NullableContext(1)]
		public ISpeedCurveMotion_SetValue ToSetValue()
		{
			return new ISpeedCurveMotion_SetValue
			{
				SpeedCurve = this.SpeedCurve
			};
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x00066C95 File Offset: 0x00064E95
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x00066CBC File Offset: 0x00064EBC
		public virtual string SpeedCurve
		{
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
			set
			{
				this.GetOrCreatePoco().SpeedCurve = value;
			}
		}

		// Token: 0x04001A11 RID: 6673
		protected ISpeedCurveMotion FbInstance;

		// Token: 0x04001A12 RID: 6674
		protected ISpeedCurveMotion_SetValue PocoInterface;
	}
}
