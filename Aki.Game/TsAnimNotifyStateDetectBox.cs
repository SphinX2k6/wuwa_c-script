using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000127 RID: 295
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDetectBox.TsAnimNotifyStateDetectBox_C")]
public class TsAnimNotifyStateDetectBox : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060011F9 RID: 4601 RVA: 0x0006645B File Offset: 0x0006465B
	static TsAnimNotifyStateDetectBox()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateDetectBox.CreateStaticDefaultValue), new Action(TsAnimNotifyStateDetectBox.ResetStaticDefaultValue));
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x0006647A File Offset: 0x0006467A
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateDetectBox.detectStateMap = new Dictionary<int, DetectStateBox>();
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x00066486 File Offset: 0x00064686
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateDetectBox.detectStateMap = null;
	}

	// Token: 0x170002F1 RID: 753
	// (get) Token: 0x060011FC RID: 4604 RVA: 0x0006648E File Offset: 0x0006468E
	// (set) Token: 0x060011FD RID: 4605 RVA: 0x0006649E File Offset: 0x0006469E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BoxHalfSizeX
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_BoxHalfSizeX);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_BoxHalfSizeX) = value;
		}
	}

	// Token: 0x170002F2 RID: 754
	// (get) Token: 0x060011FE RID: 4606 RVA: 0x000664AF File Offset: 0x000646AF
	// (set) Token: 0x060011FF RID: 4607 RVA: 0x000664BF File Offset: 0x000646BF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BoxHalfSizeY
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_BoxHalfSizeY);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_BoxHalfSizeY) = value;
		}
	}

	// Token: 0x170002F3 RID: 755
	// (get) Token: 0x06001200 RID: 4608 RVA: 0x000664D0 File Offset: 0x000646D0
	// (set) Token: 0x06001201 RID: 4609 RVA: 0x000664E0 File Offset: 0x000646E0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BoxHalfSizeZ
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_BoxHalfSizeZ);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_BoxHalfSizeZ) = value;
		}
	}

	// Token: 0x170002F4 RID: 756
	// (get) Token: 0x06001202 RID: 4610 RVA: 0x000664F1 File Offset: 0x000646F1
	// (set) Token: 0x06001203 RID: 4611 RVA: 0x00066501 File Offset: 0x00064701
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OffsetX
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_OffsetX);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_OffsetX) = value;
		}
	}

	// Token: 0x170002F5 RID: 757
	// (get) Token: 0x06001204 RID: 4612 RVA: 0x00066512 File Offset: 0x00064712
	// (set) Token: 0x06001205 RID: 4613 RVA: 0x00066522 File Offset: 0x00064722
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OffsetY
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_OffsetY);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_OffsetY) = value;
		}
	}

	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x06001206 RID: 4614 RVA: 0x00066533 File Offset: 0x00064733
	// (set) Token: 0x06001207 RID: 4615 RVA: 0x00066543 File Offset: 0x00064743
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OffsetZ
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_OffsetZ);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_OffsetZ) = value;
		}
	}

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x06001208 RID: 4616 RVA: 0x00066554 File Offset: 0x00064754
	// (set) Token: 0x06001209 RID: 4617 RVA: 0x0006658D File Offset: 0x0006478D
	[Nullable(new byte[]
	{
		1,
		0
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes
	{
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		get
		{
			base.FastCheckIsValid();
			TArray<TEnumAsByte<EObjectTypeQuery>> result;
			if ((result = this._ObjectTypes) == null)
			{
				result = (this._ObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_ObjectTypes, this));
			}
			return result;
		}
		[param: Nullable(new byte[]
		{
			1,
			0
		})]
		set
		{
			this.ObjectTypes.CopyAssign(value);
		}
	}

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x0600120A RID: 4618 RVA: 0x0006659B File Offset: 0x0006479B
	// (set) Token: 0x0600120B RID: 4619 RVA: 0x000665AF File Offset: 0x000647AF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag TagOnHit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_TagOnHit);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_TagOnHit) = value;
		}
	}

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x0600120C RID: 4620 RVA: 0x000665C4 File Offset: 0x000647C4
	// (set) Token: 0x0600120D RID: 4621 RVA: 0x000665D4 File Offset: 0x000647D4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SendGamePlayEvent
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_SendGamePlayEvent) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_SendGamePlayEvent) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x0600120E RID: 4622 RVA: 0x000665E5 File Offset: 0x000647E5
	// (set) Token: 0x0600120F RID: 4623 RVA: 0x000665F5 File Offset: 0x000647F5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_DebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectBox.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x00066608 File Offset: 0x00064808
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

	// Token: 0x06001211 RID: 4625 RVA: 0x00066683 File Offset: 0x00064883
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "盒体检测碰撞";
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x0006668C File Offset: 0x0006488C
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

	// Token: 0x06001213 RID: 4627 RVA: 0x00066734 File Offset: 0x00064934
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter && (owner as TsBaseCharacter).CharacterActorComponent != null)
		{
			int entityIdNoBlueprint = (owner as TsBaseCharacter).GetEntityIdNoBlueprint();
			DetectStateBox detectStateBox;
			if (!TsAnimNotifyStateDetectBox.detectStateMap.TryGetValue(entityIdNoBlueprint, out detectStateBox))
			{
				detectStateBox = new DetectStateBox(new UTraceBoxElement());
				TsAnimNotifyStateDetectBox.detectStateMap[entityIdNoBlueprint] = detectStateBox;
			}
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			detectStateBox.LastFramePosition.FromUeVector(characterActorComponent.ActorLocationProxy);
			detectStateBox.BoxElement.WorldContextObject = owner.GetWorld();
			TArray<TEnumAsByte<EObjectTypeQuery>> objectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			detectStateBox.BoxElement.SetObjectTypesQuery(ref objectTypes);
			this.ObjectTypes = objectTypes;
			detectStateBox.BoxElement.SetBoxHalfSize(this.BoxHalfSizeX, this.BoxHalfSizeY, this.BoxHalfSizeZ);
			if (this.DebugDraw)
			{
				detectStateBox.BoxElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
				detectStateBox.BoxElement.DrawTime = 1f;
			}
			detectStateBox.BoxElement.bIsSingle = true;
			detectStateBox.Offset.Set((double)this.OffsetX, (double)this.OffsetY, (double)this.OffsetZ);
		}
		return true;
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00066850 File Offset: 0x00064A50
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x000668F8 File Offset: 0x00064AF8
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null && tsBaseCharacter.CharacterActorComponent != null)
		{
			DetectStateBox valueOrDefault = TsAnimNotifyStateDetectBox.detectStateMap.GetValueOrDefault(tsBaseCharacter.GetEntityIdNoBlueprint());
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			if (valueOrDefault == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AnimNotify;
				ELogAuthor author = ELogAuthor.HCW;
				string message = "获取不到状态";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Owner", characterActorComponent.Owner);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("蒙太奇路径", UKismetSystemLibrary.GetPathName(animation));
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			valueOrDefault.BoxElement.SetBoxOrientation(characterActorComponent.ActorRotationProxy.Pitch, characterActorComponent.ActorRotationProxy.Yaw, characterActorComponent.ActorRotationProxy.Roll);
			valueOrDefault.BoxElement.SetStartLocation(valueOrDefault.LastFramePosition.X, valueOrDefault.LastFramePosition.Y, valueOrDefault.LastFramePosition.Z);
			MathUtils.Instance.TransformPosition(characterActorComponent.ActorLocationProxy, characterActorComponent.ActorRotationProxy, characterActorComponent.ActorScaleProxy, valueOrDefault.Offset, valueOrDefault.CurrentPosition);
			valueOrDefault.BoxElement.SetEndLocation(valueOrDefault.CurrentPosition.X, valueOrDefault.CurrentPosition.Y, valueOrDefault.CurrentPosition.Z);
			valueOrDefault.LastFramePosition.FromUeVector(valueOrDefault.CurrentPosition);
			if (TraceElementCommon.Instance.BoxTrace(valueOrDefault.BoxElement, "ANS_DetectBox"))
			{
				if (this.SendGamePlayEvent)
				{
					BaseAbilityComponent component = characterActorComponent.Entity.GetComponent<BaseAbilityComponent>();
					if (component == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.AnimNotify;
						ELogAuthor author2 = ELogAuthor.HCW;
						string message2 = "使用DetectBoxANS的角色没有AbilityComponent";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Owner", characterActorComponent.Owner);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("蒙太奇路径", UKismetSystemLibrary.GetPathName(animation));
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						return false;
					}
					component.SendGameplayEventToActor(this.TagOnHit, null);
				}
				else
				{
					BaseTagComponent component2 = characterActorComponent.Entity.GetComponent<BaseTagComponent>();
					if (component2 == null)
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.AnimNotify;
						ELogAuthor author3 = ELogAuthor.HCW;
						string message3 = "使用DetectBoxANS的角色没有BaseTagComponent";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Owner", characterActorComponent.Owner);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("蒙太奇路径", UKismetSystemLibrary.GetPathName(animation));
						instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
						return false;
					}
					component2.AddTag(new int?(this.TagOnHit.TagId()));
				}
			}
		}
		return true;
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00066BB0 File Offset: 0x00064DB0
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

	// Token: 0x06001217 RID: 4631 RVA: 0x00066C50 File Offset: 0x00064E50
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null || tsBaseCharacter.CharacterActorComponent == null)
		{
			return true;
		}
		int entityIdNoBlueprint = tsBaseCharacter.GetEntityIdNoBlueprint();
		DetectStateBox valueOrDefault = TsAnimNotifyStateDetectBox.detectStateMap.GetValueOrDefault(entityIdNoBlueprint);
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (valueOrDefault == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AnimNotify;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "获取不到状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Owner", characterActorComponent.Owner);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("蒙太奇路径", UKismetSystemLibrary.GetPathName(animation));
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		valueOrDefault.BoxElement.Dispose();
		TsAnimNotifyStateDetectBox.detectStateMap.Remove(entityIdNoBlueprint);
		if (characterActorComponent != null && !this.SendGamePlayEvent)
		{
			BaseTagComponent component = characterActorComponent.Entity.GetComponent<BaseTagComponent>();
			if (component == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.AnimNotify;
				ELogAuthor author2 = ELogAuthor.HCW;
				string message2 = "使用DetectSphereANS的角色没有BaseTagComponent";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Owner", characterActorComponent.Owner);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("蒙太奇路径", UKismetSystemLibrary.GetPathName(animation));
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			component.RemoveTag(new int?(this.TagOnHit.TagId()));
		}
		return true;
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00066DA9 File Offset: 0x00064FA9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateDetectBox._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDetectBox.TsAnimNotifyStateDetectBox_C");
		}
		return TsAnimNotifyStateDetectBox._ClassPtr;
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00066DD0 File Offset: 0x00064FD0
	public TsAnimNotifyStateDetectBox() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDetectBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00066DF8 File Offset: 0x00064FF8
	[NullableContext(1)]
	public TsAnimNotifyStateDetectBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDetectBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x00066E2B File Offset: 0x0006502B
	protected TsAnimNotifyStateDetectBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x00066E34 File Offset: 0x00065034
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x00066E48 File Offset: 0x00065048
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00066E84 File Offset: 0x00065084
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x00066EC0 File Offset: 0x000650C0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000D86 RID: 3462
	[Nullable(1)]
	private static Dictionary<int, DetectStateBox> detectStateMap;

	// Token: 0x04000D87 RID: 3463
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDetectBox.TsAnimNotifyStateDetectBox_C";

	// Token: 0x04000D88 RID: 3464
	private static IntPtr _ClassPtr;

	// Token: 0x04000D89 RID: 3465
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D8A RID: 3466
	private static int __PropertyOffset_BoxHalfSizeX;

	// Token: 0x04000D8B RID: 3467
	private static int __PropertyOffset_BoxHalfSizeY;

	// Token: 0x04000D8C RID: 3468
	private static int __PropertyOffset_BoxHalfSizeZ;

	// Token: 0x04000D8D RID: 3469
	private static int __PropertyOffset_OffsetX;

	// Token: 0x04000D8E RID: 3470
	private static int __PropertyOffset_OffsetY;

	// Token: 0x04000D8F RID: 3471
	private static int __PropertyOffset_OffsetZ;

	// Token: 0x04000D90 RID: 3472
	private static int __PropertyOffset_ObjectTypes;

	// Token: 0x04000D91 RID: 3473
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private TArray<TEnumAsByte<EObjectTypeQuery>> _ObjectTypes;

	// Token: 0x04000D92 RID: 3474
	private static int __PropertyOffset_TagOnHit;

	// Token: 0x04000D93 RID: 3475
	private static int __PropertyOffset_SendGamePlayEvent;

	// Token: 0x04000D94 RID: 3476
	private static int __PropertyOffset_DebugDraw;
}
