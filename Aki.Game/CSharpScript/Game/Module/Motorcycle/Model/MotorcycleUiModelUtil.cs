using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Motorcycle.Model
{
	// Token: 0x02005394 RID: 21396
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleUiModelUtil : Singleton
	{
		// Token: 0x06036A87 RID: 223879 RVA: 0x00CEF866 File Offset: 0x00CEDA66
		public void CreateMotor(EUiModelUseWay useWay = EUiModelUseWay.MotorInMotorView)
		{
			UiSceneManager.Instance.InitMotorSkeletalHandle(useWay);
		}

		// Token: 0x06036A88 RID: 223880 RVA: 0x00CEF873 File Offset: 0x00CEDA73
		public void DestroyMotor()
		{
			UiSceneManager.Instance.DestroyMotorSkeletalHandle();
		}

		// Token: 0x06036A89 RID: 223881 RVA: 0x00CEF880 File Offset: 0x00CEDA80
		public void ClearMotorBuff()
		{
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiModelBuffComponent uiModelBuffComponent = motorModel.CheckGetComponent<UiModelBuffComponent>();
			if (uiModelBuffComponent == null)
			{
				return;
			}
			uiModelBuffComponent.RemoveAllBuffId();
		}

		// Token: 0x06036A8A RID: 223882 RVA: 0x00CEF8A8 File Offset: 0x00CEDAA8
		[NullableContext(2)]
		public UiModelBase GetMotorModel()
		{
			SkeletalObserverHandle motorSkeletalHandle = UiSceneManager.Instance.GetMotorSkeletalHandle();
			if (motorSkeletalHandle == null)
			{
				return null;
			}
			return motorSkeletalHandle.Model;
		}

		// Token: 0x06036A8B RID: 223883 RVA: 0x00CEF8C0 File Offset: 0x00CEDAC0
		public void InitAutoRotateParam(float autoRotateDuration, ERotateAxis axis = ERotateAxis.Yaw, bool isPlus = true)
		{
			UiModelBase motorModel = this.GetMotorModel();
			UiModelRotateComponent uiModelRotateComponent = (motorModel != null) ? motorModel.CheckGetComponent<UiModelRotateComponent>() : null;
			if (uiModelRotateComponent == null)
			{
				return;
			}
			uiModelRotateComponent.SetRotateParam(autoRotateDuration * 1000f, axis, isPlus);
		}

		// Token: 0x06036A8C RID: 223884 RVA: 0x00CEF8F4 File Offset: 0x00CEDAF4
		public void SetAutoRotate(bool isAutoRotate)
		{
			UiModelBase motorModel = this.GetMotorModel();
			UiModelRotateComponent uiModelRotateComponent = (motorModel != null) ? motorModel.CheckGetComponent<UiModelRotateComponent>() : null;
			if (uiModelRotateComponent == null)
			{
				return;
			}
			if (isAutoRotate)
			{
				uiModelRotateComponent.StartRotate();
				return;
			}
			uiModelRotateComponent.StopRotate();
		}

		// Token: 0x06036A8D RID: 223885 RVA: 0x00CEF928 File Offset: 0x00CEDB28
		private MotorcycleUiModelParam GetMotorEquipParam()
		{
			int equippedFrameId = MotorcycleDiyModel.Instance.GetEquippedFrameId();
			List<int> equippedStickerIdList = MotorcycleDiyModel.Instance.GetEquippedStickerIdList();
			List<int> equippedDecorationIdList = MotorcycleDiyModel.Instance.GetEquippedDecorationIdList();
			return new MotorcycleUiModelParam
			{
				FrameId = equippedFrameId,
				StickerIds = equippedStickerIdList.ToArray(),
				DecorationIds = equippedDecorationIdList.ToArray()
			};
		}

		// Token: 0x06036A8E RID: 223886 RVA: 0x00CEF97A File Offset: 0x00CEDB7A
		public bool IsMotorCreated()
		{
			return this.GetMotorModel() != null;
		}

		// Token: 0x06036A8F RID: 223887 RVA: 0x00CEF988 File Offset: 0x00CEDB88
		public void ShowMotor(bool isShow)
		{
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiModelUtil.Instance.SetVisible(motorModel, isShow);
			UiMotorDecorationComponent uiMotorDecorationComponent = motorModel.CheckGetComponent<UiMotorDecorationComponent>();
			if (uiMotorDecorationComponent != null)
			{
				uiMotorDecorationComponent.ShowAllDecoration(isShow);
			}
			UiMotorSoarWingComponent uiMotorSoarWingComponent = motorModel.CheckGetComponent<UiMotorSoarWingComponent>();
			if (uiMotorSoarWingComponent == null)
			{
				return;
			}
			uiMotorSoarWingComponent.TrySetActive(isShow);
		}

		// Token: 0x06036A90 RID: 223888 RVA: 0x00CEF9D0 File Offset: 0x00CEDBD0
		public void SetSoarWingEnabled(bool isEnabled)
		{
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiMotorSoarWingComponent uiMotorSoarWingComponent = motorModel.CheckGetComponent<UiMotorSoarWingComponent>();
			if (uiMotorSoarWingComponent == null)
			{
				return;
			}
			uiMotorSoarWingComponent.SetCanShowSoarWing(isEnabled);
		}

		// Token: 0x06036A91 RID: 223889 RVA: 0x00CEF9FC File Offset: 0x00CEDBFC
		public void ShowSoarWing(bool isShow)
		{
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiMotorSoarWingComponent uiMotorSoarWingComponent = motorModel.CheckGetComponent<UiMotorSoarWingComponent>();
			if (uiMotorSoarWingComponent == null)
			{
				return;
			}
			uiMotorSoarWingComponent.TrySetActive(isShow);
		}

		// Token: 0x06036A92 RID: 223890 RVA: 0x00CEFA28 File Offset: 0x00CEDC28
		public void ShowMotorLoadingIcon(bool isShow)
		{
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiModelLoadingIconComponent uiModelLoadingIconComponent = motorModel.CheckGetComponent<UiModelLoadingIconComponent>();
			if (uiModelLoadingIconComponent == null)
			{
				return;
			}
			uiModelLoadingIconComponent.SetLoadingActive(isShow);
		}

		// Token: 0x06036A93 RID: 223891 RVA: 0x00CEFA54 File Offset: 0x00CEDC54
		public void LoadEquippedMotor([Nullable(new byte[]
		{
			2,
			1
		})] Action<UiModelBase> afterLoadCallBack = null)
		{
			MotorcycleUiModelParam motorEquipParam = this.GetMotorEquipParam();
			this.LoadMotorByParam(motorEquipParam, afterLoadCallBack);
		}

		// Token: 0x06036A94 RID: 223892 RVA: 0x00CEFA70 File Offset: 0x00CEDC70
		[NullableContext(2)]
		public void LoadEquippedMotorAndRole(int roleId, int roleSkinId, string animPath = null)
		{
			UiModelBase motorModel = this.GetMotorModel();
			UiMotorDataComponent uiMotorDataComponent = (motorModel != null) ? motorModel.CheckGetComponent<UiMotorDataComponent>() : null;
			if (uiMotorDataComponent != null)
			{
				uiMotorDataComponent.SetRoleData(roleId, roleSkinId, animPath);
			}
			MotorcycleUiModelParam motorEquipParam = this.GetMotorEquipParam();
			this.LoadMotorByParam(motorEquipParam, null);
		}

		// Token: 0x06036A95 RID: 223893 RVA: 0x00CEFAAC File Offset: 0x00CEDCAC
		public void LoadMotorBySkinId(int skinId, [Nullable(new byte[]
		{
			2,
			1
		})] Action<UiModelBase> afterLoadCallBack = null)
		{
			MotorcycleDiySkinEquipRecord skinSuitRecord = MotorcycleDiyModel.Instance.GetSkinSuitRecord(skinId);
			if (skinSuitRecord == null)
			{
				return;
			}
			MotorcycleUiModelParam param = new MotorcycleUiModelParam
			{
				FrameId = skinSuitRecord.FrameId,
				StickerIds = skinSuitRecord.StickerIds,
				DecorationIds = skinSuitRecord.DecorateIds
			};
			this.LoadMotorByParam(param, afterLoadCallBack);
		}

		// Token: 0x06036A96 RID: 223894 RVA: 0x00CEFAFC File Offset: 0x00CEDCFC
		private List<int> AutoFixStickerIds(int[] stickerIds)
		{
			List<int> list = new List<int>
			{
				0,
				0,
				0
			};
			foreach (int num in stickerIds)
			{
				if (num > 0)
				{
					MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num);
					if (motorStickerConfig != null)
					{
						int partId = motorStickerConfig.Value.PartId;
						int num2 = Array.IndexOf<int>(MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART, partId);
						if (num2 != -1)
						{
							list[num2] = num;
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06036A97 RID: 223895 RVA: 0x00CEFB84 File Offset: 0x00CEDD84
		private List<int> AutoFixDecorationIds(int[] decorateIds)
		{
			List<int> defaultDecorationIdList = MotorcycleDiyModel.Instance.GetDefaultDecorationIdList();
			foreach (int num in decorateIds)
			{
				if (num > 0)
				{
					MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num);
					if (motorDecorationConfig != null)
					{
						int partId = motorDecorationConfig.Value.PartId;
						int num2 = Array.IndexOf<int>(MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART, partId);
						if (num2 != -1)
						{
							defaultDecorationIdList[num2] = num;
						}
					}
				}
			}
			return defaultDecorationIdList;
		}

		// Token: 0x06036A98 RID: 223896 RVA: 0x00CEFBFC File Offset: 0x00CEDDFC
		public void LoadMotorByParam(MotorcycleUiModelParam param, [Nullable(new byte[]
		{
			2,
			1
		})] Action<UiModelBase> afterLoadCallBack = null)
		{
			MotorcycleUiModelUtil.<>c__DisplayClass17_0 CS$<>8__locals1 = new MotorcycleUiModelUtil.<>c__DisplayClass17_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.afterLoadCallBack = afterLoadCallBack;
			CS$<>8__locals1.model = this.GetMotorModel();
			if (CS$<>8__locals1.model == null)
			{
				return;
			}
			UiModelLoadComponent uiModelLoadComponent = CS$<>8__locals1.model.CheckGetComponent<UiModelLoadComponent>();
			UiModelActorComponent uiModelActorComponent = CS$<>8__locals1.model.CheckGetComponent<UiModelActorComponent>();
			CS$<>8__locals1.motorDataComponent = CS$<>8__locals1.model.CheckGetComponent<UiMotorDataComponent>();
			CS$<>8__locals1.motorSoarWingComponent = CS$<>8__locals1.model.CheckGetComponent<UiMotorSoarWingComponent>();
			CS$<>8__locals1.frameId = param.FrameId;
			CS$<>8__locals1.stickerIds = this.AutoFixStickerIds(param.StickerIds ?? Array.Empty<int>());
			List<int> list = this.AutoFixDecorationIds(param.DecorationIds ?? Array.Empty<int>());
			CS$<>8__locals1.loadSeq = CS$<>8__locals1.motorDataComponent.NextLoadSeq();
			int requestedFrameId = CS$<>8__locals1.motorDataComponent.GetRequestedFrameId();
			CS$<>8__locals1.motorDataComponent.SetRequestedFrameId(CS$<>8__locals1.frameId);
			MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(CS$<>8__locals1.frameId);
			if (motorFrameConfig == null)
			{
				return;
			}
			CS$<>8__locals1.frameBuffIds = motorFrameConfig.Value.GetModelBuffArray();
			CS$<>8__locals1.frameAnimPath = (motorFrameConfig.Value.ModelAnim ?? "");
			UiMotorSoarWingComponent motorSoarWingComponent = CS$<>8__locals1.motorSoarWingComponent;
			if (motorSoarWingComponent != null)
			{
				motorSoarWingComponent.SetSoarWingId(motorFrameConfig.Value.Wing);
			}
			if (requestedFrameId != CS$<>8__locals1.frameId || CS$<>8__locals1.motorDataComponent.GetFrameId() != CS$<>8__locals1.frameId)
			{
				this.ShowMotor(false);
				List<string> list2 = new List<string>();
				if (!StringUtils.IsBlank(CS$<>8__locals1.frameAnimPath))
				{
					list2.Add(CS$<>8__locals1.frameAnimPath);
				}
				foreach (int num in CS$<>8__locals1.stickerIds)
				{
					if (num > 0)
					{
						MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num);
						if (motorStickerConfig != null && !StringUtils.IsBlank(motorStickerConfig.Value.MaterialDA))
						{
							list2.Add(motorStickerConfig.Value.MaterialDA);
						}
					}
				}
				CS$<>8__locals1.totalLoadCount = 1;
				int[] motorcycle_DIY_DECORATION_PART = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART;
				for (int i = 0; i < motorcycle_DIY_DECORATION_PART.Length; i++)
				{
					if (i < list.Count && list[i] != 0)
					{
						int totalLoadCount = CS$<>8__locals1.totalLoadCount;
						CS$<>8__locals1.totalLoadCount = totalLoadCount + 1;
					}
				}
				uiModelActorComponent.SetTransformByTag("RoleCase");
				CS$<>8__locals1.finishCount = 0;
				uiModelLoadComponent.LoadModelByModelId(motorFrameConfig.Value.ModelId, true, delegate
				{
					if (base.<LoadMotorByParam>g__IsStale|0())
					{
						return;
					}
					CS$<>8__locals1.motorDataComponent.SetFrameId(CS$<>8__locals1.frameId);
					CS$<>8__locals1.motorDataComponent.SetStickerIdList(CS$<>8__locals1.stickerIds);
					base.<LoadMotorByParam>g__CheckAllLoadFinish|1();
				}, list2);
				this.LoadDecorations(list, new Action(CS$<>8__locals1.<LoadMotorByParam>g__CheckAllLoadFinish|1));
				return;
			}
			this.HandleSticker(CS$<>8__locals1.stickerIds);
			this.LoadDecorations(list, null);
			CS$<>8__locals1.motorSoarWingComponent.RefreshCurSoarWing();
			Action<UiModelBase> afterLoadCallBack2 = CS$<>8__locals1.afterLoadCallBack;
			if (afterLoadCallBack2 == null)
			{
				return;
			}
			afterLoadCallBack2(CS$<>8__locals1.model);
		}

		// Token: 0x06036A99 RID: 223897 RVA: 0x00CEFEE4 File Offset: 0x00CEE0E4
		public void SetEmptySticker(int stickerPart)
		{
			if (stickerPart <= 0)
			{
				return;
			}
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiMotorStickerComponent uiMotorStickerComponent = motorModel.CheckGetComponent<UiMotorStickerComponent>();
			if (uiMotorStickerComponent == null)
			{
				return;
			}
			uiMotorStickerComponent.RemoveStickerMaterial(stickerPart);
		}

		// Token: 0x06036A9A RID: 223898 RVA: 0x00CEFF14 File Offset: 0x00CEE114
		public void AddMaterialByStickerId(int stickerId)
		{
			if (stickerId <= 0)
			{
				return;
			}
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiMotorStickerComponent uiMotorStickerComponent = motorModel.CheckGetComponent<UiMotorStickerComponent>();
			if (uiMotorStickerComponent == null)
			{
				return;
			}
			uiMotorStickerComponent.AddStickerMaterial(stickerId);
		}

		// Token: 0x06036A9B RID: 223899 RVA: 0x00CEFF44 File Offset: 0x00CEE144
		private void PlayFrameBuff(long[] frameBuffIds)
		{
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiModelBuffComponent uiModelBuffComponent = motorModel.CheckGetComponent<UiModelBuffComponent>();
			if (uiModelBuffComponent == null)
			{
				return;
			}
			uiModelBuffComponent.RemoveAllBuffId();
			foreach (long buffId in frameBuffIds)
			{
				uiModelBuffComponent.AddBuffByBuffId(buffId);
			}
		}

		// Token: 0x06036A9C RID: 223900 RVA: 0x00CEFF8C File Offset: 0x00CEE18C
		private void PlayFrameAnim(string frameAnimPath)
		{
			if (StringUtils.IsBlank(frameAnimPath))
			{
				return;
			}
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiModelLoadComponent uiModelLoadComponent = motorModel.CheckGetComponent<UiModelLoadComponent>();
			UiModelAnimationComponent uiModelAnimationComponent = motorModel.CheckGetComponent<UiModelAnimationComponent>();
			if (uiModelAnimationComponent == null || uiModelLoadComponent == null)
			{
				return;
			}
			UAnimationAsset uanimationAsset = uiModelLoadComponent.GetLoadedResource(frameAnimPath) as UAnimationAsset;
			if (uanimationAsset != null)
			{
				uiModelAnimationComponent.PlayAnimation(uanimationAsset, false);
			}
		}

		// Token: 0x06036A9D RID: 223901 RVA: 0x00CEFFDC File Offset: 0x00CEE1DC
		private void HandleSticker(List<int> stickerIds)
		{
			int[] motorcycle_DIY_STICKER_PART = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART;
			for (int i = 0; i < motorcycle_DIY_STICKER_PART.Length; i++)
			{
				int num = (stickerIds.Count > i) ? stickerIds[i] : 0;
				if (num == 0)
				{
					this.SetEmptySticker(motorcycle_DIY_STICKER_PART[i]);
				}
				else
				{
					this.AddMaterialByStickerId(num);
				}
			}
		}

		// Token: 0x06036A9E RID: 223902 RVA: 0x00CF0028 File Offset: 0x00CEE228
		private void LoadDecorations(List<int> decorationIds, [Nullable(2)] Action oneLoadCallBack = null)
		{
			int[] motorcycle_DIY_DECORATION_PART = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART;
			for (int i = 0; i < motorcycle_DIY_DECORATION_PART.Length; i++)
			{
				int num = (decorationIds.Count > i) ? decorationIds[i] : 0;
				if (num == 0)
				{
					this.SetEmptyDecoration(motorcycle_DIY_DECORATION_PART[i]);
				}
				else
				{
					this.AddDecoration(num, oneLoadCallBack);
				}
			}
		}

		// Token: 0x06036A9F RID: 223903 RVA: 0x00CF0074 File Offset: 0x00CEE274
		public void SetEmptyDecoration(int decorationPart)
		{
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiMotorDataComponent uiMotorDataComponent = motorModel.CheckGetComponent<UiMotorDataComponent>();
			UiMotorDecorationComponent uiMotorDecorationComponent = motorModel.CheckGetComponent<UiMotorDecorationComponent>();
			if (uiMotorDataComponent != null)
			{
				uiMotorDataComponent.SetDecorationId(decorationPart, 0);
			}
			if (uiMotorDecorationComponent == null)
			{
				return;
			}
			uiMotorDecorationComponent.RemoveDecorationSkeletalObserver(decorationPart, null);
		}

		// Token: 0x06036AA0 RID: 223904 RVA: 0x00CF00B8 File Offset: 0x00CEE2B8
		[NullableContext(2)]
		public void AddDecoration(int decorationId, Action finishCallBack = null)
		{
			MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(decorationId);
			if (motorDecorationConfig == null)
			{
				return;
			}
			int partId = motorDecorationConfig.Value.PartId;
			int modelId = motorDecorationConfig.Value.ModelId;
			UiModelBase motorModel = this.GetMotorModel();
			if (motorModel == null)
			{
				return;
			}
			UiModelActorComponent uiModelActorComponent = motorModel.CheckGetComponent<UiModelActorComponent>();
			UiMotorDataComponent motorDataComponent = motorModel.CheckGetComponent<UiMotorDataComponent>();
			if (uiModelActorComponent == null || motorDataComponent == null)
			{
				return;
			}
			UiMotorDecorationComponent uiMotorDecorationComponent = motorModel.CheckGetComponent<UiMotorDecorationComponent>();
			if (uiMotorDecorationComponent == null)
			{
				return;
			}
			if (motorDataComponent.IsSameDecorationId(partId, decorationId))
			{
				UiDecorationLoadComponent uiDecorationLoadComponent = uiMotorDecorationComponent.GetDecorationHandle(partId, 0).Model.CheckGetComponent<UiDecorationLoadComponent>();
				uiDecorationLoadComponent.SetAttachActorComponent(uiModelActorComponent);
				uiDecorationLoadComponent.SetAttachSkinId(motorDataComponent.GetSkinId());
				uiDecorationLoadComponent.AttachToTarget();
				Action finishCallBack2 = finishCallBack;
				if (finishCallBack2 == null)
				{
					return;
				}
				finishCallBack2();
				return;
			}
			else
			{
				SkeletalObserverHandle decorationHandle = uiMotorDecorationComponent.GetDecorationHandle(partId, 0);
				if (decorationHandle == null)
				{
					uiMotorDecorationComponent.AddDecorationMesh(partId, decorationId);
					decorationHandle = uiMotorDecorationComponent.GetDecorationHandle(partId, 0);
				}
				if (decorationHandle == null)
				{
					return;
				}
				UiModelBase model = decorationHandle.Model;
				if (model == null)
				{
					return;
				}
				UiDecorationLoadComponent uiDecorationLoadComponent2 = model.CheckGetComponent<UiDecorationLoadComponent>();
				if (uiDecorationLoadComponent2 == null)
				{
					return;
				}
				uiDecorationLoadComponent2.SetAttachActorComponent(uiModelActorComponent);
				uiDecorationLoadComponent2.SetAttachSkinId(motorDataComponent.GetSkinId());
				uiDecorationLoadComponent2.LoadModelByModelId(modelId, 0, true, delegate
				{
					motorDataComponent.SetDecorationId(partId, decorationId);
					Action finishCallBack3 = finishCallBack;
					if (finishCallBack3 == null)
					{
						return;
					}
					finishCallBack3();
				}, null, false);
				if (!uiMotorDecorationComponent.IsMotorModelLoaded())
				{
					UiModelUtil.Instance.SetVisible(model, false);
				}
				return;
			}
		}

		// Token: 0x06036AA1 RID: 223905 RVA: 0x00CF0258 File Offset: 0x00CEE458
		[NullableContext(2)]
		public void RefreshRoleInMotor(int roleId, int skinId, string animPath = null)
		{
			SkeletalObserverHandle motorSkeletalHandle = UiSceneManager.Instance.GetMotorSkeletalHandle();
			if (motorSkeletalHandle == null)
			{
				return;
			}
			UiModelBase model = motorSkeletalHandle.Model;
			if (model == null)
			{
				return;
			}
			UiMotorRoleComponent uiMotorRoleComponent = model.CheckGetComponent<UiMotorRoleComponent>();
			UiMotorDataComponent uiMotorDataComponent = model.CheckGetComponent<UiMotorDataComponent>();
			if (uiMotorRoleComponent == null || uiMotorDataComponent == null)
			{
				return;
			}
			uiMotorDataComponent.SetRoleData(roleId, skinId, animPath);
			uiMotorRoleComponent.Refresh();
		}

		// Token: 0x170083AA RID: 33706
		// (get) Token: 0x06036AA2 RID: 223906 RVA: 0x00CF02A3 File Offset: 0x00CEE4A3
		public static MotorcycleUiModelUtil Instance
		{
			get
			{
				if (MotorcycleUiModelUtil._instance == null)
				{
					MotorcycleUiModelUtil._instance = new MotorcycleUiModelUtil();
					MotorcycleUiModelUtil._instance.OnInit();
				}
				return MotorcycleUiModelUtil._instance;
			}
		}

		// Token: 0x06036AA3 RID: 223907 RVA: 0x00CF02C6 File Offset: 0x00CEE4C6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036AA4 RID: 223908 RVA: 0x00CF02C8 File Offset: 0x00CEE4C8
		public static void ResetStaticDefaultValue()
		{
			MotorcycleUiModelUtil instance = MotorcycleUiModelUtil._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			MotorcycleUiModelUtil._instance = null;
		}

		// Token: 0x06036AA5 RID: 223909 RVA: 0x00CF02E1 File Offset: 0x00CEE4E1
		static MotorcycleUiModelUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleUiModelUtil.CreateStaticDefaultValue), new Action(MotorcycleUiModelUtil.ResetStaticDefaultValue));
		}

		// Token: 0x0401CE10 RID: 118288
		[Nullable(2)]
		private static MotorcycleUiModelUtil _instance;
	}
}
