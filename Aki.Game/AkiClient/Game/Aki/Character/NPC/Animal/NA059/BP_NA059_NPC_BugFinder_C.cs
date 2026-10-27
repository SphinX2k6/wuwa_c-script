using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA059
{
	// Token: 0x020041D9 RID: 16857
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA059/BP_NA059_NPC_BugFinder.BP_NA059_NPC_BugFinder_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2280)]
	public class BP_NA059_NPC_BugFinder_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD0C RID: 179468 RVA: 0x00A0B59B File Offset: 0x00A0979B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA059_NPC_BugFinder_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA059/BP_NA059_NPC_BugFinder.BP_NA059_NPC_BugFinder_C");
			}
			return BP_NA059_NPC_BugFinder_C._ClassPtr;
		}

		// Token: 0x0602BD0D RID: 179469 RVA: 0x00A0B5C0 File Offset: 0x00A097C0
		public BP_NA059_NPC_BugFinder_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA059_NPC_BugFinder_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD0E RID: 179470 RVA: 0x00A0B5E8 File Offset: 0x00A097E8
		[NullableContext(1)]
		public BP_NA059_NPC_BugFinder_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA059_NPC_BugFinder_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CE4 RID: 27876
		// (get) Token: 0x0602BD0F RID: 179471 RVA: 0x00A0B61B File Offset: 0x00A0981B
		// (set) Token: 0x0602BD10 RID: 179472 RVA: 0x00A0B62F File Offset: 0x00A0982F
		public unsafe UCapsuleComponent Capsule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_BugFinder_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_BugFinder_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CE5 RID: 27877
		// (get) Token: 0x0602BD11 RID: 179473 RVA: 0x00A0B644 File Offset: 0x00A09844
		// (set) Token: 0x0602BD12 RID: 179474 RVA: 0x00A0B658 File Offset: 0x00A09858
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_BugFinder_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_NPC_BugFinder_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602BD13 RID: 179475 RVA: 0x00A0B66D File Offset: 0x00A0986D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA059_NPC_BugFinder_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD14 RID: 179476 RVA: 0x00A0B681 File Offset: 0x00A09881
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA059_NPC_BugFinder_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BD15 RID: 179477 RVA: 0x00A0B696 File Offset: 0x00A09896
		protected BP_NA059_NPC_BugFinder_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D98 RID: 93592
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA059/BP_NA059_NPC_BugFinder.BP_NA059_NPC_BugFinder_C";

		// Token: 0x04016D99 RID: 93593
		private static IntPtr _ClassPtr;

		// Token: 0x04016D9A RID: 93594
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D9B RID: 93595
		internal static int __PropertyOffset_1;

		// Token: 0x04016D9C RID: 93596
		internal static int __PropertyOffset_2;

		// Token: 0x04016D9D RID: 93597
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
