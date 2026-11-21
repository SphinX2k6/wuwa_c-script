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
	// Token: 0x060011FF RID: 4607 RVA: 0x00067BCF File Offset: 0x00065DCF
	static TsAnimNotifyStateDetectBox()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateDetectBox.CreateStaticDefaultValue), new Action(TsAnimNotifyStateDetectBox.ResetStaticDefaultValue));
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x00067BEE File Offset: 0x00065DEE
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateDetectBox.detectStateMap = new Dictionary<int, DetectStateBox>();
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x00067BFA File Offset: 0x00065DFA
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateDetectBox.detectStateMap = null;
	}

	// Token: 0x170002F4 RID: 756
	// (get) Token: 0x06001202 RID: 4610 RVA: 0x00067C02 File Offset: 0x00065E02
	// (set) Token: 0x06001203 RID: 4611 RVA: 0x00067C12 File Offset: 0x00065E12
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

	// Token: 0x170002F5 RID: 757
	// (get) Token: 0x06001204 RID: 4612 RVA: 0x00067C23 File Offset: 0x00065E23
	// (set) Token: 0x06001205 RID: 4613 RVA: 0x00067C33 File Offset: 0x00065E33
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

	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x06001206 RID: 4614 RVA: 0x00067C44 File Offset: 0x00065E44
	// (set) Token: 0x06001207 RID: 4615 RVA: 0x00067C54 File Offset: 0x00065E54
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

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x06001208 RID: 4616 RVA: 0x00067C65 File Offset: 0x00065E65
	// (set) Token: 0x06001209 RID: 4617 RVA: 0x00067C75 File Offset: 0x00065E75
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

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x0600120A RID: 4618 RVA: 0x00067C86 File Offset: 0x00065E86
	// (set) Token: 0x0600120B RID: 4619 RVA: 0x00067C96 File Offset: 0x00065E96
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

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x0600120C RID: 4620 RVA: 0x00067CA7 File Offset: 0x00065EA7
	// (set) Token: 0x0600120D RID: 4621 RVA: 0x00067CB7 File Offset: 0x00065EB7
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

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x0600120E RID: 4622 RVA: 0x00067CC8 File Offset: 0x00065EC8
	// (set) Token: 0x0600120F RID: 4623 RVA: 0x00067D01 File Offset: 0x00065F01
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

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x06001210 RID: 4624 RVA: 0x00067D0F File Offset: 0x00065F0F
	// (set) Token: 0x06001211 RID: 4625 RVA: 0x00067D23 File Offset: 0x00065F23
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

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x06001212 RID: 4626 RVA: 0x00067D38 File Offset: 0x00065F38
	// (set) Token: 0x06001213 RID: 4627 RVA: 0x00067D48 File Offset: 0x00065F48
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

	// Token: 0x170002FD RID: 765
	// (get) Token: 0x06001214 RID: 4628 RVA: 0x00067D59 File Offset: 0x00065F59
	// (set) Token: 0x06001215 RID: 4629 RVA: 0x00067D69 File Offset: 0x00065F69
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

	// Token: 0x06001216 RID: 4630 RVA: 0x00067D7C File Offset: 0x00065F7C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateDetectBox) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateDetectBox.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001217 RID: 4631 RVA: 0x00067E0C File Offset: 0x0006600C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "盒体检测碰撞";
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00067E14 File Offset: 0x00066014
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateDetectBox) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateDetectBox.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001219 RID: 4633 RVA: 0x00067ED4 File Offset: 0x000660D4
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

	// Token: 0x0600121A RID: 4634 RVA: 0x00067FF0 File Offset: 0x000661F0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateDetectBox) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateDetectBox.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x000680B0 File Offset: 0x000662B0
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

	// Token: 0x0600121C RID: 4636 RVA: 0x00068368 File Offset: 0x00066568
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateDetectBox) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateDetectBox.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600121D RID: 4637 RVA: 0x00068420 File Offset: 0x00066620
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

	// Token: 0x0600121E RID: 4638 RVA: 0x00068579 File Offset: 0x00066779
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateDetectBox._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDetectBox.TsAnimNotifyStateDetectBox_C");
		}
		return TsAnimNotifyStateDetectBox._ClassPtr;
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x000685A0 File Offset: 0x000667A0
	public TsAnimNotifyStateDetectBox() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDetectBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x000685C8 File Offset: 0x000667C8
	[NullableContext(1)]
	public TsAnimNotifyStateDetectBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDetectBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x000685FB File Offset: 0x000667FB
	protected TsAnimNotifyStateDetectBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x00068604 File Offset: 0x00066804
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x00068618 File Offset: 0x00066818
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x00068654 File Offset: 0x00066854
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x00068690 File Offset: 0x00066890
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000D8E RID: 3470
	[Nullable(1)]
	private static Dictionary<int, DetectStateBox> detectStateMap;

	// Token: 0x04000D8F RID: 3471
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDetectBox.TsAnimNotifyStateDetectBox_C";

	// Token: 0x04000D90 RID: 3472
	private static IntPtr _ClassPtr;

	// Token: 0x04000D91 RID: 3473
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D92 RID: 3474
	private static int __PropertyOffset_BoxHalfSizeX;

	// Token: 0x04000D93 RID: 3475
	private static int __PropertyOffset_BoxHalfSizeY;

	// Token: 0x04000D94 RID: 3476
	private static int __PropertyOffset_BoxHalfSizeZ;

	// Token: 0x04000D95 RID: 3477
	private static int __PropertyOffset_OffsetX;

	// Token: 0x04000D96 RID: 3478
	private static int __PropertyOffset_OffsetY;

	// Token: 0x04000D97 RID: 3479
	private static int __PropertyOffset_OffsetZ;

	// Token: 0x04000D98 RID: 3480
	private static int __PropertyOffset_ObjectTypes;

	// Token: 0x04000D99 RID: 3481
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private TArray<TEnumAsByte<EObjectTypeQuery>> _ObjectTypes;

	// Token: 0x04000D9A RID: 3482
	private static int __PropertyOffset_TagOnHit;

	// Token: 0x04000D9B RID: 3483
	private static int __PropertyOffset_SendGamePlayEvent;

	// Token: 0x04000D9C RID: 3484
	private static int __PropertyOffset_DebugDraw;
}
