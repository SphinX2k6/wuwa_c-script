using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004981 RID: 18817
	public class KujiLongTimeToTriggerComponent : LongTimeToTriggerComponent
	{
		// Token: 0x060310DA RID: 200922 RVA: 0x00B62D16 File Offset: 0x00B60F16
		public KujiLongTimeToTriggerComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310DB RID: 200923 RVA: 0x00B62D1F File Offset: 0x00B60F1F
		protected override void OnInit()
		{
			this.ActivityView = (UiManager.Instance.GetViewByName(EUiViewName.PrizeDrawingTearView) as ActivityPrizeDrawingTearView);
		}

		// Token: 0x060310DC RID: 200924 RVA: 0x00B62D3B File Offset: 0x00B60F3B
		protected override void OnHandleLongPressRefresh(float percent)
		{
			if (this.ActivityView == null)
			{
				return;
			}
			this.ActivityView.OnGamepadHold(percent);
		}

		// Token: 0x060310DD RID: 200925 RVA: 0x00B62D52 File Offset: 0x00B60F52
		protected override void OnPressAction()
		{
			if (this.ActivityView == null)
			{
				return;
			}
			this.ActivityView.OnGamepadPress();
		}

		// Token: 0x060310DE RID: 200926 RVA: 0x00B62D68 File Offset: 0x00B60F68
		protected override void OnReleaseAction()
		{
			if (this.ActivityView == null)
			{
				return;
			}
			this.ActivityView.OnGamepadRelease();
		}

		// Token: 0x060310DF RID: 200927 RVA: 0x00B62D80 File Offset: 0x00B60F80
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PrizeDrawingTearView);
			if (viewByName == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			ActivityPrizeDrawingTearView activityPrizeDrawingTearView = viewByName as ActivityPrizeDrawingTearView;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, activityPrizeDrawingTearView.GetGamepadCanPress(), false);
		}

		// Token: 0x0401A4A7 RID: 107687
		[Nullable(2)]
		private ActivityPrizeDrawingTearView ActivityView;
	}
}
