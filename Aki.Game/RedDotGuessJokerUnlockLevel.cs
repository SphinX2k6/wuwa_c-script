using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003434 RID: 13364
public class RedDotGuessJokerUnlockLevel : RedDotBase
{
	// Token: 0x0601CDEB RID: 118251 RVA: 0x0080D6C1 File Offset: 0x0080B8C1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnGuessJokerRedDotNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CDEC RID: 118252 RVA: 0x0080D6FB File Offset: 0x0080B8FB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnGuessJokerRedDotNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.SpringManorFunctionOpenNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CDED RID: 118253 RVA: 0x0080D735 File Offset: 0x0080B935
	protected override bool OnCheck(int uId = 0)
	{
		return GuessJokerGamePlayModel.Instance.CheckRedDot();
	}

	// Token: 0x0601CDEE RID: 118254 RVA: 0x0080D741 File Offset: 0x0080B941
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.SpringManorGameEntrance);
	}
}
