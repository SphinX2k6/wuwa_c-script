using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Common
{
	// Token: 0x02004199 RID: 16793
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_BaseNPC.ABP_BaseNPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_BaseNPC_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602B966 RID: 178534 RVA: 0x00A04888 File Offset: 0x00A02A88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_BaseNPC.ABP_BaseNPC_C");
			}
			return ABP_BaseNPC_C._ClassPtr;
		}

		// Token: 0x0602B967 RID: 178535 RVA: 0x00A048AC File Offset: 0x00A02AAC
		public ABP_BaseNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B968 RID: 178536 RVA: 0x00A048D4 File Offset: 0x00A02AD4
		[NullableContext(1)]
		public ABP_BaseNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C00 RID: 27648
		// (get) Token: 0x0602B969 RID: 178537 RVA: 0x00A04907 File Offset: 0x00A02B07
		// (set) Token: 0x0602B96A RID: 178538 RVA: 0x00A0491B File Offset: 0x00A02B1B
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_C.__PropertyOffset_67);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_C.__PropertyOffset_67, value);
			}
		}

		// Token: 0x17006C01 RID: 27649
		// (get) Token: 0x0602B96B RID: 178539 RVA: 0x00A04930 File Offset: 0x00A02B30
		// (set) Token: 0x0602B96C RID: 178540 RVA: 0x00A04944 File Offset: 0x00A02B44
		public unsafe FVector 移动输入向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17006C02 RID: 27650
		// (get) Token: 0x0602B96D RID: 178541 RVA: 0x00A04959 File Offset: 0x00A02B59
		// (set) Token: 0x0602B96E RID: 178542 RVA: 0x00A04969 File Offset: 0x00A02B69
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x17006C03 RID: 27651
		// (get) Token: 0x0602B96F RID: 178543 RVA: 0x00A0497A File Offset: 0x00A02B7A
		// (set) Token: 0x0602B970 RID: 178544 RVA: 0x00A0498A File Offset: 0x00A02B8A
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_70) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_70) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C04 RID: 27652
		// (get) Token: 0x0602B971 RID: 178545 RVA: 0x00A0499B File Offset: 0x00A02B9B
		// (set) Token: 0x0602B972 RID: 178546 RVA: 0x00A049AB File Offset: 0x00A02BAB
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_71) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_71) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C05 RID: 27653
		// (get) Token: 0x0602B973 RID: 178547 RVA: 0x00A049BC File Offset: 0x00A02BBC
		// (set) Token: 0x0602B974 RID: 178548 RVA: 0x00A049F5 File Offset: 0x00A02BF5
		[Nullable(1)]
		public TArray<UAnimMontage> IdleMontageArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimMontage> result;
				if ((result = this._IdleMontageArray) == null)
				{
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_72, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x17006C06 RID: 27654
		// (get) Token: 0x0602B975 RID: 178549 RVA: 0x00A04A03 File Offset: 0x00A02C03
		// (set) Token: 0x0602B976 RID: 178550 RVA: 0x00A04A17 File Offset: 0x00A02C17
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_C.__PropertyOffset_73);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_C.__PropertyOffset_73, value);
			}
		}

		// Token: 0x17006C07 RID: 27655
		// (get) Token: 0x0602B977 RID: 178551 RVA: 0x00A04A2C File Offset: 0x00A02C2C
		// (set) Token: 0x0602B978 RID: 178552 RVA: 0x00A04A3C File Offset: 0x00A02C3C
		public unsafe bool 是否原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_74) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_74) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C08 RID: 27656
		// (get) Token: 0x0602B979 RID: 178553 RVA: 0x00A04A4D File Offset: 0x00A02C4D
		// (set) Token: 0x0602B97A RID: 178554 RVA: 0x00A04A5D File Offset: 0x00A02C5D
		public unsafe float 旋转角度差值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x17006C09 RID: 27657
		// (get) Token: 0x0602B97B RID: 178555 RVA: 0x00A04A6E File Offset: 0x00A02C6E
		// (set) Token: 0x0602B97C RID: 178556 RVA: 0x00A04A7E File Offset: 0x00A02C7E
		public unsafe float 上一次旋转角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x17006C0A RID: 27658
		// (get) Token: 0x0602B97D RID: 178557 RVA: 0x00A04A8F File Offset: 0x00A02C8F
		// (set) Token: 0x0602B97E RID: 178558 RVA: 0x00A04AA3 File Offset: 0x00A02CA3
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x17006C0B RID: 27659
		// (get) Token: 0x0602B97F RID: 178559 RVA: 0x00A04AB8 File Offset: 0x00A02CB8
		// (set) Token: 0x0602B980 RID: 178560 RVA: 0x00A04AC8 File Offset: 0x00A02CC8
		public unsafe float HeadBaseYawBuffer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_78);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_78) = value;
			}
		}

		// Token: 0x17006C0C RID: 27660
		// (get) Token: 0x0602B981 RID: 178561 RVA: 0x00A04AD9 File Offset: 0x00A02CD9
		// (set) Token: 0x0602B982 RID: 178562 RVA: 0x00A04AE9 File Offset: 0x00A02CE9
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_79) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_79) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C0D RID: 27661
		// (get) Token: 0x0602B983 RID: 178563 RVA: 0x00A04AFA File Offset: 0x00A02CFA
		// (set) Token: 0x0602B984 RID: 178564 RVA: 0x00A04B0A File Offset: 0x00A02D0A
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_80) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_80) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C0E RID: 27662
		// (get) Token: 0x0602B985 RID: 178565 RVA: 0x00A04B1B File Offset: 0x00A02D1B
		// (set) Token: 0x0602B986 RID: 178566 RVA: 0x00A04B2B File Offset: 0x00A02D2B
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_81));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_81) = (byte)value;
			}
		}

		// Token: 0x17006C0F RID: 27663
		// (get) Token: 0x0602B987 RID: 178567 RVA: 0x00A04B3C File Offset: 0x00A02D3C
		// (set) Token: 0x0602B988 RID: 178568 RVA: 0x00A04B4C File Offset: 0x00A02D4C
		public unsafe float 走跑混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_82);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_82) = value;
			}
		}

		// Token: 0x17006C10 RID: 27664
		// (get) Token: 0x0602B989 RID: 178569 RVA: 0x00A04B5D File Offset: 0x00A02D5D
		// (set) Token: 0x0602B98A RID: 178570 RVA: 0x00A04B6D File Offset: 0x00A02D6D
		public unsafe bool IsTurnLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_83) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_83) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C11 RID: 27665
		// (get) Token: 0x0602B98B RID: 178571 RVA: 0x00A04B7E File Offset: 0x00A02D7E
		// (set) Token: 0x0602B98C RID: 178572 RVA: 0x00A04B92 File Offset: 0x00A02D92
		public unsafe FRotator 角色旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_84);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_84) = value;
			}
		}

		// Token: 0x17006C12 RID: 27666
		// (get) Token: 0x0602B98D RID: 178573 RVA: 0x00A04BA7 File Offset: 0x00A02DA7
		// (set) Token: 0x0602B98E RID: 178574 RVA: 0x00A04BB7 File Offset: 0x00A02DB7
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_85);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_85) = value;
			}
		}

		// Token: 0x17006C13 RID: 27667
		// (get) Token: 0x0602B98F RID: 178575 RVA: 0x00A04BC8 File Offset: 0x00A02DC8
		// (set) Token: 0x0602B990 RID: 178576 RVA: 0x00A04BD8 File Offset: 0x00A02DD8
		public unsafe float CollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_86);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_86) = value;
			}
		}

		// Token: 0x17006C14 RID: 27668
		// (get) Token: 0x0602B991 RID: 178577 RVA: 0x00A04BE9 File Offset: 0x00A02DE9
		// (set) Token: 0x0602B992 RID: 178578 RVA: 0x00A04BF9 File Offset: 0x00A02DF9
		public unsafe float CollisionDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_87);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_87) = value;
			}
		}

		// Token: 0x17006C15 RID: 27669
		// (get) Token: 0x0602B993 RID: 178579 RVA: 0x00A04C0A File Offset: 0x00A02E0A
		// (set) Token: 0x0602B994 RID: 178580 RVA: 0x00A04C1A File Offset: 0x00A02E1A
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_88);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_88) = value;
			}
		}

		// Token: 0x17006C16 RID: 27670
		// (get) Token: 0x0602B995 RID: 178581 RVA: 0x00A04C2B File Offset: 0x00A02E2B
		// (set) Token: 0x0602B996 RID: 178582 RVA: 0x00A04C3B File Offset: 0x00A02E3B
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_89);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_89) = value;
			}
		}

		// Token: 0x17006C17 RID: 27671
		// (get) Token: 0x0602B997 RID: 178583 RVA: 0x00A04C4C File Offset: 0x00A02E4C
		// (set) Token: 0x0602B998 RID: 178584 RVA: 0x00A04C5C File Offset: 0x00A02E5C
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_90);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_90) = value;
			}
		}

		// Token: 0x17006C18 RID: 27672
		// (get) Token: 0x0602B999 RID: 178585 RVA: 0x00A04C6D File Offset: 0x00A02E6D
		// (set) Token: 0x0602B99A RID: 178586 RVA: 0x00A04C7D File Offset: 0x00A02E7D
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_91);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_91) = value;
			}
		}

		// Token: 0x17006C19 RID: 27673
		// (get) Token: 0x0602B99B RID: 178587 RVA: 0x00A04C8E File Offset: 0x00A02E8E
		// (set) Token: 0x0602B99C RID: 178588 RVA: 0x00A04C9E File Offset: 0x00A02E9E
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_92) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_92) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C1A RID: 27674
		// (get) Token: 0x0602B99D RID: 178589 RVA: 0x00A04CAF File Offset: 0x00A02EAF
		// (set) Token: 0x0602B99E RID: 178590 RVA: 0x00A04CBF File Offset: 0x00A02EBF
		public unsafe bool Cache原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_93) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_93) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C1B RID: 27675
		// (get) Token: 0x0602B99F RID: 178591 RVA: 0x00A04CD0 File Offset: 0x00A02ED0
		// (set) Token: 0x0602B9A0 RID: 178592 RVA: 0x00A04D09 File Offset: 0x00A02F09
		[Nullable(1)]
		public TArray<FName> 口型曲线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._口型曲线) == null)
				{
					result = (this._口型曲线 = new TArray<FName>(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_94, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.口型曲线.CopyAssign(value);
			}
		}

		// Token: 0x17006C1C RID: 27676
		// (get) Token: 0x0602B9A1 RID: 178593 RVA: 0x00A04D17 File Offset: 0x00A02F17
		// (set) Token: 0x0602B9A2 RID: 178594 RVA: 0x00A04D27 File Offset: 0x00A02F27
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_95) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_95) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C1D RID: 27677
		// (get) Token: 0x0602B9A3 RID: 178595 RVA: 0x00A04D38 File Offset: 0x00A02F38
		// (set) Token: 0x0602B9A4 RID: 178596 RVA: 0x00A04D48 File Offset: 0x00A02F48
		public unsafe bool 状态_地区运动模式_临时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_96) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_96) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C1E RID: 27678
		// (get) Token: 0x0602B9A5 RID: 178597 RVA: 0x00A04D59 File Offset: 0x00A02F59
		// (set) Token: 0x0602B9A6 RID: 178598 RVA: 0x00A04D69 File Offset: 0x00A02F69
		public unsafe float TurnYawRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_97);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_97) = value;
			}
		}

		// Token: 0x17006C1F RID: 27679
		// (get) Token: 0x0602B9A7 RID: 178599 RVA: 0x00A04D7A File Offset: 0x00A02F7A
		// (set) Token: 0x0602B9A8 RID: 178600 RVA: 0x00A04D8A File Offset: 0x00A02F8A
		public unsafe bool IsEnableTurnMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_98) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_98) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C20 RID: 27680
		// (get) Token: 0x0602B9A9 RID: 178601 RVA: 0x00A04D9B File Offset: 0x00A02F9B
		// (set) Token: 0x0602B9AA RID: 178602 RVA: 0x00A04DAB File Offset: 0x00A02FAB
		public unsafe bool IsForceUpdateSourceAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_99) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_99) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B9AB RID: 178603 RVA: 0x00A04DBC File Offset: 0x00A02FBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_BaseNPC_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x0602B9AC RID: 178604 RVA: 0x00A04E0C File Offset: 0x00A0300C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(FPoseLink 地区运动状态, ref FPoseLink 基础层)
		{
			ABP_BaseNPC_C.__基础层_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__基础层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseNPC_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (地区运动状态 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->地区运动状态, 地区运动状态.NativePtr, 1, false);
			}
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602B9AD RID: 178605 RVA: 0x00A04EB8 File Offset: 0x00A030B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseNPC_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseNPC_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602B9AE RID: 178606 RVA: 0x00A04F3F File Offset: 0x00A0313F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9AF RID: 178607 RVA: 0x00A04F53 File Offset: 0x00A03153
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新眨眼()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新眨眼_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9B0 RID: 178608 RVA: 0x00A04F68 File Offset: 0x00A03168
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasInputRotate(ref bool Output_Get)
		{
			ABP_BaseNPC_C.__HasInputRotate_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__HasInputRotate_FunctionParams[(UIntPtr)91] + 15L / (long)sizeof(ABP_BaseNPC_C.__HasInputRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Output_Get = Output_Get;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr);
			Output_Get = ptr->Output_Get;
		}

		// Token: 0x0602B9B1 RID: 178609 RVA: 0x00A04FB8 File Offset: 0x00A031B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 是否AI驱动(ref bool Result)
		{
			ABP_BaseNPC_C.__是否AI驱动_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__是否AI驱动_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_BaseNPC_C.__是否AI驱动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0602B9B2 RID: 178610 RVA: 0x00A05007 File Offset: 0x00A03207
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色转身()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新角色转身_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9B3 RID: 178611 RVA: 0x00A0501B File Offset: 0x00A0321B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新角色移动_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9B4 RID: 178612 RVA: 0x00A0502F File Offset: 0x00A0322F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新角色碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9B5 RID: 178613 RVA: 0x00A05043 File Offset: 0x00A03243
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9B6 RID: 178614 RVA: 0x00A05057 File Offset: 0x00A03257
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新角色信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9B7 RID: 178615 RVA: 0x00A0506C File Offset: 0x00A0326C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_BaseNPC_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B9B8 RID: 178616 RVA: 0x00A050B4 File Offset: 0x00A032B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B9B9 RID: 178617 RVA: 0x00A050FC File Offset: 0x00A032FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_BaseNPC_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B9BA RID: 178618 RVA: 0x00A05144 File Offset: 0x00A03344
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_BaseNPC_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B9BB RID: 178619 RVA: 0x00A0518A File Offset: 0x00A0338A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9BC RID: 178620 RVA: 0x00A0519E File Offset: 0x00A0339E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9BD RID: 178621 RVA: 0x00A051B2 File Offset: 0x00A033B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B9BE RID: 178622 RVA: 0x00A051C8 File Offset: 0x00A033C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B9BF RID: 178623 RVA: 0x00A05210 File Offset: 0x00A03410
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B9C0 RID: 178624 RVA: 0x00A05257 File Offset: 0x00A03457
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B9C1 RID: 178625 RVA: 0x00A0526B File Offset: 0x00A0346B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseNPC_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B9C2 RID: 178626 RVA: 0x00A05280 File Offset: 0x00A03480
		protected ABP_BaseNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016B15 RID: 92949
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_BaseNPC.ABP_BaseNPC_C";

		// Token: 0x04016B16 RID: 92950
		private static IntPtr _ClassPtr;

		// Token: 0x04016B17 RID: 92951
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016B18 RID: 92952
		internal static int __PropertyOffset_67;

		// Token: 0x04016B19 RID: 92953
		internal static int __PropertyOffset_68;

		// Token: 0x04016B1A RID: 92954
		internal static int __PropertyOffset_69;

		// Token: 0x04016B1B RID: 92955
		internal static int __PropertyOffset_70;

		// Token: 0x04016B1C RID: 92956
		internal static int __PropertyOffset_71;

		// Token: 0x04016B1D RID: 92957
		internal static int __PropertyOffset_72;

		// Token: 0x04016B1E RID: 92958
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04016B1F RID: 92959
		internal static int __PropertyOffset_73;

		// Token: 0x04016B20 RID: 92960
		internal static int __PropertyOffset_74;

		// Token: 0x04016B21 RID: 92961
		internal static int __PropertyOffset_75;

		// Token: 0x04016B22 RID: 92962
		internal static int __PropertyOffset_76;

		// Token: 0x04016B23 RID: 92963
		internal static int __PropertyOffset_77;

		// Token: 0x04016B24 RID: 92964
		internal static int __PropertyOffset_78;

		// Token: 0x04016B25 RID: 92965
		internal static int __PropertyOffset_79;

		// Token: 0x04016B26 RID: 92966
		internal static int __PropertyOffset_80;

		// Token: 0x04016B27 RID: 92967
		internal static int __PropertyOffset_81;

		// Token: 0x04016B28 RID: 92968
		internal static int __PropertyOffset_82;

		// Token: 0x04016B29 RID: 92969
		internal static int __PropertyOffset_83;

		// Token: 0x04016B2A RID: 92970
		internal static int __PropertyOffset_84;

		// Token: 0x04016B2B RID: 92971
		internal static int __PropertyOffset_85;

		// Token: 0x04016B2C RID: 92972
		internal static int __PropertyOffset_86;

		// Token: 0x04016B2D RID: 92973
		internal static int __PropertyOffset_87;

		// Token: 0x04016B2E RID: 92974
		internal static int __PropertyOffset_88;

		// Token: 0x04016B2F RID: 92975
		internal static int __PropertyOffset_89;

		// Token: 0x04016B30 RID: 92976
		internal static int __PropertyOffset_90;

		// Token: 0x04016B31 RID: 92977
		internal static int __PropertyOffset_91;

		// Token: 0x04016B32 RID: 92978
		internal static int __PropertyOffset_92;

		// Token: 0x04016B33 RID: 92979
		internal static int __PropertyOffset_93;

		// Token: 0x04016B34 RID: 92980
		internal static int __PropertyOffset_94;

		// Token: 0x04016B35 RID: 92981
		[Nullable(2)]
		private TArray<FName> _口型曲线;

		// Token: 0x04016B36 RID: 92982
		internal static int __PropertyOffset_95;

		// Token: 0x04016B37 RID: 92983
		internal static int __PropertyOffset_96;

		// Token: 0x04016B38 RID: 92984
		internal static int __PropertyOffset_97;

		// Token: 0x04016B39 RID: 92985
		internal static int __PropertyOffset_98;

		// Token: 0x04016B3A RID: 92986
		internal static int __PropertyOffset_99;

		// Token: 0x04016B3B RID: 92987
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04016B3C RID: 92988
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016B3D RID: 92989
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016B3E RID: 92990
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x04016B3F RID: 92991
		private static IntPtr __更新眨眼_NativeFunctionPtr;

		// Token: 0x04016B40 RID: 92992
		private static IntPtr __HasInputRotate_NativeFunctionPtr;

		// Token: 0x04016B41 RID: 92993
		private static IntPtr __是否AI驱动_NativeFunctionPtr;

		// Token: 0x04016B42 RID: 92994
		private static IntPtr __更新角色转身_NativeFunctionPtr;

		// Token: 0x04016B43 RID: 92995
		private static IntPtr __更新角色移动_NativeFunctionPtr;

		// Token: 0x04016B44 RID: 92996
		private static IntPtr __更新角色碰撞_NativeFunctionPtr;

		// Token: 0x04016B45 RID: 92997
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04016B46 RID: 92998
		private static IntPtr __更新角色信息_NativeFunctionPtr;

		// Token: 0x04016B47 RID: 92999
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04016B48 RID: 93000
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04016B49 RID: 93001
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04016B4A RID: 93002
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04016B4B RID: 93003
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04016B4C RID: 93004
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016B4D RID: 93005
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016B4E RID: 93006
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x0200A549 RID: 42313
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x040323C7 RID: 205767
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A54A RID: 42314
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x040323C8 RID: 205768
			[FieldOffset(0)]
			public byte 地区运动状态;

			// Token: 0x040323C9 RID: 205769
			[FieldOffset(24)]
			public byte 基础层;
		}

		// Token: 0x0200A54B RID: 42315
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040323CA RID: 205770
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A54C RID: 42316
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 76)]
		protected ref struct __HasInputRotate_FunctionParams
		{
			// Token: 0x040323CB RID: 205771
			[FieldOffset(0)]
			public bool Output_Get;
		}

		// Token: 0x0200A54D RID: 42317
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __是否AI驱动_FunctionParams
		{
			// Token: 0x040323CC RID: 205772
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A54E RID: 42318
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x040323CD RID: 205773
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A54F RID: 42319
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x040323CE RID: 205774
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x0200A550 RID: 42320
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x040323CF RID: 205775
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A551 RID: 42321
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x040323D0 RID: 205776
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A552 RID: 42322
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040323D1 RID: 205777
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
