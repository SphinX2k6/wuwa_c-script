using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui.Base
{
	// Token: 0x020046EF RID: 18159
	[NullableContext(1)]
	[Nullable(0)]
	public static class UiComponentActionBinder
	{
		// Token: 0x0602F7E0 RID: 194528 RVA: 0x00B02383 File Offset: 0x00B00583
		private static bool TryGetCompatibleDelegate(int name, Delegate fn, [Nullable(2)] out Action callBack)
		{
			callBack = (fn as Action);
			if (callBack != null)
			{
				return true;
			}
			UiComponentActionBinder.ReportTypeMismatch(name, fn, typeof(Action));
			return false;
		}

		// Token: 0x0602F7E1 RID: 194529 RVA: 0x00B023A5 File Offset: 0x00B005A5
		private static bool TryGetCompatibleDelegate<[Nullable(2)] T>(int name, Delegate fn, [Nullable(new byte[]
		{
			2,
			1
		})] out Action<T> callBack)
		{
			callBack = (fn as Action<T>);
			if (callBack != null)
			{
				return true;
			}
			UiComponentActionBinder.ReportTypeMismatch(name, fn, typeof(Action<T>));
			return false;
		}

		// Token: 0x0602F7E2 RID: 194530 RVA: 0x00B023C8 File Offset: 0x00B005C8
		private static void ReportTypeMismatch(int componentName, Delegate actualDelegate, Type expectedDelegateType)
		{
			ParameterInfo[] parameters = actualDelegate.Method.GetParameters();
			MethodInfo method = expectedDelegateType.GetMethod("Invoke");
			ParameterInfo[] expectedParams = ((method != null) ? method.GetParameters() : null) ?? Array.Empty<ParameterInfo>();
			string message = UiComponentActionBinder.BuildTypeMismatchErrorMessage(componentName, actualDelegate.GetType(), parameters, expectedDelegateType, expectedParams);
			Log.Instance.Error(ELogModule.UiCore, ELogAuthor.LRX, message, default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602F7E3 RID: 194531 RVA: 0x00B0242C File Offset: 0x00B0062C
		private static string BuildTypeMismatchErrorMessage(int componentName, Type actualType, ParameterInfo[] actualParams, Type expectedType, ParameterInfo[] expectedParams)
		{
			string parameterSignature = UiComponentActionBinder.GetParameterSignature(actualParams);
			string parameterSignature2 = UiComponentActionBinder.GetParameterSignature(expectedParams);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 5);
			defaultInterpolatedStringHandler.AppendLiteral("UI组件(#");
			defaultInterpolatedStringHandler.AppendFormatted<int>(componentName);
			defaultInterpolatedStringHandler.AppendLiteral(")委托类型不匹配 实际类型: ");
			defaultInterpolatedStringHandler.AppendFormatted(actualType.Name);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(parameterSignature);
			defaultInterpolatedStringHandler.AppendLiteral(") 期望类型: ");
			defaultInterpolatedStringHandler.AppendFormatted(expectedType.Name);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(parameterSignature2);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602F7E4 RID: 194532 RVA: 0x00B024D4 File Offset: 0x00B006D4
		private static string GetParameterSignature(ParameterInfo[] parameters)
		{
			if (parameters.Length == 0)
			{
				return "void";
			}
			string[] array = new string[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				array[i] = parameterInfo.ParameterType.Name + " " + parameterInfo.Name;
			}
			return string.Join(", ", array);
		}

		// Token: 0x0602F7E5 RID: 194533 RVA: 0x00B02530 File Offset: 0x00B00730
		private static string GetDelegateSignature(Type delegateType)
		{
			if (!typeof(Delegate).IsAssignableFrom(delegateType))
			{
				return delegateType.Name;
			}
			MethodInfo method = delegateType.GetMethod("Invoke");
			if (method == null)
			{
				return delegateType.Name;
			}
			ParameterInfo[] parameters = method.GetParameters();
			Type returnType = method.ReturnType;
			string parameterSignature = UiComponentActionBinder.GetParameterSignature(parameters);
			return ((returnType == typeof(void)) ? "void" : returnType.Name) + " (" + parameterSignature + ")";
		}

		// Token: 0x0602F7E6 RID: 194534 RVA: 0x00B025B6 File Offset: 0x00B007B6
		private static string GetDelegateSignature(Delegate del)
		{
			return UiComponentActionBinder.GetDelegateSignature(del.GetType());
		}

		// Token: 0x0602F7E7 RID: 194535 RVA: 0x00B025C4 File Offset: 0x00B007C4
		public static bool BindClickEvent(int name, UUIButtonComponent component, Delegate fn)
		{
			Action callback;
			if (!UiComponentActionBinder.TryGetCompatibleDelegate(name, fn, out callback))
			{
				return false;
			}
			component.OnClickCallBack.Bind(callback);
			return true;
		}

		// Token: 0x0602F7E8 RID: 194536 RVA: 0x00B025EC File Offset: 0x00B007EC
		public static bool BindClickEvent(int name, UUIToggleComponent component, Delegate fn)
		{
			Action<bool> callback;
			if (!UiComponentActionBinder.TryGetCompatibleDelegate<bool>(name, fn, out callback))
			{
				return false;
			}
			component.OnToggleEvent.Bind(callback);
			return true;
		}

		// Token: 0x0602F7E9 RID: 194537 RVA: 0x00B02614 File Offset: 0x00B00814
		public static bool BindClickEvent(int name, UUIExtendToggle component, Delegate fn)
		{
			Action<EToggleState> callback;
			if (!UiComponentActionBinder.TryGetCompatibleDelegate<EToggleState>(name, fn, out callback))
			{
				return false;
			}
			component.OnStateChange.Add(callback);
			return true;
		}

		// Token: 0x0602F7EA RID: 194538 RVA: 0x00B0263C File Offset: 0x00B0083C
		public static bool BindClickEvent(int name, UUISliderComponent component, Delegate fn)
		{
			Action<float> callback;
			if (!UiComponentActionBinder.TryGetCompatibleDelegate<float>(name, fn, out callback))
			{
				return false;
			}
			component.OnValueChangeCb.Bind(callback);
			return true;
		}

		// Token: 0x0602F7EB RID: 194539 RVA: 0x00B02664 File Offset: 0x00B00864
		public static bool BindClickEvent(int name, UUITextInputComponent component, Delegate fn)
		{
			Action<bool> callback;
			if (!UiComponentActionBinder.TryGetCompatibleDelegate<bool>(name, fn, out callback))
			{
				return false;
			}
			component.OnInputActivateDelegate.Bind(callback);
			return true;
		}
	}
}
