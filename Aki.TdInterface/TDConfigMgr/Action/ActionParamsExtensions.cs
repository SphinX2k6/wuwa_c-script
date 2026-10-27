using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001485 RID: 5253
	[NullableContext(1)]
	[Nullable(0)]
	public static class ActionParamsExtensions
	{
		// Token: 0x0600778F RID: 30607 RVA: 0x0011EF98 File Offset: 0x0011D198
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

		// Token: 0x06007790 RID: 30608 RVA: 0x0011EFF0 File Offset: 0x0011D1F0
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

		// Token: 0x06007791 RID: 30609 RVA: 0x0011F048 File Offset: 0x0011D248
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
