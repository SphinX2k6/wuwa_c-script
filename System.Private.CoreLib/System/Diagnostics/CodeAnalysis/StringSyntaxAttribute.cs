using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008BA RID: 2234
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	public sealed class StringSyntaxAttribute : Attribute
	{
		// Token: 0x06008A12 RID: 35346 RVA: 0x0014EADE File Offset: 0x0014CCDE
		public StringSyntaxAttribute(string syntax)
		{
			this.Syntax = syntax;
			this.Arguments = Array.Empty<object>();
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x0014EAF8 File Offset: 0x0014CCF8
		public StringSyntaxAttribute(string syntax, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] arguments)
		{
			this.Syntax = syntax;
			this.Arguments = arguments;
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06008A14 RID: 35348 RVA: 0x0014EB0E File Offset: 0x0014CD0E
		public string Syntax { get; }

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06008A15 RID: 35349 RVA: 0x0014EB16 File Offset: 0x0014CD16
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public object[] Arguments { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; }

		// Token: 0x04001E93 RID: 7827
		public const string CompositeFormat = "CompositeFormat";

		// Token: 0x04001E94 RID: 7828
		public const string DateOnlyFormat = "DateOnlyFormat";

		// Token: 0x04001E95 RID: 7829
		public const string DateTimeFormat = "DateTimeFormat";

		// Token: 0x04001E96 RID: 7830
		public const string EnumFormat = "EnumFormat";

		// Token: 0x04001E97 RID: 7831
		public const string GuidFormat = "GuidFormat";

		// Token: 0x04001E98 RID: 7832
		public const string Json = "Json";

		// Token: 0x04001E99 RID: 7833
		public const string NumericFormat = "NumericFormat";

		// Token: 0x04001E9A RID: 7834
		public const string Regex = "Regex";

		// Token: 0x04001E9B RID: 7835
		public const string TimeOnlyFormat = "TimeOnlyFormat";

		// Token: 0x04001E9C RID: 7836
		public const string TimeSpanFormat = "TimeSpanFormat";

		// Token: 0x04001E9D RID: 7837
		public const string Uri = "Uri";

		// Token: 0x04001E9E RID: 7838
		public const string Xml = "Xml";
	}
}
