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
	// Token: 0x0200409A RID: 16538
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_BaseRole_bakup.ABP_BaseRole_bakup_C")]
	[UnrealStructLayout(4480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4472)]
	public class ABP_BaseRole_bakup_C : UKuroAnimInstanceRole, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602A98C RID: 174476 RVA: 0x009E58FC File Offset: 0x009E3AFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_bakup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_BaseRole_bakup.ABP_BaseRole_bakup_C");
			}
			return ABP_BaseRole_bakup_C._ClassPtr;
		}

		// Token: 0x0602A98D RID: 174477 RVA: 0x009E5920 File Offset: 0x009E3B20
		public ABP_BaseRole_bakup_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_bakup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A98E RID: 174478 RVA: 0x009E5948 File Offset: 0x009E3B48
		[NullableContext(1)]
		public ABP_BaseRole_bakup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_bakup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006873 RID: 26739
		// (get) Token: 0x0602A98F RID: 174479 RVA: 0x009E597B File Offset: 0x009E3B7B
		// (set) Token: 0x0602A990 RID: 174480 RVA: 0x009E598F File Offset: 0x009E3B8F
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_bakup_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_bakup_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006874 RID: 26740
		// (get) Token: 0x0602A991 RID: 174481 RVA: 0x009E59A4 File Offset: 0x009E3BA4
		// (set) Token: 0x0602A992 RID: 174482 RVA: 0x009E59B4 File Offset: 0x009E3BB4
		public unsafe float 跳跃速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006875 RID: 26741
		// (get) Token: 0x0602A993 RID: 174483 RVA: 0x009E59C5 File Offset: 0x009E3BC5
		// (set) Token: 0x0602A994 RID: 174484 RVA: 0x009E59D9 File Offset: 0x009E3BD9
		public unsafe FVector 整体偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006876 RID: 26742
		// (get) Token: 0x0602A995 RID: 174485 RVA: 0x009E59EE File Offset: 0x009E3BEE
		// (set) Token: 0x0602A996 RID: 174486 RVA: 0x009E5A02 File Offset: 0x009E3C02
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_bakup_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_bakup_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17006877 RID: 26743
		// (get) Token: 0x0602A997 RID: 174487 RVA: 0x009E5A17 File Offset: 0x009E3C17
		// (set) Token: 0x0602A998 RID: 174488 RVA: 0x009E5A2B File Offset: 0x009E3C2B
		public unsafe FVector 整体偏移_实际使用_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006878 RID: 26744
		// (get) Token: 0x0602A999 RID: 174489 RVA: 0x009E5A40 File Offset: 0x009E3C40
		// (set) Token: 0x0602A99A RID: 174490 RVA: 0x009E5A50 File Offset: 0x009E3C50
		public unsafe bool 是否眩晕
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006879 RID: 26745
		// (get) Token: 0x0602A99B RID: 174491 RVA: 0x009E5A61 File Offset: 0x009E3C61
		// (set) Token: 0x0602A99C RID: 174492 RVA: 0x009E5A71 File Offset: 0x009E3C71
		public unsafe bool 是否壁上跳跃
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700687A RID: 26746
		// (get) Token: 0x0602A99D RID: 174493 RVA: 0x009E5A84 File Offset: 0x009E3C84
		// (set) Token: 0x0602A99E RID: 174494 RVA: 0x009E5ABD File Offset: 0x009E3CBD
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
					result = (this._左脚探测结果 = new FHitResult(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700687B RID: 26747
		// (get) Token: 0x0602A99F RID: 174495 RVA: 0x009E5AE0 File Offset: 0x009E3CE0
		// (set) Token: 0x0602A9A0 RID: 174496 RVA: 0x009E5B19 File Offset: 0x009E3D19
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
					result = (this._右脚探测结果 = new FHitResult(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700687C RID: 26748
		// (get) Token: 0x0602A9A1 RID: 174497 RVA: 0x009E5B3A File Offset: 0x009E3D3A
		// (set) Token: 0x0602A9A2 RID: 174498 RVA: 0x009E5B4A File Offset: 0x009E3D4A
		public unsafe bool 是否右手进入攀爬
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700687D RID: 26749
		// (get) Token: 0x0602A9A3 RID: 174499 RVA: 0x009E5B5B File Offset: 0x009E3D5B
		// (set) Token: 0x0602A9A4 RID: 174500 RVA: 0x009E5B6B File Offset: 0x009E3D6B
		public unsafe bool FASLE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700687E RID: 26750
		// (get) Token: 0x0602A9A5 RID: 174501 RVA: 0x009E5B7C File Offset: 0x009E3D7C
		// (set) Token: 0x0602A9A6 RID: 174502 RVA: 0x009E5B8C File Offset: 0x009E3D8C
		public unsafe float 钩索启动角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700687F RID: 26751
		// (get) Token: 0x0602A9A7 RID: 174503 RVA: 0x009E5B9D File Offset: 0x009E3D9D
		// (set) Token: 0x0602A9A8 RID: 174504 RVA: 0x009E5BAD File Offset: 0x009E3DAD
		public unsafe byte 反斜登顶退出
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006880 RID: 26752
		// (get) Token: 0x0602A9A9 RID: 174505 RVA: 0x009E5BBE File Offset: 0x009E3DBE
		// (set) Token: 0x0602A9AA RID: 174506 RVA: 0x009E5BCE File Offset: 0x009E3DCE
		public unsafe float 巨物拉取角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006881 RID: 26753
		// (get) Token: 0x0602A9AB RID: 174507 RVA: 0x009E5BDF File Offset: 0x009E3DDF
		// (set) Token: 0x0602A9AC RID: 174508 RVA: 0x009E5BEF File Offset: 0x009E3DEF
		public unsafe float 跳跃速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006882 RID: 26754
		// (get) Token: 0x0602A9AD RID: 174509 RVA: 0x009E5C00 File Offset: 0x009E3E00
		// (set) Token: 0x0602A9AE RID: 174510 RVA: 0x009E5C10 File Offset: 0x009E3E10
		public unsafe bool 状态_XA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006883 RID: 26755
		// (get) Token: 0x0602A9AF RID: 174511 RVA: 0x009E5C21 File Offset: 0x009E3E21
		// (set) Token: 0x0602A9B0 RID: 174512 RVA: 0x009E5C31 File Offset: 0x009E3E31
		public unsafe float XA_UD混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006884 RID: 26756
		// (get) Token: 0x0602A9B1 RID: 174513 RVA: 0x009E5C42 File Offset: 0x009E3E42
		// (set) Token: 0x0602A9B2 RID: 174514 RVA: 0x009E5C52 File Offset: 0x009E3E52
		public unsafe float XA_RL混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006885 RID: 26757
		// (get) Token: 0x0602A9B3 RID: 174515 RVA: 0x009E5C64 File Offset: 0x009E3E64
		// (set) Token: 0x0602A9B4 RID: 174516 RVA: 0x009E5C9D File Offset: 0x009E3E9D
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
					result = (this._CachePose = new FPoseSnapshot(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseSnapshot.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_20, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006886 RID: 26758
		// (get) Token: 0x0602A9B5 RID: 174517 RVA: 0x009E5CBE File Offset: 0x009E3EBE
		// (set) Token: 0x0602A9B6 RID: 174518 RVA: 0x009E5CCE File Offset: 0x009E3ECE
		public unsafe bool EnableSwitchPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006887 RID: 26759
		// (get) Token: 0x0602A9B7 RID: 174519 RVA: 0x009E5CDF File Offset: 0x009E3EDF
		// (set) Token: 0x0602A9B8 RID: 174520 RVA: 0x009E5CEF File Offset: 0x009E3EEF
		public unsafe float SwitchPoseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006888 RID: 26760
		// (get) Token: 0x0602A9B9 RID: 174521 RVA: 0x009E5D00 File Offset: 0x009E3F00
		// (set) Token: 0x0602A9BA RID: 174522 RVA: 0x009E5D10 File Offset: 0x009E3F10
		public unsafe float 上坡前倾
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17006889 RID: 26761
		// (get) Token: 0x0602A9BB RID: 174523 RVA: 0x009E5D21 File Offset: 0x009E3F21
		// (set) Token: 0x0602A9BC RID: 174524 RVA: 0x009E5D31 File Offset: 0x009E3F31
		public unsafe float 上坡削弱IK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700688A RID: 26762
		// (get) Token: 0x0602A9BD RID: 174525 RVA: 0x009E5D42 File Offset: 0x009E3F42
		// (set) Token: 0x0602A9BE RID: 174526 RVA: 0x009E5D52 File Offset: 0x009E3F52
		public unsafe bool 状态_空中_风筝
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700688B RID: 26763
		// (get) Token: 0x0602A9BF RID: 174527 RVA: 0x009E5D63 File Offset: 0x009E3F63
		// (set) Token: 0x0602A9C0 RID: 174528 RVA: 0x009E5D73 File Offset: 0x009E3F73
		public unsafe bool IsVehicleImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700688C RID: 26764
		// (get) Token: 0x0602A9C1 RID: 174529 RVA: 0x009E5D84 File Offset: 0x009E3F84
		// (set) Token: 0x0602A9C2 RID: 174530 RVA: 0x009E5D94 File Offset: 0x009E3F94
		public unsafe float VehicleCollisionStrength_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700688D RID: 26765
		// (get) Token: 0x0602A9C3 RID: 174531 RVA: 0x009E5DA5 File Offset: 0x009E3FA5
		// (set) Token: 0x0602A9C4 RID: 174532 RVA: 0x009E5DB5 File Offset: 0x009E3FB5
		public unsafe float VehicleCollisionAngle_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700688E RID: 26766
		// (get) Token: 0x0602A9C5 RID: 174533 RVA: 0x009E5DC6 File Offset: 0x009E3FC6
		// (set) Token: 0x0602A9C6 RID: 174534 RVA: 0x009E5DD6 File Offset: 0x009E3FD6
		public unsafe float VehicleCollisionAlpha_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700688F RID: 26767
		// (get) Token: 0x0602A9C7 RID: 174535 RVA: 0x009E5DE7 File Offset: 0x009E3FE7
		// (set) Token: 0x0602A9C8 RID: 174536 RVA: 0x009E5DFB File Offset: 0x009E3FFB
		public unsafe FVector4 VehicleCollisionMix_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17006890 RID: 26768
		// (get) Token: 0x0602A9C9 RID: 174537 RVA: 0x009E5E10 File Offset: 0x009E4010
		// (set) Token: 0x0602A9CA RID: 174538 RVA: 0x009E5E24 File Offset: 0x009E4024
		public unsafe FRotator VehicleSeatRot_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17006891 RID: 26769
		// (get) Token: 0x0602A9CB RID: 174539 RVA: 0x009E5E39 File Offset: 0x009E4039
		// (set) Token: 0x0602A9CC RID: 174540 RVA: 0x009E5E49 File Offset: 0x009E4049
		public unsafe bool TestCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006892 RID: 26770
		// (get) Token: 0x0602A9CD RID: 174541 RVA: 0x009E5E5A File Offset: 0x009E405A
		// (set) Token: 0x0602A9CE RID: 174542 RVA: 0x009E5E6E File Offset: 0x009E406E
		public unsafe FVector4 VehicleSuddenMoveMix_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17006893 RID: 26771
		// (get) Token: 0x0602A9CF RID: 174543 RVA: 0x009E5E83 File Offset: 0x009E4083
		// (set) Token: 0x0602A9D0 RID: 174544 RVA: 0x009E5E93 File Offset: 0x009E4093
		public unsafe float LastForwardSpeed_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17006894 RID: 26772
		// (get) Token: 0x0602A9D1 RID: 174545 RVA: 0x009E5EA4 File Offset: 0x009E40A4
		// (set) Token: 0x0602A9D2 RID: 174546 RVA: 0x009E5EB4 File Offset: 0x009E40B4
		public unsafe float CurForwardSpeed_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17006895 RID: 26773
		// (get) Token: 0x0602A9D3 RID: 174547 RVA: 0x009E5EC5 File Offset: 0x009E40C5
		// (set) Token: 0x0602A9D4 RID: 174548 RVA: 0x009E5ED5 File Offset: 0x009E40D5
		public unsafe float LastSeatRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17006896 RID: 26774
		// (get) Token: 0x0602A9D5 RID: 174549 RVA: 0x009E5EE6 File Offset: 0x009E40E6
		// (set) Token: 0x0602A9D6 RID: 174550 RVA: 0x009E5EF6 File Offset: 0x009E40F6
		public unsafe float CurSeatRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17006897 RID: 26775
		// (get) Token: 0x0602A9D7 RID: 174551 RVA: 0x009E5F07 File Offset: 0x009E4107
		// (set) Token: 0x0602A9D8 RID: 174552 RVA: 0x009E5F17 File Offset: 0x009E4117
		public unsafe float SuddenMoveCd_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17006898 RID: 26776
		// (get) Token: 0x0602A9D9 RID: 174553 RVA: 0x009E5F28 File Offset: 0x009E4128
		// (set) Token: 0x0602A9DA RID: 174554 RVA: 0x009E5F38 File Offset: 0x009E4138
		public unsafe bool SuddenMoveTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006899 RID: 26777
		// (get) Token: 0x0602A9DB RID: 174555 RVA: 0x009E5F49 File Offset: 0x009E4149
		// (set) Token: 0x0602A9DC RID: 174556 RVA: 0x009E5F59 File Offset: 0x009E4159
		public unsafe bool SuddenStopTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700689A RID: 26778
		// (get) Token: 0x0602A9DD RID: 174557 RVA: 0x009E5F6A File Offset: 0x009E416A
		// (set) Token: 0x0602A9DE RID: 174558 RVA: 0x009E5F7E File Offset: 0x009E417E
		public unsafe FVector 相对空中速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x1700689B RID: 26779
		// (get) Token: 0x0602A9DF RID: 174559 RVA: 0x009E5F93 File Offset: 0x009E4193
		// (set) Token: 0x0602A9E0 RID: 174560 RVA: 0x009E5FA3 File Offset: 0x009E41A3
		public unsafe bool 状态_滑轨
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700689C RID: 26780
		// (get) Token: 0x0602A9E1 RID: 174561 RVA: 0x009E5FB4 File Offset: 0x009E41B4
		// (set) Token: 0x0602A9E2 RID: 174562 RVA: 0x009E5FC4 File Offset: 0x009E41C4
		public unsafe bool 状态_滑轨_空中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700689D RID: 26781
		// (get) Token: 0x0602A9E3 RID: 174563 RVA: 0x009E5FD5 File Offset: 0x009E41D5
		// (set) Token: 0x0602A9E4 RID: 174564 RVA: 0x009E5FE5 File Offset: 0x009E41E5
		public unsafe bool 滑轨落地动画
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700689E RID: 26782
		// (get) Token: 0x0602A9E5 RID: 174565 RVA: 0x009E5FF6 File Offset: 0x009E41F6
		// (set) Token: 0x0602A9E6 RID: 174566 RVA: 0x009E6006 File Offset: 0x009E4206
		public unsafe bool 状态_滑轨_空中_右侧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700689F RID: 26783
		// (get) Token: 0x0602A9E7 RID: 174567 RVA: 0x009E6017 File Offset: 0x009E4217
		// (set) Token: 0x0602A9E8 RID: 174568 RVA: 0x009E6027 File Offset: 0x009E4227
		public unsafe bool 状态_牵手_牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A0 RID: 26784
		// (get) Token: 0x0602A9E9 RID: 174569 RVA: 0x009E6038 File Offset: 0x009E4238
		// (set) Token: 0x0602A9EA RID: 174570 RVA: 0x009E6048 File Offset: 0x009E4248
		public unsafe bool 状态_牵手_被牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A1 RID: 26785
		// (get) Token: 0x0602A9EB RID: 174571 RVA: 0x009E6059 File Offset: 0x009E4259
		// (set) Token: 0x0602A9EC RID: 174572 RVA: 0x009E6069 File Offset: 0x009E4269
		public unsafe bool 状态_牵手_范围内
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A2 RID: 26786
		// (get) Token: 0x0602A9ED RID: 174573 RVA: 0x009E607A File Offset: 0x009E427A
		// (set) Token: 0x0602A9EE RID: 174574 RVA: 0x009E608A File Offset: 0x009E428A
		public unsafe bool IsInPlotBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A3 RID: 26787
		// (get) Token: 0x0602A9EF RID: 174575 RVA: 0x009E609B File Offset: 0x009E429B
		// (set) Token: 0x0602A9F0 RID: 174576 RVA: 0x009E60AB File Offset: 0x009E42AB
		public unsafe float 移动平台IKAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x170068A4 RID: 26788
		// (get) Token: 0x0602A9F1 RID: 174577 RVA: 0x009E60BC File Offset: 0x009E42BC
		// (set) Token: 0x0602A9F2 RID: 174578 RVA: 0x009E60CC File Offset: 0x009E42CC
		public unsafe bool 移动平台移动中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_51) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_51) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A5 RID: 26789
		// (get) Token: 0x0602A9F3 RID: 174579 RVA: 0x009E60DD File Offset: 0x009E42DD
		// (set) Token: 0x0602A9F4 RID: 174580 RVA: 0x009E60ED File Offset: 0x009E42ED
		public unsafe bool 状态_基础移动替换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_52) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_52) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A6 RID: 26790
		// (get) Token: 0x0602A9F5 RID: 174581 RVA: 0x009E60FE File Offset: 0x009E42FE
		// (set) Token: 0x0602A9F6 RID: 174582 RVA: 0x009E610E File Offset: 0x009E430E
		public unsafe bool 状态_样条跑墙
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_53) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_53) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A7 RID: 26791
		// (get) Token: 0x0602A9F7 RID: 174583 RVA: 0x009E611F File Offset: 0x009E431F
		// (set) Token: 0x0602A9F8 RID: 174584 RVA: 0x009E612F File Offset: 0x009E432F
		public unsafe bool 状态_上坡动画替换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A8 RID: 26792
		// (get) Token: 0x0602A9F9 RID: 174585 RVA: 0x009E6140 File Offset: 0x009E4340
		// (set) Token: 0x0602A9FA RID: 174586 RVA: 0x009E6150 File Offset: 0x009E4350
		public unsafe bool 状态_强制更新源姿势
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A9 RID: 26793
		// (get) Token: 0x0602A9FB RID: 174587 RVA: 0x009E6161 File Offset: 0x009E4361
		// (set) Token: 0x0602A9FC RID: 174588 RVA: 0x009E6171 File Offset: 0x009E4371
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068AA RID: 26794
		// (get) Token: 0x0602A9FD RID: 174589 RVA: 0x009E6182 File Offset: 0x009E4382
		// (set) Token: 0x0602A9FE RID: 174590 RVA: 0x009E6192 File Offset: 0x009E4392
		public unsafe bool 状态_载具驾驶_摩托
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_57) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_57) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068AB RID: 26795
		// (get) Token: 0x0602A9FF RID: 174591 RVA: 0x009E61A3 File Offset: 0x009E43A3
		// (set) Token: 0x0602AA00 RID: 174592 RVA: 0x009E61B3 File Offset: 0x009E43B3
		public unsafe bool 状态_地区动作保留
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_58) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_58) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068AC RID: 26796
		// (get) Token: 0x0602AA01 RID: 174593 RVA: 0x009E61C4 File Offset: 0x009E43C4
		// (set) Token: 0x0602AA02 RID: 174594 RVA: 0x009E61D4 File Offset: 0x009E43D4
		public unsafe bool 状态_强制关闭IK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_59) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_59) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068AD RID: 26797
		// (get) Token: 0x0602AA03 RID: 174595 RVA: 0x009E61E5 File Offset: 0x009E43E5
		// (set) Token: 0x0602AA04 RID: 174596 RVA: 0x009E61F5 File Offset: 0x009E43F5
		public unsafe float SightLockYawMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x170068AE RID: 26798
		// (get) Token: 0x0602AA05 RID: 174597 RVA: 0x009E6206 File Offset: 0x009E4406
		// (set) Token: 0x0602AA06 RID: 174598 RVA: 0x009E6216 File Offset: 0x009E4416
		public unsafe float SightLockYawMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x170068AF RID: 26799
		// (get) Token: 0x0602AA07 RID: 174599 RVA: 0x009E6227 File Offset: 0x009E4427
		// (set) Token: 0x0602AA08 RID: 174600 RVA: 0x009E6237 File Offset: 0x009E4437
		public unsafe float SightLockPitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x170068B0 RID: 26800
		// (get) Token: 0x0602AA09 RID: 174601 RVA: 0x009E6248 File Offset: 0x009E4448
		// (set) Token: 0x0602AA0A RID: 174602 RVA: 0x009E6258 File Offset: 0x009E4458
		public unsafe float SightLockPitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_63);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_63) = value;
			}
		}

		// Token: 0x170068B1 RID: 26801
		// (get) Token: 0x0602AA0B RID: 174603 RVA: 0x009E6269 File Offset: 0x009E4469
		// (set) Token: 0x0602AA0C RID: 174604 RVA: 0x009E6279 File Offset: 0x009E4479
		public unsafe float SightLockAssitLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x170068B2 RID: 26802
		// (get) Token: 0x0602AA0D RID: 174605 RVA: 0x009E628A File Offset: 0x009E448A
		// (set) Token: 0x0602AA0E RID: 174606 RVA: 0x009E629A File Offset: 0x009E449A
		public unsafe bool 状态_关闭FB受击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_65) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_65) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068B3 RID: 26803
		// (get) Token: 0x0602AA0F RID: 174607 RVA: 0x009E62AB File Offset: 0x009E44AB
		// (set) Token: 0x0602AA10 RID: 174608 RVA: 0x009E62BB File Offset: 0x009E44BB
		public unsafe float 普通运动转基础移动BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x170068B4 RID: 26804
		// (get) Token: 0x0602AA11 RID: 174609 RVA: 0x009E62CC File Offset: 0x009E44CC
		// (set) Token: 0x0602AA12 RID: 174610 RVA: 0x009E62DC File Offset: 0x009E44DC
		public unsafe float 基础移动转普通运动BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x170068B5 RID: 26805
		// (get) Token: 0x0602AA13 RID: 174611 RVA: 0x009E62ED File Offset: 0x009E44ED
		// (set) Token: 0x0602AA14 RID: 174612 RVA: 0x009E62FD File Offset: 0x009E44FD
		public unsafe bool 滑轨启用定制动作
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_68) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_68) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068B6 RID: 26806
		// (get) Token: 0x0602AA15 RID: 174613 RVA: 0x009E630E File Offset: 0x009E450E
		// (set) Token: 0x0602AA16 RID: 174614 RVA: 0x009E631E File Offset: 0x009E451E
		public unsafe bool 状态_滑轨_空中_前向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_69) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_69) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068B7 RID: 26807
		// (get) Token: 0x0602AA17 RID: 174615 RVA: 0x009E632F File Offset: 0x009E452F
		// (set) Token: 0x0602AA18 RID: 174616 RVA: 0x009E6343 File Offset: 0x009E4543
		public unsafe FVector SightDirectInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_70);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_70) = value;
			}
		}

		// Token: 0x170068B8 RID: 26808
		// (get) Token: 0x0602AA19 RID: 174617 RVA: 0x009E6358 File Offset: 0x009E4558
		// (set) Token: 0x0602AA1A RID: 174618 RVA: 0x009E636C File Offset: 0x009E456C
		public unsafe FVector UpAxisInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_71);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x0602AA1B RID: 174619 RVA: 0x009E6384 File Offset: 0x009E4584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_BaseRole_bakup_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x0602AA1C RID: 174620 RVA: 0x009E63D4 File Offset: 0x009E45D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_bakup_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AA1D RID: 174621 RVA: 0x009E645B File Offset: 0x009E465B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新载具信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__更新载具信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA1E RID: 174622 RVA: 0x009E646F File Offset: 0x009E466F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 风筝移动更新()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__风筝移动更新_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA1F RID: 174623 RVA: 0x009E6483 File Offset: 0x009E4683
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 移动平台和上坡IK削弱()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__移动平台和上坡IK削弱_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA20 RID: 174624 RVA: 0x009E6497 File Offset: 0x009E4697
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 落地速度切割初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__落地速度切割初始化_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA21 RID: 174625 RVA: 0x009E64AC File Offset: 0x009E46AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void VelocityBlendLerp(FVeloctiyBlend From, FVeloctiyBlend To, float Alpha, ref FVeloctiyBlend Out)
		{
			ABP_BaseRole_bakup_C.__VelocityBlendLerp_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__VelocityBlendLerp_FunctionParams[(UIntPtr)99] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__VelocityBlendLerp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__VelocityBlendLerp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = From;
			ptr->To = To;
			ptr->Alpha = Alpha;
			ptr->Out = Out;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__VelocityBlendLerp_NativeFunctionPtr, (void*)ptr);
			Out = ptr->Out;
		}

		// Token: 0x0602AA22 RID: 174626 RVA: 0x009E651A File Offset: 0x009E471A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void XA状态更新()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__XA状态更新_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA23 RID: 174627 RVA: 0x009E6530 File Offset: 0x009E4730
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置跳跃速率(float 新速率)
		{
			ABP_BaseRole_bakup_C.__设置跳跃速率_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__设置跳跃速率_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__设置跳跃速率_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__设置跳跃速率_NativeFunctionPtr, (void*)ptr, 1);
			ptr->新速率 = 新速率;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__设置跳跃速率_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA24 RID: 174628 RVA: 0x009E6576 File Offset: 0x009E4776
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 冰冻结束事件()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__冰冻结束事件_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA25 RID: 174629 RVA: 0x009E658C File Offset: 0x009E478C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 计算跳跃混合(float 速度, ref float 混合)
		{
			ABP_BaseRole_bakup_C.__计算跳跃混合_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__计算跳跃混合_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__计算跳跃混合_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__计算跳跃混合_NativeFunctionPtr, (void*)ptr, 1);
			ptr->速度 = 速度;
			ptr->混合 = 混合;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__计算跳跃混合_NativeFunctionPtr, (void*)ptr);
			混合 = ptr->混合;
		}

		// Token: 0x0602AA26 RID: 174630 RVA: 0x009E65E2 File Offset: 0x009E47E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CleanAnimVariable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__CleanAnimVariable_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA27 RID: 174631 RVA: 0x009E65F8 File Offset: 0x009E47F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void True布尔序列输出(ref TArray<bool> ValArrt_Bool, ref int Out)
		{
			ABP_BaseRole_bakup_C.__True布尔序列输出_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__True布尔序列输出_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__True布尔序列输出_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__True布尔序列输出_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = ValArrt_Bool;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ValArrt_Bool);
			}
			ptr->Out = Out;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__True布尔序列输出_NativeFunctionPtr, (void*)ptr);
			TArray<bool> tarray2 = ValArrt_Bool;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ValArrt_Bool);
			}
			Out = ptr->Out;
			UnrealReflectionUtils.DestroyStruct(ABP_BaseRole_bakup_C.__True布尔序列输出_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602AA28 RID: 174632 RVA: 0x009E6680 File Offset: 0x009E4880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新上传()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__更新上传_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA29 RID: 174633 RVA: 0x009E6694 File Offset: 0x009E4894
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA2A RID: 174634 RVA: 0x009E66A8 File Offset: 0x009E48A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 替换角色时同步动作数据(ABP_BaseRole_C 切出角色AnimIns)
		{
			ABP_BaseRole_bakup_C.__替换角色时同步动作数据_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__替换角色时同步动作数据_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__替换角色时同步动作数据_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__替换角色时同步动作数据_NativeFunctionPtr, (void*)ptr, 1);
			ptr->切出角色AnimIns = ((切出角色AnimIns != null) ? 切出角色AnimIns.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__替换角色时同步动作数据_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA2B RID: 174635 RVA: 0x009E6700 File Offset: 0x009E4900
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置头部转向状态(SightLockMode SightMode)
		{
			ABP_BaseRole_bakup_C.__设置头部转向状态_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__设置头部转向状态_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__设置头部转向状态_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SightMode = SightMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA2C RID: 174636 RVA: 0x009E6746 File Offset: 0x009E4946
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA2D RID: 174637 RVA: 0x009E675A File Offset: 0x009E495A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AA2E RID: 174638 RVA: 0x009E6770 File Offset: 0x009E4970
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 播放动画(SDynamicMontageParams 播放动画)
		{
			ABP_BaseRole_bakup_C.__播放动画_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__播放动画_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__播放动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__播放动画_NativeFunctionPtr, (void*)ptr, 1);
			if (播放动画 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SDynamicMontageParams.StaticStruct(), &ptr->播放动画, 播放动画.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__播放动画_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA2F RID: 174639 RVA: 0x009E67D1 File Offset: 0x009E49D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA30 RID: 174640 RVA: 0x009E67E5 File Offset: 0x009E49E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TestFk()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__TestFk_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA31 RID: 174641 RVA: 0x009E67FC File Offset: 0x009E49FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA32 RID: 174642 RVA: 0x009E6844 File Offset: 0x009E4A44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AA33 RID: 174643 RVA: 0x009E688C File Offset: 0x009E4A8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_BaseRole_bakup_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA34 RID: 174644 RVA: 0x009E68D2 File Offset: 0x009E4AD2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA35 RID: 174645 RVA: 0x009E68E6 File Offset: 0x009E4AE6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AA36 RID: 174646 RVA: 0x009E68FC File Offset: 0x009E4AFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_BaseRole_bakup_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA37 RID: 174647 RVA: 0x009E6944 File Offset: 0x009E4B44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA38 RID: 174648 RVA: 0x009E698A File Offset: 0x009E4B8A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__ClearClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA39 RID: 174649 RVA: 0x009E69A0 File Offset: 0x009E4BA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA3A RID: 174650 RVA: 0x009E69E6 File Offset: 0x009E4BE6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlotBlendIn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__PlotBlendIn_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA3B RID: 174651 RVA: 0x009E69FA File Offset: 0x009E4BFA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NoExpose()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__NoExpose_NativeFunctionPtr, null);
		}

		// Token: 0x0602AA3C RID: 174652 RVA: 0x009E6A10 File Offset: 0x009E4C10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetSightLockConfig(float YawMin, float YawMax, float PitchMin, float PitchMax, float AssitLimit, FVector SightDirectInSightBone, FVector UpAxisInSightBone)
		{
			ABP_BaseRole_bakup_C.__SetSightLockConfig_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__SetSightLockConfig_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__SetSightLockConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__SetSightLockConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->YawMin = YawMin;
			ptr->YawMax = YawMax;
			ptr->PitchMin = PitchMin;
			ptr->PitchMax = PitchMax;
			ptr->AssitLimit = AssitLimit;
			ptr->SightDirectInSightBone = SightDirectInSightBone;
			ptr->UpAxisInSightBone = UpAxisInSightBone;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__SetSightLockConfig_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AA3D RID: 174653 RVA: 0x009E6A84 File Offset: 0x009E4C84
		protected ABP_BaseRole_bakup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016080 RID: 90240
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_BaseRole_bakup.ABP_BaseRole_bakup_C";

		// Token: 0x04016081 RID: 90241
		private static IntPtr _ClassPtr;

		// Token: 0x04016082 RID: 90242
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016083 RID: 90243
		internal static int __PropertyOffset_2;

		// Token: 0x04016084 RID: 90244
		internal static int __PropertyOffset_3;

		// Token: 0x04016085 RID: 90245
		internal static int __PropertyOffset_4;

		// Token: 0x04016086 RID: 90246
		internal static int __PropertyOffset_5;

		// Token: 0x04016087 RID: 90247
		internal static int __PropertyOffset_6;

		// Token: 0x04016088 RID: 90248
		internal static int __PropertyOffset_7;

		// Token: 0x04016089 RID: 90249
		internal static int __PropertyOffset_8;

		// Token: 0x0401608A RID: 90250
		internal static int __PropertyOffset_9;

		// Token: 0x0401608B RID: 90251
		[Nullable(2)]
		private FHitResult _左脚探测结果;

		// Token: 0x0401608C RID: 90252
		internal static int __PropertyOffset_10;

		// Token: 0x0401608D RID: 90253
		[Nullable(2)]
		private FHitResult _右脚探测结果;

		// Token: 0x0401608E RID: 90254
		internal static int __PropertyOffset_11;

		// Token: 0x0401608F RID: 90255
		internal static int __PropertyOffset_12;

		// Token: 0x04016090 RID: 90256
		internal static int __PropertyOffset_13;

		// Token: 0x04016091 RID: 90257
		internal static int __PropertyOffset_14;

		// Token: 0x04016092 RID: 90258
		internal static int __PropertyOffset_15;

		// Token: 0x04016093 RID: 90259
		internal static int __PropertyOffset_16;

		// Token: 0x04016094 RID: 90260
		internal static int __PropertyOffset_17;

		// Token: 0x04016095 RID: 90261
		internal static int __PropertyOffset_18;

		// Token: 0x04016096 RID: 90262
		internal static int __PropertyOffset_19;

		// Token: 0x04016097 RID: 90263
		internal static int __PropertyOffset_20;

		// Token: 0x04016098 RID: 90264
		[Nullable(2)]
		private FPoseSnapshot _CachePose;

		// Token: 0x04016099 RID: 90265
		internal static int __PropertyOffset_21;

		// Token: 0x0401609A RID: 90266
		internal static int __PropertyOffset_22;

		// Token: 0x0401609B RID: 90267
		internal static int __PropertyOffset_23;

		// Token: 0x0401609C RID: 90268
		internal static int __PropertyOffset_24;

		// Token: 0x0401609D RID: 90269
		internal static int __PropertyOffset_25;

		// Token: 0x0401609E RID: 90270
		internal static int __PropertyOffset_26;

		// Token: 0x0401609F RID: 90271
		internal static int __PropertyOffset_27;

		// Token: 0x040160A0 RID: 90272
		internal static int __PropertyOffset_28;

		// Token: 0x040160A1 RID: 90273
		internal static int __PropertyOffset_29;

		// Token: 0x040160A2 RID: 90274
		internal static int __PropertyOffset_30;

		// Token: 0x040160A3 RID: 90275
		internal static int __PropertyOffset_31;

		// Token: 0x040160A4 RID: 90276
		internal static int __PropertyOffset_32;

		// Token: 0x040160A5 RID: 90277
		internal static int __PropertyOffset_33;

		// Token: 0x040160A6 RID: 90278
		internal static int __PropertyOffset_34;

		// Token: 0x040160A7 RID: 90279
		internal static int __PropertyOffset_35;

		// Token: 0x040160A8 RID: 90280
		internal static int __PropertyOffset_36;

		// Token: 0x040160A9 RID: 90281
		internal static int __PropertyOffset_37;

		// Token: 0x040160AA RID: 90282
		internal static int __PropertyOffset_38;

		// Token: 0x040160AB RID: 90283
		internal static int __PropertyOffset_39;

		// Token: 0x040160AC RID: 90284
		internal static int __PropertyOffset_40;

		// Token: 0x040160AD RID: 90285
		internal static int __PropertyOffset_41;

		// Token: 0x040160AE RID: 90286
		internal static int __PropertyOffset_42;

		// Token: 0x040160AF RID: 90287
		internal static int __PropertyOffset_43;

		// Token: 0x040160B0 RID: 90288
		internal static int __PropertyOffset_44;

		// Token: 0x040160B1 RID: 90289
		internal static int __PropertyOffset_45;

		// Token: 0x040160B2 RID: 90290
		internal static int __PropertyOffset_46;

		// Token: 0x040160B3 RID: 90291
		internal static int __PropertyOffset_47;

		// Token: 0x040160B4 RID: 90292
		internal static int __PropertyOffset_48;

		// Token: 0x040160B5 RID: 90293
		internal static int __PropertyOffset_49;

		// Token: 0x040160B6 RID: 90294
		internal static int __PropertyOffset_50;

		// Token: 0x040160B7 RID: 90295
		internal static int __PropertyOffset_51;

		// Token: 0x040160B8 RID: 90296
		internal static int __PropertyOffset_52;

		// Token: 0x040160B9 RID: 90297
		internal static int __PropertyOffset_53;

		// Token: 0x040160BA RID: 90298
		internal static int __PropertyOffset_54;

		// Token: 0x040160BB RID: 90299
		internal static int __PropertyOffset_55;

		// Token: 0x040160BC RID: 90300
		internal static int __PropertyOffset_56;

		// Token: 0x040160BD RID: 90301
		internal static int __PropertyOffset_57;

		// Token: 0x040160BE RID: 90302
		internal static int __PropertyOffset_58;

		// Token: 0x040160BF RID: 90303
		internal static int __PropertyOffset_59;

		// Token: 0x040160C0 RID: 90304
		internal static int __PropertyOffset_60;

		// Token: 0x040160C1 RID: 90305
		internal static int __PropertyOffset_61;

		// Token: 0x040160C2 RID: 90306
		internal static int __PropertyOffset_62;

		// Token: 0x040160C3 RID: 90307
		internal static int __PropertyOffset_63;

		// Token: 0x040160C4 RID: 90308
		internal static int __PropertyOffset_64;

		// Token: 0x040160C5 RID: 90309
		internal static int __PropertyOffset_65;

		// Token: 0x040160C6 RID: 90310
		internal static int __PropertyOffset_66;

		// Token: 0x040160C7 RID: 90311
		internal static int __PropertyOffset_67;

		// Token: 0x040160C8 RID: 90312
		internal static int __PropertyOffset_68;

		// Token: 0x040160C9 RID: 90313
		internal static int __PropertyOffset_69;

		// Token: 0x040160CA RID: 90314
		internal static int __PropertyOffset_70;

		// Token: 0x040160CB RID: 90315
		internal static int __PropertyOffset_71;

		// Token: 0x040160CC RID: 90316
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x040160CD RID: 90317
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040160CE RID: 90318
		private static IntPtr __更新载具信息_NativeFunctionPtr;

		// Token: 0x040160CF RID: 90319
		private static IntPtr __风筝移动更新_NativeFunctionPtr;

		// Token: 0x040160D0 RID: 90320
		private static IntPtr __移动平台和上坡IK削弱_NativeFunctionPtr;

		// Token: 0x040160D1 RID: 90321
		private static IntPtr __落地速度切割初始化_NativeFunctionPtr;

		// Token: 0x040160D2 RID: 90322
		private static IntPtr __VelocityBlendLerp_NativeFunctionPtr;

		// Token: 0x040160D3 RID: 90323
		private static IntPtr __XA状态更新_NativeFunctionPtr;

		// Token: 0x040160D4 RID: 90324
		private static IntPtr __设置跳跃速率_NativeFunctionPtr;

		// Token: 0x040160D5 RID: 90325
		private static IntPtr __冰冻结束事件_NativeFunctionPtr;

		// Token: 0x040160D6 RID: 90326
		private static IntPtr __计算跳跃混合_NativeFunctionPtr;

		// Token: 0x040160D7 RID: 90327
		private static IntPtr __CleanAnimVariable_NativeFunctionPtr;

		// Token: 0x040160D8 RID: 90328
		private static IntPtr __True布尔序列输出_NativeFunctionPtr;

		// Token: 0x040160D9 RID: 90329
		private static IntPtr __更新上传_NativeFunctionPtr;

		// Token: 0x040160DA RID: 90330
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x040160DB RID: 90331
		private static IntPtr __替换角色时同步动作数据_NativeFunctionPtr;

		// Token: 0x040160DC RID: 90332
		private static IntPtr __设置头部转向状态_NativeFunctionPtr;

		// Token: 0x040160DD RID: 90333
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x040160DE RID: 90334
		private static IntPtr __播放动画_NativeFunctionPtr;

		// Token: 0x040160DF RID: 90335
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x040160E0 RID: 90336
		private static IntPtr __TestFk_NativeFunctionPtr;

		// Token: 0x040160E1 RID: 90337
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x040160E2 RID: 90338
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x040160E3 RID: 90339
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x040160E4 RID: 90340
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x040160E5 RID: 90341
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x040160E6 RID: 90342
		private static IntPtr __ClearClimbDash_NativeFunctionPtr;

		// Token: 0x040160E7 RID: 90343
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x040160E8 RID: 90344
		private static IntPtr __PlotBlendIn_NativeFunctionPtr;

		// Token: 0x040160E9 RID: 90345
		private static IntPtr __NoExpose_NativeFunctionPtr;

		// Token: 0x040160EA RID: 90346
		private static IntPtr __SetSightLockConfig_NativeFunctionPtr;

		// Token: 0x0200A3D7 RID: 41943
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x040321D0 RID: 205264
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A3D8 RID: 41944
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040321D1 RID: 205265
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A3D9 RID: 41945
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 84)]
		protected ref struct __VelocityBlendLerp_FunctionParams
		{
			// Token: 0x040321D2 RID: 205266
			[FieldOffset(0)]
			public FVeloctiyBlend From;

			// Token: 0x040321D3 RID: 205267
			[FieldOffset(16)]
			public FVeloctiyBlend To;

			// Token: 0x040321D4 RID: 205268
			[FieldOffset(32)]
			public float Alpha;

			// Token: 0x040321D5 RID: 205269
			[FieldOffset(36)]
			public FVeloctiyBlend Out;
		}

		// Token: 0x0200A3DA RID: 41946
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __设置跳跃速率_FunctionParams
		{
			// Token: 0x040321D6 RID: 205270
			[FieldOffset(0)]
			public float 新速率;
		}

		// Token: 0x0200A3DB RID: 41947
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __计算跳跃混合_FunctionParams
		{
			// Token: 0x040321D7 RID: 205271
			[FieldOffset(0)]
			public float 速度;

			// Token: 0x040321D8 RID: 205272
			[FieldOffset(4)]
			public float 混合;
		}

		// Token: 0x0200A3DC RID: 41948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __True布尔序列输出_FunctionParams
		{
			// Token: 0x040321D9 RID: 205273
			[FieldOffset(0)]
			public byte ValArrt_Bool;

			// Token: 0x040321DA RID: 205274
			[FieldOffset(16)]
			public int Out;
		}

		// Token: 0x0200A3DD RID: 41949
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __替换角色时同步动作数据_FunctionParams
		{
			// Token: 0x040321DB RID: 205275
			[FieldOffset(0)]
			public IntPtr 切出角色AnimIns;
		}

		// Token: 0x0200A3DE RID: 41950
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __设置头部转向状态_FunctionParams
		{
			// Token: 0x040321DC RID: 205276
			[FieldOffset(0)]
			public SightLockMode SightMode;
		}

		// Token: 0x0200A3DF RID: 41951
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __播放动画_FunctionParams
		{
			// Token: 0x040321DD RID: 205277
			[FieldOffset(0)]
			public byte 播放动画;
		}

		// Token: 0x0200A3E0 RID: 41952
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040321DE RID: 205278
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x0200A3E1 RID: 41953
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x040321DF RID: 205279
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A3E2 RID: 41954
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x040321E0 RID: 205280
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A3E3 RID: 41955
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x040321E1 RID: 205281
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A3E4 RID: 41956
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x040321E2 RID: 205282
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x0200A3E5 RID: 41957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __SetSightLockConfig_FunctionParams
		{
			// Token: 0x040321E3 RID: 205283
			[FieldOffset(0)]
			public float YawMin;

			// Token: 0x040321E4 RID: 205284
			[FieldOffset(4)]
			public float YawMax;

			// Token: 0x040321E5 RID: 205285
			[FieldOffset(8)]
			public float PitchMin;

			// Token: 0x040321E6 RID: 205286
			[FieldOffset(12)]
			public float PitchMax;

			// Token: 0x040321E7 RID: 205287
			[FieldOffset(16)]
			public float AssitLimit;

			// Token: 0x040321E8 RID: 205288
			[FieldOffset(20)]
			public FVector SightDirectInSightBone;

			// Token: 0x040321E9 RID: 205289
			[FieldOffset(32)]
			public FVector UpAxisInSightBone;
		}
	}
}
