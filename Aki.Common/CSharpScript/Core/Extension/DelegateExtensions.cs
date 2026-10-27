using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000017 RID: 23
	public static class DelegateExtensions
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000AB34 File Offset: 0x00008D34
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
