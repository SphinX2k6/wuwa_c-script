using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.World;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020032B0 RID: 12976
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractHookPoint.TsSimpleInteractHookPoint_C")]
public class TsSimpleInteractHookPoint : TsSimpleInteractBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601C1DE RID: 115166 RVA: 0x007D2A51 File Offset: 0x007D0C51
	protected override bool CheckLegal()
	{
		return true;
	}

	// Token: 0x0601C1DF RID: 115167 RVA: 0x007D2A54 File Offset: 0x007D0C54
	protected override void OnDraw()
	{
		FVectorDouble lineStart = base.D_K2_GetActorLocation();
		FTransformDouble ftransformDouble = base.D_GetTransform();
		UKismetSystemLibrary.D_DrawDebugArrow(this, lineStart, ftransformDouble.TransformPosition(TsSimpleInteractHookPoint.forwardOffset), 20f, TsSimpleInteractHookPoint.redColor, 0.05f, 4f);
		UKismetSystemLibrary.D_DrawDebugArrow(this, lineStart, ftransformDouble.TransformPosition(TsSimpleInteractHookPoint.upOffset), 20f, TsSimpleInteractHookPoint.blueColor, 0.05f, 4f);
	}

	// Token: 0x0601C1E0 RID: 115168 RVA: 0x007D2AC0 File Offset: 0x007D0CC0
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

	// Token: 0x0601C1E1 RID: 115169 RVA: 0x007D2B38 File Offset: 0x007D0D38
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

	// Token: 0x0601C1E2 RID: 115170 RVA: 0x007D2C6A File Offset: 0x007D0E6A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleInteractHookPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractHookPoint.TsSimpleInteractHookPoint_C");
		}
		return TsSimpleInteractHookPoint._ClassPtr;
	}

	// Token: 0x0601C1E3 RID: 115171 RVA: 0x007D2C90 File Offset: 0x007D0E90
	public TsSimpleInteractHookPoint() : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractHookPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C1E4 RID: 115172 RVA: 0x007D2CB8 File Offset: 0x007D0EB8
	public TsSimpleInteractHookPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractHookPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C1E5 RID: 115173 RVA: 0x007D2CEB File Offset: 0x007D0EEB
	protected TsSimpleInteractHookPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400DE47 RID: 56903
	private static readonly FLinearColor redColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400DE48 RID: 56904
	private static readonly FLinearColor blueColor = new FLinearColor(0f, 0f, 1f, 1f);

	// Token: 0x0400DE49 RID: 56905
	private const float DRAW_TIME = 0.05f;

	// Token: 0x0400DE4A RID: 56906
	private const float DEFAULT_THICKNESS = 4f;

	// Token: 0x0400DE4B RID: 56907
	private const float DEFAULT_ARROW_SIZE = 20f;

	// Token: 0x0400DE4C RID: 56908
	private const float DRAW_LENGTH = 100f;

	// Token: 0x0400DE4D RID: 56909
	private static readonly FVectorDouble forwardOffset = new FVectorDouble(100.0, 0.0, 0.0);

	// Token: 0x0400DE4E RID: 56910
	private static readonly FVectorDouble upOffset = new FVectorDouble(0.0, 0.0, 100.0);

	// Token: 0x0400DE4F RID: 56911
	private static readonly FColor textColor = new FColor(byte.MaxValue, 128, 128, byte.MaxValue);

	// Token: 0x0400DE50 RID: 56912
	private const float TEXT_SIZE = 80f;

	// Token: 0x0400DE51 RID: 56913
	private const string PROFILE_KEY = "TsSimpleInteractHookPoint_GetBestTransform";

	// Token: 0x0400DE52 RID: 56914
	[Nullable(2)]
	private Vector TmpLocation;

	// Token: 0x0400DE53 RID: 56915
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractHookPoint.TsSimpleInteractHookPoint_C";

	// Token: 0x0400DE54 RID: 56916
	private static IntPtr _ClassPtr;

	// Token: 0x0400DE55 RID: 56917
	private static IntPtr _ClassDefaultObjectPtr;
}
