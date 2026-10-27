using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002940 RID: 10560
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/Scene3DUI/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneUiTag.TsSceneUiTag_C")]
public class TsSceneUiTag : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17001D42 RID: 7490
	// (get) Token: 0x06015CFC RID: 89340 RVA: 0x0058018C File Offset: 0x0057E38C
	// (set) Token: 0x06015CFD RID: 89341 RVA: 0x005801A0 File Offset: 0x0057E3A0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string SceneUiTag
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsSceneUiTag.__PropertyOffset_SceneUiTag)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsSceneUiTag.__PropertyOffset_SceneUiTag)), value);
		}
	}

	// Token: 0x17001D43 RID: 7491
	// (get) Token: 0x06015CFE RID: 89342 RVA: 0x005801B5 File Offset: 0x0057E3B5
	// (set) Token: 0x06015CFF RID: 89343 RVA: 0x005801C5 File Offset: 0x0057E3C5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CalculateCamera
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSceneUiTag.__PropertyOffset_CalculateCamera) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSceneUiTag.__PropertyOffset_CalculateCamera) = (value ? 1 : 0);
		}
	}

	// Token: 0x17001D44 RID: 7492
	// (get) Token: 0x06015D00 RID: 89344 RVA: 0x005801D8 File Offset: 0x0057E3D8
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<TsSceneUiTag> BindUiTagArray
	{
		get
		{
			base.FastCheckIsValid();
			TArray<TsSceneUiTag> result;
			if ((result = this._BindUiTagArray) == null)
			{
				result = (this._BindUiTagArray = new TArray<TsSceneUiTag>(base.NativePtr + (IntPtr)TsSceneUiTag.__PropertyOffset_BindUiTagArray, this));
			}
			return result;
		}
	}

	// Token: 0x06015D01 RID: 89345 RVA: 0x00580214 File Offset: 0x0057E414
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

	// Token: 0x06015D02 RID: 89346 RVA: 0x00580284 File Offset: 0x0057E484
	protected virtual void ReceiveBeginPlay_Implementation()
	{
	}

	// Token: 0x06015D03 RID: 89347 RVA: 0x00580288 File Offset: 0x0057E488
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)EndPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06015D04 RID: 89348 RVA: 0x00580301 File Offset: 0x0057E501
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
	}

	// Token: 0x06015D05 RID: 89349 RVA: 0x00580304 File Offset: 0x0057E504
	public double CalculateSquaredDistance()
	{
		if (CameraController.Instance.MainModel == null)
		{
			return 0.0;
		}
		FTransformDouble ftransformDouble;
		if (this.CalculateCamera)
		{
			CameraModelInstance mainModel = CameraController.Instance.MainModel;
			if (mainModel == null)
			{
				return 0.0;
			}
			ftransformDouble = mainModel.CameraTransform.Value;
		}
		else
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return 0.0;
			}
			ftransformDouble = baseCharacter.D_GetTransform();
		}
		FVectorDouble fvectorDouble = base.D_K2_GetActorLocation();
		return Vector.Create(ftransformDouble.InverseTransformPositionNoScale(fvectorDouble)).SizeSquared();
	}

	// Token: 0x06015D06 RID: 89350 RVA: 0x0058038E File Offset: 0x0057E58E
	public bool CanTick()
	{
		return this.OnCanTick();
	}

	// Token: 0x06015D07 RID: 89351 RVA: 0x00580398 File Offset: 0x0057E598
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual bool OnCanTick()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnCanTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSceneUiTag.__OnCanTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSceneUiTag.__OnCanTick_FunctionParams*)ptr + 15L / (long)sizeof(TsSceneUiTag.__OnCanTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06015D08 RID: 89352 RVA: 0x0058040D File Offset: 0x0057E60D
	protected bool OnCanTick_Implementation()
	{
		return false;
	}

	// Token: 0x06015D09 RID: 89353 RVA: 0x00580410 File Offset: 0x0057E610
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSceneUiTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneUiTag.TsSceneUiTag_C");
		}
		return TsSceneUiTag._ClassPtr;
	}

	// Token: 0x06015D0A RID: 89354 RVA: 0x00580434 File Offset: 0x0057E634
	public TsSceneUiTag() : this(BuiltinUtils.AllocNativeUObject(TsSceneUiTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06015D0B RID: 89355 RVA: 0x0058045C File Offset: 0x0057E65C
	public TsSceneUiTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneUiTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06015D0C RID: 89356 RVA: 0x0058048F File Offset: 0x0057E68F
	protected TsSceneUiTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17001D45 RID: 7493
	// (get) Token: 0x06015D0D RID: 89357 RVA: 0x00580498 File Offset: 0x0057E698
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSceneUiTag.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x17001D46 RID: 7494
	// (get) Token: 0x06015D0E RID: 89358 RVA: 0x005804A8 File Offset: 0x0057E6A8
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsSceneUiTag.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06015D0F RID: 89359 RVA: 0x005804BC File Offset: 0x0057E6BC
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06015D10 RID: 89360 RVA: 0x005804C4 File Offset: 0x0057E6C4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x06015D11 RID: 89361 RVA: 0x005804E4 File Offset: 0x0057E6E4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnCanTick_Implementation(TsSceneUiTag.__OnCanTick_FunctionParams* __Params)
	{
		__Params->__Result = this.OnCanTick_Implementation();
	}

	// Token: 0x0400A25A RID: 41562
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneUiTag.TsSceneUiTag_C";

	// Token: 0x0400A25B RID: 41563
	private static IntPtr _ClassPtr;

	// Token: 0x0400A25C RID: 41564
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400A25D RID: 41565
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400A25E RID: 41566
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400A25F RID: 41567
	private static int __PropertyOffset_SceneUiTag;

	// Token: 0x0400A260 RID: 41568
	private static int __PropertyOffset_CalculateCamera;

	// Token: 0x0400A261 RID: 41569
	private static int __PropertyOffset_BindUiTagArray;

	// Token: 0x0400A262 RID: 41570
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<TsSceneUiTag> _BindUiTagArray;

	// Token: 0x02008F1F RID: 36639
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __OnCanTick_FunctionParams
	{
		// Token: 0x0402E65E RID: 190046
		[FieldOffset(0)]
		public bool __Result;
	}
}
