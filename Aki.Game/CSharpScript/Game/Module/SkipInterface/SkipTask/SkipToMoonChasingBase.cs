using System;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B7C RID: 15228
	public class SkipToMoonChasingBase : SkipTask
	{
		// Token: 0x060270C4 RID: 159940 RVA: 0x00AEE914 File Offset: 0x00AECB14
		public bool CheckMainViewOpen()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.MoonChasingMainView) != null;
		}

		// Token: 0x060270C5 RID: 159941 RVA: 0x00AEE928 File Offset: 0x00AECB28
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
