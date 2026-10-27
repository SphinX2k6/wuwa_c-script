using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Manufacture.Compose;

namespace CSharpScript.Game.RedDot.RedDots.ComposeSystem
{
	// Token: 0x020045F9 RID: 17913
	public class RedDotComposeLevel : RedDotBase
	{
		// Token: 0x0602E323 RID: 189219 RVA: 0x00AAE4D4 File Offset: 0x00AAC6D4
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add(EEventName.UpdateComposeInfo, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.GetComposeData, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.UpgradeComposeLevel, new Action(base.EventCheck));
		}

		// Token: 0x0602E324 RID: 189220 RVA: 0x00AAE554 File Offset: 0x00AAC754
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove(EEventName.UpdateComposeInfo, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.GetComposeData, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.ComposeSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.UpgradeComposeLevel, new Action(base.EventCheck));
		}

		// Token: 0x0602E325 RID: 189221 RVA: 0x00AAE5D1 File Offset: 0x00AAC7D1
		protected override bool OnCheck(int uId = 0)
		{
			return ComposeController.Instance.CheckCanGetComposeLevel();
		}
	}
}
