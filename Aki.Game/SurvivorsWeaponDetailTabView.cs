using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200208F RID: 8335
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsWeaponDetailTabView : UiPanelBase
{
	// Token: 0x060148D4 RID: 84180 RVA: 0x005FD478 File Offset: 0x005FB678
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

	// Token: 0x060148D5 RID: 84181 RVA: 0x005FD594 File Offset: 0x005FB794
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsWeaponDetailTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsWeaponDetailTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060148D6 RID: 84182 RVA: 0x005FD5D8 File Offset: 0x005FB7D8
	private UniTask InitializeWeaponTotalItemList()
	{
		SurvivorsWeaponDetailTabView.<InitializeWeaponTotalItemList>d__10 <InitializeWeaponTotalItemList>d__;
		<InitializeWeaponTotalItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeWeaponTotalItemList>d__.<>4__this = this;
		<InitializeWeaponTotalItemList>d__.<>1__state = -1;
		<InitializeWeaponTotalItemList>d__.<>t__builder.Start<SurvivorsWeaponDetailTabView.<InitializeWeaponTotalItemList>d__10>(ref <InitializeWeaponTotalItemList>d__);
		return <InitializeWeaponTotalItemList>d__.<>t__builder.Task;
	}

	// Token: 0x060148D7 RID: 84183 RVA: 0x005FD61B File Offset: 0x005FB81B
	private SurvivorsAttributeItem CreateAttributeItemProxy()
	{
		return new SurvivorsAttributeItem();
	}

	// Token: 0x060148D8 RID: 84184 RVA: 0x005FD624 File Offset: 0x005FB824
	protected override void OnStart()
	{
		this.WeaponEvolveScroll = new GenericScrollViewNew<SurvivorsWeaponDetailItem, int>(base.GetScrollViewWithScrollbar(1), new Func<SurvivorsWeaponDetailItem>(this.CreateWeaponGrid), null, false, null);
		this.WeaponAttributeIconLayout = new GenericLayout<SurvivorsWeaponAttributeIconItem, int>(base.GetHorizontalLayout(7), new Func<SurvivorsWeaponAttributeIconItem>(this.CreateWeaponAttributeIcon), null, false, true);
		EventSystem.Instance.Emit<bool>(EEventName.SurvivorsRogueWeaponDetailTabViewShow, true);
	}

	// Token: 0x060148D9 RID: 84185 RVA: 0x005FD684 File Offset: 0x005FB884
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Emit<bool>(EEventName.SurvivorsRogueWeaponDetailTabViewShow, false);
	}

	// Token: 0x060148DA RID: 84186 RVA: 0x005FD697 File Offset: 0x005FB897
	private SurvivorsWeaponDetailItem CreateWeaponGrid()
	{
		return new SurvivorsWeaponDetailItem();
	}

	// Token: 0x060148DB RID: 84187 RVA: 0x005FD69E File Offset: 0x005FB89E
	private SurvivorsWeaponAttributeIconItem CreateWeaponAttributeIcon()
	{
		return new SurvivorsWeaponAttributeIconItem();
	}

	// Token: 0x060148DC RID: 84188 RVA: 0x005FD6A8 File Offset: 0x005FB8A8
	public void RefreshByData(SurvivorsWeaponGainData weaponData)
	{
		this.WeaponData = weaponData;
		int configId = weaponData.ConfigId;
		int currentEvolveId = weaponData.GetCurrentEvolveId();
		this.RefreshWeaponCard(configId);
		this.RefreshEvolveInfo(configId, currentEvolveId);
		this.RefreshAttributeList(configId, weaponData.Data.Affixs);
		this.RefreshWeaponTotalList(weaponData.Data.KillMonsterCount);
		this.RefreshAttributeIcon();
	}

	// Token: 0x060148DD RID: 84189 RVA: 0x005FD704 File Offset: 0x005FB904
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

	// Token: 0x060148DE RID: 84190 RVA: 0x005FD738 File Offset: 0x005FB938
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

	// Token: 0x060148DF RID: 84191 RVA: 0x005FD7EC File Offset: 0x005FB9EC
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

	// Token: 0x060148E0 RID: 84192 RVA: 0x005FD874 File Offset: 0x005FBA74
	public void RefreshWeaponTotalList(int totalKillCount)
	{
		SurvivorsAttributeItem totalKillItem = this.TotalKillItem;
		if (totalKillItem == null)
		{
			return;
		}
		totalKillItem.SetValue((double)totalKillCount, false, false);
	}

	// Token: 0x060148E1 RID: 84193 RVA: 0x005FD88C File Offset: 0x005FBA8C
	private void RefreshAttributeList(int weaponId, IEnumerable<int> weaponAffixs)
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

	// Token: 0x060148E2 RID: 84194 RVA: 0x005FDB20 File Offset: 0x005FBD20
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

	// Token: 0x060148E3 RID: 84195 RVA: 0x005FDBEC File Offset: 0x005FBDEC
	private void OnClickIconMore()
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsWeaponAttributeView, this.WeaponData, null);
	}

	// Token: 0x0400AE5C RID: 44636
	private const int ATTRIBUTE_TOTAL_KILL_COUNT_ID = 267;

	// Token: 0x0400AE5D RID: 44637
	private const int SPECIAL_ATTRIBUTE_COUNT = 5;

	// Token: 0x0400AE5E RID: 44638
	[Nullable(2)]
	private SurvivorsWeaponGainData WeaponData;

	// Token: 0x0400AE5F RID: 44639
	[Nullable(2)]
	private SurvivorsRogueCardBase CardItem;

	// Token: 0x0400AE60 RID: 44640
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<SurvivorsWeaponDetailItem, int> WeaponEvolveScroll;

	// Token: 0x0400AE61 RID: 44641
	[Nullable(2)]
	private SurvivorsAttributeItem TotalKillItem;

	// Token: 0x0400AE62 RID: 44642
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<SurvivorsAttributeItem, ISurvivorsAttributeUiData> AttributeScrollView;

	// Token: 0x0400AE63 RID: 44643
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SurvivorsWeaponAttributeIconItem, int> WeaponAttributeIconLayout;
}
