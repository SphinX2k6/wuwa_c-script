using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003940 RID: 14656
	[NullableContext(1)]
	[Nullable(0)]
	public class ScrollBarInsideComponent : HotKeyComponent
	{
		// Token: 0x06025D0F RID: 154895 RVA: 0x00A9FE6D File Offset: 0x00A9E06D
		public ScrollBarInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D10 RID: 154896 RVA: 0x00A9FE78 File Offset: 0x00A9E078
		protected override void OnInputAxis(string axisName, float value)
		{
			if (Math.Abs(value) <= 0.1f)
			{
				if (this.TempValue != 0f)
				{
					this.TempValue = 0f;
					UiNavigationNewController.Instance.ScrollbarInsideComponentSetValue(base.GetBindButtonTag(), 0f);
				}
				return;
			}
			this.TempValue = value;
			UiNavigationNewController.Instance.ScrollbarInsideComponentSetValue(base.GetBindButtonTag(), value);
		}

		// Token: 0x06025D11 RID: 154897 RVA: 0x00A9FED8 File Offset: 0x00A9E0D8
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				Log.Instance.Error(ELogModule.UiNavigationHotKey, ELogAuthor.XXJ, "ScrollBar需要配置tag", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TsUiNavigationBehaviorListener focusListenerInsideListenerByTag = UiNavigationNewController.Instance.GetFocusListenerInsideListenerByTag(focusListener, bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, focusListenerInsideListenerByTag != null && focusListenerInsideListenerByTag.IsListenerActive(), false);
		}

		// Token: 0x04014D38 RID: 85304
		private const float THRESHOLD = 0.1f;

		// Token: 0x04014D39 RID: 85305
		private float TempValue;
	}
}
