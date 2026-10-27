using System;
using CSharpScript.Game.Ui;

// Token: 0x02001E88 RID: 7816
public static class HonamiStoryGamepadUtil
{
	// Token: 0x0600EE49 RID: 61001 RVA: 0x0038CE20 File Offset: 0x0038B020
	public static void HideAllTips()
	{
		HonamiStoryBackpackView honamiStoryBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryBackpackView) as HonamiStoryBackpackView;
		if (honamiStoryBackpackView != null)
		{
			honamiStoryBackpackView.HideAllTips();
		}
		HonamiStoryPickUpBackpackView honamiStoryPickUpBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpBackpackView) as HonamiStoryPickUpBackpackView;
		if (honamiStoryPickUpBackpackView != null)
		{
			honamiStoryPickUpBackpackView.HideAllTips();
		}
	}

	// Token: 0x0600EE4A RID: 61002 RVA: 0x0038CE6C File Offset: 0x0038B06C
	public static void EnterMask()
	{
		HonamiStoryBackpackView honamiStoryBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryBackpackView) as HonamiStoryBackpackView;
		if (honamiStoryBackpackView != null)
		{
			honamiStoryBackpackView.OnEnterGamepadMask();
		}
		HonamiStoryPickUpBackpackView honamiStoryPickUpBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpBackpackView) as HonamiStoryPickUpBackpackView;
		if (honamiStoryPickUpBackpackView != null)
		{
			honamiStoryPickUpBackpackView.OnEnterGamepadMask();
		}
	}

	// Token: 0x0600EE4B RID: 61003 RVA: 0x0038CEB8 File Offset: 0x0038B0B8
	public static void ExitMask()
	{
		HonamiStoryBackpackView honamiStoryBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryBackpackView) as HonamiStoryBackpackView;
		if (honamiStoryBackpackView != null)
		{
			honamiStoryBackpackView.OnExitGamepadMask();
		}
		HonamiStoryPickUpBackpackView honamiStoryPickUpBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpBackpackView) as HonamiStoryPickUpBackpackView;
		if (honamiStoryPickUpBackpackView != null)
		{
			honamiStoryPickUpBackpackView.OnExitGamepadMask();
		}
	}
}
