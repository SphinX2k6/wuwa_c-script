using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000139 RID: 313
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideBattleUi.TsAnimNotifyStateHideBattleUi_C")]
public class TsAnimNotifyStateHideBattleUi : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000323 RID: 803
	// (get) Token: 0x0600132E RID: 4910 RVA: 0x0006BD60 File Offset: 0x00069F60
	// (set) Token: 0x0600132F RID: 4911 RVA: 0x0006BD99 File Offset: 0x00069F99
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<EBattleUIChild> 需要额外显示的ui类型
	{
		get
		{
			base.FastCheckIsValid();
			TArray<EBattleUIChild> result;
			if ((result = this._需要额外显示的ui类型) == null)
			{
				result = (this._需要额外显示的ui类型 = new TArray<EBattleUIChild>(base.NativePtr + (IntPtr)TsAnimNotifyStateHideBattleUi.__PropertyOffset_需要额外显示的ui类型, this));
			}
			return result;
		}
		set
		{
			this.需要额外显示的ui类型.CopyAssign(value);
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x06001330 RID: 4912 RVA: 0x0006BDA7 File Offset: 0x00069FA7
	// (set) Token: 0x06001331 RID: 4913 RVA: 0x0006BDB7 File Offset: 0x00069FB7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsHiding
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateHideBattleUi.__PropertyOffset_IsHiding) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateHideBattleUi.__PropertyOffset_IsHiding) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x0006BEBC File Offset: 0x0006A0BC
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

	// Token: 0x06001334 RID: 4916 RVA: 0x0006BF64 File Offset: 0x0006A164
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.IsHiding)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "[TsAnimNotifyStateHideBattleUi]重复隐藏战斗UI";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MeshComp", (meshComp != null) ? meshComp.GetName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Animation", (animation != null) ? animation.GetName() : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			if (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy)
			{
				return false;
			}
			this.IsHiding = true;
			List<EBattleUiChild> list = new List<EBattleUiChild>();
			if (this.需要额外显示的ui类型 != null)
			{
				int num = this.需要额外显示的ui类型.Num();
				list.EnsureCapacity(num);
				for (int i = 0; i < num; i++)
				{
					list.Add((EBattleUiChild)this.需要额外显示的ui类型.Get(i));
				}
			}
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.HideBattleView(EBattleUiVisibleReason.ANS, list, 0);
			}
			Entity entity = characterActorComponent.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null)
			{
				foreach (int value in TsAnimNotifyStateHideBattleUi.PlayerInputLimitTagList)
				{
					baseTagComponent.AddTag(new int?(value));
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.ZFJ;
			string message2 = "[TsAnimNotifyStateHideBattleUi]开始隐藏战斗UI";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("MeshComp", (meshComp != null) ? meshComp.GetName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Animation", (animation != null) ? animation.GetName() : null);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
		return true;
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x0006C138 File Offset: 0x0006A338
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

	// Token: 0x06001336 RID: 4918 RVA: 0x0006C1D8 File Offset: 0x0006A3D8
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!this.IsHiding)
		{
			return false;
		}
		this.IsHiding = false;
		TsBaseCharacter tsBaseCharacter = ((meshComp != null) ? meshComp.GetOwner() : null) as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.Valid && characterActorComponent.IsAutonomousProxy)
			{
				Entity entity = characterActorComponent.Entity;
				BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent != null)
				{
					foreach (int value in TsAnimNotifyStateHideBattleUi.PlayerInputLimitTagList)
					{
						baseTagComponent.RemoveTag(new int?(value));
					}
				}
			}
		}
		BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
		if (childViewData != null)
		{
			childViewData.ShowBattleView(EBattleUiVisibleReason.ANS, 0);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.ZFJ;
		string message = "[TsAnimNotifyStateHideBattleUi]结束隐藏战斗UI";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MeshComp", (meshComp != null) ? meshComp.GetName() : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Animation", (animation != null) ? animation.GetName() : null);
		instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return true;
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x0006C2EC File Offset: 0x0006A4EC
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

	// Token: 0x06001338 RID: 4920 RVA: 0x0006C367 File Offset: 0x0006A567
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏战斗UI";
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x0006C36E File Offset: 0x0006A56E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateHideBattleUi._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideBattleUi.TsAnimNotifyStateHideBattleUi_C");
		}
		return TsAnimNotifyStateHideBattleUi._ClassPtr;
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x0006C394 File Offset: 0x0006A594
	public TsAnimNotifyStateHideBattleUi() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideBattleUi.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x0006C3BC File Offset: 0x0006A5BC
	public TsAnimNotifyStateHideBattleUi(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideBattleUi.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x0006C3EF File Offset: 0x0006A5EF
	protected TsAnimNotifyStateHideBattleUi(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x0006C3F8 File Offset: 0x0006A5F8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x0006C434 File Offset: 0x0006A634
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x0006C467 File Offset: 0x0006A667
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E15 RID: 3605
	private static readonly int[] PlayerInputLimitTagList = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止技能"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止移动"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止跳跃"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攀爬"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攻击"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止闪避"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象1"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象2"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止大招"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止锁定目标"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止瞄准开镜"]
	};

	// Token: 0x04000E16 RID: 3606
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideBattleUi.TsAnimNotifyStateHideBattleUi_C";

	// Token: 0x04000E17 RID: 3607
	private static IntPtr _ClassPtr;

	// Token: 0x04000E18 RID: 3608
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E19 RID: 3609
	private static int __PropertyOffset_需要额外显示的ui类型;

	// Token: 0x04000E1A RID: 3610
	[Nullable(2)]
	private TArray<EBattleUIChild> _需要额外显示的ui类型;

	// Token: 0x04000E1B RID: 3611
	private static int __PropertyOffset_IsHiding;
}
