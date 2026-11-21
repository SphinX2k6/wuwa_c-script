using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E1F RID: 11807
public class __TsAreaBlockingVolume_InheritProxy : TsAreaBlockingVolume
{
	// Token: 0x0601C72A RID: 116522 RVA: 0x008BACEC File Offset: 0x008B8EEC
	[NullableContext(1)]
	public __TsAreaBlockingVolume_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAreaBlockingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C72B RID: 116523 RVA: 0x008BAD1F File Offset: 0x008B8F1F
	protected __TsAreaBlockingVolume_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C72C RID: 116524 RVA: 0x008BAD28 File Offset: 0x008B8F28
	protected override void __CPPCALL_NotifyEnterArea_Implementation()
	{
		base.NotifyEnterArea_Implementation();
	}

	// Token: 0x0601C72D RID: 116525 RVA: 0x008BAD30 File Offset: 0x008B8F30
	protected unsafe override void __CPPCALL_ReceiveHit_Implementation(AActor.__ReceiveHit_FunctionParams* __Params)
	{
		UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(__Params->MyComp);
		AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->Other);
		UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(__Params->OtherComp);
		FHitResult fhitResult = new FHitResult(&__Params->Hit, true, true);
		base.ReceiveHit_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, __Params->bSelfMoved, __Params->HitLocation, __Params->HitNormal, __Params->NormalImpulse, fhitResult);
	}
}
