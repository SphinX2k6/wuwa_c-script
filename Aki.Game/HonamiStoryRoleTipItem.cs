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

// Token: 0x02001372 RID: 4978
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryRoleTipItem : UiPanelBase
{
	// Token: 0x0600C5BE RID: 50622 RVA: 0x003AE020 File Offset: 0x003AC220
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

	// Token: 0x0600C5BF RID: 50623 RVA: 0x003AE238 File Offset: 0x003AC438
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryRoleTipItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryRoleTipItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5C0 RID: 50624 RVA: 0x003AE27C File Offset: 0x003AC47C
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

	// Token: 0x0600C5C1 RID: 50625 RVA: 0x003AE315 File Offset: 0x003AC515
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
	}

	// Token: 0x0600C5C2 RID: 50626 RVA: 0x003AE333 File Offset: 0x003AC533
	private HonamiStoryWeaponSuitInfoItem CreateSuitItem()
	{
		return new HonamiStoryWeaponSuitInfoItem();
	}

	// Token: 0x0600C5C3 RID: 50627 RVA: 0x003AE33A File Offset: 0x003AC53A
	private HonamiStoryTipsTextItem CreateSkill()
	{
		return new HonamiStoryTipsTextItem();
	}

	// Token: 0x0600C5C4 RID: 50628 RVA: 0x003AE341 File Offset: 0x003AC541
	private HonamiStoryTipsPropertyItem CreateProperty()
	{
		return new HonamiStoryTipsPropertyItem();
	}

	// Token: 0x0600C5C5 RID: 50629 RVA: 0x003AE348 File Offset: 0x003AC548
	private HonamiStoryWeaponTagItem CreateTagItem()
	{
		return new HonamiStoryWeaponTagItem();
	}

	// Token: 0x0600C5C6 RID: 50630 RVA: 0x003AE350 File Offset: 0x003AC550
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

	// Token: 0x0600C5C7 RID: 50631 RVA: 0x003AE3AC File Offset: 0x003AC5AC
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

	// Token: 0x0600C5C8 RID: 50632 RVA: 0x003AE3F4 File Offset: 0x003AC5F4
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

	// Token: 0x0600C5C9 RID: 50633 RVA: 0x003AE5B0 File Offset: 0x003AC7B0
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

	// Token: 0x0600C5CA RID: 50634 RVA: 0x003AE8C0 File Offset: 0x003ACAC0
	public void RegisterCloseCallback(Action callback)
	{
		this.CloseCallback = callback;
	}

	// Token: 0x0600C5CB RID: 50635 RVA: 0x003AE8CC File Offset: 0x003ACACC
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

	// Token: 0x0600C5CC RID: 50636 RVA: 0x003AE924 File Offset: 0x003ACB24
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

	// Token: 0x0600C5CD RID: 50637 RVA: 0x003AE966 File Offset: 0x003ACB66
	private void OnClickedArrowButton()
	{
		Action closeCallback = this.CloseCallback;
		if (closeCallback != null)
		{
			closeCallback();
		}
		this.ShowTips(false);
	}

	// Token: 0x0600C5CE RID: 50638 RVA: 0x003AE980 File Offset: 0x003ACB80
	private void OnSkillDescModeChange(bool _)
	{
		this.RefreshWeaponTips();
		this.RefreshPluginTips();
	}

	// Token: 0x0600C5CF RID: 50639 RVA: 0x003AE990 File Offset: 0x003ACB90
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

	// Token: 0x0400709A RID: 28826
	[Nullable(2)]
	private HonamiStoryRoleEquipData EquipData;

	// Token: 0x0400709B RID: 28827
	private GenericLayout<HonamiStoryWeaponSuitInfoItem, IHonamiStoryWeaponSuitData> SuitVerticalLayout;

	// Token: 0x0400709C RID: 28828
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> SkillLayout;

	// Token: 0x0400709D RID: 28829
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData> PropertyLayout;

	// Token: 0x0400709E RID: 28830
	private GenericLayout<HonamiStoryWeaponTagItem, int> TagLayout;

	// Token: 0x0400709F RID: 28831
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040070A0 RID: 28832
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x02007612 RID: 30226
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026574 RID: 157044
		WeaponInfoPanel,
		// Token: 0x04026575 RID: 157045
		WeaponInfoText,
		// Token: 0x04026576 RID: 157046
		SuitInfoPanel,
		// Token: 0x04026577 RID: 157047
		SuitActiveVerticalLayout,
		// Token: 0x04026578 RID: 157048
		SuitActiveItem,
		// Token: 0x04026579 RID: 157049
		SkillInfoPanel,
		// Token: 0x0402657A RID: 157050
		SkillVerticalLayout,
		// Token: 0x0402657B RID: 157051
		SkillItem,
		// Token: 0x0402657C RID: 157052
		PropertyInfoPanel,
		// Token: 0x0402657D RID: 157053
		PropertyInfoVerticalLayout,
		// Token: 0x0402657E RID: 157054
		PropertyInfoItem,
		// Token: 0x0402657F RID: 157055
		ArrowButton,
		// Token: 0x04026580 RID: 157056
		WeaponEmptyPanel,
		// Token: 0x04026581 RID: 157057
		ItemEmptyPanel,
		// Token: 0x04026582 RID: 157058
		PanelSelf,
		// Token: 0x04026583 RID: 157059
		ToggleClose,
		// Token: 0x04026584 RID: 157060
		ScrollView,
		// Token: 0x04026585 RID: 157061
		TagPanel,
		// Token: 0x04026586 RID: 157062
		TagLayout,
		// Token: 0x04026587 RID: 157063
		TagItem
	}
}
