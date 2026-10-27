using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054DA RID: 21722
	public class CorniceMeetingMarkItem : SceneGameplayMarkItem
	{
		// Token: 0x06037770 RID: 227184 RVA: 0x00D2CC0B File Offset: 0x00D2AE0B
		[NullableContext(1)]
		public CorniceMeetingMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x06037771 RID: 227185 RVA: 0x00D2CC1C File Offset: 0x00D2AE1C
		public override bool CheckCanShowView()
		{
			CorniceChallenge? corniceMeetingChallengeByMarkId = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeByMarkId(this.MarkId);
			if (corniceMeetingChallengeByMarkId != null)
			{
				ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
				return currentActivityData != null && currentActivityData.GetIsShow(corniceMeetingChallengeByMarkId.Value.Id);
			}
			return false;
		}
	}
}
