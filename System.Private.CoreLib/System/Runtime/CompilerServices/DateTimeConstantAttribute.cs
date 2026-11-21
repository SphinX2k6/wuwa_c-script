using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200068F RID: 1679
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute
	{
		// Token: 0x060073E5 RID: 29669 RVA: 0x001147DB File Offset: 0x001129DB
		public DateTimeConstantAttribute(long ticks)
		{
			this._date = new DateTime(ticks);
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x060073E6 RID: 29670 RVA: 0x001147EF File Offset: 0x001129EF
		public override object Value
		{
			get
			{
				return this._date;
			}
		}

		// Token: 0x040014AB RID: 5291
		private readonly DateTime _date;
	}
}
