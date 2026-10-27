using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Struct;
using AkiClient.Game.Aki.Data.Recorder;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003327 RID: 13095
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsRecordGameplayCue.TsRecordGameplayCue_C")]
public class TsRecordGameplayCue : AKuroRecordEffect, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002799 RID: 10137
	// (get) Token: 0x0601C89C RID: 116892 RVA: 0x00800A5A File Offset: 0x007FEC5A
	// (set) Token: 0x0601C89D RID: 116893 RVA: 0x00800A6E File Offset: 0x007FEC6E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string Path
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsRecordGameplayCue.__PropertyOffset_Path)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsRecordGameplayCue.__PropertyOffset_Path)), value);
		}
	}

	// Token: 0x1700279A RID: 10138
	// (get) Token: 0x0601C89E RID: 116894 RVA: 0x00800A83 File Offset: 0x007FEC83
	// (set) Token: 0x0601C89F RID: 116895 RVA: 0x00800A97 File Offset: 0x007FEC97
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector Position0
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsRecordGameplayCue.__PropertyOffset_Position0);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsRecordGameplayCue.__PropertyOffset_Position0) = value;
		}
	}

	// Token: 0x1700279B RID: 10139
	// (get) Token: 0x0601C8A0 RID: 116896 RVA: 0x00800AAC File Offset: 0x007FECAC
	// (set) Token: 0x0601C8A1 RID: 116897 RVA: 0x00800AC0 File Offset: 0x007FECC0
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe BP_GameplayCueBeamDataAsset_C BeamData
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<BP_GameplayCueBeamDataAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsRecordGameplayCue.__PropertyOffset_BeamData);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsRecordGameplayCue.__PropertyOffset_BeamData, value);
		}
	}

	// Token: 0x0601C8A2 RID: 116898 RVA: 0x00800AD8 File Offset: 0x007FECD8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C8A3 RID: 116899 RVA: 0x00800B48 File Offset: 0x007FED48
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		base.SetActorTickEnabled(false);
	}

	// Token: 0x0601C8A4 RID: 116900 RVA: 0x00800B54 File Offset: 0x007FED54
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)endPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C8A5 RID: 116901 RVA: 0x00800BCD File Offset: 0x007FEDCD
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason endPlayReason)
	{
		this.OnStop();
	}

	// Token: 0x0601C8A6 RID: 116902 RVA: 0x00800BD8 File Offset: 0x007FEDD8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C8A7 RID: 116903 RVA: 0x00800C48 File Offset: 0x007FEE48
	protected virtual void OnPlay_Implementation()
	{
		this.SpawnHookActorRecord();
	}

	// Token: 0x0601C8A8 RID: 116904 RVA: 0x00800C50 File Offset: 0x007FEE50
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnStop()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnStop"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C8A9 RID: 116905 RVA: 0x00800CC0 File Offset: 0x007FEEC0
	protected virtual void OnStop_Implementation()
	{
		TArray<UActorComponent> tarray = base.K2_GetComponentsByClass(UNiagaraComponent.StaticClass());
		for (int i = tarray.Num() - 1; i >= 0; i--)
		{
			base.K2_DestroyComponent(tarray.Get(i));
		}
		base.SetActorTickEnabled(false);
	}

	// Token: 0x0601C8AA RID: 116906 RVA: 0x00800D08 File Offset: 0x007FEF08
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveTick_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C8AB RID: 116907 RVA: 0x00800D80 File Offset: 0x007FEF80
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		this.CurrentTime += deltaSeconds;
		if (this.BeamData == null)
		{
			return;
		}
		int num = this.BeamData.TimeLine.Num();
		if (num < 1)
		{
			return;
		}
		while (this.CurrentIndex < num && this.BeamData.TimeLine.Get(this.CurrentIndex) < this.CurrentTime)
		{
			this.CurrentIndex++;
		}
		SVectorArray svectorArray = this.BeamData.PointPositions.Get(this.CurrentIndex);
		if (this.BeamData.TimeLine.Get(this.CurrentIndex) < this.CurrentTime)
		{
			this.SetSpline(1f, svectorArray, svectorArray);
			return;
		}
		if (this.CurrentIndex > 1)
		{
			SVectorArray prevData = this.BeamData.PointPositions.Get(this.CurrentIndex - 1);
			float num2 = this.BeamData.TimeLine.Get(this.CurrentIndex - 1);
			float num3 = this.BeamData.TimeLine.Get(this.CurrentIndex);
			this.SetSpline((this.CurrentTime - num2) / (num3 - num2), prevData, svectorArray);
		}
	}

	// Token: 0x0601C8AC RID: 116908 RVA: 0x00800E9C File Offset: 0x007FF09C
	private void SpawnHookActorRecord()
	{
		UNiagaraSystem uniagaraSystem = ResourceSystem.Instance.Load<UNiagaraSystem>(this.Path, "js_undefined");
		if (uniagaraSystem == null || !uniagaraSystem.IsValid() || !this.IsValid())
		{
			return;
		}
		UNiagaraComponent uniagaraComponent = (UNiagaraComponent)base.AddComponentByClass(UNiagaraComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName));
		uniagaraComponent.SetAsset(uniagaraSystem, true);
		if (this.BeamData == null)
		{
			base.SetActorTickEnabled(false);
			FVector inValue = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, new FVectorDouble((double)this.Position0.X, (double)this.Position0.Y, (double)this.Position0.Z));
			uniagaraComponent.SetNiagaraVariableVec3("End", inValue);
			return;
		}
		base.SetActorTickEnabled(true);
		this.SplineComponent = (USplineComponent)base.AddComponentByClass(USplineComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName));
		this.SplineComponent.ClearSplinePoints(true);
		UKuroRenderingRuntimeBPPluginBPLibrary.SetNiagaraSplineComponent(uniagaraComponent, "NewSpline", this.SplineComponent);
	}

	// Token: 0x0601C8AD RID: 116909 RVA: 0x00800FAC File Offset: 0x007FF1AC
	private void SetSpline(float alpha, SVectorArray prevData, SVectorArray nextData)
	{
		if (this.SplineComponent == null)
		{
			return;
		}
		int numberOfSplinePoints = this.SplineComponent.GetNumberOfSplinePoints();
		int num = prevData.Vectors.Num();
		int num2 = nextData.Vectors.Num();
		if (num == 0 || num2 == 0)
		{
			return;
		}
		int num3 = Math.Max(num, num2);
		if (numberOfSplinePoints < num3)
		{
			for (int i = numberOfSplinePoints; i < num3; i++)
			{
				FSplinePoint fsplinePoint = new FSplinePoint((float)i, FVector.ZeroVector, FVector.ZeroVector, FVector.ZeroVector, Rotator.ZeroRotator, FVector.OneVector, ESplinePointType.Linear);
				this.SplineComponent.AddPoint(fsplinePoint, true);
			}
		}
		else if (numberOfSplinePoints > num3)
		{
			for (int j = numberOfSplinePoints - 1; j >= num3; j--)
			{
				this.SplineComponent.RemoveSplinePoint(j, true);
			}
		}
		for (int k = 0; k < num3; k++)
		{
			Vector tmpVector = TsRecordGameplayCue.TmpVector;
			FVectorDouble fvectorDouble = prevData.Vectors.Get(Math.Min(k, num - 1));
			tmpVector.FromUeVector(fvectorDouble);
			Vector tmpVector2 = TsRecordGameplayCue.TmpVector2;
			fvectorDouble = nextData.Vectors.Get(Math.Min(k, num2 - 1));
			tmpVector2.FromUeVector(fvectorDouble);
			Vector.Lerp(TsRecordGameplayCue.TmpVector, TsRecordGameplayCue.TmpVector2, (double)alpha, TsRecordGameplayCue.TmpVector);
			USplineComponent splineComponent = this.SplineComponent;
			int pointIndex = k;
			fvectorDouble = TsRecordGameplayCue.TmpVector.ToUeVector(false);
			splineComponent.D_SetLocationAtSplinePoint(pointIndex, fvectorDouble, ESplineCoordinateSpace.World, true);
		}
	}

	// Token: 0x0601C8AE RID: 116910 RVA: 0x008010F6 File Offset: 0x007FF2F6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsRecordGameplayCue._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsRecordGameplayCue.TsRecordGameplayCue_C");
		}
		return TsRecordGameplayCue._ClassPtr;
	}

	// Token: 0x0601C8AF RID: 116911 RVA: 0x0080111C File Offset: 0x007FF31C
	public TsRecordGameplayCue() : this(BuiltinUtils.AllocNativeUObject(TsRecordGameplayCue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C8B0 RID: 116912 RVA: 0x00801144 File Offset: 0x007FF344
	public TsRecordGameplayCue(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordGameplayCue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8B1 RID: 116913 RVA: 0x00801177 File Offset: 0x007FF377
	protected TsRecordGameplayCue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C8B2 RID: 116914 RVA: 0x00801180 File Offset: 0x007FF380
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C8B3 RID: 116915 RVA: 0x00801188 File Offset: 0x007FF388
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C8B4 RID: 116916 RVA: 0x008011A8 File Offset: 0x007FF3A8
	protected virtual void __CPPCALL_OnPlay_Implementation()
	{
		this.OnPlay_Implementation();
	}

	// Token: 0x0601C8B5 RID: 116917 RVA: 0x008011B0 File Offset: 0x007FF3B0
	protected virtual void __CPPCALL_OnStop_Implementation()
	{
		this.OnStop_Implementation();
	}

	// Token: 0x0601C8B6 RID: 116918 RVA: 0x008011B8 File Offset: 0x007FF3B8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0400E2AA RID: 58026
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400E2AB RID: 58027
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x0400E2AC RID: 58028
	private float CurrentTime;

	// Token: 0x0400E2AD RID: 58029
	private int CurrentIndex;

	// Token: 0x0400E2AE RID: 58030
	[Nullable(2)]
	private USplineComponent SplineComponent;

	// Token: 0x0400E2AF RID: 58031
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsRecordGameplayCue.TsRecordGameplayCue_C";

	// Token: 0x0400E2B0 RID: 58032
	private static IntPtr _ClassPtr;

	// Token: 0x0400E2B1 RID: 58033
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E2B2 RID: 58034
	private static int __PropertyOffset_Path;

	// Token: 0x0400E2B3 RID: 58035
	private static int __PropertyOffset_Position0;

	// Token: 0x0400E2B4 RID: 58036
	private static int __PropertyOffset_BeamData;
}
