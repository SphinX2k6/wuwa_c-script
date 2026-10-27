using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal
{
	// Token: 0x02004244 RID: 16964
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/CommonSmallAnimal/BP_CommonSmallAnimal.BP_CommonSmallAnimal_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_CommonSmallAnimal_C : BP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF1B RID: 179995 RVA: 0x00A0FAFD File Offset: 0x00A0DCFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CommonSmallAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/CommonSmallAnimal/BP_CommonSmallAnimal.BP_CommonSmallAnimal_C");
			}
			return BP_CommonSmallAnimal_C._ClassPtr;
		}

		// Token: 0x0602BF1C RID: 179996 RVA: 0x00A0FB24 File Offset: 0x00A0DD24
		public BP_CommonSmallAnimal_C() : this(BuiltinUtils.AllocNativeUObject(BP_CommonSmallAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF1D RID: 179997 RVA: 0x00A0FB4C File Offset: 0x00A0DD4C
		[NullableContext(1)]
		public BP_CommonSmallAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CommonSmallAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BF1E RID: 179998 RVA: 0x00A0FB7F File Offset: 0x00A0DD7F
		protected BP_CommonSmallAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F18 RID: 93976
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/CommonSmallAnimal/BP_CommonSmallAnimal.BP_CommonSmallAnimal_C";

		// Token: 0x04016F19 RID: 93977
		private static IntPtr _ClassPtr;

		// Token: 0x04016F1A RID: 93978
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
