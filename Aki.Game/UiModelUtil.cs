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

// Token: 0x02002CC3 RID: 11459
[NullableContext(1)]
[Nullable(0)]
public class UiModelUtil : Singleton
{
	// Token: 0x06017F1E RID: 98078 RVA: 0x00616C88 File Offset: 0x00614E88
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

	// Token: 0x06017F1F RID: 98079 RVA: 0x00616CE8 File Offset: 0x00614EE8
	public void PlayEffectOnRoot(UiModelBase model, string effectId)
	{
		string effectPath = EffectUtil.GetEffectPath(effectId);
		this.PlayEffectOnRootByPath(model, effectPath);
	}

	// Token: 0x06017F20 RID: 98080 RVA: 0x00616D04 File Offset: 0x00614F04
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

	// Token: 0x06017F21 RID: 98081 RVA: 0x00616D8C File Offset: 0x00614F8C
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

	// Token: 0x06017F22 RID: 98082 RVA: 0x00616DF0 File Offset: 0x00614FF0
	public void PlayEffectAtRootComponent(UiModelBase model, string effectId)
	{
		string effectPath = EffectUtil.GetEffectPath(effectId);
		this.PlayEffectAtRootComponentByPath(model, effectPath);
	}

	// Token: 0x06017F23 RID: 98083 RVA: 0x00616E0C File Offset: 0x0061500C
	public int SetRenderingMaterial(UiModelBase model, string materialId)
	{
		UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = model.CheckGetComponent<UiModelRenderingMaterialComponent>();
		if (uiModelRenderingMaterialComponent == null)
		{
			return 0;
		}
		return uiModelRenderingMaterialComponent.SetRenderingMaterial(materialId);
	}

	// Token: 0x06017F24 RID: 98084 RVA: 0x00616E20 File Offset: 0x00615020
	public void RemoveRenderingMaterial(UiModelBase model, int materialHandleId)
	{
		UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = model.CheckGetComponent<UiModelRenderingMaterialComponent>();
		if (uiModelRenderingMaterialComponent == null)
		{
			return;
		}
		uiModelRenderingMaterialComponent.RemoveRenderingMaterial(materialHandleId);
	}

	// Token: 0x06017F25 RID: 98085 RVA: 0x00616E33 File Offset: 0x00615033
	public bool SetVisible(UiModelBase model, bool visible)
	{
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		return uiModelDataComponent != null && uiModelDataComponent.SetVisible(visible);
	}

	// Token: 0x06017F26 RID: 98086 RVA: 0x00616E47 File Offset: 0x00615047
	public void SetWeaponLevelMaterialBreachLevel(UiModelBase model, int breachLevel)
	{
		UiWeaponLevelMaterialComponent uiWeaponLevelMaterialComponent = model.CheckGetComponent<UiWeaponLevelMaterialComponent>();
		if (uiWeaponLevelMaterialComponent == null)
		{
			return;
		}
		uiWeaponLevelMaterialComponent.SetBreachLevel(breachLevel);
	}

	// Token: 0x06017F27 RID: 98087 RVA: 0x00616E5A File Offset: 0x0061505A
	public void TryApplyWeaponLevelMaterial(UiModelBase model)
	{
		UiWeaponLevelMaterialComponent uiWeaponLevelMaterialComponent = model.CheckGetComponent<UiWeaponLevelMaterialComponent>();
		if (uiWeaponLevelMaterialComponent == null)
		{
			return;
		}
		uiWeaponLevelMaterialComponent.TryApply();
	}

	// Token: 0x06017F28 RID: 98088 RVA: 0x00616E6C File Offset: 0x0061506C
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

	// Token: 0x06017F29 RID: 98089 RVA: 0x00616F10 File Offset: 0x00615110
	public void SetTransformByTag(UiModelBase model, string tag)
	{
		UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
		if (uiModelActorComponent == null)
		{
			return;
		}
		uiModelActorComponent.SetTransformByTag("MonsterCase");
	}

	// Token: 0x06017F2A RID: 98090 RVA: 0x00616F27 File Offset: 0x00615127
	public void SelectDangoActor(TsUiSceneDangoActor actor, bool isSelect)
	{
		UiDangoMaterialChangeComponent uiDangoMaterialChangeComponent = actor.Model.CheckGetComponent<UiDangoMaterialChangeComponent>();
		if (uiDangoMaterialChangeComponent == null)
		{
			return;
		}
		uiDangoMaterialChangeComponent.ReplaceSelectMaterial(isSelect);
	}

	// Token: 0x06017F2B RID: 98091 RVA: 0x00616F40 File Offset: 0x00615140
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

	// Token: 0x06017F2C RID: 98092 RVA: 0x00616FBC File Offset: 0x006151BC
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

	// Token: 0x06017F2D RID: 98093 RVA: 0x00617038 File Offset: 0x00615238
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

	// Token: 0x06017F2E RID: 98094 RVA: 0x006170B0 File Offset: 0x006152B0
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

	// Token: 0x06017F2F RID: 98095 RVA: 0x00617128 File Offset: 0x00615328
	public void SetDitherEffect(UiModelBase model, float value)
	{
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		if (uiModelDataComponent == null)
		{
			return;
		}
		uiModelDataComponent.SetDitherEffect(value);
	}

	// Token: 0x06017F30 RID: 98096 RVA: 0x0061713B File Offset: 0x0061533B
	public void StopFade(UiModelBase model)
	{
		UiModelFadeComponent uiModelFadeComponent = model.CheckGetComponent<UiModelFadeComponent>();
		if (uiModelFadeComponent == null)
		{
			return;
		}
		uiModelFadeComponent.StopFade();
	}

	// Token: 0x06017F31 RID: 98097 RVA: 0x00617150 File Offset: 0x00615350
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

	// Token: 0x06017F32 RID: 98098 RVA: 0x006172FC File Offset: 0x006154FC
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

	// Token: 0x06017F33 RID: 98099 RVA: 0x00617350 File Offset: 0x00615550
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

	// Token: 0x06017F34 RID: 98100 RVA: 0x006173B4 File Offset: 0x006155B4
	public void PlayRoleMontage(UiModelBase model, EPerformanceRoleState roleState, bool reLoop = false, bool reLoopFromLoopToStart = false, bool waitLaseStateEnd = false)
	{
		UiRoleStateMachineComponent uiRoleStateMachineComponent = model.CheckGetComponent<UiRoleStateMachineComponent>();
		if (uiRoleStateMachineComponent == null)
		{
			return;
		}
		uiRoleStateMachineComponent.SetState(roleState, reLoop, reLoopFromLoopToStart, waitLaseStateEnd);
	}

	// Token: 0x06017F35 RID: 98101 RVA: 0x006173CC File Offset: 0x006155CC
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

	// Token: 0x06017F36 RID: 98102 RVA: 0x00617428 File Offset: 0x00615628
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

	// Token: 0x06017F37 RID: 98103 RVA: 0x00617486 File Offset: 0x00615686
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

	// Token: 0x06017F38 RID: 98104 RVA: 0x0061749C File Offset: 0x0061569C
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

	// Token: 0x06017F39 RID: 98105 RVA: 0x006174EC File Offset: 0x006156EC
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

	// Token: 0x06017F3A RID: 98106 RVA: 0x00617594 File Offset: 0x00615794
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

	// Token: 0x06017F3B RID: 98107 RVA: 0x0061760C File Offset: 0x0061580C
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

	// Token: 0x17002043 RID: 8259
	// (get) Token: 0x06017F3C RID: 98108 RVA: 0x0061767C File Offset: 0x0061587C
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

	// Token: 0x06017F3D RID: 98109 RVA: 0x0061769F File Offset: 0x0061589F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017F3E RID: 98110 RVA: 0x006176A1 File Offset: 0x006158A1
	public static void ResetStaticDefaultValue()
	{
		UiModelUtil instance = UiModelUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiModelUtil._instance = null;
	}

	// Token: 0x06017F3F RID: 98111 RVA: 0x006176BA File Offset: 0x006158BA
	static UiModelUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelUtil.CreateStaticDefaultValue), new Action(UiModelUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0400B27D RID: 45693
	[Nullable(2)]
	private static UiModelUtil _instance;
}
