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
	// Token: 0x020032BE RID: 12990
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/ABP_BaseAnimal.ABP_BaseAnimal_C")]
	[UnrealStructLayout(18944, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18931)]
	public class ABP_BaseAnimal_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_AnimalEcological_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020DBE RID: 134590 RVA: 0x00951063 File Offset: 0x0094F263
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/ABP_BaseAnimal.ABP_BaseAnimal_C");
			}
			return ABP_BaseAnimal_C._ClassPtr;
		}

		// Token: 0x06020DBF RID: 134591 RVA: 0x00951088 File Offset: 0x0094F288
		public ABP_BaseAnimal_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020DC0 RID: 134592 RVA: 0x009510B0 File Offset: 0x0094F2B0
		public ABP_BaseAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700417F RID: 16767
		// (get) Token: 0x06020DC1 RID: 134593 RVA: 0x009510E4 File Offset: 0x0094F2E4
		// (set) Token: 0x06020DC2 RID: 134594 RVA: 0x0095111D File Offset: 0x0094F31D
		public TArray<UAnimSequence> 待机表演配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimSequence> result;
				if ((result = this._待机表演配置) == null)
				{
					result = (this._待机表演配置 = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_待机表演配置, this));
				}
				return result;
			}
			set
			{
				this.待机表演配置.CopyAssign(value);
			}
		}

		// Token: 0x17004180 RID: 16768
		// (get) Token: 0x06020DC3 RID: 134595 RVA: 0x0095112B File Offset: 0x0094F32B
		// (set) Token: 0x06020DC4 RID: 134596 RVA: 0x0095113F File Offset: 0x0094F33F
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x17004181 RID: 16769
		// (get) Token: 0x06020DC5 RID: 134597 RVA: 0x00951154 File Offset: 0x0094F354
		// (set) Token: 0x06020DC6 RID: 134598 RVA: 0x00951168 File Offset: 0x0094F368
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色网格体
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_角色网格体);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_角色网格体, value);
			}
		}

		// Token: 0x17004182 RID: 16770
		// (get) Token: 0x06020DC7 RID: 134599 RVA: 0x0095117D File Offset: 0x0094F37D
		// (set) Token: 0x06020DC8 RID: 134600 RVA: 0x00951191 File Offset: 0x0094F391
		[Nullable(0)]
		public unsafe TEnumAsByte<EAnimalEcologicalState> 生态表现状态
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_生态表现状态);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_生态表现状态) = value;
			}
		}

		// Token: 0x17004183 RID: 16771
		// (get) Token: 0x06020DC9 RID: 134601 RVA: 0x009511A6 File Offset: 0x0094F3A6
		// (set) Token: 0x06020DCA RID: 134602 RVA: 0x009511B6 File Offset: 0x0094F3B6
		public unsafe bool 状态机初始化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_状态机初始化) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_状态机初始化) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004184 RID: 16772
		// (get) Token: 0x06020DCB RID: 134603 RVA: 0x009511C7 File Offset: 0x0094F3C7
		// (set) Token: 0x06020DCC RID: 134604 RVA: 0x009511D7 File Offset: 0x0094F3D7
		public unsafe int IdleActionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_IdleActionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_IdleActionIndex) = value;
			}
		}

		// Token: 0x17004185 RID: 16773
		// (get) Token: 0x06020DCD RID: 134605 RVA: 0x009511E8 File Offset: 0x0094F3E8
		// (set) Token: 0x06020DCE RID: 134606 RVA: 0x009511FC File Offset: 0x0094F3FC
		[Nullable(2)]
		public unsafe UAnimSequence IdleAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_IdleAnim);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_IdleAnim, value);
			}
		}

		// Token: 0x17004186 RID: 16774
		// (get) Token: 0x06020DCF RID: 134607 RVA: 0x00951214 File Offset: 0x0094F414
		// (set) Token: 0x06020DD0 RID: 134608 RVA: 0x0095124D File Offset: 0x0094F44D
		public TArray<UAnimSequence> 交互表演配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimSequence> result;
				if ((result = this._交互表演配置) == null)
				{
					result = (this._交互表演配置 = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_交互表演配置, this));
				}
				return result;
			}
			set
			{
				this.交互表演配置.CopyAssign(value);
			}
		}

		// Token: 0x17004187 RID: 16775
		// (get) Token: 0x06020DD1 RID: 134609 RVA: 0x0095125B File Offset: 0x0094F45B
		// (set) Token: 0x06020DD2 RID: 134610 RVA: 0x0095126B File Offset: 0x0094F46B
		public unsafe int InteractActionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_InteractActionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_InteractActionIndex) = value;
			}
		}

		// Token: 0x17004188 RID: 16776
		// (get) Token: 0x06020DD3 RID: 134611 RVA: 0x0095127C File Offset: 0x0094F47C
		// (set) Token: 0x06020DD4 RID: 134612 RVA: 0x00951290 File Offset: 0x0094F490
		[Nullable(2)]
		public unsafe UAnimSequence InteractAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_InteractAnim);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseAnimal_C.__PropertyOffset_InteractAnim, value);
			}
		}

		// Token: 0x17004189 RID: 16777
		// (get) Token: 0x06020DD5 RID: 134613 RVA: 0x009512A5 File Offset: 0x0094F4A5
		// (set) Token: 0x06020DD6 RID: 134614 RVA: 0x009512B9 File Offset: 0x0094F4B9
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_SightDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_SightDirect) = value;
			}
		}

		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x06020DD7 RID: 134615 RVA: 0x009512CE File Offset: 0x0094F4CE
		// (set) Token: 0x06020DD8 RID: 134616 RVA: 0x009512DE File Offset: 0x0094F4DE
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_SightLockMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_SightLockMode) = (byte)value;
			}
		}

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x06020DD9 RID: 134617 RVA: 0x009512EF File Offset: 0x0094F4EF
		// (set) Token: 0x06020DDA RID: 134618 RVA: 0x009512FF File Offset: 0x0094F4FF
		public unsafe int WalkRunParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_WalkRunParam);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_WalkRunParam) = value;
			}
		}

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x06020DDB RID: 134619 RVA: 0x00951310 File Offset: 0x0094F510
		// (set) Token: 0x06020DDC RID: 134620 RVA: 0x00951320 File Offset: 0x0094F520
		public unsafe float 左右跑参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_左右跑参数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_左右跑参数) = value;
			}
		}

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x06020DDD RID: 134621 RVA: 0x00951331 File Offset: 0x0094F531
		// (set) Token: 0x06020DDE RID: 134622 RVA: 0x00951341 File Offset: 0x0094F541
		public unsafe bool bHaveInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bHaveInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bHaveInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x06020DDF RID: 134623 RVA: 0x00951352 File Offset: 0x0094F552
		// (set) Token: 0x06020DE0 RID: 134624 RVA: 0x00951362 File Offset: 0x0094F562
		public unsafe bool bIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bIdleAction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bIdleAction) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x06020DE1 RID: 134625 RVA: 0x00951373 File Offset: 0x0094F573
		// (set) Token: 0x06020DE2 RID: 134626 RVA: 0x00951383 File Offset: 0x0094F583
		public unsafe bool 是否警觉
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_是否警觉) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_是否警觉) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x06020DE3 RID: 134627 RVA: 0x00951394 File Offset: 0x0094F594
		// (set) Token: 0x06020DE4 RID: 134628 RVA: 0x009513A4 File Offset: 0x0094F5A4
		public unsafe bool 是否起跑转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_是否起跑转身) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_是否起跑转身) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004191 RID: 16785
		// (get) Token: 0x06020DE5 RID: 134629 RVA: 0x009513B5 File Offset: 0x0094F5B5
		// (set) Token: 0x06020DE6 RID: 134630 RVA: 0x009513C5 File Offset: 0x0094F5C5
		public unsafe bool 起跑左转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_起跑左转) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_起跑左转) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004192 RID: 16786
		// (get) Token: 0x06020DE7 RID: 134631 RVA: 0x009513D6 File Offset: 0x0094F5D6
		// (set) Token: 0x06020DE8 RID: 134632 RVA: 0x009513E6 File Offset: 0x0094F5E6
		public unsafe bool bInteractAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bInteractAction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bInteractAction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x06020DE9 RID: 134633 RVA: 0x009513F7 File Offset: 0x0094F5F7
		// (set) Token: 0x06020DEA RID: 134634 RVA: 0x00951407 File Offset: 0x0094F607
		public unsafe bool 受到攻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_受到攻击) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_受到攻击) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x06020DEB RID: 134635 RVA: 0x00951418 File Offset: 0x0094F618
		// (set) Token: 0x06020DEC RID: 134636 RVA: 0x00951428 File Offset: 0x0094F628
		public unsafe bool 起飞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_起飞) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_起飞) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x06020DED RID: 134637 RVA: 0x00951439 File Offset: 0x0094F639
		// (set) Token: 0x06020DEE RID: 134638 RVA: 0x00951449 File Offset: 0x0094F649
		public unsafe bool bSitDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bSitDown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bSitDown) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x06020DEF RID: 134639 RVA: 0x0095145C File Offset: 0x0094F65C
		// (set) Token: 0x06020DF0 RID: 134640 RVA: 0x00951495 File Offset: 0x0094F695
		public TMap<FGameplayTag, UAnimSequence> 其他动作配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, UAnimSequence> result;
				if ((result = this._其他动作配置) == null)
				{
					result = (this._其他动作配置 = new TMap<FGameplayTag, UAnimSequence>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_其他动作配置, this));
				}
				return result;
			}
			set
			{
				this.其他动作配置.CopyAssign(value);
			}
		}

		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x06020DF1 RID: 134641 RVA: 0x009514A3 File Offset: 0x0094F6A3
		// (set) Token: 0x06020DF2 RID: 134642 RVA: 0x009514B3 File Offset: 0x0094F6B3
		public unsafe float ActionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_ActionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_ActionTime) = value;
			}
		}

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x06020DF3 RID: 134643 RVA: 0x009514C4 File Offset: 0x0094F6C4
		// (set) Token: 0x06020DF4 RID: 134644 RVA: 0x009514FD File Offset: 0x0094F6FD
		public TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> 材质配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> result;
				if ((result = this._材质配置) == null)
				{
					result = (this._材质配置 = new TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_材质配置, this));
				}
				return result;
			}
			set
			{
				this.材质配置.CopyAssign(value);
			}
		}

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x06020DF5 RID: 134645 RVA: 0x0095150C File Offset: 0x0094F70C
		// (set) Token: 0x06020DF6 RID: 134646 RVA: 0x00951545 File Offset: 0x0094F745
		public TMap<FGameplayTag, UAnimMontage> 蒙太奇表演配置
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, UAnimMontage> result;
				if ((result = this._蒙太奇表演配置) == null)
				{
					result = (this._蒙太奇表演配置 = new TMap<FGameplayTag, UAnimMontage>(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_蒙太奇表演配置, this));
				}
				return result;
			}
			set
			{
				this.蒙太奇表演配置.CopyAssign(value);
			}
		}

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x06020DF7 RID: 134647 RVA: 0x00951553 File Offset: 0x0094F753
		// (set) Token: 0x06020DF8 RID: 134648 RVA: 0x00951563 File Offset: 0x0094F763
		public unsafe bool 支持急转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_支持急转身) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_支持急转身) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x06020DF9 RID: 134649 RVA: 0x00951574 File Offset: 0x0094F774
		// (set) Token: 0x06020DFA RID: 134650 RVA: 0x00951584 File Offset: 0x0094F784
		public unsafe bool 系统UI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_系统UI) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_系统UI) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x06020DFB RID: 134651 RVA: 0x00951595 File Offset: 0x0094F795
		// (set) Token: 0x06020DFC RID: 134652 RVA: 0x009515A5 File Offset: 0x0094F7A5
		public unsafe bool bGetDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bGetDown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseAnimal_C.__PropertyOffset_bGetDown) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020DFD RID: 134653 RVA: 0x009515B8 File Offset: 0x0094F7B8
		[SkipLocalsInit]
		public unsafe virtual void GetCurrentActionTime(ref float ActionTime)
		{
			ABP_BaseAnimal_C.__GetCurrentActionTime_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__GetCurrentActionTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseAnimal_C.__GetCurrentActionTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActionTime = ActionTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr);
			ActionTime = ptr->ActionTime;
		}

		// Token: 0x06020DFE RID: 134654 RVA: 0x00951607 File Offset: 0x0094F807
		[SkipLocalsInit]
		public virtual void OnSystemUIStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnSystemUIStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020DFF RID: 134655 RVA: 0x0095161C File Offset: 0x0094F81C
		[SkipLocalsInit]
		public unsafe virtual void OnFeedStart(FGameplayTag GameplayTag)
		{
			ABP_BaseAnimal_C.__OnFeedStart_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__OnFeedStart_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseAnimal_C.__OnFeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__OnFeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnFeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E00 RID: 134656 RVA: 0x00951662 File Offset: 0x0094F862
		[SkipLocalsInit]
		public virtual void 更新移动信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新移动信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020E01 RID: 134657 RVA: 0x00951676 File Offset: 0x0094F876
		[SkipLocalsInit]
		public virtual void 处理动作优先级()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__处理动作优先级_NativeFunctionPtr, null);
		}

		// Token: 0x06020E02 RID: 134658 RVA: 0x0095168A File Offset: 0x0094F88A
		[SkipLocalsInit]
		public virtual void OnUnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnUnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E03 RID: 134659 RVA: 0x0095169E File Offset: 0x0094F89E
		[SkipLocalsInit]
		public virtual void OnTakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnTakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E04 RID: 134660 RVA: 0x009516B2 File Offset: 0x0094F8B2
		[SkipLocalsInit]
		public virtual void OnAlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnAlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E05 RID: 134661 RVA: 0x009516C6 File Offset: 0x0094F8C6
		[SkipLocalsInit]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x06020E06 RID: 134662 RVA: 0x009516DA File Offset: 0x0094F8DA
		[SkipLocalsInit]
		public virtual void OnInteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnInteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E07 RID: 134663 RVA: 0x009516EE File Offset: 0x0094F8EE
		[SkipLocalsInit]
		public virtual void 更新特殊交互表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新特殊交互表演_NativeFunctionPtr, null);
		}

		// Token: 0x06020E08 RID: 134664 RVA: 0x00951702 File Offset: 0x0094F902
		[SkipLocalsInit]
		public virtual void 更新交互表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新交互表演_NativeFunctionPtr, null);
		}

		// Token: 0x06020E09 RID: 134665 RVA: 0x00951716 File Offset: 0x0094F916
		[SkipLocalsInit]
		public virtual void OnIdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__OnIdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E0A RID: 134666 RVA: 0x0095172A File Offset: 0x0094F92A
		[SkipLocalsInit]
		public virtual void 更新待机表演()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__更新待机表演_NativeFunctionPtr, null);
		}

		// Token: 0x06020E0B RID: 134667 RVA: 0x0095173E File Offset: 0x0094F93E
		[SkipLocalsInit]
		public virtual void AlertEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__AlertEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E0C RID: 134668 RVA: 0x00951752 File Offset: 0x0094F952
		[SkipLocalsInit]
		public virtual void TakeOffEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__TakeOffEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E0D RID: 134669 RVA: 0x00951766 File Offset: 0x0094F966
		[SkipLocalsInit]
		public virtual void UnderAttackEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__UnderAttackEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E0E RID: 134670 RVA: 0x0095177A File Offset: 0x0094F97A
		[SkipLocalsInit]
		public virtual void IdleEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__IdleEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E0F RID: 134671 RVA: 0x0095178E File Offset: 0x0094F98E
		[SkipLocalsInit]
		public virtual void InteractEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__InteractEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E10 RID: 134672 RVA: 0x009517A2 File Offset: 0x0094F9A2
		[SkipLocalsInit]
		public virtual void NoneStateEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__NoneStateEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E11 RID: 134673 RVA: 0x009517B6 File Offset: 0x0094F9B6
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020E12 RID: 134674 RVA: 0x009517CA File Offset: 0x0094F9CA
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020E13 RID: 134675 RVA: 0x009517E0 File Offset: 0x0094F9E0
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E14 RID: 134676 RVA: 0x00951828 File Offset: 0x0094FA28
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E15 RID: 134677 RVA: 0x0095186E File Offset: 0x0094FA6E
		[SkipLocalsInit]
		public virtual void StateMachineInitializationComplete()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__StateMachineInitializationComplete_NativeFunctionPtr, null);
		}

		// Token: 0x06020E16 RID: 134678 RVA: 0x00951882 File Offset: 0x0094FA82
		[SkipLocalsInit]
		public virtual void NoneStateStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__NoneStateStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E17 RID: 134679 RVA: 0x00951896 File Offset: 0x0094FA96
		[SkipLocalsInit]
		public virtual void InteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__InteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E18 RID: 134680 RVA: 0x009518AA File Offset: 0x0094FAAA
		[SkipLocalsInit]
		public virtual void IdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__IdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E19 RID: 134681 RVA: 0x009518BE File Offset: 0x0094FABE
		[SkipLocalsInit]
		public virtual void UnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__UnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E1A RID: 134682 RVA: 0x009518D2 File Offset: 0x0094FAD2
		[SkipLocalsInit]
		public virtual void AlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__AlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E1B RID: 134683 RVA: 0x009518E6 File Offset: 0x0094FAE6
		[SkipLocalsInit]
		public virtual void TakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__TakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E1C RID: 134684 RVA: 0x009518FC File Offset: 0x0094FAFC
		[SkipLocalsInit]
		public unsafe virtual void FeedStart(FGameplayTag GameplayTag)
		{
			ABP_BaseAnimal_C.__FeedStart_FunctionParams* ptr = stackalloc ABP_BaseAnimal_C.__FeedStart_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_BaseAnimal_C.__FeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseAnimal_C.__FeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__FeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E1D RID: 134685 RVA: 0x00951942 File Offset: 0x0094FB42
		[SkipLocalsInit]
		public virtual void SystemUiStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__SystemUiStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E1E RID: 134686 RVA: 0x00951956 File Offset: 0x0094FB56
		[SkipLocalsInit]
		public virtual void SystemUiEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseAnimal_C.__SystemUiEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E1F RID: 134687 RVA: 0x0095196A File Offset: 0x0094FB6A
		protected ABP_BaseAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C89 RID: 72841
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/ABP_BaseAnimal.ABP_BaseAnimal_C";

		// Token: 0x04011C8A RID: 72842
		private static IntPtr _ClassPtr;

		// Token: 0x04011C8B RID: 72843
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C8C RID: 72844
		internal static int __PropertyOffset_待机表演配置;

		// Token: 0x04011C8D RID: 72845
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _待机表演配置;

		// Token: 0x04011C8E RID: 72846
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011C8F RID: 72847
		internal static int __PropertyOffset_角色网格体;

		// Token: 0x04011C90 RID: 72848
		internal static int __PropertyOffset_生态表现状态;

		// Token: 0x04011C91 RID: 72849
		internal static int __PropertyOffset_状态机初始化;

		// Token: 0x04011C92 RID: 72850
		internal static int __PropertyOffset_IdleActionIndex;

		// Token: 0x04011C93 RID: 72851
		internal static int __PropertyOffset_IdleAnim;

		// Token: 0x04011C94 RID: 72852
		internal static int __PropertyOffset_交互表演配置;

		// Token: 0x04011C95 RID: 72853
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _交互表演配置;

		// Token: 0x04011C96 RID: 72854
		internal static int __PropertyOffset_InteractActionIndex;

		// Token: 0x04011C97 RID: 72855
		internal static int __PropertyOffset_InteractAnim;

		// Token: 0x04011C98 RID: 72856
		internal static int __PropertyOffset_SightDirect;

		// Token: 0x04011C99 RID: 72857
		internal static int __PropertyOffset_SightLockMode;

		// Token: 0x04011C9A RID: 72858
		internal static int __PropertyOffset_WalkRunParam;

		// Token: 0x04011C9B RID: 72859
		internal static int __PropertyOffset_左右跑参数;

		// Token: 0x04011C9C RID: 72860
		internal static int __PropertyOffset_bHaveInput;

		// Token: 0x04011C9D RID: 72861
		internal static int __PropertyOffset_bIdleAction;

		// Token: 0x04011C9E RID: 72862
		internal static int __PropertyOffset_是否警觉;

		// Token: 0x04011C9F RID: 72863
		internal static int __PropertyOffset_是否起跑转身;

		// Token: 0x04011CA0 RID: 72864
		internal static int __PropertyOffset_起跑左转;

		// Token: 0x04011CA1 RID: 72865
		internal static int __PropertyOffset_bInteractAction;

		// Token: 0x04011CA2 RID: 72866
		internal static int __PropertyOffset_受到攻击;

		// Token: 0x04011CA3 RID: 72867
		internal static int __PropertyOffset_起飞;

		// Token: 0x04011CA4 RID: 72868
		internal static int __PropertyOffset_bSitDown;

		// Token: 0x04011CA5 RID: 72869
		internal static int __PropertyOffset_其他动作配置;

		// Token: 0x04011CA6 RID: 72870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, UAnimSequence> _其他动作配置;

		// Token: 0x04011CA7 RID: 72871
		internal static int __PropertyOffset_ActionTime;

		// Token: 0x04011CA8 RID: 72872
		internal static int __PropertyOffset_材质配置;

		// Token: 0x04011CA9 RID: 72873
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> _材质配置;

		// Token: 0x04011CAA RID: 72874
		internal static int __PropertyOffset_蒙太奇表演配置;

		// Token: 0x04011CAB RID: 72875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, UAnimMontage> _蒙太奇表演配置;

		// Token: 0x04011CAC RID: 72876
		internal static int __PropertyOffset_支持急转身;

		// Token: 0x04011CAD RID: 72877
		internal static int __PropertyOffset_系统UI;

		// Token: 0x04011CAE RID: 72878
		internal static int __PropertyOffset_bGetDown;

		// Token: 0x04011CAF RID: 72879
		private static IntPtr __GetCurrentActionTime_NativeFunctionPtr;

		// Token: 0x04011CB0 RID: 72880
		private static IntPtr __OnSystemUIStart_NativeFunctionPtr;

		// Token: 0x04011CB1 RID: 72881
		private static IntPtr __OnFeedStart_NativeFunctionPtr;

		// Token: 0x04011CB2 RID: 72882
		private static IntPtr __更新移动信息_NativeFunctionPtr;

		// Token: 0x04011CB3 RID: 72883
		private static IntPtr __处理动作优先级_NativeFunctionPtr;

		// Token: 0x04011CB4 RID: 72884
		private static IntPtr __OnUnderAttackStart_NativeFunctionPtr;

		// Token: 0x04011CB5 RID: 72885
		private static IntPtr __OnTakeOffStart_NativeFunctionPtr;

		// Token: 0x04011CB6 RID: 72886
		private static IntPtr __OnAlertStart_NativeFunctionPtr;

		// Token: 0x04011CB7 RID: 72887
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04011CB8 RID: 72888
		private static IntPtr __OnInteractStart_NativeFunctionPtr;

		// Token: 0x04011CB9 RID: 72889
		private static IntPtr __更新特殊交互表演_NativeFunctionPtr;

		// Token: 0x04011CBA RID: 72890
		private static IntPtr __更新交互表演_NativeFunctionPtr;

		// Token: 0x04011CBB RID: 72891
		private static IntPtr __OnIdleStart_NativeFunctionPtr;

		// Token: 0x04011CBC RID: 72892
		private static IntPtr __更新待机表演_NativeFunctionPtr;

		// Token: 0x04011CBD RID: 72893
		private static IntPtr __AlertEnd_NativeFunctionPtr;

		// Token: 0x04011CBE RID: 72894
		private static IntPtr __TakeOffEnd_NativeFunctionPtr;

		// Token: 0x04011CBF RID: 72895
		private static IntPtr __UnderAttackEnd_NativeFunctionPtr;

		// Token: 0x04011CC0 RID: 72896
		private static IntPtr __IdleEnd_NativeFunctionPtr;

		// Token: 0x04011CC1 RID: 72897
		private static IntPtr __InteractEnd_NativeFunctionPtr;

		// Token: 0x04011CC2 RID: 72898
		private static IntPtr __NoneStateEnd_NativeFunctionPtr;

		// Token: 0x04011CC3 RID: 72899
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04011CC4 RID: 72900
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011CC5 RID: 72901
		private static IntPtr __StateMachineInitializationComplete_NativeFunctionPtr;

		// Token: 0x04011CC6 RID: 72902
		private static IntPtr __NoneStateStart_NativeFunctionPtr;

		// Token: 0x04011CC7 RID: 72903
		private static IntPtr __InteractStart_NativeFunctionPtr;

		// Token: 0x04011CC8 RID: 72904
		private static IntPtr __IdleStart_NativeFunctionPtr;

		// Token: 0x04011CC9 RID: 72905
		private static IntPtr __UnderAttackStart_NativeFunctionPtr;

		// Token: 0x04011CCA RID: 72906
		private static IntPtr __AlertStart_NativeFunctionPtr;

		// Token: 0x04011CCB RID: 72907
		private static IntPtr __TakeOffStart_NativeFunctionPtr;

		// Token: 0x04011CCC RID: 72908
		private static IntPtr __FeedStart_NativeFunctionPtr;

		// Token: 0x04011CCD RID: 72909
		private static IntPtr __SystemUiStart_NativeFunctionPtr;

		// Token: 0x04011CCE RID: 72910
		private static IntPtr __SystemUiEnd_NativeFunctionPtr;

		// Token: 0x02008FDF RID: 36831
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentActionTime_FunctionParams
		{
			// Token: 0x0402CD8E RID: 183694
			[FieldOffset(0)]
			public float ActionTime;
		}

		// Token: 0x02008FE0 RID: 36832
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnFeedStart_FunctionParams
		{
			// Token: 0x0402CD8F RID: 183695
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}

		// Token: 0x02008FE1 RID: 36833
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD90 RID: 183696
			[FieldOffset(0)]
			public float DeltaTimeX;
		}

		// Token: 0x02008FE2 RID: 36834
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FeedStart_FunctionParams
		{
			// Token: 0x0402CD91 RID: 183697
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}
	}
}
