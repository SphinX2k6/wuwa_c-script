using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BDB RID: 15323
	public class RedDotSheriff : RedDotBase
	{
		// Token: 0x060274E8 RID: 161000 RVA: 0x00B067F7 File Offset: 0x00B049F7
		protected override ERedDotName? OnGetParentName()
		{
			return new ERedDotName?(ERedDotName.FunctionMap);
		}

		// Token: 0x060274E9 RID: 161001 RVA: 0x00B06800 File Offset: 0x00B04A00
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x060274EA RID: 161002 RVA: 0x00B0681E File Offset: 0x00B04A1E
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x060274EB RID: 161003 RVA: 0x00B0683C File Offset: 0x00B04A3C
		protected override bool IsAllEventParamAsUId()
		{
			return false;
		}

		// Token: 0x060274EC RID: 161004 RVA: 0x00B06840 File Offset: 0x00B04A40
		protected override bool OnCheck(int uId = 0)
		{
			List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(106);
			SheriffActivityData sheriffActivityData = (activitiesByType.Count > 0) ? (activitiesByType[0] as SheriffActivityData) : null;
			return sheriffActivityData != null && sheriffActivityData.GetTerminalRedPointShowState();
		}
	}
}
