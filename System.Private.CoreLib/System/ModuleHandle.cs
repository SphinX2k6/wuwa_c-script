using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200008B RID: 139
	[NullableContext(2)]
	[Nullable(0)]
	public struct ModuleHandle : IEquatable<ModuleHandle>
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x00010F01 File Offset: 0x0000F101
		internal ModuleHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00010F0A File Offset: 0x0000F10A
		internal IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00010F12 File Offset: 0x0000F112
		public int MDStreamVersion
		{
			get
			{
				if (this.value == IntPtr.Zero)
				{
					throw new ArgumentNullException(string.Empty, SR.Arg_InvalidHandle);
				}
				return RuntimeModule.GetMDStreamVersion(this.value);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00010F3C File Offset: 0x0000F13C
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public RuntimeFieldHandle ResolveFieldHandle(int fieldToken)
		{
			return this.ResolveFieldHandle(fieldToken, null, null);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00010F47 File Offset: 0x0000F147
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public RuntimeMethodHandle ResolveMethodHandle(int methodToken)
		{
			return this.ResolveMethodHandle(methodToken, null, null);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00010F52 File Offset: 0x0000F152
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public RuntimeTypeHandle ResolveTypeHandle(int typeToken)
		{
			return this.ResolveTypeHandle(typeToken, null, null);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00010F60 File Offset: 0x0000F160
		private static IntPtr[] ptrs_from_handles(RuntimeTypeHandle[] handles)
		{
			if (handles == null)
			{
				return null;
			}
			IntPtr[] array = new IntPtr[handles.Length];
			for (int i = 0; i < handles.Length; i++)
			{
				array[i] = handles[i].Value;
			}
			return array;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00010F9C File Offset: 0x0000F19C
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public RuntimeTypeHandle ResolveTypeHandle(int typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
		{
			if (this.value == IntPtr.Zero)
			{
				throw new ArgumentNullException(string.Empty, SR.Arg_InvalidHandle);
			}
			ResolveTokenError resolveTokenError;
			IntPtr intPtr = RuntimeModule.ResolveTypeToken(this.value, typeToken, ModuleHandle.ptrs_from_handles(typeInstantiationContext), ModuleHandle.ptrs_from_handles(methodInstantiationContext), out resolveTokenError);
			if (intPtr == IntPtr.Zero)
			{
				throw new TypeLoadException(SR.Format(SR.ClassLoad_General_Hex, typeToken, this.value.ToInt64()));
			}
			return new RuntimeTypeHandle(intPtr);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00011018 File Offset: 0x0000F218
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public RuntimeMethodHandle ResolveMethodHandle(int methodToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
		{
			if (this.value == IntPtr.Zero)
			{
				throw new ArgumentNullException(string.Empty, SR.Arg_InvalidHandle);
			}
			ResolveTokenError resolveTokenError;
			IntPtr intPtr = RuntimeModule.ResolveMethodToken(this.value, methodToken, ModuleHandle.ptrs_from_handles(typeInstantiationContext), ModuleHandle.ptrs_from_handles(methodInstantiationContext), out resolveTokenError);
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception(SR.Format(SR.ClassLoad_General_Hex, methodToken, this.value.ToInt64()));
			}
			return new RuntimeMethodHandle(intPtr);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00011094 File Offset: 0x0000F294
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public RuntimeFieldHandle ResolveFieldHandle(int fieldToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
		{
			if (this.value == IntPtr.Zero)
			{
				throw new ArgumentNullException(string.Empty, SR.Arg_InvalidHandle);
			}
			ResolveTokenError resolveTokenError;
			IntPtr intPtr = RuntimeModule.ResolveFieldToken(this.value, fieldToken, ModuleHandle.ptrs_from_handles(typeInstantiationContext), ModuleHandle.ptrs_from_handles(methodInstantiationContext), out resolveTokenError);
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception(SR.Format(SR.ClassLoad_General_Hex, fieldToken, this.value.ToInt64()));
			}
			return new RuntimeFieldHandle(intPtr);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001110D File Offset: 0x0000F30D
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(int fieldToken)
		{
			return this.ResolveFieldHandle(fieldToken);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00011116 File Offset: 0x0000F316
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(int methodToken)
		{
			return this.ResolveMethodHandle(methodToken);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0001111F File Offset: 0x0000F31F
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(int typeToken)
		{
			return this.ResolveTypeHandle(typeToken);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00011128 File Offset: 0x0000F328
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((ModuleHandle)obj).Value;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0001116D File Offset: 0x0000F36D
		public bool Equals(ModuleHandle handle)
		{
			return this.value == handle.Value;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0001117E File Offset: 0x0000F37E
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0001118B File Offset: 0x0000F38B
		public static bool operator ==(ModuleHandle left, ModuleHandle right)
		{
			return object.Equals(left, right);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0001119E File Offset: 0x0000F39E
		public static bool operator !=(ModuleHandle left, ModuleHandle right)
		{
			return !object.Equals(left, right);
		}

		// Token: 0x0400026B RID: 619
		private readonly IntPtr value;

		// Token: 0x0400026C RID: 620
		public static readonly ModuleHandle EmptyHandle = new ModuleHandle(IntPtr.Zero);
	}
}
