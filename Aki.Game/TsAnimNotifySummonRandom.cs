using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E1 RID: 481
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonRandom.TsAnimNotifySummonRandom_C")]
public class TsAnimNotifySummonRandom : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004E0 RID: 1248
	// (get) Token: 0x06001E44 RID: 7748 RVA: 0x0009C53B File Offset: 0x0009A73B
	// (set) Token: 0x06001E45 RID: 7749 RVA: 0x0009C54B File Offset: 0x0009A74B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SummonIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySummonRandom.__PropertyOffset_SummonIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySummonRandom.__PropertyOffset_SummonIndex) = value;
		}
	}

	// Token: 0x170004E1 RID: 1249
	// (get) Token: 0x06001E46 RID: 7750 RVA: 0x0009C55C File Offset: 0x0009A75C
	// (set) Token: 0x06001E47 RID: 7751 RVA: 0x0009C595 File Offset: 0x0009A795
	[UProperty(EPropertyFlags.CPF_None)]
	public SSkillBehaviorAction Action
	{
		get
		{
			base.FastCheckIsValid();
			SSkillBehaviorAction result;
			if ((result = this._Action) == null)
			{
				result = (this._Action = new SSkillBehaviorAction(base.NativePtr + (IntPtr)TsAnimNotifySummonRandom.__PropertyOffset_Action, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SSkillBehaviorAction.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifySummonRandom.__PropertyOffset_Action, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0009C5BD File Offset: 0x0009A7BD
	// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0009C5CD File Offset: 0x0009A7CD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySummonRandom.__PropertyOffset_SkillId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySummonRandom.__PropertyOffset_SkillId) = value;
		}
	}

	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0009C5DE File Offset: 0x0009A7DE
	// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0009C5EE File Offset: 0x0009A7EE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsVisible
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySummonRandom.__PropertyOffset_IsVisible) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySummonRandom.__PropertyOffset_IsVisible) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x0009C600 File Offset: 0x0009A800
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySummonRandom) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySummonRandom.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x0009C6B8 File Offset: 0x0009A8B8
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null || !(owner is TsBaseCharacter))
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		bool flag;
		if (tsBaseCharacter == null)
		{
			flag = true;
		}
		else
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			flag = !((characterActorComponent != null) ? new bool?(characterActorComponent.IsAutonomousProxy) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter2 = owner as TsBaseCharacter;
		Entity entity;
		if (tsBaseCharacter2 == null)
		{
			entity = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent2 = tsBaseCharacter2.CharacterActorComponent;
			entity = ((characterActorComponent2 != null) ? characterActorComponent2.Entity : null);
		}
		Entity entity2 = entity;
		if (entity2 == null || !entity2.Valid)
		{
			return false;
		}
		CharacterSkillComponent component = entity2.GetComponent<CharacterSkillComponent>();
		if (component == null || component.CurrentSkill == null || this.Action == null)
		{
			return false;
		}
		BeginSkillBehaviorActionParam param = new BeginSkillBehaviorActionParam
		{
			Entity = entity2,
			SkillComponent = component,
			Skill = component.CurrentSkill
		};
		FVectorDouble fvectorDouble = SkillBehaviorAction.CalculateLocation(this.Action, param);
		FRotator frotator = SkillBehaviorAction.CalculateRotation(this.Action, param);
		FVector fvector = Vector.OneVectorDouble;
		FTransformDouble transform = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
		CreatureController.Instance.SummonRandomRequest(entity2.Id, this.SummonIndex, transform, this.SkillId, this.IsVisible);
		return true;
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x0009C7E4 File Offset: 0x0009A9E4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySummonRandom) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifySummonRandom.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x0009C874 File Offset: 0x0009AA74
	protected override string GetNotifyName_Implementation()
	{
		return "随机召唤";
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x0009C87B File Offset: 0x0009AA7B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySummonRandom._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonRandom.TsAnimNotifySummonRandom_C");
		}
		return TsAnimNotifySummonRandom._ClassPtr;
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x0009C8A0 File Offset: 0x0009AAA0
	public TsAnimNotifySummonRandom() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonRandom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x0009C8C8 File Offset: 0x0009AAC8
	public TsAnimNotifySummonRandom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x0009C8FB File Offset: 0x0009AAFB
	protected TsAnimNotifySummonRandom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E54 RID: 7764 RVA: 0x0009C904 File Offset: 0x0009AB04
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E55 RID: 7765 RVA: 0x0009C937 File Offset: 0x0009AB37
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012A8 RID: 4776
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonRandom.TsAnimNotifySummonRandom_C";

	// Token: 0x040012A9 RID: 4777
	private static IntPtr _ClassPtr;

	// Token: 0x040012AA RID: 4778
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012AB RID: 4779
	private static int __PropertyOffset_SummonIndex;

	// Token: 0x040012AC RID: 4780
	private static int __PropertyOffset_Action;

	// Token: 0x040012AD RID: 4781
	[Nullable(2)]
	private SSkillBehaviorAction _Action;

	// Token: 0x040012AE RID: 4782
	private static int __PropertyOffset_SkillId;

	// Token: 0x040012AF RID: 4783
	private static int __PropertyOffset_IsVisible;
}
