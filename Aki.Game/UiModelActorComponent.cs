using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Tuanzi;
using AkiClient.Game.Aki.Character.Role.Common;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02002C77 RID: 11383
[NullableContext(1)]
[Nullable(0)]
public class UiModelActorComponent : UiModelComponentBase, IUiModelVisible, IUiModelSetDitherEffect, IUiModelSetPlanarReflectionRenderOffset
{
	// Token: 0x06017C69 RID: 97385 RVA: 0x0060C170 File Offset: 0x0060A370
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.EffectComponent = base.Owner.GetComponent<UiModelEffectComponent>();
		EUiModelActorType? modelActorType = this.ModelDataComponent.ModelActorType;
		if (modelActorType != null)
		{
			EUiModelActorType valueOrDefault = modelActorType.GetValueOrDefault();
			if (valueOrDefault <= EUiModelActorType.TsSkeletalObserver)
			{
				this.CharRenderingComponent = this.CreateUiModelCharRenderingComponent(ECharacterRenderingType.UI);
				return;
			}
			if (valueOrDefault != EUiModelActorType.TsUiSceneDangoActor)
			{
				return;
			}
			this.CharRenderingComponent = this.CreateUiModelCharRenderingComponent(ECharacterRenderingType.Default);
		}
	}

	// Token: 0x06017C6A RID: 97386 RVA: 0x0060C1E0 File Offset: 0x0060A3E0
	protected override void OnStart()
	{
	}

	// Token: 0x06017C6B RID: 97387 RVA: 0x0060C1E2 File Offset: 0x0060A3E2
	protected override void OnEnd()
	{
	}

	// Token: 0x06017C6C RID: 97388 RVA: 0x0060C1E4 File Offset: 0x0060A3E4
	public void OnModelVisibleChange(bool visible)
	{
		if (this.MainMeshComponent != null)
		{
			this.SetMeshComponentEnable(this.MainMeshComponent, visible);
			if (!visible)
			{
				UKuroAnimLibrary.EndAnimNotifyStates(this.MainMeshComponent.GetAnimInstance());
			}
		}
		if (this.ChildMeshComponentList != null && this.ChildMeshComponentList.Count > 0)
		{
			foreach (USkeletalMeshComponent meshComp in this.ChildMeshComponentList)
			{
				this.SetMeshComponentEnable(meshComp, visible);
			}
		}
		if (this.DecorationMeshComponentList != null && this.DecorationMeshComponentList.Count > 0)
		{
			foreach (USkeletalMeshComponent meshComp2 in this.DecorationMeshComponentList)
			{
				this.SetMeshComponentEnable(meshComp2, visible);
			}
		}
	}

	// Token: 0x06017C6D RID: 97389 RVA: 0x0060C2D0 File Offset: 0x0060A4D0
	public void OnModelDitherEffectChange(float value)
	{
		CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return;
		}
		charRenderingComponent.SetDitherEffect(value, ECharacterDitherType.UnDefined);
	}

	// Token: 0x06017C6E RID: 97390 RVA: 0x0060C2E4 File Offset: 0x0060A4E4
	private USkeletalMeshComponent CreateUiModelSkeletalMeshComponent(FTransform? transform = null, [Nullable(2)] string componentName = null)
	{
		FTransform ftransform = transform ?? MathUtils.Instance.DefaultTransform;
		USkeletalMeshComponent uskeletalMeshComponent = string.IsNullOrEmpty(componentName) ? (this.Actor.AddComponentByClass(USkeletalMeshComponent.StaticClass(), false, ftransform, false, default(FName)) as USkeletalMeshComponent) : (this.Actor.AddComponentByClass(USkeletalMeshComponent.StaticClass(), false, ftransform, false, FNameUtil.GetDynamicFName(componentName).Value) as USkeletalMeshComponent);
		uskeletalMeshComponent.KuroMaterialControllerUpdateGroupMode = EKuroMaterialControllerUpdateGroupMode.CharMesh;
		uskeletalMeshComponent.SetTickableWhenPaused(true);
		this.SetMeshComponentEnable(uskeletalMeshComponent, this.ModelDataComponent.GetVisible());
		if (Info.Instance.IsPlayInEditor)
		{
			ULGUIBPLibrary.AddInstanceComponent(this.Actor, uskeletalMeshComponent);
		}
		return uskeletalMeshComponent;
	}

	// Token: 0x06017C6F RID: 97391 RVA: 0x0060C3A8 File Offset: 0x0060A5A8
	private CharRenderingComponent CreateUiModelCharRenderingComponent(ECharacterRenderingType renderType)
	{
		CharRenderingComponent charRenderingComponent = this.Actor.AddComponentByClass(CharRenderingComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as CharRenderingComponent;
		charRenderingComponent.Init(renderType);
		charRenderingComponent.SetTickableWhenPaused(true);
		return charRenderingComponent;
	}

	// Token: 0x06017C70 RID: 97392 RVA: 0x0060C3F4 File Offset: 0x0060A5F4
	private void InitCharRenderingComponent()
	{
		EUiModelType? modelType = this.ModelDataComponent.ModelType;
		if (modelType != null)
		{
			switch (modelType.GetValueOrDefault())
			{
			case EUiModelType.Role:
				this.CharRenderingComponent.AddComponent("CharacterMesh0", this.MainMeshComponent);
				return;
			case EUiModelType.Weapon:
				this.CharRenderingComponent.AddComponent("WeaponCase0", this.MainMeshComponent);
				return;
			case EUiModelType.Vision:
				this.CharRenderingComponent.AddComponent("CharacterMesh0", this.MainMeshComponent);
				return;
			case EUiModelType.Hulu:
				this.CharRenderingComponent.AddComponent("HuluCase", this.MainMeshComponent);
				return;
			case EUiModelType.Dango:
				this.CharRenderingComponent.AddComponent("CharacterMesh0", this.MainMeshComponent);
				return;
			case EUiModelType.Glider:
				this.CharRenderingComponent.AddComponentByCase(ECharacterControllerCaseType.OtherCase0, this.MainMeshComponent);
				return;
			case EUiModelType.Motor:
				this.CharRenderingComponent.AddComponent("CharacterMesh0", this.MainMeshComponent);
				return;
			case EUiModelType.MotorDecoration:
				this.CharRenderingComponent.AddComponent("CharacterMesh0", this.MainMeshComponent);
				return;
			case EUiModelType.RoleOrnament:
				this.CharRenderingComponent.AddComponent("OtherCase0", this.MainMeshComponent);
				break;
			case EUiModelType.MotorSoarWing:
				this.CharRenderingComponent.AddComponent("CharacterMesh0", this.MainMeshComponent);
				return;
			case EUiModelType.SpecialItemSummon:
				this.CharRenderingComponent.AddComponentByCase(ECharacterControllerCaseType.OtherCase0, this.MainMeshComponent);
				return;
			default:
				return;
			}
		}
	}

	// Token: 0x06017C71 RID: 97393 RVA: 0x0060C548 File Offset: 0x0060A748
	public void ChangeMesh(USkeletalMesh newMesh, [Nullable(2)] UClass newAnimClass = null, [Nullable(new byte[]
	{
		2,
		1
	})] List<USkeletalMesh> childMeshList = null, [Nullable(new byte[]
	{
		2,
		1
	})] List<UiModelDecorationParam> decorationMeshParamList = null, int levelOfDetail = 0)
	{
		EUiModelType? modelType = this.ModelDataComponent.ModelType;
		if (modelType != null)
		{
			switch (modelType.GetValueOrDefault())
			{
			case EUiModelType.Role:
				this.ChangeRoleMainMesh(newMesh, newAnimClass, childMeshList, decorationMeshParamList, levelOfDetail);
				return;
			case EUiModelType.Weapon:
			case EUiModelType.Hulu:
			case EUiModelType.Dango:
			case EUiModelType.Glider:
			case EUiModelType.MotorDecoration:
			case EUiModelType.RoleOrnament:
			case EUiModelType.MotorSoarWing:
			case EUiModelType.SpecialItemSummon:
				this.ChangeMainMeshCommon(newMesh, newAnimClass, null, decorationMeshParamList, levelOfDetail);
				return;
			case EUiModelType.Vision:
				this.ChangeMainMeshCommon(newMesh, newAnimClass, childMeshList, decorationMeshParamList, levelOfDetail);
				return;
			case EUiModelType.Motor:
				this.ChangeMainMeshCommon(newMesh, null, null, decorationMeshParamList, levelOfDetail);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x06017C72 RID: 97394 RVA: 0x0060C5DC File Offset: 0x0060A7DC
	private void ChangeMainMeshCommon(USkeletalMesh newMesh, [Nullable(2)] UClass newAnimClass = null, [Nullable(new byte[]
	{
		2,
		1
	})] List<USkeletalMesh> childMeshList = null, [Nullable(new byte[]
	{
		2,
		1
	})] List<UiModelDecorationParam> decorationMeshParamList = null, int levelOfDetail = 0)
	{
		CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
		if (charRenderingComponent != null)
		{
			charRenderingComponent.ResetAllRenderingState();
		}
		this.DestroyChildMeshComponent();
		this.DestroyDecorationMeshComponent();
		UiModelEffectComponent effectComponent = this.EffectComponent;
		if (effectComponent != null)
		{
			effectComponent.DestroyAllEffect();
		}
		USkeletalMeshComponent mainMeshComponent = this.MainMeshComponent;
		UAnimInstance uanimInstance = (mainMeshComponent != null) ? mainMeshComponent.GetAnimInstance() : null;
		if (uanimInstance != null)
		{
			UKuroAnimLibrary.EndAnimNotifyStates(uanimInstance);
		}
		USkeletalMeshComponent uskeletalMeshComponent = this.CreateUiModelSkeletalMeshComponent(null, null);
		this.RefreshMeshAndSetLod(uskeletalMeshComponent, newMesh, levelOfDetail);
		if (newAnimClass != null && uskeletalMeshComponent != null)
		{
			uskeletalMeshComponent.SetAnimClass(newAnimClass.ClassStackOnlyPtr);
		}
		this.MainMeshComponent = uskeletalMeshComponent;
		if (mainMeshComponent != null)
		{
			this.DestroyMeshComponent(mainMeshComponent);
		}
		if (childMeshList != null && childMeshList.Count > 0)
		{
			foreach (USkeletalMesh newMesh2 in childMeshList)
			{
				this.AddChildMeshComponent(newMesh2);
			}
		}
		if (decorationMeshParamList != null && decorationMeshParamList.Count > 0)
		{
			foreach (UiModelDecorationParam decorationMeshParamList2 in decorationMeshParamList)
			{
				this.AddDecorationMeshComponent(decorationMeshParamList2);
			}
		}
		this.InitCharRenderingComponent();
	}

	// Token: 0x06017C73 RID: 97395 RVA: 0x0060C718 File Offset: 0x0060A918
	public void ChangeRoleMainMeshAnimation(UAnimationAsset animation)
	{
		USkeletalMeshComponent mainMeshComponent = this.MainMeshComponent;
		if (mainMeshComponent != null)
		{
			mainMeshComponent.PlayAnimation(animation, true);
		}
		USkeletalMeshComponent mainMeshComponent2 = this.MainMeshComponent;
		if (mainMeshComponent2 == null)
		{
			return;
		}
		mainMeshComponent2.SetAnimationMode(EAnimationMode.AnimationSingleNode);
	}

	// Token: 0x06017C74 RID: 97396 RVA: 0x0060C73E File Offset: 0x0060A93E
	private void RefreshMeshAndSetLod(USkeletalMeshComponent skeletalComponent, USkeletalMesh mesh, int levelOfDetail = 0)
	{
		skeletalComponent.SetSkeletalMesh(mesh, true);
		skeletalComponent.SetForcedLOD(levelOfDetail);
	}

	// Token: 0x06017C75 RID: 97397 RVA: 0x0060C750 File Offset: 0x0060A950
	private void ChangeRoleMainMesh(USkeletalMesh newMesh, [Nullable(2)] UClass newAnimClass = null, [Nullable(new byte[]
	{
		2,
		1
	})] List<USkeletalMesh> childMeshList = null, [Nullable(new byte[]
	{
		2,
		1
	})] List<UiModelDecorationParam> decorationMeshParamList = null, int levelOfDetail = 0)
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		bool flag;
		if (modelDataComponent == null)
		{
			flag = true;
		}
		else
		{
			EUiModelActorType? modelActorType = modelDataComponent.ModelActorType;
			EUiModelActorType euiModelActorType = EUiModelActorType.TsUiSceneRoleActor;
			flag = !(modelActorType.GetValueOrDefault() == euiModelActorType & modelActorType != null);
		}
		if (flag)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.LZK, "actor类型必须为TsUiSceneRoleActor", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.CharRenderingComponent.ResetAllRenderingState();
		this.DestroyChildMeshComponent();
		this.DestroyDecorationMeshComponent();
		UiModelEffectComponent effectComponent = this.EffectComponent;
		if (effectComponent != null)
		{
			effectComponent.DestroyAllEffect();
		}
		USkeletalMeshComponent mainMeshComponent = this.MainMeshComponent;
		ABP_PerformanceRole_C abp_PerformanceRole_C = null;
		if (mainMeshComponent != null && mainMeshComponent.GetAnimationMode() == 0)
		{
			abp_PerformanceRole_C = this.GetAnimInstanceFromSkeletalMesh(mainMeshComponent);
			if (abp_PerformanceRole_C != null)
			{
				UKuroAnimLibrary.EndAnimNotifyStates(abp_PerformanceRole_C);
			}
		}
		USkeletalMeshComponent uskeletalMeshComponent = this.CreateUiModelSkeletalMeshComponent(null, null);
		this.RefreshMeshAndSetLod(uskeletalMeshComponent, newMesh, levelOfDetail);
		if (newAnimClass != null)
		{
			if (uskeletalMeshComponent != null)
			{
				uskeletalMeshComponent.SetAnimClass(newAnimClass.ClassStackOnlyPtr);
			}
			ABP_PerformanceRole_C animInstanceFromSkeletalMesh = this.GetAnimInstanceFromSkeletalMesh(uskeletalMeshComponent);
			if (abp_PerformanceRole_C != null)
			{
				bool flag2 = false;
				TEnumAsByte<EPerformanceRoleState> stateInternal = abp_PerformanceRole_C.StateInternal;
				if ((stateInternal >= 13 && stateInternal <= 15) || stateInternal == 7)
				{
					flag2 = true;
				}
				if (flag2 && animInstanceFromSkeletalMesh != null)
				{
					animInstanceFromSkeletalMesh.SyncAnimInstance(abp_PerformanceRole_C);
				}
			}
		}
		this.MainMeshComponent = uskeletalMeshComponent;
		if (mainMeshComponent != null)
		{
			this.DestroyMeshComponent(mainMeshComponent);
		}
		if (childMeshList != null && childMeshList.Count > 0)
		{
			foreach (USkeletalMesh newMesh2 in childMeshList)
			{
				this.AddChildMeshComponent(newMesh2);
			}
		}
		if (decorationMeshParamList != null && decorationMeshParamList.Count > 0)
		{
			foreach (UiModelDecorationParam decorationMeshParamList2 in decorationMeshParamList)
			{
				this.AddDecorationMeshComponent(decorationMeshParamList2);
			}
		}
		this.InitCharRenderingComponent();
		this.ApplyToonCustomStencilAfterSetup();
	}

	// Token: 0x06017C76 RID: 97398 RVA: 0x0060C930 File Offset: 0x0060AB30
	private void ApplyToonCustomStencilAfterSetup()
	{
		if (this.ModelDataComponent != null && this.ModelDataComponent.ModelConfigId > 0)
		{
			EUiModelType? modelType = this.ModelDataComponent.ModelType;
			EUiModelType euiModelType = EUiModelType.Role;
			if (modelType.GetValueOrDefault() == euiModelType & modelType != null)
			{
				int toonCustomStencilValue = ModelUtil.GetModelConfig(this.ModelDataComponent.ModelConfigId).ToonCustomStencilValue;
				USkeletalMeshComponent mainMeshComponent = this.MainMeshComponent;
				if (mainMeshComponent != null)
				{
					mainMeshComponent.SetToonCustomStencilValue(toonCustomStencilValue);
				}
				if (this.ChildMeshComponentList != null)
				{
					foreach (USkeletalMeshComponent uskeletalMeshComponent in this.ChildMeshComponentList)
					{
						uskeletalMeshComponent.SetToonCustomStencilValue(toonCustomStencilValue);
					}
				}
				return;
			}
		}
	}

	// Token: 0x06017C77 RID: 97399 RVA: 0x0060C9EC File Offset: 0x0060ABEC
	private USkeletalMeshComponent AddChildMeshComponent(USkeletalMesh newMesh)
	{
		if (this.ChildMeshComponentList == null)
		{
			this.ChildMeshComponentList = new List<USkeletalMeshComponent>();
		}
		SModelChildMeshConfig childMeshConfig = this.GetChildMeshConfig(newMesh);
		string componentName = (!string.IsNullOrEmpty((childMeshConfig != null) ? childMeshConfig.ComponentName : null)) ? childMeshConfig.ComponentName : null;
		USkeletalMeshComponent uskeletalMeshComponent = this.CreateUiModelSkeletalMeshComponent(null, componentName);
		this.RefreshMeshAndSetLod(uskeletalMeshComponent, newMesh, 0);
		uskeletalMeshComponent.SetMasterPoseComponent(this.MainMeshComponent, false);
		this.ChildMeshComponentList.Add(uskeletalMeshComponent);
		int value = this.ChildMeshComponentList.Count - 1;
		CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
		defaultInterpolatedStringHandler.AppendLiteral("OtherCase");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		charRenderingComponent.AddComponent(defaultInterpolatedStringHandler.ToStringAndClear(), uskeletalMeshComponent);
		if (childMeshConfig != null && !childMeshConfig.DefaultVisible)
		{
			this.SetMeshComponentVisibility(uskeletalMeshComponent, false);
		}
		return uskeletalMeshComponent;
	}

	// Token: 0x06017C78 RID: 97400 RVA: 0x0060CAC0 File Offset: 0x0060ACC0
	[return: Nullable(2)]
	private SModelChildMeshConfig GetChildMeshConfig(USkeletalMesh mesh)
	{
		int modelConfigId = this.ModelDataComponent.ModelConfigId;
		if (modelConfigId <= 0)
		{
			return null;
		}
		TArray<SModelChildMeshConfig> ui用子网格体 = ModelUtil.GetModelConfig(modelConfigId).UI用子网格体;
		if (ui用子网格体 == null)
		{
			return null;
		}
		string pathName = UKismetSystemLibrary.GetPathName(mesh);
		for (int i = 0; i < ui用子网格体.Num(); i++)
		{
			SModelChildMeshConfig smodelChildMeshConfig = ui用子网格体.Get(i);
			if (smodelChildMeshConfig.SkeletalMesh.ToAssetPathName() == pathName)
			{
				return smodelChildMeshConfig;
			}
		}
		return null;
	}

	// Token: 0x06017C79 RID: 97401 RVA: 0x0060CB2C File Offset: 0x0060AD2C
	private void AddDecorationMeshComponent(IUiModelDecorationParam decorationMeshParamList)
	{
		if (this.DecorationMeshComponentList == null)
		{
			this.DecorationMeshComponentList = new List<USkeletalMeshComponent>();
		}
		USkeletalMeshComponent uskeletalMeshComponent = this.CreateUiModelSkeletalMeshComponent(new FTransform?(decorationMeshParamList.Transform), null);
		this.RefreshMeshAndSetLod(uskeletalMeshComponent, decorationMeshParamList.SkeletalMesh, 0);
		uskeletalMeshComponent.K2_AttachToComponent(this.MainMeshComponent, FNameUtil.GetDynamicFName(decorationMeshParamList.SocketName).Value, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
		this.CharRenderingComponent.AddComponentByCase(ECharacterControllerCaseType.OtherCase0, uskeletalMeshComponent);
		this.DecorationMeshComponentList.Add(uskeletalMeshComponent);
	}

	// Token: 0x06017C7A RID: 97402 RVA: 0x0060CBAC File Offset: 0x0060ADAC
	private void DestroyChildMeshComponent()
	{
		if (this.ChildMeshComponentList == null)
		{
			return;
		}
		for (int i = 0; i < this.ChildMeshComponentList.Count; i++)
		{
			USkeletalMeshComponent uskeletalMeshComponent = this.ChildMeshComponentList[i];
			CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("OtherCase");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				charRenderingComponent.RemoveComponent(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			uskeletalMeshComponent.SetMasterPoseComponent(null, false);
			this.DestroyMeshComponent(uskeletalMeshComponent);
		}
		this.ChildMeshComponentList.Clear();
	}

	// Token: 0x06017C7B RID: 97403 RVA: 0x0060CC38 File Offset: 0x0060AE38
	private void DestroyDecorationMeshComponent()
	{
		if (this.DecorationMeshComponentList == null)
		{
			return;
		}
		CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
		if (charRenderingComponent != null)
		{
			charRenderingComponent.RemoveComponentByCase(ECharacterControllerCaseType.OtherCase0);
		}
		foreach (USkeletalMeshComponent meshComp in this.DecorationMeshComponentList)
		{
			this.DestroyMeshComponent(meshComp);
		}
		this.DecorationMeshComponentList.Clear();
	}

	// Token: 0x06017C7C RID: 97404 RVA: 0x0060CCB4 File Offset: 0x0060AEB4
	private void DestroyMeshComponent(USkeletalMeshComponent meshComp)
	{
		meshComp.K2_DestroyComponent(this.Actor);
		if (Info.Instance.IsPlayInEditor)
		{
			ULGUIBPLibrary.RemoveInstanceComponent(this.Actor, meshComp);
		}
	}

	// Token: 0x06017C7D RID: 97405 RVA: 0x0060CCDC File Offset: 0x0060AEDC
	public void SetTransformByTag(string tag)
	{
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(tag).Value, ECollectActorType.UI);
		if (actorWithTag == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiSceneRoleActor;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "查找不到标签对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签Tag", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FHitResult fhitResult = new FHitResult();
		AActor actor = this.Actor;
		FTransformDouble ftransformDouble = actorWithTag.D_GetTransform();
		actor.D_K2_SetActorTransform(ftransformDouble, false, ref fhitResult, false);
	}

	// Token: 0x06017C7E RID: 97406 RVA: 0x0060CD4C File Offset: 0x0060AF4C
	public void SetAllMeshComponentRelativeTransform(FTransform newTransform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport = false)
	{
		USkeletalMeshComponent mainMeshComponent = this.MainMeshComponent;
		if (mainMeshComponent != null)
		{
			mainMeshComponent.K2_SetRelativeTransform(newTransform, bSweep, ref sweepHitResult, bTeleport);
		}
		if (this.ChildMeshComponentList == null || this.ChildMeshComponentList.Count == 0)
		{
			return;
		}
		foreach (USkeletalMeshComponent uskeletalMeshComponent in this.ChildMeshComponentList)
		{
			uskeletalMeshComponent.K2_SetRelativeTransform(newTransform, bSweep, ref sweepHitResult, bTeleport);
		}
	}

	// Token: 0x06017C7F RID: 97407 RVA: 0x0060CDD0 File Offset: 0x0060AFD0
	[return: Nullable(2)]
	public ABP_PerformanceRole_C GetAnimInstanceFromSkeletalMesh(USkeletalMeshComponent meshComponent)
	{
		UAnimInstance animInstance = meshComponent.GetAnimInstance();
		if (animInstance == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiComponent;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "Ui场景以下网格体AnimInstance获取失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Mesh:", meshComponent.SkeletalMesh);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		UAnimInstance linkedAnimGraphInstanceByTag = animInstance.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE);
		if (linkedAnimGraphInstanceByTag == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiComponent;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "Ui场景以下网格体动画状态机ABP_Performance_{角色}_PC需要重新生成";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Mesh:", meshComponent.SkeletalMesh);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		if (this.BaseInstance == null)
		{
			this.BaseInstance = ResourceSystem.Instance.GetLoadedAsset<UClass>("/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C");
			if (this.BaseInstance == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiComponent;
				ELogAuthor author3 = ELogAuthor.LZK;
				string message3 = "Ui场景 基本路径网格体动画蓝图错误";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("现错误Path:", "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C");
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return null;
			}
		}
		if (linkedAnimGraphInstanceByTag.IsA(this.BaseInstance.ClassStackOnlyPtr))
		{
			return linkedAnimGraphInstanceByTag as ABP_PerformanceRole_C;
		}
		return null;
	}

	// Token: 0x06017C80 RID: 97408 RVA: 0x0060CEC4 File Offset: 0x0060B0C4
	[NullableContext(2)]
	private void SetMeshComponentEnable(USkeletalMeshComponent meshComp, bool enable)
	{
		meshComp.SetHiddenInGame(!enable, false);
		meshComp.SetComponentTickEnabled(enable);
	}

	// Token: 0x06017C81 RID: 97409 RVA: 0x0060CED8 File Offset: 0x0060B0D8
	[NullableContext(2)]
	private void SetMeshComponentVisibility(USkeletalMeshComponent meshComp, bool visible)
	{
		meshComp.SetVisibility(visible, false);
	}

	// Token: 0x06017C82 RID: 97410 RVA: 0x0060CEE2 File Offset: 0x0060B0E2
	[NullableContext(2)]
	public AActor GetActor()
	{
		return this.Actor;
	}

	// Token: 0x06017C83 RID: 97411 RVA: 0x0060CEEC File Offset: 0x0060B0EC
	[return: Nullable(2)]
	public ABP_TuanziNPC_C GetDangoAnimInstanceFromSkeletalMesh(USkeletalMeshComponent meshComponent)
	{
		UAnimInstance animInstance = meshComponent.GetAnimInstance();
		if (animInstance == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiComponent;
			ELogAuthor author = ELogAuthor.BB;
			string message = "Ui团子获取网格体AnimInstance失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Mesh:", meshComponent.SkeletalMesh);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return animInstance as ABP_TuanziNPC_C;
	}

	// Token: 0x06017C84 RID: 97412 RVA: 0x0060CF38 File Offset: 0x0060B138
	public void SetPlanarReflectionRenderOffset(bool enable, FVector? offset)
	{
		if (this.Actor == null)
		{
			return;
		}
		FVector inOffsetWS = offset ?? new FVector();
		USkeletalMeshComponent mainMeshComponent = this.MainMeshComponent;
		if (mainMeshComponent != null)
		{
			mainMeshComponent.SetPlanarReflectionRenderOffset(enable, inOffsetWS);
		}
		if (this.ChildMeshComponentList != null && this.ChildMeshComponentList.Count > 0)
		{
			foreach (USkeletalMeshComponent uskeletalMeshComponent in this.ChildMeshComponentList)
			{
				uskeletalMeshComponent.SetPlanarReflectionRenderOffset(enable, inOffsetWS);
			}
		}
		if (this.DecorationMeshComponentList != null && this.DecorationMeshComponentList.Count > 0)
		{
			foreach (USkeletalMeshComponent uskeletalMeshComponent2 in this.DecorationMeshComponentList)
			{
				uskeletalMeshComponent2.SetPlanarReflectionRenderOffset(enable, inOffsetWS);
			}
		}
	}

	// Token: 0x06017C85 RID: 97413 RVA: 0x0060D030 File Offset: 0x0060B230
	public void OnModelPlanarReflectionRenderOffsetChange(bool enable, FVector? offset)
	{
		this.SetPlanarReflectionRenderOffset(enable, offset);
	}

	// Token: 0x0400B130 RID: 45360
	[Nullable(2)]
	public AActor Actor;

	// Token: 0x0400B131 RID: 45361
	[Nullable(2)]
	public USkeletalMeshComponent MainMeshComponent;

	// Token: 0x0400B132 RID: 45362
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<USkeletalMeshComponent> ChildMeshComponentList;

	// Token: 0x0400B133 RID: 45363
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<USkeletalMeshComponent> DecorationMeshComponentList;

	// Token: 0x0400B134 RID: 45364
	[Nullable(2)]
	public CharRenderingComponent CharRenderingComponent;

	// Token: 0x0400B135 RID: 45365
	[Nullable(2)]
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B136 RID: 45366
	[Nullable(2)]
	private UiModelEffectComponent EffectComponent;

	// Token: 0x0400B137 RID: 45367
	[Nullable(2)]
	private UClass BaseInstance;
}
