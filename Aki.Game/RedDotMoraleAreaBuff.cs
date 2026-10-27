using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033C9 RID: 13257
public class RedDotMoraleAreaBuff : RedDotBase
{
	// Token: 0x0601CBDB RID: 117723 RVA: 0x00808F16 File Offset: 0x00807116
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoraleBuff);
	}

	// Token: 0x0601CBDC RID: 117724 RVA: 0x00808F22 File Offset: 0x00807122
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateMoraleAreaBuff, new Action(base.EventCheck));
	}

	// Token: 0x0601CBDD RID: 117725 RVA: 0x00808F40 File Offset: 0x00807140
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateMoraleAreaBuff, new Action(base.EventCheck));
	}

	// Token: 0x0601CBDE RID: 117726 RVA: 0x00808F5E File Offset: 0x0080715E
	protected override bool OnCheck(int uId = 0)
	{
		return MoraleModel.Instance.RedDotAreaBuff();
	}
}
