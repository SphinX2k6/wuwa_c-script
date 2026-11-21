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
	// Token: 0x02003299 RID: 12953
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_BaseRole.ABP_BaseRole_C")]
	[UnrealStructLayout(191232, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 191232)]
	public class ABP_BaseRole_C : UKuroAnimInstanceRole, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020802 RID: 133122 RVA: 0x00948255 File Offset: 0x00946455
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_BaseRole.ABP_BaseRole_C");
			}
			return ABP_BaseRole_C._ClassPtr;
		}

		// Token: 0x06020803 RID: 133123 RVA: 0x0094827C File Offset: 0x0094647C
		public ABP_BaseRole_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020804 RID: 133124 RVA: 0x009482A4 File Offset: 0x009464A4
		[NullableContext(1)]
		public ABP_BaseRole_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x06020805 RID: 133125 RVA: 0x009482D7 File Offset: 0x009464D7
		// (set) Token: 0x06020806 RID: 133126 RVA: 0x009482EB File Offset: 0x009464EB
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x06020807 RID: 133127 RVA: 0x00948300 File Offset: 0x00946500
		// (set) Token: 0x06020808 RID: 133128 RVA: 0x00948310 File Offset: 0x00946510
		public unsafe float 跳跃速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_跳跃速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_跳跃速度) = value;
			}
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x06020809 RID: 133129 RVA: 0x00948321 File Offset: 0x00946521
		// (set) Token: 0x0602080A RID: 133130 RVA: 0x00948335 File Offset: 0x00946535
		public unsafe FVector 整体偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_整体偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_整体偏移) = value;
			}
		}

		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x0602080B RID: 133131 RVA: 0x0094834A File Offset: 0x0094654A
		// (set) Token: 0x0602080C RID: 133132 RVA: 0x0094835E File Offset: 0x0094655E
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_C.__PropertyOffset_角色Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_C.__PropertyOffset_角色Mesh, value);
			}
		}

		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x0602080D RID: 133133 RVA: 0x00948373 File Offset: 0x00946573
		// (set) Token: 0x0602080E RID: 133134 RVA: 0x00948387 File Offset: 0x00946587
		public unsafe FVector 整体偏移_实际使用_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_整体偏移_实际使用_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_整体偏移_实际使用_) = value;
			}
		}

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x0602080F RID: 133135 RVA: 0x0094839C File Offset: 0x0094659C
		// (set) Token: 0x06020810 RID: 133136 RVA: 0x009483AC File Offset: 0x009465AC
		public unsafe bool 是否眩晕
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_是否眩晕) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_是否眩晕) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x06020811 RID: 133137 RVA: 0x009483BD File Offset: 0x009465BD
		// (set) Token: 0x06020812 RID: 133138 RVA: 0x009483CD File Offset: 0x009465CD
		public unsafe bool 是否壁上跳跃
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_是否壁上跳跃) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_是否壁上跳跃) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x06020813 RID: 133139 RVA: 0x009483E0 File Offset: 0x009465E0
		// (set) Token: 0x06020814 RID: 133140 RVA: 0x00948419 File Offset: 0x00946619
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
					result = (this._左脚探测结果 = new FHitResult(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_左脚探测结果, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_左脚探测结果, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x06020815 RID: 133141 RVA: 0x0094843C File Offset: 0x0094663C
		// (set) Token: 0x06020816 RID: 133142 RVA: 0x00948475 File Offset: 0x00946675
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
					result = (this._右脚探测结果 = new FHitResult(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_右脚探测结果, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_右脚探测结果, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x06020817 RID: 133143 RVA: 0x00948496 File Offset: 0x00946696
		// (set) Token: 0x06020818 RID: 133144 RVA: 0x009484A6 File Offset: 0x009466A6
		public unsafe bool 是否右手进入攀爬
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_是否右手进入攀爬) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_是否右手进入攀爬) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x06020819 RID: 133145 RVA: 0x009484B7 File Offset: 0x009466B7
		// (set) Token: 0x0602081A RID: 133146 RVA: 0x009484C7 File Offset: 0x009466C7
		public unsafe bool FASLE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_FASLE) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_FASLE) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x0602081B RID: 133147 RVA: 0x009484D8 File Offset: 0x009466D8
		// (set) Token: 0x0602081C RID: 133148 RVA: 0x009484E8 File Offset: 0x009466E8
		public unsafe float 钩索启动角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_钩索启动角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_钩索启动角度) = value;
			}
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x0602081D RID: 133149 RVA: 0x009484F9 File Offset: 0x009466F9
		// (set) Token: 0x0602081E RID: 133150 RVA: 0x00948509 File Offset: 0x00946709
		public unsafe byte 反斜登顶退出
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_反斜登顶退出);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_反斜登顶退出) = value;
			}
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x0602081F RID: 133151 RVA: 0x0094851A File Offset: 0x0094671A
		// (set) Token: 0x06020820 RID: 133152 RVA: 0x0094852A File Offset: 0x0094672A
		public unsafe float 巨物拉取角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_巨物拉取角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_巨物拉取角度) = value;
			}
		}

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x06020821 RID: 133153 RVA: 0x0094853B File Offset: 0x0094673B
		// (set) Token: 0x06020822 RID: 133154 RVA: 0x0094854B File Offset: 0x0094674B
		public unsafe float 跳跃速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_跳跃速率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_跳跃速率) = value;
			}
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x06020823 RID: 133155 RVA: 0x0094855C File Offset: 0x0094675C
		// (set) Token: 0x06020824 RID: 133156 RVA: 0x0094856C File Offset: 0x0094676C
		public unsafe bool EnableSwitchPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_EnableSwitchPose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_EnableSwitchPose) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x06020825 RID: 133157 RVA: 0x0094857D File Offset: 0x0094677D
		// (set) Token: 0x06020826 RID: 133158 RVA: 0x0094858D File Offset: 0x0094678D
		public unsafe float SwitchPoseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SwitchPoseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SwitchPoseTime) = value;
			}
		}

		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x06020827 RID: 133159 RVA: 0x0094859E File Offset: 0x0094679E
		// (set) Token: 0x06020828 RID: 133160 RVA: 0x009485AE File Offset: 0x009467AE
		public unsafe bool 状态_牵手_牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_牵手_牵手中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_牵手_牵手中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x06020829 RID: 133161 RVA: 0x009485BF File Offset: 0x009467BF
		// (set) Token: 0x0602082A RID: 133162 RVA: 0x009485CF File Offset: 0x009467CF
		public unsafe bool 状态_牵手_被牵手中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_牵手_被牵手中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_牵手_被牵手中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x0602082B RID: 133163 RVA: 0x009485E0 File Offset: 0x009467E0
		// (set) Token: 0x0602082C RID: 133164 RVA: 0x009485F0 File Offset: 0x009467F0
		public unsafe bool 状态_牵手_范围内
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_牵手_范围内) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_牵手_范围内) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x0602082D RID: 133165 RVA: 0x00948601 File Offset: 0x00946801
		// (set) Token: 0x0602082E RID: 133166 RVA: 0x00948611 File Offset: 0x00946811
		public unsafe bool IsInPlotBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_IsInPlotBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_IsInPlotBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F7B RID: 16251
		// (get) Token: 0x0602082F RID: 133167 RVA: 0x00948622 File Offset: 0x00946822
		// (set) Token: 0x06020830 RID: 133168 RVA: 0x00948632 File Offset: 0x00946832
		public unsafe bool 状态_基础移动替换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_基础移动替换) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_基础移动替换) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x06020831 RID: 133169 RVA: 0x00948643 File Offset: 0x00946843
		// (set) Token: 0x06020832 RID: 133170 RVA: 0x00948653 File Offset: 0x00946853
		public unsafe bool 状态_样条跑墙
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_样条跑墙) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_样条跑墙) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x06020833 RID: 133171 RVA: 0x00948664 File Offset: 0x00946864
		// (set) Token: 0x06020834 RID: 133172 RVA: 0x00948674 File Offset: 0x00946874
		public unsafe bool 状态_上坡动画替换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_上坡动画替换) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_上坡动画替换) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x06020835 RID: 133173 RVA: 0x00948685 File Offset: 0x00946885
		// (set) Token: 0x06020836 RID: 133174 RVA: 0x00948695 File Offset: 0x00946895
		public unsafe bool 状态_强制更新源姿势
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_强制更新源姿势) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_强制更新源姿势) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x06020837 RID: 133175 RVA: 0x009486A6 File Offset: 0x009468A6
		// (set) Token: 0x06020838 RID: 133176 RVA: 0x009486B6 File Offset: 0x009468B6
		public unsafe bool 状态_强制关闭IK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_强制关闭IK) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_强制关闭IK) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x06020839 RID: 133177 RVA: 0x009486C7 File Offset: 0x009468C7
		// (set) Token: 0x0602083A RID: 133178 RVA: 0x009486D7 File Offset: 0x009468D7
		public unsafe float SightLockYawMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockYawMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockYawMin) = value;
			}
		}

		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x0602083B RID: 133179 RVA: 0x009486E8 File Offset: 0x009468E8
		// (set) Token: 0x0602083C RID: 133180 RVA: 0x009486F8 File Offset: 0x009468F8
		public unsafe float SightLockYawMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockYawMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockYawMax) = value;
			}
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x0602083D RID: 133181 RVA: 0x00948709 File Offset: 0x00946909
		// (set) Token: 0x0602083E RID: 133182 RVA: 0x00948719 File Offset: 0x00946919
		public unsafe float SightLockPitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockPitchMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockPitchMin) = value;
			}
		}

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x0602083F RID: 133183 RVA: 0x0094872A File Offset: 0x0094692A
		// (set) Token: 0x06020840 RID: 133184 RVA: 0x0094873A File Offset: 0x0094693A
		public unsafe float SightLockPitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockPitchMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockPitchMax) = value;
			}
		}

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x06020841 RID: 133185 RVA: 0x0094874B File Offset: 0x0094694B
		// (set) Token: 0x06020842 RID: 133186 RVA: 0x0094875B File Offset: 0x0094695B
		public unsafe float SightLockAssitLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockAssitLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightLockAssitLimit) = value;
			}
		}

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x06020843 RID: 133187 RVA: 0x0094876C File Offset: 0x0094696C
		// (set) Token: 0x06020844 RID: 133188 RVA: 0x0094877C File Offset: 0x0094697C
		public unsafe bool 状态_关闭FB受击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_关闭FB受击) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_状态_关闭FB受击) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x06020845 RID: 133189 RVA: 0x0094878D File Offset: 0x0094698D
		// (set) Token: 0x06020846 RID: 133190 RVA: 0x0094879D File Offset: 0x0094699D
		public unsafe float 普通运动转基础移动BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_普通运动转基础移动BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_普通运动转基础移动BlendTime) = value;
			}
		}

		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x06020847 RID: 133191 RVA: 0x009487AE File Offset: 0x009469AE
		// (set) Token: 0x06020848 RID: 133192 RVA: 0x009487BE File Offset: 0x009469BE
		public unsafe float 基础移动转普通运动BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_基础移动转普通运动BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_基础移动转普通运动BlendTime) = value;
			}
		}

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x06020849 RID: 133193 RVA: 0x009487CF File Offset: 0x009469CF
		// (set) Token: 0x0602084A RID: 133194 RVA: 0x009487E3 File Offset: 0x009469E3
		public unsafe FVector SightDirectInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightDirectInSightBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_SightDirectInSightBone) = value;
			}
		}

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x0602084B RID: 133195 RVA: 0x009487F8 File Offset: 0x009469F8
		// (set) Token: 0x0602084C RID: 133196 RVA: 0x0094880C File Offset: 0x00946A0C
		public unsafe FVector UpAxisInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_UpAxisInSightBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_UpAxisInSightBone) = value;
			}
		}

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x0602084D RID: 133197 RVA: 0x00948821 File Offset: 0x00946A21
		// (set) Token: 0x0602084E RID: 133198 RVA: 0x00948831 File Offset: 0x00946A31
		public unsafe float 起步转走混合时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_起步转走混合时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_C.__PropertyOffset_起步转走混合时间) = value;
			}
		}

		// Token: 0x0602084F RID: 133199 RVA: 0x00948844 File Offset: 0x00946A44
		[SkipLocalsInit]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_BaseRole_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x06020850 RID: 133200 RVA: 0x00948893 File Offset: 0x00946A93
		[SkipLocalsInit]
		public virtual void 更新载具信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__更新载具信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020851 RID: 133201 RVA: 0x009488A7 File Offset: 0x00946AA7
		[SkipLocalsInit]
		public virtual void 风筝移动更新()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__风筝移动更新_NativeFunctionPtr, null);
		}

		// Token: 0x06020852 RID: 133202 RVA: 0x009488BB File Offset: 0x00946ABB
		[SkipLocalsInit]
		public virtual void 移动平台和上坡IK削弱()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__移动平台和上坡IK削弱_NativeFunctionPtr, null);
		}

		// Token: 0x06020853 RID: 133203 RVA: 0x009488CF File Offset: 0x00946ACF
		[SkipLocalsInit]
		public virtual void 落地速度切割初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__落地速度切割初始化_NativeFunctionPtr, null);
		}

		// Token: 0x06020854 RID: 133204 RVA: 0x009488E4 File Offset: 0x00946AE4
		[SkipLocalsInit]
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

		// Token: 0x06020855 RID: 133205 RVA: 0x00948952 File Offset: 0x00946B52
		[SkipLocalsInit]
		public virtual void XA状态更新()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__XA状态更新_NativeFunctionPtr, null);
		}

		// Token: 0x06020856 RID: 133206 RVA: 0x00948968 File Offset: 0x00946B68
		[SkipLocalsInit]
		public unsafe virtual void 设置跳跃速率(float 新速率)
		{
			ABP_BaseRole_C.__设置跳跃速率_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__设置跳跃速率_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__设置跳跃速率_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__设置跳跃速率_NativeFunctionPtr, (void*)ptr, 1);
			ptr->新速率 = 新速率;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__设置跳跃速率_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020857 RID: 133207 RVA: 0x009489AE File Offset: 0x00946BAE
		[SkipLocalsInit]
		public virtual void 冰冻结束事件()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__冰冻结束事件_NativeFunctionPtr, null);
		}

		// Token: 0x06020858 RID: 133208 RVA: 0x009489C4 File Offset: 0x00946BC4
		[SkipLocalsInit]
		public unsafe virtual void 计算跳跃混合(float 速度, ref float 混合)
		{
			ABP_BaseRole_C.__计算跳跃混合_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__计算跳跃混合_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRole_C.__计算跳跃混合_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__计算跳跃混合_NativeFunctionPtr, (void*)ptr, 1);
			ptr->速度 = 速度;
			ptr->混合 = 混合;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__计算跳跃混合_NativeFunctionPtr, (void*)ptr);
			混合 = ptr->混合;
		}

		// Token: 0x06020859 RID: 133209 RVA: 0x00948A1A File Offset: 0x00946C1A
		[SkipLocalsInit]
		public virtual void CleanAnimVariable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__CleanAnimVariable_NativeFunctionPtr, null);
		}

		// Token: 0x0602085A RID: 133210 RVA: 0x00948A30 File Offset: 0x00946C30
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0602085B RID: 133211 RVA: 0x00948AB8 File Offset: 0x00946CB8
		[SkipLocalsInit]
		public virtual void 更新上传()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__更新上传_NativeFunctionPtr, null);
		}

		// Token: 0x0602085C RID: 133212 RVA: 0x00948ACC File Offset: 0x00946CCC
		[SkipLocalsInit]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602085D RID: 133213 RVA: 0x00948AE0 File Offset: 0x00946CE0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 替换角色时同步动作数据(ABP_BaseRole_C 切出角色AnimIns)
		{
			ABP_BaseRole_C.__替换角色时同步动作数据_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__替换角色时同步动作数据_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_BaseRole_C.__替换角色时同步动作数据_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__替换角色时同步动作数据_NativeFunctionPtr, (void*)ptr, 1);
			ptr->切出角色AnimIns = ((切出角色AnimIns != null) ? 切出角色AnimIns.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__替换角色时同步动作数据_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602085E RID: 133214 RVA: 0x00948B38 File Offset: 0x00946D38
		[SkipLocalsInit]
		public unsafe virtual void 设置头部转向状态(SightLockMode SightMode)
		{
			ABP_BaseRole_C.__设置头部转向状态_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__设置头部转向状态_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_BaseRole_C.__设置头部转向状态_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SightMode = SightMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__设置头部转向状态_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602085F RID: 133215 RVA: 0x00948B80 File Offset: 0x00946D80
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020860 RID: 133216 RVA: 0x00948BC8 File Offset: 0x00946DC8
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020861 RID: 133217 RVA: 0x00948C0E File Offset: 0x00946E0E
		[SkipLocalsInit]
		public virtual void TestFk()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__TestFk_NativeFunctionPtr, null);
		}

		// Token: 0x06020862 RID: 133218 RVA: 0x00948C24 File Offset: 0x00946E24
		[SkipLocalsInit]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_BaseRole_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020863 RID: 133219 RVA: 0x00948C6A File Offset: 0x00946E6A
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020864 RID: 133220 RVA: 0x00948C7E File Offset: 0x00946E7E
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020865 RID: 133221 RVA: 0x00948C92 File Offset: 0x00946E92
		[SkipLocalsInit]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x06020866 RID: 133222 RVA: 0x00948CA6 File Offset: 0x00946EA6
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020867 RID: 133223 RVA: 0x00948CBA File Offset: 0x00946EBA
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020868 RID: 133224 RVA: 0x00948CD0 File Offset: 0x00946ED0
		[SkipLocalsInit]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_BaseRole_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020869 RID: 133225 RVA: 0x00948D18 File Offset: 0x00946F18
		[SkipLocalsInit]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_BaseRole_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602086A RID: 133226 RVA: 0x00948D5E File Offset: 0x00946F5E
		[SkipLocalsInit]
		public virtual void ClearClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__ClearClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602086B RID: 133227 RVA: 0x00948D74 File Offset: 0x00946F74
		[SkipLocalsInit]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_BaseRole_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_BaseRole_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602086C RID: 133228 RVA: 0x00948DBA File Offset: 0x00946FBA
		[SkipLocalsInit]
		public virtual void PlotBlendIn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__PlotBlendIn_NativeFunctionPtr, null);
		}

		// Token: 0x0602086D RID: 133229 RVA: 0x00948DCE File Offset: 0x00946FCE
		[SkipLocalsInit]
		public virtual void NoExpose()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_C.__NoExpose_NativeFunctionPtr, null);
		}

		// Token: 0x0602086E RID: 133230 RVA: 0x00948DE4 File Offset: 0x00946FE4
		[SkipLocalsInit]
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

		// Token: 0x0602086F RID: 133231 RVA: 0x00948E58 File Offset: 0x00947058
		protected ABP_BaseRole_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011901 RID: 71937
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_BaseRole.ABP_BaseRole_C";

		// Token: 0x04011902 RID: 71938
		private static IntPtr _ClassPtr;

		// Token: 0x04011903 RID: 71939
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011904 RID: 71940
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011905 RID: 71941
		internal static int __PropertyOffset_跳跃速度;

		// Token: 0x04011906 RID: 71942
		internal static int __PropertyOffset_整体偏移;

		// Token: 0x04011907 RID: 71943
		internal static int __PropertyOffset_角色Mesh;

		// Token: 0x04011908 RID: 71944
		internal static int __PropertyOffset_整体偏移_实际使用_;

		// Token: 0x04011909 RID: 71945
		internal static int __PropertyOffset_是否眩晕;

		// Token: 0x0401190A RID: 71946
		internal static int __PropertyOffset_是否壁上跳跃;

		// Token: 0x0401190B RID: 71947
		internal static int __PropertyOffset_左脚探测结果;

		// Token: 0x0401190C RID: 71948
		[Nullable(2)]
		private FHitResult _左脚探测结果;

		// Token: 0x0401190D RID: 71949
		internal static int __PropertyOffset_右脚探测结果;

		// Token: 0x0401190E RID: 71950
		[Nullable(2)]
		private FHitResult _右脚探测结果;

		// Token: 0x0401190F RID: 71951
		internal static int __PropertyOffset_是否右手进入攀爬;

		// Token: 0x04011910 RID: 71952
		internal static int __PropertyOffset_FASLE;

		// Token: 0x04011911 RID: 71953
		internal static int __PropertyOffset_钩索启动角度;

		// Token: 0x04011912 RID: 71954
		internal static int __PropertyOffset_反斜登顶退出;

		// Token: 0x04011913 RID: 71955
		internal static int __PropertyOffset_巨物拉取角度;

		// Token: 0x04011914 RID: 71956
		internal static int __PropertyOffset_跳跃速率;

		// Token: 0x04011915 RID: 71957
		internal static int __PropertyOffset_EnableSwitchPose;

		// Token: 0x04011916 RID: 71958
		internal static int __PropertyOffset_SwitchPoseTime;

		// Token: 0x04011917 RID: 71959
		internal static int __PropertyOffset_状态_牵手_牵手中;

		// Token: 0x04011918 RID: 71960
		internal static int __PropertyOffset_状态_牵手_被牵手中;

		// Token: 0x04011919 RID: 71961
		internal static int __PropertyOffset_状态_牵手_范围内;

		// Token: 0x0401191A RID: 71962
		internal static int __PropertyOffset_IsInPlotBlend;

		// Token: 0x0401191B RID: 71963
		internal static int __PropertyOffset_状态_基础移动替换;

		// Token: 0x0401191C RID: 71964
		internal static int __PropertyOffset_状态_样条跑墙;

		// Token: 0x0401191D RID: 71965
		internal static int __PropertyOffset_状态_上坡动画替换;

		// Token: 0x0401191E RID: 71966
		internal static int __PropertyOffset_状态_强制更新源姿势;

		// Token: 0x0401191F RID: 71967
		internal static int __PropertyOffset_状态_强制关闭IK;

		// Token: 0x04011920 RID: 71968
		internal static int __PropertyOffset_SightLockYawMin;

		// Token: 0x04011921 RID: 71969
		internal static int __PropertyOffset_SightLockYawMax;

		// Token: 0x04011922 RID: 71970
		internal static int __PropertyOffset_SightLockPitchMin;

		// Token: 0x04011923 RID: 71971
		internal static int __PropertyOffset_SightLockPitchMax;

		// Token: 0x04011924 RID: 71972
		internal static int __PropertyOffset_SightLockAssitLimit;

		// Token: 0x04011925 RID: 71973
		internal static int __PropertyOffset_状态_关闭FB受击;

		// Token: 0x04011926 RID: 71974
		internal static int __PropertyOffset_普通运动转基础移动BlendTime;

		// Token: 0x04011927 RID: 71975
		internal static int __PropertyOffset_基础移动转普通运动BlendTime;

		// Token: 0x04011928 RID: 71976
		internal static int __PropertyOffset_SightDirectInSightBone;

		// Token: 0x04011929 RID: 71977
		internal static int __PropertyOffset_UpAxisInSightBone;

		// Token: 0x0401192A RID: 71978
		internal static int __PropertyOffset_起步转走混合时间;

		// Token: 0x0401192B RID: 71979
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x0401192C RID: 71980
		private static IntPtr __更新载具信息_NativeFunctionPtr;

		// Token: 0x0401192D RID: 71981
		private static IntPtr __风筝移动更新_NativeFunctionPtr;

		// Token: 0x0401192E RID: 71982
		private static IntPtr __移动平台和上坡IK削弱_NativeFunctionPtr;

		// Token: 0x0401192F RID: 71983
		private static IntPtr __落地速度切割初始化_NativeFunctionPtr;

		// Token: 0x04011930 RID: 71984
		private static IntPtr __VelocityBlendLerp_NativeFunctionPtr;

		// Token: 0x04011931 RID: 71985
		private static IntPtr __XA状态更新_NativeFunctionPtr;

		// Token: 0x04011932 RID: 71986
		private static IntPtr __设置跳跃速率_NativeFunctionPtr;

		// Token: 0x04011933 RID: 71987
		private static IntPtr __冰冻结束事件_NativeFunctionPtr;

		// Token: 0x04011934 RID: 71988
		private static IntPtr __计算跳跃混合_NativeFunctionPtr;

		// Token: 0x04011935 RID: 71989
		private static IntPtr __CleanAnimVariable_NativeFunctionPtr;

		// Token: 0x04011936 RID: 71990
		private static IntPtr __True布尔序列输出_NativeFunctionPtr;

		// Token: 0x04011937 RID: 71991
		private static IntPtr __更新上传_NativeFunctionPtr;

		// Token: 0x04011938 RID: 71992
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x04011939 RID: 71993
		private static IntPtr __替换角色时同步动作数据_NativeFunctionPtr;

		// Token: 0x0401193A RID: 71994
		private static IntPtr __设置头部转向状态_NativeFunctionPtr;

		// Token: 0x0401193B RID: 71995
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0401193C RID: 71996
		private static IntPtr __TestFk_NativeFunctionPtr;

		// Token: 0x0401193D RID: 71997
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x0401193E RID: 71998
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0401193F RID: 71999
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04011940 RID: 72000
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x04011941 RID: 72001
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04011942 RID: 72002
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04011943 RID: 72003
		private static IntPtr __ClearClimbDash_NativeFunctionPtr;

		// Token: 0x04011944 RID: 72004
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04011945 RID: 72005
		private static IntPtr __PlotBlendIn_NativeFunctionPtr;

		// Token: 0x04011946 RID: 72006
		private static IntPtr __NoExpose_NativeFunctionPtr;

		// Token: 0x04011947 RID: 72007
		private static IntPtr __SetSightLockConfig_NativeFunctionPtr;

		// Token: 0x02008F7B RID: 36731
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x0402CD08 RID: 183560
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008F7C RID: 36732
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 84)]
		protected ref struct __VelocityBlendLerp_FunctionParams
		{
			// Token: 0x0402CD09 RID: 183561
			[FieldOffset(0)]
			public FVeloctiyBlend From;

			// Token: 0x0402CD0A RID: 183562
			[FieldOffset(16)]
			public FVeloctiyBlend To;

			// Token: 0x0402CD0B RID: 183563
			[FieldOffset(32)]
			public float Alpha;

			// Token: 0x0402CD0C RID: 183564
			[FieldOffset(36)]
			public FVeloctiyBlend Out;
		}

		// Token: 0x02008F7D RID: 36733
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __设置跳跃速率_FunctionParams
		{
			// Token: 0x0402CD0D RID: 183565
			[FieldOffset(0)]
			public float 新速率;
		}

		// Token: 0x02008F7E RID: 36734
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __计算跳跃混合_FunctionParams
		{
			// Token: 0x0402CD0E RID: 183566
			[FieldOffset(0)]
			public float 速度;

			// Token: 0x0402CD0F RID: 183567
			[FieldOffset(4)]
			public float 混合;
		}

		// Token: 0x02008F7F RID: 36735
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __True布尔序列输出_FunctionParams
		{
			// Token: 0x0402CD10 RID: 183568
			[FieldOffset(0)]
			public byte ValArrt_Bool;

			// Token: 0x0402CD11 RID: 183569
			[FieldOffset(16)]
			public int Out;
		}

		// Token: 0x02008F80 RID: 36736
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __替换角色时同步动作数据_FunctionParams
		{
			// Token: 0x0402CD12 RID: 183570
			[FieldOffset(0)]
			public IntPtr 切出角色AnimIns;
		}

		// Token: 0x02008F81 RID: 36737
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __设置头部转向状态_FunctionParams
		{
			// Token: 0x0402CD13 RID: 183571
			[FieldOffset(0)]
			public SightLockMode SightMode;
		}

		// Token: 0x02008F82 RID: 36738
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD14 RID: 183572
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x02008F83 RID: 36739
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x0402CD15 RID: 183573
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008F84 RID: 36740
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x0402CD16 RID: 183574
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008F85 RID: 36741
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x0402CD17 RID: 183575
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008F86 RID: 36742
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x0402CD18 RID: 183576
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x02008F87 RID: 36743
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __SetSightLockConfig_FunctionParams
		{
			// Token: 0x0402CD19 RID: 183577
			[FieldOffset(0)]
			public float YawMin;

			// Token: 0x0402CD1A RID: 183578
			[FieldOffset(4)]
			public float YawMax;

			// Token: 0x0402CD1B RID: 183579
			[FieldOffset(8)]
			public float PitchMin;

			// Token: 0x0402CD1C RID: 183580
			[FieldOffset(12)]
			public float PitchMax;

			// Token: 0x0402CD1D RID: 183581
			[FieldOffset(16)]
			public float AssitLimit;

			// Token: 0x0402CD1E RID: 183582
			[FieldOffset(20)]
			public FVector SightDirectInSightBone;

			// Token: 0x0402CD1F RID: 183583
			[FieldOffset(32)]
			public FVector UpAxisInSightBone;
		}
	}
}
