using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.MusicalInstrument;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004997 RID: 18839
	[NullableContext(1)]
	[Nullable(0)]
	public class ZitherCameraZoomComponent : HotKeyComponent
	{
		// Token: 0x06031133 RID: 201011 RVA: 0x00B6398A File Offset: 0x00B61B8A
		public ZitherCameraZoomComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031134 RID: 201012 RVA: 0x00B63994 File Offset: 0x00B61B94
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			GuqinSubController guqinSubController = MusicalInstrumentController.Instance.GetSubController(EInstrumentType.ChineseZither) as GuqinSubController;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, guqinSubController != null && Info.Instance.IsInGamepad(), false);
		}

		// Token: 0x06031135 RID: 201013 RVA: 0x00B639CA File Offset: 0x00B61BCA
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
