using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004281 RID: 17025
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_Lipsync_AL.BP_Lipsync_AL_C")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class BP_Lipsync_AL_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C346 RID: 181062 RVA: 0x00A19E2A File Offset: 0x00A1802A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Lipsync_AL_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_Lipsync_AL.BP_Lipsync_AL_C");
			}
			return BP_Lipsync_AL_C._ClassPtr;
		}

		// Token: 0x0602C347 RID: 181063 RVA: 0x00A19E50 File Offset: 0x00A18050
		public BP_Lipsync_AL_C() : this(BuiltinUtils.AllocNativeUObject(BP_Lipsync_AL_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C348 RID: 181064 RVA: 0x00A19E78 File Offset: 0x00A18078
		[NullableContext(1)]
		public BP_Lipsync_AL_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Lipsync_AL_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602C349 RID: 181065 RVA: 0x00A19EAB File Offset: 0x00A180AB
		protected BP_Lipsync_AL_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017231 RID: 94769
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_Lipsync_AL.BP_Lipsync_AL_C";

		// Token: 0x04017232 RID: 94770
		private static IntPtr _ClassPtr;

		// Token: 0x04017233 RID: 94771
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
