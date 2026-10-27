using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x02002934 RID: 10548
[NullableContext(1)]
[Nullable(0)]
public class RouletteInputKeyboard : RouletteInputBase
{
	// Token: 0x06015C35 RID: 89141 RVA: 0x0057D2F8 File Offset: 0x0057B4F8
	[NullableContext(2)]
	public RouletteInputKeyboard(Vector2D pos = null, ERouletteViewType? rouletteViewType = null, int? touchId = null, float? limit = null) : base(pos, rouletteViewType, null, null)
	{
	}

	// Token: 0x06015C36 RID: 89142 RVA: 0x0057D34C File Offset: 0x0057B54C
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

	// Token: 0x06015C37 RID: 89143 RVA: 0x0057D3FC File Offset: 0x0057B5FC
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

	// Token: 0x0400A223 RID: 41507
	private readonly Vector SubtractVectorPos = Vector.Create();

	// Token: 0x0400A224 RID: 41508
	private readonly Vector BeginVectorPos = Vector.Create();

	// Token: 0x0400A225 RID: 41509
	private readonly Vector TempVectorPos = Vector.Create();

	// Token: 0x0400A226 RID: 41510
	private readonly Vector CheckVectorPos = Vector.Create();
}
