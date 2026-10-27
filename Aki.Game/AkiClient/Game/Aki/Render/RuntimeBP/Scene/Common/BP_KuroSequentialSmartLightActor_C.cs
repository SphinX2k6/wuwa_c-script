using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B5E RID: 15198
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_KuroSequentialSmartLightActor.BP_KuroSequentialSmartLightActor_C")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class BP_KuroSequentialSmartLightActor_C : AKuroSequentialSmartLightActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B94 RID: 138132 RVA: 0x008F4082 File Offset: 0x008F2282
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroSequentialSmartLightActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_KuroSequentialSmartLightActor.BP_KuroSequentialSmartLightActor_C");
			}
			return BP_KuroSequentialSmartLightActor_C._ClassPtr;
		}

		// Token: 0x06021B95 RID: 138133 RVA: 0x008F40A8 File Offset: 0x008F22A8
		public BP_KuroSequentialSmartLightActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroSequentialSmartLightActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B96 RID: 138134 RVA: 0x008F40D0 File Offset: 0x008F22D0
		[NullableContext(1)]
		public BP_KuroSequentialSmartLightActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroSequentialSmartLightActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021B97 RID: 138135 RVA: 0x008F4103 File Offset: 0x008F2303
		protected BP_KuroSequentialSmartLightActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401074D RID: 67405
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_KuroSequentialSmartLightActor.BP_KuroSequentialSmartLightActor_C";

		// Token: 0x0401074E RID: 67406
		private static IntPtr _ClassPtr;

		// Token: 0x0401074F RID: 67407
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
