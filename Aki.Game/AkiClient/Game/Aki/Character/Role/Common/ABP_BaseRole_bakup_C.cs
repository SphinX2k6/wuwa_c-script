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
	// Token: 0x02003298 RID: 12952
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_BaseRole_bakup.ABP_BaseRole_bakup_C")]
	[UnrealStructLayout(4592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4584)]
	public class ABP_BaseRole_bakup_C : UKuroAnimInstanceRole, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020754 RID: 132948 RVA: 0x0094720B File Offset: 0x0094540B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_bakup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_BaseRole_bakup.ABP_BaseRole_bakup_C");
			}
			return ABP_BaseRole_bakup_C._ClassPtr;
		}

		// Token: 0x06020755 RID: 132949 RVA: 0x00947230 File Offset: 0x00945430
		public ABP_BaseRole_bakup_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_bakup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020756 RID: 132950 RVA: 0x00947258 File Offset: 0x00945458
		[NullableContext(1)]
		public ABP_BaseRole_bakup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_bakup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x06020757 RID: 132951 RVA: 0x0094728B File Offset: 0x0094548B
		// (set) Token: 0x06020758 RID: 132952 RVA: 0x0094729F File Offset: 0x0094549F
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_bakup_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_bakup_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x06020759 RID: 132953 RVA: 0x009472B4 File Offset: 0x009454B4
		// (set) Token: 0x0602075A RID: 132954 RVA: 0x009472C4 File Offset: 0x009454C4
		public unsafe float 跳跃速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_跳跃速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_跳跃速度) = value;
			}
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x0602075B RID: 132955 RVA: 0x009472D5 File Offset: 0x009454D5
		// (set) Token: 0x0602075C RID: 132956 RVA: 0x009472E9 File Offset: 0x009454E9
		public unsafe FVector 整体偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_整体偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_整体偏移) = value;
			}
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x0602075D RID: 132957 RVA: 0x009472FE File Offset: 0x009454FE
		// (set) Token: 0x0602075E RID: 132958 RVA: 0x00947312 File Offset: 0x00945512
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_bakup_C.__PropertyOffset_角色Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_bakup_C.__PropertyOffset_角色Mesh, value);
			}
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x0602075F RID: 132959 RVA: 0x00947327 File Offset: 0x00945527
		// (set) Token: 0x06020760 RID: 132960 RVA: 0x0094733B File Offset: 0x0094553B
		public unsafe FVector 整体偏移_实际使用_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_整体偏移_实际使用_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_整体偏移_实际使用_) = value;
			}
		}

		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x06020761 RID: 132961 RVA: 0x00947350 File Offset: 0x00945550
		// (set) Token: 0x06020762 RID: 132962 RVA: 0x00947360 File Offset: 0x00945560
		public unsafe bool 是否眩晕
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_是否眩晕) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_是否眩晕) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x06020763 RID: 132963 RVA: 0x00947371 File Offset: 0x00945571
		// (set) Token: 0x06020764 RID: 132964 RVA: 0x00947381 File Offset: 0x00945581
		public unsafe bool 是否壁上跳跃
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_是否壁上跳跃) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_是否壁上跳跃) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x06020765 RID: 132965 RVA: 0x00947394 File Offset: 0x00945594
		// (set) Token: 0x06020766 RID: 132966 RVA: 0x009473CD File Offset: 0x009455CD
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
					result = (this._左脚探测结果 = new FHitResult(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_左脚探测结果, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_左脚探测结果, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x06020767 RID: 132967 RVA: 0x009473F0 File Offset: 0x009455F0
		// (set) Token: 0x06020768 RID: 132968 RVA: 0x00947429 File Offset: 0x00945629
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
					result = (this._右脚探测结果 = new FHitResult(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_右脚探测结果, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_右脚探测结果, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x06020769 RID: 132969 RVA: 0x0094744A File Offset: 0x0094564A
		// (set) Token: 0x0602076A RID: 132970 RVA: 0x0094745A File Offset: 0x0094565A
		public unsafe bool 是否右手进入攀爬
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_是否右手进入攀爬) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_是否右手进入攀爬) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x0602076B RID: 132971 RVA: 0x0094746B File Offset: 0x0094566B
		// (set) Token: 0x0602076C RID: 132972 RVA: 0x0094747B File Offset: 0x0094567B
		public unsafe bool FASLE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_FASLE) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_FASLE) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x0602076D RID: 132973 RVA: 0x0094748C File Offset: 0x0094568C
		// (set) Token: 0x0602076E RID: 132974 RVA: 0x0094749C File Offset: 0x0094569C
		public unsafe float 钩索启动角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_钩索启动角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_钩索启动角度) = value;
			}
		}

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x0602076F RID: 132975 RVA: 0x009474AD File Offset: 0x009456AD
		// (set) Token: 0x06020770 RID: 132976 RVA: 0x009474BD File Offset: 0x009456BD
		public unsafe byte 反斜登顶退出
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_反斜登顶退出);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_反斜登顶退出) = value;
			}
		}

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x06020771 RID: 132977 RVA: 0x009474CE File Offset: 0x009456CE
		// (set) Token: 0x06020772 RID: 132978 RVA: 0x009474DE File Offset: 0x009456DE
		public unsafe float 巨物拉取角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_巨物拉取角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_巨物拉取角度) = value;
			}
		}

		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x06020773 RID: 132979 RVA: 0x009474EF File Offset: 0x009456EF
		// (set) Token: 0x06020774 RID: 132980 RVA: 0x009474FF File Offset: 0x009456FF
		public unsafe float 跳跃速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_跳跃速率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_跳跃速率) = value;
			}
		}

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x06020775 RID: 132981 RVA: 0x00947510 File Offset: 0x00945710
		// (set) Token: 0x06020776 RID: 132982 RVA: 0x00947520 File Offset: 0x00945720
		public unsafe bool 状态_XA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_XA) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_XA) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x06020777 RID: 132983 RVA: 0x00947531 File Offset: 0x00945731
		// (set) Token: 0x06020778 RID: 132984 RVA: 0x00947541 File Offset: 0x00945741
		public unsafe float XA_UD混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_XA_UD混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_XA_UD混合) = value;
			}
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x06020779 RID: 132985 RVA: 0x00947552 File Offset: 0x00945752
		// (set) Token: 0x0602077A RID: 132986 RVA: 0x00947562 File Offset: 0x00945762
		public unsafe float XA_RL混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_XA_RL混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_XA_RL混合) = value;
			}
		}

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x0602077B RID: 132987 RVA: 0x00947573 File Offset: 0x00945773
		// (set) Token: 0x0602077C RID: 132988 RVA: 0x00947583 File Offset: 0x00945783
		public unsafe bool EnableSwitchPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_EnableSwitchPose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_EnableSwitchPose) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x0602077D RID: 132989 RVA: 0x00947594 File Offset: 0x00945794
		// (set) Token: 0x0602077E RID: 132990 RVA: 0x009475A4 File Offset: 0x009457A4
		public unsafe float SwitchPoseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SwitchPoseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SwitchPoseTime) = value;
			}
		}

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x0602077F RID: 132991 RVA: 0x009475B5 File Offset: 0x009457B5
		// (set) Token: 0x06020780 RID: 132992 RVA: 0x009475C5 File Offset: 0x009457C5
		public unsafe float 上坡前倾
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_上坡前倾);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_上坡前倾) = value;
			}
		}

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x06020781 RID: 132993 RVA: 0x009475D6 File Offset: 0x009457D6
		// (set) Token: 0x06020782 RID: 132994 RVA: 0x009475E6 File Offset: 0x009457E6
		public unsafe float 上坡削弱IK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_上坡削弱IK);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_上坡削弱IK) = value;
			}
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x06020783 RID: 132995 RVA: 0x009475F7 File Offset: 0x009457F7
		// (set) Token: 0x06020784 RID: 132996 RVA: 0x00947607 File Offset: 0x00945807
		public unsafe bool 状态_空中_风筝
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_空中_风筝) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_空中_风筝) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x06020785 RID: 132997 RVA: 0x00947618 File Offset: 0x00945818
		// (set) Token: 0x06020786 RID: 132998 RVA: 0x00947628 File Offset: 0x00945828
		public unsafe bool IsVehicleImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_IsVehicleImpact) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_IsVehicleImpact) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x06020787 RID: 132999 RVA: 0x00947639 File Offset: 0x00945839
		// (set) Token: 0x06020788 RID: 133000 RVA: 0x00947649 File Offset: 0x00945849
		public unsafe float VehicleCollisionStrength_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleCollisionStrength_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleCollisionStrength_0) = value;
			}
		}

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x06020789 RID: 133001 RVA: 0x0094765A File Offset: 0x0094585A
		// (set) Token: 0x0602078A RID: 133002 RVA: 0x0094766A File Offset: 0x0094586A
		public unsafe float VehicleCollisionAngle_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleCollisionAngle_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleCollisionAngle_0) = value;
			}
		}

		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x0602078B RID: 133003 RVA: 0x0094767B File Offset: 0x0094587B
		// (set) Token: 0x0602078C RID: 133004 RVA: 0x0094768B File Offset: 0x0094588B
		public unsafe float VehicleCollisionAlpha_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleCollisionAlpha_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleCollisionAlpha_0) = value;
			}
		}

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x0602078D RID: 133005 RVA: 0x0094769C File Offset: 0x0094589C
		// (set) Token: 0x0602078E RID: 133006 RVA: 0x009476B0 File Offset: 0x009458B0
		public unsafe FVector4 VehicleCollisionMix_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleCollisionMix_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleCollisionMix_0) = value;
			}
		}

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x0602078F RID: 133007 RVA: 0x009476C5 File Offset: 0x009458C5
		// (set) Token: 0x06020790 RID: 133008 RVA: 0x009476D9 File Offset: 0x009458D9
		public unsafe FRotator VehicleSeatRot_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleSeatRot_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleSeatRot_0) = value;
			}
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x06020791 RID: 133009 RVA: 0x009476EE File Offset: 0x009458EE
		// (set) Token: 0x06020792 RID: 133010 RVA: 0x009476FE File Offset: 0x009458FE
		public unsafe bool TestCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_TestCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_TestCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x06020793 RID: 133011 RVA: 0x0094770F File Offset: 0x0094590F
		// (set) Token: 0x06020794 RID: 133012 RVA: 0x00947723 File Offset: 0x00945923
		public unsafe FVector4 VehicleSuddenMoveMix_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleSuddenMoveMix_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_VehicleSuddenMoveMix_0) = value;
			}
		}

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x06020795 RID: 133013 RVA: 0x00947738 File Offset: 0x00945938
		// (set) Token: 0x06020796 RID: 133014 RVA: 0x00947748 File Offset: 0x00945948
		public unsafe float LastForwardSpeed_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_LastForwardSpeed_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_LastForwardSpeed_0) = value;
			}
		}

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x06020797 RID: 133015 RVA: 0x00947759 File Offset: 0x00945959
		// (set) Token: 0x06020798 RID: 133016 RVA: 0x00947769 File Offset: 0x00945969
		public unsafe float CurForwardSpeed_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_CurForwardSpeed_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_CurForwardSpeed_0) = value;
			}
		}

		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x06020799 RID: 133017 RVA: 0x0094777A File Offset: 0x0094597A
		// (set) Token: 0x0602079A RID: 133018 RVA: 0x0094778A File Offset: 0x0094598A
		public unsafe float LastSeatRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_LastSeatRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_LastSeatRoll) = value;
			}
		}

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x0602079B RID: 133019 RVA: 0x0094779B File Offset: 0x0094599B
		// (set) Token: 0x0602079C RID: 133020 RVA: 0x009477AB File Offset: 0x009459AB
		public unsafe float CurSeatRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_CurSeatRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_CurSeatRoll) = value;
			}
		}

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x0602079D RID: 133021 RVA: 0x009477BC File Offset: 0x009459BC
		// (set) Token: 0x0602079E RID: 133022 RVA: 0x009477CC File Offset: 0x009459CC
		public unsafe float SuddenMoveCd_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SuddenMoveCd_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SuddenMoveCd_0) = value;
			}
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x0602079F RID: 133023 RVA: 0x009477DD File Offset: 0x009459DD
		// (set) Token: 0x060207A0 RID: 133024 RVA: 0x009477ED File Offset: 0x009459ED
		public unsafe bool SuddenMoveTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SuddenMoveTrigger) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SuddenMoveTrigger) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x060207A1 RID: 133025 RVA: 0x009477FE File Offset: 0x009459FE
		// (set) Token: 0x060207A2 RID: 133026 RVA: 0x0094780E File Offset: 0x00945A0E
		public unsafe bool SuddenStopTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SuddenStopTrigger) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SuddenStopTrigger) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x060207A3 RID: 133027 RVA: 0x0094781F File Offset: 0x00945A1F
		// (set) Token: 0x060207A4 RID: 133028 RVA: 0x00947833 File Offset: 0x00945A33
		public unsafe FVector 相对空中速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_相对空中速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_相对空中速度) = value;
			}
		}

		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x060207A5 RID: 133029 RVA: 0x00947848 File Offset: 0x00945A48
		// (set) Token: 0x060207A6 RID: 133030 RVA: 0x00947858 File Offset: 0x00945A58
		public unsafe bool 状态_滑轨
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_滑轨) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_滑轨) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x060207A7 RID: 133031 RVA: 0x00947869 File Offset: 0x00945A69
		// (set) Token: 0x060207A8 RID: 133032 RVA: 0x00947879 File Offset: 0x00945A79
		public unsafe bool 状态_滑轨_空中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_滑轨_空中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_滑轨_空中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x060207A9 RID: 133033 RVA: 0x0094788A File Offset: 0x00945A8A
		// (set) Token: 0x060207AA RID: 133034 RVA: 0x0094789A File Offset: 0x00945A9A
		public unsafe bool 滑轨落地动画
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_滑轨落地动画) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_滑轨落地动画) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x060207AB RID: 133035 RVA: 0x009478AB File Offset: 0x00945AAB
		// (set) Token: 0x060207AC RID: 133036 RVA: 0x009478BB File Offset: 0x00945ABB
		public unsafe bool 状态_滑轨_空中_右侧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_滑轨_空中_右侧) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_滑轨_空中_右侧) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x060207AD RID: 133037 RVA: 0x009478CC File Offset: 0x00945ACC
		// (set) Token: 0x060207AE RID: 133038 RVA: 0x009478DC File Offset: 0x00945ADC
		public unsafe bool 状态_牵手_牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_牵手_牵手中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_牵手_牵手中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x060207AF RID: 133039 RVA: 0x009478ED File Offset: 0x00945AED
		// (set) Token: 0x060207B0 RID: 133040 RVA: 0x009478FD File Offset: 0x00945AFD
		public unsafe bool 状态_牵手_被牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_牵手_被牵手中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_牵手_被牵手中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x060207B1 RID: 133041 RVA: 0x0094790E File Offset: 0x00945B0E
		// (set) Token: 0x060207B2 RID: 133042 RVA: 0x0094791E File Offset: 0x00945B1E
		public unsafe bool 状态_牵手_范围内
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_牵手_范围内) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_牵手_范围内) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x060207B3 RID: 133043 RVA: 0x0094792F File Offset: 0x00945B2F
		// (set) Token: 0x060207B4 RID: 133044 RVA: 0x0094793F File Offset: 0x00945B3F
		public unsafe bool IsInPlotBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_IsInPlotBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_IsInPlotBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x060207B5 RID: 133045 RVA: 0x00947950 File Offset: 0x00945B50
		// (set) Token: 0x060207B6 RID: 133046 RVA: 0x00947960 File Offset: 0x00945B60
		public unsafe float 移动平台IKAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_移动平台IKAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_移动平台IKAlpha) = value;
			}
		}

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x060207B7 RID: 133047 RVA: 0x00947971 File Offset: 0x00945B71
		// (set) Token: 0x060207B8 RID: 133048 RVA: 0x00947981 File Offset: 0x00945B81
		public unsafe bool 移动平台移动中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_移动平台移动中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_移动平台移动中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x060207B9 RID: 133049 RVA: 0x00947992 File Offset: 0x00945B92
		// (set) Token: 0x060207BA RID: 133050 RVA: 0x009479A2 File Offset: 0x00945BA2
		public unsafe bool 状态_基础移动替换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_基础移动替换) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_基础移动替换) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x060207BB RID: 133051 RVA: 0x009479B3 File Offset: 0x00945BB3
		// (set) Token: 0x060207BC RID: 133052 RVA: 0x009479C3 File Offset: 0x00945BC3
		public unsafe bool 状态_样条跑墙
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_样条跑墙) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_样条跑墙) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x060207BD RID: 133053 RVA: 0x009479D4 File Offset: 0x00945BD4
		// (set) Token: 0x060207BE RID: 133054 RVA: 0x009479E4 File Offset: 0x00945BE4
		public unsafe bool 状态_上坡动画替换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_上坡动画替换) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_上坡动画替换) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x060207BF RID: 133055 RVA: 0x009479F5 File Offset: 0x00945BF5
		// (set) Token: 0x060207C0 RID: 133056 RVA: 0x00947A05 File Offset: 0x00945C05
		public unsafe bool 状态_强制更新源姿势
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_强制更新源姿势) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_强制更新源姿势) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x060207C1 RID: 133057 RVA: 0x00947A16 File Offset: 0x00945C16
		// (set) Token: 0x060207C2 RID: 133058 RVA: 0x00947A26 File Offset: 0x00945C26
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_地区运动模式) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_地区运动模式) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x060207C3 RID: 133059 RVA: 0x00947A37 File Offset: 0x00945C37
		// (set) Token: 0x060207C4 RID: 133060 RVA: 0x00947A47 File Offset: 0x00945C47
		public unsafe bool 状态_载具驾驶_摩托
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_载具驾驶_摩托) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_载具驾驶_摩托) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x060207C5 RID: 133061 RVA: 0x00947A58 File Offset: 0x00945C58
		// (set) Token: 0x060207C6 RID: 133062 RVA: 0x00947A68 File Offset: 0x00945C68
		public unsafe bool 状态_地区动作保留
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_地区动作保留) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_地区动作保留) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x060207C7 RID: 133063 RVA: 0x00947A79 File Offset: 0x00945C79
		// (set) Token: 0x060207C8 RID: 133064 RVA: 0x00947A89 File Offset: 0x00945C89
		public unsafe bool 状态_强制关闭IK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_强制关闭IK) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_强制关闭IK) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x060207C9 RID: 133065 RVA: 0x00947A9A File Offset: 0x00945C9A
		// (set) Token: 0x060207CA RID: 133066 RVA: 0x00947AAA File Offset: 0x00945CAA
		public unsafe float SightLockYawMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockYawMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockYawMin) = value;
			}
		}

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x060207CB RID: 133067 RVA: 0x00947ABB File Offset: 0x00945CBB
		// (set) Token: 0x060207CC RID: 133068 RVA: 0x00947ACB File Offset: 0x00945CCB
		public unsafe float SightLockYawMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockYawMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockYawMax) = value;
			}
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x060207CD RID: 133069 RVA: 0x00947ADC File Offset: 0x00945CDC
		// (set) Token: 0x060207CE RID: 133070 RVA: 0x00947AEC File Offset: 0x00945CEC
		public unsafe float SightLockPitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockPitchMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockPitchMin) = value;
			}
		}

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x060207CF RID: 133071 RVA: 0x00947AFD File Offset: 0x00945CFD
		// (set) Token: 0x060207D0 RID: 133072 RVA: 0x00947B0D File Offset: 0x00945D0D
		public unsafe float SightLockPitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockPitchMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockPitchMax) = value;
			}
		}

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x060207D1 RID: 133073 RVA: 0x00947B1E File Offset: 0x00945D1E
		// (set) Token: 0x060207D2 RID: 133074 RVA: 0x00947B2E File Offset: 0x00945D2E
		public unsafe float SightLockAssitLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockAssitLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightLockAssitLimit) = value;
			}
		}

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x060207D3 RID: 133075 RVA: 0x00947B3F File Offset: 0x00945D3F
		// (set) Token: 0x060207D4 RID: 133076 RVA: 0x00947B4F File Offset: 0x00945D4F
		public unsafe bool 状态_关闭FB受击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_关闭FB受击) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_关闭FB受击) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x060207D5 RID: 133077 RVA: 0x00947B60 File Offset: 0x00945D60
		// (set) Token: 0x060207D6 RID: 133078 RVA: 0x00947B70 File Offset: 0x00945D70
		public unsafe float 普通运动转基础移动BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_普通运动转基础移动BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_普通运动转基础移动BlendTime) = value;
			}
		}

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x060207D7 RID: 133079 RVA: 0x00947B81 File Offset: 0x00945D81
		// (set) Token: 0x060207D8 RID: 133080 RVA: 0x00947B91 File Offset: 0x00945D91
		public unsafe float 基础移动转普通运动BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_基础移动转普通运动BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_基础移动转普通运动BlendTime) = value;
			}
		}

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x060207D9 RID: 133081 RVA: 0x00947BA2 File Offset: 0x00945DA2
		// (set) Token: 0x060207DA RID: 133082 RVA: 0x00947BB2 File Offset: 0x00945DB2
		public unsafe bool 滑轨启用定制动作
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_滑轨启用定制动作) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_滑轨启用定制动作) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x060207DB RID: 133083 RVA: 0x00947BC3 File Offset: 0x00945DC3
		// (set) Token: 0x060207DC RID: 133084 RVA: 0x00947BD3 File Offset: 0x00945DD3
		public unsafe bool 状态_滑轨_空中_前向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_滑轨_空中_前向) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_状态_滑轨_空中_前向) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x060207DD RID: 133085 RVA: 0x00947BE4 File Offset: 0x00945DE4
		// (set) Token: 0x060207DE RID: 133086 RVA: 0x00947BF8 File Offset: 0x00945DF8
		public unsafe FVector SightDirectInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightDirectInSightBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_SightDirectInSightBone) = value;
			}
		}

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x060207DF RID: 133087 RVA: 0x00947C0D File Offset: 0x00945E0D
		// (set) Token: 0x060207E0 RID: 133088 RVA: 0x00947C21 File Offset: 0x00945E21
		public unsafe FVector UpAxisInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_UpAxisInSightBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_bakup_C.__PropertyOffset_UpAxisInSightBone) = value;
			}
		}

		// Token: 0x060207E1 RID: 133089 RVA: 0x00947C38 File Offset: 0x00945E38
		[SkipLocalsInit]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_BaseRole_bakup_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x060207E2 RID: 133090 RVA: 0x00947C87 File Offset: 0x00945E87
		[SkipLocalsInit]
		public virtual void 更新载具信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__更新载具信息_NativeFunctionPtr, null);
		}

		// Token: 0x060207E3 RID: 133091 RVA: 0x00947C9B File Offset: 0x00945E9B
		[SkipLocalsInit]
		public virtual void 风筝移动更新()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__风筝移动更新_NativeFunctionPtr, null);
		}

		// Token: 0x060207E4 RID: 133092 RVA: 0x00947CAF File Offset: 0x00945EAF
		[SkipLocalsInit]
		public virtual void 移动平台和上坡IK削弱()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__移动平台和上坡IK削弱_NativeFunctionPtr, null);
		}

		// Token: 0x060207E5 RID: 133093 RVA: 0x00947CC3 File Offset: 0x00945EC3
		[SkipLocalsInit]
		public virtual void 落地速度切割初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__落地速度切割初始化_NativeFunctionPtr, null);
		}

		// Token: 0x060207E6 RID: 133094 RVA: 0x00947CD8 File Offset: 0x00945ED8
		[SkipLocalsInit]
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

		// Token: 0x060207E7 RID: 133095 RVA: 0x00947D46 File Offset: 0x00945F46
		[SkipLocalsInit]
		public virtual void XA状态更新()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__XA状态更新_NativeFunctionPtr, null);
		}

		// Token: 0x060207E8 RID: 133096 RVA: 0x00947D5C File Offset: 0x00945F5C
		[SkipLocalsInit]
		public unsafe virtual void 设置跳跃速率(float 新速率)
		{
			ABP_BaseRole_bakup_C.__设置跳跃速率_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__设置跳跃速率_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__设置跳跃速率_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__设置跳跃速率_NativeFunctionPtr, (void*)ptr, 1);
			ptr->新速率 = 新速率;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__设置跳跃速率_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207E9 RID: 133097 RVA: 0x00947DA2 File Offset: 0x00945FA2
		[SkipLocalsInit]
		public virtual void 冰冻结束事件()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__冰冻结束事件_NativeFunctionPtr, null);
		}

		// Token: 0x060207EA RID: 133098 RVA: 0x00947DB8 File Offset: 0x00945FB8
		[SkipLocalsInit]
		public unsafe virtual void 计算跳跃混合(float 速度, ref float 混合)
		{
			ABP_BaseRole_bakup_C.__计算跳跃混合_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__计算跳跃混合_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__计算跳跃混合_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__计算跳跃混合_NativeFunctionPtr, (void*)ptr, 1);
			ptr->速度 = 速度;
			ptr->混合 = 混合;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__计算跳跃混合_NativeFunctionPtr, (void*)ptr);
			混合 = ptr->混合;
		}

		// Token: 0x060207EB RID: 133099 RVA: 0x00947E0E File Offset: 0x0094600E
		[SkipLocalsInit]
		public virtual void CleanAnimVariable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__CleanAnimVariable_NativeFunctionPtr, null);
		}

		// Token: 0x060207EC RID: 133100 RVA: 0x00947E24 File Offset: 0x00946024
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x060207ED RID: 133101 RVA: 0x00947EAC File Offset: 0x009460AC
		[SkipLocalsInit]
		public virtual void 更新上传()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__更新上传_NativeFunctionPtr, null);
		}

		// Token: 0x060207EE RID: 133102 RVA: 0x00947EC0 File Offset: 0x009460C0
		[SkipLocalsInit]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x060207EF RID: 133103 RVA: 0x00947ED4 File Offset: 0x009460D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 替换角色时同步动作数据(ABP_BaseRole_C 切出角色AnimIns)
		{
			ABP_BaseRole_bakup_C.__替换角色时同步动作数据_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__替换角色时同步动作数据_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__替换角色时同步动作数据_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__替换角色时同步动作数据_NativeFunctionPtr, (void*)ptr, 1);
			ptr->切出角色AnimIns = ((切出角色AnimIns != null) ? 切出角色AnimIns.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__替换角色时同步动作数据_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207F0 RID: 133104 RVA: 0x00947F2C File Offset: 0x0094612C
		[SkipLocalsInit]
		public unsafe virtual void 设置头部转向状态(SightLockMode SightMode)
		{
			ABP_BaseRole_bakup_C.__设置头部转向状态_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__设置头部转向状态_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__设置头部转向状态_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SightMode = SightMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207F1 RID: 133105 RVA: 0x00947F72 File Offset: 0x00946172
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x060207F2 RID: 133106 RVA: 0x00947F86 File Offset: 0x00946186
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x060207F3 RID: 133107 RVA: 0x00947F9A File Offset: 0x0094619A
		[SkipLocalsInit]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x060207F4 RID: 133108 RVA: 0x00947FAE File Offset: 0x009461AE
		[SkipLocalsInit]
		public virtual void TestFk()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__TestFk_NativeFunctionPtr, null);
		}

		// Token: 0x060207F5 RID: 133109 RVA: 0x00947FC4 File Offset: 0x009461C4
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207F6 RID: 133110 RVA: 0x0094800C File Offset: 0x0094620C
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207F7 RID: 133111 RVA: 0x00948054 File Offset: 0x00946254
		[SkipLocalsInit]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_BaseRole_bakup_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207F8 RID: 133112 RVA: 0x0094809A File Offset: 0x0094629A
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x060207F9 RID: 133113 RVA: 0x009480AE File Offset: 0x009462AE
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x060207FA RID: 133114 RVA: 0x009480C4 File Offset: 0x009462C4
		[SkipLocalsInit]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_BaseRole_bakup_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207FB RID: 133115 RVA: 0x0094810C File Offset: 0x0094630C
		[SkipLocalsInit]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207FC RID: 133116 RVA: 0x00948152 File Offset: 0x00946352
		[SkipLocalsInit]
		public virtual void ClearClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__ClearClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x060207FD RID: 133117 RVA: 0x00948168 File Offset: 0x00946368
		[SkipLocalsInit]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207FE RID: 133118 RVA: 0x009481AE File Offset: 0x009463AE
		[SkipLocalsInit]
		public virtual void PlotBlendIn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__PlotBlendIn_NativeFunctionPtr, null);
		}

		// Token: 0x060207FF RID: 133119 RVA: 0x009481C2 File Offset: 0x009463C2
		[SkipLocalsInit]
		public virtual void NoExpose()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_bakup_C.__NoExpose_NativeFunctionPtr, null);
		}

		// Token: 0x06020800 RID: 133120 RVA: 0x009481D8 File Offset: 0x009463D8
		[SkipLocalsInit]
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

		// Token: 0x06020801 RID: 133121 RVA: 0x0094824C File Offset: 0x0094644C
		protected ABP_BaseRole_bakup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401189A RID: 71834
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_BaseRole_bakup.ABP_BaseRole_bakup_C";

		// Token: 0x0401189B RID: 71835
		private static IntPtr _ClassPtr;

		// Token: 0x0401189C RID: 71836
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401189D RID: 71837
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x0401189E RID: 71838
		internal static int __PropertyOffset_跳跃速度;

		// Token: 0x0401189F RID: 71839
		internal static int __PropertyOffset_整体偏移;

		// Token: 0x040118A0 RID: 71840
		internal static int __PropertyOffset_角色Mesh;

		// Token: 0x040118A1 RID: 71841
		internal static int __PropertyOffset_整体偏移_实际使用_;

		// Token: 0x040118A2 RID: 71842
		internal static int __PropertyOffset_是否眩晕;

		// Token: 0x040118A3 RID: 71843
		internal static int __PropertyOffset_是否壁上跳跃;

		// Token: 0x040118A4 RID: 71844
		internal static int __PropertyOffset_左脚探测结果;

		// Token: 0x040118A5 RID: 71845
		[Nullable(2)]
		private FHitResult _左脚探测结果;

		// Token: 0x040118A6 RID: 71846
		internal static int __PropertyOffset_右脚探测结果;

		// Token: 0x040118A7 RID: 71847
		[Nullable(2)]
		private FHitResult _右脚探测结果;

		// Token: 0x040118A8 RID: 71848
		internal static int __PropertyOffset_是否右手进入攀爬;

		// Token: 0x040118A9 RID: 71849
		internal static int __PropertyOffset_FASLE;

		// Token: 0x040118AA RID: 71850
		internal static int __PropertyOffset_钩索启动角度;

		// Token: 0x040118AB RID: 71851
		internal static int __PropertyOffset_反斜登顶退出;

		// Token: 0x040118AC RID: 71852
		internal static int __PropertyOffset_巨物拉取角度;

		// Token: 0x040118AD RID: 71853
		internal static int __PropertyOffset_跳跃速率;

		// Token: 0x040118AE RID: 71854
		internal static int __PropertyOffset_状态_XA;

		// Token: 0x040118AF RID: 71855
		internal static int __PropertyOffset_XA_UD混合;

		// Token: 0x040118B0 RID: 71856
		internal static int __PropertyOffset_XA_RL混合;

		// Token: 0x040118B1 RID: 71857
		internal static int __PropertyOffset_EnableSwitchPose;

		// Token: 0x040118B2 RID: 71858
		internal static int __PropertyOffset_SwitchPoseTime;

		// Token: 0x040118B3 RID: 71859
		internal static int __PropertyOffset_上坡前倾;

		// Token: 0x040118B4 RID: 71860
		internal static int __PropertyOffset_上坡削弱IK;

		// Token: 0x040118B5 RID: 71861
		internal static int __PropertyOffset_状态_空中_风筝;

		// Token: 0x040118B6 RID: 71862
		internal static int __PropertyOffset_IsVehicleImpact;

		// Token: 0x040118B7 RID: 71863
		internal static int __PropertyOffset_VehicleCollisionStrength_0;

		// Token: 0x040118B8 RID: 71864
		internal static int __PropertyOffset_VehicleCollisionAngle_0;

		// Token: 0x040118B9 RID: 71865
		internal static int __PropertyOffset_VehicleCollisionAlpha_0;

		// Token: 0x040118BA RID: 71866
		internal static int __PropertyOffset_VehicleCollisionMix_0;

		// Token: 0x040118BB RID: 71867
		internal static int __PropertyOffset_VehicleSeatRot_0;

		// Token: 0x040118BC RID: 71868
		internal static int __PropertyOffset_TestCollision;

		// Token: 0x040118BD RID: 71869
		internal static int __PropertyOffset_VehicleSuddenMoveMix_0;

		// Token: 0x040118BE RID: 71870
		internal static int __PropertyOffset_LastForwardSpeed_0;

		// Token: 0x040118BF RID: 71871
		internal static int __PropertyOffset_CurForwardSpeed_0;

		// Token: 0x040118C0 RID: 71872
		internal static int __PropertyOffset_LastSeatRoll;

		// Token: 0x040118C1 RID: 71873
		internal static int __PropertyOffset_CurSeatRoll;

		// Token: 0x040118C2 RID: 71874
		internal static int __PropertyOffset_SuddenMoveCd_0;

		// Token: 0x040118C3 RID: 71875
		internal static int __PropertyOffset_SuddenMoveTrigger;

		// Token: 0x040118C4 RID: 71876
		internal static int __PropertyOffset_SuddenStopTrigger;

		// Token: 0x040118C5 RID: 71877
		internal static int __PropertyOffset_相对空中速度;

		// Token: 0x040118C6 RID: 71878
		internal static int __PropertyOffset_状态_滑轨;

		// Token: 0x040118C7 RID: 71879
		internal static int __PropertyOffset_状态_滑轨_空中;

		// Token: 0x040118C8 RID: 71880
		internal static int __PropertyOffset_滑轨落地动画;

		// Token: 0x040118C9 RID: 71881
		internal static int __PropertyOffset_状态_滑轨_空中_右侧;

		// Token: 0x040118CA RID: 71882
		internal static int __PropertyOffset_状态_牵手_牵手中;

		// Token: 0x040118CB RID: 71883
		internal static int __PropertyOffset_状态_牵手_被牵手中;

		// Token: 0x040118CC RID: 71884
		internal static int __PropertyOffset_状态_牵手_范围内;

		// Token: 0x040118CD RID: 71885
		internal static int __PropertyOffset_IsInPlotBlend;

		// Token: 0x040118CE RID: 71886
		internal static int __PropertyOffset_移动平台IKAlpha;

		// Token: 0x040118CF RID: 71887
		internal static int __PropertyOffset_移动平台移动中;

		// Token: 0x040118D0 RID: 71888
		internal static int __PropertyOffset_状态_基础移动替换;

		// Token: 0x040118D1 RID: 71889
		internal static int __PropertyOffset_状态_样条跑墙;

		// Token: 0x040118D2 RID: 71890
		internal static int __PropertyOffset_状态_上坡动画替换;

		// Token: 0x040118D3 RID: 71891
		internal static int __PropertyOffset_状态_强制更新源姿势;

		// Token: 0x040118D4 RID: 71892
		internal static int __PropertyOffset_状态_地区运动模式;

		// Token: 0x040118D5 RID: 71893
		internal static int __PropertyOffset_状态_载具驾驶_摩托;

		// Token: 0x040118D6 RID: 71894
		internal static int __PropertyOffset_状态_地区动作保留;

		// Token: 0x040118D7 RID: 71895
		internal static int __PropertyOffset_状态_强制关闭IK;

		// Token: 0x040118D8 RID: 71896
		internal static int __PropertyOffset_SightLockYawMin;

		// Token: 0x040118D9 RID: 71897
		internal static int __PropertyOffset_SightLockYawMax;

		// Token: 0x040118DA RID: 71898
		internal static int __PropertyOffset_SightLockPitchMin;

		// Token: 0x040118DB RID: 71899
		internal static int __PropertyOffset_SightLockPitchMax;

		// Token: 0x040118DC RID: 71900
		internal static int __PropertyOffset_SightLockAssitLimit;

		// Token: 0x040118DD RID: 71901
		internal static int __PropertyOffset_状态_关闭FB受击;

		// Token: 0x040118DE RID: 71902
		internal static int __PropertyOffset_普通运动转基础移动BlendTime;

		// Token: 0x040118DF RID: 71903
		internal static int __PropertyOffset_基础移动转普通运动BlendTime;

		// Token: 0x040118E0 RID: 71904
		internal static int __PropertyOffset_滑轨启用定制动作;

		// Token: 0x040118E1 RID: 71905
		internal static int __PropertyOffset_状态_滑轨_空中_前向;

		// Token: 0x040118E2 RID: 71906
		internal static int __PropertyOffset_SightDirectInSightBone;

		// Token: 0x040118E3 RID: 71907
		internal static int __PropertyOffset_UpAxisInSightBone;

		// Token: 0x040118E4 RID: 71908
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x040118E5 RID: 71909
		private static IntPtr __更新载具信息_NativeFunctionPtr;

		// Token: 0x040118E6 RID: 71910
		private static IntPtr __风筝移动更新_NativeFunctionPtr;

		// Token: 0x040118E7 RID: 71911
		private static IntPtr __移动平台和上坡IK削弱_NativeFunctionPtr;

		// Token: 0x040118E8 RID: 71912
		private static IntPtr __落地速度切割初始化_NativeFunctionPtr;

		// Token: 0x040118E9 RID: 71913
		private static IntPtr __VelocityBlendLerp_NativeFunctionPtr;

		// Token: 0x040118EA RID: 71914
		private static IntPtr __XA状态更新_NativeFunctionPtr;

		// Token: 0x040118EB RID: 71915
		private static IntPtr __设置跳跃速率_NativeFunctionPtr;

		// Token: 0x040118EC RID: 71916
		private static IntPtr __冰冻结束事件_NativeFunctionPtr;

		// Token: 0x040118ED RID: 71917
		private static IntPtr __计算跳跃混合_NativeFunctionPtr;

		// Token: 0x040118EE RID: 71918
		private static IntPtr __CleanAnimVariable_NativeFunctionPtr;

		// Token: 0x040118EF RID: 71919
		private static IntPtr __True布尔序列输出_NativeFunctionPtr;

		// Token: 0x040118F0 RID: 71920
		private static IntPtr __更新上传_NativeFunctionPtr;

		// Token: 0x040118F1 RID: 71921
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x040118F2 RID: 71922
		private static IntPtr __替换角色时同步动作数据_NativeFunctionPtr;

		// Token: 0x040118F3 RID: 71923
		private static IntPtr __设置头部转向状态_NativeFunctionPtr;

		// Token: 0x040118F4 RID: 71924
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x040118F5 RID: 71925
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x040118F6 RID: 71926
		private static IntPtr __TestFk_NativeFunctionPtr;

		// Token: 0x040118F7 RID: 71927
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x040118F8 RID: 71928
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x040118F9 RID: 71929
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x040118FA RID: 71930
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x040118FB RID: 71931
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x040118FC RID: 71932
		private static IntPtr __ClearClimbDash_NativeFunctionPtr;

		// Token: 0x040118FD RID: 71933
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x040118FE RID: 71934
		private static IntPtr __PlotBlendIn_NativeFunctionPtr;

		// Token: 0x040118FF RID: 71935
		private static IntPtr __NoExpose_NativeFunctionPtr;

		// Token: 0x04011900 RID: 71936
		private static IntPtr __SetSightLockConfig_NativeFunctionPtr;

		// Token: 0x02008F6E RID: 36718
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x0402CCF0 RID: 183536
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008F6F RID: 36719
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 84)]
		protected ref struct __VelocityBlendLerp_FunctionParams
		{
			// Token: 0x0402CCF1 RID: 183537
			[FieldOffset(0)]
			public FVeloctiyBlend From;

			// Token: 0x0402CCF2 RID: 183538
			[FieldOffset(16)]
			public FVeloctiyBlend To;

			// Token: 0x0402CCF3 RID: 183539
			[FieldOffset(32)]
			public float Alpha;

			// Token: 0x0402CCF4 RID: 183540
			[FieldOffset(36)]
			public FVeloctiyBlend Out;
		}

		// Token: 0x02008F70 RID: 36720
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __设置跳跃速率_FunctionParams
		{
			// Token: 0x0402CCF5 RID: 183541
			[FieldOffset(0)]
			public float 新速率;
		}

		// Token: 0x02008F71 RID: 36721
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __计算跳跃混合_FunctionParams
		{
			// Token: 0x0402CCF6 RID: 183542
			[FieldOffset(0)]
			public float 速度;

			// Token: 0x0402CCF7 RID: 183543
			[FieldOffset(4)]
			public float 混合;
		}

		// Token: 0x02008F72 RID: 36722
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __True布尔序列输出_FunctionParams
		{
			// Token: 0x0402CCF8 RID: 183544
			[FieldOffset(0)]
			public byte ValArrt_Bool;

			// Token: 0x0402CCF9 RID: 183545
			[FieldOffset(16)]
			public int Out;
		}

		// Token: 0x02008F73 RID: 36723
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __替换角色时同步动作数据_FunctionParams
		{
			// Token: 0x0402CCFA RID: 183546
			[FieldOffset(0)]
			public IntPtr 切出角色AnimIns;
		}

		// Token: 0x02008F74 RID: 36724
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __设置头部转向状态_FunctionParams
		{
			// Token: 0x0402CCFB RID: 183547
			[FieldOffset(0)]
			public SightLockMode SightMode;
		}

		// Token: 0x02008F75 RID: 36725
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CCFC RID: 183548
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x02008F76 RID: 36726
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x0402CCFD RID: 183549
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008F77 RID: 36727
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x0402CCFE RID: 183550
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008F78 RID: 36728
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x0402CCFF RID: 183551
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008F79 RID: 36729
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x0402CD00 RID: 183552
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x02008F7A RID: 36730
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __SetSightLockConfig_FunctionParams
		{
			// Token: 0x0402CD01 RID: 183553
			[FieldOffset(0)]
			public float YawMin;

			// Token: 0x0402CD02 RID: 183554
			[FieldOffset(4)]
			public float YawMax;

			// Token: 0x0402CD03 RID: 183555
			[FieldOffset(8)]
			public float PitchMin;

			// Token: 0x0402CD04 RID: 183556
			[FieldOffset(12)]
			public float PitchMax;

			// Token: 0x0402CD05 RID: 183557
			[FieldOffset(16)]
			public float AssitLimit;

			// Token: 0x0402CD06 RID: 183558
			[FieldOffset(20)]
			public FVector SightDirectInSightBone;

			// Token: 0x0402CD07 RID: 183559
			[FieldOffset(32)]
			public FVector UpAxisInSightBone;
		}
	}
}
