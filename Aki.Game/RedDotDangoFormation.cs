using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028EC RID: 10476
public class RedDotDangoFormation : RedDotBase
{
	// Token: 0x0601A769 RID: 108393 RVA: 0x0082C8C9 File Offset: 0x0082AAC9
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A76A RID: 108394 RVA: 0x0082C8CC File Offset: 0x0082AACC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshAbyssDangoRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A76B RID: 108395 RVA: 0x0082C8EA File Offset: 0x0082AAEA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshAbyssDangoRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A76C RID: 108396 RVA: 0x0082C908 File Offset: 0x0082AB08
	protected override bool OnCheck(int uId = 0)
	{
		return DangoAbyssModel.Instance.GetDangoFormationNewRedDot();
	}
}
