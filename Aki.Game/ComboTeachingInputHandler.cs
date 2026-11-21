using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

// Token: 0x02000C80 RID: 3200
public class ComboTeachingInputHandler : IInputHandler
{
	// Token: 0x060085AD RID: 34221 RVA: 0x0028DB1D File Offset: 0x0028BD1D
	public int GetPriority()
	{
		return 1;
	}

	// Token: 0x060085AE RID: 34222 RVA: 0x0028DB20 File Offset: 0x0028BD20
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

	// Token: 0x060085AF RID: 34223 RVA: 0x0028DB97 File Offset: 0x0028BD97
	public void HandlePressEvent(EInputAction action, float time)
	{
		EventSystem.Instance.Emit<EInputAction, float>(EEventName.ComboTeachingPress, action, time);
	}

	// Token: 0x060085B0 RID: 34224 RVA: 0x0028DBAB File Offset: 0x0028BDAB
	public void HandleReleaseEvent(EInputAction action, float time)
	{
		EventSystem.Instance.Emit<EInputAction, float>(EEventName.ComboTeachingRelease, action, time);
	}

	// Token: 0x060085B1 RID: 34225 RVA: 0x0028DBBF File Offset: 0x0028BDBF
	public void HandleHoldEvent(EInputAction action, float time)
	{
		EventSystem.Instance.Emit<EInputAction, float>(EEventName.ComboTeachingHold, action, time);
	}

	// Token: 0x060085B2 RID: 34226 RVA: 0x0028DBD3 File Offset: 0x0028BDD3
	public void HandleInputAxis(EInputAxis axis, float value)
	{
	}

	// Token: 0x060085B3 RID: 34227 RVA: 0x0028DBD5 File Offset: 0x0028BDD5
	public void ClearInputAxis(bool nextFrame)
	{
	}

	// Token: 0x060085B4 RID: 34228 RVA: 0x0028DBD7 File Offset: 0x0028BDD7
	public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
	{
	}

	// Token: 0x060085B5 RID: 34229 RVA: 0x0028DBD9 File Offset: 0x0028BDD9
	public void PreProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x060085B6 RID: 34230 RVA: 0x0028DBDB File Offset: 0x0028BDDB
	public void PostProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x04005157 RID: 20823
	[Nullable(2)]
	public InputFilter InputFilter;
}
