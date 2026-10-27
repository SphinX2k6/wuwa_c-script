using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EB6 RID: 16054
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomizationBase.BP_QtaCustomizationBase_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_QtaCustomizationBase_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060289AE RID: 166318 RVA: 0x009B04BB File Offset: 0x009AE6BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QtaCustomizationBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomizationBase.BP_QtaCustomizationBase_C");
			}
			return BP_QtaCustomizationBase_C._ClassPtr;
		}

		// Token: 0x060289AF RID: 166319 RVA: 0x009B04E0 File Offset: 0x009AE6E0
		public BP_QtaCustomizationBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomizationBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060289B0 RID: 166320 RVA: 0x009B0508 File Offset: 0x009AE708
		[NullableContext(1)]
		public BP_QtaCustomizationBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomizationBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060289B1 RID: 166321 RVA: 0x009B053B File Offset: 0x009AE73B
		protected BP_QtaCustomizationBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B90 RID: 84880
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomizationBase.BP_QtaCustomizationBase_C";

		// Token: 0x04014B91 RID: 84881
		private static IntPtr _ClassPtr;

		// Token: 0x04014B92 RID: 84882
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
