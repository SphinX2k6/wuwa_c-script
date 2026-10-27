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
	// Token: 0x020041A3 RID: 16803
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/ABP_BaseAnimal.ABP_BaseAnimal_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_BaseAnimal_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_AnimalEcological_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602BB25 RID: 178981 RVA: 0x00A07D21 File Offset: 0x00A05F21
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/ABP_BaseAnimal.ABP_BaseAnimal_C");
			}
			return ABP_BaseAnimal_C._ClassPtr;
		}

		// Token: 0x0602BB26 RID: 178982 RVA: 0x00A07D48 File Offset: 0x00A05F48
		public ABP_BaseAnimal_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BB27 RID: 178983 RVA: 0x00A07D70 File Offset: 0x00A05F70
		[NullableContext(1)]
		public ABP_BaseAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C8F RID: 27791
		// (get) Token: 0x0602BB28 RID: 178984 RVA: 0x00A07DA4 File Offset: 0x00A05FA4
		// (set) Token: 0x0602BB29 RID: 178985 RVA: 0x00A07DDD File Offset: 0x00A05FDD
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
					result = (this._待机表演配置 = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_137, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.待机表演配置.CopyAssign(value);
			}
		}

		// Token: 0x17006C90 RID: 27792
		// (get) Token: 0x0602BB2A RID: 178986 RVA: 0x00A07DEB File Offset: 0x00A05FEB
		// (set) Token: 0x0602BB2B RID: 178987 RVA: 0x00A07DFF File Offset: 0x00A05FFF
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_138);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_138, value);
			}
		}

		// Token: 0x17006C91 RID: 27793
		// (get) Token: 0x0602BB2C RID: 178988 RVA: 0x00A07E14 File Offset: 0x00A06014
		// (set) Token: 0x0602BB2D RID: 178989 RVA: 0x00A07E28 File Offset: 0x00A06028
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色网格体
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_139);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_139, value);
			}
		}

		// Token: 0x17006C92 RID: 27794
		// (get) Token: 0x0602BB2E RID: 178990 RVA: 0x00A07E3D File Offset: 0x00A0603D
		// (set) Token: 0x0602BB2F RID: 178991 RVA: 0x00A07E51 File Offset: 0x00A06051
		public unsafe TEnumAsByte<EAnimalEcologicalState> 生态表现状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_140);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_140) = value;
			}
		}

		// Token: 0x17006C93 RID: 27795
		// (get) Token: 0x0602BB30 RID: 178992 RVA: 0x00A07E66 File Offset: 0x00A06066
		// (set) Token: 0x0602BB31 RID: 178993 RVA: 0x00A07E76 File Offset: 0x00A06076
		public unsafe bool 状态机初始化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_141) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_141) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C94 RID: 27796
		// (get) Token: 0x0602BB32 RID: 178994 RVA: 0x00A07E87 File Offset: 0x00A06087
		// (set) Token: 0x0602BB33 RID: 178995 RVA: 0x00A07E97 File Offset: 0x00A06097
		public unsafe int IdleActionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_142);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_142) = value;
			}
		}

		// Token: 0x17006C95 RID: 27797
		// (get) Token: 0x0602BB34 RID: 178996 RVA: 0x00A07EA8 File Offset: 0x00A060A8
		// (set) Token: 0x0602BB35 RID: 178997 RVA: 0x00A07EBC File Offset: 0x00A060BC
		[Nullable(2)]
		public unsafe UAnimSequence IdleAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_143);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_143, value);
			}
		}

		// Token: 0x17006C96 RID: 27798
		// (get) Token: 0x0602BB36 RID: 178998 RVA: 0x00A07ED4 File Offset: 0x00A060D4
		// (set) Token: 0x0602BB37 RID: 178999 RVA: 0x00A07F0D File Offset: 0x00A0610D
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
					result = (this._交互表演配置 = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_144, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.交互表演配置.CopyAssign(value);
			}
		}

		// Token: 0x17006C97 RID: 27799
		// (get) Token: 0x0602BB38 RID: 179000 RVA: 0x00A07F1B File Offset: 0x00A0611B
		// (set) Token: 0x0602BB39 RID: 179001 RVA: 0x00A07F2B File Offset: 0x00A0612B
		public unsafe int InteractActionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_145);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_145) = value;
			}
		}

		// Token: 0x17006C98 RID: 27800
		// (get) Token: 0x0602BB3A RID: 179002 RVA: 0x00A07F3C File Offset: 0x00A0613C
		// (set) Token: 0x0602BB3B RID: 179003 RVA: 0x00A07F50 File Offset: 0x00A06150
		[Nullable(2)]
		public unsafe UAnimSequence InteractAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_146);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_146, value);
			}
		}

		// Token: 0x17006C99 RID: 27801
		// (get) Token: 0x0602BB3C RID: 179004 RVA: 0x00A07F65 File Offset: 0x00A06165
		// (set) Token: 0x0602BB3D RID: 179005 RVA: 0x00A07F79 File Offset: 0x00A06179
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_147);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_147) = value;
			}
		}

		// Token: 0x17006C9A RID: 27802
		// (get) Token: 0x0602BB3E RID: 179006 RVA: 0x00A07F8E File Offset: 0x00A0618E
		// (set) Token: 0x0602BB3F RID: 179007 RVA: 0x00A07F9E File Offset: 0x00A0619E
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_148));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_148) = (byte)value;
			}
		}

		// Token: 0x17006C9B RID: 27803
		// (get) Token: 0x0602BB40 RID: 179008 RVA: 0x00A07FAF File Offset: 0x00A061AF
		// (set) Token: 0x0602BB41 RID: 179009 RVA: 0x00A07FBF File Offset: 0x00A061BF
		public unsafe int WalkRunParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_149);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_149) = value;
			}
		}

		// Token: 0x17006C9C RID: 27804
		// (get) Token: 0x0602BB42 RID: 179010 RVA: 0x00A07FD0 File Offset: 0x00A061D0
		// (set) Token: 0x0602BB43 RID: 179011 RVA: 0x00A07FE0 File Offset: 0x00A061E0
		public unsafe float 左右跑参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_150);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_150) = value;
			}
		}

		// Token: 0x17006C9D RID: 27805
		// (get) Token: 0x0602BB44 RID: 179012 RVA: 0x00A07FF1 File Offset: 0x00A061F1
		// (set) Token: 0x0602BB45 RID: 179013 RVA: 0x00A08001 File Offset: 0x00A06201
		public unsafe bool bHaveInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_151) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_151) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C9E RID: 27806
		// (get) Token: 0x0602BB46 RID: 179014 RVA: 0x00A08012 File Offset: 0x00A06212
		// (set) Token: 0x0602BB47 RID: 179015 RVA: 0x00A08022 File Offset: 0x00A06222
		public unsafe bool bIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_152) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_152) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C9F RID: 27807
		// (get) Token: 0x0602BB48 RID: 179016 RVA: 0x00A08033 File Offset: 0x00A06233
		// (set) Token: 0x0602BB49 RID: 179017 RVA: 0x00A08043 File Offset: 0x00A06243
		public unsafe bool 是否警觉
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_153) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_153) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CA0 RID: 27808
		// (get) Token: 0x0602BB4A RID: 179018 RVA: 0x00A08054 File Offset: 0x00A06254
		// (set) Token: 0x0602BB4B RID: 179019 RVA: 0x00A08064 File Offset: 0x00A06264
		public unsafe bool 是否起跑转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_154) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_154) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CA1 RID: 27809
		// (get) Token: 0x0602BB4C RID: 179020 RVA: 0x00A08075 File Offset: 0x00A06275
		// (set) Token: 0x0602BB4D RID: 179021 RVA: 0x00A08085 File Offset: 0x00A06285
		public unsafe bool 起跑左转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_155) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_155) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CA2 RID: 27810
		// (get) Token: 0x0602BB4E RID: 179022 RVA: 0x00A08096 File Offset: 0x00A06296
		// (set) Token: 0x0602BB4F RID: 179023 RVA: 0x00A080A6 File Offset: 0x00A062A6
		public unsafe bool bInteractAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_156) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_156) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CA3 RID: 27811
		// (get) Token: 0x0602BB50 RID: 179024 RVA: 0x00A080B7 File Offset: 0x00A062B7
		// (set) Token: 0x0602BB51 RID: 179025 RVA: 0x00A080C7 File Offset: 0x00A062C7
		public unsafe bool 受到攻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_157) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_157) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CA4 RID: 27812
		// (get) Token: 0x0602BB52 RID: 179026 RVA: 0x00A080D8 File Offset: 0x00A062D8
		// (set) Token: 0x0602BB53 RID: 179027 RVA: 0x00A080E8 File Offset: 0x00A062E8
		public unsafe bool 起飞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_158) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_158) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CA5 RID: 27813
		// (get) Token: 0x0602BB54 RID: 179028 RVA: 0x00A080F9 File Offset: 0x00A062F9
		// (set) Token: 0x0602BB55 RID: 179029 RVA: 0x00A08109 File Offset: 0x00A06309
		public unsafe bool bSitDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_159) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_159) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CA6 RID: 27814
		// (get) Token: 0x0602BB56 RID: 179030 RVA: 0x00A0811C File Offset: 0x00A0631C
		// (set) Token: 0x0602BB57 RID: 179031 RVA: 0x00A08155 File Offset: 0x00A06355
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
					result = (this._其他动作配置 = new TMap<FGameplayTag, UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_160, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.其他动作配置.CopyAssign(value);
			}
		}

		// Token: 0x17006CA7 RID: 27815
		// (get) Token: 0x0602BB58 RID: 179032 RVA: 0x00A08163 File Offset: 0x00A06363
		// (set) Token: 0x0602BB59 RID: 179033 RVA: 0x00A08173 File Offset: 0x00A06373
		public unsafe float ActionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_161);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_161) = value;
			}
		}

		// Token: 0x17006CA8 RID: 27816
		// (get) Token: 0x0602BB5A RID: 179034 RVA: 0x00A08184 File Offset: 0x00A06384
		// (set) Token: 0x0602BB5B RID: 179035 RVA: 0x00A081BD File Offset: 0x00A063BD
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
					result = (this._材质配置 = new TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_162, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.材质配置.CopyAssign(value);
			}
		}

		// Token: 0x17006CA9 RID: 27817
		// (get) Token: 0x0602BB5C RID: 179036 RVA: 0x00A081CC File Offset: 0x00A063CC
		// (set) Token: 0x0602BB5D RID: 179037 RVA: 0x00A08205 File Offset: 0x00A06405
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
					result = (this._蒙太奇表演配置 = new TMap<FGameplayTag, UAnimMontage>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_163, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.蒙太奇表演配置.CopyAssign(value);
			}
		}

		// Token: 0x17006CAA RID: 27818
		// (get) Token: 0x0602BB5E RID: 179038 RVA: 0x00A08213 File Offset: 0x00A06413
		// (set) Token: 0x0602BB5F RID: 179039 RVA: 0x00A08223 File Offset: 0x00A06423
		public unsafe bool 支持急转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_164) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_164) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CAB RID: 27819
		// (get) Token: 0x0602BB60 RID: 179040 RVA: 0x00A08234 File Offset: 0x00A06434
		// (set) Token: 0x0602BB61 RID: 179041 RVA: 0x00A08244 File Offset: 0x00A06444
		public unsafe bool 系统UI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_165) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_165) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CAC RID: 27820
		// (get) Token: 0x0602BB62 RID: 179042 RVA: 0x00A08255 File Offset: 0x00A06455
		// (set) Token: 0x0602BB63 RID: 179043 RVA: 0x00A08265 File Offset: 0x00A06465
		public unsafe bool bGetDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_166) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_166) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602BB64 RID: 179044 RVA: 0x00A08278 File Offset: 0x00A06478
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCurrentActionTime(ref float ActionTime)
		{
			ABP_BaseAnimal_C.__GetCurrentActionTime_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__GetCurrentActionTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseAnimal_C.__GetCurrentActionTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActionTime = ActionTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr);
			ActionTime = ptr->ActionTime;
		}

		// Token: 0x0602BB65 RID: 179045 RVA: 0x00A082C8 File Offset: 0x00A064C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 演出层(FPoseLink 状态机输入, ref FPoseLink 演出层)
		{
			ABP_BaseAnimal_C.__演出层_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__演出层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseAnimal_C.__演出层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__演出层_NativeFunctionPtr, (void*)ptr, 1);
			if (状态机输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->状态机输入, 状态机输入.NativePtr, 1, false);
			}
			if (演出层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->演出层, 演出层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__演出层_NativeFunctionPtr, (void*)ptr);
			if (演出层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 演出层.NativePtr, &ptr->演出层, 1, false);
			}
		}

		// Token: 0x0602BB66 RID: 179046 RVA: 0x00A08374 File Offset: 0x00A06574
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 后处理层(FPoseLink 基础输入, ref FPoseLink 后处理层)
		{
			ABP_BaseAnimal_C.__后处理层_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__后处理层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseAnimal_C.__后处理层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__后处理层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础输入 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础输入, 基础输入.NativePtr, 1, false);
			}
			if (后处理层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->后处理层, 后处理层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__后处理层_NativeFunctionPtr, (void*)ptr);
			if (后处理层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 后处理层.NativePtr, &ptr->后处理层, 1, false);
			}
		}

		// Token: 0x0602BB67 RID: 179047 RVA: 0x00A08420 File Offset: 0x00A06620
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_BaseAnimal_C.__基础层_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseAnimal_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BB68 RID: 179048 RVA: 0x00A084A8 File Offset: 0x00A066A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseAnimal_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseAnimal_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BB69 RID: 179049 RVA: 0x00A0852F File Offset: 0x00A0672F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnSystemUIStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnSystemUIStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB6A RID: 179050 RVA: 0x00A08544 File Offset: 0x00A06744
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnFeedStart(FGameplayTag GameplayTag)
		{
			ABP_BaseAnimal_C.__OnFeedStart_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__OnFeedStart_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseAnimal_C.__OnFeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__OnFeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnFeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BB6B RID: 179051 RVA: 0x00A0858A File Offset: 0x00A0678A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新移动信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新移动信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB6C RID: 179052 RVA: 0x00A0859E File Offset: 0x00A0679E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 处理动作优先级()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__处理动作优先级_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB6D RID: 179053 RVA: 0x00A085B2 File Offset: 0x00A067B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnUnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnUnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB6E RID: 179054 RVA: 0x00A085C6 File Offset: 0x00A067C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnTakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB6F RID: 179055 RVA: 0x00A085DA File Offset: 0x00A067DA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnAlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnAlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB70 RID: 179056 RVA: 0x00A085EE File Offset: 0x00A067EE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB71 RID: 179057 RVA: 0x00A08602 File Offset: 0x00A06802
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnInteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB72 RID: 179058 RVA: 0x00A08616 File Offset: 0x00A06816
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新特殊交互表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新特殊交互表演_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB73 RID: 179059 RVA: 0x00A0862A File Offset: 0x00A0682A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新交互表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新交互表演_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB74 RID: 179060 RVA: 0x00A0863E File Offset: 0x00A0683E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnIdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnIdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB75 RID: 179061 RVA: 0x00A08652 File Offset: 0x00A06852
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新待机表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新待机表演_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB76 RID: 179062 RVA: 0x00A08666 File Offset: 0x00A06866
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AlertEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__AlertEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB77 RID: 179063 RVA: 0x00A0867A File Offset: 0x00A0687A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TakeOffEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__TakeOffEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB78 RID: 179064 RVA: 0x00A0868E File Offset: 0x00A0688E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UnderAttackEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__UnderAttackEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB79 RID: 179065 RVA: 0x00A086A2 File Offset: 0x00A068A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void IdleEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__IdleEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB7A RID: 179066 RVA: 0x00A086B6 File Offset: 0x00A068B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InteractEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__InteractEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB7B RID: 179067 RVA: 0x00A086CA File Offset: 0x00A068CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NoneStateEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__NoneStateEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB7C RID: 179068 RVA: 0x00A086DE File Offset: 0x00A068DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB7D RID: 179069 RVA: 0x00A086F2 File Offset: 0x00A068F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BB7E RID: 179070 RVA: 0x00A08708 File Offset: 0x00A06908
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BB7F RID: 179071 RVA: 0x00A08750 File Offset: 0x00A06950
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BB80 RID: 179072 RVA: 0x00A08797 File Offset: 0x00A06997
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StateMachineInitializationComplete()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__StateMachineInitializationComplete_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB81 RID: 179073 RVA: 0x00A087AB File Offset: 0x00A069AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NoneStateStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__NoneStateStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB82 RID: 179074 RVA: 0x00A087BF File Offset: 0x00A069BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__InteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB83 RID: 179075 RVA: 0x00A087D3 File Offset: 0x00A069D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void IdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__IdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB84 RID: 179076 RVA: 0x00A087E7 File Offset: 0x00A069E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__UnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB85 RID: 179077 RVA: 0x00A087FB File Offset: 0x00A069FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__AlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB86 RID: 179078 RVA: 0x00A0880F File Offset: 0x00A06A0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__TakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB87 RID: 179079 RVA: 0x00A08824 File Offset: 0x00A06A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FeedStart(FGameplayTag GameplayTag)
		{
			ABP_BaseAnimal_C.__FeedStart_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__FeedStart_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseAnimal_C.__FeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__FeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__FeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BB88 RID: 179080 RVA: 0x00A0886A File Offset: 0x00A06A6A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SystemUiStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__SystemUiStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB89 RID: 179081 RVA: 0x00A0887E File Offset: 0x00A06A7E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SystemUiEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__SystemUiEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB8A RID: 179082 RVA: 0x00A08892 File Offset: 0x00A06A92
		protected ABP_BaseAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016C33 RID: 93235
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/ABP_BaseAnimal.ABP_BaseAnimal_C";

		// Token: 0x04016C34 RID: 93236
		private static IntPtr _ClassPtr;

		// Token: 0x04016C35 RID: 93237
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016C36 RID: 93238
		internal static int __PropertyOffset_137;

		// Token: 0x04016C37 RID: 93239
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _待机表演配置;

		// Token: 0x04016C38 RID: 93240
		internal static int __PropertyOffset_138;

		// Token: 0x04016C39 RID: 93241
		internal static int __PropertyOffset_139;

		// Token: 0x04016C3A RID: 93242
		internal static int __PropertyOffset_140;

		// Token: 0x04016C3B RID: 93243
		internal static int __PropertyOffset_141;

		// Token: 0x04016C3C RID: 93244
		internal static int __PropertyOffset_142;

		// Token: 0x04016C3D RID: 93245
		internal static int __PropertyOffset_143;

		// Token: 0x04016C3E RID: 93246
		internal static int __PropertyOffset_144;

		// Token: 0x04016C3F RID: 93247
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _交互表演配置;

		// Token: 0x04016C40 RID: 93248
		internal static int __PropertyOffset_145;

		// Token: 0x04016C41 RID: 93249
		internal static int __PropertyOffset_146;

		// Token: 0x04016C42 RID: 93250
		internal static int __PropertyOffset_147;

		// Token: 0x04016C43 RID: 93251
		internal static int __PropertyOffset_148;

		// Token: 0x04016C44 RID: 93252
		internal static int __PropertyOffset_149;

		// Token: 0x04016C45 RID: 93253
		internal static int __PropertyOffset_150;

		// Token: 0x04016C46 RID: 93254
		internal static int __PropertyOffset_151;

		// Token: 0x04016C47 RID: 93255
		internal static int __PropertyOffset_152;

		// Token: 0x04016C48 RID: 93256
		internal static int __PropertyOffset_153;

		// Token: 0x04016C49 RID: 93257
		internal static int __PropertyOffset_154;

		// Token: 0x04016C4A RID: 93258
		internal static int __PropertyOffset_155;

		// Token: 0x04016C4B RID: 93259
		internal static int __PropertyOffset_156;

		// Token: 0x04016C4C RID: 93260
		internal static int __PropertyOffset_157;

		// Token: 0x04016C4D RID: 93261
		internal static int __PropertyOffset_158;

		// Token: 0x04016C4E RID: 93262
		internal static int __PropertyOffset_159;

		// Token: 0x04016C4F RID: 93263
		internal static int __PropertyOffset_160;

		// Token: 0x04016C50 RID: 93264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, UAnimSequence> _其他动作配置;

		// Token: 0x04016C51 RID: 93265
		internal static int __PropertyOffset_161;

		// Token: 0x04016C52 RID: 93266
		internal static int __PropertyOffset_162;

		// Token: 0x04016C53 RID: 93267
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> _材质配置;

		// Token: 0x04016C54 RID: 93268
		internal static int __PropertyOffset_163;

		// Token: 0x04016C55 RID: 93269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, UAnimMontage> _蒙太奇表演配置;

		// Token: 0x04016C56 RID: 93270
		internal static int __PropertyOffset_164;

		// Token: 0x04016C57 RID: 93271
		internal static int __PropertyOffset_165;

		// Token: 0x04016C58 RID: 93272
		internal static int __PropertyOffset_166;

		// Token: 0x04016C59 RID: 93273
		private static IntPtr __GetCurrentActionTime_NativeFunctionPtr;

		// Token: 0x04016C5A RID: 93274
		private static IntPtr __演出层_NativeFunctionPtr;

		// Token: 0x04016C5B RID: 93275
		private static IntPtr __后处理层_NativeFunctionPtr;

		// Token: 0x04016C5C RID: 93276
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016C5D RID: 93277
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016C5E RID: 93278
		private static IntPtr __OnSystemUIStart_NativeFunctionPtr;

		// Token: 0x04016C5F RID: 93279
		private static IntPtr __OnFeedStart_NativeFunctionPtr;

		// Token: 0x04016C60 RID: 93280
		private static IntPtr __更新移动信息_NativeFunctionPtr;

		// Token: 0x04016C61 RID: 93281
		private static IntPtr __处理动作优先级_NativeFunctionPtr;

		// Token: 0x04016C62 RID: 93282
		private static IntPtr __OnUnderAttackStart_NativeFunctionPtr;

		// Token: 0x04016C63 RID: 93283
		private static IntPtr __OnTakeOffStart_NativeFunctionPtr;

		// Token: 0x04016C64 RID: 93284
		private static IntPtr __OnAlertStart_NativeFunctionPtr;

		// Token: 0x04016C65 RID: 93285
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04016C66 RID: 93286
		private static IntPtr __OnInteractStart_NativeFunctionPtr;

		// Token: 0x04016C67 RID: 93287
		private static IntPtr __更新特殊交互表演_NativeFunctionPtr;

		// Token: 0x04016C68 RID: 93288
		private static IntPtr __更新交互表演_NativeFunctionPtr;

		// Token: 0x04016C69 RID: 93289
		private static IntPtr __OnIdleStart_NativeFunctionPtr;

		// Token: 0x04016C6A RID: 93290
		private static IntPtr __更新待机表演_NativeFunctionPtr;

		// Token: 0x04016C6B RID: 93291
		private static IntPtr __AlertEnd_NativeFunctionPtr;

		// Token: 0x04016C6C RID: 93292
		private static IntPtr __TakeOffEnd_NativeFunctionPtr;

		// Token: 0x04016C6D RID: 93293
		private static IntPtr __UnderAttackEnd_NativeFunctionPtr;

		// Token: 0x04016C6E RID: 93294
		private static IntPtr __IdleEnd_NativeFunctionPtr;

		// Token: 0x04016C6F RID: 93295
		private static IntPtr __InteractEnd_NativeFunctionPtr;

		// Token: 0x04016C70 RID: 93296
		private static IntPtr __NoneStateEnd_NativeFunctionPtr;

		// Token: 0x04016C71 RID: 93297
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016C72 RID: 93298
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016C73 RID: 93299
		private static IntPtr __StateMachineInitializationComplete_NativeFunctionPtr;

		// Token: 0x04016C74 RID: 93300
		private static IntPtr __NoneStateStart_NativeFunctionPtr;

		// Token: 0x04016C75 RID: 93301
		private static IntPtr __InteractStart_NativeFunctionPtr;

		// Token: 0x04016C76 RID: 93302
		private static IntPtr __IdleStart_NativeFunctionPtr;

		// Token: 0x04016C77 RID: 93303
		private static IntPtr __UnderAttackStart_NativeFunctionPtr;

		// Token: 0x04016C78 RID: 93304
		private static IntPtr __AlertStart_NativeFunctionPtr;

		// Token: 0x04016C79 RID: 93305
		private static IntPtr __TakeOffStart_NativeFunctionPtr;

		// Token: 0x04016C7A RID: 93306
		private static IntPtr __FeedStart_NativeFunctionPtr;

		// Token: 0x04016C7B RID: 93307
		private static IntPtr __SystemUiStart_NativeFunctionPtr;

		// Token: 0x04016C7C RID: 93308
		private static IntPtr __SystemUiEnd_NativeFunctionPtr;

		// Token: 0x0200A583 RID: 42371
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentActionTime_FunctionParams
		{
			// Token: 0x0403240B RID: 205835
			[FieldOffset(0)]
			public float ActionTime;
		}

		// Token: 0x0200A584 RID: 42372
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __演出层_FunctionParams
		{
			// Token: 0x0403240C RID: 205836
			[FieldOffset(0)]
			public byte 状态机输入;

			// Token: 0x0403240D RID: 205837
			[FieldOffset(24)]
			public byte 演出层;
		}

		// Token: 0x0200A585 RID: 42373
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __后处理层_FunctionParams
		{
			// Token: 0x0403240E RID: 205838
			[FieldOffset(0)]
			public byte 基础输入;

			// Token: 0x0403240F RID: 205839
			[FieldOffset(24)]
			public byte 后处理层;
		}

		// Token: 0x0200A586 RID: 42374
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x04032410 RID: 205840
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A587 RID: 42375
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032411 RID: 205841
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A588 RID: 42376
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnFeedStart_FunctionParams
		{
			// Token: 0x04032412 RID: 205842
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}

		// Token: 0x0200A589 RID: 42377
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032413 RID: 205843
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x0200A58A RID: 42378
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FeedStart_FunctionParams
		{
			// Token: 0x04032414 RID: 205844
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}
	}
}
