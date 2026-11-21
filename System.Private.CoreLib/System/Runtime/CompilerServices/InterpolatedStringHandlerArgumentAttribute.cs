using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006AB RID: 1707
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	public sealed class InterpolatedStringHandlerArgumentAttribute : Attribute
	{
		// Token: 0x06007414 RID: 29716 RVA: 0x00114937 File Offset: 0x00112B37
		public InterpolatedStringHandlerArgumentAttribute(string argument)
		{
			this.Arguments = new string[]
			{
				argument
			};
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x0011494F File Offset: 0x00112B4F
		public InterpolatedStringHandlerArgumentAttribute(params string[] arguments)
		{
			this.Arguments = arguments;
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06007416 RID: 29718 RVA: 0x0011495E File Offset: 0x00112B5E
		public string[] Arguments { get; }
	}
}
