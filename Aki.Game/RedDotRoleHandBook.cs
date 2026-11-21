using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200298C RID: 10636
public class RedDotRoleHandBook : RedDotBase
{
	// Token: 0x0601AA57 RID: 109143 RVA: 0x00832235 File Offset: 0x00830435
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotStart, new Action(base.EventCheck));
	}

	// Token: 0x0601AA58 RID: 109144 RVA: 0x0083226F File Offset: 0x0083046F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotStart, new Action(base.EventCheck));
	}

	// Token: 0x0601AA59 RID: 109145 RVA: 0x008322AC File Offset: 0x008304AC
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
