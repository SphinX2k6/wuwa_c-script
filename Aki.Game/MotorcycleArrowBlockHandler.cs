using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

// Token: 0x02000343 RID: 835
public class MotorcycleArrowBlockHandler : IInputHandler
{
	// Token: 0x06002EE8 RID: 12008 RVA: 0x00112CB1 File Offset: 0x00110EB1
	public void Init()
	{
	}

	// Token: 0x06002EE9 RID: 12009 RVA: 0x00112CB3 File Offset: 0x00110EB3
	public int GetPriority()
	{
		return 99;
	}

	// Token: 0x06002EEA RID: 12010 RVA: 0x00112CB7 File Offset: 0x00110EB7
	[NullableContext(1)]
	public InputFilter GetInputFilter()
	{
		return new InputFilter(null, InputFilterManager.CharacterActions, null, InputFilterManager.CharacterAxes);
	}

	// Token: 0x06002EEB RID: 12011 RVA: 0x00112CCA File Offset: 0x00110ECA
	public void HandlePressEvent(EInputAction action, float time)
	{
	}

	// Token: 0x06002EEC RID: 12012 RVA: 0x00112CCC File Offset: 0x00110ECC
	public void HandleReleaseEvent(EInputAction action, float time)
	{
	}

	// Token: 0x06002EED RID: 12013 RVA: 0x00112CCE File Offset: 0x00110ECE
	public void HandleHoldEvent(EInputAction action, float time)
	{
	}

	// Token: 0x06002EEE RID: 12014 RVA: 0x00112CD0 File Offset: 0x00110ED0
	public void HandleInputAxis(EInputAxis axis, float value)
	{
	}

	// Token: 0x06002EEF RID: 12015 RVA: 0x00112CD2 File Offset: 0x00110ED2
	public void ClearInputAxis(bool nextFrame)
	{
	}

	// Token: 0x06002EF0 RID: 12016 RVA: 0x00112CD4 File Offset: 0x00110ED4
	public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
	{
	}

	// Token: 0x06002EF1 RID: 12017 RVA: 0x00112CD6 File Offset: 0x00110ED6
	public void PreProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x06002EF2 RID: 12018 RVA: 0x00112CD8 File Offset: 0x00110ED8
	public void PostProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x04002A4D RID: 10829
	private const int MOTORARROW_BLOCK_PRIORITY = 99;
}
