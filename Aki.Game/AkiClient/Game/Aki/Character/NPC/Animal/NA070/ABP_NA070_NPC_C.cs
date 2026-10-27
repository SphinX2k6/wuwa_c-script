using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA070
{
	// Token: 0x020041B1 RID: 16817
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA070/ABP_NA070_NPC.ABP_NA070_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA070_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC26 RID: 179238 RVA: 0x00A09AAC File Offset: 0x00A07CAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA070_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA070/ABP_NA070_NPC.ABP_NA070_NPC_C");
			}
			return ABP_NA070_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC27 RID: 179239 RVA: 0x00A09AD0 File Offset: 0x00A07CD0
		public ABP_NA070_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA070_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC28 RID: 179240 RVA: 0x00A09AF8 File Offset: 0x00A07CF8
		[NullableContext(1)]
		public ABP_NA070_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA070_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC29 RID: 179241 RVA: 0x00A09B2B File Offset: 0x00A07D2B
		protected ABP_NA070_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CFD RID: 93437
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA070/ABP_NA070_NPC.ABP_NA070_NPC_C";

		// Token: 0x04016CFE RID: 93438
		private static IntPtr _ClassPtr;

		// Token: 0x04016CFF RID: 93439
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
