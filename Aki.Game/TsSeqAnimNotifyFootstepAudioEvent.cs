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

// Token: 0x020001EC RID: 492
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyFootstepAudioEvent.TsSeqAnimNotifyFootstepAudioEvent_C")]
public class TsSeqAnimNotifyFootstepAudioEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700050E RID: 1294
	// (get) Token: 0x06001F0F RID: 7951 RVA: 0x0009EFD7 File Offset: 0x0009D1D7
	// (set) Token: 0x06001F10 RID: 7952 RVA: 0x0009EFE7 File Offset: 0x0009D1E7
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

	// Token: 0x1700050F RID: 1295
	// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0009EFF8 File Offset: 0x0009D1F8
	// (set) Token: 0x06001F12 RID: 7954 RVA: 0x0009F031 File Offset: 0x0009D231
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

	// Token: 0x17000510 RID: 1296
	// (get) Token: 0x06001F13 RID: 7955 RVA: 0x0009F056 File Offset: 0x0009D256
	// (set) Token: 0x06001F14 RID: 7956 RVA: 0x0009F06A File Offset: 0x0009D26A
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

	// Token: 0x17000511 RID: 1297
	// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0009F080 File Offset: 0x0009D280
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

	// Token: 0x06001F16 RID: 7958 RVA: 0x0009F0BC File Offset: 0x0009D2BC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSeqAnimNotifyFootstepAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsSeqAnimNotifyFootstepAudioEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001F17 RID: 7959 RVA: 0x0009F174 File Offset: 0x0009D374
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

	// Token: 0x06001F18 RID: 7960 RVA: 0x0009F494 File Offset: 0x0009D694
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSeqAnimNotifyFootstepAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsSeqAnimNotifyFootstepAudioEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001F19 RID: 7961 RVA: 0x0009F524 File Offset: 0x0009D724
	protected override string GetNotifyName_Implementation()
	{
		return "SeqAnimNotifyFootstepAudioEvent";
	}

	// Token: 0x06001F1A RID: 7962 RVA: 0x0009F52C File Offset: 0x0009D72C
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

	// Token: 0x06001F1B RID: 7963 RVA: 0x0009F66C File Offset: 0x0009D86C
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

	// Token: 0x06001F1C RID: 7964 RVA: 0x0009F6B7 File Offset: 0x0009D8B7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSeqAnimNotifyFootstepAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyFootstepAudioEvent.TsSeqAnimNotifyFootstepAudioEvent_C");
		}
		return TsSeqAnimNotifyFootstepAudioEvent._ClassPtr;
	}

	// Token: 0x06001F1D RID: 7965 RVA: 0x0009F6DC File Offset: 0x0009D8DC
	public TsSeqAnimNotifyFootstepAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyFootstepAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x0009F704 File Offset: 0x0009D904
	public TsSeqAnimNotifyFootstepAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyFootstepAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001F1F RID: 7967 RVA: 0x0009F737 File Offset: 0x0009D937
	protected TsSeqAnimNotifyFootstepAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x0009F740 File Offset: 0x0009D940
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x0009F773 File Offset: 0x0009D973
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001304 RID: 4868
	private const int MATERIAL_ID_WAT = 6;

	// Token: 0x04001305 RID: 4869
	private const int MATERIAL_ID_SHR = 14;

	// Token: 0x04001306 RID: 4870
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyFootstepAudioEvent.TsSeqAnimNotifyFootstepAudioEvent_C";

	// Token: 0x04001307 RID: 4871
	private static IntPtr _ClassPtr;

	// Token: 0x04001308 RID: 4872
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001309 RID: 4873
	private static int __PropertyOffset_Variant;

	// Token: 0x0400130A RID: 4874
	private static int __PropertyOffset_FootstepEvent;

	// Token: 0x0400130B RID: 4875
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _FootstepEvent;

	// Token: 0x0400130C RID: 4876
	private static int __PropertyOffset_FootTraceElement;

	// Token: 0x0400130D RID: 4877
	private static int __PropertyOffset_FootstepVariantMap;

	// Token: 0x0400130E RID: 4878
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<E_FootstepVariant, string> _FootstepVariantMap;
}
