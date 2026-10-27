using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA065
{
	// Token: 0x020041C4 RID: 16836
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA065/ABP_NA065_NPC.ABP_NA065_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA065_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC90 RID: 179344 RVA: 0x00A0A734 File Offset: 0x00A08934
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA065_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA065/ABP_NA065_NPC.ABP_NA065_NPC_C");
			}
			return ABP_NA065_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC91 RID: 179345 RVA: 0x00A0A758 File Offset: 0x00A08958
		public ABP_NA065_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA065_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC92 RID: 179346 RVA: 0x00A0A780 File Offset: 0x00A08980
		[NullableContext(1)]
		public ABP_NA065_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA065_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC93 RID: 179347 RVA: 0x00A0A7B3 File Offset: 0x00A089B3
		protected ABP_NA065_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D45 RID: 93509
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA065/ABP_NA065_NPC.ABP_NA065_NPC_C";

		// Token: 0x04016D46 RID: 93510
		private static IntPtr _ClassPtr;

		// Token: 0x04016D47 RID: 93511
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
