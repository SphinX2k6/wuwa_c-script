using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x020006F1 RID: 1777
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class FieldInfo : MemberInfo
	{
		// Token: 0x060075CA RID: 30154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle);

		// Token: 0x060075CB RID: 30155 RVA: 0x00118F07 File Offset: 0x00117107
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
		{
			if (handle.IsNullHandle())
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			return FieldInfo.internal_from_handle_type(handle.Value, IntPtr.Zero);
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x00118F2E File Offset: 0x0011712E
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
		{
			if (handle.IsNullHandle())
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			FieldInfo fieldInfo = FieldInfo.internal_from_handle_type(handle.Value, declaringType.Value);
			if (fieldInfo == null)
			{
				throw new ArgumentException(SR.Argument_FieldPropertyEventAndTypeHandleIncompatibility);
			}
			return fieldInfo;
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x0001A4BD File Offset: 0x000186BD
		internal virtual int GetFieldOffset()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x060075CE RID: 30158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MarshalAsAttribute get_marshal_info();

		// Token: 0x060075CF RID: 30159 RVA: 0x00118F6C File Offset: 0x0011716C
		internal object[] GetPseudoCustomAttributes()
		{
			int num = 0;
			if (this.IsNotSerialized)
			{
				num++;
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				num++;
			}
			MarshalAsAttribute marshal_info = this.get_marshal_info();
			if (marshal_info != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			object[] array = new object[num];
			num = 0;
			if (this.IsNotSerialized)
			{
				array[num++] = new NonSerializedAttribute();
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				array[num++] = new FieldOffsetAttribute(this.GetFieldOffset());
			}
			if (marshal_info != null)
			{
				array[num++] = marshal_info;
			}
			return array;
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00118FF4 File Offset: 0x001171F4
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			int num = 0;
			if (this.IsNotSerialized)
			{
				num++;
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				num++;
			}
			MarshalAsAttribute marshal_info = this.get_marshal_info();
			if (marshal_info != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			CustomAttributeData[] array = new CustomAttributeData[num];
			num = 0;
			if (this.IsNotSerialized)
			{
				array[num++] = new RuntimeCustomAttributeData(typeof(NonSerializedAttribute).GetConstructor(Type.EmptyTypes));
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				CustomAttributeTypedArgument[] ctorArgs = new CustomAttributeTypedArgument[]
				{
					new CustomAttributeTypedArgument(typeof(int), this.GetFieldOffset())
				};
				array[num++] = new RuntimeCustomAttributeData(typeof(FieldOffsetAttribute).GetConstructor(new Type[]
				{
					typeof(int)
				}), ctorArgs, Array.Empty<CustomAttributeNamedArgument>());
			}
			if (marshal_info != null)
			{
				CustomAttributeTypedArgument[] ctorArgs2 = new CustomAttributeTypedArgument[]
				{
					new CustomAttributeTypedArgument(typeof(UnmanagedType), marshal_info.Value)
				};
				array[num++] = new RuntimeCustomAttributeData(typeof(MarshalAsAttribute).GetConstructor(new Type[]
				{
					typeof(UnmanagedType)
				}), ctorArgs2, Array.Empty<CustomAttributeNamedArgument>());
			}
			return array;
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x060075D2 RID: 30162 RVA: 0x000211FB File Offset: 0x0001F3FB
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Field;
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x060075D3 RID: 30163
		public abstract FieldAttributes Attributes { get; }

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x060075D4 RID: 30164
		public abstract Type FieldType { get; }

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x060075D5 RID: 30165 RVA: 0x0011912F File Offset: 0x0011732F
		public bool IsInitOnly
		{
			get
			{
				return (this.Attributes & FieldAttributes.InitOnly) > FieldAttributes.PrivateScope;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x060075D6 RID: 30166 RVA: 0x0011913D File Offset: 0x0011733D
		public bool IsLiteral
		{
			get
			{
				return (this.Attributes & FieldAttributes.Literal) > FieldAttributes.PrivateScope;
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x060075D7 RID: 30167 RVA: 0x0011914B File Offset: 0x0011734B
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public bool IsNotSerialized
		{
			get
			{
				return (this.Attributes & FieldAttributes.NotSerialized) > FieldAttributes.PrivateScope;
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x060075D8 RID: 30168 RVA: 0x0011915C File Offset: 0x0011735C
		public bool IsPinvokeImpl
		{
			get
			{
				return (this.Attributes & FieldAttributes.PinvokeImpl) > FieldAttributes.PrivateScope;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x060075D9 RID: 30169 RVA: 0x0011916D File Offset: 0x0011736D
		public bool IsSpecialName
		{
			get
			{
				return (this.Attributes & FieldAttributes.SpecialName) > FieldAttributes.PrivateScope;
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x060075DA RID: 30170 RVA: 0x0011917E File Offset: 0x0011737E
		public bool IsStatic
		{
			get
			{
				return (this.Attributes & FieldAttributes.Static) > FieldAttributes.PrivateScope;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x060075DB RID: 30171 RVA: 0x0011918C File Offset: 0x0011738C
		public bool IsAssembly
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Assembly;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x060075DC RID: 30172 RVA: 0x00119199 File Offset: 0x00117399
		public bool IsFamily
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Family;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x060075DD RID: 30173 RVA: 0x001191A6 File Offset: 0x001173A6
		public bool IsFamilyAndAssembly
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.FamANDAssem;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x060075DE RID: 30174 RVA: 0x001191B3 File Offset: 0x001173B3
		public bool IsFamilyOrAssembly
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.FamORAssem;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x060075DF RID: 30175 RVA: 0x001191C0 File Offset: 0x001173C0
		public bool IsPrivate
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Private;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x060075E0 RID: 30176 RVA: 0x001191CD File Offset: 0x001173CD
		public bool IsPublic
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x060075E1 RID: 30177 RVA: 0x000070DD File Offset: 0x000052DD
		public virtual bool IsSecurityCritical
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x060075E2 RID: 30178 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsSecuritySafeCritical
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x060075E3 RID: 30179 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsSecurityTransparent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x060075E4 RID: 30180
		public abstract RuntimeFieldHandle FieldHandle { get; }

		// Token: 0x060075E5 RID: 30181 RVA: 0x001191DA File Offset: 0x001173DA
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x001191E3 File Offset: 0x001173E3
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x0011699B File Offset: 0x00114B9B
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(FieldInfo left, FieldInfo right)
		{
			if (right == null)
			{
				return left == null;
			}
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x001191EB File Offset: 0x001173EB
		[NullableContext(2)]
		public static bool operator !=(FieldInfo left, FieldInfo right)
		{
			return !(left == right);
		}

		// Token: 0x060075E9 RID: 30185
		[NullableContext(2)]
		public abstract object GetValue(object obj);

		// Token: 0x060075EA RID: 30186 RVA: 0x001191F7 File Offset: 0x001173F7
		[NullableContext(2)]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public void SetValue(object obj, object value)
		{
			this.SetValue(obj, value, BindingFlags.Default, Type.DefaultBinder, null);
		}

		// Token: 0x060075EB RID: 30187
		[NullableContext(2)]
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		// Token: 0x060075EC RID: 30188 RVA: 0x00119208 File Offset: 0x00117408
		[CLSCompliant(false)]
		public virtual void SetValueDirect(TypedReference obj, object value)
		{
			throw new NotSupportedException(SR.NotSupported_AbstractNonCLS);
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x00119208 File Offset: 0x00117408
		[NullableContext(2)]
		[CLSCompliant(false)]
		public virtual object GetValueDirect(TypedReference obj)
		{
			throw new NotSupportedException(SR.NotSupported_AbstractNonCLS);
		}

		// Token: 0x060075EE RID: 30190 RVA: 0x00119208 File Offset: 0x00117408
		[NullableContext(2)]
		public virtual object GetRawConstantValue()
		{
			throw new NotSupportedException(SR.NotSupported_AbstractNonCLS);
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x0001A563 File Offset: 0x00018763
		public virtual Type GetModifiedFieldType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual Type[] GetOptionalCustomModifiers()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual Type[] GetRequiredCustomModifiers()
		{
			throw NotImplemented.ByDesign;
		}
	}
}
