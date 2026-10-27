using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.CommonBigAnimal
{
	// Token: 0x0200424A RID: 16970
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/CommonBigAnimal/BP_CommonBigAnimal.BP_CommonBigAnimal_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_CommonBigAnimal_C : BP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF5B RID: 180059 RVA: 0x00A104B1 File Offset: 0x00A0E6B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CommonBigAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/CommonBigAnimal/BP_CommonBigAnimal.BP_CommonBigAnimal_C");
			}
			return BP_CommonBigAnimal_C._ClassPtr;
		}

		// Token: 0x0602BF5C RID: 180060 RVA: 0x00A104D8 File Offset: 0x00A0E6D8
		public BP_CommonBigAnimal_C() : this(BuiltinUtils.AllocNativeUObject(BP_CommonBigAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF5D RID: 180061 RVA: 0x00A10500 File Offset: 0x00A0E700
		[NullableContext(1)]
		public BP_CommonBigAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CommonBigAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BF5E RID: 180062 RVA: 0x00A10533 File Offset: 0x00A0E733
		protected BP_CommonBigAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F43 RID: 94019
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/CommonBigAnimal/BP_CommonBigAnimal.BP_CommonBigAnimal_C";

		// Token: 0x04016F44 RID: 94020
		private static IntPtr _ClassPtr;

		// Token: 0x04016F45 RID: 94021
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
