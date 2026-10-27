using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA002
{
	// Token: 0x02004242 RID: 16962
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA002/BP_NA002.BP_NA002_C")]
	[UnrealStructLayout(2240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public class BP_NA002_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF06 RID: 179974 RVA: 0x00A0F7A4 File Offset: 0x00A0D9A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA002_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA002/BP_NA002.BP_NA002_C");
			}
			return BP_NA002_C._ClassPtr;
		}

		// Token: 0x0602BF07 RID: 179975 RVA: 0x00A0F7C8 File Offset: 0x00A0D9C8
		public BP_NA002_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA002_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF08 RID: 179976 RVA: 0x00A0F7F0 File Offset: 0x00A0D9F0
		[NullableContext(1)]
		public BP_NA002_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA002_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BF09 RID: 179977 RVA: 0x00A0F823 File Offset: 0x00A0DA23
		protected BP_NA002_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F0A RID: 93962
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA002/BP_NA002.BP_NA002_C";

		// Token: 0x04016F0B RID: 93963
		private static IntPtr _ClassPtr;

		// Token: 0x04016F0C RID: 93964
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
