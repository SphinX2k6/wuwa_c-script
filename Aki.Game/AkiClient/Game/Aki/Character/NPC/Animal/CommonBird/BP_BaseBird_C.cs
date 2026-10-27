using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.CommonBird
{
	// Token: 0x02004248 RID: 16968
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/CommonBird/BP_BaseBird.BP_BaseBird_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_BaseBird_C : BP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF41 RID: 180033 RVA: 0x00A10104 File Offset: 0x00A0E304
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseBird_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/CommonBird/BP_BaseBird.BP_BaseBird_C");
			}
			return BP_BaseBird_C._ClassPtr;
		}

		// Token: 0x0602BF42 RID: 180034 RVA: 0x00A10128 File Offset: 0x00A0E328
		public BP_BaseBird_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseBird_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF43 RID: 180035 RVA: 0x00A10150 File Offset: 0x00A0E350
		[NullableContext(1)]
		public BP_BaseBird_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseBird_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BF44 RID: 180036 RVA: 0x00A10183 File Offset: 0x00A0E383
		protected BP_BaseBird_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F32 RID: 94002
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/CommonBird/BP_BaseBird.BP_BaseBird_C";

		// Token: 0x04016F33 RID: 94003
		private static IntPtr _ClassPtr;

		// Token: 0x04016F34 RID: 94004
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
