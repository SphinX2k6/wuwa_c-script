using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA059
{
	// Token: 0x020041D7 RID: 16855
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA059/ABP_NA059_NPC.ABP_NA059_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA059_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCFE RID: 179454 RVA: 0x00A0B410 File Offset: 0x00A09610
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA059_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA059/ABP_NA059_NPC.ABP_NA059_NPC_C");
			}
			return ABP_NA059_NPC_C._ClassPtr;
		}

		// Token: 0x0602BCFF RID: 179455 RVA: 0x00A0B434 File Offset: 0x00A09634
		public ABP_NA059_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA059_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD00 RID: 179456 RVA: 0x00A0B45C File Offset: 0x00A0965C
		[NullableContext(1)]
		public ABP_NA059_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA059_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD01 RID: 179457 RVA: 0x00A0B48F File Offset: 0x00A0968F
		protected ABP_NA059_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D8F RID: 93583
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA059/ABP_NA059_NPC.ABP_NA059_NPC_C";

		// Token: 0x04016D90 RID: 93584
		private static IntPtr _ClassPtr;

		// Token: 0x04016D91 RID: 93585
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
