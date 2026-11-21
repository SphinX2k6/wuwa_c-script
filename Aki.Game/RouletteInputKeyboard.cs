using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x02001EAF RID: 7855
[NullableContext(1)]
[Nullable(0)]
public class RouletteInputKeyboard : RouletteInputBase
{
	// Token: 0x0601363A RID: 79418 RVA: 0x005A8338 File Offset: 0x005A6538
	[NullableContext(2)]
	public RouletteInputKeyboard(Vector2D pos = null, ERouletteViewType? rouletteViewType = null, int? touchId = null, float? limit = null) : base(pos, rouletteViewType, null, null)
	{
	}

	// Token: 0x0601363B RID: 79419 RVA: 0x005A838C File Offset: 0x005A658C
	public override void OnInit()
	{
		if (this.BeginPos == null)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			this.BeginPos = (characterController.GetCursorPosition() ?? Vector2D.Create());
		}
		this.BeginVectorPos.Set(this.BeginPos.X, this.BeginPos.Y, 0.0);
		this.TempVectorPos.Set(this.BeginPos.X, this.BeginPos.Y, 0.0);
		this.SubtractVectorPos.Set(0.0, 0.0, 0.0);
	}

	// Token: 0x0601363C RID: 79420 RVA: 0x005A843C File Offset: 0x005A663C
	protected override void InputTick(float delta)
	{
		TsCharacterController characterController = Global.CharacterController;
		if (characterController == null)
		{
			return;
		}
		Vector2D cursorPosition = characterController.GetCursorPosition();
		if (cursorPosition == null)
		{
			return;
		}
		this.CheckVectorPos.Set(cursorPosition.X, cursorPosition.Y, 0.0);
		if (this.CheckVectorPos.Equals(this.TempVectorPos, 1.0))
		{
			return;
		}
		this.CheckVectorPos.Subtraction(this.BeginVectorPos, this.SubtractVectorPos);
		if (this.NeedEmptyChoose && this.SubtractVectorPos.Size() <= 100.0)
		{
			this.AreaIndex = 0;
			return;
		}
		this.TempVectorPos.Set(this.CheckVectorPos.X, this.CheckVectorPos.Y, 0.0);
		this.Angle = (int)AngleCalculator.GetVectorAngle(this.ForwardVector, this.SubtractVectorPos);
		this.AreaIndex = AngleCalculator.AngleToAreaIndex((double)this.Angle);
	}

	// Token: 0x0400A60E RID: 42510
	private readonly Vector SubtractVectorPos = Vector.Create();

	// Token: 0x0400A60F RID: 42511
	private readonly Vector BeginVectorPos = Vector.Create();

	// Token: 0x0400A610 RID: 42512
	private readonly Vector TempVectorPos = Vector.Create();

	// Token: 0x0400A611 RID: 42513
	private readonly Vector CheckVectorPos = Vector.Create();
}
