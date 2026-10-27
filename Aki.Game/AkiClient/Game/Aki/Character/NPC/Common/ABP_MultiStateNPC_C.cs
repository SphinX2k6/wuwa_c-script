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
	// Token: 0x0200419A RID: 16794
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_MultiStateNPC.ABP_MultiStateNPC_C")]
	[UnrealStructLayout(20208, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 20193)]
	public class ABP_MultiStateNPC_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602B9C3 RID: 178627 RVA: 0x00A05289 File Offset: 0x00A03489
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_MultiStateNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_MultiStateNPC.ABP_MultiStateNPC_C");
			}
			return ABP_MultiStateNPC_C._ClassPtr;
		}

		// Token: 0x0602B9C4 RID: 178628 RVA: 0x00A052B0 File Offset: 0x00A034B0
		public ABP_MultiStateNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_MultiStateNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B9C5 RID: 178629 RVA: 0x00A052D8 File Offset: 0x00A034D8
		[NullableContext(1)]
		public ABP_MultiStateNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_MultiStateNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C21 RID: 27681
		// (get) Token: 0x0602B9C6 RID: 178630 RVA: 0x00A0530B File Offset: 0x00A0350B
		// (set) Token: 0x0602B9C7 RID: 178631 RVA: 0x00A0531F File Offset: 0x00A0351F
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_123);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_123, value);
			}
		}

		// Token: 0x17006C22 RID: 27682
		// (get) Token: 0x0602B9C8 RID: 178632 RVA: 0x00A05334 File Offset: 0x00A03534
		// (set) Token: 0x0602B9C9 RID: 178633 RVA: 0x00A05348 File Offset: 0x00A03548
		public unsafe FVector 移动输入向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_124);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_124) = value;
			}
		}

		// Token: 0x17006C23 RID: 27683
		// (get) Token: 0x0602B9CA RID: 178634 RVA: 0x00A0535D File Offset: 0x00A0355D
		// (set) Token: 0x0602B9CB RID: 178635 RVA: 0x00A0536D File Offset: 0x00A0356D
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_125);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_125) = value;
			}
		}

		// Token: 0x17006C24 RID: 27684
		// (get) Token: 0x0602B9CC RID: 178636 RVA: 0x00A0537E File Offset: 0x00A0357E
		// (set) Token: 0x0602B9CD RID: 178637 RVA: 0x00A0538E File Offset: 0x00A0358E
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_126) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_126) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C25 RID: 27685
		// (get) Token: 0x0602B9CE RID: 178638 RVA: 0x00A0539F File Offset: 0x00A0359F
		// (set) Token: 0x0602B9CF RID: 178639 RVA: 0x00A053AF File Offset: 0x00A035AF
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_127) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_127) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C26 RID: 27686
		// (get) Token: 0x0602B9D0 RID: 178640 RVA: 0x00A053C0 File Offset: 0x00A035C0
		// (set) Token: 0x0602B9D1 RID: 178641 RVA: 0x00A053F9 File Offset: 0x00A035F9
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
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_128, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x17006C27 RID: 27687
		// (get) Token: 0x0602B9D2 RID: 178642 RVA: 0x00A05407 File Offset: 0x00A03607
		// (set) Token: 0x0602B9D3 RID: 178643 RVA: 0x00A0541B File Offset: 0x00A0361B
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_129);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_129, value);
			}
		}

		// Token: 0x17006C28 RID: 27688
		// (get) Token: 0x0602B9D4 RID: 178644 RVA: 0x00A05430 File Offset: 0x00A03630
		// (set) Token: 0x0602B9D5 RID: 178645 RVA: 0x00A05440 File Offset: 0x00A03640
		public unsafe bool 是否原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_130) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_130) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C29 RID: 27689
		// (get) Token: 0x0602B9D6 RID: 178646 RVA: 0x00A05451 File Offset: 0x00A03651
		// (set) Token: 0x0602B9D7 RID: 178647 RVA: 0x00A05461 File Offset: 0x00A03661
		public unsafe float 旋转角度差值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_131);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_131) = value;
			}
		}

		// Token: 0x17006C2A RID: 27690
		// (get) Token: 0x0602B9D8 RID: 178648 RVA: 0x00A05472 File Offset: 0x00A03672
		// (set) Token: 0x0602B9D9 RID: 178649 RVA: 0x00A05482 File Offset: 0x00A03682
		public unsafe float 上一次旋转角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_132);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_132) = value;
			}
		}

		// Token: 0x17006C2B RID: 27691
		// (get) Token: 0x0602B9DA RID: 178650 RVA: 0x00A05493 File Offset: 0x00A03693
		// (set) Token: 0x0602B9DB RID: 178651 RVA: 0x00A054A7 File Offset: 0x00A036A7
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_133);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_133) = value;
			}
		}

		// Token: 0x17006C2C RID: 27692
		// (get) Token: 0x0602B9DC RID: 178652 RVA: 0x00A054BC File Offset: 0x00A036BC
		// (set) Token: 0x0602B9DD RID: 178653 RVA: 0x00A054CC File Offset: 0x00A036CC
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_134) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_134) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C2D RID: 27693
		// (get) Token: 0x0602B9DE RID: 178654 RVA: 0x00A054DD File Offset: 0x00A036DD
		// (set) Token: 0x0602B9DF RID: 178655 RVA: 0x00A054ED File Offset: 0x00A036ED
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_135) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_135) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C2E RID: 27694
		// (get) Token: 0x0602B9E0 RID: 178656 RVA: 0x00A054FE File Offset: 0x00A036FE
		// (set) Token: 0x0602B9E1 RID: 178657 RVA: 0x00A0550E File Offset: 0x00A0370E
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_136));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_136) = (byte)value;
			}
		}

		// Token: 0x17006C2F RID: 27695
		// (get) Token: 0x0602B9E2 RID: 178658 RVA: 0x00A0551F File Offset: 0x00A0371F
		// (set) Token: 0x0602B9E3 RID: 178659 RVA: 0x00A0552F File Offset: 0x00A0372F
		public unsafe float 走跑混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_137);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_137) = value;
			}
		}

		// Token: 0x17006C30 RID: 27696
		// (get) Token: 0x0602B9E4 RID: 178660 RVA: 0x00A05540 File Offset: 0x00A03740
		// (set) Token: 0x0602B9E5 RID: 178661 RVA: 0x00A05550 File Offset: 0x00A03750
		public unsafe bool IsTurnLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_138) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_138) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C31 RID: 27697
		// (get) Token: 0x0602B9E6 RID: 178662 RVA: 0x00A05561 File Offset: 0x00A03761
		// (set) Token: 0x0602B9E7 RID: 178663 RVA: 0x00A05575 File Offset: 0x00A03775
		public unsafe FRotator 角色旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_139);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_139) = value;
			}
		}

		// Token: 0x17006C32 RID: 27698
		// (get) Token: 0x0602B9E8 RID: 178664 RVA: 0x00A0558A File Offset: 0x00A0378A
		// (set) Token: 0x0602B9E9 RID: 178665 RVA: 0x00A0559A File Offset: 0x00A0379A
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_140);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_140) = value;
			}
		}

		// Token: 0x17006C33 RID: 27699
		// (get) Token: 0x0602B9EA RID: 178666 RVA: 0x00A055AB File Offset: 0x00A037AB
		// (set) Token: 0x0602B9EB RID: 178667 RVA: 0x00A055BB File Offset: 0x00A037BB
		public unsafe float CollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_141);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_141) = value;
			}
		}

		// Token: 0x17006C34 RID: 27700
		// (get) Token: 0x0602B9EC RID: 178668 RVA: 0x00A055CC File Offset: 0x00A037CC
		// (set) Token: 0x0602B9ED RID: 178669 RVA: 0x00A055DC File Offset: 0x00A037DC
		public unsafe float CollisionDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_142);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_142) = value;
			}
		}

		// Token: 0x17006C35 RID: 27701
		// (get) Token: 0x0602B9EE RID: 178670 RVA: 0x00A055ED File Offset: 0x00A037ED
		// (set) Token: 0x0602B9EF RID: 178671 RVA: 0x00A055FD File Offset: 0x00A037FD
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_143);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_143) = value;
			}
		}

		// Token: 0x17006C36 RID: 27702
		// (get) Token: 0x0602B9F0 RID: 178672 RVA: 0x00A0560E File Offset: 0x00A0380E
		// (set) Token: 0x0602B9F1 RID: 178673 RVA: 0x00A0561E File Offset: 0x00A0381E
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_144);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_144) = value;
			}
		}

		// Token: 0x17006C37 RID: 27703
		// (get) Token: 0x0602B9F2 RID: 178674 RVA: 0x00A0562F File Offset: 0x00A0382F
		// (set) Token: 0x0602B9F3 RID: 178675 RVA: 0x00A0563F File Offset: 0x00A0383F
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_145);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_145) = value;
			}
		}

		// Token: 0x17006C38 RID: 27704
		// (get) Token: 0x0602B9F4 RID: 178676 RVA: 0x00A05650 File Offset: 0x00A03850
		// (set) Token: 0x0602B9F5 RID: 178677 RVA: 0x00A05660 File Offset: 0x00A03860
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_146);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_146) = value;
			}
		}

		// Token: 0x17006C39 RID: 27705
		// (get) Token: 0x0602B9F6 RID: 178678 RVA: 0x00A05671 File Offset: 0x00A03871
		// (set) Token: 0x0602B9F7 RID: 178679 RVA: 0x00A05681 File Offset: 0x00A03881
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_147) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_147) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C3A RID: 27706
		// (get) Token: 0x0602B9F8 RID: 178680 RVA: 0x00A05692 File Offset: 0x00A03892
		// (set) Token: 0x0602B9F9 RID: 178681 RVA: 0x00A056A2 File Offset: 0x00A038A2
		public unsafe bool Cache原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_148) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_148) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C3B RID: 27707
		// (get) Token: 0x0602B9FA RID: 178682 RVA: 0x00A056B4 File Offset: 0x00A038B4
		// (set) Token: 0x0602B9FB RID: 178683 RVA: 0x00A056ED File Offset: 0x00A038ED
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
					result = (this._口型曲线 = new TArray<FName>(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_149, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.口型曲线.CopyAssign(value);
			}
		}

		// Token: 0x17006C3C RID: 27708
		// (get) Token: 0x0602B9FC RID: 178684 RVA: 0x00A056FB File Offset: 0x00A038FB
		// (set) Token: 0x0602B9FD RID: 178685 RVA: 0x00A0570B File Offset: 0x00A0390B
		public unsafe int 当前状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_150);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_150) = value;
			}
		}

		// Token: 0x17006C3D RID: 27709
		// (get) Token: 0x0602B9FE RID: 178686 RVA: 0x00A0571C File Offset: 0x00A0391C
		// (set) Token: 0x0602B9FF RID: 178687 RVA: 0x00A0572C File Offset: 0x00A0392C
		public unsafe bool 是否无过渡切换状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_151) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_151) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C3E RID: 27710
		// (get) Token: 0x0602BA00 RID: 178688 RVA: 0x00A0573D File Offset: 0x00A0393D
		// (set) Token: 0x0602BA01 RID: 178689 RVA: 0x00A0574D File Offset: 0x00A0394D
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_152) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_152) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C3F RID: 27711
		// (get) Token: 0x0602BA02 RID: 178690 RVA: 0x00A0575E File Offset: 0x00A0395E
		// (set) Token: 0x0602BA03 RID: 178691 RVA: 0x00A0576E File Offset: 0x00A0396E
		public unsafe bool 状态_地区运动模式_临时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_153) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_153) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C40 RID: 27712
		// (get) Token: 0x0602BA04 RID: 178692 RVA: 0x00A0577F File Offset: 0x00A0397F
		// (set) Token: 0x0602BA05 RID: 178693 RVA: 0x00A05793 File Offset: 0x00A03993
		[Nullable(2)]
		public unsafe BP_ABPLogicParams_C Ts逻辑变量集
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_ABPLogicParams_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_154);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_154, value);
			}
		}

		// Token: 0x17006C41 RID: 27713
		// (get) Token: 0x0602BA06 RID: 178694 RVA: 0x00A057A8 File Offset: 0x00A039A8
		// (set) Token: 0x0602BA07 RID: 178695 RVA: 0x00A057B8 File Offset: 0x00A039B8
		public unsafe bool IsEnableTurnMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_155) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_155) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C42 RID: 27714
		// (get) Token: 0x0602BA08 RID: 178696 RVA: 0x00A057C9 File Offset: 0x00A039C9
		// (set) Token: 0x0602BA09 RID: 178697 RVA: 0x00A057D9 File Offset: 0x00A039D9
		public unsafe float TurnYawRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_156);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_156) = value;
			}
		}

		// Token: 0x17006C43 RID: 27715
		// (get) Token: 0x0602BA0A RID: 178698 RVA: 0x00A057EA File Offset: 0x00A039EA
		// (set) Token: 0x0602BA0B RID: 178699 RVA: 0x00A057FA File Offset: 0x00A039FA
		public unsafe bool IsForceUpdateSourceAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_157) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_157) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602BA0C RID: 178700 RVA: 0x00A0580C File Offset: 0x00A03A0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_MultiStateNPC_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x0602BA0D RID: 178701 RVA: 0x00A0585C File Offset: 0x00A03A5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(FPoseLink 地区运动状态, ref FPoseLink 基础层)
		{
			ABP_MultiStateNPC_C.__基础层_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__基础层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (地区运动状态 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->地区运动状态, 地区运动状态.NativePtr, 1, false);
			}
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BA0E RID: 178702 RVA: 0x00A05908 File Offset: 0x00A03B08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_MultiStateNPC_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BA0F RID: 178703 RVA: 0x00A0598F File Offset: 0x00A03B8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA10 RID: 178704 RVA: 0x00A059A3 File Offset: 0x00A03BA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色状态()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色状态_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA11 RID: 178705 RVA: 0x00A059B7 File Offset: 0x00A03BB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新眨眼()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新眨眼_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA12 RID: 178706 RVA: 0x00A059CC File Offset: 0x00A03BCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasInputRotate(ref bool Output_Get)
		{
			ABP_MultiStateNPC_C.__HasInputRotate_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__HasInputRotate_FunctionParams[(UIntPtr)91] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__HasInputRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Output_Get = Output_Get;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr);
			Output_Get = ptr->Output_Get;
		}

		// Token: 0x0602BA13 RID: 178707 RVA: 0x00A05A1C File Offset: 0x00A03C1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 是否AI驱动(ref bool Result)
		{
			ABP_MultiStateNPC_C.__是否AI驱动_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__是否AI驱动_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__是否AI驱动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0602BA14 RID: 178708 RVA: 0x00A05A6B File Offset: 0x00A03C6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色转身()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色转身_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA15 RID: 178709 RVA: 0x00A05A7F File Offset: 0x00A03C7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色移动_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA16 RID: 178710 RVA: 0x00A05A93 File Offset: 0x00A03C93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA17 RID: 178711 RVA: 0x00A05AA7 File Offset: 0x00A03CA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA18 RID: 178712 RVA: 0x00A05ABB File Offset: 0x00A03CBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA19 RID: 178713 RVA: 0x00A05AD0 File Offset: 0x00A03CD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_MultiStateNPC_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA1A RID: 178714 RVA: 0x00A05B18 File Offset: 0x00A03D18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA1B RID: 178715 RVA: 0x00A05B60 File Offset: 0x00A03D60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_MultiStateNPC_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA1C RID: 178716 RVA: 0x00A05BA8 File Offset: 0x00A03DA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_MultiStateNPC_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA1D RID: 178717 RVA: 0x00A05BEE File Offset: 0x00A03DEE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA1E RID: 178718 RVA: 0x00A05C02 File Offset: 0x00A03E02
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA1F RID: 178719 RVA: 0x00A05C16 File Offset: 0x00A03E16
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MultiStateNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BA20 RID: 178720 RVA: 0x00A05C2C File Offset: 0x00A03E2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA21 RID: 178721 RVA: 0x00A05C74 File Offset: 0x00A03E74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BA22 RID: 178722 RVA: 0x00A05CBB File Offset: 0x00A03EBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA23 RID: 178723 RVA: 0x00A05CCF File Offset: 0x00A03ECF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MultiStateNPC_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BA24 RID: 178724 RVA: 0x00A05CE4 File Offset: 0x00A03EE4
		protected ABP_MultiStateNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016B4F RID: 93007
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_MultiStateNPC.ABP_MultiStateNPC_C";

		// Token: 0x04016B50 RID: 93008
		private static IntPtr _ClassPtr;

		// Token: 0x04016B51 RID: 93009
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016B52 RID: 93010
		internal static int __PropertyOffset_123;

		// Token: 0x04016B53 RID: 93011
		internal static int __PropertyOffset_124;

		// Token: 0x04016B54 RID: 93012
		internal static int __PropertyOffset_125;

		// Token: 0x04016B55 RID: 93013
		internal static int __PropertyOffset_126;

		// Token: 0x04016B56 RID: 93014
		internal static int __PropertyOffset_127;

		// Token: 0x04016B57 RID: 93015
		internal static int __PropertyOffset_128;

		// Token: 0x04016B58 RID: 93016
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04016B59 RID: 93017
		internal static int __PropertyOffset_129;

		// Token: 0x04016B5A RID: 93018
		internal static int __PropertyOffset_130;

		// Token: 0x04016B5B RID: 93019
		internal static int __PropertyOffset_131;

		// Token: 0x04016B5C RID: 93020
		internal static int __PropertyOffset_132;

		// Token: 0x04016B5D RID: 93021
		internal static int __PropertyOffset_133;

		// Token: 0x04016B5E RID: 93022
		internal static int __PropertyOffset_134;

		// Token: 0x04016B5F RID: 93023
		internal static int __PropertyOffset_135;

		// Token: 0x04016B60 RID: 93024
		internal static int __PropertyOffset_136;

		// Token: 0x04016B61 RID: 93025
		internal static int __PropertyOffset_137;

		// Token: 0x04016B62 RID: 93026
		internal static int __PropertyOffset_138;

		// Token: 0x04016B63 RID: 93027
		internal static int __PropertyOffset_139;

		// Token: 0x04016B64 RID: 93028
		internal static int __PropertyOffset_140;

		// Token: 0x04016B65 RID: 93029
		internal static int __PropertyOffset_141;

		// Token: 0x04016B66 RID: 93030
		internal static int __PropertyOffset_142;

		// Token: 0x04016B67 RID: 93031
		internal static int __PropertyOffset_143;

		// Token: 0x04016B68 RID: 93032
		internal static int __PropertyOffset_144;

		// Token: 0x04016B69 RID: 93033
		internal static int __PropertyOffset_145;

		// Token: 0x04016B6A RID: 93034
		internal static int __PropertyOffset_146;

		// Token: 0x04016B6B RID: 93035
		internal static int __PropertyOffset_147;

		// Token: 0x04016B6C RID: 93036
		internal static int __PropertyOffset_148;

		// Token: 0x04016B6D RID: 93037
		internal static int __PropertyOffset_149;

		// Token: 0x04016B6E RID: 93038
		[Nullable(2)]
		private TArray<FName> _口型曲线;

		// Token: 0x04016B6F RID: 93039
		internal static int __PropertyOffset_150;

		// Token: 0x04016B70 RID: 93040
		internal static int __PropertyOffset_151;

		// Token: 0x04016B71 RID: 93041
		internal static int __PropertyOffset_152;

		// Token: 0x04016B72 RID: 93042
		internal static int __PropertyOffset_153;

		// Token: 0x04016B73 RID: 93043
		internal static int __PropertyOffset_154;

		// Token: 0x04016B74 RID: 93044
		internal static int __PropertyOffset_155;

		// Token: 0x04016B75 RID: 93045
		internal static int __PropertyOffset_156;

		// Token: 0x04016B76 RID: 93046
		internal static int __PropertyOffset_157;

		// Token: 0x04016B77 RID: 93047
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04016B78 RID: 93048
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016B79 RID: 93049
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016B7A RID: 93050
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x04016B7B RID: 93051
		private static IntPtr __更新角色状态_NativeFunctionPtr;

		// Token: 0x04016B7C RID: 93052
		private static IntPtr __更新眨眼_NativeFunctionPtr;

		// Token: 0x04016B7D RID: 93053
		private static IntPtr __HasInputRotate_NativeFunctionPtr;

		// Token: 0x04016B7E RID: 93054
		private static IntPtr __是否AI驱动_NativeFunctionPtr;

		// Token: 0x04016B7F RID: 93055
		private static IntPtr __更新角色转身_NativeFunctionPtr;

		// Token: 0x04016B80 RID: 93056
		private static IntPtr __更新角色移动_NativeFunctionPtr;

		// Token: 0x04016B81 RID: 93057
		private static IntPtr __更新角色碰撞_NativeFunctionPtr;

		// Token: 0x04016B82 RID: 93058
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04016B83 RID: 93059
		private static IntPtr __更新角色信息_NativeFunctionPtr;

		// Token: 0x04016B84 RID: 93060
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04016B85 RID: 93061
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04016B86 RID: 93062
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04016B87 RID: 93063
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04016B88 RID: 93064
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04016B89 RID: 93065
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016B8A RID: 93066
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016B8B RID: 93067
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x0200A553 RID: 42323
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x040323D2 RID: 205778
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A554 RID: 42324
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x040323D3 RID: 205779
			[FieldOffset(0)]
			public byte 地区运动状态;

			// Token: 0x040323D4 RID: 205780
			[FieldOffset(24)]
			public byte 基础层;
		}

		// Token: 0x0200A555 RID: 42325
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040323D5 RID: 205781
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A556 RID: 42326
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 76)]
		protected ref struct __HasInputRotate_FunctionParams
		{
			// Token: 0x040323D6 RID: 205782
			[FieldOffset(0)]
			public bool Output_Get;
		}

		// Token: 0x0200A557 RID: 42327
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __是否AI驱动_FunctionParams
		{
			// Token: 0x040323D7 RID: 205783
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A558 RID: 42328
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x040323D8 RID: 205784
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A559 RID: 42329
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x040323D9 RID: 205785
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x0200A55A RID: 42330
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x040323DA RID: 205786
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A55B RID: 42331
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x040323DB RID: 205787
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A55C RID: 42332
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040323DC RID: 205788
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
