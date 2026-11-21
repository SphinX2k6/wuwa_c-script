using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B7 RID: 9399
	public class ToggleScanSplineEffect : ActionParams
	{
		// Token: 0x0600CC64 RID: 52324 RVA: 0x001D1DB4 File Offset: 0x001CFFB4
		private ToggleScanSplineEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ToggleScanSplineEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ToggleScanSplineEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ToggleScanSplineEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600CC65 RID: 52325 RVA: 0x001D1DEC File Offset: 0x001CFFEC
		public static ToggleScanSplineEffect Create([Nullable(2)] ToggleScanSplineEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleScanSplineEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CC66 RID: 52326 RVA: 0x001D1DFF File Offset: 0x001CFFFF
		public static ToggleScanSplineEffect CreateFromSetValue([Nullable(2)] ToggleScanSplineEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ToggleScanSplineEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CC67 RID: 52327 RVA: 0x001D1E12 File Offset: 0x001D0012
		public ToggleScanSplineEffect_SetValue ToSetValue()
		{
			return new ToggleScanSplineEffect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x0600CC68 RID: 52328 RVA: 0x001D1E25 File Offset: 0x001D0025
		// (set) Token: 0x0600CC69 RID: 52329 RVA: 0x001D1E50 File Offset: 0x001D0050
		public virtual ETraceSplineOptionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETraceSplineOptionType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400791E RID: 31006
		[Nullable(2)]
		protected new ToggleScanSplineEffect FbInstance;

		// Token: 0x0400791F RID: 31007
		[Nullable(2)]
		protected ToggleScanSplineEffect_SetValue PocoInterface;
	}
}
