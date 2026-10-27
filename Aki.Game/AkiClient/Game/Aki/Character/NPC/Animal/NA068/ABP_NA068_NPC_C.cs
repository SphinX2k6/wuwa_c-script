using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA068
{
	// Token: 0x020041B8 RID: 16824
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA068/ABP_NA068_NPC.ABP_NA068_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA068_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC4A RID: 179274 RVA: 0x00A09F0C File Offset: 0x00A0810C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA068_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA068/ABP_NA068_NPC.ABP_NA068_NPC_C");
			}
			return ABP_NA068_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC4B RID: 179275 RVA: 0x00A09F30 File Offset: 0x00A08130
		public ABP_NA068_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA068_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC4C RID: 179276 RVA: 0x00A09F58 File Offset: 0x00A08158
		[NullableContext(1)]
		public ABP_NA068_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA068_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC4D RID: 179277 RVA: 0x00A09F8B File Offset: 0x00A0818B
		protected ABP_NA068_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D16 RID: 93462
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA068/ABP_NA068_NPC.ABP_NA068_NPC_C";

		// Token: 0x04016D17 RID: 93463
		private static IntPtr _ClassPtr;

		// Token: 0x04016D18 RID: 93464
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
