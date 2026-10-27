using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B13 RID: 11027
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsWeaponDetailTabView : UiPanelBase
{
	// Token: 0x06016EA3 RID: 93859 RVA: 0x005D08F8 File Offset: 0x005CEAF8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickIconMore))
		};
	}

	// Token: 0x06016EA4 RID: 93860 RVA: 0x005D0A14 File Offset: 0x005CEC14
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsWeaponDetailTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsWeaponDetailTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016EA5 RID: 93861 RVA: 0x005D0A58 File Offset: 0x005CEC58
	private UniTask InitializeWeaponTotalItemList()
	{
		SurvivorsWeaponDetailTabView.<InitializeWeaponTotalItemList>d__10 <InitializeWeaponTotalItemList>d__;
		<InitializeWeaponTotalItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeWeaponTotalItemList>d__.<>4__this = this;
		<InitializeWeaponTotalItemList>d__.<>1__state = -1;
		<InitializeWeaponTotalItemList>d__.<>t__builder.Start<SurvivorsWeaponDetailTabView.<InitializeWeaponTotalItemList>d__10>(ref <InitializeWeaponTotalItemList>d__);
		return <InitializeWeaponTotalItemList>d__.<>t__builder.Task;
	}

	// Token: 0x06016EA6 RID: 93862 RVA: 0x005D0A9B File Offset: 0x005CEC9B
	private SurvivorsAttributeItem CreateAttributeItemProxy()
	{
		return new SurvivorsAttributeItem();
	}

	// Token: 0x06016EA7 RID: 93863 RVA: 0x005D0AA4 File Offset: 0x005CECA4
	protected override void OnStart()
	{
		this.WeaponEvolveScroll = new GenericScrollViewNew<SurvivorsWeaponDetailItem, int>(base.GetScrollViewWithScrollbar(1), new Func<SurvivorsWeaponDetailItem>(this.CreateWeaponGrid), null, false, null);
		this.WeaponAttributeIconLayout = new GenericLayout<SurvivorsWeaponAttributeIconItem, int>(base.GetHorizontalLayout(7), new Func<SurvivorsWeaponAttributeIconItem>(this.CreateWeaponAttributeIcon), null, false, true);
		EventSystem.Instance.Emit<bool>(EEventName.SurvivorsRogueWeaponDetailTabViewShow, true);
	}

	// Token: 0x06016EA8 RID: 93864 RVA: 0x005D0B04 File Offset: 0x005CED04
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Emit<bool>(EEventName.SurvivorsRogueWeaponDetailTabViewShow, false);
	}

	// Token: 0x06016EA9 RID: 93865 RVA: 0x005D0B17 File Offset: 0x005CED17
	private SurvivorsWeaponDetailItem CreateWeaponGrid()
	{
		return new SurvivorsWeaponDetailItem();
	}

	// Token: 0x06016EAA RID: 93866 RVA: 0x005D0B1E File Offset: 0x005CED1E
	private SurvivorsWeaponAttributeIconItem CreateWeaponAttributeIcon()
	{
		return new SurvivorsWeaponAttributeIconItem();
	}

	// Token: 0x06016EAB RID: 93867 RVA: 0x005D0B28 File Offset: 0x005CED28
	public void RefreshByData(SurvivorsWeaponGainData weaponData)
	{
		this.WeaponData = weaponData;
		int configId = weaponData.ConfigId;
		int currentEvolveId = weaponData.GetCurrentEvolveId();
		this.RefreshWeaponCard(configId);
		this.RefreshEvolveInfo(configId, currentEvolveId);
		this.RefreshAttributeList(configId, weaponData.Data.Affixs.ToList<int>());
		this.RefreshWeaponTotalList(weaponData.Data.KillMonsterCount);
		this.RefreshAttributeIcon();
	}

	// Token: 0x06016EAC RID: 93868 RVA: 0x005D0B88 File Offset: 0x005CED88
	public void RefreshWeaponCard(int weaponId)
	{
		SurvivorsRogueWeaponCard survivorsRogueWeaponCard = SurvivorsRogueCardDataFactory.CreateGeneralWeapon(weaponId);
		survivorsRogueWeaponCard.TagVisible = new bool?(false);
		SurvivorsRogueCardBase cardItem = this.CardItem;
		if (cardItem == null)
		{
			return;
		}
		cardItem.Apply(survivorsRogueWeaponCard);
	}

	// Token: 0x06016EAD RID: 93869 RVA: 0x005D0BBC File Offset: 0x005CEDBC
	public void RefreshEvolveInfo(int weaponId, int weaponEvolveId)
	{
		SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponId);
		List<int> weaponEvolveIdList = new List<int>();
		for (int i = 0; i < survivorsWeapon.Value.EvolveIdsLength; i++)
		{
			DicIntInt? dicIntInt = survivorsWeapon.Value.EvolveIds(i);
			if (dicIntInt != null)
			{
				weaponEvolveIdList.Add(dicIntInt.Value.Key);
			}
		}
		GenericScrollViewNew<SurvivorsWeaponDetailItem, int> weaponEvolveScroll = this.WeaponEvolveScroll;
		if (weaponEvolveScroll == null)
		{
			return;
		}
		weaponEvolveScroll.RefreshByDataAsync(weaponEvolveIdList, true).ContinueWith(delegate()
		{
			this.RefreshCurrentEvolve(weaponEvolveIdList, weaponEvolveIdList, weaponEvolveId);
		});
	}

	// Token: 0x06016EAE RID: 93870 RVA: 0x005D0C70 File Offset: 0x005CEE70
	public void RefreshCurrentEvolve(List<int> weaponEvolveIdList, List<int> unlockEvolveIdList, int currentEvolveId)
	{
		UUIItem uiitem = null;
		List<SurvivorsWeaponDetailItem> scrollItemList = this.WeaponEvolveScroll.GetScrollItemList();
		for (int i = 0; i < weaponEvolveIdList.Count; i++)
		{
			int num = weaponEvolveIdList[i];
			SurvivorsWeaponDetailItem survivorsWeaponDetailItem = scrollItemList[i];
			bool flag = unlockEvolveIdList.Contains(num);
			survivorsWeaponDetailItem.SetIsLocked(!flag);
			if (num == currentEvolveId)
			{
				uiitem = this.WeaponEvolveScroll.GetItemByIndex(i);
				survivorsWeaponDetailItem.SetIsCurrentState(true);
			}
			else
			{
				survivorsWeaponDetailItem.SetIsCurrentState(false);
			}
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		scrollViewWithScrollbar.ScrollTo(uiitem, true);
	}

	// Token: 0x06016EAF RID: 93871 RVA: 0x005D0CF8 File Offset: 0x005CEEF8
	public void RefreshWeaponTotalList(int totalKillCount)
	{
		SurvivorsAttributeItem totalKillItem = this.TotalKillItem;
		if (totalKillItem == null)
		{
			return;
		}
		totalKillItem.SetValue((double)totalKillCount, false, false);
	}

	// Token: 0x06016EB0 RID: 93872 RVA: 0x005D0D10 File Offset: 0x005CEF10
	private void RefreshAttributeList(int weaponId, List<int> weaponAffixs)
	{
		Dictionary<int, double> dictionary = new Dictionary<int, double>();
		foreach (int lvId in weaponAffixs)
		{
			SurvivorsWeaponLv? survivorsWeaponLv = SurvivorsRogueConfig.Instance.GetSurvivorsWeaponLv(lvId);
			double num = dictionary.ContainsKey(survivorsWeaponLv.Value.PropertyId) ? dictionary[survivorsWeaponLv.Value.PropertyId] : 0.0;
			int num2 = survivorsWeaponLv.Value.PropertyValue / 10000;
			dictionary[survivorsWeaponLv.Value.PropertyId] = num + (double)num2;
		}
		SurvivorsRoleGainData roleGainData = SurvivorsRogueModel.Instance.GainData.GetRoleGainData();
		if (roleGainData != null)
		{
			foreach (int lvId2 in roleGainData.Data.Affixs)
			{
				SurvivorsRoleLv? survivorsRoleLv = SurvivorsRogueConfig.Instance.GetSurvivorsRoleLv(lvId2);
				if (survivorsRoleLv.Value.BuffCategoryType == 2)
				{
					double num3 = dictionary.ContainsKey(survivorsRoleLv.Value.PropertyId) ? dictionary[survivorsRoleLv.Value.PropertyId] : 0.0;
					int num4 = survivorsRoleLv.Value.PropertyValue / 10000;
					dictionary[survivorsRoleLv.Value.PropertyId] = num3 + (double)num4;
				}
			}
		}
		SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponId);
		HashSet<int> hashSet = new HashSet<int>(survivorsWeapon.Value.GetRecommendPropertyArray());
		List<ISurvivorsAttributeUiData> list = new List<ISurvivorsAttributeUiData>();
		foreach (int num5 in survivorsWeapon.Value.GetPropertyListArray())
		{
			if (dictionary.ContainsKey(num5))
			{
				double value = dictionary[num5];
				list.Add(new SurvivorsAttributeUiData
				{
					AttrId = num5,
					IsRecommend = hashSet.Contains(num5),
					Value = value,
					IsAddition = new bool?(true)
				});
			}
		}
		list.Sort(delegate(ISurvivorsAttributeUiData a, ISurvivorsAttributeUiData b)
		{
			if (a.IsRecommend == b.IsRecommend)
			{
				return a.AttrId - b.AttrId;
			}
			if (!a.IsRecommend)
			{
				return 1;
			}
			return -1;
		});
		this.AttributeScrollView.RefreshByData(list, false, null, false);
	}

	// Token: 0x06016EB1 RID: 93873 RVA: 0x005D0FA4 File Offset: 0x005CF1A4
	private void RefreshAttributeIcon()
	{
		List<int> list = new List<int>();
		foreach (ISurvivorsWeaponAttributeData survivorsWeaponAttributeData in this.WeaponData.GetWeaponSpecialAttributeList())
		{
			list.Add(survivorsWeaponAttributeData.AttrId);
		}
		if (list.Count > 0)
		{
			int num = (list.Count > 5) ? 5 : list.Count;
			List<int> list2 = new List<int>();
			for (int i = 0; i < num; i++)
			{
				list2.Add(list[i]);
			}
			this.WeaponAttributeIconLayout.RefreshByData(list2, null, false);
		}
		base.GetItem(6).SetUIActive(list.Count > 0);
	}

	// Token: 0x06016EB2 RID: 93874 RVA: 0x005D1070 File Offset: 0x005CF270
	private void OnClickIconMore()
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsWeaponAttributeView, this.WeaponData, null);
	}

	// Token: 0x0400AA56 RID: 43606
	private const int ATTRIBUTE_TOTAL_KILL_COUNT_ID = 267;

	// Token: 0x0400AA57 RID: 43607
	private const int SPECIAL_ATTRIBUTE_COUNT = 5;

	// Token: 0x0400AA58 RID: 43608
	[Nullable(2)]
	private SurvivorsWeaponGainData WeaponData;

	// Token: 0x0400AA59 RID: 43609
	[Nullable(2)]
	private SurvivorsRogueCardBase CardItem;

	// Token: 0x0400AA5A RID: 43610
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<SurvivorsWeaponDetailItem, int> WeaponEvolveScroll;

	// Token: 0x0400AA5B RID: 43611
	[Nullable(2)]
	private SurvivorsAttributeItem TotalKillItem;

	// Token: 0x0400AA5C RID: 43612
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<SurvivorsAttributeItem, ISurvivorsAttributeUiData> AttributeScrollView;

	// Token: 0x0400AA5D RID: 43613
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SurvivorsWeaponAttributeIconItem, int> WeaponAttributeIconLayout;
}
