using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000ED8 RID: 3800
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/AreaBlockingVolume/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/AreaBlockingVolume/TsAreaBlockingVolume.TsAreaBlockingVolume_C")]
public class TsAreaBlockingVolume : ATriggerBox, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06005EC2 RID: 24258 RVA: 0x00119D54 File Offset: 0x00117F54
	static TsAreaBlockingVolume()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAreaBlockingVolume.CreateStaticDefaultValue), new Action(TsAreaBlockingVolume.ResetStaticDefaultValue));
	}

	// Token: 0x17000743 RID: 1859
	// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x00119D73 File Offset: 0x00117F73
	// (set) Token: 0x06005EC4 RID: 24260 RVA: 0x00119D83 File Offset: 0x00117F83
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int AreaId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAreaBlockingVolume.__PropertyOffset_AreaId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAreaBlockingVolume.__PropertyOffset_AreaId) = value;
		}
	}

	// Token: 0x06005EC5 RID: 24261 RVA: 0x00119D94 File Offset: 0x00117F94
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void NotifyEnterArea()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("NotifyEnterArea"), out num);
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

	// Token: 0x06005EC6 RID: 24262 RVA: 0x00119E04 File Offset: 0x00118004
	protected void NotifyEnterArea_Implementation()
	{
		if (Time.Instance.PlayerTime - TsAreaBlockingVolume.lastLogTime >= 5000.0)
		{
			TsAreaBlockingVolume.lastLogTime = Time.Instance.PlayerTime;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Log;
			ELogAuthor author = ELogAuthor.LC;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("AreaBlockingVolume:进入区域");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.AreaId);
			instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		EventSystem.Instance.Emit<int>(EEventName.EnterAreaNotify, this.AreaId);
	}

	// Token: 0x06005EC7 RID: 24263 RVA: 0x00119E94 File Offset: 0x00118094
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveHit(UPrimitiveComponent myComp, AActor other, UPrimitiveComponent otherComp, bool bSelfMoved, FVector hitLocation, FVector hitNormal, FVector normalImpulse, in FHitResult hit)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveHit"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveHit_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveHit_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveHit_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MyComp) = ((myComp != null) ? myComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Other) = ((other != null) ? other.NativePtr : ((IntPtr)0));
			*(&ptr2->OtherComp) = ((otherComp != null) ? otherComp.NativePtr : ((IntPtr)0));
			ptr2->bSelfMoved = bSelfMoved;
			ptr2->HitLocation = hitLocation;
			ptr2->HitNormal = hitNormal;
			ptr2->NormalImpulse = normalImpulse;
			UScriptStructStackOnlyPtr nativeUStructPtr = FHitResult.StaticStruct();
			IntPtr dest = &ptr2->Hit;
			object obj = hit;
			UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (obj != null) ? obj.NativePtr : ((IntPtr)0), 1, false);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005EC8 RID: 24264 RVA: 0x00119F88 File Offset: 0x00118188
	[NullableContext(2)]
	protected void ReceiveHit_Implementation(UPrimitiveComponent myComp, AActor other, UPrimitiveComponent otherComp, bool bSelfMoved, FVector hitLocation, FVector hitNormal, FVector normalImpulse, in FHitResult hit)
	{
		this.NotifyEnterArea();
	}

	// Token: 0x06005EC9 RID: 24265 RVA: 0x00119F90 File Offset: 0x00118190
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005ECA RID: 24266 RVA: 0x00119F92 File Offset: 0x00118192
	public static void ResetStaticDefaultValue()
	{
		TsAreaBlockingVolume.lastLogTime = 0.0;
	}

	// Token: 0x06005ECB RID: 24267 RVA: 0x00119FA2 File Offset: 0x001181A2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAreaBlockingVolume._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/AreaBlockingVolume/TsAreaBlockingVolume.TsAreaBlockingVolume_C");
		}
		return TsAreaBlockingVolume._ClassPtr;
	}

	// Token: 0x06005ECC RID: 24268 RVA: 0x00119FC8 File Offset: 0x001181C8
	public TsAreaBlockingVolume() : this(BuiltinUtils.AllocNativeUObject(TsAreaBlockingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06005ECD RID: 24269 RVA: 0x00119FF0 File Offset: 0x001181F0
	[NullableContext(1)]
	public TsAreaBlockingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAreaBlockingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06005ECE RID: 24270 RVA: 0x0011A023 File Offset: 0x00118223
	protected TsAreaBlockingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06005ECF RID: 24271 RVA: 0x0011A02C File Offset: 0x0011822C
	protected virtual void __CPPCALL_NotifyEnterArea_Implementation()
	{
		this.NotifyEnterArea_Implementation();
	}

	// Token: 0x06005ED0 RID: 24272 RVA: 0x0011A034 File Offset: 0x00118234
	protected unsafe virtual void __CPPCALL_ReceiveHit_Implementation(AActor.__ReceiveHit_FunctionParams* __Params)
	{
		UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(__Params->MyComp);
		AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->Other);
		UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(__Params->OtherComp);
		FHitResult fhitResult = new FHitResult(&__Params->Hit, true, true);
		this.ReceiveHit_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, __Params->bSelfMoved, __Params->HitLocation, __Params->HitNormal, __Params->NormalImpulse, fhitResult);
	}

	// Token: 0x04002B08 RID: 11016
	private static double lastLogTime;

	// Token: 0x04002B09 RID: 11017
	private const int LOG_INTERVAL = 5000;

	// Token: 0x04002B0A RID: 11018
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/AreaBlockingVolume/TsAreaBlockingVolume.TsAreaBlockingVolume_C";

	// Token: 0x04002B0B RID: 11019
	private static IntPtr _ClassPtr;

	// Token: 0x04002B0C RID: 11020
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002B0D RID: 11021
	private static int __PropertyOffset_AreaId;
}
