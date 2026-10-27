using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EB8 RID: 16056
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomization_Null.BP_QtaCustomization_Null_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_QtaCustomization_Null_C : BP_QtaCustomizationBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060289B8 RID: 166328 RVA: 0x009B0627 File Offset: 0x009AE827
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QtaCustomization_Null_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomization_Null.BP_QtaCustomization_Null_C");
			}
			return BP_QtaCustomization_Null_C._ClassPtr;
		}

		// Token: 0x060289B9 RID: 166329 RVA: 0x009B064C File Offset: 0x009AE84C
		public BP_QtaCustomization_Null_C() : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomization_Null_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060289BA RID: 166330 RVA: 0x009B0674 File Offset: 0x009AE874
		[NullableContext(1)]
		public BP_QtaCustomization_Null_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomization_Null_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060289BB RID: 166331 RVA: 0x009B06A7 File Offset: 0x009AE8A7
		protected BP_QtaCustomization_Null_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B98 RID: 84888
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomization_Null.BP_QtaCustomization_Null_C";

		// Token: 0x04014B99 RID: 84889
		private static IntPtr _ClassPtr;

		// Token: 0x04014B9A RID: 84890
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
