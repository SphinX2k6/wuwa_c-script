using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Season;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020025B3 RID: 9651
[NullableContext(1)]
[Nullable(0)]
public class CharacterFootEffectComponent : EntityComponent
{
	// Token: 0x1700256A RID: 9578
	// (get) Token: 0x06017F13 RID: 98067 RVA: 0x00724AD4 File Offset: 0x00722CD4
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CharacterAudioComponent),
				typeof(CharacterAnimationComponent),
				typeof(CharacterUnifiedStateComponent),
				typeof(CreatureDataComponent)
			};
		}
	}

	// Token: 0x06017F14 RID: 98068 RVA: 0x00724B28 File Offset: 0x00722D28
	protected override bool OnInit()
	{
		base.OnInit();
		return true;
	}

	// Token: 0x06017F15 RID: 98069 RVA: 0x00724B34 File Offset: 0x00722D34
	protected override bool OnStart()
	{
		base.OnStart();
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		CharacterAnimationComponent component2 = base.Entity.GetComponent<CharacterAnimationComponent>();
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		CharacterAudioComponent component3 = base.Entity.GetComponent<CharacterAudioComponent>();
		if (component3 == null || !component3.Valid)
		{
			return false;
		}
		CreatureDataComponent component4 = base.Entity.GetComponent<CreatureDataComponent>();
		if (component4 == null || !component4.Valid)
		{
			return false;
		}
		CharacterUnifiedStateComponent component5 = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component5 == null || !component5.Valid)
		{
			return false;
		}
		this.ActorComp = component;
		this.UnifiedStateComp = component5;
		TsBaseCharacter actor = this.ActorComp.Actor;
		if (actor.IsValid())
		{
			this.EnviInteractionComp = (actor.GetComponentByClass(UKuroEnviInteractionComponent.StaticClass()) as UKuroEnviInteractionComponent);
		}
		this.FootTraceElement = UE.NewObject<UTraceSphereElement>(GlobalData.World, null, EObjectFlags.RF_NoFlags);
		this.FootTraceElement.bIsSingle = true;
		this.FootTraceElement.bTraceComplex = true;
		this.FootTraceElement.bIgnoreSelf = true;
		this.FootTraceElement.WorldContextObject = this.ActorComp.Actor;
		this.FootTraceElement.Radius = 10f;
		this.FootTraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		foreach (SFootprint sfootprint in DataTableUtil.GetDataTableAllRow<SFootprint>(EDataTable.Footprint))
		{
			CharacterFootEffectComponent.CharacterFootEffectConfig characterFootEffectConfig = new CharacterFootEffectComponent.CharacterFootEffectConfig();
			characterFootEffectConfig.EffectPath = sfootprint.Effect;
			characterFootEffectConfig.PriorToGlobal = sfootprint.PriorToGlobal;
			this.FootprintMap.Add(sfootprint.SurfaceType, characterFootEffectConfig);
		}
		List<SCharacterFootprint> dataTableAllRow = DataTableUtil.GetDataTableAllRow<SCharacterFootprint>(EDataTable.SCharacterFootPrint);
		for (int i = 0; i < dataTableAllRow.Count; i++)
		{
			SCharacterFootprint scharacterFootprint = dataTableAllRow[i];
			CharacterFootEffectComponent.CharacterSpecialFootEffectConfig characterSpecialFootEffectConfig = new CharacterFootEffectComponent.CharacterSpecialFootEffectConfig();
			characterSpecialFootEffectConfig.Tag = scharacterFootprint.Tag;
			characterSpecialFootEffectConfig.EffectPath = scharacterFootprint.Effect;
			characterSpecialFootEffectConfig.SortId = scharacterFootprint.SortID;
			characterSpecialFootEffectConfig.OverrideGlobalFootEffect = scharacterFootprint.OverrideGlobalFootEffect;
			characterSpecialFootEffectConfig.OverrideOtherCharacterFootEffect = scharacterFootprint.OverrideOtherCharacterFootEffect;
			int key = scharacterFootprint.Tag.TagId();
			this.CharacterFootprintMap.TryAdd(key, new List<CharacterFootEffectComponent.CharacterSpecialFootEffectConfig>());
			this.CharacterFootprintMap[key].Add(characterSpecialFootEffectConfig);
		}
		this.LeftFootprintDelegate = DelegateUtils.ToManualReleaseDelegate<FAsyncTraceDelegate>(new Action<bool, UTraceBaseElement, double, double>(this.LeftFootprintHandle));
		this.RightFootprintDelegate = DelegateUtils.ToManualReleaseDelegate<FAsyncTraceDelegate>(new Action<bool, UTraceBaseElement, double, double>(this.RightFootprintHandle));
		this.FootVoiceDelegate = DelegateUtils.ToManualReleaseDelegate<FAsyncTraceDelegate>(new Action<bool, UTraceBaseElement, double, double>(this.FootVoiceHandle));
		this.SeasonFootstepDelegate = DelegateUtils.ToManualReleaseDelegate<FAsyncTraceDelegate>(new Action<bool, UTraceBaseElement, double, double>(this.SeasonFootstepHandle));
		this.SeasonTraceElement = new UTraceLineElement();
		this.SeasonTraceElement.bIsSingle = true;
		this.SeasonTraceElement.bTraceComplex = false;
		this.SeasonTraceElement.bIgnoreSelf = true;
		this.SeasonTraceElement.WorldContextObject = this.ActorComp.Actor;
		this.SeasonTraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		return true;
	}

	// Token: 0x06017F16 RID: 98070 RVA: 0x00724E68 File Offset: 0x00723068
	protected override bool OnEnd()
	{
		this.ActorComp = null;
		UTraceSphereElement footTraceElement = this.FootTraceElement;
		if (footTraceElement != null)
		{
			footTraceElement.Dispose();
		}
		this.FootTraceElement = null;
		this.FootprintMap.Clear();
		this.CharacterFootprintMap.Clear();
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, UTraceBaseElement, double, double>(this.LeftFootprintHandle));
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, UTraceBaseElement, double, double>(this.RightFootprintHandle));
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, UTraceBaseElement, double, double>(this.FootVoiceHandle));
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, UTraceBaseElement, double, double>(this.SeasonFootstepHandle));
		this.LeftFootprintDelegate = null;
		this.RightFootprintDelegate = null;
		this.FootVoiceDelegate = null;
		this.SeasonFootstepDelegate = null;
		UTraceLineElement seasonTraceElement = this.SeasonTraceElement;
		if (seasonTraceElement != null)
		{
			seasonTraceElement.Dispose();
		}
		this.SeasonTraceElement = null;
		return true;
	}

	// Token: 0x06017F17 RID: 98071 RVA: 0x00724F23 File Offset: 0x00723123
	protected override void OnTick(float delta)
	{
		this.UpdateEnvironmentInfoAtFootLocation();
	}

	// Token: 0x06017F18 RID: 98072 RVA: 0x00724F2C File Offset: 0x0072312C
	public TraceHandle DetectFootGround(FName boneName, FAsyncTraceDelegate delg)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		bool flag;
		if (actorComp == null)
		{
			flag = (null != null);
		}
		else
		{
			TsBaseCharacter actor = actorComp.Actor;
			flag = (((actor != null) ? actor.Mesh : null) != null);
		}
		if (!flag)
		{
			global::Log.Instance.Error(ELogModule.Character, ELogAuthor.LRX, "CharacterFootEffectComponent's ActorComp or ActorComp.Actor or ActorComp.Actor.Mesh is null!", default(ReadOnlySpan<ValueTuple<string, object>>));
			throw new ArgumentNullException();
		}
		if (this.UnifiedStateComp == null)
		{
			global::Log.Instance.Warn(ELogModule.Character, ELogAuthor.LRX, "CharacterFootEffectComponent's UnifiedStateComp is null!", default(ReadOnlySpan<ValueTuple<string, object>>));
			throw new ArgumentNullException();
		}
		this.LastDetectFootstepTime = Time.Instance.Now;
		Vector startLocation = this.StartLocation;
		FVectorDouble fvectorDouble = this.ActorComp.Actor.Mesh.D_GetSocketLocation(boneName);
		startLocation.FromUeVector(fvectorDouble);
		this.ActorComp.ActorUpProxy.Multiply((double)((this.UnifiedStateComp.MoveState == ECharMoveState.Sprint) ? -50 : -15), this.EndLocation);
		this.EndLocation.AdditionEqual(this.StartLocation);
		TraceElementCommon.Instance.SetStartLocation(this.FootTraceElement, this.StartLocation);
		TraceElementCommon.Instance.SetEndLocation(this.FootTraceElement, this.EndLocation);
		return TraceElementCommon.Instance.AsyncSphereTrace(this.FootTraceElement, "CharacterFootEffectComponent_FootTrace", delg);
	}

	// Token: 0x06017F19 RID: 98073 RVA: 0x0072505C File Offset: 0x0072325C
	private ESeason? GetPlayerInsideSeason()
	{
		SeasonController instance = SeasonController.Instance;
		SeasonModel instance2 = SeasonModel.Instance;
		if (instance2 != null && instance != null)
		{
			foreach (int areaId in instance2.ActiveAreaIds)
			{
				if (instance2.IsAreaActive(areaId))
				{
					return instance.GetSeasonByAreaId(areaId);
				}
			}
		}
		return null;
	}

	// Token: 0x06017F1A RID: 98074 RVA: 0x007250DC File Offset: 0x007232DC
	public CharacterFootEffectComponent.EFootstepTexture GetFootstepTexture()
	{
		if (this.FootTraceElement == null)
		{
			throw new ArgumentNullException("FootTraceElement");
		}
		UTraceSphereElement footTraceElement = this.FootTraceElement;
		UKuroHitResult ukuroHitResult = (footTraceElement != null) ? footTraceElement.HitResult : null;
		if (ukuroHitResult == null || !ukuroHitResult.IsValid())
		{
			return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		TsBaseCharacter tsBaseCharacter = (actorComp != null) ? actorComp.Actor : null;
		if (tsBaseCharacter == null || !tsBaseCharacter.IsValid())
		{
			return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
		}
		Vector tmpHitLocation = this.TmpHitLocation;
		bool flag = false;
		TWeakObjectPtr<UPhysicalMaterial>? tweakObjectPtr = (ukuroHitResult.PhysMaterials.Num() > 0) ? new TWeakObjectPtr<UPhysicalMaterial>?(ukuroHitResult.PhysMaterials.Get(0)) : null;
		CharRenderingComponent charRenderingComponent = tsBaseCharacter.CharRenderingComponent;
		if (charRenderingComponent != null && charRenderingComponent.GetInWater(2f))
		{
			flag = ((double)tsBaseCharacter.CharRenderingComponent.GetWaterHitLocationZ() > tmpHitLocation.Z - (double)this.FootTraceElement.Radius);
		}
		else
		{
			UPhysicalMaterial componentPhysicalMaterial = UKuroRenderingRuntimeBPPluginBPLibrary.GetComponentPhysicalMaterial(ukuroHitResult.Components.Get(0));
			if (componentPhysicalMaterial != null && componentPhysicalMaterial.IsValid() && componentPhysicalMaterial.GetName() == "WaterLightLand")
			{
				flag = true;
			}
		}
		if (flag)
		{
			return this.CheckWaterSurfaceType();
		}
		TraceElementCommon.Instance.GetHitLocation(ukuroHitResult, 0, tmpHitLocation);
		FoliageAudioInfo foliageAudioInfo = AudioUtils.Instance.QueryFoliageAudioPhysicalMaterial(tmpHitLocation.ToUeVector(false), base.Entity);
		bool flag2 = false;
		CharacterFootEffectComponent.EFootstepTexture result = CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
		if (foliageAudioInfo.IsHitFoliage && foliageAudioInfo.PhysicalMaterial != null)
		{
			tweakObjectPtr = new TWeakObjectPtr<UPhysicalMaterial>?(new TWeakObjectPtr<UPhysicalMaterial>(foliageAudioInfo.PhysicalMaterial));
		}
		if (this.GetPlayerInsideSeason().GetValueOrDefault() == ESeason.Winter && this.IsOnExposedSurface)
		{
			flag2 = true;
			result = CharacterFootEffectComponent.EFootstepTexture.SnowSurface;
		}
		else if (tweakObjectPtr != null && tweakObjectPtr.GetValueOrDefault().IsValid(false, false))
		{
			TEnumAsByte<EPhysicalSurface> surfaceType = tweakObjectPtr.Value.Get().SurfaceType;
			if (surfaceType == EPhysicalSurface.SurfaceType6 || surfaceType == EPhysicalSurface.SurfaceType14)
			{
				flag2 = true;
				result = CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
			}
			else
			{
				flag2 = Enum.TryParse<CharacterFootEffectComponent.EFootstepTexture>(UKuroAudioMaterialSettings.GetFootstepTextureName(surfaceType).ToString(), out result);
				if (!flag2)
				{
					result = CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
				}
			}
		}
		if (!flag2)
		{
			result = CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
		}
		return result;
	}

	// Token: 0x06017F1B RID: 98075 RVA: 0x00725308 File Offset: 0x00723508
	public void PostFootstepVoice()
	{
		if (Time.Instance.Now - this.LastDetectFootstepTime < 150.0)
		{
			this.PostFootstepAudio();
			return;
		}
		this.LastDetectFootstepTime = Time.Instance.Now;
		if (this.ActorComp == null)
		{
			global::Log.Instance.Error(ELogModule.Character, ELogAuthor.LRX, "CharacterFootEffectComponent's ActorComp is null!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.StartLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.ActorComp.ActorUpProxy.Multiply((double)(-15f - this.ActorComp.ScaledHalfHeight), this.EndLocation);
		this.EndLocation.AdditionEqual(this.StartLocation);
		TraceElementCommon.Instance.SetStartLocation(this.FootTraceElement, this.StartLocation);
		TraceElementCommon.Instance.SetEndLocation(this.FootTraceElement, this.EndLocation);
		this.TraceHandleFootVoice = TraceElementCommon.Instance.AsyncSphereTrace(this.FootTraceElement, "CharacterFootEffectComponent_FootTrace", this.FootVoiceDelegate);
		if (this.GetPlayerInsideSeason().GetValueOrDefault() == ESeason.Winter)
		{
			this.ActorComp.ActorUpProxy.Multiply(5000.0, this.TmpVector);
			this.TmpVector.AdditionEqual(this.ActorComp.ActorLocationProxy);
			TraceElementCommon.Instance.SetStartLocation(this.SeasonTraceElement, this.TmpVector);
			TraceElementCommon.Instance.SetEndLocation(this.SeasonTraceElement, this.EndLocation);
			this.TraceHandleSnowFootprint = TraceElementCommon.Instance.AsyncLineTrace(this.SeasonTraceElement, "CharacterFootEffectComponent_FootTrace", this.SeasonFootstepDelegate);
			return;
		}
		this.IsOnExposedSurface = false;
	}

	// Token: 0x06017F1C RID: 98076 RVA: 0x007254B4 File Offset: 0x007236B4
	[return: Nullable(2)]
	private string GetFootprintEffectPath(UPhysicalMaterial localPhysMaterial)
	{
		UPhysicalMaterial getPhysMaterial = SceneTeamModel.Instance.GetPhysMaterial;
		CharacterFootEffectComponent.CharacterFootEffectConfig characterFootEffectConfig;
		this.FootprintMap.TryGetValue(localPhysMaterial.SurfaceType, out characterFootEffectConfig);
		string text = null;
		if (getPhysMaterial != null)
		{
			CharacterFootEffectComponent.CharacterFootEffectConfig characterFootEffectConfig2;
			this.FootprintMap.TryGetValue(getPhysMaterial.SurfaceType, out characterFootEffectConfig2);
			if (characterFootEffectConfig2 != null && (characterFootEffectConfig == null || !characterFootEffectConfig.PriorToGlobal))
			{
				TSoftObjectPtr<UEffectModelBase> effectPath = characterFootEffectConfig2.EffectPath;
				text = ((effectPath != null) ? effectPath.ToAssetPathName() : null);
			}
		}
		if (string.IsNullOrEmpty(text) && characterFootEffectConfig != null)
		{
			TSoftObjectPtr<UEffectModelBase> effectPath2 = characterFootEffectConfig.EffectPath;
			text = ((effectPath2 != null) ? effectPath2.ToAssetPathName() : null);
		}
		return text;
	}

	// Token: 0x06017F1D RID: 98077 RVA: 0x00725544 File Offset: 0x00723744
	private unsafe List<string> GetFootprintEffectPaths(UPhysicalMaterial localPhysMaterial)
	{
		string footprintEffectPath = this.GetFootprintEffectPath(localPhysMaterial);
		CharacterFootEffectComponent.CharacterSpecialFootEffectConfig bestCharacterFootEffectConfig = this.GetBestCharacterFootEffectConfig();
		if (bestCharacterFootEffectConfig != null)
		{
			return this.ApplyCharacterEffectStrategy(bestCharacterFootEffectConfig, footprintEffectPath);
		}
		if (string.IsNullOrEmpty(footprintEffectPath))
		{
			return new List<string>();
		}
		int num = 1;
		List<string> list = new List<string>(num);
		CollectionsMarshal.SetCount<string>(list, num);
		Span<string> span = CollectionsMarshal.AsSpan<string>(list);
		int index = 0;
		*span[index] = footprintEffectPath;
		return list;
	}

	// Token: 0x06017F1E RID: 98078 RVA: 0x007255A0 File Offset: 0x007237A0
	[NullableContext(2)]
	private CharacterFootEffectComponent.CharacterSpecialFootEffectConfig GetBestCharacterFootEffectConfig()
	{
		Entity entity = base.Entity;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent == null)
		{
			return null;
		}
		CharacterFootEffectComponent.CharacterSpecialFootEffectConfig result = null;
		int num = int.MinValue;
		foreach (KeyValuePair<int, List<CharacterFootEffectComponent.CharacterSpecialFootEffectConfig>> keyValuePair in this.CharacterFootprintMap)
		{
			if (baseTagComponent.HasTag(keyValuePair.Key))
			{
				foreach (CharacterFootEffectComponent.CharacterSpecialFootEffectConfig characterSpecialFootEffectConfig in keyValuePair.Value)
				{
					if (characterSpecialFootEffectConfig.SortId > num)
					{
						num = characterSpecialFootEffectConfig.SortId;
						result = characterSpecialFootEffectConfig;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06017F1F RID: 98079 RVA: 0x00725670 File Offset: 0x00723870
	private List<string> ApplyCharacterEffectStrategy(CharacterFootEffectComponent.CharacterSpecialFootEffectConfig characterConfig, [Nullable(2)] string baseEffectPath)
	{
		TSoftObjectPtr<UEffectModelBase> effectPath = characterConfig.EffectPath;
		string text = (effectPath != null) ? effectPath.ToAssetPathName() : null;
		List<string> list = new List<string>();
		int overrideGlobalFootEffect = characterConfig.OverrideGlobalFootEffect;
		if (overrideGlobalFootEffect != 1)
		{
			if (overrideGlobalFootEffect == 2)
			{
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
			else if (!string.IsNullOrEmpty(baseEffectPath))
			{
				list.Add(baseEffectPath);
			}
		}
		else
		{
			if (!string.IsNullOrEmpty(text))
			{
				list.Add(text);
			}
			if (!string.IsNullOrEmpty(baseEffectPath))
			{
				list.Add(baseEffectPath);
			}
		}
		return list;
	}

	// Token: 0x06017F20 RID: 98080 RVA: 0x007256E8 File Offset: 0x007238E8
	private void CalculateFootprintTransform(UKuroHitResult hitResult, Vector baseLocation, Vector outLocation, Rotator outRotation)
	{
		if (this.ActorComp == null)
		{
			throw new ArgumentNullException("ActorComp");
		}
		this.ActorComp.ActorForwardProxy.Multiply(5.0, this.TmpVector);
		TraceElementCommon.Instance.GetImpactNormal(hitResult, 0, this.TmpVector2);
		Vector.VectorPlaneProject(this.TmpVector, this.TmpVector2, this.TmpVector3);
		this.TmpVector3.AdditionEqual(baseLocation);
		outLocation.DeepCopy(this.TmpVector3);
		MathUtils.Instance.LookRotationUpFirst(this.ActorComp.ActorForwardProxy, this.TmpVector2, outRotation);
	}

	// Token: 0x06017F21 RID: 98081 RVA: 0x00725788 File Offset: 0x00723988
	private void SpawnRainFootEffect(Vector location, Rotator rotation, [Nullable(2)] UPhysicalMaterial localPhysmaterial)
	{
		if (localPhysmaterial == null || this.EnviInteractionComp == null || this.ActorComp == null || !this.EnviInteractionComp.bUpdateRainOcclusion)
		{
			return;
		}
		if (localPhysmaterial.SurfaceType != EPhysicalSurface.SurfaceType10 && this.EnviInteractionComp.GetRainWalkOcclusionParam() < 0.9f && !this.EnviInteractionComp.GetEnviInteractionData().bInWater)
		{
			Vector tmpVector = this.TmpVector3;
			TsBaseCharacter tsBaseCharacter = this.ActorComp.Owner as TsBaseCharacter;
			if (tsBaseCharacter != null && tsBaseCharacter != null && tsBaseCharacter.Mesh != null)
			{
				tmpVector.Z = tsBaseCharacter.Mesh.D_K2_GetComponentLocation().Z;
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FRotator frotator = this.TmpRotator.ToUeRotator();
			FVectorDouble fvectorDouble = this.TmpVector3.ToUeVector(false);
			FVectorDouble fvectorDouble2 = Vector.OneVectorProxy.ToUeVector(false);
			FVector fvector = fvectorDouble2;
			FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector));
			instance.SpawnUnloopedEffect(world, ftransformDouble, "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_FX_SI3_Water_Step01.DA_FX_SI3_Water_Step01", "[SceneCharacterFootprintEffect.SpawnRainFootEffect]", null, global::EEffectType.Scene, null, null, null, false, false);
		}
	}

	// Token: 0x06017F22 RID: 98082 RVA: 0x00725898 File Offset: 0x00723A98
	[NullableContext(2)]
	private void TriggerFootprintEffectInternal(UKuroHitResult hitResult)
	{
		if (hitResult == null || !hitResult.bBlockingHit)
		{
			return;
		}
		if (Time.Instance.Now - this.LastSpawnFootprintTime < 200.0)
		{
			return;
		}
		Vector tmpHitLocation = this.TmpHitLocation;
		TraceElementCommon.Instance.GetHitLocation(hitResult, 0, tmpHitLocation);
		if (Vector.DistSquared(tmpHitLocation, this.LastSpawnFootprintLocation) < 500.0)
		{
			return;
		}
		if (hitResult.PhysMaterials == null || hitResult.PhysMaterials.Num() <= 0)
		{
			return;
		}
		TWeakObjectPtr<UPhysicalMaterial> weak = hitResult.PhysMaterials.Get(0);
		this.CalculateFootprintTransform(hitResult, tmpHitLocation, this.TmpVector3, this.TmpRotator);
		this.SpawnRainFootEffect(this.TmpVector3, this.TmpRotator, weak);
		this.LastSpawnFootprintTime = Time.Instance.Now;
		this.LastSpawnFootprintLocation.DeepCopy(tmpHitLocation);
	}

	// Token: 0x06017F23 RID: 98083 RVA: 0x0072596C File Offset: 0x00723B6C
	public void TriggerFootprint(bool isLeftFoot)
	{
		if (this.FootTraceElement == null || this.FootTraceElement.HitResult == null || !this.FootTraceElement.HitResult.bBlockingHit || this.FootTraceElement.HitResult.GetHitCount() == 0)
		{
			return;
		}
		if (Time.Instance.Now - this.LastSpawnFootprintTime < 200.0)
		{
			return;
		}
		if (this.ActorComp == null)
		{
			throw new ArgumentNullException("ActorComp");
		}
		TsBaseCharacter actor = this.ActorComp.Actor;
		if (actor == null)
		{
			throw new ArgumentNullException("ActorComp.Actor");
		}
		USkeletalMeshComponent mesh = actor.Mesh;
		if (mesh == null)
		{
			throw new ArgumentNullException("ActorComp.Actor.Mesh");
		}
		if (isLeftFoot)
		{
			Vector footLocation = this.FootLocation;
			FVectorDouble fvectorDouble = mesh.D_GetSocketLocation(CharacterFootEffectComponent.LeftFootSocketName);
			footLocation.FromUeVector(fvectorDouble);
		}
		else
		{
			Vector footLocation2 = this.FootLocation;
			FVectorDouble fvectorDouble = mesh.D_GetSocketLocation(CharacterFootEffectComponent.RightFootSocketName);
			footLocation2.FromUeVector(fvectorDouble);
		}
		if (Vector.DistSquared(this.FootLocation, this.LastSpawnFootprintLocation) < 500.0)
		{
			return;
		}
		UPhysicalMaterial componentPhysicalMaterial = UKuroRenderingRuntimeBPPluginBPLibrary.GetComponentPhysicalMaterial(this.FootTraceElement.HitResult.Components.Get(0));
		TArray<TWeakObjectPtr<UPhysicalMaterial>> physMaterials = this.FootTraceElement.HitResult.PhysMaterials;
		TWeakObjectPtr<UPhysicalMaterial>? tweakObjectPtr = (physMaterials != null) ? new TWeakObjectPtr<UPhysicalMaterial>?(physMaterials.Get(0)) : null;
		List<string> list = new List<string>();
		if (componentPhysicalMaterial != null)
		{
			list = this.GetFootprintEffectPaths(componentPhysicalMaterial);
		}
		if (tweakObjectPtr != null)
		{
			TWeakObjectPtr<UPhysicalMaterial>? tweakObjectPtr2 = tweakObjectPtr;
			foreach (string item in this.GetFootprintEffectPaths((tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null))
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		this.CalculateFootprintTransform(this.FootTraceElement.HitResult, this.FootLocation, this.TmpVector3, this.TmpRotator);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i];
			if (!string.IsNullOrEmpty(text))
			{
				string text2;
				if (list.Count != 1)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[SceneCharacterFootprintEffect.SpawnEffect.$");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i);
					defaultInterpolatedStringHandler.AppendLiteral("]");
					text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					text2 = "[SceneCharacterFootprintEffect.SpawnEffect]";
				}
				string reason = text2;
				EffectSystem instance = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FRotator frotator = this.TmpRotator.ToUeRotator();
				FVectorDouble fvectorDouble = this.TmpVector3.ToUeVector(false);
				FVectorDouble fvectorDouble2 = Vector.OneVectorProxy.ToUeVector(false);
				FVector fvector = fvectorDouble2;
				FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector));
				instance.SpawnUnloopedEffect(world, ftransformDouble, text, reason, null, global::EEffectType.Scene, null, null, null, false, false);
			}
		}
		if (isLeftFoot)
		{
			if (this.LeftFootprintDelegate == null)
			{
				throw new ArgumentNullException("LeftFootprintDelegate");
			}
			this.TraceHandleLeftFootprint = this.DetectFootGround(CharacterFootEffectComponent.LeftFootSocketName, this.LeftFootprintDelegate);
			return;
		}
		else
		{
			if (this.RightFootprintDelegate == null)
			{
				throw new ArgumentNullException("RightFootprintDelegate");
			}
			this.TraceHandleRightFootprint = this.DetectFootGround(CharacterFootEffectComponent.RightFootSocketName, this.RightFootprintDelegate);
			return;
		}
	}

	// Token: 0x06017F24 RID: 98084 RVA: 0x00725C8C File Offset: 0x00723E8C
	private unsafe void LeftFootprintHandle(bool hitResult, UTraceBaseElement element, double frame, double index)
	{
		if (this.TraceHandleLeftFootprint != null && frame < (double)this.TraceHandleLeftFootprint.Frame)
		{
			return;
		}
		if (this.TraceHandleLeftFootprint != null && frame == (double)this.TraceHandleLeftFootprint.Frame && index < (double)this.TraceHandleLeftFootprint.Index)
		{
			return;
		}
		if (!hitResult)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Detect Footprint Failed";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "location";
			CharacterActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? actorComp.ActorLocationProxy : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("start", this.StartLocation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("end", this.EndLocation);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		TraceElementCommon.Instance.GetHitLocation(element.HitResult, 0, this.TmpHitLocation);
		this.TriggerFootprintEffectInternal(element.HitResult);
		if (hitResult)
		{
			EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.OnCharFootOnTheGround, true);
			EventSystem.Instance.Emit<bool>(EEventName.OnCharFootOnTheGround, true);
		}
		else
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Test;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "Detect TriggerEffect Failed";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item2 = "location";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ptr2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? actorComp2.ActorLocationProxy : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("start", this.StartLocation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("end", this.EndLocation);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		WorldController.Instance.EnvironmentInfoUpdate(this.TmpHitLocation.ToUeVector(false), this.ActorComp.IsRoleAndCtrlByMe, false);
	}

	// Token: 0x06017F25 RID: 98085 RVA: 0x00725E60 File Offset: 0x00724060
	private unsafe void RightFootprintHandle(bool hitResult, UTraceBaseElement element, double frame, double index)
	{
		if (this.TraceHandleRightFootprint != null && frame < (double)this.TraceHandleRightFootprint.Frame)
		{
			return;
		}
		if (this.TraceHandleRightFootprint != null && frame == (double)this.TraceHandleRightFootprint.Frame && index < (double)this.TraceHandleRightFootprint.Index)
		{
			return;
		}
		if (!hitResult)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Detect Footprint Failed";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "location";
			CharacterActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? actorComp.ActorLocationProxy : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("start", this.StartLocation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("end", this.EndLocation);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		TraceElementCommon.Instance.GetHitLocation(element.HitResult, 0, this.TmpHitLocation);
		this.TriggerFootprintEffectInternal(element.HitResult);
		if (hitResult)
		{
			EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.OnCharFootOnTheGround, false);
			EventSystem.Instance.Emit<bool>(EEventName.OnCharFootOnTheGround, false);
		}
		else
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Test;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "Detect TriggerEffect Failed";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item2 = "location";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ptr2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? actorComp2.ActorLocationProxy : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("start", this.StartLocation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("end", this.EndLocation);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		if (this.ActorComp == null)
		{
			throw new ArgumentNullException("ActorComp");
		}
		WorldController.Instance.EnvironmentInfoUpdate(this.TmpHitLocation.ToUeVector(false), this.ActorComp.IsRoleAndCtrlByMe, false);
	}

	// Token: 0x06017F26 RID: 98086 RVA: 0x00726048 File Offset: 0x00724248
	private unsafe void FootVoiceHandle(bool hitResult, UTraceBaseElement element, double frame, double index)
	{
		if (this.TraceHandleFootVoice != null && frame < (double)this.TraceHandleFootVoice.Frame)
		{
			this.PostFootstepAudio();
			return;
		}
		if (this.TraceHandleFootVoice != null && frame == (double)this.TraceHandleFootVoice.Frame && index < (double)this.TraceHandleFootVoice.Index)
		{
			this.PostFootstepAudio();
			return;
		}
		if (!hitResult)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Detect Footprint Failed";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "location";
			CharacterActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? actorComp.ActorLocationProxy : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("start", this.StartLocation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("end", this.EndLocation);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (((element != null) ? element.HitResult : null) != null)
		{
			TraceElementCommon.Instance.GetHitLocation(element.HitResult, 0, this.TmpHitLocation);
		}
		this.FootVoiceHitLocation.DeepCopy(this.TmpHitLocation);
		this.PostFootstepAudio();
	}

	// Token: 0x06017F27 RID: 98087 RVA: 0x0072616C File Offset: 0x0072436C
	private void SeasonFootstepHandle(bool hitResult, UTraceBaseElement element, double frame, double index)
	{
		if (this.TraceHandleSnowFootprint != null && frame < (double)this.TraceHandleSnowFootprint.Frame)
		{
			return;
		}
		if (this.TraceHandleSnowFootprint != null && frame == (double)this.TraceHandleSnowFootprint.Frame && index < (double)this.TraceHandleSnowFootprint.Index)
		{
			return;
		}
		if (hitResult)
		{
			bool flag;
			if (element == null)
			{
				flag = true;
			}
			else
			{
				UKuroHitResult hitResult2 = element.HitResult;
				flag = !((hitResult2 != null) ? new bool?(hitResult2.bBlockingHit) : null).GetValueOrDefault();
			}
			if (!flag)
			{
				TraceElementCommon.Instance.GetHitLocation(element.HitResult, 0, this.SnowHitLocation);
				bool flag2 = false;
				if (element.HitResult.Actors.Num() > 0)
				{
					TWeakObjectPtr<AActor> tweakObjectPtr = element.HitResult.Actors.Get(0);
					ULevel ulevel = tweakObjectPtr.IsValid(false, false) ? tweakObjectPtr.Get().GetLevel() : null;
					if (ulevel != null && !ulevel.bIsPartitioned)
					{
						flag2 = true;
					}
				}
				double num = Math.Abs(this.SnowHitLocation.Z - this.FootVoiceHitLocation.Z);
				this.IsOnExposedSurface = (num <= 50.0 && !flag2);
				return;
			}
		}
		this.IsOnExposedSurface = true;
	}

	// Token: 0x06017F28 RID: 98088 RVA: 0x00726298 File Offset: 0x00724498
	private void PostFootstepAudio()
	{
		CharacterFootEffectComponent.EFootstepTexture footstepTexture = this.GetFootstepTexture();
		RoleAudioComponent component = base.Entity.GetComponent<RoleAudioComponent>();
		if (component == null)
		{
			return;
		}
		component.PostFootstepAudio(footstepTexture);
	}

	// Token: 0x06017F29 RID: 98089 RVA: 0x007262C4 File Offset: 0x007244C4
	private void UpdateEnvironmentInfoAtFootLocation()
	{
		if (TeleportModel.Instance.IsTeleport || !this.ActorComp.EnableVoxelDetection)
		{
			return;
		}
		if (this.ActorComp == null || this.UnifiedStateComp == null)
		{
			return;
		}
		if (this.UnifiedStateComp.MoveState == ECharMoveState.Stand)
		{
			return;
		}
		WorldController.Instance.EnvironmentInfoUpdate(this.ActorComp.ActorLocation, this.ActorComp.IsRoleAndCtrlByMe, false);
	}

	// Token: 0x06017F2A RID: 98090 RVA: 0x00726330 File Offset: 0x00724530
	private CharacterFootEffectComponent.EFootstepTexture CheckWaterSurfaceType()
	{
		if (this.ActorComp == null)
		{
			return CharacterFootEffectComponent.EFootstepTexture.WaterSurface;
		}
		AActor owner = this.ActorComp.Owner;
		UKuroEnviInteractionComponent ukuroEnviInteractionComponent = ((owner != null) ? owner.GetComponentByClass(UKuroEnviInteractionComponent.StaticClass()) : null) as UKuroEnviInteractionComponent;
		if (ukuroEnviInteractionComponent != null && this.ActorComp.Owner != null)
		{
			UKuroInteractionEffectSystem kuroInteractionEffectSystem = UKuroInteractionEffectSystem.GetKuroInteractionEffectSystem(this.ActorComp.Owner.GetWorld());
			if (kuroInteractionEffectSystem != null)
			{
				TWeakObjectPtr<UKuroEnviInteractionComponent> key = new TWeakObjectPtr<UKuroEnviInteractionComponent>(ukuroEnviInteractionComponent);
				FKuroEnviInteractionData fkuroEnviInteractionData = kuroInteractionEffectSystem.EnviInteractionCollections.Get(key);
				if (fkuroEnviInteractionData != null && fkuroEnviInteractionData.WaterType == 1)
				{
					return CharacterFootEffectComponent.EFootstepTexture.VoicelessSurface;
				}
			}
		}
		return CharacterFootEffectComponent.EFootstepTexture.WaterSurface;
	}

	// Token: 0x06017F2B RID: 98091 RVA: 0x007263C0 File Offset: 0x007245C0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterFootEffectComponent characterFootEffectComponent = (CharacterFootEffectComponent)componentTemplate;
		if (characterFootEffectComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterFootEffectComponent.UnifiedStateComp == null)
		{
			this.UnifiedStateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComp), "UnifiedStateComp"))
		{
			return false;
		}
		if (characterFootEffectComponent.EnviInteractionComp == null)
		{
			this.EnviInteractionComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EnviInteractionComp), "EnviInteractionComp"))
		{
			return false;
		}
		if (characterFootEffectComponent.FootTraceElement == null)
		{
			this.FootTraceElement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FootTraceElement), "FootTraceElement"))
		{
			return false;
		}
		if (characterFootEffectComponent.StartLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StartLocation), "StartLocation"))
		{
			return false;
		}
		if (characterFootEffectComponent.EndLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndLocation), "EndLocation"))
		{
			return false;
		}
		if (characterFootEffectComponent.TmpHitLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpHitLocation), "TmpHitLocation"))
		{
			return false;
		}
		if (characterFootEffectComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector), "TmpVector"))
		{
			return false;
		}
		if (characterFootEffectComponent.TmpVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector2), "TmpVector2"))
		{
			return false;
		}
		if (characterFootEffectComponent.TmpVector3 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector3), "TmpVector3"))
		{
			return false;
		}
		if (characterFootEffectComponent.TmpRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpRotator), "TmpRotator"))
		{
			return false;
		}
		if (characterFootEffectComponent.FootLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FootLocation), "FootLocation"))
		{
			return false;
		}
		if (characterFootEffectComponent.StatTraceDelegate == null)
		{
			this.StatTraceDelegate = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StatTraceDelegate), "StatTraceDelegate"))
		{
			return false;
		}
		if (characterFootEffectComponent.StatGetFootTexture == null)
		{
			this.StatGetFootTexture = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StatGetFootTexture), "StatGetFootTexture"))
		{
			return false;
		}
		if (characterFootEffectComponent.StatPostFootsteupAudio == null)
		{
			this.StatPostFootsteupAudio = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StatPostFootsteupAudio), "StatPostFootsteupAudio"))
		{
			return false;
		}
		if (characterFootEffectComponent.FootprintMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FootprintMap), "FootprintMap"))
		{
			return false;
		}
		if (characterFootEffectComponent.CharacterFootprintMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharacterFootprintMap), "CharacterFootprintMap"))
		{
			return false;
		}
		this.LastSpawnFootprintTime = characterFootEffectComponent.LastSpawnFootprintTime;
		this.LastDetectFootstepTime = characterFootEffectComponent.LastDetectFootstepTime;
		if (characterFootEffectComponent.LastSpawnFootprintLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastSpawnFootprintLocation), "LastSpawnFootprintLocation"))
		{
			return false;
		}
		if (characterFootEffectComponent.LeftHitLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LeftHitLocation), "LeftHitLocation"))
		{
			return false;
		}
		if (characterFootEffectComponent.RightHitLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.RightHitLocation), "RightHitLocation"))
		{
			return false;
		}
		if (characterFootEffectComponent.LeftFootprintDelegate == null)
		{
			this.LeftFootprintDelegate = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LeftFootprintDelegate), "LeftFootprintDelegate"))
		{
			return false;
		}
		if (characterFootEffectComponent.RightFootprintDelegate == null)
		{
			this.RightFootprintDelegate = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RightFootprintDelegate), "RightFootprintDelegate"))
		{
			return false;
		}
		if (characterFootEffectComponent.FootVoiceDelegate == null)
		{
			this.FootVoiceDelegate = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FootVoiceDelegate), "FootVoiceDelegate"))
		{
			return false;
		}
		if (characterFootEffectComponent.SeasonFootstepDelegate == null)
		{
			this.SeasonFootstepDelegate = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SeasonFootstepDelegate), "SeasonFootstepDelegate"))
		{
			return false;
		}
		if (characterFootEffectComponent.SeasonTraceElement == null)
		{
			this.SeasonTraceElement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SeasonTraceElement), "SeasonTraceElement"))
		{
			return false;
		}
		this.IsOnExposedSurface = characterFootEffectComponent.IsOnExposedSurface;
		if (characterFootEffectComponent.SnowHitLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SnowHitLocation), "SnowHitLocation"))
		{
			return false;
		}
		if (characterFootEffectComponent.FootVoiceHitLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FootVoiceHitLocation), "FootVoiceHitLocation"))
		{
			return false;
		}
		if (characterFootEffectComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		this.IsLeftFootOnGround = characterFootEffectComponent.IsLeftFootOnGround;
		this.IsRightFootOnGround = characterFootEffectComponent.IsRightFootOnGround;
		this.IsTriggerEffect = characterFootEffectComponent.IsTriggerEffect;
		this.IsLeftFootHit = characterFootEffectComponent.IsLeftFootHit;
		this.IsRightFootHit = characterFootEffectComponent.IsRightFootHit;
		if (characterFootEffectComponent.TraceHandleLeftFootprint == null)
		{
			this.TraceHandleLeftFootprint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceHandleLeftFootprint), "TraceHandleLeftFootprint"))
		{
			return false;
		}
		if (characterFootEffectComponent.TraceHandleRightFootprint == null)
		{
			this.TraceHandleRightFootprint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceHandleRightFootprint), "TraceHandleRightFootprint"))
		{
			return false;
		}
		if (characterFootEffectComponent.TraceHandleFootVoice == null)
		{
			this.TraceHandleFootVoice = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceHandleFootVoice), "TraceHandleFootVoice"))
		{
			return false;
		}
		if (characterFootEffectComponent.TraceHandleSnowFootprint == null)
		{
			this.TraceHandleSnowFootprint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceHandleSnowFootprint), "TraceHandleSnowFootprint"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x1700256B RID: 9579
	// (get) Token: 0x06017F2C RID: 98092 RVA: 0x00726919 File Offset: 0x00724B19
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700256C RID: 9580
	// (get) Token: 0x06017F2D RID: 98093 RVA: 0x0072691C File Offset: 0x00724B1C
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700256D RID: 9581
	// (get) Token: 0x06017F2E RID: 98094 RVA: 0x0072691F File Offset: 0x00724B1F
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700256E RID: 9582
	// (get) Token: 0x06017F2F RID: 98095 RVA: 0x00726922 File Offset: 0x00724B22
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CCD2 RID: 52434
	private const string PROFILE_KEY = "CharacterFootEffectComponent_FootTrace";

	// Token: 0x0400CCD3 RID: 52435
	private const int FOOTPRINT_DETECT_DURATION = 150;

	// Token: 0x0400CCD4 RID: 52436
	private const int FOOTPRINT_SPAWN_DURATION = 200;

	// Token: 0x0400CCD5 RID: 52437
	private const int FOOTPRINT_SPAWN_MIN_DISTANCE_SQUARED = 500;

	// Token: 0x0400CCD6 RID: 52438
	private const int SPRINT_FOOTEFFECT_DETECT_HEIGHT = 50;

	// Token: 0x0400CCD7 RID: 52439
	private const int NORMAL_FOOTEFFECT_DETECT_HEIGHT = 15;

	// Token: 0x0400CCD8 RID: 52440
	private const int MATERIAL_ID_WAT = 6;

	// Token: 0x0400CCD9 RID: 52441
	private const int MATERIAL_ID_SHR = 14;

	// Token: 0x0400CCDA RID: 52442
	private const int FOOTPRINT_FORWARD_OFFSET = 5;

	// Token: 0x0400CCDB RID: 52443
	private const int SNOW_DETECT_SKY_HEIGHT = 5000;

	// Token: 0x0400CCDC RID: 52444
	private const int SNOW_FOOTPRINT_EPSILON = 50;

	// Token: 0x0400CCDD RID: 52445
	private const string RAIN_FOOT_EFFCT = "/Game/Aki/Effect/DataAsset/Niagara/Common/Water/DA_FX_SI3_Water_Step01.DA_FX_SI3_Water_Step01";

	// Token: 0x0400CCDE RID: 52446
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CCDF RID: 52447
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedStateComp;

	// Token: 0x0400CCE0 RID: 52448
	[Nullable(2)]
	private UKuroEnviInteractionComponent EnviInteractionComp;

	// Token: 0x0400CCE1 RID: 52449
	[Nullable(2)]
	private UTraceSphereElement FootTraceElement;

	// Token: 0x0400CCE2 RID: 52450
	private readonly Vector StartLocation = Vector.Create();

	// Token: 0x0400CCE3 RID: 52451
	private readonly Vector EndLocation = Vector.Create();

	// Token: 0x0400CCE4 RID: 52452
	private readonly Vector TmpHitLocation = Vector.Create();

	// Token: 0x0400CCE5 RID: 52453
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400CCE6 RID: 52454
	private readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x0400CCE7 RID: 52455
	private readonly Vector TmpVector3 = Vector.Create();

	// Token: 0x0400CCE8 RID: 52456
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400CCE9 RID: 52457
	private readonly Vector FootLocation = Vector.Create();

	// Token: 0x0400CCEA RID: 52458
	private Stat StatTraceDelegate = Stat.Create("CharacterFootEffectComponent.AsyncTraceDelegate", "", "");

	// Token: 0x0400CCEB RID: 52459
	private Stat StatGetFootTexture = Stat.Create("CharacterFootEffectComponent.GetFootTexture", "", "");

	// Token: 0x0400CCEC RID: 52460
	private Stat StatPostFootsteupAudio = Stat.Create("CharacterFootEffectComponent.PostFootStepAudio", "", "");

	// Token: 0x0400CCED RID: 52461
	private readonly Dictionary<EPhysicalSurface, CharacterFootEffectComponent.CharacterFootEffectConfig> FootprintMap = new Dictionary<EPhysicalSurface, CharacterFootEffectComponent.CharacterFootEffectConfig>();

	// Token: 0x0400CCEE RID: 52462
	private readonly Dictionary<int, List<CharacterFootEffectComponent.CharacterSpecialFootEffectConfig>> CharacterFootprintMap = new Dictionary<int, List<CharacterFootEffectComponent.CharacterSpecialFootEffectConfig>>();

	// Token: 0x0400CCEF RID: 52463
	private double LastSpawnFootprintTime;

	// Token: 0x0400CCF0 RID: 52464
	private double LastDetectFootstepTime;

	// Token: 0x0400CCF1 RID: 52465
	private readonly Vector LastSpawnFootprintLocation = Vector.Create();

	// Token: 0x0400CCF2 RID: 52466
	private readonly Vector LeftHitLocation = Vector.Create();

	// Token: 0x0400CCF3 RID: 52467
	private readonly Vector RightHitLocation = Vector.Create();

	// Token: 0x0400CCF4 RID: 52468
	public static readonly FName LeftFootSocketName = new FName("Bip001LFoot");

	// Token: 0x0400CCF5 RID: 52469
	public static readonly FName RightFootSocketName = new FName("Bip001RFoot");

	// Token: 0x0400CCF6 RID: 52470
	[Nullable(2)]
	private FAsyncTraceDelegate LeftFootprintDelegate;

	// Token: 0x0400CCF7 RID: 52471
	[Nullable(2)]
	private FAsyncTraceDelegate RightFootprintDelegate;

	// Token: 0x0400CCF8 RID: 52472
	[Nullable(2)]
	private FAsyncTraceDelegate FootVoiceDelegate;

	// Token: 0x0400CCF9 RID: 52473
	[Nullable(2)]
	private FAsyncTraceDelegate SeasonFootstepDelegate;

	// Token: 0x0400CCFA RID: 52474
	[Nullable(2)]
	private UTraceLineElement SeasonTraceElement;

	// Token: 0x0400CCFB RID: 52475
	public bool IsOnExposedSurface = true;

	// Token: 0x0400CCFC RID: 52476
	private readonly Vector SnowHitLocation = Vector.Create();

	// Token: 0x0400CCFD RID: 52477
	private readonly Vector FootVoiceHitLocation = Vector.Create();

	// Token: 0x0400CCFE RID: 52478
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400CCFF RID: 52479
	private bool IsLeftFootOnGround;

	// Token: 0x0400CD00 RID: 52480
	private bool IsRightFootOnGround;

	// Token: 0x0400CD01 RID: 52481
	private bool IsTriggerEffect;

	// Token: 0x0400CD02 RID: 52482
	private bool IsLeftFootHit;

	// Token: 0x0400CD03 RID: 52483
	private bool IsRightFootHit;

	// Token: 0x0400CD04 RID: 52484
	public static readonly FName FootstepCurveName = new FName("Foot_voice");

	// Token: 0x0400CD05 RID: 52485
	[Nullable(2)]
	private TraceHandle TraceHandleLeftFootprint;

	// Token: 0x0400CD06 RID: 52486
	[Nullable(2)]
	private TraceHandle TraceHandleRightFootprint;

	// Token: 0x0400CD07 RID: 52487
	[Nullable(2)]
	private TraceHandle TraceHandleFootVoice;

	// Token: 0x0400CD08 RID: 52488
	[Nullable(2)]
	private TraceHandle TraceHandleSnowFootprint;

	// Token: 0x02008869 RID: 34921
	[NullableContext(0)]
	[EnumExtensions]
	public enum EFootstepTexture
	{
		// Token: 0x0402B9FA RID: 178682
		[EnumStringMember("DirtSurface")]
		DirtSurface,
		// Token: 0x0402B9FB RID: 178683
		[EnumStringMember("ConcreteSurface")]
		ConcreteSurface,
		// Token: 0x0402B9FC RID: 178684
		[EnumStringMember("GrassSurface")]
		GrassSurface,
		// Token: 0x0402B9FD RID: 178685
		[EnumStringMember("MetalSheetSurface")]
		MetalSheetSurface,
		// Token: 0x0402B9FE RID: 178686
		[EnumStringMember("MetalHardSurface")]
		MetalHardSurface,
		// Token: 0x0402B9FF RID: 178687
		[EnumStringMember("WoodFloorSurface")]
		WoodFloorSurface,
		// Token: 0x0402BA00 RID: 178688
		[EnumStringMember("WaterSurface")]
		WaterSurface,
		// Token: 0x0402BA01 RID: 178689
		[EnumStringMember("FabricSurface")]
		FabricSurface,
		// Token: 0x0402BA02 RID: 178690
		[EnumStringMember("SandSurface")]
		SandSurface,
		// Token: 0x0402BA03 RID: 178691
		[EnumStringMember("IceSurface")]
		IceSurface,
		// Token: 0x0402BA04 RID: 178692
		[EnumStringMember("SnowSurface")]
		SnowSurface,
		// Token: 0x0402BA05 RID: 178693
		[EnumStringMember("VoicelessSurface")]
		VoicelessSurface
	}

	// Token: 0x0200886A RID: 34922
	[NullableContext(0)]
	public class CharacterFootEffectConfig
	{
		// Token: 0x0402BA06 RID: 178694
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TSoftObjectPtr<UEffectModelBase> EffectPath;

		// Token: 0x0402BA07 RID: 178695
		public bool PriorToGlobal;
	}

	// Token: 0x0200886B RID: 34923
	[NullableContext(0)]
	public class CharacterSpecialFootEffectConfig
	{
		// Token: 0x0402BA08 RID: 178696
		public FGameplayTag Tag;

		// Token: 0x0402BA09 RID: 178697
		public int SortId;

		// Token: 0x0402BA0A RID: 178698
		public int OverrideGlobalFootEffect;

		// Token: 0x0402BA0B RID: 178699
		public int OverrideOtherCharacterFootEffect;

		// Token: 0x0402BA0C RID: 178700
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TSoftObjectPtr<UEffectModelBase> EffectPath;
	}
}
