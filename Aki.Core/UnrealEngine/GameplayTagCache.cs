using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;

namespace UnrealEngine
{
	// Token: 0x02000115 RID: 277
	public class GameplayTagCache : IStaticVariableResetter
	{
		// Token: 0x06000A66 RID: 2662 RVA: 0x00034259 File Offset: 0x00032459
		static GameplayTagCache()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameplayTagCache.CreateStaticDefaultValue), new Action(GameplayTagCache.ResetStaticDefaultValue));
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00034278 File Offset: 0x00032478
		public static void CreateStaticDefaultValue()
		{
			GameplayTagCache.TagIdCache = new Dictionary<FName, int>();
			GameplayTagCache.OriginalTagNameCache = new Dictionary<FName, FName>();
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0003428E File Offset: 0x0003248E
		public static void ResetStaticDefaultValue()
		{
			GameplayTagCache.TagIdCache = null;
			GameplayTagCache.OriginalTagNameCache = null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0003429C File Offset: 0x0003249C
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

		// Token: 0x06000A6A RID: 2666 RVA: 0x000342D8 File Offset: 0x000324D8
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

		// Token: 0x040006A8 RID: 1704
		[Nullable(2)]
		private static Dictionary<FName, int> TagIdCache;

		// Token: 0x040006A9 RID: 1705
		[Nullable(2)]
		private static Dictionary<FName, FName> OriginalTagNameCache;
	}
}
