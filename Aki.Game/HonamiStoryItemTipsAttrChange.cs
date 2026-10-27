using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EA9 RID: 7849
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemTipsAttrChange : UiPanelBase
{
	// Token: 0x0600F134 RID: 61748 RVA: 0x0039F288 File Offset: 0x0039D488
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600F135 RID: 61749 RVA: 0x0039F30E File Offset: 0x0039D50E
	protected override void OnStart()
	{
		this.AttrLayout = new GenericLayout<HonamiStoryAttrItem, IHonamiStoryAttrData>(base.GetVerticalLayout(0), new Func<HonamiStoryAttrItem>(this.InitAttrItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600F136 RID: 61750 RVA: 0x0039F341 File Offset: 0x0039D541
	private HonamiStoryAttrItem InitAttrItem()
	{
		return new HonamiStoryAttrItem();
	}

	// Token: 0x0600F137 RID: 61751 RVA: 0x0039F348 File Offset: 0x0039D548
	public List<IHonamiStoryAttrData> CombineDataList(HonamiStoryEquipItemData oldData, HonamiStoryEquipItemData newData)
	{
		int[] mainPropList = oldData.GetMainPropList();
		int[] mainPropList2 = newData.GetMainPropList();
		this.PropertyMap.Clear();
		List<IHonamiStoryAttrData> list = new List<IHonamiStoryAttrData>();
		HonamiStoryProp? honamiStoryProp = null;
		foreach (int id in mainPropList)
		{
			honamiStoryProp = HonamiStoryConfig.Instance.GetHonamiStoryProp(id);
			if (honamiStoryProp != null)
			{
				PropertyIndexConfig instance = PropertyIndexConfig.Instance;
				string text = (instance != null) ? instance.GetPropertyIndexName(honamiStoryProp.Value.PropId) : null;
				PropertyIndexConfig instance2 = PropertyIndexConfig.Instance;
				string text2 = (instance2 != null) ? instance2.GetPropertyIndexIcon(honamiStoryProp.Value.PropId) : null;
				HonamiStoryAttrData value = new HonamiStoryAttrData
				{
					Name = (text ?? string.Empty),
					IconPath = (text2 ?? string.Empty),
					OldValue = honamiStoryProp.Value.StandardProperty,
					NewValue = 0,
					IsPercent = honamiStoryProp.Value.ShowPercent
				};
				this.PropertyMap[honamiStoryProp.Value.PropId] = value;
			}
		}
		foreach (int num in mainPropList2)
		{
			honamiStoryProp = HonamiStoryConfig.Instance.GetHonamiStoryProp(num);
			if (honamiStoryProp != null)
			{
				int standardProperty = honamiStoryProp.Value.StandardProperty;
				IHonamiStoryAttrData honamiStoryAttrData;
				if (this.PropertyMap.TryGetValue(honamiStoryProp.Value.PropId, out honamiStoryAttrData))
				{
					honamiStoryAttrData.NewValue = standardProperty;
				}
				else
				{
					PropertyIndexConfig instance3 = PropertyIndexConfig.Instance;
					string text3 = (instance3 != null) ? instance3.GetPropertyIndexName(honamiStoryProp.Value.PropId) : null;
					PropertyIndexConfig instance4 = PropertyIndexConfig.Instance;
					string text4 = (instance4 != null) ? instance4.GetPropertyIndexIcon(honamiStoryProp.Value.PropId) : null;
					HonamiStoryAttrData value2 = new HonamiStoryAttrData
					{
						Name = (text3 ?? string.Empty),
						IconPath = (text4 ?? string.Empty),
						OldValue = 0,
						NewValue = standardProperty,
						IsPercent = honamiStoryProp.Value.ShowPercent
					};
					this.PropertyMap[num] = value2;
				}
			}
		}
		foreach (IHonamiStoryAttrData item in this.PropertyMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600F138 RID: 61752 RVA: 0x0039F5DC File Offset: 0x0039D7DC
	public void Refresh(HonamiStoryEquipItemData oldData, HonamiStoryEquipItemData newData, Action callBack)
	{
		List<IHonamiStoryAttrData> data = this.CombineDataList(oldData, newData);
		this.AttrLayout.RefreshByData(data, delegate
		{
			Action callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2();
		}, false);
	}

	// Token: 0x0600F139 RID: 61753 RVA: 0x0039F618 File Offset: 0x0039D818
	public void AddHotKey(UUIItem hotKeyItem)
	{
		hotKeyItem.SetUIActive(true);
		hotKeyItem.SetUIParent(base.GetItem(2), false);
	}

	// Token: 0x0600F13A RID: 61754 RVA: 0x0039F630 File Offset: 0x0039D830
	public void SetAutoLocation(UUIItem gridItem)
	{
		global::Vector adaptiveTipsPosition = LguiUtil.Instance.GetAdaptiveTipsPosition(gridItem, this.RootItem, 0f);
		float width = base.GetItem(4).Width;
		adaptiveTipsPosition.X += (double)width;
		adaptiveTipsPosition.Z += (double)(gridItem.Height / 2f);
		UUIItem rootItem = this.RootItem;
		FVector fvector = adaptiveTipsPosition.ToUeVectorOld();
		rootItem.SetUIWorldLocation(fvector);
	}

	// Token: 0x04006F8E RID: 28558
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryAttrItem, IHonamiStoryAttrData> AttrLayout;

	// Token: 0x04006F8F RID: 28559
	private readonly Dictionary<int, IHonamiStoryAttrData> PropertyMap = new Dictionary<int, IHonamiStoryAttrData>();

	// Token: 0x02008479 RID: 33913
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402B1CC RID: 176588
		PnlAttrList,
		// Token: 0x0402B1CD RID: 176589
		PnlAttrItem,
		// Token: 0x0402B1CE RID: 176590
		PnlKeyDown,
		// Token: 0x0402B1CF RID: 176591
		PnlKeyUp,
		// Token: 0x0402B1D0 RID: 176592
		PnlLocalOffsetX
	}
}
