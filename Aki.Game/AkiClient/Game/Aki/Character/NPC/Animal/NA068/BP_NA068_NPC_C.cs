using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA068
{
	// Token: 0x020041BA RID: 16826
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA068/BP_NA068_NPC.BP_NA068_NPC_C")]
	[UnrealStructLayout(2352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2352)]
	public class BP_NA068_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC5A RID: 179290 RVA: 0x00A0A0C0 File Offset: 0x00A082C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA068_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA068/BP_NA068_NPC.BP_NA068_NPC_C");
			}
			return BP_NA068_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC5B RID: 179291 RVA: 0x00A0A0E4 File Offset: 0x00A082E4
		public BP_NA068_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA068_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC5C RID: 179292 RVA: 0x00A0A10C File Offset: 0x00A0830C
		[NullableContext(1)]
		public BP_NA068_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA068_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CD1 RID: 27857
		// (get) Token: 0x0602BC5D RID: 179293 RVA: 0x00A0A13F File Offset: 0x00A0833F
		// (set) Token: 0x0602BC5E RID: 179294 RVA: 0x00A0A153 File Offset: 0x00A08353
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_NPC_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_NPC_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006CD2 RID: 27858
		// (get) Token: 0x0602BC5F RID: 179295 RVA: 0x00A0A168 File Offset: 0x00A08368
		// (set) Token: 0x0602BC60 RID: 179296 RVA: 0x00A0A17C File Offset: 0x00A0837C
		public unsafe UCapsuleComponent Capsule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_NPC_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_NPC_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602BC61 RID: 179297 RVA: 0x00A0A191 File Offset: 0x00A08391
		protected BP_NA068_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D20 RID: 93472
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA068/BP_NA068_NPC.BP_NA068_NPC_C";

		// Token: 0x04016D21 RID: 93473
		private static IntPtr _ClassPtr;

		// Token: 0x04016D22 RID: 93474
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D23 RID: 93475
		internal static int __PropertyOffset_0;

		// Token: 0x04016D24 RID: 93476
		internal new static int __PropertyOffset_1;
	}
}
