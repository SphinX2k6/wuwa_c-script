using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.AnimNotify
{
	// Token: 0x02003E32 RID: 15922
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/AnimNotify/BP_AnimNotify_AddMaterialControllerData.BP_AnimNotify_AddMaterialControllerData_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 89)]
	public class BP_AnimNotify_AddMaterialControllerData_C : __AnimNotifyAddMaterialControllerData_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027F54 RID: 163668 RVA: 0x009A0609 File Offset: 0x0099E809
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AnimNotify_AddMaterialControllerData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/AnimNotify/BP_AnimNotify_AddMaterialControllerData.BP_AnimNotify_AddMaterialControllerData_C");
			}
			return BP_AnimNotify_AddMaterialControllerData_C._ClassPtr;
		}

		// Token: 0x06027F55 RID: 163669 RVA: 0x009A0630 File Offset: 0x0099E830
		public BP_AnimNotify_AddMaterialControllerData_C() : this(BuiltinUtils.AllocNativeUObject(BP_AnimNotify_AddMaterialControllerData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027F56 RID: 163670 RVA: 0x009A0658 File Offset: 0x0099E858
		[NullableContext(1)]
		public BP_AnimNotify_AddMaterialControllerData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AnimNotify_AddMaterialControllerData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027F57 RID: 163671 RVA: 0x009A068B File Offset: 0x0099E88B
		protected BP_AnimNotify_AddMaterialControllerData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014485 RID: 83077
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/AnimNotify/BP_AnimNotify_AddMaterialControllerData.BP_AnimNotify_AddMaterialControllerData_C";

		// Token: 0x04014486 RID: 83078
		private static IntPtr _ClassPtr;

		// Token: 0x04014487 RID: 83079
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
