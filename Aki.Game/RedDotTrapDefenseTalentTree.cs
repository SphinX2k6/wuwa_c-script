using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02003448 RID: 13384
public class RedDotTrapDefenseTalentTree : RedDotBase
{
	// Token: 0x0601CE34 RID: 118324 RVA: 0x0080DE18 File Offset: 0x0080C018
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefense);
	}

	// Token: 0x0601CE35 RID: 118325 RVA: 0x0080DE24 File Offset: 0x0080C024
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseTalentTree, new Action(base.EventCheck));
	}

	// Token: 0x0601CE36 RID: 118326 RVA: 0x0080DE42 File Offset: 0x0080C042
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseTalentTree, new Action(base.EventCheck));
	}

	// Token: 0x0601CE37 RID: 118327 RVA: 0x0080DE60 File Offset: 0x0080C060
	protected override bool OnCheck(int uId = 0)
	{
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		return instance != null && instance.TalentTreeData.HasAnyNodeCanUnlockAndAfford();
	}
}
