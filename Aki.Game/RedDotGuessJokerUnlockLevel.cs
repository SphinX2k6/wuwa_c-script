using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029A8 RID: 10664
public class RedDotGuessJokerUnlockLevel : RedDotBase
{
	// Token: 0x0601AAEB RID: 109291 RVA: 0x00833DA9 File Offset: 0x00831FA9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnGuessJokerRedDotNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AAEC RID: 109292 RVA: 0x00833DE3 File Offset: 0x00831FE3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnGuessJokerRedDotNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AAED RID: 109293 RVA: 0x00833E1D File Offset: 0x0083201D
	protected override bool OnCheck(int uId = 0)
	{
		return GuessJokerGamePlayModel.Instance.CheckRedDot();
	}

	// Token: 0x0601AAEE RID: 109294 RVA: 0x00833E29 File Offset: 0x00832029
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.SpringManorGameEntrance);
	}
}
