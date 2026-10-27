using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Template
{
	// Token: 0x020043E9 RID: 17385
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Infinite.GE_Template_Infinite_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Template_Infinite_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D09A RID: 184474 RVA: 0x00A2F14C File Offset: 0x00A2D34C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Template_Infinite_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Infinite.GE_Template_Infinite_C");
			}
			return GE_Template_Infinite_C._ClassPtr;
		}

		// Token: 0x0602D09B RID: 184475 RVA: 0x00A2F170 File Offset: 0x00A2D370
		public GE_Template_Infinite_C() : this(BuiltinUtils.AllocNativeUObject(GE_Template_Infinite_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D09C RID: 184476 RVA: 0x00A2F198 File Offset: 0x00A2D398
		[NullableContext(1)]
		public GE_Template_Infinite_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Template_Infinite_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D09D RID: 184477 RVA: 0x00A2F1CB File Offset: 0x00A2D3CB
		protected GE_Template_Infinite_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E6C RID: 97900
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Infinite.GE_Template_Infinite_C";

		// Token: 0x04017E6D RID: 97901
		private static IntPtr _ClassPtr;

		// Token: 0x04017E6E RID: 97902
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
