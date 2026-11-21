using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020029BB RID: 10683
public class RedDotTrapDefenseRougeModeOpen : RedDotBase
{
	// Token: 0x0601AB2F RID: 109359 RVA: 0x0083449F File Offset: 0x0083269F
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseRougeLevel);
	}

	// Token: 0x0601AB30 RID: 109360 RVA: 0x008344AB File Offset: 0x008326AB
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseRougeModeOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601AB31 RID: 109361 RVA: 0x008344C9 File Offset: 0x008326C9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseRougeModeOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601AB32 RID: 109362 RVA: 0x008344E7 File Offset: 0x008326E7
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.RougeModeData.RedDotModeOpen();
	}
}
