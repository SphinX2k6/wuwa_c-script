using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200293F RID: 10559
[UClass("/Game/Aki/TypeScript/Game/Module/Scene3DUI/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneDecorativeUiActor.TsSceneDecorativeUiActor_C")]
public class TsSceneDecorativeUiActor : TsSceneUiTag, IUnrealUObject, IUnrealObject
{
	// Token: 0x17001D3E RID: 7486
	// (get) Token: 0x06015CE6 RID: 89318 RVA: 0x0057FEAD File Offset: 0x0057E0AD
	// (set) Token: 0x06015CE7 RID: 89319 RVA: 0x0057FEBD File Offset: 0x0057E0BD
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

	// Token: 0x17001D3F RID: 7487
	// (get) Token: 0x06015CE8 RID: 89320 RVA: 0x0057FECE File Offset: 0x0057E0CE
	// (set) Token: 0x06015CE9 RID: 89321 RVA: 0x0057FEDE File Offset: 0x0057E0DE
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

	// Token: 0x17001D40 RID: 7488
	// (get) Token: 0x06015CEA RID: 89322 RVA: 0x0057FEEF File Offset: 0x0057E0EF
	// (set) Token: 0x06015CEB RID: 89323 RVA: 0x0057FEF7 File Offset: 0x0057E0F7
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

	// Token: 0x17001D41 RID: 7489
	// (get) Token: 0x06015CEC RID: 89324 RVA: 0x0057FF00 File Offset: 0x0057E100
	// (set) Token: 0x06015CED RID: 89325 RVA: 0x0057FF08 File Offset: 0x0057E108
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

	// Token: 0x06015CEE RID: 89326 RVA: 0x0057FF14 File Offset: 0x0057E114
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Create3dUi()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Create3dUi"), out num);
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

	// Token: 0x06015CEF RID: 89327 RVA: 0x0057FF84 File Offset: 0x0057E184
	protected void Create3dUi_Implementation()
	{
	}

	// Token: 0x06015CF0 RID: 89328 RVA: 0x0057FF88 File Offset: 0x0057E188
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Destroy3dUi()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Destroy3dUi"), out num);
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

	// Token: 0x06015CF1 RID: 89329 RVA: 0x0057FFF8 File Offset: 0x0057E1F8
	protected void Destroy3dUi_Implementation()
	{
		if (this.EditorUiActor != null)
		{
			ActorSystem.Instance.Put("TsSceneDecorativeUiActor.Destroy3dUi", this.EditorUiActor, null);
			this.EditorUiActor = null;
		}
	}

	// Token: 0x06015CF2 RID: 89330 RVA: 0x00580020 File Offset: 0x0057E220
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void DrawDistance()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DrawDistance"), out num);
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

	// Token: 0x06015CF3 RID: 89331 RVA: 0x00580090 File Offset: 0x0057E290
	protected void DrawDistance_Implementation()
	{
		int segments = 12;
		int num = 5;
		UKismetSystemLibrary.D_DrawDebugSphere(this, base.D_K2_GetActorLocation(), this.ShowDistance, segments, new FLinearColor?(ColorUtils.LinearRed), (float)num, 0f);
	}

	// Token: 0x06015CF4 RID: 89332 RVA: 0x005800C6 File Offset: 0x0057E2C6
	protected override bool OnCanTick()
	{
		return !this.IsControlled && base.CalculateSquaredDistance() <= (double)(this.ShowDistance * this.ShowDistance);
	}

	// Token: 0x06015CF5 RID: 89333 RVA: 0x005800EB File Offset: 0x0057E2EB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSceneDecorativeUiActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneDecorativeUiActor.TsSceneDecorativeUiActor_C");
		}
		return TsSceneDecorativeUiActor._ClassPtr;
	}

	// Token: 0x06015CF6 RID: 89334 RVA: 0x00580110 File Offset: 0x0057E310
	public TsSceneDecorativeUiActor() : this(BuiltinUtils.AllocNativeUObject(TsSceneDecorativeUiActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06015CF7 RID: 89335 RVA: 0x00580138 File Offset: 0x0057E338
	[NullableContext(1)]
	public TsSceneDecorativeUiActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneDecorativeUiActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06015CF8 RID: 89336 RVA: 0x0058016B File Offset: 0x0057E36B
	protected TsSceneDecorativeUiActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06015CF9 RID: 89337 RVA: 0x00580174 File Offset: 0x0057E374
	protected virtual void __CPPCALL_Create3dUi_Implementation()
	{
		this.Create3dUi_Implementation();
	}

	// Token: 0x06015CFA RID: 89338 RVA: 0x0058017C File Offset: 0x0057E37C
	protected virtual void __CPPCALL_Destroy3dUi_Implementation()
	{
		this.Destroy3dUi_Implementation();
	}

	// Token: 0x06015CFB RID: 89339 RVA: 0x00580184 File Offset: 0x0057E384
	protected virtual void __CPPCALL_DrawDistance_Implementation()
	{
		this.DrawDistance_Implementation();
	}

	// Token: 0x0400A252 RID: 41554
	private bool IsControlledInternal;

	// Token: 0x0400A253 RID: 41555
	private bool InShowInternal;

	// Token: 0x0400A254 RID: 41556
	[Nullable(2)]
	private AActor EditorUiActor;

	// Token: 0x0400A255 RID: 41557
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Scene3DUI/TsSceneDecorativeUiActor.TsSceneDecorativeUiActor_C";

	// Token: 0x0400A256 RID: 41558
	private static IntPtr _ClassPtr;

	// Token: 0x0400A257 RID: 41559
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400A258 RID: 41560
	private static int __PropertyOffset_ShowDistance;

	// Token: 0x0400A259 RID: 41561
	private static int __PropertyOffset_IsFaceToCharacter;
}
