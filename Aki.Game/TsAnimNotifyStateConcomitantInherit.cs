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
	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x06001159 RID: 4441 RVA: 0x00061CA3 File Offset: 0x0005FEA3
	// (set) Token: 0x0600115A RID: 4442 RVA: 0x00061CB3 File Offset: 0x0005FEB3
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

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x0600115B RID: 4443 RVA: 0x00061CC4 File Offset: 0x0005FEC4
	// (set) Token: 0x0600115C RID: 4444 RVA: 0x00061CD4 File Offset: 0x0005FED4
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

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x0600115D RID: 4445 RVA: 0x00061CE5 File Offset: 0x0005FEE5
	// (set) Token: 0x0600115E RID: 4446 RVA: 0x00061CF5 File Offset: 0x0005FEF5
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

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x0600115F RID: 4447 RVA: 0x00061D08 File Offset: 0x0005FF08
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

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x06001160 RID: 4448 RVA: 0x00061D41 File Offset: 0x0005FF41
	// (set) Token: 0x06001161 RID: 4449 RVA: 0x00061D51 File Offset: 0x0005FF51
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

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x06001162 RID: 4450 RVA: 0x00061D62 File Offset: 0x0005FF62
	// (set) Token: 0x06001163 RID: 4451 RVA: 0x00061D72 File Offset: 0x0005FF72
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

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x06001164 RID: 4452 RVA: 0x00061D83 File Offset: 0x0005FF83
	// (set) Token: 0x06001165 RID: 4453 RVA: 0x00061D93 File Offset: 0x0005FF93
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

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x06001166 RID: 4454 RVA: 0x00061DA4 File Offset: 0x0005FFA4
	// (set) Token: 0x06001167 RID: 4455 RVA: 0x00061DB4 File Offset: 0x0005FFB4
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

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x06001168 RID: 4456 RVA: 0x00061DC5 File Offset: 0x0005FFC5
	// (set) Token: 0x06001169 RID: 4457 RVA: 0x00061DD5 File Offset: 0x0005FFD5
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

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x0600116A RID: 4458 RVA: 0x00061DE6 File Offset: 0x0005FFE6
	// (set) Token: 0x0600116B RID: 4459 RVA: 0x00061DF6 File Offset: 0x0005FFF6
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

	// Token: 0x0600116C RID: 4460 RVA: 0x00061E08 File Offset: 0x00060008
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x00061EB0 File Offset: 0x000600B0
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

	// Token: 0x0600116E RID: 4462 RVA: 0x00062040 File Offset: 0x00060240
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x000620E0 File Offset: 0x000602E0
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

	// Token: 0x06001170 RID: 4464 RVA: 0x000621D0 File Offset: 0x000603D0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x0006224B File Offset: 0x0006044B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "技能打断时召唤伴生物继承技能";
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00062252 File Offset: 0x00060452
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateConcomitantInherit._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateConcomitantInherit.TsAnimNotifyStateConcomitantInherit_C");
		}
		return TsAnimNotifyStateConcomitantInherit._ClassPtr;
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x00062278 File Offset: 0x00060478
	public TsAnimNotifyStateConcomitantInherit() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateConcomitantInherit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x000622A0 File Offset: 0x000604A0
	[NullableContext(1)]
	public TsAnimNotifyStateConcomitantInherit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateConcomitantInherit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x000622D3 File Offset: 0x000604D3
	protected TsAnimNotifyStateConcomitantInherit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x000622DC File Offset: 0x000604DC
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00062318 File Offset: 0x00060518
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x0006234B File Offset: 0x0006054B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000D05 RID: 3333
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateConcomitantInherit.TsAnimNotifyStateConcomitantInherit_C";

	// Token: 0x04000D06 RID: 3334
	private static IntPtr _ClassPtr;

	// Token: 0x04000D07 RID: 3335
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D08 RID: 3336
	private static int __PropertyOffset_技能打断;

	// Token: 0x04000D09 RID: 3337
	private static int __PropertyOffset_受击打断;

	// Token: 0x04000D0A RID: 3338
	private static int __PropertyOffset_其他打断;

	// Token: 0x04000D0B RID: 3339
	private static int __PropertyOffset_技能Id;

	// Token: 0x04000D0C RID: 3340
	[Nullable(2)]
	private TArray<long> _技能Id;

	// Token: 0x04000D0D RID: 3341
	private static int __PropertyOffset_开始特效;

	// Token: 0x04000D0E RID: 3342
	private static int __PropertyOffset_结束特效;

	// Token: 0x04000D0F RID: 3343
	private static int __PropertyOffset_持续时间类型;

	// Token: 0x04000D10 RID: 3344
	private static int __PropertyOffset_持续时间;

	// Token: 0x04000D11 RID: 3345
	private static int __PropertyOffset_伴生物编号;

	// Token: 0x04000D12 RID: 3346
	private static int __PropertyOffset_BuffId;
}
