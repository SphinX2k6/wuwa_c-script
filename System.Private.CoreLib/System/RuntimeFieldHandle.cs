using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200008F RID: 143
	public struct RuntimeFieldHandle : IEquatable<RuntimeFieldHandle>, ISerializable
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x00011822 File Offset: 0x0000FA22
		internal RuntimeFieldHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001182B File Offset: 0x0000FA2B
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00011833 File Offset: 0x0000FA33
		internal bool IsNullHandle()
		{
			return this.value == IntPtr.Zero;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00011844 File Offset: 0x0000FA44
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeFieldHandle)obj).Value;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00011889 File Offset: 0x0000FA89
		public bool Equals(RuntimeFieldHandle handle)
		{
			return this.value == handle.Value;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0001189A File Offset: 0x0000FA9A
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000118A7 File Offset: 0x0000FAA7
		public static RuntimeFieldHandle FromIntPtr(IntPtr value)
		{
			return new RuntimeFieldHandle(value);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000118AF File Offset: 0x0000FAAF
		public static IntPtr ToIntPtr(RuntimeFieldHandle value)
		{
			return value.Value;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000118B8 File Offset: 0x0000FAB8
		public static bool operator ==(RuntimeFieldHandle left, RuntimeFieldHandle right)
		{
			return left.Equals(right);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000118C2 File Offset: 0x0000FAC2
		public static bool operator !=(RuntimeFieldHandle left, RuntimeFieldHandle right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0600055A RID: 1370
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern object GetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, RuntimeType contextType);

		// Token: 0x0600055B RID: 1371
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType);

		// Token: 0x04000271 RID: 625
		private readonly IntPtr value;
	}
}
