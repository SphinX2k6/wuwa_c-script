using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA061
{
	// Token: 0x020041D3 RID: 16851
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA061/BP_NA061.BP_NA061_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_NA061_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCE4 RID: 179428 RVA: 0x00A0B11E File Offset: 0x00A0931E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA061_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA061/BP_NA061.BP_NA061_C");
			}
			return BP_NA061_C._ClassPtr;
		}

		// Token: 0x0602BCE5 RID: 179429 RVA: 0x00A0B144 File Offset: 0x00A09344
		public BP_NA061_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA061_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCE6 RID: 179430 RVA: 0x00A0B16C File Offset: 0x00A0936C
		[NullableContext(1)]
		public BP_NA061_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA061_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CDF RID: 27871
		// (get) Token: 0x0602BCE7 RID: 179431 RVA: 0x00A0B19F File Offset: 0x00A0939F
		// (set) Token: 0x0602BCE8 RID: 179432 RVA: 0x00A0B1B3 File Offset: 0x00A093B3
		[Nullable(2)]
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA061_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA061_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602BCE9 RID: 179433 RVA: 0x00A0B1C8 File Offset: 0x00A093C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA061_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BCEA RID: 179434 RVA: 0x00A0B1DC File Offset: 0x00A093DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA061_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BCEB RID: 179435 RVA: 0x00A0B1F1 File Offset: 0x00A093F1
		protected BP_NA061_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D7E RID: 93566
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA061/BP_NA061.BP_NA061_C";

		// Token: 0x04016D7F RID: 93567
		private static IntPtr _ClassPtr;

		// Token: 0x04016D80 RID: 93568
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D81 RID: 93569
		internal static int __PropertyOffset_1;

		// Token: 0x04016D82 RID: 93570
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
