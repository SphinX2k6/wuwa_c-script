using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.LensFlare
{
	// Token: 0x02003B36 RID: 15158
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/LensFlare/PDA_ModelLensFlareConfig.PDA_ModelLensFlareConfig_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class PDA_ModelLensFlareConfig_C : USunLensFlareConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021862 RID: 137314 RVA: 0x008EE97C File Offset: 0x008ECB7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_ModelLensFlareConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/LensFlare/PDA_ModelLensFlareConfig.PDA_ModelLensFlareConfig_C");
			}
			return PDA_ModelLensFlareConfig_C._ClassPtr;
		}

		// Token: 0x06021863 RID: 137315 RVA: 0x008EE9A0 File Offset: 0x008ECBA0
		public PDA_ModelLensFlareConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_ModelLensFlareConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021864 RID: 137316 RVA: 0x008EE9C8 File Offset: 0x008ECBC8
		[NullableContext(1)]
		public PDA_ModelLensFlareConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_ModelLensFlareConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021865 RID: 137317 RVA: 0x008EE9FB File Offset: 0x008ECBFB
		protected PDA_ModelLensFlareConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010563 RID: 66915
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/LensFlare/PDA_ModelLensFlareConfig.PDA_ModelLensFlareConfig_C";

		// Token: 0x04010564 RID: 66916
		private static IntPtr _ClassPtr;

		// Token: 0x04010565 RID: 66917
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
