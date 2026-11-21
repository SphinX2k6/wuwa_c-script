using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Sharphereal.AOTRedirector.Attributes;

namespace Sharphereal.AOTRedirector
{
	// Token: 0x02000006 RID: 6
	[NullableContext(1)]
	[Nullable(0)]
	public static class AOTRedirectorFrontend
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000020A4 File Offset: 0x000002A4
		public static void AddRedirectAssembly(Assembly redirectAssembly, Assembly originalAssembly)
		{
			Backend backend = AOTRedirectorFrontend.GetBackend(originalAssembly.GetName().Name);
			backend.patchSwitch = true;
			foreach (Type type in redirectAssembly.GetTypes())
			{
				RedirectGenericTypeAttribute redirectGenericTypeAttribute = type.GetCustomAttribute(typeof(RedirectGenericTypeAttribute)) as RedirectGenericTypeAttribute;
				bool flag = redirectGenericTypeAttribute != null;
				if (flag)
				{
					backend.SetRedirectGenericType(redirectGenericTypeAttribute.sourceGenericDefinitionType, type);
				}
				foreach (MethodInfo methodInfo in type.GetMethods())
				{
					AOTRedirectorFrontend.RedirectMethod(type, methodInfo, backend);
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002148 File Offset: 0x00000348
		private static void RedirectMethod(Type type, MethodInfo methodInfo, Backend backend)
		{
			RedirectAttribute redirectAttribute = methodInfo.GetCustomAttribute(typeof(RedirectAttribute)) as RedirectAttribute;
			bool flag = redirectAttribute == null;
			if (!flag)
			{
				int rrid = redirectAttribute.RRID;
				bool flag2 = rrid == 0;
				if (flag2)
				{
					throw new Exception(string.Format("Invalid method: {0}.{1}, RRID: {2}", type.FullName, methodInfo.Name, rrid));
				}
				bool flag3 = !redirectAttribute.DelegateType.ContainsGenericParameters;
				if (flag3)
				{
					Delegate @delegate = methodInfo.CreateDelegate(redirectAttribute.DelegateType);
					backend.SetRedirectDelegate(rrid, @delegate);
				}
				else
				{
					bool flag4 = !type.ContainsGenericParameters;
					if (flag4)
					{
						backend.SetRedirectGenericMethodInfo(rrid, methodInfo);
					}
				}
				backend.SetMethodRedirect(rrid);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002200 File Offset: 0x00000400
		public static Backend CreateBackend(string assemblyName)
		{
			Console.WriteLine(assemblyName + " is Creating backend!!!");
			Backend backend = new Backend(assemblyName);
			AOTRedirectorFrontend.backends.Add(assemblyName, backend);
			return backend;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002238 File Offset: 0x00000438
		private static Backend GetBackend(string assemblyName)
		{
			Console.WriteLine(assemblyName + " is Searching backend!!!");
			return AOTRedirectorFrontend.backends[assemblyName];
		}

		// Token: 0x04000004 RID: 4
		private static Dictionary<string, Backend> backends = new Dictionary<string, Backend>();
	}
}
