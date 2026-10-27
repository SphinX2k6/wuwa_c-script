using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MusicalInstrument;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004999 RID: 18841
	public class ZitherLowPitchComponent : HotKeyComponent
	{
		// Token: 0x0603113A RID: 201018 RVA: 0x00B63A86 File Offset: 0x00B61C86
		public ZitherLowPitchComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603113B RID: 201019 RVA: 0x00B63A90 File Offset: 0x00B61C90
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			GuqinSubController guqinSubController = MusicalInstrumentController.Instance.GetSubController(EInstrumentType.ChineseZither) as GuqinSubController;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, guqinSubController != null, false);
		}

		// Token: 0x0603113C RID: 201020 RVA: 0x00B63ABC File Offset: 0x00B61CBC
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

		// Token: 0x0603113D RID: 201021 RVA: 0x00B63AF0 File Offset: 0x00B61CF0
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
