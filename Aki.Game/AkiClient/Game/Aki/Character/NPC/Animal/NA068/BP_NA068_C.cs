using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA068
{
	// Token: 0x020041B9 RID: 16825
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA068/BP_NA068.BP_NA068_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class BP_NA068_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC4E RID: 179278 RVA: 0x00A09F94 File Offset: 0x00A08194
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA068_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA068/BP_NA068.BP_NA068_C");
			}
			return BP_NA068_C._ClassPtr;
		}

		// Token: 0x0602BC4F RID: 179279 RVA: 0x00A09FB8 File Offset: 0x00A081B8
		public BP_NA068_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA068_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC50 RID: 179280 RVA: 0x00A09FE0 File Offset: 0x00A081E0
		[NullableContext(1)]
		public BP_NA068_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA068_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CCE RID: 27854
		// (get) Token: 0x0602BC51 RID: 179281 RVA: 0x00A0A013 File Offset: 0x00A08213
		// (set) Token: 0x0602BC52 RID: 179282 RVA: 0x00A0A027 File Offset: 0x00A08227
		public unsafe BP_SnowTrailComponent_NPC_C BP_SnowTrailComponent_NPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTrailComponent_NPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CCF RID: 27855
		// (get) Token: 0x0602BC53 RID: 179283 RVA: 0x00A0A03C File Offset: 0x00A0823C
		// (set) Token: 0x0602BC54 RID: 179284 RVA: 0x00A0A050 File Offset: 0x00A08250
		public unsafe UCapsuleComponent Capsule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006CD0 RID: 27856
		// (get) Token: 0x0602BC55 RID: 179285 RVA: 0x00A0A065 File Offset: 0x00A08265
		// (set) Token: 0x0602BC56 RID: 179286 RVA: 0x00A0A079 File Offset: 0x00A08279
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA068_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602BC57 RID: 179287 RVA: 0x00A0A08E File Offset: 0x00A0828E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA068_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BC58 RID: 179288 RVA: 0x00A0A0A2 File Offset: 0x00A082A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA068_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BC59 RID: 179289 RVA: 0x00A0A0B7 File Offset: 0x00A082B7
		protected BP_NA068_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D19 RID: 93465
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA068/BP_NA068.BP_NA068_C";

		// Token: 0x04016D1A RID: 93466
		private static IntPtr _ClassPtr;

		// Token: 0x04016D1B RID: 93467
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D1C RID: 93468
		internal static int __PropertyOffset_1;

		// Token: 0x04016D1D RID: 93469
		internal static int __PropertyOffset_2;

		// Token: 0x04016D1E RID: 93470
		internal static int __PropertyOffset_3;

		// Token: 0x04016D1F RID: 93471
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
