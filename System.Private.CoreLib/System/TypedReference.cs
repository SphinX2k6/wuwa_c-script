using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000A5 RID: 165
	[NullableContext(2)]
	[Nullable(0)]
	[CLSCompliant(false)]
	public ref struct TypedReference
	{
		// Token: 0x06000899 RID: 2201 RVA: 0x0001BC42 File Offset: 0x00019E42
		public unsafe static object ToObject(TypedReference value)
		{
			return TypedReference.InternalToObject((void*)(&value));
		}

		// Token: 0x0600089A RID: 2202
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern object InternalToObject(void* value);

		// Token: 0x0600089B RID: 2203 RVA: 0x0001BC4C File Offset: 0x00019E4C
		[NullableContext(1)]
		public unsafe static TypedReference MakeTypedReference(object target, FieldInfo[] flds)
		{
			ArgumentNullException.ThrowIfNull(target, "target");
			ArgumentNullException.ThrowIfNull(flds, "flds");
			if (flds.Length == 0)
			{
				throw new ArgumentException(SR.Arg_ArrayZeroError, "flds");
			}
			IntPtr[] array = new IntPtr[flds.Length];
			RuntimeType runtimeType = (RuntimeType)target.GetType();
			for (int i = 0; i < flds.Length; i++)
			{
				RuntimeFieldInfo runtimeFieldInfo = flds[i] as RuntimeFieldInfo;
				if (runtimeFieldInfo == null)
				{
					throw new ArgumentException(SR.Argument_MustBeRuntimeFieldInfo);
				}
				RuntimeFieldInfo runtimeFieldInfo2 = runtimeFieldInfo;
				if (runtimeFieldInfo2.IsStatic)
				{
					throw new ArgumentException(SR.Format(SR.Argument_TypedReferenceInvalidField, runtimeFieldInfo2.Name));
				}
				if (runtimeType != runtimeFieldInfo2.GetDeclaringTypeInternal() && !runtimeType.IsSubclassOf(runtimeFieldInfo2.GetDeclaringTypeInternal()))
				{
					throw new MissingMemberException(SR.MissingMemberTypeRef);
				}
				RuntimeType runtimeType2 = (RuntimeType)runtimeFieldInfo2.FieldType;
				if (runtimeType2.IsPrimitive)
				{
					throw new ArgumentException(SR.Format(SR.Arg_TypeRefPrimitive, runtimeFieldInfo2.Name));
				}
				if (i < flds.Length - 1 && !runtimeType2.IsValueType)
				{
					throw new MissingMemberException(SR.MissingMemberNestErr);
				}
				array[i] = runtimeFieldInfo2.FieldHandle.Value;
				runtimeType = runtimeType2;
			}
			TypedReference result = default(TypedReference);
			TypedReference.InternalMakeTypedReference((void*)(&result), target, array, runtimeType);
			return result;
		}

		// Token: 0x0600089C RID: 2204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType);

		// Token: 0x0600089D RID: 2205 RVA: 0x0001BD82 File Offset: 0x00019F82
		public override int GetHashCode()
		{
			if (this._type == IntPtr.Zero)
			{
				return 0;
			}
			return __reftype(this).GetHashCode();
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000068EB File Offset: 0x00004AEB
		public override bool Equals(object o)
		{
			throw new NotSupportedException(SR.NotSupported_NYI);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0001BDA5 File Offset: 0x00019FA5
		internal bool IsNull
		{
			get
			{
				return Unsafe.IsNullRef<byte>(this._value) && this._type == IntPtr.Zero;
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0001BDC3 File Offset: 0x00019FC3
		[NullableContext(1)]
		public static Type GetTargetType(TypedReference value)
		{
			return __reftype(value);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0001BDCD File Offset: 0x00019FCD
		public static RuntimeTypeHandle TargetTypeToken(TypedReference value)
		{
			return __reftype(value).TypeHandle;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001A563 File Offset: 0x00018763
		public static void SetTypedReference(TypedReference target, object value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040002AC RID: 684
		private readonly RuntimeTypeHandle type;

		// Token: 0x040002AD RID: 685
		private unsafe readonly byte* _value;

		// Token: 0x040002AE RID: 686
		private readonly IntPtr _type;
	}
}
