using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x0200409B RID: 16539
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_BaseRole.ABP_BaseRole_C")]
	[UnrealStructLayout(189264, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 189260)]
	public class ABP_BaseRole_C : UKuroAnimInstanceRole, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602AA3E RID: 174654 RVA: 0x009E6A8D File Offset: 0x009E4C8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_BaseRole.ABP_BaseRole_C");
			}
			return ABP_BaseRole_C._ClassPtr;
		}

		// Token: 0x0602AA3F RID: 174655 RVA: 0x009E6AB4 File Offset: 0x009E4CB4
		public ABP_BaseRole_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AA40 RID: 174656 RVA: 0x009E6ADC File Offset: 0x009E4CDC
		[NullableContext(1)]
		public ABP_BaseRole_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068B9 RID: 26809
		// (get) Token: 0x0602AA41 RID: 174657 RVA: 0x009E6B0F File Offset: 0x009E4D0F
		// (set) Token: 0x0602AA42 RID: 174658 RVA: 0x009E6B23 File Offset: 0x009E4D23
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_C.__PropertyOffset_1460);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_C.__PropertyOffset_1460, value);
			}
		}

		// Token: 0x170068BA RID: 26810
		// (get) Token: 0x0602AA43 RID: 174659 RVA: 0x009E6B38 File Offset: 0x009E4D38
		// (set) Token: 0x0602AA44 RID: 174660 RVA: 0x009E6B48 File Offset: 0x009E4D48
		public unsafe float 跳跃速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1461);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1461) = value;
			}
		}

		// Token: 0x170068BB RID: 26811
		// (get) Token: 0x0602AA45 RID: 174661 RVA: 0x009E6B59 File Offset: 0x009E4D59
		// (set) Token: 0x0602AA46 RID: 174662 RVA: 0x009E6B6D File Offset: 0x009E4D6D
		public unsafe FVector 整体偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1462);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1462) = value;
			}
		}

		// Token: 0x170068BC RID: 26812
		// (get) Token: 0x0602AA47 RID: 174663 RVA: 0x009E6B82 File Offset: 0x009E4D82
		// (set) Token: 0x0602AA48 RID: 174664 RVA: 0x009E6B96 File Offset: 0x009E4D96
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_C.__PropertyOffset_1463);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_C.__PropertyOffset_1463, value);
			}
		}

		// Token: 0x170068BD RID: 26813
		// (get) Token: 0x0602AA49 RID: 174665 RVA: 0x009E6BAB File Offset: 0x009E4DAB
		// (set) Token: 0x0602AA4A RID: 174666 RVA: 0x009E6BBF File Offset: 0x009E4DBF
		public unsafe FVector 整体偏移_实际使用_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1464);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1464) = value;
			}
		}

		// Token: 0x170068BE RID: 26814
		// (get) Token: 0x0602AA4B RID: 174667 RVA: 0x009E6BD4 File Offset: 0x009E4DD4
		// (set) Token: 0x0602AA4C RID: 174668 RVA: 0x009E6BE4 File Offset: 0x009E4DE4
		public unsafe bool 是否眩晕
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1465) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1465) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068BF RID: 26815
		// (get) Token: 0x0602AA4D RID: 174669 RVA: 0x009E6BF5 File Offset: 0x009E4DF5
		// (set) Token: 0x0602AA4E RID: 174670 RVA: 0x009E6C05 File Offset: 0x009E4E05
		public unsafe bool 是否壁上跳跃
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1466) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1466) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068C0 RID: 26816
		// (get) Token: 0x0602AA4F RID: 174671 RVA: 0x009E6C18 File Offset: 0x009E4E18
		// (set) Token: 0x0602AA50 RID: 174672 RVA: 0x009E6C51 File Offset: 0x009E4E51
		[Nullable(1)]
		public FHitResult 左脚探测结果
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._左脚探测结果) == null)
				{
					result = (this._左脚探测结果 = new FHitResult(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1467, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1467, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170068C1 RID: 26817
		// (get) Token: 0x0602AA51 RID: 174673 RVA: 0x009E6C74 File Offset: 0x009E4E74
		// (set) Token: 0x0602AA52 RID: 174674 RVA: 0x009E6CAD File Offset: 0x009E4EAD
		[Nullable(1)]
		public FHitResult 右脚探测结果
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._右脚探测结果) == null)
				{
					result = (this._右脚探测结果 = new FHitResult(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1468, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1468, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170068C2 RID: 26818
		// (get) Token: 0x0602AA53 RID: 174675 RVA: 0x009E6CCE File Offset: 0x009E4ECE
		// (set) Token: 0x0602AA54 RID: 174676 RVA: 0x009E6CDE File Offset: 0x009E4EDE
		public unsafe bool 是否右手进入攀爬
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1469) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1469) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068C3 RID: 26819
		// (get) Token: 0x0602AA55 RID: 174677 RVA: 0x009E6CEF File Offset: 0x009E4EEF
		// (set) Token: 0x0602AA56 RID: 174678 RVA: 0x009E6CFF File Offset: 0x009E4EFF
		public unsafe bool FASLE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1470) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1470) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068C4 RID: 26820
		// (get) Token: 0x0602AA57 RID: 174679 RVA: 0x009E6D10 File Offset: 0x009E4F10
		// (set) Token: 0x0602AA58 RID: 174680 RVA: 0x009E6D20 File Offset: 0x009E4F20
		public unsafe float 钩索启动角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1471);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1471) = value;
			}
		}

		// Token: 0x170068C5 RID: 26821
		// (get) Token: 0x0602AA59 RID: 174681 RVA: 0x009E6D31 File Offset: 0x009E4F31
		// (set) Token: 0x0602AA5A RID: 174682 RVA: 0x009E6D41 File Offset: 0x009E4F41
		public unsafe byte 反斜登顶退出
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1472);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1472) = value;
			}
		}

		// Token: 0x170068C6 RID: 26822
		// (get) Token: 0x0602AA5B RID: 174683 RVA: 0x009E6D52 File Offset: 0x009E4F52
		// (set) Token: 0x0602AA5C RID: 174684 RVA: 0x009E6D62 File Offset: 0x009E4F62
		public unsafe float 巨物拉取角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1473);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1473) = value;
			}
		}

		// Token: 0x170068C7 RID: 26823
		// (get) Token: 0x0602AA5D RID: 174685 RVA: 0x009E6D73 File Offset: 0x009E4F73
		// (set) Token: 0x0602AA5E RID: 174686 RVA: 0x009E6D83 File Offset: 0x009E4F83
		public unsafe float 跳跃速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1474);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1474) = value;
			}
		}

		// Token: 0x170068C8 RID: 26824
		// (get) Token: 0x0602AA5F RID: 174687 RVA: 0x009E6D94 File Offset: 0x009E4F94
		// (set) Token: 0x0602AA60 RID: 174688 RVA: 0x009E6DCD File Offset: 0x009E4FCD
		[Nullable(1)]
		public FPoseSnapshot CachePose
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPoseSnapshot result;
				if ((result = this._CachePose) == null)
				{
					result = (this._CachePose = new FPoseSnapshot(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1475, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseSnapshot.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1475, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170068C9 RID: 26825
		// (get) Token: 0x0602AA61 RID: 174689 RVA: 0x009E6DEE File Offset: 0x009E4FEE
		// (set) Token: 0x0602AA62 RID: 174690 RVA: 0x009E6DFE File Offset: 0x009E4FFE
		public unsafe bool EnableSwitchPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1476) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1476) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068CA RID: 26826
		// (get) Token: 0x0602AA63 RID: 174691 RVA: 0x009E6E0F File Offset: 0x009E500F
		// (set) Token: 0x0602AA64 RID: 174692 RVA: 0x009E6E1F File Offset: 0x009E501F
		public unsafe float SwitchPoseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1477);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1477) = value;
			}
		}

		// Token: 0x170068CB RID: 26827
		// (get) Token: 0x0602AA65 RID: 174693 RVA: 0x009E6E30 File Offset: 0x009E5030
		// (set) Token: 0x0602AA66 RID: 174694 RVA: 0x009E6E40 File Offset: 0x009E5040
		public unsafe bool 状态_牵手_牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1478) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1478) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068CC RID: 26828
		// (get) Token: 0x0602AA67 RID: 174695 RVA: 0x009E6E51 File Offset: 0x009E5051
		// (set) Token: 0x0602AA68 RID: 174696 RVA: 0x009E6E61 File Offset: 0x009E5061
		public unsafe bool 状态_牵手_被牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1479) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1479) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068CD RID: 26829
		// (get) Token: 0x0602AA69 RID: 174697 RVA: 0x009E6E72 File Offset: 0x009E5072
		// (set) Token: 0x0602AA6A RID: 174698 RVA: 0x009E6E82 File Offset: 0x009E5082
		public unsafe bool 状态_牵手_范围内
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1480) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1480) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068CE RID: 26830
		// (get) Token: 0x0602AA6B RID: 174699 RVA: 0x009E6E93 File Offset: 0x009E5093
		// (set) Token: 0x0602AA6C RID: 174700 RVA: 0x009E6EA3 File Offset: 0x009E50A3
		public unsafe bool IsInPlotBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1481) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1481) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068CF RID: 26831
		// (get) Token: 0x0602AA6D RID: 174701 RVA: 0x009E6EB4 File Offset: 0x009E50B4
		// (set) Token: 0x0602AA6E RID: 174702 RVA: 0x009E6EC4 File Offset: 0x009E50C4
		public unsafe bool 状态_基础移动替换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1482) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1482) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068D0 RID: 26832
		// (get) Token: 0x0602AA6F RID: 174703 RVA: 0x009E6ED5 File Offset: 0x009E50D5
		// (set) Token: 0x0602AA70 RID: 174704 RVA: 0x009E6EE5 File Offset: 0x009E50E5
		public unsafe bool 状态_样条跑墙
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1483) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1483) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068D1 RID: 26833
		// (get) Token: 0x0602AA71 RID: 174705 RVA: 0x009E6EF6 File Offset: 0x009E50F6
		// (set) Token: 0x0602AA72 RID: 174706 RVA: 0x009E6F06 File Offset: 0x009E5106
		public unsafe bool 状态_上坡动画替换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1484) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1484) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068D2 RID: 26834
		// (get) Token: 0x0602AA73 RID: 174707 RVA: 0x009E6F17 File Offset: 0x009E5117
		// (set) Token: 0x0602AA74 RID: 174708 RVA: 0x009E6F27 File Offset: 0x009E5127
		public unsafe bool 状态_强制更新源姿势
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1485) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1485) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068D3 RID: 26835
		// (get) Token: 0x0602AA75 RID: 174709 RVA: 0x009E6F38 File Offset: 0x009E5138
		// (set) Token: 0x0602AA76 RID: 174710 RVA: 0x009E6F48 File Offset: 0x009E5148
		public unsafe bool 状态_强制关闭IK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1486) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1486) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068D4 RID: 26836
		// (get) Token: 0x0602AA77 RID: 174711 RVA: 0x009E6F59 File Offset: 0x009E5159
		// (set) Token: 0x0602AA78 RID: 174712 RVA: 0x009E6F69 File Offset: 0x009E5169
		public unsafe float SightLockYawMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1487);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1487) = value;
			}
		}

		// Token: 0x170068D5 RID: 26837
		// (get) Token: 0x0602AA79 RID: 174713 RVA: 0x009E6F7A File Offset: 0x009E517A
		// (set) Token: 0x0602AA7A RID: 174714 RVA: 0x009E6F8A File Offset: 0x009E518A
		public unsafe float SightLockYawMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1488);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1488) = value;
			}
		}

		// Token: 0x170068D6 RID: 26838
		// (get) Token: 0x0602AA7B RID: 174715 RVA: 0x009E6F9B File Offset: 0x009E519B
		// (set) Token: 0x0602AA7C RID: 174716 RVA: 0x009E6FAB File Offset: 0x009E51AB
		public unsafe float SightLockPitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1489);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1489) = value;
			}
		}

		// Token: 0x170068D7 RID: 26839
		// (get) Token: 0x0602AA7D RID: 174717 RVA: 0x009E6FBC File Offset: 0x009E51BC
		// (set) Token: 0x0602AA7E RID: 174718 RVA: 0x009E6FCC File Offset: 0x009E51CC
		public unsafe float SightLockPitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1490);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1490) = value;
			}
		}

		// Token: 0x170068D8 RID: 26840
		// (get) Token: 0x0602AA7F RID: 174719 RVA: 0x009E6FDD File Offset: 0x009E51DD
		// (set) Token: 0x0602AA80 RID: 174720 RVA: 0x009E6FED File Offset: 0x009E51ED
		public unsafe float SightLockAssitLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1491);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1491) = value;
			}
		}

		// Token: 0x170068D9 RID: 26841
		// (get) Token: 0x0602AA81 RID: 174721 RVA: 0x009E6FFE File Offset: 0x009E51FE
		// (set) Token: 0x0602AA82 RID: 174722 RVA: 0x009E700E File Offset: 0x009E520E
		public unsafe bool 状态_关闭FB受击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1492) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1492) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068DA RID: 26842
		// (get) Token: 0x0602AA83 RID: 174723 RVA: 0x009E701F File Offset: 0x009E521F
		// (set) Token: 0x0602AA84 RID: 174724 RVA: 0x009E702F File Offset: 0x009E522F
		public unsafe float 普通运动转基础移动BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1493);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1493) = value;
			}
		}

		// Token: 0x170068DB RID: 26843
		// (get) Token: 0x0602AA85 RID: 174725 RVA: 0x009E7040 File Offset: 0x009E5240
		// (set) Token: 0x0602AA86 RID: 174726 RVA: 0x009E7050 File Offset: 0x009E5250
		public unsafe float 基础移动转普通运动BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1494);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1494) = value;
			}
		}

		// Token: 0x170068DC RID: 26844
		// (get) Token: 0x0602AA87 RID: 174727 RVA: 0x009E7061 File Offset: 0x009E5261
		// (set) Token: 0x0602AA88 RID: 174728 RVA: 0x009E7075 File Offset: 0x009E5275
		public unsafe FVector SightDirectInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1495);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1495) = value;
			}
		}

		// Token: 0x170068DD RID: 26845
		// (get) Token: 0x0602AA89 RID: 174729 RVA: 0x009E708A File Offset: 0x009E528A
		// (set) Token: 0x0602AA8A RID: 174730 RVA: 0x009E709E File Offset: 0x009E529E
		public unsafe FVector UpAxisInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1496);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_1496) = value;
			}
		}

		// Token: 0x0602AA8B RID: 174731 RVA: 0x009E70B4 File Offset: 0x009E52B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_BaseRole_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x0602AA8C RID: 174732 RVA: 0x009E7104 File Offset: 0x009E5304
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 修型层(FPoseLink InPose_0, ref FPoseLink 修型层)
		{
			ABP_BaseRole_C.__修型层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__修型层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseRole_C.__修型层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__修型层_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose_0 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose_0, InPose_0.NativePtr, 1, false);
			}
			if (修型层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->修型层, 修型层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__修型层_NativeFunctionPtr, (void*)ptr);
			if (修型层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 修型层.NativePtr, &ptr->修型层, 1, false);
			}
		}

		// Token: 0x0602AA8D RID: 174733 RVA: 0x009E71B0 File Offset: 0x009E53B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 演出层(FPoseLink InPose, ref FPoseLink 演出层)
		{
			ABP_BaseRole_C.__演出层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__演出层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseRole_C.__演出层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__演出层_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose, InPose.NativePtr, 1, false);
			}
			if (演出层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->演出层, 演出层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__演出层_NativeFunctionPtr, (void*)ptr);
			if (演出层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 演出层.NativePtr, &ptr->演出层, 1, false);
			}
		}

		// Token: 0x0602AA8E RID: 174734 RVA: 0x009E725C File Offset: 0x009E545C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 地面站立循环混合层2(FPoseLink 前_走跑, FPoseLink 后_走跑, FPoseLink 左前_走跑, FPoseLink 右前_走跑, FPoseLink 左后_走跑, FPoseLink 右后_走跑, FPoseLink 前_冲刺, ref FPoseLink 地面站立循环混合层2)
		{
			ABP_BaseRole_C.__地面站立循环混合层2_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__地面站立循环混合层2_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(ABP_BaseRole_C.__地面站立循环混合层2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__地面站立循环混合层2_NativeFunctionPtr, (void*)ptr, 1);
			if (前_走跑 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->前_走跑, 前_走跑.NativePtr, 1, false);
			}
			if (后_走跑 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->后_走跑, 后_走跑.NativePtr, 1, false);
			}
			if (左前_走跑 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->左前_走跑, 左前_走跑.NativePtr, 1, false);
			}
			if (右前_走跑 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->右前_走跑, 右前_走跑.NativePtr, 1, false);
			}
			if (左后_走跑 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->左后_走跑, 左后_走跑.NativePtr, 1, false);
			}
			if (右后_走跑 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->右后_走跑, 右后_走跑.NativePtr, 1, false);
			}
			if (前_冲刺 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->前_冲刺, 前_冲刺.NativePtr, 1, false);
			}
			if (地面站立循环混合层2 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->地面站立循环混合层2, 地面站立循环混合层2.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__地面站立循环混合层2_NativeFunctionPtr, (void*)ptr);
			if (地面站立循环混合层2 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 地面站立循环混合层2.NativePtr, &ptr->地面站立循环混合层2, 1, false);
			}
		}

		// Token: 0x0602AA8F RID: 174735 RVA: 0x009E73E0 File Offset: 0x009E55E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 空中射击层(FPoseLink 空中瞄准, FPoseLink 空中射击, FPoseLink 空中射击BasePose, ref FPoseLink 空中射击层)
		{
			ABP_BaseRole_C.__空中射击层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__空中射击层_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(ABP_BaseRole_C.__空中射击层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__空中射击层_NativeFunctionPtr, (void*)ptr, 1);
			if (空中瞄准 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->空中瞄准, 空中瞄准.NativePtr, 1, false);
			}
			if (空中射击 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->空中射击, 空中射击.NativePtr, 1, false);
			}
			if (空中射击BasePose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->空中射击BasePose, 空中射击BasePose.NativePtr, 1, false);
			}
			if (空中射击层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->空中射击层, 空中射击层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__空中射击层_NativeFunctionPtr, (void*)ptr);
			if (空中射击层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 空中射击层.NativePtr, &ptr->空中射击层, 1, false);
			}
		}

		// Token: 0x0602AA90 RID: 174736 RVA: 0x009E74D4 File Offset: 0x009E56D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 后处理层(FPoseLink InPose_0, ref FPoseLink 后处理层)
		{
			ABP_BaseRole_C.__后处理层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__后处理层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseRole_C.__后处理层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__后处理层_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose_0 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose_0, InPose_0.NativePtr, 1, false);
			}
			if (后处理层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->后处理层, 后处理层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__后处理层_NativeFunctionPtr, (void*)ptr);
			if (后处理层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 后处理层.NativePtr, &ptr->后处理层, 1, false);
			}
		}

		// Token: 0x0602AA91 RID: 174737 RVA: 0x009E7580 File Offset: 0x009E5780
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 地面站立循环混合层(FPoseLink 前, FPoseLink 后, FPoseLink 左前, FPoseLink 左后, FPoseLink 右前, FPoseLink 右后, FPoseLink 冲刺, ref FPoseLink 地面站立循环混合层)
		{
			ABP_BaseRole_C.__地面站立循环混合层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__地面站立循环混合层_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(ABP_BaseRole_C.__地面站立循环混合层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__地面站立循环混合层_NativeFunctionPtr, (void*)ptr, 1);
			if (前 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->前, 前.NativePtr, 1, false);
			}
			if (后 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->后, 后.NativePtr, 1, false);
			}
			if (左前 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->左前, 左前.NativePtr, 1, false);
			}
			if (左后 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->左后, 左后.NativePtr, 1, false);
			}
			if (右前 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->右前, 右前.NativePtr, 1, false);
			}
			if (右后 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->右后, 右后.NativePtr, 1, false);
			}
			if (冲刺 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->冲刺, 冲刺.NativePtr, 1, false);
			}
			if (地面站立循环混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->地面站立循环混合层, 地面站立循环混合层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__地面站立循环混合层_NativeFunctionPtr, (void*)ptr);
			if (地面站立循环混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 地面站立循环混合层.NativePtr, &ptr->地面站立循环混合层, 1, false);
			}
		}

		// Token: 0x0602AA92 RID: 174738 RVA: 0x009E7704 File Offset: 0x009E5904
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 骨骼混合叠加层(FPoseLink BaseLayer, FPoseLink OverlayLayer, FPoseLink BasePose, ref FPoseLink 骨骼混合叠加层)
		{
			ABP_BaseRole_C.__骨骼混合叠加层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__骨骼混合叠加层_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(ABP_BaseRole_C.__骨骼混合叠加层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__骨骼混合叠加层_NativeFunctionPtr, (void*)ptr, 1);
			if (BaseLayer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->BaseLayer, BaseLayer.NativePtr, 1, false);
			}
			if (OverlayLayer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->OverlayLayer, OverlayLayer.NativePtr, 1, false);
			}
			if (BasePose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->BasePose, BasePose.NativePtr, 1, false);
			}
			if (骨骼混合叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->骨骼混合叠加层, 骨骼混合叠加层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__骨骼混合叠加层_NativeFunctionPtr, (void*)ptr);
			if (骨骼混合叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 骨骼混合叠加层.NativePtr, &ptr->骨骼混合叠加层, 1, false);
			}
		}

		// Token: 0x0602AA93 RID: 174739 RVA: 0x009E77F8 File Offset: 0x009E59F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 混合层(FPoseLink 基础层输入, FPoseLink 叠加层输入, FPoseLink 手臂叠加层输入, FPoseLink 姿势层输入, FPoseLink 地区运动状态, ref FPoseLink 混合层)
		{
			ABP_BaseRole_C.__混合层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__混合层_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(ABP_BaseRole_C.__混合层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__混合层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层输入, 基础层输入.NativePtr, 1, false);
			}
			if (叠加层输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->叠加层输入, 叠加层输入.NativePtr, 1, false);
			}
			if (手臂叠加层输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->手臂叠加层输入, 手臂叠加层输入.NativePtr, 1, false);
			}
			if (姿势层输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->姿势层输入, 姿势层输入.NativePtr, 1, false);
			}
			if (地区运动状态 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->地区运动状态, 地区运动状态.NativePtr, 1, false);
			}
			if (混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->混合层, 混合层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__混合层_NativeFunctionPtr, (void*)ptr);
			if (混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 混合层.NativePtr, &ptr->混合层, 1, false);
			}
		}

		// Token: 0x0602AA94 RID: 174740 RVA: 0x009E7934 File Offset: 0x009E5B34
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础姿势层(ref FPoseLink 基础姿势层)
		{
			ABP_BaseRole_C.__基础姿势层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__基础姿势层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_C.__基础姿势层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__基础姿势层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础姿势层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础姿势层, 基础姿势层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__基础姿势层_NativeFunctionPtr, (void*)ptr);
			if (基础姿势层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础姿势层.NativePtr, &ptr->基础姿势层, 1, false);
			}
		}

		// Token: 0x0602AA95 RID: 174741 RVA: 0x009E79BC File Offset: 0x009E5BBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 手臂叠加层(ref FPoseLink 手臂叠加层)
		{
			ABP_BaseRole_C.__手臂叠加层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__手臂叠加层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_C.__手臂叠加层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__手臂叠加层_NativeFunctionPtr, (void*)ptr, 1);
			if (手臂叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->手臂叠加层, 手臂叠加层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__手臂叠加层_NativeFunctionPtr, (void*)ptr);
			if (手臂叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 手臂叠加层.NativePtr, &ptr->手臂叠加层, 1, false);
			}
		}

		// Token: 0x0602AA96 RID: 174742 RVA: 0x009E7A44 File Offset: 0x009E5C44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 叠加层(FPoseLink 角色特定动作, ref FPoseLink 叠加层)
		{
			ABP_BaseRole_C.__叠加层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__叠加层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseRole_C.__叠加层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__叠加层_NativeFunctionPtr, (void*)ptr, 1);
			if (角色特定动作 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->角色特定动作, 角色特定动作.NativePtr, 1, false);
			}
			if (叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->叠加层, 叠加层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__叠加层_NativeFunctionPtr, (void*)ptr);
			if (叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 叠加层.NativePtr, &ptr->叠加层, 1, false);
			}
		}

		// Token: 0x0602AA97 RID: 174743 RVA: 0x009E7AF0 File Offset: 0x009E5CF0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(FPoseLink 替换基础移动, ref FPoseLink 基础层)
		{
			ABP_BaseRole_C.__基础层_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__基础层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseRole_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (替换基础移动 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->替换基础移动, 替换基础移动.NativePtr, 1, false);
			}
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602AA98 RID: 174744 RVA: 0x009E7B9C File Offset: 0x009E5D9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(FPoseLink SpeicalPose, FPoseLink 替换基础移动Pose, FPoseLink 地区运动模式, ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__AnimGraph_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(ABP_BaseRole_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (SpeicalPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->SpeicalPose, SpeicalPose.NativePtr, 1, false);
			}
			if (替换基础移动Pose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->替换基础移动Pose, 替换基础移动Pose.NativePtr, 1, false);
			}
			if (地区运动模式 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->地区运动模式, 地区运动模式.NativePtr, 1, false);
			}
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AA99 RID: 174745 RVA: 0x009E7C8D File Offset: 0x009E5E8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新载具信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__更新载具信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA9A RID: 174746 RVA: 0x009E7CA1 File Offset: 0x009E5EA1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 风筝移动更新()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__风筝移动更新_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA9B RID: 174747 RVA: 0x009E7CB5 File Offset: 0x009E5EB5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 移动平台和上坡IK削弱()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__移动平台和上坡IK削弱_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA9C RID: 174748 RVA: 0x009E7CC9 File Offset: 0x009E5EC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 落地速度切割初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__落地速度切割初始化_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA9D RID: 174749 RVA: 0x009E7CE0 File Offset: 0x009E5EE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void VelocityBlendLerp(FVeloctiyBlend From, FVeloctiyBlend To, float Alpha, ref FVeloctiyBlend Out)
		{
			ABP_BaseRole_C.__VelocityBlendLerp_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__VelocityBlendLerp_FunctionParams[(UIntPtr)99] + 15L / (long)sizeof(ABP_BaseRole_C.__VelocityBlendLerp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__VelocityBlendLerp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = From;
			ptr->To = To;
			ptr->Alpha = Alpha;
			ptr->Out = Out;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__VelocityBlendLerp_NativeFunctionPtr, (void*)ptr);
			Out = ptr->Out;
		}

		// Token: 0x0602AA9E RID: 174750 RVA: 0x009E7D4E File Offset: 0x009E5F4E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void XA状态更新()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__XA状态更新_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA9F RID: 174751 RVA: 0x009E7D64 File Offset: 0x009E5F64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置跳跃速率(float 新速率)
		{
			ABP_BaseRole_C.__设置跳跃速率_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__设置跳跃速率_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__设置跳跃速率_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__设置跳跃速率_NativeFunctionPtr, (void*)ptr, 1);
			ptr->新速率 = 新速率;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__设置跳跃速率_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAA0 RID: 174752 RVA: 0x009E7DAA File Offset: 0x009E5FAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 冰冻结束事件()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__冰冻结束事件_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAA1 RID: 174753 RVA: 0x009E7DC0 File Offset: 0x009E5FC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 计算跳跃混合(float 速度, ref float 混合)
		{
			ABP_BaseRole_C.__计算跳跃混合_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__计算跳跃混合_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRole_C.__计算跳跃混合_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__计算跳跃混合_NativeFunctionPtr, (void*)ptr, 1);
			ptr->速度 = 速度;
			ptr->混合 = 混合;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__计算跳跃混合_NativeFunctionPtr, (void*)ptr);
			混合 = ptr->混合;
		}

		// Token: 0x0602AAA2 RID: 174754 RVA: 0x009E7E16 File Offset: 0x009E6016
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CleanAnimVariable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__CleanAnimVariable_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAA3 RID: 174755 RVA: 0x009E7E2C File Offset: 0x009E602C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void True布尔序列输出(ref TArray<bool> ValArrt_Bool, ref int Out)
		{
			ABP_BaseRole_C.__True布尔序列输出_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__True布尔序列输出_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ABP_BaseRole_C.__True布尔序列输出_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__True布尔序列输出_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = ValArrt_Bool;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ValArrt_Bool);
			}
			ptr->Out = Out;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__True布尔序列输出_NativeFunctionPtr, (void*)ptr);
			TArray<bool> tarray2 = ValArrt_Bool;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ValArrt_Bool);
			}
			Out = ptr->Out;
			UnrealReflectionUtils.DestroyStruct(ABP_BaseRole_C.__True布尔序列输出_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602AAA4 RID: 174756 RVA: 0x009E7EB4 File Offset: 0x009E60B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新上传()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__更新上传_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAA5 RID: 174757 RVA: 0x009E7EC8 File Offset: 0x009E60C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAA6 RID: 174758 RVA: 0x009E7EDC File Offset: 0x009E60DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 替换角色时同步动作数据(ABP_BaseRole_C 切出角色AnimIns)
		{
			ABP_BaseRole_C.__替换角色时同步动作数据_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__替换角色时同步动作数据_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRole_C.__替换角色时同步动作数据_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__替换角色时同步动作数据_NativeFunctionPtr, (void*)ptr, 1);
			ptr->切出角色AnimIns = ((切出角色AnimIns != null) ? 切出角色AnimIns.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__替换角色时同步动作数据_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAA7 RID: 174759 RVA: 0x009E7F34 File Offset: 0x009E6134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置头部转向状态(SightLockMode SightMode)
		{
			ABP_BaseRole_C.__设置头部转向状态_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__设置头部转向状态_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_BaseRole_C.__设置头部转向状态_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SightMode = SightMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAA8 RID: 174760 RVA: 0x009E7F7C File Offset: 0x009E617C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAA9 RID: 174761 RVA: 0x009E7FC4 File Offset: 0x009E61C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AAAA RID: 174762 RVA: 0x009E800B File Offset: 0x009E620B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TestFk()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__TestFk_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAAB RID: 174763 RVA: 0x009E8020 File Offset: 0x009E6220
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_BaseRole_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAAC RID: 174764 RVA: 0x009E8066 File Offset: 0x009E6266
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAAD RID: 174765 RVA: 0x009E807A File Offset: 0x009E627A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AAAE RID: 174766 RVA: 0x009E8090 File Offset: 0x009E6290
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 播放动画(SDynamicMontageParams 播放动画)
		{
			ABP_BaseRole_C.__播放动画_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__播放动画_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_C.__播放动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__播放动画_NativeFunctionPtr, (void*)ptr, 1);
			if (播放动画 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SDynamicMontageParams.StaticStruct(), &ptr->播放动画, 播放动画.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__播放动画_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAAF RID: 174767 RVA: 0x009E80F1 File Offset: 0x009E62F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAB0 RID: 174768 RVA: 0x009E8105 File Offset: 0x009E6305
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAB1 RID: 174769 RVA: 0x009E8119 File Offset: 0x009E6319
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AAB2 RID: 174770 RVA: 0x009E8130 File Offset: 0x009E6330
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_BaseRole_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAB3 RID: 174771 RVA: 0x009E8178 File Offset: 0x009E6378
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_BaseRole_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAB4 RID: 174772 RVA: 0x009E81BE File Offset: 0x009E63BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__ClearClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAB5 RID: 174773 RVA: 0x009E81D4 File Offset: 0x009E63D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_BaseRole_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAB6 RID: 174774 RVA: 0x009E821A File Offset: 0x009E641A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlotBlendIn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__PlotBlendIn_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAB7 RID: 174775 RVA: 0x009E822E File Offset: 0x009E642E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NoExpose()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__NoExpose_NativeFunctionPtr, null);
		}

		// Token: 0x0602AAB8 RID: 174776 RVA: 0x009E8244 File Offset: 0x009E6444
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetSightLockConfig(float YawMin, float YawMax, float PitchMin, float PitchMax, float AssitLimit, FVector SightDirectInSightBone, FVector UpAxisInSightBone)
		{
			ABP_BaseRole_C.__SetSightLockConfig_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__SetSightLockConfig_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(ABP_BaseRole_C.__SetSightLockConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__SetSightLockConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->YawMin = YawMin;
			ptr->YawMax = YawMax;
			ptr->PitchMin = PitchMin;
			ptr->PitchMax = PitchMax;
			ptr->AssitLimit = AssitLimit;
			ptr->SightDirectInSightBone = SightDirectInSightBone;
			ptr->UpAxisInSightBone = UpAxisInSightBone;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__SetSightLockConfig_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAB9 RID: 174777 RVA: 0x009E82B8 File Offset: 0x009E64B8
		protected ABP_BaseRole_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040160EB RID: 90347
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_BaseRole.ABP_BaseRole_C";

		// Token: 0x040160EC RID: 90348
		private static IntPtr _ClassPtr;

		// Token: 0x040160ED RID: 90349
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040160EE RID: 90350
		internal static int __PropertyOffset_1460;

		// Token: 0x040160EF RID: 90351
		internal static int __PropertyOffset_1461;

		// Token: 0x040160F0 RID: 90352
		internal static int __PropertyOffset_1462;

		// Token: 0x040160F1 RID: 90353
		internal static int __PropertyOffset_1463;

		// Token: 0x040160F2 RID: 90354
		internal static int __PropertyOffset_1464;

		// Token: 0x040160F3 RID: 90355
		internal static int __PropertyOffset_1465;

		// Token: 0x040160F4 RID: 90356
		internal static int __PropertyOffset_1466;

		// Token: 0x040160F5 RID: 90357
		internal static int __PropertyOffset_1467;

		// Token: 0x040160F6 RID: 90358
		[Nullable(2)]
		private FHitResult _左脚探测结果;

		// Token: 0x040160F7 RID: 90359
		internal static int __PropertyOffset_1468;

		// Token: 0x040160F8 RID: 90360
		[Nullable(2)]
		private FHitResult _右脚探测结果;

		// Token: 0x040160F9 RID: 90361
		internal static int __PropertyOffset_1469;

		// Token: 0x040160FA RID: 90362
		internal static int __PropertyOffset_1470;

		// Token: 0x040160FB RID: 90363
		internal static int __PropertyOffset_1471;

		// Token: 0x040160FC RID: 90364
		internal static int __PropertyOffset_1472;

		// Token: 0x040160FD RID: 90365
		internal static int __PropertyOffset_1473;

		// Token: 0x040160FE RID: 90366
		internal static int __PropertyOffset_1474;

		// Token: 0x040160FF RID: 90367
		internal static int __PropertyOffset_1475;

		// Token: 0x04016100 RID: 90368
		[Nullable(2)]
		private FPoseSnapshot _CachePose;

		// Token: 0x04016101 RID: 90369
		internal static int __PropertyOffset_1476;

		// Token: 0x04016102 RID: 90370
		internal static int __PropertyOffset_1477;

		// Token: 0x04016103 RID: 90371
		internal static int __PropertyOffset_1478;

		// Token: 0x04016104 RID: 90372
		internal static int __PropertyOffset_1479;

		// Token: 0x04016105 RID: 90373
		internal static int __PropertyOffset_1480;

		// Token: 0x04016106 RID: 90374
		internal static int __PropertyOffset_1481;

		// Token: 0x04016107 RID: 90375
		internal static int __PropertyOffset_1482;

		// Token: 0x04016108 RID: 90376
		internal static int __PropertyOffset_1483;

		// Token: 0x04016109 RID: 90377
		internal static int __PropertyOffset_1484;

		// Token: 0x0401610A RID: 90378
		internal static int __PropertyOffset_1485;

		// Token: 0x0401610B RID: 90379
		internal static int __PropertyOffset_1486;

		// Token: 0x0401610C RID: 90380
		internal static int __PropertyOffset_1487;

		// Token: 0x0401610D RID: 90381
		internal static int __PropertyOffset_1488;

		// Token: 0x0401610E RID: 90382
		internal static int __PropertyOffset_1489;

		// Token: 0x0401610F RID: 90383
		internal static int __PropertyOffset_1490;

		// Token: 0x04016110 RID: 90384
		internal static int __PropertyOffset_1491;

		// Token: 0x04016111 RID: 90385
		internal static int __PropertyOffset_1492;

		// Token: 0x04016112 RID: 90386
		internal static int __PropertyOffset_1493;

		// Token: 0x04016113 RID: 90387
		internal static int __PropertyOffset_1494;

		// Token: 0x04016114 RID: 90388
		internal static int __PropertyOffset_1495;

		// Token: 0x04016115 RID: 90389
		internal static int __PropertyOffset_1496;

		// Token: 0x04016116 RID: 90390
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04016117 RID: 90391
		private static IntPtr __修型层_NativeFunctionPtr;

		// Token: 0x04016118 RID: 90392
		private static IntPtr __演出层_NativeFunctionPtr;

		// Token: 0x04016119 RID: 90393
		private static IntPtr __地面站立循环混合层2_NativeFunctionPtr;

		// Token: 0x0401611A RID: 90394
		private static IntPtr __空中射击层_NativeFunctionPtr;

		// Token: 0x0401611B RID: 90395
		private static IntPtr __后处理层_NativeFunctionPtr;

		// Token: 0x0401611C RID: 90396
		private static IntPtr __地面站立循环混合层_NativeFunctionPtr;

		// Token: 0x0401611D RID: 90397
		private static IntPtr __骨骼混合叠加层_NativeFunctionPtr;

		// Token: 0x0401611E RID: 90398
		private static IntPtr __混合层_NativeFunctionPtr;

		// Token: 0x0401611F RID: 90399
		private static IntPtr __基础姿势层_NativeFunctionPtr;

		// Token: 0x04016120 RID: 90400
		private static IntPtr __手臂叠加层_NativeFunctionPtr;

		// Token: 0x04016121 RID: 90401
		private static IntPtr __叠加层_NativeFunctionPtr;

		// Token: 0x04016122 RID: 90402
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016123 RID: 90403
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016124 RID: 90404
		private static IntPtr __更新载具信息_NativeFunctionPtr;

		// Token: 0x04016125 RID: 90405
		private static IntPtr __风筝移动更新_NativeFunctionPtr;

		// Token: 0x04016126 RID: 90406
		private static IntPtr __移动平台和上坡IK削弱_NativeFunctionPtr;

		// Token: 0x04016127 RID: 90407
		private static IntPtr __落地速度切割初始化_NativeFunctionPtr;

		// Token: 0x04016128 RID: 90408
		private static IntPtr __VelocityBlendLerp_NativeFunctionPtr;

		// Token: 0x04016129 RID: 90409
		private static IntPtr __XA状态更新_NativeFunctionPtr;

		// Token: 0x0401612A RID: 90410
		private static IntPtr __设置跳跃速率_NativeFunctionPtr;

		// Token: 0x0401612B RID: 90411
		private static IntPtr __冰冻结束事件_NativeFunctionPtr;

		// Token: 0x0401612C RID: 90412
		private static IntPtr __计算跳跃混合_NativeFunctionPtr;

		// Token: 0x0401612D RID: 90413
		private static IntPtr __CleanAnimVariable_NativeFunctionPtr;

		// Token: 0x0401612E RID: 90414
		private static IntPtr __True布尔序列输出_NativeFunctionPtr;

		// Token: 0x0401612F RID: 90415
		private static IntPtr __更新上传_NativeFunctionPtr;

		// Token: 0x04016130 RID: 90416
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x04016131 RID: 90417
		private static IntPtr __替换角色时同步动作数据_NativeFunctionPtr;

		// Token: 0x04016132 RID: 90418
		private static IntPtr __设置头部转向状态_NativeFunctionPtr;

		// Token: 0x04016133 RID: 90419
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016134 RID: 90420
		private static IntPtr __TestFk_NativeFunctionPtr;

		// Token: 0x04016135 RID: 90421
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04016136 RID: 90422
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016137 RID: 90423
		private static IntPtr __播放动画_NativeFunctionPtr;

		// Token: 0x04016138 RID: 90424
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04016139 RID: 90425
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x0401613A RID: 90426
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x0401613B RID: 90427
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x0401613C RID: 90428
		private static IntPtr __ClearClimbDash_NativeFunctionPtr;

		// Token: 0x0401613D RID: 90429
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x0401613E RID: 90430
		private static IntPtr __PlotBlendIn_NativeFunctionPtr;

		// Token: 0x0401613F RID: 90431
		private static IntPtr __NoExpose_NativeFunctionPtr;

		// Token: 0x04016140 RID: 90432
		private static IntPtr __SetSightLockConfig_NativeFunctionPtr;

		// Token: 0x0200A3E6 RID: 41958
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x040321EA RID: 205290
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A3E7 RID: 41959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __修型层_FunctionParams
		{
			// Token: 0x040321EB RID: 205291
			[FieldOffset(0)]
			public byte InPose_0;

			// Token: 0x040321EC RID: 205292
			[FieldOffset(24)]
			public byte 修型层;
		}

		// Token: 0x0200A3E8 RID: 41960
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __演出层_FunctionParams
		{
			// Token: 0x040321ED RID: 205293
			[FieldOffset(0)]
			public byte InPose;

			// Token: 0x040321EE RID: 205294
			[FieldOffset(24)]
			public byte 演出层;
		}

		// Token: 0x0200A3E9 RID: 41961
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __地面站立循环混合层2_FunctionParams
		{
			// Token: 0x040321EF RID: 205295
			[FieldOffset(0)]
			public byte 前_走跑;

			// Token: 0x040321F0 RID: 205296
			[FieldOffset(24)]
			public byte 后_走跑;

			// Token: 0x040321F1 RID: 205297
			[FieldOffset(48)]
			public byte 左前_走跑;

			// Token: 0x040321F2 RID: 205298
			[FieldOffset(72)]
			public byte 右前_走跑;

			// Token: 0x040321F3 RID: 205299
			[FieldOffset(96)]
			public byte 左后_走跑;

			// Token: 0x040321F4 RID: 205300
			[FieldOffset(120)]
			public byte 右后_走跑;

			// Token: 0x040321F5 RID: 205301
			[FieldOffset(144)]
			public byte 前_冲刺;

			// Token: 0x040321F6 RID: 205302
			[FieldOffset(168)]
			public byte 地面站立循环混合层2;
		}

		// Token: 0x0200A3EA RID: 41962
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __空中射击层_FunctionParams
		{
			// Token: 0x040321F7 RID: 205303
			[FieldOffset(0)]
			public byte 空中瞄准;

			// Token: 0x040321F8 RID: 205304
			[FieldOffset(24)]
			public byte 空中射击;

			// Token: 0x040321F9 RID: 205305
			[FieldOffset(48)]
			public byte 空中射击BasePose;

			// Token: 0x040321FA RID: 205306
			[FieldOffset(72)]
			public byte 空中射击层;
		}

		// Token: 0x0200A3EB RID: 41963
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __后处理层_FunctionParams
		{
			// Token: 0x040321FB RID: 205307
			[FieldOffset(0)]
			public byte InPose_0;

			// Token: 0x040321FC RID: 205308
			[FieldOffset(24)]
			public byte 后处理层;
		}

		// Token: 0x0200A3EC RID: 41964
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __地面站立循环混合层_FunctionParams
		{
			// Token: 0x040321FD RID: 205309
			[FieldOffset(0)]
			public byte 前;

			// Token: 0x040321FE RID: 205310
			[FieldOffset(24)]
			public byte 后;

			// Token: 0x040321FF RID: 205311
			[FieldOffset(48)]
			public byte 左前;

			// Token: 0x04032200 RID: 205312
			[FieldOffset(72)]
			public byte 左后;

			// Token: 0x04032201 RID: 205313
			[FieldOffset(96)]
			public byte 右前;

			// Token: 0x04032202 RID: 205314
			[FieldOffset(120)]
			public byte 右后;

			// Token: 0x04032203 RID: 205315
			[FieldOffset(144)]
			public byte 冲刺;

			// Token: 0x04032204 RID: 205316
			[FieldOffset(168)]
			public byte 地面站立循环混合层;
		}

		// Token: 0x0200A3ED RID: 41965
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __骨骼混合叠加层_FunctionParams
		{
			// Token: 0x04032205 RID: 205317
			[FieldOffset(0)]
			public byte BaseLayer;

			// Token: 0x04032206 RID: 205318
			[FieldOffset(24)]
			public byte OverlayLayer;

			// Token: 0x04032207 RID: 205319
			[FieldOffset(48)]
			public byte BasePose;

			// Token: 0x04032208 RID: 205320
			[FieldOffset(72)]
			public byte 骨骼混合叠加层;
		}

		// Token: 0x0200A3EE RID: 41966
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __混合层_FunctionParams
		{
			// Token: 0x04032209 RID: 205321
			[FieldOffset(0)]
			public byte 基础层输入;

			// Token: 0x0403220A RID: 205322
			[FieldOffset(24)]
			public byte 叠加层输入;

			// Token: 0x0403220B RID: 205323
			[FieldOffset(48)]
			public byte 手臂叠加层输入;

			// Token: 0x0403220C RID: 205324
			[FieldOffset(72)]
			public byte 姿势层输入;

			// Token: 0x0403220D RID: 205325
			[FieldOffset(96)]
			public byte 地区运动状态;

			// Token: 0x0403220E RID: 205326
			[FieldOffset(120)]
			public byte 混合层;
		}

		// Token: 0x0200A3EF RID: 41967
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础姿势层_FunctionParams
		{
			// Token: 0x0403220F RID: 205327
			[FieldOffset(0)]
			public byte 基础姿势层;
		}

		// Token: 0x0200A3F0 RID: 41968
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __手臂叠加层_FunctionParams
		{
			// Token: 0x04032210 RID: 205328
			[FieldOffset(0)]
			public byte 手臂叠加层;
		}

		// Token: 0x0200A3F1 RID: 41969
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __叠加层_FunctionParams
		{
			// Token: 0x04032211 RID: 205329
			[FieldOffset(0)]
			public byte 角色特定动作;

			// Token: 0x04032212 RID: 205330
			[FieldOffset(24)]
			public byte 叠加层;
		}

		// Token: 0x0200A3F2 RID: 41970
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x04032213 RID: 205331
			[FieldOffset(0)]
			public byte 替换基础移动;

			// Token: 0x04032214 RID: 205332
			[FieldOffset(24)]
			public byte 基础层;
		}

		// Token: 0x0200A3F3 RID: 41971
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032215 RID: 205333
			[FieldOffset(0)]
			public byte SpeicalPose;

			// Token: 0x04032216 RID: 205334
			[FieldOffset(24)]
			public byte 替换基础移动Pose;

			// Token: 0x04032217 RID: 205335
			[FieldOffset(48)]
			public byte 地区运动模式;

			// Token: 0x04032218 RID: 205336
			[FieldOffset(72)]
			public byte AnimGraph;
		}

		// Token: 0x0200A3F4 RID: 41972
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 84)]
		protected ref struct __VelocityBlendLerp_FunctionParams
		{
			// Token: 0x04032219 RID: 205337
			[FieldOffset(0)]
			public FVeloctiyBlend From;

			// Token: 0x0403221A RID: 205338
			[FieldOffset(16)]
			public FVeloctiyBlend To;

			// Token: 0x0403221B RID: 205339
			[FieldOffset(32)]
			public float Alpha;

			// Token: 0x0403221C RID: 205340
			[FieldOffset(36)]
			public FVeloctiyBlend Out;
		}

		// Token: 0x0200A3F5 RID: 41973
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __设置跳跃速率_FunctionParams
		{
			// Token: 0x0403221D RID: 205341
			[FieldOffset(0)]
			public float 新速率;
		}

		// Token: 0x0200A3F6 RID: 41974
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __计算跳跃混合_FunctionParams
		{
			// Token: 0x0403221E RID: 205342
			[FieldOffset(0)]
			public float 速度;

			// Token: 0x0403221F RID: 205343
			[FieldOffset(4)]
			public float 混合;
		}

		// Token: 0x0200A3F7 RID: 41975
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __True布尔序列输出_FunctionParams
		{
			// Token: 0x04032220 RID: 205344
			[FieldOffset(0)]
			public byte ValArrt_Bool;

			// Token: 0x04032221 RID: 205345
			[FieldOffset(16)]
			public int Out;
		}

		// Token: 0x0200A3F8 RID: 41976
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __替换角色时同步动作数据_FunctionParams
		{
			// Token: 0x04032222 RID: 205346
			[FieldOffset(0)]
			public IntPtr 切出角色AnimIns;
		}

		// Token: 0x0200A3F9 RID: 41977
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __设置头部转向状态_FunctionParams
		{
			// Token: 0x04032223 RID: 205347
			[FieldOffset(0)]
			public SightLockMode SightMode;
		}

		// Token: 0x0200A3FA RID: 41978
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032224 RID: 205348
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x0200A3FB RID: 41979
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x04032225 RID: 205349
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A3FC RID: 41980
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __播放动画_FunctionParams
		{
			// Token: 0x04032226 RID: 205350
			[FieldOffset(0)]
			public byte 播放动画;
		}

		// Token: 0x0200A3FD RID: 41981
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x04032227 RID: 205351
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A3FE RID: 41982
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x04032228 RID: 205352
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A3FF RID: 41983
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x04032229 RID: 205353
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x0200A400 RID: 41984
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __SetSightLockConfig_FunctionParams
		{
			// Token: 0x0403222A RID: 205354
			[FieldOffset(0)]
			public float YawMin;

			// Token: 0x0403222B RID: 205355
			[FieldOffset(4)]
			public float YawMax;

			// Token: 0x0403222C RID: 205356
			[FieldOffset(8)]
			public float PitchMin;

			// Token: 0x0403222D RID: 205357
			[FieldOffset(12)]
			public float PitchMax;

			// Token: 0x0403222E RID: 205358
			[FieldOffset(16)]
			public float AssitLimit;

			// Token: 0x0403222F RID: 205359
			[FieldOffset(20)]
			public FVector SightDirectInSightBone;

			// Token: 0x04032230 RID: 205360
			[FieldOffset(32)]
			public FVector UpAxisInSightBone;
		}
	}
}
