using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Reflection
{
	// Token: 0x020006F5 RID: 1781
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class MethodBase : MemberInfo
	{
		// Token: 0x06007609 RID: 30217 RVA: 0x001192EC File Offset: 0x001174EC
		public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
		{
			if (handle.IsNullHandle())
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			MethodBase methodFromHandleInternalType = RuntimeMethodInfo.GetMethodFromHandleInternalType(handle.Value, IntPtr.Zero);
			if (methodFromHandleInternalType == null)
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			Type declaringType = methodFromHandleInternalType.DeclaringType;
			if (declaringType != null && declaringType.IsGenericType)
			{
				throw new ArgumentException(SR.Format(SR.Argument_MethodDeclaringTypeGeneric, methodFromHandleInternalType, declaringType.GetGenericTypeDefinition()));
			}
			return methodFromHandleInternalType;
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x00119363 File Offset: 0x00117563
		public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle, RuntimeTypeHandle declaringType)
		{
			if (handle.IsNullHandle())
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			MethodBase methodFromHandleInternalType = RuntimeMethodInfo.GetMethodFromHandleInternalType(handle.Value, declaringType.Value);
			if (methodFromHandleInternalType == null)
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			return methodFromHandleInternalType;
		}

		// Token: 0x0600760B RID: 30219
		[RequiresUnreferencedCode("Metadata for the method might be incomplete or removed")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern MethodBase GetCurrentMethod();

		// Token: 0x0600760C RID: 30220 RVA: 0x001193A0 File Offset: 0x001175A0
		internal virtual ReadOnlySpan<ParameterInfo> GetParametersAsSpan()
		{
			return this.GetParametersInternal();
		}

		// Token: 0x0600760D RID: 30221 RVA: 0x0000FD41 File Offset: 0x0000DF41
		internal virtual ParameterInfo[] GetParametersInternal()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x0000FD41 File Offset: 0x0000DF41
		internal virtual int GetParametersCount()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x0000FD41 File Offset: 0x0000DF41
		internal virtual Type GetParameterType(int pos)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x0000FD41 File Offset: 0x0000DF41
		internal virtual int get_next_table_index(int table, int count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007612 RID: 30226
		[NullableContext(1)]
		public abstract ParameterInfo[] GetParameters();

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06007613 RID: 30227
		public abstract MethodAttributes Attributes { get; }

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06007614 RID: 30228 RVA: 0x001193AD File Offset: 0x001175AD
		public virtual MethodImplAttributes MethodImplementationFlags
		{
			get
			{
				return this.GetMethodImplementationFlags();
			}
		}

		// Token: 0x06007615 RID: 30229
		public abstract MethodImplAttributes GetMethodImplementationFlags();

		// Token: 0x06007616 RID: 30230 RVA: 0x00066B61 File Offset: 0x00064D61
		[RequiresUnreferencedCode("Trimming may change method bodies. For example it can change some instructions, remove branches or local variables.")]
		public virtual MethodBody GetMethodBody()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06007617 RID: 30231 RVA: 0x000070DD File Offset: 0x000052DD
		public virtual CallingConventions CallingConvention
		{
			get
			{
				return CallingConventions.Standard;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06007618 RID: 30232 RVA: 0x001193B5 File Offset: 0x001175B5
		public bool IsAbstract
		{
			get
			{
				return (this.Attributes & MethodAttributes.Abstract) > MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06007619 RID: 30233 RVA: 0x001193C6 File Offset: 0x001175C6
		public bool IsConstructor
		{
			get
			{
				return this is ConstructorInfo && !this.IsStatic && (this.Attributes & MethodAttributes.RTSpecialName) == MethodAttributes.RTSpecialName;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x0600761A RID: 30234 RVA: 0x001193ED File Offset: 0x001175ED
		public bool IsFinal
		{
			get
			{
				return (this.Attributes & MethodAttributes.Final) > MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x0600761B RID: 30235 RVA: 0x001193FB File Offset: 0x001175FB
		public bool IsHideBySig
		{
			get
			{
				return (this.Attributes & MethodAttributes.HideBySig) > MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x0600761C RID: 30236 RVA: 0x0011940C File Offset: 0x0011760C
		public bool IsSpecialName
		{
			get
			{
				return (this.Attributes & MethodAttributes.SpecialName) > MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x0600761D RID: 30237 RVA: 0x0011941D File Offset: 0x0011761D
		public bool IsStatic
		{
			get
			{
				return (this.Attributes & MethodAttributes.Static) > MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x0600761E RID: 30238 RVA: 0x0011942B File Offset: 0x0011762B
		public bool IsVirtual
		{
			get
			{
				return (this.Attributes & MethodAttributes.Virtual) > MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x0600761F RID: 30239 RVA: 0x00119439 File Offset: 0x00117639
		public bool IsAssembly
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Assembly;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06007620 RID: 30240 RVA: 0x00119446 File Offset: 0x00117646
		public bool IsFamily
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Family;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06007621 RID: 30241 RVA: 0x00119453 File Offset: 0x00117653
		public bool IsFamilyAndAssembly
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.FamANDAssem;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06007622 RID: 30242 RVA: 0x00119460 File Offset: 0x00117660
		public bool IsFamilyOrAssembly
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.FamORAssem;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06007623 RID: 30243 RVA: 0x0011946D File Offset: 0x0011766D
		public bool IsPrivate
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Private;
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06007624 RID: 30244 RVA: 0x0011947A File Offset: 0x0011767A
		public bool IsPublic
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06007625 RID: 30245 RVA: 0x00119487 File Offset: 0x00117687
		public virtual bool IsConstructedGenericMethod
		{
			get
			{
				return this.IsGenericMethod && !this.IsGenericMethodDefinition;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06007626 RID: 30246 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsGenericMethod
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06007627 RID: 30247 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsGenericMethodDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x0001A51E File Offset: 0x0001871E
		[NullableContext(1)]
		public virtual Type[] GetGenericArguments()
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06007629 RID: 30249 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool ContainsGenericParameters
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x0011949C File Offset: 0x0011769C
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object Invoke(object obj, object[] parameters)
		{
			return this.Invoke(obj, BindingFlags.Default, null, parameters, null);
		}

		// Token: 0x0600762B RID: 30251
		public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x0600762C RID: 30252
		public abstract RuntimeMethodHandle MethodHandle { get; }

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600762D RID: 30253 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsSecurityCritical
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x0600762E RID: 30254 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsSecuritySafeCritical
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x0600762F RID: 30255 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsSecurityTransparent
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x001191DA File Offset: 0x001173DA
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x001191E3 File Offset: 0x001173E3
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x0011699B File Offset: 0x00114B9B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(MethodBase left, MethodBase right)
		{
			if (right == null)
			{
				return left == null;
			}
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x001194A9 File Offset: 0x001176A9
		public static bool operator !=(MethodBase left, MethodBase right)
		{
			return !(left == right);
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x001194B8 File Offset: 0x001176B8
		internal static void AppendParameters(ref ValueStringBuilder sbParamList, Type[] parameterTypes, CallingConventions callingConvention)
		{
			string s = "";
			foreach (Type type in parameterTypes)
			{
				sbParamList.Append(s);
				string text = type.FormatTypeName();
				if (type.IsByRef)
				{
					sbParamList.Append(text.AsSpan().TrimEnd('&'));
					sbParamList.Append(" ByRef");
				}
				else
				{
					sbParamList.Append(text);
				}
				s = ", ";
			}
			if ((callingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
			{
				sbParamList.Append(s);
				sbParamList.Append("...");
			}
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00119538 File Offset: 0x00117738
		internal unsafe virtual Type[] GetParameterTypes()
		{
			ReadOnlySpan<ParameterInfo> parametersAsSpan = this.GetParametersAsSpan();
			if (parametersAsSpan.Length == 0)
			{
				return Type.EmptyTypes;
			}
			Type[] array = new Type[parametersAsSpan.Length];
			for (int i = 0; i < parametersAsSpan.Length; i++)
			{
				array[i] = parametersAsSpan[i]->ParameterType;
			}
			return array;
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x0011958C File Offset: 0x0011778C
		internal static object HandleTypeMissing(ParameterInfo paramInfo, RuntimeType sigType)
		{
			if (paramInfo.DefaultValue == DBNull.Value)
			{
				throw new ArgumentException(SR.Arg_VarMissNull, "parameters");
			}
			object obj = paramInfo.DefaultValue;
			if (sigType.IsNullableOfT && obj != null)
			{
				Type type = sigType.GetGenericArguments()[0];
				if (type.IsEnum)
				{
					obj = Enum.ToObject(type, obj);
				}
			}
			return obj;
		}

		// Token: 0x020006F6 RID: 1782
		[Flags]
		internal enum InvokerStrategy
		{
			// Token: 0x0400153C RID: 5436
			HasBeenInvoked_ObjSpanArgs = 1,
			// Token: 0x0400153D RID: 5437
			StrategyDetermined_ObjSpanArgs = 2,
			// Token: 0x0400153E RID: 5438
			HasBeenInvoked_Obj4Args = 4,
			// Token: 0x0400153F RID: 5439
			StrategyDetermined_Obj4Args = 8,
			// Token: 0x04001540 RID: 5440
			HasBeenInvoked_RefArgs = 16,
			// Token: 0x04001541 RID: 5441
			StrategyDetermined_RefArgs = 32
		}

		// Token: 0x020006F7 RID: 1783
		[Flags]
		internal enum InvokerArgFlags
		{
			// Token: 0x04001543 RID: 5443
			IsValueType = 1,
			// Token: 0x04001544 RID: 5444
			IsValueType_ByRef_Or_Pointer = 2,
			// Token: 0x04001545 RID: 5445
			IsNullableOfT = 4
		}

		// Token: 0x020006F8 RID: 1784
		[InlineArray(4)]
		internal struct ArgumentData<T>
		{
			// Token: 0x04001546 RID: 5446
			private T _arg0;
		}

		// Token: 0x020006F9 RID: 1785
		[CompilerFeatureRequired("RefStructs")]
		internal ref struct StackAllocatedArguments
		{
			// Token: 0x06007637 RID: 30263 RVA: 0x001195E4 File Offset: 0x001177E4
			public unsafe StackAllocatedArguments(object obj1, object obj2, object obj3, object obj4)
			{
				this._args = default(MethodBase.ArgumentData<object>);
				*<PrivateImplementationDetails>.InlineArrayFirstElementRef<MethodBase.ArgumentData<object>, object>(ref this._args) = obj1;
				*<PrivateImplementationDetails>.InlineArrayElementRef<MethodBase.ArgumentData<object>, object>(ref this._args, 1) = obj2;
				*<PrivateImplementationDetails>.InlineArrayElementRef<MethodBase.ArgumentData<object>, object>(ref this._args, 2) = obj3;
				*<PrivateImplementationDetails>.InlineArrayElementRef<MethodBase.ArgumentData<object>, object>(ref this._args, 3) = obj4;
			}

			// Token: 0x04001547 RID: 5447
			internal MethodBase.ArgumentData<object> _args;
		}

		// Token: 0x020006FA RID: 1786
		[CompilerFeatureRequired("RefStructs")]
		internal ref struct StackAllocatedArgumentsWithCopyBack
		{
			// Token: 0x04001548 RID: 5448
			internal MethodBase.ArgumentData<object> _args;

			// Token: 0x04001549 RID: 5449
			internal MethodBase.ArgumentData<bool> _shouldCopyBack;
		}

		// Token: 0x020006FB RID: 1787
		[CompilerFeatureRequired("RefStructs")]
		[InlineArray(4)]
		internal ref struct StackAllocatedByRefs
		{
			// Token: 0x0400154A RID: 5450
			internal unsafe byte* _arg0;
		}
	}
}
