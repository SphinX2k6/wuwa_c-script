using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E8 RID: 17128
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ML_BaseRole.ML_BaseRole_C")]
	[UnrealStructLayout(2240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public abstract class ML_BaseRole_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C39C RID: 181148 RVA: 0x00A1A8D0 File Offset: 0x00A18AD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ML_BaseRole_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/ML_BaseRole.ML_BaseRole_C");
			}
			return ML_BaseRole_C._ClassPtr;
		}

		// Token: 0x0602C39D RID: 181149 RVA: 0x00A1A8F4 File Offset: 0x00A18AF4
		protected ML_BaseRole_C() : this(BuiltinUtils.AllocNativeUObject(ML_BaseRole_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C39E RID: 181150 RVA: 0x00A1A91C File Offset: 0x00A18B1C
		protected ML_BaseRole_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017515 RID: 95509
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/ML_BaseRole.ML_BaseRole_C";

		// Token: 0x04017516 RID: 95510
		private static IntPtr _ClassPtr;

		// Token: 0x04017517 RID: 95511
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
