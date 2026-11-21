using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.World;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002823 RID: 10275
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractPoint.TsSimpleInteractPoint_C")]
public class TsSimpleInteractPoint : TsSimpleInteractBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170029C5 RID: 10693
	// (get) Token: 0x06019E3A RID: 106042 RVA: 0x007FB311 File Offset: 0x007F9511
	// (set) Token: 0x06019E3B RID: 106043 RVA: 0x007FB321 File Offset: 0x007F9521
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OnWall
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleInteractPoint.__PropertyOffset_OnWall) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleInteractPoint.__PropertyOffset_OnWall) = (value ? 1 : 0);
		}
	}

	// Token: 0x06019E3C RID: 106044 RVA: 0x007FB332 File Offset: 0x007F9532
	protected override void OnBeginPlay()
	{
		this.OutRotator = Rotator.Create();
		this.TmpLocation = Vector.Create();
		base.OnBeginPlay();
	}

	// Token: 0x06019E3D RID: 106045 RVA: 0x007FB350 File Offset: 0x007F9550
	protected override bool CheckLegal()
	{
		return true;
	}

	// Token: 0x06019E3E RID: 106046 RVA: 0x007FB354 File Offset: 0x007F9554
	protected override void OnDraw()
	{
		FVectorDouble fvectorDouble = base.D_K2_GetActorLocation();
		FTransformDouble ftransformDouble = base.D_GetTransform();
		FVectorDouble fvectorDouble2;
		if (this.OnWall)
		{
			FVectorDouble lineStart = fvectorDouble;
			fvectorDouble2 = TsSimpleInteractPoint.ForwardOffset.ToUeVector(false);
			UKismetSystemLibrary.D_DrawDebugArrow(this, lineStart, ftransformDouble.TransformPosition(fvectorDouble2), 20f, TsSimpleInteractPoint.RedColor, 0.05f, 4f);
			return;
		}
		FVectorDouble lineStart2 = fvectorDouble;
		fvectorDouble2 = TsSimpleInteractPoint.UpOffset.ToUeVector(false);
		UKismetSystemLibrary.D_DrawDebugArrow(this, lineStart2, ftransformDouble.TransformPosition(fvectorDouble2), 20f, TsSimpleInteractPoint.BlueColor, 0.05f, 4f);
	}

	// Token: 0x06019E3F RID: 106047 RVA: 0x007FB3D8 File Offset: 0x007F95D8
	protected override void SetText(FVector offset)
	{
		base.Text.HorizontalAlignment = EHorizTextAligment.EHTA_Center;
		base.Text.SetWorldSize(80f);
		base.Text.SetTextRenderColor(TsSimpleInteractPoint.TextColor);
		UTextRenderComponent text = base.Text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Point ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(base.TypeId);
		text.Text = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06019E40 RID: 106048 RVA: 0x007FB450 File Offset: 0x007F9650
	protected override SSimpleInteractResult OnGetBestTransform(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		this.UpdateData();
		Vector actorLocation = this.ActorLocation;
		FVectorDouble fvectorDouble = actor.D_K2_GetActorLocation();
		actorLocation.FromUeVector(fvectorDouble);
		this.ActorLocation.Subtraction(this.SelfLocation, this.SelfToActor);
		if (this.OnWall && MathUtils.Instance.DotProduct(this.SelfToActor, base.GetActorForwardVector()) > (double)radius)
		{
			return this.TmpResult;
		}
		if (this.OnWall)
		{
			this.TmpVector1.X = (double)radius;
			this.TmpVector1.Y = 0.0;
			this.TmpVector1.Z = 0.0;
		}
		else
		{
			this.TmpVector1.X = 0.0;
			this.TmpVector1.Y = 0.0;
			this.TmpVector1.Z = (double)halfHeight;
		}
		this.SelfTransform.TransformPosition(this.TmpVector1, this.TmpLocation);
		this.TmpResult.Location = this.TmpLocation.ToUeVectorOld();
		if (!this.OnWall)
		{
			this.TmpResult.Success = true;
			this.MoveOffset.FromUeVector(moveOffset);
			this.SelfLocation.Subtraction(this.ActorLocation, this.TmpVector1);
			this.TmpResult.SquaredOffsetLength = (float)(MathUtils.Instance.Square(this.SelfToActor.Size2D() - this.MoveOffset.Size2D()) + MathUtils.Instance.Square(this.SelfToActor.Z + this.MoveOffset.Z));
			this.SelfTransform.GetRotation().RotateVector(Vector.UpVectorProxy, this.TmpVector2);
			MathUtils.Instance.LookRotationForwardFirst(this.TmpVector1, this.TmpVector2, this.OutRotator);
			this.TmpResult.Rotator = this.OutRotator.ToUeRotator();
			return this.TmpResult;
		}
		UTraceLineElement lineTrace = this.LineTrace;
		lineTrace.WorldContextObject = actor;
		TraceElementCommon.Instance.SetStartLocation(lineTrace, this.ActorLocation);
		TraceElementCommon.Instance.SetEndLocation(lineTrace, this.TmpResult.Location);
		this.TmpResult.Success = !TraceElementCommon.Instance.LineTrace(lineTrace, "TsSimpleInteractPoint_GetBestTransform");
		lineTrace.WorldContextObject = null;
		if (!this.TmpResult.Success)
		{
			return this.TmpResult;
		}
		this.MoveOffset.FromUeVector(moveOffset);
		this.SelfLocation.Subtraction(this.ActorLocation, this.TmpVector1);
		this.TmpResult.SquaredOffsetLength = (float)(MathUtils.Instance.Square(this.SelfToActor.Size2D() - this.MoveOffset.Size2D()) + MathUtils.Instance.Square(this.SelfToActor.Z + this.MoveOffset.Z));
		Quat rotation = this.SelfTransform.GetRotation();
		rotation.RotateVector(Vector.ForwardVectorProxy, this.TmpVector1);
		rotation.RotateVector(Vector.UpVectorProxy, this.TmpVector2);
		this.TmpVector1.UnaryNegation(this.TmpVector1);
		MathUtils.Instance.LookRotationForwardFirst(this.TmpVector1, this.TmpVector2, this.OutRotator);
		this.TmpResult.Rotator = this.OutRotator.ToUeRotator();
		return this.TmpResult;
	}

	// Token: 0x06019E41 RID: 106049 RVA: 0x007FB79B File Offset: 0x007F999B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleInteractPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractPoint.TsSimpleInteractPoint_C");
		}
		return TsSimpleInteractPoint._ClassPtr;
	}

	// Token: 0x06019E42 RID: 106050 RVA: 0x007FB7C0 File Offset: 0x007F99C0
	public TsSimpleInteractPoint() : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019E43 RID: 106051 RVA: 0x007FB7E8 File Offset: 0x007F99E8
	public TsSimpleInteractPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019E44 RID: 106052 RVA: 0x007FB81B File Offset: 0x007F9A1B
	protected TsSimpleInteractPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E31D RID: 58141
	private static readonly FLinearColor RedColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400E31E RID: 58142
	private static readonly FLinearColor BlueColor = new FLinearColor(0f, 0f, 1f, 1f);

	// Token: 0x0400E31F RID: 58143
	private const float DRAW_TIME = 0.05f;

	// Token: 0x0400E320 RID: 58144
	private const float DEFAULT_THICKNESS = 4f;

	// Token: 0x0400E321 RID: 58145
	private const float DEFAULT_ARROW_SIZE = 20f;

	// Token: 0x0400E322 RID: 58146
	private const float DRAW_LENGTH = 100f;

	// Token: 0x0400E323 RID: 58147
	[StaticVariableRuleIgnore]
	private static readonly Vector ForwardOffset = Vector.Create(100.0, 0.0, 0.0);

	// Token: 0x0400E324 RID: 58148
	[StaticVariableRuleIgnore]
	private static readonly Vector UpOffset = Vector.Create(0.0, 0.0, 100.0);

	// Token: 0x0400E325 RID: 58149
	private static readonly FColor TextColor = new FColor(byte.MaxValue, 128, 128, byte.MaxValue);

	// Token: 0x0400E326 RID: 58150
	private const float TEXT_SIZE = 80f;

	// Token: 0x0400E327 RID: 58151
	private const string PROFILE_KEY = "TsSimpleInteractPoint_GetBestTransform";

	// Token: 0x0400E328 RID: 58152
	[Nullable(2)]
	private Rotator OutRotator;

	// Token: 0x0400E329 RID: 58153
	[Nullable(2)]
	private Vector TmpLocation;

	// Token: 0x0400E32A RID: 58154
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractPoint.TsSimpleInteractPoint_C";

	// Token: 0x0400E32B RID: 58155
	private static IntPtr _ClassPtr;

	// Token: 0x0400E32C RID: 58156
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E32D RID: 58157
	private static int __PropertyOffset_OnWall;
}
