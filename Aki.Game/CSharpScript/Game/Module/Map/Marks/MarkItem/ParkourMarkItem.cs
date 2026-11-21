using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044C3 RID: 17603
	public class ParkourMarkItem : SceneGameplayMarkItem
	{
		// Token: 0x0602C77C RID: 182140 RVA: 0x00C7DED8 File Offset: 0x00C7C0D8
		[NullableContext(1)]
		public ParkourMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x0602C77D RID: 182141 RVA: 0x00C7DEEC File Offset: 0x00C7C0EC
		public override bool CheckCanShowView()
		{
			ParkourChallenge? config = ConfigParkourChallengeByMarkId.GetConfig(this.MarkId, true);
			if (config != null)
			{
				ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(config.Value.Id);
				return activityRunData != null && activityRunData.GetIsShow();
			}
			return false;
		}
	}
}
