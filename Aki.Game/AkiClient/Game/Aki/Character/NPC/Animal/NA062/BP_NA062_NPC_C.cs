using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA062
{
	// Token: 0x020041CF RID: 16847
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA062/BP_NA062_NPC.BP_NA062_NPC_C")]
	[UnrealStructLayout(2352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2344)]
	public class BP_NA062_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCCE RID: 179406 RVA: 0x00A0AE7E File Offset: 0x00A0907E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA062_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA062/BP_NA062_NPC.BP_NA062_NPC_C");
			}
			return BP_NA062_NPC_C._ClassPtr;
		}

		// Token: 0x0602BCCF RID: 179407 RVA: 0x00A0AEA4 File Offset: 0x00A090A4
		public BP_NA062_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA062_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCD0 RID: 179408 RVA: 0x00A0AECC File Offset: 0x00A090CC
		[NullableContext(1)]
		public BP_NA062_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA062_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CDD RID: 27869
		// (get) Token: 0x0602BCD1 RID: 179409 RVA: 0x00A0AEFF File Offset: 0x00A090FF
		// (set) Token: 0x0602BCD2 RID: 179410 RVA: 0x00A0AF13 File Offset: 0x00A09113
		[Nullable(2)]
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA062_NPC_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA062_NPC_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BCD3 RID: 179411 RVA: 0x00A0AF28 File Offset: 0x00A09128
		protected BP_NA062_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D6F RID: 93551
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA062/BP_NA062_NPC.BP_NA062_NPC_C";

		// Token: 0x04016D70 RID: 93552
		private static IntPtr _ClassPtr;

		// Token: 0x04016D71 RID: 93553
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D72 RID: 93554
		internal static int __PropertyOffset_0;
	}
}
