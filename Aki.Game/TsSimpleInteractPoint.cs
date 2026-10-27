using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.World;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020032B2 RID: 12978
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractPoint.TsSimpleInteractPoint_C")]
public class TsSimpleInteractPoint : TsSimpleInteractBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170026D8 RID: 9944
	// (get) Token: 0x0601C1F9 RID: 115193 RVA: 0x007D4215 File Offset: 0x007D2415
	// (set) Token: 0x0601C1FA RID: 115194 RVA: 0x007D4225 File Offset: 0x007D2425
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

	// Token: 0x0601C1FB RID: 115195 RVA: 0x007D4236 File Offset: 0x007D2436
	protected override void OnBeginPlay()
	{
		this.OutRotator = Rotator.Create();
		this.TmpLocation = Vector.Create();
		base.OnBeginPlay();
	}

	// Token: 0x0601C1FC RID: 115196 RVA: 0x007D4254 File Offset: 0x007D2454
	protected override bool CheckLegal()
	{
		return true;
	}

	// Token: 0x0601C1FD RID: 115197 RVA: 0x007D4258 File Offset: 0x007D2458
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

	// Token: 0x0601C1FE RID: 115198 RVA: 0x007D42DC File Offset: 0x007D24DC
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

	// Token: 0x0601C1FF RID: 115199 RVA: 0x007D4354 File Offset: 0x007D2554
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

	// Token: 0x0601C200 RID: 115200 RVA: 0x007D469F File Offset: 0x007D289F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleInteractPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractPoint.TsSimpleInteractPoint_C");
		}
		return TsSimpleInteractPoint._ClassPtr;
	}

	// Token: 0x0601C201 RID: 115201 RVA: 0x007D46C4 File Offset: 0x007D28C4
	public TsSimpleInteractPoint() : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C202 RID: 115202 RVA: 0x007D46EC File Offset: 0x007D28EC
	public TsSimpleInteractPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C203 RID: 115203 RVA: 0x007D471F File Offset: 0x007D291F
	protected TsSimpleInteractPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400DE77 RID: 56951
	private static readonly FLinearColor RedColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400DE78 RID: 56952
	private static readonly FLinearColor BlueColor = new FLinearColor(0f, 0f, 1f, 1f);

	// Token: 0x0400DE79 RID: 56953
	private const float DRAW_TIME = 0.05f;

	// Token: 0x0400DE7A RID: 56954
	private const float DEFAULT_THICKNESS = 4f;

	// Token: 0x0400DE7B RID: 56955
	private const float DEFAULT_ARROW_SIZE = 20f;

	// Token: 0x0400DE7C RID: 56956
	private const float DRAW_LENGTH = 100f;

	// Token: 0x0400DE7D RID: 56957
	[StaticVariableRuleIgnore]
	private static readonly Vector ForwardOffset = Vector.Create(100.0, 0.0, 0.0);

	// Token: 0x0400DE7E RID: 56958
	[StaticVariableRuleIgnore]
	private static readonly Vector UpOffset = Vector.Create(0.0, 0.0, 100.0);

	// Token: 0x0400DE7F RID: 56959
	private static readonly FColor TextColor = new FColor(byte.MaxValue, 128, 128, byte.MaxValue);

	// Token: 0x0400DE80 RID: 56960
	private const float TEXT_SIZE = 80f;

	// Token: 0x0400DE81 RID: 56961
	private const string PROFILE_KEY = "TsSimpleInteractPoint_GetBestTransform";

	// Token: 0x0400DE82 RID: 56962
	[Nullable(2)]
	private Rotator OutRotator;

	// Token: 0x0400DE83 RID: 56963
	[Nullable(2)]
	private Vector TmpLocation;

	// Token: 0x0400DE84 RID: 56964
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractPoint.TsSimpleInteractPoint_C";

	// Token: 0x0400DE85 RID: 56965
	private static IntPtr _ClassPtr;

	// Token: 0x0400DE86 RID: 56966
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DE87 RID: 56967
	private static int __PropertyOffset_OnWall;
}
