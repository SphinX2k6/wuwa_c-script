using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA059
{
	// Token: 0x020041DA RID: 16858
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA059/BP_NA059_NPC.BP_NA059_NPC_C")]
	[UnrealStructLayout(2368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2360)]
	public class BP_NA059_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD16 RID: 179478 RVA: 0x00A0B69F File Offset: 0x00A0989F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA059_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA059/BP_NA059_NPC.BP_NA059_NPC_C");
			}
			return BP_NA059_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD17 RID: 179479 RVA: 0x00A0B6C4 File Offset: 0x00A098C4
		public BP_NA059_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA059_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD18 RID: 179480 RVA: 0x00A0B6EC File Offset: 0x00A098EC
		[NullableContext(1)]
		public BP_NA059_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA059_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CE6 RID: 27878
		// (get) Token: 0x0602BD19 RID: 179481 RVA: 0x00A0B71F File Offset: 0x00A0991F
		// (set) Token: 0x0602BD1A RID: 179482 RVA: 0x00A0B733 File Offset: 0x00A09933
		public unsafe UKuroAdjustableCapsuleComponent Bip001_Bone_Forearm_R
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006CE7 RID: 27879
		// (get) Token: 0x0602BD1B RID: 179483 RVA: 0x00A0B748 File Offset: 0x00A09948
		// (set) Token: 0x0602BD1C RID: 179484 RVA: 0x00A0B75C File Offset: 0x00A0995C
		public unsafe UKuroAdjustableCapsuleComponent Bip001_Bone_Forearm_L
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CE8 RID: 27880
		// (get) Token: 0x0602BD1D RID: 179485 RVA: 0x00A0B771 File Offset: 0x00A09971
		// (set) Token: 0x0602BD1E RID: 179486 RVA: 0x00A0B785 File Offset: 0x00A09985
		public unsafe UKuroAdjustableCapsuleComponent Bip001
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602BD1F RID: 179487 RVA: 0x00A0B79A File Offset: 0x00A0999A
		protected BP_NA059_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D9E RID: 93598
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA059/BP_NA059_NPC.BP_NA059_NPC_C";

		// Token: 0x04016D9F RID: 93599
		private static IntPtr _ClassPtr;

		// Token: 0x04016DA0 RID: 93600
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016DA1 RID: 93601
		internal static int __PropertyOffset_0;

		// Token: 0x04016DA2 RID: 93602
		internal new static int __PropertyOffset_1;

		// Token: 0x04016DA3 RID: 93603
		internal new static int __PropertyOffset_2;
	}
}
