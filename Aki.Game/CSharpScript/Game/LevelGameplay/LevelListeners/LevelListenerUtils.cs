using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners
{
	// Token: 0x02005C62 RID: 23650
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelListenerUtils
	{
		// Token: 0x0603A115 RID: 237845 RVA: 0x010572D0 File Offset: 0x010554D0
		private static List<FieldInfo> GetAllFields(Type type)
		{
			List<FieldInfo> list = new List<FieldInfo>();
			list.AddRange(type.GetFields(BindingFlags.Instance | BindingFlags.Public));
			Type type2 = type;
			while (type2 != null && type2 != typeof(object))
			{
				foreach (FieldInfo fieldInfo in type2.GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
				{
					if (!(fieldInfo.DeclaringType != type2))
					{
						list.Add(fieldInfo);
					}
				}
				type2 = type2.BaseType;
			}
			list.Reverse();
			return list;
		}

		// Token: 0x0603A116 RID: 237846 RVA: 0x01057354 File Offset: 0x01055554
		public unsafe static bool ClearListener<[Nullable(0)] T>(T listener, T listenerTemplate) where T : LevelListenerBase
		{
			foreach (FieldInfo fieldInfo in LevelListenerUtils.GetAllFields(listener.GetType()))
			{
				object value = fieldInfo.GetValue(listenerTemplate);
				if (value == null)
				{
					fieldInfo.SetValue(listener, null);
				}
				else if (fieldInfo.FieldType.IsValueType)
				{
					fieldInfo.SetValue(listener, value);
				}
				else if (fieldInfo.FieldType == typeof(string))
				{
					fieldInfo.SetValue(listener, value);
				}
				else if (!LevelListenerUtils.ClearObject(fieldInfo.GetValue(listener)))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.LevelListener;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "监听器存在未定义清理方式的Object";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Listener", listener.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Field", fieldInfo.Name);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603A117 RID: 237847 RVA: 0x010574AC File Offset: 0x010556AC
		[NullableContext(2)]
		private static bool ClearObject(object obj)
		{
			if (obj == null)
			{
				return true;
			}
			if (obj is Stat || obj is Delegate)
			{
				return true;
			}
			IList list = obj as IList;
			if (list != null)
			{
				list.Clear();
				return true;
			}
			IClearable clearable = obj as IClearable;
			if (clearable != null)
			{
				clearable.Clear();
				return true;
			}
			IDictionary dictionary = obj as IDictionary;
			if (dictionary != null)
			{
				dictionary.Clear();
				return true;
			}
			IClear clear = obj as IClear;
			if (clear != null)
			{
				return clear.ClearObject();
			}
			Type type = obj.GetType();
			if (type.IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				if (genericTypeDefinition == typeof(HashSet<>) || genericTypeDefinition == typeof(TArray<>) || genericTypeDefinition == typeof(TSet<>) || genericTypeDefinition == typeof(TMap<, >) || genericTypeDefinition == typeof(ConditionalWeakTable<, >) || genericTypeDefinition == typeof(WeakSet<>) || genericTypeDefinition == typeof(WeakMap<, >))
				{
					if (LevelListenerUtils.<>o__2.<>p__0 == null)
					{
						LevelListenerUtils.<>o__2.<>p__0 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Clear", null, typeof(LevelListenerUtils), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					LevelListenerUtils.<>o__2.<>p__0.Target(LevelListenerUtils.<>o__2.<>p__0, obj);
					return true;
				}
			}
			return false;
		}
	}
}
