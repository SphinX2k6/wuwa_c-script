using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Cook;

namespace CSharpScript.Game.RedDot.RedDots.CookSystem
{
	// Token: 0x02003521 RID: 13601
	public class RedDotCookerLevel : RedDotBase
	{
		// Token: 0x06022A14 RID: 141844 RVA: 0x009DAA7C File Offset: 0x009D8C7C
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add(EEventName.UpdateCookerInfo, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.GetCookData, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.CookSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.MachiningSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Add(EEventName.UpgradeCookerLevel, new Action(base.EventCheck));
		}

		// Token: 0x06022A15 RID: 141845 RVA: 0x009DAB18 File Offset: 0x009D8D18
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove(EEventName.UpdateCookerInfo, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.GetCookData, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.CookSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.MachiningSuccess, new Action(base.EventCheck));
			EventSystem.Instance.Remove(EEventName.UpgradeCookerLevel, new Action(base.EventCheck));
		}

		// Token: 0x06022A16 RID: 141846 RVA: 0x009DABB1 File Offset: 0x009D8DB1
		protected override bool OnCheck(int id = 0)
		{
			return CookController.Instance.CheckCanGetCookerLevel();
		}
	}
}
