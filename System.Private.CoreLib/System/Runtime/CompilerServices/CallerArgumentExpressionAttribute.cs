using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200066E RID: 1646
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	public sealed class CallerArgumentExpressionAttribute : Attribute
	{
		// Token: 0x0600737F RID: 29567 RVA: 0x00113456 File Offset: 0x00111656
		public CallerArgumentExpressionAttribute(string parameterName)
		{
			this.ParameterName = parameterName;
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06007380 RID: 29568 RVA: 0x00113465 File Offset: 0x00111665
		public string ParameterName { get; }
	}
}
