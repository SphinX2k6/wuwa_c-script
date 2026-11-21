using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.MusicalInstrument;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003911 RID: 14609
	[NullableContext(1)]
	[Nullable(0)]
	public class ZitherCameraZoomComponent : HotKeyComponent
	{
		// Token: 0x06025C69 RID: 154729 RVA: 0x00A9E8DA File Offset: 0x00A9CADA
		public ZitherCameraZoomComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C6A RID: 154730 RVA: 0x00A9E8E4 File Offset: 0x00A9CAE4
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			GuqinSubController guqinSubController = MusicalInstrumentController.Instance.GetSubController(EInstrumentType.ChineseZither) as GuqinSubController;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, guqinSubController != null && Info.Instance.IsInGamepad(), false);
		}

		// Token: 0x06025C6B RID: 154731 RVA: 0x00A9E91A File Offset: 0x00A9CB1A
		protected override void OnInputAxis(string axisName, float value)
		{
			GuqinSubController guqinSubController = MusicalInstrumentController.Instance.GetSubController(EInstrumentType.ChineseZither) as GuqinSubController;
			if (guqinSubController == null)
			{
				return;
			}
			guqinSubController.OnGamepadCameraZoom(axisName, value);
		}
	}
}
