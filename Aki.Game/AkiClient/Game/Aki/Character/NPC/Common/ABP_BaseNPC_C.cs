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
	// Token: 0x020032B6 RID: 12982
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_BaseNPC.ABP_BaseNPC_C")]
	[UnrealStructLayout(13168, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13160)]
	public class ABP_BaseNPC_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020C17 RID: 134167 RVA: 0x0094E42A File Offset: 0x0094C62A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_BaseNPC.ABP_BaseNPC_C");
			}
			return ABP_BaseNPC_C._ClassPtr;
		}

		// Token: 0x06020C18 RID: 134168 RVA: 0x0094E450 File Offset: 0x0094C650
		public ABP_BaseNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C19 RID: 134169 RVA: 0x0094E478 File Offset: 0x0094C678
		[NullableContext(1)]
		public ABP_BaseNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x06020C1A RID: 134170 RVA: 0x0094E4AB File Offset: 0x0094C6AB
		// (set) Token: 0x06020C1B RID: 134171 RVA: 0x0094E4BF File Offset: 0x0094C6BF
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x06020C1C RID: 134172 RVA: 0x0094E4D4 File Offset: 0x0094C6D4
		// (set) Token: 0x06020C1D RID: 134173 RVA: 0x0094E4E8 File Offset: 0x0094C6E8
		public unsafe FVector 移动输入向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_移动输入向量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_移动输入向量) = value;
			}
		}

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x06020C1E RID: 134174 RVA: 0x0094E4FD File Offset: 0x0094C6FD
		// (set) Token: 0x06020C1F RID: 134175 RVA: 0x0094E50D File Offset: 0x0094C70D
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_速度) = value;
			}
		}

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x06020C20 RID: 134176 RVA: 0x0094E51E File Offset: 0x0094C71E
		// (set) Token: 0x06020C21 RID: 134177 RVA: 0x0094E52E File Offset: 0x0094C72E
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_是否有移动输入) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_是否有移动输入) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x06020C22 RID: 134178 RVA: 0x0094E53F File Offset: 0x0094C73F
		// (set) Token: 0x06020C23 RID: 134179 RVA: 0x0094E54F File Offset: 0x0094C74F
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_ifPlayIdleAction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_ifPlayIdleAction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x06020C24 RID: 134180 RVA: 0x0094E560 File Offset: 0x0094C760
		// (set) Token: 0x06020C25 RID: 134181 RVA: 0x0094E599 File Offset: 0x0094C799
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
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IdleMontageArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x06020C26 RID: 134182 RVA: 0x0094E5A7 File Offset: 0x0094C7A7
		// (set) Token: 0x06020C27 RID: 134183 RVA: 0x0094E5BB File Offset: 0x0094C7BB
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_C.__PropertyOffset_角色Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_C.__PropertyOffset_角色Mesh, value);
			}
		}

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x06020C28 RID: 134184 RVA: 0x0094E5D0 File Offset: 0x0094C7D0
		// (set) Token: 0x06020C29 RID: 134185 RVA: 0x0094E5E0 File Offset: 0x0094C7E0
		public unsafe bool 是否原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_是否原地转身) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_是否原地转身) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x06020C2A RID: 134186 RVA: 0x0094E5F1 File Offset: 0x0094C7F1
		// (set) Token: 0x06020C2B RID: 134187 RVA: 0x0094E601 File Offset: 0x0094C801
		public unsafe float 旋转角度差值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_旋转角度差值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_旋转角度差值) = value;
			}
		}

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x06020C2C RID: 134188 RVA: 0x0094E612 File Offset: 0x0094C812
		// (set) Token: 0x06020C2D RID: 134189 RVA: 0x0094E622 File Offset: 0x0094C822
		public unsafe float 上一次旋转角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_上一次旋转角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_上一次旋转角度) = value;
			}
		}

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x06020C2E RID: 134190 RVA: 0x0094E633 File Offset: 0x0094C833
		// (set) Token: 0x06020C2F RID: 134191 RVA: 0x0094E647 File Offset: 0x0094C847
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightDirect) = value;
			}
		}

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x06020C30 RID: 134192 RVA: 0x0094E65C File Offset: 0x0094C85C
		// (set) Token: 0x06020C31 RID: 134193 RVA: 0x0094E66C File Offset: 0x0094C86C
		public unsafe float HeadBaseYawBuffer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_HeadBaseYawBuffer);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_HeadBaseYawBuffer) = value;
			}
		}

		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x06020C32 RID: 134194 RVA: 0x0094E67D File Offset: 0x0094C87D
		// (set) Token: 0x06020C33 RID: 134195 RVA: 0x0094E68D File Offset: 0x0094C88D
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsBeingImpacted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsBeingImpacted) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x06020C34 RID: 134196 RVA: 0x0094E69E File Offset: 0x0094C89E
		// (set) Token: 0x06020C35 RID: 134197 RVA: 0x0094E6AE File Offset: 0x0094C8AE
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsBeingAttacked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsBeingAttacked) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x06020C36 RID: 134198 RVA: 0x0094E6BF File Offset: 0x0094C8BF
		// (set) Token: 0x06020C37 RID: 134199 RVA: 0x0094E6CF File Offset: 0x0094C8CF
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockMode) = (byte)value;
			}
		}

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x06020C38 RID: 134200 RVA: 0x0094E6E0 File Offset: 0x0094C8E0
		// (set) Token: 0x06020C39 RID: 134201 RVA: 0x0094E6F0 File Offset: 0x0094C8F0
		public unsafe float 走跑混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_走跑混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_走跑混合) = value;
			}
		}

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x06020C3A RID: 134202 RVA: 0x0094E701 File Offset: 0x0094C901
		// (set) Token: 0x06020C3B RID: 134203 RVA: 0x0094E711 File Offset: 0x0094C911
		public unsafe bool IsTurnLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsTurnLeft) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsTurnLeft) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x06020C3C RID: 134204 RVA: 0x0094E722 File Offset: 0x0094C922
		// (set) Token: 0x06020C3D RID: 134205 RVA: 0x0094E736 File Offset: 0x0094C936
		public unsafe FRotator 角色旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_角色旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_角色旋转) = value;
			}
		}

		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x06020C3E RID: 134206 RVA: 0x0094E74B File Offset: 0x0094C94B
		// (set) Token: 0x06020C3F RID: 134207 RVA: 0x0094E75B File Offset: 0x0094C95B
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_NpcEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_NpcEntityId) = value;
			}
		}

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x06020C40 RID: 134208 RVA: 0x0094E76C File Offset: 0x0094C96C
		// (set) Token: 0x06020C41 RID: 134209 RVA: 0x0094E77C File Offset: 0x0094C97C
		public unsafe float CollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_CollisionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_CollisionStrength) = value;
			}
		}

		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x06020C42 RID: 134210 RVA: 0x0094E78D File Offset: 0x0094C98D
		// (set) Token: 0x06020C43 RID: 134211 RVA: 0x0094E79D File Offset: 0x0094C99D
		public unsafe float CollisionDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_CollisionDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_CollisionDirection) = value;
			}
		}

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x06020C44 RID: 134212 RVA: 0x0094E7AE File Offset: 0x0094C9AE
		// (set) Token: 0x06020C45 RID: 134213 RVA: 0x0094E7BE File Offset: 0x0094C9BE
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_RandomEpresionEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_RandomEpresionEndTime) = value;
			}
		}

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x06020C46 RID: 134214 RVA: 0x0094E7CF File Offset: 0x0094C9CF
		// (set) Token: 0x06020C47 RID: 134215 RVA: 0x0094E7DF File Offset: 0x0094C9DF
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_眨眼动画时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_眨眼动画时长) = value;
			}
		}

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x06020C48 RID: 134216 RVA: 0x0094E7F0 File Offset: 0x0094C9F0
		// (set) Token: 0x06020C49 RID: 134217 RVA: 0x0094E800 File Offset: 0x0094CA00
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_此轮眨眼动画总时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_此轮眨眼动画总时长) = value;
			}
		}

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x06020C4A RID: 134218 RVA: 0x0094E811 File Offset: 0x0094CA11
		// (set) Token: 0x06020C4B RID: 134219 RVA: 0x0094E821 File Offset: 0x0094CA21
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_ExpresionAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_ExpresionAlpha) = value;
			}
		}

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x06020C4C RID: 134220 RVA: 0x0094E832 File Offset: 0x0094CA32
		// (set) Token: 0x06020C4D RID: 134221 RVA: 0x0094E842 File Offset: 0x0094CA42
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_眨眼中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_眨眼中) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x06020C4E RID: 134222 RVA: 0x0094E853 File Offset: 0x0094CA53
		// (set) Token: 0x06020C4F RID: 134223 RVA: 0x0094E863 File Offset: 0x0094CA63
		public unsafe bool Cache原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_Cache原地转身) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_Cache原地转身) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x06020C50 RID: 134224 RVA: 0x0094E874 File Offset: 0x0094CA74
		// (set) Token: 0x06020C51 RID: 134225 RVA: 0x0094E8AD File Offset: 0x0094CAAD
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
					result = (this._口型曲线 = new TArray<FName>(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_口型曲线, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.口型曲线.CopyAssign(value);
			}
		}

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x06020C52 RID: 134226 RVA: 0x0094E8BB File Offset: 0x0094CABB
		// (set) Token: 0x06020C53 RID: 134227 RVA: 0x0094E8CB File Offset: 0x0094CACB
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_状态_地区运动模式) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_状态_地区运动模式) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x06020C54 RID: 134228 RVA: 0x0094E8DC File Offset: 0x0094CADC
		// (set) Token: 0x06020C55 RID: 134229 RVA: 0x0094E8EC File Offset: 0x0094CAEC
		public unsafe bool 状态_地区运动模式_临时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_状态_地区运动模式_临时) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_状态_地区运动模式_临时) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x06020C56 RID: 134230 RVA: 0x0094E8FD File Offset: 0x0094CAFD
		// (set) Token: 0x06020C57 RID: 134231 RVA: 0x0094E90D File Offset: 0x0094CB0D
		public unsafe float TurnYawRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_TurnYawRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_TurnYawRate) = value;
			}
		}

		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x06020C58 RID: 134232 RVA: 0x0094E91E File Offset: 0x0094CB1E
		// (set) Token: 0x06020C59 RID: 134233 RVA: 0x0094E92E File Offset: 0x0094CB2E
		public unsafe bool IsEnableTurnMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsEnableTurnMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsEnableTurnMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x06020C5A RID: 134234 RVA: 0x0094E93F File Offset: 0x0094CB3F
		// (set) Token: 0x06020C5B RID: 134235 RVA: 0x0094E94F File Offset: 0x0094CB4F
		public unsafe bool IsForceUpdateSourceAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsForceUpdateSourceAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_IsForceUpdateSourceAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x06020C5C RID: 134236 RVA: 0x0094E960 File Offset: 0x0094CB60
		// (set) Token: 0x06020C5D RID: 134237 RVA: 0x0094E974 File Offset: 0x0094CB74
		public unsafe FName SightLockSightBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockSightBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockSightBoneName) = value;
			}
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x06020C5E RID: 134238 RVA: 0x0094E989 File Offset: 0x0094CB89
		// (set) Token: 0x06020C5F RID: 134239 RVA: 0x0094E99D File Offset: 0x0094CB9D
		public unsafe FName SightLockBeginBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockBeginBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockBeginBoneName) = value;
			}
		}

		// Token: 0x17004113 RID: 16659
		// (get) Token: 0x06020C60 RID: 134240 RVA: 0x0094E9B2 File Offset: 0x0094CBB2
		// (set) Token: 0x06020C61 RID: 134241 RVA: 0x0094E9C6 File Offset: 0x0094CBC6
		public unsafe FName SightLockEndBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockEndBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockEndBoneName) = value;
			}
		}

		// Token: 0x17004114 RID: 16660
		// (get) Token: 0x06020C62 RID: 134242 RVA: 0x0094E9DB File Offset: 0x0094CBDB
		// (set) Token: 0x06020C63 RID: 134243 RVA: 0x0094E9EF File Offset: 0x0094CBEF
		public unsafe FVector SightLockForwardAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockForwardAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockForwardAxis) = value;
			}
		}

		// Token: 0x17004115 RID: 16661
		// (get) Token: 0x06020C64 RID: 134244 RVA: 0x0094EA04 File Offset: 0x0094CC04
		// (set) Token: 0x06020C65 RID: 134245 RVA: 0x0094EA18 File Offset: 0x0094CC18
		public unsafe FVector SightLockUpAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockUpAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_C.__PropertyOffset_SightLockUpAxis) = value;
			}
		}

		// Token: 0x06020C66 RID: 134246 RVA: 0x0094EA30 File Offset: 0x0094CC30
		[SkipLocalsInit]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_BaseNPC_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x06020C67 RID: 134247 RVA: 0x0094EA7F File Offset: 0x0094CC7F
		[SkipLocalsInit]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x06020C68 RID: 134248 RVA: 0x0094EA93 File Offset: 0x0094CC93
		[SkipLocalsInit]
		public virtual void 更新眨眼()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新眨眼_NativeFunctionPtr, null);
		}

		// Token: 0x06020C69 RID: 134249 RVA: 0x0094EAA8 File Offset: 0x0094CCA8
		[SkipLocalsInit]
		public unsafe virtual void HasInputRotate(ref bool Output_Get)
		{
			ABP_BaseNPC_C.__HasInputRotate_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__HasInputRotate_FunctionParams[(UIntPtr)91] + 15L / (long)sizeof(ABP_BaseNPC_C.__HasInputRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Output_Get = Output_Get;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr);
			Output_Get = ptr->Output_Get;
		}

		// Token: 0x06020C6A RID: 134250 RVA: 0x0094EAF8 File Offset: 0x0094CCF8
		[SkipLocalsInit]
		public unsafe virtual void 是否AI驱动(ref bool Result)
		{
			ABP_BaseNPC_C.__是否AI驱动_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__是否AI驱动_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_BaseNPC_C.__是否AI驱动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06020C6B RID: 134251 RVA: 0x0094EB47 File Offset: 0x0094CD47
		[SkipLocalsInit]
		public virtual void 更新角色转身()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新角色转身_NativeFunctionPtr, null);
		}

		// Token: 0x06020C6C RID: 134252 RVA: 0x0094EB5B File Offset: 0x0094CD5B
		[SkipLocalsInit]
		public virtual void 更新角色移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新角色移动_NativeFunctionPtr, null);
		}

		// Token: 0x06020C6D RID: 134253 RVA: 0x0094EB6F File Offset: 0x0094CD6F
		[SkipLocalsInit]
		public virtual void 更新角色碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新角色碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x06020C6E RID: 134254 RVA: 0x0094EB83 File Offset: 0x0094CD83
		[SkipLocalsInit]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x06020C6F RID: 134255 RVA: 0x0094EB97 File Offset: 0x0094CD97
		[SkipLocalsInit]
		public virtual void 更新角色信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__更新角色信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020C70 RID: 134256 RVA: 0x0094EBAC File Offset: 0x0094CDAC
		[SkipLocalsInit]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_BaseNPC_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C71 RID: 134257 RVA: 0x0094EBF4 File Offset: 0x0094CDF4
		[SkipLocalsInit]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C72 RID: 134258 RVA: 0x0094EC3C File Offset: 0x0094CE3C
		[SkipLocalsInit]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_BaseNPC_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C73 RID: 134259 RVA: 0x0094EC84 File Offset: 0x0094CE84
		[SkipLocalsInit]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_BaseNPC_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C74 RID: 134260 RVA: 0x0094ECCA File Offset: 0x0094CECA
		[SkipLocalsInit]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x06020C75 RID: 134261 RVA: 0x0094ECDE File Offset: 0x0094CEDE
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020C76 RID: 134262 RVA: 0x0094ECF2 File Offset: 0x0094CEF2
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020C77 RID: 134263 RVA: 0x0094ED08 File Offset: 0x0094CF08
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C78 RID: 134264 RVA: 0x0094ED50 File Offset: 0x0094CF50
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C79 RID: 134265 RVA: 0x0094ED96 File Offset: 0x0094CF96
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020C7A RID: 134266 RVA: 0x0094EDAA File Offset: 0x0094CFAA
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020C7B RID: 134267 RVA: 0x0094EDBE File Offset: 0x0094CFBE
		protected ABP_BaseNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B7F RID: 72575
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_BaseNPC.ABP_BaseNPC_C";

		// Token: 0x04011B80 RID: 72576
		private static IntPtr _ClassPtr;

		// Token: 0x04011B81 RID: 72577
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B82 RID: 72578
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011B83 RID: 72579
		internal static int __PropertyOffset_移动输入向量;

		// Token: 0x04011B84 RID: 72580
		internal static int __PropertyOffset_速度;

		// Token: 0x04011B85 RID: 72581
		internal static int __PropertyOffset_是否有移动输入;

		// Token: 0x04011B86 RID: 72582
		internal static int __PropertyOffset_ifPlayIdleAction;

		// Token: 0x04011B87 RID: 72583
		internal static int __PropertyOffset_IdleMontageArray;

		// Token: 0x04011B88 RID: 72584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04011B89 RID: 72585
		internal static int __PropertyOffset_角色Mesh;

		// Token: 0x04011B8A RID: 72586
		internal static int __PropertyOffset_是否原地转身;

		// Token: 0x04011B8B RID: 72587
		internal static int __PropertyOffset_旋转角度差值;

		// Token: 0x04011B8C RID: 72588
		internal static int __PropertyOffset_上一次旋转角度;

		// Token: 0x04011B8D RID: 72589
		internal static int __PropertyOffset_SightDirect;

		// Token: 0x04011B8E RID: 72590
		internal static int __PropertyOffset_HeadBaseYawBuffer;

		// Token: 0x04011B8F RID: 72591
		internal static int __PropertyOffset_IsBeingImpacted;

		// Token: 0x04011B90 RID: 72592
		internal static int __PropertyOffset_IsBeingAttacked;

		// Token: 0x04011B91 RID: 72593
		internal static int __PropertyOffset_SightLockMode;

		// Token: 0x04011B92 RID: 72594
		internal static int __PropertyOffset_走跑混合;

		// Token: 0x04011B93 RID: 72595
		internal static int __PropertyOffset_IsTurnLeft;

		// Token: 0x04011B94 RID: 72596
		internal static int __PropertyOffset_角色旋转;

		// Token: 0x04011B95 RID: 72597
		internal static int __PropertyOffset_NpcEntityId;

		// Token: 0x04011B96 RID: 72598
		internal static int __PropertyOffset_CollisionStrength;

		// Token: 0x04011B97 RID: 72599
		internal static int __PropertyOffset_CollisionDirection;

		// Token: 0x04011B98 RID: 72600
		internal static int __PropertyOffset_RandomEpresionEndTime;

		// Token: 0x04011B99 RID: 72601
		internal static int __PropertyOffset_眨眼动画时长;

		// Token: 0x04011B9A RID: 72602
		internal static int __PropertyOffset_此轮眨眼动画总时长;

		// Token: 0x04011B9B RID: 72603
		internal static int __PropertyOffset_ExpresionAlpha;

		// Token: 0x04011B9C RID: 72604
		internal static int __PropertyOffset_眨眼中;

		// Token: 0x04011B9D RID: 72605
		internal static int __PropertyOffset_Cache原地转身;

		// Token: 0x04011B9E RID: 72606
		internal static int __PropertyOffset_口型曲线;

		// Token: 0x04011B9F RID: 72607
		[Nullable(2)]
		private TArray<FName> _口型曲线;

		// Token: 0x04011BA0 RID: 72608
		internal static int __PropertyOffset_状态_地区运动模式;

		// Token: 0x04011BA1 RID: 72609
		internal static int __PropertyOffset_状态_地区运动模式_临时;

		// Token: 0x04011BA2 RID: 72610
		internal static int __PropertyOffset_TurnYawRate;

		// Token: 0x04011BA3 RID: 72611
		internal static int __PropertyOffset_IsEnableTurnMove;

		// Token: 0x04011BA4 RID: 72612
		internal static int __PropertyOffset_IsForceUpdateSourceAnimation;

		// Token: 0x04011BA5 RID: 72613
		internal static int __PropertyOffset_SightLockSightBoneName;

		// Token: 0x04011BA6 RID: 72614
		internal static int __PropertyOffset_SightLockBeginBoneName;

		// Token: 0x04011BA7 RID: 72615
		internal static int __PropertyOffset_SightLockEndBoneName;

		// Token: 0x04011BA8 RID: 72616
		internal static int __PropertyOffset_SightLockForwardAxis;

		// Token: 0x04011BA9 RID: 72617
		internal static int __PropertyOffset_SightLockUpAxis;

		// Token: 0x04011BAA RID: 72618
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04011BAB RID: 72619
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x04011BAC RID: 72620
		private static IntPtr __更新眨眼_NativeFunctionPtr;

		// Token: 0x04011BAD RID: 72621
		private static IntPtr __HasInputRotate_NativeFunctionPtr;

		// Token: 0x04011BAE RID: 72622
		private static IntPtr __是否AI驱动_NativeFunctionPtr;

		// Token: 0x04011BAF RID: 72623
		private static IntPtr __更新角色转身_NativeFunctionPtr;

		// Token: 0x04011BB0 RID: 72624
		private static IntPtr __更新角色移动_NativeFunctionPtr;

		// Token: 0x04011BB1 RID: 72625
		private static IntPtr __更新角色碰撞_NativeFunctionPtr;

		// Token: 0x04011BB2 RID: 72626
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04011BB3 RID: 72627
		private static IntPtr __更新角色信息_NativeFunctionPtr;

		// Token: 0x04011BB4 RID: 72628
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04011BB5 RID: 72629
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04011BB6 RID: 72630
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04011BB7 RID: 72631
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04011BB8 RID: 72632
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04011BB9 RID: 72633
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04011BBA RID: 72634
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011BBB RID: 72635
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x02008FB2 RID: 36786
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x0402CD59 RID: 183641
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FB3 RID: 36787
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 76)]
		protected ref struct __HasInputRotate_FunctionParams
		{
			// Token: 0x0402CD5A RID: 183642
			[FieldOffset(0)]
			public bool Output_Get;
		}

		// Token: 0x02008FB4 RID: 36788
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __是否AI驱动_FunctionParams
		{
			// Token: 0x0402CD5B RID: 183643
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008FB5 RID: 36789
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x0402CD5C RID: 183644
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FB6 RID: 36790
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x0402CD5D RID: 183645
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x02008FB7 RID: 36791
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x0402CD5E RID: 183646
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FB8 RID: 36792
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x0402CD5F RID: 183647
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FB9 RID: 36793
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD60 RID: 183648
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
