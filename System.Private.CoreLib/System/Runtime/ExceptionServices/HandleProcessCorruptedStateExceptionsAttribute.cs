using System;

namespace System.Runtime.ExceptionServices
{
	// Token: 0x0200052F RID: 1327
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[Obsolete("Recovery from corrupted process state exceptions is not supported; HandleProcessCorruptedStateExceptionsAttribute is ignored.", DiagnosticId = "SYSLIB0032", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute
	{
	}
}
