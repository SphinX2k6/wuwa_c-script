using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E9 RID: 17129
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ML_Character.ML_Character_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ML_Character_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C39F RID: 181151 RVA: 0x00A1A925 File Offset: 0x00A18B25
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ML_Character_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/ML_Character.ML_Character_C");
			}
			return ML_Character_C._ClassPtr;
		}

		// Token: 0x0602C3A0 RID: 181152 RVA: 0x00A1A94C File Offset: 0x00A18B4C
		protected ML_Character_C() : this(BuiltinUtils.AllocNativeUObject(ML_Character_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C3A1 RID: 181153 RVA: 0x00A1A974 File Offset: 0x00A18B74
		protected ML_Character_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017518 RID: 95512
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/ML_Character.ML_Character_C";

		// Token: 0x04017519 RID: 95513
		private static IntPtr _ClassPtr;

		// Token: 0x0401751A RID: 95514
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
