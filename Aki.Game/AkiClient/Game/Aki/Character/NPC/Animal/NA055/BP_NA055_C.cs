using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA055
{
	// Token: 0x020041E4 RID: 16868
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA055/BP_NA055.BP_NA055_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_NA055_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD4F RID: 179535 RVA: 0x00A0BD4E File Offset: 0x00A09F4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA055_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA055/BP_NA055.BP_NA055_C");
			}
			return BP_NA055_C._ClassPtr;
		}

		// Token: 0x0602BD50 RID: 179536 RVA: 0x00A0BD74 File Offset: 0x00A09F74
		public BP_NA055_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA055_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD51 RID: 179537 RVA: 0x00A0BD9C File Offset: 0x00A09F9C
		[NullableContext(1)]
		public BP_NA055_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA055_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CEA RID: 27882
		// (get) Token: 0x0602BD52 RID: 179538 RVA: 0x00A0BDCF File Offset: 0x00A09FCF
		// (set) Token: 0x0602BD53 RID: 179539 RVA: 0x00A0BDE3 File Offset: 0x00A09FE3
		[Nullable(2)]
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA055_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA055_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602BD54 RID: 179540 RVA: 0x00A0BDF8 File Offset: 0x00A09FF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA055_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD55 RID: 179541 RVA: 0x00A0BE0C File Offset: 0x00A0A00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA055_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BD56 RID: 179542 RVA: 0x00A0BE21 File Offset: 0x00A0A021
		protected BP_NA055_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DC7 RID: 93639
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA055/BP_NA055.BP_NA055_C";

		// Token: 0x04016DC8 RID: 93640
		private static IntPtr _ClassPtr;

		// Token: 0x04016DC9 RID: 93641
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016DCA RID: 93642
		internal static int __PropertyOffset_1;

		// Token: 0x04016DCB RID: 93643
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
