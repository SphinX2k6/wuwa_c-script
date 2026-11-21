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

// Token: 0x02001EBB RID: 7867
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/Scene3DUI/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneUiTag.TsSceneUiTag_C")]
public class TsSceneUiTag : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17001D9C RID: 7580
	// (get) Token: 0x06013701 RID: 79617 RVA: 0x005AB184 File Offset: 0x005A9384
	// (set) Token: 0x06013702 RID: 79618 RVA: 0x005AB198 File Offset: 0x005A9398
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

	// Token: 0x17001D9D RID: 7581
	// (get) Token: 0x06013703 RID: 79619 RVA: 0x005AB1AD File Offset: 0x005A93AD
	// (set) Token: 0x06013704 RID: 79620 RVA: 0x005AB1BD File Offset: 0x005A93BD
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

	// Token: 0x17001D9E RID: 7582
	// (get) Token: 0x06013705 RID: 79621 RVA: 0x005AB1D0 File Offset: 0x005A93D0
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

	// Token: 0x06013706 RID: 79622 RVA: 0x005AB20C File Offset: 0x005A940C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSceneUiTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsSceneUiTag.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06013707 RID: 79623 RVA: 0x005AB265 File Offset: 0x005A9465
	protected virtual void ReceiveBeginPlay_Implementation()
	{
	}

	// Token: 0x06013708 RID: 79624 RVA: 0x005AB268 File Offset: 0x005A9468
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSceneUiTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsSceneUiTag.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(EndPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)EndPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06013709 RID: 79625 RVA: 0x005AB2F7 File Offset: 0x005A94F7
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
	}

	// Token: 0x0601370A RID: 79626 RVA: 0x005AB2FC File Offset: 0x005A94FC
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

	// Token: 0x0601370B RID: 79627 RVA: 0x005AB386 File Offset: 0x005A9586
	public bool CanTick()
	{
		return this.OnCanTick();
	}

	// Token: 0x0601370C RID: 79628 RVA: 0x005AB390 File Offset: 0x005A9590
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual bool OnCanTick()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSceneUiTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnCanTick"), TsSceneUiTag.StaticClass(), out intPtr, out num))
		{
			return this.OnCanTick_Implementation();
		}
		TsSceneUiTag.__OnCanTick_FunctionParams* ptr = stackalloc TsSceneUiTag.__OnCanTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsSceneUiTag.__OnCanTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601370D RID: 79629 RVA: 0x005AB41A File Offset: 0x005A961A
	protected bool OnCanTick_Implementation()
	{
		return false;
	}

	// Token: 0x0601370E RID: 79630 RVA: 0x005AB41D File Offset: 0x005A961D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSceneUiTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneUiTag.TsSceneUiTag_C");
		}
		return TsSceneUiTag._ClassPtr;
	}

	// Token: 0x0601370F RID: 79631 RVA: 0x005AB444 File Offset: 0x005A9644
	public TsSceneUiTag() : this(BuiltinUtils.AllocNativeUObject(TsSceneUiTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06013710 RID: 79632 RVA: 0x005AB46C File Offset: 0x005A966C
	public TsSceneUiTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneUiTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06013711 RID: 79633 RVA: 0x005AB49F File Offset: 0x005A969F
	protected TsSceneUiTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17001D9F RID: 7583
	// (get) Token: 0x06013712 RID: 79634 RVA: 0x005AB4A8 File Offset: 0x005A96A8
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsSceneUiTag.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06013713 RID: 79635 RVA: 0x005AB4BC File Offset: 0x005A96BC
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06013714 RID: 79636 RVA: 0x005AB4C4 File Offset: 0x005A96C4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x06013715 RID: 79637 RVA: 0x005AB4E4 File Offset: 0x005A96E4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnCanTick_Implementation(TsSceneUiTag.__OnCanTick_FunctionParams* __Params)
	{
		__Params->__Result = this.OnCanTick_Implementation();
	}

	// Token: 0x0400A645 RID: 42565
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneUiTag.TsSceneUiTag_C";

	// Token: 0x0400A646 RID: 42566
	private static IntPtr _ClassPtr;

	// Token: 0x0400A647 RID: 42567
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400A648 RID: 42568
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400A649 RID: 42569
	private static int __PropertyOffset_SceneUiTag;

	// Token: 0x0400A64A RID: 42570
	private static int __PropertyOffset_CalculateCamera;

	// Token: 0x0400A64B RID: 42571
	private static int __PropertyOffset_BindUiTagArray;

	// Token: 0x0400A64C RID: 42572
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<TsSceneUiTag> _BindUiTagArray;

	// Token: 0x02008167 RID: 33127
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __OnCanTick_FunctionParams
	{
		// Token: 0x04029D5B RID: 171355
		[FieldOffset(0)]
		public bool __Result;
	}
}
