using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA065
{
	// Token: 0x020041C5 RID: 16837
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA065/BP_NA065.BP_NA065_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2280)]
	public class BP_NA065_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC94 RID: 179348 RVA: 0x00A0A7BC File Offset: 0x00A089BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA065_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA065/BP_NA065.BP_NA065_C");
			}
			return BP_NA065_C._ClassPtr;
		}

		// Token: 0x0602BC95 RID: 179349 RVA: 0x00A0A7E0 File Offset: 0x00A089E0
		public BP_NA065_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA065_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC96 RID: 179350 RVA: 0x00A0A808 File Offset: 0x00A08A08
		[NullableContext(1)]
		public BP_NA065_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA065_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CD7 RID: 27863
		// (get) Token: 0x0602BC97 RID: 179351 RVA: 0x00A0A83B File Offset: 0x00A08A3B
		// (set) Token: 0x0602BC98 RID: 179352 RVA: 0x00A0A84F File Offset: 0x00A08A4F
		public unsafe BP_SnowTrailComponent_NPC_C BP_SnowTrailComponent_NPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTrailComponent_NPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA065_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA065_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CD8 RID: 27864
		// (get) Token: 0x0602BC99 RID: 179353 RVA: 0x00A0A864 File Offset: 0x00A08A64
		// (set) Token: 0x0602BC9A RID: 179354 RVA: 0x00A0A878 File Offset: 0x00A08A78
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA065_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA065_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602BC9B RID: 179355 RVA: 0x00A0A88D File Offset: 0x00A08A8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA065_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BC9C RID: 179356 RVA: 0x00A0A8A1 File Offset: 0x00A08AA1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA065_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BC9D RID: 179357 RVA: 0x00A0A8B6 File Offset: 0x00A08AB6
		protected BP_NA065_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D48 RID: 93512
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA065/BP_NA065.BP_NA065_C";

		// Token: 0x04016D49 RID: 93513
		private static IntPtr _ClassPtr;

		// Token: 0x04016D4A RID: 93514
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D4B RID: 93515
		internal static int __PropertyOffset_1;

		// Token: 0x04016D4C RID: 93516
		internal static int __PropertyOffset_2;

		// Token: 0x04016D4D RID: 93517
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
