using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C6 RID: 18886
	[NullableContext(1)]
	[Nullable(0)]
	public class ScrollBarInsideComponent : HotKeyComponent
	{
		// Token: 0x060311D9 RID: 201177 RVA: 0x00B64F1D File Offset: 0x00B6311D
		public ScrollBarInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311DA RID: 201178 RVA: 0x00B64F28 File Offset: 0x00B63128
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

		// Token: 0x060311DB RID: 201179 RVA: 0x00B64F88 File Offset: 0x00B63188
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

		// Token: 0x0401A4C6 RID: 107718
		private const float THRESHOLD = 0.1f;

		// Token: 0x0401A4C7 RID: 107719
		private float TempValue;
	}
}
