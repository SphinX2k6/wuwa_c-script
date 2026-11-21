using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200074B RID: 1867
	internal static class InvokerEmitUtil
	{
		// Token: 0x06007913 RID: 30995 RVA: 0x0011F594 File Offset: 0x0011D794
		public unsafe static InvokerEmitUtil.InvokeFunc_Obj4Args CreateInvokeDelegate_Obj4Args(MethodBase method, bool backwardsCompat)
		{
			bool flag = method is RuntimeConstructorInfo;
			bool flag2 = !flag && !method.IsStatic;
			Type[] parameterTypes = new Type[]
			{
				typeof(object),
				typeof(object),
				typeof(object),
				typeof(object),
				typeof(object)
			};
			string str = (method.DeclaringType != null) ? (method.DeclaringType.Name + ".") : string.Empty;
			DynamicMethod dynamicMethod = new DynamicMethod("InvokeStub_" + str + method.Name, typeof(object), parameterTypes, typeof(object).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			if (flag2)
			{
				ilgenerator.Emit(OpCodes.Ldarg_0);
				if (method.DeclaringType.IsValueType)
				{
					ilgenerator.Emit(OpCodes.Unbox, method.DeclaringType);
				}
			}
			ReadOnlySpan<ParameterInfo> parametersAsSpan = method.GetParametersAsSpan();
			for (int i = 0; i < parametersAsSpan.Length; i++)
			{
				RuntimeType runtimeType = (RuntimeType)parametersAsSpan[i]->ParameterType;
				switch (i)
				{
				case 0:
					ilgenerator.Emit(OpCodes.Ldarg_1);
					break;
				case 1:
					ilgenerator.Emit(OpCodes.Ldarg_2);
					break;
				case 2:
					ilgenerator.Emit(OpCodes.Ldarg_3);
					break;
				default:
					ilgenerator.Emit(OpCodes.Ldarg_S, i + 1);
					break;
				}
				if (runtimeType.IsPointer || runtimeType.IsFunctionPointer)
				{
					InvokerEmitUtil.Unbox(ilgenerator, typeof(IntPtr));
				}
				else if (runtimeType.IsValueType)
				{
					InvokerEmitUtil.Unbox(ilgenerator, runtimeType);
				}
			}
			InvokerEmitUtil.EmitCallAndReturnHandling(ilgenerator, method, flag, backwardsCompat);
			return (InvokerEmitUtil.InvokeFunc_Obj4Args)dynamicMethod.CreateDelegate(typeof(InvokerEmitUtil.InvokeFunc_Obj4Args), null);
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x0011F77C File Offset: 0x0011D97C
		public unsafe static InvokerEmitUtil.InvokeFunc_ObjSpanArgs CreateInvokeDelegate_ObjSpanArgs(MethodBase method, bool backwardsCompat)
		{
			bool flag = method is RuntimeConstructorInfo;
			bool flag2 = !flag && !method.IsStatic;
			Type[] parameterTypes = new Type[]
			{
				typeof(object),
				typeof(Span<object>)
			};
			string str = (method.DeclaringType != null) ? (method.DeclaringType.Name + ".") : string.Empty;
			DynamicMethod dynamicMethod = new DynamicMethod("InvokeStub_" + str + method.Name, typeof(object), parameterTypes, typeof(object).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			if (flag2)
			{
				ilgenerator.Emit(OpCodes.Ldarg_0);
				if (method.DeclaringType.IsValueType)
				{
					ilgenerator.Emit(OpCodes.Unbox, method.DeclaringType);
				}
			}
			ReadOnlySpan<ParameterInfo> parametersAsSpan = method.GetParametersAsSpan();
			for (int i = 0; i < parametersAsSpan.Length; i++)
			{
				RuntimeType runtimeType = (RuntimeType)parametersAsSpan[i]->ParameterType;
				ilgenerator.Emit(OpCodes.Ldarga_S, 1);
				ilgenerator.Emit(OpCodes.Ldc_I4, i);
				ilgenerator.Emit(OpCodes.Call, InvokerEmitUtil.Methods.Span_get_Item());
				ilgenerator.Emit(OpCodes.Ldind_Ref);
				if (runtimeType.IsPointer || runtimeType.IsFunctionPointer)
				{
					InvokerEmitUtil.Unbox(ilgenerator, typeof(IntPtr));
				}
				else if (runtimeType.IsValueType)
				{
					InvokerEmitUtil.Unbox(ilgenerator, runtimeType);
				}
			}
			InvokerEmitUtil.EmitCallAndReturnHandling(ilgenerator, method, flag, backwardsCompat);
			return (InvokerEmitUtil.InvokeFunc_ObjSpanArgs)dynamicMethod.CreateDelegate(typeof(InvokerEmitUtil.InvokeFunc_ObjSpanArgs), null);
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x0011F924 File Offset: 0x0011DB24
		public unsafe static InvokerEmitUtil.InvokeFunc_RefArgs CreateInvokeDelegate_RefArgs(MethodBase method, bool backwardsCompat)
		{
			bool flag = method is RuntimeConstructorInfo;
			bool flag2 = !flag && !method.IsStatic;
			Type[] parameterTypes = new Type[]
			{
				typeof(object),
				typeof(object),
				typeof(IntPtr*)
			};
			string str = (method.DeclaringType != null) ? (method.DeclaringType.Name + ".") : string.Empty;
			DynamicMethod dynamicMethod = new DynamicMethod("InvokeStub_" + str + method.Name, typeof(object), parameterTypes, typeof(object).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			if (flag2)
			{
				ilgenerator.Emit(OpCodes.Ldarg_1);
				if (method.DeclaringType.IsValueType)
				{
					ilgenerator.Emit(OpCodes.Unbox, method.DeclaringType);
				}
			}
			ReadOnlySpan<ParameterInfo> parametersAsSpan = method.GetParametersAsSpan();
			for (int i = 0; i < parametersAsSpan.Length; i++)
			{
				ilgenerator.Emit(OpCodes.Ldarg_2);
				if (i != 0)
				{
					ilgenerator.Emit(OpCodes.Ldc_I4, i * 8);
					ilgenerator.Emit(OpCodes.Add);
				}
				ilgenerator.Emit(OpCodes.Ldfld, InvokerEmitUtil.Methods.ByReferenceOfByte_Value());
				RuntimeType runtimeType = (RuntimeType)parametersAsSpan[i]->ParameterType;
				if (!runtimeType.IsByRef)
				{
					ilgenerator.Emit(OpCodes.Ldobj, (runtimeType.IsPointer || runtimeType.IsFunctionPointer) ? typeof(IntPtr) : runtimeType);
				}
			}
			InvokerEmitUtil.EmitCallAndReturnHandling(ilgenerator, method, flag, backwardsCompat);
			return (InvokerEmitUtil.InvokeFunc_RefArgs)dynamicMethod.CreateDelegate(typeof(InvokerEmitUtil.InvokeFunc_RefArgs), null);
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x0011FADF File Offset: 0x0011DCDF
		private static void Unbox(ILGenerator il, Type parameterType)
		{
			il.Emit(OpCodes.Call, InvokerEmitUtil.Methods.Object_GetRawData());
			il.Emit(OpCodes.Ldobj, parameterType);
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x0011FB00 File Offset: 0x0011DD00
		private static void EmitCallAndReturnHandling(ILGenerator il, MethodBase method, bool emitNew, bool backwardsCompat)
		{
			if (backwardsCompat && RuntimeFeature.IsDynamicCodeCompiled)
			{
				il.Emit(OpCodes.Call, InvokerEmitUtil.Methods.DisableInline());
			}
			if (emitNew)
			{
				il.Emit(OpCodes.Newobj, (ConstructorInfo)method);
			}
			else if (method.IsStatic || method.DeclaringType.IsValueType)
			{
				il.Emit(OpCodes.Call, (MethodInfo)method);
			}
			else
			{
				il.Emit(OpCodes.Callvirt, (MethodInfo)method);
			}
			if (emitNew)
			{
				Type declaringType = method.DeclaringType;
				if (declaringType.IsValueType)
				{
					il.Emit(OpCodes.Box, declaringType);
				}
			}
			else
			{
				RuntimeMethodInfo runtimeMethodInfo = method as RuntimeMethodInfo;
				RuntimeType runtimeType;
				if (runtimeMethodInfo != null)
				{
					runtimeType = (RuntimeType)runtimeMethodInfo.ReturnType;
				}
				else
				{
					runtimeType = (RuntimeType)((DynamicMethod)method).ReturnType;
				}
				if (runtimeType == typeof(void))
				{
					il.Emit(OpCodes.Ldnull);
				}
				else if (runtimeType.IsValueType)
				{
					il.Emit(OpCodes.Box, runtimeType);
				}
				else if (runtimeType.IsPointer)
				{
					il.Emit(OpCodes.Ldtoken, runtimeType);
					il.Emit(OpCodes.Call, InvokerEmitUtil.Methods.Type_GetTypeFromHandle());
					il.Emit(OpCodes.Call, InvokerEmitUtil.Methods.Pointer_Box());
				}
				else if (runtimeType.IsFunctionPointer)
				{
					il.Emit(OpCodes.Box, typeof(IntPtr));
				}
				else if (runtimeType.IsByRef)
				{
					RuntimeType runtimeType2 = (RuntimeType)runtimeType.GetElementType();
					Label label = il.DefineLabel();
					il.Emit(OpCodes.Dup);
					il.Emit(OpCodes.Brtrue_S, label);
					il.Emit(OpCodes.Call, InvokerEmitUtil.Methods.ThrowHelper_Throw_NullReference_InvokeNullRefReturned());
					il.MarkLabel(label);
					if (runtimeType2.IsValueType)
					{
						il.Emit(OpCodes.Ldobj, runtimeType2);
						il.Emit(OpCodes.Box, runtimeType2);
					}
					else if (runtimeType2.IsPointer)
					{
						il.Emit(OpCodes.Ldind_Ref);
						il.Emit(OpCodes.Conv_U);
						il.Emit(OpCodes.Ldtoken, runtimeType2);
						il.Emit(OpCodes.Call, InvokerEmitUtil.Methods.Type_GetTypeFromHandle());
						il.Emit(OpCodes.Call, InvokerEmitUtil.Methods.Pointer_Box());
					}
					else if (runtimeType2.IsFunctionPointer)
					{
						il.Emit(OpCodes.Box, typeof(IntPtr));
					}
					else
					{
						il.Emit(OpCodes.Ldobj, runtimeType2);
					}
				}
			}
			il.Emit(OpCodes.Ret);
		}

		// Token: 0x0200074C RID: 1868
		// (Invoke) Token: 0x06007919 RID: 31001
		internal unsafe delegate object InvokeFunc_RefArgs(object obj, IntPtr* refArguments);

		// Token: 0x0200074D RID: 1869
		// (Invoke) Token: 0x0600791B RID: 31003
		internal delegate object InvokeFunc_ObjSpanArgs(object obj, Span<object> arguments);

		// Token: 0x0200074E RID: 1870
		// (Invoke) Token: 0x0600791D RID: 31005
		internal delegate object InvokeFunc_Obj4Args(object obj, object arg1, object arg2, object arg3, object arg4);

		// Token: 0x0200074F RID: 1871
		private static class ThrowHelper
		{
			// Token: 0x0600791E RID: 31006 RVA: 0x0011FD4E File Offset: 0x0011DF4E
			public static void Throw_NullReference_InvokeNullRefReturned()
			{
				throw new NullReferenceException(SR.NullReference_InvokeNullRefReturned);
			}
		}

		// Token: 0x02000750 RID: 1872
		private static class Methods
		{
			// Token: 0x0600791F RID: 31007 RVA: 0x0011FD5A File Offset: 0x0011DF5A
			public static FieldInfo ByReferenceOfByte_Value()
			{
				FieldInfo result;
				if ((result = InvokerEmitUtil.Methods.s_ByReferenceOfByte_Value) == null)
				{
					result = (InvokerEmitUtil.Methods.s_ByReferenceOfByte_Value = typeof(ByReference).GetField("Value"));
				}
				return result;
			}

			// Token: 0x06007920 RID: 31008 RVA: 0x0011FD7F File Offset: 0x0011DF7F
			public static MethodInfo Span_get_Item()
			{
				MethodInfo result;
				if ((result = InvokerEmitUtil.Methods.s_Span_get_Item) == null)
				{
					result = (InvokerEmitUtil.Methods.s_Span_get_Item = typeof(Span<object>).GetProperty("Item").GetGetMethod());
				}
				return result;
			}

			// Token: 0x06007921 RID: 31009 RVA: 0x0011FDA9 File Offset: 0x0011DFA9
			public static MethodInfo ThrowHelper_Throw_NullReference_InvokeNullRefReturned()
			{
				MethodInfo result;
				if ((result = InvokerEmitUtil.Methods.s_ThrowHelper_Throw_NullReference_InvokeNullRefReturned) == null)
				{
					result = (InvokerEmitUtil.Methods.s_ThrowHelper_Throw_NullReference_InvokeNullRefReturned = typeof(InvokerEmitUtil.ThrowHelper).GetMethod("Throw_NullReference_InvokeNullRefReturned"));
				}
				return result;
			}

			// Token: 0x06007922 RID: 31010 RVA: 0x0011FDCE File Offset: 0x0011DFCE
			public static MethodInfo Object_GetRawData()
			{
				MethodInfo result;
				if ((result = InvokerEmitUtil.Methods.s_Object_GetRawData) == null)
				{
					result = (InvokerEmitUtil.Methods.s_Object_GetRawData = typeof(RuntimeHelpers).GetMethod("GetRawData", BindingFlags.Static | BindingFlags.NonPublic));
				}
				return result;
			}

			// Token: 0x06007923 RID: 31011 RVA: 0x0011FDF8 File Offset: 0x0011DFF8
			public unsafe static MethodInfo Pointer_Box()
			{
				MethodInfo result;
				if ((result = InvokerEmitUtil.Methods.s_Pointer_Box) == null)
				{
					result = (InvokerEmitUtil.Methods.s_Pointer_Box = typeof(Pointer).GetMethod("Box", new Type[]
					{
						typeof(void*),
						typeof(Type)
					}));
				}
				return result;
			}

			// Token: 0x06007924 RID: 31012 RVA: 0x0011FE48 File Offset: 0x0011E048
			public static MethodInfo Type_GetTypeFromHandle()
			{
				MethodInfo result;
				if ((result = InvokerEmitUtil.Methods.s_Type_GetTypeFromHandle) == null)
				{
					result = (InvokerEmitUtil.Methods.s_Type_GetTypeFromHandle = typeof(Type).GetMethod("GetTypeFromHandle", new Type[]
					{
						typeof(RuntimeTypeHandle)
					}));
				}
				return result;
			}

			// Token: 0x06007925 RID: 31013 RVA: 0x0011FE80 File Offset: 0x0011E080
			public static MethodInfo DisableInline()
			{
				MethodInfo result;
				if ((result = InvokerEmitUtil.Methods.s_DisableInline) == null)
				{
					result = (InvokerEmitUtil.Methods.s_DisableInline = typeof(JitHelpers).GetMethod("DisableInline", BindingFlags.Static | BindingFlags.NonPublic));
				}
				return result;
			}

			// Token: 0x04001688 RID: 5768
			private static FieldInfo s_ByReferenceOfByte_Value;

			// Token: 0x04001689 RID: 5769
			private static MethodInfo s_Span_get_Item;

			// Token: 0x0400168A RID: 5770
			private static MethodInfo s_ThrowHelper_Throw_NullReference_InvokeNullRefReturned;

			// Token: 0x0400168B RID: 5771
			private static MethodInfo s_Object_GetRawData;

			// Token: 0x0400168C RID: 5772
			private static MethodInfo s_Pointer_Box;

			// Token: 0x0400168D RID: 5773
			private static MethodInfo s_Type_GetTypeFromHandle;

			// Token: 0x0400168E RID: 5774
			private static MethodInfo s_DisableInline;
		}
	}
}
