using System;
using System.Diagnostics;

namespace System.Threading.Tasks
{
	// Token: 0x020004A6 RID: 1190
	internal static class LoggingExtensions
	{
		// Token: 0x06004532 RID: 17714 RVA: 0x000E7460 File Offset: 0x000E5660
		public static string GetMethodName(this Delegate @delegate)
		{
			DiagnosticMethodInfo diagnosticMethodInfo = DiagnosticMethodInfo.Create(@delegate);
			return ((diagnosticMethodInfo != null) ? diagnosticMethodInfo.Name : null) ?? "<unknown>";
		}
	}
}
