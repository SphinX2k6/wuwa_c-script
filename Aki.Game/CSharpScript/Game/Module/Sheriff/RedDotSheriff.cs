using System;
using System.Linq;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C2A RID: 19498
	public class RedDotSheriff : RedDotBase
	{
		// Token: 0x06032735 RID: 206645 RVA: 0x00BC1BDF File Offset: 0x00BBFDDF
		protected override ERedDotName? OnGetParentName()
		{
			return new ERedDotName?(ERedDotName.FunctionMap);
		}

		// Token: 0x06032736 RID: 206646 RVA: 0x00BC1BE8 File Offset: 0x00BBFDE8
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x06032737 RID: 206647 RVA: 0x00BC1C06 File Offset: 0x00BBFE06
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x06032738 RID: 206648 RVA: 0x00BC1C24 File Offset: 0x00BBFE24
		protected override bool IsAllEventParamAsUId()
		{
			return false;
		}

		// Token: 0x06032739 RID: 206649 RVA: 0x00BC1C27 File Offset: 0x00BBFE27
		protected override bool OnCheck(int uId = 0)
		{
			SheriffActivityData sheriffActivityData = ActivityModel.Instance.GetActivitiesByType(106).FirstOrDefault<ActivityBaseData>() as SheriffActivityData;
			return sheriffActivityData != null && sheriffActivityData.GetTerminalRedPointShowState();
		}
	}
}
