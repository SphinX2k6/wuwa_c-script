using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Motorcycle.Model
{
	// Token: 0x02004377 RID: 17271
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleUiModelUtil : Singleton
	{
		// Token: 0x0602B9CD RID: 178637 RVA: 0x00C3E90E File Offset: 0x00C3CB0E
		public void CreateMotor(EUiModelUseWay useWay = EUiModelUseWay.MotorInMotorView)
		{
			UiSceneManager.Instance.InitMotorSkeletalHandle(useWay);
		}

		// Token: 0x0602B9CE RID: 178638 RVA: 0x00C3E91B File Offset: 0x00C3CB1B
		public void DestroyMotor()
		{
			UiSceneManager.Instance.DestroyMotorSkeletalHandle();
		}

		// Token: 0x0602B9CF RID: 178639 RVA: 0x00C3E928 File Offset: 0x00C3CB28
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

		// Token: 0x0602B9D0 RID: 178640 RVA: 0x00C3E950 File Offset: 0x00C3CB50
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

		// Token: 0x0602B9D1 RID: 178641 RVA: 0x00C3E968 File Offset: 0x00C3CB68
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

		// Token: 0x0602B9D2 RID: 178642 RVA: 0x00C3E99C File Offset: 0x00C3CB9C
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

		// Token: 0x0602B9D3 RID: 178643 RVA: 0x00C3E9D0 File Offset: 0x00C3CBD0
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

		// Token: 0x0602B9D4 RID: 178644 RVA: 0x00C3EA22 File Offset: 0x00C3CC22
		public bool IsMotorCreated()
		{
			return this.GetMotorModel() != null;
		}

		// Token: 0x0602B9D5 RID: 178645 RVA: 0x00C3EA30 File Offset: 0x00C3CC30
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

		// Token: 0x0602B9D6 RID: 178646 RVA: 0x00C3EA78 File Offset: 0x00C3CC78
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

		// Token: 0x0602B9D7 RID: 178647 RVA: 0x00C3EAA4 File Offset: 0x00C3CCA4
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

		// Token: 0x0602B9D8 RID: 178648 RVA: 0x00C3EAD0 File Offset: 0x00C3CCD0
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

		// Token: 0x0602B9D9 RID: 178649 RVA: 0x00C3EAFC File Offset: 0x00C3CCFC
		public void LoadEquippedMotor([Nullable(new byte[]
		{
			2,
			1
		})] Action<UiModelBase> afterLoadCallBack = null)
		{
			MotorcycleUiModelParam motorEquipParam = this.GetMotorEquipParam();
			this.LoadMotorByParam(motorEquipParam, afterLoadCallBack);
		}

		// Token: 0x0602B9DA RID: 178650 RVA: 0x00C3EB18 File Offset: 0x00C3CD18
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

		// Token: 0x0602B9DB RID: 178651 RVA: 0x00C3EB54 File Offset: 0x00C3CD54
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

		// Token: 0x0602B9DC RID: 178652 RVA: 0x00C3EBA4 File Offset: 0x00C3CDA4
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

		// Token: 0x0602B9DD RID: 178653 RVA: 0x00C3EC2C File Offset: 0x00C3CE2C
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

		// Token: 0x0602B9DE RID: 178654 RVA: 0x00C3ECA4 File Offset: 0x00C3CEA4
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

		// Token: 0x0602B9DF RID: 178655 RVA: 0x00C3EF8C File Offset: 0x00C3D18C
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

		// Token: 0x0602B9E0 RID: 178656 RVA: 0x00C3EFBC File Offset: 0x00C3D1BC
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

		// Token: 0x0602B9E1 RID: 178657 RVA: 0x00C3EFEC File Offset: 0x00C3D1EC
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

		// Token: 0x0602B9E2 RID: 178658 RVA: 0x00C3F034 File Offset: 0x00C3D234
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

		// Token: 0x0602B9E3 RID: 178659 RVA: 0x00C3F084 File Offset: 0x00C3D284
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

		// Token: 0x0602B9E4 RID: 178660 RVA: 0x00C3F0D0 File Offset: 0x00C3D2D0
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

		// Token: 0x0602B9E5 RID: 178661 RVA: 0x00C3F11C File Offset: 0x00C3D31C
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

		// Token: 0x0602B9E6 RID: 178662 RVA: 0x00C3F160 File Offset: 0x00C3D360
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

		// Token: 0x0602B9E7 RID: 178663 RVA: 0x00C3F300 File Offset: 0x00C3D500
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

		// Token: 0x17005776 RID: 22390
		// (get) Token: 0x0602B9E8 RID: 178664 RVA: 0x00C3F34B File Offset: 0x00C3D54B
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

		// Token: 0x0602B9E9 RID: 178665 RVA: 0x00C3F36E File Offset: 0x00C3D56E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B9EA RID: 178666 RVA: 0x00C3F370 File Offset: 0x00C3D570
		public static void ResetStaticDefaultValue()
		{
			MotorcycleUiModelUtil instance = MotorcycleUiModelUtil._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			MotorcycleUiModelUtil._instance = null;
		}

		// Token: 0x0602B9EB RID: 178667 RVA: 0x00C3F389 File Offset: 0x00C3D589
		static MotorcycleUiModelUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleUiModelUtil.CreateStaticDefaultValue), new Action(MotorcycleUiModelUtil.ResetStaticDefaultValue));
		}

		// Token: 0x040178A8 RID: 96424
		[Nullable(2)]
		private static MotorcycleUiModelUtil _instance;
	}
}
