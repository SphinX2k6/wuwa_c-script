using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Reflection
{
	// Token: 0x0200070F RID: 1807
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeConstructorInfo : ConstructorInfo
	{
		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x0600778A RID: 30602 RVA: 0x0011C818 File Offset: 0x0011AA18
		internal InvocationFlags InvocationFlags
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.Invoker._invocationFlags;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x0600778B RID: 30603 RVA: 0x0011C825 File Offset: 0x0011AA25
		internal MethodBaseInvoker Invoker
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (this.invoker == null)
				{
					this.invoker = new MethodBaseInvoker(this);
				}
				return this.invoker;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x0600778C RID: 30604 RVA: 0x0011C841 File Offset: 0x0011AA41
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x0011C849 File Offset: 0x0011AA49
		internal RuntimeModule GetRuntimeModule()
		{
			return RuntimeTypeHandle.GetModule((RuntimeType)this.DeclaringType);
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x0011C85B File Offset: 0x0011AA5B
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MonoMethodInfo.GetMethodImplementationFlags(this.mhandle);
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x0011C868 File Offset: 0x0011AA68
		public override ParameterInfo[] GetParameters()
		{
			return MonoMethodInfo.GetParametersInfo(this.mhandle, this);
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x0011C868 File Offset: 0x0011AA68
		internal override ParameterInfo[] GetParametersInternal()
		{
			return MonoMethodInfo.GetParametersInfo(this.mhandle, this);
		}

		// Token: 0x06007791 RID: 30609 RVA: 0x0011C878 File Offset: 0x0011AA78
		internal override int GetParametersCount()
		{
			ParameterInfo[] parametersInfo = MonoMethodInfo.GetParametersInfo(this.mhandle, this);
			if (parametersInfo != null)
			{
				return parametersInfo.Length;
			}
			return 0;
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06007792 RID: 30610 RVA: 0x0011C89C File Offset: 0x0011AA9C
		internal RuntimeType[] ArgumentTypes
		{
			get
			{
				if (this.parameterTypes != null)
				{
					return this.parameterTypes;
				}
				ParameterInfo[] parametersInternal = this.GetParametersInternal();
				RuntimeType[] array = new RuntimeType[parametersInternal.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (RuntimeType)parametersInternal[i].ParameterType;
				}
				Interlocked.CompareExchange<RuntimeType[]>(ref this.parameterTypes, array, null);
				return array;
			}
		}

		// Token: 0x06007793 RID: 30611
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InvokeClassConstructor(QCallTypeHandle type);

		// Token: 0x06007794 RID: 30612 RVA: 0x0011C8F8 File Offset: 0x0011AAF8
		private void InvokeClassConstructor()
		{
			RuntimeType runtimeType = (RuntimeType)this.DeclaringType;
			RuntimeConstructorInfo.InvokeClassConstructor(new QCallTypeHandle(ref runtimeType));
		}

		// Token: 0x06007795 RID: 30613
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe extern object InternalInvoke(object obj, IntPtr* args, out Exception exc);

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06007796 RID: 30614 RVA: 0x0011C91D File Offset: 0x0011AB1D
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return new RuntimeMethodHandle(this.mhandle);
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06007797 RID: 30615 RVA: 0x0011C92A File Offset: 0x0011AB2A
		public override MethodAttributes Attributes
		{
			get
			{
				return MonoMethodInfo.GetAttributes(this.mhandle);
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06007798 RID: 30616 RVA: 0x0011C937 File Offset: 0x0011AB37
		public override CallingConventions CallingConvention
		{
			get
			{
				return MonoMethodInfo.GetCallingConvention(this.mhandle);
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06007799 RID: 30617 RVA: 0x0011C944 File Offset: 0x0011AB44
		public override bool ContainsGenericParameters
		{
			get
			{
				return this.DeclaringType.ContainsGenericParameters;
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x0600779A RID: 30618 RVA: 0x0011C951 File Offset: 0x0011AB51
		public override Type ReflectedType
		{
			get
			{
				return this.reftype;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x0600779B RID: 30619 RVA: 0x0011C959 File Offset: 0x0011AB59
		public override Type DeclaringType
		{
			get
			{
				return MonoMethodInfo.GetDeclaringType(this.mhandle);
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x0600779C RID: 30620 RVA: 0x0011C966 File Offset: 0x0011AB66
		public override string Name
		{
			get
			{
				if (this.name != null)
				{
					return this.name;
				}
				return RuntimeMethodInfo.get_name(this);
			}
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x0011B1F4 File Offset: 0x001193F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, inherit);
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x0011B1FD File Offset: 0x001193FD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x0011C97D File Offset: 0x0011AB7D
		[RequiresUnreferencedCode("Trimming may change method bodies. For example it can change some instructions, remove branches or local variables.")]
		public override MethodBody GetMethodBody()
		{
			return RuntimeMethodInfo.GetMethodBody(this.mhandle);
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x0011C98C File Offset: 0x0011AB8C
		public override string ToString()
		{
			if (this.toString == null)
			{
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(100);
				valueStringBuilder.Append("Void ");
				valueStringBuilder.Append(this.Name);
				valueStringBuilder.Append('(');
				MethodBase.AppendParameters(ref valueStringBuilder, this.GetParameterTypes(), this.CallingConvention);
				valueStringBuilder.Append(')');
				this.toString = valueStringBuilder.ToString();
			}
			return this.toString;
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x0011CA01 File Offset: 0x0011AC01
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return RuntimeCustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x0011CA09 File Offset: 0x0011AC09
		public sealed override bool HasSameMetadataDefinitionAs(MemberInfo other)
		{
			return base.HasSameMetadataDefinitionAsCore<RuntimeConstructorInfo>(other);
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x060077A4 RID: 30628 RVA: 0x0011CA12 File Offset: 0x0011AC12
		public override int MetadataToken
		{
			get
			{
				return RuntimeConstructorInfo.get_metadata_token(this);
			}
		}

		// Token: 0x060077A5 RID: 30629
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimeConstructorInfo method);

		// Token: 0x060077A6 RID: 30630 RVA: 0x0011CA1C File Offset: 0x0011AC1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal InvocationFlags ComputeAndUpdateInvocationFlags()
		{
			InvocationFlags invocationFlags = InvocationFlags.IsConstructor;
			Type declaringType = this.DeclaringType;
			if (declaringType == typeof(void) || (declaringType != null && declaringType.ContainsGenericParameters) || (this.CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
			{
				invocationFlags |= InvocationFlags.NoInvoke;
			}
			else if (base.IsStatic)
			{
				invocationFlags |= (InvocationFlags.RunClassConstructor | InvocationFlags.NoConstructorInvoke);
			}
			else if (declaringType != null && declaringType.IsAbstract)
			{
				invocationFlags |= InvocationFlags.NoConstructorInvoke;
			}
			else
			{
				if (declaringType != null && declaringType.IsByRefLike)
				{
					invocationFlags |= InvocationFlags.ContainsStackPointers;
				}
				if (typeof(Delegate).IsAssignableFrom(this.DeclaringType))
				{
					invocationFlags |= InvocationFlags.IsDelegateConstructor;
				}
			}
			return invocationFlags | InvocationFlags.Initialized;
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x0011CACC File Offset: 0x0011ACCC
		internal static void CheckCanCreateInstance(Type declaringType, bool isVarArg)
		{
			ArgumentNullException.ThrowIfNull(declaringType, "declaringType");
			if (declaringType.IsInterface)
			{
				throw new MemberAccessException(SR.Format(SR.Acc_CreateInterfaceEx, declaringType));
			}
			if (declaringType.IsAbstract)
			{
				throw new MemberAccessException(SR.Format(SR.Acc_CreateAbstEx, declaringType));
			}
			if (declaringType.GetRootElementType() == typeof(ArgIterator))
			{
				throw new NotSupportedException();
			}
			if (isVarArg)
			{
				throw new NotSupportedException();
			}
			if (declaringType.ContainsGenericParameters)
			{
				throw new MemberAccessException(SR.Format(SR.Acc_CreateGenericEx, declaringType));
			}
			if (declaringType == typeof(void))
			{
				throw new MemberAccessException(SR.Access_Void);
			}
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x0011CB72 File Offset: 0x0011AD72
		[DoesNotReturn]
		internal void ThrowNoInvokeException()
		{
			RuntimeConstructorInfo.CheckCanCreateInstance(this.DeclaringType, (this.CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs);
			if ((this.Attributes & MethodAttributes.Static) == MethodAttributes.Static)
			{
				throw new MemberAccessException(SR.Acc_NotClassInit);
			}
			throw new TargetException();
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x0011CBA8 File Offset: 0x0011ADA8
		[DebuggerStepThrough]
		[DebuggerHidden]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			if ((this.InvocationFlags & InvocationFlags.NoInvoke) != InvocationFlags.Unknown)
			{
				this.ThrowNoInvokeException();
			}
			if (!base.IsStatic)
			{
				MethodInvokerCommon.ValidateInvokeTarget(obj, this);
			}
			int num = (parameters == null) ? 0 : parameters.Length;
			if (this.ArgumentTypes.Length != num)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			if ((this.InvocationFlags & InvocationFlags.RunClassConstructor) != InvocationFlags.Unknown)
			{
				this.InvokeClassConstructor();
				return null;
			}
			if (num != 0)
			{
				return this.Invoker.InvokeConstructorWithoutAlloc(obj, invokeAttr, binder, parameters, culture);
			}
			return this.Invoker.InvokeConstructorWithoutAlloc(obj, (invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default);
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x0011CC30 File Offset: 0x0011AE30
		[DebuggerStepThrough]
		[DebuggerHidden]
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			if ((this.InvocationFlags & (InvocationFlags.NoInvoke | InvocationFlags.NoConstructorInvoke | InvocationFlags.ContainsStackPointers)) != InvocationFlags.Unknown)
			{
				this.ThrowNoInvokeException();
			}
			int num = (parameters == null) ? 0 : parameters.Length;
			if (this.ArgumentTypes.Length != num)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			object result;
			switch (num)
			{
			case 0:
				result = this.Invoker.InvokeWithNoArgs(null, invokeAttr);
				break;
			case 1:
				result = this.Invoker.InvokeWithOneArg(null, invokeAttr, binder, parameters, culture);
				break;
			case 2:
			case 3:
			case 4:
				result = this.Invoker.InvokeWithFewArgs(null, invokeAttr, binder, parameters, culture);
				break;
			default:
				result = this.Invoker.InvokeWithManyArgs(null, invokeAttr, binder, parameters, culture);
				break;
			}
			return result;
		}

		// Token: 0x040015AF RID: 5551
		internal IntPtr mhandle;

		// Token: 0x040015B0 RID: 5552
		private string name;

		// Token: 0x040015B1 RID: 5553
		private Type reftype;

		// Token: 0x040015B2 RID: 5554
		private string toString;

		// Token: 0x040015B3 RID: 5555
		private RuntimeType[] parameterTypes;

		// Token: 0x040015B4 RID: 5556
		private MethodBaseInvoker invoker;
	}
}
