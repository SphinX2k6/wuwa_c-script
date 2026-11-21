using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace System
{
	// Token: 0x02000090 RID: 144
	public struct RuntimeMethodHandle : IEquatable<RuntimeMethodHandle>, ISerializable
	{
		// Token: 0x0600055C RID: 1372 RVA: 0x000118CF File Offset: 0x0000FACF
		internal RuntimeMethodHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x000118D8 File Offset: 0x0000FAD8
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600055F RID: 1375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetFunctionPointer(IntPtr m);

		// Token: 0x06000560 RID: 1376 RVA: 0x000118E0 File Offset: 0x0000FAE0
		public IntPtr GetFunctionPointer()
		{
			return RuntimeMethodHandle.GetFunctionPointer(this.value);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000118F0 File Offset: 0x0000FAF0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeMethodHandle)obj).Value;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00011935 File Offset: 0x0000FB35
		public bool Equals(RuntimeMethodHandle handle)
		{
			return this.value == handle.Value;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00011946 File Offset: 0x0000FB46
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00011953 File Offset: 0x0000FB53
		public static RuntimeMethodHandle FromIntPtr(IntPtr value)
		{
			return new RuntimeMethodHandle(value);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0001195B File Offset: 0x0000FB5B
		public static IntPtr ToIntPtr(RuntimeMethodHandle value)
		{
			return value.Value;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00011964 File Offset: 0x0000FB64
		public static bool operator ==(RuntimeMethodHandle left, RuntimeMethodHandle right)
		{
			return left.Equals(right);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001196E File Offset: 0x0000FB6E
		public static bool operator !=(RuntimeMethodHandle left, RuntimeMethodHandle right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0001197C File Offset: 0x0000FB7C
		internal static string ConstructInstantiation(RuntimeMethodInfo method)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Type[] genericArguments = method.GetGenericArguments();
			stringBuilder.Append('[');
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(genericArguments[i].Name);
			}
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000119D8 File Offset: 0x0000FBD8
		internal bool IsNullHandle()
		{
			return this.value == IntPtr.Zero;
		}

		// Token: 0x0600056A RID: 1386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ReboxFromNullable(object src, ObjectHandleOnStack res);

		// Token: 0x0600056B RID: 1387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ReboxToNullable(object src, QCallTypeHandle destNullableType, ObjectHandleOnStack res);

		// Token: 0x0600056C RID: 1388 RVA: 0x000119E8 File Offset: 0x0000FBE8
		internal static object ReboxFromNullable(object src)
		{
			object result = null;
			RuntimeMethodHandle.ReboxFromNullable(src, ObjectHandleOnStack.Create<object>(ref result));
			return result;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00011A08 File Offset: 0x0000FC08
		internal static object ReboxToNullable(object src, RuntimeType destNullableType)
		{
			object result = null;
			RuntimeMethodHandle.ReboxToNullable(src, new QCallTypeHandle(ref destNullableType), ObjectHandleOnStack.Create<object>(ref result));
			return result;
		}

		// Token: 0x04000272 RID: 626
		private readonly IntPtr value;
	}
}
