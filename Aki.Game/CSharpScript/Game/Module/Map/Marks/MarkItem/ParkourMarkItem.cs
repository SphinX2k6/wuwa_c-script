using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054F0 RID: 21744
	public class ParkourMarkItem : SceneGameplayMarkItem
	{
		// Token: 0x060378B1 RID: 227505 RVA: 0x00D2FEE2 File Offset: 0x00D2E0E2
		[NullableContext(1)]
		public ParkourMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x060378B2 RID: 227506 RVA: 0x00D2FEF4 File Offset: 0x00D2E0F4
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
