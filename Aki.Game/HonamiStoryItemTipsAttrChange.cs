using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200136B RID: 4971
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemTipsAttrChange : UiPanelBase
{
	// Token: 0x0600C553 RID: 50515 RVA: 0x003AAE44 File Offset: 0x003A9044
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

	// Token: 0x0600C554 RID: 50516 RVA: 0x003AAECA File Offset: 0x003A90CA
	protected override void OnStart()
	{
		this.AttrLayout = new GenericLayout<HonamiStoryAttrItem, IHonamiStoryAttrData>(base.GetVerticalLayout(0), new Func<HonamiStoryAttrItem>(this.InitAttrItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600C555 RID: 50517 RVA: 0x003AAEFD File Offset: 0x003A90FD
	private HonamiStoryAttrItem InitAttrItem()
	{
		return new HonamiStoryAttrItem();
	}

	// Token: 0x0600C556 RID: 50518 RVA: 0x003AAF04 File Offset: 0x003A9104
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

	// Token: 0x0600C557 RID: 50519 RVA: 0x003AB198 File Offset: 0x003A9398
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

	// Token: 0x0600C558 RID: 50520 RVA: 0x003AB1D4 File Offset: 0x003A93D4
	public void AddHotKey(UUIItem hotKeyItem)
	{
		hotKeyItem.SetUIActive(true);
		hotKeyItem.SetUIParent(base.GetItem(2), false);
	}

	// Token: 0x0600C559 RID: 50521 RVA: 0x003AB1EC File Offset: 0x003A93EC
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

	// Token: 0x0400706F RID: 28783
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryAttrItem, IHonamiStoryAttrData> AttrLayout;

	// Token: 0x04007070 RID: 28784
	private readonly Dictionary<int, IHonamiStoryAttrData> PropertyMap = new Dictionary<int, IHonamiStoryAttrData>();

	// Token: 0x020075FE RID: 30206
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x040264F0 RID: 156912
		PnlAttrList,
		// Token: 0x040264F1 RID: 156913
		PnlAttrItem,
		// Token: 0x040264F2 RID: 156914
		PnlKeyDown,
		// Token: 0x040264F3 RID: 156915
		PnlKeyUp,
		// Token: 0x040264F4 RID: 156916
		PnlLocalOffsetX
	}
}
