using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000121 RID: 289
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateConcomitantInherit.TsAnimNotifyStateConcomitantInherit_C")]
public class TsAnimNotifyStateConcomitantInherit : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x0600115F RID: 4447 RVA: 0x000632A7 File Offset: 0x000614A7
	// (set) Token: 0x06001160 RID: 4448 RVA: 0x000632B7 File Offset: 0x000614B7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 技能打断
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_技能打断) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_技能打断) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x06001161 RID: 4449 RVA: 0x000632C8 File Offset: 0x000614C8
	// (set) Token: 0x06001162 RID: 4450 RVA: 0x000632D8 File Offset: 0x000614D8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 受击打断
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_受击打断) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_受击打断) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x06001163 RID: 4451 RVA: 0x000632E9 File Offset: 0x000614E9
	// (set) Token: 0x06001164 RID: 4452 RVA: 0x000632F9 File Offset: 0x000614F9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 其他打断
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_其他打断) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_其他打断) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x06001165 RID: 4453 RVA: 0x0006330C File Offset: 0x0006150C
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<long> 技能Id
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TArray<long> result;
			if ((result = this._技能Id) == null)
			{
				result = (this._技能Id = new TArray<long>(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_技能Id, this));
			}
			return result;
		}
	}

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x06001166 RID: 4454 RVA: 0x00063345 File Offset: 0x00061545
	// (set) Token: 0x06001167 RID: 4455 RVA: 0x00063355 File Offset: 0x00061555
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long 开始特效
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_开始特效);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_开始特效) = value;
		}
	}

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x06001168 RID: 4456 RVA: 0x00063366 File Offset: 0x00061566
	// (set) Token: 0x06001169 RID: 4457 RVA: 0x00063376 File Offset: 0x00061576
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long 结束特效
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_结束特效);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_结束特效) = value;
		}
	}

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x0600116A RID: 4458 RVA: 0x00063387 File Offset: 0x00061587
	// (set) Token: 0x0600116B RID: 4459 RVA: 0x00063397 File Offset: 0x00061597
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EConcomitantDurationType 持续时间类型
	{
		get
		{
			return (EConcomitantDurationType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_持续时间类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_持续时间类型) = (byte)value;
		}
	}

	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x0600116C RID: 4460 RVA: 0x000633A8 File Offset: 0x000615A8
	// (set) Token: 0x0600116D RID: 4461 RVA: 0x000633B8 File Offset: 0x000615B8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 持续时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_持续时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_持续时间) = value;
		}
	}

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x0600116E RID: 4462 RVA: 0x000633C9 File Offset: 0x000615C9
	// (set) Token: 0x0600116F RID: 4463 RVA: 0x000633D9 File Offset: 0x000615D9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int 伴生物编号
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_伴生物编号);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_伴生物编号) = value;
		}
	}

	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x06001170 RID: 4464 RVA: 0x000633EA File Offset: 0x000615EA
	// (set) Token: 0x06001171 RID: 4465 RVA: 0x000633FA File Offset: 0x000615FA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long BuffId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_BuffId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateConcomitantInherit.__PropertyOffset_BuffId) = value;
		}
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x0006340C File Offset: 0x0006160C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateConcomitantInherit) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateConcomitantInherit.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x000634CC File Offset: 0x000616CC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			Entity entity;
			if (tsBaseCharacter == null)
			{
				entity = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			Entity entity2 = entity;
			if (entity2 == null)
			{
				return false;
			}
			CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, entity2, "TsAnimNotifyStateConcomitantInherit K2_NotifyBegin", default(ReadOnlySpan<ValueTuple<string, object>>));
			CreatureDataComponent component = entity2.GetComponent<CreatureDataComponent>();
			long? num = (component != null) ? new long?(component.GetSummonerId()) : null;
			if (num != null && num.Value != 0L)
			{
				return false;
			}
			CharacterFollowComponent component2 = entity2.GetComponent<CharacterFollowComponent>();
			CharacterBuffComponent component3 = entity2.GetComponent<CharacterBuffComponent>();
			long? preMessage = (component3 != null) ? component3.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
			List<long> list = new List<long>();
			if (list != null)
			{
				for (int i = 0; i < this.技能Id.Num(); i++)
				{
					list.Add(this.技能Id.Get(i));
				}
			}
			if (component2 != null)
			{
				component2.ListenConcomitantInherit(new IConcomitantInheritContext
				{
					SkillInterrupt = this.技能打断,
					HitInterrupt = this.受击打断,
					OtherInterrupt = this.其他打断,
					NewSkillIds = list,
					SkillId = null,
					ConcomitantDurationType = this.持续时间类型,
					Duration = this.持续时间,
					StartCue = this.开始特效,
					EndCue = this.结束特效,
					SummonIndex = this.伴生物编号,
					BuffId = this.BuffId,
					PreMessage = preMessage
				});
			}
		}
		return true;
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x0006365C File Offset: 0x0006185C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateConcomitantInherit) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateConcomitantInherit.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00063714 File Offset: 0x00061914
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		Entity entity = null;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			Entity entity2;
			if (tsBaseCharacter == null)
			{
				entity2 = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				entity2 = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			entity = entity2;
		}
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, entity, "TsAnimNotifyStateConcomitantInherit K2_NotifyEnd", default(ReadOnlySpan<ValueTuple<string, object>>));
		long? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new long?(component.GetSummonerId()) : null);
		}
		long? num2 = num;
		if (num2 == null || num2.Value == 0L)
		{
			CharacterFollowComponent characterFollowComponent = (entity != null) ? entity.GetComponent<CharacterFollowComponent>() : null;
			if (characterFollowComponent != null)
			{
				characterFollowComponent.RemoveListenConcomitantInherit();
			}
		}
		else if (this.持续时间类型 == EConcomitantDurationType.帧事件结束时消失)
		{
			EntityHandle entity3 = CreatureModel.Instance.GetEntity(num2.Value);
			WorldEntity worldEntity = (entity3 != null) ? entity3.Entity : null;
			CharacterFollowComponent characterFollowComponent2 = (worldEntity != null) ? worldEntity.GetComponent<CharacterFollowComponent>() : null;
			if (characterFollowComponent2 != null)
			{
				characterFollowComponent2.EndConcomitantInherit(this.伴生物编号);
			}
		}
		return true;
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x00063804 File Offset: 0x00061A04
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateConcomitantInherit) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateConcomitantInherit.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00063894 File Offset: 0x00061A94
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "技能打断时召唤伴生物继承技能";
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x0006389B File Offset: 0x00061A9B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateConcomitantInherit._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateConcomitantInherit.TsAnimNotifyStateConcomitantInherit_C");
		}
		return TsAnimNotifyStateConcomitantInherit._ClassPtr;
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x000638C0 File Offset: 0x00061AC0
	public TsAnimNotifyStateConcomitantInherit() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateConcomitantInherit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x000638E8 File Offset: 0x00061AE8
	[NullableContext(1)]
	public TsAnimNotifyStateConcomitantInherit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateConcomitantInherit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x0006391B File Offset: 0x00061B1B
	protected TsAnimNotifyStateConcomitantInherit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x00063924 File Offset: 0x00061B24
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x00063960 File Offset: 0x00061B60
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x00063993 File Offset: 0x00061B93
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000D0D RID: 3341
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateConcomitantInherit.TsAnimNotifyStateConcomitantInherit_C";

	// Token: 0x04000D0E RID: 3342
	private static IntPtr _ClassPtr;

	// Token: 0x04000D0F RID: 3343
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D10 RID: 3344
	private static int __PropertyOffset_技能打断;

	// Token: 0x04000D11 RID: 3345
	private static int __PropertyOffset_受击打断;

	// Token: 0x04000D12 RID: 3346
	private static int __PropertyOffset_其他打断;

	// Token: 0x04000D13 RID: 3347
	private static int __PropertyOffset_技能Id;

	// Token: 0x04000D14 RID: 3348
	[Nullable(2)]
	private TArray<long> _技能Id;

	// Token: 0x04000D15 RID: 3349
	private static int __PropertyOffset_开始特效;

	// Token: 0x04000D16 RID: 3350
	private static int __PropertyOffset_结束特效;

	// Token: 0x04000D17 RID: 3351
	private static int __PropertyOffset_持续时间类型;

	// Token: 0x04000D18 RID: 3352
	private static int __PropertyOffset_持续时间;

	// Token: 0x04000D19 RID: 3353
	private static int __PropertyOffset_伴生物编号;

	// Token: 0x04000D1A RID: 3354
	private static int __PropertyOffset_BuffId;
}
