using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.World;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002821 RID: 10273
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractHookPoint.TsSimpleInteractHookPoint_C")]
public class TsSimpleInteractHookPoint : TsSimpleInteractBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06019E1F RID: 106015 RVA: 0x007F9B4D File Offset: 0x007F7D4D
	protected override bool CheckLegal()
	{
		return true;
	}

	// Token: 0x06019E20 RID: 106016 RVA: 0x007F9B50 File Offset: 0x007F7D50
	protected override void OnDraw()
	{
		FVectorDouble lineStart = base.D_K2_GetActorLocation();
		FTransformDouble ftransformDouble = base.D_GetTransform();
		UKismetSystemLibrary.D_DrawDebugArrow(this, lineStart, ftransformDouble.TransformPosition(TsSimpleInteractHookPoint.forwardOffset), 20f, TsSimpleInteractHookPoint.redColor, 0.05f, 4f);
		UKismetSystemLibrary.D_DrawDebugArrow(this, lineStart, ftransformDouble.TransformPosition(TsSimpleInteractHookPoint.upOffset), 20f, TsSimpleInteractHookPoint.blueColor, 0.05f, 4f);
	}

	// Token: 0x06019E21 RID: 106017 RVA: 0x007F9BBC File Offset: 0x007F7DBC
	protected override void SetText(FVector offset)
	{
		base.Text.HorizontalAlignment = EHorizTextAligment.EHTA_Center;
		base.Text.SetWorldSize(80f);
		base.Text.SetTextRenderColor(TsSimpleInteractHookPoint.textColor);
		UTextRenderComponent text = base.Text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HookPoint ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(base.TypeId);
		text.Text = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06019E22 RID: 106018 RVA: 0x007F9C34 File Offset: 0x007F7E34
	protected override SSimpleInteractResult OnGetBestTransform(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		Vector actorLocation = this.ActorLocation;
		FVectorDouble fvectorDouble = actor.D_K2_GetActorLocation();
		actorLocation.FromUeVector(fvectorDouble);
		this.ActorLocation.Subtraction(this.SelfLocation, this.SelfToActor);
		this.TmpVector1.X = (double)radius;
		this.TmpVector1.Y = 0.0;
		this.TmpVector1.Z = 0.0;
		if (this.TmpLocation == null)
		{
			this.TmpLocation = Vector.Create();
		}
		this.SelfTransform.TransformPosition(this.TmpVector1, this.TmpLocation);
		this.TmpResult.Location = this.TmpLocation.ToUeVectorOld();
		this.LineTrace.WorldContextObject = actor;
		TraceElementCommon.Instance.SetStartLocation(this.LineTrace, this.ActorLocation);
		TraceElementCommon.Instance.SetEndLocation(this.LineTrace, this.TmpResult.Location);
		this.TmpResult.Success = !TraceElementCommon.Instance.LineTrace(this.LineTrace, "TsSimpleInteractHookPoint_GetBestTransform");
		this.LineTrace.WorldContextObject = null;
		bool success = this.TmpResult.Success;
		return this.TmpResult;
	}

	// Token: 0x06019E23 RID: 106019 RVA: 0x007F9D66 File Offset: 0x007F7F66
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleInteractHookPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractHookPoint.TsSimpleInteractHookPoint_C");
		}
		return TsSimpleInteractHookPoint._ClassPtr;
	}

	// Token: 0x06019E24 RID: 106020 RVA: 0x007F9D8C File Offset: 0x007F7F8C
	public TsSimpleInteractHookPoint() : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractHookPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019E25 RID: 106021 RVA: 0x007F9DB4 File Offset: 0x007F7FB4
	public TsSimpleInteractHookPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractHookPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019E26 RID: 106022 RVA: 0x007F9DE7 File Offset: 0x007F7FE7
	protected TsSimpleInteractHookPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E2ED RID: 58093
	private static readonly FLinearColor redColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400E2EE RID: 58094
	private static readonly FLinearColor blueColor = new FLinearColor(0f, 0f, 1f, 1f);

	// Token: 0x0400E2EF RID: 58095
	private const float DRAW_TIME = 0.05f;

	// Token: 0x0400E2F0 RID: 58096
	private const float DEFAULT_THICKNESS = 4f;

	// Token: 0x0400E2F1 RID: 58097
	private const float DEFAULT_ARROW_SIZE = 20f;

	// Token: 0x0400E2F2 RID: 58098
	private const float DRAW_LENGTH = 100f;

	// Token: 0x0400E2F3 RID: 58099
	private static readonly FVectorDouble forwardOffset = new FVectorDouble(100.0, 0.0, 0.0);

	// Token: 0x0400E2F4 RID: 58100
	private static readonly FVectorDouble upOffset = new FVectorDouble(0.0, 0.0, 100.0);

	// Token: 0x0400E2F5 RID: 58101
	private static readonly FColor textColor = new FColor(byte.MaxValue, 128, 128, byte.MaxValue);

	// Token: 0x0400E2F6 RID: 58102
	private const float TEXT_SIZE = 80f;

	// Token: 0x0400E2F7 RID: 58103
	private const string PROFILE_KEY = "TsSimpleInteractHookPoint_GetBestTransform";

	// Token: 0x0400E2F8 RID: 58104
	[Nullable(2)]
	private Vector TmpLocation;

	// Token: 0x0400E2F9 RID: 58105
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractHookPoint.TsSimpleInteractHookPoint_C";

	// Token: 0x0400E2FA RID: 58106
	private static IntPtr _ClassPtr;

	// Token: 0x0400E2FB RID: 58107
	private static IntPtr _ClassDefaultObjectPtr;
}
