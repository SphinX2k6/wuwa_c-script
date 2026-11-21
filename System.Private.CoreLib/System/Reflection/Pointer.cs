using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x0200076D RID: 1901
	[CLSCompliant(false)]
	public sealed class Pointer : ISerializable
	{
		// Token: 0x060079F7 RID: 31223 RVA: 0x0012165F File Offset: 0x0011F85F
		private unsafe Pointer(void* ptr, RuntimeType ptrType)
		{
			this._ptr = ptr;
			this._ptrType = ptrType;
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x00121678 File Offset: 0x0011F878
		[NullableContext(1)]
		public unsafe static object Box([Nullable(0)] void* ptr, Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			if (!type.IsPointer)
			{
				throw new ArgumentException(SR.Arg_MustBePointer, "ptr");
			}
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Arg_MustBeType, "type");
			}
			return new Pointer(ptr, runtimeType);
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x001216CC File Offset: 0x0011F8CC
		public unsafe static void* Unbox([Nullable(1)] object ptr)
		{
			Pointer pointer = ptr as Pointer;
			if (pointer != null)
			{
				return pointer._ptr;
			}
			throw new ArgumentException(SR.Arg_MustBePointer, "ptr");
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x001216FC File Offset: 0x0011F8FC
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			Pointer pointer = obj as Pointer;
			return pointer != null && this._ptr == pointer._ptr;
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x00121724 File Offset: 0x0011F924
		public override int GetHashCode()
		{
			return this._ptr.GetHashCode();
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x0000ACEC File Offset: 0x00008EEC
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x0012173F File Offset: 0x0011F93F
		internal RuntimeType GetPointerType()
		{
			return this._ptrType;
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x00121747 File Offset: 0x0011F947
		internal IntPtr GetPointerValue()
		{
			return this._ptr;
		}

		// Token: 0x040016FA RID: 5882
		private unsafe readonly void* _ptr;

		// Token: 0x040016FB RID: 5883
		private readonly RuntimeType _ptrType;
	}
}
