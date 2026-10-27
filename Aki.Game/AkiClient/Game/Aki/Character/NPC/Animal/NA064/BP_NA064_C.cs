using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA064
{
	// Token: 0x020041CA RID: 16842
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA064/BP_NA064.BP_NA064_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class BP_NA064_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCAE RID: 179374 RVA: 0x00A0AAE0 File Offset: 0x00A08CE0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA064_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA064/BP_NA064.BP_NA064_C");
			}
			return BP_NA064_C._ClassPtr;
		}

		// Token: 0x0602BCAF RID: 179375 RVA: 0x00A0AB04 File Offset: 0x00A08D04
		public BP_NA064_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA064_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCB0 RID: 179376 RVA: 0x00A0AB2C File Offset: 0x00A08D2C
		[NullableContext(1)]
		public BP_NA064_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA064_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CD9 RID: 27865
		// (get) Token: 0x0602BCB1 RID: 179377 RVA: 0x00A0AB5F File Offset: 0x00A08D5F
		// (set) Token: 0x0602BCB2 RID: 179378 RVA: 0x00A0AB73 File Offset: 0x00A08D73
		public unsafe BP_SnowTrailComponent_NPC_C BP_SnowTrailComponent_NPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTrailComponent_NPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA064_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA064_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CDA RID: 27866
		// (get) Token: 0x0602BCB3 RID: 179379 RVA: 0x00A0AB88 File Offset: 0x00A08D88
		// (set) Token: 0x0602BCB4 RID: 179380 RVA: 0x00A0AB9C File Offset: 0x00A08D9C
		public unsafe UCapsuleComponent Capsule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA064_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA064_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006CDB RID: 27867
		// (get) Token: 0x0602BCB5 RID: 179381 RVA: 0x00A0ABB1 File Offset: 0x00A08DB1
		// (set) Token: 0x0602BCB6 RID: 179382 RVA: 0x00A0ABC5 File Offset: 0x00A08DC5
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA064_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA064_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602BCB7 RID: 179383 RVA: 0x00A0ABDA File Offset: 0x00A08DDA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA064_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BCB8 RID: 179384 RVA: 0x00A0ABEE File Offset: 0x00A08DEE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA064_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BCB9 RID: 179385 RVA: 0x00A0AC03 File Offset: 0x00A08E03
		protected BP_NA064_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D5A RID: 93530
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA064/BP_NA064.BP_NA064_C";

		// Token: 0x04016D5B RID: 93531
		private static IntPtr _ClassPtr;

		// Token: 0x04016D5C RID: 93532
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D5D RID: 93533
		internal static int __PropertyOffset_1;

		// Token: 0x04016D5E RID: 93534
		internal static int __PropertyOffset_2;

		// Token: 0x04016D5F RID: 93535
		internal static int __PropertyOffset_3;

		// Token: 0x04016D60 RID: 93536
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
