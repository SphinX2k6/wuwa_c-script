using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200038D RID: 909
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/AreaBlockingVolume/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/AreaBlockingVolume/TsAreaBlockingVolume.TsAreaBlockingVolume_C")]
public class TsAreaBlockingVolume : ATriggerBox, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06003259 RID: 12889 RVA: 0x00121A34 File Offset: 0x0011FC34
	static TsAreaBlockingVolume()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAreaBlockingVolume.CreateStaticDefaultValue), new Action(TsAreaBlockingVolume.ResetStaticDefaultValue));
	}

	// Token: 0x17000767 RID: 1895
	// (get) Token: 0x0600325A RID: 12890 RVA: 0x00121A53 File Offset: 0x0011FC53
	// (set) Token: 0x0600325B RID: 12891 RVA: 0x00121A63 File Offset: 0x0011FC63
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

	// Token: 0x0600325C RID: 12892 RVA: 0x00121A74 File Offset: 0x0011FC74
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void NotifyEnterArea()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsAreaBlockingVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("NotifyEnterArea"), TsAreaBlockingVolume.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.NotifyEnterArea_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600325D RID: 12893 RVA: 0x00121AD0 File Offset: 0x0011FCD0
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

	// Token: 0x0600325E RID: 12894 RVA: 0x00121B60 File Offset: 0x0011FD60
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveHit(UPrimitiveComponent myComp, AActor other, UPrimitiveComponent otherComp, bool bSelfMoved, FVector hitLocation, FVector hitNormal, FVector normalImpulse, in FHitResult hit)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAreaBlockingVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveHit"), TsAreaBlockingVolume.StaticClass(), out intPtr, out num))
		{
			this.ReceiveHit_Implementation(myComp, other, otherComp, bSelfMoved, hitLocation, hitNormal, normalImpulse, hit);
			return;
		}
		AActor.__ReceiveHit_FunctionParams* ptr = stackalloc AActor.__ReceiveHit_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveHit_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MyComp) = ((myComp != null) ? myComp.NativePtr : ((IntPtr)0));
		*(&ptr->Other) = ((other != null) ? other.NativePtr : ((IntPtr)0));
		*(&ptr->OtherComp) = ((otherComp != null) ? otherComp.NativePtr : ((IntPtr)0));
		ptr->bSelfMoved = bSelfMoved;
		ptr->HitLocation = hitLocation;
		ptr->HitNormal = hitNormal;
		ptr->NormalImpulse = normalImpulse;
		UScriptStructStackOnlyPtr nativeUStructPtr = FHitResult.StaticStruct();
		IntPtr dest = &ptr->Hit;
		object obj = hit;
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (obj != null) ? obj.NativePtr : ((IntPtr)0), 1, false);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600325F RID: 12895 RVA: 0x00121C73 File Offset: 0x0011FE73
	[NullableContext(2)]
	protected void ReceiveHit_Implementation(UPrimitiveComponent myComp, AActor other, UPrimitiveComponent otherComp, bool bSelfMoved, FVector hitLocation, FVector hitNormal, FVector normalImpulse, in FHitResult hit)
	{
		this.NotifyEnterArea();
	}

	// Token: 0x06003260 RID: 12896 RVA: 0x00121C7B File Offset: 0x0011FE7B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003261 RID: 12897 RVA: 0x00121C7D File Offset: 0x0011FE7D
	public static void ResetStaticDefaultValue()
	{
		TsAreaBlockingVolume.lastLogTime = 0.0;
	}

	// Token: 0x06003262 RID: 12898 RVA: 0x00121C8D File Offset: 0x0011FE8D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAreaBlockingVolume._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/AreaBlockingVolume/TsAreaBlockingVolume.TsAreaBlockingVolume_C");
		}
		return TsAreaBlockingVolume._ClassPtr;
	}

	// Token: 0x06003263 RID: 12899 RVA: 0x00121CB4 File Offset: 0x0011FEB4
	public TsAreaBlockingVolume() : this(BuiltinUtils.AllocNativeUObject(TsAreaBlockingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06003264 RID: 12900 RVA: 0x00121CDC File Offset: 0x0011FEDC
	[NullableContext(1)]
	public TsAreaBlockingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAreaBlockingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06003265 RID: 12901 RVA: 0x00121D0F File Offset: 0x0011FF0F
	protected TsAreaBlockingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06003266 RID: 12902 RVA: 0x00121D18 File Offset: 0x0011FF18
	protected virtual void __CPPCALL_NotifyEnterArea_Implementation()
	{
		this.NotifyEnterArea_Implementation();
	}

	// Token: 0x06003267 RID: 12903 RVA: 0x00121D20 File Offset: 0x0011FF20
	protected unsafe virtual void __CPPCALL_ReceiveHit_Implementation(AActor.__ReceiveHit_FunctionParams* __Params)
	{
		UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(__Params->MyComp);
		AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->Other);
		UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(__Params->OtherComp);
		FHitResult fhitResult = new FHitResult(&__Params->Hit, true, true);
		this.ReceiveHit_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, __Params->bSelfMoved, __Params->HitLocation, __Params->HitNormal, __Params->NormalImpulse, fhitResult);
	}

	// Token: 0x04002BA3 RID: 11171
	private static double lastLogTime;

	// Token: 0x04002BA4 RID: 11172
	private const int LOG_INTERVAL = 5000;

	// Token: 0x04002BA5 RID: 11173
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/AreaBlockingVolume/TsAreaBlockingVolume.TsAreaBlockingVolume_C";

	// Token: 0x04002BA6 RID: 11174
	private static IntPtr _ClassPtr;

	// Token: 0x04002BA7 RID: 11175
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002BA8 RID: 11176
	private static int __PropertyOffset_AreaId;
}
