using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02001EBA RID: 7866
[UClass("/Game/Aki/TypeScript/Game/Module/Scene3DUI/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneDecorativeUiActor.TsSceneDecorativeUiActor_C")]
public class TsSceneDecorativeUiActor : TsSceneUiTag, IUnrealUObject, IUnrealObject
{
	// Token: 0x17001D98 RID: 7576
	// (get) Token: 0x060136EB RID: 79595 RVA: 0x005AAEE5 File Offset: 0x005A90E5
	// (set) Token: 0x060136EC RID: 79596 RVA: 0x005AAEF5 File Offset: 0x005A90F5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ShowDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSceneDecorativeUiActor.__PropertyOffset_ShowDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSceneDecorativeUiActor.__PropertyOffset_ShowDistance) = value;
		}
	}

	// Token: 0x17001D99 RID: 7577
	// (get) Token: 0x060136ED RID: 79597 RVA: 0x005AAF06 File Offset: 0x005A9106
	// (set) Token: 0x060136EE RID: 79598 RVA: 0x005AAF16 File Offset: 0x005A9116
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsFaceToCharacter
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSceneDecorativeUiActor.__PropertyOffset_IsFaceToCharacter) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSceneDecorativeUiActor.__PropertyOffset_IsFaceToCharacter) = (value ? 1 : 0);
		}
	}

	// Token: 0x17001D9A RID: 7578
	// (get) Token: 0x060136EF RID: 79599 RVA: 0x005AAF27 File Offset: 0x005A9127
	// (set) Token: 0x060136F0 RID: 79600 RVA: 0x005AAF2F File Offset: 0x005A912F
	public bool IsControlled
	{
		get
		{
			return this.IsControlledInternal;
		}
		set
		{
			this.IsControlledInternal = value;
		}
	}

	// Token: 0x17001D9B RID: 7579
	// (get) Token: 0x060136F1 RID: 79601 RVA: 0x005AAF38 File Offset: 0x005A9138
	// (set) Token: 0x060136F2 RID: 79602 RVA: 0x005AAF40 File Offset: 0x005A9140
	public bool InShow
	{
		get
		{
			return this.InShowInternal;
		}
		set
		{
			this.InShowInternal = value;
		}
	}

	// Token: 0x060136F3 RID: 79603 RVA: 0x005AAF4C File Offset: 0x005A914C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void Create3dUi()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSceneDecorativeUiActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Create3dUi"), TsSceneDecorativeUiActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Create3dUi_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060136F4 RID: 79604 RVA: 0x005AAFA5 File Offset: 0x005A91A5
	protected void Create3dUi_Implementation()
	{
	}

	// Token: 0x060136F5 RID: 79605 RVA: 0x005AAFA8 File Offset: 0x005A91A8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void Destroy3dUi()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSceneDecorativeUiActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Destroy3dUi"), TsSceneDecorativeUiActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Destroy3dUi_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060136F6 RID: 79606 RVA: 0x005AB001 File Offset: 0x005A9201
	protected void Destroy3dUi_Implementation()
	{
		if (this.EditorUiActor != null)
		{
			ActorSystem.Instance.Put("TsSceneDecorativeUiActor.Destroy3dUi", this.EditorUiActor, null);
			this.EditorUiActor = null;
		}
	}

	// Token: 0x060136F7 RID: 79607 RVA: 0x005AB02C File Offset: 0x005A922C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void DrawDistance()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSceneDecorativeUiActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DrawDistance"), TsSceneDecorativeUiActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.DrawDistance_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060136F8 RID: 79608 RVA: 0x005AB088 File Offset: 0x005A9288
	protected void DrawDistance_Implementation()
	{
		int segments = 12;
		int num = 5;
		UKismetSystemLibrary.D_DrawDebugSphere(this, base.D_K2_GetActorLocation(), this.ShowDistance, segments, new FLinearColor?(ColorUtils.LinearRed), (float)num, 0f);
	}

	// Token: 0x060136F9 RID: 79609 RVA: 0x005AB0BE File Offset: 0x005A92BE
	protected override bool OnCanTick()
	{
		return !this.IsControlled && base.CalculateSquaredDistance() <= (double)(this.ShowDistance * this.ShowDistance);
	}

	// Token: 0x060136FA RID: 79610 RVA: 0x005AB0E3 File Offset: 0x005A92E3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSceneDecorativeUiActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneDecorativeUiActor.TsSceneDecorativeUiActor_C");
		}
		return TsSceneDecorativeUiActor._ClassPtr;
	}

	// Token: 0x060136FB RID: 79611 RVA: 0x005AB108 File Offset: 0x005A9308
	public TsSceneDecorativeUiActor() : this(BuiltinUtils.AllocNativeUObject(TsSceneDecorativeUiActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060136FC RID: 79612 RVA: 0x005AB130 File Offset: 0x005A9330
	[NullableContext(1)]
	public TsSceneDecorativeUiActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneDecorativeUiActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060136FD RID: 79613 RVA: 0x005AB163 File Offset: 0x005A9363
	protected TsSceneDecorativeUiActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060136FE RID: 79614 RVA: 0x005AB16C File Offset: 0x005A936C
	protected virtual void __CPPCALL_Create3dUi_Implementation()
	{
		this.Create3dUi_Implementation();
	}

	// Token: 0x060136FF RID: 79615 RVA: 0x005AB174 File Offset: 0x005A9374
	protected virtual void __CPPCALL_Destroy3dUi_Implementation()
	{
		this.Destroy3dUi_Implementation();
	}

	// Token: 0x06013700 RID: 79616 RVA: 0x005AB17C File Offset: 0x005A937C
	protected virtual void __CPPCALL_DrawDistance_Implementation()
	{
		this.DrawDistance_Implementation();
	}

	// Token: 0x0400A63D RID: 42557
	private bool IsControlledInternal;

	// Token: 0x0400A63E RID: 42558
	private bool InShowInternal;

	// Token: 0x0400A63F RID: 42559
	[Nullable(2)]
	private AActor EditorUiActor;

	// Token: 0x0400A640 RID: 42560
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneDecorativeUiActor.TsSceneDecorativeUiActor_C";

	// Token: 0x0400A641 RID: 42561
	private static IntPtr _ClassPtr;

	// Token: 0x0400A642 RID: 42562
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400A643 RID: 42563
	private static int __PropertyOffset_ShowDistance;

	// Token: 0x0400A644 RID: 42564
	private static int __PropertyOffset_IsFaceToCharacter;
}
