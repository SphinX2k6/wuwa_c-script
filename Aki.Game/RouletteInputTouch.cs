using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x02002935 RID: 10549
[NullableContext(1)]
[Nullable(0)]
public class RouletteInputTouch : RouletteInputBase
{
	// Token: 0x06015C38 RID: 89144 RVA: 0x0057D4F0 File Offset: 0x0057B6F0
	[NullableContext(2)]
	public RouletteInputTouch(Vector2D pos = null, ERouletteViewType? rouletteViewType = null, int? touchId = null, float? limit = null) : base(pos, rouletteViewType, touchId, null)
	{
		this.TouchId = touchId.GetValueOrDefault(-1);
	}

	// Token: 0x06015C39 RID: 89145 RVA: 0x0057D550 File Offset: 0x0057B750
	public unsafe override void OnInit()
	{
		if (this.BeginPos == null)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			if (this.TouchId < 0)
			{
				Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YYZ, "当前轮盘输入方式为触屏,未检测到对应触屏Id或初始位置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.BeginPos = (characterController.GetTouchPosition(this.TouchId) ?? Vector2D.Create());
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[轮盘界面]触屏开启信息";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TouchId", this.TouchId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Pos", this.BeginPos);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.BeginVectorPos.Set(this.BeginPos.X, this.BeginPos.Y, 0.0);
		this.TempVectorPos.Set(this.BeginPos.X, this.BeginPos.Y, 0.0);
		this.SubtractVectorPos.Set(0.0, 0.0, 0.0);
	}

	// Token: 0x06015C3A RID: 89146 RVA: 0x0057D68F File Offset: 0x0057B88F
	protected override void OnDestroy()
	{
		this.IsInTouch = false;
	}

	// Token: 0x06015C3B RID: 89147 RVA: 0x0057D698 File Offset: 0x0057B898
	protected override void InputTick(float delta)
	{
		if (this.RouletteViewType == ERouletteViewType.Assembly)
		{
			return;
		}
		TsCharacterController characterController = Global.CharacterController;
		if (characterController == null)
		{
			return;
		}
		if (this.TouchId < 0)
		{
			base.EndInput();
			return;
		}
		this.IsInTouch = characterController.IsInTouch((float)this.TouchId);
		if (!this.IsInTouch)
		{
			base.EndInput();
			return;
		}
		Vector2D touchPosition = characterController.GetTouchPosition(this.TouchId);
		if (touchPosition == null)
		{
			return;
		}
		this.CheckVectorPos.Set(touchPosition.X, touchPosition.Y, 0.0);
		if (this.CheckVectorPos.Equals(this.TempVectorPos, 9.999999747378752E-05))
		{
			return;
		}
		this.TempVectorPos.Set(this.CheckVectorPos.X, this.CheckVectorPos.Y, 0.0);
		this.CheckVectorPos.Subtraction(this.BeginVectorPos, this.SubtractVectorPos);
		this.Angle = (int)AngleCalculator.GetVectorAngle(this.ForwardVector, this.SubtractVectorPos);
		this.AreaIndex = AngleCalculator.AngleToAreaIndex((double)this.Angle);
	}

	// Token: 0x0400A227 RID: 41511
	private readonly Vector SubtractVectorPos = Vector.Create();

	// Token: 0x0400A228 RID: 41512
	private readonly Vector BeginVectorPos = Vector.Create();

	// Token: 0x0400A229 RID: 41513
	private readonly Vector TempVectorPos = Vector.Create();

	// Token: 0x0400A22A RID: 41514
	private readonly Vector CheckVectorPos = Vector.Create();

	// Token: 0x0400A22B RID: 41515
	private readonly int TouchId = -1;

	// Token: 0x0400A22C RID: 41516
	private bool IsInTouch;
}
