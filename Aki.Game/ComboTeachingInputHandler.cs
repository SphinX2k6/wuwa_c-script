using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

// Token: 0x020017C7 RID: 6087
public class ComboTeachingInputHandler : IInputHandler
{
	// Token: 0x0600B1C5 RID: 45509 RVA: 0x00283575 File Offset: 0x00281775
	public int GetPriority()
	{
		return 1;
	}

	// Token: 0x0600B1C6 RID: 45510 RVA: 0x00283578 File Offset: 0x00281778
	[NullableContext(1)]
	public InputFilter GetInputFilter()
	{
		if (this.InputFilter == null)
		{
			this.InputFilter = new InputFilter(new EInputAction[]
			{
				EInputAction.攻击,
				EInputAction.大招,
				EInputAction.跳跃,
				EInputAction.闪避,
				EInputAction.技能1,
				EInputAction.瞄准
			}, null, null, null);
		}
		return this.InputFilter;
	}

	// Token: 0x0600B1C7 RID: 45511 RVA: 0x002835EF File Offset: 0x002817EF
	public void HandlePressEvent(EInputAction action, float time)
	{
		EventSystem.Instance.Emit<EInputAction, float>(EEventName.ComboTeachingPress, action, time);
	}

	// Token: 0x0600B1C8 RID: 45512 RVA: 0x00283603 File Offset: 0x00281803
	public void HandleReleaseEvent(EInputAction action, float time)
	{
		EventSystem.Instance.Emit<EInputAction, float>(EEventName.ComboTeachingRelease, action, time);
	}

	// Token: 0x0600B1C9 RID: 45513 RVA: 0x00283617 File Offset: 0x00281817
	public void HandleHoldEvent(EInputAction action, float time)
	{
		EventSystem.Instance.Emit<EInputAction, float>(EEventName.ComboTeachingHold, action, time);
	}

	// Token: 0x0600B1CA RID: 45514 RVA: 0x0028362B File Offset: 0x0028182B
	public void HandleInputAxis(EInputAxis axis, float value)
	{
	}

	// Token: 0x0600B1CB RID: 45515 RVA: 0x0028362D File Offset: 0x0028182D
	public void ClearInputAxis(bool nextFrame)
	{
	}

	// Token: 0x0600B1CC RID: 45516 RVA: 0x0028362F File Offset: 0x0028182F
	public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
	{
	}

	// Token: 0x0600B1CD RID: 45517 RVA: 0x00283631 File Offset: 0x00281831
	public void PreProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x0600B1CE RID: 45518 RVA: 0x00283633 File Offset: 0x00281833
	public void PostProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x040050AC RID: 20652
	[Nullable(2)]
	public InputFilter InputFilter;
}
