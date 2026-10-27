using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

// Token: 0x02000DDF RID: 3551
[NullableContext(1)]
public interface IInputHandler
{
	// Token: 0x06005537 RID: 21815
	int GetPriority();

	// Token: 0x06005538 RID: 21816
	InputFilter GetInputFilter();

	// Token: 0x06005539 RID: 21817
	void HandlePressEvent(EInputAction action, float time);

	// Token: 0x0600553A RID: 21818
	void HandleReleaseEvent(EInputAction action, float time);

	// Token: 0x0600553B RID: 21819
	void HandleHoldEvent(EInputAction action, float time);

	// Token: 0x0600553C RID: 21820
	void HandleInputAxis(EInputAxis axis, float value);

	// Token: 0x0600553D RID: 21821
	void ClearInputAxis(bool nextFrame);

	// Token: 0x0600553E RID: 21822
	void ClearSingleAxisInput(EInputAxis axis, bool nextFrame);

	// Token: 0x0600553F RID: 21823
	void PreProcessInput(float deltaTime, bool gamePaused);

	// Token: 0x06005540 RID: 21824
	void PostProcessInput(float deltaTime, bool gamePaused);
}
