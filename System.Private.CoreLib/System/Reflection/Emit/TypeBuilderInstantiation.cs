using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007BA RID: 1978
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class TypeBuilderInstantiation : TypeInfo
	{
		// Token: 0x06007F21 RID: 32545 RVA: 0x0012D464 File Offset: 0x0012B664
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:UnrecognizedReflectionPattern", Justification = "Reflection.Emit is not subject to trimming")]
		internal override Type InternalResolve()
		{
			Type type = this._genericType.InternalResolve();
			Type[] array = new Type[this._typeArguments.Length];
			for (int i = 0; i < this._typeArguments.Length; i++)
			{
				array[i] = this._typeArguments[i].InternalResolve();
			}
			return type.MakeGenericType(array);
		}

		// Token: 0x06007F22 RID: 32546 RVA: 0x0012D4B8 File Offset: 0x0012B6B8
		internal override Type RuntimeResolve()
		{
			TypeBuilder typeBuilder = this._genericType as TypeBuilder;
			if (typeBuilder != null && !typeBuilder.IsCreated())
			{
				throw new NotImplementedException();
			}
			for (int i = 0; i < this._typeArguments.Length; i++)
			{
				TypeBuilder typeBuilder2 = this._typeArguments[i] as TypeBuilder;
				if (typeBuilder2 != null && !typeBuilder2.IsCreated())
				{
					throw new NotImplementedException();
				}
			}
			return this.InternalResolve();
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06007F23 RID: 32547 RVA: 0x0012D51C File Offset: 0x0012B71C
		internal override bool IsUserType
		{
			get
			{
				Type[] typeArguments = this._typeArguments;
				for (int i = 0; i < typeArguments.Length; i++)
				{
					if (typeArguments[i].IsUserType)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06007F24 RID: 32548 RVA: 0x0012D54B File Offset: 0x0012B74B
		internal override MethodInfo GetMethod(MethodInfo fromNonInstantiated)
		{
			return new MethodOnTypeBuilderInstantiation(fromNonInstantiated, this);
		}

		// Token: 0x06007F25 RID: 32549 RVA: 0x0012D554 File Offset: 0x0012B754
		internal override ConstructorInfo GetConstructor(ConstructorInfo fromNoninstanciated)
		{
			return new ConstructorOnTypeBuilderInstantiation(fromNoninstanciated, this);
		}

		// Token: 0x06007F26 RID: 32550 RVA: 0x0012D55D File Offset: 0x0012B75D
		internal override FieldInfo GetField(FieldInfo fromNoninstanciated)
		{
			return FieldOnTypeBuilderInstantiation.GetField(fromNoninstanciated, this);
		}

		// Token: 0x06007F27 RID: 32551 RVA: 0x001221A1 File Offset: 0x001203A1
		public override bool IsAssignableFrom([NotNullWhen(true)] TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		// Token: 0x06007F28 RID: 32552 RVA: 0x0012D568 File Offset: 0x0012B768
		internal static Type MakeGenericType(Type type, Type[] typeArguments)
		{
			if (!type.IsGenericTypeDefinition)
			{
				throw new InvalidOperationException();
			}
			ArgumentNullException.ThrowIfNull(typeArguments, "typeArguments");
			for (int i = 0; i < typeArguments.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(typeArguments[i], "typeArguments");
			}
			return new TypeBuilderInstantiation(type, typeArguments);
		}

		// Token: 0x06007F29 RID: 32553 RVA: 0x0012D5B2 File Offset: 0x0012B7B2
		internal TypeBuilderInstantiation(Type type, Type[] inst)
		{
			this._genericType = type;
			this._typeArguments = inst;
			this._hashtable = new Hashtable();
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x0012D3D7 File Offset: 0x0012B5D7
		public override string ToString()
		{
			return TypeNameBuilder.ToString(this, TypeNameBuilder.Format.ToString);
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06007F2B RID: 32555 RVA: 0x0012D5D3 File Offset: 0x0012B7D3
		public override Type DeclaringType
		{
			get
			{
				return this._genericType.DeclaringType;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06007F2C RID: 32556 RVA: 0x0012D5E0 File Offset: 0x0012B7E0
		public override Type ReflectedType
		{
			get
			{
				return this._genericType.ReflectedType;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06007F2D RID: 32557 RVA: 0x0012D5ED File Offset: 0x0012B7ED
		public override string Name
		{
			get
			{
				return this._genericType.Name;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06007F2E RID: 32558 RVA: 0x0012D5FA File Offset: 0x0012B7FA
		public override Module Module
		{
			get
			{
				return this._genericType.Module;
			}
		}

		// Token: 0x06007F2F RID: 32559 RVA: 0x001276AB File Offset: 0x001258AB
		public override Type MakePointerType()
		{
			return SymbolType.FormCompoundType("*", this, 0);
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x0012768B File Offset: 0x0012588B
		public override Type MakeByRefType()
		{
			return SymbolType.FormCompoundType("&", this, 0);
		}

		// Token: 0x06007F31 RID: 32561 RVA: 0x0012766E File Offset: 0x0012586E
		public override Type MakeArrayType()
		{
			return SymbolType.FormCompoundType("[]", this, 0);
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x0012D607 File Offset: 0x0012B807
		public override Type MakeArrayType(int rank)
		{
			if (rank <= 0)
			{
				throw new IndexOutOfRangeException();
			}
			return SymbolType.FormCompoundType((rank == 1) ? "[]" : ("[" + new string(',', rank - 1) + "]"), this, 0);
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06007F33 RID: 32563 RVA: 0x0012D640 File Offset: 0x0012B840
		public override Guid GUID
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06007F35 RID: 32565 RVA: 0x0012D652 File Offset: 0x0012B852
		public override Assembly Assembly
		{
			get
			{
				return this._genericType.Assembly;
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06007F36 RID: 32566 RVA: 0x0012D660 File Offset: 0x0012B860
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06007F37 RID: 32567 RVA: 0x0012D674 File Offset: 0x0012B874
		public override string FullName
		{
			get
			{
				string result;
				if ((result = this._strFullQualName) == null)
				{
					result = (this._strFullQualName = TypeNameBuilder.ToString(this, TypeNameBuilder.Format.FullName));
				}
				return result;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06007F38 RID: 32568 RVA: 0x0012D69B File Offset: 0x0012B89B
		public override string Namespace
		{
			get
			{
				return this._genericType.Namespace;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06007F39 RID: 32569 RVA: 0x0012ADAD File Offset: 0x00128FAD
		public override string AssemblyQualifiedName
		{
			get
			{
				return TypeNameBuilder.ToString(this, TypeNameBuilder.Format.AssemblyQualifiedName);
			}
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x0012D6A8 File Offset: 0x0012B8A8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:UnrecognizedReflectionPattern", Justification = "The entire TypeBuilderInstantiation is serving the MakeGenericType implementation. Currently this is not supported by linker. Once it is supported the outercall (Type.MakeGenericType)will validate that the types fulfill the necessary requirements of annotations on type parameters.As such the actual internals of the implementation are not interesting.")]
		private Type Substitute(Type[] substitutes)
		{
			Type[] genericArguments = this.GetGenericArguments();
			Type[] array = new Type[genericArguments.Length];
			for (int i = 0; i < array.Length; i++)
			{
				Type type = genericArguments[i];
				TypeBuilderInstantiation typeBuilderInstantiation = type as TypeBuilderInstantiation;
				if (typeBuilderInstantiation != null)
				{
					array[i] = typeBuilderInstantiation.Substitute(substitutes);
				}
				else if (type is GenericTypeParameterBuilder)
				{
					array[i] = substitutes[type.GenericParameterPosition];
				}
				else
				{
					array[i] = type;
				}
			}
			return this.GetGenericTypeDefinition().MakeGenericType(array);
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06007F3B RID: 32571 RVA: 0x0012D718 File Offset: 0x0012B918
		public override Type BaseType
		{
			get
			{
				Type baseType = this._genericType.BaseType;
				if (baseType == null)
				{
					return null;
				}
				TypeBuilderInstantiation typeBuilderInstantiation = baseType as TypeBuilderInstantiation;
				if (typeBuilderInstantiation == null)
				{
					return baseType;
				}
				return typeBuilderInstantiation.Substitute(this.GetGenericArguments());
			}
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F3D RID: 32573 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type GetInterface(string name, bool ignoreCase)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type[] GetInterfaces()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		public override EventInfo[] GetEvents()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F49 RID: 32585 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x0001A563 File Offset: 0x00018763
		public override InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F4D RID: 32589 RVA: 0x0001A563 File Offset: 0x00018763
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F4E RID: 32590 RVA: 0x0012D75A File Offset: 0x0012B95A
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this._genericType.Attributes;
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06007F4F RID: 32591 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06007F50 RID: 32592 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007F51 RID: 32593 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06007F52 RID: 32594 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x06007F54 RID: 32596 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x06007F55 RID: 32597 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x0001A563 File Offset: 0x00018763
		public override Type GetElementType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool HasElementTypeImpl()
		{
			return false;
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06007F58 RID: 32600 RVA: 0x00007B62 File Offset: 0x00005D62
		public override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x0012D767 File Offset: 0x0012B967
		public override Type[] GetGenericArguments()
		{
			return this._typeArguments;
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06007F5A RID: 32602 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06007F5B RID: 32603 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsGenericType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06007F5C RID: 32604 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsConstructedGenericType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06007F5D RID: 32605 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06007F5E RID: 32606 RVA: 0x00066B61 File Offset: 0x00064D61
		public override int GenericParameterPosition
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x0012D76F File Offset: 0x0012B96F
		protected override bool IsValueTypeImpl()
		{
			return this._genericType.IsValueType;
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06007F60 RID: 32608 RVA: 0x0012D77C File Offset: 0x0012B97C
		public override bool ContainsGenericParameters
		{
			get
			{
				for (int i = 0; i < this._typeArguments.Length; i++)
				{
					if (this._typeArguments[i].ContainsGenericParameters)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06007F61 RID: 32609 RVA: 0x0001A4BA File Offset: 0x000186BA
		public override MethodBase DeclaringMethod
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x0012D7AE File Offset: 0x0012B9AE
		public override Type GetGenericTypeDefinition()
		{
			return this._genericType;
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x00127699 File Offset: 0x00125899
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public override Type MakeGenericType(params Type[] inst)
		{
			throw new InvalidOperationException(SR.Format(SR.Arg_NotGenericTypeDefinition, this));
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x0001A563 File Offset: 0x00018763
		public override bool IsAssignableFrom([NotNullWhen(true)] Type c)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F65 RID: 32613 RVA: 0x0001A563 File Offset: 0x00018763
		public override bool IsSubclassOf(Type c)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F66 RID: 32614 RVA: 0x0001A563 File Offset: 0x00018763
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x0001A563 File Offset: 0x00018763
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x0001A563 File Offset: 0x00018763
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001896 RID: 6294
		private Type _genericType;

		// Token: 0x04001897 RID: 6295
		private Type[] _typeArguments;

		// Token: 0x04001898 RID: 6296
		private string _strFullQualName;

		// Token: 0x04001899 RID: 6297
		internal Hashtable _hashtable;
	}
}
