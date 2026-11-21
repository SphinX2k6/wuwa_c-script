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

// Token: 0x0200013A RID: 314
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideBattleUi.TsAnimNotifyStateHideBattleUi_C")]
public class TsAnimNotifyStateHideBattleUi : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700033E RID: 830
	// (get) Token: 0x060013AC RID: 5036 RVA: 0x00070290 File Offset: 0x0006E490
	// (set) Token: 0x060013AD RID: 5037 RVA: 0x000702C9 File Offset: 0x0006E4C9
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

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x060013AE RID: 5038 RVA: 0x000702D7 File Offset: 0x0006E4D7
	// (set) Token: 0x060013AF RID: 5039 RVA: 0x000702E7 File Offset: 0x0006E4E7
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

	// Token: 0x060013B1 RID: 5041 RVA: 0x000703EC File Offset: 0x0006E5EC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateHideBattleUi) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateHideBattleUi.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013B2 RID: 5042 RVA: 0x000704AC File Offset: 0x0006E6AC
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

	// Token: 0x060013B3 RID: 5043 RVA: 0x00070680 File Offset: 0x0006E880
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateHideBattleUi) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateHideBattleUi.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013B4 RID: 5044 RVA: 0x00070738 File Offset: 0x0006E938
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

	// Token: 0x060013B5 RID: 5045 RVA: 0x0007084C File Offset: 0x0006EA4C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateHideBattleUi) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateHideBattleUi.StaticClass(), out intPtr, out num))
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

	// Token: 0x060013B6 RID: 5046 RVA: 0x000708DC File Offset: 0x0006EADC
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏战斗UI";
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x000708E3 File Offset: 0x0006EAE3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateHideBattleUi._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideBattleUi.TsAnimNotifyStateHideBattleUi_C");
		}
		return TsAnimNotifyStateHideBattleUi._ClassPtr;
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x00070908 File Offset: 0x0006EB08
	public TsAnimNotifyStateHideBattleUi() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideBattleUi.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x00070930 File Offset: 0x0006EB30
	public TsAnimNotifyStateHideBattleUi(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateHideBattleUi.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x00070963 File Offset: 0x0006EB63
	protected TsAnimNotifyStateHideBattleUi(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x0007096C File Offset: 0x0006EB6C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x000709A8 File Offset: 0x0006EBA8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x000709DB File Offset: 0x0006EBDB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E47 RID: 3655
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

	// Token: 0x04000E48 RID: 3656
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateHideBattleUi.TsAnimNotifyStateHideBattleUi_C";

	// Token: 0x04000E49 RID: 3657
	private static IntPtr _ClassPtr;

	// Token: 0x04000E4A RID: 3658
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E4B RID: 3659
	private static int __PropertyOffset_需要额外显示的ui类型;

	// Token: 0x04000E4C RID: 3660
	[Nullable(2)]
	private TArray<EBattleUIChild> _需要额外显示的ui类型;

	// Token: 0x04000E4D RID: 3661
	private static int __PropertyOffset_IsHiding;
}
