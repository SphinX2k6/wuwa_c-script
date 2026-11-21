using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Reflection
{
	// Token: 0x0200070E RID: 1806
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeMethodInfo : MethodInfo
	{
		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x0600774F RID: 30543 RVA: 0x0011BD6D File Offset: 0x00119F6D
		internal InvocationFlags InvocationFlags
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.Invoker._invocationFlags;
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06007750 RID: 30544 RVA: 0x0011BD7A File Offset: 0x00119F7A
		private MethodBaseInvoker Invoker
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

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06007751 RID: 30545 RVA: 0x0011BD96 File Offset: 0x00119F96
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x0011BD9E File Offset: 0x00119F9E
		public override Delegate CreateDelegate(Type delegateType)
		{
			return Delegate.CreateDelegate(delegateType, this);
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x0011BDA7 File Offset: 0x00119FA7
		public override Delegate CreateDelegate(Type delegateType, object target)
		{
			return Delegate.CreateDelegate(delegateType, target, this);
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x0011BDB4 File Offset: 0x00119FB4
		public override string ToString()
		{
			if (this.toString == null)
			{
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(100);
				valueStringBuilder.Append(this.ReturnType.FormatTypeName());
				valueStringBuilder.Append(' ');
				valueStringBuilder.Append(this.Name);
				if (this.IsGenericMethod)
				{
					valueStringBuilder.Append(RuntimeMethodHandle.ConstructInstantiation(this));
				}
				valueStringBuilder.Append('(');
				MethodBase.AppendParameters(ref valueStringBuilder, this.GetParameterTypes(), this.CallingConvention);
				valueStringBuilder.Append(')');
				this.toString = valueStringBuilder.ToString();
			}
			return this.toString;
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x0011BE4D File Offset: 0x0011A04D
		internal RuntimeModule GetRuntimeModule()
		{
			return ((RuntimeType)this.DeclaringType).GetRuntimeModule();
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x0011BE5F File Offset: 0x0011A05F
		internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle)
		{
			return RuntimeMethodInfo.GetMethodFromHandleInternalType_native(handle.Value, IntPtr.Zero, false);
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x0011BE73 File Offset: 0x0011A073
		internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType)
		{
			return RuntimeMethodInfo.GetMethodFromHandleInternalType_native(handle.Value, reflectedType.Value, false);
		}

		// Token: 0x06007758 RID: 30552
		[DynamicDependency("#ctor(System.Reflection.ExceptionHandlingClause[],System.Reflection.LocalVariableInfo[],System.Byte[],System.Boolean,System.Int32,System.Int32)", typeof(RuntimeMethodBody))]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern MethodBody GetMethodBodyInternal(IntPtr handle);

		// Token: 0x06007759 RID: 30553 RVA: 0x0011BE89 File Offset: 0x0011A089
		[RequiresUnreferencedCode("Trimming may change method bodies. For example it can change some instructions, remove branches or local variables.")]
		internal static MethodBody GetMethodBody(IntPtr handle)
		{
			return RuntimeMethodInfo.GetMethodBodyInternal(handle);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x0011BE91 File Offset: 0x0011A091
		internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle)
		{
			return RuntimeMethodInfo.GetMethodFromHandleInternalType_native(method_handle, type_handle, true);
		}

		// Token: 0x0600775B RID: 30555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck);

		// Token: 0x0600775C RID: 30556 RVA: 0x0011BE9B File Offset: 0x0011A09B
		internal RuntimeMethodInfo()
		{
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x0011BEA3 File Offset: 0x0011A0A3
		internal RuntimeMethodInfo(RuntimeMethodHandle mhandle)
		{
			this.mhandle = mhandle.Value;
		}

		// Token: 0x0600775E RID: 30558
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string get_name(MethodBase method);

		// Token: 0x0600775F RID: 30559
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition);

		// Token: 0x06007760 RID: 30560
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimeMethodInfo method);

		// Token: 0x06007761 RID: 30561 RVA: 0x0011BEB8 File Offset: 0x0011A0B8
		public override MethodInfo GetBaseDefinition()
		{
			return RuntimeMethodInfo.get_base_method(this, true);
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x0011BEC1 File Offset: 0x0011A0C1
		internal MethodInfo GetBaseMethod()
		{
			return RuntimeMethodInfo.get_base_method(this, false);
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06007763 RID: 30563 RVA: 0x0011BECA File Offset: 0x0011A0CA
		public override ParameterInfo ReturnParameter
		{
			get
			{
				return MonoMethodInfo.GetReturnParameterInfo(this);
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06007764 RID: 30564 RVA: 0x0011BED2 File Offset: 0x0011A0D2
		public override Type ReturnType
		{
			get
			{
				return MonoMethodInfo.GetReturnType(this.mhandle);
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06007765 RID: 30565 RVA: 0x0011BECA File Offset: 0x0011A0CA
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			get
			{
				return MonoMethodInfo.GetReturnParameterInfo(this);
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06007766 RID: 30566 RVA: 0x0011BEDF File Offset: 0x0011A0DF
		public override int MetadataToken
		{
			get
			{
				return RuntimeMethodInfo.get_metadata_token(this);
			}
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x0011BEE7 File Offset: 0x0011A0E7
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MonoMethodInfo.GetMethodImplementationFlags(this.mhandle);
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x0011BEF4 File Offset: 0x0011A0F4
		public override ParameterInfo[] GetParameters()
		{
			ParameterInfo[] parametersInfo = MonoMethodInfo.GetParametersInfo(this.mhandle, this);
			if (parametersInfo.Length == 0)
			{
				return parametersInfo;
			}
			ParameterInfo[] result = new ParameterInfo[parametersInfo.Length];
			Array.FastCopy(ObjectHandleOnStack.Create<ParameterInfo[]>(ref parametersInfo), 0, ObjectHandleOnStack.Create<ParameterInfo[]>(ref result), 0, parametersInfo.Length);
			return result;
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x0011BF37 File Offset: 0x0011A137
		internal override ParameterInfo[] GetParametersInternal()
		{
			return MonoMethodInfo.GetParametersInfo(this.mhandle, this);
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x0011BF45 File Offset: 0x0011A145
		internal override int GetParametersCount()
		{
			return MonoMethodInfo.GetParametersInfo(this.mhandle, this).Length;
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x0600776B RID: 30571 RVA: 0x0011BF58 File Offset: 0x0011A158
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

		// Token: 0x0600776C RID: 30572
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe extern object InternalInvoke(object obj, IntPtr* args, out Exception exc);

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x0600776D RID: 30573 RVA: 0x0011BFB1 File Offset: 0x0011A1B1
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return new RuntimeMethodHandle(this.mhandle);
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x0600776E RID: 30574 RVA: 0x0011BFBE File Offset: 0x0011A1BE
		public override MethodAttributes Attributes
		{
			get
			{
				return MonoMethodInfo.GetAttributes(this.mhandle);
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x0600776F RID: 30575 RVA: 0x0011BFCB File Offset: 0x0011A1CB
		public override CallingConventions CallingConvention
		{
			get
			{
				return MonoMethodInfo.GetCallingConvention(this.mhandle);
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06007770 RID: 30576 RVA: 0x0011BFD8 File Offset: 0x0011A1D8
		public override Type ReflectedType
		{
			get
			{
				return this.reftype;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06007771 RID: 30577 RVA: 0x0011BFE0 File Offset: 0x0011A1E0
		public override Type DeclaringType
		{
			get
			{
				return MonoMethodInfo.GetDeclaringType(this.mhandle);
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06007772 RID: 30578 RVA: 0x0011BFED File Offset: 0x0011A1ED
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

		// Token: 0x06007773 RID: 30579 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x0011B1F4 File Offset: 0x001193F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, inherit);
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x0011B1FD File Offset: 0x001193FD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x06007776 RID: 30582
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName);

		// Token: 0x06007777 RID: 30583 RVA: 0x0011C004 File Offset: 0x0011A204
		internal object[] GetPseudoCustomAttributes()
		{
			int num = 0;
			MonoMethodInfo methodInfo = MonoMethodInfo.GetMethodInfo(this.mhandle);
			if ((methodInfo.iattrs & MethodImplAttributes.PreserveSig) != MethodImplAttributes.IL)
			{
				num++;
			}
			if ((methodInfo.attrs & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			object[] array = new object[num];
			num = 0;
			if ((methodInfo.iattrs & MethodImplAttributes.PreserveSig) != MethodImplAttributes.IL)
			{
				array[num++] = new PreserveSigAttribute();
			}
			if ((methodInfo.attrs & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope)
			{
				array[num++] = this.GetDllImportAttribute();
			}
			return array;
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x0011C088 File Offset: 0x0011A288
		private DllImportAttribute GetDllImportAttribute()
		{
			PInvokeAttributes pinvokeAttributes;
			string entryPoint;
			string dllName;
			this.GetPInvoke(out pinvokeAttributes, out entryPoint, out dllName);
			CharSet charSet = CharSet.None;
			switch (pinvokeAttributes & PInvokeAttributes.CharSetMask)
			{
			case PInvokeAttributes.CharSetNotSpec:
				charSet = CharSet.None;
				break;
			case PInvokeAttributes.CharSetAnsi:
				charSet = CharSet.Ansi;
				break;
			case PInvokeAttributes.CharSetUnicode:
				charSet = CharSet.Unicode;
				break;
			case PInvokeAttributes.CharSetMask:
				charSet = CharSet.Auto;
				break;
			}
			CallingConvention callingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl;
			PInvokeAttributes pinvokeAttributes2 = pinvokeAttributes & PInvokeAttributes.CallConvMask;
			if (pinvokeAttributes2 <= PInvokeAttributes.CallConvCdecl)
			{
				if (pinvokeAttributes2 != PInvokeAttributes.CallConvWinapi)
				{
					if (pinvokeAttributes2 == PInvokeAttributes.CallConvCdecl)
					{
						callingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl;
					}
				}
				else
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.Winapi;
				}
			}
			else if (pinvokeAttributes2 != PInvokeAttributes.CallConvStdcall)
			{
				if (pinvokeAttributes2 != PInvokeAttributes.CallConvThiscall)
				{
					if (pinvokeAttributes2 == PInvokeAttributes.CallConvFastcall)
					{
						callingConvention = System.Runtime.InteropServices.CallingConvention.FastCall;
					}
				}
				else
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall;
				}
			}
			else
			{
				callingConvention = System.Runtime.InteropServices.CallingConvention.StdCall;
			}
			bool exactSpelling = (pinvokeAttributes & PInvokeAttributes.NoMangle) > PInvokeAttributes.CharSetNotSpec;
			bool setLastError = (pinvokeAttributes & PInvokeAttributes.SupportsLastError) > PInvokeAttributes.CharSetNotSpec;
			bool bestFitMapping = (pinvokeAttributes & PInvokeAttributes.BestFitMask) == PInvokeAttributes.BestFitEnabled;
			bool throwOnUnmappableChar = (pinvokeAttributes & PInvokeAttributes.ThrowOnUnmappableCharMask) == PInvokeAttributes.ThrowOnUnmappableCharEnabled;
			bool preserveSig = (this.GetMethodImplementationFlags() & MethodImplAttributes.PreserveSig) > MethodImplAttributes.IL;
			return new DllImportAttribute(dllName)
			{
				EntryPoint = entryPoint,
				CharSet = charSet,
				SetLastError = setLastError,
				ExactSpelling = exactSpelling,
				PreserveSig = preserveSig,
				BestFitMapping = bestFitMapping,
				ThrowOnUnmappableChar = throwOnUnmappableChar,
				CallingConvention = callingConvention
			};
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x0011C1B8 File Offset: 0x0011A3B8
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			int num = 0;
			MonoMethodInfo methodInfo = MonoMethodInfo.GetMethodInfo(this.mhandle);
			if ((methodInfo.iattrs & MethodImplAttributes.PreserveSig) != MethodImplAttributes.IL)
			{
				num++;
			}
			if ((methodInfo.attrs & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			CustomAttributeData[] array = new CustomAttributeData[num];
			num = 0;
			if ((methodInfo.iattrs & MethodImplAttributes.PreserveSig) != MethodImplAttributes.IL)
			{
				array[num++] = new RuntimeCustomAttributeData(typeof(PreserveSigAttribute).GetConstructor(Type.EmptyTypes));
			}
			if ((methodInfo.attrs & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope)
			{
				array[num++] = this.GetDllImportAttributeData();
			}
			return array;
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x0011C250 File Offset: 0x0011A450
		private RuntimeCustomAttributeData GetDllImportAttributeData()
		{
			if ((this.Attributes & MethodAttributes.PinvokeImpl) == MethodAttributes.PrivateScope)
			{
				return null;
			}
			PInvokeAttributes pinvokeAttributes;
			string value;
			string value2;
			this.GetPInvoke(out pinvokeAttributes, out value, out value2);
			CharSet charSet;
			switch (pinvokeAttributes & PInvokeAttributes.CharSetMask)
			{
			case PInvokeAttributes.CharSetNotSpec:
				charSet = CharSet.None;
				goto IL_5D;
			case PInvokeAttributes.CharSetAnsi:
				charSet = CharSet.Ansi;
				goto IL_5D;
			case PInvokeAttributes.CharSetUnicode:
				charSet = CharSet.Unicode;
				goto IL_5D;
			case PInvokeAttributes.CharSetMask:
				charSet = CharSet.Auto;
				goto IL_5D;
			}
			charSet = CharSet.None;
			IL_5D:
			CharSet charSet2 = charSet;
			PInvokeAttributes pinvokeAttributes2 = pinvokeAttributes & PInvokeAttributes.CallConvMask;
			CallingConvention callingConvention;
			if (pinvokeAttributes2 <= PInvokeAttributes.CallConvCdecl)
			{
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvWinapi)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.Winapi;
					goto IL_BF;
				}
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvCdecl)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl;
					goto IL_BF;
				}
			}
			else
			{
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvStdcall)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.StdCall;
					goto IL_BF;
				}
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvThiscall)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall;
					goto IL_BF;
				}
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvFastcall)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.FastCall;
					goto IL_BF;
				}
			}
			callingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl;
			IL_BF:
			CallingConvention callingConvention2 = callingConvention;
			bool flag = (pinvokeAttributes & PInvokeAttributes.NoMangle) > PInvokeAttributes.CharSetNotSpec;
			bool flag2 = (pinvokeAttributes & PInvokeAttributes.SupportsLastError) > PInvokeAttributes.CharSetNotSpec;
			bool flag3 = (pinvokeAttributes & PInvokeAttributes.BestFitMask) == PInvokeAttributes.BestFitEnabled;
			bool flag4 = (pinvokeAttributes & PInvokeAttributes.ThrowOnUnmappableCharMask) == PInvokeAttributes.ThrowOnUnmappableCharEnabled;
			bool flag5 = (this.GetMethodImplementationFlags() & MethodImplAttributes.PreserveSig) > MethodImplAttributes.IL;
			CustomAttributeTypedArgument[] ctorArgs = new CustomAttributeTypedArgument[]
			{
				new CustomAttributeTypedArgument(typeof(string), value2)
			};
			Type typeFromHandle = typeof(DllImportAttribute);
			CustomAttributeNamedArgument[] namedArgs = new CustomAttributeNamedArgument[]
			{
				new CustomAttributeNamedArgument(typeFromHandle.GetField("EntryPoint"), value),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("CharSet"), charSet2),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("ExactSpelling"), flag),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("SetLastError"), flag2),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("PreserveSig"), flag5),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("CallingConvention"), callingConvention2),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("BestFitMapping"), flag3),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("ThrowOnUnmappableChar"), flag4)
			};
			return new RuntimeCustomAttributeData(typeFromHandle.GetConstructor(new Type[]
			{
				typeof(string)
			}), ctorArgs, namedArgs);
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x0011C4A4 File Offset: 0x0011A6A4
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public override MethodInfo MakeGenericMethod(params Type[] methodInstantiation)
		{
			ArgumentNullException.ThrowIfNull(methodInstantiation, "methodInstantiation");
			if (!this.IsGenericMethodDefinition)
			{
				throw new InvalidOperationException(SR.Format(SR.Arg_NotGenericMethodDefinition, this));
			}
			if (this.GetGenericArguments().Length != methodInstantiation.Length)
			{
				throw new ArgumentException(SR.Format(SR.Argument_NotEnoughGenArguments, this.GetGenericArguments().Length, methodInstantiation.Length));
			}
			bool flag = false;
			foreach (Type type in methodInstantiation)
			{
				if (type == null)
				{
					throw new ArgumentNullException();
				}
				if (!(type is RuntimeType))
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (RuntimeFeature.IsDynamicCodeSupported)
				{
					return new MethodOnTypeBuilderInstantiation(this, methodInstantiation);
				}
				throw new NotSupportedException(SR.PlatformNotSupported_ReflectionEmit);
			}
			else
			{
				MethodInfo methodInfo = this.MakeGenericMethod_impl(methodInstantiation);
				if (methodInfo == null)
				{
					throw new ArgumentException(SR.Format(SR.Argument_NotEnoughGenArguments, this.GetGenericArguments().Length, methodInstantiation.Length));
				}
				return methodInfo;
			}
		}

		// Token: 0x0600777C RID: 30588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MethodInfo MakeGenericMethod_impl(Type[] types);

		// Token: 0x0600777D RID: 30589
		[MethodImpl(MethodImplOptions.InternalCall)]
		public override extern Type[] GetGenericArguments();

		// Token: 0x0600777E RID: 30590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MethodInfo GetGenericMethodDefinition_impl();

		// Token: 0x0600777F RID: 30591 RVA: 0x0011C586 File Offset: 0x0011A786
		public override MethodInfo GetGenericMethodDefinition()
		{
			MethodInfo genericMethodDefinition_impl = this.GetGenericMethodDefinition_impl();
			if (genericMethodDefinition_impl == null)
			{
				throw new InvalidOperationException();
			}
			return genericMethodDefinition_impl;
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06007780 RID: 30592
		public override extern bool IsGenericMethodDefinition { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06007781 RID: 30593
		public override extern bool IsGenericMethod { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06007782 RID: 30594 RVA: 0x0011C5A0 File Offset: 0x0011A7A0
		public override bool ContainsGenericParameters
		{
			get
			{
				if (this.IsGenericMethod)
				{
					Type[] genericArguments = this.GetGenericArguments();
					for (int i = 0; i < genericArguments.Length; i++)
					{
						if (genericArguments[i].ContainsGenericParameters)
						{
							return true;
						}
					}
				}
				return this.DeclaringType.ContainsGenericParameters;
			}
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x0011C5E1 File Offset: 0x0011A7E1
		[RequiresUnreferencedCode("Trimming may change method bodies. For example it can change some instructions, remove branches or local variables.")]
		public override MethodBody GetMethodBody()
		{
			return RuntimeMethodInfo.GetMethodBody(this.mhandle);
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x0011C5EE File Offset: 0x0011A7EE
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return RuntimeCustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x0011C5F6 File Offset: 0x0011A7F6
		public sealed override bool HasSameMetadataDefinitionAs(MemberInfo other)
		{
			return base.HasSameMetadataDefinitionAsCore<RuntimeMethodInfo>(other);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x0011C600 File Offset: 0x0011A800
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal InvocationFlags ComputeAndUpdateInvocationFlags()
		{
			InvocationFlags invocationFlags = InvocationFlags.Unknown;
			Type declaringType = this.DeclaringType;
			if (this.ContainsGenericParameters || RuntimeMethodInfo.<ComputeAndUpdateInvocationFlags>g__IsDisallowedByRefType|79_0(this.ReturnType) || (this.CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
			{
				invocationFlags = InvocationFlags.NoInvoke;
			}
			else
			{
				if (declaringType != null)
				{
					if (declaringType.ContainsGenericParameters)
					{
						invocationFlags = InvocationFlags.NoInvoke;
					}
					else if (declaringType.IsByRefLike)
					{
						invocationFlags |= InvocationFlags.ContainsStackPointers;
					}
				}
				if (this.ReturnType.IsByRefLike)
				{
					invocationFlags |= InvocationFlags.ContainsStackPointers;
				}
			}
			return invocationFlags | InvocationFlags.Initialized;
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x0011C67C File Offset: 0x0011A87C
		[DoesNotReturn]
		internal void ThrowNoInvokeException()
		{
			if ((this.InvocationFlags & InvocationFlags.ContainsStackPointers) != InvocationFlags.Unknown)
			{
				throw new NotSupportedException();
			}
			if ((this.CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
			{
				throw new NotSupportedException();
			}
			if (this.DeclaringType.ContainsGenericParameters || this.ContainsGenericParameters)
			{
				throw new InvalidOperationException(SR.Arg_UnboundGenParam);
			}
			if (base.IsAbstract)
			{
				throw new MemberAccessException();
			}
			if (this.ReturnType.IsByRef)
			{
				Type elementType = this.ReturnType.GetElementType();
				if (elementType.IsByRefLike)
				{
					throw new NotSupportedException(SR.NotSupported_ByRefToByRefLikeReturn);
				}
				if (elementType == typeof(void))
				{
					throw new NotSupportedException(SR.NotSupported_ByRefToVoidReturn);
				}
			}
			throw new TargetException();
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x0011C728 File Offset: 0x0011A928
		[DebuggerStepThrough]
		[DebuggerHidden]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			if ((this.InvocationFlags & (InvocationFlags.NoInvoke | InvocationFlags.ContainsStackPointers)) != InvocationFlags.Unknown)
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
			object result;
			switch (num)
			{
			case 0:
				result = this.Invoker.InvokeWithNoArgs(obj, invokeAttr);
				break;
			case 1:
				result = this.Invoker.InvokeWithOneArg(obj, invokeAttr, binder, parameters, culture);
				break;
			case 2:
			case 3:
			case 4:
				result = this.Invoker.InvokeWithFewArgs(obj, invokeAttr, binder, parameters, culture);
				break;
			default:
				result = this.Invoker.InvokeWithManyArgs(obj, invokeAttr, binder, parameters, culture);
				break;
			}
			return result;
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x0011C7E0 File Offset: 0x0011A9E0
		[CompilerGenerated]
		internal static bool <ComputeAndUpdateInvocationFlags>g__IsDisallowedByRefType|79_0(Type type)
		{
			if (!type.IsByRef)
			{
				return false;
			}
			Type elementType = type.GetElementType();
			return elementType.IsByRefLike || elementType == typeof(void);
		}

		// Token: 0x040015A9 RID: 5545
		internal IntPtr mhandle;

		// Token: 0x040015AA RID: 5546
		private string name;

		// Token: 0x040015AB RID: 5547
		private Type reftype;

		// Token: 0x040015AC RID: 5548
		private string toString;

		// Token: 0x040015AD RID: 5549
		private RuntimeType[] parameterTypes;

		// Token: 0x040015AE RID: 5550
		private MethodBaseInvoker invoker;
	}
}
