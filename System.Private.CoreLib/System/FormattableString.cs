using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200010D RID: 269
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class FormattableString : IFormattable
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06001149 RID: 4425
		[StringSyntax("CompositeFormat")]
		public abstract string Format { get; }

		// Token: 0x0600114A RID: 4426
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public abstract object[] GetArguments();

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600114B RID: 4427
		public abstract int ArgumentCount { get; }

		// Token: 0x0600114C RID: 4428
		[NullableContext(2)]
		public abstract object GetArgument(int index);

		// Token: 0x0600114D RID: 4429
		public abstract string ToString([Nullable(2)] IFormatProvider formatProvider);

		// Token: 0x0600114E RID: 4430 RVA: 0x00030BC0 File Offset: 0x0002EDC0
		string IFormattable.ToString(string ignored, IFormatProvider formatProvider)
		{
			return this.ToString(formatProvider);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00030BC9 File Offset: 0x0002EDC9
		public static string Invariant(FormattableString formattable)
		{
			ArgumentNullException.ThrowIfNull(formattable, "formattable");
			return formattable.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00030BE1 File Offset: 0x0002EDE1
		public static string CurrentCulture(FormattableString formattable)
		{
			ArgumentNullException.ThrowIfNull(formattable, "formattable");
			return formattable.ToString(CultureInfo.CurrentCulture);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00030BF9 File Offset: 0x0002EDF9
		public override string ToString()
		{
			return this.ToString(CultureInfo.CurrentCulture);
		}
	}
}
