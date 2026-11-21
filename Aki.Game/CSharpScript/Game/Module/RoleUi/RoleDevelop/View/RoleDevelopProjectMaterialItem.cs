using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003CFE RID: 15614
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectMaterialItem : GridProxyAbstract<RoleDevelopProjectMaterialItemData>
	{
		// Token: 0x06027F84 RID: 163716 RVA: 0x00B2E4AC File Offset: 0x00B2C6AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnMapClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnMapClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027F85 RID: 163717 RVA: 0x00B2E6C8 File Offset: 0x00B2C8C8
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectMaterialItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectMaterialItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027F86 RID: 163718 RVA: 0x00B2E70C File Offset: 0x00B2C90C
		protected override void OnStart()
		{
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Add(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChange));
			EventSystem.Instance.Add(EEventName.ResetNavigationListener, new Action(this.OnNavigationFocusChange));
		}

		// Token: 0x06027F87 RID: 163719 RVA: 0x00B2E770 File Offset: 0x00B2C970
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChange));
			EventSystem.Instance.Remove(EEventName.ResetNavigationListener, new Action(this.OnNavigationFocusChange));
		}

		// Token: 0x06027F88 RID: 163720 RVA: 0x00B2E7D1 File Offset: 0x00B2C9D1
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (this.ItemData == null || !base.IsUiActiveInHierarchy())
			{
				return;
			}
			this.RefreshMapButtonState();
		}

		// Token: 0x06027F89 RID: 163721 RVA: 0x00B2E7EB File Offset: 0x00B2C9EB
		private void OnNavigationFocusChange()
		{
			if (this.ItemData == null || !base.IsUiActiveInHierarchy())
			{
				return;
			}
			this.RefreshMapButtonState();
		}

		// Token: 0x06027F8A RID: 163722 RVA: 0x00B2E808 File Offset: 0x00B2CA08
		private bool IsNavigationFocusOnSelf()
		{
			AActor rootActor = base.GetRootActor();
			if (rootActor == null || !rootActor.IsValid())
			{
				return false;
			}
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			AActor aactor = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetOwner() : null;
			int num = 0;
			while (aactor != null && num < 16)
			{
				if (aactor == rootActor)
				{
					return true;
				}
				aactor = aactor.GetAttachParentActor();
				num++;
			}
			return false;
		}

		// Token: 0x06027F8B RID: 163723 RVA: 0x00B2E860 File Offset: 0x00B2CA60
		private bool RefreshMapButtonState()
		{
			bool flag = this.ShouldShowMapButton();
			UUIButtonComponent button = base.GetButton(10);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag && !Info.Instance.IsInGamepad());
				}
			}
			UUIButtonComponent button2 = base.GetButton(11);
			if (button2 != null)
			{
				UUIItem uuiitem2 = button2.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(flag && Info.Instance.IsInGamepad() && this.IsNavigationFocusOnSelf());
				}
			}
			return flag;
		}

		// Token: 0x06027F8C RID: 163724 RVA: 0x00B2E8EC File Offset: 0x00B2CAEC
		public override void Refresh(RoleDevelopProjectMaterialItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.RefreshContent();
		}

		// Token: 0x06027F8D RID: 163725 RVA: 0x00B2E8FC File Offset: 0x00B2CAFC
		private void RefreshContent()
		{
			RoleDevelopProjectMaterialItemData itemData = this.ItemData;
			RoleDevelopItemGroup groupItem = itemData.GroupItem;
			RoleDevTypeManage? typeManageConfig = RoleDevConfig.Instance.GetTypeManageConfig((int)groupItem.Type);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), typeManageConfig.Value.TypeDescribe, Array.Empty<object>());
			List<RoleDevelopNeedItem> data = RoleDevelopUtil.SortItemsByQuality(new List<RoleDevelopNeedItem>(groupItem.Items));
			this.MaterialItemLayout.RefreshByData(data, null, false);
			this.RefreshWeeklyMaterialText(itemData);
			bool flag = RoleDevelopUtil.CheckIsItemsHaveUnknownMaterial(groupItem.Items);
			bool flag2 = RoleDevelopUtil.CheckIsAllNeedItemsEnough(groupItem.Items);
			bool showMapButton = this.RefreshMapButtonState();
			base.GetItem(6).SetUIActive(flag2 && !flag);
			this.ButtonConfirm.SetUiActive(!flag);
			this.ButtonConfirm.SetLocalTextNew(this.GetConfirmButtonTextId(flag, showMapButton), Array.Empty<object>());
			this.ButtonConfirm.SetEnableClick(!flag);
			base.GetItem(5).SetUIActive(flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "RoleProject_Access_None", Array.Empty<object>());
			base.GetItem(8).SetUIActive(RoleDevelopModel.Instance.IsItemGroupCanBeSupplemented(groupItem));
			this.RefreshDoubleIcon();
		}

		// Token: 0x06027F8E RID: 163726 RVA: 0x00B2EA2E File Offset: 0x00B2CC2E
		private string GetConfirmButtonTextId(bool hasUnknownMaterial, bool showMapButton)
		{
			if (hasUnknownMaterial)
			{
				return "RoleProject_Access_None";
			}
			if (!showMapButton)
			{
				return "RoleProject_Button03";
			}
			return "NewSoundDetectDirectChallenge";
		}

		// Token: 0x06027F8F RID: 163727 RVA: 0x00B2EA48 File Offset: 0x00B2CC48
		private void RefreshWeeklyMaterialText(RoleDevelopProjectMaterialItemData data)
		{
			RoleDevelopItemGroup groupItem = data.GroupItem;
			RoleDevCulProjectConfig? roleDevCulProjectConfig;
			int? num = (RoleDevConfig.Instance.GetRoleDevStaticConfig() != null) ? new int?(roleDevCulProjectConfig.GetValueOrDefault().UnknownItemId) : null;
			bool flag = false;
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in groupItem.Items)
			{
				int itemId = roleDevelopNeedItem.ItemId;
				int? num2 = num;
				if (!(itemId == num2.GetValueOrDefault() & num2 != null))
				{
					RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(roleDevelopNeedItem.ItemId);
					if (itemJumpGroupConfig != null && itemJumpGroupConfig.GetValueOrDefault().ItemType == 5)
					{
						flag = true;
						break;
					}
				}
			}
			UUIText text = base.GetText(1);
			if (flag)
			{
				text.SetUIActive(true);
				int num3 = 1;
				ExchangeShared? exchangeShareConfig = ExchangeRewardConfig.Instance.GetExchangeShareConfig(new int?(num3));
				int exchangeRewardShareCount = ExchangeRewardModel.Instance.GetExchangeRewardShareCount(num3);
				int maxCount = exchangeShareConfig.Value.MaxCount;
				int value = maxCount - exchangeRewardShareCount;
				LguiUtil instance = LguiUtil.Instance;
				UUIText uiText = text;
				string textTableId = "ReceivedCount";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(maxCount);
				instance.SetLocalText(uiText, textTableId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x06027F90 RID: 163728 RVA: 0x00B2EBC8 File Offset: 0x00B2CDC8
		private void RefreshDoubleIcon()
		{
			RoleDevelopItemGroup groupItem = this.ItemData.GroupItem;
			if (groupItem.Items.TrueForAll((RoleDevelopNeedItem item) => RoleDevelopUtil.IsUnknownItem(item.ItemId)))
			{
				base.GetItem(9).SetUIActive(false);
				return;
			}
			List<EDungeonType> dungeonTypesByItemDetection = RoleDevelopUtil.GetDungeonTypesByItemDetection(groupItem.Items);
			bool uiactive = false;
			using (List<EDungeonType>.Enumerator enumerator = dungeonTypesByItemDetection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (RoleDevelopUtil.IsDungeonShowDouble(enumerator.Current))
					{
						uiactive = true;
						break;
					}
				}
			}
			base.GetItem(9).SetUIActive(uiactive);
		}

		// Token: 0x06027F91 RID: 163729 RVA: 0x00B2EC7C File Offset: 0x00B2CE7C
		public bool HasItem(int configId)
		{
			return this.ItemData != null && this.ItemData.GroupItem.Items.Exists((RoleDevelopNeedItem item) => item.ItemId == configId);
		}

		// Token: 0x06027F92 RID: 163730 RVA: 0x00B2ECC1 File Offset: 0x00B2CEC1
		public void RefreshSelf()
		{
			if (this.ItemData == null)
			{
				return;
			}
			this.RefreshContent();
		}

		// Token: 0x06027F93 RID: 163731 RVA: 0x00B2ECD2 File Offset: 0x00B2CED2
		private RoleDevelopProjectMaterialListItem CreateMaterialItem()
		{
			return new RoleDevelopProjectMaterialListItem();
		}

		// Token: 0x06027F94 RID: 163732 RVA: 0x00B2ECDC File Offset: 0x00B2CEDC
		private void OnClickJump(int value)
		{
			RoleDevelopProjectMaterialItemData itemData = this.ItemData;
			if (itemData == null)
			{
				return;
			}
			RoleDevelopItemGroup groupItem = itemData.GroupItem;
			itemData.JumpCallback(groupItem);
			if (itemData.LogRoleId != null && itemData.LogMainPage != null && itemData.LogSubPage != null)
			{
				ERoleDevelopLogItemState value2 = ERoleDevelopLogItemState.Normal;
				if (!RoleDevelopUtil.CheckIsAllNeedItemsEnough(groupItem.Items))
				{
					value2 = (RoleDevelopModel.Instance.IsItemGroupCanBeSupplemented(groupItem) ? ERoleDevelopLogItemState.CanComplement : ERoleDevelopLogItemState.NotComplement);
				}
				RoleController.Instance.LogRoleDevelopClick(itemData.LogRoleId.Value, itemData.LogMainPage.Value, itemData.LogSubPage.Value, new ERoleDevelopLogItemState?(value2));
			}
		}

		// Token: 0x06027F95 RID: 163733 RVA: 0x00B2ED9C File Offset: 0x00B2CF9C
		private bool IsDetectionMapJumpAvailable(int detectionType, int detectionId, out int markId)
		{
			markId = 0;
			EDetectionJumpType jumpType;
			bool isDetectionPreOpenByRecord;
			bool isLock;
			if (detectionType == 1)
			{
				DungeonDetectionRecord soundAreaDetectData = AdventureGuideModel.Instance.GetSoundAreaDetectData(detectionId);
				if (soundAreaDetectData == null)
				{
					return false;
				}
				InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(soundAreaDetectData.Conf.DungeonId);
				jumpType = (EDetectionJumpType)soundAreaDetectData.Conf.JumpType;
				markId = ((config != null) ? config.Value.MarkId : 0);
				isDetectionPreOpenByRecord = AdventureGuideModel.Instance.GetIsDetectionPreOpenByRecord(soundAreaDetectData);
				isLock = soundAreaDetectData.IsLock;
			}
			else
			{
				if (detectionType != 2)
				{
					return false;
				}
				SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(detectionId);
				if (silentAreaDetectData == null)
				{
					return false;
				}
				jumpType = (EDetectionJumpType)silentAreaDetectData.Conf.JumpType;
				markId = silentAreaDetectData.Conf.MarkId;
				isDetectionPreOpenByRecord = AdventureGuideModel.Instance.GetIsDetectionPreOpenByRecord(silentAreaDetectData);
				isLock = silentAreaDetectData.IsLock;
			}
			return (isDetectionPreOpenByRecord || !isLock) && jumpType != EDetectionJumpType.MapMark && (jumpType == EDetectionJumpType.DirectEntrance || (markId != 0 && MapModel.Instance.MapMarkIsCanTeleport(markId)) || isDetectionPreOpenByRecord);
		}

		// Token: 0x06027F96 RID: 163734 RVA: 0x00B2EE9C File Offset: 0x00B2D09C
		private Dictionary<EItemMaterialType, int> GetJumpPriorityMap(int roleId)
		{
			if (roleId <= 0 || RoleDevelopUtil.IsProspectRole(roleId))
			{
				return new Dictionary<EItemMaterialType, int>();
			}
			RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId);
			if (roleDevProjectConfig == null)
			{
				return new Dictionary<EItemMaterialType, int>();
			}
			List<IntArray> list = new List<IntArray>();
			int skillItemJumpTypeLength = roleDevProjectConfig.Value.SkillItemJumpTypeLength;
			for (int i = 0; i < skillItemJumpTypeLength; i++)
			{
				IntArray? intArray = roleDevProjectConfig.Value.SkillItemJumpType(i);
				if (intArray != null)
				{
					list.Add(intArray.Value);
				}
			}
			return RoleDevelopUtil.ConvertSkillItemJumpTypes(list);
		}

		// Token: 0x06027F97 RID: 163735 RVA: 0x00B2EF2C File Offset: 0x00B2D12C
		private bool ResolveMapJumpMarkId(out int markId)
		{
			markId = 0;
			RoleDevelopProjectMaterialItemData itemData = this.ItemData;
			RoleDevelopItemGroup roleDevelopItemGroup = (itemData != null) ? itemData.GroupItem : null;
			if (((roleDevelopItemGroup != null) ? roleDevelopItemGroup.Items : null) == null)
			{
				return false;
			}
			RoleDevelopProjectMaterialItemData itemData2 = this.ItemData;
			int roleId = ((itemData2 != null) ? itemData2.LogRoleId : null) ?? RoleDevelopModel.Instance.DevTargetRoleId;
			Dictionary<EItemMaterialType, int> jumpPriorityMap = this.GetJumpPriorityMap(roleId);
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in roleDevelopItemGroup.Items)
			{
				if (!RoleDevelopUtil.IsUnknownItem(roleDevelopNeedItem.ItemId))
				{
					RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(roleDevelopNeedItem.ItemId);
					if (itemJumpGroupConfig != null)
					{
						int itemType = itemJumpGroupConfig.Value.ItemType;
						int detectionType = itemJumpGroupConfig.Value.DetectionType;
						int detectionIDLength = itemJumpGroupConfig.Value.DetectionIDLength;
						if (detectionIDLength > 0)
						{
							EItemMaterialType key = (EItemMaterialType)itemType;
							int num = jumpPriorityMap.ContainsKey(key) ? jumpPriorityMap[key] : 0;
							if (num > 0 && num <= detectionIDLength && this.IsDetectionMapJumpAvailable(detectionType, itemJumpGroupConfig.Value.DetectionID(num - 1), out markId))
							{
								return true;
							}
							for (int i = 0; i < detectionIDLength; i++)
							{
								if (this.IsDetectionMapJumpAvailable(detectionType, itemJumpGroupConfig.Value.DetectionID(i), out markId))
								{
									return true;
								}
							}
						}
					}
				}
			}
			markId = 0;
			return false;
		}

		// Token: 0x06027F98 RID: 163736 RVA: 0x00B2F0E4 File Offset: 0x00B2D2E4
		private bool ShouldShowMapButton()
		{
			int num;
			return this.ResolveMapJumpMarkId(out num);
		}

		// Token: 0x06027F99 RID: 163737 RVA: 0x00B2F0FC File Offset: 0x00B2D2FC
		private void OnMapClick()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			int num;
			if (!this.ResolveMapJumpMarkId(out num) || num == 0)
			{
				Log.Instance.Error(ELogModule.AdventureGuide, ELogAuthor.LY, "点击地图跳转按钮但未找到对应地图标记", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			MapConfig instance = MapConfig.Instance;
			MapMark? mapMark = (instance != null) ? instance.GetConfigMark(num) : null;
			if (mapMark == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.AdventureGuide;
				ELogAuthor author = ELogAuthor.LY;
				string message = "地图标记配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId:", num);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(mapMark.Value.MarkId),
				MarkType = (EMarkType)mapMark.Value.ObjectType,
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x04015C56 RID: 89174
		private const int FocusSearchMaxDepth = 16;

		// Token: 0x04015C57 RID: 89175
		private RoleDevelopProjectMaterialItemData ItemData;

		// Token: 0x04015C58 RID: 89176
		private ButtonItem ButtonConfirm;

		// Token: 0x04015C59 RID: 89177
		private GenericLayout<RoleDevelopProjectMaterialListItem, RoleDevelopNeedItem> MaterialItemLayout;

		// Token: 0x020098BD RID: 39101
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FA12 RID: 195090
			TxtTitle,
			// Token: 0x0402FA13 RID: 195091
			TxtMatLimit,
			// Token: 0x0402FA14 RID: 195092
			HorizontalLayoutContent,
			// Token: 0x0402FA15 RID: 195093
			ItemBaseB,
			// Token: 0x0402FA16 RID: 195094
			ItemBtnConfirm,
			// Token: 0x0402FA17 RID: 195095
			ItemPanelNotObtained,
			// Token: 0x0402FA18 RID: 195096
			ItemFinishTag,
			// Token: 0x0402FA19 RID: 195097
			TextNoMaterial,
			// Token: 0x0402FA1A RID: 195098
			ItemSupplement,
			// Token: 0x0402FA1B RID: 195099
			ItemDouble,
			// Token: 0x0402FA1C RID: 195100
			BtnFunctionA2,
			// Token: 0x0402FA1D RID: 195101
			BtnCommon
		}
	}
}
