using System;
using System.Collections.Generic;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F36 RID: 20278
	public static class WheelTowerUtil
	{
		// Token: 0x06032F7B RID: 208763 RVA: 0x00E47B38 File Offset: 0x00E45D38
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
