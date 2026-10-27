using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

// Token: 0x02000E8E RID: 3726
public class MotorcycleArrowBlockHandler : IInputHandler
{
	// Token: 0x06005B51 RID: 23377 RVA: 0x0010B019 File Offset: 0x00109219
	public void Init()
	{
	}

	// Token: 0x06005B52 RID: 23378 RVA: 0x0010B01B File Offset: 0x0010921B
	public int GetPriority()
	{
		return 99;
	}

	// Token: 0x06005B53 RID: 23379 RVA: 0x0010B01F File Offset: 0x0010921F
	[NullableContext(1)]
	public InputFilter GetInputFilter()
	{
		return new InputFilter(null, InputFilterManager.CharacterActions, null, InputFilterManager.CharacterAxes);
	}

	// Token: 0x06005B54 RID: 23380 RVA: 0x0010B032 File Offset: 0x00109232
	public void HandlePressEvent(EInputAction action, float time)
	{
	}

	// Token: 0x06005B55 RID: 23381 RVA: 0x0010B034 File Offset: 0x00109234
	public void HandleReleaseEvent(EInputAction action, float time)
	{
	}

	// Token: 0x06005B56 RID: 23382 RVA: 0x0010B036 File Offset: 0x00109236
	public void HandleHoldEvent(EInputAction action, float time)
	{
	}

	// Token: 0x06005B57 RID: 23383 RVA: 0x0010B038 File Offset: 0x00109238
	public void HandleInputAxis(EInputAxis axis, float value)
	{
	}

	// Token: 0x06005B58 RID: 23384 RVA: 0x0010B03A File Offset: 0x0010923A
	public void ClearInputAxis(bool nextFrame)
	{
	}

	// Token: 0x06005B59 RID: 23385 RVA: 0x0010B03C File Offset: 0x0010923C
	public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
	{
	}

	// Token: 0x06005B5A RID: 23386 RVA: 0x0010B03E File Offset: 0x0010923E
	public void PreProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x06005B5B RID: 23387 RVA: 0x0010B040 File Offset: 0x00109240
	public void PostProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x040029B2 RID: 10674
	private const int MOTORARROW_BLOCK_PRIORITY = 99;
}
