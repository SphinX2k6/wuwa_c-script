using System;

namespace System
{
	// Token: 0x02000161 RID: 353
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class LoaderOptimizationAttribute : Attribute
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x00046521 File Offset: 0x00044721
		public LoaderOptimizationAttribute(byte value)
		{
			this._val = value;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00046530 File Offset: 0x00044730
		public LoaderOptimizationAttribute(LoaderOptimization value)
		{
			this._val = (byte)value;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00046540 File Offset: 0x00044740
		public LoaderOptimization Value
		{
			get
			{
				return (LoaderOptimization)this._val;
			}
		}

		// Token: 0x040004E7 RID: 1255
		private readonly byte _val;
	}
}
