using System;
using CSharpScript.Game.Ui;

// Token: 0x0200134A RID: 4938
public static class HonamiStoryGamepadUtil
{
	// Token: 0x0600C268 RID: 49768 RVA: 0x00398A10 File Offset: 0x00396C10
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

	// Token: 0x0600C269 RID: 49769 RVA: 0x00398A5C File Offset: 0x00396C5C
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

	// Token: 0x0600C26A RID: 49770 RVA: 0x00398AA8 File Offset: 0x00396CA8
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
