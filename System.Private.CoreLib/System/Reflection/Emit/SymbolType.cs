using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007B9 RID: 1977
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class SymbolType : TypeInfo
	{
		// Token: 0x06007EE7 RID: 32487 RVA: 0x0012CE6C File Offset: 0x0012B06C
		internal override Type InternalResolve()
		{
			switch (this._typeKind)
			{
			case TypeKind.IsArray:
			{
				Type type = this._baseType.InternalResolve();
				if (this._rank == 1)
				{
					return type.MakeArrayType();
				}
				return type.MakeArrayType(this._rank);
			}
			case TypeKind.IsPointer:
				return this._baseType.InternalResolve().MakePointerType();
			case TypeKind.IsByRef:
				return this._baseType.InternalResolve().MakeByRefType();
			default:
				throw new NotSupportedException();
			}
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x0012CEE8 File Offset: 0x0012B0E8
		internal override Type RuntimeResolve()
		{
			if (this._typeKind != TypeKind.IsArray)
			{
				return this.InternalResolve();
			}
			Type type = this._baseType.RuntimeResolve();
			if (this._rank == 1)
			{
				return type.MakeArrayType();
			}
			return type.MakeArrayType(this._rank);
		}

		// Token: 0x06007EE9 RID: 32489 RVA: 0x001221A1 File Offset: 0x001203A1
		public override bool IsAssignableFrom([NotNullWhen(true)] TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		// Token: 0x06007EEA RID: 32490 RVA: 0x0012CF30 File Offset: 0x0012B130
		internal static Type FormCompoundType(string format, Type baseType, int curIndex)
		{
			if (format == null || curIndex == format.Length)
			{
				return baseType;
			}
			if (format[curIndex] == '&')
			{
				SymbolType symbolType = new SymbolType(baseType, TypeKind.IsByRef);
				symbolType.SetFormat(format, curIndex, 1);
				curIndex++;
				if (curIndex != format.Length)
				{
					throw new ArgumentException(SR.Argument_BadSigFormat);
				}
				return symbolType;
			}
			else
			{
				if (format[curIndex] == '[')
				{
					SymbolType symbolType = new SymbolType(baseType, TypeKind.IsArray);
					int num = curIndex;
					curIndex++;
					int num2 = 0;
					int num3 = -1;
					while (format[curIndex] != ']')
					{
						if (format[curIndex] == '*')
						{
							symbolType._isSzArray = false;
							curIndex++;
						}
						if (char.IsAsciiDigit(format[curIndex]) || format[curIndex] == '-')
						{
							bool flag = false;
							if (format[curIndex] == '-')
							{
								flag = true;
								curIndex++;
							}
							while (char.IsAsciiDigit(format[curIndex]))
							{
								num2 *= 10;
								num2 += (int)(format[curIndex] - '0');
								curIndex++;
							}
							if (flag)
							{
								num2 = 0 - num2;
							}
							num3 = num2 - 1;
						}
						if (format[curIndex] == '.')
						{
							curIndex++;
							if (format[curIndex] != '.')
							{
								throw new ArgumentException(SR.Argument_BadSigFormat);
							}
							curIndex++;
							if (char.IsAsciiDigit(format[curIndex]) || format[curIndex] == '-')
							{
								bool flag2 = false;
								num3 = 0;
								if (format[curIndex] == '-')
								{
									flag2 = true;
									curIndex++;
								}
								while (char.IsAsciiDigit(format[curIndex]))
								{
									num3 *= 10;
									num3 += (int)(format[curIndex] - '0');
									curIndex++;
								}
								if (flag2)
								{
									num3 = 0 - num3;
								}
								if (num3 < num2)
								{
									throw new ArgumentException(SR.Argument_BadSigFormat);
								}
							}
						}
						if (format[curIndex] == ',')
						{
							curIndex++;
							symbolType.SetBounds(num2, num3);
							num2 = 0;
							num3 = -1;
						}
						else if (format[curIndex] != ']')
						{
							throw new ArgumentException(SR.Argument_BadSigFormat);
						}
					}
					symbolType.SetBounds(num2, num3);
					curIndex++;
					symbolType.SetFormat(format, num, curIndex - num);
					return SymbolType.FormCompoundType(format, symbolType, curIndex);
				}
				if (format[curIndex] == '*')
				{
					SymbolType symbolType = new SymbolType(baseType, TypeKind.IsPointer);
					symbolType.SetFormat(format, curIndex, 1);
					curIndex++;
					return SymbolType.FormCompoundType(format, symbolType, curIndex);
				}
				return null;
			}
		}

		// Token: 0x06007EEB RID: 32491 RVA: 0x0012D14C File Offset: 0x0012B34C
		internal SymbolType(Type baseType, TypeKind typeKind)
		{
			ArgumentNullException.ThrowIfNull(baseType, "baseType");
			this._baseType = baseType;
			this._typeKind = typeKind;
			this._iaLowerBound = new int[4];
			this._iaUpperBound = new int[4];
		}

		// Token: 0x06007EEC RID: 32492 RVA: 0x0012D18C File Offset: 0x0012B38C
		private void SetBounds(int lower, int upper)
		{
			if (lower != 0 || upper != -1)
			{
				this._isSzArray = false;
			}
			if (this._iaLowerBound.Length <= this._rank)
			{
				int[] array = new int[this._rank * 2];
				Array.Copy(this._iaLowerBound, array, this._rank);
				this._iaLowerBound = array;
				Array.Copy(this._iaUpperBound, array, this._rank);
				this._iaUpperBound = array;
			}
			this._iaLowerBound[this._rank] = lower;
			this._iaUpperBound[this._rank] = upper;
			this._rank++;
		}

		// Token: 0x06007EED RID: 32493 RVA: 0x0012D221 File Offset: 0x0012B421
		internal void SetFormat(string format, int curIndex, int length)
		{
			this._format = format.Substring(curIndex, length);
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06007EEE RID: 32494 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06007EEF RID: 32495 RVA: 0x0012D231 File Offset: 0x0012B431
		public override bool IsSZArray
		{
			get
			{
				return this._rank <= 1 && this._isSzArray;
			}
		}

		// Token: 0x06007EF0 RID: 32496 RVA: 0x0012D244 File Offset: 0x0012B444
		public override Type MakePointerType()
		{
			return SymbolType.FormCompoundType(this._format + "*", this._baseType, 0);
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x0012D262 File Offset: 0x0012B462
		public override Type MakeByRefType()
		{
			return SymbolType.FormCompoundType(this._format + "&", this._baseType, 0);
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x0012D280 File Offset: 0x0012B480
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public override Type MakeArrayType()
		{
			return SymbolType.FormCompoundType(this._format + "[]", this._baseType, 0);
		}

		// Token: 0x06007EF3 RID: 32499 RVA: 0x0012D2A0 File Offset: 0x0012B4A0
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public override Type MakeArrayType(int rank)
		{
			string str = SymbolType.FormatRank(rank);
			return SymbolType.FormCompoundType(this._format + str, this._baseType, 0) as SymbolType;
		}

		// Token: 0x06007EF4 RID: 32500 RVA: 0x0012265F File Offset: 0x0012085F
		internal static string FormatRank(int rank)
		{
			if (rank <= 0)
			{
				throw new IndexOutOfRangeException();
			}
			if (rank != 1)
			{
				return "[" + new string(',', rank - 1) + "]";
			}
			return "[*]";
		}

		// Token: 0x06007EF5 RID: 32501 RVA: 0x0012D2D1 File Offset: 0x0012B4D1
		public override int GetArrayRank()
		{
			if (!base.IsArray)
			{
				throw new ArgumentException(SR.Argument_HasToBeArrayClass);
			}
			return this._rank;
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06007EF6 RID: 32502 RVA: 0x0012D2EC File Offset: 0x0012B4EC
		public override Guid GUID
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_NonReflectedType);
			}
		}

		// Token: 0x06007EF7 RID: 32503 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06007EF8 RID: 32504 RVA: 0x0012D310 File Offset: 0x0012B510
		public override Module Module
		{
			get
			{
				Type baseType = this._baseType;
				while (baseType is SymbolType)
				{
					baseType = ((SymbolType)baseType)._baseType;
				}
				return baseType.Module;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06007EF9 RID: 32505 RVA: 0x0012D340 File Offset: 0x0012B540
		public override Assembly Assembly
		{
			get
			{
				Type baseType = this._baseType;
				while (baseType is SymbolType)
				{
					baseType = ((SymbolType)baseType)._baseType;
				}
				return baseType.Assembly;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06007EFA RID: 32506 RVA: 0x0012D370 File Offset: 0x0012B570
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_NonReflectedType);
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06007EFB RID: 32507 RVA: 0x0012D388 File Offset: 0x0012B588
		public override string Name
		{
			get
			{
				string str = this._format;
				Type baseType = this._baseType;
				while (baseType is SymbolType)
				{
					str = ((SymbolType)baseType)._format + str;
					baseType = ((SymbolType)baseType)._baseType;
				}
				return baseType.Name + str;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06007EFC RID: 32508 RVA: 0x0012AEB2 File Offset: 0x001290B2
		public override string FullName
		{
			get
			{
				return TypeNameBuilder.ToString(this, TypeNameBuilder.Format.FullName);
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06007EFD RID: 32509 RVA: 0x0012ADAD File Offset: 0x00128FAD
		public override string AssemblyQualifiedName
		{
			get
			{
				return TypeNameBuilder.ToString(this, TypeNameBuilder.Format.AssemblyQualifiedName);
			}
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x0012D3D7 File Offset: 0x0012B5D7
		public override string ToString()
		{
			return TypeNameBuilder.ToString(this, TypeNameBuilder.Format.ToString);
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06007EFF RID: 32511 RVA: 0x0012D3E0 File Offset: 0x0012B5E0
		public override string Namespace
		{
			get
			{
				return this._baseType.Namespace;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06007F00 RID: 32512 RVA: 0x0012D3ED File Offset: 0x0012B5ED
		public override Type BaseType
		{
			get
			{
				return typeof(Array);
			}
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F02 RID: 32514 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F03 RID: 32515 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type GetInterface(string name, bool ignoreCase)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F08 RID: 32520 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type[] GetInterfaces()
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F09 RID: 32521 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F0A RID: 32522 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		public override EventInfo[] GetEvents()
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F0B RID: 32523 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F0C RID: 32524 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F0D RID: 32525 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F11 RID: 32529 RVA: 0x0012D303 File Offset: 0x0012B503
		public override InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F12 RID: 32530 RVA: 0x0012D303 File Offset: 0x0012B503
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F13 RID: 32531 RVA: 0x0012D3FC File Offset: 0x0012B5FC
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			Type baseType = this._baseType;
			while (baseType is SymbolType)
			{
				baseType = ((SymbolType)baseType)._baseType;
			}
			return baseType.Attributes;
		}

		// Token: 0x06007F14 RID: 32532 RVA: 0x0012D42C File Offset: 0x0012B62C
		protected override bool IsArrayImpl()
		{
			return this._typeKind == TypeKind.IsArray;
		}

		// Token: 0x06007F15 RID: 32533 RVA: 0x0012D437 File Offset: 0x0012B637
		protected override bool IsPointerImpl()
		{
			return this._typeKind == TypeKind.IsPointer;
		}

		// Token: 0x06007F16 RID: 32534 RVA: 0x0012D442 File Offset: 0x0012B642
		protected override bool IsByRefImpl()
		{
			return this._typeKind == TypeKind.IsByRef;
		}

		// Token: 0x06007F17 RID: 32535 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x06007F18 RID: 32536 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsValueTypeImpl()
		{
			return false;
		}

		// Token: 0x06007F19 RID: 32537 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06007F1A RID: 32538 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007F1B RID: 32539 RVA: 0x0012D44D File Offset: 0x0012B64D
		public override Type GetElementType()
		{
			return this._baseType;
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x0012D455 File Offset: 0x0012B655
		protected override bool HasElementTypeImpl()
		{
			return this._baseType != null;
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06007F1D RID: 32541 RVA: 0x00007B62 File Offset: 0x00005D62
		public override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06007F1E RID: 32542 RVA: 0x0012D303 File Offset: 0x0012B503
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F1F RID: 32543 RVA: 0x0012D303 File Offset: 0x0012B503
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x06007F20 RID: 32544 RVA: 0x0012D303 File Offset: 0x0012B503
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotSupportedException(SR.NotSupported_NonReflectedType);
		}

		// Token: 0x0400188F RID: 6287
		internal Type _baseType;

		// Token: 0x04001890 RID: 6288
		internal TypeKind _typeKind;

		// Token: 0x04001891 RID: 6289
		internal int _rank;

		// Token: 0x04001892 RID: 6290
		internal int[] _iaLowerBound;

		// Token: 0x04001893 RID: 6291
		internal int[] _iaUpperBound;

		// Token: 0x04001894 RID: 6292
		private string _format;

		// Token: 0x04001895 RID: 6293
		private bool _isSzArray = true;
	}
}
