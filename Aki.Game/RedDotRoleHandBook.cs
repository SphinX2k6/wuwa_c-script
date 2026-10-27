using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200341A RID: 13338
public class RedDotRoleHandBook : RedDotBase
{
	// Token: 0x0601CD5F RID: 118111 RVA: 0x0080BC71 File Offset: 0x00809E71
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotStart, new Action(base.EventCheck));
	}

	// Token: 0x0601CD60 RID: 118112 RVA: 0x0080BCAB File Offset: 0x00809EAB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotStart, new Action(base.EventCheck));
	}

	// Token: 0x0601CD61 RID: 118113 RVA: 0x0080BCE8 File Offset: 0x00809EE8
	protected override bool OnCheck(int uId = 0)
	{
		IReadOnlyList<RoleInfo> roleListByType = RoleConfig.Instance.GetRoleListByType(ERoleType.Common);
		int count = roleListByType.Count;
		for (int i = 0; i < count; i++)
		{
			RoleInfo roleInfo = roleListByType[i];
			int id = roleInfo.Id;
			if (roleInfo.PartyId != 9)
			{
				ItemInfo? itemInfo = null;
				int num = 0;
				using (Dictionary<int, int>.Enumerator enumerator = roleInfo.ExchangeConsume().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						KeyValuePair<int, int> keyValuePair = enumerator.Current;
						int key = keyValuePair.Key;
						int value = keyValuePair.Value;
						itemInfo = ItemConfig.Instance.GetConfig(key);
						num = value;
					}
				}
				object roleInstanceById = RoleModel.Instance.GetRoleInstanceById(id);
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemInfo.Value.Id, 0);
				if (roleInstanceById == null && itemCountByConfigId >= num)
				{
					return true;
				}
			}
		}
		return false;
	}
}
