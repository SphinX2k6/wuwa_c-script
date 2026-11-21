using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleFavor
{
	// Token: 0x02003CAE RID: 15534
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleFavorInfoView : UiViewBase
	{
		// Token: 0x06027CED RID: 163053 RVA: 0x00B25301 File Offset: 0x00B23501
		public RoleFavorInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06027CEE RID: 163054 RVA: 0x00B25334 File Offset: 0x00B23534
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

		// Token: 0x06027CEF RID: 163055 RVA: 0x00B254A8 File Offset: 0x00B236A8
		protected override UniTask OnBeforeStartAsync()
		{
			RoleFavorInfoView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleFavorInfoView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027CF0 RID: 163056 RVA: 0x00B254EB File Offset: 0x00B236EB
		protected override void OnBeforeShow()
		{
			base.GetItem(13).SetUIActive(true);
			if (this.SelectedContentData != null && this.SelectedContentData.FavorContentType == EFavorContentType.PreciousItem)
			{
				UiSceneManager.Instance.HideRoleSystemRoleActor();
			}
			this.RefreshView();
		}

		// Token: 0x06027CF1 RID: 163057 RVA: 0x00B25521 File Offset: 0x00B23721
		protected override void OnAfterHide()
		{
			if (this.SelectedContentData != null && this.SelectedContentData.FavorContentType == EFavorContentType.PreciousItem)
			{
				UiSceneManager.Instance.ShowRoleSystemRoleActor();
			}
		}

		// Token: 0x06027CF2 RID: 163058 RVA: 0x00B25544 File Offset: 0x00B23744
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

		// Token: 0x06027CF3 RID: 163059 RVA: 0x00B2560A File Offset: 0x00B2380A
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

		// Token: 0x06027CF4 RID: 163060 RVA: 0x00B25634 File Offset: 0x00B23834
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

		// Token: 0x06027CF5 RID: 163061 RVA: 0x00B256C0 File Offset: 0x00B238C0
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

		// Token: 0x06027CF6 RID: 163062 RVA: 0x00B25714 File Offset: 0x00B23914
		private List<RoleFavorPreciousItemClassifyData> GetPreciousItemDataList()
		{
			List<RoleFavorPreciousItemClassifyData> list = new List<RoleFavorPreciousItemClassifyData>();
			int roleId = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetRoleId();
			RoleFavorPreciousItemClassifyData item = ClassifyDataFactory.CreateClassifyData("FavorPreciousItem", EFavorTabType.PreciousItem, roleId);
			list.Add(item);
			return list;
		}

		// Token: 0x06027CF7 RID: 163063 RVA: 0x00B25750 File Offset: 0x00B23950
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

		// Token: 0x06027CF8 RID: 163064 RVA: 0x00B257DC File Offset: 0x00B239DC
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

		// Token: 0x06027CF9 RID: 163065 RVA: 0x00B2583C File Offset: 0x00B23A3C
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

		// Token: 0x06027CFA RID: 163066 RVA: 0x00B258AC File Offset: 0x00B23AAC
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

		// Token: 0x06027CFB RID: 163067 RVA: 0x00B25924 File Offset: 0x00B23B24
		protected void ShowDefaultItem()
		{
			int roleId = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetRoleId();
			FavorRoleInfo? favorRoleInfoConfig = RoleFavorConfig.Instance.GetFavorRoleInfoConfig(roleId);
			EFavorExperienceSubType favorExperienceSubType = EFavorExperienceSubType.RoleBaseInfo;
			RoleFavorRoleInfoContentData contentItemData = new RoleFavorRoleInfoContentData(this.RoleId, favorExperienceSubType, favorRoleInfoConfig.Value);
			this.ShowItemByData(contentItemData);
		}

		// Token: 0x06027CFC RID: 163068 RVA: 0x00B25970 File Offset: 0x00B23B70
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

		// Token: 0x06027CFD RID: 163069 RVA: 0x00B259BC File Offset: 0x00B23BBC
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

		// Token: 0x06027CFE RID: 163070 RVA: 0x00B25AD8 File Offset: 0x00B23CD8
		private void ShowActionItem(RoleFavorActionContentData contentData)
		{
			this.UpdateCvPanel(false);
			this.RoleFavorDescComponent.SetData(contentData, true);
		}

		// Token: 0x06027CFF RID: 163071 RVA: 0x00B25AF0 File Offset: 0x00B23CF0
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

		// Token: 0x06027D00 RID: 163072 RVA: 0x00B25B2E File Offset: 0x00B23D2E
		private void ShowRoleStoryItem(RoleFavorStoryContentData contentData)
		{
			this.RoleFavorDescComponent.SetData(contentData, true);
		}

		// Token: 0x06027D01 RID: 163073 RVA: 0x00B25B3D File Offset: 0x00B23D3D
		private void ShowPreciousItem(RoleFavorPreciousItemContentData contentData)
		{
			this.UpdateCvPanel(false);
			this.RoleFavorDescComponent.SetData(contentData, true);
			this.RoleFavorPreciousItemComponent.SetData(contentData, true);
			this.RoleFavorPreciousItemComponent.SetLockState(false);
		}

		// Token: 0x06027D02 RID: 163074 RVA: 0x00B25B6C File Offset: 0x00B23D6C
		private void ShowVoiceItem(RoleFavorVoiceContentData contentData)
		{
			this.UpdateCvPanel(true);
			this.RoleFavorDescComponent.SetData(contentData, true);
		}

		// Token: 0x06027D03 RID: 163075 RVA: 0x00B25B84 File Offset: 0x00B23D84
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

		// Token: 0x06027D04 RID: 163076 RVA: 0x00B25BE5 File Offset: 0x00B23DE5
		private void HideAllItem()
		{
			this.RoleFavorLockComponent.SetComponentActive(false);
			this.RoleFavorDescComponent.SetComponentActive(false);
			this.RoleFavorBaseInfoComponent.SetComponentActive(false);
			this.RoleFavorPowerInfoComponent.SetComponentActive(false);
			this.RoleFavorPreciousItemComponent.SetComponentActive(false);
		}

		// Token: 0x06027D05 RID: 163077 RVA: 0x00B25C24 File Offset: 0x00B23E24
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

		// Token: 0x06027D06 RID: 163078 RVA: 0x00B25C9C File Offset: 0x00B23E9C
		protected void ClearVerticalLayout()
		{
			if (this.ClassifyVerticalLayout != null)
			{
				this.ClassifyVerticalLayout.ClearChildren();
			}
		}

		// Token: 0x06027D07 RID: 163079 RVA: 0x00B25CB4 File Offset: 0x00B23EB4
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

		// Token: 0x06027D08 RID: 163080 RVA: 0x00B25D98 File Offset: 0x00B23F98
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

		// Token: 0x06027D09 RID: 163081 RVA: 0x00B25E44 File Offset: 0x00B24044
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

		// Token: 0x06027D0A RID: 163082 RVA: 0x00B25EB0 File Offset: 0x00B240B0
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

		// Token: 0x06027D0B RID: 163083 RVA: 0x00B25EF0 File Offset: 0x00B240F0
		protected void ClearAudio(RoleFavorContentItem roleFavorContentItem)
		{
			AudioController.Instance.StopEvent(this.FavorInfoAudioResult, true, null);
			roleFavorContentItem.EndPlay();
		}

		// Token: 0x06027D0C RID: 163084 RVA: 0x00B25F20 File Offset: 0x00B24120
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

		// Token: 0x06027D0D RID: 163085 RVA: 0x00B25FB4 File Offset: 0x00B241B4
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

		// Token: 0x06027D0E RID: 163086 RVA: 0x00B2602C File Offset: 0x00B2422C
		private List<RoleFavorClassifyDataBase> ConvertClassifyDataList<[Nullable(0)] T>(List<T> source) where T : RoleFavorClassifyDataBase
		{
			List<RoleFavorClassifyDataBase> list = new List<RoleFavorClassifyDataBase>(source.Count);
			for (int i = 0; i < source.Count; i++)
			{
				list.Add(source[i]);
			}
			return list;
		}

		// Token: 0x06027D0F RID: 163087 RVA: 0x00B2606C File Offset: 0x00B2426C
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

		// Token: 0x06027D10 RID: 163088 RVA: 0x00B26120 File Offset: 0x00B24320
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

		// Token: 0x06027D11 RID: 163089 RVA: 0x00B26154 File Offset: 0x00B24354
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

		// Token: 0x06027D12 RID: 163090 RVA: 0x00B261B0 File Offset: 0x00B243B0
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

		// Token: 0x06027D13 RID: 163091 RVA: 0x00B26246 File Offset: 0x00B24446
		private RoleFavorClassifyItem CreateClassifyItem()
		{
			return new RoleFavorClassifyItem();
		}

		// Token: 0x06027D14 RID: 163092 RVA: 0x00B2624D File Offset: 0x00B2444D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.UnLockRoleFavorItem, new Action<int, int>(this.RoleFavorUnlock));
			EventSystem.Instance.Add<UiCameraDefine.IFinishData>(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraDefine.IFinishData>(this.OnCameraFinish));
		}

		// Token: 0x06027D15 RID: 163093 RVA: 0x00B26287 File Offset: 0x00B24487
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UnLockRoleFavorItem, new Action<int, int>(this.RoleFavorUnlock));
			EventSystem.Instance.Remove(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraDefine.IFinishData>(this.OnCameraFinish));
		}

		// Token: 0x06027D16 RID: 163094 RVA: 0x00B262C4 File Offset: 0x00B244C4
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

		// Token: 0x06027D17 RID: 163095 RVA: 0x00B26350 File Offset: 0x00B24550
		private void OnCameraFinish(UiCameraDefine.IFinishData finishData)
		{
			if (finishData.ToHandleData.GetViewName() != EUiViewName.RoleFavorInfoView)
			{
				return;
			}
			base.GetItem(13).SetUIActive(false);
		}

		// Token: 0x06027D18 RID: 163096 RVA: 0x00B26380 File Offset: 0x00B24580
		private void OnClickClose()
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			if (roleSystemRoleActor != null)
			{
				RoleController.Instance.SetRoleMorphType(roleSystemRoleActor, EUiModelMorphType.默认形态);
			}
			base.CloseMe(null);
		}

		// Token: 0x06027D19 RID: 163097 RVA: 0x00B263AE File Offset: 0x00B245AE
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

		// Token: 0x06027D1A RID: 163098 RVA: 0x00B263E4 File Offset: 0x00B245E4
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

		// Token: 0x04015B16 RID: 88854
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoleFavorClassifyItem, RoleFavorClassifyDataBase> ClassifyVerticalLayout;

		// Token: 0x04015B17 RID: 88855
		private List<RoleFavorClassifyDataBase> ClassifyDataList = new List<RoleFavorClassifyDataBase>();

		// Token: 0x04015B18 RID: 88856
		private readonly List<RoleFavorContentItem> RoleFavorContentItemList = new List<RoleFavorContentItem>();

		// Token: 0x04015B19 RID: 88857
		[Nullable(2)]
		private RoleFavorContentDataBase SelectedContentData;

		// Token: 0x04015B1A RID: 88858
		[Nullable(2)]
		private RoleFavorContentItem CurSelectedRoleFavorContentItem;

		// Token: 0x04015B1B RID: 88859
		[Nullable(2)]
		private RoleFavorContentItem LastSelectedRoleFavorContentItem;

		// Token: 0x04015B1C RID: 88860
		[Nullable(2)]
		private string VoicePath;

		// Token: 0x04015B1D RID: 88861
		private readonly int PlayFlag = 1;

		// Token: 0x04015B1E RID: 88862
		[Nullable(2)]
		private RoleFavorDescComponent RoleFavorDescComponent;

		// Token: 0x04015B1F RID: 88863
		[Nullable(2)]
		private RoleFavorBaseInfoComponent RoleFavorBaseInfoComponent;

		// Token: 0x04015B20 RID: 88864
		[Nullable(2)]
		private RoleFavorPowerInfoComponent RoleFavorPowerInfoComponent;

		// Token: 0x04015B21 RID: 88865
		[Nullable(2)]
		private RoleFavorPreciousItemComponent RoleFavorPreciousItemComponent;

		// Token: 0x04015B22 RID: 88866
		[Nullable(2)]
		private RoleFavorLockComponent RoleFavorLockComponent;

		// Token: 0x04015B23 RID: 88867
		private readonly PlayResult FavorInfoAudioResult = new PlayResult();

		// Token: 0x04015B24 RID: 88868
		private int RoleId;

		// Token: 0x04015B25 RID: 88869
		private EFavorTabType FavorTabType;

		// Token: 0x04015B26 RID: 88870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EFavorContentType, IContentHandler> ContentHandlersMap;

		// Token: 0x020098A8 RID: 39080
		[NullableContext(0)]
		private enum ERoleFavorInfoViewDefine
		{
			// Token: 0x0402F9A4 RID: 194980
			CloseButton,
			// Token: 0x0402F9A5 RID: 194981
			ClassifyVerticalLayout,
			// Token: 0x0402F9A6 RID: 194982
			ClassifyIcon,
			// Token: 0x0402F9A7 RID: 194983
			ClassifyText,
			// Token: 0x0402F9A8 RID: 194984
			NameText,
			// Token: 0x0402F9A9 RID: 194985
			LockItem,
			// Token: 0x0402F9AA RID: 194986
			DescItem,
			// Token: 0x0402F9AB RID: 194987
			BaseInfoItem,
			// Token: 0x0402F9AC RID: 194988
			PowerInfoItem,
			// Token: 0x0402F9AD RID: 194989
			PreciousItem,
			// Token: 0x0402F9AE RID: 194990
			DragItem,
			// Token: 0x0402F9AF RID: 194991
			CVNameText,
			// Token: 0x0402F9B0 RID: 194992
			CVPanel,
			// Token: 0x0402F9B1 RID: 194993
			MaskPanel
		}
	}
}
