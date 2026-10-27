using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA066
{
	// Token: 0x020041BF RID: 16831
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA066/ABP_NA066.ABP_NA066_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA066_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC72 RID: 179314 RVA: 0x00A0A3BC File Offset: 0x00A085BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA066_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA066/ABP_NA066.ABP_NA066_C");
			}
			return ABP_NA066_C._ClassPtr;
		}

		// Token: 0x0602BC73 RID: 179315 RVA: 0x00A0A3E0 File Offset: 0x00A085E0
		public ABP_NA066_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA066_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC74 RID: 179316 RVA: 0x00A0A408 File Offset: 0x00A08608
		[NullableContext(1)]
		public ABP_NA066_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA066_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC75 RID: 179317 RVA: 0x00A0A43B File Offset: 0x00A0863B
		protected ABP_NA066_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D31 RID: 93489
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA066/ABP_NA066.ABP_NA066_C";

		// Token: 0x04016D32 RID: 93490
		private static IntPtr _ClassPtr;

		// Token: 0x04016D33 RID: 93491
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
