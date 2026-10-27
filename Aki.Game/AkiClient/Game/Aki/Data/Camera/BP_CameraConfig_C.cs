using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera
{
	// Token: 0x02003FAB RID: 16299
	[UnrealObjectPath("/Game/Aki/Data/Camera/BP_CameraConfig.BP_CameraConfig_C")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class BP_CameraConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029A22 RID: 170530 RVA: 0x009C9238 File Offset: 0x009C7438
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/BP_CameraConfig.BP_CameraConfig_C");
			}
			return BP_CameraConfig_C._ClassPtr;
		}

		// Token: 0x06029A23 RID: 170531 RVA: 0x009C925C File Offset: 0x009C745C
		public BP_CameraConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029A24 RID: 170532 RVA: 0x009C9284 File Offset: 0x009C7484
		[NullableContext(1)]
		public BP_CameraConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700644B RID: 25675
		// (get) Token: 0x06029A25 RID: 170533 RVA: 0x009C92B7 File Offset: 0x009C74B7
		// (set) Token: 0x06029A26 RID: 170534 RVA: 0x009C92C7 File Offset: 0x009C74C7
		public unsafe float 切换角色相机臂中心点过渡时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700644C RID: 25676
		// (get) Token: 0x06029A27 RID: 170535 RVA: 0x009C92D8 File Offset: 0x009C74D8
		// (set) Token: 0x06029A28 RID: 170536 RVA: 0x009C92E8 File Offset: 0x009C74E8
		public unsafe float 在水中摄像机碰撞检测起点额外高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700644D RID: 25677
		// (get) Token: 0x06029A29 RID: 170537 RVA: 0x009C92F9 File Offset: 0x009C74F9
		// (set) Token: 0x06029A2A RID: 170538 RVA: 0x009C9309 File Offset: 0x009C7509
		public unsafe float 障碍碰撞检测胶囊体半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700644E RID: 25678
		// (get) Token: 0x06029A2B RID: 170539 RVA: 0x009C931A File Offset: 0x009C751A
		// (set) Token: 0x06029A2C RID: 170540 RVA: 0x009C932A File Offset: 0x009C752A
		public unsafe float 自动俯仰角输入下界_目标高_高度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700644F RID: 25679
		// (get) Token: 0x06029A2D RID: 170541 RVA: 0x009C933B File Offset: 0x009C753B
		// (set) Token: 0x06029A2E RID: 170542 RVA: 0x009C934B File Offset: 0x009C754B
		public unsafe float 自动俯仰角输入上界_目标高_高度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006450 RID: 25680
		// (get) Token: 0x06029A2F RID: 170543 RVA: 0x009C935C File Offset: 0x009C755C
		// (set) Token: 0x06029A30 RID: 170544 RVA: 0x009C936C File Offset: 0x009C756C
		public unsafe float 自动俯仰角输入下界_目标高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006451 RID: 25681
		// (get) Token: 0x06029A31 RID: 170545 RVA: 0x009C937D File Offset: 0x009C757D
		// (set) Token: 0x06029A32 RID: 170546 RVA: 0x009C938D File Offset: 0x009C758D
		public unsafe float 自动俯仰角输入上界_目标高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006452 RID: 25682
		// (get) Token: 0x06029A33 RID: 170547 RVA: 0x009C939E File Offset: 0x009C759E
		// (set) Token: 0x06029A34 RID: 170548 RVA: 0x009C93AE File Offset: 0x009C75AE
		public unsafe float 自动俯仰角输出下界_目标高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006453 RID: 25683
		// (get) Token: 0x06029A35 RID: 170549 RVA: 0x009C93BF File Offset: 0x009C75BF
		// (set) Token: 0x06029A36 RID: 170550 RVA: 0x009C93CF File Offset: 0x009C75CF
		public unsafe float 自动俯仰角输出上界_目标高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006454 RID: 25684
		// (get) Token: 0x06029A37 RID: 170551 RVA: 0x009C93E0 File Offset: 0x009C75E0
		// (set) Token: 0x06029A38 RID: 170552 RVA: 0x009C93F0 File Offset: 0x009C75F0
		public unsafe float 自动俯仰角输入下界_目标矮_高度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006455 RID: 25685
		// (get) Token: 0x06029A39 RID: 170553 RVA: 0x009C9401 File Offset: 0x009C7601
		// (set) Token: 0x06029A3A RID: 170554 RVA: 0x009C9411 File Offset: 0x009C7611
		public unsafe float 自动俯仰角输入上界_目标矮_高度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006456 RID: 25686
		// (get) Token: 0x06029A3B RID: 170555 RVA: 0x009C9422 File Offset: 0x009C7622
		// (set) Token: 0x06029A3C RID: 170556 RVA: 0x009C9432 File Offset: 0x009C7632
		public unsafe float 自动俯仰角输入下界_目标矮
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006457 RID: 25687
		// (get) Token: 0x06029A3D RID: 170557 RVA: 0x009C9443 File Offset: 0x009C7643
		// (set) Token: 0x06029A3E RID: 170558 RVA: 0x009C9453 File Offset: 0x009C7653
		public unsafe float 自动俯仰角输入上界_目标矮
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006458 RID: 25688
		// (get) Token: 0x06029A3F RID: 170559 RVA: 0x009C9464 File Offset: 0x009C7664
		// (set) Token: 0x06029A40 RID: 170560 RVA: 0x009C9474 File Offset: 0x009C7674
		public unsafe float 自动俯仰角输出下界_目标矮
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006459 RID: 25689
		// (get) Token: 0x06029A41 RID: 170561 RVA: 0x009C9485 File Offset: 0x009C7685
		// (set) Token: 0x06029A42 RID: 170562 RVA: 0x009C9495 File Offset: 0x009C7695
		public unsafe float 自动俯仰角输出上界_目标矮
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700645A RID: 25690
		// (get) Token: 0x06029A43 RID: 170563 RVA: 0x009C94A6 File Offset: 0x009C76A6
		// (set) Token: 0x06029A44 RID: 170564 RVA: 0x009C94B6 File Offset: 0x009C76B6
		public unsafe float 摄像机最小Pitch_目标比角色矮_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700645B RID: 25691
		// (get) Token: 0x06029A45 RID: 170565 RVA: 0x009C94C7 File Offset: 0x009C76C7
		// (set) Token: 0x06029A46 RID: 170566 RVA: 0x009C94D7 File Offset: 0x009C76D7
		public unsafe float 摄像机最大Pitch_目标比角色矮_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700645C RID: 25692
		// (get) Token: 0x06029A47 RID: 170567 RVA: 0x009C94E8 File Offset: 0x009C76E8
		// (set) Token: 0x06029A48 RID: 170568 RVA: 0x009C94F8 File Offset: 0x009C76F8
		public unsafe float 摄像机最小Pitch_目标比角色高_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700645D RID: 25693
		// (get) Token: 0x06029A49 RID: 170569 RVA: 0x009C9509 File Offset: 0x009C7709
		// (set) Token: 0x06029A4A RID: 170570 RVA: 0x009C9519 File Offset: 0x009C7719
		public unsafe float 摄像机最大Pitch_目标比角色高_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700645E RID: 25694
		// (get) Token: 0x06029A4B RID: 170571 RVA: 0x009C952A File Offset: 0x009C772A
		// (set) Token: 0x06029A4C RID: 170572 RVA: 0x009C953A File Offset: 0x009C773A
		public unsafe float 近距离范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700645F RID: 25695
		// (get) Token: 0x06029A4D RID: 170573 RVA: 0x009C954B File Offset: 0x009C774B
		// (set) Token: 0x06029A4E RID: 170574 RVA: 0x009C955B File Offset: 0x009C775B
		public unsafe float 近距离修正最小角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006460 RID: 25696
		// (get) Token: 0x06029A4F RID: 170575 RVA: 0x009C956C File Offset: 0x009C776C
		// (set) Token: 0x06029A50 RID: 170576 RVA: 0x009C957C File Offset: 0x009C777C
		public unsafe float 近距离修正最大角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006461 RID: 25697
		// (get) Token: 0x06029A51 RID: 170577 RVA: 0x009C958D File Offset: 0x009C778D
		// (set) Token: 0x06029A52 RID: 170578 RVA: 0x009C959D File Offset: 0x009C779D
		public unsafe float 远距离修正最小角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006462 RID: 25698
		// (get) Token: 0x06029A53 RID: 170579 RVA: 0x009C95AE File Offset: 0x009C77AE
		// (set) Token: 0x06029A54 RID: 170580 RVA: 0x009C95BE File Offset: 0x009C77BE
		public unsafe float 远距离修正最大角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17006463 RID: 25699
		// (get) Token: 0x06029A55 RID: 170581 RVA: 0x009C95CF File Offset: 0x009C77CF
		// (set) Token: 0x06029A56 RID: 170582 RVA: 0x009C95DF File Offset: 0x009C77DF
		public unsafe float 检测屏幕内MinX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17006464 RID: 25700
		// (get) Token: 0x06029A57 RID: 170583 RVA: 0x009C95F0 File Offset: 0x009C77F0
		// (set) Token: 0x06029A58 RID: 170584 RVA: 0x009C9600 File Offset: 0x009C7800
		public unsafe float 检测屏幕内MaxX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17006465 RID: 25701
		// (get) Token: 0x06029A59 RID: 170585 RVA: 0x009C9611 File Offset: 0x009C7811
		// (set) Token: 0x06029A5A RID: 170586 RVA: 0x009C9621 File Offset: 0x009C7821
		public unsafe float 检测屏幕内MinY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17006466 RID: 25702
		// (get) Token: 0x06029A5B RID: 170587 RVA: 0x009C9632 File Offset: 0x009C7832
		// (set) Token: 0x06029A5C RID: 170588 RVA: 0x009C9642 File Offset: 0x009C7842
		public unsafe float 检测屏幕内MaxY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17006467 RID: 25703
		// (get) Token: 0x06029A5D RID: 170589 RVA: 0x009C9653 File Offset: 0x009C7853
		// (set) Token: 0x06029A5E RID: 170590 RVA: 0x009C9663 File Offset: 0x009C7863
		public unsafe float 目标比角色更靠近镜头时额外臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17006468 RID: 25704
		// (get) Token: 0x06029A5F RID: 170591 RVA: 0x009C9674 File Offset: 0x009C7874
		// (set) Token: 0x06029A60 RID: 170592 RVA: 0x009C9684 File Offset: 0x009C7884
		public unsafe float 额外臂长系数_目标距离_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17006469 RID: 25705
		// (get) Token: 0x06029A61 RID: 170593 RVA: 0x009C9695 File Offset: 0x009C7895
		// (set) Token: 0x06029A62 RID: 170594 RVA: 0x009C96A5 File Offset: 0x009C78A5
		public unsafe float 额外臂长系数_目标高度差_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700646A RID: 25706
		// (get) Token: 0x06029A63 RID: 170595 RVA: 0x009C96B6 File Offset: 0x009C78B6
		// (set) Token: 0x06029A64 RID: 170596 RVA: 0x009C96C6 File Offset: 0x009C78C6
		public unsafe float 额外臂水平偏移_目标距离_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700646B RID: 25707
		// (get) Token: 0x06029A65 RID: 170597 RVA: 0x009C96D7 File Offset: 0x009C78D7
		// (set) Token: 0x06029A66 RID: 170598 RVA: 0x009C96E7 File Offset: 0x009C78E7
		public unsafe float 额外最大水平臂偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x1700646C RID: 25708
		// (get) Token: 0x06029A67 RID: 170599 RVA: 0x009C96F8 File Offset: 0x009C78F8
		// (set) Token: 0x06029A68 RID: 170600 RVA: 0x009C9708 File Offset: 0x009C7908
		public unsafe float 角色屏幕高度参考
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x1700646D RID: 25709
		// (get) Token: 0x06029A69 RID: 170601 RVA: 0x009C9719 File Offset: 0x009C7919
		// (set) Token: 0x06029A6A RID: 170602 RVA: 0x009C9729 File Offset: 0x009C7929
		public unsafe float 额外臂垂直偏移系数_角色屏幕高度与参考值差_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700646E RID: 25710
		// (get) Token: 0x06029A6B RID: 170603 RVA: 0x009C973A File Offset: 0x009C793A
		// (set) Token: 0x06029A6C RID: 170604 RVA: 0x009C974A File Offset: 0x009C794A
		public unsafe float 额外臂垂直偏移速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x1700646F RID: 25711
		// (get) Token: 0x06029A6D RID: 170605 RVA: 0x009C975B File Offset: 0x009C795B
		// (set) Token: 0x06029A6E RID: 170606 RVA: 0x009C976B File Offset: 0x009C796B
		public unsafe float 额外臂垂直偏移系数_目标高度差_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17006470 RID: 25712
		// (get) Token: 0x06029A6F RID: 170607 RVA: 0x009C977C File Offset: 0x009C797C
		// (set) Token: 0x06029A70 RID: 170608 RVA: 0x009C978C File Offset: 0x009C798C
		public unsafe float 额外最大垂直臂偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17006471 RID: 25713
		// (get) Token: 0x06029A71 RID: 170609 RVA: 0x009C979D File Offset: 0x009C799D
		// (set) Token: 0x06029A72 RID: 170610 RVA: 0x009C97AD File Offset: 0x009C79AD
		public unsafe float 臂长过渡速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17006472 RID: 25714
		// (get) Token: 0x06029A73 RID: 170611 RVA: 0x009C97BE File Offset: 0x009C79BE
		// (set) Token: 0x06029A74 RID: 170612 RVA: 0x009C97CE File Offset: 0x009C79CE
		public unsafe float 臂偏移过渡速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17006473 RID: 25715
		// (get) Token: 0x06029A75 RID: 170613 RVA: 0x009C97DF File Offset: 0x009C79DF
		// (set) Token: 0x06029A76 RID: 170614 RVA: 0x009C97EF File Offset: 0x009C79EF
		public unsafe float 检测屏幕内MinX_外_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17006474 RID: 25716
		// (get) Token: 0x06029A77 RID: 170615 RVA: 0x009C9800 File Offset: 0x009C7A00
		// (set) Token: 0x06029A78 RID: 170616 RVA: 0x009C9810 File Offset: 0x009C7A10
		public unsafe float 检测屏幕内MaxX_外_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17006475 RID: 25717
		// (get) Token: 0x06029A79 RID: 170617 RVA: 0x009C9821 File Offset: 0x009C7A21
		// (set) Token: 0x06029A7A RID: 170618 RVA: 0x009C9831 File Offset: 0x009C7A31
		public unsafe float 检测屏幕内MinY_外_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17006476 RID: 25718
		// (get) Token: 0x06029A7B RID: 170619 RVA: 0x009C9842 File Offset: 0x009C7A42
		// (set) Token: 0x06029A7C RID: 170620 RVA: 0x009C9852 File Offset: 0x009C7A52
		public unsafe float 检测屏幕内MaxY_外_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17006477 RID: 25719
		// (get) Token: 0x06029A7D RID: 170621 RVA: 0x009C9863 File Offset: 0x009C7A63
		// (set) Token: 0x06029A7E RID: 170622 RVA: 0x009C9873 File Offset: 0x009C7A73
		public unsafe float 臂旋转过渡速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17006478 RID: 25720
		// (get) Token: 0x06029A7F RID: 170623 RVA: 0x009C9884 File Offset: 0x009C7A84
		// (set) Token: 0x06029A80 RID: 170624 RVA: 0x009C9894 File Offset: 0x009C7A94
		public unsafe float 滚轮轴影响臂长系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17006479 RID: 25721
		// (get) Token: 0x06029A81 RID: 170625 RVA: 0x009C98A5 File Offset: 0x009C7AA5
		// (set) Token: 0x06029A82 RID: 170626 RVA: 0x009C98B5 File Offset: 0x009C7AB5
		public unsafe float 臂长还原过渡速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x1700647A RID: 25722
		// (get) Token: 0x06029A83 RID: 170627 RVA: 0x009C98C6 File Offset: 0x009C7AC6
		// (set) Token: 0x06029A84 RID: 170628 RVA: 0x009C98D6 File Offset: 0x009C7AD6
		public unsafe float 臂偏移还原过渡速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x1700647B RID: 25723
		// (get) Token: 0x06029A85 RID: 170629 RVA: 0x009C98E7 File Offset: 0x009C7AE7
		// (set) Token: 0x06029A86 RID: 170630 RVA: 0x009C98F7 File Offset: 0x009C7AF7
		public unsafe float 旋转还原过渡速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x1700647C RID: 25724
		// (get) Token: 0x06029A87 RID: 170631 RVA: 0x009C9908 File Offset: 0x009C7B08
		// (set) Token: 0x06029A88 RID: 170632 RVA: 0x009C9918 File Offset: 0x009C7B18
		public unsafe float Fov还原过渡速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x1700647D RID: 25725
		// (get) Token: 0x06029A89 RID: 170633 RVA: 0x009C9929 File Offset: 0x009C7B29
		// (set) Token: 0x06029A8A RID: 170634 RVA: 0x009C9939 File Offset: 0x009C7B39
		public unsafe float 技能修正过渡时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x1700647E RID: 25726
		// (get) Token: 0x06029A8B RID: 170635 RVA: 0x009C994A File Offset: 0x009C7B4A
		// (set) Token: 0x06029A8C RID: 170636 RVA: 0x009C995A File Offset: 0x009C7B5A
		public unsafe float G修正角度Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x1700647F RID: 25727
		// (get) Token: 0x06029A8D RID: 170637 RVA: 0x009C996B File Offset: 0x009C7B6B
		// (set) Token: 0x06029A8E RID: 170638 RVA: 0x009C997B File Offset: 0x009C7B7B
		public unsafe float G修正角度Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17006480 RID: 25728
		// (get) Token: 0x06029A8F RID: 170639 RVA: 0x009C998C File Offset: 0x009C7B8C
		// (set) Token: 0x06029A90 RID: 170640 RVA: 0x009C999C File Offset: 0x009C7B9C
		public unsafe float G额外臂长系数_目标水平距离_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17006481 RID: 25729
		// (get) Token: 0x06029A91 RID: 170641 RVA: 0x009C99AD File Offset: 0x009C7BAD
		// (set) Token: 0x06029A92 RID: 170642 RVA: 0x009C99BD File Offset: 0x009C7BBD
		public unsafe float G额外臂长系数_目标高度差_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17006482 RID: 25730
		// (get) Token: 0x06029A93 RID: 170643 RVA: 0x009C99CE File Offset: 0x009C7BCE
		// (set) Token: 0x06029A94 RID: 170644 RVA: 0x009C99DE File Offset: 0x009C7BDE
		public unsafe float G额外臂长限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x17006483 RID: 25731
		// (get) Token: 0x06029A95 RID: 170645 RVA: 0x009C99EF File Offset: 0x009C7BEF
		// (set) Token: 0x06029A96 RID: 170646 RVA: 0x009C99FF File Offset: 0x009C7BFF
		public unsafe float G额外臂水平偏移系数_目标水平距离_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x17006484 RID: 25732
		// (get) Token: 0x06029A97 RID: 170647 RVA: 0x009C9A10 File Offset: 0x009C7C10
		// (set) Token: 0x06029A98 RID: 170648 RVA: 0x009C9A20 File Offset: 0x009C7C20
		public unsafe float G额外臂水平偏移上限
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x17006485 RID: 25733
		// (get) Token: 0x06029A99 RID: 170649 RVA: 0x009C9A31 File Offset: 0x009C7C31
		// (set) Token: 0x06029A9A RID: 170650 RVA: 0x009C9A41 File Offset: 0x009C7C41
		public unsafe float G额外臂垂直偏移系数_目标高度差_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17006486 RID: 25734
		// (get) Token: 0x06029A9B RID: 170651 RVA: 0x009C9A52 File Offset: 0x009C7C52
		// (set) Token: 0x06029A9C RID: 170652 RVA: 0x009C9A62 File Offset: 0x009C7C62
		public unsafe float G额外臂垂直偏移上限
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x17006487 RID: 25735
		// (get) Token: 0x06029A9D RID: 170653 RVA: 0x009C9A73 File Offset: 0x009C7C73
		// (set) Token: 0x06029A9E RID: 170654 RVA: 0x009C9A83 File Offset: 0x009C7C83
		public unsafe float GInRangeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17006488 RID: 25736
		// (get) Token: 0x06029A9F RID: 170655 RVA: 0x009C9A94 File Offset: 0x009C7C94
		// (set) Token: 0x06029AA0 RID: 170656 RVA: 0x009C9AA4 File Offset: 0x009C7CA4
		public unsafe float GInRangeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x17006489 RID: 25737
		// (get) Token: 0x06029AA1 RID: 170657 RVA: 0x009C9AB5 File Offset: 0x009C7CB5
		// (set) Token: 0x06029AA2 RID: 170658 RVA: 0x009C9AC5 File Offset: 0x009C7CC5
		public unsafe float GOutRangeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x1700648A RID: 25738
		// (get) Token: 0x06029AA3 RID: 170659 RVA: 0x009C9AD6 File Offset: 0x009C7CD6
		// (set) Token: 0x06029AA4 RID: 170660 RVA: 0x009C9AE6 File Offset: 0x009C7CE6
		public unsafe float GOutRangeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_63);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_63) = value;
			}
		}

		// Token: 0x1700648B RID: 25739
		// (get) Token: 0x06029AA5 RID: 170661 RVA: 0x009C9AF7 File Offset: 0x009C7CF7
		// (set) Token: 0x06029AA6 RID: 170662 RVA: 0x009C9B07 File Offset: 0x009C7D07
		public unsafe float GCameraPitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x1700648C RID: 25740
		// (get) Token: 0x06029AA7 RID: 170663 RVA: 0x009C9B18 File Offset: 0x009C7D18
		// (set) Token: 0x06029AA8 RID: 170664 RVA: 0x009C9B28 File Offset: 0x009C7D28
		public unsafe float GCameraPitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x1700648D RID: 25741
		// (get) Token: 0x06029AA9 RID: 170665 RVA: 0x009C9B39 File Offset: 0x009C7D39
		// (set) Token: 0x06029AAA RID: 170666 RVA: 0x009C9B49 File Offset: 0x009C7D49
		public unsafe float GCameraPitchOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x1700648E RID: 25742
		// (get) Token: 0x06029AAB RID: 170667 RVA: 0x009C9B5A File Offset: 0x009C7D5A
		// (set) Token: 0x06029AAC RID: 170668 RVA: 0x009C9B6A File Offset: 0x009C7D6A
		public unsafe float GNearerRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x1700648F RID: 25743
		// (get) Token: 0x06029AAD RID: 170669 RVA: 0x009C9B7B File Offset: 0x009C7D7B
		// (set) Token: 0x06029AAE RID: 170670 RVA: 0x009C9B8B File Offset: 0x009C7D8B
		public unsafe float E修正角度Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17006490 RID: 25744
		// (get) Token: 0x06029AAF RID: 170671 RVA: 0x009C9B9C File Offset: 0x009C7D9C
		// (set) Token: 0x06029AB0 RID: 170672 RVA: 0x009C9BAC File Offset: 0x009C7DAC
		public unsafe float E修正角度Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x17006491 RID: 25745
		// (get) Token: 0x06029AB1 RID: 170673 RVA: 0x009C9BBD File Offset: 0x009C7DBD
		// (set) Token: 0x06029AB2 RID: 170674 RVA: 0x009C9BCD File Offset: 0x009C7DCD
		public unsafe float EInRangeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_70);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_70) = value;
			}
		}

		// Token: 0x17006492 RID: 25746
		// (get) Token: 0x06029AB3 RID: 170675 RVA: 0x009C9BDE File Offset: 0x009C7DDE
		// (set) Token: 0x06029AB4 RID: 170676 RVA: 0x009C9BEE File Offset: 0x009C7DEE
		public unsafe float EInRangeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_71);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x17006493 RID: 25747
		// (get) Token: 0x06029AB5 RID: 170677 RVA: 0x009C9BFF File Offset: 0x009C7DFF
		// (set) Token: 0x06029AB6 RID: 170678 RVA: 0x009C9C0F File Offset: 0x009C7E0F
		public unsafe float EOutRangeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x17006494 RID: 25748
		// (get) Token: 0x06029AB7 RID: 170679 RVA: 0x009C9C20 File Offset: 0x009C7E20
		// (set) Token: 0x06029AB8 RID: 170680 RVA: 0x009C9C30 File Offset: 0x009C7E30
		public unsafe float EOutRangeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_73);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_73) = value;
			}
		}

		// Token: 0x17006495 RID: 25749
		// (get) Token: 0x06029AB9 RID: 170681 RVA: 0x009C9C41 File Offset: 0x009C7E41
		// (set) Token: 0x06029ABA RID: 170682 RVA: 0x009C9C51 File Offset: 0x009C7E51
		public unsafe float E摄像机合法角度_移动方向_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_74);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_74) = value;
			}
		}

		// Token: 0x17006496 RID: 25750
		// (get) Token: 0x06029ABB RID: 170683 RVA: 0x009C9C62 File Offset: 0x009C7E62
		// (set) Token: 0x06029ABC RID: 170684 RVA: 0x009C9C72 File Offset: 0x009C7E72
		public unsafe float E移动方向合法角度_看向点方向_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x17006497 RID: 25751
		// (get) Token: 0x06029ABD RID: 170685 RVA: 0x009C9C83 File Offset: 0x009C7E83
		// (set) Token: 0x06029ABE RID: 170686 RVA: 0x009C9C93 File Offset: 0x009C7E93
		public unsafe float D淡入系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x17006498 RID: 25752
		// (get) Token: 0x06029ABF RID: 170687 RVA: 0x009C9CA4 File Offset: 0x009C7EA4
		// (set) Token: 0x06029AC0 RID: 170688 RVA: 0x009C9CB4 File Offset: 0x009C7EB4
		public unsafe float D淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x17006499 RID: 25753
		// (get) Token: 0x06029AC1 RID: 170689 RVA: 0x009C9CC5 File Offset: 0x009C7EC5
		// (set) Token: 0x06029AC2 RID: 170690 RVA: 0x009C9CD5 File Offset: 0x009C7ED5
		public unsafe float D淡出速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_78);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_78) = value;
			}
		}

		// Token: 0x1700649A RID: 25754
		// (get) Token: 0x06029AC3 RID: 170691 RVA: 0x009C9CE6 File Offset: 0x009C7EE6
		// (set) Token: 0x06029AC4 RID: 170692 RVA: 0x009C9CF6 File Offset: 0x009C7EF6
		public unsafe float D检查旋转角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_79);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_79) = value;
			}
		}

		// Token: 0x1700649B RID: 25755
		// (get) Token: 0x06029AC5 RID: 170693 RVA: 0x009C9D07 File Offset: 0x009C7F07
		// (set) Token: 0x06029AC6 RID: 170694 RVA: 0x009C9D17 File Offset: 0x009C7F17
		public unsafe float D检查最小俯仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_80);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_80) = value;
			}
		}

		// Token: 0x1700649C RID: 25756
		// (get) Token: 0x06029AC7 RID: 170695 RVA: 0x009C9D28 File Offset: 0x009C7F28
		// (set) Token: 0x06029AC8 RID: 170696 RVA: 0x009C9D38 File Offset: 0x009C7F38
		public unsafe float D检查最大俯仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_81);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_81) = value;
			}
		}

		// Token: 0x1700649D RID: 25757
		// (get) Token: 0x06029AC9 RID: 170697 RVA: 0x009C9D49 File Offset: 0x009C7F49
		// (set) Token: 0x06029ACA RID: 170698 RVA: 0x009C9D59 File Offset: 0x009C7F59
		public unsafe float D调整旋转角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_82);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_82) = value;
			}
		}

		// Token: 0x1700649E RID: 25758
		// (get) Token: 0x06029ACB RID: 170699 RVA: 0x009C9D6A File Offset: 0x009C7F6A
		// (set) Token: 0x06029ACC RID: 170700 RVA: 0x009C9D7A File Offset: 0x009C7F7A
		public unsafe float D调整最小俯仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_83);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_83) = value;
			}
		}

		// Token: 0x1700649F RID: 25759
		// (get) Token: 0x06029ACD RID: 170701 RVA: 0x009C9D8B File Offset: 0x009C7F8B
		// (set) Token: 0x06029ACE RID: 170702 RVA: 0x009C9D9B File Offset: 0x009C7F9B
		public unsafe float D调整最大俯仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_84);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_84) = value;
			}
		}

		// Token: 0x170064A0 RID: 25760
		// (get) Token: 0x06029ACF RID: 170703 RVA: 0x009C9DAC File Offset: 0x009C7FAC
		// (set) Token: 0x06029AD0 RID: 170704 RVA: 0x009C9DBC File Offset: 0x009C7FBC
		public unsafe float D中心点偏移比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_85);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_85) = value;
			}
		}

		// Token: 0x170064A1 RID: 25761
		// (get) Token: 0x06029AD1 RID: 170705 RVA: 0x009C9DCD File Offset: 0x009C7FCD
		// (set) Token: 0x06029AD2 RID: 170706 RVA: 0x009C9DDD File Offset: 0x009C7FDD
		public unsafe float D中心点最大偏移距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_86);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_86) = value;
			}
		}

		// Token: 0x170064A2 RID: 25762
		// (get) Token: 0x06029AD3 RID: 170707 RVA: 0x009C9DEE File Offset: 0x009C7FEE
		// (set) Token: 0x06029AD4 RID: 170708 RVA: 0x009C9DFE File Offset: 0x009C7FFE
		public unsafe float 最小上浮臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_87);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_87) = value;
			}
		}

		// Token: 0x170064A3 RID: 25763
		// (get) Token: 0x06029AD5 RID: 170709 RVA: 0x009C9E0F File Offset: 0x009C800F
		// (set) Token: 0x06029AD6 RID: 170710 RVA: 0x009C9E1F File Offset: 0x009C801F
		public unsafe float 最大上浮臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_88);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_88) = value;
			}
		}

		// Token: 0x170064A4 RID: 25764
		// (get) Token: 0x06029AD7 RID: 170711 RVA: 0x009C9E30 File Offset: 0x009C8030
		// (set) Token: 0x06029AD8 RID: 170712 RVA: 0x009C9E40 File Offset: 0x009C8040
		public unsafe float C退出攀爬淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_89);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_89) = value;
			}
		}

		// Token: 0x170064A5 RID: 25765
		// (get) Token: 0x06029AD9 RID: 170713 RVA: 0x009C9E51 File Offset: 0x009C8051
		// (set) Token: 0x06029ADA RID: 170714 RVA: 0x009C9E61 File Offset: 0x009C8061
		public unsafe float C无操作等待时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_90);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_90) = value;
			}
		}

		// Token: 0x170064A6 RID: 25766
		// (get) Token: 0x06029ADB RID: 170715 RVA: 0x009C9E72 File Offset: 0x009C8072
		// (set) Token: 0x06029ADC RID: 170716 RVA: 0x009C9E82 File Offset: 0x009C8082
		public unsafe float C持续移动进入修正时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_91);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_91) = value;
			}
		}

		// Token: 0x170064A7 RID: 25767
		// (get) Token: 0x06029ADD RID: 170717 RVA: 0x009C9E93 File Offset: 0x009C8093
		// (set) Token: 0x06029ADE RID: 170718 RVA: 0x009C9EA3 File Offset: 0x009C80A3
		public unsafe float C镜头角度插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_92);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_92) = value;
			}
		}

		// Token: 0x170064A8 RID: 25768
		// (get) Token: 0x06029ADF RID: 170719 RVA: 0x009C9EB4 File Offset: 0x009C80B4
		// (set) Token: 0x06029AE0 RID: 170720 RVA: 0x009C9EC4 File Offset: 0x009C80C4
		public unsafe float C角色移动基准速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_93);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_93) = value;
			}
		}

		// Token: 0x170064A9 RID: 25769
		// (get) Token: 0x06029AE1 RID: 170721 RVA: 0x009C9ED5 File Offset: 0x009C80D5
		// (set) Token: 0x06029AE2 RID: 170722 RVA: 0x009C9EE5 File Offset: 0x009C80E5
		public unsafe float C进入攀爬增加臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x170064AA RID: 25770
		// (get) Token: 0x06029AE3 RID: 170723 RVA: 0x009C9EF6 File Offset: 0x009C80F6
		// (set) Token: 0x06029AE4 RID: 170724 RVA: 0x009C9F06 File Offset: 0x009C8106
		public unsafe float C进入攀爬修正时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_95);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_95) = value;
			}
		}

		// Token: 0x170064AB RID: 25771
		// (get) Token: 0x06029AE5 RID: 170725 RVA: 0x009C9F17 File Offset: 0x009C8117
		// (set) Token: 0x06029AE6 RID: 170726 RVA: 0x009C9F27 File Offset: 0x009C8127
		public unsafe float C进入攀爬淡出系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_96);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_96) = value;
			}
		}

		// Token: 0x170064AC RID: 25772
		// (get) Token: 0x06029AE7 RID: 170727 RVA: 0x009C9F38 File Offset: 0x009C8138
		// (set) Token: 0x06029AE8 RID: 170728 RVA: 0x009C9F48 File Offset: 0x009C8148
		public unsafe float C攀爬基准臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_97);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_97) = value;
			}
		}

		// Token: 0x170064AD RID: 25773
		// (get) Token: 0x06029AE9 RID: 170729 RVA: 0x009C9F59 File Offset: 0x009C8159
		// (set) Token: 0x06029AEA RID: 170730 RVA: 0x009C9F69 File Offset: 0x009C8169
		public unsafe float C臂长插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_98);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_98) = value;
			}
		}

		// Token: 0x170064AE RID: 25774
		// (get) Token: 0x06029AEB RID: 170731 RVA: 0x009C9F7A File Offset: 0x009C817A
		// (set) Token: 0x06029AEC RID: 170732 RVA: 0x009C9F8A File Offset: 0x009C818A
		public unsafe float C镜头预期朝向与角色移动方向夹角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_99);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_99) = value;
			}
		}

		// Token: 0x170064AF RID: 25775
		// (get) Token: 0x06029AED RID: 170733 RVA: 0x009C9F9B File Offset: 0x009C819B
		// (set) Token: 0x06029AEE RID: 170734 RVA: 0x009C9FAB File Offset: 0x009C81AB
		public unsafe float C镜头预期朝向俯视角压缩倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_100);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_100) = value;
			}
		}

		// Token: 0x170064B0 RID: 25776
		// (get) Token: 0x06029AEF RID: 170735 RVA: 0x009C9FBC File Offset: 0x009C81BC
		// (set) Token: 0x06029AF0 RID: 170736 RVA: 0x009C9FCC File Offset: 0x009C81CC
		public unsafe float C镜头预期朝向仰视角压缩倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_101);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_101) = value;
			}
		}

		// Token: 0x170064B1 RID: 25777
		// (get) Token: 0x06029AF1 RID: 170737 RVA: 0x009C9FDD File Offset: 0x009C81DD
		// (set) Token: 0x06029AF2 RID: 170738 RVA: 0x009C9FED File Offset: 0x009C81ED
		public unsafe float S旋转角速度插值速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_102);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x170064B2 RID: 25778
		// (get) Token: 0x06029AF3 RID: 170739 RVA: 0x009C9FFE File Offset: 0x009C81FE
		// (set) Token: 0x06029AF4 RID: 170740 RVA: 0x009CA00E File Offset: 0x009C820E
		public unsafe float C镜头预期朝向和角色面朝方向夹角合法范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_103);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_103) = value;
			}
		}

		// Token: 0x170064B3 RID: 25779
		// (get) Token: 0x06029AF5 RID: 170741 RVA: 0x009CA01F File Offset: 0x009C821F
		// (set) Token: 0x06029AF6 RID: 170742 RVA: 0x009CA02F File Offset: 0x009C822F
		public unsafe float C输入粘滞时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_104);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_104) = value;
			}
		}

		// Token: 0x170064B4 RID: 25780
		// (get) Token: 0x06029AF7 RID: 170743 RVA: 0x009CA040 File Offset: 0x009C8240
		// (set) Token: 0x06029AF8 RID: 170744 RVA: 0x009CA050 File Offset: 0x009C8250
		public unsafe float S俯仰角插值速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_105);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_105) = value;
			}
		}

		// Token: 0x170064B5 RID: 25781
		// (get) Token: 0x06029AF9 RID: 170745 RVA: 0x009CA061 File Offset: 0x009C8261
		// (set) Token: 0x06029AFA RID: 170746 RVA: 0x009CA071 File Offset: 0x009C8271
		public unsafe float S相机俯角偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_106);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_106) = value;
			}
		}

		// Token: 0x170064B6 RID: 25782
		// (get) Token: 0x06029AFB RID: 170747 RVA: 0x009CA082 File Offset: 0x009C8282
		// (set) Token: 0x06029AFC RID: 170748 RVA: 0x009CA092 File Offset: 0x009C8292
		public unsafe float S最大俯角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_107);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_107) = value;
			}
		}

		// Token: 0x170064B7 RID: 25783
		// (get) Token: 0x06029AFD RID: 170749 RVA: 0x009CA0A3 File Offset: 0x009C82A3
		// (set) Token: 0x06029AFE RID: 170750 RVA: 0x009CA0B3 File Offset: 0x009C82B3
		public unsafe float S最大仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_108);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_108) = value;
			}
		}

		// Token: 0x170064B8 RID: 25784
		// (get) Token: 0x06029AFF RID: 170751 RVA: 0x009CA0C4 File Offset: 0x009C82C4
		// (set) Token: 0x06029B00 RID: 170752 RVA: 0x009CA0D4 File Offset: 0x009C82D4
		public unsafe float S俯仰修正时间阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_109);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_109) = value;
			}
		}

		// Token: 0x170064B9 RID: 25785
		// (get) Token: 0x06029B01 RID: 170753 RVA: 0x009CA0E5 File Offset: 0x009C82E5
		// (set) Token: 0x06029B02 RID: 170754 RVA: 0x009CA0F5 File Offset: 0x009C82F5
		public unsafe float 弹簧臂中心点垂直插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_110);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_110) = value;
			}
		}

		// Token: 0x170064BA RID: 25786
		// (get) Token: 0x06029B03 RID: 170755 RVA: 0x009CA106 File Offset: 0x009C8306
		// (set) Token: 0x06029B04 RID: 170756 RVA: 0x009CA116 File Offset: 0x009C8316
		public unsafe float 弹簧臂中心点垂直偏移距离上限
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_111);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_111) = value;
			}
		}

		// Token: 0x170064BB RID: 25787
		// (get) Token: 0x06029B05 RID: 170757 RVA: 0x009CA127 File Offset: 0x009C8327
		// (set) Token: 0x06029B06 RID: 170758 RVA: 0x009CA137 File Offset: 0x009C8337
		public unsafe float 弹簧臂中心点水平插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_112);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_112) = value;
			}
		}

		// Token: 0x170064BC RID: 25788
		// (get) Token: 0x06029B07 RID: 170759 RVA: 0x009CA148 File Offset: 0x009C8348
		// (set) Token: 0x06029B08 RID: 170760 RVA: 0x009CA158 File Offset: 0x009C8358
		public unsafe float 弹簧臂中心点水平偏移距离上限
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_113);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_113) = value;
			}
		}

		// Token: 0x170064BD RID: 25789
		// (get) Token: 0x06029B09 RID: 170761 RVA: 0x009CA169 File Offset: 0x009C8369
		// (set) Token: 0x06029B0A RID: 170762 RVA: 0x009CA179 File Offset: 0x009C8379
		public unsafe float S俯仰角加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_114);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_114) = value;
			}
		}

		// Token: 0x170064BE RID: 25790
		// (get) Token: 0x06029B0B RID: 170763 RVA: 0x009CA18A File Offset: 0x009C838A
		// (set) Token: 0x06029B0C RID: 170764 RVA: 0x009CA19A File Offset: 0x009C839A
		public unsafe float C登顶镜头插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_115);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_115) = value;
			}
		}

		// Token: 0x170064BF RID: 25791
		// (get) Token: 0x06029B0D RID: 170765 RVA: 0x009CA1AB File Offset: 0x009C83AB
		// (set) Token: 0x06029B0E RID: 170766 RVA: 0x009CA1BB File Offset: 0x009C83BB
		public unsafe float C登顶镜头预期Pitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_116);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_116) = value;
			}
		}

		// Token: 0x170064C0 RID: 25792
		// (get) Token: 0x06029B0F RID: 170767 RVA: 0x009CA1CC File Offset: 0x009C83CC
		// (set) Token: 0x06029B10 RID: 170768 RVA: 0x009CA1DC File Offset: 0x009C83DC
		public unsafe float 镜头输入缓冲系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_117);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_117) = value;
			}
		}

		// Token: 0x170064C1 RID: 25793
		// (get) Token: 0x06029B11 RID: 170769 RVA: 0x009CA1ED File Offset: 0x009C83ED
		// (set) Token: 0x06029B12 RID: 170770 RVA: 0x009CA1FD File Offset: 0x009C83FD
		public unsafe float 镜头基准灵敏度Yaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_118);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_118) = value;
			}
		}

		// Token: 0x170064C2 RID: 25794
		// (get) Token: 0x06029B13 RID: 170771 RVA: 0x009CA20E File Offset: 0x009C840E
		// (set) Token: 0x06029B14 RID: 170772 RVA: 0x009CA21E File Offset: 0x009C841E
		public unsafe float 镜头基准灵敏度Pitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_119);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_119) = value;
			}
		}

		// Token: 0x170064C3 RID: 25795
		// (get) Token: 0x06029B15 RID: 170773 RVA: 0x009CA22F File Offset: 0x009C842F
		// (set) Token: 0x06029B16 RID: 170774 RVA: 0x009CA23F File Offset: 0x009C843F
		public unsafe float 镜头输入速率Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_120);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_120) = value;
			}
		}

		// Token: 0x170064C4 RID: 25796
		// (get) Token: 0x06029B17 RID: 170775 RVA: 0x009CA250 File Offset: 0x009C8450
		// (set) Token: 0x06029B18 RID: 170776 RVA: 0x009CA260 File Offset: 0x009C8460
		public unsafe float 镜头输入速率Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_121);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraConfig_C.__PropertyOffset_121) = value;
			}
		}

		// Token: 0x06029B19 RID: 170777 RVA: 0x009CA271 File Offset: 0x009C8471
		protected BP_CameraConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155E7 RID: 87527
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/BP_CameraConfig.BP_CameraConfig_C";

		// Token: 0x040155E8 RID: 87528
		private static IntPtr _ClassPtr;

		// Token: 0x040155E9 RID: 87529
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040155EA RID: 87530
		internal static int __PropertyOffset_0;

		// Token: 0x040155EB RID: 87531
		internal static int __PropertyOffset_1;

		// Token: 0x040155EC RID: 87532
		internal static int __PropertyOffset_2;

		// Token: 0x040155ED RID: 87533
		internal static int __PropertyOffset_3;

		// Token: 0x040155EE RID: 87534
		internal static int __PropertyOffset_4;

		// Token: 0x040155EF RID: 87535
		internal static int __PropertyOffset_5;

		// Token: 0x040155F0 RID: 87536
		internal static int __PropertyOffset_6;

		// Token: 0x040155F1 RID: 87537
		internal static int __PropertyOffset_7;

		// Token: 0x040155F2 RID: 87538
		internal static int __PropertyOffset_8;

		// Token: 0x040155F3 RID: 87539
		internal static int __PropertyOffset_9;

		// Token: 0x040155F4 RID: 87540
		internal static int __PropertyOffset_10;

		// Token: 0x040155F5 RID: 87541
		internal static int __PropertyOffset_11;

		// Token: 0x040155F6 RID: 87542
		internal static int __PropertyOffset_12;

		// Token: 0x040155F7 RID: 87543
		internal static int __PropertyOffset_13;

		// Token: 0x040155F8 RID: 87544
		internal static int __PropertyOffset_14;

		// Token: 0x040155F9 RID: 87545
		internal static int __PropertyOffset_15;

		// Token: 0x040155FA RID: 87546
		internal static int __PropertyOffset_16;

		// Token: 0x040155FB RID: 87547
		internal static int __PropertyOffset_17;

		// Token: 0x040155FC RID: 87548
		internal static int __PropertyOffset_18;

		// Token: 0x040155FD RID: 87549
		internal static int __PropertyOffset_19;

		// Token: 0x040155FE RID: 87550
		internal static int __PropertyOffset_20;

		// Token: 0x040155FF RID: 87551
		internal static int __PropertyOffset_21;

		// Token: 0x04015600 RID: 87552
		internal static int __PropertyOffset_22;

		// Token: 0x04015601 RID: 87553
		internal static int __PropertyOffset_23;

		// Token: 0x04015602 RID: 87554
		internal static int __PropertyOffset_24;

		// Token: 0x04015603 RID: 87555
		internal static int __PropertyOffset_25;

		// Token: 0x04015604 RID: 87556
		internal static int __PropertyOffset_26;

		// Token: 0x04015605 RID: 87557
		internal static int __PropertyOffset_27;

		// Token: 0x04015606 RID: 87558
		internal static int __PropertyOffset_28;

		// Token: 0x04015607 RID: 87559
		internal static int __PropertyOffset_29;

		// Token: 0x04015608 RID: 87560
		internal static int __PropertyOffset_30;

		// Token: 0x04015609 RID: 87561
		internal static int __PropertyOffset_31;

		// Token: 0x0401560A RID: 87562
		internal static int __PropertyOffset_32;

		// Token: 0x0401560B RID: 87563
		internal static int __PropertyOffset_33;

		// Token: 0x0401560C RID: 87564
		internal static int __PropertyOffset_34;

		// Token: 0x0401560D RID: 87565
		internal static int __PropertyOffset_35;

		// Token: 0x0401560E RID: 87566
		internal static int __PropertyOffset_36;

		// Token: 0x0401560F RID: 87567
		internal static int __PropertyOffset_37;

		// Token: 0x04015610 RID: 87568
		internal static int __PropertyOffset_38;

		// Token: 0x04015611 RID: 87569
		internal static int __PropertyOffset_39;

		// Token: 0x04015612 RID: 87570
		internal static int __PropertyOffset_40;

		// Token: 0x04015613 RID: 87571
		internal static int __PropertyOffset_41;

		// Token: 0x04015614 RID: 87572
		internal static int __PropertyOffset_42;

		// Token: 0x04015615 RID: 87573
		internal static int __PropertyOffset_43;

		// Token: 0x04015616 RID: 87574
		internal static int __PropertyOffset_44;

		// Token: 0x04015617 RID: 87575
		internal static int __PropertyOffset_45;

		// Token: 0x04015618 RID: 87576
		internal static int __PropertyOffset_46;

		// Token: 0x04015619 RID: 87577
		internal static int __PropertyOffset_47;

		// Token: 0x0401561A RID: 87578
		internal static int __PropertyOffset_48;

		// Token: 0x0401561B RID: 87579
		internal static int __PropertyOffset_49;

		// Token: 0x0401561C RID: 87580
		internal static int __PropertyOffset_50;

		// Token: 0x0401561D RID: 87581
		internal static int __PropertyOffset_51;

		// Token: 0x0401561E RID: 87582
		internal static int __PropertyOffset_52;

		// Token: 0x0401561F RID: 87583
		internal static int __PropertyOffset_53;

		// Token: 0x04015620 RID: 87584
		internal static int __PropertyOffset_54;

		// Token: 0x04015621 RID: 87585
		internal static int __PropertyOffset_55;

		// Token: 0x04015622 RID: 87586
		internal static int __PropertyOffset_56;

		// Token: 0x04015623 RID: 87587
		internal static int __PropertyOffset_57;

		// Token: 0x04015624 RID: 87588
		internal static int __PropertyOffset_58;

		// Token: 0x04015625 RID: 87589
		internal static int __PropertyOffset_59;

		// Token: 0x04015626 RID: 87590
		internal static int __PropertyOffset_60;

		// Token: 0x04015627 RID: 87591
		internal static int __PropertyOffset_61;

		// Token: 0x04015628 RID: 87592
		internal static int __PropertyOffset_62;

		// Token: 0x04015629 RID: 87593
		internal static int __PropertyOffset_63;

		// Token: 0x0401562A RID: 87594
		internal static int __PropertyOffset_64;

		// Token: 0x0401562B RID: 87595
		internal static int __PropertyOffset_65;

		// Token: 0x0401562C RID: 87596
		internal static int __PropertyOffset_66;

		// Token: 0x0401562D RID: 87597
		internal static int __PropertyOffset_67;

		// Token: 0x0401562E RID: 87598
		internal static int __PropertyOffset_68;

		// Token: 0x0401562F RID: 87599
		internal static int __PropertyOffset_69;

		// Token: 0x04015630 RID: 87600
		internal static int __PropertyOffset_70;

		// Token: 0x04015631 RID: 87601
		internal static int __PropertyOffset_71;

		// Token: 0x04015632 RID: 87602
		internal static int __PropertyOffset_72;

		// Token: 0x04015633 RID: 87603
		internal static int __PropertyOffset_73;

		// Token: 0x04015634 RID: 87604
		internal static int __PropertyOffset_74;

		// Token: 0x04015635 RID: 87605
		internal static int __PropertyOffset_75;

		// Token: 0x04015636 RID: 87606
		internal static int __PropertyOffset_76;

		// Token: 0x04015637 RID: 87607
		internal static int __PropertyOffset_77;

		// Token: 0x04015638 RID: 87608
		internal static int __PropertyOffset_78;

		// Token: 0x04015639 RID: 87609
		internal static int __PropertyOffset_79;

		// Token: 0x0401563A RID: 87610
		internal static int __PropertyOffset_80;

		// Token: 0x0401563B RID: 87611
		internal static int __PropertyOffset_81;

		// Token: 0x0401563C RID: 87612
		internal static int __PropertyOffset_82;

		// Token: 0x0401563D RID: 87613
		internal static int __PropertyOffset_83;

		// Token: 0x0401563E RID: 87614
		internal static int __PropertyOffset_84;

		// Token: 0x0401563F RID: 87615
		internal static int __PropertyOffset_85;

		// Token: 0x04015640 RID: 87616
		internal static int __PropertyOffset_86;

		// Token: 0x04015641 RID: 87617
		internal static int __PropertyOffset_87;

		// Token: 0x04015642 RID: 87618
		internal static int __PropertyOffset_88;

		// Token: 0x04015643 RID: 87619
		internal static int __PropertyOffset_89;

		// Token: 0x04015644 RID: 87620
		internal static int __PropertyOffset_90;

		// Token: 0x04015645 RID: 87621
		internal static int __PropertyOffset_91;

		// Token: 0x04015646 RID: 87622
		internal static int __PropertyOffset_92;

		// Token: 0x04015647 RID: 87623
		internal static int __PropertyOffset_93;

		// Token: 0x04015648 RID: 87624
		internal static int __PropertyOffset_94;

		// Token: 0x04015649 RID: 87625
		internal static int __PropertyOffset_95;

		// Token: 0x0401564A RID: 87626
		internal static int __PropertyOffset_96;

		// Token: 0x0401564B RID: 87627
		internal static int __PropertyOffset_97;

		// Token: 0x0401564C RID: 87628
		internal static int __PropertyOffset_98;

		// Token: 0x0401564D RID: 87629
		internal static int __PropertyOffset_99;

		// Token: 0x0401564E RID: 87630
		internal static int __PropertyOffset_100;

		// Token: 0x0401564F RID: 87631
		internal static int __PropertyOffset_101;

		// Token: 0x04015650 RID: 87632
		internal static int __PropertyOffset_102;

		// Token: 0x04015651 RID: 87633
		internal static int __PropertyOffset_103;

		// Token: 0x04015652 RID: 87634
		internal static int __PropertyOffset_104;

		// Token: 0x04015653 RID: 87635
		internal static int __PropertyOffset_105;

		// Token: 0x04015654 RID: 87636
		internal static int __PropertyOffset_106;

		// Token: 0x04015655 RID: 87637
		internal static int __PropertyOffset_107;

		// Token: 0x04015656 RID: 87638
		internal static int __PropertyOffset_108;

		// Token: 0x04015657 RID: 87639
		internal static int __PropertyOffset_109;

		// Token: 0x04015658 RID: 87640
		internal static int __PropertyOffset_110;

		// Token: 0x04015659 RID: 87641
		internal static int __PropertyOffset_111;

		// Token: 0x0401565A RID: 87642
		internal static int __PropertyOffset_112;

		// Token: 0x0401565B RID: 87643
		internal static int __PropertyOffset_113;

		// Token: 0x0401565C RID: 87644
		internal static int __PropertyOffset_114;

		// Token: 0x0401565D RID: 87645
		internal static int __PropertyOffset_115;

		// Token: 0x0401565E RID: 87646
		internal static int __PropertyOffset_116;

		// Token: 0x0401565F RID: 87647
		internal static int __PropertyOffset_117;

		// Token: 0x04015660 RID: 87648
		internal static int __PropertyOffset_118;

		// Token: 0x04015661 RID: 87649
		internal static int __PropertyOffset_119;

		// Token: 0x04015662 RID: 87650
		internal static int __PropertyOffset_120;

		// Token: 0x04015663 RID: 87651
		internal static int __PropertyOffset_121;
	}
}
