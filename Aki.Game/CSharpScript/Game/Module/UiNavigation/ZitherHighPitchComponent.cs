using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MusicalInstrument;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004998 RID: 18840
	public class ZitherHighPitchComponent : HotKeyComponent
	{
		// Token: 0x06031136 RID: 201014 RVA: 0x00B639E8 File Offset: 0x00B61BE8
		public ZitherHighPitchComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031137 RID: 201015 RVA: 0x00B639F4 File Offset: 0x00B61BF4
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			GuqinSubController guqinSubController = MusicalInstrumentController.Instance.GetSubController(EInstrumentType.ChineseZither) as GuqinSubController;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, guqinSubController != null, false);
		}

		// Token: 0x06031138 RID: 201016 RVA: 0x00B63A20 File Offset: 0x00B61C20
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

		// Token: 0x06031139 RID: 201017 RVA: 0x00B63A54 File Offset: 0x00B61C54
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
