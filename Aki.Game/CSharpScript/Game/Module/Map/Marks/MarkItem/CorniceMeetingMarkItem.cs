using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044AD RID: 17581
	public class CorniceMeetingMarkItem : SceneGameplayMarkItem
	{
		// Token: 0x0602C626 RID: 181798 RVA: 0x00C7ACB7 File Offset: 0x00C78EB7
		[NullableContext(1)]
		public CorniceMeetingMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x0602C627 RID: 181799 RVA: 0x00C7ACC8 File Offset: 0x00C78EC8
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
