using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.InteractiveObject
{
	// Token: 0x02003E61 RID: 15969
	[UnrealObjectPath("/Game/Aki/GamePlay/InteractiveObject/BP_ManipulateConfig.BP_ManipulateConfig_C")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 348)]
	public class BP_ManipulateConfig_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028268 RID: 164456 RVA: 0x009A55AE File Offset: 0x009A37AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ManipulateConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/InteractiveObject/BP_ManipulateConfig.BP_ManipulateConfig_C");
			}
			return BP_ManipulateConfig_C._ClassPtr;
		}

		// Token: 0x06028269 RID: 164457 RVA: 0x009A55D4 File Offset: 0x009A37D4
		public BP_ManipulateConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_ManipulateConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602826A RID: 164458 RVA: 0x009A55FC File Offset: 0x009A37FC
		[NullableContext(1)]
		public BP_ManipulateConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ManipulateConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BF5 RID: 23541
		// (get) Token: 0x0602826B RID: 164459 RVA: 0x009A562F File Offset: 0x009A382F
		// (set) Token: 0x0602826C RID: 164460 RVA: 0x009A563F File Offset: 0x009A383F
		public unsafe float ChantTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005BF6 RID: 23542
		// (get) Token: 0x0602826D RID: 164461 RVA: 0x009A5650 File Offset: 0x009A3850
		// (set) Token: 0x0602826E RID: 164462 RVA: 0x009A5664 File Offset: 0x009A3864
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> ChantCameraShake
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_1);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005BF7 RID: 23543
		// (get) Token: 0x0602826F RID: 164463 RVA: 0x009A5679 File Offset: 0x009A3879
		// (set) Token: 0x06028270 RID: 164464 RVA: 0x009A568D File Offset: 0x009A388D
		public unsafe FGameplayTag ChantCameraStateTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005BF8 RID: 23544
		// (get) Token: 0x06028271 RID: 164465 RVA: 0x009A56A2 File Offset: 0x009A38A2
		// (set) Token: 0x06028272 RID: 164466 RVA: 0x009A56B2 File Offset: 0x009A38B2
		public unsafe float DrawDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005BF9 RID: 23545
		// (get) Token: 0x06028273 RID: 164467 RVA: 0x009A56C3 File Offset: 0x009A38C3
		// (set) Token: 0x06028274 RID: 164468 RVA: 0x009A56D3 File Offset: 0x009A38D3
		public unsafe float DrawTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005BFA RID: 23546
		// (get) Token: 0x06028275 RID: 164469 RVA: 0x009A56E4 File Offset: 0x009A38E4
		// (set) Token: 0x06028276 RID: 164470 RVA: 0x009A56F4 File Offset: 0x009A38F4
		public unsafe float DrawAlignTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005BFB RID: 23547
		// (get) Token: 0x06028277 RID: 164471 RVA: 0x009A5705 File Offset: 0x009A3905
		// (set) Token: 0x06028278 RID: 164472 RVA: 0x009A5715 File Offset: 0x009A3915
		public unsafe float DrawAlignHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005BFC RID: 23548
		// (get) Token: 0x06028279 RID: 164473 RVA: 0x009A5726 File Offset: 0x009A3926
		// (set) Token: 0x0602827A RID: 164474 RVA: 0x009A573A File Offset: 0x009A393A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> DrawCameraShake
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_7);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005BFD RID: 23549
		// (get) Token: 0x0602827B RID: 164475 RVA: 0x009A574F File Offset: 0x009A394F
		// (set) Token: 0x0602827C RID: 164476 RVA: 0x009A575F File Offset: 0x009A395F
		public unsafe float HoldSwingFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005BFE RID: 23550
		// (get) Token: 0x0602827D RID: 164477 RVA: 0x009A5770 File Offset: 0x009A3970
		// (set) Token: 0x0602827E RID: 164478 RVA: 0x009A5780 File Offset: 0x009A3980
		public unsafe float HoldAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005BFF RID: 23551
		// (get) Token: 0x0602827F RID: 164479 RVA: 0x009A5791 File Offset: 0x009A3991
		// (set) Token: 0x06028280 RID: 164480 RVA: 0x009A57A5 File Offset: 0x009A39A5
		public unsafe FRotator HoldRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005C00 RID: 23552
		// (get) Token: 0x06028281 RID: 164481 RVA: 0x009A57BA File Offset: 0x009A39BA
		// (set) Token: 0x06028282 RID: 164482 RVA: 0x009A57CE File Offset: 0x009A39CE
		public unsafe FVector HoldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005C01 RID: 23553
		// (get) Token: 0x06028283 RID: 164483 RVA: 0x009A57E3 File Offset: 0x009A39E3
		// (set) Token: 0x06028284 RID: 164484 RVA: 0x009A57F3 File Offset: 0x009A39F3
		public unsafe float HoldSwingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005C02 RID: 23554
		// (get) Token: 0x06028285 RID: 164485 RVA: 0x009A5804 File Offset: 0x009A3A04
		// (set) Token: 0x06028286 RID: 164486 RVA: 0x009A5814 File Offset: 0x009A3A14
		public unsafe float CastAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005C03 RID: 23555
		// (get) Token: 0x06028287 RID: 164487 RVA: 0x009A5825 File Offset: 0x009A3A25
		// (set) Token: 0x06028288 RID: 164488 RVA: 0x009A5839 File Offset: 0x009A3A39
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> CastCameraShake
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_14);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005C04 RID: 23556
		// (get) Token: 0x06028289 RID: 164489 RVA: 0x009A584E File Offset: 0x009A3A4E
		// (set) Token: 0x0602828A RID: 164490 RVA: 0x009A585E File Offset: 0x009A3A5E
		public unsafe float CastVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005C05 RID: 23557
		// (get) Token: 0x0602828B RID: 164491 RVA: 0x009A586F File Offset: 0x009A3A6F
		// (set) Token: 0x0602828C RID: 164492 RVA: 0x009A587F File Offset: 0x009A3A7F
		public unsafe float PhysHandleLinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005C06 RID: 23558
		// (get) Token: 0x0602828D RID: 164493 RVA: 0x009A5890 File Offset: 0x009A3A90
		// (set) Token: 0x0602828E RID: 164494 RVA: 0x009A58A0 File Offset: 0x009A3AA0
		public unsafe float PhysHandleAngularStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005C07 RID: 23559
		// (get) Token: 0x0602828F RID: 164495 RVA: 0x009A58B1 File Offset: 0x009A3AB1
		// (set) Token: 0x06028290 RID: 164496 RVA: 0x009A58C1 File Offset: 0x009A3AC1
		public unsafe float PhysHandleLinearStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005C08 RID: 23560
		// (get) Token: 0x06028291 RID: 164497 RVA: 0x009A58D2 File Offset: 0x009A3AD2
		// (set) Token: 0x06028292 RID: 164498 RVA: 0x009A58E2 File Offset: 0x009A3AE2
		public unsafe float PhysHandleAngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005C09 RID: 23561
		// (get) Token: 0x06028293 RID: 164499 RVA: 0x009A58F3 File Offset: 0x009A3AF3
		// (set) Token: 0x06028294 RID: 164500 RVA: 0x009A5907 File Offset: 0x009A3B07
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> HoldCameraShake
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_20);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005C0A RID: 23562
		// (get) Token: 0x06028295 RID: 164501 RVA: 0x009A591C File Offset: 0x009A3B1C
		// (set) Token: 0x06028296 RID: 164502 RVA: 0x009A5930 File Offset: 0x009A3B30
		public unsafe FGameplayTag HoldCameraStateTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ManipulateConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x06028297 RID: 164503 RVA: 0x009A5945 File Offset: 0x009A3B45
		protected BP_ManipulateConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040146F7 RID: 83703
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/InteractiveObject/BP_ManipulateConfig.BP_ManipulateConfig_C";

		// Token: 0x040146F8 RID: 83704
		private static IntPtr _ClassPtr;

		// Token: 0x040146F9 RID: 83705
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040146FA RID: 83706
		internal static int __PropertyOffset_0;

		// Token: 0x040146FB RID: 83707
		internal static int __PropertyOffset_1;

		// Token: 0x040146FC RID: 83708
		internal static int __PropertyOffset_2;

		// Token: 0x040146FD RID: 83709
		internal static int __PropertyOffset_3;

		// Token: 0x040146FE RID: 83710
		internal static int __PropertyOffset_4;

		// Token: 0x040146FF RID: 83711
		internal static int __PropertyOffset_5;

		// Token: 0x04014700 RID: 83712
		internal static int __PropertyOffset_6;

		// Token: 0x04014701 RID: 83713
		internal static int __PropertyOffset_7;

		// Token: 0x04014702 RID: 83714
		internal static int __PropertyOffset_8;

		// Token: 0x04014703 RID: 83715
		internal static int __PropertyOffset_9;

		// Token: 0x04014704 RID: 83716
		internal static int __PropertyOffset_10;

		// Token: 0x04014705 RID: 83717
		internal static int __PropertyOffset_11;

		// Token: 0x04014706 RID: 83718
		internal static int __PropertyOffset_12;

		// Token: 0x04014707 RID: 83719
		internal static int __PropertyOffset_13;

		// Token: 0x04014708 RID: 83720
		internal static int __PropertyOffset_14;

		// Token: 0x04014709 RID: 83721
		internal static int __PropertyOffset_15;

		// Token: 0x0401470A RID: 83722
		internal static int __PropertyOffset_16;

		// Token: 0x0401470B RID: 83723
		internal static int __PropertyOffset_17;

		// Token: 0x0401470C RID: 83724
		internal static int __PropertyOffset_18;

		// Token: 0x0401470D RID: 83725
		internal static int __PropertyOffset_19;

		// Token: 0x0401470E RID: 83726
		internal static int __PropertyOffset_20;

		// Token: 0x0401470F RID: 83727
		internal static int __PropertyOffset_21;
	}
}
