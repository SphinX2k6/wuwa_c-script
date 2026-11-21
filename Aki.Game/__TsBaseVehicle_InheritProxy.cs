using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002ED1 RID: 11985
public class __TsBaseVehicle_InheritProxy : TsBaseVehicle
{
	// Token: 0x0601C91C RID: 117020 RVA: 0x008BE070 File Offset: 0x008BC270
	[NullableContext(1)]
	public __TsBaseVehicle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C91D RID: 117021 RVA: 0x008BE0A3 File Offset: 0x008BC2A3
	protected __TsBaseVehicle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C91E RID: 117022 RVA: 0x008BE0AC File Offset: 0x008BC2AC
	protected unsafe override void __CPPCALL_GetEntityId_Implementation(TsBaseVehicle.__GetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = base.GetEntityId_Implementation();
	}

	// Token: 0x0601C91F RID: 117023 RVA: 0x008BE0BA File Offset: 0x008BC2BA
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601C920 RID: 117024 RVA: 0x008BE0C4 File Offset: 0x008BC2C4
	protected unsafe override void __CPPCALL_SetDitherEffect_Implementation(TsBaseVehicle.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		base.SetDitherEffect_Implementation(__Params->dither, ditherType);
	}
}
