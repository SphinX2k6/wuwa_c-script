using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FDB RID: 16347
	[UnrealObjectPath("/Game/Aki/Core/BP_StartupPlayerController.BP_StartupPlayerController_C")]
	[UnrealStructLayout(2320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2320)]
	public class BP_StartupPlayerController_C : __TsStartupPlayerController_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029DD8 RID: 171480 RVA: 0x009CE3D5 File Offset: 0x009CC5D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StartupPlayerController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_StartupPlayerController.BP_StartupPlayerController_C");
			}
			return BP_StartupPlayerController_C._ClassPtr;
		}

		// Token: 0x06029DD9 RID: 171481 RVA: 0x009CE3FC File Offset: 0x009CC5FC
		public BP_StartupPlayerController_C() : this(BuiltinUtils.AllocNativeUObject(BP_StartupPlayerController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029DDA RID: 171482 RVA: 0x009CE424 File Offset: 0x009CC624
		[NullableContext(1)]
		public BP_StartupPlayerController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StartupPlayerController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06029DDB RID: 171483 RVA: 0x009CE457 File Offset: 0x009CC657
		protected BP_StartupPlayerController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157FF RID: 88063
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_StartupPlayerController.BP_StartupPlayerController_C";

		// Token: 0x04015800 RID: 88064
		private static IntPtr _ClassPtr;

		// Token: 0x04015801 RID: 88065
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
