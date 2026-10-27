using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Weather;

// Token: 0x02003454 RID: 13396
public class RedDotWeatherCentral : RedDotBase
{
	// Token: 0x0601CE6F RID: 118383 RVA: 0x0080E3D9 File Offset: 0x0080C5D9
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionMap);
	}

	// Token: 0x0601CE70 RID: 118384 RVA: 0x0080E3E2 File Offset: 0x0080C5E2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnWeatherCentralRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE71 RID: 118385 RVA: 0x0080E400 File Offset: 0x0080C600
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnWeatherCentralRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE72 RID: 118386 RVA: 0x0080E41E File Offset: 0x0080C61E
	protected override bool OnCheck(int uId = 0)
	{
		return WeatherModel.Instance.HasAnyNewWeather();
	}
}
