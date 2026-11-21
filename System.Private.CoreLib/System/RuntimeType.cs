using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Mono;

namespace System
{
	// Token: 0x02000091 RID: 145
	internal sealed class RuntimeType : TypeInfo, ICloneable
	{
		// Token: 0x0600056E RID: 1390 RVA: 0x00011A2C File Offset: 0x0000FC2C
		[RequiresUnreferencedCode("Types might be removed")]
		internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			ArgumentNullException.ThrowIfNull(typeName, "typeName");
			return RuntimeTypeHandle.GetTypeByName(typeName, throwOnError, ignoreCase, ref stackMark);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00011A44 File Offset: 0x0000FC44
		private static void SplitName(string fullname, out string name, out string ns)
		{
			name = null;
			ns = null;
			if (fullname == null)
			{
				return;
			}
			int num = fullname.LastIndexOf('.');
			if (num == -1)
			{
				name = fullname;
				return;
			}
			ns = fullname.Substring(0, num);
			int num2 = fullname.Length - ns.Length - 1;
			if (num2 != 0)
			{
				name = fullname.Substring(num + 1, num2);
				return;
			}
			name = "";
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00011AA0 File Offset: 0x0000FCA0
		internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic)
		{
			BindingFlags bindingFlags = isPublic ? BindingFlags.Public : BindingFlags.NonPublic;
			if (isInherited)
			{
				bindingFlags |= BindingFlags.DeclaredOnly;
				if (isStatic)
				{
					bindingFlags |= (BindingFlags.Static | BindingFlags.FlattenHierarchy);
				}
				else
				{
					bindingFlags |= BindingFlags.Instance;
				}
			}
			else if (isStatic)
			{
				bindingFlags |= BindingFlags.Static;
			}
			else
			{
				bindingFlags |= BindingFlags.Instance;
			}
			return bindingFlags;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00011ADC File Offset: 0x0000FCDC
		private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
			prefixLookup = false;
			ignoreCase = false;
			if (name != null)
			{
				if ((bindingFlags & BindingFlags.IgnoreCase) != BindingFlags.Default)
				{
					name = name.ToLowerInvariant();
					ignoreCase = true;
					listType = RuntimeType.MemberListType.CaseInsensitive;
				}
				else
				{
					listType = RuntimeType.MemberListType.CaseSensitive;
				}
				if (allowPrefixLookup && name.EndsWith('*'))
				{
					name = name.Substring(0, name.Length - 1);
					prefixLookup = true;
					listType = RuntimeType.MemberListType.All;
					return;
				}
			}
			else
			{
				listType = RuntimeType.MemberListType.All;
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00011B40 File Offset: 0x0000FD40
		private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
			bool flag;
			RuntimeType.FilterHelper(bindingFlags, ref name, false, out flag, out ignoreCase, out listType);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00011B59 File Offset: 0x0000FD59
		private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase)
		{
			if (ignoreCase)
			{
				if (!memberInfo.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase))
				{
					return false;
				}
			}
			else if (!memberInfo.Name.StartsWith(name, StringComparison.Ordinal))
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00011B84 File Offset: 0x0000FD84
		private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup)
		{
			if (isPublic)
			{
				if ((bindingFlags & BindingFlags.Public) == BindingFlags.Default)
				{
					return false;
				}
			}
			else if ((bindingFlags & BindingFlags.NonPublic) == BindingFlags.Default)
			{
				return false;
			}
			bool flag = memberInfo.DeclaringType != memberInfo.ReflectedType;
			if ((bindingFlags & BindingFlags.DeclaredOnly) > BindingFlags.Default && flag)
			{
				return false;
			}
			if (memberInfo.MemberType != MemberTypes.TypeInfo && memberInfo.MemberType != MemberTypes.NestedType)
			{
				if (isStatic)
				{
					if ((bindingFlags & BindingFlags.FlattenHierarchy) == BindingFlags.Default && flag)
					{
						return false;
					}
					if ((bindingFlags & BindingFlags.Static) == BindingFlags.Default)
					{
						return false;
					}
				}
				else if ((bindingFlags & BindingFlags.Instance) == BindingFlags.Default)
				{
					return false;
				}
			}
			if (prefixLookup && !RuntimeType.FilterApplyPrefixLookup(memberInfo, name, (bindingFlags & BindingFlags.IgnoreCase) > BindingFlags.Default))
			{
				return false;
			}
			if ((bindingFlags & BindingFlags.DeclaredOnly) == BindingFlags.Default && flag && isNonProtectedInternal && (bindingFlags & BindingFlags.NonPublic) != BindingFlags.Default && !isStatic && (bindingFlags & BindingFlags.Instance) != BindingFlags.Default)
			{
				MethodInfo methodInfo = memberInfo as MethodInfo;
				if (methodInfo == null)
				{
					return false;
				}
				if (!methodInfo.IsVirtual && !methodInfo.IsAbstract)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00011C50 File Offset: 0x0000FE50
		private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns)
		{
			bool isPublic = type.IsNestedPublic || type.IsPublic;
			bool isStatic = false;
			return RuntimeType.FilterApplyBase(type, bindingFlags, isPublic, type.IsNestedAssembly, isStatic, name, prefixLookup) && (ns == null || !(ns != type.Namespace));
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00011C9C File Offset: 0x0000FE9C
		private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
		{
			return RuntimeType.FilterApplyMethodBase(method, bindingFlags, callConv, argumentTypes);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00011C9C File Offset: 0x0000FE9C
		private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
		{
			return RuntimeType.FilterApplyMethodBase(constructor, bindingFlags, callConv, argumentTypes);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		private unsafe static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
		{
			bindingFlags ^= BindingFlags.DeclaredOnly;
			if ((callConv & CallingConventions.Any) == (CallingConventions)0)
			{
				if ((callConv & CallingConventions.VarArgs) != (CallingConventions)0 && (methodBase.CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
				{
					return false;
				}
				if ((callConv & CallingConventions.Standard) != (CallingConventions)0 && (methodBase.CallingConvention & CallingConventions.Standard) == (CallingConventions)0)
				{
					return false;
				}
			}
			if (argumentTypes != null)
			{
				ReadOnlySpan<ParameterInfo> parametersAsSpan = methodBase.GetParametersAsSpan();
				if (argumentTypes.Length != parametersAsSpan.Length)
				{
					if ((bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetProperty | BindingFlags.SetProperty)) == BindingFlags.Default)
					{
						return false;
					}
					bool flag = false;
					if (argumentTypes.Length > parametersAsSpan.Length)
					{
						if ((methodBase.CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
						{
							flag = true;
						}
					}
					else if ((bindingFlags & BindingFlags.OptionalParamBinding) == BindingFlags.Default)
					{
						flag = true;
					}
					else if (!parametersAsSpan[argumentTypes.Length]->IsOptional)
					{
						flag = true;
					}
					if (flag)
					{
						if (parametersAsSpan.Length == 0)
						{
							return false;
						}
						if (argumentTypes.Length < parametersAsSpan.Length - 1)
						{
							return false;
						}
						ParameterInfo parameterInfo = *parametersAsSpan[parametersAsSpan.Length - 1];
						if (!parameterInfo.ParameterType.IsArray)
						{
							return false;
						}
						if (!parameterInfo.IsDefined(typeof(ParamArrayAttribute), false))
						{
							return false;
						}
					}
				}
				else if ((bindingFlags & BindingFlags.ExactBinding) != BindingFlags.Default && (bindingFlags & BindingFlags.InvokeMethod) == BindingFlags.Default)
				{
					for (int i = 0; i < parametersAsSpan.Length; i++)
					{
						if (argumentTypes[i] != null && !argumentTypes[i].MatchesParameterTypeExactly(*parametersAsSpan[i]))
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00011DDF File Offset: 0x0000FFDF
		internal RuntimeType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00011DEC File Offset: 0x0000FFEC
		private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out listType);
			RuntimeMethodInfo[] methodsByName = this.GetMethodsByName(name, bindingAttr, listType, this);
			RuntimeType.ListBuilder<MethodInfo> result = new RuntimeType.ListBuilder<MethodInfo>(methodsByName.Length);
			int i = 0;
			while (i < methodsByName.Length)
			{
				RuntimeMethodInfo runtimeMethodInfo = methodsByName[i];
				if (genericParamCount == -1)
				{
					goto IL_5E;
				}
				bool isGenericMethod = runtimeMethodInfo.IsGenericMethod;
				if ((genericParamCount != 0 || !isGenericMethod) && (genericParamCount <= 0 || isGenericMethod) && runtimeMethodInfo.GetGenericArguments().Length == genericParamCount)
				{
					goto IL_5E;
				}
				IL_82:
				i++;
				continue;
				IL_5E:
				if (RuntimeType.FilterApplyMethodInfo(runtimeMethodInfo, bindingAttr, callConv, types) && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimeMethodInfo, name, ignoreCase)))
				{
					result.Add(runtimeMethodInfo);
					goto IL_82;
				}
				goto IL_82;
			}
			return result;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00011E8C File Offset: 0x0001008C
		private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType memberListType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out memberListType);
			if (!string.IsNullOrEmpty(name) && name != ConstructorInfo.ConstructorName && name != ConstructorInfo.TypeConstructorName)
			{
				return new RuntimeType.ListBuilder<ConstructorInfo>(0);
			}
			RuntimeConstructorInfo[] constructors_internal = this.GetConstructors_internal(bindingAttr, this);
			RuntimeType.ListBuilder<ConstructorInfo> result = new RuntimeType.ListBuilder<ConstructorInfo>(constructors_internal.Length);
			foreach (RuntimeConstructorInfo runtimeConstructorInfo in constructors_internal)
			{
				if (RuntimeType.FilterApplyConstructorInfo(runtimeConstructorInfo, bindingAttr, callConv, types) && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimeConstructorInfo, name, ignoreCase)))
				{
					result.Add(runtimeConstructorInfo);
				}
			}
			return result;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00011F24 File Offset: 0x00010124
		private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out listType);
			RuntimePropertyInfo[] propertiesByName = this.GetPropertiesByName(name, bindingAttr, listType, this);
			bindingAttr ^= BindingFlags.DeclaredOnly;
			RuntimeType.ListBuilder<PropertyInfo> result = new RuntimeType.ListBuilder<PropertyInfo>(propertiesByName.Length);
			foreach (RuntimePropertyInfo runtimePropertyInfo in propertiesByName)
			{
				if ((bindingAttr & runtimePropertyInfo.BindingFlags) == runtimePropertyInfo.BindingFlags && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimePropertyInfo, name, ignoreCase)) && (types == null || runtimePropertyInfo.GetIndexParameters().Length == types.Length))
				{
					result.Add(runtimePropertyInfo);
				}
			}
			return result;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00011FB0 File Offset: 0x000101B0
		private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out listType);
			RuntimeEventInfo[] events_internal = this.GetEvents_internal(name, listType, this);
			bindingAttr ^= BindingFlags.DeclaredOnly;
			RuntimeType.ListBuilder<EventInfo> result = new RuntimeType.ListBuilder<EventInfo>(events_internal.Length);
			foreach (RuntimeEventInfo runtimeEventInfo in events_internal)
			{
				if ((bindingAttr & runtimeEventInfo.BindingFlags) == runtimeEventInfo.BindingFlags && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimeEventInfo, name, ignoreCase)))
				{
					result.Add(runtimeEventInfo);
				}
			}
			return result;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00012028 File Offset: 0x00010228
		private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out listType);
			RuntimeFieldInfo[] fields_internal = this.GetFields_internal(name, bindingAttr, listType, this);
			RuntimeType.ListBuilder<FieldInfo> result = new RuntimeType.ListBuilder<FieldInfo>(fields_internal.Length);
			foreach (RuntimeFieldInfo runtimeFieldInfo in fields_internal)
			{
				if (!flag || RuntimeType.FilterApplyPrefixLookup(runtimeFieldInfo, name, ignoreCase))
				{
					result.Add(runtimeFieldInfo);
				}
			}
			return result;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0001208C File Offset: 0x0001028C
		private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			bindingAttr &= ~BindingFlags.Static;
			string text;
			string ns;
			RuntimeType.SplitName(fullname, out text, out ns);
			bool prefixLookup;
			bool flag;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref text, allowPrefixLookup, out prefixLookup, out flag, out listType);
			RuntimeType[] nestedTypes_internal = this.GetNestedTypes_internal(text, bindingAttr, listType);
			RuntimeType.ListBuilder<Type> result = new RuntimeType.ListBuilder<Type>(nestedTypes_internal.Length);
			foreach (RuntimeType runtimeType in nestedTypes_internal)
			{
				if (RuntimeType.FilterApplyType(runtimeType, bindingAttr, text, prefixLookup, ns))
				{
					result.Add(runtimeType);
				}
			}
			return result;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00012100 File Offset: 0x00010300
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this.GetMethodCandidates(null, bindingAttr, CallingConventions.Any, null, -1, false).ToArray();
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00012124 File Offset: 0x00010324
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return this.GetConstructorCandidates(null, bindingAttr, CallingConventions.Any, null, false).ToArray();
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00012144 File Offset: 0x00010344
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return this.GetPropertyCandidates(null, bindingAttr, null, false).ToArray();
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00012164 File Offset: 0x00010364
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return this.GetEventCandidates(null, bindingAttr, false).ToArray();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00012184 File Offset: 0x00010384
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return this.GetFieldCandidates(null, bindingAttr, false).ToArray();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000121A4 File Offset: 0x000103A4
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			return this.GetNestedTypeCandidates(null, bindingAttr, false).ToArray();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000121C4 File Offset: 0x000103C4
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			RuntimeType.ListBuilder<MethodInfo> methodCandidates = this.GetMethodCandidates(null, bindingAttr, CallingConventions.Any, null, -1, false);
			RuntimeType.ListBuilder<ConstructorInfo> constructorCandidates = this.GetConstructorCandidates(null, bindingAttr, CallingConventions.Any, null, false);
			RuntimeType.ListBuilder<PropertyInfo> propertyCandidates = this.GetPropertyCandidates(null, bindingAttr, null, false);
			RuntimeType.ListBuilder<EventInfo> eventCandidates = this.GetEventCandidates(null, bindingAttr, false);
			RuntimeType.ListBuilder<FieldInfo> fieldCandidates = this.GetFieldCandidates(null, bindingAttr, false);
			RuntimeType.ListBuilder<Type> nestedTypeCandidates = this.GetNestedTypeCandidates(null, bindingAttr, false);
			MemberInfo[] array = new MemberInfo[methodCandidates.Count + constructorCandidates.Count + propertyCandidates.Count + eventCandidates.Count + fieldCandidates.Count + nestedTypeCandidates.Count];
			int num = 0;
			object[] array2 = array;
			methodCandidates.CopyTo(array2, num);
			num += methodCandidates.Count;
			array2 = array;
			constructorCandidates.CopyTo(array2, num);
			num += constructorCandidates.Count;
			array2 = array;
			propertyCandidates.CopyTo(array2, num);
			num += propertyCandidates.Count;
			array2 = array;
			eventCandidates.CopyTo(array2, num);
			num += eventCandidates.Count;
			array2 = array;
			fieldCandidates.CopyTo(array2, num);
			num += fieldCandidates.Count;
			array2 = array;
			nestedTypeCandidates.CopyTo(array2, num);
			num += nestedTypeCandidates.Count;
			return array;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000122F2 File Offset: 0x000104F2
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethodImpl(name, -1, bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00012304 File Offset: 0x00010504
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected override MethodInfo GetMethodImpl(string name, int genericParamCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers)
		{
			RuntimeType.ListBuilder<MethodInfo> methodCandidates = this.GetMethodCandidates(name, bindingAttr, callConv, types, genericParamCount, false);
			if (methodCandidates.Count == 0)
			{
				return null;
			}
			MethodBase[] match;
			if (types == null || types.Length == 0)
			{
				MethodInfo methodInfo = methodCandidates[0];
				if (methodCandidates.Count == 1)
				{
					return methodInfo;
				}
				if (types == null)
				{
					for (int i = 1; i < methodCandidates.Count; i++)
					{
						if (!System.DefaultBinder.CompareMethodSig(methodCandidates[i], methodInfo))
						{
							throw ThrowHelper.GetAmbiguousMatchException(methodInfo);
						}
					}
					match = methodCandidates.ToArray();
					return System.DefaultBinder.FindMostDerivedNewSlotMeth(match, methodCandidates.Count) as MethodInfo;
				}
			}
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			Binder binder2 = binder;
			match = methodCandidates.ToArray();
			return binder2.SelectMethod(bindingAttr, match, types, modifiers) as MethodInfo;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000123B8 File Offset: 0x000105B8
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			RuntimeType.ListBuilder<ConstructorInfo> constructorCandidates = this.GetConstructorCandidates(null, bindingAttr, CallingConventions.Any, types, false);
			if (constructorCandidates.Count == 0)
			{
				return null;
			}
			if (types.Length == 0 && constructorCandidates.Count == 1)
			{
				ConstructorInfo constructorInfo = constructorCandidates[0];
				if (constructorInfo.GetParametersAsSpan().Length == 0)
				{
					return constructorInfo;
				}
			}
			MethodBase[] match;
			if ((bindingAttr & BindingFlags.ExactBinding) != BindingFlags.Default)
			{
				match = constructorCandidates.ToArray();
				return System.DefaultBinder.ExactBinding(match, types) as ConstructorInfo;
			}
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			Binder binder2 = binder;
			match = constructorCandidates.ToArray();
			return binder2.SelectMethod(bindingAttr, match, types, modifiers) as ConstructorInfo;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001244C File Offset: 0x0001064C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			RuntimeType.ListBuilder<PropertyInfo> propertyCandidates = this.GetPropertyCandidates(name, bindingAttr, types, false);
			if (propertyCandidates.Count == 0)
			{
				return null;
			}
			if (types == null || types.Length == 0)
			{
				PropertyInfo propertyInfo = propertyCandidates[0];
				if (propertyCandidates.Count == 1)
				{
					if (returnType != null && !returnType.IsEquivalentTo(propertyInfo.PropertyType))
					{
						return null;
					}
					return propertyInfo;
				}
				else if (returnType == null)
				{
					throw ThrowHelper.GetAmbiguousMatchException(propertyInfo);
				}
			}
			if ((bindingAttr & BindingFlags.ExactBinding) != BindingFlags.Default)
			{
				return System.DefaultBinder.ExactPropertyBinding(propertyCandidates.ToArray(), returnType, types);
			}
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			return binder.SelectProperty(bindingAttr, propertyCandidates.ToArray(), returnType, types, modifiers);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000124F4 File Offset: 0x000106F4
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			bool flag;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, out flag, out listType);
			RuntimeEventInfo[] events_internal = this.GetEvents_internal(name, listType, this);
			EventInfo eventInfo = null;
			bindingAttr ^= BindingFlags.DeclaredOnly;
			foreach (RuntimeEventInfo runtimeEventInfo in events_internal)
			{
				if ((bindingAttr & runtimeEventInfo.BindingFlags) == runtimeEventInfo.BindingFlags)
				{
					if (eventInfo != null)
					{
						throw ThrowHelper.GetAmbiguousMatchException(eventInfo);
					}
					eventInfo = runtimeEventInfo;
				}
			}
			return eventInfo;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00012568 File Offset: 0x00010768
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			bool flag;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, out flag, out listType);
			RuntimeFieldInfo[] fields_internal = this.GetFields_internal(name, bindingAttr, listType, this);
			FieldInfo fieldInfo = null;
			bool flag2 = false;
			foreach (RuntimeFieldInfo runtimeFieldInfo in fields_internal)
			{
				if (fieldInfo != null)
				{
					if (runtimeFieldInfo.DeclaringType == fieldInfo.DeclaringType)
					{
						throw ThrowHelper.GetAmbiguousMatchException(fieldInfo);
					}
					if (fieldInfo.DeclaringType.IsInterface && runtimeFieldInfo.DeclaringType.IsInterface)
					{
						flag2 = true;
					}
				}
				if (fieldInfo == null || runtimeFieldInfo.DeclaringType.IsSubclassOf(fieldInfo.DeclaringType) || fieldInfo.DeclaringType.IsInterface)
				{
					fieldInfo = runtimeFieldInfo;
				}
			}
			if (flag2 && fieldInfo.DeclaringType.IsInterface)
			{
				throw ThrowHelper.GetAmbiguousMatchException(fieldInfo);
			}
			return fieldInfo;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00012634 File Offset: 0x00010834
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2063:UnrecognizedReflectionPattern", Justification = "Trimming makes sure that interfaces are fully preserved, so the Interfaces annotation is transitive.The cache doesn't carry the necessary annotation since it returns an array type,so the analysis complains that the returned value doesn't have the necessary annotation.")]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type GetInterface(string fullname, bool ignoreCase)
		{
			ArgumentNullException.ThrowIfNull(fullname, "fullname");
			BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
			bindingFlags &= ~BindingFlags.Static;
			if (ignoreCase)
			{
				bindingFlags |= BindingFlags.IgnoreCase;
			}
			string text;
			string ns;
			RuntimeType.SplitName(fullname, out text, out ns);
			RuntimeType.MemberListType memberListType;
			RuntimeType.FilterHelper(bindingFlags, ref text, out ignoreCase, out memberListType);
			List<RuntimeType> list = null;
			StringComparison comparisonType = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
			foreach (RuntimeType runtimeType in this.GetInterfaces())
			{
				if (string.Equals(runtimeType.Name, text, comparisonType))
				{
					if (list == null)
					{
						list = new List<RuntimeType>(2);
					}
					list.Add(runtimeType);
				}
			}
			if (list == null)
			{
				return null;
			}
			RuntimeType[] array = list.ToArray();
			RuntimeType runtimeType2 = null;
			foreach (RuntimeType runtimeType3 in array)
			{
				if (RuntimeType.FilterApplyType(runtimeType3, bindingFlags, text, false, ns))
				{
					if (runtimeType2 != null)
					{
						throw ThrowHelper.GetAmbiguousMatchException(runtimeType2);
					}
					runtimeType2 = runtimeType3;
				}
			}
			return runtimeType2;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00012718 File Offset: 0x00010918
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type GetNestedType(string fullname, BindingFlags bindingAttr)
		{
			ArgumentNullException.ThrowIfNull(fullname, "fullname");
			bindingAttr &= ~BindingFlags.Static;
			string text;
			string ns;
			RuntimeType.SplitName(fullname, out text, out ns);
			bool flag;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref text, out flag, out listType);
			RuntimeType[] nestedTypes_internal = this.GetNestedTypes_internal(text, bindingAttr, listType);
			RuntimeType runtimeType = null;
			foreach (RuntimeType runtimeType2 in nestedTypes_internal)
			{
				if (RuntimeType.FilterApplyType(runtimeType2, bindingAttr, text, false, ns))
				{
					if (runtimeType != null)
					{
						throw ThrowHelper.GetAmbiguousMatchException(runtimeType);
					}
					runtimeType = runtimeType2;
				}
			}
			return runtimeType;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00012798 File Offset: 0x00010998
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			RuntimeType.ListBuilder<MethodInfo> listBuilder = default(RuntimeType.ListBuilder<MethodInfo>);
			RuntimeType.ListBuilder<ConstructorInfo> listBuilder2 = default(RuntimeType.ListBuilder<ConstructorInfo>);
			RuntimeType.ListBuilder<PropertyInfo> listBuilder3 = default(RuntimeType.ListBuilder<PropertyInfo>);
			RuntimeType.ListBuilder<EventInfo> listBuilder4 = default(RuntimeType.ListBuilder<EventInfo>);
			RuntimeType.ListBuilder<FieldInfo> listBuilder5 = default(RuntimeType.ListBuilder<FieldInfo>);
			RuntimeType.ListBuilder<Type> listBuilder6 = default(RuntimeType.ListBuilder<Type>);
			int num = 0;
			if ((type & MemberTypes.Method) != (MemberTypes)0)
			{
				listBuilder = this.GetMethodCandidates(name, bindingAttr, CallingConventions.Any, null, -1, true);
				if (type == MemberTypes.Method)
				{
					return listBuilder.ToArray();
				}
				num += listBuilder.Count;
			}
			if ((type & MemberTypes.Constructor) != (MemberTypes)0)
			{
				listBuilder2 = this.GetConstructorCandidates(name, bindingAttr, CallingConventions.Any, null, true);
				if (type == MemberTypes.Constructor)
				{
					return listBuilder2.ToArray();
				}
				num += listBuilder2.Count;
			}
			if ((type & MemberTypes.Property) != (MemberTypes)0)
			{
				listBuilder3 = this.GetPropertyCandidates(name, bindingAttr, null, true);
				if (type == MemberTypes.Property)
				{
					return listBuilder3.ToArray();
				}
				num += listBuilder3.Count;
			}
			if ((type & MemberTypes.Event) != (MemberTypes)0)
			{
				listBuilder4 = this.GetEventCandidates(name, bindingAttr, true);
				if (type == MemberTypes.Event)
				{
					return listBuilder4.ToArray();
				}
				num += listBuilder4.Count;
			}
			if ((type & MemberTypes.Field) != (MemberTypes)0)
			{
				listBuilder5 = this.GetFieldCandidates(name, bindingAttr, true);
				if (type == MemberTypes.Field)
				{
					return listBuilder5.ToArray();
				}
				num += listBuilder5.Count;
			}
			if ((type & (MemberTypes.TypeInfo | MemberTypes.NestedType)) != (MemberTypes)0)
			{
				listBuilder6 = this.GetNestedTypeCandidates(name, bindingAttr, true);
				if (type == MemberTypes.NestedType || type == MemberTypes.TypeInfo)
				{
					return listBuilder6.ToArray();
				}
				num += listBuilder6.Count;
			}
			MemberInfo[] array;
			if (type != (MemberTypes.Constructor | MemberTypes.Method))
			{
				array = new MemberInfo[num];
			}
			else
			{
				MemberInfo[] array2 = new MethodBase[num];
				array = array2;
			}
			MemberInfo[] array3 = array;
			int num2 = 0;
			object[] array4 = array3;
			listBuilder.CopyTo(array4, num2);
			num2 += listBuilder.Count;
			array4 = array3;
			listBuilder2.CopyTo(array4, num2);
			num2 += listBuilder2.Count;
			array4 = array3;
			listBuilder3.CopyTo(array4, num2);
			num2 += listBuilder3.Count;
			array4 = array3;
			listBuilder4.CopyTo(array4, num2);
			num2 += listBuilder4.Count;
			array4 = array3;
			listBuilder5.CopyTo(array4, num2);
			num2 += listBuilder5.Count;
			array4 = array3;
			listBuilder6.CopyTo(array4, num2);
			num2 += listBuilder6.Count;
			return array3;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000129C0 File Offset: 0x00010BC0
		public override MemberInfo GetMemberWithSameMetadataDefinitionAs(MemberInfo member)
		{
			ArgumentNullException.ThrowIfNull(member, "member");
			RuntimeType runtimeType = this;
			while (runtimeType != null)
			{
				MemberTypes memberType = member.MemberType;
				MemberInfo memberInfo;
				if (memberType <= MemberTypes.Method)
				{
					switch (memberType)
					{
					case MemberTypes.Constructor:
						memberInfo = RuntimeType.GetConstructorWithSameMetadataDefinitionAs(runtimeType, member);
						break;
					case MemberTypes.Event:
						memberInfo = RuntimeType.GetEventWithSameMetadataDefinitionAs(runtimeType, member);
						break;
					case MemberTypes.Constructor | MemberTypes.Event:
						goto IL_86;
					case MemberTypes.Field:
						memberInfo = RuntimeType.GetFieldWithSameMetadataDefinitionAs(runtimeType, member);
						break;
					default:
						if (memberType != MemberTypes.Method)
						{
							goto IL_86;
						}
						memberInfo = RuntimeType.GetMethodWithSameMetadataDefinitionAs(runtimeType, member);
						break;
					}
				}
				else if (memberType != MemberTypes.Property)
				{
					if (memberType != MemberTypes.NestedType)
					{
						goto IL_86;
					}
					memberInfo = RuntimeType.GetNestedTypeWithSameMetadataDefinitionAs(runtimeType, member);
				}
				else
				{
					memberInfo = RuntimeType.GetPropertyWithSameMetadataDefinitionAs(runtimeType, member);
				}
				IL_88:
				MemberInfo memberInfo2 = memberInfo;
				if (memberInfo2 != null)
				{
					return memberInfo2;
				}
				runtimeType = runtimeType.GetBaseType();
				continue;
				IL_86:
				memberInfo = null;
				goto IL_88;
			}
			throw Type.CreateGetMemberWithSameMetadataDefinitionAsNotFoundException(member);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00012A7C File Offset: 0x00010C7C
		private static MethodInfo GetMethodWithSameMetadataDefinitionAs(RuntimeType runtimeType, MemberInfo methodInfo)
		{
			RuntimeType.ListBuilder<MethodInfo> methodCandidates = runtimeType.GetMethodCandidates(methodInfo.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, CallingConventions.Any, null, -1, false);
			for (int i = 0; i < methodCandidates.Count; i++)
			{
				MethodInfo methodInfo2 = methodCandidates[i];
				if (methodInfo2.HasSameMetadataDefinitionAs(methodInfo))
				{
					return methodInfo2;
				}
			}
			return null;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00012AC4 File Offset: 0x00010CC4
		private static ConstructorInfo GetConstructorWithSameMetadataDefinitionAs(RuntimeType runtimeType, MemberInfo constructorInfo)
		{
			RuntimeType.ListBuilder<ConstructorInfo> constructorCandidates = runtimeType.GetConstructorCandidates(null, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, CallingConventions.Any, null, false);
			for (int i = 0; i < constructorCandidates.Count; i++)
			{
				ConstructorInfo constructorInfo2 = constructorCandidates[i];
				if (constructorInfo2.HasSameMetadataDefinitionAs(constructorInfo))
				{
					return constructorInfo2;
				}
			}
			return null;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00012B08 File Offset: 0x00010D08
		private static PropertyInfo GetPropertyWithSameMetadataDefinitionAs(RuntimeType runtimeType, MemberInfo propertyInfo)
		{
			RuntimeType.ListBuilder<PropertyInfo> propertyCandidates = runtimeType.GetPropertyCandidates(propertyInfo.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, false);
			for (int i = 0; i < propertyCandidates.Count; i++)
			{
				PropertyInfo propertyInfo2 = propertyCandidates[i];
				if (propertyInfo2.HasSameMetadataDefinitionAs(propertyInfo))
				{
					return propertyInfo2;
				}
			}
			return null;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00012B50 File Offset: 0x00010D50
		private static FieldInfo GetFieldWithSameMetadataDefinitionAs(RuntimeType runtimeType, MemberInfo fieldInfo)
		{
			RuntimeType.ListBuilder<FieldInfo> fieldCandidates = runtimeType.GetFieldCandidates(fieldInfo.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, false);
			for (int i = 0; i < fieldCandidates.Count; i++)
			{
				FieldInfo fieldInfo2 = fieldCandidates[i];
				if (fieldInfo2.HasSameMetadataDefinitionAs(fieldInfo))
				{
					return fieldInfo2;
				}
			}
			return null;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00012B94 File Offset: 0x00010D94
		private static EventInfo GetEventWithSameMetadataDefinitionAs(RuntimeType runtimeType, MemberInfo eventInfo)
		{
			RuntimeType.ListBuilder<EventInfo> eventCandidates = runtimeType.GetEventCandidates(null, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, false);
			for (int i = 0; i < eventCandidates.Count; i++)
			{
				EventInfo eventInfo2 = eventCandidates[i];
				if (eventInfo2.HasSameMetadataDefinitionAs(eventInfo))
				{
					return eventInfo2;
				}
			}
			return null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00012BD4 File Offset: 0x00010DD4
		private static Type GetNestedTypeWithSameMetadataDefinitionAs(RuntimeType runtimeType, MemberInfo nestedType)
		{
			RuntimeType.ListBuilder<Type> nestedTypeCandidates = runtimeType.GetNestedTypeCandidates(nestedType.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, false);
			for (int i = 0; i < nestedTypeCandidates.Count; i++)
			{
				Type type = nestedTypeCandidates[i];
				if (type.HasSameMetadataDefinitionAs(nestedType))
				{
					return type;
				}
			}
			return null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00012C18 File Offset: 0x00010E18
		public override bool IsEquivalentTo(Type other)
		{
			RuntimeType runtimeType = other as RuntimeType;
			return runtimeType != null && (runtimeType == this || RuntimeTypeHandle.IsEquivalentTo(this, runtimeType));
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00012C44 File Offset: 0x00010E44
		internal CorElementType GetCorElementType()
		{
			RuntimeType.TypeCache typeCache = this.Cache;
			if ((typeCache.Cached & 32) != 0)
			{
				return typeCache.CorElementType;
			}
			RuntimeType runtimeType = this;
			typeCache.CorElementType = RuntimeTypeHandle.GetCorElementType(new QCallTypeHandle(ref runtimeType));
			Interlocked.MemoryBarrier();
			this.UpdateCached(RuntimeType.TypeCacheEntries.CorElementType);
			return typeCache.CorElementType;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00012C94 File Offset: 0x00010E94
		internal TypeAttributes GetAttributes()
		{
			RuntimeType.TypeCache typeCache = this.Cache;
			if ((typeCache.Cached & 64) != 0)
			{
				return typeCache.TypeAttributes;
			}
			RuntimeType runtimeType = this;
			typeCache.TypeAttributes = RuntimeTypeHandle.GetAttributes(new QCallTypeHandle(ref runtimeType));
			Interlocked.MemoryBarrier();
			this.UpdateCached(RuntimeType.TypeCacheEntries.TypeAttributes);
			return typeCache.TypeAttributes;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00012CE4 File Offset: 0x00010EE4
		internal bool IsDelegate()
		{
			RuntimeType.TypeCache typeCache = this.Cache;
			if ((typeCache.Cached & 2) != 0)
			{
				return (typeCache.Flags & 2) != 0;
			}
			bool flag = this.GetBaseType() == typeof(MulticastDelegate);
			this.CacheFlag(RuntimeType.TypeCacheEntries.IsDelegate, flag);
			return flag;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00012D30 File Offset: 0x00010F30
		protected override bool IsValueTypeImpl()
		{
			RuntimeType.TypeCache typeCache = this.Cache;
			if ((typeCache.Cached & 4) != 0)
			{
				return (typeCache.Flags & 4) != 0;
			}
			bool flag = false;
			if (!(this == typeof(ValueType)) && !(this == typeof(Enum)))
			{
				flag = this.IsSubclassOf(typeof(ValueType));
			}
			this.CacheFlag(RuntimeType.TypeCacheEntries.IsValueType, flag);
			return flag;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00012D9A File Offset: 0x00010F9A
		internal bool IsActualValueType
		{
			get
			{
				return RuntimeTypeHandle.IsValueType(this);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00012DA2 File Offset: 0x00010FA2
		public override bool IsEnum
		{
			get
			{
				return this.GetBaseType() == RuntimeType.EnumType;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00012DB4 File Offset: 0x00010FB4
		internal bool IsActualEnum
		{
			get
			{
				RuntimeType.TypeCache typeCache = this.Cache;
				if ((typeCache.Cached & 8) != 0)
				{
					return (typeCache.Flags & 8) != 0;
				}
				bool flag = !this.IsGenericParameter && RuntimeTypeHandle.GetBaseType(this) == RuntimeType.EnumType;
				this.CacheFlag(RuntimeType.TypeCacheEntries.IsActualEnum, flag);
				return flag;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00012E03 File Offset: 0x00011003
		public override bool IsByRefLike
		{
			get
			{
				return RuntimeTypeHandle.IsByRefLike(this);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00012E0B File Offset: 0x0001100B
		public override bool IsConstructedGenericType
		{
			get
			{
				return this.IsGenericType && !this.IsGenericTypeDefinition;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00012E20 File Offset: 0x00011020
		public override bool IsGenericType
		{
			get
			{
				RuntimeType.TypeCache typeCache = this.Cache;
				if ((typeCache.Cached & 16) != 0)
				{
					return (typeCache.Flags & 16) != 0;
				}
				bool flag = RuntimeTypeHandle.HasInstantiation(this);
				this.CacheFlag(RuntimeType.TypeCacheEntries.IsGenericType, flag);
				return flag;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00012E60 File Offset: 0x00011060
		public override bool IsGenericTypeDefinition
		{
			get
			{
				RuntimeType.TypeCache typeCache = this.Cache;
				if ((typeCache.Cached & 1) != 0)
				{
					return (typeCache.Flags & 1) != 0;
				}
				bool flag = RuntimeTypeHandle.IsGenericTypeDefinition(this);
				this.CacheFlag(RuntimeType.TypeCacheEntries.IsGenericTypeDef, flag);
				return flag;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00012E9A File Offset: 0x0001109A
		public override Type GetGenericTypeDefinition()
		{
			if (!this.IsGenericType)
			{
				throw new InvalidOperationException(SR.InvalidOperation_NotGenericType);
			}
			return RuntimeTypeHandle.GetGenericTypeDefinition(this);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00012EB5 File Offset: 0x000110B5
		public override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				if (!this.IsGenericParameter)
				{
					throw new InvalidOperationException(SR.Arg_NotGenericParameter);
				}
				return this.GetGenericParameterAttributes();
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00012ED0 File Offset: 0x000110D0
		internal RuntimeType[] GetGenericArgumentsInternal()
		{
			RuntimeType[] result = null;
			RuntimeType runtimeType = this;
			RuntimeType.GetGenericArgumentsInternal(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<RuntimeType[]>(ref result), true);
			return result;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00012EF8 File Offset: 0x000110F8
		public override Type[] GetGenericArguments()
		{
			Type[] array = null;
			RuntimeType runtimeType = this;
			RuntimeType.GetGenericArgumentsInternal(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<Type[]>(ref array), false);
			return array ?? Type.EmptyTypes;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00012F28 File Offset: 0x00011128
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public override Type MakeGenericType(params Type[] instantiation)
		{
			ArgumentNullException.ThrowIfNull(instantiation, "instantiation");
			RuntimeType[] array = new RuntimeType[instantiation.Length];
			if (!this.IsGenericTypeDefinition)
			{
				throw new InvalidOperationException(SR.Format(SR.Arg_NotGenericTypeDefinition, this));
			}
			RuntimeType[] genericArgumentsInternal = this.GetGenericArgumentsInternal();
			if (genericArgumentsInternal.Length != instantiation.Length)
			{
				throw new ArgumentException(SR.Argument_GenericArgsCount, "instantiation");
			}
			int i = 0;
			while (i < instantiation.Length)
			{
				Type type = instantiation[i];
				if (type == null)
				{
					throw new ArgumentNullException();
				}
				RuntimeType runtimeType = type as RuntimeType;
				if (runtimeType == null)
				{
					if (type.IsSignatureType)
					{
						return Type.MakeGenericSignatureType(this, instantiation);
					}
					Type[] array2 = new Type[instantiation.Length];
					for (int j = 0; j < instantiation.Length; j++)
					{
						array2[j] = instantiation[j];
					}
					instantiation = array2;
					if (!RuntimeFeature.IsDynamicCodeSupported)
					{
						throw new PlatformNotSupportedException();
					}
					return TypeBuilderInstantiation.MakeGenericType(this, instantiation);
				}
				else
				{
					array[i] = runtimeType;
					i++;
				}
			}
			RuntimeType.SanityCheckGenericArguments(array, genericArgumentsInternal);
			Type type2 = null;
			Type[] types = array;
			RuntimeType.MakeGenericType(this, types, ObjectHandleOnStack.Create<Type>(ref type2));
			if (type2 == null)
			{
				throw new TypeLoadException();
			}
			return type2;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001303C File Offset: 0x0001123C
		public override int GenericParameterPosition
		{
			get
			{
				if (!this.IsGenericParameter)
				{
					throw new InvalidOperationException(SR.Arg_NotGenericParameter);
				}
				RuntimeType runtimeType = this;
				return RuntimeType.GetGenericParameterPosition(new QCallTypeHandle(ref runtimeType));
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000FF2A File Offset: 0x0000E12A
		public static bool operator ==(RuntimeType left, RuntimeType right)
		{
			return left == right;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0001306A File Offset: 0x0001126A
		public static bool operator !=(RuntimeType left, RuntimeType right)
		{
			return left != right;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00013074 File Offset: 0x00011274
		private void CreateInstanceCheckThis()
		{
			if (this.ContainsGenericParameters)
			{
				throw new ArgumentException(SR.Format(SR.Acc_CreateGenericEx, this));
			}
			Type rootElementType = base.GetRootElementType();
			if (rootElementType == typeof(ArgIterator))
			{
				throw new NotSupportedException(SR.Acc_CreateArgIterator);
			}
			if (rootElementType == typeof(void))
			{
				throw new NotSupportedException(SR.Acc_CreateVoid);
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000130D0 File Offset: 0x000112D0
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2082:UnrecognizedReflectionPattern", Justification = "Implementation detail of Activator that linker intrinsically recognizes")]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2085:UnrecognizedReflectionPattern", Justification = "Implementation detail of Activator that linker intrinsically recognizes")]
		internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
		{
			this.CreateInstanceCheckThis();
			object result;
			try
			{
				if (args == null)
				{
					args = Array.Empty<object>();
				}
				int num = args.Length;
				if (binder == null)
				{
					binder = Type.DefaultBinder;
				}
				bool publicOnly = (bindingAttr & BindingFlags.NonPublic) == BindingFlags.Default;
				bool wrapExceptions = (bindingAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default;
				if (num == 0 && (bindingAttr & BindingFlags.Public) != BindingFlags.Default && (bindingAttr & BindingFlags.Instance) != BindingFlags.Default && base.IsValueType)
				{
					result = this.CreateInstanceDefaultCtor(publicOnly, wrapExceptions);
				}
				else
				{
					ConstructorInfo[] constructors = this.GetConstructors(bindingAttr);
					List<MethodBase> list = new List<MethodBase>(constructors.Length);
					Type[] array = new Type[num];
					for (int i = 0; i < num; i++)
					{
						if (args[i] != null)
						{
							array[i] = args[i].GetType();
						}
					}
					for (int j = 0; j < constructors.Length; j++)
					{
						if (RuntimeType.FilterApplyConstructorInfo((RuntimeConstructorInfo)constructors[j], bindingAttr, CallingConventions.Any, array))
						{
							list.Add(constructors[j]);
						}
					}
					MethodBase[] array2 = new MethodBase[list.Count];
					list.CopyTo(array2);
					if (array2 != null && array2.Length == 0)
					{
						array2 = null;
					}
					if (array2 == null)
					{
						throw new MissingMethodException(SR.Format(SR.MissingConstructor_Name, this.FullName));
					}
					object obj = null;
					MethodBase methodBase;
					try
					{
						methodBase = binder.BindToMethod(bindingAttr, array2, ref args, null, culture, null, out obj);
					}
					catch (MissingMethodException)
					{
						methodBase = null;
					}
					if (methodBase == null)
					{
						throw new MissingMethodException(SR.Format(SR.MissingConstructor_Name, this.FullName));
					}
					if (methodBase.GetParametersAsSpan().Length == 0)
					{
						if (args.Length != 0)
						{
							throw new NotSupportedException(SR.NotSupported_CallToVarArg);
						}
						result = Activator.CreateInstance(this, true, wrapExceptions);
					}
					else
					{
						result = ((ConstructorInfo)methodBase).Invoke(bindingAttr, binder, args, culture);
						if (obj != null)
						{
							binder.ReorderArgumentArray(ref args, obj);
						}
					}
				}
			}
			catch (Exception)
			{
				throw;
			}
			return result;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000132A8 File Offset: 0x000114A8
		[DebuggerStepThrough]
		[DebuggerHidden]
		internal object CreateInstanceDefaultCtor(bool publicOnly, bool wrapExceptions)
		{
			if (this.IsByRefLike)
			{
				throw new NotSupportedException(SR.NotSupported_ByRefLike);
			}
			this.CreateInstanceCheckThis();
			return this.CreateInstanceMono(!publicOnly, wrapExceptions);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000132CE File Offset: 0x000114CE
		[DebuggerStepThrough]
		[DebuggerHidden]
		internal object CreateInstanceOfT()
		{
			return this.CreateInstanceMono(false, true);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000132D8 File Offset: 0x000114D8
		[DebuggerStepThrough]
		[DebuggerHidden]
		internal void CallDefaultStructConstructor(ref byte value)
		{
			RuntimeConstructorInfo defaultConstructor = this.GetDefaultConstructor();
			if (defaultConstructor == null)
			{
				return;
			}
			if (!defaultConstructor.IsPublic)
			{
				throw new MissingMethodException(SR.Format(SR.Arg_NoDefCTor, this));
			}
			method functionPointer = defaultConstructor.MethodHandle.GetFunctionPointer();
			if (functionPointer == (UIntPtr)0)
			{
				throw new ExecutionEngineException();
			}
			try
			{
				method system.Void_u0020(System.Byte&) = functionPointer;
				calli(System.Void(System.Byte&), ref value, system.Void_u0020(System.Byte&));
			}
			catch (Exception inner)
			{
				throw new TargetInvocationException(inner);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001334C File Offset: 0x0001154C
		internal RuntimeType.TypeCache Cache
		{
			get
			{
				RuntimeType.TypeCache result;
				if ((result = Volatile.Read<RuntimeType.TypeCache>(ref this.cache)) == null)
				{
					result = (Interlocked.CompareExchange<RuntimeType.TypeCache>(ref this.cache, new RuntimeType.TypeCache(), null) ?? this.cache);
				}
				return result;
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00013378 File Offset: 0x00011578
		private void UpdateCached(RuntimeType.TypeCacheEntries entry)
		{
			RuntimeType.TypeCache typeCache = this.Cache;
			int cached = typeCache.Cached;
			int value = cached | (int)entry;
			Interlocked.CompareExchange(ref typeCache.Cached, value, cached);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000133A4 File Offset: 0x000115A4
		private void CacheFlag(RuntimeType.TypeCacheEntries flag, bool value)
		{
			RuntimeType.TypeCache typeCache = this.Cache;
			int flags = typeCache.Flags;
			int value2 = value ? (flags | (int)flag) : flags;
			if (Interlocked.CompareExchange(ref typeCache.Flags, value2, flags) == flags)
			{
				this.UpdateCached(flag);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000133E0 File Offset: 0x000115E0
		internal RuntimeConstructorInfo GetDefaultConstructor()
		{
			RuntimeType.TypeCache typeCache = this.Cache;
			RuntimeConstructorInfo result = null;
			if ((typeCache.Cached & 128) != 0)
			{
				return typeCache.default_ctor;
			}
			RuntimeType.ListBuilder<ConstructorInfo> constructorCandidates = this.GetConstructorCandidates(null, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, CallingConventions.Any, Type.EmptyTypes, false);
			if (constructorCandidates.Count == 1)
			{
				result = (typeCache.default_ctor = (RuntimeConstructorInfo)constructorCandidates[0]);
			}
			Interlocked.MemoryBarrier();
			this.UpdateCached(RuntimeType.TypeCacheEntries.DefaultCtor);
			return result;
		}

		// Token: 0x060005B4 RID: 1460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern MemberInfo GetCorrespondingInflatedMethod(QCallTypeHandle type, MemberInfo generic);

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001344C File Offset: 0x0001164C
		internal override MethodInfo GetMethod(MethodInfo fromNoninstanciated)
		{
			ArgumentNullException.ThrowIfNull(fromNoninstanciated, "fromNoninstanciated");
			RuntimeType runtimeType = this;
			return (MethodInfo)RuntimeType.GetCorrespondingInflatedMethod(new QCallTypeHandle(ref runtimeType), fromNoninstanciated);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00013478 File Offset: 0x00011678
		internal override ConstructorInfo GetConstructor(ConstructorInfo fromNoninstanciated)
		{
			ArgumentNullException.ThrowIfNull(fromNoninstanciated, "fromNoninstanciated");
			RuntimeType runtimeType = this;
			return (ConstructorInfo)RuntimeType.GetCorrespondingInflatedMethod(new QCallTypeHandle(ref runtimeType), fromNoninstanciated);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000134A4 File Offset: 0x000116A4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2085:UnrecognizedReflectionPattern", Justification = "We already have a FieldInfo so this will succeed")]
		internal override FieldInfo GetField(FieldInfo fromNoninstanciated)
		{
			BindingFlags bindingFlags = fromNoninstanciated.IsStatic ? BindingFlags.Static : BindingFlags.Instance;
			bindingFlags |= (fromNoninstanciated.IsPublic ? BindingFlags.Public : BindingFlags.NonPublic);
			return this.GetField(fromNoninstanciated.Name, bindingFlags);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000134DC File Offset: 0x000116DC
		private string GetDefaultMemberName()
		{
			object[] customAttributes = this.GetCustomAttributes(typeof(DefaultMemberAttribute), true);
			if (customAttributes.Length == 0)
			{
				return null;
			}
			return ((DefaultMemberAttribute)customAttributes[0]).MemberName;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00013510 File Offset: 0x00011710
		private object CreateInstanceMono(bool nonPublic, bool wrapExceptions)
		{
			RuntimeConstructorInfo defaultConstructor = this.GetDefaultConstructor();
			if (!nonPublic && defaultConstructor != null && !defaultConstructor.IsPublic)
			{
				throw new MissingMethodException(SR.Format(SR.Arg_NoDefCTor, this));
			}
			if (defaultConstructor == null)
			{
				Type rootElementType = base.GetRootElementType();
				if (rootElementType == typeof(TypedReference) || rootElementType == typeof(RuntimeArgumentHandle))
				{
					throw new NotSupportedException(SR.NotSupported_ContainsStackPtr);
				}
				if (base.IsValueType)
				{
					RuntimeType runtimeType = this;
					return RuntimeType.CreateInstanceInternal(new QCallTypeHandle(ref runtimeType));
				}
				throw new MissingMethodException(SR.Format(SR.Arg_NoDefCTor, this));
			}
			else
			{
				if (base.IsAbstract)
				{
					throw new MissingMethodException(SR.Format(SR.Acc_CreateAbstEx, this));
				}
				return defaultConstructor.Invoker.InvokeWithNoArgs(null, wrapExceptions ? BindingFlags.Default : BindingFlags.DoNotWrapExceptions);
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000135D8 File Offset: 0x000117D8
		private RuntimeType.CheckValueStatus TryChangeTypeSpecial(ref object value)
		{
			if (this.IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(this);
				if (underlyingType == value.GetType())
				{
					return RuntimeType.CheckValueStatus.Success;
				}
				object obj = RuntimeType.IsConvertibleToPrimitiveType(value, underlyingType);
				if (obj != null)
				{
					value = obj;
					return RuntimeType.CheckValueStatus.Success;
				}
			}
			else if (base.IsPrimitive)
			{
				object obj2 = RuntimeType.IsConvertibleToPrimitiveType(value, this);
				if (obj2 != null)
				{
					value = obj2;
					return RuntimeType.CheckValueStatus.Success;
				}
			}
			else if (base.IsPointer)
			{
				object obj3 = value;
				bool flag = obj3 is IntPtr || obj3 is UIntPtr;
				if (flag)
				{
					return RuntimeType.CheckValueStatus.Success;
				}
				Pointer pointer = value as Pointer;
				if (pointer != null && pointer.GetPointerType() == this)
				{
					value = pointer.GetPointerValue();
					return RuntimeType.CheckValueStatus.Success;
				}
			}
			else if (this.IsFunctionPointer)
			{
				object obj3 = value;
				bool flag = obj3 is IntPtr || obj3 is UIntPtr;
				if (flag)
				{
					return RuntimeType.CheckValueStatus.Success;
				}
				value = (IntPtr)value;
				return RuntimeType.CheckValueStatus.Success;
			}
			return RuntimeType.CheckValueStatus.ArgumentException;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000136C8 File Offset: 0x000118C8
		private static object IsConvertibleToPrimitiveType(object value, Type targetType)
		{
			Type type = value.GetType();
			if (type.IsEnum)
			{
				type = Enum.GetUnderlyingType(type);
				if (type == targetType)
				{
					return value;
				}
			}
			TypeCode typeCode = Type.GetTypeCode(type);
			switch (Type.GetTypeCode(targetType))
			{
			case TypeCode.Char:
				if (typeCode == TypeCode.Byte)
				{
					return (char)((byte)value);
				}
				if (typeCode == TypeCode.UInt16)
				{
					return value;
				}
				break;
			case TypeCode.Int16:
				if (typeCode == TypeCode.SByte)
				{
					return (short)((sbyte)value);
				}
				if (typeCode == TypeCode.Byte)
				{
					return (short)((byte)value);
				}
				break;
			case TypeCode.UInt16:
				if (typeCode == TypeCode.Char)
				{
					return value;
				}
				if (typeCode == TypeCode.Byte)
				{
					return (ushort)((byte)value);
				}
				break;
			case TypeCode.Int32:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (int)((char)value);
				case TypeCode.SByte:
					return (int)((sbyte)value);
				case TypeCode.Byte:
					return (int)((byte)value);
				case TypeCode.Int16:
					return (int)((short)value);
				case TypeCode.UInt16:
					return (int)((ushort)value);
				}
				break;
			case TypeCode.UInt32:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (uint)((char)value);
				case TypeCode.Byte:
					return (uint)((byte)value);
				case TypeCode.UInt16:
					return (uint)((ushort)value);
				}
				break;
			case TypeCode.Int64:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (long)((ulong)((char)value));
				case TypeCode.SByte:
					return (long)((sbyte)value);
				case TypeCode.Byte:
					return (long)((ulong)((byte)value));
				case TypeCode.Int16:
					return (long)((short)value);
				case TypeCode.UInt16:
					return (long)((ulong)((ushort)value));
				case TypeCode.Int32:
					return (long)((int)value);
				case TypeCode.UInt32:
					return (long)((ulong)((uint)value));
				}
				break;
			case TypeCode.UInt64:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (ulong)((char)value);
				case TypeCode.Byte:
					return (ulong)((byte)value);
				case TypeCode.UInt16:
					return (ulong)((ushort)value);
				case TypeCode.UInt32:
					return (ulong)((uint)value);
				}
				break;
			case TypeCode.Single:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (float)((char)value);
				case TypeCode.SByte:
					return (float)((sbyte)value);
				case TypeCode.Byte:
					return (float)((byte)value);
				case TypeCode.Int16:
					return (float)((short)value);
				case TypeCode.UInt16:
					return (float)((ushort)value);
				case TypeCode.Int32:
					return (float)((int)value);
				case TypeCode.UInt32:
					return (uint)value;
				case TypeCode.Int64:
					return (float)((long)value);
				case TypeCode.UInt64:
					return (ulong)value;
				}
				break;
			case TypeCode.Double:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (double)((char)value);
				case TypeCode.SByte:
					return (double)((sbyte)value);
				case TypeCode.Byte:
					return (double)((byte)value);
				case TypeCode.Int16:
					return (double)((short)value);
				case TypeCode.UInt16:
					return (double)((ushort)value);
				case TypeCode.Int32:
					return (double)((int)value);
				case TypeCode.UInt32:
					return (uint)value;
				case TypeCode.Int64:
					return (double)((long)value);
				case TypeCode.UInt64:
					return (ulong)value;
				case TypeCode.Single:
					return (double)((float)value);
				}
				break;
			}
			return null;
		}

		// Token: 0x060005BC RID: 1468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void make_array_type(QCallTypeHandle type, int rank, ObjectHandleOnStack res);

		// Token: 0x060005BD RID: 1469 RVA: 0x00013A7C File Offset: 0x00011C7C
		public override Type MakeArrayType()
		{
			Type result = null;
			RuntimeType runtimeType = this;
			RuntimeType.make_array_type(new QCallTypeHandle(ref runtimeType), 0, ObjectHandleOnStack.Create<Type>(ref result));
			return result;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00013AA4 File Offset: 0x00011CA4
		public override Type MakeArrayType(int rank)
		{
			if (rank < 1)
			{
				throw new IndexOutOfRangeException();
			}
			Type result = null;
			RuntimeType runtimeType = this;
			RuntimeType.make_array_type(new QCallTypeHandle(ref runtimeType), rank, ObjectHandleOnStack.Create<Type>(ref result));
			return result;
		}

		// Token: 0x060005BF RID: 1471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void make_byref_type(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x060005C0 RID: 1472 RVA: 0x00013AD4 File Offset: 0x00011CD4
		public override Type MakeByRefType()
		{
			if (base.IsByRef)
			{
				throw new TypeLoadException(SR.Format(SR.CannotCreateByRefOfByRef, base.GetType()));
			}
			Type result = null;
			RuntimeType runtimeType = this;
			RuntimeType.make_byref_type(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<Type>(ref result));
			return result;
		}

		// Token: 0x060005C1 RID: 1473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void make_pointer_type(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x060005C2 RID: 1474 RVA: 0x00013B18 File Offset: 0x00011D18
		public override Type MakePointerType()
		{
			if (base.IsByRef)
			{
				throw new TypeLoadException(SR.Format(SR.CannotCreatePointerOfByRef, base.GetType()));
			}
			Type result = null;
			RuntimeType runtimeType = this;
			RuntimeType.make_pointer_type(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<Type>(ref result));
			return result;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00013B5B File Offset: 0x00011D5B
		public override StructLayoutAttribute StructLayoutAttribute
		{
			get
			{
				return this.GetStructLayoutAttribute();
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00013B64 File Offset: 0x00011D64
		public override bool ContainsGenericParameters
		{
			get
			{
				if (this.IsGenericParameter)
				{
					return true;
				}
				if (this.IsGenericType)
				{
					Type[] array = this.GetGenericArguments();
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].ContainsGenericParameters)
						{
							return true;
						}
					}
				}
				if (base.HasElementType)
				{
					return this.GetElementType().ContainsGenericParameters;
				}
				if (this.IsFunctionPointer)
				{
					if (this.GetFunctionPointerReturnType().ContainsGenericParameters)
					{
						return true;
					}
					Type[] array = this.GetFunctionPointerParameterTypes();
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].ContainsGenericParameters)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00013BF4 File Offset: 0x00011DF4
		public override Type[] GetGenericParameterConstraints()
		{
			if (!this.IsGenericParameter)
			{
				throw new InvalidOperationException(SR.Arg_NotGenericParameter);
			}
			RuntimeGenericParamInfoHandle runtimeGenericParamInfoHandle = new RuntimeGenericParamInfoHandle(RuntimeTypeHandle.GetGenericParameterInfo(this));
			return runtimeGenericParamInfoHandle.Constraints ?? Type.EmptyTypes;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00013C34 File Offset: 0x00011E34
		internal static object CreateInstanceForAnotherGenericParameter([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] Type genericType, RuntimeType genericArgument, RuntimeType genericArgument2 = null)
		{
			RuntimeType runtimeType = null;
			if (genericArgument2 != null)
			{
				RuntimeType.MakeGenericType(genericType, new Type[]
				{
					genericArgument,
					genericArgument2
				}, ObjectHandleOnStack.Create<RuntimeType>(ref runtimeType));
			}
			else
			{
				RuntimeType.MakeGenericType(genericType, new Type[]
				{
					genericArgument
				}, ObjectHandleOnStack.Create<RuntimeType>(ref runtimeType));
			}
			RuntimeConstructorInfo defaultConstructor = runtimeType.GetDefaultConstructor();
			if (defaultConstructor == null || !defaultConstructor.IsPublic)
			{
				throw new MissingMethodException(SR.Format(SR.Arg_NoDefCTor, runtimeType));
			}
			return defaultConstructor.Invoker.InvokeWithNoArgs(null, BindingFlags.Default);
		}

		// Token: 0x060005C7 RID: 1479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void MakeGenericType(Type gt, Type[] types, ObjectHandleOnStack res);

		// Token: 0x060005C8 RID: 1480
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr GetMethodsByName_native(QCallTypeHandle type, IntPtr namePtr, BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x060005C9 RID: 1481 RVA: 0x00013CB0 File Offset: 0x00011EB0
		internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			RuntimeType runtimeType = this;
			RuntimeTypeHandle reflectedType2 = new RuntimeTypeHandle(reflectedType);
			RuntimeMethodInfo[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(name))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(RuntimeType.GetMethodsByName_native(new QCallTypeHandle(ref runtimeType), safeStringMarshal.Value, bindingAttr, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimeMethodInfo[] array = new RuntimeMethodInfo[length];
					for (int i = 0; i < length; i++)
					{
						RuntimeMethodHandle handle = new RuntimeMethodHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimeMethodInfo)RuntimeMethodInfo.GetMethodFromHandleNoGenericCheck(handle, reflectedType2);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x060005CA RID: 1482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetPropertiesByName_native(QCallTypeHandle type, IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x060005CB RID: 1483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetConstructors_native(QCallTypeHandle type, BindingFlags bindingAttr);

		// Token: 0x060005CC RID: 1484 RVA: 0x00013D74 File Offset: 0x00011F74
		private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType)
		{
			RuntimeTypeHandle reflectedType2 = new RuntimeTypeHandle(reflectedType);
			RuntimeType runtimeType = this;
			RuntimeConstructorInfo[] result;
			using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(RuntimeType.GetConstructors_native(new QCallTypeHandle(ref runtimeType), bindingAttr)))
			{
				int length = safeGPtrArrayHandle.Length;
				RuntimeConstructorInfo[] array = new RuntimeConstructorInfo[length];
				for (int i = 0; i < length; i++)
				{
					RuntimeMethodHandle handle = new RuntimeMethodHandle(safeGPtrArrayHandle[i]);
					array[i] = (RuntimeConstructorInfo)RuntimeMethodInfo.GetMethodFromHandleNoGenericCheck(handle, reflectedType2);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00013E08 File Offset: 0x00012008
		private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			RuntimeTypeHandle reflectedType2 = new RuntimeTypeHandle(reflectedType);
			RuntimeType runtimeType = this;
			RuntimePropertyInfo[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(name))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(RuntimeType.GetPropertiesByName_native(new QCallTypeHandle(ref runtimeType), safeStringMarshal.Value, bindingAttr, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimePropertyInfo[] array = new RuntimePropertyInfo[length];
					for (int i = 0; i < length; i++)
					{
						RuntimePropertyHandle handle = new RuntimePropertyHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimePropertyInfo)RuntimePropertyInfo.GetPropertyFromHandle(handle, reflectedType2);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00013ECC File Offset: 0x000120CC
		public override InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			if (this.IsGenericParameter)
			{
				throw new InvalidOperationException(SR.Arg_GenericParameter);
			}
			ArgumentNullException.ThrowIfNull(interfaceType, "interfaceType");
			RuntimeType left = interfaceType as RuntimeType;
			if (left == null)
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType, "interfaceType");
			}
			if (!interfaceType.IsInterface)
			{
				throw new ArgumentException(SR.Arg_MustBeInterface, "interfaceType");
			}
			if (base.IsInterface)
			{
				throw new ArgumentException(SR.Argument_InterfaceMap);
			}
			RuntimeType runtimeType = this;
			InterfaceMapping interfaceMapping;
			interfaceMapping.TargetType = this;
			interfaceMapping.InterfaceType = interfaceType;
			RuntimeType.GetInterfaceMapData(new QCallTypeHandle(ref runtimeType), new QCallTypeHandle(ref left), out interfaceMapping.TargetMethods, out interfaceMapping.InterfaceMethods);
			if (interfaceMapping.TargetMethods == null)
			{
				throw new ArgumentException(SR.Arg_NotFoundIFace, "interfaceType");
			}
			return interfaceMapping;
		}

		// Token: 0x060005CF RID: 1487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetInterfaceMapData(QCallTypeHandle t, QCallTypeHandle iface, out MethodInfo[] targets, out MethodInfo[] methods);

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00013F90 File Offset: 0x00012190
		public override Guid GUID
		{
			get
			{
				object[] customAttributes = this.GetCustomAttributes(typeof(GuidAttribute), true);
				if (customAttributes.Length == 0)
				{
					return Guid.Empty;
				}
				return new Guid(((GuidAttribute)customAttributes[0]).Value);
			}
		}

		// Token: 0x060005D1 RID: 1489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetPacking(QCallTypeHandle type, out int packing, out int size);

		// Token: 0x060005D2 RID: 1490 RVA: 0x00013FCC File Offset: 0x000121CC
		internal void GetPacking(out int packing, out int size)
		{
			RuntimeType runtimeType = this;
			RuntimeType.GetPacking(new QCallTypeHandle(ref runtimeType), out packing, out size);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00013FE9 File Offset: 0x000121E9
		public override string ToString()
		{
			return this.getFullName(false, false);
		}

		// Token: 0x060005D4 RID: 1492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object CreateInstanceInternal(QCallTypeHandle type);

		// Token: 0x060005D5 RID: 1493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetDeclaringMethod(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00013FF4 File Offset: 0x000121F4
		public override MethodBase DeclaringMethod
		{
			get
			{
				RuntimeType runtimeType = this;
				MethodBase result = null;
				RuntimeType.GetDeclaringMethod(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<MethodBase>(ref result));
				return result;
			}
		}

		// Token: 0x060005D7 RID: 1495
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void getFullName(QCallTypeHandle type, ObjectHandleOnStack res, bool full_name, bool assembly_qualified);

		// Token: 0x060005D8 RID: 1496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGenericArgumentsInternal(QCallTypeHandle type, ObjectHandleOnStack res, bool runtimeArray);

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001401C File Offset: 0x0001221C
		internal string getFullName(bool full_name, bool assembly_qualified)
		{
			RuntimeType runtimeType = this;
			string result = null;
			RuntimeType.getFullName(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<string>(ref result), full_name, assembly_qualified);
			return result;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00014044 File Offset: 0x00012244
		private GenericParameterAttributes GetGenericParameterAttributes()
		{
			return new RuntimeGenericParamInfoHandle(RuntimeTypeHandle.GetGenericParameterInfo(this)).Attributes;
		}

		// Token: 0x060005DB RID: 1499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetGenericParameterPosition(QCallTypeHandle type);

		// Token: 0x060005DC RID: 1500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetEvents_native(QCallTypeHandle type, IntPtr name, RuntimeType.MemberListType listType);

		// Token: 0x060005DD RID: 1501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetFields_native(QCallTypeHandle type, IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x060005DE RID: 1502 RVA: 0x00014064 File Offset: 0x00012264
		private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			RuntimeTypeHandle declaringType = new RuntimeTypeHandle(reflectedType);
			RuntimeType runtimeType = this;
			RuntimeFieldInfo[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(name))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(RuntimeType.GetFields_native(new QCallTypeHandle(ref runtimeType), safeStringMarshal.Value, bindingAttr, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimeFieldInfo[] array = new RuntimeFieldInfo[length];
					for (int i = 0; i < length; i++)
					{
						RuntimeFieldHandle handle = new RuntimeFieldHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimeFieldInfo)FieldInfo.GetFieldFromHandle(handle, declaringType);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00014128 File Offset: 0x00012328
		private RuntimeEventInfo[] GetEvents_internal(string name, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			RuntimeTypeHandle reflectedType2 = new RuntimeTypeHandle(reflectedType);
			RuntimeType runtimeType = this;
			RuntimeEventInfo[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(name))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(RuntimeType.GetEvents_native(new QCallTypeHandle(ref runtimeType), safeStringMarshal.Value, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimeEventInfo[] array = new RuntimeEventInfo[length];
					for (int i = 0; i < length; i++)
					{
						RuntimeEventHandle handle = new RuntimeEventHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimeEventInfo)RuntimeEventInfo.GetEventFromHandle(handle, reflectedType2);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x060005E0 RID: 1504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetInterfaces(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x060005E1 RID: 1505 RVA: 0x000141E8 File Offset: 0x000123E8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type[] GetInterfaces()
		{
			RuntimeType runtimeType = this;
			Type[] result = null;
			RuntimeType.GetInterfaces(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<Type[]>(ref result));
			return result;
		}

		// Token: 0x060005E2 RID: 1506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetNestedTypes_native(QCallTypeHandle type, IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x060005E3 RID: 1507 RVA: 0x00014210 File Offset: 0x00012410
		private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			string str = null;
			if (displayName != null)
			{
				str = displayName;
			}
			RuntimeType runtimeType = this;
			RuntimeType[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(str))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(RuntimeType.GetNestedTypes_native(new QCallTypeHandle(ref runtimeType), safeStringMarshal.Value, bindingAttr, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimeType[] array = new RuntimeType[length];
					for (int i = 0; i < length; i++)
					{
						RuntimeTypeHandle handle = new RuntimeTypeHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimeType)Type.GetTypeFromHandle(handle);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000142D0 File Offset: 0x000124D0
		public override string AssemblyQualifiedName
		{
			get
			{
				return this.getFullName(true, true);
			}
		}

		// Token: 0x060005E5 RID: 1509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetDeclaringType(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000142DC File Offset: 0x000124DC
		public override Type DeclaringType
		{
			get
			{
				RuntimeType runtimeType = this;
				Type result = null;
				RuntimeType.GetDeclaringType(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<Type>(ref result));
				return result;
			}
		}

		// Token: 0x060005E7 RID: 1511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetName(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00014304 File Offset: 0x00012504
		public override string Name
		{
			get
			{
				RuntimeType runtimeType = this;
				string result = null;
				RuntimeType.GetName(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<string>(ref result));
				return result;
			}
		}

		// Token: 0x060005E9 RID: 1513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetNamespace(QCallTypeHandle type, ObjectHandleOnStack res);

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0001432C File Offset: 0x0001252C
		public override string Namespace
		{
			get
			{
				RuntimeType runtimeType = this;
				string result = null;
				RuntimeType.GetNamespace(new QCallTypeHandle(ref runtimeType), ObjectHandleOnStack.Create<string>(ref result));
				return result;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00014354 File Offset: 0x00012554
		public override string FullName
		{
			get
			{
				if (this.ContainsGenericParameters && !base.GetRootElementType().IsGenericTypeDefinition)
				{
					return null;
				}
				RuntimeType.TypeCache typeCache = this.Cache;
				string result;
				if ((result = typeCache.full_name) == null)
				{
					result = (typeCache.full_name = this.getFullName(true, false));
				}
				return result;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001439C File Offset: 0x0001259C
		public sealed override bool HasSameMetadataDefinitionAs(MemberInfo other)
		{
			return base.HasSameMetadataDefinitionAsCore<RuntimeType>(other);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000143A5 File Offset: 0x000125A5
		internal bool IsNullableOfT
		{
			get
			{
				return Nullable.GetUnderlyingType(this) != null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x000143B3 File Offset: 0x000125B3
		public override bool IsSZArray
		{
			get
			{
				return RuntimeTypeHandle.IsSzArray(this);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000143BB File Offset: 0x000125BB
		public override bool IsFunctionPointer
		{
			get
			{
				return RuntimeTypeHandle.IsFunctionPointer(this);
			}
		}

		// Token: 0x060005F0 RID: 1520
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsUnmanagedFunctionPointerInternal(QCallTypeHandle type);

		// Token: 0x060005F1 RID: 1521 RVA: 0x000143C3 File Offset: 0x000125C3
		internal static bool IsUnmanagedFunctionPointerInternal(RuntimeType type)
		{
			return RuntimeType.IsUnmanagedFunctionPointerInternal(new QCallTypeHandle(ref type));
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x000143D1 File Offset: 0x000125D1
		public override bool IsUnmanagedFunctionPointer
		{
			get
			{
				return RuntimeType.IsUnmanagedFunctionPointerInternal(this);
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000143DC File Offset: 0x000125DC
		public override Type[] GetFunctionPointerParameterTypes()
		{
			Type[] array = RuntimeType.FunctionPointerReturnAndParameterTypes(this, false);
			if (array.Length != 0)
			{
				return array;
			}
			return Type.EmptyTypes;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000143FC File Offset: 0x000125FC
		public override Type GetFunctionPointerReturnType()
		{
			return RuntimeType.FunctionPointerReturnAndParameterTypes(this, true)[0];
		}

		// Token: 0x060005F5 RID: 1525
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr FunctionPointerReturnAndParameterTypes(QCallTypeHandle type);

		// Token: 0x060005F6 RID: 1526 RVA: 0x00014408 File Offset: 0x00012608
		internal static Type[] FunctionPointerReturnAndParameterTypes(RuntimeType type, bool returnType)
		{
			if (!RuntimeTypeHandle.IsFunctionPointer(type))
			{
				throw new InvalidOperationException(SR.InvalidOperation_NotFunctionPointer);
			}
			Type[] result;
			using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(RuntimeType.FunctionPointerReturnAndParameterTypes(new QCallTypeHandle(ref type))))
			{
				int num = returnType ? 1 : (safeGPtrArrayHandle.Length - 1);
				Type[] array = new Type[num];
				if (returnType)
				{
					RuntimeTypeHandle handle = new RuntimeTypeHandle(safeGPtrArrayHandle[0]);
					array[0] = (RuntimeType)Type.GetTypeFromHandle(handle);
				}
				else
				{
					for (int i = 1; i < num + 1; i++)
					{
						RuntimeTypeHandle handle2 = new RuntimeTypeHandle(safeGPtrArrayHandle[i]);
						array[i - 1] = (RuntimeType)Type.GetTypeFromHandle(handle2);
					}
				}
				result = array;
			}
			return result;
		}

		// Token: 0x060005F7 RID: 1527
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Type[] GetFunctionPointerTypeModifiers(QCallTypeHandle type, int position, bool optional);

		// Token: 0x060005F8 RID: 1528 RVA: 0x000144D0 File Offset: 0x000126D0
		internal static Type[] GetFunctionPointerTypeModifiers(RuntimeType type, int position, bool optional)
		{
			return RuntimeType.GetFunctionPointerTypeModifiers(new QCallTypeHandle(ref type), position, optional) ?? Type.EmptyTypes;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000144E9 File Offset: 0x000126E9
		public Type[] GetCustomModifiersFromFunctionPointer(int position, bool optional)
		{
			return RuntimeType.GetFunctionPointerTypeModifiers(this, position, optional);
		}

		// Token: 0x060005FA RID: 1530
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern byte GetCallingConventionFromFunctionPointerInternal(QCallTypeHandle type);

		// Token: 0x060005FB RID: 1531 RVA: 0x000144F3 File Offset: 0x000126F3
		internal static byte GetCallingConventionFromFunctionPointerInternal(RuntimeType type)
		{
			return RuntimeType.GetCallingConventionFromFunctionPointerInternal(new QCallTypeHandle(ref type));
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00014501 File Offset: 0x00012701
		public SignatureCallingConvention GetCallingConventionFromFunctionPointer()
		{
			return (SignatureCallingConvention)RuntimeType.GetCallingConventionFromFunctionPointerInternal(this);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00014509 File Offset: 0x00012709
		public override Type[] GetFunctionPointerCallingConventions()
		{
			if (!RuntimeTypeHandle.IsFunctionPointer(this))
			{
				throw new InvalidOperationException(SR.InvalidOperation_NotFunctionPointer);
			}
			return Type.EmptyTypes;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x00007B65 File Offset: 0x00005D65
		internal override bool IsUserType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00014524 File Offset: 0x00012724
		public override bool IsSubclassOf(Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			RuntimeType runtimeType = type as RuntimeType;
			return !(runtimeType == null) && RuntimeTypeHandle.IsSubclassOf(this, runtimeType);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00014558 File Offset: 0x00012758
		internal StructLayoutAttribute GetStructLayoutAttribute()
		{
			if (base.IsInterface || base.HasElementType || this.IsGenericParameter)
			{
				return null;
			}
			LayoutKind layoutKind = LayoutKind.Auto;
			TypeAttributes typeAttributes = base.Attributes & TypeAttributes.LayoutMask;
			if (typeAttributes != TypeAttributes.NotPublic)
			{
				if (typeAttributes != TypeAttributes.SequentialLayout)
				{
					if (typeAttributes == TypeAttributes.ExplicitLayout)
					{
						layoutKind = LayoutKind.Explicit;
					}
				}
				else
				{
					layoutKind = LayoutKind.Sequential;
				}
			}
			else
			{
				layoutKind = LayoutKind.Auto;
			}
			CharSet charSet = CharSet.None;
			typeAttributes = (base.Attributes & TypeAttributes.StringFormatMask);
			if (typeAttributes != TypeAttributes.NotPublic)
			{
				if (typeAttributes != TypeAttributes.UnicodeClass)
				{
					if (typeAttributes == TypeAttributes.AutoClass)
					{
						charSet = CharSet.Auto;
					}
				}
				else
				{
					charSet = CharSet.Unicode;
				}
			}
			else
			{
				charSet = CharSet.Ansi;
			}
			int pack;
			int size;
			this.GetPacking(out pack, out size);
			return new StructLayoutAttribute(layoutKind)
			{
				Pack = pack,
				Size = size,
				CharSet = charSet
			};
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x000145FC File Offset: 0x000127FC
		public override Assembly Assembly
		{
			get
			{
				return RuntimeTypeHandle.GetAssembly(this);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00014604 File Offset: 0x00012804
		public override Type BaseType
		{
			get
			{
				return this.GetBaseType();
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001460C File Offset: 0x0001280C
		public override bool IsGenericParameter
		{
			get
			{
				return RuntimeTypeHandle.IsGenericVariable(this);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00014614 File Offset: 0x00012814
		public override bool IsTypeDefinition
		{
			get
			{
				return RuntimeTypeHandle.IsTypeDefinition(this);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsSecurityCritical
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsSecuritySafeCritical
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsSecurityTransparent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001461C File Offset: 0x0001281C
		public override MemberTypes MemberType
		{
			get
			{
				if (!base.IsPublic && !base.IsNotPublic)
				{
					return MemberTypes.NestedType;
				}
				return MemberTypes.TypeInfo;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00014636 File Offset: 0x00012836
		public override int MetadataToken
		{
			get
			{
				return RuntimeTypeHandle.GetToken(this);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001463E File Offset: 0x0001283E
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00014646 File Offset: 0x00012846
		public override Type ReflectedType
		{
			get
			{
				return this.DeclaringType;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0001464E File Offset: 0x0001284E
		public override RuntimeTypeHandle TypeHandle
		{
			[Intrinsic]
			get
			{
				return new RuntimeTypeHandle(this);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00007B62 File Offset: 0x00005D62
		public override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00007B62 File Offset: 0x00005D62
		public object Clone()
		{
			return this;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00014656 File Offset: 0x00012856
		public override bool Equals(object obj)
		{
			return obj == this;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001465C File Offset: 0x0001285C
		public override int GetArrayRank()
		{
			if (!this.IsArrayImpl())
			{
				throw new ArgumentException(SR.Argument_HasToBeArrayClass);
			}
			return RuntimeTypeHandle.GetArrayRank(this);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00014677 File Offset: 0x00012877
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return RuntimeTypeHandle.GetAttributes(this);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001467F File Offset: 0x0001287F
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, RuntimeType.ObjectType, inherit);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00014690 File Offset: 0x00012890
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Arg_MustBeType, "attributeType");
			}
			return CustomAttribute.GetCustomAttributes(this, runtimeType, inherit);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000146CF File Offset: 0x000128CF
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return RuntimeCustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000146D8 File Offset: 0x000128D8
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)2731)]
		public override MemberInfo[] GetDefaultMembers()
		{
			MemberInfo[] array = null;
			string defaultMemberName = this.GetDefaultMemberName();
			if (defaultMemberName != null)
			{
				array = base.GetMember(defaultMemberName);
			}
			return array ?? Array.Empty<MemberInfo>();
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00014703 File Offset: 0x00012903
		public override Type GetElementType()
		{
			return RuntimeTypeHandle.GetElementType(this);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001470C File Offset: 0x0001290C
		public override string GetEnumName(object value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			RuntimeType runtimeType = (RuntimeType)value.GetType();
			if (!runtimeType.IsActualEnum && !Type.IsIntegerType(runtimeType))
			{
				throw new ArgumentException(SR.Arg_MustBeEnumBaseTypeOrEnum, "value");
			}
			return Enum.GetName(this, Enum.ToUInt64(value));
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001475C File Offset: 0x0001295C
		private static void ThrowMustBeEnum()
		{
			throw new ArgumentException(SR.Arg_MustBeEnum, "enumType");
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00014770 File Offset: 0x00012970
		public override string[] GetEnumNames()
		{
			if (!this.IsActualEnum)
			{
				RuntimeType.ThrowMustBeEnum();
			}
			return new ReadOnlySpan<string>(Enum.GetNamesNoCopy(this)).ToArray();
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000147A0 File Offset: 0x000129A0
		[RequiresDynamicCode("It might not be possible to create an array of the enum type at runtime. Use Enum.GetValues<T> or the GetEnumValuesAsUnderlyingType method instead.")]
		public override Array GetEnumValues()
		{
			if (!this.IsActualEnum)
			{
				RuntimeType.ThrowMustBeEnum();
			}
			Array valuesAsUnderlyingTypeNoCopy = Enum.GetValuesAsUnderlyingTypeNoCopy(this);
			Array array = Array.CreateInstance(this, valuesAsUnderlyingTypeNoCopy.Length);
			Array.Copy(valuesAsUnderlyingTypeNoCopy, array, valuesAsUnderlyingTypeNoCopy.Length);
			return array;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000147DC File Offset: 0x000129DC
		public override Array GetEnumValuesAsUnderlyingType()
		{
			if (!this.IsActualEnum)
			{
				RuntimeType.ThrowMustBeEnum();
			}
			return Enum.GetValuesAsUnderlyingType(this);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000147F1 File Offset: 0x000129F1
		public override Type GetEnumUnderlyingType()
		{
			if (!this.IsActualEnum)
			{
				RuntimeType.ThrowMustBeEnum();
			}
			return Enum.InternalGetUnderlyingType(this);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000FF47 File Offset: 0x0000E147
		public override int GetHashCode()
		{
			return RuntimeHelpers.GetHashCode(this);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00014806 File Offset: 0x00012A06
		internal RuntimeModule GetRuntimeModule()
		{
			return RuntimeTypeHandle.GetModule(this);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00014810 File Offset: 0x00012A10
		protected override TypeCode GetTypeCodeImpl()
		{
			TypeCode typeCode = this.Cache.TypeCode;
			if (typeCode != TypeCode.Empty)
			{
				return typeCode;
			}
			typeCode = Type.GetRuntimeTypeCode(this);
			this.Cache.TypeCode = typeCode;
			return typeCode;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00014842 File Offset: 0x00012A42
		protected override bool HasElementTypeImpl()
		{
			return RuntimeTypeHandle.HasElementType(this);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001484A File Offset: 0x00012A4A
		protected override bool IsArrayImpl()
		{
			return RuntimeTypeHandle.IsArray(this);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsContextfulImpl()
		{
			return false;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00014854 File Offset: 0x00012A54
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Arg_MustBeType, "attributeType");
			}
			return CustomAttribute.IsDefined(this, runtimeType, inherit);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00014894 File Offset: 0x00012A94
		public override bool IsEnumDefined(object value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			if (!this.IsActualEnum)
			{
				RuntimeType.ThrowMustBeEnum();
			}
			RuntimeType runtimeType = (RuntimeType)value.GetType();
			if (runtimeType.IsActualEnum)
			{
				if (!runtimeType.IsEquivalentTo(this))
				{
					throw new ArgumentException(SR.Format(SR.Arg_EnumAndObjectMustBeSameType, runtimeType, this));
				}
				runtimeType = (RuntimeType)runtimeType.GetEnumUnderlyingType();
			}
			if (runtimeType == RuntimeType.StringType)
			{
				return Array.IndexOf<string>(Enum.GetNamesNoCopy(this), (string)value) >= 0;
			}
			if (!Type.IsIntegerType(runtimeType))
			{
				throw new InvalidOperationException(SR.InvalidOperation_UnknownEnumType);
			}
			RuntimeType runtimeType2 = Enum.InternalGetUnderlyingType(this);
			if (runtimeType2 != runtimeType)
			{
				throw new ArgumentException(SR.Format(SR.Arg_EnumUnderlyingTypeAndObjectMustBeSameType, runtimeType, runtimeType2));
			}
			bool result;
			switch (Type.GetTypeCode(runtimeType2))
			{
			case TypeCode.Char:
				result = Enum.IsDefinedPrimitive<char>(this, (char)value);
				break;
			case TypeCode.SByte:
				result = Enum.IsDefinedPrimitive<byte>(this, (byte)((sbyte)value));
				break;
			case TypeCode.Byte:
				result = Enum.IsDefinedPrimitive<byte>(this, (byte)value);
				break;
			case TypeCode.Int16:
				result = Enum.IsDefinedPrimitive<ushort>(this, (ushort)((short)value));
				break;
			case TypeCode.UInt16:
				result = Enum.IsDefinedPrimitive<ushort>(this, (ushort)value);
				break;
			case TypeCode.Int32:
				result = Enum.IsDefinedPrimitive<uint>(this, (uint)((int)value));
				break;
			case TypeCode.UInt32:
				result = Enum.IsDefinedPrimitive<uint>(this, (uint)value);
				break;
			case TypeCode.Int64:
				result = Enum.IsDefinedPrimitive<ulong>(this, (ulong)((long)value));
				break;
			case TypeCode.UInt64:
				result = Enum.IsDefinedPrimitive<ulong>(this, (ulong)value);
				break;
			case TypeCode.Single:
				result = Enum.IsDefinedPrimitive<float>(this, (float)value);
				break;
			case TypeCode.Double:
				result = Enum.IsDefinedPrimitive<double>(this, (double)value);
				break;
			default:
			{
				bool flag;
				if (!(runtimeType2 == typeof(IntPtr)))
				{
					if (!(runtimeType2 == typeof(UIntPtr)))
					{
						throw new InvalidOperationException(SR.InvalidOperation_UnknownEnumType);
					}
					flag = Enum.IsDefinedPrimitive<UIntPtr>(this, (UIntPtr)value);
				}
				else
				{
					flag = Enum.IsDefinedPrimitive<UIntPtr>(this, (UIntPtr)((IntPtr)value));
				}
				result = flag;
				break;
			}
			}
			return result;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00014A95 File Offset: 0x00012C95
		protected override bool IsByRefImpl()
		{
			return RuntimeTypeHandle.IsByRef(this);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00014A9D File Offset: 0x00012C9D
		protected override bool IsPrimitiveImpl()
		{
			return RuntimeTypeHandle.IsPrimitive(this);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00014AA5 File Offset: 0x00012CA5
		protected override bool IsPointerImpl()
		{
			return RuntimeTypeHandle.IsPointer(this);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00014AAD File Offset: 0x00012CAD
		protected override bool IsCOMObjectImpl()
		{
			return RuntimeTypeHandle.IsComObject(this, false);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00014AB6 File Offset: 0x00012CB6
		public override bool IsInstanceOfType([NotNullWhen(true)] object o)
		{
			return RuntimeTypeHandle.IsInstanceOfType(this, o);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00014ABF File Offset: 0x00012CBF
		public override bool IsAssignableFrom([NotNullWhen(true)] TypeInfo typeInfo)
		{
			return typeInfo != null && this.IsAssignableFrom(typeInfo.AsType());
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00014AD8 File Offset: 0x00012CD8
		public override bool IsAssignableFrom([NotNullWhen(true)] Type c)
		{
			if (c == null)
			{
				return false;
			}
			if (c == this)
			{
				return true;
			}
			RuntimeType runtimeType = c.UnderlyingSystemType as RuntimeType;
			if (runtimeType != null)
			{
				return RuntimeTypeHandle.CanCastTo(runtimeType, this);
			}
			if (c is TypeBuilder)
			{
				if (c.IsSubclassOf(this))
				{
					return true;
				}
				if (base.IsInterface)
				{
					return c.ImplementInterface(this);
				}
				if (this.IsGenericParameter)
				{
					Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
					for (int i = 0; i < genericParameterConstraints.Length; i++)
					{
						if (!genericParameterConstraints[i].IsAssignableFrom(c))
						{
							return false;
						}
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00014B58 File Offset: 0x00012D58
		[DebuggerStepThrough]
		[DebuggerHidden]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams)
		{
			if (this.IsGenericParameter)
			{
				throw new InvalidOperationException(SR.Arg_GenericParameter);
			}
			if ((bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty)) == BindingFlags.Default)
			{
				throw new ArgumentException(SR.Arg_NoAccessSpec, "bindingFlags");
			}
			if ((bindingFlags & (BindingFlags)255) == BindingFlags.Default)
			{
				bindingFlags |= (BindingFlags.Instance | BindingFlags.Public);
				if ((bindingFlags & BindingFlags.CreateInstance) == BindingFlags.Default)
				{
					bindingFlags |= BindingFlags.Static;
				}
			}
			if (namedParams != null)
			{
				if (providedArgs != null)
				{
					if (namedParams.Length > providedArgs.Length)
					{
						throw new ArgumentException(SR.Arg_NamedParamTooBig, "namedParams");
					}
				}
				else if (namedParams.Length != 0)
				{
					throw new ArgumentException(SR.Arg_NamedParamTooBig, "namedParams");
				}
			}
			if (namedParams != null && Array.IndexOf<string>(namedParams, null) >= 0)
			{
				throw new ArgumentException(SR.Arg_NamedParamNull, "namedParams");
			}
			int num = (providedArgs != null) ? providedArgs.Length : 0;
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			if ((bindingFlags & BindingFlags.CreateInstance) != BindingFlags.Default)
			{
				if ((bindingFlags & BindingFlags.CreateInstance) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty)) != BindingFlags.Default)
				{
					throw new ArgumentException(SR.Arg_CreatInstAccess, "bindingFlags");
				}
				return Activator.CreateInstance(this, bindingFlags, binder, providedArgs, culture);
			}
			else
			{
				if ((bindingFlags & (BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty)) != BindingFlags.Default)
				{
					bindingFlags |= BindingFlags.SetProperty;
				}
				ArgumentNullException.ThrowIfNull(name, "name");
				if (name.Length == 0 || name.Equals("[DISPID=0]"))
				{
					name = (this.GetDefaultMemberName() ?? "ToString");
				}
				bool flag = (bindingFlags & BindingFlags.GetField) > BindingFlags.Default;
				bool flag2 = (bindingFlags & BindingFlags.SetField) > BindingFlags.Default;
				if (flag || flag2)
				{
					if (flag)
					{
						if (flag2)
						{
							throw new ArgumentException(SR.Arg_FldSetGet, "bindingFlags");
						}
						if ((bindingFlags & BindingFlags.SetProperty) != BindingFlags.Default)
						{
							throw new ArgumentException(SR.Arg_FldGetPropSet, "bindingFlags");
						}
					}
					else
					{
						ArgumentNullException.ThrowIfNull(providedArgs, "providedArgs");
						if ((bindingFlags & BindingFlags.GetProperty) != BindingFlags.Default)
						{
							throw new ArgumentException(SR.Arg_FldSetPropGet, "bindingFlags");
						}
						if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default)
						{
							throw new ArgumentException(SR.Arg_FldSetInvoke, "bindingFlags");
						}
					}
					FieldInfo fieldInfo = null;
					FieldInfo[] array = this.GetMember(name, MemberTypes.Field, bindingFlags) as FieldInfo[];
					if (array.Length == 1)
					{
						fieldInfo = array[0];
					}
					else if (array.Length != 0)
					{
						fieldInfo = binder.BindToField(bindingFlags, array, flag ? Empty.Value : providedArgs[0], culture);
					}
					if (fieldInfo != null)
					{
						if (fieldInfo.FieldType.IsArray || fieldInfo.FieldType == typeof(Array))
						{
							int num2;
							if ((bindingFlags & BindingFlags.GetField) != BindingFlags.Default)
							{
								num2 = num;
							}
							else
							{
								num2 = num - 1;
							}
							if (num2 > 0)
							{
								int[] array2 = new int[num2];
								for (int i = 0; i < num2; i++)
								{
									try
									{
										array2[i] = ((IConvertible)providedArgs[i]).ToInt32(null);
									}
									catch (InvalidCastException)
									{
										throw new ArgumentException(SR.Arg_IndexMustBeInt);
									}
								}
								Array array3 = (Array)fieldInfo.GetValue(target);
								if ((bindingFlags & BindingFlags.GetField) != BindingFlags.Default)
								{
									return array3.GetValue(array2);
								}
								array3.SetValue(providedArgs[num2], array2);
								return null;
							}
						}
						if (flag)
						{
							if (num != 0)
							{
								throw new ArgumentException(SR.Arg_FldGetArgErr, "bindingFlags");
							}
							return fieldInfo.GetValue(target);
						}
						else
						{
							if (num != 1)
							{
								throw new ArgumentException(SR.Arg_FldSetArgErr, "bindingFlags");
							}
							fieldInfo.SetValue(target, providedArgs[0], bindingFlags, binder, culture);
							return null;
						}
					}
					else if ((bindingFlags & (BindingFlags)16773888) == BindingFlags.Default)
					{
						throw new MissingFieldException(this.FullName, name);
					}
				}
				bool flag3 = (bindingFlags & BindingFlags.GetProperty) > BindingFlags.Default;
				bool flag4 = (bindingFlags & BindingFlags.SetProperty) > BindingFlags.Default;
				if (flag3 || flag4)
				{
					if (flag3)
					{
						if (flag4)
						{
							throw new ArgumentException(SR.Arg_PropSetGet, "bindingFlags");
						}
					}
					else if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default)
					{
						throw new ArgumentException(SR.Arg_PropSetInvoke, "bindingFlags");
					}
				}
				MethodInfo[] array4 = null;
				MethodInfo methodInfo = null;
				if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default)
				{
					MethodInfo[] array5 = this.GetMember(name, MemberTypes.Method, bindingFlags) as MethodInfo[];
					List<MethodInfo> list = null;
					foreach (MethodInfo methodInfo2 in array5)
					{
						if (RuntimeType.FilterApplyMethodInfo((RuntimeMethodInfo)methodInfo2, bindingFlags, CallingConventions.Any, new Type[num]))
						{
							if (methodInfo == null)
							{
								methodInfo = methodInfo2;
							}
							else
							{
								if (list == null)
								{
									list = new List<MethodInfo>(array5.Length)
									{
										methodInfo
									};
								}
								list.Add(methodInfo2);
							}
						}
					}
					if (list != null)
					{
						array4 = list.ToArray();
					}
				}
				if ((methodInfo == null && flag3) || flag4)
				{
					PropertyInfo[] array6 = this.GetMember(name, MemberTypes.Property, bindingFlags) as PropertyInfo[];
					List<MethodInfo> list2 = null;
					for (int k = 0; k < array6.Length; k++)
					{
						MethodInfo methodInfo3;
						if (flag4)
						{
							methodInfo3 = array6[k].GetSetMethod(true);
						}
						else
						{
							methodInfo3 = array6[k].GetGetMethod(true);
						}
						if (!(methodInfo3 == null) && RuntimeType.FilterApplyMethodInfo((RuntimeMethodInfo)methodInfo3, bindingFlags, CallingConventions.Any, new Type[num]))
						{
							if (methodInfo == null)
							{
								methodInfo = methodInfo3;
							}
							else
							{
								if (list2 == null)
								{
									list2 = new List<MethodInfo>(array6.Length)
									{
										methodInfo
									};
								}
								list2.Add(methodInfo3);
							}
						}
					}
					if (list2 != null)
					{
						array4 = list2.ToArray();
					}
				}
				if (!(methodInfo != null))
				{
					throw new MissingMethodException(this.FullName, name);
				}
				if (array4 == null && num == 0 && methodInfo.GetParametersAsSpan().Length == 0 && (bindingFlags & BindingFlags.OptionalParamBinding) == BindingFlags.Default)
				{
					return methodInfo.Invoke(target, bindingFlags, binder, providedArgs, culture);
				}
				if (array4 == null)
				{
					array4 = new MethodInfo[]
					{
						methodInfo
					};
				}
				if (providedArgs == null)
				{
					providedArgs = Array.Empty<object>();
				}
				object obj = null;
				MethodBase methodBase = null;
				try
				{
					Binder binder2 = binder;
					BindingFlags bindingAttr = bindingFlags;
					MethodBase[] match = array4;
					methodBase = binder2.BindToMethod(bindingAttr, match, ref providedArgs, modifiers, culture, namedParams, out obj);
				}
				catch (MissingMethodException)
				{
				}
				if (methodBase == null)
				{
					throw new MissingMethodException(this.FullName, name);
				}
				object result = ((MethodInfo)methodBase).Invoke(target, bindingFlags, binder, providedArgs, culture);
				if (obj != null)
				{
					binder.ReorderArgumentArray(ref providedArgs, obj);
				}
				return result;
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x000150F8 File Offset: 0x000132F8
		private RuntimeType GetBaseType()
		{
			if (base.IsInterface)
			{
				return null;
			}
			if (RuntimeTypeHandle.IsGenericVariable(this))
			{
				Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
				RuntimeType runtimeType = RuntimeType.ObjectType;
				foreach (RuntimeType runtimeType2 in genericParameterConstraints)
				{
					if (!runtimeType2.IsInterface)
					{
						if (runtimeType2.IsGenericParameter)
						{
							GenericParameterAttributes genericParameterAttributes = runtimeType2.GenericParameterAttributes;
							if ((genericParameterAttributes & GenericParameterAttributes.ReferenceTypeConstraint) == GenericParameterAttributes.None && (genericParameterAttributes & GenericParameterAttributes.NotNullableValueTypeConstraint) == GenericParameterAttributes.None)
							{
								goto IL_52;
							}
						}
						runtimeType = runtimeType2;
					}
					IL_52:;
				}
				if (runtimeType == RuntimeType.ObjectType && (this.GenericParameterAttributes & GenericParameterAttributes.NotNullableValueTypeConstraint) != GenericParameterAttributes.None)
				{
					runtimeType = RuntimeType.ValueType;
				}
				return runtimeType;
			}
			return RuntimeTypeHandle.GetBaseType(this);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00015186 File Offset: 0x00013386
		private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type)
		{
			if (type.IsPointer || type.IsFunctionPointer || type.IsByRef || type == typeof(void))
			{
				throw new ArgumentException(SR.Format(SR.Argument_NeverValidGenericArgument, type));
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000151C4 File Offset: 0x000133C4
		internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParameters)
		{
			ArgumentNullException.ThrowIfNull(genericArguments, "genericArguments");
			for (int i = 0; i < genericArguments.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(genericArguments[i], null);
				RuntimeType.ThrowIfTypeNeverValidGenericArgument(genericArguments[i]);
			}
			if (genericArguments.Length != genericParameters.Length)
			{
				throw new ArgumentException(SR.Format(SR.Argument_NotEnoughGenArguments, genericArguments.Length, genericParameters.Length));
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00015223 File Offset: 0x00013423
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetByRefElementType(RuntimeType type, [NotNullWhen(true)] out RuntimeType elementType)
		{
			if (RuntimeTypeHandle.GetCorElementType(type) == CorElementType.ELEMENT_TYPE_BYREF)
			{
				elementType = RuntimeTypeHandle.GetElementType(type);
				return true;
			}
			elementType = null;
			return false;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00015240 File Offset: 0x00013440
		internal bool CheckValue(ref object value)
		{
			if (this.IsInstanceOfType(value))
			{
				if (this.IsNullableOfT)
				{
					value = RuntimeMethodHandle.ReboxToNullable(value, this);
					return true;
				}
				return false;
			}
			else
			{
				bool result = false;
				RuntimeType.CheckValueStatus checkValueStatus = this.TryChangeType(ref value, ref result);
				if (checkValueStatus == RuntimeType.CheckValueStatus.Success)
				{
					return result;
				}
				if (checkValueStatus == RuntimeType.CheckValueStatus.ArgumentException)
				{
					string arg_ObjObjEx = SR.Arg_ObjObjEx;
					object obj = value;
					throw new ArgumentException(SR.Format(arg_ObjObjEx, (obj != null) ? obj.GetType() : null, this));
				}
				if (checkValueStatus != RuntimeType.CheckValueStatus.NotSupported_ByRefLike)
				{
					return false;
				}
				throw new NotSupportedException(SR.NotSupported_ByRefLike);
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000152B4 File Offset: 0x000134B4
		internal bool CheckValue(ref object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr)
		{
			if (this.IsInstanceOfType(value))
			{
				if (this.IsNullableOfT)
				{
					value = RuntimeMethodHandle.ReboxToNullable(value, this);
					return true;
				}
				return false;
			}
			else
			{
				bool result = false;
				RuntimeType.CheckValueStatus checkValueStatus = this.TryChangeType(ref value, ref result);
				if (checkValueStatus == RuntimeType.CheckValueStatus.Success)
				{
					return result;
				}
				if (checkValueStatus == RuntimeType.CheckValueStatus.ArgumentException && (invokeAttr & BindingFlags.ExactBinding) == BindingFlags.Default && binder != null && binder != Type.DefaultBinder)
				{
					value = binder.ChangeType(value, this, culture);
					if (this.IsInstanceOfType(value))
					{
						if (this.IsNullableOfT)
						{
							value = RuntimeMethodHandle.ReboxToNullable(value, this);
						}
						return true;
					}
					checkValueStatus = this.TryChangeType(ref value, ref result);
					if (checkValueStatus == RuntimeType.CheckValueStatus.Success)
					{
						return result;
					}
				}
				if (checkValueStatus == RuntimeType.CheckValueStatus.ArgumentException)
				{
					string arg_ObjObjEx = SR.Arg_ObjObjEx;
					object obj = value;
					throw new ArgumentException(SR.Format(arg_ObjObjEx, (obj != null) ? obj.GetType() : null, this));
				}
				if (checkValueStatus != RuntimeType.CheckValueStatus.NotSupported_ByRefLike)
				{
					return false;
				}
				throw new NotSupportedException(SR.NotSupported_ByRefLike);
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00015379 File Offset: 0x00013579
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2067:UnrecognizedReflectionPattern", Justification = "AllocateValueType is only called on a ValueType. You can always create an instance of a ValueType.")]
		[return: NotNullIfNotNull("value")]
		internal static object AllocateValueType(RuntimeType type, object value)
		{
			if (value != null)
			{
				return RuntimeHelpers.Box(value.GetRawData(), type.TypeHandle);
			}
			if (type.IsNullableOfT)
			{
				return RuntimeMethodHandle.ReboxToNullable(null, type);
			}
			return RuntimeHelpers.GetUninitializedObject(type);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000153A8 File Offset: 0x000135A8
		private RuntimeType.CheckValueStatus TryChangeType(ref object value, ref bool copyBack)
		{
			RuntimeType runtimeType;
			if (RuntimeType.TryGetByRefElementType(this, out runtimeType))
			{
				copyBack = true;
				if (runtimeType.IsInstanceOfType(value))
				{
					if (runtimeType.IsActualValueType)
					{
						if (runtimeType.IsNullableOfT)
						{
							value = RuntimeMethodHandle.ReboxToNullable(value, runtimeType);
						}
						else
						{
							value = RuntimeType.AllocateValueType(runtimeType, value);
						}
					}
					return RuntimeType.CheckValueStatus.Success;
				}
				if (value != null)
				{
					return RuntimeType.CheckValueStatus.ArgumentException;
				}
				if (!runtimeType.IsActualValueType)
				{
					return RuntimeType.CheckValueStatus.Success;
				}
				if (runtimeType.IsByRefLike)
				{
					return RuntimeType.CheckValueStatus.NotSupported_ByRefLike;
				}
				value = RuntimeType.AllocateValueType(runtimeType, null);
				return RuntimeType.CheckValueStatus.Success;
			}
			else if (value == null)
			{
				if (base.IsPointer || this.IsFunctionPointer)
				{
					value = (IntPtr)0;
					return RuntimeType.CheckValueStatus.Success;
				}
				if (!this.IsActualValueType)
				{
					return RuntimeType.CheckValueStatus.Success;
				}
				if (this.IsByRefLike)
				{
					return RuntimeType.CheckValueStatus.NotSupported_ByRefLike;
				}
				value = RuntimeType.AllocateValueType(this, null);
				return RuntimeType.CheckValueStatus.Success;
			}
			else
			{
				if (base.IsPointer || this.IsEnum || base.IsPrimitive || this.IsFunctionPointer)
				{
					return this.TryChangeTypeSpecial(ref value);
				}
				return RuntimeType.CheckValueStatus.ArgumentException;
			}
		}

		// Token: 0x04000273 RID: 627
		internal static readonly RuntimeType ValueType = (RuntimeType)typeof(ValueType);

		// Token: 0x04000274 RID: 628
		internal static readonly RuntimeType EnumType = (RuntimeType)typeof(Enum);

		// Token: 0x04000275 RID: 629
		private static readonly RuntimeType ObjectType = (RuntimeType)typeof(object);

		// Token: 0x04000276 RID: 630
		private static readonly RuntimeType StringType = (RuntimeType)typeof(string);

		// Token: 0x04000277 RID: 631
		private RuntimeType.TypeCache cache;

		// Token: 0x02000092 RID: 146
		internal enum MemberListType
		{
			// Token: 0x04000279 RID: 633
			All,
			// Token: 0x0400027A RID: 634
			CaseSensitive,
			// Token: 0x0400027B RID: 635
			CaseInsensitive,
			// Token: 0x0400027C RID: 636
			HandleToInfo
		}

		// Token: 0x02000093 RID: 147
		private struct ListBuilder<T> where T : class
		{
			// Token: 0x06000636 RID: 1590 RVA: 0x000154DD File Offset: 0x000136DD
			public ListBuilder(int capacity)
			{
				this._items = null;
				this._item = default(T);
				this._count = 0;
				this._capacity = capacity;
			}

			// Token: 0x17000079 RID: 121
			public T this[int index]
			{
				get
				{
					if (this._items == null)
					{
						return this._item;
					}
					return this._items[index];
				}
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x00015520 File Offset: 0x00013720
			public T[] ToArray()
			{
				if (this._count == 0)
				{
					return Array.Empty<T>();
				}
				if (this._count == 1)
				{
					return new T[]
					{
						this._item
					};
				}
				Array.Resize<T>(ref this._items, this._count);
				this._capacity = this._count;
				return this._items;
			}

			// Token: 0x06000639 RID: 1593 RVA: 0x0001557B File Offset: 0x0001377B
			public void CopyTo(object[] array, int index)
			{
				if (this._count == 0)
				{
					return;
				}
				if (this._count == 1)
				{
					array[index] = this._item;
					return;
				}
				Array.Copy(this._items, 0, array, index, this._count);
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x0600063A RID: 1594 RVA: 0x000155B2 File Offset: 0x000137B2
			public int Count
			{
				get
				{
					return this._count;
				}
			}

			// Token: 0x0600063B RID: 1595 RVA: 0x000155BC File Offset: 0x000137BC
			public void Add(T item)
			{
				if (this._count == 0)
				{
					this._item = item;
				}
				else
				{
					if (this._count == 1)
					{
						if (this._capacity < 2)
						{
							this._capacity = 4;
						}
						this._items = new T[this._capacity];
						this._items[0] = this._item;
					}
					else if (this._capacity == this._count)
					{
						int num = 2 * this._capacity;
						Array.Resize<T>(ref this._items, num);
						this._capacity = num;
					}
					this._items[this._count] = item;
				}
				this._count++;
			}

			// Token: 0x0400027D RID: 637
			private T[] _items;

			// Token: 0x0400027E RID: 638
			private T _item;

			// Token: 0x0400027F RID: 639
			private int _count;

			// Token: 0x04000280 RID: 640
			private int _capacity;
		}

		// Token: 0x02000094 RID: 148
		[Flags]
		private enum TypeCacheEntries
		{
			// Token: 0x04000282 RID: 642
			IsGenericTypeDef = 1,
			// Token: 0x04000283 RID: 643
			IsDelegate = 2,
			// Token: 0x04000284 RID: 644
			IsValueType = 4,
			// Token: 0x04000285 RID: 645
			IsActualEnum = 8,
			// Token: 0x04000286 RID: 646
			IsGenericType = 16,
			// Token: 0x04000287 RID: 647
			CorElementType = 32,
			// Token: 0x04000288 RID: 648
			TypeAttributes = 64,
			// Token: 0x04000289 RID: 649
			DefaultCtor = 128
		}

		// Token: 0x02000095 RID: 149
		internal sealed class TypeCache
		{
			// Token: 0x0400028A RID: 650
			public object EnumInfo;

			// Token: 0x0400028B RID: 651
			public TypeCode TypeCode;

			// Token: 0x0400028C RID: 652
			public string full_name;

			// Token: 0x0400028D RID: 653
			public RuntimeConstructorInfo default_ctor;

			// Token: 0x0400028E RID: 654
			public CorElementType CorElementType;

			// Token: 0x0400028F RID: 655
			public TypeAttributes TypeAttributes;

			// Token: 0x04000290 RID: 656
			public int Flags;

			// Token: 0x04000291 RID: 657
			public int Cached;
		}

		// Token: 0x02000096 RID: 150
		private enum CheckValueStatus
		{
			// Token: 0x04000293 RID: 659
			Success,
			// Token: 0x04000294 RID: 660
			ArgumentException,
			// Token: 0x04000295 RID: 661
			NotSupported_ByRefLike
		}
	}
}
