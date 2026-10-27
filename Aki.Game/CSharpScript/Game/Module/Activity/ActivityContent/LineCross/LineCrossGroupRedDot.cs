using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x02006566 RID: 25958
	public class LineCrossGroupRedDot : RedDotBase
	{
		// Token: 0x060410CE RID: 266446 RVA: 0x00FC410D File Offset: 0x00FC230D
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshLineCrossGroupRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x060410CF RID: 266447 RVA: 0x00FC412B File Offset: 0x00FC232B
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshLineCrossGroupRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x060410D0 RID: 266448 RVA: 0x00FC4149 File Offset: 0x00FC2349
		protected override bool OnCheck(int groupId)
		{
			return LineCrossModel.Instance.GetGroupRedDotState(groupId);
		}
	}
}
