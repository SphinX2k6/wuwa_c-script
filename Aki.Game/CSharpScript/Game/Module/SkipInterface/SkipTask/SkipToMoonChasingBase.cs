using System;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BD2 RID: 19410
	public class SkipToMoonChasingBase : SkipTask
	{
		// Token: 0x06032333 RID: 205619 RVA: 0x00BAA65C File Offset: 0x00BA885C
		public bool CheckMainViewOpen()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.MoonChasingMainView) != null;
		}

		// Token: 0x06032334 RID: 205620 RVA: 0x00BAA670 File Offset: 0x00BA8870
		public void SkipToMap(int activityId)
		{
			TrackMoonActivity? activityMoonChasingConfig = ActivityMoonChasingConfig.Instance.GetActivityMoonChasingConfig(activityId);
			if (activityMoonChasingConfig == null)
			{
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(activityMoonChasingConfig.Value.FocusMarkId),
				MarkType = EMarkType.SmallTeleport
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}
	}
}
