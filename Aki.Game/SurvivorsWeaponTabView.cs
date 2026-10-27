using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B32 RID: 11058
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SurvivorsWeaponTabView : SurvivorsTabViewBase<SurvivorWeaponTabItem, SurvivorsHandbookWeaponData>
{
	// Token: 0x17001E9F RID: 7839
	// (get) Token: 0x06016F37 RID: 94007 RVA: 0x005D31AB File Offset: 0x005D13AB
	protected override ESurvivorsRogueItemType ItemType
	{
		get
		{
			return ESurvivorsRogueItemType.Weapon;
		}
	}

	// Token: 0x06016F38 RID: 94008 RVA: 0x005D31B0 File Offset: 0x005D13B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06016F39 RID: 94009 RVA: 0x005D3299 File Offset: 0x005D1499
	protected override int GetLoopItemIndex()
	{
		return 3;
	}

	// Token: 0x06016F3A RID: 94010 RVA: 0x005D329C File Offset: 0x005D149C
	protected override int GetLoopScrollComponentIndex()
	{
		return 1;
	}

	// Token: 0x06016F3B RID: 94011 RVA: 0x005D32A0 File Offset: 0x005D14A0
	protected override UniTask InitSubComponents()
	{
		SurvivorsWeaponTabView.<InitSubComponents>d__6 <InitSubComponents>d__;
		<InitSubComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSubComponents>d__.<>4__this = this;
		<InitSubComponents>d__.<>1__state = -1;
		<InitSubComponents>d__.<>t__builder.Start<SurvivorsWeaponTabView.<InitSubComponents>d__6>(ref <InitSubComponents>d__);
		return <InitSubComponents>d__.<>t__builder.Task;
	}

	// Token: 0x06016F3C RID: 94012 RVA: 0x005D32E3 File Offset: 0x005D14E3
	protected override void OnTriggerSequenceStartEvent()
	{
		GenericScrollViewNew<SurvivorsWeaponDetailItem, int> weaponEvolveScroll = this.WeaponEvolveScroll;
		if (weaponEvolveScroll == null)
		{
			return;
		}
		weaponEvolveScroll.GetGenericLayout().PlayGridAnim();
	}

	// Token: 0x06016F3D RID: 94013 RVA: 0x005D32FA File Offset: 0x005D14FA
	private SurvivorsWeaponDetailItem CreateWeaponEvolveItem()
	{
		return new SurvivorsWeaponDetailItem();
	}

	// Token: 0x06016F3E RID: 94014 RVA: 0x005D3301 File Offset: 0x005D1501
	protected override SurvivorWeaponTabItem CreateLoopItem()
	{
		return new SurvivorWeaponTabItem
		{
			OnClickToggleCallBack = new Action<SurvivorsHandbookWeaponData, SurvivorWeaponTabItem>(base.OnItemClick),
			OnCanToggleClicked = new Func<SurvivorsHandbookWeaponData, bool, EToggleState, bool>(base.OnCanClickItem)
		};
	}

	// Token: 0x06016F3F RID: 94015 RVA: 0x005D332C File Offset: 0x005D152C
	[PreserveBaseOverrides]
	protected new virtual List<SurvivorsHandbookWeaponData> GenerateItemUiDataList()
	{
		int actId = SurvivorsRogueModel.Instance.ActivityData.ActId;
		IEnumerable<SurvivorsWeapon> allSurvivorsWeaponByActId = SurvivorsRogueConfig.Instance.GetAllSurvivorsWeaponByActId(actId);
		List<SurvivorsHandbookWeaponData> list = new List<SurvivorsHandbookWeaponData>();
		foreach (SurvivorsWeapon survivorsWeapon in allSurvivorsWeaponByActId)
		{
			bool itemIsLock = SurvivorsRogueModel.Instance.GetItemIsLock(this.ItemType, survivorsWeapon.Id);
			SurvivorsHandbookWeaponData item = new SurvivorsHandbookWeaponData
			{
				Id = survivorsWeapon.Id,
				LockState = new bool?(itemIsLock),
				IsNew = new bool?(SurvivorsRogueModel.Instance.GetItemIsNew(this.ItemType, survivorsWeapon.Id)),
				SortId = survivorsWeapon.SortId
			};
			list.Add(item);
		}
		this.SortUiDataList(list);
		return list;
	}

	// Token: 0x06016F40 RID: 94016 RVA: 0x005D3408 File Offset: 0x005D1608
	private void SortUiDataList(List<SurvivorsHandbookWeaponData> uiDataList)
	{
		uiDataList.Sort(delegate(SurvivorsHandbookWeaponData a, SurvivorsHandbookWeaponData b)
		{
			bool? lockState = a.LockState;
			bool? lockState2 = b.LockState;
			if (!(lockState.GetValueOrDefault() == lockState2.GetValueOrDefault() & lockState != null == (lockState2 != null)))
			{
				if (a.LockState == null || b.LockState == null)
				{
					return 0;
				}
				if (!a.LockState.Value)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (a.SortId != b.SortId)
				{
					return a.SortId - b.SortId;
				}
				return a.Id - b.Id;
			}
		});
	}

	// Token: 0x06016F41 RID: 94017 RVA: 0x005D3430 File Offset: 0x005D1630
	protected override void OnSelectItem(SurvivorsHandbookWeaponData data, bool isFromClick = true)
	{
		SurvivorsWeapon value = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(data.Id).Value;
		UUIText text = base.GetText(8);
		if (text != null)
		{
			if (data.LockState.GetValueOrDefault())
			{
				text.ShowTextNew("Text_Unknown_Text");
			}
			else
			{
				text.ShowTextNew(value.Name);
			}
		}
		this.WeaponEvolveScroll.RefreshByData(this.GenerateWeaponEvolveUiDataList(data).ToList<int>(), delegate
		{
			foreach (SurvivorsWeaponDetailItem survivorsWeaponDetailItem in this.WeaponEvolveScroll.GetScrollItemList())
			{
				survivorsWeaponDetailItem.SetIsCurrentState(false);
				survivorsWeaponDetailItem.SetIsLocked(false);
			}
		}, isFromClick);
	}

	// Token: 0x06016F42 RID: 94018 RVA: 0x005D34B0 File Offset: 0x005D16B0
	private IReadOnlyList<int> GenerateWeaponEvolveUiDataList(SurvivorsHandbookWeaponData data)
	{
		int id = data.Id;
		SurvivorsWeapon value = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(id).Value;
		List<int> list;
		if (!data.LockState.GetValueOrDefault())
		{
			list = new List<int>();
			for (int i = 0; i < value.EvolveIdsLength; i++)
			{
				list.Add(value.EvolveIds(i).Value.Key);
			}
		}
		else
		{
			list = new List<int>
			{
				SurvivorsRogueConfig.Instance.GetSurvivorsWeaponDefaultEvolve(id).Value.Id
			};
		}
		return list;
	}

	// Token: 0x0400AAE8 RID: 43752
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<SurvivorsWeaponDetailItem, int> WeaponEvolveScroll;
}
