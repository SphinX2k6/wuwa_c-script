using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000018 RID: 24
	public static class DelegateExtensions
	{
		// Token: 0x06000119 RID: 281 RVA: 0x0000E2DC File Offset: 0x0000C4DC
		[NullableContext(1)]
		public static string GetDelegateInfo(this Delegate delegateObj)
		{
			MethodInfo method = delegateObj.Method;
			ParameterInfo[] parameters = method.GetParameters();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
			Type declaringType = method.DeclaringType;
			defaultInterpolatedStringHandler.AppendFormatted(((declaringType != null) ? declaringType.FullName : null) ?? "Unknown");
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted(method.Name);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(string.Join(", ", from p in parameters
			select p.ParameterType.Name + " " + p.Name));
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}
}
