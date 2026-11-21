using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Threading;

namespace AssemblyContext
{
	// Token: 0x02000003 RID: 3
	public static class AssemblyLoadContextManager
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
		public unsafe static void InitializeContext(bool isInEditor, bool isWaitForAttach, IntPtr LoadAssemblyToALCFromName, IntPtr* OutLoadAssemblyToALC)
		{
			if (isWaitForAttach)
			{
				while (!Debugger.IsAttached)
				{
					Thread.Sleep(100);
				}
				Debugger.Break();
			}
			if (AssemblyLoadContextManager.s_CurrentContext != null)
			{
				throw new InvalidOperationException("Already initialized");
			}
			AssemblyLoadContextManager.isInEditor = isInEditor;
			AssemblyLoadContextManager.s_CurrentContext = (isInEditor ? new SharpherealAssemblyLoadContext("GameAssemblyLoadContext " + DateTime.Now.ToString("HH:mm:ss zz")) : AssemblyLoadContext.Default);
			if (AssemblyLoadContextManager.s_CurrentContext.IsCollectible)
			{
				AssemblyLoadContextManager.s_AlcWeakRef = new WeakReference(AssemblyLoadContextManager.s_CurrentContext, true);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E8 File Offset: 0x000002E8
		[NullableContext(1)]
		public static Assembly LoadAssembly(string assemblyPath)
		{
			if (AssemblyLoadContextManager.s_CurrentContext == null)
			{
				throw new InvalidOperationException("Not initialized");
			}
			string path = Path.ChangeExtension(assemblyPath, ".pdb");
			Assembly result;
			using (FileStream fileStream = new FileStream(assemblyPath, FileMode.Open, FileAccess.Read))
			{
				if (File.Exists(path))
				{
					using (FileStream fileStream2 = new FileStream(path, FileMode.Open, FileAccess.Read))
					{
						return AssemblyLoadContextManager.s_CurrentContext.LoadFromStream(fileStream, fileStream2);
					}
				}
				result = AssemblyLoadContextManager.s_CurrentContext.LoadFromStream(fileStream);
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000217C File Offset: 0x0000037C
		[return: Nullable(1)]
		public unsafe static Assembly LoadAssemblyFromUnmanagedMemory(byte* assemblyBytes, long assemblyLength, byte* pdbBytes, long pdbLength)
		{
			if (AssemblyLoadContextManager.s_CurrentContext == null)
			{
				throw new InvalidOperationException("Not initialized");
			}
			Assembly result;
			using (UnmanagedMemoryStream unmanagedMemoryStream = new UnmanagedMemoryStream(assemblyBytes, assemblyLength))
			{
				if (pdbBytes != null && pdbLength > 0L)
				{
					using (UnmanagedMemoryStream unmanagedMemoryStream2 = new UnmanagedMemoryStream(pdbBytes, pdbLength))
					{
						return AssemblyLoadContextManager.s_CurrentContext.LoadFromStream(unmanagedMemoryStream, unmanagedMemoryStream2);
					}
				}
				result = AssemblyLoadContextManager.s_CurrentContext.LoadFromStream(unmanagedMemoryStream);
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002204 File Offset: 0x00000404
		[NullableContext(2)]
		public static object StartUnload()
		{
			if (AssemblyLoadContextManager.s_CurrentContext == null)
			{
				return null;
			}
			if (!AssemblyLoadContextManager.s_CurrentContext.IsCollectible)
			{
				AssemblyLoadContextManager.s_CurrentContext = null;
				return null;
			}
			FieldInfo field = typeof(AssemblyLoadContext).GetField("_nativeAssemblyLoadContext", BindingFlags.Instance | BindingFlags.NonPublic);
			object result = null;
			if (field != null)
			{
				result = field.GetValue(AssemblyLoadContextManager.s_CurrentContext);
			}
			AssemblyLoadContextManager.s_CurrentContext.Unload();
			AssemblyLoadContextManager.s_CurrentContext = null;
			return result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002270 File Offset: 0x00000470
		public static void WaitForGC(int count)
		{
			if (AssemblyLoadContextManager.isInEditor)
			{
				int num = 0;
				while ((AssemblyLoadContextManager.s_AlcWeakRef == null || AssemblyLoadContextManager.s_AlcWeakRef.IsAlive) && num < count)
				{
					GC.Collect();
					GC.WaitForPendingFinalizers();
					num++;
				}
				AssemblyLoadContextManager.s_AlcWeakRef = null;
			}
		}

		// Token: 0x04000001 RID: 1
		[Nullable(2)]
		private static AssemblyLoadContext s_CurrentContext;

		// Token: 0x04000002 RID: 2
		[Nullable(2)]
		private static WeakReference s_AlcWeakRef;

		// Token: 0x04000003 RID: 3
		private static bool isInEditor;
	}
}
