using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA018
{
	// Token: 0x0200421D RID: 16925
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA018/ABP_NA018_NPC.ABP_NA018_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA018_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE5A RID: 179802 RVA: 0x00A0E0F8 File Offset: 0x00A0C2F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA018_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA018/ABP_NA018_NPC.ABP_NA018_NPC_C");
			}
			return ABP_NA018_NPC_C._ClassPtr;
		}

		// Token: 0x0602BE5B RID: 179803 RVA: 0x00A0E11C File Offset: 0x00A0C31C
		public ABP_NA018_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA018_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE5C RID: 179804 RVA: 0x00A0E144 File Offset: 0x00A0C344
		[NullableContext(1)]
		public ABP_NA018_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA018_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE5D RID: 179805 RVA: 0x00A0E177 File Offset: 0x00A0C377
		protected ABP_NA018_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E8D RID: 93837
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA018/ABP_NA018_NPC.ABP_NA018_NPC_C";

		// Token: 0x04016E8E RID: 93838
		private static IntPtr _ClassPtr;

		// Token: 0x04016E8F RID: 93839
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
