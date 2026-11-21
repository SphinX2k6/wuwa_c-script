using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020006FE RID: 1790
	internal class ModifiedType : Type
	{
		// Token: 0x0600765D RID: 30301 RVA: 0x0011A8F0 File Offset: 0x00118AF0
		internal static Type Create(Type sourceType, object sourceTypeInfo, int parameterIndex = 0)
		{
			RuntimeType runtimeType = (RuntimeType)sourceType;
			ModifiedType.TypeSignature typeSignature;
			if (runtimeType.IsFunctionPointer)
			{
				typeSignature = new ModifiedType.TypeSignature(runtimeType, sourceTypeInfo, parameterIndex);
			}
			else
			{
				typeSignature = new ModifiedType.TypeSignature(sourceTypeInfo, parameterIndex);
			}
			return ModifiedType.Create(runtimeType, typeSignature);
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x0011A928 File Offset: 0x00118B28
		internal Type GetTypeParameter(Type unmodifiedType, int index)
		{
			Type unmodifiedType2 = this.UnmodifiedType;
			RuntimeType runtimeType = (RuntimeType)unmodifiedType;
			ModifiedType.TypeSignature typeSignature;
			if (runtimeType.IsFunctionPointer)
			{
				typeSignature = new ModifiedType.TypeSignature(runtimeType, index);
			}
			else if (unmodifiedType2.IsFunctionPointer)
			{
				RuntimeType signatureHolderType = this._typeSignature.SignatureHolderType;
				if (signatureHolderType == null)
				{
					throw new Exception("Parent's SignatureHolderType cannot be null");
				}
				RuntimeType signatureHolderType2 = signatureHolderType;
				typeSignature = new ModifiedType.TypeSignature(signatureHolderType2, index);
			}
			else
			{
				object signatureHolderInfo = this._typeSignature.SignatureHolderInfo;
				if (signatureHolderInfo == null)
				{
					throw new Exception("Parent's SignatureHolderInfo cannot be null");
				}
				object signatureHolderInfo2 = signatureHolderInfo;
				typeSignature = new ModifiedType.TypeSignature(signatureHolderInfo2, index);
			}
			return ModifiedType.Create(runtimeType, typeSignature);
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x0011A9B1 File Offset: 0x00118BB1
		internal SignatureCallingConvention GetCallingConventionFromFunctionPointer()
		{
			if (this._typeSignature.SignatureHolderType == null)
			{
				throw new Exception("SignatureHolderType cannot be null when retrieving calling conventions from a function pointer type ");
			}
			return this._typeSignature.SignatureHolderType.GetCallingConventionFromFunctionPointer();
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x0011A9DC File Offset: 0x00118BDC
		private Type[] GetCustomModifiers(bool required)
		{
			Type[] result;
			if (this._typeSignature.TryGetCustomModifiersFromSignatureHolderInfo(required, out result))
			{
				return result;
			}
			Type[] result2;
			if (this._typeSignature.TryGetCustomModifiersFromSignatureHolderType(required, out result2))
			{
				return result2;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(56, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Failed to retrieve custom modifiers on a modified type: ");
			defaultInterpolatedStringHandler.AppendFormatted<ModifiedType>(this);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x0011AA3D File Offset: 0x00118C3D
		internal ModifiedType(Type unmodifiedType, ModifiedType.TypeSignature typeSignature)
		{
			this._unmodifiedType = unmodifiedType;
			this._typeSignature = typeSignature;
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x0011AA54 File Offset: 0x00118C54
		protected static Type Create(Type unmodifiedType, ModifiedType.TypeSignature typeSignature)
		{
			Type result;
			if (unmodifiedType.IsFunctionPointer)
			{
				result = new ModifiedFunctionPointerType(unmodifiedType, typeSignature);
			}
			else if (unmodifiedType.HasElementType)
			{
				result = new ModifiedHasElementType(unmodifiedType, typeSignature);
			}
			else if (unmodifiedType.IsGenericType)
			{
				result = new ModifiedGenericType(unmodifiedType, typeSignature);
			}
			else
			{
				result = new ModifiedType(unmodifiedType, typeSignature);
			}
			return result;
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06007663 RID: 30307 RVA: 0x0011AAA0 File Offset: 0x00118CA0
		protected Type UnmodifiedType
		{
			get
			{
				return this._unmodifiedType;
			}
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x0011AAA8 File Offset: 0x00118CA8
		public override Type[] GetRequiredCustomModifiers()
		{
			return this.GetCustomModifiers(true);
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x0011AAB1 File Offset: 0x00118CB1
		public override Type[] GetOptionalCustomModifiers()
		{
			return this.GetCustomModifiers(false);
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x0011AABA File Offset: 0x00118CBA
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007667 RID: 30311 RVA: 0x0011AABA File Offset: 0x00118CBA
		public override bool Equals(Type other)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x0011AABA File Offset: 0x00118CBA
		public override int GetHashCode()
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x0011AAC6 File Offset: 0x00118CC6
		public override string ToString()
		{
			return this._unmodifiedType.ToString();
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x0600766A RID: 30314 RVA: 0x0011AAA0 File Offset: 0x00118CA0
		public override Type UnderlyingSystemType
		{
			get
			{
				return this._unmodifiedType;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x0600766B RID: 30315 RVA: 0x0011AAD3 File Offset: 0x00118CD3
		public override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				return this._unmodifiedType.GenericParameterAttributes;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x0600766C RID: 30316 RVA: 0x0011AAE0 File Offset: 0x00118CE0
		public override bool ContainsGenericParameters
		{
			get
			{
				return this._unmodifiedType.ContainsGenericParameters;
			}
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x0011AAED File Offset: 0x00118CED
		public override Type GetGenericTypeDefinition()
		{
			return this._unmodifiedType.GetGenericTypeDefinition();
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x0600766E RID: 30318 RVA: 0x0011AAFA File Offset: 0x00118CFA
		public override bool IsGenericType
		{
			get
			{
				return this._unmodifiedType.IsGenericType;
			}
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x0011AB07 File Offset: 0x00118D07
		public override Guid GUID
		{
			get
			{
				return this._unmodifiedType.GUID;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06007671 RID: 30321 RVA: 0x0011AABA File Offset: 0x00118CBA
		public override int MetadataToken
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_ModifiedType);
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06007672 RID: 30322 RVA: 0x0011AB14 File Offset: 0x00118D14
		public override Module Module
		{
			get
			{
				return this._unmodifiedType.Module;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06007673 RID: 30323 RVA: 0x0011AB21 File Offset: 0x00118D21
		public override Assembly Assembly
		{
			get
			{
				return this._unmodifiedType.Assembly;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x0011AB30 File Offset: 0x00118D30
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_ModifiedType);
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06007675 RID: 30325 RVA: 0x0011AB47 File Offset: 0x00118D47
		public override string Name
		{
			get
			{
				return this._unmodifiedType.Name;
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06007676 RID: 30326 RVA: 0x0011AB54 File Offset: 0x00118D54
		public override string FullName
		{
			get
			{
				return this._unmodifiedType.FullName;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06007677 RID: 30327 RVA: 0x0011AB61 File Offset: 0x00118D61
		public override string Namespace
		{
			get
			{
				return this._unmodifiedType.Namespace;
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06007678 RID: 30328 RVA: 0x0011AB6E File Offset: 0x00118D6E
		public override string AssemblyQualifiedName
		{
			get
			{
				return this._unmodifiedType.AssemblyQualifiedName;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06007679 RID: 30329 RVA: 0x0011AABA File Offset: 0x00118CBA
		public override Type BaseType
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_ModifiedType);
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x0600767A RID: 30330 RVA: 0x0011AABA File Offset: 0x00118CBA
		public override Type DeclaringType
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_ModifiedType);
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x0600767B RID: 30331 RVA: 0x0011AABA File Offset: 0x00118CBA
		public override Type ReflectedType
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_ModifiedType);
			}
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x0011AB7B File Offset: 0x00118D7B
		public override Type[] GetFunctionPointerCallingConventions()
		{
			return this._unmodifiedType.GetFunctionPointerCallingConventions();
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x0011AB88 File Offset: 0x00118D88
		public override Type[] GetFunctionPointerParameterTypes()
		{
			return this._unmodifiedType.GetFunctionPointerParameterTypes();
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x0011AB95 File Offset: 0x00118D95
		public override Type GetFunctionPointerReturnType()
		{
			return this._unmodifiedType.GetFunctionPointerReturnType();
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type GetInterface(string name, bool ignoreCase)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type[] GetInterfaces()
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x0011ABA2 File Offset: 0x00118DA2
		public override InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			return this._unmodifiedType.GetInterfaceMap(interfaceType);
		}

		// Token: 0x06007688 RID: 30344 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007689 RID: 30345 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		public override EventInfo[] GetEvents()
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x0011AABA File Offset: 0x00118CBA
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x0011AABA File Offset: 0x00118CBA
		public override MemberInfo GetMemberWithSameMetadataDefinitionAs(MemberInfo member)
		{
			throw new NotSupportedException(SR.NotSupported_ModifiedType);
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x0011ABB0 File Offset: 0x00118DB0
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this._unmodifiedType.Attributes;
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x0011ABBD File Offset: 0x00118DBD
		public override int GetArrayRank()
		{
			return this._unmodifiedType.GetArrayRank();
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06007694 RID: 30356 RVA: 0x0011ABCA File Offset: 0x00118DCA
		public override bool IsTypeDefinition
		{
			get
			{
				return this._unmodifiedType.IsTypeDefinition;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06007695 RID: 30357 RVA: 0x0011ABD7 File Offset: 0x00118DD7
		public override bool IsSZArray
		{
			get
			{
				return this._unmodifiedType.IsSZArray;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06007696 RID: 30358 RVA: 0x0011ABE4 File Offset: 0x00118DE4
		public override bool IsVariableBoundArray
		{
			get
			{
				return this._unmodifiedType.IsVariableBoundArray;
			}
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x0011ABF1 File Offset: 0x00118DF1
		protected override bool IsArrayImpl()
		{
			return this._unmodifiedType.IsArray;
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06007698 RID: 30360 RVA: 0x0011ABFE File Offset: 0x00118DFE
		public override bool IsEnum
		{
			get
			{
				return this._unmodifiedType.IsEnum;
			}
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x0011AC0B File Offset: 0x00118E0B
		protected override bool IsPrimitiveImpl()
		{
			return this._unmodifiedType.IsPrimitive;
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x0011AC18 File Offset: 0x00118E18
		protected override bool IsByRefImpl()
		{
			return this._unmodifiedType.IsByRef;
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x0600769B RID: 30363 RVA: 0x0011AC25 File Offset: 0x00118E25
		public override bool IsGenericTypeParameter
		{
			get
			{
				return this._unmodifiedType.IsGenericTypeParameter;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x0600769C RID: 30364 RVA: 0x0011AC32 File Offset: 0x00118E32
		public override bool IsGenericMethodParameter
		{
			get
			{
				return this._unmodifiedType.IsGenericMethodParameter;
			}
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x0011AC3F File Offset: 0x00118E3F
		protected override bool IsPointerImpl()
		{
			return this._unmodifiedType.IsPointer;
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x0011AC4C File Offset: 0x00118E4C
		protected override bool IsValueTypeImpl()
		{
			return this._unmodifiedType.IsValueType;
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x0011AC59 File Offset: 0x00118E59
		protected override bool IsCOMObjectImpl()
		{
			return this._unmodifiedType.IsCOMObject;
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x060076A0 RID: 30368 RVA: 0x0011AC66 File Offset: 0x00118E66
		public override bool IsByRefLike
		{
			get
			{
				return this._unmodifiedType.IsByRefLike;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x060076A1 RID: 30369 RVA: 0x0011AC73 File Offset: 0x00118E73
		public override bool IsConstructedGenericType
		{
			get
			{
				return this._unmodifiedType.IsConstructedGenericType;
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x060076A2 RID: 30370 RVA: 0x0011AC80 File Offset: 0x00118E80
		public override bool IsCollectible
		{
			get
			{
				return this._unmodifiedType.IsCollectible;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x060076A3 RID: 30371 RVA: 0x0011AC8D File Offset: 0x00118E8D
		public override bool IsFunctionPointer
		{
			get
			{
				return this._unmodifiedType.IsFunctionPointer;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x060076A4 RID: 30372 RVA: 0x0011AC9A File Offset: 0x00118E9A
		public override bool IsUnmanagedFunctionPointer
		{
			get
			{
				return this._unmodifiedType.IsUnmanagedFunctionPointer;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x060076A5 RID: 30373 RVA: 0x0011ACA7 File Offset: 0x00118EA7
		public override bool IsSecurityCritical
		{
			get
			{
				return this._unmodifiedType.IsSecurityCritical;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x060076A6 RID: 30374 RVA: 0x0011ACB4 File Offset: 0x00118EB4
		public override bool IsSecuritySafeCritical
		{
			get
			{
				return this._unmodifiedType.IsSecuritySafeCritical;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x060076A7 RID: 30375 RVA: 0x0011ACC1 File Offset: 0x00118EC1
		public override bool IsSecurityTransparent
		{
			get
			{
				return this._unmodifiedType.IsSecurityTransparent;
			}
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x0011ACCE File Offset: 0x00118ECE
		public override Type GetElementType()
		{
			return this._unmodifiedType.GetElementType();
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x0011ACDB File Offset: 0x00118EDB
		protected override bool HasElementTypeImpl()
		{
			return this._unmodifiedType.HasElementType;
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x0011ACE8 File Offset: 0x00118EE8
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this._unmodifiedType.GetCustomAttributes(inherit);
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x0011ACF6 File Offset: 0x00118EF6
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this._unmodifiedType.GetCustomAttributes(attributeType, inherit);
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x0011AD05 File Offset: 0x00118F05
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this._unmodifiedType.IsDefined(attributeType, inherit);
		}

		// Token: 0x0400155F RID: 5471
		private readonly ModifiedType.TypeSignature _typeSignature;

		// Token: 0x04001560 RID: 5472
		private readonly Type _unmodifiedType;

		// Token: 0x020006FF RID: 1791
		internal struct TypeSignature
		{
			// Token: 0x060076AD RID: 30381 RVA: 0x0011AD14 File Offset: 0x00118F14
			internal TypeSignature(RuntimeType signatureHolderType, int parameterIndex)
			{
				this.SignatureHolderType = signatureHolderType;
				this.SignatureHolderInfo = null;
				this.ParameterIndex = parameterIndex;
			}

			// Token: 0x060076AE RID: 30382 RVA: 0x0011AD2B File Offset: 0x00118F2B
			internal TypeSignature(object signatureHolderInfo, int parameterIndex)
			{
				this.SignatureHolderType = null;
				this.SignatureHolderInfo = signatureHolderInfo;
				this.ParameterIndex = parameterIndex;
			}

			// Token: 0x060076AF RID: 30383 RVA: 0x0011AD42 File Offset: 0x00118F42
			internal TypeSignature(RuntimeType signatureHolderType, object signatureHolderInfo, int parameterIndex)
			{
				this.SignatureHolderType = signatureHolderType;
				this.SignatureHolderInfo = signatureHolderInfo;
				this.ParameterIndex = parameterIndex;
			}

			// Token: 0x060076B0 RID: 30384 RVA: 0x0011AD5C File Offset: 0x00118F5C
			internal bool TryGetCustomModifiersFromSignatureHolderInfo(bool required, out Type[] modifiers)
			{
				if (this.SignatureHolderInfo == null)
				{
					modifiers = Type.EmptyTypes;
					return false;
				}
				object signatureHolderInfo = this.SignatureHolderInfo;
				RuntimeFieldInfo runtimeFieldInfo = signatureHolderInfo as RuntimeFieldInfo;
				if (runtimeFieldInfo == null)
				{
					RuntimeParameterInfo runtimeParameterInfo = signatureHolderInfo as RuntimeParameterInfo;
					if (runtimeParameterInfo == null)
					{
						RuntimePropertyInfo runtimePropertyInfo = signatureHolderInfo as RuntimePropertyInfo;
						if (runtimePropertyInfo == null)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 1);
							defaultInterpolatedStringHandler.AppendLiteral("SignatureHolderInfo: ");
							defaultInterpolatedStringHandler.AppendFormatted<object>(this.SignatureHolderInfo);
							defaultInterpolatedStringHandler.AppendLiteral(" is not recognized");
							throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
						}
						modifiers = runtimePropertyInfo.GetCustomModifiersFromModifiedType(!required, runtimePropertyInfo.PropertyType.IsGenericType ? this.ParameterIndex : -1);
					}
					else
					{
						modifiers = runtimeParameterInfo.GetCustomModifiersFromModifiedType(!required, runtimeParameterInfo.ParameterType.IsGenericType ? this.ParameterIndex : -1);
					}
				}
				else
				{
					modifiers = runtimeFieldInfo.GetCustomModifiersFromModifiedType(!required, runtimeFieldInfo.FieldType.IsGenericType ? this.ParameterIndex : -1);
				}
				return true;
			}

			// Token: 0x060076B1 RID: 30385 RVA: 0x0011AE4D File Offset: 0x0011904D
			internal bool TryGetCustomModifiersFromSignatureHolderType(bool required, out Type[] modifiers)
			{
				if (this.SignatureHolderType == null)
				{
					modifiers = Type.EmptyTypes;
					return false;
				}
				modifiers = this.SignatureHolderType.GetCustomModifiersFromFunctionPointer(this.ParameterIndex, !required);
				return true;
			}

			// Token: 0x04001561 RID: 5473
			internal readonly RuntimeType SignatureHolderType;

			// Token: 0x04001562 RID: 5474
			internal readonly object SignatureHolderInfo;

			// Token: 0x04001563 RID: 5475
			internal int ParameterIndex;
		}
	}
}
