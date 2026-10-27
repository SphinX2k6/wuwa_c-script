using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleFavor
{
	// Token: 0x02004CFC RID: 19708
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleFavorInfoView : UiViewBase
	{
		// Token: 0x06032F12 RID: 208658 RVA: 0x00BDF9F9 File Offset: 0x00BDDBF9
		public RoleFavorInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06032F13 RID: 208659 RVA: 0x00BDFA2C File Offset: 0x00BDDC2C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose))
			};
		}

		// Token: 0x06032F14 RID: 208660 RVA: 0x00BDFBA0 File Offset: 0x00BDDDA0
		protected override UniTask OnBeforeStartAsync()
		{
			RoleFavorInfoView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleFavorInfoView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032F15 RID: 208661 RVA: 0x00BDFBE3 File Offset: 0x00BDDDE3
		protected override void OnBeforeShow()
		{
			base.GetItem(13).SetUIActive(true);
			if (this.SelectedContentData != null && this.SelectedContentData.FavorContentType == EFavorContentType.PreciousItem)
			{
				UiSceneManager.Instance.HideRoleSystemRoleActor();
			}
			this.RefreshView();
		}

		// Token: 0x06032F16 RID: 208662 RVA: 0x00BDFC19 File Offset: 0x00BDDE19
		protected override void OnAfterHide()
		{
			if (this.SelectedContentData != null && this.SelectedContentData.FavorContentType == EFavorContentType.PreciousItem)
			{
				UiSceneManager.Instance.ShowRoleSystemRoleActor();
			}
		}

		// Token: 0x06032F17 RID: 208663 RVA: 0x00BDFC3C File Offset: 0x00BDDE3C
		protected override void OnBeforeDestroy()
		{
			if (this.RoleFavorDescComponent != null)
			{
				this.RoleFavorDescComponent.Destroy(null);
				this.RoleFavorDescComponent = null;
			}
			if (this.RoleFavorBaseInfoComponent != null)
			{
				this.RoleFavorBaseInfoComponent.Destroy(null);
				this.RoleFavorBaseInfoComponent = null;
			}
			if (this.RoleFavorPowerInfoComponent != null)
			{
				this.RoleFavorPowerInfoComponent.Destroy(null);
				this.RoleFavorPowerInfoComponent = null;
			}
			if (this.RoleFavorPreciousItemComponent != null)
			{
				this.RoleFavorPreciousItemComponent.Destroy(null);
				this.RoleFavorPreciousItemComponent = null;
			}
			if (this.RoleFavorLockComponent != null)
			{
				this.RoleFavorLockComponent.Destroy(null);
				this.RoleFavorLockComponent = null;
			}
			this.ClearVerticalLayout();
			this.ClassifyDataList.Clear();
			this.SelectedContentData = null;
			AudioController.Instance.StopEvent(this.FavorInfoAudioResult, true, null);
		}

		// Token: 0x06032F18 RID: 208664 RVA: 0x00BDFD02 File Offset: 0x00BDDF02
		private void RefreshView()
		{
			this.UpdateClassifyTitle();
			this.HideAllItem();
			if (this.SelectedContentData != null)
			{
				this.ShowItemByData(this.SelectedContentData);
				return;
			}
			this.ShowDefaultItem();
		}

		// Token: 0x06032F19 RID: 208665 RVA: 0x00BDFD2C File Offset: 0x00BDDF2C
		private List<RoleFavorActionClassifyData> GetActionDataList()
		{
			List<RoleFavorActionClassifyData> list = new List<RoleFavorActionClassifyData>();
			int roleId = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetRoleId();
			IReadOnlyList<Motion> roleMotionByType = MotionConfig.Instance.GetRoleMotionByType(roleId, 1);
			IReadOnlyList<Motion> roleMotionByType2 = MotionConfig.Instance.GetRoleMotionByType(roleId, 2);
			if (roleMotionByType != null && roleMotionByType.Count > 0)
			{
				RoleFavorActionClassifyData item = ClassifyDataFactory.CreateClassifyData("FavorIdleAction", EFavorTabType.Action, roleId, EFavorActionType.IdleAction);
				list.Add(item);
			}
			if (roleMotionByType2 != null && roleMotionByType2.Count > 0)
			{
				RoleFavorActionClassifyData item2 = ClassifyDataFactory.CreateClassifyData("FavorFightAction", EFavorTabType.Action, roleId, EFavorActionType.FightAction);
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x06032F1A RID: 208666 RVA: 0x00BDFDB8 File Offset: 0x00BDDFB8
		private List<RoleFavorExperienceClassifyData> GetExperienceDataList()
		{
			List<RoleFavorExperienceClassifyData> list = new List<RoleFavorExperienceClassifyData>();
			int roleId = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetRoleId();
			RoleFavorExperienceClassifyData item = ClassifyDataFactory.CreateClassifyData("FavorRoleInfo", EFavorTabType.Experience, roleId, EFavorExperienceType.File);
			RoleFavorExperienceClassifyData item2 = ClassifyDataFactory.CreateClassifyData("FavorRoleStory", EFavorTabType.Experience, roleId, EFavorExperienceType.Story);
			list.Add(item);
			list.Add(item2);
			return list;
		}

		// Token: 0x06032F1B RID: 208667 RVA: 0x00BDFE0C File Offset: 0x00BDE00C
		private List<RoleFavorPreciousItemClassifyData> GetPreciousItemDataList()
		{
			List<RoleFavorPreciousItemClassifyData> list = new List<RoleFavorPreciousItemClassifyData>();
			int roleId = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetRoleId();
			RoleFavorPreciousItemClassifyData item = ClassifyDataFactory.CreateClassifyData("FavorPreciousItem", EFavorTabType.PreciousItem, roleId);
			list.Add(item);
			return list;
		}

		// Token: 0x06032F1C RID: 208668 RVA: 0x00BDFE48 File Offset: 0x00BDE048
		private List<RoleFavorVoiceClassifyData> GetVoiceDataList()
		{
			List<RoleFavorVoiceClassifyData> list = new List<RoleFavorVoiceClassifyData>();
			int roleId = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetRoleId();
			IReadOnlyList<FavorWord> favorWordConfig = RoleFavorConfig.Instance.GetFavorWordConfig(roleId, 1);
			IReadOnlyList<FavorWord> favorWordConfig2 = RoleFavorConfig.Instance.GetFavorWordConfig(roleId, 2);
			if (favorWordConfig != null && favorWordConfig.Count > 0)
			{
				RoleFavorVoiceClassifyData item = ClassifyDataFactory.CreateClassifyData("FavorNatureVoice", EFavorTabType.Voice, roleId, EFavorVoiceType.FavorNatureVoice);
				list.Add(item);
			}
			if (favorWordConfig2 != null && favorWordConfig2.Count > 0)
			{
				RoleFavorVoiceClassifyData item2 = ClassifyDataFactory.CreateClassifyData("FavorFightVoice", EFavorTabType.Voice, roleId, EFavorVoiceType.FavorFightVoice);
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x06032F1D RID: 208669 RVA: 0x00BDFED4 File Offset: 0x00BDE0D4
		protected EFavorItemStatus GetItemState(RoleFavorContentDataBase contentItemData)
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
			RoleFavorData favorData = roleInstanceById.GetFavorData();
			EFavorItemStatus result;
			if (contentItemData.FavorContentType == EFavorContentType.Action)
			{
				result = (EFavorItemStatus)MotionModel.Instance.GetRoleMotionState(roleInstanceById.GetRoleId(), contentItemData.ConfigId);
			}
			else
			{
				result = favorData.GetFavorItemState(contentItemData.ConfigId, contentItemData.FavorContentType);
			}
			return result;
		}

		// Token: 0x06032F1E RID: 208670 RVA: 0x00BDFF34 File Offset: 0x00BDE134
		private void UpdateClassifyTitle()
		{
			string textTableId = null;
			UUIText text = base.GetText(3);
			switch (this.SelectedContentData.FavorContentType)
			{
			case EFavorContentType.Voice:
				textTableId = "FavorVoice";
				break;
			case EFavorContentType.ExperienceFile:
			case EFavorContentType.ExperienceStory:
				textTableId = "FavorExperience";
				break;
			case EFavorContentType.Action:
				textTableId = "FavorAction";
				break;
			case EFavorContentType.PreciousItem:
				textTableId = "FavorPreciousItem";
				break;
			}
			LguiUtil.Instance.SetLocalText(text, textTableId, Array.Empty<object>());
		}

		// Token: 0x06032F1F RID: 208671 RVA: 0x00BDFFA4 File Offset: 0x00BDE1A4
		private void UpdateCvPanel(bool isShow)
		{
			if (isShow)
			{
				string curLanguageCvName = RoleFavorUtil.GetCurLanguageCvName(this.RoleId);
				UUIText text = base.GetText(11);
				UUIItem item = base.GetItem(12);
				if (curLanguageCvName == "")
				{
					if (item != null)
					{
						item.SetUIActive(false);
						return;
					}
				}
				else
				{
					if (item != null)
					{
						item.SetUIActive(true);
					}
					LguiUtil.Instance.SetLocalTextNew(text, curLanguageCvName, Array.Empty<object>());
				}
				return;
			}
			UUIItem item2 = base.GetItem(12);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06032F20 RID: 208672 RVA: 0x00BE001C File Offset: 0x00BDE21C
		protected void ShowDefaultItem()
		{
			int roleId = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetRoleId();
			FavorRoleInfo? favorRoleInfoConfig = RoleFavorConfig.Instance.GetFavorRoleInfoConfig(roleId);
			EFavorExperienceSubType favorExperienceSubType = EFavorExperienceSubType.RoleBaseInfo;
			RoleFavorRoleInfoContentData contentItemData = new RoleFavorRoleInfoContentData(this.RoleId, favorExperienceSubType, favorRoleInfoConfig.Value);
			this.ShowItemByData(contentItemData);
		}

		// Token: 0x06032F21 RID: 208673 RVA: 0x00BE0068 File Offset: 0x00BDE268
		protected void ShowItemByData(RoleFavorContentDataBase contentItemData)
		{
			this.HideAllItem();
			EFavorItemStatus itemState = this.GetItemState(contentItemData);
			if (contentItemData.FavorContentType != EFavorContentType.ExperienceFile && itemState != EFavorItemStatus.ItemUnLocked)
			{
				this.HandleLockItemData();
				return;
			}
			IContentHandler contentHandler;
			if (this.GetContentHandlersMap().TryGetValue(contentItemData.FavorContentType, out contentHandler))
			{
				contentHandler.ShowItem(contentItemData);
			}
		}

		// Token: 0x06032F22 RID: 208674 RVA: 0x00BE00B4 File Offset: 0x00BDE2B4
		protected void HandleLockItemData()
		{
			int configId = this.SelectedContentData.ConfigId;
			EFavorContentType favorContentType = this.SelectedContentData.FavorContentType;
			FavorItemType? favorItemType = null;
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
			RoleFavorData favorData = roleInstanceById.GetFavorData();
			if (favorContentType == EFavorContentType.Action)
			{
				if (this.LastSelectedRoleFavorContentItem != null)
				{
					this.ClearRoleMontage(this.LastSelectedRoleFavorContentItem);
				}
				EFavorItemStatus roleMotionState = (EFavorItemStatus)MotionModel.Instance.GetRoleMotionState(roleInstanceById.GetRoleId(), configId);
				if (roleMotionState == EFavorItemStatus.ItemCanUnLock)
				{
					MotionController.Instance.RequestUnlockMotion(roleInstanceById.GetRoleId(), configId);
					return;
				}
				if (roleMotionState == EFavorItemStatus.ItemLocked)
				{
					this.ShowLockItem();
				}
				return;
			}
			else
			{
				switch (favorContentType)
				{
				case EFavorContentType.Voice:
					favorItemType = new FavorItemType?(FavorItemType.Word);
					if (this.LastSelectedRoleFavorContentItem != null)
					{
						this.ClearAudio(this.LastSelectedRoleFavorContentItem);
					}
					break;
				case EFavorContentType.ExperienceStory:
					favorItemType = new FavorItemType?(FavorItemType.Story);
					break;
				case EFavorContentType.PreciousItem:
					favorItemType = new FavorItemType?(FavorItemType.Goods);
					break;
				}
				EFavorItemStatus favorItemState = favorData.GetFavorItemState(this.SelectedContentData.ConfigId, favorContentType);
				if (favorItemState == EFavorItemStatus.ItemCanUnLock)
				{
					RoleController.Instance.SendRoleFavorUnLockRequest(favorItemType.Value, roleInstanceById.GetRoleId(), configId);
					return;
				}
				if (favorItemState == EFavorItemStatus.ItemLocked)
				{
					this.ShowLockItem();
				}
				return;
			}
		}

		// Token: 0x06032F23 RID: 208675 RVA: 0x00BE01D0 File Offset: 0x00BDE3D0
		private void ShowActionItem(RoleFavorActionContentData contentData)
		{
			this.UpdateCvPanel(false);
			this.RoleFavorDescComponent.SetData(contentData, true);
		}

		// Token: 0x06032F24 RID: 208676 RVA: 0x00BE01E8 File Offset: 0x00BDE3E8
		private void ShowRoleInfoItem(RoleFavorRoleInfoContentData contentData)
		{
			this.UpdateCvPanel(true);
			EFavorExperienceSubType favorExperienceSubType = contentData.FavorExperienceSubType;
			if (favorExperienceSubType == EFavorExperienceSubType.RoleBaseInfo)
			{
				this.RoleFavorBaseInfoComponent.SetData(contentData, true);
				return;
			}
			if (favorExperienceSubType == EFavorExperienceSubType.RolePowerFile)
			{
				this.RoleFavorPowerInfoComponent.SetData(contentData, true);
			}
		}

		// Token: 0x06032F25 RID: 208677 RVA: 0x00BE0226 File Offset: 0x00BDE426
		private void ShowRoleStoryItem(RoleFavorStoryContentData contentData)
		{
			this.RoleFavorDescComponent.SetData(contentData, true);
		}

		// Token: 0x06032F26 RID: 208678 RVA: 0x00BE0235 File Offset: 0x00BDE435
		private void ShowPreciousItem(RoleFavorPreciousItemContentData contentData)
		{
			this.UpdateCvPanel(false);
			this.RoleFavorDescComponent.SetData(contentData, true);
			this.RoleFavorPreciousItemComponent.SetData(contentData, true);
			this.RoleFavorPreciousItemComponent.SetLockState(false);
		}

		// Token: 0x06032F27 RID: 208679 RVA: 0x00BE0264 File Offset: 0x00BDE464
		private void ShowVoiceItem(RoleFavorVoiceContentData contentData)
		{
			this.UpdateCvPanel(true);
			this.RoleFavorDescComponent.SetData(contentData, true);
		}

		// Token: 0x06032F28 RID: 208680 RVA: 0x00BE027C File Offset: 0x00BDE47C
		protected void ShowLockItem()
		{
			this.HideAllItem();
			this.RoleFavorLockComponent.SetData(this.SelectedContentData, true);
			RoleFavorContentDataBase selectedContentData = this.SelectedContentData;
			if (selectedContentData != null && selectedContentData.FavorContentType == EFavorContentType.PreciousItem)
			{
				RoleFavorPreciousItemContentData contentData = this.SelectedContentData as RoleFavorPreciousItemContentData;
				this.RoleFavorPreciousItemComponent.SetData(contentData, true);
				this.RoleFavorPreciousItemComponent.SetLockState(true);
			}
		}

		// Token: 0x06032F29 RID: 208681 RVA: 0x00BE02DD File Offset: 0x00BDE4DD
		private void HideAllItem()
		{
			this.RoleFavorLockComponent.SetComponentActive(false);
			this.RoleFavorDescComponent.SetComponentActive(false);
			this.RoleFavorBaseInfoComponent.SetComponentActive(false);
			this.RoleFavorPowerInfoComponent.SetComponentActive(false);
			this.RoleFavorPreciousItemComponent.SetComponentActive(false);
		}

		// Token: 0x06032F2A RID: 208682 RVA: 0x00BE031C File Offset: 0x00BDE51C
		private void ResetAllRoleFavorContentItemToggle()
		{
			int count = this.RoleFavorContentItemList.Count;
			for (int i = 0; i < count; i++)
			{
				RoleFavorContentItem roleFavorContentItem = this.RoleFavorContentItemList[i];
				RoleFavorContentDataBase contentData = roleFavorContentItem.ContentData;
				int num = (contentData != null) ? contentData.InstanceId : -1;
				if (this.SelectedContentData.InstanceId == num)
				{
					roleFavorContentItem.SetToggleState(EToggleState.ETT_Checked);
					roleFavorContentItem.SetButtonActive(true);
					this.CurSelectedRoleFavorContentItem = roleFavorContentItem;
				}
				else
				{
					roleFavorContentItem.SetToggleState(EToggleState.ETT_UnChecked);
					roleFavorContentItem.SetButtonActive(false);
				}
			}
		}

		// Token: 0x06032F2B RID: 208683 RVA: 0x00BE0394 File Offset: 0x00BDE594
		protected void ClearVerticalLayout()
		{
			if (this.ClassifyVerticalLayout != null)
			{
				this.ClassifyVerticalLayout.ClearChildren();
			}
		}

		// Token: 0x06032F2C RID: 208684 RVA: 0x00BE03AC File Offset: 0x00BDE5AC
		private void PlayVoice(RoleFavorVoiceContentData contentData, RoleFavorContentItem roleFavorContentItem)
		{
			if (roleFavorContentItem.GetCurVoiceState() == EFavorPlayerStatus.Play)
			{
				this.ClearAudio(roleFavorContentItem);
				return;
			}
			if (this.LastSelectedRoleFavorContentItem != null && this.LastSelectedRoleFavorContentItem.GetCurVoiceState() == EFavorPlayerStatus.Play)
			{
				this.ClearAudio(this.LastSelectedRoleFavorContentItem);
			}
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.MASTERVOLUMEFUNCTION, true, true);
			int? currentValue2 = GameSettingsManager.Instance.GetCurrentValue(EFunction.VOICEVOLUMEFUNCTION, true, true);
			if (currentValue != null)
			{
				int? num = currentValue;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null) && currentValue2 != null)
				{
					num = currentValue2;
					num2 = 0;
					if (!(num.GetValueOrDefault() == num2 & num != null))
					{
						FavorWord configData = contentData.ConfigData;
						TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
						RoleController.Instance.SetRoleMorphType(roleSystemRoleActor, (EUiModelMorphType)configData.Morph);
						this.PlayVoiceByConfig(roleFavorContentItem, configData);
						return;
					}
				}
			}
			ScrollingTipsController.Instance.ShowTipsById("FavorVolume", Array.Empty<object>());
		}

		// Token: 0x06032F2D RID: 208685 RVA: 0x00BE0490 File Offset: 0x00BDE690
		private void PlayVoiceByConfig(RoleFavorContentItem roleFavorContentItem, FavorWord config)
		{
			RoleFavorInfoView.<>c__DisplayClass44_0 CS$<>8__locals1 = new RoleFavorInfoView.<>c__DisplayClass44_0();
			CS$<>8__locals1.roleFavorContentItem = roleFavorContentItem;
			this.VoicePath = config.Voice;
			if (this.VoicePath == "")
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Role;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "配置的语音路径为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("this.VoicePath", this.VoicePath);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			CS$<>8__locals1.voicePath = this.VoicePath;
			CS$<>8__locals1.audioResult = this.FavorInfoAudioResult;
			CS$<>8__locals1.playFlag = this.PlayFlag;
			AudioController.Instance.LoadAndAddCallback(this.VoicePath, new Action(CS$<>8__locals1.<PlayVoiceByConfig>g__loadedCallback|0), this.FavorInfoAudioResult);
		}

		// Token: 0x06032F2E RID: 208686 RVA: 0x00BE053C File Offset: 0x00BDE73C
		private void PlayRoleMontage(RoleFavorActionContentData contentData, RoleFavorContentItem roleFavorContentItem)
		{
			Motion configData = contentData.ConfigData;
			if (roleFavorContentItem.GetCurVoiceState() == EFavorPlayerStatus.Play)
			{
				this.ClearRoleMontage(roleFavorContentItem);
				return;
			}
			if (this.LastSelectedRoleFavorContentItem != null && this.LastSelectedRoleFavorContentItem.GetCurVoiceState() == EFavorPlayerStatus.Play)
			{
				this.ClearRoleMontage(this.LastSelectedRoleFavorContentItem);
			}
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			RoleController.Instance.SetRoleMorphType(roleSystemRoleActor, (EUiModelMorphType)configData.Morph);
			this.PlayRoleMontageByConfig(roleFavorContentItem, configData);
		}

		// Token: 0x06032F2F RID: 208687 RVA: 0x00BE05A8 File Offset: 0x00BDE7A8
		private void PlayRoleMontageByConfig(RoleFavorContentItem roleFavorContentItem, Motion config)
		{
			ResourceSystem.Instance.LoadAsync<UAnimMontage>(config.AniMontage, delegate([Nullable(2)] UAnimMontage montageObject, string _)
			{
				if (montageObject == null || !montageObject.IsValid())
				{
					return;
				}
				TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
				if (roleSystemRoleActor == null)
				{
					return;
				}
				UiModelBase model = roleSystemRoleActor.Model;
				UiModelUtil.Instance.SetVisible(model, true);
				UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
				USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
				if (uskeletalMeshComponent == null)
				{
					return;
				}
				roleFavorContentItem.StartPlay();
				ABP_PerformanceRole_C animInstanceFromSkeletalMesh = uiModelActorComponent.GetAnimInstanceFromSkeletalMesh(uskeletalMeshComponent);
				if (animInstanceFromSkeletalMesh == null || !animInstanceFromSkeletalMesh.IsValid())
				{
					return;
				}
				animInstanceFromSkeletalMesh.TryForceEnterLoop();
				animInstanceFromSkeletalMesh.Montage_Play(montageObject, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
				animInstanceFromSkeletalMesh.OnMontageEnded.Add(roleFavorContentItem.OnMontageCompleted);
			}, 100, this.MemoryTag);
		}

		// Token: 0x06032F30 RID: 208688 RVA: 0x00BE05E8 File Offset: 0x00BDE7E8
		protected void ClearAudio(RoleFavorContentItem roleFavorContentItem)
		{
			AudioController.Instance.StopEvent(this.FavorInfoAudioResult, true, null);
			roleFavorContentItem.EndPlay();
		}

		// Token: 0x06032F31 RID: 208689 RVA: 0x00BE0618 File Offset: 0x00BDE818
		protected void ClearRoleMontage(RoleFavorContentItem roleFavorContentItem)
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			if (roleSystemRoleActor == null)
			{
				return;
			}
			UiModelBase model = roleSystemRoleActor.Model;
			UiModelUtil.Instance.SetVisible(model, true);
			UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
			USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
			if (uskeletalMeshComponent == null)
			{
				return;
			}
			UAnimInstance linkedAnimGraphInstanceByTag = uskeletalMeshComponent.GetAnimInstance().GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE);
			linkedAnimGraphInstanceByTag.StopSlotAnimation(0.25f, default(FName));
			if (roleFavorContentItem.OnMontageCompleted != null)
			{
				linkedAnimGraphInstanceByTag.OnMontageEnded.Remove(roleFavorContentItem.OnMontageCompleted);
			}
			roleFavorContentItem.EndPlay();
		}

		// Token: 0x06032F32 RID: 208690 RVA: 0x00BE06AC File Offset: 0x00BDE8AC
		private void InitClassifyItemDataList()
		{
			switch (this.FavorTabType)
			{
			case EFavorTabType.Voice:
				this.ClassifyDataList = this.ConvertClassifyDataList<RoleFavorVoiceClassifyData>(this.GetVoiceDataList());
				return;
			case EFavorTabType.Experience:
				this.ClassifyDataList = this.ConvertClassifyDataList<RoleFavorExperienceClassifyData>(this.GetExperienceDataList());
				return;
			case EFavorTabType.Action:
				this.ClassifyDataList = this.ConvertClassifyDataList<RoleFavorActionClassifyData>(this.GetActionDataList());
				return;
			case EFavorTabType.PreciousItem:
				this.ClassifyDataList = this.ConvertClassifyDataList<RoleFavorPreciousItemClassifyData>(this.GetPreciousItemDataList());
				return;
			default:
				return;
			}
		}

		// Token: 0x06032F33 RID: 208691 RVA: 0x00BE0724 File Offset: 0x00BDE924
		private List<RoleFavorClassifyDataBase> ConvertClassifyDataList<[Nullable(0)] T>(List<T> source) where T : RoleFavorClassifyDataBase
		{
			List<RoleFavorClassifyDataBase> list = new List<RoleFavorClassifyDataBase>(source.Count);
			for (int i = 0; i < source.Count; i++)
			{
				list.Add(source[i]);
			}
			return list;
		}

		// Token: 0x06032F34 RID: 208692 RVA: 0x00BE0764 File Offset: 0x00BDE964
		private void InitRoleFavorContentItemList()
		{
			foreach (RoleFavorClassifyItem roleFavorClassifyItem in this.ClassifyVerticalLayout.GetLayoutItemList())
			{
				foreach (RoleFavorContentItem roleFavorContentItem in roleFavorClassifyItem.GetContentItemList())
				{
					roleFavorContentItem.BindToggleFunction(new TRoleFavorContentItemToggleFunction(this.ContentItemToggleFunction));
					roleFavorContentItem.BindButtonFunction(new TRoleFavorContentItemButtonFunction(this.ContentItemButtonFunction));
					this.RoleFavorContentItemList.Add(roleFavorContentItem);
				}
			}
		}

		// Token: 0x06032F35 RID: 208693 RVA: 0x00BE0818 File Offset: 0x00BDEA18
		private void ContentItemToggleFunction(bool isSelect, RoleFavorContentDataBase contentItemData, RoleFavorContentItem roleFavorContentItem)
		{
			if (isSelect)
			{
				this.HideAllItem();
				this.SelectedContentData = contentItemData;
				this.LastSelectedRoleFavorContentItem = this.CurSelectedRoleFavorContentItem;
				this.ResetAllRoleFavorContentItemToggle();
				this.OnContentItemToggleClick(roleFavorContentItem, this.SelectedContentData);
			}
		}

		// Token: 0x06032F36 RID: 208694 RVA: 0x00BE084C File Offset: 0x00BDEA4C
		protected void OnContentItemToggleClick(RoleFavorContentItem roleFavorContentItem, RoleFavorContentDataBase contentItemData)
		{
			EFavorItemStatus itemState = this.GetItemState(contentItemData);
			if (contentItemData.FavorContentType != EFavorContentType.ExperienceFile && itemState != EFavorItemStatus.ItemUnLocked)
			{
				this.HandleLockItemData();
				return;
			}
			IContentHandler contentHandler;
			if (this.GetContentHandlersMap().TryGetValue(contentItemData.FavorContentType, out contentHandler))
			{
				contentHandler.ShowItem(contentItemData);
				if (new Action<RoleFavorContentDataBase, RoleFavorContentItem>(contentHandler.PlayContent) != null)
				{
					contentHandler.PlayContent(contentItemData, roleFavorContentItem);
				}
			}
		}

		// Token: 0x06032F37 RID: 208695 RVA: 0x00BE08A8 File Offset: 0x00BDEAA8
		private void ContentItemButtonFunction(RoleFavorContentDataBase contentItemData, RoleFavorContentItem roleFavorContentItem)
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
			RoleFavorData favorData = roleInstanceById.GetFavorData();
			EFavorItemStatus efavorItemStatus;
			if (contentItemData.FavorContentType == EFavorContentType.Action)
			{
				efavorItemStatus = (EFavorItemStatus)MotionModel.Instance.GetRoleMotionState(roleInstanceById.GetRoleId(), contentItemData.ConfigId);
			}
			else
			{
				efavorItemStatus = favorData.GetFavorItemState(contentItemData.ConfigId, contentItemData.FavorContentType);
			}
			if (contentItemData.FavorContentType != EFavorContentType.ExperienceFile && efavorItemStatus != EFavorItemStatus.ItemUnLocked)
			{
				return;
			}
			IContentHandler contentHandler;
			if (this.GetContentHandlersMap().TryGetValue(contentItemData.FavorContentType, out contentHandler) && new Action<RoleFavorContentDataBase, RoleFavorContentItem>(contentHandler.PlayContent) != null)
			{
				contentHandler.PlayContent(contentItemData, roleFavorContentItem);
			}
		}

		// Token: 0x06032F38 RID: 208696 RVA: 0x00BE093E File Offset: 0x00BDEB3E
		private RoleFavorClassifyItem CreateClassifyItem()
		{
			return new RoleFavorClassifyItem();
		}

		// Token: 0x06032F39 RID: 208697 RVA: 0x00BE0945 File Offset: 0x00BDEB45
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.UnLockRoleFavorItem, new Action<int, int>(this.RoleFavorUnlock));
			EventSystem.Instance.Add<UiCameraAnimationDefine.IFinishData>(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraAnimationDefine.IFinishData>(this.OnCameraFinish));
		}

		// Token: 0x06032F3A RID: 208698 RVA: 0x00BE097F File Offset: 0x00BDEB7F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UnLockRoleFavorItem, new Action<int, int>(this.RoleFavorUnlock));
			EventSystem.Instance.Remove(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraAnimationDefine.IFinishData>(this.OnCameraFinish));
		}

		// Token: 0x06032F3B RID: 208699 RVA: 0x00BE09BC File Offset: 0x00BDEBBC
		private void RoleFavorUnlock(int roleId, int unlockId)
		{
			if (roleId != this.RoleId)
			{
				return;
			}
			foreach (RoleFavorContentItem roleFavorContentItem in this.RoleFavorContentItemList)
			{
				if (roleFavorContentItem.ContentData.ConfigId == unlockId)
				{
					roleFavorContentItem.RefreshContentItem();
					this.ContentItemToggleFunction(true, roleFavorContentItem.ContentData, roleFavorContentItem);
				}
			}
			GenericPromptController.Instance.ShowPromptByCode("30001", Array.Empty<object>());
		}

		// Token: 0x06032F3C RID: 208700 RVA: 0x00BE0A48 File Offset: 0x00BDEC48
		private void OnCameraFinish(UiCameraAnimationDefine.IFinishData finishData)
		{
			if (finishData.ToHandleData.ViewName != EUiViewName.RoleFavorInfoView)
			{
				return;
			}
			base.GetItem(13).SetUIActive(false);
		}

		// Token: 0x06032F3D RID: 208701 RVA: 0x00BE0A78 File Offset: 0x00BDEC78
		private void OnClickClose()
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			if (roleSystemRoleActor != null)
			{
				RoleController.Instance.SetRoleMorphType(roleSystemRoleActor, EUiModelMorphType.默认形态);
			}
			base.CloseMe(null);
		}

		// Token: 0x06032F3E RID: 208702 RVA: 0x00BE0AA6 File Offset: 0x00BDECA6
		protected override void OnHandleLoadScene()
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			object obj;
			if (roleSystemRoleActor == null)
			{
				obj = null;
			}
			else
			{
				UiModelBase model = roleSystemRoleActor.Model;
				obj = ((model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				return;
			}
			obj2.SetTransformByTag("RoleCase");
		}

		// Token: 0x06032F3F RID: 208703 RVA: 0x00BE0ADC File Offset: 0x00BDECDC
		private Dictionary<EFavorContentType, IContentHandler> GetContentHandlersMap()
		{
			if (this.ContentHandlersMap == null)
			{
				this.ContentHandlersMap = new Dictionary<EFavorContentType, IContentHandler>
				{
					{
						EFavorContentType.Action,
						ContentHandlerFactory.CreateContentHandler<RoleFavorActionContentData>(new Action<RoleFavorActionContentData>(this.ShowActionItem), new Action<RoleFavorActionContentData, RoleFavorContentItem>(this.PlayRoleMontage))
					},
					{
						EFavorContentType.ExperienceFile,
						ContentHandlerFactory.CreateContentHandler<RoleFavorRoleInfoContentData>(new Action<RoleFavorRoleInfoContentData>(this.ShowRoleInfoItem), null)
					},
					{
						EFavorContentType.ExperienceStory,
						ContentHandlerFactory.CreateContentHandler<RoleFavorStoryContentData>(new Action<RoleFavorStoryContentData>(this.ShowRoleStoryItem), null)
					},
					{
						EFavorContentType.PreciousItem,
						ContentHandlerFactory.CreateContentHandler<RoleFavorPreciousItemContentData>(new Action<RoleFavorPreciousItemContentData>(this.ShowPreciousItem), null)
					},
					{
						EFavorContentType.Voice,
						ContentHandlerFactory.CreateContentHandler<RoleFavorVoiceContentData>(new Action<RoleFavorVoiceContentData>(this.ShowVoiceItem), new Action<RoleFavorVoiceContentData, RoleFavorContentItem>(this.PlayVoice))
					}
				};
			}
			return this.ContentHandlersMap;
		}

		// Token: 0x0401B191 RID: 110993
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoleFavorClassifyItem, RoleFavorClassifyDataBase> ClassifyVerticalLayout;

		// Token: 0x0401B192 RID: 110994
		private List<RoleFavorClassifyDataBase> ClassifyDataList = new List<RoleFavorClassifyDataBase>();

		// Token: 0x0401B193 RID: 110995
		private readonly List<RoleFavorContentItem> RoleFavorContentItemList = new List<RoleFavorContentItem>();

		// Token: 0x0401B194 RID: 110996
		[Nullable(2)]
		private RoleFavorContentDataBase SelectedContentData;

		// Token: 0x0401B195 RID: 110997
		[Nullable(2)]
		private RoleFavorContentItem CurSelectedRoleFavorContentItem;

		// Token: 0x0401B196 RID: 110998
		[Nullable(2)]
		private RoleFavorContentItem LastSelectedRoleFavorContentItem;

		// Token: 0x0401B197 RID: 110999
		[Nullable(2)]
		private string VoicePath;

		// Token: 0x0401B198 RID: 111000
		private readonly int PlayFlag = 1;

		// Token: 0x0401B199 RID: 111001
		[Nullable(2)]
		private RoleFavorDescComponent RoleFavorDescComponent;

		// Token: 0x0401B19A RID: 111002
		[Nullable(2)]
		private RoleFavorBaseInfoComponent RoleFavorBaseInfoComponent;

		// Token: 0x0401B19B RID: 111003
		[Nullable(2)]
		private RoleFavorPowerInfoComponent RoleFavorPowerInfoComponent;

		// Token: 0x0401B19C RID: 111004
		[Nullable(2)]
		private RoleFavorPreciousItemComponent RoleFavorPreciousItemComponent;

		// Token: 0x0401B19D RID: 111005
		[Nullable(2)]
		private RoleFavorLockComponent RoleFavorLockComponent;

		// Token: 0x0401B19E RID: 111006
		private readonly PlayResult FavorInfoAudioResult = new PlayResult();

		// Token: 0x0401B19F RID: 111007
		private int RoleId;

		// Token: 0x0401B1A0 RID: 111008
		private EFavorTabType FavorTabType;

		// Token: 0x0401B1A1 RID: 111009
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EFavorContentType, IContentHandler> ContentHandlersMap;

		// Token: 0x0200AE8A RID: 44682
		[NullableContext(0)]
		private enum ERoleFavorInfoViewDefine
		{
			// Token: 0x04034FFC RID: 217084
			CloseButton,
			// Token: 0x04034FFD RID: 217085
			ClassifyVerticalLayout,
			// Token: 0x04034FFE RID: 217086
			ClassifyIcon,
			// Token: 0x04034FFF RID: 217087
			ClassifyText,
			// Token: 0x04035000 RID: 217088
			NameText,
			// Token: 0x04035001 RID: 217089
			LockItem,
			// Token: 0x04035002 RID: 217090
			DescItem,
			// Token: 0x04035003 RID: 217091
			BaseInfoItem,
			// Token: 0x04035004 RID: 217092
			PowerInfoItem,
			// Token: 0x04035005 RID: 217093
			PreciousItem,
			// Token: 0x04035006 RID: 217094
			DragItem,
			// Token: 0x04035007 RID: 217095
			CVNameText,
			// Token: 0x04035008 RID: 217096
			CVPanel,
			// Token: 0x04035009 RID: 217097
			MaskPanel
		}
	}
}
