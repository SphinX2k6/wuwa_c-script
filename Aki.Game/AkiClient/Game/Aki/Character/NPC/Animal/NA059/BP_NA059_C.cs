using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA059
{
	// Token: 0x020041D8 RID: 16856
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA059/BP_NA059.BP_NA059_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2280)]
	public class BP_NA059_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD02 RID: 179458 RVA: 0x00A0B498 File Offset: 0x00A09698
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA059_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA059/BP_NA059.BP_NA059_C");
			}
			return BP_NA059_C._ClassPtr;
		}

		// Token: 0x0602BD03 RID: 179459 RVA: 0x00A0B4BC File Offset: 0x00A096BC
		public BP_NA059_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA059_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD04 RID: 179460 RVA: 0x00A0B4E4 File Offset: 0x00A096E4
		[NullableContext(1)]
		public BP_NA059_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA059_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CE2 RID: 27874
		// (get) Token: 0x0602BD05 RID: 179461 RVA: 0x00A0B517 File Offset: 0x00A09717
		// (set) Token: 0x0602BD06 RID: 179462 RVA: 0x00A0B52B File Offset: 0x00A0972B
		public unsafe UCapsuleComponent Capsule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CE3 RID: 27875
		// (get) Token: 0x0602BD07 RID: 179463 RVA: 0x00A0B540 File Offset: 0x00A09740
		// (set) Token: 0x0602BD08 RID: 179464 RVA: 0x00A0B554 File Offset: 0x00A09754
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA059_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602BD09 RID: 179465 RVA: 0x00A0B569 File Offset: 0x00A09769
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA059_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD0A RID: 179466 RVA: 0x00A0B57D File Offset: 0x00A0977D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA059_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BD0B RID: 179467 RVA: 0x00A0B592 File Offset: 0x00A09792
		protected BP_NA059_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D92 RID: 93586
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA059/BP_NA059.BP_NA059_C";

		// Token: 0x04016D93 RID: 93587
		private static IntPtr _ClassPtr;

		// Token: 0x04016D94 RID: 93588
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D95 RID: 93589
		internal static int __PropertyOffset_1;

		// Token: 0x04016D96 RID: 93590
		internal static int __PropertyOffset_2;

		// Token: 0x04016D97 RID: 93591
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
