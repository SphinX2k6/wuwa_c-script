using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015DE RID: 5598
	public static class ActionParamsExtensions
	{
		// Token: 0x06007E5C RID: 32348 RVA: 0x0012DBE4 File Offset: 0x0012BDE4
		public static IReadOnlyList<ICharacterGroupNew> GetCharacterGroupNew(this ActionParams p)
		{
			AddTrialCharacter addTrialCharacter = p as AddTrialCharacter;
			List<ICharacterGroupNew> characterGroupNew;
			if (addTrialCharacter == null)
			{
				UpdateTrialCharacter updateTrialCharacter = p as UpdateTrialCharacter;
				if (updateTrialCharacter == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的CharacterGroupNew的字段失败");
				}
				characterGroupNew = updateTrialCharacter.CharacterGroupNew;
			}
			else
			{
				characterGroupNew = addTrialCharacter.CharacterGroupNew;
			}
			return characterGroupNew;
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x0012DC3C File Offset: 0x0012BE3C
		public static IReadOnlyList<IEnableLevelPlayConfig> GetConfigs(this ActionParams p)
		{
			EnableLevelPlay enableLevelPlay = p as EnableLevelPlay;
			List<IEnableLevelPlayConfig> configs;
			if (enableLevelPlay == null)
			{
				ServerForceEnableLevelPlay serverForceEnableLevelPlay = p as ServerForceEnableLevelPlay;
				if (serverForceEnableLevelPlay == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的Configs的字段失败");
				}
				configs = serverForceEnableLevelPlay.Configs;
			}
			else
			{
				configs = enableLevelPlay.Configs;
			}
			return configs;
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x0012DC94 File Offset: 0x0012BE94
		public static IReadOnlyList<IItemData> GetItems(this ActionParams p)
		{
			FixGetItem fixGetItem = p as FixGetItem;
			List<IItemData> items;
			if (fixGetItem == null)
			{
				GetItem getItem = p as GetItem;
				if (getItem == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的Items的字段失败");
				}
				items = getItem.Items;
			}
			else
			{
				items = fixGetItem.Items;
			}
			return items;
		}
	}
}
