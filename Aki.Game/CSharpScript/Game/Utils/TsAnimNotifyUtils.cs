using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02003480 RID: 13440
	public class TsAnimNotifyUtils
	{
		// Token: 0x06022496 RID: 140438 RVA: 0x009B7700 File Offset: 0x009B5900
		[NullableContext(1)]
		public static bool CheckTags(bool needAnyTag, TMap<FGameplayTag, bool> playNeedTags, Func<int, bool> tagCheckFunc)
		{
			int num = playNeedTags.Num();
			if (needAnyTag)
			{
				for (int i = 0; i < num; i++)
				{
					FGameplayTag key = playNeedTags.GetKey(i);
					bool flag = playNeedTags.Get(key);
					if (tagCheckFunc(key.TagId()) == flag)
					{
						return true;
					}
				}
				return false;
			}
			for (int j = 0; j < num; j++)
			{
				FGameplayTag key2 = playNeedTags.GetKey(j);
				bool flag2 = playNeedTags.Get(key2);
				if (tagCheckFunc(key2.TagId()) != flag2)
				{
					return false;
				}
			}
			return true;
		}
	}
}
