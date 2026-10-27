using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA067
{
	// Token: 0x020041BC RID: 16828
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA067/ABP_NA067_NPC.ABP_NA067_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA067_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC66 RID: 179302 RVA: 0x00A0A224 File Offset: 0x00A08424
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA067_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA067/ABP_NA067_NPC.ABP_NA067_NPC_C");
			}
			return ABP_NA067_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC67 RID: 179303 RVA: 0x00A0A248 File Offset: 0x00A08448
		public ABP_NA067_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA067_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC68 RID: 179304 RVA: 0x00A0A270 File Offset: 0x00A08470
		[NullableContext(1)]
		public ABP_NA067_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA067_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC69 RID: 179305 RVA: 0x00A0A2A3 File Offset: 0x00A084A3
		protected ABP_NA067_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D28 RID: 93480
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA067/ABP_NA067_NPC.ABP_NA067_NPC_C";

		// Token: 0x04016D29 RID: 93481
		private static IntPtr _ClassPtr;

		// Token: 0x04016D2A RID: 93482
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
