using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

namespace System.Runtime.Loader
{
	// Token: 0x0200053E RID: 1342
	[NullableContext(1)]
	[Nullable(0)]
	[UnsupportedOSPlatform("android")]
	[UnsupportedOSPlatform("browser")]
	[UnsupportedOSPlatform("ios")]
	[UnsupportedOSPlatform("tvos")]
	public sealed class AssemblyDependencyResolver
	{
		// Token: 0x06004971 RID: 18801 RVA: 0x000F3340 File Offset: 0x000F1540
		public AssemblyDependencyResolver(string componentAssemblyPath)
		{
			ArgumentNullException.ThrowIfNull(componentAssemblyPath, "componentAssemblyPath");
			string assemblyPathsList = null;
			string nativeSearchPathsList = null;
			string resourceSearchPathsList = null;
			int num = 0;
			StringBuilder errorMessage = new StringBuilder();
			try
			{
				Interop.HostPolicy.corehost_error_writer_fn corehost_error_writer_fn = delegate(IntPtr message)
				{
					errorMessage.AppendLine(Marshal.PtrToStringAuto(message));
				};
				IntPtr errorWriter = Interop.HostPolicy.corehost_set_error_writer(Marshal.GetFunctionPointerForDelegate<Interop.HostPolicy.corehost_error_writer_fn>(corehost_error_writer_fn));
				try
				{
					num = Interop.HostPolicy.corehost_resolve_component_dependencies(componentAssemblyPath, delegate(IntPtr assemblyPaths, IntPtr nativeSearchPaths, IntPtr resourceSearchPaths)
					{
						assemblyPathsList = Marshal.PtrToStringAuto(assemblyPaths);
						nativeSearchPathsList = Marshal.PtrToStringAuto(nativeSearchPaths);
						resourceSearchPathsList = Marshal.PtrToStringAuto(resourceSearchPaths);
					});
				}
				finally
				{
					Interop.HostPolicy.corehost_set_error_writer(errorWriter);
					GC.KeepAlive(corehost_error_writer_fn);
				}
			}
			catch (EntryPointNotFoundException innerException)
			{
				throw new InvalidOperationException(SR.AssemblyDependencyResolver_FailedToLoadHostpolicy, innerException);
			}
			catch (DllNotFoundException innerException2)
			{
				throw new InvalidOperationException(SR.AssemblyDependencyResolver_FailedToLoadHostpolicy, innerException2);
			}
			if (num != 0)
			{
				throw new InvalidOperationException(SR.Format(SR.AssemblyDependencyResolver_FailedToResolveDependencies, componentAssemblyPath, num, errorMessage));
			}
			string[] array = AssemblyDependencyResolver.SplitPathsList(assemblyPathsList);
			this._assemblyPaths = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			foreach (string text in array)
			{
				this._assemblyPaths.TryAdd(Path.GetFileNameWithoutExtension(text), text);
			}
			this._nativeSearchPaths = AssemblyDependencyResolver.SplitPathsList(nativeSearchPathsList);
			this._resourceSearchPaths = AssemblyDependencyResolver.SplitPathsList(resourceSearchPathsList);
			this._assemblyDirectorySearchPaths = new string[]
			{
				Path.GetDirectoryName(componentAssemblyPath)
			};
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x000F34B0 File Offset: 0x000F16B0
		[return: Nullable(2)]
		public string ResolveAssemblyToPath(AssemblyName assemblyName)
		{
			ArgumentNullException.ThrowIfNull(assemblyName, "assemblyName");
			string text2;
			if (!string.IsNullOrEmpty(assemblyName.CultureName) && !string.Equals(assemblyName.CultureName, "neutral", StringComparison.OrdinalIgnoreCase))
			{
				string[] resourceSearchPaths = this._resourceSearchPaths;
				for (int i = 0; i < resourceSearchPaths.Length; i++)
				{
					string text = Path.Combine(resourceSearchPaths[i], assemblyName.CultureName, assemblyName.Name + ".dll");
					if (File.Exists(text))
					{
						return text;
					}
				}
			}
			else if (assemblyName.Name != null && this._assemblyPaths.TryGetValue(assemblyName.Name, out text2) && File.Exists(text2))
			{
				return text2;
			}
			return null;
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x000F3550 File Offset: 0x000F1750
		[return: Nullable(2)]
		public string ResolveUnmanagedDllToPath(string unmanagedDllName)
		{
			ArgumentNullException.ThrowIfNull(unmanagedDllName, "unmanagedDllName");
			string[] array;
			if (unmanagedDllName.Contains(Path.DirectorySeparatorChar))
			{
				array = this._assemblyDirectorySearchPaths;
			}
			else
			{
				array = this._nativeSearchPaths;
			}
			bool isRelativePath = !Path.IsPathFullyQualified(unmanagedDllName);
			foreach (LibraryNameVariation libraryNameVariation in LibraryNameVariation.DetermineLibraryNameVariations(unmanagedDllName, isRelativePath))
			{
				string path = libraryNameVariation.Prefix + unmanagedDllName + libraryNameVariation.Suffix;
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string text = Path.Combine(array2[i], path);
					if (File.Exists(text))
					{
						return text;
					}
				}
			}
			return null;
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x000F3614 File Offset: 0x000F1814
		private static string[] SplitPathsList(string pathsList)
		{
			if (pathsList == null)
			{
				return Array.Empty<string>();
			}
			return pathsList.Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries);
		}

		// Token: 0x040011B8 RID: 4536
		private readonly Dictionary<string, string> _assemblyPaths;

		// Token: 0x040011B9 RID: 4537
		private readonly string[] _nativeSearchPaths;

		// Token: 0x040011BA RID: 4538
		private readonly string[] _resourceSearchPaths;

		// Token: 0x040011BB RID: 4539
		private readonly string[] _assemblyDirectorySearchPaths;
	}
}
