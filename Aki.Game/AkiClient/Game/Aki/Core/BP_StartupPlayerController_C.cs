using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003252 RID: 12882
	[UnrealObjectPath("/Game/Aki/Core/BP_StartupPlayerController.BP_StartupPlayerController_C")]
	[UnrealStructLayout(2360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2360)]
	public class BP_StartupPlayerController_C : __TsStartupPlayerController_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202F0 RID: 131824 RVA: 0x0093F35A File Offset: 0x0093D55A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StartupPlayerController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_StartupPlayerController.BP_StartupPlayerController_C");
			}
			return BP_StartupPlayerController_C._ClassPtr;
		}

		// Token: 0x060202F1 RID: 131825 RVA: 0x0093F380 File Offset: 0x0093D580
		public BP_StartupPlayerController_C() : this(BuiltinUtils.AllocNativeUObject(BP_StartupPlayerController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060202F2 RID: 131826 RVA: 0x0093F3A8 File Offset: 0x0093D5A8
		[NullableContext(1)]
		public BP_StartupPlayerController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StartupPlayerController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060202F3 RID: 131827 RVA: 0x0093F3DB File Offset: 0x0093D5DB
		protected BP_StartupPlayerController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401152A RID: 70954
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_StartupPlayerController.BP_StartupPlayerController_C";

		// Token: 0x0401152B RID: 70955
		private static IntPtr _ClassPtr;

		// Token: 0x0401152C RID: 70956
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
