using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MusicalInstrument;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003912 RID: 14610
	public class ZitherHighPitchComponent : HotKeyComponent
	{
		// Token: 0x06025C6C RID: 154732 RVA: 0x00A9E938 File Offset: 0x00A9CB38
		public ZitherHighPitchComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C6D RID: 154733 RVA: 0x00A9E944 File Offset: 0x00A9CB44
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			GuqinSubController guqinSubController = MusicalInstrumentController.Instance.GetSubController(EInstrumentType.ChineseZither) as GuqinSubController;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, guqinSubController != null, false);
		}

		// Token: 0x06025C6E RID: 154734 RVA: 0x00A9E970 File Offset: 0x00A9CB70
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
				view.OnGamepadPressPitch(EZitherGamepadPitchType.High);
			}
		}

		// Token: 0x06025C6F RID: 154735 RVA: 0x00A9E9A4 File Offset: 0x00A9CBA4
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
				view.OnGamepadReleasePitch(EZitherGamepadPitchType.High);
			}
		}
	}
}
