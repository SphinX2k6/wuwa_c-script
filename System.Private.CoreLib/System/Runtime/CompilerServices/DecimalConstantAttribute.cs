using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000690 RID: 1680
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	public sealed class DecimalConstantAttribute : Attribute
	{
		// Token: 0x060073E7 RID: 29671 RVA: 0x001147FC File Offset: 0x001129FC
		[CLSCompliant(false)]
		public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
		{
			this._dec = new decimal((int)low, (int)mid, (int)hi, sign > 0, scale);
		}

		// Token: 0x060073E8 RID: 29672 RVA: 0x001147FC File Offset: 0x001129FC
		public DecimalConstantAttribute(byte scale, byte sign, int hi, int mid, int low)
		{
			this._dec = new decimal(low, mid, hi, sign > 0, scale);
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x060073E9 RID: 29673 RVA: 0x00114819 File Offset: 0x00112A19
		public decimal Value
		{
			get
			{
				return this._dec;
			}
		}

		// Token: 0x040014AC RID: 5292
		private readonly decimal _dec;
	}
}
