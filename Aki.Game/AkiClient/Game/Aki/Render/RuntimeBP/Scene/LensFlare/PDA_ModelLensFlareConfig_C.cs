using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.LensFlare
{
	// Token: 0x020030B6 RID: 12470
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/LensFlare/PDA_ModelLensFlareConfig.PDA_ModelLensFlareConfig_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class PDA_ModelLensFlareConfig_C : USunLensFlareConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DF63 RID: 122723 RVA: 0x00907271 File Offset: 0x00905471
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_ModelLensFlareConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/LensFlare/PDA_ModelLensFlareConfig.PDA_ModelLensFlareConfig_C");
			}
			return PDA_ModelLensFlareConfig_C._ClassPtr;
		}

		// Token: 0x0601DF64 RID: 122724 RVA: 0x00907298 File Offset: 0x00905498
		public PDA_ModelLensFlareConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_ModelLensFlareConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DF65 RID: 122725 RVA: 0x009072C0 File Offset: 0x009054C0
		[NullableContext(1)]
		public PDA_ModelLensFlareConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_ModelLensFlareConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DF66 RID: 122726 RVA: 0x009072F3 File Offset: 0x009054F3
		protected PDA_ModelLensFlareConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD44 RID: 64836
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/LensFlare/PDA_ModelLensFlareConfig.PDA_ModelLensFlareConfig_C";

		// Token: 0x0400FD45 RID: 64837
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD46 RID: 64838
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
