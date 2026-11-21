using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MusicalInstrument;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003913 RID: 14611
	public class ZitherLowPitchComponent : HotKeyComponent
	{
		// Token: 0x06025C70 RID: 154736 RVA: 0x00A9E9D6 File Offset: 0x00A9CBD6
		public ZitherLowPitchComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C71 RID: 154737 RVA: 0x00A9E9E0 File Offset: 0x00A9CBE0
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			GuqinSubController guqinSubController = MusicalInstrumentController.Instance.GetSubController(EInstrumentType.ChineseZither) as GuqinSubController;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, guqinSubController != null, false);
		}

		// Token: 0x06025C72 RID: 154738 RVA: 0x00A9EA0C File Offset: 0x00A9CC0C
		protected override void OnPress(HotKeyMap config)
		{
			GuqinSubController guqinSubController = MusicalInstrumentController.Instance.GetSubController(EInstrumentType.ChineseZither) as GuqinSubController;
			if (guqinSubController != null)
			{
				GuqinView view = guqinSubController.GetView();
				if (view == null)
				{
					return;
				}
				view.OnGamepadPressPitch(EZitherGamepadPitchType.Low);
			}
		}

		// Token: 0x06025C73 RID: 154739 RVA: 0x00A9EA40 File Offset: 0x00A9CC40
		protected override void OnRelease(HotKeyMap config)
		{
			GuqinSubController guqinSubController = MusicalInstrumentController.Instance.GetSubController(EInstrumentType.ChineseZither) as GuqinSubController;
			if (guqinSubController != null)
			{
				GuqinView view = guqinSubController.GetView();
				if (view == null)
				{
					return;
				}
				view.OnGamepadReleasePitch(EZitherGamepadPitchType.Low);
			}
		}
	}
}
