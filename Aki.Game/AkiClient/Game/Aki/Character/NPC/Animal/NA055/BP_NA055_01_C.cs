using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA055
{
	// Token: 0x020041E3 RID: 16867
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA055/BP_NA055_01.BP_NA055_01_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_NA055_01_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD47 RID: 179527 RVA: 0x00A0BC74 File Offset: 0x00A09E74
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA055_01_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA055/BP_NA055_01.BP_NA055_01_C");
			}
			return BP_NA055_01_C._ClassPtr;
		}

		// Token: 0x0602BD48 RID: 179528 RVA: 0x00A0BC98 File Offset: 0x00A09E98
		public BP_NA055_01_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA055_01_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD49 RID: 179529 RVA: 0x00A0BCC0 File Offset: 0x00A09EC0
		[NullableContext(1)]
		public BP_NA055_01_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA055_01_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CE9 RID: 27881
		// (get) Token: 0x0602BD4A RID: 179530 RVA: 0x00A0BCF3 File Offset: 0x00A09EF3
		// (set) Token: 0x0602BD4B RID: 179531 RVA: 0x00A0BD07 File Offset: 0x00A09F07
		[Nullable(2)]
		public unsafe UKuroAdjustableCapsuleComponent ROOT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA055_01_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA055_01_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602BD4C RID: 179532 RVA: 0x00A0BD1C File Offset: 0x00A09F1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA055_01_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BD4D RID: 179533 RVA: 0x00A0BD30 File Offset: 0x00A09F30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA055_01_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BD4E RID: 179534 RVA: 0x00A0BD45 File Offset: 0x00A09F45
		protected BP_NA055_01_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DC2 RID: 93634
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA055/BP_NA055_01.BP_NA055_01_C";

		// Token: 0x04016DC3 RID: 93635
		private static IntPtr _ClassPtr;

		// Token: 0x04016DC4 RID: 93636
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016DC5 RID: 93637
		internal static int __PropertyOffset_1;

		// Token: 0x04016DC6 RID: 93638
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
