using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA058
{
	// Token: 0x020041DC RID: 16860
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA058/BP_NA058Monster.BP_NA058Monster_C")]
	[UnrealStructLayout(2240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public class BP_NA058Monster_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD24 RID: 179492 RVA: 0x00A0B82C File Offset: 0x00A09A2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA058Monster_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA058/BP_NA058Monster.BP_NA058Monster_C");
			}
			return BP_NA058Monster_C._ClassPtr;
		}

		// Token: 0x0602BD25 RID: 179493 RVA: 0x00A0B850 File Offset: 0x00A09A50
		public BP_NA058Monster_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA058Monster_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD26 RID: 179494 RVA: 0x00A0B878 File Offset: 0x00A09A78
		[NullableContext(1)]
		public BP_NA058Monster_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA058Monster_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD27 RID: 179495 RVA: 0x00A0B8AB File Offset: 0x00A09AAB
		protected BP_NA058Monster_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DA7 RID: 93607
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA058/BP_NA058Monster.BP_NA058Monster_C";

		// Token: 0x04016DA8 RID: 93608
		private static IntPtr _ClassPtr;

		// Token: 0x04016DA9 RID: 93609
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
