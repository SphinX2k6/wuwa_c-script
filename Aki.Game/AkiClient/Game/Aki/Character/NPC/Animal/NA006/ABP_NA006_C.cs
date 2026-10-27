using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA006
{
	// Token: 0x0200423B RID: 16955
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA006/ABP_NA006.ABP_NA006_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA006_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEE4 RID: 179940 RVA: 0x00A0F368 File Offset: 0x00A0D568
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA006_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA006/ABP_NA006.ABP_NA006_C");
			}
			return ABP_NA006_C._ClassPtr;
		}

		// Token: 0x0602BEE5 RID: 179941 RVA: 0x00A0F38C File Offset: 0x00A0D58C
		public ABP_NA006_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA006_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEE6 RID: 179942 RVA: 0x00A0F3B4 File Offset: 0x00A0D5B4
		[NullableContext(1)]
		public ABP_NA006_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA006_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEE7 RID: 179943 RVA: 0x00A0F3E7 File Offset: 0x00A0D5E7
		protected ABP_NA006_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EF2 RID: 93938
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA006/ABP_NA006.ABP_NA006_C";

		// Token: 0x04016EF3 RID: 93939
		private static IntPtr _ClassPtr;

		// Token: 0x04016EF4 RID: 93940
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
