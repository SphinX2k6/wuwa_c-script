using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Struct;
using AkiClient.Game.Aki.Data.Recorder;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002899 RID: 10393
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsRecordGameplayCue.TsRecordGameplayCue_C")]
public class TsRecordGameplayCue : AKuroRecordEffect, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B35 RID: 11061
	// (get) Token: 0x0601A594 RID: 107924 RVA: 0x00827016 File Offset: 0x00825216
	// (set) Token: 0x0601A595 RID: 107925 RVA: 0x0082702A File Offset: 0x0082522A
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

	// Token: 0x17002B36 RID: 11062
	// (get) Token: 0x0601A596 RID: 107926 RVA: 0x0082703F File Offset: 0x0082523F
	// (set) Token: 0x0601A597 RID: 107927 RVA: 0x00827053 File Offset: 0x00825253
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

	// Token: 0x17002B37 RID: 11063
	// (get) Token: 0x0601A598 RID: 107928 RVA: 0x00827068 File Offset: 0x00825268
	// (set) Token: 0x0601A599 RID: 107929 RVA: 0x0082707C File Offset: 0x0082527C
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

	// Token: 0x0601A59A RID: 107930 RVA: 0x00827094 File Offset: 0x00825294
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsRecordGameplayCue) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsRecordGameplayCue.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A59B RID: 107931 RVA: 0x008270ED File Offset: 0x008252ED
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		base.SetActorTickEnabled(false);
	}

	// Token: 0x0601A59C RID: 107932 RVA: 0x008270F8 File Offset: 0x008252F8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsRecordGameplayCue) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsRecordGameplayCue.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A59D RID: 107933 RVA: 0x00827187 File Offset: 0x00825387
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason endPlayReason)
	{
		this.OnStop();
	}

	// Token: 0x0601A59E RID: 107934 RVA: 0x00827190 File Offset: 0x00825390
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsRecordGameplayCue) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnPlay"), TsRecordGameplayCue.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A59F RID: 107935 RVA: 0x008271E9 File Offset: 0x008253E9
	protected virtual void OnPlay_Implementation()
	{
		this.SpawnHookActorRecord();
	}

	// Token: 0x0601A5A0 RID: 107936 RVA: 0x008271F4 File Offset: 0x008253F4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnStop()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsRecordGameplayCue) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnStop"), TsRecordGameplayCue.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnStop_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A5A1 RID: 107937 RVA: 0x00827250 File Offset: 0x00825450
	protected virtual void OnStop_Implementation()
	{
		TArray<UActorComponent> tarray = base.K2_GetComponentsByClass(UNiagaraComponent.StaticClass());
		for (int i = tarray.Num() - 1; i >= 0; i--)
		{
			base.K2_DestroyComponent(tarray.Get(i));
		}
		base.SetActorTickEnabled(false);
	}

	// Token: 0x0601A5A2 RID: 107938 RVA: 0x00827298 File Offset: 0x00825498
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsRecordGameplayCue) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsRecordGameplayCue.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(deltaSeconds);
			return;
		}
		AActor.__ReceiveTick_FunctionParams* ptr = stackalloc AActor.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A5A3 RID: 107939 RVA: 0x00827324 File Offset: 0x00825524
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

	// Token: 0x0601A5A4 RID: 107940 RVA: 0x00827440 File Offset: 0x00825640
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

	// Token: 0x0601A5A5 RID: 107941 RVA: 0x00827550 File Offset: 0x00825750
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
				int num4 = i;
				FSplinePoint fsplinePoint = new FSplinePoint
				{
					InputKey = (float)num4,
					Scale = FVector.OneVector,
					Type = ESplinePointType.Linear
				};
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

	// Token: 0x0601A5A6 RID: 107942 RVA: 0x0082769C File Offset: 0x0082589C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsRecordGameplayCue._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsRecordGameplayCue.TsRecordGameplayCue_C");
		}
		return TsRecordGameplayCue._ClassPtr;
	}

	// Token: 0x0601A5A7 RID: 107943 RVA: 0x008276C0 File Offset: 0x008258C0
	public TsRecordGameplayCue() : this(BuiltinUtils.AllocNativeUObject(TsRecordGameplayCue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601A5A8 RID: 107944 RVA: 0x008276E8 File Offset: 0x008258E8
	public TsRecordGameplayCue(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordGameplayCue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601A5A9 RID: 107945 RVA: 0x0082771B File Offset: 0x0082591B
	protected TsRecordGameplayCue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601A5AA RID: 107946 RVA: 0x00827724 File Offset: 0x00825924
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601A5AB RID: 107947 RVA: 0x0082772C File Offset: 0x0082592C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601A5AC RID: 107948 RVA: 0x0082774C File Offset: 0x0082594C
	protected virtual void __CPPCALL_OnPlay_Implementation()
	{
		this.OnPlay_Implementation();
	}

	// Token: 0x0601A5AD RID: 107949 RVA: 0x00827754 File Offset: 0x00825954
	protected virtual void __CPPCALL_OnStop_Implementation()
	{
		this.OnStop_Implementation();
	}

	// Token: 0x0601A5AE RID: 107950 RVA: 0x0082775C File Offset: 0x0082595C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0400E75A RID: 59226
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400E75B RID: 59227
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x0400E75C RID: 59228
	private float CurrentTime;

	// Token: 0x0400E75D RID: 59229
	private int CurrentIndex;

	// Token: 0x0400E75E RID: 59230
	[Nullable(2)]
	private USplineComponent SplineComponent;

	// Token: 0x0400E75F RID: 59231
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsRecordGameplayCue.TsRecordGameplayCue_C";

	// Token: 0x0400E760 RID: 59232
	private static IntPtr _ClassPtr;

	// Token: 0x0400E761 RID: 59233
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E762 RID: 59234
	private static int __PropertyOffset_Path;

	// Token: 0x0400E763 RID: 59235
	private static int __PropertyOffset_Position0;

	// Token: 0x0400E764 RID: 59236
	private static int __PropertyOffset_BeamData;
}
