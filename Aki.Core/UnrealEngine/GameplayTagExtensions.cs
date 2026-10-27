using System;

namespace UnrealEngine
{
	// Token: 0x02000114 RID: 276
	public static class GameplayTagExtensions
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x00033863 File Offset: 0x00031A63
		public static int TagId(this FGameplayTag tag)
		{
			return GameplayTagCache.GetOrCreateTagId(tag.TagName);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00033870 File Offset: 0x00031A70
		public static FName OriginalTagName(this FGameplayTag tag)
		{
			return GameplayTagCache.GetOrCreateOriginalTagName(tag.TagName);
		}
	}
}
