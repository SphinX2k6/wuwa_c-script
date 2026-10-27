using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA015
{
	// Token: 0x02004227 RID: 16935
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA015/ABP_NPC_NA015.ABP_NPC_NA015_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NPC_NA015_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE8A RID: 179850 RVA: 0x00A0E72C File Offset: 0x00A0C92C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NPC_NA015_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA015/ABP_NPC_NA015.ABP_NPC_NA015_C");
			}
			return ABP_NPC_NA015_C._ClassPtr;
		}

		// Token: 0x0602BE8B RID: 179851 RVA: 0x00A0E750 File Offset: 0x00A0C950
		public ABP_NPC_NA015_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NPC_NA015_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE8C RID: 179852 RVA: 0x00A0E778 File Offset: 0x00A0C978
		[NullableContext(1)]
		public ABP_NPC_NA015_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NPC_NA015_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE8D RID: 179853 RVA: 0x00A0E7AB File Offset: 0x00A0C9AB
		protected ABP_NPC_NA015_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EB1 RID: 93873
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA015/ABP_NPC_NA015.ABP_NPC_NA015_C";

		// Token: 0x04016EB2 RID: 93874
		private static IntPtr _ClassPtr;

		// Token: 0x04016EB3 RID: 93875
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
