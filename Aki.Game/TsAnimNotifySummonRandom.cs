using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001DD RID: 477
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonRandom.TsAnimNotifySummonRandom_C")]
public class TsAnimNotifySummonRandom : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x000955AB File Offset: 0x000937AB
	// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x000955BB File Offset: 0x000937BB
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

	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x000955CC File Offset: 0x000937CC
	// (set) Token: 0x06001DAA RID: 7594 RVA: 0x00095605 File Offset: 0x00093805
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

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0009562D File Offset: 0x0009382D
	// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0009563D File Offset: 0x0009383D
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

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0009564E File Offset: 0x0009384E
	// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0009565E File Offset: 0x0009385E
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

	// Token: 0x06001DAF RID: 7599 RVA: 0x00095670 File Offset: 0x00093870
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x06001DB0 RID: 7600 RVA: 0x00095710 File Offset: 0x00093910
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

	// Token: 0x06001DB1 RID: 7601 RVA: 0x0009583C File Offset: 0x00093A3C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001DB2 RID: 7602 RVA: 0x000958B7 File Offset: 0x00093AB7
	protected override string GetNotifyName_Implementation()
	{
		return "随机召唤";
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x000958BE File Offset: 0x00093ABE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySummonRandom._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonRandom.TsAnimNotifySummonRandom_C");
		}
		return TsAnimNotifySummonRandom._ClassPtr;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x000958E4 File Offset: 0x00093AE4
	public TsAnimNotifySummonRandom() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonRandom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x0009590C File Offset: 0x00093B0C
	public TsAnimNotifySummonRandom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x0009593F File Offset: 0x00093B3F
	protected TsAnimNotifySummonRandom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x00095948 File Offset: 0x00093B48
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x0009597B File Offset: 0x00093B7B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001265 RID: 4709
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonRandom.TsAnimNotifySummonRandom_C";

	// Token: 0x04001266 RID: 4710
	private static IntPtr _ClassPtr;

	// Token: 0x04001267 RID: 4711
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001268 RID: 4712
	private static int __PropertyOffset_SummonIndex;

	// Token: 0x04001269 RID: 4713
	private static int __PropertyOffset_Action;

	// Token: 0x0400126A RID: 4714
	[Nullable(2)]
	private SSkillBehaviorAction _Action;

	// Token: 0x0400126B RID: 4715
	private static int __PropertyOffset_SkillId;

	// Token: 0x0400126C RID: 4716
	private static int __PropertyOffset_IsVisible;
}
