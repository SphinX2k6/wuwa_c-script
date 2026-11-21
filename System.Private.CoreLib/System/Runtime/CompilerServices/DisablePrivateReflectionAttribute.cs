using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000693 RID: 1683
	[Obsolete("DisablePrivateReflectionAttribute has no effect in .NET 6.0+.", DiagnosticId = "SYSLIB0015", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class DisablePrivateReflectionAttribute : Attribute
	{
	}
}
