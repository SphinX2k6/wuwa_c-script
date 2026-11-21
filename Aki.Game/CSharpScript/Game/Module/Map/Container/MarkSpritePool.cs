using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Container
{
	// Token: 0x02004569 RID: 17769
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public static class MarkSpritePool
	{
		// Token: 0x0602CC67 RID: 183399 RVA: 0x00C89F58 File Offset: 0x00C88158
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

		// Token: 0x0602CC68 RID: 183400 RVA: 0x00C89F8C File Offset: 0x00C8818C
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

		// Token: 0x0602CC69 RID: 183401 RVA: 0x00C8A018 File Offset: 0x00C88218
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

		// Token: 0x0602CC6A RID: 183402 RVA: 0x00C8A0C4 File Offset: 0x00C882C4
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

		// Token: 0x0602CC6B RID: 183403 RVA: 0x00C8A1B8 File Offset: 0x00C883B8
		public static void Dispose()
		{
			MarkSpritePool.ComponentAndSpriteRefMap.Clear();
			MarkSpritePool.SpriteHandleCacheMap.Clear();
		}

		// Token: 0x04017FF6 RID: 98294
		public const int MAX_SPRITE_HANDLE_CACHE_TIME = 10000;

		// Token: 0x04017FF7 RID: 98295
		private static readonly Dictionary<int, HashSet<string>> ComponentAndSpriteRefMap = new Dictionary<int, HashSet<string>>();

		// Token: 0x04017FF8 RID: 98296
		private static readonly Dictionary<string, IMarkSpritePoolObj> SpriteHandleCacheMap = new Dictionary<string, IMarkSpritePoolObj>();

		// Token: 0x04017FF9 RID: 98297
		private static readonly List<string> ToRemoveElements = new List<string>();
	}
}
