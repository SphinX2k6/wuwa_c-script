using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200069A RID: 1690
	public static class FormattableStringFactory
	{
		// Token: 0x060073F8 RID: 29688 RVA: 0x00114884 File Offset: 0x00112A84
		[NullableContext(1)]
		public static FormattableString Create([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] arguments)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			ArgumentNullException.ThrowIfNull(arguments, "arguments");
			return new FormattableStringFactory.ConcreteFormattableString(format, arguments);
		}

		// Token: 0x0200069B RID: 1691
		private sealed class ConcreteFormattableString : FormattableString
		{
			// Token: 0x060073F9 RID: 29689 RVA: 0x001148A3 File Offset: 0x00112AA3
			internal ConcreteFormattableString(string format, object[] arguments)
			{
				this._format = format;
				this._arguments = arguments;
			}

			// Token: 0x17000E3E RID: 3646
			// (get) Token: 0x060073FA RID: 29690 RVA: 0x001148B9 File Offset: 0x00112AB9
			public override string Format
			{
				get
				{
					return this._format;
				}
			}

			// Token: 0x060073FB RID: 29691 RVA: 0x001148C1 File Offset: 0x00112AC1
			public override object[] GetArguments()
			{
				return this._arguments;
			}

			// Token: 0x17000E3F RID: 3647
			// (get) Token: 0x060073FC RID: 29692 RVA: 0x001148C9 File Offset: 0x00112AC9
			public override int ArgumentCount
			{
				get
				{
					return this._arguments.Length;
				}
			}

			// Token: 0x060073FD RID: 29693 RVA: 0x001148D3 File Offset: 0x00112AD3
			public override object GetArgument(int index)
			{
				return this._arguments[index];
			}

			// Token: 0x060073FE RID: 29694 RVA: 0x001148DD File Offset: 0x00112ADD
			public override string ToString(IFormatProvider formatProvider)
			{
				return string.Format(formatProvider, this._format, this._arguments);
			}

			// Token: 0x040014B2 RID: 5298
			private readonly string _format;

			// Token: 0x040014B3 RID: 5299
			private readonly object[] _arguments;
		}
	}
}
