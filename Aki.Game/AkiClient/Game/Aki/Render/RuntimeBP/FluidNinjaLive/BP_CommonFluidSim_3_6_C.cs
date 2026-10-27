using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D85 RID: 15749
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/BP_CommonFluidSim_3_6.BP_CommonFluidSim_3_6_C")]
	[UnrealStructLayout(1712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1712)]
	public class BP_CommonFluidSim_3_6_C : BP_CommonFluidSim_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026B42 RID: 158530 RVA: 0x0097C7A2 File Offset: 0x0097A9A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CommonFluidSim_3_6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/BP_CommonFluidSim_3_6.BP_CommonFluidSim_3_6_C");
			}
			return BP_CommonFluidSim_3_6_C._ClassPtr;
		}

		// Token: 0x06026B43 RID: 158531 RVA: 0x0097C7C8 File Offset: 0x0097A9C8
		public BP_CommonFluidSim_3_6_C() : this(BuiltinUtils.AllocNativeUObject(BP_CommonFluidSim_3_6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026B44 RID: 158532 RVA: 0x0097C7F0 File Offset: 0x0097A9F0
		[NullableContext(1)]
		public BP_CommonFluidSim_3_6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CommonFluidSim_3_6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170053B1 RID: 21425
		// (get) Token: 0x06026B45 RID: 158533 RVA: 0x0097C823 File Offset: 0x0097AA23
		// (set) Token: 0x06026B46 RID: 158534 RVA: 0x0097C837 File Offset: 0x0097AA37
		public unsafe FVector PlayerPrevUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170053B2 RID: 21426
		// (get) Token: 0x06026B47 RID: 158535 RVA: 0x0097C84C File Offset: 0x0097AA4C
		// (set) Token: 0x06026B48 RID: 158536 RVA: 0x0097C860 File Offset: 0x0097AA60
		public unsafe UMaterialInstanceDynamic AddPointsMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_3_6_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_3_6_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170053B3 RID: 21427
		// (get) Token: 0x06026B49 RID: 158537 RVA: 0x0097C875 File Offset: 0x0097AA75
		// (set) Token: 0x06026B4A RID: 158538 RVA: 0x0097C889 File Offset: 0x0097AA89
		public unsafe FVectorDouble CurrPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170053B4 RID: 21428
		// (get) Token: 0x06026B4B RID: 158539 RVA: 0x0097C89E File Offset: 0x0097AA9E
		// (set) Token: 0x06026B4C RID: 158540 RVA: 0x0097C8B2 File Offset: 0x0097AAB2
		public unsafe BP_SceneBattleInteract_C Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_3_6_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_3_6_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170053B5 RID: 21429
		// (get) Token: 0x06026B4D RID: 158541 RVA: 0x0097C8C7 File Offset: 0x0097AAC7
		// (set) Token: 0x06026B4E RID: 158542 RVA: 0x0097C8D7 File Offset: 0x0097AAD7
		public unsafe float WeaponInteractRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170053B6 RID: 21430
		// (get) Token: 0x06026B4F RID: 158543 RVA: 0x0097C8E8 File Offset: 0x0097AAE8
		// (set) Token: 0x06026B50 RID: 158544 RVA: 0x0097C8F8 File Offset: 0x0097AAF8
		public unsafe float captureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170053B7 RID: 21431
		// (get) Token: 0x06026B51 RID: 158545 RVA: 0x0097C909 File Offset: 0x0097AB09
		// (set) Token: 0x06026B52 RID: 158546 RVA: 0x0097C91D File Offset: 0x0097AB1D
		public unsafe FVectorDouble PrevPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170053B8 RID: 21432
		// (get) Token: 0x06026B53 RID: 158547 RVA: 0x0097C932 File Offset: 0x0097AB32
		// (set) Token: 0x06026B54 RID: 158548 RVA: 0x0097C946 File Offset: 0x0097AB46
		public unsafe UTextureRenderTarget2D PointRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_3_6_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_3_6_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170053B9 RID: 21433
		// (get) Token: 0x06026B55 RID: 158549 RVA: 0x0097C95B File Offset: 0x0097AB5B
		// (set) Token: 0x06026B56 RID: 158550 RVA: 0x0097C96B File Offset: 0x0097AB6B
		public unsafe bool bUsingWeapon
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053BA RID: 21434
		// (get) Token: 0x06026B57 RID: 158551 RVA: 0x0097C97C File Offset: 0x0097AB7C
		// (set) Token: 0x06026B58 RID: 158552 RVA: 0x0097C98C File Offset: 0x0097AB8C
		public unsafe bool bCleared
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053BB RID: 21435
		// (get) Token: 0x06026B59 RID: 158553 RVA: 0x0097C99D File Offset: 0x0097AB9D
		// (set) Token: 0x06026B5A RID: 158554 RVA: 0x0097C9AD File Offset: 0x0097ABAD
		public unsafe double WeaponMaxHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170053BC RID: 21436
		// (get) Token: 0x06026B5B RID: 158555 RVA: 0x0097C9BE File Offset: 0x0097ABBE
		// (set) Token: 0x06026B5C RID: 158556 RVA: 0x0097C9CE File Offset: 0x0097ABCE
		public unsafe bool bPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053BD RID: 21437
		// (get) Token: 0x06026B5D RID: 158557 RVA: 0x0097C9DF File Offset: 0x0097ABDF
		// (set) Token: 0x06026B5E RID: 158558 RVA: 0x0097C9EF File Offset: 0x0097ABEF
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170053BE RID: 21438
		// (get) Token: 0x06026B5F RID: 158559 RVA: 0x0097CA00 File Offset: 0x0097AC00
		// (set) Token: 0x06026B60 RID: 158560 RVA: 0x0097CA14 File Offset: 0x0097AC14
		public unsafe FVectorDouble LastPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170053BF RID: 21439
		// (get) Token: 0x06026B61 RID: 158561 RVA: 0x0097CA29 File Offset: 0x0097AC29
		// (set) Token: 0x06026B62 RID: 158562 RVA: 0x0097CA3D File Offset: 0x0097AC3D
		public unsafe FVectorDouble tempPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_3_6_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x06026B63 RID: 158563 RVA: 0x0097CA54 File Offset: 0x0097AC54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcTexCoord(FVectorDouble RTCenter, FVectorDouble WeaponPointLocation, float CaptureSize, ref FVector TexCoord)
		{
			BP_CommonFluidSim_3_6_C.__CalcTexCoord_FunctionParams* ptr = stackalloc BP_CommonFluidSim_3_6_C.__CalcTexCoord_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_CommonFluidSim_3_6_C.__CalcTexCoord_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CommonFluidSim_3_6_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RTCenter = RTCenter;
			ptr->WeaponPointLocation = WeaponPointLocation;
			ptr->CaptureSize = CaptureSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CommonFluidSim_3_6_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x06026B64 RID: 158564 RVA: 0x0097CAC5 File Offset: 0x0097ACC5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void CheckSimEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CommonFluidSim_3_6_C.__CheckSimEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06026B65 RID: 158565 RVA: 0x0097CAD9 File Offset: 0x0097ACD9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CommonFluidSim_3_6_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026B66 RID: 158566 RVA: 0x0097CAED File Offset: 0x0097ACED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CommonFluidSim_3_6_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026B67 RID: 158567 RVA: 0x0097CB04 File Offset: 0x0097AD04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CommonFluidSim_3_6_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CommonFluidSim_3_6_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CommonFluidSim_3_6_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CommonFluidSim_3_6_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CommonFluidSim_3_6_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026B68 RID: 158568 RVA: 0x0097CB4C File Offset: 0x0097AD4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CommonFluidSim_3_6_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CommonFluidSim_3_6_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CommonFluidSim_3_6_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CommonFluidSim_3_6_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CommonFluidSim_3_6_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026B69 RID: 158569 RVA: 0x0097CB94 File Offset: 0x0097AD94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteract(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_CommonFluidSim_3_6_C.__OnWeaponInteract_FunctionParams* ptr = stackalloc BP_CommonFluidSim_3_6_C.__OnWeaponInteract_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CommonFluidSim_3_6_C.__OnWeaponInteract_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CommonFluidSim_3_6_C.__OnWeaponInteract_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CommonFluidSim_3_6_C.__OnWeaponInteract_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026B6A RID: 158570 RVA: 0x0097CBF7 File Offset: 0x0097ADF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Clear_RT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CommonFluidSim_3_6_C.__Clear_RT_NativeFunctionPtr, null);
		}

		// Token: 0x06026B6B RID: 158571 RVA: 0x0097CC0B File Offset: 0x0097AE0B
		protected BP_CommonFluidSim_3_6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401376C RID: 79724
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/BP_CommonFluidSim_3_6.BP_CommonFluidSim_3_6_C";

		// Token: 0x0401376D RID: 79725
		private static IntPtr _ClassPtr;

		// Token: 0x0401376E RID: 79726
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401376F RID: 79727
		internal new static int __PropertyOffset_1;

		// Token: 0x04013770 RID: 79728
		internal new static int __PropertyOffset_2;

		// Token: 0x04013771 RID: 79729
		internal new static int __PropertyOffset_3;

		// Token: 0x04013772 RID: 79730
		internal new static int __PropertyOffset_4;

		// Token: 0x04013773 RID: 79731
		internal new static int __PropertyOffset_5;

		// Token: 0x04013774 RID: 79732
		internal new static int __PropertyOffset_6;

		// Token: 0x04013775 RID: 79733
		internal new static int __PropertyOffset_7;

		// Token: 0x04013776 RID: 79734
		internal new static int __PropertyOffset_8;

		// Token: 0x04013777 RID: 79735
		internal new static int __PropertyOffset_9;

		// Token: 0x04013778 RID: 79736
		internal new static int __PropertyOffset_10;

		// Token: 0x04013779 RID: 79737
		internal new static int __PropertyOffset_11;

		// Token: 0x0401377A RID: 79738
		internal static int __PropertyOffset_12;

		// Token: 0x0401377B RID: 79739
		internal static int __PropertyOffset_13;

		// Token: 0x0401377C RID: 79740
		internal static int __PropertyOffset_14;

		// Token: 0x0401377D RID: 79741
		internal static int __PropertyOffset_15;

		// Token: 0x0401377E RID: 79742
		private static IntPtr __CalcTexCoord_NativeFunctionPtr;

		// Token: 0x0401377F RID: 79743
		private static IntPtr __CheckSimEnable_NativeFunctionPtr;

		// Token: 0x04013780 RID: 79744
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013781 RID: 79745
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013782 RID: 79746
		private static IntPtr __OnWeaponInteract_NativeFunctionPtr;

		// Token: 0x04013783 RID: 79747
		private static IntPtr __Clear_RT_NativeFunctionPtr;

		// Token: 0x0200A149 RID: 41289
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __CalcTexCoord_FunctionParams
		{
			// Token: 0x04031CEB RID: 204011
			[FieldOffset(0)]
			public FVectorDouble RTCenter;

			// Token: 0x04031CEC RID: 204012
			[FieldOffset(24)]
			public FVectorDouble WeaponPointLocation;

			// Token: 0x04031CED RID: 204013
			[FieldOffset(48)]
			public float CaptureSize;

			// Token: 0x04031CEE RID: 204014
			[FieldOffset(52)]
			public FVector TexCoord;
		}

		// Token: 0x0200A14A RID: 41290
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031CEF RID: 204015
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A14B RID: 41291
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteract_FunctionParams
		{
			// Token: 0x04031CF0 RID: 204016
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031CF1 RID: 204017
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031CF2 RID: 204018
			[FieldOffset(32)]
			public int Id;
		}
	}
}
