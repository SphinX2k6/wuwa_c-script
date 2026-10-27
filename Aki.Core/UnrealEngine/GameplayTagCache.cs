using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;

namespace UnrealEngine
{
	// Token: 0x02000115 RID: 277
	public class GameplayTagCache : IStaticVariableResetter
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x0003387D File Offset: 0x00031A7D
		static GameplayTagCache()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameplayTagCache.CreateStaticDefaultValue), new Action(GameplayTagCache.ResetStaticDefaultValue));
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0003389C File Offset: 0x00031A9C
		public static void CreateStaticDefaultValue()
		{
			GameplayTagCache.TagIdCache = new Dictionary<FName, int>();
			GameplayTagCache.OriginalTagNameCache = new Dictionary<FName, FName>();
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000338B2 File Offset: 0x00031AB2
		public static void ResetStaticDefaultValue()
		{
			GameplayTagCache.TagIdCache = null;
			GameplayTagCache.OriginalTagNameCache = null;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000338C0 File Offset: 0x00031AC0
		public static int GetOrCreateTagId(FName tagName)
		{
			int num;
			if (!GameplayTagCache.TagIdCache.TryGetValue(tagName, out num))
			{
				num = UGASBPLibrary.FnvHash(tagName.ToString());
				GameplayTagCache.TagIdCache[tagName] = num;
			}
			return num;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000338FC File Offset: 0x00031AFC
		public static FName GetOrCreateOriginalTagName(FName tagName)
		{
			FName fname;
			if (!GameplayTagCache.OriginalTagNameCache.TryGetValue(tagName, out fname))
			{
				fname = GameplayTagsManager.GetOriginalTag(tagName);
				GameplayTagCache.OriginalTagNameCache[tagName] = fname;
			}
			return fname;
		}

		// Token: 0x0400069D RID: 1693
		[Nullable(2)]
		private static Dictionary<FName, int> TagIdCache;

		// Token: 0x0400069E RID: 1694
		[Nullable(2)]
		private static Dictionary<FName, FName> OriginalTagNameCache;
	}
}
