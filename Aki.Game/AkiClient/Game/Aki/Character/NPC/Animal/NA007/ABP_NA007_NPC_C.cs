using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA007
{
	// Token: 0x02004235 RID: 16949
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA007/ABP_NA007_NPC.ABP_NA007_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA007_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BECC RID: 179916 RVA: 0x00A0F038 File Offset: 0x00A0D238
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA007_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA007/ABP_NA007_NPC.ABP_NA007_NPC_C");
			}
			return ABP_NA007_NPC_C._ClassPtr;
		}

		// Token: 0x0602BECD RID: 179917 RVA: 0x00A0F05C File Offset: 0x00A0D25C
		public ABP_NA007_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA007_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BECE RID: 179918 RVA: 0x00A0F084 File Offset: 0x00A0D284
		[NullableContext(1)]
		public ABP_NA007_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA007_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BECF RID: 179919 RVA: 0x00A0F0B7 File Offset: 0x00A0D2B7
		protected ABP_NA007_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EE0 RID: 93920
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA007/ABP_NA007_NPC.ABP_NA007_NPC_C";

		// Token: 0x04016EE1 RID: 93921
		private static IntPtr _ClassPtr;

		// Token: 0x04016EE2 RID: 93922
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
