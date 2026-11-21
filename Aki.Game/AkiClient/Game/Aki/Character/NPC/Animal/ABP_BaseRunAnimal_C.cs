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
	// Token: 0x020032BF RID: 12991
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/ABP_BaseRunAnimal.ABP_BaseRunAnimal_C")]
	[UnrealStructLayout(19264, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19250)]
	public class ABP_BaseRunAnimal_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_AnimalEcological_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020E20 RID: 134688 RVA: 0x00951973 File Offset: 0x0094FB73
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRunAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/ABP_BaseRunAnimal.ABP_BaseRunAnimal_C");
			}
			return ABP_BaseRunAnimal_C._ClassPtr;
		}

		// Token: 0x06020E21 RID: 134689 RVA: 0x00951998 File Offset: 0x0094FB98
		public ABP_BaseRunAnimal_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRunAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E22 RID: 134690 RVA: 0x009519C0 File Offset: 0x0094FBC0
		public ABP_BaseRunAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRunAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x06020E23 RID: 134691 RVA: 0x009519F4 File Offset: 0x0094FBF4
		// (set) Token: 0x06020E24 RID: 134692 RVA: 0x00951A2D File Offset: 0x0094FC2D
		public TArray<UAnimSequence> 待机表演配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimSequence> result;
				if ((result = this._待机表演配置) == null)
				{
					result = (this._待机表演配置 = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_待机表演配置, this));
				}
				return result;
			}
			set
			{
				this.待机表演配置.CopyAssign(value);
			}
		}

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x06020E25 RID: 134693 RVA: 0x00951A3B File Offset: 0x0094FC3B
		// (set) Token: 0x06020E26 RID: 134694 RVA: 0x00951A4F File Offset: 0x0094FC4F
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x06020E27 RID: 134695 RVA: 0x00951A64 File Offset: 0x0094FC64
		// (set) Token: 0x06020E28 RID: 134696 RVA: 0x00951A78 File Offset: 0x0094FC78
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色网格体
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_角色网格体);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_角色网格体, value);
			}
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x06020E29 RID: 134697 RVA: 0x00951A8D File Offset: 0x0094FC8D
		// (set) Token: 0x06020E2A RID: 134698 RVA: 0x00951AA1 File Offset: 0x0094FCA1
		[Nullable(0)]
		public unsafe TEnumAsByte<EAnimalEcologicalState> 生态表现状态
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_生态表现状态);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_生态表现状态) = value;
			}
		}

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x06020E2B RID: 134699 RVA: 0x00951AB6 File Offset: 0x0094FCB6
		// (set) Token: 0x06020E2C RID: 134700 RVA: 0x00951AC6 File Offset: 0x0094FCC6
		public unsafe bool 状态机初始化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_状态机初始化) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_状态机初始化) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x06020E2D RID: 134701 RVA: 0x00951AD7 File Offset: 0x0094FCD7
		// (set) Token: 0x06020E2E RID: 134702 RVA: 0x00951AE7 File Offset: 0x0094FCE7
		public unsafe int IdleActionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_IdleActionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_IdleActionIndex) = value;
			}
		}

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x06020E2F RID: 134703 RVA: 0x00951AF8 File Offset: 0x0094FCF8
		// (set) Token: 0x06020E30 RID: 134704 RVA: 0x00951B0C File Offset: 0x0094FD0C
		[Nullable(2)]
		public unsafe UAnimSequence IdleAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_IdleAnim);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_IdleAnim, value);
			}
		}

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x06020E31 RID: 134705 RVA: 0x00951B24 File Offset: 0x0094FD24
		// (set) Token: 0x06020E32 RID: 134706 RVA: 0x00951B5D File Offset: 0x0094FD5D
		public TArray<UAnimSequence> 交互表演配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimSequence> result;
				if ((result = this._交互表演配置) == null)
				{
					result = (this._交互表演配置 = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_交互表演配置, this));
				}
				return result;
			}
			set
			{
				this.交互表演配置.CopyAssign(value);
			}
		}

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x06020E33 RID: 134707 RVA: 0x00951B6B File Offset: 0x0094FD6B
		// (set) Token: 0x06020E34 RID: 134708 RVA: 0x00951B7B File Offset: 0x0094FD7B
		public unsafe int InteractActionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_InteractActionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_InteractActionIndex) = value;
			}
		}

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x06020E35 RID: 134709 RVA: 0x00951B8C File Offset: 0x0094FD8C
		// (set) Token: 0x06020E36 RID: 134710 RVA: 0x00951BA0 File Offset: 0x0094FDA0
		[Nullable(2)]
		public unsafe UAnimSequence InteractAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_InteractAnim);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRunAnimal_C.__PropertyOffset_InteractAnim, value);
			}
		}

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x06020E37 RID: 134711 RVA: 0x00951BB5 File Offset: 0x0094FDB5
		// (set) Token: 0x06020E38 RID: 134712 RVA: 0x00951BC9 File Offset: 0x0094FDC9
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_SightDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_SightDirect) = value;
			}
		}

		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x06020E39 RID: 134713 RVA: 0x00951BDE File Offset: 0x0094FDDE
		// (set) Token: 0x06020E3A RID: 134714 RVA: 0x00951BEE File Offset: 0x0094FDEE
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_SightLockMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_SightLockMode) = (byte)value;
			}
		}

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x06020E3B RID: 134715 RVA: 0x00951BFF File Offset: 0x0094FDFF
		// (set) Token: 0x06020E3C RID: 134716 RVA: 0x00951C0F File Offset: 0x0094FE0F
		public unsafe int WalkRunParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_WalkRunParam);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_WalkRunParam) = value;
			}
		}

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x06020E3D RID: 134717 RVA: 0x00951C20 File Offset: 0x0094FE20
		// (set) Token: 0x06020E3E RID: 134718 RVA: 0x00951C30 File Offset: 0x0094FE30
		public unsafe float 左右跑参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_左右跑参数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_左右跑参数) = value;
			}
		}

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x06020E3F RID: 134719 RVA: 0x00951C41 File Offset: 0x0094FE41
		// (set) Token: 0x06020E40 RID: 134720 RVA: 0x00951C51 File Offset: 0x0094FE51
		public unsafe bool bHaveInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bHaveInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bHaveInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x06020E41 RID: 134721 RVA: 0x00951C62 File Offset: 0x0094FE62
		// (set) Token: 0x06020E42 RID: 134722 RVA: 0x00951C72 File Offset: 0x0094FE72
		public unsafe bool bIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bIdleAction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bIdleAction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x06020E43 RID: 134723 RVA: 0x00951C83 File Offset: 0x0094FE83
		// (set) Token: 0x06020E44 RID: 134724 RVA: 0x00951C93 File Offset: 0x0094FE93
		public unsafe bool 是否警觉
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_是否警觉) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_是否警觉) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x06020E45 RID: 134725 RVA: 0x00951CA4 File Offset: 0x0094FEA4
		// (set) Token: 0x06020E46 RID: 134726 RVA: 0x00951CB4 File Offset: 0x0094FEB4
		public unsafe bool 是否起跑转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_是否起跑转身) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_是否起跑转身) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x06020E47 RID: 134727 RVA: 0x00951CC5 File Offset: 0x0094FEC5
		// (set) Token: 0x06020E48 RID: 134728 RVA: 0x00951CD5 File Offset: 0x0094FED5
		public unsafe bool 起跑左转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_起跑左转) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_起跑左转) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x06020E49 RID: 134729 RVA: 0x00951CE6 File Offset: 0x0094FEE6
		// (set) Token: 0x06020E4A RID: 134730 RVA: 0x00951CF6 File Offset: 0x0094FEF6
		public unsafe bool bInteractAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bInteractAction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bInteractAction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x06020E4B RID: 134731 RVA: 0x00951D07 File Offset: 0x0094FF07
		// (set) Token: 0x06020E4C RID: 134732 RVA: 0x00951D17 File Offset: 0x0094FF17
		public unsafe bool 受到攻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_受到攻击) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_受到攻击) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x06020E4D RID: 134733 RVA: 0x00951D28 File Offset: 0x0094FF28
		// (set) Token: 0x06020E4E RID: 134734 RVA: 0x00951D38 File Offset: 0x0094FF38
		public unsafe bool 起飞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_起飞) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_起飞) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x06020E4F RID: 134735 RVA: 0x00951D49 File Offset: 0x0094FF49
		// (set) Token: 0x06020E50 RID: 134736 RVA: 0x00951D59 File Offset: 0x0094FF59
		public unsafe bool bSitDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bSitDown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bSitDown) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x06020E51 RID: 134737 RVA: 0x00951D6C File Offset: 0x0094FF6C
		// (set) Token: 0x06020E52 RID: 134738 RVA: 0x00951DA5 File Offset: 0x0094FFA5
		public TMap<FGameplayTag, UAnimSequence> 其他动作配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, UAnimSequence> result;
				if ((result = this._其他动作配置) == null)
				{
					result = (this._其他动作配置 = new TMap<FGameplayTag, UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_其他动作配置, this));
				}
				return result;
			}
			set
			{
				this.其他动作配置.CopyAssign(value);
			}
		}

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x06020E53 RID: 134739 RVA: 0x00951DB3 File Offset: 0x0094FFB3
		// (set) Token: 0x06020E54 RID: 134740 RVA: 0x00951DC3 File Offset: 0x0094FFC3
		public unsafe float ActionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_ActionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_ActionTime) = value;
			}
		}

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x06020E55 RID: 134741 RVA: 0x00951DD4 File Offset: 0x0094FFD4
		// (set) Token: 0x06020E56 RID: 134742 RVA: 0x00951E0D File Offset: 0x0095000D
		public TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> 材质配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> result;
				if ((result = this._材质配置) == null)
				{
					result = (this._材质配置 = new TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_材质配置, this));
				}
				return result;
			}
			set
			{
				this.材质配置.CopyAssign(value);
			}
		}

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x06020E57 RID: 134743 RVA: 0x00951E1C File Offset: 0x0095001C
		// (set) Token: 0x06020E58 RID: 134744 RVA: 0x00951E55 File Offset: 0x00950055
		public TMap<FGameplayTag, UAnimMontage> 蒙太奇表演配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, UAnimMontage> result;
				if ((result = this._蒙太奇表演配置) == null)
				{
					result = (this._蒙太奇表演配置 = new TMap<FGameplayTag, UAnimMontage>(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_蒙太奇表演配置, this));
				}
				return result;
			}
			set
			{
				this.蒙太奇表演配置.CopyAssign(value);
			}
		}

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x06020E59 RID: 134745 RVA: 0x00951E63 File Offset: 0x00950063
		// (set) Token: 0x06020E5A RID: 134746 RVA: 0x00951E73 File Offset: 0x00950073
		public unsafe bool 系统UI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_系统UI) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_系统UI) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x06020E5B RID: 134747 RVA: 0x00951E84 File Offset: 0x00950084
		// (set) Token: 0x06020E5C RID: 134748 RVA: 0x00951E94 File Offset: 0x00950094
		public unsafe bool bGetDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bGetDown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRunAnimal_C.__PropertyOffset_bGetDown) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020E5D RID: 134749 RVA: 0x00951EA8 File Offset: 0x009500A8
		[SkipLocalsInit]
		public unsafe virtual void GetCurrentActionTime(ref float ActionTime)
		{
			ABP_BaseRunAnimal_C.__GetCurrentActionTime_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__GetCurrentActionTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__GetCurrentActionTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActionTime = ActionTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr);
			ActionTime = ptr->ActionTime;
		}

		// Token: 0x06020E5E RID: 134750 RVA: 0x00951EF7 File Offset: 0x009500F7
		[SkipLocalsInit]
		public virtual void OnSystemUIStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnSystemUIStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E5F RID: 134751 RVA: 0x00951F0C File Offset: 0x0095010C
		[SkipLocalsInit]
		public unsafe virtual void OnFeedStart(FGameplayTag GameplayTag)
		{
			ABP_BaseRunAnimal_C.__OnFeedStart_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__OnFeedStart_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__OnFeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__OnFeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnFeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E60 RID: 134752 RVA: 0x00951F52 File Offset: 0x00950152
		[SkipLocalsInit]
		public virtual void 更新移动信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新移动信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020E61 RID: 134753 RVA: 0x00951F66 File Offset: 0x00950166
		[SkipLocalsInit]
		public virtual void 处理动作优先级()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__处理动作优先级_NativeFunctionPtr, null);
		}

		// Token: 0x06020E62 RID: 134754 RVA: 0x00951F7A File Offset: 0x0095017A
		[SkipLocalsInit]
		public virtual void OnUnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnUnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E63 RID: 134755 RVA: 0x00951F8E File Offset: 0x0095018E
		[SkipLocalsInit]
		public virtual void OnTakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnTakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E64 RID: 134756 RVA: 0x00951FA2 File Offset: 0x009501A2
		[SkipLocalsInit]
		public virtual void OnAlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnAlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E65 RID: 134757 RVA: 0x00951FB6 File Offset: 0x009501B6
		[SkipLocalsInit]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x06020E66 RID: 134758 RVA: 0x00951FCA File Offset: 0x009501CA
		[SkipLocalsInit]
		public virtual void OnInteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnInteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E67 RID: 134759 RVA: 0x00951FDE File Offset: 0x009501DE
		[SkipLocalsInit]
		public virtual void 更新特殊交互表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新特殊交互表演_NativeFunctionPtr, null);
		}

		// Token: 0x06020E68 RID: 134760 RVA: 0x00951FF2 File Offset: 0x009501F2
		[SkipLocalsInit]
		public virtual void 更新交互表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新交互表演_NativeFunctionPtr, null);
		}

		// Token: 0x06020E69 RID: 134761 RVA: 0x00952006 File Offset: 0x00950206
		[SkipLocalsInit]
		public virtual void OnIdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__OnIdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E6A RID: 134762 RVA: 0x0095201A File Offset: 0x0095021A
		[SkipLocalsInit]
		public virtual void 更新待机表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__更新待机表演_NativeFunctionPtr, null);
		}

		// Token: 0x06020E6B RID: 134763 RVA: 0x0095202E File Offset: 0x0095022E
		[SkipLocalsInit]
		public virtual void TakeOffEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__TakeOffEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E6C RID: 134764 RVA: 0x00952042 File Offset: 0x00950242
		[SkipLocalsInit]
		public virtual void AlertEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__AlertEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E6D RID: 134765 RVA: 0x00952056 File Offset: 0x00950256
		[SkipLocalsInit]
		public virtual void UnderAttackEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__UnderAttackEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E6E RID: 134766 RVA: 0x0095206A File Offset: 0x0095026A
		[SkipLocalsInit]
		public virtual void IdleEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__IdleEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E6F RID: 134767 RVA: 0x0095207E File Offset: 0x0095027E
		[SkipLocalsInit]
		public virtual void InteractEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__InteractEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E70 RID: 134768 RVA: 0x00952092 File Offset: 0x00950292
		[SkipLocalsInit]
		public virtual void NoneStateEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__NoneStateEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E71 RID: 134769 RVA: 0x009520A6 File Offset: 0x009502A6
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020E72 RID: 134770 RVA: 0x009520BA File Offset: 0x009502BA
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020E73 RID: 134771 RVA: 0x009520D0 File Offset: 0x009502D0
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E74 RID: 134772 RVA: 0x00952118 File Offset: 0x00950318
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E75 RID: 134773 RVA: 0x0095215E File Offset: 0x0095035E
		[SkipLocalsInit]
		public virtual void StateMachineInitializationComplete()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__StateMachineInitializationComplete_NativeFunctionPtr, null);
		}

		// Token: 0x06020E76 RID: 134774 RVA: 0x00952172 File Offset: 0x00950372
		[SkipLocalsInit]
		public virtual void NoneStateStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__NoneStateStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E77 RID: 134775 RVA: 0x00952186 File Offset: 0x00950386
		[SkipLocalsInit]
		public virtual void InteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__InteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E78 RID: 134776 RVA: 0x0095219A File Offset: 0x0095039A
		[SkipLocalsInit]
		public virtual void IdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__IdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E79 RID: 134777 RVA: 0x009521AE File Offset: 0x009503AE
		[SkipLocalsInit]
		public virtual void UnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__UnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E7A RID: 134778 RVA: 0x009521C2 File Offset: 0x009503C2
		[SkipLocalsInit]
		public virtual void AlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__AlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E7B RID: 134779 RVA: 0x009521D6 File Offset: 0x009503D6
		[SkipLocalsInit]
		public virtual void TakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__TakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E7C RID: 134780 RVA: 0x009521EC File Offset: 0x009503EC
		[SkipLocalsInit]
		public unsafe virtual void FeedStart(FGameplayTag GameplayTag)
		{
			ABP_BaseRunAnimal_C.__FeedStart_FunctionParams* ptr = stackalloc ABP_BaseRunAnimal_C.__FeedStart_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseRunAnimal_C.__FeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRunAnimal_C.__FeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__FeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E7D RID: 134781 RVA: 0x00952232 File Offset: 0x00950432
		[SkipLocalsInit]
		public virtual void SystemUiStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__SystemUiStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E7E RID: 134782 RVA: 0x00952246 File Offset: 0x00950446
		[SkipLocalsInit]
		public virtual void SystemUiEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRunAnimal_C.__SystemUiEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E7F RID: 134783 RVA: 0x0095225A File Offset: 0x0095045A
		protected ABP_BaseRunAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CCF RID: 72911
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/ABP_BaseRunAnimal.ABP_BaseRunAnimal_C";

		// Token: 0x04011CD0 RID: 72912
		private static IntPtr _ClassPtr;

		// Token: 0x04011CD1 RID: 72913
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011CD2 RID: 72914
		internal static int __PropertyOffset_待机表演配置;

		// Token: 0x04011CD3 RID: 72915
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _待机表演配置;

		// Token: 0x04011CD4 RID: 72916
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011CD5 RID: 72917
		internal static int __PropertyOffset_角色网格体;

		// Token: 0x04011CD6 RID: 72918
		internal static int __PropertyOffset_生态表现状态;

		// Token: 0x04011CD7 RID: 72919
		internal static int __PropertyOffset_状态机初始化;

		// Token: 0x04011CD8 RID: 72920
		internal static int __PropertyOffset_IdleActionIndex;

		// Token: 0x04011CD9 RID: 72921
		internal static int __PropertyOffset_IdleAnim;

		// Token: 0x04011CDA RID: 72922
		internal static int __PropertyOffset_交互表演配置;

		// Token: 0x04011CDB RID: 72923
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _交互表演配置;

		// Token: 0x04011CDC RID: 72924
		internal static int __PropertyOffset_InteractActionIndex;

		// Token: 0x04011CDD RID: 72925
		internal static int __PropertyOffset_InteractAnim;

		// Token: 0x04011CDE RID: 72926
		internal static int __PropertyOffset_SightDirect;

		// Token: 0x04011CDF RID: 72927
		internal static int __PropertyOffset_SightLockMode;

		// Token: 0x04011CE0 RID: 72928
		internal static int __PropertyOffset_WalkRunParam;

		// Token: 0x04011CE1 RID: 72929
		internal static int __PropertyOffset_左右跑参数;

		// Token: 0x04011CE2 RID: 72930
		internal static int __PropertyOffset_bHaveInput;

		// Token: 0x04011CE3 RID: 72931
		internal static int __PropertyOffset_bIdleAction;

		// Token: 0x04011CE4 RID: 72932
		internal static int __PropertyOffset_是否警觉;

		// Token: 0x04011CE5 RID: 72933
		internal static int __PropertyOffset_是否起跑转身;

		// Token: 0x04011CE6 RID: 72934
		internal static int __PropertyOffset_起跑左转;

		// Token: 0x04011CE7 RID: 72935
		internal static int __PropertyOffset_bInteractAction;

		// Token: 0x04011CE8 RID: 72936
		internal static int __PropertyOffset_受到攻击;

		// Token: 0x04011CE9 RID: 72937
		internal static int __PropertyOffset_起飞;

		// Token: 0x04011CEA RID: 72938
		internal static int __PropertyOffset_bSitDown;

		// Token: 0x04011CEB RID: 72939
		internal static int __PropertyOffset_其他动作配置;

		// Token: 0x04011CEC RID: 72940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, UAnimSequence> _其他动作配置;

		// Token: 0x04011CED RID: 72941
		internal static int __PropertyOffset_ActionTime;

		// Token: 0x04011CEE RID: 72942
		internal static int __PropertyOffset_材质配置;

		// Token: 0x04011CEF RID: 72943
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> _材质配置;

		// Token: 0x04011CF0 RID: 72944
		internal static int __PropertyOffset_蒙太奇表演配置;

		// Token: 0x04011CF1 RID: 72945
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, UAnimMontage> _蒙太奇表演配置;

		// Token: 0x04011CF2 RID: 72946
		internal static int __PropertyOffset_系统UI;

		// Token: 0x04011CF3 RID: 72947
		internal static int __PropertyOffset_bGetDown;

		// Token: 0x04011CF4 RID: 72948
		private static IntPtr __GetCurrentActionTime_NativeFunctionPtr;

		// Token: 0x04011CF5 RID: 72949
		private static IntPtr __OnSystemUIStart_NativeFunctionPtr;

		// Token: 0x04011CF6 RID: 72950
		private static IntPtr __OnFeedStart_NativeFunctionPtr;

		// Token: 0x04011CF7 RID: 72951
		private static IntPtr __更新移动信息_NativeFunctionPtr;

		// Token: 0x04011CF8 RID: 72952
		private static IntPtr __处理动作优先级_NativeFunctionPtr;

		// Token: 0x04011CF9 RID: 72953
		private static IntPtr __OnUnderAttackStart_NativeFunctionPtr;

		// Token: 0x04011CFA RID: 72954
		private static IntPtr __OnTakeOffStart_NativeFunctionPtr;

		// Token: 0x04011CFB RID: 72955
		private static IntPtr __OnAlertStart_NativeFunctionPtr;

		// Token: 0x04011CFC RID: 72956
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04011CFD RID: 72957
		private static IntPtr __OnInteractStart_NativeFunctionPtr;

		// Token: 0x04011CFE RID: 72958
		private static IntPtr __更新特殊交互表演_NativeFunctionPtr;

		// Token: 0x04011CFF RID: 72959
		private static IntPtr __更新交互表演_NativeFunctionPtr;

		// Token: 0x04011D00 RID: 72960
		private static IntPtr __OnIdleStart_NativeFunctionPtr;

		// Token: 0x04011D01 RID: 72961
		private static IntPtr __更新待机表演_NativeFunctionPtr;

		// Token: 0x04011D02 RID: 72962
		private static IntPtr __TakeOffEnd_NativeFunctionPtr;

		// Token: 0x04011D03 RID: 72963
		private static IntPtr __AlertEnd_NativeFunctionPtr;

		// Token: 0x04011D04 RID: 72964
		private static IntPtr __UnderAttackEnd_NativeFunctionPtr;

		// Token: 0x04011D05 RID: 72965
		private static IntPtr __IdleEnd_NativeFunctionPtr;

		// Token: 0x04011D06 RID: 72966
		private static IntPtr __InteractEnd_NativeFunctionPtr;

		// Token: 0x04011D07 RID: 72967
		private static IntPtr __NoneStateEnd_NativeFunctionPtr;

		// Token: 0x04011D08 RID: 72968
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04011D09 RID: 72969
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011D0A RID: 72970
		private static IntPtr __StateMachineInitializationComplete_NativeFunctionPtr;

		// Token: 0x04011D0B RID: 72971
		private static IntPtr __NoneStateStart_NativeFunctionPtr;

		// Token: 0x04011D0C RID: 72972
		private static IntPtr __InteractStart_NativeFunctionPtr;

		// Token: 0x04011D0D RID: 72973
		private static IntPtr __IdleStart_NativeFunctionPtr;

		// Token: 0x04011D0E RID: 72974
		private static IntPtr __UnderAttackStart_NativeFunctionPtr;

		// Token: 0x04011D0F RID: 72975
		private static IntPtr __AlertStart_NativeFunctionPtr;

		// Token: 0x04011D10 RID: 72976
		private static IntPtr __TakeOffStart_NativeFunctionPtr;

		// Token: 0x04011D11 RID: 72977
		private static IntPtr __FeedStart_NativeFunctionPtr;

		// Token: 0x04011D12 RID: 72978
		private static IntPtr __SystemUiStart_NativeFunctionPtr;

		// Token: 0x04011D13 RID: 72979
		private static IntPtr __SystemUiEnd_NativeFunctionPtr;

		// Token: 0x02008FE3 RID: 36835
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentActionTime_FunctionParams
		{
			// Token: 0x0402CD92 RID: 183698
			[FieldOffset(0)]
			public float ActionTime;
		}

		// Token: 0x02008FE4 RID: 36836
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnFeedStart_FunctionParams
		{
			// Token: 0x0402CD93 RID: 183699
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}

		// Token: 0x02008FE5 RID: 36837
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD94 RID: 183700
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x02008FE6 RID: 36838
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FeedStart_FunctionParams
		{
			// Token: 0x0402CD95 RID: 183701
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}
	}
}
