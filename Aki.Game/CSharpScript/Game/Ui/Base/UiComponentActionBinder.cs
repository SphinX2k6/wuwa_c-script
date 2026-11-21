using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui.Base
{
	// Token: 0x0200361F RID: 13855
	[NullableContext(1)]
	[Nullable(0)]
	public static class UiComponentActionBinder
	{
		// Token: 0x06023FA9 RID: 147369 RVA: 0x00A321BF File Offset: 0x00A303BF
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

		// Token: 0x06023FAA RID: 147370 RVA: 0x00A321E1 File Offset: 0x00A303E1
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

		// Token: 0x06023FAB RID: 147371 RVA: 0x00A32204 File Offset: 0x00A30404
		private static void ReportTypeMismatch(int componentName, Delegate actualDelegate, Type expectedDelegateType)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
			defaultInterpolatedStringHandler.AppendLiteral("UI组件(#");
			defaultInterpolatedStringHandler.AppendFormatted<int>(componentName);
			defaultInterpolatedStringHandler.AppendLiteral(")委托类型不匹配 实际类型: (");
			defaultInterpolatedStringHandler.AppendFormatted<Type>(actualDelegate.GetType());
			defaultInterpolatedStringHandler.AppendLiteral(") 期望类型: (");
			defaultInterpolatedStringHandler.AppendFormatted<Type>(expectedDelegateType);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			string message = defaultInterpolatedStringHandler.ToStringAndClear();
			Log.Instance.Error(ELogModule.UiCore, ELogAuthor.LRX, message, default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06023FAC RID: 147372 RVA: 0x00A32288 File Offset: 0x00A30488
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

		// Token: 0x06023FAD RID: 147373 RVA: 0x00A322B0 File Offset: 0x00A304B0
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

		// Token: 0x06023FAE RID: 147374 RVA: 0x00A322D8 File Offset: 0x00A304D8
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

		// Token: 0x06023FAF RID: 147375 RVA: 0x00A32300 File Offset: 0x00A30500
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

		// Token: 0x06023FB0 RID: 147376 RVA: 0x00A32328 File Offset: 0x00A30528
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
