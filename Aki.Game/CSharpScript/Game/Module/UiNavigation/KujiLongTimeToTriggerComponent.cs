using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038FA RID: 14586
	public class KujiLongTimeToTriggerComponent : LongTimeToTriggerComponent
	{
		// Token: 0x06025C0E RID: 154638 RVA: 0x00A9DC16 File Offset: 0x00A9BE16
		public KujiLongTimeToTriggerComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C0F RID: 154639 RVA: 0x00A9DC1F File Offset: 0x00A9BE1F
		[NullableContext(2)]
		private IKujiTearGamepadHandler GetTearView()
		{
			return (UiManager.Instance.GetViewByName(EUiViewName.SolarSchoolPrizeDrawingTearView) as IKujiTearGamepadHandler) ?? (UiManager.Instance.GetViewByName(EUiViewName.PrizeDrawingTearView) as IKujiTearGamepadHandler);
		}

		// Token: 0x06025C10 RID: 154640 RVA: 0x00A9DC4D File Offset: 0x00A9BE4D
		protected override void OnHandleLongPressRefresh(float percent)
		{
			IKujiTearGamepadHandler tearView = this.GetTearView();
			if (tearView == null)
			{
				return;
			}
			tearView.OnGamepadHold(percent);
		}

		// Token: 0x06025C11 RID: 154641 RVA: 0x00A9DC60 File Offset: 0x00A9BE60
		protected override void OnPressAction()
		{
			IKujiTearGamepadHandler tearView = this.GetTearView();
			if (tearView == null)
			{
				return;
			}
			tearView.OnGamepadPress();
		}

		// Token: 0x06025C12 RID: 154642 RVA: 0x00A9DC72 File Offset: 0x00A9BE72
		protected override void OnReleaseAction()
		{
			IKujiTearGamepadHandler tearView = this.GetTearView();
			if (tearView == null)
			{
				return;
			}
			tearView.OnGamepadRelease();
		}

		// Token: 0x06025C13 RID: 154643 RVA: 0x00A9DC84 File Offset: 0x00A9BE84
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			IKujiTearGamepadHandler tearView = this.GetTearView();
			if (tearView == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, tearView.GetGamepadCanPress(), false);
		}
	}
}
