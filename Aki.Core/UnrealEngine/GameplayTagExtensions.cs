using System;

namespace UnrealEngine
{
	// Token: 0x02000114 RID: 276
	public static class GameplayTagExtensions
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x0003423F File Offset: 0x0003243F
		public static int TagId(this FGameplayTag tag)
		{
			return GameplayTagCache.GetOrCreateTagId(tag.TagName);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0003424C File Offset: 0x0003244C
		public static FName OriginalTagName(this FGameplayTag tag)
		{
			return GameplayTagCache.GetOrCreateOriginalTagName(tag.TagName);
		}
	}
}
