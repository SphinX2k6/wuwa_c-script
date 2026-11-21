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
	// Token: 0x020032B7 RID: 12983
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_MultiStateNPC.ABP_MultiStateNPC_C")]
	[UnrealStructLayout(20224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 20209)]
	public class ABP_MultiStateNPC_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020C7C RID: 134268 RVA: 0x0094EDC7 File Offset: 0x0094CFC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_MultiStateNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_MultiStateNPC.ABP_MultiStateNPC_C");
			}
			return ABP_MultiStateNPC_C._ClassPtr;
		}

		// Token: 0x06020C7D RID: 134269 RVA: 0x0094EDEC File Offset: 0x0094CFEC
		public ABP_MultiStateNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_MultiStateNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C7E RID: 134270 RVA: 0x0094EE14 File Offset: 0x0094D014
		[NullableContext(1)]
		public ABP_MultiStateNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_MultiStateNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004116 RID: 16662
		// (get) Token: 0x06020C7F RID: 134271 RVA: 0x0094EE47 File Offset: 0x0094D047
		// (set) Token: 0x06020C80 RID: 134272 RVA: 0x0094EE5B File Offset: 0x0094D05B
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x17004117 RID: 16663
		// (get) Token: 0x06020C81 RID: 134273 RVA: 0x0094EE70 File Offset: 0x0094D070
		// (set) Token: 0x06020C82 RID: 134274 RVA: 0x0094EE84 File Offset: 0x0094D084
		public unsafe FVector 移动输入向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_移动输入向量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_移动输入向量) = value;
			}
		}

		// Token: 0x17004118 RID: 16664
		// (get) Token: 0x06020C83 RID: 134275 RVA: 0x0094EE99 File Offset: 0x0094D099
		// (set) Token: 0x06020C84 RID: 134276 RVA: 0x0094EEA9 File Offset: 0x0094D0A9
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_速度) = value;
			}
		}

		// Token: 0x17004119 RID: 16665
		// (get) Token: 0x06020C85 RID: 134277 RVA: 0x0094EEBA File Offset: 0x0094D0BA
		// (set) Token: 0x06020C86 RID: 134278 RVA: 0x0094EECA File Offset: 0x0094D0CA
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_是否有移动输入) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_是否有移动输入) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x06020C87 RID: 134279 RVA: 0x0094EEDB File Offset: 0x0094D0DB
		// (set) Token: 0x06020C88 RID: 134280 RVA: 0x0094EEEB File Offset: 0x0094D0EB
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_ifPlayIdleAction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_ifPlayIdleAction) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x06020C89 RID: 134281 RVA: 0x0094EEFC File Offset: 0x0094D0FC
		// (set) Token: 0x06020C8A RID: 134282 RVA: 0x0094EF35 File Offset: 0x0094D135
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
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IdleMontageArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x06020C8B RID: 134283 RVA: 0x0094EF43 File Offset: 0x0094D143
		// (set) Token: 0x06020C8C RID: 134284 RVA: 0x0094EF57 File Offset: 0x0094D157
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_角色Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_角色Mesh, value);
			}
		}

		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x06020C8D RID: 134285 RVA: 0x0094EF6C File Offset: 0x0094D16C
		// (set) Token: 0x06020C8E RID: 134286 RVA: 0x0094EF7C File Offset: 0x0094D17C
		public unsafe bool 是否原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_是否原地转身) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_是否原地转身) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x06020C8F RID: 134287 RVA: 0x0094EF8D File Offset: 0x0094D18D
		// (set) Token: 0x06020C90 RID: 134288 RVA: 0x0094EF9D File Offset: 0x0094D19D
		public unsafe float 旋转角度差值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_旋转角度差值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_旋转角度差值) = value;
			}
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x06020C91 RID: 134289 RVA: 0x0094EFAE File Offset: 0x0094D1AE
		// (set) Token: 0x06020C92 RID: 134290 RVA: 0x0094EFBE File Offset: 0x0094D1BE
		public unsafe float 上一次旋转角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_上一次旋转角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_上一次旋转角度) = value;
			}
		}

		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x06020C93 RID: 134291 RVA: 0x0094EFCF File Offset: 0x0094D1CF
		// (set) Token: 0x06020C94 RID: 134292 RVA: 0x0094EFE3 File Offset: 0x0094D1E3
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_SightDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_SightDirect) = value;
			}
		}

		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x06020C95 RID: 134293 RVA: 0x0094EFF8 File Offset: 0x0094D1F8
		// (set) Token: 0x06020C96 RID: 134294 RVA: 0x0094F008 File Offset: 0x0094D208
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsBeingImpacted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsBeingImpacted) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x06020C97 RID: 134295 RVA: 0x0094F019 File Offset: 0x0094D219
		// (set) Token: 0x06020C98 RID: 134296 RVA: 0x0094F029 File Offset: 0x0094D229
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsBeingAttacked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsBeingAttacked) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x06020C99 RID: 134297 RVA: 0x0094F03A File Offset: 0x0094D23A
		// (set) Token: 0x06020C9A RID: 134298 RVA: 0x0094F04A File Offset: 0x0094D24A
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_SightLockMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_SightLockMode) = (byte)value;
			}
		}

		// Token: 0x17004124 RID: 16676
		// (get) Token: 0x06020C9B RID: 134299 RVA: 0x0094F05B File Offset: 0x0094D25B
		// (set) Token: 0x06020C9C RID: 134300 RVA: 0x0094F06B File Offset: 0x0094D26B
		public unsafe float 走跑混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_走跑混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_走跑混合) = value;
			}
		}

		// Token: 0x17004125 RID: 16677
		// (get) Token: 0x06020C9D RID: 134301 RVA: 0x0094F07C File Offset: 0x0094D27C
		// (set) Token: 0x06020C9E RID: 134302 RVA: 0x0094F08C File Offset: 0x0094D28C
		public unsafe bool IsTurnLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsTurnLeft) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsTurnLeft) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004126 RID: 16678
		// (get) Token: 0x06020C9F RID: 134303 RVA: 0x0094F09D File Offset: 0x0094D29D
		// (set) Token: 0x06020CA0 RID: 134304 RVA: 0x0094F0B1 File Offset: 0x0094D2B1
		public unsafe FRotator 角色旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_角色旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_角色旋转) = value;
			}
		}

		// Token: 0x17004127 RID: 16679
		// (get) Token: 0x06020CA1 RID: 134305 RVA: 0x0094F0C6 File Offset: 0x0094D2C6
		// (set) Token: 0x06020CA2 RID: 134306 RVA: 0x0094F0D6 File Offset: 0x0094D2D6
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_NpcEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_NpcEntityId) = value;
			}
		}

		// Token: 0x17004128 RID: 16680
		// (get) Token: 0x06020CA3 RID: 134307 RVA: 0x0094F0E7 File Offset: 0x0094D2E7
		// (set) Token: 0x06020CA4 RID: 134308 RVA: 0x0094F0F7 File Offset: 0x0094D2F7
		public unsafe float CollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_CollisionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_CollisionStrength) = value;
			}
		}

		// Token: 0x17004129 RID: 16681
		// (get) Token: 0x06020CA5 RID: 134309 RVA: 0x0094F108 File Offset: 0x0094D308
		// (set) Token: 0x06020CA6 RID: 134310 RVA: 0x0094F118 File Offset: 0x0094D318
		public unsafe float CollisionDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_CollisionDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_CollisionDirection) = value;
			}
		}

		// Token: 0x1700412A RID: 16682
		// (get) Token: 0x06020CA7 RID: 134311 RVA: 0x0094F129 File Offset: 0x0094D329
		// (set) Token: 0x06020CA8 RID: 134312 RVA: 0x0094F139 File Offset: 0x0094D339
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_RandomEpresionEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_RandomEpresionEndTime) = value;
			}
		}

		// Token: 0x1700412B RID: 16683
		// (get) Token: 0x06020CA9 RID: 134313 RVA: 0x0094F14A File Offset: 0x0094D34A
		// (set) Token: 0x06020CAA RID: 134314 RVA: 0x0094F15A File Offset: 0x0094D35A
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_眨眼动画时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_眨眼动画时长) = value;
			}
		}

		// Token: 0x1700412C RID: 16684
		// (get) Token: 0x06020CAB RID: 134315 RVA: 0x0094F16B File Offset: 0x0094D36B
		// (set) Token: 0x06020CAC RID: 134316 RVA: 0x0094F17B File Offset: 0x0094D37B
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_此轮眨眼动画总时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_此轮眨眼动画总时长) = value;
			}
		}

		// Token: 0x1700412D RID: 16685
		// (get) Token: 0x06020CAD RID: 134317 RVA: 0x0094F18C File Offset: 0x0094D38C
		// (set) Token: 0x06020CAE RID: 134318 RVA: 0x0094F19C File Offset: 0x0094D39C
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_ExpresionAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_ExpresionAlpha) = value;
			}
		}

		// Token: 0x1700412E RID: 16686
		// (get) Token: 0x06020CAF RID: 134319 RVA: 0x0094F1AD File Offset: 0x0094D3AD
		// (set) Token: 0x06020CB0 RID: 134320 RVA: 0x0094F1BD File Offset: 0x0094D3BD
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_眨眼中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_眨眼中) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700412F RID: 16687
		// (get) Token: 0x06020CB1 RID: 134321 RVA: 0x0094F1CE File Offset: 0x0094D3CE
		// (set) Token: 0x06020CB2 RID: 134322 RVA: 0x0094F1DE File Offset: 0x0094D3DE
		public unsafe bool Cache原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_Cache原地转身) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_Cache原地转身) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004130 RID: 16688
		// (get) Token: 0x06020CB3 RID: 134323 RVA: 0x0094F1F0 File Offset: 0x0094D3F0
		// (set) Token: 0x06020CB4 RID: 134324 RVA: 0x0094F229 File Offset: 0x0094D429
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
					result = (this._口型曲线 = new TArray<FName>(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_口型曲线, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.口型曲线.CopyAssign(value);
			}
		}

		// Token: 0x17004131 RID: 16689
		// (get) Token: 0x06020CB5 RID: 134325 RVA: 0x0094F237 File Offset: 0x0094D437
		// (set) Token: 0x06020CB6 RID: 134326 RVA: 0x0094F247 File Offset: 0x0094D447
		public unsafe int 当前状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_当前状态);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_当前状态) = value;
			}
		}

		// Token: 0x17004132 RID: 16690
		// (get) Token: 0x06020CB7 RID: 134327 RVA: 0x0094F258 File Offset: 0x0094D458
		// (set) Token: 0x06020CB8 RID: 134328 RVA: 0x0094F268 File Offset: 0x0094D468
		public unsafe bool 是否无过渡切换状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_是否无过渡切换状态) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_是否无过渡切换状态) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004133 RID: 16691
		// (get) Token: 0x06020CB9 RID: 134329 RVA: 0x0094F279 File Offset: 0x0094D479
		// (set) Token: 0x06020CBA RID: 134330 RVA: 0x0094F289 File Offset: 0x0094D489
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_状态_地区运动模式) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_状态_地区运动模式) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004134 RID: 16692
		// (get) Token: 0x06020CBB RID: 134331 RVA: 0x0094F29A File Offset: 0x0094D49A
		// (set) Token: 0x06020CBC RID: 134332 RVA: 0x0094F2AA File Offset: 0x0094D4AA
		public unsafe bool 状态_地区运动模式_临时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_状态_地区运动模式_临时) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_状态_地区运动模式_临时) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004135 RID: 16693
		// (get) Token: 0x06020CBD RID: 134333 RVA: 0x0094F2BB File Offset: 0x0094D4BB
		// (set) Token: 0x06020CBE RID: 134334 RVA: 0x0094F2CF File Offset: 0x0094D4CF
		[Nullable(2)]
		public unsafe BP_ABPLogicParams_C Ts逻辑变量集
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_ABPLogicParams_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_Ts逻辑变量集);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MultiStateNPC_C.__PropertyOffset_Ts逻辑变量集, value);
			}
		}

		// Token: 0x17004136 RID: 16694
		// (get) Token: 0x06020CBF RID: 134335 RVA: 0x0094F2E4 File Offset: 0x0094D4E4
		// (set) Token: 0x06020CC0 RID: 134336 RVA: 0x0094F2F4 File Offset: 0x0094D4F4
		public unsafe bool IsEnableTurnMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsEnableTurnMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsEnableTurnMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004137 RID: 16695
		// (get) Token: 0x06020CC1 RID: 134337 RVA: 0x0094F305 File Offset: 0x0094D505
		// (set) Token: 0x06020CC2 RID: 134338 RVA: 0x0094F315 File Offset: 0x0094D515
		public unsafe float TurnYawRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_TurnYawRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_TurnYawRate) = value;
			}
		}

		// Token: 0x17004138 RID: 16696
		// (get) Token: 0x06020CC3 RID: 134339 RVA: 0x0094F326 File Offset: 0x0094D526
		// (set) Token: 0x06020CC4 RID: 134340 RVA: 0x0094F336 File Offset: 0x0094D536
		public unsafe bool IsForceUpdateSourceAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsForceUpdateSourceAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MultiStateNPC_C.__PropertyOffset_IsForceUpdateSourceAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020CC5 RID: 134341 RVA: 0x0094F348 File Offset: 0x0094D548
		[SkipLocalsInit]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_MultiStateNPC_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x06020CC6 RID: 134342 RVA: 0x0094F397 File Offset: 0x0094D597
		[SkipLocalsInit]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x06020CC7 RID: 134343 RVA: 0x0094F3AB File Offset: 0x0094D5AB
		[SkipLocalsInit]
		public virtual void 更新角色状态()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色状态_NativeFunctionPtr, null);
		}

		// Token: 0x06020CC8 RID: 134344 RVA: 0x0094F3BF File Offset: 0x0094D5BF
		[SkipLocalsInit]
		public virtual void 更新眨眼()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新眨眼_NativeFunctionPtr, null);
		}

		// Token: 0x06020CC9 RID: 134345 RVA: 0x0094F3D4 File Offset: 0x0094D5D4
		[SkipLocalsInit]
		public unsafe virtual void HasInputRotate(ref bool Output_Get)
		{
			ABP_MultiStateNPC_C.__HasInputRotate_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__HasInputRotate_FunctionParams[(UIntPtr)91] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__HasInputRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Output_Get = Output_Get;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr);
			Output_Get = ptr->Output_Get;
		}

		// Token: 0x06020CCA RID: 134346 RVA: 0x0094F424 File Offset: 0x0094D624
		[SkipLocalsInit]
		public unsafe virtual void 是否AI驱动(ref bool Result)
		{
			ABP_MultiStateNPC_C.__是否AI驱动_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__是否AI驱动_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__是否AI驱动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06020CCB RID: 134347 RVA: 0x0094F473 File Offset: 0x0094D673
		[SkipLocalsInit]
		public virtual void 更新角色转身()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色转身_NativeFunctionPtr, null);
		}

		// Token: 0x06020CCC RID: 134348 RVA: 0x0094F487 File Offset: 0x0094D687
		[SkipLocalsInit]
		public virtual void 更新角色移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色移动_NativeFunctionPtr, null);
		}

		// Token: 0x06020CCD RID: 134349 RVA: 0x0094F49B File Offset: 0x0094D69B
		[SkipLocalsInit]
		public virtual void 更新角色碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x06020CCE RID: 134350 RVA: 0x0094F4AF File Offset: 0x0094D6AF
		[SkipLocalsInit]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x06020CCF RID: 134351 RVA: 0x0094F4C3 File Offset: 0x0094D6C3
		[SkipLocalsInit]
		public virtual void 更新角色信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__更新角色信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020CD0 RID: 134352 RVA: 0x0094F4D8 File Offset: 0x0094D6D8
		[SkipLocalsInit]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_MultiStateNPC_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020CD1 RID: 134353 RVA: 0x0094F520 File Offset: 0x0094D720
		[SkipLocalsInit]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020CD2 RID: 134354 RVA: 0x0094F568 File Offset: 0x0094D768
		[SkipLocalsInit]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_MultiStateNPC_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020CD3 RID: 134355 RVA: 0x0094F5B0 File Offset: 0x0094D7B0
		[SkipLocalsInit]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_MultiStateNPC_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020CD4 RID: 134356 RVA: 0x0094F5F6 File Offset: 0x0094D7F6
		[SkipLocalsInit]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x06020CD5 RID: 134357 RVA: 0x0094F60A File Offset: 0x0094D80A
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020CD6 RID: 134358 RVA: 0x0094F61E File Offset: 0x0094D81E
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MultiStateNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020CD7 RID: 134359 RVA: 0x0094F634 File Offset: 0x0094D834
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020CD8 RID: 134360 RVA: 0x0094F67C File Offset: 0x0094D87C
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MultiStateNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020CD9 RID: 134361 RVA: 0x0094F6C2 File Offset: 0x0094D8C2
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MultiStateNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020CDA RID: 134362 RVA: 0x0094F6D6 File Offset: 0x0094D8D6
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MultiStateNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020CDB RID: 134363 RVA: 0x0094F6EA File Offset: 0x0094D8EA
		protected ABP_MultiStateNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BBC RID: 72636
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_MultiStateNPC.ABP_MultiStateNPC_C";

		// Token: 0x04011BBD RID: 72637
		private static IntPtr _ClassPtr;

		// Token: 0x04011BBE RID: 72638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BBF RID: 72639
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011BC0 RID: 72640
		internal static int __PropertyOffset_移动输入向量;

		// Token: 0x04011BC1 RID: 72641
		internal static int __PropertyOffset_速度;

		// Token: 0x04011BC2 RID: 72642
		internal static int __PropertyOffset_是否有移动输入;

		// Token: 0x04011BC3 RID: 72643
		internal static int __PropertyOffset_ifPlayIdleAction;

		// Token: 0x04011BC4 RID: 72644
		internal static int __PropertyOffset_IdleMontageArray;

		// Token: 0x04011BC5 RID: 72645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04011BC6 RID: 72646
		internal static int __PropertyOffset_角色Mesh;

		// Token: 0x04011BC7 RID: 72647
		internal static int __PropertyOffset_是否原地转身;

		// Token: 0x04011BC8 RID: 72648
		internal static int __PropertyOffset_旋转角度差值;

		// Token: 0x04011BC9 RID: 72649
		internal static int __PropertyOffset_上一次旋转角度;

		// Token: 0x04011BCA RID: 72650
		internal static int __PropertyOffset_SightDirect;

		// Token: 0x04011BCB RID: 72651
		internal static int __PropertyOffset_IsBeingImpacted;

		// Token: 0x04011BCC RID: 72652
		internal static int __PropertyOffset_IsBeingAttacked;

		// Token: 0x04011BCD RID: 72653
		internal static int __PropertyOffset_SightLockMode;

		// Token: 0x04011BCE RID: 72654
		internal static int __PropertyOffset_走跑混合;

		// Token: 0x04011BCF RID: 72655
		internal static int __PropertyOffset_IsTurnLeft;

		// Token: 0x04011BD0 RID: 72656
		internal static int __PropertyOffset_角色旋转;

		// Token: 0x04011BD1 RID: 72657
		internal static int __PropertyOffset_NpcEntityId;

		// Token: 0x04011BD2 RID: 72658
		internal static int __PropertyOffset_CollisionStrength;

		// Token: 0x04011BD3 RID: 72659
		internal static int __PropertyOffset_CollisionDirection;

		// Token: 0x04011BD4 RID: 72660
		internal static int __PropertyOffset_RandomEpresionEndTime;

		// Token: 0x04011BD5 RID: 72661
		internal static int __PropertyOffset_眨眼动画时长;

		// Token: 0x04011BD6 RID: 72662
		internal static int __PropertyOffset_此轮眨眼动画总时长;

		// Token: 0x04011BD7 RID: 72663
		internal static int __PropertyOffset_ExpresionAlpha;

		// Token: 0x04011BD8 RID: 72664
		internal static int __PropertyOffset_眨眼中;

		// Token: 0x04011BD9 RID: 72665
		internal static int __PropertyOffset_Cache原地转身;

		// Token: 0x04011BDA RID: 72666
		internal static int __PropertyOffset_口型曲线;

		// Token: 0x04011BDB RID: 72667
		[Nullable(2)]
		private TArray<FName> _口型曲线;

		// Token: 0x04011BDC RID: 72668
		internal static int __PropertyOffset_当前状态;

		// Token: 0x04011BDD RID: 72669
		internal static int __PropertyOffset_是否无过渡切换状态;

		// Token: 0x04011BDE RID: 72670
		internal static int __PropertyOffset_状态_地区运动模式;

		// Token: 0x04011BDF RID: 72671
		internal static int __PropertyOffset_状态_地区运动模式_临时;

		// Token: 0x04011BE0 RID: 72672
		internal static int __PropertyOffset_Ts逻辑变量集;

		// Token: 0x04011BE1 RID: 72673
		internal static int __PropertyOffset_IsEnableTurnMove;

		// Token: 0x04011BE2 RID: 72674
		internal static int __PropertyOffset_TurnYawRate;

		// Token: 0x04011BE3 RID: 72675
		internal static int __PropertyOffset_IsForceUpdateSourceAnimation;

		// Token: 0x04011BE4 RID: 72676
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04011BE5 RID: 72677
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x04011BE6 RID: 72678
		private static IntPtr __更新角色状态_NativeFunctionPtr;

		// Token: 0x04011BE7 RID: 72679
		private static IntPtr __更新眨眼_NativeFunctionPtr;

		// Token: 0x04011BE8 RID: 72680
		private static IntPtr __HasInputRotate_NativeFunctionPtr;

		// Token: 0x04011BE9 RID: 72681
		private static IntPtr __是否AI驱动_NativeFunctionPtr;

		// Token: 0x04011BEA RID: 72682
		private static IntPtr __更新角色转身_NativeFunctionPtr;

		// Token: 0x04011BEB RID: 72683
		private static IntPtr __更新角色移动_NativeFunctionPtr;

		// Token: 0x04011BEC RID: 72684
		private static IntPtr __更新角色碰撞_NativeFunctionPtr;

		// Token: 0x04011BED RID: 72685
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04011BEE RID: 72686
		private static IntPtr __更新角色信息_NativeFunctionPtr;

		// Token: 0x04011BEF RID: 72687
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04011BF0 RID: 72688
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04011BF1 RID: 72689
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04011BF2 RID: 72690
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04011BF3 RID: 72691
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04011BF4 RID: 72692
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04011BF5 RID: 72693
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011BF6 RID: 72694
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x02008FBA RID: 36794
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x0402CD61 RID: 183649
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FBB RID: 36795
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 76)]
		protected ref struct __HasInputRotate_FunctionParams
		{
			// Token: 0x0402CD62 RID: 183650
			[FieldOffset(0)]
			public bool Output_Get;
		}

		// Token: 0x02008FBC RID: 36796
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __是否AI驱动_FunctionParams
		{
			// Token: 0x0402CD63 RID: 183651
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008FBD RID: 36797
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x0402CD64 RID: 183652
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FBE RID: 36798
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x0402CD65 RID: 183653
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x02008FBF RID: 36799
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x0402CD66 RID: 183654
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FC0 RID: 36800
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x0402CD67 RID: 183655
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FC1 RID: 36801
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD68 RID: 183656
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
