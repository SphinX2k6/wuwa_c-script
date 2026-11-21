using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200393C RID: 14652
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ScrollBarComponentBase : HotKeyComponent
	{
		// Token: 0x06025D05 RID: 154885 RVA: 0x00A9FD36 File Offset: 0x00A9DF36
		protected ScrollBarComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D06 RID: 154886 RVA: 0x00A9FD40 File Offset: 0x00A9DF40
		protected override void OnInputAxis(string axisName, float value)
		{
			if (Math.Abs(value) <= 0.1f)
			{
				if (this.TempValue != 0f)
				{
					this.TempValue = 0f;
					this.HandleScrollBarChange(0f);
				}
				return;
			}
			this.TempValue = value;
			this.HandleScrollBarChange(value);
		}

		// Token: 0x06025D07 RID: 154887 RVA: 0x00A9FD8C File Offset: 0x00A9DF8C
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				Log.Instance.Error(ELogModule.UiNavigationHotKey, ELogAuthor.XXJ, "ScrollBar需要配置tag", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			TsUiNavigationBehaviorListener currentListener = viewHandle.GetScrollbarData().GetCurrentListener();
			if (currentListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!currentListener.IsListenerActive())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TArray<string> tagArray = currentListener.TagArray;
			if (tagArray == null || !tagArray.Contains(bindButtonTag))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025D08 RID: 154888
		protected abstract void HandleScrollBarChange(float value);

		// Token: 0x04014D34 RID: 85300
		private const float THRESHOLD = 0.1f;

		// Token: 0x04014D35 RID: 85301
		private float TempValue;
	}
}
