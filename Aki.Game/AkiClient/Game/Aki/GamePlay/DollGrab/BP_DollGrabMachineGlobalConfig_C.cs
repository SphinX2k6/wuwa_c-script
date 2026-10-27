using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.DollGrab
{
	// Token: 0x02003E6A RID: 15978
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/DollGrab/BP_DollGrabMachineGlobalConfig.BP_DollGrabMachineGlobalConfig_C")]
	[UnrealStructLayout(928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class BP_DollGrabMachineGlobalConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028325 RID: 164645 RVA: 0x009A65EF File Offset: 0x009A47EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollGrabMachineGlobalConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/DollGrab/BP_DollGrabMachineGlobalConfig.BP_DollGrabMachineGlobalConfig_C");
			}
			return BP_DollGrabMachineGlobalConfig_C._ClassPtr;
		}

		// Token: 0x06028326 RID: 164646 RVA: 0x009A6614 File Offset: 0x009A4814
		public BP_DollGrabMachineGlobalConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabMachineGlobalConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028327 RID: 164647 RVA: 0x009A663C File Offset: 0x009A483C
		public BP_DollGrabMachineGlobalConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabMachineGlobalConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C41 RID: 23617
		// (get) Token: 0x06028328 RID: 164648 RVA: 0x009A666F File Offset: 0x009A486F
		// (set) Token: 0x06028329 RID: 164649 RVA: 0x009A667F File Offset: 0x009A487F
		public unsafe float 钩爪移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005C42 RID: 23618
		// (get) Token: 0x0602832A RID: 164650 RVA: 0x009A6690 File Offset: 0x009A4890
		// (set) Token: 0x0602832B RID: 164651 RVA: 0x009A66A0 File Offset: 0x009A48A0
		public unsafe float 钩爪X轴移动距离限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005C43 RID: 23619
		// (get) Token: 0x0602832C RID: 164652 RVA: 0x009A66B1 File Offset: 0x009A48B1
		// (set) Token: 0x0602832D RID: 164653 RVA: 0x009A66C1 File Offset: 0x009A48C1
		public unsafe float 钩爪X轴起始偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005C44 RID: 23620
		// (get) Token: 0x0602832E RID: 164654 RVA: 0x009A66D2 File Offset: 0x009A48D2
		// (set) Token: 0x0602832F RID: 164655 RVA: 0x009A66E2 File Offset: 0x009A48E2
		public unsafe float 钩爪Y轴移动距离限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005C45 RID: 23621
		// (get) Token: 0x06028330 RID: 164656 RVA: 0x009A66F3 File Offset: 0x009A48F3
		// (set) Token: 0x06028331 RID: 164657 RVA: 0x009A6703 File Offset: 0x009A4903
		public unsafe float 钩爪Y轴起始偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005C46 RID: 23622
		// (get) Token: 0x06028332 RID: 164658 RVA: 0x009A6714 File Offset: 0x009A4914
		// (set) Token: 0x06028333 RID: 164659 RVA: 0x009A6724 File Offset: 0x009A4924
		public unsafe float 钩爪下探距离限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005C47 RID: 23623
		// (get) Token: 0x06028334 RID: 164660 RVA: 0x009A6735 File Offset: 0x009A4935
		// (set) Token: 0x06028335 RID: 164661 RVA: 0x009A6745 File Offset: 0x009A4945
		public unsafe float 钩爪下探速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005C48 RID: 23624
		// (get) Token: 0x06028336 RID: 164662 RVA: 0x009A6756 File Offset: 0x009A4956
		// (set) Token: 0x06028337 RID: 164663 RVA: 0x009A6766 File Offset: 0x009A4966
		public unsafe float 钩爪上升速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005C49 RID: 23625
		// (get) Token: 0x06028338 RID: 164664 RVA: 0x009A6777 File Offset: 0x009A4977
		// (set) Token: 0x06028339 RID: 164665 RVA: 0x009A678B File Offset: 0x009A498B
		public unsafe FVector 相机位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005C4A RID: 23626
		// (get) Token: 0x0602833A RID: 164666 RVA: 0x009A67A0 File Offset: 0x009A49A0
		// (set) Token: 0x0602833B RID: 164667 RVA: 0x009A67B4 File Offset: 0x009A49B4
		public unsafe FRotator 相机旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005C4B RID: 23627
		// (get) Token: 0x0602833C RID: 164668 RVA: 0x009A67C9 File Offset: 0x009A49C9
		// (set) Token: 0x0602833D RID: 164669 RVA: 0x009A67D9 File Offset: 0x009A49D9
		public unsafe float 淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005C4C RID: 23628
		// (get) Token: 0x0602833E RID: 164670 RVA: 0x009A67EA File Offset: 0x009A49EA
		// (set) Token: 0x0602833F RID: 164671 RVA: 0x009A67FA File Offset: 0x009A49FA
		public unsafe float 淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005C4D RID: 23629
		// (get) Token: 0x06028340 RID: 164672 RVA: 0x009A680B File Offset: 0x009A4A0B
		// (set) Token: 0x06028341 RID: 164673 RVA: 0x009A681B File Offset: 0x009A4A1B
		public unsafe bool 关闭镜头碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C4E RID: 23630
		// (get) Token: 0x06028342 RID: 164674 RVA: 0x009A682C File Offset: 0x009A4A2C
		// (set) Token: 0x06028343 RID: 164675 RVA: 0x009A683C File Offset: 0x009A4A3C
		public unsafe bool 关闭镜头虚化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C4F RID: 23631
		// (get) Token: 0x06028344 RID: 164676 RVA: 0x009A684D File Offset: 0x009A4A4D
		// (set) Token: 0x06028345 RID: 164677 RVA: 0x009A685D File Offset: 0x009A4A5D
		public unsafe float Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005C50 RID: 23632
		// (get) Token: 0x06028346 RID: 164678 RVA: 0x009A686E File Offset: 0x009A4A6E
		// (set) Token: 0x06028347 RID: 164679 RVA: 0x009A687E File Offset: 0x009A4A7E
		public unsafe float 履带移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005C51 RID: 23633
		// (get) Token: 0x06028348 RID: 164680 RVA: 0x009A688F File Offset: 0x009A4A8F
		// (set) Token: 0x06028349 RID: 164681 RVA: 0x009A689F File Offset: 0x009A4A9F
		public unsafe float 履带吸附距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005C52 RID: 23634
		// (get) Token: 0x0602834A RID: 164682 RVA: 0x009A68B0 File Offset: 0x009A4AB0
		// (set) Token: 0x0602834B RID: 164683 RVA: 0x009A68C0 File Offset: 0x009A4AC0
		public unsafe float 履带吸附速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005C53 RID: 23635
		// (get) Token: 0x0602834C RID: 164684 RVA: 0x009A68D1 File Offset: 0x009A4AD1
		// (set) Token: 0x0602834D RID: 164685 RVA: 0x009A68E1 File Offset: 0x009A4AE1
		public unsafe float 履带TriggerZ轴缩放值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005C54 RID: 23636
		// (get) Token: 0x0602834E RID: 164686 RVA: 0x009A68F2 File Offset: 0x009A4AF2
		// (set) Token: 0x0602834F RID: 164687 RVA: 0x009A6906 File Offset: 0x009A4B06
		public unsafe FVector 展示柜相机位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005C55 RID: 23637
		// (get) Token: 0x06028350 RID: 164688 RVA: 0x009A691B File Offset: 0x009A4B1B
		// (set) Token: 0x06028351 RID: 164689 RVA: 0x009A692F File Offset: 0x009A4B2F
		public unsafe FRotator 展示柜相机旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005C56 RID: 23638
		// (get) Token: 0x06028352 RID: 164690 RVA: 0x009A6944 File Offset: 0x009A4B44
		// (set) Token: 0x06028353 RID: 164691 RVA: 0x009A6954 File Offset: 0x009A4B54
		public unsafe float 展示柜淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005C57 RID: 23639
		// (get) Token: 0x06028354 RID: 164692 RVA: 0x009A6965 File Offset: 0x009A4B65
		// (set) Token: 0x06028355 RID: 164693 RVA: 0x009A6975 File Offset: 0x009A4B75
		public unsafe float 展示柜淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005C58 RID: 23640
		// (get) Token: 0x06028356 RID: 164694 RVA: 0x009A6986 File Offset: 0x009A4B86
		// (set) Token: 0x06028357 RID: 164695 RVA: 0x009A6996 File Offset: 0x009A4B96
		public unsafe bool 展示柜关闭镜头碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C59 RID: 23641
		// (get) Token: 0x06028358 RID: 164696 RVA: 0x009A69A7 File Offset: 0x009A4BA7
		// (set) Token: 0x06028359 RID: 164697 RVA: 0x009A69B7 File Offset: 0x009A4BB7
		public unsafe bool 展示柜关闭镜头虚化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C5A RID: 23642
		// (get) Token: 0x0602835A RID: 164698 RVA: 0x009A69C8 File Offset: 0x009A4BC8
		// (set) Token: 0x0602835B RID: 164699 RVA: 0x009A69D8 File Offset: 0x009A4BD8
		public unsafe float 展示柜Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005C5B RID: 23643
		// (get) Token: 0x0602835C RID: 164700 RVA: 0x009A69E9 File Offset: 0x009A4BE9
		// (set) Token: 0x0602835D RID: 164701 RVA: 0x009A69F9 File Offset: 0x009A4BF9
		public unsafe float 钩爪延迟合上时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005C5C RID: 23644
		// (get) Token: 0x0602835E RID: 164702 RVA: 0x009A6A0A File Offset: 0x009A4C0A
		// (set) Token: 0x0602835F RID: 164703 RVA: 0x009A6A1F File Offset: 0x009A4C1F
		public TSoftObjectPtr<ULevelSequence> 钩爪Seq
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_27, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_27, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C5D RID: 23645
		// (get) Token: 0x06028360 RID: 164704 RVA: 0x009A6A44 File Offset: 0x009A4C44
		// (set) Token: 0x06028361 RID: 164705 RVA: 0x009A6A54 File Offset: 0x009A4C54
		public unsafe float 钩爪锁链缩放比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17005C5E RID: 23646
		// (get) Token: 0x06028362 RID: 164706 RVA: 0x009A6A65 File Offset: 0x009A4C65
		// (set) Token: 0x06028363 RID: 164707 RVA: 0x009A6A75 File Offset: 0x009A4C75
		public unsafe float 钩爪复位时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17005C5F RID: 23647
		// (get) Token: 0x06028364 RID: 164708 RVA: 0x009A6A86 File Offset: 0x009A4C86
		// (set) Token: 0x06028365 RID: 164709 RVA: 0x009A6A96 File Offset: 0x009A4C96
		public unsafe float 溶解时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17005C60 RID: 23648
		// (get) Token: 0x06028366 RID: 164710 RVA: 0x009A6AA7 File Offset: 0x009A4CA7
		// (set) Token: 0x06028367 RID: 164711 RVA: 0x009A6AB7 File Offset: 0x009A4CB7
		public unsafe float 溶解半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17005C61 RID: 23649
		// (get) Token: 0x06028368 RID: 164712 RVA: 0x009A6AC8 File Offset: 0x009A4CC8
		// (set) Token: 0x06028369 RID: 164713 RVA: 0x009A6AD8 File Offset: 0x009A4CD8
		public unsafe float 旋转阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17005C62 RID: 23650
		// (get) Token: 0x0602836A RID: 164714 RVA: 0x009A6AE9 File Offset: 0x009A4CE9
		// (set) Token: 0x0602836B RID: 164715 RVA: 0x009A6AF9 File Offset: 0x009A4CF9
		public unsafe float 平移阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17005C63 RID: 23651
		// (get) Token: 0x0602836C RID: 164716 RVA: 0x009A6B0A File Offset: 0x009A4D0A
		// (set) Token: 0x0602836D RID: 164717 RVA: 0x009A6B1F File Offset: 0x009A4D1F
		public TSoftObjectPtr<UEffectModelGroup> 倒计时屏幕特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_34, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_34, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C64 RID: 23652
		// (get) Token: 0x0602836E RID: 164718 RVA: 0x009A6B44 File Offset: 0x009A4D44
		// (set) Token: 0x0602836F RID: 164719 RVA: 0x009A6B59 File Offset: 0x009A4D59
		public TSoftObjectPtr<UTexture> 钩爪松开按钮图标
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_35, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_35, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C65 RID: 23653
		// (get) Token: 0x06028370 RID: 164720 RVA: 0x009A6B7E File Offset: 0x009A4D7E
		// (set) Token: 0x06028371 RID: 164721 RVA: 0x009A6B93 File Offset: 0x009A4D93
		public TSoftObjectPtr<UTexture> 钩爪常态按钮图标
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_36, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_36, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C66 RID: 23654
		// (get) Token: 0x06028372 RID: 164722 RVA: 0x009A6BB8 File Offset: 0x009A4DB8
		// (set) Token: 0x06028373 RID: 164723 RVA: 0x009A6BCD File Offset: 0x009A4DCD
		public TSoftObjectPtr<UTexture> 钩爪抓取按钮图标
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_37, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_37, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C67 RID: 23655
		// (get) Token: 0x06028374 RID: 164724 RVA: 0x009A6BF2 File Offset: 0x009A4DF2
		// (set) Token: 0x06028375 RID: 164725 RVA: 0x009A6C07 File Offset: 0x009A4E07
		public TSoftObjectPtr<UTexture> 投币按钮图标
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_38, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_38, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C68 RID: 23656
		// (get) Token: 0x06028376 RID: 164726 RVA: 0x009A6C2C File Offset: 0x009A4E2C
		// (set) Token: 0x06028377 RID: 164727 RVA: 0x009A6C40 File Offset: 0x009A4E40
		public unsafe FVector 投出口特效偏移位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17005C69 RID: 23657
		// (get) Token: 0x06028378 RID: 164728 RVA: 0x009A6C55 File Offset: 0x009A4E55
		// (set) Token: 0x06028379 RID: 164729 RVA: 0x009A6C65 File Offset: 0x009A4E65
		public unsafe float 危险倒计时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17005C6A RID: 23658
		// (get) Token: 0x0602837A RID: 164730 RVA: 0x009A6C76 File Offset: 0x009A4E76
		// (set) Token: 0x0602837B RID: 164731 RVA: 0x009A6C8B File Offset: 0x009A4E8B
		public TSoftObjectPtr<ULGUITexturePackerSpriteData> 进度条安全
		{
			get
			{
				return new TSoftObjectPtr<ULGUITexturePackerSpriteData>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_41, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_41, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C6B RID: 23659
		// (get) Token: 0x0602837C RID: 164732 RVA: 0x009A6CB0 File Offset: 0x009A4EB0
		// (set) Token: 0x0602837D RID: 164733 RVA: 0x009A6CC5 File Offset: 0x009A4EC5
		public TSoftObjectPtr<ULGUITexturePackerSpriteData> 进度条危险
		{
			get
			{
				return new TSoftObjectPtr<ULGUITexturePackerSpriteData>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_42, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_42, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C6C RID: 23660
		// (get) Token: 0x0602837E RID: 164734 RVA: 0x009A6CEA File Offset: 0x009A4EEA
		// (set) Token: 0x0602837F RID: 164735 RVA: 0x009A6CFF File Offset: 0x009A4EFF
		public TSoftObjectPtr<ULevelSequence> 常态灯光
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_43, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_43, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C6D RID: 23661
		// (get) Token: 0x06028380 RID: 164736 RVA: 0x009A6D24 File Offset: 0x009A4F24
		// (set) Token: 0x06028381 RID: 164737 RVA: 0x009A6D39 File Offset: 0x009A4F39
		public TSoftObjectPtr<ULevelSequence> 完成态灯光
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_44, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_44, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C6E RID: 23662
		// (get) Token: 0x06028382 RID: 164738 RVA: 0x009A6D5E File Offset: 0x009A4F5E
		// (set) Token: 0x06028383 RID: 164739 RVA: 0x009A6D73 File Offset: 0x009A4F73
		public TSoftObjectPtr<ULevelSequence> 开启玩法灯光
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_45, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_45, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C6F RID: 23663
		// (get) Token: 0x06028384 RID: 164740 RVA: 0x009A6D98 File Offset: 0x009A4F98
		// (set) Token: 0x06028385 RID: 164741 RVA: 0x009A6DAD File Offset: 0x009A4FAD
		public TSoftObjectPtr<ULevelSequence> 玩法进行中灯光
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_46, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_46, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C70 RID: 23664
		// (get) Token: 0x06028386 RID: 164742 RVA: 0x009A6DD2 File Offset: 0x009A4FD2
		// (set) Token: 0x06028387 RID: 164743 RVA: 0x009A6DE2 File Offset: 0x009A4FE2
		public unsafe float 钩爪松开时恢复移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17005C71 RID: 23665
		// (get) Token: 0x06028388 RID: 164744 RVA: 0x009A6DF3 File Offset: 0x009A4FF3
		// (set) Token: 0x06028389 RID: 164745 RVA: 0x009A6E08 File Offset: 0x009A5008
		public TSoftObjectPtr<ULevelSequence> 阿布展示Seq
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_48, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_48, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C72 RID: 23666
		// (get) Token: 0x0602838A RID: 164746 RVA: 0x009A6E2D File Offset: 0x009A502D
		// (set) Token: 0x0602838B RID: 164747 RVA: 0x009A6E41 File Offset: 0x009A5041
		public unsafe FVectorDouble 阿布展示播放位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17005C73 RID: 23667
		// (get) Token: 0x0602838C RID: 164748 RVA: 0x009A6E56 File Offset: 0x009A5056
		// (set) Token: 0x0602838D RID: 164749 RVA: 0x009A6E66 File Offset: 0x009A5066
		public unsafe float 黑幕淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17005C74 RID: 23668
		// (get) Token: 0x0602838E RID: 164750 RVA: 0x009A6E77 File Offset: 0x009A5077
		// (set) Token: 0x0602838F RID: 164751 RVA: 0x009A6E87 File Offset: 0x009A5087
		public unsafe float 黑幕淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17005C75 RID: 23669
		// (get) Token: 0x06028390 RID: 164752 RVA: 0x009A6E98 File Offset: 0x009A5098
		// (set) Token: 0x06028391 RID: 164753 RVA: 0x009A6EA8 File Offset: 0x009A50A8
		public unsafe float 黑幕持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17005C76 RID: 23670
		// (get) Token: 0x06028392 RID: 164754 RVA: 0x009A6EB9 File Offset: 0x009A50B9
		// (set) Token: 0x06028393 RID: 164755 RVA: 0x009A6EC9 File Offset: 0x009A50C9
		public unsafe float 展示动画播放速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x06028394 RID: 164756 RVA: 0x009A6EDA File Offset: 0x009A50DA
		protected BP_DollGrabMachineGlobalConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014768 RID: 83816
		public new const string __ObjectPath = "/Game/Aki/GamePlay/DollGrab/BP_DollGrabMachineGlobalConfig.BP_DollGrabMachineGlobalConfig_C";

		// Token: 0x04014769 RID: 83817
		private static IntPtr _ClassPtr;

		// Token: 0x0401476A RID: 83818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401476B RID: 83819
		internal static int __PropertyOffset_0;

		// Token: 0x0401476C RID: 83820
		internal static int __PropertyOffset_1;

		// Token: 0x0401476D RID: 83821
		internal static int __PropertyOffset_2;

		// Token: 0x0401476E RID: 83822
		internal static int __PropertyOffset_3;

		// Token: 0x0401476F RID: 83823
		internal static int __PropertyOffset_4;

		// Token: 0x04014770 RID: 83824
		internal static int __PropertyOffset_5;

		// Token: 0x04014771 RID: 83825
		internal static int __PropertyOffset_6;

		// Token: 0x04014772 RID: 83826
		internal static int __PropertyOffset_7;

		// Token: 0x04014773 RID: 83827
		internal static int __PropertyOffset_8;

		// Token: 0x04014774 RID: 83828
		internal static int __PropertyOffset_9;

		// Token: 0x04014775 RID: 83829
		internal static int __PropertyOffset_10;

		// Token: 0x04014776 RID: 83830
		internal static int __PropertyOffset_11;

		// Token: 0x04014777 RID: 83831
		internal static int __PropertyOffset_12;

		// Token: 0x04014778 RID: 83832
		internal static int __PropertyOffset_13;

		// Token: 0x04014779 RID: 83833
		internal static int __PropertyOffset_14;

		// Token: 0x0401477A RID: 83834
		internal static int __PropertyOffset_15;

		// Token: 0x0401477B RID: 83835
		internal static int __PropertyOffset_16;

		// Token: 0x0401477C RID: 83836
		internal static int __PropertyOffset_17;

		// Token: 0x0401477D RID: 83837
		internal static int __PropertyOffset_18;

		// Token: 0x0401477E RID: 83838
		internal static int __PropertyOffset_19;

		// Token: 0x0401477F RID: 83839
		internal static int __PropertyOffset_20;

		// Token: 0x04014780 RID: 83840
		internal static int __PropertyOffset_21;

		// Token: 0x04014781 RID: 83841
		internal static int __PropertyOffset_22;

		// Token: 0x04014782 RID: 83842
		internal static int __PropertyOffset_23;

		// Token: 0x04014783 RID: 83843
		internal static int __PropertyOffset_24;

		// Token: 0x04014784 RID: 83844
		internal static int __PropertyOffset_25;

		// Token: 0x04014785 RID: 83845
		internal static int __PropertyOffset_26;

		// Token: 0x04014786 RID: 83846
		internal static int __PropertyOffset_27;

		// Token: 0x04014787 RID: 83847
		internal static int __PropertyOffset_28;

		// Token: 0x04014788 RID: 83848
		internal static int __PropertyOffset_29;

		// Token: 0x04014789 RID: 83849
		internal static int __PropertyOffset_30;

		// Token: 0x0401478A RID: 83850
		internal static int __PropertyOffset_31;

		// Token: 0x0401478B RID: 83851
		internal static int __PropertyOffset_32;

		// Token: 0x0401478C RID: 83852
		internal static int __PropertyOffset_33;

		// Token: 0x0401478D RID: 83853
		internal static int __PropertyOffset_34;

		// Token: 0x0401478E RID: 83854
		internal static int __PropertyOffset_35;

		// Token: 0x0401478F RID: 83855
		internal static int __PropertyOffset_36;

		// Token: 0x04014790 RID: 83856
		internal static int __PropertyOffset_37;

		// Token: 0x04014791 RID: 83857
		internal static int __PropertyOffset_38;

		// Token: 0x04014792 RID: 83858
		internal static int __PropertyOffset_39;

		// Token: 0x04014793 RID: 83859
		internal static int __PropertyOffset_40;

		// Token: 0x04014794 RID: 83860
		internal static int __PropertyOffset_41;

		// Token: 0x04014795 RID: 83861
		internal static int __PropertyOffset_42;

		// Token: 0x04014796 RID: 83862
		internal static int __PropertyOffset_43;

		// Token: 0x04014797 RID: 83863
		internal static int __PropertyOffset_44;

		// Token: 0x04014798 RID: 83864
		internal static int __PropertyOffset_45;

		// Token: 0x04014799 RID: 83865
		internal static int __PropertyOffset_46;

		// Token: 0x0401479A RID: 83866
		internal static int __PropertyOffset_47;

		// Token: 0x0401479B RID: 83867
		internal static int __PropertyOffset_48;

		// Token: 0x0401479C RID: 83868
		internal static int __PropertyOffset_49;

		// Token: 0x0401479D RID: 83869
		internal static int __PropertyOffset_50;

		// Token: 0x0401479E RID: 83870
		internal static int __PropertyOffset_51;

		// Token: 0x0401479F RID: 83871
		internal static int __PropertyOffset_52;

		// Token: 0x040147A0 RID: 83872
		internal static int __PropertyOffset_53;
	}
}
