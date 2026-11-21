using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020AE RID: 8366
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SurvivorsWeaponTabView : SurvivorsTabViewBase<SurvivorWeaponTabItem, SurvivorsHandbookWeaponData>
{
	// Token: 0x17001EF7 RID: 7927
	// (get) Token: 0x06014968 RID: 84328 RVA: 0x005FFD1F File Offset: 0x005FDF1F
	protected override ESurvivorsRogueItemType ItemType
	{
		get
		{
			return ESurvivorsRogueItemType.Weapon;
		}
	}

	// Token: 0x06014969 RID: 84329 RVA: 0x005FFD24 File Offset: 0x005FDF24
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

	// Token: 0x0601496A RID: 84330 RVA: 0x005FFE0D File Offset: 0x005FE00D
	protected override int GetLoopItemIndex()
	{
		return 3;
	}

	// Token: 0x0601496B RID: 84331 RVA: 0x005FFE10 File Offset: 0x005FE010
	protected override int GetLoopScrollComponentIndex()
	{
		return 1;
	}

	// Token: 0x0601496C RID: 84332 RVA: 0x005FFE14 File Offset: 0x005FE014
	protected override UniTask InitSubComponents()
	{
		SurvivorsWeaponTabView.<InitSubComponents>d__6 <InitSubComponents>d__;
		<InitSubComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSubComponents>d__.<>4__this = this;
		<InitSubComponents>d__.<>1__state = -1;
		<InitSubComponents>d__.<>t__builder.Start<SurvivorsWeaponTabView.<InitSubComponents>d__6>(ref <InitSubComponents>d__);
		return <InitSubComponents>d__.<>t__builder.Task;
	}

	// Token: 0x0601496D RID: 84333 RVA: 0x005FFE57 File Offset: 0x005FE057
	protected override void OnTriggerSequenceStartEvent()
	{
		GenericScrollViewNew<SurvivorsWeaponDetailItem, int> weaponEvolveScroll = this.WeaponEvolveScroll;
		if (weaponEvolveScroll == null)
		{
			return;
		}
		weaponEvolveScroll.GetGenericLayout().PlayGridAnim();
	}

	// Token: 0x0601496E RID: 84334 RVA: 0x005FFE6E File Offset: 0x005FE06E
	private SurvivorsWeaponDetailItem CreateWeaponEvolveItem()
	{
		return new SurvivorsWeaponDetailItem();
	}

	// Token: 0x0601496F RID: 84335 RVA: 0x005FFE75 File Offset: 0x005FE075
	protected override SurvivorWeaponTabItem CreateLoopItem()
	{
		return new SurvivorWeaponTabItem
		{
			OnClickToggleCallBack = new Action<SurvivorsHandbookWeaponData, SurvivorWeaponTabItem>(base.OnItemClick),
			OnCanToggleClicked = new Func<SurvivorsHandbookWeaponData, bool, EToggleState, bool>(base.OnCanClickItem)
		};
	}

	// Token: 0x06014970 RID: 84336 RVA: 0x005FFEA0 File Offset: 0x005FE0A0
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

	// Token: 0x06014971 RID: 84337 RVA: 0x005FFF7C File Offset: 0x005FE17C
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

	// Token: 0x06014972 RID: 84338 RVA: 0x005FFFA4 File Offset: 0x005FE1A4
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
		this.WeaponEvolveScroll.RefreshByData(this.GenerateWeaponEvolveUiDataList(data), delegate
		{
			foreach (SurvivorsWeaponDetailItem survivorsWeaponDetailItem in this.WeaponEvolveScroll.GetScrollItemList())
			{
				survivorsWeaponDetailItem.SetIsCurrentState(false);
				survivorsWeaponDetailItem.SetIsLocked(false);
			}
		}, isFromClick);
	}

	// Token: 0x06014973 RID: 84339 RVA: 0x00600020 File Offset: 0x005FE220
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

	// Token: 0x0400AEEE RID: 44782
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<SurvivorsWeaponDetailItem, int> WeaponEvolveScroll;
}
