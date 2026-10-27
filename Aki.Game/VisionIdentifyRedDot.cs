using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200344F RID: 13391
public class VisionIdentifyRedDot : RedDotBase
{
	// Token: 0x0601CE57 RID: 118359 RVA: 0x0080E164 File Offset: 0x0080C364
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomLevelUpWithId, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnVisionIdentifyWithId, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RefreshVisionIdentifyRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE58 RID: 118360 RVA: 0x0080E1C8 File Offset: 0x0080C3C8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomLevelUpWithId, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnVisionIdentifyWithId, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RefreshVisionIdentifyRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE59 RID: 118361 RVA: 0x0080E229 File Offset: 0x0080C429
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomBattleModel.Instance.CheckVisionIdentifyRedDot(uId);
	}
}
