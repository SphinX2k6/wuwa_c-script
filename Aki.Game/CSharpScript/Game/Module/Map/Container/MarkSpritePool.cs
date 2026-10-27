using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Container
{
	// Token: 0x02005593 RID: 21907
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public static class MarkSpritePool
	{
		// Token: 0x06037D69 RID: 228713 RVA: 0x00D3C210 File Offset: 0x00D3A410
		[return: Nullable(2)]
		public static ULGUISpriteData_BaseObject Get(int componentId, string spritePath)
		{
			IMarkSpritePoolObj markSpritePoolObj;
			if (MarkSpritePool.SpriteHandleCacheMap.TryGetValue(spritePath, out markSpritePoolObj))
			{
				MarkSpritePool.Ref(componentId, spritePath, markSpritePoolObj.Obj);
				return markSpritePoolObj.Obj;
			}
			return null;
		}

		// Token: 0x06037D6A RID: 228714 RVA: 0x00D3C244 File Offset: 0x00D3A444
		public static void Ref(int componentId, string spritePath, ULGUISpriteData_BaseObject sprite)
		{
			HashSet<string> hashSet;
			if (!MarkSpritePool.ComponentAndSpriteRefMap.TryGetValue(componentId, out hashSet))
			{
				hashSet = new HashSet<string>();
				MarkSpritePool.ComponentAndSpriteRefMap[componentId] = hashSet;
			}
			hashSet.Add(spritePath);
			IMarkSpritePoolObj markSpritePoolObj;
			if (MarkSpritePool.SpriteHandleCacheMap.TryGetValue(spritePath, out markSpritePoolObj))
			{
				IMarkSpritePoolObj markSpritePoolObj2 = markSpritePoolObj;
				int @ref = markSpritePoolObj2.Ref;
				markSpritePoolObj2.Ref = @ref + 1;
				return;
			}
			markSpritePoolObj = new MarkSpritePoolObj
			{
				SpritePath = spritePath,
				RecycleTimeStamp = 0.0,
				Obj = sprite,
				Ref = 1
			};
			MarkSpritePool.SpriteHandleCacheMap[spritePath] = markSpritePoolObj;
		}

		// Token: 0x06037D6B RID: 228715 RVA: 0x00D3C2D0 File Offset: 0x00D3A4D0
		public static void UnRef(int componentId)
		{
			HashSet<string> hashSet;
			if (!MarkSpritePool.ComponentAndSpriteRefMap.TryGetValue(componentId, out hashSet))
			{
				return;
			}
			foreach (string key in hashSet)
			{
				IMarkSpritePoolObj markSpritePoolObj;
				if (MarkSpritePool.SpriteHandleCacheMap.TryGetValue(key, out markSpritePoolObj))
				{
					IMarkSpritePoolObj markSpritePoolObj2 = markSpritePoolObj;
					int @ref = markSpritePoolObj2.Ref;
					markSpritePoolObj2.Ref = @ref - 1;
					if (markSpritePoolObj.Ref <= 0)
					{
						markSpritePoolObj.RecycleTimeStamp = Time.Instance.ServerTimeStamp;
						MarkSpritePool.SpriteHandleCacheMap.Remove(key);
					}
				}
			}
			MarkSpritePool.ComponentAndSpriteRefMap.Remove(componentId);
		}

		// Token: 0x06037D6C RID: 228716 RVA: 0x00D3C37C File Offset: 0x00D3A57C
		public static void Tick()
		{
			MarkSpritePool.ToRemoveElements.Clear();
			foreach (IMarkSpritePoolObj markSpritePoolObj in MarkSpritePool.SpriteHandleCacheMap.Values)
			{
				double num = Time.Instance.ServerTimeStamp - markSpritePoolObj.RecycleTimeStamp;
				bool flag;
				if (markSpritePoolObj.Ref > 0 || num <= 10000.0)
				{
					ULGUISpriteData_BaseObject obj = markSpritePoolObj.Obj;
					flag = (obj == null || !obj.IsValid());
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					MarkSpritePool.ToRemoveElements.Add(markSpritePoolObj.SpritePath);
				}
			}
			foreach (string key in MarkSpritePool.ToRemoveElements)
			{
				MarkSpritePool.SpriteHandleCacheMap.Remove(key);
			}
		}

		// Token: 0x06037D6D RID: 228717 RVA: 0x00D3C470 File Offset: 0x00D3A670
		public static void Dispose()
		{
			MarkSpritePool.ComponentAndSpriteRefMap.Clear();
			MarkSpritePool.SpriteHandleCacheMap.Clear();
		}

		// Token: 0x0401D56B RID: 120171
		public const int MAX_SPRITE_HANDLE_CACHE_TIME = 10000;

		// Token: 0x0401D56C RID: 120172
		private static readonly Dictionary<int, HashSet<string>> ComponentAndSpriteRefMap = new Dictionary<int, HashSet<string>>();

		// Token: 0x0401D56D RID: 120173
		private static readonly Dictionary<string, IMarkSpritePoolObj> SpriteHandleCacheMap = new Dictionary<string, IMarkSpritePoolObj>();

		// Token: 0x0401D56E RID: 120174
		private static readonly List<string> ToRemoveElements = new List<string>();
	}
}
