using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000079 RID: 121
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class Delegate : ICloneable, ISerializable
	{
		// Token: 0x0600031E RID: 798 RVA: 0x0000A0CE File Offset: 0x000082CE
		[RequiresUnreferencedCode("The target method might be removed")]
		protected Delegate(object target, string method)
		{
			ArgumentNullException.ThrowIfNull(target, "target");
			ArgumentNullException.ThrowIfNull(method, "method");
			this._target = target;
			this.data = new DelegateData
			{
				method_name = method
			};
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000A108 File Offset: 0x00008308
		protected Delegate([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type target, string method)
		{
			ArgumentNullException.ThrowIfNull(target, "target");
			if (target.ContainsGenericParameters)
			{
				throw new ArgumentException(SR.Arg_UnboundGenParam, "target");
			}
			ArgumentNullException.ThrowIfNull(method, "method");
			if (!(target is RuntimeType))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "target");
			}
			this.data = new DelegateData
			{
				method_name = method,
				target_type = target
			};
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000A17A File Offset: 0x0000837A
		[Nullable(2)]
		public object Target
		{
			[NullableContext(2)]
			get
			{
				return this.GetTarget();
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000A182 File Offset: 0x00008382
		internal virtual object GetTarget()
		{
			return this._target;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000A18A File Offset: 0x0000838A
		public static Delegate CreateDelegate(Type type, [Nullable(2)] object firstArgument, MethodInfo method, bool throwOnBindFailure)
		{
			return Delegate.CreateDelegate(type, firstArgument, method, throwOnBindFailure, true);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000A196 File Offset: 0x00008396
		[return: Nullable(2)]
		public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
		{
			return Delegate.CreateDelegate(type, null, method, throwOnBindFailure, false);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000A1A4 File Offset: 0x000083A4
		private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			ArgumentNullException.ThrowIfNull(method, "method");
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "type");
			}
			if (!(method is RuntimeMethodInfo) && !(method is DynamicMethod))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeMethodInfo, "method");
			}
			if (!runtimeType.IsDelegate())
			{
				throw new ArgumentException(SR.Arg_MustBeDelegate, "type");
			}
			DelegateData delegateData;
			if (Delegate.IsMatchingCandidate(runtimeType, firstArgument, method, allowClosed, out delegateData))
			{
				Delegate @delegate = Delegate.CreateDelegate_internal(new QCallTypeHandle(ref runtimeType), firstArgument, method, throwOnBindFailure);
				if (@delegate != null)
				{
					@delegate.original_method_info = method;
					@delegate.data = delegateData;
				}
				return @delegate;
			}
			if (throwOnBindFailure)
			{
				throw new ArgumentException(SR.Arg_DlgtTargMeth);
			}
			return null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000A25C File Offset: 0x0000845C
		[RequiresUnreferencedCode("The target method might be removed")]
		[return: Nullable(2)]
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			ArgumentNullException.ThrowIfNull(target, "target");
			ArgumentNullException.ThrowIfNull(method, "method");
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "type");
			}
			if (!runtimeType.IsDelegate())
			{
				throw new ArgumentException(SR.Arg_MustBeDelegate, "type");
			}
			MethodInfo candidateMethod = Delegate.GetCandidateMethod(runtimeType, target.GetType(), method, BindingFlags.Instance, ignoreCase);
			if (candidateMethod != null)
			{
				return Delegate.CreateDelegate_internal(new QCallTypeHandle(ref runtimeType), target, candidateMethod, throwOnBindFailure);
			}
			if (throwOnBindFailure)
			{
				throw new ArgumentException(SR.Arg_DlgtTargMeth);
			}
			return null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[return: Nullable(2)]
		public static Delegate CreateDelegate(Type type, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			ArgumentNullException.ThrowIfNull(target, "target");
			if (target.ContainsGenericParameters)
			{
				throw new ArgumentException(SR.Arg_UnboundGenParam, "target");
			}
			ArgumentNullException.ThrowIfNull(method, "method");
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "type");
			}
			if (!(target is RuntimeType))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "target");
			}
			if (!runtimeType.IsDelegate())
			{
				throw new ArgumentException(SR.Arg_MustBeDelegate, "type");
			}
			MethodInfo candidateMethod = Delegate.GetCandidateMethod(runtimeType, target, method, BindingFlags.Static, ignoreCase);
			if (candidateMethod != null)
			{
				return Delegate.CreateDelegate_internal(new QCallTypeHandle(ref runtimeType), null, candidateMethod, throwOnBindFailure);
			}
			if (throwOnBindFailure)
			{
				throw new ArgumentException(SR.Arg_DlgtTargMeth);
			}
			return null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000A3B0 File Offset: 0x000085B0
		private unsafe static MethodInfo GetCandidateMethod(RuntimeType type, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type target, string method, BindingFlags bflags, bool ignoreCase)
		{
			MethodInfo delegateInvokeMethod = Delegate.GetDelegateInvokeMethod(type);
			if (delegateInvokeMethod == null)
			{
				return null;
			}
			ReadOnlySpan<ParameterInfo> parametersAsSpan = delegateInvokeMethod.GetParametersAsSpan();
			Type[] array = new Type[parametersAsSpan.Length];
			for (int i = 0; i < parametersAsSpan.Length; i++)
			{
				array[i] = parametersAsSpan[i]->ParameterType;
			}
			BindingFlags bindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.ExactBinding | bflags;
			if (ignoreCase)
			{
				bindingFlags |= BindingFlags.IgnoreCase;
			}
			Type type2 = target;
			while (type2 != null)
			{
				MethodInfo methodInfo = type2.GetMethod(method, bindingFlags, null, array, Array.Empty<ParameterModifier>());
				if (methodInfo != null && Delegate.IsReturnTypeMatch(delegateInvokeMethod.ReturnType, methodInfo.ReturnType))
				{
					return methodInfo;
				}
				type2 = type2.BaseType;
			}
			return null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000A464 File Offset: 0x00008664
		private unsafe static bool IsMatchingCandidate(RuntimeType type, object target, MethodInfo method, bool allowClosed, out DelegateData delegateData)
		{
			MethodInfo delegateInvokeMethod = Delegate.GetDelegateInvokeMethod(type);
			if (delegateInvokeMethod == null || !Delegate.IsReturnTypeMatch(delegateInvokeMethod.ReturnType, method.ReturnType))
			{
				delegateData = null;
				return false;
			}
			ReadOnlySpan<ParameterInfo> parametersAsSpan = delegateInvokeMethod.GetParametersAsSpan();
			ReadOnlySpan<ParameterInfo> parametersAsSpan2 = method.GetParametersAsSpan();
			bool flag;
			if (target != null)
			{
				if (!method.IsStatic)
				{
					flag = (parametersAsSpan2.Length == parametersAsSpan.Length);
				}
				else
				{
					flag = (parametersAsSpan2.Length == parametersAsSpan.Length + 1);
				}
			}
			else if (!method.IsStatic)
			{
				flag = (parametersAsSpan2.Length + 1 == parametersAsSpan.Length);
				if (!flag)
				{
					flag = (parametersAsSpan2.Length == parametersAsSpan.Length);
				}
			}
			else
			{
				flag = (parametersAsSpan2.Length == parametersAsSpan.Length);
				if (!flag)
				{
					flag = (parametersAsSpan2.Length == parametersAsSpan.Length + 1);
				}
			}
			if (!flag)
			{
				delegateData = null;
				return false;
			}
			delegateData = new DelegateData();
			bool flag2;
			if (target != null)
			{
				if (!method.IsStatic)
				{
					flag2 = Delegate.IsArgumentTypeMatchWithThis(target.GetType(), method.DeclaringType, true);
					for (int i = 0; i < parametersAsSpan2.Length; i++)
					{
						flag2 &= Delegate.IsArgumentTypeMatch(parametersAsSpan[i]->ParameterType, parametersAsSpan2[i]->ParameterType);
					}
				}
				else
				{
					flag2 = Delegate.IsArgumentTypeMatch(target.GetType(), parametersAsSpan2[0]->ParameterType);
					for (int j = 1; j < parametersAsSpan2.Length; j++)
					{
						flag2 &= Delegate.IsArgumentTypeMatch(parametersAsSpan[j - 1]->ParameterType, parametersAsSpan2[j]->ParameterType);
					}
					delegateData.curried_first_arg = true;
				}
			}
			else if (!method.IsStatic)
			{
				if (parametersAsSpan2.Length + 1 == parametersAsSpan.Length)
				{
					flag2 = Delegate.IsArgumentTypeMatchWithThis(parametersAsSpan[0]->ParameterType, method.DeclaringType, false);
					for (int k = 0; k < parametersAsSpan2.Length; k++)
					{
						flag2 &= Delegate.IsArgumentTypeMatch(parametersAsSpan[k + 1]->ParameterType, parametersAsSpan2[k]->ParameterType);
					}
				}
				else
				{
					flag2 = allowClosed;
					for (int l = 0; l < parametersAsSpan2.Length; l++)
					{
						flag2 &= Delegate.IsArgumentTypeMatch(parametersAsSpan[l]->ParameterType, parametersAsSpan2[l]->ParameterType);
					}
				}
			}
			else if (parametersAsSpan.Length + 1 == parametersAsSpan2.Length)
			{
				flag2 = (!parametersAsSpan2[0]->ParameterType.IsValueType && !parametersAsSpan2[0]->ParameterType.IsByRef && allowClosed);
				for (int m = 0; m < parametersAsSpan.Length; m++)
				{
					flag2 &= Delegate.IsArgumentTypeMatch(parametersAsSpan[m]->ParameterType, parametersAsSpan2[m + 1]->ParameterType);
				}
				delegateData.curried_first_arg = true;
			}
			else
			{
				flag2 = true;
				for (int n = 0; n < parametersAsSpan2.Length; n++)
				{
					flag2 &= Delegate.IsArgumentTypeMatch(parametersAsSpan[n]->ParameterType, parametersAsSpan2[n]->ParameterType);
				}
			}
			return flag2;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000A7A8 File Offset: 0x000089A8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "ILLinker will never remove the Invoke method from delegates.")]
		private static MethodInfo GetDelegateInvokeMethod(RuntimeType type)
		{
			return type.GetMethod("Invoke");
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000A7B8 File Offset: 0x000089B8
		private static bool IsReturnTypeMatch(Type delReturnType, Type returnType)
		{
			bool flag = returnType == delReturnType;
			if (!flag)
			{
				if (!returnType.IsValueType && delReturnType.IsAssignableFrom(returnType))
				{
					flag = true;
				}
				else
				{
					bool isEnum = delReturnType.IsEnum;
					bool isEnum2 = returnType.IsEnum;
					if (isEnum2 && isEnum)
					{
						flag = (Enum.GetUnderlyingType(delReturnType) == Enum.GetUnderlyingType(returnType));
					}
					else if (isEnum && Enum.GetUnderlyingType(delReturnType) == returnType)
					{
						flag = true;
					}
					else if (isEnum2 && Enum.GetUnderlyingType(returnType) == delReturnType)
					{
						flag = true;
					}
				}
			}
			return flag;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000A838 File Offset: 0x00008A38
		private static bool IsArgumentTypeMatch(Type delArgType, Type argType)
		{
			bool flag = delArgType == argType;
			if (!flag && !argType.IsValueType && argType.IsAssignableFrom(delArgType))
			{
				flag = true;
			}
			if (!flag)
			{
				if (delArgType.IsEnum && Enum.GetUnderlyingType(delArgType) == argType)
				{
					flag = true;
				}
				else if (argType.IsEnum && Enum.GetUnderlyingType(argType) == delArgType)
				{
					flag = true;
				}
			}
			return flag;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000A89C File Offset: 0x00008A9C
		private static bool IsArgumentTypeMatchWithThis(Type delArgType, Type argType, bool boxedThis)
		{
			bool result;
			if (argType.IsValueType)
			{
				result = ((delArgType.IsByRef && delArgType.GetElementType() == argType) || (boxedThis && delArgType == argType));
			}
			else
			{
				result = (delArgType == argType || argType.IsAssignableFrom(delArgType));
			}
			return result;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[NullableContext(2)]
		protected unsafe virtual object DynamicInvokeImpl(object[] args)
		{
			MethodInfo methodInfo = this.Method;
			object obj = this._target;
			if (this.data == null)
			{
				this.data = this.CreateDelegateData();
			}
			MethodInfo methodInfo2 = base.GetType().GetMethod("Invoke");
			if (methodInfo2 != null && args != null)
			{
				ReadOnlySpan<ParameterInfo> parametersAsSpan = methodInfo2.GetParametersAsSpan();
				for (int i = 0; i < args.Length; i++)
				{
					if (args[i] == Type.Missing)
					{
						ParameterInfo parameterInfo = *parametersAsSpan[i];
						if (parameterInfo.HasDefaultValue)
						{
							args[i] = parameterInfo.DefaultValue;
						}
					}
				}
			}
			if (methodInfo.IsStatic)
			{
				if (this.data.curried_first_arg)
				{
					if (args == null)
					{
						args = new object[]
						{
							obj
						};
					}
					else
					{
						Array.Resize<object>(ref args, args.Length + 1);
						Array.Copy(args, 0, args, 1, args.Length - 1);
						args[0] = obj;
					}
					obj = null;
				}
			}
			else if (this._target == null && args != null && args.Length != 0)
			{
				obj = args[0];
				Array.Copy(args, 1, args, 0, args.Length - 1);
				Array.Resize<object>(ref args, args.Length - 1);
			}
			return methodInfo.Invoke(obj, args);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000AA00 File Offset: 0x00008C00
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			Delegate @delegate = obj as Delegate;
			if (@delegate == null || !Delegate.InternalEqualTypes(this, obj))
			{
				return false;
			}
			if (@delegate._target != this._target || !(@delegate.Method == this.Method))
			{
				return false;
			}
			if (@delegate.data == null && this.data == null)
			{
				return true;
			}
			if (@delegate.data != null && this.data != null)
			{
				return @delegate.data.target_type == this.data.target_type && @delegate.data.method_name == this.data.method_name;
			}
			if (@delegate.data != null)
			{
				return @delegate.data.target_type == null;
			}
			return this.data != null && this.data.target_type == null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		public override int GetHashCode()
		{
			MethodInfo methodInfo = this.Method;
			return ((methodInfo != null) ? methodInfo.GetHashCode() : base.GetType().GetHashCode()) ^ RuntimeHelpers.GetHashCode(this._target);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000AB14 File Offset: 0x00008D14
		protected virtual MethodInfo GetMethodImpl()
		{
			if (this.method_info != null)
			{
				return this.method_info;
			}
			if (this.method != IntPtr.Zero)
			{
				if (!this.method_is_virtual)
				{
					this.method_info = (MethodInfo)RuntimeMethodInfo.GetMethodFromHandleNoGenericCheck(new RuntimeMethodHandle(this.method));
				}
				else
				{
					this.method_info = this.GetVirtualMethod_internal();
				}
			}
			return this.method_info;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000AB7C File Offset: 0x00008D7C
		private DelegateData CreateDelegateData()
		{
			DelegateData delegateData = new DelegateData();
			if (this.method_info.IsStatic)
			{
				if (this._target != null)
				{
					delegateData.curried_first_arg = true;
				}
				else
				{
					MethodInfo methodInfo = base.GetType().GetMethod("Invoke");
					if (methodInfo != null && methodInfo.GetParametersCount() + 1 == this.method_info.GetParametersCount())
					{
						delegateData.curried_first_arg = true;
					}
				}
			}
			return delegateData;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		internal static bool InternalEqualTypes(object source, object value)
		{
			return source.GetType() == value.GetType();
		}

		// Token: 0x06000333 RID: 819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private protected static extern MulticastDelegate AllocDelegateLike_internal(Delegate d);

		// Token: 0x06000334 RID: 820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Delegate CreateDelegate_internal(QCallTypeHandle type, object target, MethodInfo info, bool throwOnBindFailure);

		// Token: 0x06000335 RID: 821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MethodInfo GetVirtualMethod_internal();

		// Token: 0x06000336 RID: 822 RVA: 0x00007BA1 File Offset: 0x00005DA1
		public virtual object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000ABF7 File Offset: 0x00008DF7
		[NullableContext(2)]
		[return: NotNullIfNotNull("a")]
		[return: NotNullIfNotNull("b")]
		public static Delegate Combine(Delegate a, Delegate b)
		{
			if (a == null)
			{
				return b;
			}
			return a.CombineImpl(b);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000AC05 File Offset: 0x00008E05
		[NullableContext(2)]
		public static Delegate Combine(params Delegate[] delegates)
		{
			return Delegate.Combine(delegates);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000AC14 File Offset: 0x00008E14
		[NullableContext(2)]
		public unsafe static Delegate Combine([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<Delegate> delegates)
		{
			Delegate @delegate = null;
			if (!delegates.IsEmpty)
			{
				@delegate = *delegates[0];
				for (int i = 1; i < delegates.Length; i++)
				{
					@delegate = Delegate.Combine(@delegate, *delegates[i]);
				}
			}
			return @delegate;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000AC59 File Offset: 0x00008E59
		public static Delegate CreateDelegate(Type type, [Nullable(2)] object firstArgument, MethodInfo method)
		{
			return Delegate.CreateDelegate(type, firstArgument, method, true);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000AC64 File Offset: 0x00008E64
		public static Delegate CreateDelegate(Type type, MethodInfo method)
		{
			return Delegate.CreateDelegate(type, method, true);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000AC6E File Offset: 0x00008E6E
		[RequiresUnreferencedCode("The target method might be removed")]
		public static Delegate CreateDelegate(Type type, object target, string method)
		{
			return Delegate.CreateDelegate(type, target, method, false, true);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000AC7A File Offset: 0x00008E7A
		[RequiresUnreferencedCode("The target method might be removed")]
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase)
		{
			return Delegate.CreateDelegate(type, target, method, ignoreCase, true);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000AC86 File Offset: 0x00008E86
		public static Delegate CreateDelegate(Type type, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type target, string method)
		{
			return Delegate.CreateDelegate(type, target, method, false, true);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000AC92 File Offset: 0x00008E92
		public static Delegate CreateDelegate(Type type, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type target, string method, bool ignoreCase)
		{
			return Delegate.CreateDelegate(type, target, method, ignoreCase, true);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000AC9E File Offset: 0x00008E9E
		protected virtual Delegate CombineImpl([Nullable(2)] Delegate d)
		{
			throw new MulticastNotSupportedException(SR.Multicast_Combine);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000ACAA File Offset: 0x00008EAA
		[return: Nullable(2)]
		protected virtual Delegate RemoveImpl(Delegate d)
		{
			if (!d.Equals(this))
			{
				return this;
			}
			return null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		public virtual Delegate[] GetInvocationList()
		{
			return new Delegate[]
			{
				this
			};
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		public bool HasSingleTarget
		{
			get
			{
				return Unsafe.As<MulticastDelegate>(this).HasSingleTarget;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000ACD1 File Offset: 0x00008ED1
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Delegate.InvocationListEnumerator<TDelegate> EnumerateInvocationList<TDelegate>([Nullable(2)] TDelegate d) where TDelegate : Delegate
		{
			return new Delegate.InvocationListEnumerator<TDelegate>(Unsafe.As<MulticastDelegate>(d));
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000ACE3 File Offset: 0x00008EE3
		[NullableContext(2)]
		public object DynamicInvoke(params object[] args)
		{
			return this.DynamicInvokeImpl(args);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000ACF3 File Offset: 0x00008EF3
		public MethodInfo Method
		{
			get
			{
				return this.GetMethodImpl();
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000ACFB File Offset: 0x00008EFB
		[NullableContext(2)]
		public static Delegate Remove(Delegate source, Delegate value)
		{
			if (source == null)
			{
				return null;
			}
			if (value == null)
			{
				return source;
			}
			if (!Delegate.InternalEqualTypes(source, value))
			{
				throw new ArgumentException(SR.Arg_DlgtTypeMis);
			}
			return source.RemoveImpl(value);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000AD24 File Offset: 0x00008F24
		[NullableContext(2)]
		public static Delegate RemoveAll(Delegate source, Delegate value)
		{
			Delegate @delegate;
			do
			{
				@delegate = source;
				source = Delegate.Remove(source, value);
			}
			while (@delegate != source);
			return @delegate;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000AD46 File Offset: 0x00008F46
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Delegate d1, Delegate d2)
		{
			if (d2 == null)
			{
				return d1 == null;
			}
			return d2 == d1 || d2.Equals(d1);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000AD5D File Offset: 0x00008F5D
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Delegate d1, Delegate d2)
		{
			if (d2 == null)
			{
				return d1 != null;
			}
			return d2 != d1 && !d2.Equals(d1);
		}

		// Token: 0x040001F2 RID: 498
		private IntPtr method_ptr;

		// Token: 0x040001F3 RID: 499
		private IntPtr invoke_impl;

		// Token: 0x040001F4 RID: 500
		private object _target;

		// Token: 0x040001F5 RID: 501
		private IntPtr method;

		// Token: 0x040001F6 RID: 502
		private IntPtr delegate_trampoline;

		// Token: 0x040001F7 RID: 503
		private IntPtr extra_arg;

		// Token: 0x040001F8 RID: 504
		private IntPtr method_code;

		// Token: 0x040001F9 RID: 505
		private IntPtr interp_method;

		// Token: 0x040001FA RID: 506
		private IntPtr interp_invoke_impl;

		// Token: 0x040001FB RID: 507
		private MethodInfo method_info;

		// Token: 0x040001FC RID: 508
		private MethodInfo original_method_info;

		// Token: 0x040001FD RID: 509
		private DelegateData data;

		// Token: 0x040001FE RID: 510
		private bool method_is_virtual;

		// Token: 0x040001FF RID: 511
		private bool bound;

		// Token: 0x0200007A RID: 122
		[Nullable(0)]
		public struct InvocationListEnumerator<[Nullable(0)] TDelegate> where TDelegate : Delegate
		{
			// Token: 0x0600034C RID: 844 RVA: 0x0000AD77 File Offset: 0x00008F77
			internal InvocationListEnumerator(MulticastDelegate d)
			{
				this._current = default(TDelegate);
				this._delegate = d;
				this._index = -1;
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600034D RID: 845 RVA: 0x0000AD93 File Offset: 0x00008F93
			public TDelegate Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x0600034E RID: 846 RVA: 0x0000AD9C File Offset: 0x00008F9C
			public bool MoveNext()
			{
				int index = this._index + 1;
				MulticastDelegate @delegate = this._delegate;
				if ((this._current = Unsafe.As<TDelegate>((@delegate != null) ? @delegate.TryGetAt(index) : null)) == null)
				{
					return false;
				}
				this._index = index;
				return true;
			}

			// Token: 0x0600034F RID: 847 RVA: 0x0000ADEA File Offset: 0x00008FEA
			[EditorBrowsable(EditorBrowsableState.Never)]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			public Delegate.InvocationListEnumerator<TDelegate> GetEnumerator()
			{
				return this;
			}

			// Token: 0x04000200 RID: 512
			private readonly MulticastDelegate _delegate;

			// Token: 0x04000201 RID: 513
			private int _index;

			// Token: 0x04000202 RID: 514
			private TDelegate _current;
		}
	}
}
