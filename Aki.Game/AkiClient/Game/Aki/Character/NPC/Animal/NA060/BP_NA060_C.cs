using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA060
{
	// Token: 0x020041D5 RID: 16853
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA060/BP_NA060.BP_NA060_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2280)]
	public class BP_NA060_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCF0 RID: 179440 RVA: 0x00A0B284 File Offset: 0x00A09484
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA060_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA060/BP_NA060.BP_NA060_C");
			}
			return BP_NA060_C._ClassPtr;
		}

		// Token: 0x0602BCF1 RID: 179441 RVA: 0x00A0B2A8 File Offset: 0x00A094A8
		public BP_NA060_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA060_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCF2 RID: 179442 RVA: 0x00A0B2D0 File Offset: 0x00A094D0
		[NullableContext(1)]
		public BP_NA060_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA060_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CE0 RID: 27872
		// (get) Token: 0x0602BCF3 RID: 179443 RVA: 0x00A0B303 File Offset: 0x00A09503
		// (set) Token: 0x0602BCF4 RID: 179444 RVA: 0x00A0B317 File Offset: 0x00A09517
		public unsafe UCapsuleComponent Capsule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA060_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA060_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CE1 RID: 27873
		// (get) Token: 0x0602BCF5 RID: 179445 RVA: 0x00A0B32C File Offset: 0x00A0952C
		// (set) Token: 0x0602BCF6 RID: 179446 RVA: 0x00A0B340 File Offset: 0x00A09540
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA060_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA060_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602BCF7 RID: 179447 RVA: 0x00A0B355 File Offset: 0x00A09555
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA060_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BCF8 RID: 179448 RVA: 0x00A0B369 File Offset: 0x00A09569
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA060_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BCF9 RID: 179449 RVA: 0x00A0B37E File Offset: 0x00A0957E
		protected BP_NA060_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D86 RID: 93574
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA060/BP_NA060.BP_NA060_C";

		// Token: 0x04016D87 RID: 93575
		private static IntPtr _ClassPtr;

		// Token: 0x04016D88 RID: 93576
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D89 RID: 93577
		internal static int __PropertyOffset_1;

		// Token: 0x04016D8A RID: 93578
		internal static int __PropertyOffset_2;

		// Token: 0x04016D8B RID: 93579
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
