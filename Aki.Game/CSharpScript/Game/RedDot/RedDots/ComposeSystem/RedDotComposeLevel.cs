using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Manufacture.Compose;

namespace CSharpScript.Game.RedDot.RedDots.ComposeSystem
{
	// Token: 0x02003522 RID: 13602
	public class RedDotComposeLevel : RedDotBase
	{
		// Token: 0x06022A18 RID: 141848 RVA: 0x009DABC8 File Offset: 0x009D8DC8
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add(EEventName.UpdateComposeInfo, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.GetComposeData, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.UpgradeComposeLevel, new Action(base.EventCheck));
		}

		// Token: 0x06022A19 RID: 141849 RVA: 0x009DAC48 File Offset: 0x009D8E48
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove(EEventName.UpdateComposeInfo, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.GetComposeData, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.ComposeSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.UpgradeComposeLevel, new Action(base.EventCheck));
		}

		// Token: 0x06022A1A RID: 141850 RVA: 0x009DACC5 File Offset: 0x009D8EC5
		protected override bool OnCheck(int uId = 0)
		{
			return ComposeController.Instance.CheckCanGetComposeLevel();
		}
	}
}
