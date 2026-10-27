using System;
using System.Collections.Generic;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F4F RID: 24399
	public static class WheelTowerUtil
	{
		// Token: 0x0603DFE0 RID: 253920 RVA: 0x00EF5E0C File Offset: 0x00EF400C
		public static NewTowerMedal? GetLastMedalConfigByGroupId(int groupId)
		{
			IReadOnlyList<NewTowerMedal> medalConfigListByGroupId = WheelTowerConfig.Instance.GetMedalConfigListByGroupId(groupId);
			if (medalConfigListByGroupId == null || medalConfigListByGroupId.Count == 0)
			{
				return null;
			}
			NewTowerMedal value = medalConfigListByGroupId[0];
			for (int i = 1; i < medalConfigListByGroupId.Count; i++)
			{
				if (medalConfigListByGroupId[i].Target > value.Target)
				{
					value = medalConfigListByGroupId[i];
				}
			}
			return new NewTowerMedal?(value);
		}
	}
}
