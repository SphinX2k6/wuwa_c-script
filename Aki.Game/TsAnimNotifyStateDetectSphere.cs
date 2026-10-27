using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000129 RID: 297
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDetectSphere.TsAnimNotifyStateDetectSphere_C")]
public class TsAnimNotifyStateDetectSphere : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001221 RID: 4641 RVA: 0x00066F23 File Offset: 0x00065123
	static TsAnimNotifyStateDetectSphere()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateDetectSphere.CreateStaticDefaultValue), new Action(TsAnimNotifyStateDetectSphere.ResetStaticDefaultValue));
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x00066F42 File Offset: 0x00065142
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateDetectSphere.detectStateMap = new Dictionary<int, DetectStateSphere>();
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x00066F4E File Offset: 0x0006514E
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateDetectSphere.detectStateMap = null;
	}

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x06001224 RID: 4644 RVA: 0x00066F56 File Offset: 0x00065156
	// (set) Token: 0x06001225 RID: 4645 RVA: 0x00066F66 File Offset: 0x00065166
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Radius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_Radius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_Radius) = value;
		}
	}

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x06001226 RID: 4646 RVA: 0x00066F77 File Offset: 0x00065177
	// (set) Token: 0x06001227 RID: 4647 RVA: 0x00066F87 File Offset: 0x00065187
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OffsetX
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_OffsetX);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_OffsetX) = value;
		}
	}

	// Token: 0x170002FD RID: 765
	// (get) Token: 0x06001228 RID: 4648 RVA: 0x00066F98 File Offset: 0x00065198
	// (set) Token: 0x06001229 RID: 4649 RVA: 0x00066FA8 File Offset: 0x000651A8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OffsetY
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_OffsetY);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_OffsetY) = value;
		}
	}

	// Token: 0x170002FE RID: 766
	// (get) Token: 0x0600122A RID: 4650 RVA: 0x00066FB9 File Offset: 0x000651B9
	// (set) Token: 0x0600122B RID: 4651 RVA: 0x00066FC9 File Offset: 0x000651C9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OffsetZ
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_OffsetZ);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_OffsetZ) = value;
		}
	}

	// Token: 0x170002FF RID: 767
	// (get) Token: 0x0600122C RID: 4652 RVA: 0x00066FDC File Offset: 0x000651DC
	// (set) Token: 0x0600122D RID: 4653 RVA: 0x00067015 File Offset: 0x00065215
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
				result = (this._ObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_ObjectTypes, this));
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

	// Token: 0x17000300 RID: 768
	// (get) Token: 0x0600122E RID: 4654 RVA: 0x00067023 File Offset: 0x00065223
	// (set) Token: 0x0600122F RID: 4655 RVA: 0x00067037 File Offset: 0x00065237
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag TagOnHit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_TagOnHit);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_TagOnHit) = value;
		}
	}

	// Token: 0x17000301 RID: 769
	// (get) Token: 0x06001230 RID: 4656 RVA: 0x0006704C File Offset: 0x0006524C
	// (set) Token: 0x06001231 RID: 4657 RVA: 0x0006705C File Offset: 0x0006525C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SendGamePlayEvent
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_SendGamePlayEvent) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_SendGamePlayEvent) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000302 RID: 770
	// (get) Token: 0x06001232 RID: 4658 RVA: 0x0006706D File Offset: 0x0006526D
	// (set) Token: 0x06001233 RID: 4659 RVA: 0x0006707D File Offset: 0x0006527D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_DebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateDetectSphere.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00067090 File Offset: 0x00065290
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

	// Token: 0x06001235 RID: 4661 RVA: 0x00067138 File Offset: 0x00065338
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter && (owner as TsBaseCharacter).CharacterActorComponent != null)
		{
			int entityIdNoBlueprint = (owner as TsBaseCharacter).GetEntityIdNoBlueprint();
			DetectStateSphere detectStateSphere;
			if (!TsAnimNotifyStateDetectSphere.detectStateMap.TryGetValue(entityIdNoBlueprint, out detectStateSphere))
			{
				detectStateSphere = new DetectStateSphere(new UTraceSphereElement());
				TsAnimNotifyStateDetectSphere.detectStateMap[entityIdNoBlueprint] = detectStateSphere;
			}
			detectStateSphere.LastFramePosition.FromUeVector((owner as TsBaseCharacter).CharacterActorComponent.ActorLocationProxy);
			detectStateSphere.SphereElement.WorldContextObject = owner.GetWorld();
			TArray<TEnumAsByte<EObjectTypeQuery>> objectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			detectStateSphere.SphereElement.SetObjectTypesQuery(ref objectTypes);
			this.ObjectTypes = objectTypes;
			detectStateSphere.SphereElement.Radius = this.Radius;
			detectStateSphere.SphereElement.bIsSingle = true;
			if (this.DebugDraw)
			{
				detectStateSphere.SphereElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
				detectStateSphere.SphereElement.DrawTime = 1f;
			}
			detectStateSphere.Offset.Set((double)this.OffsetX, (double)this.OffsetY, (double)this.OffsetZ);
		}
		return true;
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00067244 File Offset: 0x00065444
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

	// Token: 0x06001237 RID: 4663 RVA: 0x000672EC File Offset: 0x000654EC
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null && tsBaseCharacter.CharacterActorComponent != null)
		{
			DetectStateSphere valueOrDefault = TsAnimNotifyStateDetectSphere.detectStateMap.GetValueOrDefault(tsBaseCharacter.GetEntityIdNoBlueprint());
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
			valueOrDefault.SphereElement.SetStartLocation(valueOrDefault.LastFramePosition.X, valueOrDefault.LastFramePosition.Y, valueOrDefault.LastFramePosition.Z);
			MathUtils.Instance.TransformPosition(characterActorComponent.ActorLocationProxy, characterActorComponent.ActorRotationProxy, characterActorComponent.ActorScaleProxy, valueOrDefault.Offset, valueOrDefault.CurrentPosition);
			valueOrDefault.SphereElement.SetEndLocation(valueOrDefault.CurrentPosition.X, valueOrDefault.CurrentPosition.Y, valueOrDefault.CurrentPosition.Z);
			valueOrDefault.LastFramePosition.FromUeVector(valueOrDefault.CurrentPosition);
			if (TraceElementCommon.Instance.SphereTrace(valueOrDefault.SphereElement, "ANS_DetectSphere"))
			{
				if (this.SendGamePlayEvent)
				{
					BaseAbilityComponent component = characterActorComponent.Entity.GetComponent<BaseAbilityComponent>();
					if (component == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.AnimNotify;
						ELogAuthor author2 = ELogAuthor.HCW;
						string message2 = "使用DetectSphereANS的角色没有AbilityComponent";
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
						string message3 = "使用DetectSphereANS的角色没有BaseTagComponent";
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

	// Token: 0x06001238 RID: 4664 RVA: 0x00067574 File Offset: 0x00065774
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

	// Token: 0x06001239 RID: 4665 RVA: 0x00067614 File Offset: 0x00065814
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null || tsBaseCharacter.CharacterActorComponent == null)
		{
			return true;
		}
		int entityIdNoBlueprint = tsBaseCharacter.GetEntityIdNoBlueprint();
		DetectStateSphere valueOrDefault = TsAnimNotifyStateDetectSphere.detectStateMap.GetValueOrDefault(entityIdNoBlueprint);
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
		valueOrDefault.SphereElement.Dispose();
		TsAnimNotifyStateDetectSphere.detectStateMap.Remove(entityIdNoBlueprint);
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

	// Token: 0x0600123A RID: 4666 RVA: 0x00067770 File Offset: 0x00065970
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

	// Token: 0x0600123B RID: 4667 RVA: 0x000677EB File Offset: 0x000659EB
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "球形检测碰撞";
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x000677F2 File Offset: 0x000659F2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateDetectSphere._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDetectSphere.TsAnimNotifyStateDetectSphere_C");
		}
		return TsAnimNotifyStateDetectSphere._ClassPtr;
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x00067818 File Offset: 0x00065A18
	public TsAnimNotifyStateDetectSphere() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDetectSphere.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x00067840 File Offset: 0x00065A40
	[NullableContext(1)]
	public TsAnimNotifyStateDetectSphere(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDetectSphere.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00067873 File Offset: 0x00065A73
	protected TsAnimNotifyStateDetectSphere(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x0006787C File Offset: 0x00065A7C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x000678B8 File Offset: 0x00065AB8
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x000678F4 File Offset: 0x00065AF4
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x00067927 File Offset: 0x00065B27
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000D99 RID: 3481
	[Nullable(1)]
	private static Dictionary<int, DetectStateSphere> detectStateMap;

	// Token: 0x04000D9A RID: 3482
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDetectSphere.TsAnimNotifyStateDetectSphere_C";

	// Token: 0x04000D9B RID: 3483
	private static IntPtr _ClassPtr;

	// Token: 0x04000D9C RID: 3484
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D9D RID: 3485
	private static int __PropertyOffset_Radius;

	// Token: 0x04000D9E RID: 3486
	private static int __PropertyOffset_OffsetX;

	// Token: 0x04000D9F RID: 3487
	private static int __PropertyOffset_OffsetY;

	// Token: 0x04000DA0 RID: 3488
	private static int __PropertyOffset_OffsetZ;

	// Token: 0x04000DA1 RID: 3489
	private static int __PropertyOffset_ObjectTypes;

	// Token: 0x04000DA2 RID: 3490
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private TArray<TEnumAsByte<EObjectTypeQuery>> _ObjectTypes;

	// Token: 0x04000DA3 RID: 3491
	private static int __PropertyOffset_TagOnHit;

	// Token: 0x04000DA4 RID: 3492
	private static int __PropertyOffset_SendGamePlayEvent;

	// Token: 0x04000DA5 RID: 3493
	private static int __PropertyOffset_DebugDraw;
}
