using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.AI.AIFunctionCommon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.RoleNPC
{
	// Token: 0x020032B1 RID: 12977
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/RoleNPC/ABP_BaseRoleNPC.ABP_BaseRoleNPC_C")]
	[UnrealStructLayout(56720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56716)]
	public class ABP_BaseRoleNPC_C : UKuroAnimInstanceChar, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A99 RID: 133785 RVA: 0x0094C3D3 File Offset: 0x0094A5D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRoleNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/RoleNPC/ABP_BaseRoleNPC.ABP_BaseRoleNPC_C");
			}
			return ABP_BaseRoleNPC_C._ClassPtr;
		}

		// Token: 0x06020A9A RID: 133786 RVA: 0x0094C3F8 File Offset: 0x0094A5F8
		public ABP_BaseRoleNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRoleNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A9B RID: 133787 RVA: 0x0094C420 File Offset: 0x0094A620
		[NullableContext(1)]
		public ABP_BaseRoleNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRoleNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x06020A9C RID: 133788 RVA: 0x0094C453 File Offset: 0x0094A653
		// (set) Token: 0x06020A9D RID: 133789 RVA: 0x0094C467 File Offset: 0x0094A667
		public unsafe TsBaseCharacter 角色蓝图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_角色蓝图);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x06020A9E RID: 133790 RVA: 0x0094C47C File Offset: 0x0094A67C
		// (set) Token: 0x06020A9F RID: 133791 RVA: 0x0094C48C File Offset: 0x0094A68C
		public unsafe float DeltaTimeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_DeltaTimeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_DeltaTimeX) = value;
			}
		}

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x06020AA0 RID: 133792 RVA: 0x0094C49D File Offset: 0x0094A69D
		// (set) Token: 0x06020AA1 RID: 133793 RVA: 0x0094C4B1 File Offset: 0x0094A6B1
		public unsafe FVector 速度向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_速度向量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_速度向量) = value;
			}
		}

		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x06020AA2 RID: 133794 RVA: 0x0094C4C6 File Offset: 0x0094A6C6
		// (set) Token: 0x06020AA3 RID: 133795 RVA: 0x0094C4DA File Offset: 0x0094A6DA
		public unsafe FVector 加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_加速度) = value;
			}
		}

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x06020AA4 RID: 133796 RVA: 0x0094C4EF File Offset: 0x0094A6EF
		// (set) Token: 0x06020AA5 RID: 133797 RVA: 0x0094C503 File Offset: 0x0094A703
		public unsafe FVector 移动输入向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_移动输入向量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_移动输入向量) = value;
			}
		}

		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x06020AA6 RID: 133798 RVA: 0x0094C518 File Offset: 0x0094A718
		// (set) Token: 0x06020AA7 RID: 133799 RVA: 0x0094C528 File Offset: 0x0094A728
		public unsafe bool 是否正在移动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否正在移动) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否正在移动) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x06020AA8 RID: 133800 RVA: 0x0094C539 File Offset: 0x0094A739
		// (set) Token: 0x06020AA9 RID: 133801 RVA: 0x0094C549 File Offset: 0x0094A749
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否有移动输入) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否有移动输入) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x06020AAA RID: 133802 RVA: 0x0094C55A File Offset: 0x0094A75A
		// (set) Token: 0x06020AAB RID: 133803 RVA: 0x0094C56A File Offset: 0x0094A76A
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_速度) = value;
			}
		}

		// Token: 0x1700405A RID: 16474
		// (get) Token: 0x06020AAC RID: 133804 RVA: 0x0094C57B File Offset: 0x0094A77B
		// (set) Token: 0x06020AAD RID: 133805 RVA: 0x0094C58F File Offset: 0x0094A78F
		public unsafe FRotator 瞄准旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_瞄准旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_瞄准旋转) = value;
			}
		}

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x06020AAE RID: 133806 RVA: 0x0094C5A4 File Offset: 0x0094A7A4
		// (set) Token: 0x06020AAF RID: 133807 RVA: 0x0094C5B4 File Offset: 0x0094A7B4
		public unsafe bool 是否将要移动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否将要移动) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否将要移动) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x06020AB0 RID: 133808 RVA: 0x0094C5C5 File Offset: 0x0094A7C5
		// (set) Token: 0x06020AB1 RID: 133809 RVA: 0x0094C5D5 File Offset: 0x0094A7D5
		public unsafe bool 正在旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_正在旋转) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_正在旋转) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x06020AB2 RID: 133810 RVA: 0x0094C5E6 File Offset: 0x0094A7E6
		// (set) Token: 0x06020AB3 RID: 133811 RVA: 0x0094C5F6 File Offset: 0x0094A7F6
		public unsafe float 旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_旋转速度) = value;
			}
		}

		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x06020AB4 RID: 133812 RVA: 0x0094C607 File Offset: 0x0094A807
		// (set) Token: 0x06020AB5 RID: 133813 RVA: 0x0094C617 File Offset: 0x0094A817
		public unsafe float 旋转混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_旋转混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_旋转混合) = value;
			}
		}

		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x06020AB6 RID: 133814 RVA: 0x0094C628 File Offset: 0x0094A828
		// (set) Token: 0x06020AB7 RID: 133815 RVA: 0x0094C63C File Offset: 0x0094A83C
		public unsafe FVeloctiyBlend 速度混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_速度混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_速度混合) = value;
			}
		}

		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x06020AB8 RID: 133816 RVA: 0x0094C651 File Offset: 0x0094A851
		// (set) Token: 0x06020AB9 RID: 133817 RVA: 0x0094C665 File Offset: 0x0094A865
		public unsafe FVector 相对加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_相对加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_相对加速度) = value;
			}
		}

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x06020ABA RID: 133818 RVA: 0x0094C67A File Offset: 0x0094A87A
		// (set) Token: 0x06020ABB RID: 133819 RVA: 0x0094C68A File Offset: 0x0094A88A
		public unsafe float 地上倾斜量平滑速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_地上倾斜量平滑速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_地上倾斜量平滑速度) = value;
			}
		}

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x06020ABC RID: 133820 RVA: 0x0094C69B File Offset: 0x0094A89B
		// (set) Token: 0x06020ABD RID: 133821 RVA: 0x0094C6AF File Offset: 0x0094A8AF
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovementDirection> 移动方向
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_移动方向);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_移动方向) = value;
			}
		}

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x06020ABE RID: 133822 RVA: 0x0094C6C4 File Offset: 0x0094A8C4
		// (set) Token: 0x06020ABF RID: 133823 RVA: 0x0094C6D4 File Offset: 0x0094A8D4
		public unsafe float 站立播放速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_站立播放速率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_站立播放速率) = value;
			}
		}

		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x06020AC0 RID: 133824 RVA: 0x0094C6E5 File Offset: 0x0094A8E5
		// (set) Token: 0x06020AC1 RID: 133825 RVA: 0x0094C6F5 File Offset: 0x0094A8F5
		public unsafe float 走跑混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_走跑混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_走跑混合) = value;
			}
		}

		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x06020AC2 RID: 133826 RVA: 0x0094C706 File Offset: 0x0094A906
		// (set) Token: 0x06020AC3 RID: 133827 RVA: 0x0094C71A File Offset: 0x0094A91A
		public unsafe UCurveFloat 站立走步幅混合曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_站立走步幅混合曲线);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_站立走步幅混合曲线, value);
			}
		}

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x06020AC4 RID: 133828 RVA: 0x0094C72F File Offset: 0x0094A92F
		// (set) Token: 0x06020AC5 RID: 133829 RVA: 0x0094C743 File Offset: 0x0094A943
		public unsafe UCurveFloat 站立跑步幅混合曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_站立跑步幅混合曲线);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_站立跑步幅混合曲线, value);
			}
		}

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x06020AC6 RID: 133830 RVA: 0x0094C758 File Offset: 0x0094A958
		// (set) Token: 0x06020AC7 RID: 133831 RVA: 0x0094C768 File Offset: 0x0094A968
		public unsafe float 步幅混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_步幅混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_步幅混合) = value;
			}
		}

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x06020AC8 RID: 133832 RVA: 0x0094C779 File Offset: 0x0094A979
		// (set) Token: 0x06020AC9 RID: 133833 RVA: 0x0094C789 File Offset: 0x0094A989
		public unsafe float 动画行走速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_动画行走速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_动画行走速度) = value;
			}
		}

		// Token: 0x17004069 RID: 16489
		// (get) Token: 0x06020ACA RID: 133834 RVA: 0x0094C79A File Offset: 0x0094A99A
		// (set) Token: 0x06020ACB RID: 133835 RVA: 0x0094C7AA File Offset: 0x0094A9AA
		public unsafe float 动画跑步速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_动画跑步速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_动画跑步速度) = value;
			}
		}

		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x06020ACC RID: 133836 RVA: 0x0094C7BB File Offset: 0x0094A9BB
		// (set) Token: 0x06020ACD RID: 133837 RVA: 0x0094C7CB File Offset: 0x0094A9CB
		public unsafe float 动画疾跑速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_动画疾跑速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_动画疾跑速度) = value;
			}
		}

		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x06020ACE RID: 133838 RVA: 0x0094C7DC File Offset: 0x0094A9DC
		// (set) Token: 0x06020ACF RID: 133839 RVA: 0x0094C7F0 File Offset: 0x0094A9F0
		public unsafe UCurveFloat RelativeSpeedBlendCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_RelativeSpeedBlendCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_RelativeSpeedBlendCurve, value);
			}
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x06020AD0 RID: 133840 RVA: 0x0094C805 File Offset: 0x0094AA05
		// (set) Token: 0x06020AD1 RID: 133841 RVA: 0x0094C819 File Offset: 0x0094AA19
		public unsafe FVector 整体偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_整体偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_整体偏移) = value;
			}
		}

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x06020AD2 RID: 133842 RVA: 0x0094C82E File Offset: 0x0094AA2E
		// (set) Token: 0x06020AD3 RID: 133843 RVA: 0x0094C842 File Offset: 0x0094AA42
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_角色Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_角色Mesh, value);
			}
		}

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x06020AD4 RID: 133844 RVA: 0x0094C857 File Offset: 0x0094AA57
		// (set) Token: 0x06020AD5 RID: 133845 RVA: 0x0094C86B File Offset: 0x0094AA6B
		public unsafe FVector 整体偏移_实际使用_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_整体偏移_实际使用_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_整体偏移_实际使用_) = value;
			}
		}

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x06020AD6 RID: 133846 RVA: 0x0094C880 File Offset: 0x0094AA80
		// (set) Token: 0x06020AD7 RID: 133847 RVA: 0x0094C894 File Offset: 0x0094AA94
		public unsafe FVector 上一帧模型位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_上一帧模型位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_上一帧模型位置) = value;
			}
		}

		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x06020AD8 RID: 133848 RVA: 0x0094C8A9 File Offset: 0x0094AAA9
		// (set) Token: 0x06020AD9 RID: 133849 RVA: 0x0094C8B9 File Offset: 0x0094AAB9
		public unsafe bool IsAutonomousProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_IsAutonomousProxy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_IsAutonomousProxy) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x06020ADA RID: 133850 RVA: 0x0094C8CA File Offset: 0x0094AACA
		// (set) Token: 0x06020ADB RID: 133851 RVA: 0x0094C8DA File Offset: 0x0094AADA
		public unsafe float 瞄准面向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_瞄准面向);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_瞄准面向) = value;
			}
		}

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x06020ADC RID: 133852 RVA: 0x0094C8EB File Offset: 0x0094AAEB
		// (set) Token: 0x06020ADD RID: 133853 RVA: 0x0094C8FB File Offset: 0x0094AAFB
		public unsafe float 瞄准仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_瞄准仰角);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_瞄准仰角) = value;
			}
		}

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x06020ADE RID: 133854 RVA: 0x0094C90C File Offset: 0x0094AB0C
		// (set) Token: 0x06020ADF RID: 133855 RVA: 0x0094C91C File Offset: 0x0094AB1C
		public unsafe float 当前坡度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_当前坡度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_当前坡度) = value;
			}
		}

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x06020AE0 RID: 133856 RVA: 0x0094C92D File Offset: 0x0094AB2D
		// (set) Token: 0x06020AE1 RID: 133857 RVA: 0x0094C93D File Offset: 0x0094AB3D
		public unsafe float 视线修正Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_视线修正Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_视线修正Alpha) = value;
			}
		}

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x06020AE2 RID: 133858 RVA: 0x0094C94E File Offset: 0x0094AB4E
		// (set) Token: 0x06020AE3 RID: 133859 RVA: 0x0094C962 File Offset: 0x0094AB62
		public unsafe FVector 看向位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_看向位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_看向位置) = value;
			}
		}

		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x06020AE4 RID: 133860 RVA: 0x0094C977 File Offset: 0x0094AB77
		// (set) Token: 0x06020AE5 RID: 133861 RVA: 0x0094C987 File Offset: 0x0094AB87
		public unsafe float CachePercent_LR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CachePercent_LR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CachePercent_LR) = value;
			}
		}

		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x06020AE6 RID: 133862 RVA: 0x0094C998 File Offset: 0x0094AB98
		// (set) Token: 0x06020AE7 RID: 133863 RVA: 0x0094C9A8 File Offset: 0x0094ABA8
		public unsafe float CachePercent_FB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CachePercent_FB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CachePercent_FB) = value;
			}
		}

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x06020AE8 RID: 133864 RVA: 0x0094C9B9 File Offset: 0x0094ABB9
		// (set) Token: 0x06020AE9 RID: 133865 RVA: 0x0094C9CD File Offset: 0x0094ABCD
		public unsafe FVector 角色向前向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_角色向前向量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_角色向前向量) = value;
			}
		}

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x06020AEA RID: 133866 RVA: 0x0094C9E2 File Offset: 0x0094ABE2
		// (set) Token: 0x06020AEB RID: 133867 RVA: 0x0094C9F6 File Offset: 0x0094ABF6
		public unsafe FVector 外部方向输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_外部方向输入);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_外部方向输入) = value;
			}
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x06020AEC RID: 133868 RVA: 0x0094CA0B File Offset: 0x0094AC0B
		// (set) Token: 0x06020AED RID: 133869 RVA: 0x0094CA1B File Offset: 0x0094AC1B
		public unsafe bool 是否需要原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否需要原地转身) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否需要原地转身) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x06020AEE RID: 133870 RVA: 0x0094CA2C File Offset: 0x0094AC2C
		// (set) Token: 0x06020AEF RID: 133871 RVA: 0x0094CA3C File Offset: 0x0094AC3C
		public unsafe bool 右转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_右转) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_右转) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x06020AF0 RID: 133872 RVA: 0x0094CA4D File Offset: 0x0094AC4D
		// (set) Token: 0x06020AF1 RID: 133873 RVA: 0x0094CA5D File Offset: 0x0094AC5D
		public unsafe bool 状态_跑停
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_跑停) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_跑停) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x06020AF2 RID: 133874 RVA: 0x0094CA6E File Offset: 0x0094AC6E
		// (set) Token: 0x06020AF3 RID: 133875 RVA: 0x0094CA7E File Offset: 0x0094AC7E
		public unsafe bool 状态_跑停_RunStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_跑停_RunStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_跑停_RunStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x06020AF4 RID: 133876 RVA: 0x0094CA8F File Offset: 0x0094AC8F
		// (set) Token: 0x06020AF5 RID: 133877 RVA: 0x0094CA9F File Offset: 0x0094AC9F
		public unsafe bool 状态_跑停_SprintStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_跑停_SprintStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_跑停_SprintStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x06020AF6 RID: 133878 RVA: 0x0094CAB0 File Offset: 0x0094ACB0
		// (set) Token: 0x06020AF7 RID: 133879 RVA: 0x0094CAC0 File Offset: 0x0094ACC0
		public unsafe bool 状态_跑停_WalkStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_跑停_WalkStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_跑停_WalkStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x06020AF8 RID: 133880 RVA: 0x0094CAD1 File Offset: 0x0094ACD1
		// (set) Token: 0x06020AF9 RID: 133881 RVA: 0x0094CAE1 File Offset: 0x0094ACE1
		public unsafe bool 状态_地面_Sprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_地面_Sprint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_地面_Sprint) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x06020AFA RID: 133882 RVA: 0x0094CAF2 File Offset: 0x0094ACF2
		// (set) Token: 0x06020AFB RID: 133883 RVA: 0x0094CB02 File Offset: 0x0094AD02
		public unsafe bool 状态_地面_Walk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_地面_Walk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_地面_Walk) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x06020AFC RID: 133884 RVA: 0x0094CB13 File Offset: 0x0094AD13
		// (set) Token: 0x06020AFD RID: 133885 RVA: 0x0094CB23 File Offset: 0x0094AD23
		public unsafe bool 状态_地面_Run
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_地面_Run) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_地面_Run) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004083 RID: 16515
		// (get) Token: 0x06020AFE RID: 133886 RVA: 0x0094CB34 File Offset: 0x0094AD34
		// (set) Token: 0x06020AFF RID: 133887 RVA: 0x0094CB44 File Offset: 0x0094AD44
		public unsafe bool 状态_牵手_牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_牵手_牵手中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_牵手_牵手中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x06020B00 RID: 133888 RVA: 0x0094CB55 File Offset: 0x0094AD55
		// (set) Token: 0x06020B01 RID: 133889 RVA: 0x0094CB65 File Offset: 0x0094AD65
		public unsafe bool 状态_牵手_被牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_牵手_被牵手中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_牵手_被牵手中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x06020B02 RID: 133890 RVA: 0x0094CB76 File Offset: 0x0094AD76
		// (set) Token: 0x06020B03 RID: 133891 RVA: 0x0094CB86 File Offset: 0x0094AD86
		public unsafe bool 状态_牵手_范围内
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_牵手_范围内) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_牵手_范围内) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x06020B04 RID: 133892 RVA: 0x0094CB97 File Offset: 0x0094AD97
		// (set) Token: 0x06020B05 RID: 133893 RVA: 0x0094CBA7 File Offset: 0x0094ADA7
		public unsafe bool 状态_牵手_接受邀请中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_牵手_接受邀请中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_牵手_接受邀请中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x06020B06 RID: 133894 RVA: 0x0094CBB8 File Offset: 0x0094ADB8
		// (set) Token: 0x06020B07 RID: 133895 RVA: 0x0094CBCC File Offset: 0x0094ADCC
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharState> CharMoveState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CharMoveState);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CharMoveState) = value;
			}
		}

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x06020B08 RID: 133896 RVA: 0x0094CBE1 File Offset: 0x0094ADE1
		// (set) Token: 0x06020B09 RID: 133897 RVA: 0x0094CBF1 File Offset: 0x0094ADF1
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_ExpresionAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_ExpresionAlpha) = value;
			}
		}

		// Token: 0x17004089 RID: 16521
		// (get) Token: 0x06020B0A RID: 133898 RVA: 0x0094CC02 File Offset: 0x0094AE02
		// (set) Token: 0x06020B0B RID: 133899 RVA: 0x0094CC12 File Offset: 0x0094AE12
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_RandomEpresionEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_RandomEpresionEndTime) = value;
			}
		}

		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x06020B0C RID: 133900 RVA: 0x0094CC23 File Offset: 0x0094AE23
		// (set) Token: 0x06020B0D RID: 133901 RVA: 0x0094CC33 File Offset: 0x0094AE33
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_眨眼动画时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_眨眼动画时长) = value;
			}
		}

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x06020B0E RID: 133902 RVA: 0x0094CC44 File Offset: 0x0094AE44
		// (set) Token: 0x06020B0F RID: 133903 RVA: 0x0094CC54 File Offset: 0x0094AE54
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_此轮眨眼动画总时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_此轮眨眼动画总时长) = value;
			}
		}

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x06020B10 RID: 133904 RVA: 0x0094CC65 File Offset: 0x0094AE65
		// (set) Token: 0x06020B11 RID: 133905 RVA: 0x0094CC79 File Offset: 0x0094AE79
		public unsafe FRotator 角色旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_角色旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_角色旋转) = value;
			}
		}

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x06020B12 RID: 133906 RVA: 0x0094CC8E File Offset: 0x0094AE8E
		// (set) Token: 0x06020B13 RID: 133907 RVA: 0x0094CC9E File Offset: 0x0094AE9E
		public unsafe float 原地旋转偏差角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_原地旋转偏差角);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_原地旋转偏差角) = value;
			}
		}

		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x06020B14 RID: 133908 RVA: 0x0094CCAF File Offset: 0x0094AEAF
		// (set) Token: 0x06020B15 RID: 133909 RVA: 0x0094CCBF File Offset: 0x0094AEBF
		public unsafe bool 移动时是否有阻挡
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_移动时是否有阻挡) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_移动时是否有阻挡) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x06020B16 RID: 133910 RVA: 0x0094CCD0 File Offset: 0x0094AED0
		// (set) Token: 0x06020B17 RID: 133911 RVA: 0x0094CCE0 File Offset: 0x0094AEE0
		public unsafe float TimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_TimeSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_TimeSeconds) = value;
			}
		}

		// Token: 0x17004090 RID: 16528
		// (get) Token: 0x06020B18 RID: 133912 RVA: 0x0094CCF1 File Offset: 0x0094AEF1
		// (set) Token: 0x06020B19 RID: 133913 RVA: 0x0094CD01 File Offset: 0x0094AF01
		public unsafe float InSequenceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_InSequenceAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_InSequenceAlpha) = value;
			}
		}

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x06020B1A RID: 133914 RVA: 0x0094CD12 File Offset: 0x0094AF12
		// (set) Token: 0x06020B1B RID: 133915 RVA: 0x0094CD26 File Offset: 0x0094AF26
		public unsafe FVector 缓存角色位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_缓存角色位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_缓存角色位置) = value;
			}
		}

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x06020B1C RID: 133916 RVA: 0x0094CD3B File Offset: 0x0094AF3B
		// (set) Token: 0x06020B1D RID: 133917 RVA: 0x0094CD4F File Offset: 0x0094AF4F
		public unsafe UCurveFloat AngelToStepLength
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_AngelToStepLength);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_AngelToStepLength, value);
			}
		}

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x06020B1E RID: 133918 RVA: 0x0094CD64 File Offset: 0x0094AF64
		// (set) Token: 0x06020B1F RID: 133919 RVA: 0x0094CD78 File Offset: 0x0094AF78
		public unsafe UCurveFloat Angle_to_Step_Frequency
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_Angle_to_Step_Frequency);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_Angle_to_Step_Frequency, value);
			}
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x06020B20 RID: 133920 RVA: 0x0094CD8D File Offset: 0x0094AF8D
		// (set) Token: 0x06020B21 RID: 133921 RVA: 0x0094CDA1 File Offset: 0x0094AFA1
		public unsafe FRotator 综合旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_综合旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_综合旋转) = value;
			}
		}

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x06020B22 RID: 133922 RVA: 0x0094CDB6 File Offset: 0x0094AFB6
		// (set) Token: 0x06020B23 RID: 133923 RVA: 0x0094CDCA File Offset: 0x0094AFCA
		public unsafe FVector 上一帧位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_上一帧位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_上一帧位置) = value;
			}
		}

		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x06020B24 RID: 133924 RVA: 0x0094CDDF File Offset: 0x0094AFDF
		// (set) Token: 0x06020B25 RID: 133925 RVA: 0x0094CDEF File Offset: 0x0094AFEF
		public unsafe float 角色位移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_角色位移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_角色位移) = value;
			}
		}

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x06020B26 RID: 133926 RVA: 0x0094CE00 File Offset: 0x0094B000
		// (set) Token: 0x06020B27 RID: 133927 RVA: 0x0094CE10 File Offset: 0x0094B010
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_眨眼中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_眨眼中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004098 RID: 16536
		// (get) Token: 0x06020B28 RID: 133928 RVA: 0x0094CE21 File Offset: 0x0094B021
		// (set) Token: 0x06020B29 RID: 133929 RVA: 0x0094CE31 File Offset: 0x0094B031
		public unsafe int 身高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_身高);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_身高) = value;
			}
		}

		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x06020B2A RID: 133930 RVA: 0x0094CE42 File Offset: 0x0094B042
		// (set) Token: 0x06020B2B RID: 133931 RVA: 0x0094CE52 File Offset: 0x0094B052
		public unsafe bool bComponentStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_bComponentStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_bComponentStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x06020B2C RID: 133932 RVA: 0x0094CE63 File Offset: 0x0094B063
		// (set) Token: 0x06020B2D RID: 133933 RVA: 0x0094CE77 File Offset: 0x0094B077
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharParentMoveState> CharPositionState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CharPositionState);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CharPositionState) = value;
			}
		}

		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x06020B2E RID: 133934 RVA: 0x0094CE8C File Offset: 0x0094B08C
		// (set) Token: 0x06020B2F RID: 133935 RVA: 0x0094CEA0 File Offset: 0x0094B0A0
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharViewDirectionState> CharCameraState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CharCameraState);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CharCameraState) = value;
			}
		}

		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x06020B30 RID: 133936 RVA: 0x0094CEB5 File Offset: 0x0094B0B5
		// (set) Token: 0x06020B31 RID: 133937 RVA: 0x0094CEC9 File Offset: 0x0094B0C9
		public unsafe BP_ABPLogicParams_C Ts逻辑变量集
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_ABPLogicParams_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_Ts逻辑变量集);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_Ts逻辑变量集, value);
			}
		}

		// Token: 0x1700409D RID: 16541
		// (get) Token: 0x06020B32 RID: 133938 RVA: 0x0094CEDE File Offset: 0x0094B0DE
		// (set) Token: 0x06020B33 RID: 133939 RVA: 0x0094CEEE File Offset: 0x0094B0EE
		public unsafe bool 不进行_IK_Lerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_不进行_IK_Lerp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_不进行_IK_Lerp) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x06020B34 RID: 133940 RVA: 0x0094CEFF File Offset: 0x0094B0FF
		// (set) Token: 0x06020B35 RID: 133941 RVA: 0x0094CF0F File Offset: 0x0094B10F
		public unsafe KuroHumanIKMode IK模式
		{
			get
			{
				return (KuroHumanIKMode)(*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_IK模式));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_IK模式) = (byte)value;
			}
		}

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x06020B36 RID: 133942 RVA: 0x0094CF20 File Offset: 0x0094B120
		// (set) Token: 0x06020B37 RID: 133943 RVA: 0x0094CF30 File Offset: 0x0094B130
		public unsafe bool 使用混合空间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_使用混合空间) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_使用混合空间) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x06020B38 RID: 133944 RVA: 0x0094CF41 File Offset: 0x0094B141
		// (set) Token: 0x06020B39 RID: 133945 RVA: 0x0094CF55 File Offset: 0x0094B155
		public unsafe FVector2D 看向角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_看向角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_看向角度) = value;
			}
		}

		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x06020B3A RID: 133946 RVA: 0x0094CF6A File Offset: 0x0094B16A
		// (set) Token: 0x06020B3B RID: 133947 RVA: 0x0094CF7E File Offset: 0x0094B17E
		public unsafe FVector4 VehicleCollisionMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleCollisionMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleCollisionMix) = value;
			}
		}

		// Token: 0x170040A2 RID: 16546
		// (get) Token: 0x06020B3C RID: 133948 RVA: 0x0094CF93 File Offset: 0x0094B193
		// (set) Token: 0x06020B3D RID: 133949 RVA: 0x0094CFA3 File Offset: 0x0094B1A3
		public unsafe bool IsVehicleImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_IsVehicleImpact) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_IsVehicleImpact) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x06020B3E RID: 133950 RVA: 0x0094CFB4 File Offset: 0x0094B1B4
		// (set) Token: 0x06020B3F RID: 133951 RVA: 0x0094CFC8 File Offset: 0x0094B1C8
		public unsafe FRotator VehicleSeatRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleSeatRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleSeatRot) = value;
			}
		}

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x06020B40 RID: 133952 RVA: 0x0094CFDD File Offset: 0x0094B1DD
		// (set) Token: 0x06020B41 RID: 133953 RVA: 0x0094CFED File Offset: 0x0094B1ED
		public unsafe float VehicleCollisionAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleCollisionAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleCollisionAngle) = value;
			}
		}

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x06020B42 RID: 133954 RVA: 0x0094CFFE File Offset: 0x0094B1FE
		// (set) Token: 0x06020B43 RID: 133955 RVA: 0x0094D00E File Offset: 0x0094B20E
		public unsafe float VehicleCollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleCollisionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleCollisionStrength) = value;
			}
		}

		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x06020B44 RID: 133956 RVA: 0x0094D01F File Offset: 0x0094B21F
		// (set) Token: 0x06020B45 RID: 133957 RVA: 0x0094D02F File Offset: 0x0094B22F
		public unsafe float VehicleCollisionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleCollisionAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleCollisionAlpha) = value;
			}
		}

		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x06020B46 RID: 133958 RVA: 0x0094D040 File Offset: 0x0094B240
		// (set) Token: 0x06020B47 RID: 133959 RVA: 0x0094D050 File Offset: 0x0094B250
		public unsafe bool SuddenMoveTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_SuddenMoveTrigger) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_SuddenMoveTrigger) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x06020B48 RID: 133960 RVA: 0x0094D061 File Offset: 0x0094B261
		// (set) Token: 0x06020B49 RID: 133961 RVA: 0x0094D075 File Offset: 0x0094B275
		public unsafe FVector4 VehicleSuddenMoveMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleSuddenMoveMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_VehicleSuddenMoveMix) = value;
			}
		}

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x06020B4A RID: 133962 RVA: 0x0094D08A File Offset: 0x0094B28A
		// (set) Token: 0x06020B4B RID: 133963 RVA: 0x0094D09A File Offset: 0x0094B29A
		public unsafe float CurForwardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CurForwardSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CurForwardSpeed) = value;
			}
		}

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x06020B4C RID: 133964 RVA: 0x0094D0AB File Offset: 0x0094B2AB
		// (set) Token: 0x06020B4D RID: 133965 RVA: 0x0094D0BB File Offset: 0x0094B2BB
		public unsafe float LastForwardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_LastForwardSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_LastForwardSpeed) = value;
			}
		}

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x06020B4E RID: 133966 RVA: 0x0094D0CC File Offset: 0x0094B2CC
		// (set) Token: 0x06020B4F RID: 133967 RVA: 0x0094D0DC File Offset: 0x0094B2DC
		public unsafe float CurSeatRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CurSeatRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_CurSeatRoll) = value;
			}
		}

		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x06020B50 RID: 133968 RVA: 0x0094D0ED File Offset: 0x0094B2ED
		// (set) Token: 0x06020B51 RID: 133969 RVA: 0x0094D0FD File Offset: 0x0094B2FD
		public unsafe float SuddenMoveCd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_SuddenMoveCd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_SuddenMoveCd) = value;
			}
		}

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x06020B52 RID: 133970 RVA: 0x0094D10E File Offset: 0x0094B30E
		// (set) Token: 0x06020B53 RID: 133971 RVA: 0x0094D11E File Offset: 0x0094B31E
		public unsafe bool SuddenStopTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_SuddenStopTrigger) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_SuddenStopTrigger) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040AE RID: 16558
		// (get) Token: 0x06020B54 RID: 133972 RVA: 0x0094D12F File Offset: 0x0094B32F
		// (set) Token: 0x06020B55 RID: 133973 RVA: 0x0094D13F File Offset: 0x0094B33F
		public unsafe float LastSeatRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_LastSeatRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_LastSeatRoll) = value;
			}
		}

		// Token: 0x170040AF RID: 16559
		// (get) Token: 0x06020B56 RID: 133974 RVA: 0x0094D150 File Offset: 0x0094B350
		// (set) Token: 0x06020B57 RID: 133975 RVA: 0x0094D160 File Offset: 0x0094B360
		public unsafe bool EnableSwitchPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_EnableSwitchPose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_EnableSwitchPose) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x06020B58 RID: 133976 RVA: 0x0094D171 File Offset: 0x0094B371
		// (set) Token: 0x06020B59 RID: 133977 RVA: 0x0094D181 File Offset: 0x0094B381
		public unsafe float SwitchPoseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_SwitchPoseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_SwitchPoseTime) = value;
			}
		}

		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x06020B5A RID: 133978 RVA: 0x0094D192 File Offset: 0x0094B392
		// (set) Token: 0x06020B5B RID: 133979 RVA: 0x0094D1A2 File Offset: 0x0094B3A2
		public unsafe bool IsInPlotBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_IsInPlotBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_IsInPlotBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x06020B5C RID: 133980 RVA: 0x0094D1B3 File Offset: 0x0094B3B3
		// (set) Token: 0x06020B5D RID: 133981 RVA: 0x0094D1C3 File Offset: 0x0094B3C3
		public unsafe bool 状态_叠加层_手臂叠加层左手
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_叠加层_手臂叠加层左手) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_叠加层_手臂叠加层左手) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040B3 RID: 16563
		// (get) Token: 0x06020B5E RID: 133982 RVA: 0x0094D1D4 File Offset: 0x0094B3D4
		// (set) Token: 0x06020B5F RID: 133983 RVA: 0x0094D1E4 File Offset: 0x0094B3E4
		public unsafe bool 状态_叠加层_手臂叠加层右手
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_叠加层_手臂叠加层右手) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_叠加层_手臂叠加层右手) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x06020B60 RID: 133984 RVA: 0x0094D1F5 File Offset: 0x0094B3F5
		// (set) Token: 0x06020B61 RID: 133985 RVA: 0x0094D205 File Offset: 0x0094B405
		public unsafe bool 状态_叠加层_下半身通用融合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_叠加层_下半身通用融合) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_叠加层_下半身通用融合) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x06020B62 RID: 133986 RVA: 0x0094D216 File Offset: 0x0094B416
		// (set) Token: 0x06020B63 RID: 133987 RVA: 0x0094D226 File Offset: 0x0094B426
		public unsafe float 站立叠加倾斜量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_站立叠加倾斜量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_站立叠加倾斜量) = value;
			}
		}

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x06020B64 RID: 133988 RVA: 0x0094D237 File Offset: 0x0094B437
		// (set) Token: 0x06020B65 RID: 133989 RVA: 0x0094D247 File Offset: 0x0094B447
		public unsafe bool 是否待机表演
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否待机表演) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_是否待机表演) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x06020B66 RID: 133990 RVA: 0x0094D258 File Offset: 0x0094B458
		// (set) Token: 0x06020B67 RID: 133991 RVA: 0x0094D268 File Offset: 0x0094B468
		public unsafe float 待机表演间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_待机表演间隔);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_待机表演间隔) = value;
			}
		}

		// Token: 0x170040B8 RID: 16568
		// (get) Token: 0x06020B68 RID: 133992 RVA: 0x0094D279 File Offset: 0x0094B479
		// (set) Token: 0x06020B69 RID: 133993 RVA: 0x0094D289 File Offset: 0x0094B489
		public unsafe float 当前待机表演计时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_当前待机表演计时);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_当前待机表演计时) = value;
			}
		}

		// Token: 0x170040B9 RID: 16569
		// (get) Token: 0x06020B6A RID: 133994 RVA: 0x0094D29A File Offset: 0x0094B49A
		// (set) Token: 0x06020B6B RID: 133995 RVA: 0x0094D2AA File Offset: 0x0094B4AA
		public unsafe bool 禁用眨眼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_禁用眨眼) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_禁用眨眼) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x06020B6C RID: 133996 RVA: 0x0094D2BB File Offset: 0x0094B4BB
		// (set) Token: 0x06020B6D RID: 133997 RVA: 0x0094D2CB File Offset: 0x0094B4CB
		public unsafe bool 状态_乘坐载具
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_乘坐载具) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_乘坐载具) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x06020B6E RID: 133998 RVA: 0x0094D2DC File Offset: 0x0094B4DC
		// (set) Token: 0x06020B6F RID: 133999 RVA: 0x0094D2EC File Offset: 0x0094B4EC
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_地区运动模式) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_状态_地区运动模式) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x06020B70 RID: 134000 RVA: 0x0094D2FD File Offset: 0x0094B4FD
		// (set) Token: 0x06020B71 RID: 134001 RVA: 0x0094D30D File Offset: 0x0094B50D
		public unsafe bool 眨眼曲线覆盖蒙太奇
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_眨眼曲线覆盖蒙太奇) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_眨眼曲线覆盖蒙太奇) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020B72 RID: 134002 RVA: 0x0094D31E File Offset: 0x0094B51E
		[SkipLocalsInit]
		public virtual void 重置坐下待机计时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__重置坐下待机计时_NativeFunctionPtr, null);
		}

		// Token: 0x06020B73 RID: 134003 RVA: 0x0094D332 File Offset: 0x0094B532
		[SkipLocalsInit]
		public virtual void 更新坐下待机计时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新坐下待机计时_NativeFunctionPtr, null);
		}

		// Token: 0x06020B74 RID: 134004 RVA: 0x0094D346 File Offset: 0x0094B546
		[SkipLocalsInit]
		public virtual void 更新牵手组件参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新牵手组件参数_NativeFunctionPtr, null);
		}

		// Token: 0x06020B75 RID: 134005 RVA: 0x0094D35A File Offset: 0x0094B55A
		[SkipLocalsInit]
		public virtual void 更新载具信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新载具信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020B76 RID: 134006 RVA: 0x0094D36E File Offset: 0x0094B56E
		[SkipLocalsInit]
		public virtual void 初始化身高()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__初始化身高_NativeFunctionPtr, null);
		}

		// Token: 0x06020B77 RID: 134007 RVA: 0x0094D382 File Offset: 0x0094B582
		[SkipLocalsInit]
		public virtual void 组件参数动画蓝图初始化绑定()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__组件参数动画蓝图初始化绑定_NativeFunctionPtr, null);
		}

		// Token: 0x06020B78 RID: 134008 RVA: 0x0094D396 File Offset: 0x0094B596
		[SkipLocalsInit]
		public virtual void 绑定组件参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__绑定组件参数_NativeFunctionPtr, null);
		}

		// Token: 0x06020B79 RID: 134009 RVA: 0x0094D3AA File Offset: 0x0094B5AA
		[SkipLocalsInit]
		public virtual void 更新移动信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新移动信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020B7A RID: 134010 RVA: 0x0094D3BE File Offset: 0x0094B5BE
		[SkipLocalsInit]
		public virtual void 更新角色信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新角色信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020B7B RID: 134011 RVA: 0x0094D3D2 File Offset: 0x0094B5D2
		[SkipLocalsInit]
		public virtual void 更新状态参数信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新状态参数信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020B7C RID: 134012 RVA: 0x0094D3E6 File Offset: 0x0094B5E6
		[SkipLocalsInit]
		public virtual void 切换地面移动模式时高度补差()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__切换地面移动模式时高度补差_NativeFunctionPtr, null);
		}

		// Token: 0x06020B7D RID: 134013 RVA: 0x0094D3FA File Offset: 0x0094B5FA
		[SkipLocalsInit]
		public virtual void 更新上传()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新上传_NativeFunctionPtr, null);
		}

		// Token: 0x06020B7E RID: 134014 RVA: 0x0094D40E File Offset: 0x0094B60E
		[SkipLocalsInit]
		public virtual void 更新时间参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新时间参数_NativeFunctionPtr, null);
		}

		// Token: 0x06020B7F RID: 134015 RVA: 0x0094D422 File Offset: 0x0094B622
		[SkipLocalsInit]
		public virtual void 更新网络参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新网络参数_NativeFunctionPtr, null);
		}

		// Token: 0x06020B80 RID: 134016 RVA: 0x0094D436 File Offset: 0x0094B636
		[SkipLocalsInit]
		public virtual void 更新动画组件参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新动画组件参数_NativeFunctionPtr, null);
		}

		// Token: 0x06020B81 RID: 134017 RVA: 0x0094D44A File Offset: 0x0094B64A
		[SkipLocalsInit]
		public virtual void 更新移动组件参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新移动组件参数_NativeFunctionPtr, null);
		}

		// Token: 0x06020B82 RID: 134018 RVA: 0x0094D45E File Offset: 0x0094B65E
		[SkipLocalsInit]
		public virtual void 更新随机表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新随机表演_NativeFunctionPtr, null);
		}

		// Token: 0x06020B83 RID: 134019 RVA: 0x0094D472 File Offset: 0x0094B672
		[SkipLocalsInit]
		public virtual void 更新角色状态()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新角色状态_NativeFunctionPtr, null);
		}

		// Token: 0x06020B84 RID: 134020 RVA: 0x0094D488 File Offset: 0x0094B688
		[SkipLocalsInit]
		public unsafe virtual void 设置头部转向状态(SightLockMode SightMode)
		{
			ABP_BaseRoleNPC_C.__设置头部转向状态_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__设置头部转向状态_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__设置头部转向状态_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SightMode = SightMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B85 RID: 134021 RVA: 0x0094D4D0 File Offset: 0x0094B6D0
		[SkipLocalsInit]
		public unsafe virtual void 更新头部转向(FRotator NewParam)
		{
			ABP_BaseRoleNPC_C.__更新头部转向_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__更新头部转向_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__更新头部转向_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__更新头部转向_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新头部转向_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B86 RID: 134022 RVA: 0x0094D516 File Offset: 0x0094B716
		[SkipLocalsInit]
		public virtual void 更新_IK信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新_IK信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020B87 RID: 134023 RVA: 0x0094D52A File Offset: 0x0094B72A
		[SkipLocalsInit]
		public virtual void 原地旋转检查()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__原地旋转检查_NativeFunctionPtr, null);
		}

		// Token: 0x06020B88 RID: 134024 RVA: 0x0094D53E File Offset: 0x0094B73E
		[SkipLocalsInit]
		public virtual void 更新旋转信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新旋转信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020B89 RID: 134025 RVA: 0x0094D554 File Offset: 0x0094B754
		[SkipLocalsInit]
		public unsafe virtual bool 是否需要移动()
		{
			ABP_BaseRoleNPC_C.__是否需要移动_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__是否需要移动_FunctionParams[(UIntPtr)21] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__是否需要移动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__是否需要移动_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__是否需要移动_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020B8A RID: 134026 RVA: 0x0094D59C File Offset: 0x0094B79C
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B8B RID: 134027 RVA: 0x0094D5E4 File Offset: 0x0094B7E4
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B8C RID: 134028 RVA: 0x0094D62A File Offset: 0x0094B82A
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020B8D RID: 134029 RVA: 0x0094D63E File Offset: 0x0094B83E
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020B8E RID: 134030 RVA: 0x0094D652 File Offset: 0x0094B852
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020B8F RID: 134031 RVA: 0x0094D666 File Offset: 0x0094B866
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020B90 RID: 134032 RVA: 0x0094D67C File Offset: 0x0094B87C
		[SkipLocalsInit]
		public unsafe virtual void MovementChanged(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			ABP_BaseRoleNPC_C.__MovementChanged_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__MovementChanged_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__MovementChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__MovementChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__MovementChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B91 RID: 134033 RVA: 0x0094D6E4 File Offset: 0x0094B8E4
		[SkipLocalsInit]
		public virtual void PlotBlendIn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__PlotBlendIn_NativeFunctionPtr, null);
		}

		// Token: 0x06020B92 RID: 134034 RVA: 0x0094D6F8 File Offset: 0x0094B8F8
		[SkipLocalsInit]
		public virtual void NoExpose()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__NoExpose_NativeFunctionPtr, null);
		}

		// Token: 0x06020B93 RID: 134035 RVA: 0x0094D70C File Offset: 0x0094B90C
		protected ABP_BaseRoleNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011AA8 RID: 72360
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/RoleNPC/ABP_BaseRoleNPC.ABP_BaseRoleNPC_C";

		// Token: 0x04011AA9 RID: 72361
		private static IntPtr _ClassPtr;

		// Token: 0x04011AAA RID: 72362
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011AAB RID: 72363
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011AAC RID: 72364
		internal static int __PropertyOffset_DeltaTimeX;

		// Token: 0x04011AAD RID: 72365
		internal static int __PropertyOffset_速度向量;

		// Token: 0x04011AAE RID: 72366
		internal static int __PropertyOffset_加速度;

		// Token: 0x04011AAF RID: 72367
		internal static int __PropertyOffset_移动输入向量;

		// Token: 0x04011AB0 RID: 72368
		internal static int __PropertyOffset_是否正在移动;

		// Token: 0x04011AB1 RID: 72369
		internal static int __PropertyOffset_是否有移动输入;

		// Token: 0x04011AB2 RID: 72370
		internal static int __PropertyOffset_速度;

		// Token: 0x04011AB3 RID: 72371
		internal static int __PropertyOffset_瞄准旋转;

		// Token: 0x04011AB4 RID: 72372
		internal static int __PropertyOffset_是否将要移动;

		// Token: 0x04011AB5 RID: 72373
		internal static int __PropertyOffset_正在旋转;

		// Token: 0x04011AB6 RID: 72374
		internal static int __PropertyOffset_旋转速度;

		// Token: 0x04011AB7 RID: 72375
		internal static int __PropertyOffset_旋转混合;

		// Token: 0x04011AB8 RID: 72376
		internal static int __PropertyOffset_速度混合;

		// Token: 0x04011AB9 RID: 72377
		internal static int __PropertyOffset_相对加速度;

		// Token: 0x04011ABA RID: 72378
		internal static int __PropertyOffset_地上倾斜量平滑速度;

		// Token: 0x04011ABB RID: 72379
		internal static int __PropertyOffset_移动方向;

		// Token: 0x04011ABC RID: 72380
		internal static int __PropertyOffset_站立播放速率;

		// Token: 0x04011ABD RID: 72381
		internal static int __PropertyOffset_走跑混合;

		// Token: 0x04011ABE RID: 72382
		internal static int __PropertyOffset_站立走步幅混合曲线;

		// Token: 0x04011ABF RID: 72383
		internal static int __PropertyOffset_站立跑步幅混合曲线;

		// Token: 0x04011AC0 RID: 72384
		internal static int __PropertyOffset_步幅混合;

		// Token: 0x04011AC1 RID: 72385
		internal static int __PropertyOffset_动画行走速度;

		// Token: 0x04011AC2 RID: 72386
		internal static int __PropertyOffset_动画跑步速度;

		// Token: 0x04011AC3 RID: 72387
		internal static int __PropertyOffset_动画疾跑速度;

		// Token: 0x04011AC4 RID: 72388
		internal static int __PropertyOffset_RelativeSpeedBlendCurve;

		// Token: 0x04011AC5 RID: 72389
		internal static int __PropertyOffset_整体偏移;

		// Token: 0x04011AC6 RID: 72390
		internal static int __PropertyOffset_角色Mesh;

		// Token: 0x04011AC7 RID: 72391
		internal static int __PropertyOffset_整体偏移_实际使用_;

		// Token: 0x04011AC8 RID: 72392
		internal static int __PropertyOffset_上一帧模型位置;

		// Token: 0x04011AC9 RID: 72393
		internal static int __PropertyOffset_IsAutonomousProxy;

		// Token: 0x04011ACA RID: 72394
		internal static int __PropertyOffset_瞄准面向;

		// Token: 0x04011ACB RID: 72395
		internal static int __PropertyOffset_瞄准仰角;

		// Token: 0x04011ACC RID: 72396
		internal static int __PropertyOffset_当前坡度;

		// Token: 0x04011ACD RID: 72397
		internal static int __PropertyOffset_视线修正Alpha;

		// Token: 0x04011ACE RID: 72398
		internal static int __PropertyOffset_看向位置;

		// Token: 0x04011ACF RID: 72399
		internal static int __PropertyOffset_CachePercent_LR;

		// Token: 0x04011AD0 RID: 72400
		internal static int __PropertyOffset_CachePercent_FB;

		// Token: 0x04011AD1 RID: 72401
		internal static int __PropertyOffset_角色向前向量;

		// Token: 0x04011AD2 RID: 72402
		internal static int __PropertyOffset_外部方向输入;

		// Token: 0x04011AD3 RID: 72403
		internal static int __PropertyOffset_是否需要原地转身;

		// Token: 0x04011AD4 RID: 72404
		internal static int __PropertyOffset_右转;

		// Token: 0x04011AD5 RID: 72405
		internal static int __PropertyOffset_状态_跑停;

		// Token: 0x04011AD6 RID: 72406
		internal static int __PropertyOffset_状态_跑停_RunStop;

		// Token: 0x04011AD7 RID: 72407
		internal static int __PropertyOffset_状态_跑停_SprintStop;

		// Token: 0x04011AD8 RID: 72408
		internal static int __PropertyOffset_状态_跑停_WalkStop;

		// Token: 0x04011AD9 RID: 72409
		internal static int __PropertyOffset_状态_地面_Sprint;

		// Token: 0x04011ADA RID: 72410
		internal static int __PropertyOffset_状态_地面_Walk;

		// Token: 0x04011ADB RID: 72411
		internal static int __PropertyOffset_状态_地面_Run;

		// Token: 0x04011ADC RID: 72412
		internal static int __PropertyOffset_状态_牵手_牵手中;

		// Token: 0x04011ADD RID: 72413
		internal static int __PropertyOffset_状态_牵手_被牵手中;

		// Token: 0x04011ADE RID: 72414
		internal static int __PropertyOffset_状态_牵手_范围内;

		// Token: 0x04011ADF RID: 72415
		internal static int __PropertyOffset_状态_牵手_接受邀请中;

		// Token: 0x04011AE0 RID: 72416
		internal static int __PropertyOffset_CharMoveState;

		// Token: 0x04011AE1 RID: 72417
		internal static int __PropertyOffset_ExpresionAlpha;

		// Token: 0x04011AE2 RID: 72418
		internal static int __PropertyOffset_RandomEpresionEndTime;

		// Token: 0x04011AE3 RID: 72419
		internal static int __PropertyOffset_眨眼动画时长;

		// Token: 0x04011AE4 RID: 72420
		internal static int __PropertyOffset_此轮眨眼动画总时长;

		// Token: 0x04011AE5 RID: 72421
		internal static int __PropertyOffset_角色旋转;

		// Token: 0x04011AE6 RID: 72422
		internal static int __PropertyOffset_原地旋转偏差角;

		// Token: 0x04011AE7 RID: 72423
		internal static int __PropertyOffset_移动时是否有阻挡;

		// Token: 0x04011AE8 RID: 72424
		internal static int __PropertyOffset_TimeSeconds;

		// Token: 0x04011AE9 RID: 72425
		internal static int __PropertyOffset_InSequenceAlpha;

		// Token: 0x04011AEA RID: 72426
		internal static int __PropertyOffset_缓存角色位置;

		// Token: 0x04011AEB RID: 72427
		internal static int __PropertyOffset_AngelToStepLength;

		// Token: 0x04011AEC RID: 72428
		internal static int __PropertyOffset_Angle_to_Step_Frequency;

		// Token: 0x04011AED RID: 72429
		internal static int __PropertyOffset_综合旋转;

		// Token: 0x04011AEE RID: 72430
		internal static int __PropertyOffset_上一帧位置;

		// Token: 0x04011AEF RID: 72431
		internal static int __PropertyOffset_角色位移;

		// Token: 0x04011AF0 RID: 72432
		internal static int __PropertyOffset_眨眼中;

		// Token: 0x04011AF1 RID: 72433
		internal static int __PropertyOffset_身高;

		// Token: 0x04011AF2 RID: 72434
		internal static int __PropertyOffset_bComponentStart;

		// Token: 0x04011AF3 RID: 72435
		internal static int __PropertyOffset_CharPositionState;

		// Token: 0x04011AF4 RID: 72436
		internal static int __PropertyOffset_CharCameraState;

		// Token: 0x04011AF5 RID: 72437
		internal static int __PropertyOffset_Ts逻辑变量集;

		// Token: 0x04011AF6 RID: 72438
		internal static int __PropertyOffset_不进行_IK_Lerp;

		// Token: 0x04011AF7 RID: 72439
		internal static int __PropertyOffset_IK模式;

		// Token: 0x04011AF8 RID: 72440
		internal static int __PropertyOffset_使用混合空间;

		// Token: 0x04011AF9 RID: 72441
		internal static int __PropertyOffset_看向角度;

		// Token: 0x04011AFA RID: 72442
		internal static int __PropertyOffset_VehicleCollisionMix;

		// Token: 0x04011AFB RID: 72443
		internal static int __PropertyOffset_IsVehicleImpact;

		// Token: 0x04011AFC RID: 72444
		internal static int __PropertyOffset_VehicleSeatRot;

		// Token: 0x04011AFD RID: 72445
		internal static int __PropertyOffset_VehicleCollisionAngle;

		// Token: 0x04011AFE RID: 72446
		internal static int __PropertyOffset_VehicleCollisionStrength;

		// Token: 0x04011AFF RID: 72447
		internal static int __PropertyOffset_VehicleCollisionAlpha;

		// Token: 0x04011B00 RID: 72448
		internal static int __PropertyOffset_SuddenMoveTrigger;

		// Token: 0x04011B01 RID: 72449
		internal static int __PropertyOffset_VehicleSuddenMoveMix;

		// Token: 0x04011B02 RID: 72450
		internal static int __PropertyOffset_CurForwardSpeed;

		// Token: 0x04011B03 RID: 72451
		internal static int __PropertyOffset_LastForwardSpeed;

		// Token: 0x04011B04 RID: 72452
		internal static int __PropertyOffset_CurSeatRoll;

		// Token: 0x04011B05 RID: 72453
		internal static int __PropertyOffset_SuddenMoveCd;

		// Token: 0x04011B06 RID: 72454
		internal static int __PropertyOffset_SuddenStopTrigger;

		// Token: 0x04011B07 RID: 72455
		internal static int __PropertyOffset_LastSeatRoll;

		// Token: 0x04011B08 RID: 72456
		internal static int __PropertyOffset_EnableSwitchPose;

		// Token: 0x04011B09 RID: 72457
		internal static int __PropertyOffset_SwitchPoseTime;

		// Token: 0x04011B0A RID: 72458
		internal static int __PropertyOffset_IsInPlotBlend;

		// Token: 0x04011B0B RID: 72459
		internal static int __PropertyOffset_状态_叠加层_手臂叠加层左手;

		// Token: 0x04011B0C RID: 72460
		internal static int __PropertyOffset_状态_叠加层_手臂叠加层右手;

		// Token: 0x04011B0D RID: 72461
		internal static int __PropertyOffset_状态_叠加层_下半身通用融合;

		// Token: 0x04011B0E RID: 72462
		internal static int __PropertyOffset_站立叠加倾斜量;

		// Token: 0x04011B0F RID: 72463
		internal static int __PropertyOffset_是否待机表演;

		// Token: 0x04011B10 RID: 72464
		internal static int __PropertyOffset_待机表演间隔;

		// Token: 0x04011B11 RID: 72465
		internal static int __PropertyOffset_当前待机表演计时;

		// Token: 0x04011B12 RID: 72466
		internal static int __PropertyOffset_禁用眨眼;

		// Token: 0x04011B13 RID: 72467
		internal static int __PropertyOffset_状态_乘坐载具;

		// Token: 0x04011B14 RID: 72468
		internal static int __PropertyOffset_状态_地区运动模式;

		// Token: 0x04011B15 RID: 72469
		internal static int __PropertyOffset_眨眼曲线覆盖蒙太奇;

		// Token: 0x04011B16 RID: 72470
		private static IntPtr __重置坐下待机计时_NativeFunctionPtr;

		// Token: 0x04011B17 RID: 72471
		private static IntPtr __更新坐下待机计时_NativeFunctionPtr;

		// Token: 0x04011B18 RID: 72472
		private static IntPtr __更新牵手组件参数_NativeFunctionPtr;

		// Token: 0x04011B19 RID: 72473
		private static IntPtr __更新载具信息_NativeFunctionPtr;

		// Token: 0x04011B1A RID: 72474
		private static IntPtr __初始化身高_NativeFunctionPtr;

		// Token: 0x04011B1B RID: 72475
		private static IntPtr __组件参数动画蓝图初始化绑定_NativeFunctionPtr;

		// Token: 0x04011B1C RID: 72476
		private static IntPtr __绑定组件参数_NativeFunctionPtr;

		// Token: 0x04011B1D RID: 72477
		private static IntPtr __更新移动信息_NativeFunctionPtr;

		// Token: 0x04011B1E RID: 72478
		private static IntPtr __更新角色信息_NativeFunctionPtr;

		// Token: 0x04011B1F RID: 72479
		private static IntPtr __更新状态参数信息_NativeFunctionPtr;

		// Token: 0x04011B20 RID: 72480
		private static IntPtr __切换地面移动模式时高度补差_NativeFunctionPtr;

		// Token: 0x04011B21 RID: 72481
		private static IntPtr __更新上传_NativeFunctionPtr;

		// Token: 0x04011B22 RID: 72482
		private static IntPtr __更新时间参数_NativeFunctionPtr;

		// Token: 0x04011B23 RID: 72483
		private static IntPtr __更新网络参数_NativeFunctionPtr;

		// Token: 0x04011B24 RID: 72484
		private static IntPtr __更新动画组件参数_NativeFunctionPtr;

		// Token: 0x04011B25 RID: 72485
		private static IntPtr __更新移动组件参数_NativeFunctionPtr;

		// Token: 0x04011B26 RID: 72486
		private static IntPtr __更新随机表演_NativeFunctionPtr;

		// Token: 0x04011B27 RID: 72487
		private static IntPtr __更新角色状态_NativeFunctionPtr;

		// Token: 0x04011B28 RID: 72488
		private static IntPtr __设置头部转向状态_NativeFunctionPtr;

		// Token: 0x04011B29 RID: 72489
		private static IntPtr __更新头部转向_NativeFunctionPtr;

		// Token: 0x04011B2A RID: 72490
		private static IntPtr __更新_IK信息_NativeFunctionPtr;

		// Token: 0x04011B2B RID: 72491
		private static IntPtr __原地旋转检查_NativeFunctionPtr;

		// Token: 0x04011B2C RID: 72492
		private static IntPtr __更新旋转信息_NativeFunctionPtr;

		// Token: 0x04011B2D RID: 72493
		private static IntPtr __是否需要移动_NativeFunctionPtr;

		// Token: 0x04011B2E RID: 72494
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011B2F RID: 72495
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04011B30 RID: 72496
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x04011B31 RID: 72497
		private static IntPtr __MovementChanged_NativeFunctionPtr;

		// Token: 0x04011B32 RID: 72498
		private static IntPtr __PlotBlendIn_NativeFunctionPtr;

		// Token: 0x04011B33 RID: 72499
		private static IntPtr __NoExpose_NativeFunctionPtr;

		// Token: 0x02008FA5 RID: 36773
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __设置头部转向状态_FunctionParams
		{
			// Token: 0x0402CD47 RID: 183623
			[FieldOffset(0)]
			public SightLockMode SightMode;
		}

		// Token: 0x02008FA6 RID: 36774
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __更新头部转向_FunctionParams
		{
			// Token: 0x0402CD48 RID: 183624
			[FieldOffset(0)]
			public FRotator NewParam;
		}

		// Token: 0x02008FA7 RID: 36775
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 6)]
		protected ref struct __是否需要移动_FunctionParams
		{
			// Token: 0x0402CD49 RID: 183625
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02008FA8 RID: 36776
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD4A RID: 183626
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x02008FA9 RID: 36777
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementChanged_FunctionParams
		{
			// Token: 0x0402CD4B RID: 183627
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0402CD4C RID: 183628
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x0402CD4D RID: 183629
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}
	}
}
