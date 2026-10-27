using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EB0 RID: 7856
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryRoleTipItem : UiPanelBase
{
	// Token: 0x0600F19F RID: 61855 RVA: 0x003A2520 File Offset: 0x003A0720
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(16, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIMultiTemplateLayout)),
			new ValueTuple<int, Type>(19, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickedArrowButton)),
			new ValueTuple<int, Delegate>(15, new Action<EToggleState>(this.OnClickedButton))
		};
	}

	// Token: 0x0600F1A0 RID: 61856 RVA: 0x003A2738 File Offset: 0x003A0938
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryRoleTipItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryRoleTipItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1A1 RID: 61857 RVA: 0x003A277C File Offset: 0x003A097C
	protected override void OnStart()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(1),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.HonamiStory
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		bool tipsOpen = HonamiStoryModel.Instance.GetBackpackLogic().GetTipsOpen();
		UUIExtendToggle extendToggle = base.GetExtendToggle(15);
		if (extendToggle != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(tipsOpen);
		}
		EventSystem.Instance.Add<bool>(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
	}

	// Token: 0x0600F1A2 RID: 61858 RVA: 0x003A2815 File Offset: 0x003A0A15
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
	}

	// Token: 0x0600F1A3 RID: 61859 RVA: 0x003A2833 File Offset: 0x003A0A33
	private HonamiStoryWeaponSuitInfoItem CreateSuitItem()
	{
		return new HonamiStoryWeaponSuitInfoItem();
	}

	// Token: 0x0600F1A4 RID: 61860 RVA: 0x003A283A File Offset: 0x003A0A3A
	private HonamiStoryTipsTextItem CreateSkill()
	{
		return new HonamiStoryTipsTextItem();
	}

	// Token: 0x0600F1A5 RID: 61861 RVA: 0x003A2841 File Offset: 0x003A0A41
	private HonamiStoryTipsPropertyItem CreateProperty()
	{
		return new HonamiStoryTipsPropertyItem();
	}

	// Token: 0x0600F1A6 RID: 61862 RVA: 0x003A2848 File Offset: 0x003A0A48
	private HonamiStoryWeaponTagItem CreateTagItem()
	{
		return new HonamiStoryWeaponTagItem();
	}

	// Token: 0x0600F1A7 RID: 61863 RVA: 0x003A2850 File Offset: 0x003A0A50
	public void Refresh(HonamiStoryRoleEquipData equipData)
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(16);
		FVector2D fvector2D = new FVector2D(0f, 0f);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.ScrollToTop(ref fvector2D, base.GetItem(0), true);
		}
		this.EquipData = equipData;
		this.RefreshItemTipsOpen();
		this.RefreshWeaponTips();
		this.RefreshPluginTips();
		this.ShowTips(true);
	}

	// Token: 0x0600F1A8 RID: 61864 RVA: 0x003A28AC File Offset: 0x003A0AAC
	public void RefreshItemTipsOpen()
	{
		if (!base.IsUiActiveInHierarchy())
		{
			return;
		}
		bool tipsOpen = HonamiStoryModel.Instance.GetBackpackLogic().GetTipsOpen();
		UUIExtendToggle extendToggle = base.GetExtendToggle(15);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.RootUIComp.Get().SetUIActive(tipsOpen);
	}

	// Token: 0x0600F1A9 RID: 61865 RVA: 0x003A28F4 File Offset: 0x003A0AF4
	private void RefreshWeaponTips()
	{
		if (this.EquipData == null)
		{
			return;
		}
		int weaponId = this.EquipData.GetWeaponId();
		bool flag = weaponId != 0;
		if (flag)
		{
			HonamiStoryWeaponData weaponData = HonamiStoryModel.Instance.GetWeaponData(weaponId);
			bool skillDescMode = HonamiStoryModel.Instance.GetSkillDescMode();
			string textStringId = skillDescMode ? weaponData.DescSimple : weaponData.Desc;
			List<string> list = skillDescMode ? weaponData.DescSimpleArgs : weaponData.DescArgs;
			if (list != null && list.Count > 0)
			{
				object[] array = new object[list.Count];
				for (int i = 0; i < list.Count; i++)
				{
					array[i] = list[i];
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, array);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
			}
			List<int> suitId = weaponData.SuitId;
			List<IHonamiStoryWeaponSuitData> list2 = new List<IHonamiStoryWeaponSuitData>();
			foreach (int suitId2 in suitId)
			{
				list2.Add(new HonamiStoryWeaponSuitData
				{
					SuitId = suitId2,
					EquipData = this.EquipData
				});
			}
			GenericLayout<HonamiStoryWeaponSuitInfoItem, IHonamiStoryWeaponSuitData> suitVerticalLayout = this.SuitVerticalLayout;
			if (suitVerticalLayout != null)
			{
				suitVerticalLayout.RefreshByData(list2, null, false);
			}
			GenericLayout<HonamiStoryWeaponTagItem, int> tagLayout = this.TagLayout;
			if (tagLayout != null)
			{
				tagLayout.RefreshByData(weaponData.PluginTags, null, false);
			}
		}
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		UUIItem item3 = base.GetItem(12);
		if (item3 != null)
		{
			item3.SetUIActive(!flag);
		}
		UUIItem item4 = base.GetItem(17);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(flag);
	}

	// Token: 0x0600F1AA RID: 61866 RVA: 0x003A2AB0 File Offset: 0x003A0CB0
	private void RefreshPluginTips()
	{
		List<HonamiStoryEquipItemData> list = (this.EquipData != null) ? this.EquipData.GetPluginList() : new List<HonamiStoryEquipItemData>();
		bool flag = false;
		if (list != null && list.Count > 0)
		{
			using (List<HonamiStoryEquipItemData>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current != null)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (flag)
		{
			Dictionary<int, IHonamiStoryTipsBuffInfo> dictionary = new Dictionary<int, IHonamiStoryTipsBuffInfo>();
			Dictionary<int, IHonamiStoryTipsPropertyData> dictionary2 = new Dictionary<int, IHonamiStoryTipsPropertyData>();
			Dictionary<int, int> dictionary3 = new Dictionary<int, int>();
			foreach (HonamiStoryEquipItemData honamiStoryEquipItemData in list)
			{
				if (honamiStoryEquipItemData != null)
				{
					foreach (IHonamiStoryTipsBuffInfo honamiStoryTipsBuffInfo in honamiStoryEquipItemData.GetBuffTempIdList(false))
					{
						if (honamiStoryTipsBuffInfo.RoleId == null || HonamiStoryUtil.CheckRolePowerValid(honamiStoryTipsBuffInfo.RoleId.Value, this.EquipData.GetParentRoleId()))
						{
							dictionary[honamiStoryTipsBuffInfo.BuffId] = honamiStoryTipsBuffInfo;
						}
					}
					foreach (int num in honamiStoryEquipItemData.GetMainPropList())
					{
						HonamiStoryProp? honamiStoryProp = HonamiStoryConfig.Instance.GetHonamiStoryProp(num);
						if (honamiStoryProp != null)
						{
							int propId = honamiStoryProp.Value.PropId;
							if (!dictionary3.ContainsKey(propId))
							{
								dictionary3[propId] = num;
							}
							int num2 = dictionary3[propId];
							if (!dictionary2.ContainsKey(num2))
							{
								dictionary2[num2] = new HonamiStoryTipsPropertyData
								{
									PropId = num2,
									PropertyNumber = new int?(honamiStoryProp.Value.StandardProperty)
								};
							}
							else
							{
								IHonamiStoryTipsPropertyData honamiStoryTipsPropertyData2;
								IHonamiStoryTipsPropertyData honamiStoryTipsPropertyData = honamiStoryTipsPropertyData2 = dictionary2[num2];
								int? propertyNumber = honamiStoryTipsPropertyData2.PropertyNumber;
								int value = propertyNumber.GetValueOrDefault();
								if (propertyNumber == null)
								{
									value = 0;
									honamiStoryTipsPropertyData2.PropertyNumber = new int?(value);
								}
								honamiStoryTipsPropertyData.PropertyNumber = new int?(honamiStoryTipsPropertyData.PropertyNumber.Value + honamiStoryProp.Value.StandardProperty);
							}
						}
					}
				}
			}
			List<IHonamiStoryTipsBuffInfo> data = new List<IHonamiStoryTipsBuffInfo>(dictionary.Values);
			GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> skillLayout = this.SkillLayout;
			if (skillLayout != null)
			{
				skillLayout.RefreshByData(data, null, false);
			}
			GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData> propertyLayout = this.PropertyLayout;
			if (propertyLayout != null)
			{
				propertyLayout.RefreshByData(new List<IHonamiStoryTipsPropertyData>(dictionary2.Values), null, false);
			}
		}
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		UUIItem item3 = base.GetItem(13);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(!flag);
	}

	// Token: 0x0600F1AB RID: 61867 RVA: 0x003A2DC0 File Offset: 0x003A0FC0
	public void RegisterCloseCallback(Action callback)
	{
		this.CloseCallback = callback;
	}

	// Token: 0x0600F1AC RID: 61868 RVA: 0x003A2DCC File Offset: 0x003A0FCC
	public void ShowTips(bool isShow)
	{
		this.SetActive(isShow);
		if (this.LevelSequencePlayer.IsPlayingSequence("In"))
		{
			this.LevelSequencePlayer.StopSequenceByKey("In", false, false);
		}
		if (!isShow)
		{
			return;
		}
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("In", false, null);
	}

	// Token: 0x0600F1AD RID: 61869 RVA: 0x003A2E24 File Offset: 0x003A1024
	private void OnClickedButton(EToggleState toggleState)
	{
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		if (backpackLogic != null)
		{
			backpackLogic.CloseTips();
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(15);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600F1AE RID: 61870 RVA: 0x003A2E66 File Offset: 0x003A1066
	private void OnClickedArrowButton()
	{
		Action closeCallback = this.CloseCallback;
		if (closeCallback != null)
		{
			closeCallback();
		}
		this.ShowTips(false);
	}

	// Token: 0x0600F1AF RID: 61871 RVA: 0x003A2E80 File Offset: 0x003A1080
	private void OnSkillDescModeChange(bool _)
	{
		this.RefreshWeaponTips();
		this.RefreshPluginTips();
	}

	// Token: 0x0600F1B0 RID: 61872 RVA: 0x003A2E90 File Offset: 0x003A1090
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "SuitDesc"))
		{
			return null;
		}
		int index = int.Parse(configParams[1]);
		UUIItem itemByIndex = this.SuitVerticalLayout.GetItemByIndex(index);
		UUIItem item = base.GetItem(2);
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(16);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.StopMovement();
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(16);
		if (scrollViewWithScrollbar2 != null)
		{
			scrollViewWithScrollbar2.ScrollTo(item, true);
		}
		if (itemByIndex == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			itemByIndex,
			itemByIndex
		};
	}

	// Token: 0x04006FB9 RID: 28601
	[Nullable(2)]
	private HonamiStoryRoleEquipData EquipData;

	// Token: 0x04006FBA RID: 28602
	private GenericLayout<HonamiStoryWeaponSuitInfoItem, IHonamiStoryWeaponSuitData> SuitVerticalLayout;

	// Token: 0x04006FBB RID: 28603
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> SkillLayout;

	// Token: 0x04006FBC RID: 28604
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData> PropertyLayout;

	// Token: 0x04006FBD RID: 28605
	private GenericLayout<HonamiStoryWeaponTagItem, int> TagLayout;

	// Token: 0x04006FBE RID: 28606
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006FBF RID: 28607
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x0200848D RID: 33933
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B250 RID: 176720
		WeaponInfoPanel,
		// Token: 0x0402B251 RID: 176721
		WeaponInfoText,
		// Token: 0x0402B252 RID: 176722
		SuitInfoPanel,
		// Token: 0x0402B253 RID: 176723
		SuitActiveVerticalLayout,
		// Token: 0x0402B254 RID: 176724
		SuitActiveItem,
		// Token: 0x0402B255 RID: 176725
		SkillInfoPanel,
		// Token: 0x0402B256 RID: 176726
		SkillVerticalLayout,
		// Token: 0x0402B257 RID: 176727
		SkillItem,
		// Token: 0x0402B258 RID: 176728
		PropertyInfoPanel,
		// Token: 0x0402B259 RID: 176729
		PropertyInfoVerticalLayout,
		// Token: 0x0402B25A RID: 176730
		PropertyInfoItem,
		// Token: 0x0402B25B RID: 176731
		ArrowButton,
		// Token: 0x0402B25C RID: 176732
		WeaponEmptyPanel,
		// Token: 0x0402B25D RID: 176733
		ItemEmptyPanel,
		// Token: 0x0402B25E RID: 176734
		PanelSelf,
		// Token: 0x0402B25F RID: 176735
		ToggleClose,
		// Token: 0x0402B260 RID: 176736
		ScrollView,
		// Token: 0x0402B261 RID: 176737
		TagPanel,
		// Token: 0x0402B262 RID: 176738
		TagLayout,
		// Token: 0x0402B263 RID: 176739
		TagItem
	}
}
