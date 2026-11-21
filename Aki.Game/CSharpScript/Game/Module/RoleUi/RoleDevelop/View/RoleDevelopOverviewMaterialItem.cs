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
	// Token: 0x02003CF9 RID: 15609
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopOverviewMaterialItem : GridProxyAbstract<RoleDevelopOverviewMaterialItemData>
	{
		// Token: 0x06027F39 RID: 163641 RVA: 0x00B2CAD0 File Offset: 0x00B2ACD0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
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
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickJumpMap));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickJumpMap));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027F3A RID: 163642 RVA: 0x00B2CCC8 File Offset: 0x00B2AEC8
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopOverviewMaterialItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopOverviewMaterialItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027F3B RID: 163643 RVA: 0x00B2CD0C File Offset: 0x00B2AF0C
		protected override void OnStart()
		{
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Add(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChange));
			EventSystem.Instance.Add(EEventName.ResetNavigationListener, new Action(this.OnNavigationFocusChange));
		}

		// Token: 0x06027F3C RID: 163644 RVA: 0x00B2CD70 File Offset: 0x00B2AF70
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChange));
			EventSystem.Instance.Remove(EEventName.ResetNavigationListener, new Action(this.OnNavigationFocusChange));
		}

		// Token: 0x06027F3D RID: 163645 RVA: 0x00B2CDD1 File Offset: 0x00B2AFD1
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (this.ItemData == null || !base.IsUiActiveInHierarchy())
			{
				return;
			}
			this.RefreshMapButtonState();
		}

		// Token: 0x06027F3E RID: 163646 RVA: 0x00B2CDEB File Offset: 0x00B2AFEB
		private void OnNavigationFocusChange()
		{
			if (this.ItemData == null || !base.IsUiActiveInHierarchy())
			{
				return;
			}
			this.RefreshMapButtonState();
		}

		// Token: 0x06027F3F RID: 163647 RVA: 0x00B2CE08 File Offset: 0x00B2B008
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

		// Token: 0x06027F40 RID: 163648 RVA: 0x00B2CE60 File Offset: 0x00B2B060
		private bool RefreshMapButtonState()
		{
			bool flag = this.ShouldShowMapButton();
			UUIButtonComponent button = base.GetButton(9);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag && !Info.Instance.IsInGamepad());
				}
			}
			UUIButtonComponent button2 = base.GetButton(10);
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

		// Token: 0x06027F41 RID: 163649 RVA: 0x00B2CEEC File Offset: 0x00B2B0EC
		public override void Refresh(RoleDevelopOverviewMaterialItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.RefreshContent();
		}

		// Token: 0x06027F42 RID: 163650 RVA: 0x00B2CEFC File Offset: 0x00B2B0FC
		private void RefreshContent()
		{
			RoleDevelopOverviewMaterialItemData itemData = this.ItemData;
			RoleDevelopItemGroup groupItem = itemData.GroupItem;
			RoleDevTypeManage? typeManageConfig = RoleDevConfig.Instance.GetTypeManageConfig((int)groupItem.Type);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), typeManageConfig.Value.TypeDescribe, Array.Empty<object>());
			List<RoleDevelopNeedItem> data = RoleDevelopUtil.SortItemsByQuality(new List<RoleDevelopNeedItem>(groupItem.Items));
			this.MaterialItemLayout.RefreshByData(data, null, false);
			this.RefreshWeeklyMaterialText(itemData);
			bool flag = RoleDevelopUtil.CheckIsItemsHaveUnknownMaterial(groupItem.Items);
			bool showMapButton = this.RefreshMapButtonState();
			this.ButtonConfirm.SetUiActive(!flag);
			this.ButtonConfirm.SetLocalTextNew(this.GetConfirmButtonTextId(flag, showMapButton), Array.Empty<object>());
			this.ButtonConfirm.SetEnableClick(!flag);
			base.GetItem(7).SetUIActive(flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "RoleProject_Access_None", Array.Empty<object>());
			base.GetItem(6).SetUIActive(RoleDevelopModel.Instance.IsItemGroupCanBeSupplemented(groupItem));
			this.RefreshDoubleIcon();
		}

		// Token: 0x06027F43 RID: 163651 RVA: 0x00B2D009 File Offset: 0x00B2B209
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

		// Token: 0x06027F44 RID: 163652 RVA: 0x00B2D024 File Offset: 0x00B2B224
		private void RefreshWeeklyMaterialText(RoleDevelopOverviewMaterialItemData data)
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

		// Token: 0x06027F45 RID: 163653 RVA: 0x00B2D1A4 File Offset: 0x00B2B3A4
		private void RefreshDoubleIcon()
		{
			RoleDevelopItemGroup groupItem = this.ItemData.GroupItem;
			if (groupItem.Items.TrueForAll((RoleDevelopNeedItem item) => RoleDevelopUtil.IsUnknownItem(item.ItemId)))
			{
				base.GetItem(5).SetUIActive(false);
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
			base.GetItem(5).SetUIActive(uiactive);
		}

		// Token: 0x06027F46 RID: 163654 RVA: 0x00B2D254 File Offset: 0x00B2B454
		public bool HasItem(int configId)
		{
			return this.ItemData != null && this.ItemData.GroupItem.Items.Exists((RoleDevelopNeedItem item) => item.ItemId == configId);
		}

		// Token: 0x06027F47 RID: 163655 RVA: 0x00B2D299 File Offset: 0x00B2B499
		public void RefreshSelf()
		{
			if (this.ItemData == null)
			{
				return;
			}
			this.RefreshContent();
		}

		// Token: 0x06027F48 RID: 163656 RVA: 0x00B2D2AA File Offset: 0x00B2B4AA
		private RoleDevelopProjectMaterialListItem CreateMaterialItem()
		{
			return new RoleDevelopProjectMaterialListItem();
		}

		// Token: 0x06027F49 RID: 163657 RVA: 0x00B2D2B4 File Offset: 0x00B2B4B4
		private void OnClickJump(int value)
		{
			RoleDevelopOverviewMaterialItemData itemData = this.ItemData;
			if (itemData == null)
			{
				return;
			}
			RoleDevelopItemGroup groupItem = itemData.GroupItem;
			itemData.JumpCallback(groupItem);
		}

		// Token: 0x06027F4A RID: 163658 RVA: 0x00B2D2E0 File Offset: 0x00B2B4E0
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

		// Token: 0x06027F4B RID: 163659 RVA: 0x00B2D3E0 File Offset: 0x00B2B5E0
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

		// Token: 0x06027F4C RID: 163660 RVA: 0x00B2D470 File Offset: 0x00B2B670
		private bool ResolveMapJumpMarkId(out int markId)
		{
			markId = 0;
			RoleDevelopOverviewMaterialItemData itemData = this.ItemData;
			RoleDevelopItemGroup roleDevelopItemGroup = (itemData != null) ? itemData.GroupItem : null;
			if (((roleDevelopItemGroup != null) ? roleDevelopItemGroup.Items : null) == null)
			{
				return false;
			}
			Dictionary<EItemMaterialType, int> jumpPriorityMap = this.GetJumpPriorityMap(RoleDevelopModel.Instance.DevTargetRoleId);
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

		// Token: 0x06027F4D RID: 163661 RVA: 0x00B2D5F4 File Offset: 0x00B2B7F4
		private bool ShouldShowMapButton()
		{
			int num;
			return this.ResolveMapJumpMarkId(out num);
		}

		// Token: 0x06027F4E RID: 163662 RVA: 0x00B2D60C File Offset: 0x00B2B80C
		private void OnClickJumpMap()
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

		// Token: 0x04015C45 RID: 89157
		private const int FocusSearchMaxDepth = 16;

		// Token: 0x04015C46 RID: 89158
		private RoleDevelopOverviewMaterialItemData ItemData;

		// Token: 0x04015C47 RID: 89159
		private ButtonItem ButtonConfirm;

		// Token: 0x04015C48 RID: 89160
		private GenericLayout<RoleDevelopProjectMaterialListItem, RoleDevelopNeedItem> MaterialItemLayout;

		// Token: 0x020098B6 RID: 39094
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402F9E9 RID: 195049
			TxtTitle,
			// Token: 0x0402F9EA RID: 195050
			TxtMatLimit,
			// Token: 0x0402F9EB RID: 195051
			HorizontalLayoutContent,
			// Token: 0x0402F9EC RID: 195052
			ItemBaseB,
			// Token: 0x0402F9ED RID: 195053
			ItemBtnConfirm,
			// Token: 0x0402F9EE RID: 195054
			ItemDouble,
			// Token: 0x0402F9EF RID: 195055
			ItemSupplement,
			// Token: 0x0402F9F0 RID: 195056
			ItemPanelNotObtained,
			// Token: 0x0402F9F1 RID: 195057
			TxtNotObtained,
			// Token: 0x0402F9F2 RID: 195058
			BtnFunctionA2,
			// Token: 0x0402F9F3 RID: 195059
			BtnCommon
		}
	}
}
