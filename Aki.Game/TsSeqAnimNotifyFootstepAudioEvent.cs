using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Audio;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E8 RID: 488
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyFootstepAudioEvent.TsSeqAnimNotifyFootstepAudioEvent_C")]
public class TsSeqAnimNotifyFootstepAudioEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00097EB3 File Offset: 0x000960B3
	// (set) Token: 0x06001E73 RID: 7795 RVA: 0x00097EC3 File Offset: 0x000960C3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe E_FootstepVariant Variant
	{
		get
		{
			return (E_FootstepVariant)(*(base.NativePtr + (IntPtr)TsSeqAnimNotifyFootstepAudioEvent.__PropertyOffset_Variant));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSeqAnimNotifyFootstepAudioEvent.__PropertyOffset_Variant) = (byte)value;
		}
	}

	// Token: 0x170004ED RID: 1261
	// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00097ED4 File Offset: 0x000960D4
	// (set) Token: 0x06001E75 RID: 7797 RVA: 0x00097F0D File Offset: 0x0009610D
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAkAudioEvent> FootstepEvent
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAkAudioEvent> result;
			if ((result = this._FootstepEvent) == null)
			{
				result = (this._FootstepEvent = new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)TsSeqAnimNotifyFootstepAudioEvent.__PropertyOffset_FootstepEvent, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsSeqAnimNotifyFootstepAudioEvent.__PropertyOffset_FootstepEvent, 1);
		}
	}

	// Token: 0x170004EE RID: 1262
	// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00097F32 File Offset: 0x00096132
	// (set) Token: 0x06001E77 RID: 7799 RVA: 0x00097F46 File Offset: 0x00096146
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe UTraceLineElement FootTraceElement
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UTraceLineElement>(base.NativePtr / (IntPtr)sizeof(void*) + TsSeqAnimNotifyFootstepAudioEvent.__PropertyOffset_FootTraceElement);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsSeqAnimNotifyFootstepAudioEvent.__PropertyOffset_FootTraceElement, value);
		}
	}

	// Token: 0x170004EF RID: 1263
	// (get) Token: 0x06001E78 RID: 7800 RVA: 0x00097F5C File Offset: 0x0009615C
	[UProperty(EPropertyFlags.CPF_None)]
	private TMap<E_FootstepVariant, string> FootstepVariantMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<E_FootstepVariant, string> result;
			if ((result = this._FootstepVariantMap) == null)
			{
				result = (this._FootstepVariantMap = new TMap<E_FootstepVariant, string>(base.NativePtr + (IntPtr)TsSeqAnimNotifyFootstepAudioEvent.__PropertyOffset_FootstepVariantMap, this));
			}
			return result;
		}
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x00097F98 File Offset: 0x00096198
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

	// Token: 0x06001E7A RID: 7802 RVA: 0x00098038 File Offset: 0x00096238
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp == null)
		{
			return false;
		}
		if (meshComp.bHiddenInGame)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (owner.bHidden)
		{
			return false;
		}
		bool flag = false;
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(owner);
		if (worldType != BP_EWorldType.Game && worldType != BP_EWorldType.PIE)
		{
			ULevelSequence selectedSequenceInEditor = SequenceUtils.GetSelectedSequenceInEditor();
			if (selectedSequenceInEditor != null)
			{
				flag = selectedSequenceInEditor.GetAnimAudio();
				if (flag)
				{
					AudioSystem.Instance.SetSwitch("footstep_texture", CharacterFootEffectComponent.EFootstepTexture.DirtSurface.ToEnumString(), owner);
					string text = (this.FootstepEvent != null) ? AudioSystem.Instance.parseAudioEventPath(this.FootstepEvent) : null;
					if (text == null)
					{
						return false;
					}
					if (!SequenceUtils.CheckIfUseAudioSeq(owner))
					{
						return false;
					}
					UAkComponent akComponent = AudioSystem.Instance.GetAkComponent(owner, null, null);
					AudioSystem.Instance.PostEvent(text.ToString(), akComponent, null);
					return true;
				}
			}
		}
		else
		{
			ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
			bool? flag2;
			if (curLevelSeqActor == null)
			{
				flag2 = null;
			}
			else
			{
				ULevelSequence sequence = curLevelSeqActor.GetSequence();
				flag2 = ((sequence != null) ? new bool?(sequence.GetAnimAudio()) : null);
			}
			bool? flag3 = flag2;
			flag = flag3.GetValueOrDefault();
		}
		if (!flag)
		{
			return false;
		}
		this.FootstepVariantMap.TryAdd(E_FootstepVariant.land, "land");
		this.FootstepVariantMap.TryAdd(E_FootstepVariant.run, "run");
		this.FootstepVariantMap.TryAdd(E_FootstepVariant.runstop, "runstop");
		this.FootstepVariantMap.TryAdd(E_FootstepVariant.sprint, "sprint");
		this.FootstepVariantMap.TryAdd(E_FootstepVariant.sprintstop, "sprintstop");
		this.FootstepVariantMap.TryAdd(E_FootstepVariant.walk, "walk");
		this.FootstepVariantMap.TryAdd(E_FootstepVariant.walkstop, "walkstop");
		this.FootstepVariantMap.TryAdd(E_FootstepVariant.turnback, "turnback");
		FVectorDouble fvectorDouble = owner.D_K2_GetActorLocation();
		this.FootTraceElement = new UTraceLineElement();
		this.FootTraceElement.bIsProfile = true;
		this.FootTraceElement.bIsSingle = true;
		this.FootTraceElement.bTraceComplex = true;
		this.FootTraceElement.bIgnoreSelf = true;
		this.FootTraceElement.WorldContextObject = owner;
		this.FootTraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		this.FootTraceElement.SetStartLocation(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z);
		this.FootTraceElement.SetEndLocation(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z - 400.0);
		UKuroTraceLibrary.LineTrace(this.FootTraceElement, "");
		UAkComponent akComponent2 = AudioSystem.Instance.GetAkComponent(owner, null, null);
		AudioSystem.Instance.SetSwitch("footstep_variant", this.FootstepVariantMap[this.Variant], owner);
		CharacterFootEffectComponent.EFootstepTexture footstepTexture = this.GetFootstepTexture();
		this.FootTraceElement.Dispose();
		string text2 = (this.FootstepEvent != null) ? AudioSystem.Instance.parseAudioEventPath(this.FootstepEvent) : null;
		if (text2 == null)
		{
			return false;
		}
		if (!SequenceUtils.CheckIfUseAudioSeq(owner))
		{
			return false;
		}
		AudioSystem.Instance.SetSwitch("footstep_texture", footstepTexture.ToEnumString(), owner);
		AudioSystem.Instance.PostEvent(text2.ToString(), akComponent2, null);
		return true;
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x00098358 File Offset: 0x00096558
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

	// Token: 0x06001E7C RID: 7804 RVA: 0x000983D3 File Offset: 0x000965D3
	protected override string GetNotifyName_Implementation()
	{
		return "SeqAnimNotifyFootstepAudioEvent";
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x000983DC File Offset: 0x000965DC
	public CharacterFootEffectComponent.EFootstepTexture GetFootstepTexture()
	{
		UTraceLineElement footTraceElement = this.FootTraceElement;
		UKuroHitResult ukuroHitResult = (footTraceElement != null) ? footTraceElement.HitResult : null;
		if (ukuroHitResult == null || !ukuroHitResult.IsValid())
		{
			return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
		}
		bool flag = false;
		UPhysicalMaterial uphysicalMaterial = UKuroRenderingRuntimeBPPluginBPLibrary.GetComponentPhysicalMaterial(ukuroHitResult.Components.Get(0));
		if (uphysicalMaterial != null && uphysicalMaterial.IsValid() && uphysicalMaterial.GetName() == "WaterLightLand")
		{
			flag = true;
		}
		if (flag)
		{
			return this.CheckWaterSurfaceType(ukuroHitResult);
		}
		Vector vector = Vector.Create();
		TraceElementCommon.Instance.GetHitLocation(ukuroHitResult, 0, vector);
		CharacterFootEffectComponent.EFootstepTexture? efootstepTexture = null;
		FoliageAudioInfo foliageAudioInfo = AudioUtils.Instance.QueryFoliageAudioPhysicalMaterial(vector.ToUeVector(false), null);
		if (foliageAudioInfo.IsHitFoliage && foliageAudioInfo.PhysicalMaterial != null)
		{
			uphysicalMaterial = foliageAudioInfo.PhysicalMaterial;
		}
		if (uphysicalMaterial != null && uphysicalMaterial.IsValid())
		{
			if (uphysicalMaterial.SurfaceType == EPhysicalSurface.SurfaceType6 || uphysicalMaterial.SurfaceType == EPhysicalSurface.SurfaceType14)
			{
				efootstepTexture = new CharacterFootEffectComponent.EFootstepTexture?(CharacterFootEffectComponent.EFootstepTexture.DirtSurface);
			}
			else
			{
				efootstepTexture = new CharacterFootEffectComponent.EFootstepTexture?(CharacterFootEffectComponent_EFootstepTextureExtensions.FromString(UKuroAudioMaterialSettings.GetFootstepTextureName(uphysicalMaterial.SurfaceType).ToString()));
			}
		}
		if (efootstepTexture == null)
		{
			efootstepTexture = new CharacterFootEffectComponent.EFootstepTexture?(CharacterFootEffectComponent.EFootstepTexture.DirtSurface);
		}
		return efootstepTexture.Value;
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x0009851C File Offset: 0x0009671C
	[NullableContext(2)]
	private CharacterFootEffectComponent.EFootstepTexture CheckWaterSurfaceType(UKuroHitResult hitResult)
	{
		if (hitResult == null)
		{
			return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
		}
		int hitCount = hitResult.GetHitCount();
		for (int i = 0; i < hitCount; i++)
		{
			if (UKuroCollisionLibrary.GetBodyInstance(hitResult, i).CollisionResponses.ResponseToChannels.GameTraceChannel2 == ECollisionResponse.ECR_Block)
			{
				return CharacterFootEffectComponent.EFootstepTexture.WaterSurface;
			}
		}
		return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x00098567 File Offset: 0x00096767
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSeqAnimNotifyFootstepAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyFootstepAudioEvent.TsSeqAnimNotifyFootstepAudioEvent_C");
		}
		return TsSeqAnimNotifyFootstepAudioEvent._ClassPtr;
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x0009858C File Offset: 0x0009678C
	public TsSeqAnimNotifyFootstepAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyFootstepAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x000985B4 File Offset: 0x000967B4
	public TsSeqAnimNotifyFootstepAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyFootstepAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x000985E7 File Offset: 0x000967E7
	protected TsSeqAnimNotifyFootstepAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x000985F0 File Offset: 0x000967F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x00098623 File Offset: 0x00096823
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012C1 RID: 4801
	private const int MATERIAL_ID_WAT = 6;

	// Token: 0x040012C2 RID: 4802
	private const int MATERIAL_ID_SHR = 14;

	// Token: 0x040012C3 RID: 4803
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyFootstepAudioEvent.TsSeqAnimNotifyFootstepAudioEvent_C";

	// Token: 0x040012C4 RID: 4804
	private static IntPtr _ClassPtr;

	// Token: 0x040012C5 RID: 4805
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012C6 RID: 4806
	private static int __PropertyOffset_Variant;

	// Token: 0x040012C7 RID: 4807
	private static int __PropertyOffset_FootstepEvent;

	// Token: 0x040012C8 RID: 4808
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _FootstepEvent;

	// Token: 0x040012C9 RID: 4809
	private static int __PropertyOffset_FootTraceElement;

	// Token: 0x040012CA RID: 4810
	private static int __PropertyOffset_FootstepVariantMap;

	// Token: 0x040012CB RID: 4811
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<E_FootstepVariant, string> _FootstepVariantMap;
}
