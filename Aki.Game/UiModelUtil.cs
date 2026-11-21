using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200221C RID: 8732
[NullableContext(1)]
[Nullable(0)]
public class UiModelUtil : Singleton
{
	// Token: 0x06015797 RID: 87959 RVA: 0x0063C948 File Offset: 0x0063AB48
	public void PlayEffectOnRootByPath(UiModelBase model, string effectPath)
	{
		UiModelEffectComponent uiModelEffectComponent = model.CheckGetComponent<UiModelEffectComponent>();
		UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
		USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
		if (uskeletalMeshComponent == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.LZK, "MainMeshComponent为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (uiModelEffectComponent != null)
		{
			uiModelEffectComponent.PlayEffectOnRoot(effectPath, uskeletalMeshComponent, CharacterNameDefines.Instance.ROOT, true);
		}
	}

	// Token: 0x06015798 RID: 87960 RVA: 0x0063C9A8 File Offset: 0x0063ABA8
	public void PlayEffectOnRoot(UiModelBase model, string effectId)
	{
		string effectPath = EffectUtil.GetEffectPath(effectId);
		this.PlayEffectOnRootByPath(model, effectPath);
	}

	// Token: 0x06015799 RID: 87961 RVA: 0x0063C9C4 File Offset: 0x0063ABC4
	public void PlayEffectOnRootWithCallback(UiModelBase model, string effectId, Action<int> callback)
	{
		UiModelEffectComponent uiModelEffectComponent = model.CheckGetComponent<UiModelEffectComponent>();
		UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
		string effectPath = EffectUtil.GetEffectPath(effectId);
		USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
		if (uskeletalMeshComponent == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.LZK, "MainMeshComponent为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (uiModelEffectComponent == null)
		{
			return;
		}
		int id = uiModelEffectComponent.PlayEffectByPath(effectPath, uskeletalMeshComponent, CharacterNameDefines.Instance.ROOT, true, false, global::Vector.ZeroVectorDouble, Rotator.ZeroRotator, global::Vector.OneVectorDouble, true, null, null);
		EffectSystem.Instance.AddFinishCallback(id, callback);
	}

	// Token: 0x0601579A RID: 87962 RVA: 0x0063CA4C File Offset: 0x0063AC4C
	public void PlayEffectAtRootComponentByPath(UiModelBase model, string effectPath)
	{
		UiModelEffectComponent uiModelEffectComponent = model.CheckGetComponent<UiModelEffectComponent>();
		UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
		USceneComponent usceneComponent;
		if (uiModelActorComponent == null)
		{
			usceneComponent = null;
		}
		else
		{
			AActor actor = uiModelActorComponent.Actor;
			usceneComponent = ((actor != null) ? actor.RootComponent : null);
		}
		USceneComponent usceneComponent2 = usceneComponent;
		if (usceneComponent2 == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.LZK, "Actor为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (uiModelEffectComponent != null)
		{
			uiModelEffectComponent.PlayEffectOnRoot(effectPath, usceneComponent2, FNameUtil.EMPTY, true);
		}
	}

	// Token: 0x0601579B RID: 87963 RVA: 0x0063CAB0 File Offset: 0x0063ACB0
	public void PlayEffectAtRootComponent(UiModelBase model, string effectId)
	{
		string effectPath = EffectUtil.GetEffectPath(effectId);
		this.PlayEffectAtRootComponentByPath(model, effectPath);
	}

	// Token: 0x0601579C RID: 87964 RVA: 0x0063CACC File Offset: 0x0063ACCC
	public int SetRenderingMaterial(UiModelBase model, string materialId)
	{
		UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = model.CheckGetComponent<UiModelRenderingMaterialComponent>();
		if (uiModelRenderingMaterialComponent == null)
		{
			return 0;
		}
		return uiModelRenderingMaterialComponent.SetRenderingMaterial(materialId);
	}

	// Token: 0x0601579D RID: 87965 RVA: 0x0063CAE0 File Offset: 0x0063ACE0
	public void RemoveRenderingMaterial(UiModelBase model, int materialHandleId)
	{
		UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = model.CheckGetComponent<UiModelRenderingMaterialComponent>();
		if (uiModelRenderingMaterialComponent == null)
		{
			return;
		}
		uiModelRenderingMaterialComponent.RemoveRenderingMaterial(materialHandleId);
	}

	// Token: 0x0601579E RID: 87966 RVA: 0x0063CAF3 File Offset: 0x0063ACF3
	public bool SetVisible(UiModelBase model, bool visible)
	{
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		return uiModelDataComponent != null && uiModelDataComponent.SetVisible(visible);
	}

	// Token: 0x0601579F RID: 87967 RVA: 0x0063CB07 File Offset: 0x0063AD07
	public void SetWeaponLevelMaterialBreachLevel(UiModelBase model, int breachLevel)
	{
		UiWeaponLevelMaterialComponent uiWeaponLevelMaterialComponent = model.CheckGetComponent<UiWeaponLevelMaterialComponent>();
		if (uiWeaponLevelMaterialComponent == null)
		{
			return;
		}
		uiWeaponLevelMaterialComponent.SetBreachLevel(breachLevel);
	}

	// Token: 0x060157A0 RID: 87968 RVA: 0x0063CB1A File Offset: 0x0063AD1A
	public void TryApplyWeaponLevelMaterial(UiModelBase model)
	{
		UiWeaponLevelMaterialComponent uiWeaponLevelMaterialComponent = model.CheckGetComponent<UiWeaponLevelMaterialComponent>();
		if (uiWeaponLevelMaterialComponent == null)
		{
			return;
		}
		uiWeaponLevelMaterialComponent.TryApply();
	}

	// Token: 0x060157A1 RID: 87969 RVA: 0x0063CB2C File Offset: 0x0063AD2C
	public FVector2D GetActorLguiPos(AActor actor, global::Vector offset = null)
	{
		if (offset == null)
		{
			offset = global::Vector.ZeroVectorProxy;
		}
		FVectorDouble fvectorDouble = actor.D_K2_GetActorLocation();
		FVectorDouble fvectorDouble2 = offset.ToUeVector(false);
		FVectorDouble fvectorDouble3 = fvectorDouble + fvectorDouble2;
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		FVector2D fvector2D = default(FVector2D);
		UGameplayStatics.D_ProjectWorldToScreen(Global.CharacterController, fvectorDouble3, ref fvector2D, true);
		FVector2D fvector2D2 = canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		Vector2D viewportSize = LGuiExtension.GetViewportSize();
		viewportSize.Set((double)fvector2D2.X - viewportSize.X / 2.0, (double)fvector2D2.Y - viewportSize.Y / 2.0);
		return viewportSize.ToUeVector2D(false);
	}

	// Token: 0x060157A2 RID: 87970 RVA: 0x0063CBD0 File Offset: 0x0063ADD0
	public void SetTransformByTag(UiModelBase model, string tag)
	{
		UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
		if (uiModelActorComponent == null)
		{
			return;
		}
		uiModelActorComponent.SetTransformByTag("MonsterCase");
	}

	// Token: 0x060157A3 RID: 87971 RVA: 0x0063CBE7 File Offset: 0x0063ADE7
	public void SelectDangoActor(TsUiSceneDangoActor actor, bool isSelect)
	{
		UiDangoMaterialChangeComponent uiDangoMaterialChangeComponent = actor.Model.CheckGetComponent<UiDangoMaterialChangeComponent>();
		if (uiDangoMaterialChangeComponent == null)
		{
			return;
		}
		uiDangoMaterialChangeComponent.ReplaceSelectMaterial(isSelect);
	}

	// Token: 0x060157A4 RID: 87972 RVA: 0x0063CC00 File Offset: 0x0063AE00
	public void DangoFadeIn(TsUiSceneDangoActor actor, ERoleFadeCurveDefine? curveId, Action fadeFinishCallBack = null)
	{
		if (curveId == null)
		{
			curveId = new ERoleFadeCurveDefine?(ERoleFadeCurveDefine.RoleFadeInCurve);
		}
		UiModelFadeComponent uiModelFadeComponent = actor.Model.CheckGetComponent<UiModelFadeComponent>();
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("RoleFadeInDuration").GetValueOrDefault();
		if (uiModelFadeComponent == null)
		{
			return;
		}
		float startValue = 1f;
		float endValue = 0f;
		float duration = (float)valueOrDefault;
		ERoleFadeCurveDefine? eroleFadeCurveDefine = curveId;
		uiModelFadeComponent.Fade(startValue, endValue, duration, (eroleFadeCurveDefine != null) ? eroleFadeCurveDefine.GetValueOrDefault() : null, fadeFinishCallBack);
	}

	// Token: 0x060157A5 RID: 87973 RVA: 0x0063CC7C File Offset: 0x0063AE7C
	public void DangoFadeOut(TsUiSceneDangoActor roleActor, ERoleFadeCurveDefine? curveId, Action fadeFinishCallBack = null)
	{
		if (curveId == null)
		{
			curveId = new ERoleFadeCurveDefine?(ERoleFadeCurveDefine.RoleFadeOutCurve);
		}
		UiModelFadeComponent uiModelFadeComponent = roleActor.Model.CheckGetComponent<UiModelFadeComponent>();
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("RoleFadeOutDuration").GetValueOrDefault();
		if (uiModelFadeComponent == null)
		{
			return;
		}
		float startValue = 0f;
		float endValue = 1f;
		float duration = (float)valueOrDefault;
		ERoleFadeCurveDefine? eroleFadeCurveDefine = curveId;
		uiModelFadeComponent.Fade(startValue, endValue, duration, (eroleFadeCurveDefine != null) ? eroleFadeCurveDefine.GetValueOrDefault() : null, fadeFinishCallBack);
	}

	// Token: 0x060157A6 RID: 87974 RVA: 0x0063CCF8 File Offset: 0x0063AEF8
	public void ModelFadeIn(UiModelBase model, ERoleFadeCurveDefine? curveId, Action fadeFinishCallBack = null)
	{
		if (curveId == null)
		{
			curveId = new ERoleFadeCurveDefine?(ERoleFadeCurveDefine.RoleFadeInCurve);
		}
		if (model == null)
		{
			return;
		}
		UiModelFadeComponent uiModelFadeComponent = model.CheckGetComponent<UiModelFadeComponent>();
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("RoleFadeInDuration").GetValueOrDefault();
		if (uiModelFadeComponent == null)
		{
			return;
		}
		float startValue = 1f;
		float endValue = 0f;
		float duration = (float)valueOrDefault;
		ERoleFadeCurveDefine? eroleFadeCurveDefine = curveId;
		uiModelFadeComponent.Fade(startValue, endValue, duration, (eroleFadeCurveDefine != null) ? eroleFadeCurveDefine.GetValueOrDefault() : null, fadeFinishCallBack);
	}

	// Token: 0x060157A7 RID: 87975 RVA: 0x0063CD70 File Offset: 0x0063AF70
	public void ModelFadeOut(UiModelBase model, ERoleFadeCurveDefine? curveId, Action fadeFinishCallBack = null)
	{
		if (curveId == null)
		{
			curveId = new ERoleFadeCurveDefine?(ERoleFadeCurveDefine.RoleFadeOutCurve);
		}
		if (model == null)
		{
			return;
		}
		UiModelFadeComponent uiModelFadeComponent = model.CheckGetComponent<UiModelFadeComponent>();
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("RoleFadeOutDuration").GetValueOrDefault();
		if (uiModelFadeComponent == null)
		{
			return;
		}
		float startValue = 0f;
		float endValue = 1f;
		float duration = (float)valueOrDefault;
		ERoleFadeCurveDefine? eroleFadeCurveDefine = curveId;
		uiModelFadeComponent.Fade(startValue, endValue, duration, (eroleFadeCurveDefine != null) ? eroleFadeCurveDefine.GetValueOrDefault() : null, fadeFinishCallBack);
	}

	// Token: 0x060157A8 RID: 87976 RVA: 0x0063CDE8 File Offset: 0x0063AFE8
	public void SetDitherEffect(UiModelBase model, float value)
	{
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		if (uiModelDataComponent == null)
		{
			return;
		}
		uiModelDataComponent.SetDitherEffect(value);
	}

	// Token: 0x060157A9 RID: 87977 RVA: 0x0063CDFB File Offset: 0x0063AFFB
	public void StopFade(UiModelBase model)
	{
		UiModelFadeComponent uiModelFadeComponent = model.CheckGetComponent<UiModelFadeComponent>();
		if (uiModelFadeComponent == null)
		{
			return;
		}
		uiModelFadeComponent.StopFade();
	}

	// Token: 0x060157AA RID: 87978 RVA: 0x0063CE10 File Offset: 0x0063B010
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<EUiModelMorphType, IUiMorphId> GetRoleMorphConfigMap(int roleConfigId, int roleSkinId)
	{
		List<RoleMorph> roleMorphConfigList = RoleConfig.Instance.GetRoleMorphConfigList(roleConfigId, roleSkinId);
		if (roleMorphConfigList == null || roleMorphConfigList.Count == 0)
		{
			return null;
		}
		Dictionary<EUiModelMorphType, IUiMorphId> dictionary = new Dictionary<EUiModelMorphType, IUiMorphId>();
		foreach (RoleMorph roleMorph in roleMorphConfigList)
		{
			if (roleMorph.Morph != 0 && roleMorph.UiMeshId != 0)
			{
				SModelConfig modelConfig = ModelUtil.GetModelConfig(roleMorph.UiMeshId);
				string mainMeshPath = modelConfig.网格体.ToAssetPathName();
				string uiScenePerformanceABP = roleMorph.UiScenePerformanceABP;
				List<string> childMeshPathList = this.GetChildMeshPathList(roleMorph.UiMeshId);
				UiMorphId value = new UiMorphId
				{
					MainMeshPath = mainMeshPath,
					AnimPath = uiScenePerformanceABP,
					ChildMeshPathList = childMeshPathList,
					DecorationMeshConfigArray = modelConfig.UiModelDecorationArray,
					RoleBody = roleMorph.RoleBody
				};
				dictionary[(EUiModelMorphType)roleMorph.Morph] = value;
			}
		}
		if (dictionary.Count > 0)
		{
			EUiModelMorphType key = EUiModelMorphType.默认形态;
			RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(roleSkinId);
			if (roleSkinData != null)
			{
				int uiMeshId = roleSkinData.GetUiMeshId();
				SModelConfig modelConfig2 = ModelUtil.GetModelConfig(uiMeshId);
				string mainMeshPath2 = modelConfig2.网格体.ToAssetPathName();
				string uiScenePerformanceABP2 = roleSkinData.GetRoleSkinConfig().UiScenePerformanceABP;
				List<string> childMeshPathList2 = this.GetChildMeshPathList(uiMeshId);
				UiMorphId value2 = new UiMorphId
				{
					MainMeshPath = mainMeshPath2,
					AnimPath = uiScenePerformanceABP2,
					ChildMeshPathList = childMeshPathList2,
					RoleBody = roleSkinData.GetRoleSkinConfig().RoleBody,
					DecorationMeshConfigArray = modelConfig2.UiModelDecorationArray
				};
				dictionary[key] = value2;
			}
		}
		return dictionary;
	}

	// Token: 0x060157AB RID: 87979 RVA: 0x0063CFBC File Offset: 0x0063B1BC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> GetChildMeshPathList(int modelId)
	{
		TArray<SModelChildMeshConfig> ui用子网格体 = ModelUtil.GetModelConfig(modelId).UI用子网格体;
		if (ui用子网格体 != null)
		{
			int num = ui用子网格体.Num();
			if (num > 0)
			{
				List<string> list = new List<string>(num);
				for (int i = 0; i < num; i++)
				{
					list.Add(ui用子网格体.Get(i).SkeletalMesh.ToAssetPathName());
				}
				return list;
			}
		}
		return null;
	}

	// Token: 0x060157AC RID: 87980 RVA: 0x0063D010 File Offset: 0x0063B210
	public void CheckPathListAndAdd(List<string> pathList, [Nullable(new byte[]
	{
		2,
		1
	})] List<string> checkPathList)
	{
		if (checkPathList != null && checkPathList.Count > 0)
		{
			foreach (string text in checkPathList)
			{
				if (!StringUtils.IsEmpty(text))
				{
					pathList.Add(text);
				}
			}
		}
	}

	// Token: 0x060157AD RID: 87981 RVA: 0x0063D074 File Offset: 0x0063B274
	public void PlayRoleMontage(UiModelBase model, EPerformanceRoleState roleState, bool reLoop = false, bool reLoopFromLoopToStart = false, bool waitLaseStateEnd = false)
	{
		UiRoleStateMachineComponent uiRoleStateMachineComponent = model.CheckGetComponent<UiRoleStateMachineComponent>();
		if (uiRoleStateMachineComponent == null)
		{
			return;
		}
		uiRoleStateMachineComponent.SetState(roleState, reLoop, reLoopFromLoopToStart, waitLaseStateEnd);
	}

	// Token: 0x060157AE RID: 87982 RVA: 0x0063D08C File Offset: 0x0063B28C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<T> GetSelfAndOwnerComponents<[Nullable(0)] T>(AActor outer, bool includeOwner = false) where T : UiModelComponentBase
	{
		List<T> list = new List<T>();
		T uiModelComponent = this.GetUiModelComponent<T>(outer);
		if (uiModelComponent != null)
		{
			list.Add(uiModelComponent);
		}
		if (!includeOwner)
		{
			return list;
		}
		AActor attachRootParentActor = outer.GetAttachRootParentActor();
		if (attachRootParentActor != null && attachRootParentActor.IsValid())
		{
			T uiModelComponent2 = this.GetUiModelComponent<T>(attachRootParentActor);
			if (uiModelComponent2 != null)
			{
				list.Add(uiModelComponent2);
			}
		}
		return list;
	}

	// Token: 0x060157AF RID: 87983 RVA: 0x0063D0E8 File Offset: 0x0063B2E8
	[return: Nullable(2)]
	public T GetUiModelComponent<[Nullable(0)] T>(AActor outer) where T : UiModelComponentBase
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = outer as TsUiSceneRoleActor;
		if (tsUiSceneRoleActor != null)
		{
			UiModelBase model = tsUiSceneRoleActor.Model;
			if (model == null)
			{
				return default(T);
			}
			return model.CheckGetComponent<T>();
		}
		else
		{
			TsSkeletalObserver tsSkeletalObserver = outer as TsSkeletalObserver;
			if (tsSkeletalObserver == null)
			{
				return default(T);
			}
			UiModelBase model2 = tsSkeletalObserver.Model;
			if (model2 == null)
			{
				return default(T);
			}
			return model2.GetComponent<T>();
		}
	}

	// Token: 0x060157B0 RID: 87984 RVA: 0x0063D146 File Offset: 0x0063B346
	public static void RefreshRoleOrnaments(UiModelBase model, [Nullable(new byte[]
	{
		2,
		1
	})] OrnamentModelContext[] contexts = null, bool forceRefresh = false)
	{
		UiRoleOrnamentComponent uiRoleOrnamentComponent = model.CheckGetComponent<UiRoleOrnamentComponent>();
		if (uiRoleOrnamentComponent == null)
		{
			return;
		}
		uiRoleOrnamentComponent.RefreshModels(contexts, forceRefresh);
	}

	// Token: 0x060157B1 RID: 87985 RVA: 0x0063D15C File Offset: 0x0063B35C
	public static void LoadRoleModelWithOrnaments(UiModelBase model, int roleId, int roleSkinId, [Nullable(new byte[]
	{
		2,
		1
	})] OrnamentModelContext[] ornamentContexts = null, bool waitMeshStreaming = false, [Nullable(2)] Action callback = null)
	{
		UiRoleOrnamentComponent uiRoleOrnamentComponent = model.CheckGetComponent<UiRoleOrnamentComponent>();
		if (ornamentContexts != null && uiRoleOrnamentComponent != null)
		{
			uiRoleOrnamentComponent.SetPendingContexts(ornamentContexts);
		}
		UiRoleLoadComponent uiRoleLoadComponent = model.CheckGetComponent<UiRoleLoadComponent>();
		if (uiRoleLoadComponent != null)
		{
			uiRoleLoadComponent.LoadModelByRoleDataId(roleId, roleSkinId, waitMeshStreaming, callback);
		}
		if (uiRoleOrnamentComponent != null && uiRoleOrnamentComponent.HasPendingContexts())
		{
			uiRoleOrnamentComponent.RefreshModels(uiRoleOrnamentComponent.ConsumePendingContexts(), false);
		}
	}

	// Token: 0x060157B2 RID: 87986 RVA: 0x0063D1AC File Offset: 0x0063B3AC
	public static OrnamentModelContext BuildOrnamentModelContext(int skinId, int ornamentId)
	{
		Ornament value = RoleConfig.Instance.GetOrnamentConfig(ornamentId).Value;
		int skinOrnamentModelId = RoleUtils.GetSkinOrnamentModelId(skinId, ornamentId);
		List<long> list = new List<long>();
		for (int i = 0; i < value.OrnamentUiBuffLength; i++)
		{
			list.Add(value.OrnamentUiBuff(i));
		}
		List<string> list2 = new List<string>();
		for (int j = 0; j < value.UiModelEquipTagsLength; j++)
		{
			list2.Add(value.UiModelEquipTags(j));
		}
		return new OrnamentModelContext
		{
			ModelId = skinOrnamentModelId,
			HideInUi = value.HideInUi,
			OrnamentUiBuff = list,
			EquipTags = list2
		};
	}

	// Token: 0x060157B3 RID: 87987 RVA: 0x0063D254 File Offset: 0x0063B454
	public static List<OrnamentModelContext> GetSkinWearingOrnamentContexts(int roleId, int skinId)
	{
		List<int> roleSkinAllWearingOrnaments = RoleOrnamentModel.Instance.GetRoleSkinAllWearingOrnaments(roleId, skinId);
		if (roleSkinAllWearingOrnaments.Count == 0)
		{
			return new List<OrnamentModelContext>();
		}
		List<OrnamentModelContext> list = new List<OrnamentModelContext>();
		foreach (int ornamentId in roleSkinAllWearingOrnaments)
		{
			list.Add(UiModelUtil.BuildOrnamentModelContext(skinId, ornamentId));
		}
		return list;
	}

	// Token: 0x060157B4 RID: 87988 RVA: 0x0063D2CC File Offset: 0x0063B4CC
	public static bool NeedPreHideAnsEffectOnEnd(UiAnsContextBase ansContext)
	{
		UiEffectAnsContext uiEffectAnsContext = ansContext as UiEffectAnsContext;
		if (uiEffectAnsContext == null || uiEffectAnsContext.EffectPath == null)
		{
			return false;
		}
		foreach (string value in UiModelAnsPreHideConfig.PreHideOnAnsEndEffects)
		{
			if (uiEffectAnsContext.EffectPath.Contains(value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x17002094 RID: 8340
	// (get) Token: 0x060157B5 RID: 87989 RVA: 0x0063D33C File Offset: 0x0063B53C
	public static UiModelUtil Instance
	{
		get
		{
			if (UiModelUtil._instance == null)
			{
				UiModelUtil._instance = new UiModelUtil();
				UiModelUtil._instance.OnInit();
			}
			return UiModelUtil._instance;
		}
	}

	// Token: 0x060157B6 RID: 87990 RVA: 0x0063D35F File Offset: 0x0063B55F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060157B7 RID: 87991 RVA: 0x0063D361 File Offset: 0x0063B561
	public static void ResetStaticDefaultValue()
	{
		UiModelUtil instance = UiModelUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiModelUtil._instance = null;
	}

	// Token: 0x060157B8 RID: 87992 RVA: 0x0063D37A File Offset: 0x0063B57A
	static UiModelUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelUtil.CreateStaticDefaultValue), new Action(UiModelUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0400B5E8 RID: 46568
	[Nullable(2)]
	private static UiModelUtil _instance;
}
