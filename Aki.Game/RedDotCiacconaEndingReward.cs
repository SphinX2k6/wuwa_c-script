using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CiacconaGal;

// Token: 0x02003374 RID: 13172
public class RedDotCiacconaEndingReward : RedDotBase
{
	// Token: 0x0601CA57 RID: 117335 RVA: 0x00805FE4 File Offset: 0x008041E4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CA58 RID: 117336 RVA: 0x00806002 File Offset: 0x00804202
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CA59 RID: 117337 RVA: 0x00806020 File Offset: 0x00804220
	protected override bool OnCheck(int uId = 0)
	{
		return CiacconaGalModel.Instance.HasAnyEndingReward();
	}
}
