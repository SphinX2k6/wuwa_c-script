using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.GaCha.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.WeaponLevelMaterial;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Weapon.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200225D RID: 8797
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WeaponController : UiControllerBase
{
	// Token: 0x06015C4F RID: 89167 RVA: 0x00650A58 File Offset: 0x0064EC58
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<WeaponItem, bool, bool>(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
		EventSystem.Instance.Add<WeaponItem>(EEventName.OnResponseWeaponItem, new Action<WeaponItem>(this.OnResponseWeaponItem));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemoveWeaponItem, new Action<IReadOnlyList<int>>(this.OnRemoveWeaponItem));
	}

	// Token: 0x06015C50 RID: 89168 RVA: 0x00650ABC File Offset: 0x0064ECBC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<WeaponItem, bool, bool>(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
		EventSystem.Instance.Remove<WeaponItem>(EEventName.OnResponseWeaponItem, new Action<WeaponItem>(this.OnResponseWeaponItem));
		EventSystem.Instance.Remove<IReadOnlyList<int>>(EEventName.OnRemoveWeaponItem, new Action<IReadOnlyList<int>>(this.OnRemoveWeaponItem));
	}

	// Token: 0x06015C51 RID: 89169 RVA: 0x00650B20 File Offset: 0x0064ED20
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.EquipTakeOnNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			EquipTakeOnNotify equipTakeOnNotify = (EquipTakeOnNotify)msg;
			if (equipTakeOnNotify == null)
			{
				return;
			}
			WeaponModel.Instance.WeaponRoleLoadEquip(equipTakeOnNotify.DataList);
		});
		Net.Instance.Register(ENotifyMessageId.EntityEquipChangeNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			EntityEquipChangeNotify entityEquipChangeNotify = (EntityEquipChangeNotify)msg;
			long creatureDataId = MathUtils.Instance.LongToNumber(entityEquipChangeNotify.EntityId);
			EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
			CharacterWeaponComponent characterWeaponComponent;
			if (entity == null)
			{
				characterWeaponComponent = null;
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				characterWeaponComponent = ((entity2 != null) ? entity2.GetComponent<CharacterWeaponComponent>() : null);
			}
			CharacterWeaponComponent characterWeaponComponent2 = characterWeaponComponent;
			if (characterWeaponComponent2 == null)
			{
				return;
			}
			characterWeaponComponent2.OnEquipWeaponForRoleNotify(entityEquipChangeNotify);
		});
	}

	// Token: 0x06015C52 RID: 89170 RVA: 0x00650B8B File Offset: 0x0064ED8B
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.EquipTakeOnNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityEquipChangeNotify);
	}

	// Token: 0x06015C53 RID: 89171 RVA: 0x00650BAD File Offset: 0x0064EDAD
	private void OnAddWeaponItem(WeaponItem weaponItem, bool b, bool arg3)
	{
		WeaponModel.Instance.AddWeaponData(weaponItem);
	}

	// Token: 0x06015C54 RID: 89172 RVA: 0x00650BBA File Offset: 0x0064EDBA
	private void OnResponseWeaponItem(WeaponItem weaponItem)
	{
		WeaponModel.Instance.AddWeaponData(weaponItem);
	}

	// Token: 0x06015C55 RID: 89173 RVA: 0x00650BC8 File Offset: 0x0064EDC8
	private void OnRemoveWeaponItem(IReadOnlyList<int> uniqueIdList)
	{
		foreach (int incId in uniqueIdList)
		{
			WeaponModel.Instance.RemoveWeaponData(incId);
		}
	}

	// Token: 0x06015C56 RID: 89174 RVA: 0x00650C14 File Offset: 0x0064EE14
	public void SendPbWeaponLevelUpRequest(int incId, ISelectedData[] consumeList)
	{
		WeaponLevelUpRequest weaponLevelUpRequest = WeaponLevelUpRequest.Create();
		weaponLevelUpRequest.IncId = incId;
		foreach (ISelectedData selectedData in consumeList)
		{
			WeaponConsumeItem weaponConsumeItem = WeaponConsumeItem.Create();
			weaponConsumeItem.Count = selectedData.SelectedCount;
			weaponConsumeItem.IncId = selectedData.IncId;
			weaponConsumeItem.ItemId = selectedData.ItemId;
			weaponLevelUpRequest.ConsumeList.Add(weaponConsumeItem);
		}
		Net.Instance.Call(ERequestMessageId.WeaponLevelUpRequest, weaponLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			WeaponLevelUpResponse weaponLevelUpResponse = (WeaponLevelUpResponse)msg;
			if (weaponLevelUpResponse == null)
			{
				return;
			}
			if (weaponLevelUpResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				WeaponModel.Instance.WeaponLevelUpResponse(weaponLevelUpResponse);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(weaponLevelUpResponse.ErrorCode, 17061, null, true, true);
		}, 0);
	}

	// Token: 0x06015C57 RID: 89175 RVA: 0x00650CB0 File Offset: 0x0064EEB0
	public void SendPbWeaponBreachRequest(int incId, Action<int> callback)
	{
		WeaponBreachRequest weaponBreachRequest = WeaponBreachRequest.Create();
		weaponBreachRequest.IncId = incId;
		Net.Instance.Call(ERequestMessageId.WeaponBreachRequest, weaponBreachRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			WeaponBreachResponse weaponBreachResponse = (WeaponBreachResponse)msg;
			if (weaponBreachResponse == null)
			{
				return;
			}
			if (weaponBreachResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				int weaponBreach = weaponBreachResponse.WeaponBreach;
				WeaponModel.Instance.SetWeaponBreachData(incId, weaponBreach);
				callback(weaponBreach);
				UiManager.Instance.OpenView(EUiViewName.WeaponBreachSuccessView, incId, null);
				EventSystem.Instance.Emit(EEventName.WeaponBreakUp);
				WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
				if (weaponDataByIncId != null && weaponDataByIncId.HasRole())
				{
					EventSystem.Instance.Emit<int>(EEventName.WeaponRoleBreakUp, weaponDataByIncId.GetRoleId());
					return;
				}
			}
			else
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(weaponBreachResponse.ErrorCode, 26514, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06015C58 RID: 89176 RVA: 0x00650D00 File Offset: 0x0064EF00
	public void SendPbResonUpRequest(int incId, WeaponConsumeItem[] consumeList)
	{
		if (RoleController.Instance.CheckCharacterInBattleTagAndShowTips(false))
		{
			return;
		}
		WeaponResonUpRequest weaponResonUpRequest = WeaponResonUpRequest.Create();
		weaponResonUpRequest.IncId = incId;
		weaponResonUpRequest.ConsumeItemList.AddRange(consumeList);
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		int lastLevel = weaponDataByIncId.GetResonanceLevel();
		Net.Instance.Call(ERequestMessageId.WeaponResonUpRequest, weaponResonUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			WeaponResonUpResponse weaponResonUpResponse = (WeaponResonUpResponse)msg;
			if (weaponResonUpResponse == null)
			{
				return;
			}
			if (weaponResonUpResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				WeaponModel.Instance.SetWeaponResonanceData(weaponResonUpResponse.IncId, weaponResonUpResponse.ReaonLevel);
				EventSystem.Instance.Emit<int, int>(EEventName.WeaponResonanceSuccess, incId, lastLevel);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(weaponResonUpResponse.ErrorCode, 21310, null, true, true);
		}, 0);
	}

	// Token: 0x06015C59 RID: 89177 RVA: 0x00650D80 File Offset: 0x0064EF80
	public void SendPbEquipTakeOnRequest(int roleId, EquipPos pos, int equipIncId)
	{
		if (RoleController.Instance.CheckCharacterInBattleTagAndShowTips(true))
		{
			return;
		}
		if (roleId <= 0)
		{
			return;
		}
		EquipTakeOnRequest equipTakeOnRequest = EquipTakeOnRequest.Create();
		equipTakeOnRequest.Data = RoleLoadEquipData.Create();
		equipTakeOnRequest.Data.RoleID = roleId;
		equipTakeOnRequest.Data.Pos = pos;
		equipTakeOnRequest.Data.EquipIncID = equipIncId;
		Net.Instance.Call(ERequestMessageId.EquipTakeOnRequest, equipTakeOnRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			EquipTakeOnResponse equipTakeOnResponse = (EquipTakeOnResponse)msg;
			if (equipTakeOnResponse == null)
			{
				return;
			}
			if (equipTakeOnResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				WeaponModel.Instance.WeaponRoleLoadEquip(equipTakeOnResponse.DataList);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(equipTakeOnResponse.ErrorCode, 29980, null, true, true);
		}, 0);
	}

	// Token: 0x06015C5A RID: 89178 RVA: 0x00650E08 File Offset: 0x0064F008
	private static void LoadWeaponModelInCurrentObserver(int[] models, int[] modelsIndex, int transformId, string weaponCase, string scabbardCase, UiModelBase weaponModel, UiModelBase scabbardModel, bool needMeshStreaming = false, int? skinId = null)
	{
		WeaponController.<>c__DisplayClass11_0 CS$<>8__locals1 = new WeaponController.<>c__DisplayClass11_0();
		CS$<>8__locals1.weaponModel = weaponModel;
		CS$<>8__locals1.scabbardModel = scabbardModel;
		CS$<>8__locals1.weaponCase = weaponCase;
		if (CS$<>8__locals1.weaponModel == null)
		{
			return;
		}
		if (models.Length == 0)
		{
			Log.Instance.Error(ELogModule.Weapon, ELogAuthor.LRC, "武器模型未配置 请检查", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (models.Length != modelsIndex.Length)
		{
			Log.Instance.Error(ELogModule.Weapon, ELogAuthor.LRC, "武器模型与索引配置长度不一致 请检查", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		CS$<>8__locals1.weaponPromise = new CustomPromise();
		CS$<>8__locals1.scabbardPromise = new CustomPromise();
		UiModelEffectComponent component = CS$<>8__locals1.weaponModel.GetComponent<UiModelEffectComponent>();
		if (component != null)
		{
			component.NeedSetUiScale = true;
		}
		UiWeaponDataComponent uiWeaponDataComponent = CS$<>8__locals1.weaponModel.CheckGetComponent<UiWeaponDataComponent>();
		SGachaWeaponTransform? sgachaWeaponTransform;
		if (!DataTableUtil.TryGetDataTableRowStruct<SGachaWeaponTransform>(EDataTable.GachaWeaponTransform, (skinId ?? uiWeaponDataComponent.WeaponConfigId).ToString(), out sgachaWeaponTransform))
		{
			WeaponController.<>c__DisplayClass11_0 CS$<>8__locals2 = CS$<>8__locals1;
			WeaponModelTransform? weaponModelTransformData = WeaponConfig.Instance.GetWeaponModelTransformData(transformId);
			CS$<>8__locals2.transformData = ((weaponModelTransformData != null) ? weaponModelTransformData.GetValueOrDefault() : null);
		}
		else
		{
			CS$<>8__locals1.transformData = sgachaWeaponTransform.Value;
		}
		CS$<>8__locals1.weaponActorComponent = CS$<>8__locals1.weaponModel.CheckGetComponent<UiModelActorComponent>();
		UiModelActorComponent weaponActorComponent = CS$<>8__locals1.weaponActorComponent;
		if (weaponActorComponent != null)
		{
			weaponActorComponent.SetTransformByTag(CS$<>8__locals1.weaponCase);
		}
		UiModelLoadComponent uiModelLoadComponent = CS$<>8__locals1.weaponModel.CheckGetComponent<UiModelLoadComponent>();
		int num = (modelsIndex.Length == models.Length) ? modelsIndex[0] : 0;
		WeaponDataBase weaponDataBase = (uiWeaponDataComponent != null) ? uiWeaponDataComponent.WeaponData : null;
		int breachLevel = (weaponDataBase != null) ? weaponDataBase.GetBreachLevel() : 0;
		UiModelUtil.Instance.SetWeaponLevelMaterialBreachLevel(CS$<>8__locals1.weaponModel, breachLevel);
		if (uiModelLoadComponent != null)
		{
			uiModelLoadComponent.LoadModelByModelId(models[num], needMeshStreaming, delegate
			{
				WeaponController.WeaponLoadCallBack(CS$<>8__locals1.weaponModel, CS$<>8__locals1.transformData, CS$<>8__locals1.weaponActorComponent);
				CS$<>8__locals1.weaponPromise.SetResult();
			}, null);
		}
		WeaponController.StartRotate(CS$<>8__locals1.weaponPromise, CS$<>8__locals1.scabbardPromise, CS$<>8__locals1.weaponModel, CS$<>8__locals1.transformData);
		if (CS$<>8__locals1.scabbardModel == null)
		{
			CS$<>8__locals1.scabbardPromise.SetResult();
			return;
		}
		if (CS$<>8__locals1.transformData.ShowScabbard())
		{
			if (models.Length > 1)
			{
				UiModelEffectComponent component2 = CS$<>8__locals1.scabbardModel.GetComponent<UiModelEffectComponent>();
				if (component2 != null)
				{
					component2.NeedSetUiScale = true;
				}
				UiModelLoadComponent uiModelLoadComponent2 = CS$<>8__locals1.scabbardModel.CheckGetComponent<UiModelLoadComponent>();
				int num2 = (modelsIndex.Length == models.Length) ? modelsIndex[1] : 1;
				UiModelUtil.Instance.SetWeaponLevelMaterialBreachLevel(CS$<>8__locals1.scabbardModel, breachLevel);
				uiModelLoadComponent2.LoadModelByModelId(models[num2], false, delegate
				{
					WeaponController.ScabbardLoadCallBack(CS$<>8__locals1.scabbardModel, CS$<>8__locals1.transformData, CS$<>8__locals1.weaponCase);
					CS$<>8__locals1.scabbardPromise.SetResult();
				}, null);
				return;
			}
		}
		else
		{
			UiModelUtil.Instance.SetVisible(CS$<>8__locals1.scabbardModel, false);
		}
		CS$<>8__locals1.scabbardPromise.SetResult();
	}

	// Token: 0x06015C5B RID: 89179 RVA: 0x00651078 File Offset: 0x0064F278
	private static void WeaponLoadCallBack(UiModelBase weaponModel, TWeaponModelTransform transformData, UiModelActorComponent weaponActorComponent)
	{
		UiModelUtil.Instance.SetVisible(weaponModel, true);
		global::Vector vector = transformData.Location();
		global::Vector vector2 = transformData.Rotation();
		global::Vector vector3 = transformData.AxisRotate();
		float num = transformData.Size();
		global::Vector inT = global::Vector.Create(vector.X, vector.Y, vector.Z);
		global::Rotator rotator = global::Rotator.Create((float)vector2.Y, (float)vector2.Z, (float)vector2.X);
		global::Vector inS = global::Vector.Create((double)num, (double)num, (double)num);
		global::Transform transform = global::Transform.Create(rotator.Quaternion(null), inT, inS);
		FHitResult fhitResult = new FHitResult();
		if (weaponActorComponent != null)
		{
			USkeletalMeshComponent mainMeshComponent = weaponActorComponent.MainMeshComponent;
			if (mainMeshComponent != null)
			{
				FTransformDouble ftransformDouble = transform.ToUeTransform();
				mainMeshComponent.D_K2_SetRelativeTransform(ftransformDouble, false, ref fhitResult, false);
			}
		}
		UiModelUtil.Instance.SetRenderingMaterial(weaponModel, "WeaponRootWeaponMaterialController");
		UiModelUtil.Instance.PlayEffectOnRoot(weaponModel, "WeaponRootWeaponShowHideEffect");
		rotator.Set((float)vector3.Y, (float)vector3.Z, (float)vector3.X);
		if (weaponActorComponent != null)
		{
			AActor actor = weaponActorComponent.Actor;
			if (actor == null)
			{
				return;
			}
			actor.K2_SetActorRotation(rotator.ToUeRotator(), false);
		}
	}

	// Token: 0x06015C5C RID: 89180 RVA: 0x00651188 File Offset: 0x0064F388
	private static void ScabbardLoadCallBack(UiModelBase scabbardModel, TWeaponModelTransform transformData, string weaponCase)
	{
		UiModelUtil.Instance.SetVisible(scabbardModel, true);
		UiModelActorComponent uiModelActorComponent = scabbardModel.CheckGetComponent<UiModelActorComponent>();
		uiModelActorComponent.SetTransformByTag(weaponCase);
		global::Vector vector = transformData.ScabbardOffset();
		global::Vector inT = global::Vector.Create(vector.X, vector.Y, vector.Z);
		global::Vector vector2 = transformData.HasScabbardValue() ? transformData.ScabbardRotationOffset() : transformData.Rotation();
		global::Rotator rotator = new global::Rotator((float)vector2.Y, (float)vector2.Z, (float)vector2.X);
		float num = transformData.Size();
		global::Vector inS = global::Vector.Create((double)num, (double)num, (double)num);
		global::Transform transform = global::Transform.Create(rotator.Quaternion(null), inT, inS);
		FHitResult fhitResult = new FHitResult();
		USkeletalMeshComponent mainMeshComponent = uiModelActorComponent.MainMeshComponent;
		if (mainMeshComponent != null)
		{
			FTransformDouble ftransformDouble = transform.ToUeTransform();
			mainMeshComponent.D_K2_SetRelativeTransform(ftransformDouble, false, ref fhitResult, false);
		}
		UiModelUtil.Instance.SetRenderingMaterial(scabbardModel, "WeaponRootWeaponMaterialController");
		UiModelRotateComponent uiModelRotateComponent = scabbardModel.CheckGetComponent<UiModelRotateComponent>();
		float aroundTime = transformData.RotateTime();
		uiModelRotateComponent.SetRotateParam(aroundTime, ERotateAxis.Yaw, true);
		uiModelRotateComponent.StartRotate();
		global::Vector vector3 = transformData.AxisRotate();
		rotator.Set((float)vector3.Y, (float)vector3.Z, (float)vector3.X);
		if (uiModelActorComponent == null)
		{
			return;
		}
		AActor actor = uiModelActorComponent.Actor;
		if (actor == null)
		{
			return;
		}
		actor.K2_SetActorRotation(rotator.ToUeRotator(), false);
	}

	// Token: 0x06015C5D RID: 89181 RVA: 0x006512C0 File Offset: 0x0064F4C0
	private static UniTask StartRotate(CustomPromise weaponPromise, CustomPromise scabbardPromise, UiModelBase weaponModel, TWeaponModelTransform transformData)
	{
		WeaponController.<StartRotate>d__14 <StartRotate>d__;
		<StartRotate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartRotate>d__.weaponPromise = weaponPromise;
		<StartRotate>d__.scabbardPromise = scabbardPromise;
		<StartRotate>d__.weaponModel = weaponModel;
		<StartRotate>d__.transformData = transformData;
		<StartRotate>d__.<>1__state = -1;
		<StartRotate>d__.<>t__builder.Start<WeaponController.<StartRotate>d__14>(ref <StartRotate>d__);
		return <StartRotate>d__.<>t__builder.Task;
	}

	// Token: 0x06015C5E RID: 89182 RVA: 0x0065131C File Offset: 0x0064F51C
	public void SelectedWeaponSkinChange(int incId, int skinId, SkeletalObserverHandle weaponObserver, SkeletalObserverHandle weaponScabbardObserver, bool needMeshStreaming = false)
	{
		if (skinId == -1)
		{
			WeaponConf? weaponConfig = WeaponModel.Instance.GetWeaponDataByIncId(incId).GetWeaponConfig();
			WeaponController.LoadWeaponModelInCurrentObserver(weaponConfig.Value.Models(), weaponConfig.Value.ModelsIndex(), weaponConfig.Value.TransformId, "WeaponSkinCase", "WeaponSkinCase", weaponObserver.Model, weaponScabbardObserver.Model, needMeshStreaming, null);
			return;
		}
		WeaponSkin weaponSkinConfig = SkinConfig.Instance.GetWeaponSkinConfig(skinId);
		WeaponController.LoadWeaponModelInCurrentObserver(weaponSkinConfig.Models(), weaponSkinConfig.ModelsIndex(), weaponSkinConfig.TransformId, "WeaponSkinCase", "WeaponSkinCase", weaponObserver.Model, weaponScabbardObserver.Model, needMeshStreaming, new int?(skinId));
	}

	// Token: 0x06015C5F RID: 89183 RVA: 0x006513D8 File Offset: 0x0064F5D8
	public void OnSelectedWeaponChange(WeaponDataBase weaponInstance, SkeletalObserverHandle weaponObserver, SkeletalObserverHandle weaponScabbardObserver, int skinId = -1, bool needMeshStreaming = false)
	{
		if (skinId == -1)
		{
			skinId = -1;
		}
		if (weaponObserver.Model != null)
		{
			UiModelBase model = weaponObserver.Model;
			UiWeaponDataComponent uiWeaponDataComponent = model.CheckGetComponent<UiWeaponDataComponent>();
			if (uiWeaponDataComponent != null)
			{
				uiWeaponDataComponent.SetWeaponData(weaponInstance);
			}
			UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
			if (uiModelDataComponent != null)
			{
				uiModelDataComponent.SetLoadingIconFollowState(needMeshStreaming);
			}
		}
		if (weaponScabbardObserver.Model != null)
		{
			weaponScabbardObserver.Model.CheckGetComponent<UiWeaponDataComponent>().SetWeaponData(weaponInstance);
		}
		WeaponController.LoadWeaponModelInCurrentObserver(weaponInstance.GetModels(skinId), weaponInstance.GetModelsIndex(skinId), weaponInstance.GetTransformId(skinId), "WeaponCase", "WeaponScabbardCase", weaponObserver.Model, weaponScabbardObserver.Model, needMeshStreaming, (skinId != -1) ? new int?(skinId) : null);
	}

	// Token: 0x06015C60 RID: 89184 RVA: 0x00651484 File Offset: 0x0064F684
	public void PlayWeaponRenderingMaterial(string materialId, SkeletalObserverHandle weaponObserver, SkeletalObserverHandle weaponScabbardObserver = null)
	{
		UiModelUtil.Instance.SetRenderingMaterial(weaponObserver.Model, materialId);
		if (weaponScabbardObserver != null)
		{
			UiModelUtil.Instance.SetRenderingMaterial(weaponScabbardObserver.Model, materialId);
		}
	}

	// Token: 0x06015C61 RID: 89185 RVA: 0x006514AD File Offset: 0x0064F6AD
	public void ApplyWeaponLevelMaterial(USkinnedMeshComponent mesh, PD_WeaponLevelMaterialDatas_C data, int level = 0)
	{
		BP_CharacterRenderingFunctionLibrary_C.ApplyWeaponLevelMaterial(mesh, data, level, mesh);
	}

	// Token: 0x06015C62 RID: 89186 RVA: 0x006514BC File Offset: 0x0064F6BC
	public UniTask LoadCharacterRenderingFunctionLibraryAsync()
	{
		WeaponController.<LoadCharacterRenderingFunctionLibraryAsync>d__19 <LoadCharacterRenderingFunctionLibraryAsync>d__;
		<LoadCharacterRenderingFunctionLibraryAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadCharacterRenderingFunctionLibraryAsync>d__.<>1__state = -1;
		<LoadCharacterRenderingFunctionLibraryAsync>d__.<>t__builder.Start<WeaponController.<LoadCharacterRenderingFunctionLibraryAsync>d__19>(ref <LoadCharacterRenderingFunctionLibraryAsync>d__);
		return <LoadCharacterRenderingFunctionLibraryAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015C63 RID: 89187 RVA: 0x006514F8 File Offset: 0x0064F6F8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<PD_WeaponLevelMaterialDatas_C> LoadWeaponLevelMaterialDataAsync(string daPath)
	{
		WeaponController.<LoadWeaponLevelMaterialDataAsync>d__20 <LoadWeaponLevelMaterialDataAsync>d__;
		<LoadWeaponLevelMaterialDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<PD_WeaponLevelMaterialDatas_C>.Create();
		<LoadWeaponLevelMaterialDataAsync>d__.daPath = daPath;
		<LoadWeaponLevelMaterialDataAsync>d__.<>1__state = -1;
		<LoadWeaponLevelMaterialDataAsync>d__.<>t__builder.Start<WeaponController.<LoadWeaponLevelMaterialDataAsync>d__20>(ref <LoadWeaponLevelMaterialDataAsync>d__);
		return <LoadWeaponLevelMaterialDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015C64 RID: 89188 RVA: 0x0065153C File Offset: 0x0064F73C
	public void RoleFadeIn(TsUiSceneRoleActor roleActor, string curveId = "RoleFadeInCurve")
	{
		UiModelFadeComponent uiModelFadeComponent = roleActor.Model.CheckGetComponent<UiModelFadeComponent>();
		int? intConfig = ConfigCommonParamById.GetIntConfig("RoleFadeInDuration");
		if (uiModelFadeComponent == null)
		{
			return;
		}
		uiModelFadeComponent.Fade(1f, 0f, (float)intConfig.Value, curveId, null);
	}

	// Token: 0x06015C65 RID: 89189 RVA: 0x00651580 File Offset: 0x0064F780
	public void RoleFadeOut(TsUiSceneRoleActor roleActor, string curveId = "RoleFadeOutCurve")
	{
		UiModelFadeComponent uiModelFadeComponent = roleActor.Model.CheckGetComponent<UiModelFadeComponent>();
		int? intConfig = ConfigCommonParamById.GetIntConfig("RoleFadeOutDuration");
		if (uiModelFadeComponent == null)
		{
			return;
		}
		uiModelFadeComponent.Fade(0f, 1f, (float)intConfig.Value, curveId, null);
	}

	// Token: 0x17002105 RID: 8453
	// (get) Token: 0x06015C66 RID: 89190 RVA: 0x006515C1 File Offset: 0x0064F7C1
	public static WeaponController Instance
	{
		get
		{
			return WeaponController._Instance;
		}
	}

	// Token: 0x06015C67 RID: 89191 RVA: 0x006515C8 File Offset: 0x0064F7C8
	public static WeaponController GetOrCreateInstance()
	{
		if (WeaponController._Instance == null)
		{
			WeaponController.CreateInstance();
		}
		return WeaponController._Instance;
	}

	// Token: 0x06015C68 RID: 89192 RVA: 0x006515DC File Offset: 0x0064F7DC
	public static bool CreateInstance()
	{
		if (WeaponController._Instance != null)
		{
			return true;
		}
		WeaponController._Instance = new WeaponController();
		return true;
	}

	// Token: 0x06015C69 RID: 89193 RVA: 0x006515F2 File Offset: 0x0064F7F2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015C6A RID: 89194 RVA: 0x006515F4 File Offset: 0x0064F7F4
	public static void ResetStaticDefaultValue()
	{
		WeaponController._Instance = null;
	}

	// Token: 0x06015C6B RID: 89195 RVA: 0x006515FC File Offset: 0x0064F7FC
	static WeaponController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeaponController.CreateStaticDefaultValue), new Action(WeaponController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B783 RID: 46979
	[Nullable(2)]
	private static WeaponController _Instance;
}
