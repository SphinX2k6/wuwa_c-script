using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA062
{
	// Token: 0x020041CE RID: 16846
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA062/BP_NA062.BP_NA062_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_NA062_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCC6 RID: 179398 RVA: 0x00A0ADA4 File Offset: 0x00A08FA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA062_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA062/BP_NA062.BP_NA062_C");
			}
			return BP_NA062_C._ClassPtr;
		}

		// Token: 0x0602BCC7 RID: 179399 RVA: 0x00A0ADC8 File Offset: 0x00A08FC8
		public BP_NA062_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA062_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCC8 RID: 179400 RVA: 0x00A0ADF0 File Offset: 0x00A08FF0
		[NullableContext(1)]
		public BP_NA062_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA062_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CDC RID: 27868
		// (get) Token: 0x0602BCC9 RID: 179401 RVA: 0x00A0AE23 File Offset: 0x00A09023
		// (set) Token: 0x0602BCCA RID: 179402 RVA: 0x00A0AE37 File Offset: 0x00A09037
		[Nullable(2)]
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA062_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA062_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602BCCB RID: 179403 RVA: 0x00A0AE4C File Offset: 0x00A0904C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA062_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BCCC RID: 179404 RVA: 0x00A0AE60 File Offset: 0x00A09060
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA062_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BCCD RID: 179405 RVA: 0x00A0AE75 File Offset: 0x00A09075
		protected BP_NA062_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D6A RID: 93546
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA062/BP_NA062.BP_NA062_C";

		// Token: 0x04016D6B RID: 93547
		private static IntPtr _ClassPtr;

		// Token: 0x04016D6C RID: 93548
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D6D RID: 93549
		internal static int __PropertyOffset_1;

		// Token: 0x04016D6E RID: 93550
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
