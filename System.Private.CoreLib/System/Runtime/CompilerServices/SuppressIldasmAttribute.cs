using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006CF RID: 1743
	[Obsolete("SuppressIldasmAttribute has no effect in .NET 6.0+.", DiagnosticId = "SYSLIB0025", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module)]
	public sealed class SuppressIldasmAttribute : Attribute
	{
	}
}
