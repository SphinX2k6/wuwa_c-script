using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007B7 RID: 1975
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class SignatureHelper
	{
		// Token: 0x06007ECB RID: 32459 RVA: 0x0012C91F File Offset: 0x0012AB1F
		[DynamicDependency("modopts")]
		internal SignatureHelper(ModuleBuilder module, SignatureHelper.SignatureHelperType type)
		{
			AssemblyBuilder.EnsureDynamicCodeSupported();
			this.type = type;
			this.module = module;
		}

		// Token: 0x06007ECC RID: 32460 RVA: 0x0012C93A File Offset: 0x0012AB3A
		public static SignatureHelper GetFieldSigHelper([Nullable(2)] Module mod)
		{
			if (mod != null && !(mod is ModuleBuilder))
			{
				throw new NotSupportedException(SR.NotSupported_MustBeModuleBuilder);
			}
			return new SignatureHelper((ModuleBuilder)mod, SignatureHelper.SignatureHelperType.HELPER_FIELD);
		}

		// Token: 0x06007ECD RID: 32461 RVA: 0x0012C964 File Offset: 0x0012AB64
		public static SignatureHelper GetLocalVarSigHelper([Nullable(2)] Module mod)
		{
			if (mod != null && !(mod is ModuleBuilder))
			{
				throw new NotSupportedException(SR.NotSupported_MustBeModuleBuilder);
			}
			return new SignatureHelper((ModuleBuilder)mod, SignatureHelper.SignatureHelperType.HELPER_LOCAL);
		}

		// Token: 0x06007ECE RID: 32462 RVA: 0x0012C98E File Offset: 0x0012AB8E
		public static SignatureHelper GetLocalVarSigHelper()
		{
			return new SignatureHelper(null, SignatureHelper.SignatureHelperType.HELPER_LOCAL);
		}

		// Token: 0x06007ECF RID: 32463 RVA: 0x0012C997 File Offset: 0x0012AB97
		public static SignatureHelper GetMethodSigHelper(CallingConventions callingConvention, [Nullable(2)] Type returnType)
		{
			return SignatureHelper.GetMethodSigHelper(null, callingConvention, (CallingConvention)0, returnType, null);
		}

		// Token: 0x06007ED0 RID: 32464 RVA: 0x0012C9A3 File Offset: 0x0012ABA3
		[NullableContext(2)]
		[return: Nullable(1)]
		public static SignatureHelper GetMethodSigHelper(Module mod, CallingConventions callingConvention, Type returnType)
		{
			return SignatureHelper.GetMethodSigHelper(mod, callingConvention, (CallingConvention)0, returnType, null);
		}

		// Token: 0x06007ED1 RID: 32465 RVA: 0x0012C9AF File Offset: 0x0012ABAF
		[NullableContext(2)]
		[return: Nullable(1)]
		public static SignatureHelper GetMethodSigHelper(Module mod, Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			return SignatureHelper.GetMethodSigHelper(mod, CallingConventions.Standard, (CallingConvention)0, returnType, parameterTypes);
		}

		// Token: 0x06007ED2 RID: 32466 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[NullableContext(2)]
		[return: Nullable(1)]
		public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[NullableContext(2)]
		[return: Nullable(1)]
		public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] requiredReturnTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] optionalReturnTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] requiredParameterTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] optionalParameterTypeCustomModifiers)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007ED4 RID: 32468 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[NullableContext(2)]
		[return: Nullable(1)]
		public static SignatureHelper GetPropertySigHelper(Module mod, CallingConventions callingConvention, Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] requiredReturnTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] optionalReturnTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] requiredParameterTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] optionalParameterTypeCustomModifiers)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x0012C9BC File Offset: 0x0012ABBC
		private static int AppendArray([NotNull] ref Type[] array, Type t)
		{
			if (array != null)
			{
				Type[] array2 = new Type[array.Length + 1];
				Array.Copy(array, array2, array.Length);
				array2[array.Length] = t;
				array = array2;
				return array.Length - 1;
			}
			array = new Type[1];
			array[0] = t;
			return 0;
		}

		// Token: 0x06007ED6 RID: 32470 RVA: 0x0012CA04 File Offset: 0x0012AC04
		private static void AppendArrayAt([NotNull] ref Type[][] array, Type[] t, int pos)
		{
			int num = Math.Max(pos, (array == null) ? 0 : array.Length);
			Type[][] array2 = new Type[num + 1][];
			if (array != null)
			{
				Array.Copy(array, array2, num);
			}
			array2[pos] = t;
			array = array2;
		}

		// Token: 0x06007ED7 RID: 32471 RVA: 0x0012CA40 File Offset: 0x0012AC40
		private static void ValidateParameterModifiers(string name, Type[] parameter_modifiers)
		{
			foreach (Type type in parameter_modifiers)
			{
				ArgumentNullException.ThrowIfNull(type, name);
				if (type.IsArray)
				{
					throw new ArgumentException(SR.Argument_ArraysInvalid, name);
				}
				if (type.ContainsGenericParameters)
				{
					throw new ArgumentException(SR.Argument_OpenGenericTypeNotPermitted, name);
				}
			}
		}

		// Token: 0x06007ED8 RID: 32472 RVA: 0x0012CA90 File Offset: 0x0012AC90
		private static void ValidateCustomModifier(int n, Type[][] custom_modifiers, string name)
		{
			if (custom_modifiers == null)
			{
				return;
			}
			if (custom_modifiers.Length != n)
			{
				throw new ArgumentException(SR.Format(SR.Argument_CustomModifierLengthInvalidLength, custom_modifiers.Length));
			}
			foreach (Type[] array in custom_modifiers)
			{
				if (array != null)
				{
					SignatureHelper.ValidateParameterModifiers(name, array);
				}
			}
		}

		// Token: 0x06007ED9 RID: 32473 RVA: 0x0012CADD File Offset: 0x0012ACDD
		private static Exception MissingFeature()
		{
			throw new NotImplementedException(SR.NotImplemented_NoSupportForModOpt);
		}

		// Token: 0x06007EDA RID: 32474 RVA: 0x0012CAEC File Offset: 0x0012ACEC
		public void AddArguments([Nullable(new byte[]
		{
			2,
			1
		})] Type[] arguments, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] requiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] optionalCustomModifiers)
		{
			ArgumentNullException.ThrowIfNull(arguments, "arguments");
			if (requiredCustomModifiers != null || optionalCustomModifiers != null)
			{
				throw SignatureHelper.MissingFeature();
			}
			SignatureHelper.ValidateCustomModifier(arguments.Length, requiredCustomModifiers, "requiredCustomModifiers");
			SignatureHelper.ValidateCustomModifier(arguments.Length, optionalCustomModifiers, "optionalCustomModifiers");
			for (int i = 0; i < arguments.Length; i++)
			{
				this.AddArgument(arguments[i], (requiredCustomModifiers != null) ? requiredCustomModifiers[i] : null, (optionalCustomModifiers != null) ? optionalCustomModifiers[i] : null);
			}
		}

		// Token: 0x06007EDB RID: 32475 RVA: 0x0012CB55 File Offset: 0x0012AD55
		public void AddArgument(Type argument, bool pinned)
		{
			this.AddArgument(argument);
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x0012CB60 File Offset: 0x0012AD60
		public void AddArgument(Type argument, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] requiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] optionalCustomModifiers)
		{
			ArgumentNullException.ThrowIfNull(argument, "argument");
			if (requiredCustomModifiers != null)
			{
				SignatureHelper.ValidateParameterModifiers("requiredCustomModifiers", requiredCustomModifiers);
			}
			if (optionalCustomModifiers != null)
			{
				SignatureHelper.ValidateParameterModifiers("optionalCustomModifiers", optionalCustomModifiers);
			}
			int pos = SignatureHelper.AppendArray(ref this.arguments, argument);
			if (requiredCustomModifiers != null)
			{
				SignatureHelper.AppendArrayAt(ref this.modreqs, requiredCustomModifiers, pos);
			}
			if (optionalCustomModifiers != null)
			{
				SignatureHelper.AppendArrayAt(ref this.modopts, optionalCustomModifiers, pos);
			}
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x0012CBC1 File Offset: 0x0012ADC1
		public void AddArgument(Type clsArgument)
		{
			ArgumentNullException.ThrowIfNull(clsArgument, "clsArgument");
			SignatureHelper.AppendArray(ref this.arguments, clsArgument);
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public void AddSentinel()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x0012CBDC File Offset: 0x0012ADDC
		private static bool CompareOK(Type[][] one, Type[][] two)
		{
			if (one == null)
			{
				return two == null;
			}
			if (two == null)
			{
				return false;
			}
			if (one.Length != two.Length)
			{
				return false;
			}
			int i = 0;
			while (i < one.Length)
			{
				Type[] array = one[i];
				Type[] array2 = two[i];
				if (array == null)
				{
					if (array2 != null)
					{
						goto IL_32;
					}
				}
				else
				{
					if (array2 == null)
					{
						return false;
					}
					goto IL_32;
				}
				IL_83:
				i++;
				continue;
				IL_32:
				if (array.Length != array2.Length)
				{
					return false;
				}
				for (int j = 0; j < array.Length; j++)
				{
					Type type = array[j];
					Type type2 = array2[j];
					if (type == null)
					{
						if (!(type2 == null))
						{
							return false;
						}
					}
					else
					{
						if (type2 == null)
						{
							return false;
						}
						if (!type.Equals(type2))
						{
							return false;
						}
					}
				}
				goto IL_83;
			}
			return true;
		}

		// Token: 0x06007EE0 RID: 32480 RVA: 0x0012CC78 File Offset: 0x0012AE78
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			SignatureHelper signatureHelper = obj as SignatureHelper;
			if (signatureHelper == null)
			{
				return false;
			}
			if (signatureHelper.module != this.module || signatureHelper.returnType != this.returnType || signatureHelper.callConv != this.callConv || signatureHelper.unmanagedCallConv != this.unmanagedCallConv)
			{
				return false;
			}
			if (this.arguments != null)
			{
				if (signatureHelper.arguments == null)
				{
					return false;
				}
				if (this.arguments.Length != signatureHelper.arguments.Length)
				{
					return false;
				}
				for (int i = 0; i < this.arguments.Length; i++)
				{
					if (!signatureHelper.arguments[i].Equals(this.arguments[i]))
					{
						return false;
					}
				}
			}
			else if (signatureHelper.arguments != null)
			{
				return false;
			}
			return SignatureHelper.CompareOK(signatureHelper.modreqs, this.modreqs) && SignatureHelper.CompareOK(signatureHelper.modopts, this.modopts);
		}

		// Token: 0x06007EE1 RID: 32481 RVA: 0x00007B65 File Offset: 0x00005D65
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007EE2 RID: 32482
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern byte[] get_signature_local();

		// Token: 0x06007EE3 RID: 32483
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern byte[] get_signature_field();

		// Token: 0x06007EE4 RID: 32484 RVA: 0x0012CD5C File Offset: 0x0012AF5C
		public byte[] GetSignature()
		{
			RuntimeTypeBuilder.ResolveUserTypes(this.arguments);
			SignatureHelper.SignatureHelperType signatureHelperType = this.type;
			byte[] result;
			if (signatureHelperType != SignatureHelper.SignatureHelperType.HELPER_FIELD)
			{
				if (signatureHelperType != SignatureHelper.SignatureHelperType.HELPER_LOCAL)
				{
					throw new NotImplementedException();
				}
				result = this.get_signature_local();
			}
			else
			{
				result = this.get_signature_field();
			}
			return result;
		}

		// Token: 0x06007EE5 RID: 32485 RVA: 0x0012CD9B File Offset: 0x0012AF9B
		public override string ToString()
		{
			return "SignatureHelper";
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x0012CDA4 File Offset: 0x0012AFA4
		internal static SignatureHelper GetMethodSigHelper(Module mod, CallingConventions callingConvention, CallingConvention unmanagedCallingConvention, Type returnType, Type[] parameters)
		{
			if (mod != null && !(mod is ModuleBuilder))
			{
				throw new NotSupportedException(SR.NotSupported_MustBeModuleBuilder);
			}
			if (returnType == null)
			{
				returnType = typeof(void);
			}
			if (returnType.IsUserType)
			{
				throw new NotSupportedException(SR.PlatformNotSupported_UserDefinedSubclassesOfType);
			}
			if (parameters != null)
			{
				for (int i = 0; i < parameters.Length; i++)
				{
					if (parameters[i].IsUserType)
					{
						throw new NotSupportedException(SR.PlatformNotSupported_UserDefinedSubclassesOfType);
					}
				}
			}
			SignatureHelper signatureHelper = new SignatureHelper((ModuleBuilder)mod, SignatureHelper.SignatureHelperType.HELPER_METHOD);
			signatureHelper.returnType = returnType;
			signatureHelper.callConv = callingConvention;
			signatureHelper.unmanagedCallConv = unmanagedCallingConvention;
			if (parameters != null)
			{
				signatureHelper.arguments = new Type[parameters.Length];
				for (int j = 0; j < parameters.Length; j++)
				{
					signatureHelper.arguments[j] = parameters[j];
				}
			}
			return signatureHelper;
		}

		// Token: 0x04001882 RID: 6274
		private ModuleBuilder module;

		// Token: 0x04001883 RID: 6275
		private Type[] arguments;

		// Token: 0x04001884 RID: 6276
		private SignatureHelper.SignatureHelperType type;

		// Token: 0x04001885 RID: 6277
		private Type returnType;

		// Token: 0x04001886 RID: 6278
		private CallingConventions callConv;

		// Token: 0x04001887 RID: 6279
		private CallingConvention unmanagedCallConv;

		// Token: 0x04001888 RID: 6280
		private Type[][] modreqs;

		// Token: 0x04001889 RID: 6281
		private Type[][] modopts;

		// Token: 0x020007B8 RID: 1976
		internal enum SignatureHelperType
		{
			// Token: 0x0400188B RID: 6283
			HELPER_FIELD,
			// Token: 0x0400188C RID: 6284
			HELPER_LOCAL,
			// Token: 0x0400188D RID: 6285
			HELPER_METHOD,
			// Token: 0x0400188E RID: 6286
			HELPER_PROPERTY
		}
	}
}
