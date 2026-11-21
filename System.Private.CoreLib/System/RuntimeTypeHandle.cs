using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Mono;

namespace System
{
	// Token: 0x02000097 RID: 151
	[NullableContext(1)]
	[Nullable(0)]
	public struct RuntimeTypeHandle : IEquatable<RuntimeTypeHandle>, ISerializable
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x00015662 File Offset: 0x00013862
		internal RuntimeTypeHandle(IntPtr val)
		{
			this.value = val;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001566B File Offset: 0x0001386B
		internal RuntimeTypeHandle(RuntimeType type)
		{
			this = new RuntimeTypeHandle(type._impl.value);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0001567E File Offset: 0x0001387E
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00015688 File Offset: 0x00013888
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeTypeHandle)obj).Value;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000156CD File Offset: 0x000138CD
		public bool Equals(RuntimeTypeHandle handle)
		{
			return this.value == handle.Value;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000156DE File Offset: 0x000138DE
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000156EB File Offset: 0x000138EB
		public static RuntimeTypeHandle FromIntPtr(IntPtr value)
		{
			return new RuntimeTypeHandle(value);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000156F3 File Offset: 0x000138F3
		public static IntPtr ToIntPtr(RuntimeTypeHandle value)
		{
			return value.Value;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000156FC File Offset: 0x000138FC
		public static bool operator ==(RuntimeTypeHandle left, object right)
		{
			return right != null && right is RuntimeTypeHandle && left.Equals((RuntimeTypeHandle)right);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00015718 File Offset: 0x00013918
		public static bool operator !=(RuntimeTypeHandle left, object right)
		{
			return right == null || !(right is RuntimeTypeHandle) || !left.Equals((RuntimeTypeHandle)right);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00015738 File Offset: 0x00013938
		public static bool operator ==(object left, RuntimeTypeHandle right)
		{
			return left != null && left is RuntimeTypeHandle && ((RuntimeTypeHandle)left).Equals(right);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00015764 File Offset: 0x00013964
		public static bool operator !=(object left, RuntimeTypeHandle right)
		{
			return left == null || !(left is RuntimeTypeHandle) || !((RuntimeTypeHandle)left).Equals(right);
		}

		// Token: 0x0600064A RID: 1610
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern TypeAttributes GetAttributes(QCallTypeHandle type);

		// Token: 0x0600064B RID: 1611 RVA: 0x00015790 File Offset: 0x00013990
		internal static TypeAttributes GetAttributes(RuntimeType type)
		{
			return type.GetAttributes();
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00015798 File Offset: 0x00013998
		public ModuleHandle GetModuleHandle()
		{
			if (this.value == IntPtr.Zero)
			{
				throw new ArgumentException(SR.Arg_InvalidHandle);
			}
			return Type.GetTypeFromHandle(this).Module.ModuleHandle;
		}

		// Token: 0x0600064D RID: 1613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMetadataToken(QCallTypeHandle type);

		// Token: 0x0600064E RID: 1614 RVA: 0x000157C7 File Offset: 0x000139C7
		internal static int GetToken(RuntimeType type)
		{
			return RuntimeTypeHandle.GetMetadataToken(new QCallTypeHandle(ref type));
		}

		// Token: 0x0600064F RID: 1615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGenericTypeDefinition_impl(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x06000650 RID: 1616 RVA: 0x000157D8 File Offset: 0x000139D8
		internal static Type GetGenericTypeDefinition(RuntimeType type)
		{
			Type type2 = null;
			RuntimeTypeHandle.GetGenericTypeDefinition_impl(new QCallTypeHandle(ref type), ObjectHandleOnStack.Create<Type>(ref type2));
			if (type2 == null)
			{
				return type;
			}
			return type2;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00015808 File Offset: 0x00013A08
		internal static bool IsPrimitive(RuntimeType type)
		{
			CorElementType corElementType = RuntimeTypeHandle.GetCorElementType(type);
			return (corElementType >= CorElementType.ELEMENT_TYPE_BOOLEAN && corElementType <= CorElementType.ELEMENT_TYPE_R8) || corElementType == CorElementType.ELEMENT_TYPE_I || corElementType == CorElementType.ELEMENT_TYPE_U;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00015831 File Offset: 0x00013A31
		internal static bool IsByRef(RuntimeType type)
		{
			return RuntimeTypeHandle.GetCorElementType(type) == CorElementType.ELEMENT_TYPE_BYREF;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0001583D File Offset: 0x00013A3D
		internal static bool IsPointer(RuntimeType type)
		{
			return RuntimeTypeHandle.GetCorElementType(type) == CorElementType.ELEMENT_TYPE_PTR;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00015849 File Offset: 0x00013A49
		internal static bool IsFunctionPointer(RuntimeType type)
		{
			return RuntimeTypeHandle.GetCorElementType(type) == CorElementType.ELEMENT_TYPE_FNPTR;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00015858 File Offset: 0x00013A58
		internal static bool IsArray(RuntimeType type)
		{
			CorElementType corElementType = RuntimeTypeHandle.GetCorElementType(type);
			return corElementType == CorElementType.ELEMENT_TYPE_ARRAY || corElementType == CorElementType.ELEMENT_TYPE_SZARRAY;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00015878 File Offset: 0x00013A78
		internal static bool IsSzArray(RuntimeType type)
		{
			return RuntimeTypeHandle.GetCorElementType(type) == CorElementType.ELEMENT_TYPE_SZARRAY;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00015884 File Offset: 0x00013A84
		internal static bool IsValueType(RuntimeType type)
		{
			return type.IsValueType;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0001588C File Offset: 0x00013A8C
		internal static bool HasElementType(RuntimeType type)
		{
			CorElementType corElementType = RuntimeTypeHandle.GetCorElementType(type);
			return corElementType == CorElementType.ELEMENT_TYPE_ARRAY || corElementType == CorElementType.ELEMENT_TYPE_SZARRAY || corElementType == CorElementType.ELEMENT_TYPE_PTR || corElementType == CorElementType.ELEMENT_TYPE_BYREF;
		}

		// Token: 0x06000659 RID: 1625
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern CorElementType GetCorElementType(QCallTypeHandle type);

		// Token: 0x0600065A RID: 1626
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool HasInstantiation(QCallTypeHandle type);

		// Token: 0x0600065B RID: 1627
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsInstanceOfType(QCallTypeHandle type, [NotNullWhen(true)] object o);

		// Token: 0x0600065C RID: 1628 RVA: 0x000158B6 File Offset: 0x00013AB6
		internal static bool IsInstanceOfType(RuntimeType type, [NotNullWhen(true)] object o)
		{
			return RuntimeTypeHandle.IsInstanceOfType(new QCallTypeHandle(ref type), o);
		}

		// Token: 0x0600065D RID: 1629
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool HasReferences(QCallTypeHandle type);

		// Token: 0x0600065E RID: 1630 RVA: 0x000158C5 File Offset: 0x00013AC5
		internal static bool HasReferences(RuntimeType type)
		{
			return RuntimeTypeHandle.HasReferences(new QCallTypeHandle(ref type));
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000158D3 File Offset: 0x00013AD3
		internal static CorElementType GetCorElementType(RuntimeType type)
		{
			return type.GetCorElementType();
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000158DB File Offset: 0x00013ADB
		internal static bool HasInstantiation(RuntimeType type)
		{
			return RuntimeTypeHandle.HasInstantiation(new QCallTypeHandle(ref type));
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00007B65 File Offset: 0x00005D65
		internal static bool IsComObject(RuntimeType type, bool isGenericCOM)
		{
			return false;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00007B65 File Offset: 0x00005D65
		internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2)
		{
			return false;
		}

		// Token: 0x06000663 RID: 1635
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetArrayRank(QCallTypeHandle type);

		// Token: 0x06000664 RID: 1636
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void GetAssembly(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x06000665 RID: 1637
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void GetElementType(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x06000666 RID: 1638
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void GetModule(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x06000667 RID: 1639
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void GetBaseType(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x06000668 RID: 1640 RVA: 0x000158E9 File Offset: 0x00013AE9
		internal static int GetArrayRank(RuntimeType type)
		{
			return RuntimeTypeHandle.GetArrayRank(new QCallTypeHandle(ref type));
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000158F8 File Offset: 0x00013AF8
		internal static RuntimeAssembly GetAssembly(RuntimeType type)
		{
			RuntimeAssembly result = null;
			RuntimeTypeHandle.GetAssembly(new QCallTypeHandle(ref type), ObjectHandleOnStack.Create<RuntimeAssembly>(ref result));
			return result;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001591C File Offset: 0x00013B1C
		internal static RuntimeModule GetModule(RuntimeType type)
		{
			RuntimeModule result = null;
			RuntimeTypeHandle.GetModule(new QCallTypeHandle(ref type), ObjectHandleOnStack.Create<RuntimeModule>(ref result));
			return result;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00015940 File Offset: 0x00013B40
		internal static RuntimeType GetElementType(RuntimeType type)
		{
			RuntimeType result = null;
			RuntimeTypeHandle.GetElementType(new QCallTypeHandle(ref type), ObjectHandleOnStack.Create<RuntimeType>(ref result));
			return result;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00015964 File Offset: 0x00013B64
		internal static RuntimeType GetBaseType(RuntimeType type)
		{
			RuntimeType result = null;
			RuntimeTypeHandle.GetBaseType(new QCallTypeHandle(ref type), ObjectHandleOnStack.Create<RuntimeType>(ref result));
			return result;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00015987 File Offset: 0x00013B87
		internal static bool CanCastTo(RuntimeType type, RuntimeType target)
		{
			return RuntimeTypeHandle.type_is_assignable_from(new QCallTypeHandle(ref target), new QCallTypeHandle(ref type));
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001599C File Offset: 0x00013B9C
		internal static bool IsGenericVariable(RuntimeType type)
		{
			CorElementType corElementType = RuntimeTypeHandle.GetCorElementType(type);
			return corElementType == CorElementType.ELEMENT_TYPE_VAR || corElementType == CorElementType.ELEMENT_TYPE_MVAR;
		}

		// Token: 0x0600066F RID: 1647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool type_is_assignable_from(QCallTypeHandle a, QCallTypeHandle b);

		// Token: 0x06000670 RID: 1648
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsGenericTypeDefinition(QCallTypeHandle type);

		// Token: 0x06000671 RID: 1649
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr GetGenericParameterInfo(QCallTypeHandle type);

		// Token: 0x06000672 RID: 1650 RVA: 0x000159BC File Offset: 0x00013BBC
		internal static bool IsGenericTypeDefinition(RuntimeType type)
		{
			return RuntimeTypeHandle.IsGenericTypeDefinition(new QCallTypeHandle(ref type));
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000159CA File Offset: 0x00013BCA
		internal static IntPtr GetGenericParameterInfo(RuntimeType type)
		{
			return RuntimeTypeHandle.GetGenericParameterInfo(new QCallTypeHandle(ref type));
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000159D8 File Offset: 0x00013BD8
		internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType)
		{
			return RuntimeTypeHandle.is_subclass_of(new QCallTypeHandle(ref childType), new QCallTypeHandle(ref baseType));
		}

		// Token: 0x06000675 RID: 1653
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool is_subclass_of(QCallTypeHandle childType, QCallTypeHandle baseType);

		// Token: 0x06000676 RID: 1654
		[DynamicDependency("#ctor()", typeof(IsByRefLikeAttribute))]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsByRefLike(QCallTypeHandle type);

		// Token: 0x06000677 RID: 1655 RVA: 0x000159ED File Offset: 0x00013BED
		internal static bool IsByRefLike(RuntimeType type)
		{
			return RuntimeTypeHandle.IsByRefLike(new QCallTypeHandle(ref type));
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000159FC File Offset: 0x00013BFC
		internal static bool IsTypeDefinition(RuntimeType type)
		{
			CorElementType corElementType = RuntimeTypeHandle.GetCorElementType(type);
			return ((corElementType >= CorElementType.ELEMENT_TYPE_VOID && corElementType < CorElementType.ELEMENT_TYPE_PTR) || corElementType == CorElementType.ELEMENT_TYPE_VALUETYPE || corElementType == CorElementType.ELEMENT_TYPE_CLASS || corElementType == CorElementType.ELEMENT_TYPE_TYPEDBYREF || corElementType == CorElementType.ELEMENT_TYPE_I || corElementType == CorElementType.ELEMENT_TYPE_U || corElementType == CorElementType.ELEMENT_TYPE_OBJECT) && (!RuntimeTypeHandle.HasInstantiation(type) || RuntimeTypeHandle.IsGenericTypeDefinition(type));
		}

		// Token: 0x06000679 RID: 1657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void internal_from_name(IntPtr name, ref StackCrawlMark stackMark, ObjectHandleOnStack res, bool throwOnError, bool ignoreCase);

		// Token: 0x0600067A RID: 1658 RVA: 0x00015A4C File Offset: 0x00013C4C
		[RequiresUnreferencedCode("Types might be removed")]
		internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			ArgumentNullException.ThrowIfNull(typeName, "typeName");
			if (typeName.Length != 0)
			{
				RuntimeType runtimeType = null;
				using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(typeName))
				{
					RuntimeTypeHandle.internal_from_name(safeStringMarshal.Value, ref stackMark, ObjectHandleOnStack.Create<RuntimeType>(ref runtimeType), throwOnError, ignoreCase);
					if (throwOnError && runtimeType == null)
					{
						throw new TypeLoadException(SR.Arg_TypeLoadException);
					}
				}
				return runtimeType;
			}
			if (throwOnError)
			{
				throw new TypeLoadException(SR.Arg_TypeLoadNullStr);
			}
			return null;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00015AD4 File Offset: 0x00013CD4
		internal static IntPtr[] CopyRuntimeTypeHandles(RuntimeTypeHandle[] inHandles, out int length)
		{
			if (inHandles == null || inHandles.Length == 0)
			{
				length = 0;
				return null;
			}
			IntPtr[] array = new IntPtr[inHandles.Length];
			for (int i = 0; i < inHandles.Length; i++)
			{
				array[i] = inHandles[i].Value;
			}
			length = array.Length;
			return array;
		}

		// Token: 0x04000296 RID: 662
		private readonly IntPtr value;
	}
}
