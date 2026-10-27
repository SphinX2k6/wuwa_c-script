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
	// Token: 0x0200418F RID: 16783
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/RoleNPC/ABP_BaseRoleNPC.ABP_BaseRoleNPC_C")]
	[UnrealStructLayout(56672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56668)]
	public class ABP_BaseRoleNPC_C : UKuroAnimInstanceChar, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B792 RID: 178066 RVA: 0x00A01C7F File Offset: 0x009FFE7F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRoleNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/RoleNPC/ABP_BaseRoleNPC.ABP_BaseRoleNPC_C");
			}
			return ABP_BaseRoleNPC_C._ClassPtr;
		}

		// Token: 0x0602B793 RID: 178067 RVA: 0x00A01CA4 File Offset: 0x009FFEA4
		public ABP_BaseRoleNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRoleNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B794 RID: 178068 RVA: 0x00A01CCC File Offset: 0x009FFECC
		[NullableContext(1)]
		public ABP_BaseRoleNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRoleNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B4F RID: 27471
		// (get) Token: 0x0602B795 RID: 178069 RVA: 0x00A01CFF File Offset: 0x009FFEFF
		// (set) Token: 0x0602B796 RID: 178070 RVA: 0x00A01D13 File Offset: 0x009FFF13
		public unsafe TsBaseCharacter 角色蓝图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_365);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_365, value);
			}
		}

		// Token: 0x17006B50 RID: 27472
		// (get) Token: 0x0602B797 RID: 178071 RVA: 0x00A01D28 File Offset: 0x009FFF28
		// (set) Token: 0x0602B798 RID: 178072 RVA: 0x00A01D38 File Offset: 0x009FFF38
		public unsafe float DeltaTimeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_366);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_366) = value;
			}
		}

		// Token: 0x17006B51 RID: 27473
		// (get) Token: 0x0602B799 RID: 178073 RVA: 0x00A01D49 File Offset: 0x009FFF49
		// (set) Token: 0x0602B79A RID: 178074 RVA: 0x00A01D5D File Offset: 0x009FFF5D
		public unsafe FVector 速度向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_367);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_367) = value;
			}
		}

		// Token: 0x17006B52 RID: 27474
		// (get) Token: 0x0602B79B RID: 178075 RVA: 0x00A01D72 File Offset: 0x009FFF72
		// (set) Token: 0x0602B79C RID: 178076 RVA: 0x00A01D86 File Offset: 0x009FFF86
		public unsafe FVector 加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_368);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_368) = value;
			}
		}

		// Token: 0x17006B53 RID: 27475
		// (get) Token: 0x0602B79D RID: 178077 RVA: 0x00A01D9B File Offset: 0x009FFF9B
		// (set) Token: 0x0602B79E RID: 178078 RVA: 0x00A01DAF File Offset: 0x009FFFAF
		public unsafe FVector 移动输入向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_369);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_369) = value;
			}
		}

		// Token: 0x17006B54 RID: 27476
		// (get) Token: 0x0602B79F RID: 178079 RVA: 0x00A01DC4 File Offset: 0x009FFFC4
		// (set) Token: 0x0602B7A0 RID: 178080 RVA: 0x00A01DD4 File Offset: 0x009FFFD4
		public unsafe bool 是否正在移动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_370) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_370) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B55 RID: 27477
		// (get) Token: 0x0602B7A1 RID: 178081 RVA: 0x00A01DE5 File Offset: 0x009FFFE5
		// (set) Token: 0x0602B7A2 RID: 178082 RVA: 0x00A01DF5 File Offset: 0x009FFFF5
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_371) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_371) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B56 RID: 27478
		// (get) Token: 0x0602B7A3 RID: 178083 RVA: 0x00A01E06 File Offset: 0x00A00006
		// (set) Token: 0x0602B7A4 RID: 178084 RVA: 0x00A01E16 File Offset: 0x00A00016
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_372);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_372) = value;
			}
		}

		// Token: 0x17006B57 RID: 27479
		// (get) Token: 0x0602B7A5 RID: 178085 RVA: 0x00A01E27 File Offset: 0x00A00027
		// (set) Token: 0x0602B7A6 RID: 178086 RVA: 0x00A01E3B File Offset: 0x00A0003B
		public unsafe FRotator 瞄准旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_373);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_373) = value;
			}
		}

		// Token: 0x17006B58 RID: 27480
		// (get) Token: 0x0602B7A7 RID: 178087 RVA: 0x00A01E50 File Offset: 0x00A00050
		// (set) Token: 0x0602B7A8 RID: 178088 RVA: 0x00A01E60 File Offset: 0x00A00060
		public unsafe bool 是否将要移动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_374) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_374) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B59 RID: 27481
		// (get) Token: 0x0602B7A9 RID: 178089 RVA: 0x00A01E71 File Offset: 0x00A00071
		// (set) Token: 0x0602B7AA RID: 178090 RVA: 0x00A01E81 File Offset: 0x00A00081
		public unsafe bool 正在旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_375) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_375) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B5A RID: 27482
		// (get) Token: 0x0602B7AB RID: 178091 RVA: 0x00A01E92 File Offset: 0x00A00092
		// (set) Token: 0x0602B7AC RID: 178092 RVA: 0x00A01EA2 File Offset: 0x00A000A2
		public unsafe float 旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_376);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_376) = value;
			}
		}

		// Token: 0x17006B5B RID: 27483
		// (get) Token: 0x0602B7AD RID: 178093 RVA: 0x00A01EB3 File Offset: 0x00A000B3
		// (set) Token: 0x0602B7AE RID: 178094 RVA: 0x00A01EC3 File Offset: 0x00A000C3
		public unsafe float 旋转混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_377);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_377) = value;
			}
		}

		// Token: 0x17006B5C RID: 27484
		// (get) Token: 0x0602B7AF RID: 178095 RVA: 0x00A01ED4 File Offset: 0x00A000D4
		// (set) Token: 0x0602B7B0 RID: 178096 RVA: 0x00A01EE8 File Offset: 0x00A000E8
		public unsafe FVeloctiyBlend 速度混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_378);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_378) = value;
			}
		}

		// Token: 0x17006B5D RID: 27485
		// (get) Token: 0x0602B7B1 RID: 178097 RVA: 0x00A01EFD File Offset: 0x00A000FD
		// (set) Token: 0x0602B7B2 RID: 178098 RVA: 0x00A01F11 File Offset: 0x00A00111
		public unsafe FVector 相对加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_379);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_379) = value;
			}
		}

		// Token: 0x17006B5E RID: 27486
		// (get) Token: 0x0602B7B3 RID: 178099 RVA: 0x00A01F28 File Offset: 0x00A00128
		// (set) Token: 0x0602B7B4 RID: 178100 RVA: 0x00A01F61 File Offset: 0x00A00161
		[Nullable(1)]
		public FLeanAmount 倾斜量
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLeanAmount result;
				if ((result = this._倾斜量) == null)
				{
					result = (this._倾斜量 = new FLeanAmount(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_380, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLeanAmount.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_380, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B5F RID: 27487
		// (get) Token: 0x0602B7B5 RID: 178101 RVA: 0x00A01F82 File Offset: 0x00A00182
		// (set) Token: 0x0602B7B6 RID: 178102 RVA: 0x00A01F92 File Offset: 0x00A00192
		public unsafe float 地上倾斜量平滑速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_381);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_381) = value;
			}
		}

		// Token: 0x17006B60 RID: 27488
		// (get) Token: 0x0602B7B7 RID: 178103 RVA: 0x00A01FA3 File Offset: 0x00A001A3
		// (set) Token: 0x0602B7B8 RID: 178104 RVA: 0x00A01FB7 File Offset: 0x00A001B7
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovementDirection> 移动方向
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_382);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_382) = value;
			}
		}

		// Token: 0x17006B61 RID: 27489
		// (get) Token: 0x0602B7B9 RID: 178105 RVA: 0x00A01FCC File Offset: 0x00A001CC
		// (set) Token: 0x0602B7BA RID: 178106 RVA: 0x00A01FDC File Offset: 0x00A001DC
		public unsafe float 站立播放速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_383);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_383) = value;
			}
		}

		// Token: 0x17006B62 RID: 27490
		// (get) Token: 0x0602B7BB RID: 178107 RVA: 0x00A01FED File Offset: 0x00A001ED
		// (set) Token: 0x0602B7BC RID: 178108 RVA: 0x00A01FFD File Offset: 0x00A001FD
		public unsafe float 走跑混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_384);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_384) = value;
			}
		}

		// Token: 0x17006B63 RID: 27491
		// (get) Token: 0x0602B7BD RID: 178109 RVA: 0x00A0200E File Offset: 0x00A0020E
		// (set) Token: 0x0602B7BE RID: 178110 RVA: 0x00A02022 File Offset: 0x00A00222
		public unsafe UCurveFloat 站立走步幅混合曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_385);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_385, value);
			}
		}

		// Token: 0x17006B64 RID: 27492
		// (get) Token: 0x0602B7BF RID: 178111 RVA: 0x00A02037 File Offset: 0x00A00237
		// (set) Token: 0x0602B7C0 RID: 178112 RVA: 0x00A0204B File Offset: 0x00A0024B
		public unsafe UCurveFloat 站立跑步幅混合曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_386);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_386, value);
			}
		}

		// Token: 0x17006B65 RID: 27493
		// (get) Token: 0x0602B7C1 RID: 178113 RVA: 0x00A02060 File Offset: 0x00A00260
		// (set) Token: 0x0602B7C2 RID: 178114 RVA: 0x00A02070 File Offset: 0x00A00270
		public unsafe float 步幅混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_387);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_387) = value;
			}
		}

		// Token: 0x17006B66 RID: 27494
		// (get) Token: 0x0602B7C3 RID: 178115 RVA: 0x00A02081 File Offset: 0x00A00281
		// (set) Token: 0x0602B7C4 RID: 178116 RVA: 0x00A02091 File Offset: 0x00A00291
		public unsafe float 动画行走速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_388);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_388) = value;
			}
		}

		// Token: 0x17006B67 RID: 27495
		// (get) Token: 0x0602B7C5 RID: 178117 RVA: 0x00A020A2 File Offset: 0x00A002A2
		// (set) Token: 0x0602B7C6 RID: 178118 RVA: 0x00A020B2 File Offset: 0x00A002B2
		public unsafe float 动画跑步速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_389);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_389) = value;
			}
		}

		// Token: 0x17006B68 RID: 27496
		// (get) Token: 0x0602B7C7 RID: 178119 RVA: 0x00A020C3 File Offset: 0x00A002C3
		// (set) Token: 0x0602B7C8 RID: 178120 RVA: 0x00A020D3 File Offset: 0x00A002D3
		public unsafe float 动画疾跑速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_390);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_390) = value;
			}
		}

		// Token: 0x17006B69 RID: 27497
		// (get) Token: 0x0602B7C9 RID: 178121 RVA: 0x00A020E4 File Offset: 0x00A002E4
		// (set) Token: 0x0602B7CA RID: 178122 RVA: 0x00A020F8 File Offset: 0x00A002F8
		public unsafe UCurveFloat RelativeSpeedBlendCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_391);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_391, value);
			}
		}

		// Token: 0x17006B6A RID: 27498
		// (get) Token: 0x0602B7CB RID: 178123 RVA: 0x00A0210D File Offset: 0x00A0030D
		// (set) Token: 0x0602B7CC RID: 178124 RVA: 0x00A02121 File Offset: 0x00A00321
		public unsafe FVector 整体偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_392);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_392) = value;
			}
		}

		// Token: 0x17006B6B RID: 27499
		// (get) Token: 0x0602B7CD RID: 178125 RVA: 0x00A02136 File Offset: 0x00A00336
		// (set) Token: 0x0602B7CE RID: 178126 RVA: 0x00A0214A File Offset: 0x00A0034A
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_393);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_393, value);
			}
		}

		// Token: 0x17006B6C RID: 27500
		// (get) Token: 0x0602B7CF RID: 178127 RVA: 0x00A0215F File Offset: 0x00A0035F
		// (set) Token: 0x0602B7D0 RID: 178128 RVA: 0x00A02173 File Offset: 0x00A00373
		public unsafe FVector 整体偏移_实际使用_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_394);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_394) = value;
			}
		}

		// Token: 0x17006B6D RID: 27501
		// (get) Token: 0x0602B7D1 RID: 178129 RVA: 0x00A02188 File Offset: 0x00A00388
		// (set) Token: 0x0602B7D2 RID: 178130 RVA: 0x00A0219C File Offset: 0x00A0039C
		public unsafe FVector 上一帧模型位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_395);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_395) = value;
			}
		}

		// Token: 0x17006B6E RID: 27502
		// (get) Token: 0x0602B7D3 RID: 178131 RVA: 0x00A021B1 File Offset: 0x00A003B1
		// (set) Token: 0x0602B7D4 RID: 178132 RVA: 0x00A021C1 File Offset: 0x00A003C1
		public unsafe bool IsAutonomousProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_396) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_396) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B6F RID: 27503
		// (get) Token: 0x0602B7D5 RID: 178133 RVA: 0x00A021D2 File Offset: 0x00A003D2
		// (set) Token: 0x0602B7D6 RID: 178134 RVA: 0x00A021E2 File Offset: 0x00A003E2
		public unsafe float 瞄准面向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_397);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_397) = value;
			}
		}

		// Token: 0x17006B70 RID: 27504
		// (get) Token: 0x0602B7D7 RID: 178135 RVA: 0x00A021F3 File Offset: 0x00A003F3
		// (set) Token: 0x0602B7D8 RID: 178136 RVA: 0x00A02203 File Offset: 0x00A00403
		public unsafe float 瞄准仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_398);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_398) = value;
			}
		}

		// Token: 0x17006B71 RID: 27505
		// (get) Token: 0x0602B7D9 RID: 178137 RVA: 0x00A02214 File Offset: 0x00A00414
		// (set) Token: 0x0602B7DA RID: 178138 RVA: 0x00A02224 File Offset: 0x00A00424
		public unsafe float 当前坡度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_399);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_399) = value;
			}
		}

		// Token: 0x17006B72 RID: 27506
		// (get) Token: 0x0602B7DB RID: 178139 RVA: 0x00A02235 File Offset: 0x00A00435
		// (set) Token: 0x0602B7DC RID: 178140 RVA: 0x00A02245 File Offset: 0x00A00445
		public unsafe float 视线修正Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_400);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_400) = value;
			}
		}

		// Token: 0x17006B73 RID: 27507
		// (get) Token: 0x0602B7DD RID: 178141 RVA: 0x00A02256 File Offset: 0x00A00456
		// (set) Token: 0x0602B7DE RID: 178142 RVA: 0x00A0226A File Offset: 0x00A0046A
		public unsafe FVector 看向位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_401);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_401) = value;
			}
		}

		// Token: 0x17006B74 RID: 27508
		// (get) Token: 0x0602B7DF RID: 178143 RVA: 0x00A0227F File Offset: 0x00A0047F
		// (set) Token: 0x0602B7E0 RID: 178144 RVA: 0x00A0228F File Offset: 0x00A0048F
		public unsafe float CachePercent_LR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_402);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_402) = value;
			}
		}

		// Token: 0x17006B75 RID: 27509
		// (get) Token: 0x0602B7E1 RID: 178145 RVA: 0x00A022A0 File Offset: 0x00A004A0
		// (set) Token: 0x0602B7E2 RID: 178146 RVA: 0x00A022B0 File Offset: 0x00A004B0
		public unsafe float CachePercent_FB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_403);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_403) = value;
			}
		}

		// Token: 0x17006B76 RID: 27510
		// (get) Token: 0x0602B7E3 RID: 178147 RVA: 0x00A022C1 File Offset: 0x00A004C1
		// (set) Token: 0x0602B7E4 RID: 178148 RVA: 0x00A022D5 File Offset: 0x00A004D5
		public unsafe FVector 角色向前向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_404);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_404) = value;
			}
		}

		// Token: 0x17006B77 RID: 27511
		// (get) Token: 0x0602B7E5 RID: 178149 RVA: 0x00A022EA File Offset: 0x00A004EA
		// (set) Token: 0x0602B7E6 RID: 178150 RVA: 0x00A022FE File Offset: 0x00A004FE
		public unsafe FVector 外部方向输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_405);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_405) = value;
			}
		}

		// Token: 0x17006B78 RID: 27512
		// (get) Token: 0x0602B7E7 RID: 178151 RVA: 0x00A02313 File Offset: 0x00A00513
		// (set) Token: 0x0602B7E8 RID: 178152 RVA: 0x00A02323 File Offset: 0x00A00523
		public unsafe bool 是否需要原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_406) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_406) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B79 RID: 27513
		// (get) Token: 0x0602B7E9 RID: 178153 RVA: 0x00A02334 File Offset: 0x00A00534
		// (set) Token: 0x0602B7EA RID: 178154 RVA: 0x00A02344 File Offset: 0x00A00544
		public unsafe bool 右转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_407) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_407) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B7A RID: 27514
		// (get) Token: 0x0602B7EB RID: 178155 RVA: 0x00A02355 File Offset: 0x00A00555
		// (set) Token: 0x0602B7EC RID: 178156 RVA: 0x00A02365 File Offset: 0x00A00565
		public unsafe bool 状态_跑停
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_408) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_408) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B7B RID: 27515
		// (get) Token: 0x0602B7ED RID: 178157 RVA: 0x00A02376 File Offset: 0x00A00576
		// (set) Token: 0x0602B7EE RID: 178158 RVA: 0x00A02386 File Offset: 0x00A00586
		public unsafe bool 状态_跑停_RunStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_409) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_409) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B7C RID: 27516
		// (get) Token: 0x0602B7EF RID: 178159 RVA: 0x00A02397 File Offset: 0x00A00597
		// (set) Token: 0x0602B7F0 RID: 178160 RVA: 0x00A023A7 File Offset: 0x00A005A7
		public unsafe bool 状态_跑停_SprintStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_410) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_410) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B7D RID: 27517
		// (get) Token: 0x0602B7F1 RID: 178161 RVA: 0x00A023B8 File Offset: 0x00A005B8
		// (set) Token: 0x0602B7F2 RID: 178162 RVA: 0x00A023C8 File Offset: 0x00A005C8
		public unsafe bool 状态_跑停_WalkStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_411) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_411) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B7E RID: 27518
		// (get) Token: 0x0602B7F3 RID: 178163 RVA: 0x00A023D9 File Offset: 0x00A005D9
		// (set) Token: 0x0602B7F4 RID: 178164 RVA: 0x00A023E9 File Offset: 0x00A005E9
		public unsafe bool 状态_地面_Sprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_412) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_412) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B7F RID: 27519
		// (get) Token: 0x0602B7F5 RID: 178165 RVA: 0x00A023FA File Offset: 0x00A005FA
		// (set) Token: 0x0602B7F6 RID: 178166 RVA: 0x00A0240A File Offset: 0x00A0060A
		public unsafe bool 状态_地面_Walk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_413) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_413) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B80 RID: 27520
		// (get) Token: 0x0602B7F7 RID: 178167 RVA: 0x00A0241B File Offset: 0x00A0061B
		// (set) Token: 0x0602B7F8 RID: 178168 RVA: 0x00A0242B File Offset: 0x00A0062B
		public unsafe bool 状态_地面_Run
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_414) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_414) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B81 RID: 27521
		// (get) Token: 0x0602B7F9 RID: 178169 RVA: 0x00A0243C File Offset: 0x00A0063C
		// (set) Token: 0x0602B7FA RID: 178170 RVA: 0x00A0244C File Offset: 0x00A0064C
		public unsafe bool 状态_牵手_牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_415) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_415) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B82 RID: 27522
		// (get) Token: 0x0602B7FB RID: 178171 RVA: 0x00A0245D File Offset: 0x00A0065D
		// (set) Token: 0x0602B7FC RID: 178172 RVA: 0x00A0246D File Offset: 0x00A0066D
		public unsafe bool 状态_牵手_被牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_416) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_416) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B83 RID: 27523
		// (get) Token: 0x0602B7FD RID: 178173 RVA: 0x00A0247E File Offset: 0x00A0067E
		// (set) Token: 0x0602B7FE RID: 178174 RVA: 0x00A0248E File Offset: 0x00A0068E
		public unsafe bool 状态_牵手_范围内
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_417) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_417) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B84 RID: 27524
		// (get) Token: 0x0602B7FF RID: 178175 RVA: 0x00A0249F File Offset: 0x00A0069F
		// (set) Token: 0x0602B800 RID: 178176 RVA: 0x00A024AF File Offset: 0x00A006AF
		public unsafe bool 状态_牵手_接受邀请中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_418) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_418) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B85 RID: 27525
		// (get) Token: 0x0602B801 RID: 178177 RVA: 0x00A024C0 File Offset: 0x00A006C0
		// (set) Token: 0x0602B802 RID: 178178 RVA: 0x00A024D4 File Offset: 0x00A006D4
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharState> CharMoveState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_419);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_419) = value;
			}
		}

		// Token: 0x17006B86 RID: 27526
		// (get) Token: 0x0602B803 RID: 178179 RVA: 0x00A024E9 File Offset: 0x00A006E9
		// (set) Token: 0x0602B804 RID: 178180 RVA: 0x00A024F9 File Offset: 0x00A006F9
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_420);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_420) = value;
			}
		}

		// Token: 0x17006B87 RID: 27527
		// (get) Token: 0x0602B805 RID: 178181 RVA: 0x00A0250A File Offset: 0x00A0070A
		// (set) Token: 0x0602B806 RID: 178182 RVA: 0x00A0251A File Offset: 0x00A0071A
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_421);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_421) = value;
			}
		}

		// Token: 0x17006B88 RID: 27528
		// (get) Token: 0x0602B807 RID: 178183 RVA: 0x00A0252B File Offset: 0x00A0072B
		// (set) Token: 0x0602B808 RID: 178184 RVA: 0x00A0253B File Offset: 0x00A0073B
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_422);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_422) = value;
			}
		}

		// Token: 0x17006B89 RID: 27529
		// (get) Token: 0x0602B809 RID: 178185 RVA: 0x00A0254C File Offset: 0x00A0074C
		// (set) Token: 0x0602B80A RID: 178186 RVA: 0x00A0255C File Offset: 0x00A0075C
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_423);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_423) = value;
			}
		}

		// Token: 0x17006B8A RID: 27530
		// (get) Token: 0x0602B80B RID: 178187 RVA: 0x00A0256D File Offset: 0x00A0076D
		// (set) Token: 0x0602B80C RID: 178188 RVA: 0x00A02581 File Offset: 0x00A00781
		public unsafe FRotator 角色旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_424);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_424) = value;
			}
		}

		// Token: 0x17006B8B RID: 27531
		// (get) Token: 0x0602B80D RID: 178189 RVA: 0x00A02596 File Offset: 0x00A00796
		// (set) Token: 0x0602B80E RID: 178190 RVA: 0x00A025A6 File Offset: 0x00A007A6
		public unsafe float 原地旋转偏差角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_425);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_425) = value;
			}
		}

		// Token: 0x17006B8C RID: 27532
		// (get) Token: 0x0602B80F RID: 178191 RVA: 0x00A025B7 File Offset: 0x00A007B7
		// (set) Token: 0x0602B810 RID: 178192 RVA: 0x00A025C7 File Offset: 0x00A007C7
		public unsafe bool 移动时是否有阻挡
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_426) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_426) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B8D RID: 27533
		// (get) Token: 0x0602B811 RID: 178193 RVA: 0x00A025D8 File Offset: 0x00A007D8
		// (set) Token: 0x0602B812 RID: 178194 RVA: 0x00A025E8 File Offset: 0x00A007E8
		public unsafe float TimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_427);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_427) = value;
			}
		}

		// Token: 0x17006B8E RID: 27534
		// (get) Token: 0x0602B813 RID: 178195 RVA: 0x00A025F9 File Offset: 0x00A007F9
		// (set) Token: 0x0602B814 RID: 178196 RVA: 0x00A02609 File Offset: 0x00A00809
		public unsafe float InSequenceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_428);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_428) = value;
			}
		}

		// Token: 0x17006B8F RID: 27535
		// (get) Token: 0x0602B815 RID: 178197 RVA: 0x00A0261A File Offset: 0x00A0081A
		// (set) Token: 0x0602B816 RID: 178198 RVA: 0x00A0262E File Offset: 0x00A0082E
		public unsafe FVector 缓存角色位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_429);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_429) = value;
			}
		}

		// Token: 0x17006B90 RID: 27536
		// (get) Token: 0x0602B817 RID: 178199 RVA: 0x00A02643 File Offset: 0x00A00843
		// (set) Token: 0x0602B818 RID: 178200 RVA: 0x00A02657 File Offset: 0x00A00857
		public unsafe UCurveFloat AngelToStepLength
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_430);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_430, value);
			}
		}

		// Token: 0x17006B91 RID: 27537
		// (get) Token: 0x0602B819 RID: 178201 RVA: 0x00A0266C File Offset: 0x00A0086C
		// (set) Token: 0x0602B81A RID: 178202 RVA: 0x00A02680 File Offset: 0x00A00880
		public unsafe UCurveFloat Angle_to_Step_Frequency
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_431);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_431, value);
			}
		}

		// Token: 0x17006B92 RID: 27538
		// (get) Token: 0x0602B81B RID: 178203 RVA: 0x00A02695 File Offset: 0x00A00895
		// (set) Token: 0x0602B81C RID: 178204 RVA: 0x00A026A9 File Offset: 0x00A008A9
		public unsafe FRotator 综合旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_432);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_432) = value;
			}
		}

		// Token: 0x17006B93 RID: 27539
		// (get) Token: 0x0602B81D RID: 178205 RVA: 0x00A026BE File Offset: 0x00A008BE
		// (set) Token: 0x0602B81E RID: 178206 RVA: 0x00A026D2 File Offset: 0x00A008D2
		public unsafe FVector 上一帧位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_433);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_433) = value;
			}
		}

		// Token: 0x17006B94 RID: 27540
		// (get) Token: 0x0602B81F RID: 178207 RVA: 0x00A026E7 File Offset: 0x00A008E7
		// (set) Token: 0x0602B820 RID: 178208 RVA: 0x00A026F7 File Offset: 0x00A008F7
		public unsafe float 角色位移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_434);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_434) = value;
			}
		}

		// Token: 0x17006B95 RID: 27541
		// (get) Token: 0x0602B821 RID: 178209 RVA: 0x00A02708 File Offset: 0x00A00908
		// (set) Token: 0x0602B822 RID: 178210 RVA: 0x00A02718 File Offset: 0x00A00918
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_435) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_435) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B96 RID: 27542
		// (get) Token: 0x0602B823 RID: 178211 RVA: 0x00A02729 File Offset: 0x00A00929
		// (set) Token: 0x0602B824 RID: 178212 RVA: 0x00A02739 File Offset: 0x00A00939
		public unsafe int 身高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_436);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_436) = value;
			}
		}

		// Token: 0x17006B97 RID: 27543
		// (get) Token: 0x0602B825 RID: 178213 RVA: 0x00A0274A File Offset: 0x00A0094A
		// (set) Token: 0x0602B826 RID: 178214 RVA: 0x00A0275A File Offset: 0x00A0095A
		public unsafe bool bComponentStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_437) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_437) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B98 RID: 27544
		// (get) Token: 0x0602B827 RID: 178215 RVA: 0x00A0276B File Offset: 0x00A0096B
		// (set) Token: 0x0602B828 RID: 178216 RVA: 0x00A0277F File Offset: 0x00A0097F
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharParentMoveState> CharPositionState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_438);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_438) = value;
			}
		}

		// Token: 0x17006B99 RID: 27545
		// (get) Token: 0x0602B829 RID: 178217 RVA: 0x00A02794 File Offset: 0x00A00994
		// (set) Token: 0x0602B82A RID: 178218 RVA: 0x00A027A8 File Offset: 0x00A009A8
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharViewDirectionState> CharCameraState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_439);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_439) = value;
			}
		}

		// Token: 0x17006B9A RID: 27546
		// (get) Token: 0x0602B82B RID: 178219 RVA: 0x00A027BD File Offset: 0x00A009BD
		// (set) Token: 0x0602B82C RID: 178220 RVA: 0x00A027D1 File Offset: 0x00A009D1
		[Nullable(0)]
		public unsafe TEnumAsByte<ESwim> 泳态
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_440);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_440) = value;
			}
		}

		// Token: 0x17006B9B RID: 27547
		// (get) Token: 0x0602B82D RID: 178221 RVA: 0x00A027E6 File Offset: 0x00A009E6
		// (set) Token: 0x0602B82E RID: 178222 RVA: 0x00A027FA File Offset: 0x00A009FA
		public unsafe BP_ABPLogicParams_C Ts逻辑变量集
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_ABPLogicParams_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_441);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRoleNPC_C.__PropertyOffset_441, value);
			}
		}

		// Token: 0x17006B9C RID: 27548
		// (get) Token: 0x0602B82F RID: 178223 RVA: 0x00A0280F File Offset: 0x00A00A0F
		// (set) Token: 0x0602B830 RID: 178224 RVA: 0x00A0281F File Offset: 0x00A00A1F
		public unsafe bool 不进行_IK_Lerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_442) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_442) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B9D RID: 27549
		// (get) Token: 0x0602B831 RID: 178225 RVA: 0x00A02830 File Offset: 0x00A00A30
		// (set) Token: 0x0602B832 RID: 178226 RVA: 0x00A02840 File Offset: 0x00A00A40
		public unsafe KuroHumanIKMode IK模式
		{
			get
			{
				return (KuroHumanIKMode)(*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_443));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_443) = (byte)value;
			}
		}

		// Token: 0x17006B9E RID: 27550
		// (get) Token: 0x0602B833 RID: 178227 RVA: 0x00A02851 File Offset: 0x00A00A51
		// (set) Token: 0x0602B834 RID: 178228 RVA: 0x00A02861 File Offset: 0x00A00A61
		public unsafe bool 使用混合空间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_444) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_444) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B9F RID: 27551
		// (get) Token: 0x0602B835 RID: 178229 RVA: 0x00A02872 File Offset: 0x00A00A72
		// (set) Token: 0x0602B836 RID: 178230 RVA: 0x00A02886 File Offset: 0x00A00A86
		public unsafe FVector2D 看向角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_445);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_445) = value;
			}
		}

		// Token: 0x17006BA0 RID: 27552
		// (get) Token: 0x0602B837 RID: 178231 RVA: 0x00A0289B File Offset: 0x00A00A9B
		// (set) Token: 0x0602B838 RID: 178232 RVA: 0x00A028AF File Offset: 0x00A00AAF
		public unsafe FVector4 VehicleCollisionMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_446);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_446) = value;
			}
		}

		// Token: 0x17006BA1 RID: 27553
		// (get) Token: 0x0602B839 RID: 178233 RVA: 0x00A028C4 File Offset: 0x00A00AC4
		// (set) Token: 0x0602B83A RID: 178234 RVA: 0x00A028D4 File Offset: 0x00A00AD4
		public unsafe bool IsVehicleImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_447) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_447) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BA2 RID: 27554
		// (get) Token: 0x0602B83B RID: 178235 RVA: 0x00A028E5 File Offset: 0x00A00AE5
		// (set) Token: 0x0602B83C RID: 178236 RVA: 0x00A028F9 File Offset: 0x00A00AF9
		public unsafe FRotator VehicleSeatRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_448);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_448) = value;
			}
		}

		// Token: 0x17006BA3 RID: 27555
		// (get) Token: 0x0602B83D RID: 178237 RVA: 0x00A0290E File Offset: 0x00A00B0E
		// (set) Token: 0x0602B83E RID: 178238 RVA: 0x00A0291E File Offset: 0x00A00B1E
		public unsafe float VehicleCollisionAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_449);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_449) = value;
			}
		}

		// Token: 0x17006BA4 RID: 27556
		// (get) Token: 0x0602B83F RID: 178239 RVA: 0x00A0292F File Offset: 0x00A00B2F
		// (set) Token: 0x0602B840 RID: 178240 RVA: 0x00A0293F File Offset: 0x00A00B3F
		public unsafe float VehicleCollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_450);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_450) = value;
			}
		}

		// Token: 0x17006BA5 RID: 27557
		// (get) Token: 0x0602B841 RID: 178241 RVA: 0x00A02950 File Offset: 0x00A00B50
		// (set) Token: 0x0602B842 RID: 178242 RVA: 0x00A02960 File Offset: 0x00A00B60
		public unsafe float VehicleCollisionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_451);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_451) = value;
			}
		}

		// Token: 0x17006BA6 RID: 27558
		// (get) Token: 0x0602B843 RID: 178243 RVA: 0x00A02971 File Offset: 0x00A00B71
		// (set) Token: 0x0602B844 RID: 178244 RVA: 0x00A02981 File Offset: 0x00A00B81
		public unsafe bool SuddenMoveTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_452) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_452) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BA7 RID: 27559
		// (get) Token: 0x0602B845 RID: 178245 RVA: 0x00A02992 File Offset: 0x00A00B92
		// (set) Token: 0x0602B846 RID: 178246 RVA: 0x00A029A6 File Offset: 0x00A00BA6
		public unsafe FVector4 VehicleSuddenMoveMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_453);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_453) = value;
			}
		}

		// Token: 0x17006BA8 RID: 27560
		// (get) Token: 0x0602B847 RID: 178247 RVA: 0x00A029BB File Offset: 0x00A00BBB
		// (set) Token: 0x0602B848 RID: 178248 RVA: 0x00A029CB File Offset: 0x00A00BCB
		public unsafe float CurForwardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_454);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_454) = value;
			}
		}

		// Token: 0x17006BA9 RID: 27561
		// (get) Token: 0x0602B849 RID: 178249 RVA: 0x00A029DC File Offset: 0x00A00BDC
		// (set) Token: 0x0602B84A RID: 178250 RVA: 0x00A029EC File Offset: 0x00A00BEC
		public unsafe float LastForwardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_455);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_455) = value;
			}
		}

		// Token: 0x17006BAA RID: 27562
		// (get) Token: 0x0602B84B RID: 178251 RVA: 0x00A029FD File Offset: 0x00A00BFD
		// (set) Token: 0x0602B84C RID: 178252 RVA: 0x00A02A0D File Offset: 0x00A00C0D
		public unsafe float CurSeatRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_456);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_456) = value;
			}
		}

		// Token: 0x17006BAB RID: 27563
		// (get) Token: 0x0602B84D RID: 178253 RVA: 0x00A02A1E File Offset: 0x00A00C1E
		// (set) Token: 0x0602B84E RID: 178254 RVA: 0x00A02A2E File Offset: 0x00A00C2E
		public unsafe float SuddenMoveCd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_457);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_457) = value;
			}
		}

		// Token: 0x17006BAC RID: 27564
		// (get) Token: 0x0602B84F RID: 178255 RVA: 0x00A02A3F File Offset: 0x00A00C3F
		// (set) Token: 0x0602B850 RID: 178256 RVA: 0x00A02A4F File Offset: 0x00A00C4F
		public unsafe bool SuddenStopTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_458) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_458) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BAD RID: 27565
		// (get) Token: 0x0602B851 RID: 178257 RVA: 0x00A02A60 File Offset: 0x00A00C60
		// (set) Token: 0x0602B852 RID: 178258 RVA: 0x00A02A70 File Offset: 0x00A00C70
		public unsafe float LastSeatRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_459);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_459) = value;
			}
		}

		// Token: 0x17006BAE RID: 27566
		// (get) Token: 0x0602B853 RID: 178259 RVA: 0x00A02A81 File Offset: 0x00A00C81
		// (set) Token: 0x0602B854 RID: 178260 RVA: 0x00A02A91 File Offset: 0x00A00C91
		public unsafe bool EnableSwitchPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_460) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_460) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BAF RID: 27567
		// (get) Token: 0x0602B855 RID: 178261 RVA: 0x00A02AA4 File Offset: 0x00A00CA4
		// (set) Token: 0x0602B856 RID: 178262 RVA: 0x00A02ADD File Offset: 0x00A00CDD
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
					result = (this._CachePose = new FPoseSnapshot(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_461, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseSnapshot.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_461, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006BB0 RID: 27568
		// (get) Token: 0x0602B857 RID: 178263 RVA: 0x00A02AFE File Offset: 0x00A00CFE
		// (set) Token: 0x0602B858 RID: 178264 RVA: 0x00A02B0E File Offset: 0x00A00D0E
		public unsafe float SwitchPoseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_462);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_462) = value;
			}
		}

		// Token: 0x17006BB1 RID: 27569
		// (get) Token: 0x0602B859 RID: 178265 RVA: 0x00A02B1F File Offset: 0x00A00D1F
		// (set) Token: 0x0602B85A RID: 178266 RVA: 0x00A02B2F File Offset: 0x00A00D2F
		public unsafe bool IsInPlotBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_463) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_463) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BB2 RID: 27570
		// (get) Token: 0x0602B85B RID: 178267 RVA: 0x00A02B40 File Offset: 0x00A00D40
		// (set) Token: 0x0602B85C RID: 178268 RVA: 0x00A02B50 File Offset: 0x00A00D50
		public unsafe bool 状态_叠加层_手臂叠加层左手
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_464) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_464) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BB3 RID: 27571
		// (get) Token: 0x0602B85D RID: 178269 RVA: 0x00A02B61 File Offset: 0x00A00D61
		// (set) Token: 0x0602B85E RID: 178270 RVA: 0x00A02B71 File Offset: 0x00A00D71
		public unsafe bool 状态_叠加层_手臂叠加层右手
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_465) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_465) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BB4 RID: 27572
		// (get) Token: 0x0602B85F RID: 178271 RVA: 0x00A02B82 File Offset: 0x00A00D82
		// (set) Token: 0x0602B860 RID: 178272 RVA: 0x00A02B92 File Offset: 0x00A00D92
		public unsafe bool 状态_叠加层_下半身通用融合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_466) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_466) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BB5 RID: 27573
		// (get) Token: 0x0602B861 RID: 178273 RVA: 0x00A02BA3 File Offset: 0x00A00DA3
		// (set) Token: 0x0602B862 RID: 178274 RVA: 0x00A02BB3 File Offset: 0x00A00DB3
		public unsafe float 站立叠加倾斜量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_467);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_467) = value;
			}
		}

		// Token: 0x17006BB6 RID: 27574
		// (get) Token: 0x0602B863 RID: 178275 RVA: 0x00A02BC4 File Offset: 0x00A00DC4
		// (set) Token: 0x0602B864 RID: 178276 RVA: 0x00A02BD4 File Offset: 0x00A00DD4
		public unsafe bool 是否待机表演
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_468) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_468) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BB7 RID: 27575
		// (get) Token: 0x0602B865 RID: 178277 RVA: 0x00A02BE5 File Offset: 0x00A00DE5
		// (set) Token: 0x0602B866 RID: 178278 RVA: 0x00A02BF5 File Offset: 0x00A00DF5
		public unsafe float 待机表演间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_469);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_469) = value;
			}
		}

		// Token: 0x17006BB8 RID: 27576
		// (get) Token: 0x0602B867 RID: 178279 RVA: 0x00A02C06 File Offset: 0x00A00E06
		// (set) Token: 0x0602B868 RID: 178280 RVA: 0x00A02C16 File Offset: 0x00A00E16
		public unsafe float 当前待机表演计时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_470);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_470) = value;
			}
		}

		// Token: 0x17006BB9 RID: 27577
		// (get) Token: 0x0602B869 RID: 178281 RVA: 0x00A02C27 File Offset: 0x00A00E27
		// (set) Token: 0x0602B86A RID: 178282 RVA: 0x00A02C37 File Offset: 0x00A00E37
		public unsafe bool 禁用眨眼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_471) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_471) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BBA RID: 27578
		// (get) Token: 0x0602B86B RID: 178283 RVA: 0x00A02C48 File Offset: 0x00A00E48
		// (set) Token: 0x0602B86C RID: 178284 RVA: 0x00A02C58 File Offset: 0x00A00E58
		public unsafe bool 状态_乘坐载具
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_472) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_472) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BBB RID: 27579
		// (get) Token: 0x0602B86D RID: 178285 RVA: 0x00A02C69 File Offset: 0x00A00E69
		// (set) Token: 0x0602B86E RID: 178286 RVA: 0x00A02C79 File Offset: 0x00A00E79
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_473) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_473) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006BBC RID: 27580
		// (get) Token: 0x0602B86F RID: 178287 RVA: 0x00A02C8A File Offset: 0x00A00E8A
		// (set) Token: 0x0602B870 RID: 178288 RVA: 0x00A02C9A File Offset: 0x00A00E9A
		public unsafe bool 眨眼曲线覆盖蒙太奇
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_474) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRoleNPC_C.__PropertyOffset_474) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B871 RID: 178289 RVA: 0x00A02CAC File Offset: 0x00A00EAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 骨骼混合叠加层(FPoseLink BaseLayer, FPoseLink OverlayLayer, FPoseLink BasePose, ref FPoseLink 骨骼混合叠加层)
		{
			ABP_BaseRoleNPC_C.__骨骼混合叠加层_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__骨骼混合叠加层_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__骨骼混合叠加层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__骨骼混合叠加层_NativeFunctionPtr, (void*)ptr, 1);
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
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__骨骼混合叠加层_NativeFunctionPtr, (void*)ptr);
			if (骨骼混合叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 骨骼混合叠加层.NativePtr, &ptr->骨骼混合叠加层, 1, false);
			}
		}

		// Token: 0x0602B872 RID: 178290 RVA: 0x00A02DA0 File Offset: 0x00A00FA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础姿势层(ref FPoseLink 基础姿势层)
		{
			ABP_BaseRoleNPC_C.__基础姿势层_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__基础姿势层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__基础姿势层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__基础姿势层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础姿势层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础姿势层, 基础姿势层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__基础姿势层_NativeFunctionPtr, (void*)ptr);
			if (基础姿势层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础姿势层.NativePtr, &ptr->基础姿势层, 1, false);
			}
		}

		// Token: 0x0602B873 RID: 178291 RVA: 0x00A02E28 File Offset: 0x00A01028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 混合层(FPoseLink 基础层输入, FPoseLink 叠加层输入, FPoseLink 姿势层输入, FPoseLink 手臂叠加层输入, ref FPoseLink 混合层)
		{
			ABP_BaseRoleNPC_C.__混合层_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__混合层_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__混合层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__混合层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层输入, 基础层输入.NativePtr, 1, false);
			}
			if (叠加层输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->叠加层输入, 叠加层输入.NativePtr, 1, false);
			}
			if (姿势层输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->姿势层输入, 姿势层输入.NativePtr, 1, false);
			}
			if (手臂叠加层输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->手臂叠加层输入, 手臂叠加层输入.NativePtr, 1, false);
			}
			if (混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->混合层, 混合层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__混合层_NativeFunctionPtr, (void*)ptr);
			if (混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 混合层.NativePtr, &ptr->混合层, 1, false);
			}
		}

		// Token: 0x0602B874 RID: 178292 RVA: 0x00A02F40 File Offset: 0x00A01140
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 手臂叠加层(ref FPoseLink 手臂叠加层)
		{
			ABP_BaseRoleNPC_C.__手臂叠加层_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__手臂叠加层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__手臂叠加层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__手臂叠加层_NativeFunctionPtr, (void*)ptr, 1);
			if (手臂叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->手臂叠加层, 手臂叠加层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__手臂叠加层_NativeFunctionPtr, (void*)ptr);
			if (手臂叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 手臂叠加层.NativePtr, &ptr->手臂叠加层, 1, false);
			}
		}

		// Token: 0x0602B875 RID: 178293 RVA: 0x00A02FC8 File Offset: 0x00A011C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 叠加层(ref FPoseLink 叠加层)
		{
			ABP_BaseRoleNPC_C.__叠加层_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__叠加层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__叠加层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__叠加层_NativeFunctionPtr, (void*)ptr, 1);
			if (叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->叠加层, 叠加层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__叠加层_NativeFunctionPtr, (void*)ptr);
			if (叠加层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 叠加层.NativePtr, &ptr->叠加层, 1, false);
			}
		}

		// Token: 0x0602B876 RID: 178294 RVA: 0x00A03050 File Offset: 0x00A01250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(FPoseLink 地区运动模式, ref FPoseLink AnimGraph)
		{
			ABP_BaseRoleNPC_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__AnimGraph_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (地区运动模式 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->地区运动模式, 地区运动模式.NativePtr, 1, false);
			}
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602B877 RID: 178295 RVA: 0x00A030F9 File Offset: 0x00A012F9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 重置坐下待机计时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__重置坐下待机计时_NativeFunctionPtr, null);
		}

		// Token: 0x0602B878 RID: 178296 RVA: 0x00A0310D File Offset: 0x00A0130D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新坐下待机计时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新坐下待机计时_NativeFunctionPtr, null);
		}

		// Token: 0x0602B879 RID: 178297 RVA: 0x00A03121 File Offset: 0x00A01321
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新牵手组件参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新牵手组件参数_NativeFunctionPtr, null);
		}

		// Token: 0x0602B87A RID: 178298 RVA: 0x00A03135 File Offset: 0x00A01335
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新载具信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新载具信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602B87B RID: 178299 RVA: 0x00A03149 File Offset: 0x00A01349
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化身高()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__初始化身高_NativeFunctionPtr, null);
		}

		// Token: 0x0602B87C RID: 178300 RVA: 0x00A0315D File Offset: 0x00A0135D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 组件参数动画蓝图初始化绑定()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__组件参数动画蓝图初始化绑定_NativeFunctionPtr, null);
		}

		// Token: 0x0602B87D RID: 178301 RVA: 0x00A03171 File Offset: 0x00A01371
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 绑定组件参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__绑定组件参数_NativeFunctionPtr, null);
		}

		// Token: 0x0602B87E RID: 178302 RVA: 0x00A03185 File Offset: 0x00A01385
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新移动信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新移动信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602B87F RID: 178303 RVA: 0x00A03199 File Offset: 0x00A01399
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新角色信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602B880 RID: 178304 RVA: 0x00A031AD File Offset: 0x00A013AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新状态参数信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新状态参数信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602B881 RID: 178305 RVA: 0x00A031C1 File Offset: 0x00A013C1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 切换地面移动模式时高度补差()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__切换地面移动模式时高度补差_NativeFunctionPtr, null);
		}

		// Token: 0x0602B882 RID: 178306 RVA: 0x00A031D5 File Offset: 0x00A013D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新上传()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新上传_NativeFunctionPtr, null);
		}

		// Token: 0x0602B883 RID: 178307 RVA: 0x00A031E9 File Offset: 0x00A013E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新时间参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新时间参数_NativeFunctionPtr, null);
		}

		// Token: 0x0602B884 RID: 178308 RVA: 0x00A031FD File Offset: 0x00A013FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新网络参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新网络参数_NativeFunctionPtr, null);
		}

		// Token: 0x0602B885 RID: 178309 RVA: 0x00A03211 File Offset: 0x00A01411
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新动画组件参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新动画组件参数_NativeFunctionPtr, null);
		}

		// Token: 0x0602B886 RID: 178310 RVA: 0x00A03225 File Offset: 0x00A01425
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新移动组件参数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新移动组件参数_NativeFunctionPtr, null);
		}

		// Token: 0x0602B887 RID: 178311 RVA: 0x00A03239 File Offset: 0x00A01439
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新随机表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新随机表演_NativeFunctionPtr, null);
		}

		// Token: 0x0602B888 RID: 178312 RVA: 0x00A0324D File Offset: 0x00A0144D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色状态()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新角色状态_NativeFunctionPtr, null);
		}

		// Token: 0x0602B889 RID: 178313 RVA: 0x00A03264 File Offset: 0x00A01464
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置头部转向状态(SightLockMode SightMode)
		{
			ABP_BaseRoleNPC_C.__设置头部转向状态_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__设置头部转向状态_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__设置头部转向状态_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SightMode = SightMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B88A RID: 178314 RVA: 0x00A032AC File Offset: 0x00A014AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 更新头部转向(FRotator NewParam)
		{
			ABP_BaseRoleNPC_C.__更新头部转向_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__更新头部转向_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__更新头部转向_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__更新头部转向_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新头部转向_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B88B RID: 178315 RVA: 0x00A032F2 File Offset: 0x00A014F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新_IK信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新_IK信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602B88C RID: 178316 RVA: 0x00A03306 File Offset: 0x00A01506
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 原地旋转检查()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__原地旋转检查_NativeFunctionPtr, null);
		}

		// Token: 0x0602B88D RID: 178317 RVA: 0x00A0331A File Offset: 0x00A0151A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新旋转信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__更新旋转信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602B88E RID: 178318 RVA: 0x00A03330 File Offset: 0x00A01530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool 是否需要移动()
		{
			ABP_BaseRoleNPC_C.__是否需要移动_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__是否需要移动_FunctionParams[(UIntPtr)21] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__是否需要移动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__是否需要移动_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__是否需要移动_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602B88F RID: 178319 RVA: 0x00A03378 File Offset: 0x00A01578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B890 RID: 178320 RVA: 0x00A033C0 File Offset: 0x00A015C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B891 RID: 178321 RVA: 0x00A03407 File Offset: 0x00A01607
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602B892 RID: 178322 RVA: 0x00A0341B File Offset: 0x00A0161B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B893 RID: 178323 RVA: 0x00A03430 File Offset: 0x00A01630
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 播放动画(SDynamicMontageParams 播放动画)
		{
			ABP_BaseRoleNPC_C.__播放动画_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__播放动画_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__播放动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__播放动画_NativeFunctionPtr, (void*)ptr, 1);
			if (播放动画 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SDynamicMontageParams.StaticStruct(), &ptr->播放动画, 播放动画.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__播放动画_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B894 RID: 178324 RVA: 0x00A03491 File Offset: 0x00A01691
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B895 RID: 178325 RVA: 0x00A034A5 File Offset: 0x00A016A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B896 RID: 178326 RVA: 0x00A034BC File Offset: 0x00A016BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementChanged(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			ABP_BaseRoleNPC_C.__MovementChanged_FunctionParams* ptr = stackalloc ABP_BaseRoleNPC_C.__MovementChanged_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRoleNPC_C.__MovementChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRoleNPC_C.__MovementChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__MovementChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B897 RID: 178327 RVA: 0x00A03524 File Offset: 0x00A01724
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlotBlendIn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__PlotBlendIn_NativeFunctionPtr, null);
		}

		// Token: 0x0602B898 RID: 178328 RVA: 0x00A03538 File Offset: 0x00A01738
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NoExpose()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRoleNPC_C.__NoExpose_NativeFunctionPtr, null);
		}

		// Token: 0x0602B899 RID: 178329 RVA: 0x00A0354C File Offset: 0x00A0174C
		protected ABP_BaseRoleNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016A15 RID: 92693
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/RoleNPC/ABP_BaseRoleNPC.ABP_BaseRoleNPC_C";

		// Token: 0x04016A16 RID: 92694
		private static IntPtr _ClassPtr;

		// Token: 0x04016A17 RID: 92695
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016A18 RID: 92696
		internal static int __PropertyOffset_365;

		// Token: 0x04016A19 RID: 92697
		internal static int __PropertyOffset_366;

		// Token: 0x04016A1A RID: 92698
		internal static int __PropertyOffset_367;

		// Token: 0x04016A1B RID: 92699
		internal static int __PropertyOffset_368;

		// Token: 0x04016A1C RID: 92700
		internal static int __PropertyOffset_369;

		// Token: 0x04016A1D RID: 92701
		internal static int __PropertyOffset_370;

		// Token: 0x04016A1E RID: 92702
		internal static int __PropertyOffset_371;

		// Token: 0x04016A1F RID: 92703
		internal static int __PropertyOffset_372;

		// Token: 0x04016A20 RID: 92704
		internal static int __PropertyOffset_373;

		// Token: 0x04016A21 RID: 92705
		internal static int __PropertyOffset_374;

		// Token: 0x04016A22 RID: 92706
		internal static int __PropertyOffset_375;

		// Token: 0x04016A23 RID: 92707
		internal static int __PropertyOffset_376;

		// Token: 0x04016A24 RID: 92708
		internal static int __PropertyOffset_377;

		// Token: 0x04016A25 RID: 92709
		internal static int __PropertyOffset_378;

		// Token: 0x04016A26 RID: 92710
		internal static int __PropertyOffset_379;

		// Token: 0x04016A27 RID: 92711
		internal static int __PropertyOffset_380;

		// Token: 0x04016A28 RID: 92712
		private FLeanAmount _倾斜量;

		// Token: 0x04016A29 RID: 92713
		internal static int __PropertyOffset_381;

		// Token: 0x04016A2A RID: 92714
		internal static int __PropertyOffset_382;

		// Token: 0x04016A2B RID: 92715
		internal static int __PropertyOffset_383;

		// Token: 0x04016A2C RID: 92716
		internal static int __PropertyOffset_384;

		// Token: 0x04016A2D RID: 92717
		internal static int __PropertyOffset_385;

		// Token: 0x04016A2E RID: 92718
		internal static int __PropertyOffset_386;

		// Token: 0x04016A2F RID: 92719
		internal static int __PropertyOffset_387;

		// Token: 0x04016A30 RID: 92720
		internal static int __PropertyOffset_388;

		// Token: 0x04016A31 RID: 92721
		internal static int __PropertyOffset_389;

		// Token: 0x04016A32 RID: 92722
		internal static int __PropertyOffset_390;

		// Token: 0x04016A33 RID: 92723
		internal static int __PropertyOffset_391;

		// Token: 0x04016A34 RID: 92724
		internal static int __PropertyOffset_392;

		// Token: 0x04016A35 RID: 92725
		internal static int __PropertyOffset_393;

		// Token: 0x04016A36 RID: 92726
		internal static int __PropertyOffset_394;

		// Token: 0x04016A37 RID: 92727
		internal static int __PropertyOffset_395;

		// Token: 0x04016A38 RID: 92728
		internal static int __PropertyOffset_396;

		// Token: 0x04016A39 RID: 92729
		internal static int __PropertyOffset_397;

		// Token: 0x04016A3A RID: 92730
		internal static int __PropertyOffset_398;

		// Token: 0x04016A3B RID: 92731
		internal static int __PropertyOffset_399;

		// Token: 0x04016A3C RID: 92732
		internal static int __PropertyOffset_400;

		// Token: 0x04016A3D RID: 92733
		internal static int __PropertyOffset_401;

		// Token: 0x04016A3E RID: 92734
		internal static int __PropertyOffset_402;

		// Token: 0x04016A3F RID: 92735
		internal static int __PropertyOffset_403;

		// Token: 0x04016A40 RID: 92736
		internal static int __PropertyOffset_404;

		// Token: 0x04016A41 RID: 92737
		internal static int __PropertyOffset_405;

		// Token: 0x04016A42 RID: 92738
		internal static int __PropertyOffset_406;

		// Token: 0x04016A43 RID: 92739
		internal static int __PropertyOffset_407;

		// Token: 0x04016A44 RID: 92740
		internal static int __PropertyOffset_408;

		// Token: 0x04016A45 RID: 92741
		internal static int __PropertyOffset_409;

		// Token: 0x04016A46 RID: 92742
		internal static int __PropertyOffset_410;

		// Token: 0x04016A47 RID: 92743
		internal static int __PropertyOffset_411;

		// Token: 0x04016A48 RID: 92744
		internal static int __PropertyOffset_412;

		// Token: 0x04016A49 RID: 92745
		internal static int __PropertyOffset_413;

		// Token: 0x04016A4A RID: 92746
		internal static int __PropertyOffset_414;

		// Token: 0x04016A4B RID: 92747
		internal static int __PropertyOffset_415;

		// Token: 0x04016A4C RID: 92748
		internal static int __PropertyOffset_416;

		// Token: 0x04016A4D RID: 92749
		internal static int __PropertyOffset_417;

		// Token: 0x04016A4E RID: 92750
		internal static int __PropertyOffset_418;

		// Token: 0x04016A4F RID: 92751
		internal static int __PropertyOffset_419;

		// Token: 0x04016A50 RID: 92752
		internal static int __PropertyOffset_420;

		// Token: 0x04016A51 RID: 92753
		internal static int __PropertyOffset_421;

		// Token: 0x04016A52 RID: 92754
		internal static int __PropertyOffset_422;

		// Token: 0x04016A53 RID: 92755
		internal static int __PropertyOffset_423;

		// Token: 0x04016A54 RID: 92756
		internal static int __PropertyOffset_424;

		// Token: 0x04016A55 RID: 92757
		internal static int __PropertyOffset_425;

		// Token: 0x04016A56 RID: 92758
		internal static int __PropertyOffset_426;

		// Token: 0x04016A57 RID: 92759
		internal static int __PropertyOffset_427;

		// Token: 0x04016A58 RID: 92760
		internal static int __PropertyOffset_428;

		// Token: 0x04016A59 RID: 92761
		internal static int __PropertyOffset_429;

		// Token: 0x04016A5A RID: 92762
		internal static int __PropertyOffset_430;

		// Token: 0x04016A5B RID: 92763
		internal static int __PropertyOffset_431;

		// Token: 0x04016A5C RID: 92764
		internal static int __PropertyOffset_432;

		// Token: 0x04016A5D RID: 92765
		internal static int __PropertyOffset_433;

		// Token: 0x04016A5E RID: 92766
		internal static int __PropertyOffset_434;

		// Token: 0x04016A5F RID: 92767
		internal static int __PropertyOffset_435;

		// Token: 0x04016A60 RID: 92768
		internal static int __PropertyOffset_436;

		// Token: 0x04016A61 RID: 92769
		internal static int __PropertyOffset_437;

		// Token: 0x04016A62 RID: 92770
		internal static int __PropertyOffset_438;

		// Token: 0x04016A63 RID: 92771
		internal static int __PropertyOffset_439;

		// Token: 0x04016A64 RID: 92772
		internal static int __PropertyOffset_440;

		// Token: 0x04016A65 RID: 92773
		internal static int __PropertyOffset_441;

		// Token: 0x04016A66 RID: 92774
		internal static int __PropertyOffset_442;

		// Token: 0x04016A67 RID: 92775
		internal static int __PropertyOffset_443;

		// Token: 0x04016A68 RID: 92776
		internal static int __PropertyOffset_444;

		// Token: 0x04016A69 RID: 92777
		internal static int __PropertyOffset_445;

		// Token: 0x04016A6A RID: 92778
		internal static int __PropertyOffset_446;

		// Token: 0x04016A6B RID: 92779
		internal static int __PropertyOffset_447;

		// Token: 0x04016A6C RID: 92780
		internal static int __PropertyOffset_448;

		// Token: 0x04016A6D RID: 92781
		internal static int __PropertyOffset_449;

		// Token: 0x04016A6E RID: 92782
		internal static int __PropertyOffset_450;

		// Token: 0x04016A6F RID: 92783
		internal static int __PropertyOffset_451;

		// Token: 0x04016A70 RID: 92784
		internal static int __PropertyOffset_452;

		// Token: 0x04016A71 RID: 92785
		internal static int __PropertyOffset_453;

		// Token: 0x04016A72 RID: 92786
		internal static int __PropertyOffset_454;

		// Token: 0x04016A73 RID: 92787
		internal static int __PropertyOffset_455;

		// Token: 0x04016A74 RID: 92788
		internal static int __PropertyOffset_456;

		// Token: 0x04016A75 RID: 92789
		internal static int __PropertyOffset_457;

		// Token: 0x04016A76 RID: 92790
		internal static int __PropertyOffset_458;

		// Token: 0x04016A77 RID: 92791
		internal static int __PropertyOffset_459;

		// Token: 0x04016A78 RID: 92792
		internal static int __PropertyOffset_460;

		// Token: 0x04016A79 RID: 92793
		internal static int __PropertyOffset_461;

		// Token: 0x04016A7A RID: 92794
		private FPoseSnapshot _CachePose;

		// Token: 0x04016A7B RID: 92795
		internal static int __PropertyOffset_462;

		// Token: 0x04016A7C RID: 92796
		internal static int __PropertyOffset_463;

		// Token: 0x04016A7D RID: 92797
		internal static int __PropertyOffset_464;

		// Token: 0x04016A7E RID: 92798
		internal static int __PropertyOffset_465;

		// Token: 0x04016A7F RID: 92799
		internal static int __PropertyOffset_466;

		// Token: 0x04016A80 RID: 92800
		internal static int __PropertyOffset_467;

		// Token: 0x04016A81 RID: 92801
		internal static int __PropertyOffset_468;

		// Token: 0x04016A82 RID: 92802
		internal static int __PropertyOffset_469;

		// Token: 0x04016A83 RID: 92803
		internal static int __PropertyOffset_470;

		// Token: 0x04016A84 RID: 92804
		internal static int __PropertyOffset_471;

		// Token: 0x04016A85 RID: 92805
		internal static int __PropertyOffset_472;

		// Token: 0x04016A86 RID: 92806
		internal static int __PropertyOffset_473;

		// Token: 0x04016A87 RID: 92807
		internal static int __PropertyOffset_474;

		// Token: 0x04016A88 RID: 92808
		private static IntPtr __骨骼混合叠加层_NativeFunctionPtr;

		// Token: 0x04016A89 RID: 92809
		private static IntPtr __基础姿势层_NativeFunctionPtr;

		// Token: 0x04016A8A RID: 92810
		private static IntPtr __混合层_NativeFunctionPtr;

		// Token: 0x04016A8B RID: 92811
		private static IntPtr __手臂叠加层_NativeFunctionPtr;

		// Token: 0x04016A8C RID: 92812
		private static IntPtr __叠加层_NativeFunctionPtr;

		// Token: 0x04016A8D RID: 92813
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016A8E RID: 92814
		private static IntPtr __重置坐下待机计时_NativeFunctionPtr;

		// Token: 0x04016A8F RID: 92815
		private static IntPtr __更新坐下待机计时_NativeFunctionPtr;

		// Token: 0x04016A90 RID: 92816
		private static IntPtr __更新牵手组件参数_NativeFunctionPtr;

		// Token: 0x04016A91 RID: 92817
		private static IntPtr __更新载具信息_NativeFunctionPtr;

		// Token: 0x04016A92 RID: 92818
		private static IntPtr __初始化身高_NativeFunctionPtr;

		// Token: 0x04016A93 RID: 92819
		private static IntPtr __组件参数动画蓝图初始化绑定_NativeFunctionPtr;

		// Token: 0x04016A94 RID: 92820
		private static IntPtr __绑定组件参数_NativeFunctionPtr;

		// Token: 0x04016A95 RID: 92821
		private static IntPtr __更新移动信息_NativeFunctionPtr;

		// Token: 0x04016A96 RID: 92822
		private static IntPtr __更新角色信息_NativeFunctionPtr;

		// Token: 0x04016A97 RID: 92823
		private static IntPtr __更新状态参数信息_NativeFunctionPtr;

		// Token: 0x04016A98 RID: 92824
		private static IntPtr __切换地面移动模式时高度补差_NativeFunctionPtr;

		// Token: 0x04016A99 RID: 92825
		private static IntPtr __更新上传_NativeFunctionPtr;

		// Token: 0x04016A9A RID: 92826
		private static IntPtr __更新时间参数_NativeFunctionPtr;

		// Token: 0x04016A9B RID: 92827
		private static IntPtr __更新网络参数_NativeFunctionPtr;

		// Token: 0x04016A9C RID: 92828
		private static IntPtr __更新动画组件参数_NativeFunctionPtr;

		// Token: 0x04016A9D RID: 92829
		private static IntPtr __更新移动组件参数_NativeFunctionPtr;

		// Token: 0x04016A9E RID: 92830
		private static IntPtr __更新随机表演_NativeFunctionPtr;

		// Token: 0x04016A9F RID: 92831
		private static IntPtr __更新角色状态_NativeFunctionPtr;

		// Token: 0x04016AA0 RID: 92832
		private static IntPtr __设置头部转向状态_NativeFunctionPtr;

		// Token: 0x04016AA1 RID: 92833
		private static IntPtr __更新头部转向_NativeFunctionPtr;

		// Token: 0x04016AA2 RID: 92834
		private static IntPtr __更新_IK信息_NativeFunctionPtr;

		// Token: 0x04016AA3 RID: 92835
		private static IntPtr __原地旋转检查_NativeFunctionPtr;

		// Token: 0x04016AA4 RID: 92836
		private static IntPtr __更新旋转信息_NativeFunctionPtr;

		// Token: 0x04016AA5 RID: 92837
		private static IntPtr __是否需要移动_NativeFunctionPtr;

		// Token: 0x04016AA6 RID: 92838
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016AA7 RID: 92839
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016AA8 RID: 92840
		private static IntPtr __播放动画_NativeFunctionPtr;

		// Token: 0x04016AA9 RID: 92841
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x04016AAA RID: 92842
		private static IntPtr __MovementChanged_NativeFunctionPtr;

		// Token: 0x04016AAB RID: 92843
		private static IntPtr __PlotBlendIn_NativeFunctionPtr;

		// Token: 0x04016AAC RID: 92844
		private static IntPtr __NoExpose_NativeFunctionPtr;

		// Token: 0x0200A535 RID: 42293
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __骨骼混合叠加层_FunctionParams
		{
			// Token: 0x040323A6 RID: 205734
			[FieldOffset(0)]
			public byte BaseLayer;

			// Token: 0x040323A7 RID: 205735
			[FieldOffset(24)]
			public byte OverlayLayer;

			// Token: 0x040323A8 RID: 205736
			[FieldOffset(48)]
			public byte BasePose;

			// Token: 0x040323A9 RID: 205737
			[FieldOffset(72)]
			public byte 骨骼混合叠加层;
		}

		// Token: 0x0200A536 RID: 42294
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础姿势层_FunctionParams
		{
			// Token: 0x040323AA RID: 205738
			[FieldOffset(0)]
			public byte 基础姿势层;
		}

		// Token: 0x0200A537 RID: 42295
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __混合层_FunctionParams
		{
			// Token: 0x040323AB RID: 205739
			[FieldOffset(0)]
			public byte 基础层输入;

			// Token: 0x040323AC RID: 205740
			[FieldOffset(24)]
			public byte 叠加层输入;

			// Token: 0x040323AD RID: 205741
			[FieldOffset(48)]
			public byte 姿势层输入;

			// Token: 0x040323AE RID: 205742
			[FieldOffset(72)]
			public byte 手臂叠加层输入;

			// Token: 0x040323AF RID: 205743
			[FieldOffset(96)]
			public byte 混合层;
		}

		// Token: 0x0200A538 RID: 42296
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __手臂叠加层_FunctionParams
		{
			// Token: 0x040323B0 RID: 205744
			[FieldOffset(0)]
			public byte 手臂叠加层;
		}

		// Token: 0x0200A539 RID: 42297
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __叠加层_FunctionParams
		{
			// Token: 0x040323B1 RID: 205745
			[FieldOffset(0)]
			public byte 叠加层;
		}

		// Token: 0x0200A53A RID: 42298
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040323B2 RID: 205746
			[FieldOffset(0)]
			public byte 地区运动模式;

			// Token: 0x040323B3 RID: 205747
			[FieldOffset(24)]
			public byte AnimGraph;
		}

		// Token: 0x0200A53B RID: 42299
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __设置头部转向状态_FunctionParams
		{
			// Token: 0x040323B4 RID: 205748
			[FieldOffset(0)]
			public SightLockMode SightMode;
		}

		// Token: 0x0200A53C RID: 42300
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __更新头部转向_FunctionParams
		{
			// Token: 0x040323B5 RID: 205749
			[FieldOffset(0)]
			public FRotator NewParam;
		}

		// Token: 0x0200A53D RID: 42301
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 6)]
		protected ref struct __是否需要移动_FunctionParams
		{
			// Token: 0x040323B6 RID: 205750
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200A53E RID: 42302
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040323B7 RID: 205751
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x0200A53F RID: 42303
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __播放动画_FunctionParams
		{
			// Token: 0x040323B8 RID: 205752
			[FieldOffset(0)]
			public byte 播放动画;
		}

		// Token: 0x0200A540 RID: 42304
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementChanged_FunctionParams
		{
			// Token: 0x040323B9 RID: 205753
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040323BA RID: 205754
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040323BB RID: 205755
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}
	}
}
