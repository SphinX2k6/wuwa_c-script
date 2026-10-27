using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x0200439F RID: 17311
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/BP_Fx_Yangyang_Atk_51.BP_Fx_Yangyang_Atk_51_C")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class BP_Fx_Yangyang_Atk_51_C : UMatineeCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CD6F RID: 183663 RVA: 0x00A2A074 File Offset: 0x00A28274
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_Yangyang_Atk_51_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Camera/BP_Fx_Yangyang_Atk_51.BP_Fx_Yangyang_Atk_51_C");
			}
			return BP_Fx_Yangyang_Atk_51_C._ClassPtr;
		}

		// Token: 0x0602CD70 RID: 183664 RVA: 0x00A2A098 File Offset: 0x00A28298
		public BP_Fx_Yangyang_Atk_51_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Yangyang_Atk_51_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CD71 RID: 183665 RVA: 0x00A2A0C0 File Offset: 0x00A282C0
		[NullableContext(1)]
		public BP_Fx_Yangyang_Atk_51_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Yangyang_Atk_51_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CD72 RID: 183666 RVA: 0x00A2A0F3 File Offset: 0x00A282F3
		protected BP_Fx_Yangyang_Atk_51_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A95 RID: 96917
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/BP_Fx_Yangyang_Atk_51.BP_Fx_Yangyang_Atk_51_C";

		// Token: 0x04017A96 RID: 96918
		private static IntPtr _ClassPtr;

		// Token: 0x04017A97 RID: 96919
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
