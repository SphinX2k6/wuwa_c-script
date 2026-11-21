using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Weather;

// Token: 0x020029C8 RID: 10696
public class RedDotWeatherCentral : RedDotBase
{
	// Token: 0x0601AB6F RID: 109423 RVA: 0x00834AC1 File Offset: 0x00832CC1
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionMap);
	}

	// Token: 0x0601AB70 RID: 109424 RVA: 0x00834ACA File Offset: 0x00832CCA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnWeatherCentralRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB71 RID: 109425 RVA: 0x00834AE8 File Offset: 0x00832CE8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnWeatherCentralRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB72 RID: 109426 RVA: 0x00834B06 File Offset: 0x00832D06
	protected override bool OnCheck(int uId = 0)
	{
		return WeatherModel.Instance.HasAnyNewWeather();
	}
}
