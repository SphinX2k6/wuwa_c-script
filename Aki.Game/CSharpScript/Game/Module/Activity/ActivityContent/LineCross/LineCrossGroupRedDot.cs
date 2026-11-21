using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x020054E4 RID: 21732
	public class LineCrossGroupRedDot : RedDotBase
	{
		// Token: 0x06035D93 RID: 220563 RVA: 0x00F0B0F1 File Offset: 0x00F092F1
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshLineCrossGroupRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x06035D94 RID: 220564 RVA: 0x00F0B10F File Offset: 0x00F0930F
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshLineCrossGroupRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x06035D95 RID: 220565 RVA: 0x00F0B12D File Offset: 0x00F0932D
		protected override bool OnCheck(int groupId)
		{
			return LineCrossModel.Instance.GetGroupRedDotState(groupId);
		}
	}
}
