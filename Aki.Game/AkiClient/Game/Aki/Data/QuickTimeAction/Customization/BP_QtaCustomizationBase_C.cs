using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003183 RID: 12675
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomizationBase.BP_QtaCustomizationBase_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_QtaCustomizationBase_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F44C RID: 128076 RVA: 0x0092A029 File Offset: 0x00928229
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QtaCustomizationBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomizationBase.BP_QtaCustomizationBase_C");
			}
			return BP_QtaCustomizationBase_C._ClassPtr;
		}

		// Token: 0x0601F44D RID: 128077 RVA: 0x0092A050 File Offset: 0x00928250
		public BP_QtaCustomizationBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomizationBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F44E RID: 128078 RVA: 0x0092A078 File Offset: 0x00928278
		[NullableContext(1)]
		public BP_QtaCustomizationBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomizationBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F44F RID: 128079 RVA: 0x0092A0AB File Offset: 0x009282AB
		protected BP_QtaCustomizationBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010BB8 RID: 68536
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomizationBase.BP_QtaCustomizationBase_C";

		// Token: 0x04010BB9 RID: 68537
		private static IntPtr _ClassPtr;

		// Token: 0x04010BBA RID: 68538
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
