using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C2 RID: 18882
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ScrollBarComponentBase : HotKeyComponent
	{
		// Token: 0x060311CF RID: 201167 RVA: 0x00B64DE6 File Offset: 0x00B62FE6
		protected ScrollBarComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311D0 RID: 201168 RVA: 0x00B64DF0 File Offset: 0x00B62FF0
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

		// Token: 0x060311D1 RID: 201169 RVA: 0x00B64E3C File Offset: 0x00B6303C
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

		// Token: 0x060311D2 RID: 201170
		protected abstract void HandleScrollBarChange(float value);

		// Token: 0x0401A4C2 RID: 107714
		private const float THRESHOLD = 0.1f;

		// Token: 0x0401A4C3 RID: 107715
		private float TempValue;
	}
}
