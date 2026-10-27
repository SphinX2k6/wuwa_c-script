using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004983 RID: 18819
	public class LongPressInsideComponent : HotKeyComponent
	{
		// Token: 0x060310E3 RID: 200931 RVA: 0x00B62DFE File Offset: 0x00B60FFE
		public LongPressInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310E4 RID: 200932 RVA: 0x00B62E07 File Offset: 0x00B61007
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointUpInside(config.BindButtonTag, config.Id, this.PressListener);
		}

		// Token: 0x060310E5 RID: 200933 RVA: 0x00B62E27 File Offset: 0x00B61027
		protected override void OnPress(HotKeyMap config)
		{
			this.PressListener = UiNavigationNewController.Instance.SimulationPointDownInside(config.BindButtonTag, config.Id);
		}

		// Token: 0x060310E6 RID: 200934 RVA: 0x00B62E48 File Offset: 0x00B61048
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!base.IsLinkListener(focusListener.GetOwner()))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TsUiNavigationBehaviorListener childListenerByTag = focusListener.GetChildListenerByTag(bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, childListenerByTag != null && childListenerByTag.IsListenerActive(), false);
		}

		// Token: 0x0401A4A8 RID: 107688
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener PressListener;
	}
}
