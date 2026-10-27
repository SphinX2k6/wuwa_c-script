using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Cook;

namespace CSharpScript.Game.RedDot.RedDots.CookSystem
{
	// Token: 0x020045F8 RID: 17912
	public class RedDotCookerLevel : RedDotBase
	{
		// Token: 0x0602E31F RID: 189215 RVA: 0x00AAE388 File Offset: 0x00AAC588
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add(EEventName.UpdateCookerInfo, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.GetCookData, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.CookSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.MachiningSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.UpgradeCookerLevel, new Action(base.EventCheck));
		}

		// Token: 0x0602E320 RID: 189216 RVA: 0x00AAE424 File Offset: 0x00AAC624
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove(EEventName.UpdateCookerInfo, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.GetCookData, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.CookSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.MachiningSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.UpgradeCookerLevel, new Action(base.EventCheck));
		}

		// Token: 0x0602E321 RID: 189217 RVA: 0x00AAE4BD File Offset: 0x00AAC6BD
		protected override bool OnCheck(int id = 0)
		{
			return CookController.Instance.CheckCanGetCookerLevel();
		}
	}
}
