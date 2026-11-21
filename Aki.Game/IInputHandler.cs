using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

// Token: 0x02000291 RID: 657
[NullableContext(1)]
public interface IInputHandler
{
	// Token: 0x060028C1 RID: 10433
	int GetPriority();

	// Token: 0x060028C2 RID: 10434
	InputFilter GetInputFilter();

	// Token: 0x060028C3 RID: 10435
	void HandlePressEvent(EInputAction action, float time);

	// Token: 0x060028C4 RID: 10436
	void HandleReleaseEvent(EInputAction action, float time);

	// Token: 0x060028C5 RID: 10437
	void HandleHoldEvent(EInputAction action, float time);

	// Token: 0x060028C6 RID: 10438
	void HandleInputAxis(EInputAxis axis, float value);

	// Token: 0x060028C7 RID: 10439
	void ClearInputAxis(bool nextFrame);

	// Token: 0x060028C8 RID: 10440
	void ClearSingleAxisInput(EInputAxis axis, bool nextFrame);

	// Token: 0x060028C9 RID: 10441
	void PreProcessInput(float deltaTime, bool gamePaused);

	// Token: 0x060028CA RID: 10442
	void PostProcessInput(float deltaTime, bool gamePaused);
}
