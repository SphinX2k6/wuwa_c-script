using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003956 RID: 14678
public class __TsBaseVehicle_InheritProxy : TsBaseVehicle
{
	// Token: 0x0601EC89 RID: 126089 RVA: 0x0089AF5C File Offset: 0x0089915C
	[NullableContext(1)]
	public __TsBaseVehicle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC8A RID: 126090 RVA: 0x0089AF8F File Offset: 0x0089918F
	protected __TsBaseVehicle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC8B RID: 126091 RVA: 0x0089AF98 File Offset: 0x00899198
	protected unsafe override void __CPPCALL_GetEntityId_Implementation(TsBaseVehicle.__GetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = base.GetEntityId_Implementation();
	}

	// Token: 0x0601EC8C RID: 126092 RVA: 0x0089AFA6 File Offset: 0x008991A6
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601EC8D RID: 126093 RVA: 0x0089AFB0 File Offset: 0x008991B0
	protected unsafe override void __CPPCALL_SetDitherEffect_Implementation(TsBaseVehicle.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		base.SetDitherEffect_Implementation(__Params->dither, ditherType);
	}
}
