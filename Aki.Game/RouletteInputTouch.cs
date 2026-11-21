using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x02001EB0 RID: 7856
[NullableContext(1)]
[Nullable(0)]
public class RouletteInputTouch : RouletteInputBase
{
	// Token: 0x0601363D RID: 79421 RVA: 0x005A8530 File Offset: 0x005A6730
	[NullableContext(2)]
	public RouletteInputTouch(Vector2D pos = null, ERouletteViewType? rouletteViewType = null, int? touchId = null, float? limit = null) : base(pos, rouletteViewType, touchId, null)
	{
		this.TouchId = touchId.GetValueOrDefault(-1);
	}

	// Token: 0x0601363E RID: 79422 RVA: 0x005A8590 File Offset: 0x005A6790
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

	// Token: 0x0601363F RID: 79423 RVA: 0x005A86CF File Offset: 0x005A68CF
	protected override void OnDestroy()
	{
		this.IsInTouch = false;
	}

	// Token: 0x06013640 RID: 79424 RVA: 0x005A86D8 File Offset: 0x005A68D8
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

	// Token: 0x0400A612 RID: 42514
	private readonly Vector SubtractVectorPos = Vector.Create();

	// Token: 0x0400A613 RID: 42515
	private readonly Vector BeginVectorPos = Vector.Create();

	// Token: 0x0400A614 RID: 42516
	private readonly Vector TempVectorPos = Vector.Create();

	// Token: 0x0400A615 RID: 42517
	private readonly Vector CheckVectorPos = Vector.Create();

	// Token: 0x0400A616 RID: 42518
	private readonly int TouchId = -1;

	// Token: 0x0400A617 RID: 42519
	private bool IsInTouch;
}
