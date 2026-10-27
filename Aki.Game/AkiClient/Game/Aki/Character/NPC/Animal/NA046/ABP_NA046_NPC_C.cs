using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA046
{
	// Token: 0x020041F2 RID: 16882
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA046/ABP_NA046_NPC.ABP_NA046_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA046_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD8B RID: 179595 RVA: 0x00A0C514 File Offset: 0x00A0A714
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA046_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA046/ABP_NA046_NPC.ABP_NA046_NPC_C");
			}
			return ABP_NA046_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD8C RID: 179596 RVA: 0x00A0C538 File Offset: 0x00A0A738
		public ABP_NA046_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA046_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD8D RID: 179597 RVA: 0x00A0C560 File Offset: 0x00A0A760
		[NullableContext(1)]
		public ABP_NA046_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA046_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD8E RID: 179598 RVA: 0x00A0C593 File Offset: 0x00A0A793
		protected ABP_NA046_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DF3 RID: 93683
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA046/ABP_NA046_NPC.ABP_NA046_NPC_C";

		// Token: 0x04016DF4 RID: 93684
		private static IntPtr _ClassPtr;

		// Token: 0x04016DF5 RID: 93685
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
