using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal
{
	// Token: 0x020041A4 RID: 16804
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/ABP_BaseRunAnimal.ABP_BaseRunAnimal_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_BaseRunAnimal_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_AnimalEcological_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602BB8B RID: 179083 RVA: 0x00A0889B File Offset: 0x00A06A9B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRunAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/ABP_BaseRunAnimal.ABP_BaseRunAnimal_C");
			}
			return ABP_BaseRunAnimal_C._ClassPtr;
		}

		// Token: 0x0602BB8C RID: 179084 RVA: 0x00A088C0 File Offset: 0x00A06AC0
		public ABP_BaseRunAnimal_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRunAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BB8D RID: 179085 RVA: 0x00A088E8 File Offset: 0x00A06AE8
		[NullableContext(1)]
		public ABP_BaseRunAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRunAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CAD RID: 27821
		// (get) Token: 0x0602BB8E RID: 179086 RVA: 0x00A0891C File Offset: 0x00A06B1C
		// (set) Token: 0x0602BB8F RID: 179087 RVA: 0x00A08955 File Offset: 0x00A06B55
		[Nullable(1)]
		public TArray<UAnimSequence> 待机表演配置
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimSequence> result;
				if ((result = this._待机表演配置) == null)
				{
					result = (this._待机表演配置 = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_140, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.待机表演配置.CopyAssign(value);
			}
		}

		// Token: 0x17006CAE RID: 27822
		// (get) Token: 0x0602BB90 RID: 179088 RVA: 0x00A08963 File Offset: 0x00A06B63
		// (set) Token: 0x0602BB91 RID: 179089 RVA: 0x00A08977 File Offset: 0x00A06B77
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_141);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_141, value);
			}
		}

		// Token: 0x17006CAF RID: 27823
		// (get) Token: 0x0602BB92 RID: 179090 RVA: 0x00A0898C File Offset: 0x00A06B8C
		// (set) Token: 0x0602BB93 RID: 179091 RVA: 0x00A089A0 File Offset: 0x00A06BA0
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色网格体
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_142);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_142, value);
			}
		}

		// Token: 0x17006CB0 RID: 27824
		// (get) Token: 0x0602BB94 RID: 179092 RVA: 0x00A089B5 File Offset: 0x00A06BB5
		// (set) Token: 0x0602BB95 RID: 179093 RVA: 0x00A089C9 File Offset: 0x00A06BC9
		public unsafe TEnumAsByte<EAnimalEcologicalState> 生态表现状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_143);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_143) = value;
			}
		}

		// Token: 0x17006CB1 RID: 27825
		// (get) Token: 0x0602BB96 RID: 179094 RVA: 0x00A089DE File Offset: 0x00A06BDE
		// (set) Token: 0x0602BB97 RID: 179095 RVA: 0x00A089EE File Offset: 0x00A06BEE
		public unsafe bool 状态机初始化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_144) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_144) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CB2 RID: 27826
		// (get) Token: 0x0602BB98 RID: 179096 RVA: 0x00A089FF File Offset: 0x00A06BFF
		// (set) Token: 0x0602BB99 RID: 179097 RVA: 0x00A08A0F File Offset: 0x00A06C0F
		public unsafe int IdleActionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_145);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_145) = value;
			}
		}

		// Token: 0x17006CB3 RID: 27827
		// (get) Token: 0x0602BB9A RID: 179098 RVA: 0x00A08A20 File Offset: 0x00A06C20
		// (set) Token: 0x0602BB9B RID: 179099 RVA: 0x00A08A34 File Offset: 0x00A06C34
		[Nullable(2)]
		public unsafe UAnimSequence IdleAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_146);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_146, value);
			}
		}

		// Token: 0x17006CB4 RID: 27828
		// (get) Token: 0x0602BB9C RID: 179100 RVA: 0x00A08A4C File Offset: 0x00A06C4C
		// (set) Token: 0x0602BB9D RID: 179101 RVA: 0x00A08A85 File Offset: 0x00A06C85
		[Nullable(1)]
		public TArray<UAnimSequence> 交互表演配置
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimSequence> result;
				if ((result = this._交互表演配置) == null)
				{
					result = (this._交互表演配置 = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_147, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.交互表演配置.CopyAssign(value);
			}
		}

		// Token: 0x17006CB5 RID: 27829
		// (get) Token: 0x0602BB9E RID: 179102 RVA: 0x00A08A93 File Offset: 0x00A06C93
		// (set) Token: 0x0602BB9F RID: 179103 RVA: 0x00A08AA3 File Offset: 0x00A06CA3
		public unsafe int InteractActionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_148);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_148) = value;
			}
		}

		// Token: 0x17006CB6 RID: 27830
		// (get) Token: 0x0602BBA0 RID: 179104 RVA: 0x00A08AB4 File Offset: 0x00A06CB4
		// (set) Token: 0x0602BBA1 RID: 179105 RVA: 0x00A08AC8 File Offset: 0x00A06CC8
		[Nullable(2)]
		public unsafe UAnimSequence InteractAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_149);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_149, value);
			}
		}

		// Token: 0x17006CB7 RID: 27831
		// (get) Token: 0x0602BBA2 RID: 179106 RVA: 0x00A08ADD File Offset: 0x00A06CDD
		// (set) Token: 0x0602BBA3 RID: 179107 RVA: 0x00A08AF1 File Offset: 0x00A06CF1
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_150);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_150) = value;
			}
		}

		// Token: 0x17006CB8 RID: 27832
		// (get) Token: 0x0602BBA4 RID: 179108 RVA: 0x00A08B06 File Offset: 0x00A06D06
		// (set) Token: 0x0602BBA5 RID: 179109 RVA: 0x00A08B16 File Offset: 0x00A06D16
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_151));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_151) = (byte)value;
			}
		}

		// Token: 0x17006CB9 RID: 27833
		// (get) Token: 0x0602BBA6 RID: 179110 RVA: 0x00A08B27 File Offset: 0x00A06D27
		// (set) Token: 0x0602BBA7 RID: 179111 RVA: 0x00A08B37 File Offset: 0x00A06D37
		public unsafe int WalkRunParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_152);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_152) = value;
			}
		}

		// Token: 0x17006CBA RID: 27834
		// (get) Token: 0x0602BBA8 RID: 179112 RVA: 0x00A08B48 File Offset: 0x00A06D48
		// (set) Token: 0x0602BBA9 RID: 179113 RVA: 0x00A08B58 File Offset: 0x00A06D58
		public unsafe float 左右跑参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_153);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_153) = value;
			}
		}

		// Token: 0x17006CBB RID: 27835
		// (get) Token: 0x0602BBAA RID: 179114 RVA: 0x00A08B69 File Offset: 0x00A06D69
		// (set) Token: 0x0602BBAB RID: 179115 RVA: 0x00A08B79 File Offset: 0x00A06D79
		public unsafe bool bHaveInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_154) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_154) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CBC RID: 27836
		// (get) Token: 0x0602BBAC RID: 179116 RVA: 0x00A08B8A File Offset: 0x00A06D8A
		// (set) Token: 0x0602BBAD RID: 179117 RVA: 0x00A08B9A File Offset: 0x00A06D9A
		public unsafe bool bIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_155) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_155) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CBD RID: 27837
		// (get) Token: 0x0602BBAE RID: 179118 RVA: 0x00A08BAB File Offset: 0x00A06DAB
		// (set) Token: 0x0602BBAF RID: 179119 RVA: 0x00A08BBB File Offset: 0x00A06DBB
		public unsafe bool 是否警觉
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_156) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_156) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CBE RID: 27838
		// (get) Token: 0x0602BBB0 RID: 179120 RVA: 0x00A08BCC File Offset: 0x00A06DCC
		// (set) Token: 0x0602BBB1 RID: 179121 RVA: 0x00A08BDC File Offset: 0x00A06DDC
		public unsafe bool 是否起跑转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_157) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_157) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CBF RID: 27839
		// (get) Token: 0x0602BBB2 RID: 179122 RVA: 0x00A08BED File Offset: 0x00A06DED
		// (set) Token: 0x0602BBB3 RID: 179123 RVA: 0x00A08BFD File Offset: 0x00A06DFD
		public unsafe bool 起跑左转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_158) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_158) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CC0 RID: 27840
		// (get) Token: 0x0602BBB4 RID: 179124 RVA: 0x00A08C0E File Offset: 0x00A06E0E
		// (set) Token: 0x0602BBB5 RID: 179125 RVA: 0x00A08C1E File Offset: 0x00A06E1E
		public unsafe bool bInteractAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_159) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_159) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CC1 RID: 27841
		// (get) Token: 0x0602BBB6 RID: 179126 RVA: 0x00A08C2F File Offset: 0x00A06E2F
		// (set) Token: 0x0602BBB7 RID: 179127 RVA: 0x00A08C3F File Offset: 0x00A06E3F
		public unsafe bool 受到攻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_160) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_160) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CC2 RID: 27842
		// (get) Token: 0x0602BBB8 RID: 179128 RVA: 0x00A08C50 File Offset: 0x00A06E50
		// (set) Token: 0x0602BBB9 RID: 179129 RVA: 0x00A08C60 File Offset: 0x00A06E60
		public unsafe bool 起飞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_161) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_161) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CC3 RID: 27843
		// (get) Token: 0x0602BBBA RID: 179130 RVA: 0x00A08C71 File Offset: 0x00A06E71
		// (set) Token: 0x0602BBBB RID: 179131 RVA: 0x00A08C81 File Offset: 0x00A06E81
		public unsafe bool bSitDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_162) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_162) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CC4 RID: 27844
		// (get) Token: 0x0602BBBC RID: 179132 RVA: 0x00A08C94 File Offset: 0x00A06E94
		// (set) Token: 0x0602BBBD RID: 179133 RVA: 0x00A08CCD File Offset: 0x00A06ECD
		[Nullable(1)]
		public TMap<FGameplayTag, UAnimSequence> 其他动作配置
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, UAnimSequence> result;
				if ((result = this._其他动作配置) == null)
				{
					result = (this._其他动作配置 = new TMap<FGameplayTag, UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_163, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.其他动作配置.CopyAssign(value);
			}
		}

		// Token: 0x17006CC5 RID: 27845
		// (get) Token: 0x0602BBBE RID: 179134 RVA: 0x00A08CDB File Offset: 0x00A06EDB
		// (set) Token: 0x0602BBBF RID: 179135 RVA: 0x00A08CEB File Offset: 0x00A06EEB
		public unsafe float ActionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_164);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_164) = value;
			}
		}

		// Token: 0x17006CC6 RID: 27846
		// (get) Token: 0x0602BBC0 RID: 179136 RVA: 0x00A08CFC File Offset: 0x00A06EFC
		// (set) Token: 0x0602BBC1 RID: 179137 RVA: 0x00A08D35 File Offset: 0x00A06F35
		[Nullable(1)]
		public TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> 材质配置
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> result;
				if ((result = this._材质配置) == null)
				{
					result = (this._材质配置 = new TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_165, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.材质配置.CopyAssign(value);
			}
		}

		// Token: 0x17006CC7 RID: 27847
		// (get) Token: 0x0602BBC2 RID: 179138 RVA: 0x00A08D44 File Offset: 0x00A06F44
		// (set) Token: 0x0602BBC3 RID: 179139 RVA: 0x00A08D7D File Offset: 0x00A06F7D
		[Nullable(1)]
		public TMap<FGameplayTag, UAnimMontage> 蒙太奇表演配置
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, UAnimMontage> result;
				if ((result = this._蒙太奇表演配置) == null)
				{
					result = (this._蒙太奇表演配置 = new TMap<FGameplayTag, UAnimMontage>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_166, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.蒙太奇表演配置.CopyAssign(value);
			}
		}

		// Token: 0x17006CC8 RID: 27848
		// (get) Token: 0x0602BBC4 RID: 179140 RVA: 0x00A08D8B File Offset: 0x00A06F8B
		// (set) Token: 0x0602BBC5 RID: 179141 RVA: 0x00A08D9B File Offset: 0x00A06F9B
		public unsafe bool 系统UI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_167) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_167) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CC9 RID: 27849
		// (get) Token: 0x0602BBC6 RID: 179142 RVA: 0x00A08DAC File Offset: 0x00A06FAC
		// (set) Token: 0x0602BBC7 RID: 179143 RVA: 0x00A08DBC File Offset: 0x00A06FBC
		public unsafe bool bGetDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_168) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_168) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602BBC8 RID: 179144 RVA: 0x00A08DD0 File Offset: 0x00A06FD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCurrentActionTime(ref float ActionTime)
		{
			ABP_BaseRunAnimal_C.__GetCurrentActionTime_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__GetCurrentActionTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__GetCurrentActionTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActionTime = ActionTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr);
			ActionTime = ptr->ActionTime;
		}

		// Token: 0x0602BBC9 RID: 179145 RVA: 0x00A08E20 File Offset: 0x00A07020
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 演出层(FPoseLink 状态机输入, ref FPoseLink 演出层)
		{
			ABP_BaseRunAnimal_C.__演出层_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__演出层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__演出层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__演出层_NativeFunctionPtr, (void*)ptr, 1);
			if (状态机输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->状态机输入, 状态机输入.NativePtr, 1, false);
			}
			if (演出层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->演出层, 演出层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__演出层_NativeFunctionPtr, (void*)ptr);
			if (演出层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 演出层.NativePtr, &ptr->演出层, 1, false);
			}
		}

		// Token: 0x0602BBCA RID: 179146 RVA: 0x00A08ECC File Offset: 0x00A070CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 后处理层(FPoseLink 基础输入, ref FPoseLink 后处理层)
		{
			ABP_BaseRunAnimal_C.__后处理层_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__后处理层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__后处理层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__后处理层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础输入, 基础输入.NativePtr, 1, false);
			}
			if (后处理层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->后处理层, 后处理层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__后处理层_NativeFunctionPtr, (void*)ptr);
			if (后处理层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 后处理层.NativePtr, &ptr->后处理层, 1, false);
			}
		}

		// Token: 0x0602BBCB RID: 179147 RVA: 0x00A08F78 File Offset: 0x00A07178
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_BaseRunAnimal_C.__基础层_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BBCC RID: 179148 RVA: 0x00A09000 File Offset: 0x00A07200
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRunAnimal_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BBCD RID: 179149 RVA: 0x00A09087 File Offset: 0x00A07287
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnSystemUIStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnSystemUIStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBCE RID: 179150 RVA: 0x00A0909C File Offset: 0x00A0729C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnFeedStart(FGameplayTag GameplayTag)
		{
			ABP_BaseRunAnimal_C.__OnFeedStart_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__OnFeedStart_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__OnFeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__OnFeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnFeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BBCF RID: 179151 RVA: 0x00A090E2 File Offset: 0x00A072E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新移动信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新移动信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD0 RID: 179152 RVA: 0x00A090F6 File Offset: 0x00A072F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 处理动作优先级()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__处理动作优先级_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD1 RID: 179153 RVA: 0x00A0910A File Offset: 0x00A0730A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnUnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnUnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD2 RID: 179154 RVA: 0x00A0911E File Offset: 0x00A0731E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnTakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD3 RID: 179155 RVA: 0x00A09132 File Offset: 0x00A07332
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnAlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnAlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD4 RID: 179156 RVA: 0x00A09146 File Offset: 0x00A07346
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD5 RID: 179157 RVA: 0x00A0915A File Offset: 0x00A0735A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnInteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD6 RID: 179158 RVA: 0x00A0916E File Offset: 0x00A0736E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新特殊交互表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新特殊交互表演_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD7 RID: 179159 RVA: 0x00A09182 File Offset: 0x00A07382
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新交互表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新交互表演_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD8 RID: 179160 RVA: 0x00A09196 File Offset: 0x00A07396
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnIdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnIdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBD9 RID: 179161 RVA: 0x00A091AA File Offset: 0x00A073AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新待机表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新待机表演_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBDA RID: 179162 RVA: 0x00A091BE File Offset: 0x00A073BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TakeOffEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__TakeOffEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBDB RID: 179163 RVA: 0x00A091D2 File Offset: 0x00A073D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AlertEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__AlertEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBDC RID: 179164 RVA: 0x00A091E6 File Offset: 0x00A073E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UnderAttackEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__UnderAttackEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBDD RID: 179165 RVA: 0x00A091FA File Offset: 0x00A073FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void IdleEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__IdleEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBDE RID: 179166 RVA: 0x00A0920E File Offset: 0x00A0740E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InteractEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__InteractEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBDF RID: 179167 RVA: 0x00A09222 File Offset: 0x00A07422
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NoneStateEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__NoneStateEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBE0 RID: 179168 RVA: 0x00A09236 File Offset: 0x00A07436
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBE1 RID: 179169 RVA: 0x00A0924A File Offset: 0x00A0744A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BBE2 RID: 179170 RVA: 0x00A09260 File Offset: 0x00A07460
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BBE3 RID: 179171 RVA: 0x00A092A8 File Offset: 0x00A074A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BBE4 RID: 179172 RVA: 0x00A092EF File Offset: 0x00A074EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StateMachineInitializationComplete()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__StateMachineInitializationComplete_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBE5 RID: 179173 RVA: 0x00A09303 File Offset: 0x00A07503
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NoneStateStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__NoneStateStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBE6 RID: 179174 RVA: 0x00A09317 File Offset: 0x00A07517
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__InteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBE7 RID: 179175 RVA: 0x00A0932B File Offset: 0x00A0752B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void IdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__IdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBE8 RID: 179176 RVA: 0x00A0933F File Offset: 0x00A0753F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__UnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBE9 RID: 179177 RVA: 0x00A09353 File Offset: 0x00A07553
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__AlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBEA RID: 179178 RVA: 0x00A09367 File Offset: 0x00A07567
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__TakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBEB RID: 179179 RVA: 0x00A0937C File Offset: 0x00A0757C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FeedStart(FGameplayTag GameplayTag)
		{
			ABP_BaseRunAnimal_C.__FeedStart_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__FeedStart_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__FeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__FeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__FeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BBEC RID: 179180 RVA: 0x00A093C2 File Offset: 0x00A075C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SystemUiStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__SystemUiStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBED RID: 179181 RVA: 0x00A093D6 File Offset: 0x00A075D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SystemUiEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__SystemUiEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBEE RID: 179182 RVA: 0x00A093EA File Offset: 0x00A075EA
		protected ABP_BaseRunAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016C7D RID: 93309
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/ABP_BaseRunAnimal.ABP_BaseRunAnimal_C";

		// Token: 0x04016C7E RID: 93310
		private static IntPtr _ClassPtr;

		// Token: 0x04016C7F RID: 93311
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016C80 RID: 93312
		internal static int __PropertyOffset_140;

		// Token: 0x04016C81 RID: 93313
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _待机表演配置;

		// Token: 0x04016C82 RID: 93314
		internal static int __PropertyOffset_141;

		// Token: 0x04016C83 RID: 93315
		internal static int __PropertyOffset_142;

		// Token: 0x04016C84 RID: 93316
		internal static int __PropertyOffset_143;

		// Token: 0x04016C85 RID: 93317
		internal static int __PropertyOffset_144;

		// Token: 0x04016C86 RID: 93318
		internal static int __PropertyOffset_145;

		// Token: 0x04016C87 RID: 93319
		internal static int __PropertyOffset_146;

		// Token: 0x04016C88 RID: 93320
		internal static int __PropertyOffset_147;

		// Token: 0x04016C89 RID: 93321
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _交互表演配置;

		// Token: 0x04016C8A RID: 93322
		internal static int __PropertyOffset_148;

		// Token: 0x04016C8B RID: 93323
		internal static int __PropertyOffset_149;

		// Token: 0x04016C8C RID: 93324
		internal static int __PropertyOffset_150;

		// Token: 0x04016C8D RID: 93325
		internal static int __PropertyOffset_151;

		// Token: 0x04016C8E RID: 93326
		internal static int __PropertyOffset_152;

		// Token: 0x04016C8F RID: 93327
		internal static int __PropertyOffset_153;

		// Token: 0x04016C90 RID: 93328
		internal static int __PropertyOffset_154;

		// Token: 0x04016C91 RID: 93329
		internal static int __PropertyOffset_155;

		// Token: 0x04016C92 RID: 93330
		internal static int __PropertyOffset_156;

		// Token: 0x04016C93 RID: 93331
		internal static int __PropertyOffset_157;

		// Token: 0x04016C94 RID: 93332
		internal static int __PropertyOffset_158;

		// Token: 0x04016C95 RID: 93333
		internal static int __PropertyOffset_159;

		// Token: 0x04016C96 RID: 93334
		internal static int __PropertyOffset_160;

		// Token: 0x04016C97 RID: 93335
		internal static int __PropertyOffset_161;

		// Token: 0x04016C98 RID: 93336
		internal static int __PropertyOffset_162;

		// Token: 0x04016C99 RID: 93337
		internal static int __PropertyOffset_163;

		// Token: 0x04016C9A RID: 93338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, UAnimSequence> _其他动作配置;

		// Token: 0x04016C9B RID: 93339
		internal static int __PropertyOffset_164;

		// Token: 0x04016C9C RID: 93340
		internal static int __PropertyOffset_165;

		// Token: 0x04016C9D RID: 93341
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> _材质配置;

		// Token: 0x04016C9E RID: 93342
		internal static int __PropertyOffset_166;

		// Token: 0x04016C9F RID: 93343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, UAnimMontage> _蒙太奇表演配置;

		// Token: 0x04016CA0 RID: 93344
		internal static int __PropertyOffset_167;

		// Token: 0x04016CA1 RID: 93345
		internal static int __PropertyOffset_168;

		// Token: 0x04016CA2 RID: 93346
		private static IntPtr __GetCurrentActionTime_NativeFunctionPtr;

		// Token: 0x04016CA3 RID: 93347
		private static IntPtr __演出层_NativeFunctionPtr;

		// Token: 0x04016CA4 RID: 93348
		private static IntPtr __后处理层_NativeFunctionPtr;

		// Token: 0x04016CA5 RID: 93349
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016CA6 RID: 93350
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016CA7 RID: 93351
		private static IntPtr __OnSystemUIStart_NativeFunctionPtr;

		// Token: 0x04016CA8 RID: 93352
		private static IntPtr __OnFeedStart_NativeFunctionPtr;

		// Token: 0x04016CA9 RID: 93353
		private static IntPtr __更新移动信息_NativeFunctionPtr;

		// Token: 0x04016CAA RID: 93354
		private static IntPtr __处理动作优先级_NativeFunctionPtr;

		// Token: 0x04016CAB RID: 93355
		private static IntPtr __OnUnderAttackStart_NativeFunctionPtr;

		// Token: 0x04016CAC RID: 93356
		private static IntPtr __OnTakeOffStart_NativeFunctionPtr;

		// Token: 0x04016CAD RID: 93357
		private static IntPtr __OnAlertStart_NativeFunctionPtr;

		// Token: 0x04016CAE RID: 93358
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04016CAF RID: 93359
		private static IntPtr __OnInteractStart_NativeFunctionPtr;

		// Token: 0x04016CB0 RID: 93360
		private static IntPtr __更新特殊交互表演_NativeFunctionPtr;

		// Token: 0x04016CB1 RID: 93361
		private static IntPtr __更新交互表演_NativeFunctionPtr;

		// Token: 0x04016CB2 RID: 93362
		private static IntPtr __OnIdleStart_NativeFunctionPtr;

		// Token: 0x04016CB3 RID: 93363
		private static IntPtr __更新待机表演_NativeFunctionPtr;

		// Token: 0x04016CB4 RID: 93364
		private static IntPtr __TakeOffEnd_NativeFunctionPtr;

		// Token: 0x04016CB5 RID: 93365
		private static IntPtr __AlertEnd_NativeFunctionPtr;

		// Token: 0x04016CB6 RID: 93366
		private static IntPtr __UnderAttackEnd_NativeFunctionPtr;

		// Token: 0x04016CB7 RID: 93367
		private static IntPtr __IdleEnd_NativeFunctionPtr;

		// Token: 0x04016CB8 RID: 93368
		private static IntPtr __InteractEnd_NativeFunctionPtr;

		// Token: 0x04016CB9 RID: 93369
		private static IntPtr __NoneStateEnd_NativeFunctionPtr;

		// Token: 0x04016CBA RID: 93370
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016CBB RID: 93371
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016CBC RID: 93372
		private static IntPtr __StateMachineInitializationComplete_NativeFunctionPtr;

		// Token: 0x04016CBD RID: 93373
		private static IntPtr __NoneStateStart_NativeFunctionPtr;

		// Token: 0x04016CBE RID: 93374
		private static IntPtr __InteractStart_NativeFunctionPtr;

		// Token: 0x04016CBF RID: 93375
		private static IntPtr __IdleStart_NativeFunctionPtr;

		// Token: 0x04016CC0 RID: 93376
		private static IntPtr __UnderAttackStart_NativeFunctionPtr;

		// Token: 0x04016CC1 RID: 93377
		private static IntPtr __AlertStart_NativeFunctionPtr;

		// Token: 0x04016CC2 RID: 93378
		private static IntPtr __TakeOffStart_NativeFunctionPtr;

		// Token: 0x04016CC3 RID: 93379
		private static IntPtr __FeedStart_NativeFunctionPtr;

		// Token: 0x04016CC4 RID: 93380
		private static IntPtr __SystemUiStart_NativeFunctionPtr;

		// Token: 0x04016CC5 RID: 93381
		private static IntPtr __SystemUiEnd_NativeFunctionPtr;

		// Token: 0x0200A58B RID: 42379
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentActionTime_FunctionParams
		{
			// Token: 0x04032415 RID: 205845
			[FieldOffset(0)]
			public float ActionTime;
		}

		// Token: 0x0200A58C RID: 42380
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __演出层_FunctionParams
		{
			// Token: 0x04032416 RID: 205846
			[FieldOffset(0)]
			public byte 状态机输入;

			// Token: 0x04032417 RID: 205847
			[FieldOffset(24)]
			public byte 演出层;
		}

		// Token: 0x0200A58D RID: 42381
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __后处理层_FunctionParams
		{
			// Token: 0x04032418 RID: 205848
			[FieldOffset(0)]
			public byte 基础输入;

			// Token: 0x04032419 RID: 205849
			[FieldOffset(24)]
			public byte 后处理层;
		}

		// Token: 0x0200A58E RID: 42382
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x0403241A RID: 205850
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A58F RID: 42383
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403241B RID: 205851
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A590 RID: 42384
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnFeedStart_FunctionParams
		{
			// Token: 0x0403241C RID: 205852
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}

		// Token: 0x0200A591 RID: 42385
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0403241D RID: 205853
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x0200A592 RID: 42386
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FeedStart_FunctionParams
		{
			// Token: 0x0403241E RID: 205854
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}
	}
}
