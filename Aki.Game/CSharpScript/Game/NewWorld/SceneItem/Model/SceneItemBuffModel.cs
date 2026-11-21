using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x0200628D RID: 25229
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SceneItemBuffModel : ModelBase
	{
		// Token: 0x0603CE43 RID: 249411 RVA: 0x0117D280 File Offset: 0x0117B480
		public bool Add(int targetEntityId, long buffId, int producerEntityId)
		{
			Dictionary<long, List<int>> dictionary;
			if (!this.SceneItemBuffCacheMap.TryGetValue(targetEntityId, out dictionary))
			{
				dictionary = new Dictionary<long, List<int>>();
				this.SceneItemBuffCacheMap.Add(targetEntityId, dictionary);
			}
			List<int> list;
			if (!dictionary.TryGetValue(buffId, out list))
			{
				list = new List<int>();
				dictionary.Add(buffId, list);
			}
			if (!list.Contains(producerEntityId))
			{
				list.Add(producerEntityId);
				return true;
			}
			return false;
		}

		// Token: 0x0603CE44 RID: 249412 RVA: 0x0117D2DC File Offset: 0x0117B4DC
		public List<int> Remove(int targetEntityId, long buffId, int deltaCount, int? producerEntityId = null)
		{
			List<int> result = new List<int>();
			Dictionary<long, List<int>> dictionary;
			if (this.SceneItemBuffCacheMap.TryGetValue(targetEntityId, out dictionary))
			{
				List<int> list;
				if (dictionary.TryGetValue(buffId, out list))
				{
					if (producerEntityId != null)
					{
						int? num = producerEntityId;
						int num2 = 0;
						if (!(num.GetValueOrDefault() == num2 & num != null))
						{
							int num3 = list.IndexOf(producerEntityId.Value);
							if (num3 > -1)
							{
								result = list.Slice(num3, deltaCount);
								list.RemoveRange(num3, deltaCount);
								goto IL_93;
							}
							goto IL_93;
						}
					}
					int num4 = (deltaCount == -1) ? list.Count : deltaCount;
					result = list.Slice(0, num4);
					list.RemoveRange(0, num4);
					IL_93:
					if (list.Count == 0)
					{
						dictionary.Remove(buffId);
					}
				}
				if (dictionary.Count == 0)
				{
					this.SceneItemBuffCacheMap.Remove(targetEntityId);
				}
			}
			return result;
		}

		// Token: 0x0603CE45 RID: 249413 RVA: 0x0117D3A2 File Offset: 0x0117B5A2
		public bool RemoveAll(int targetEntityId)
		{
			return this.SceneItemBuffCacheMap.Remove(targetEntityId);
		}

		// Token: 0x0603CE46 RID: 249414 RVA: 0x0117D3B0 File Offset: 0x0117B5B0
		public bool Switch(int newTargetEntityId, int oldTargetEntityId)
		{
			Dictionary<long, List<int>> value;
			if (this.SceneItemBuffCacheMap.ContainsKey(newTargetEntityId) || !this.SceneItemBuffCacheMap.TryGetValue(oldTargetEntityId, out value))
			{
				return false;
			}
			this.SceneItemBuffCacheMap.Add(newTargetEntityId, value);
			this.SceneItemBuffCacheMap.Remove(oldTargetEntityId);
			return true;
		}

		// Token: 0x0603CE47 RID: 249415 RVA: 0x0117D3F8 File Offset: 0x0117B5F8
		[NullableContext(2)]
		public List<int> GetSceneItemIds(int targetEntityId)
		{
			Dictionary<long, List<int>> dictionary;
			if (!this.SceneItemBuffCacheMap.TryGetValue(targetEntityId, out dictionary))
			{
				return null;
			}
			List<int> list = new List<int>();
			foreach (List<int> list2 in dictionary.Values)
			{
				foreach (int item in list2)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x17007349 RID: 29513
		// (get) Token: 0x0603CE48 RID: 249416 RVA: 0x0117D49C File Offset: 0x0117B69C
		public static SceneItemBuffModel Instance
		{
			get
			{
				return SceneItemBuffModel._Instance;
			}
		}

		// Token: 0x0603CE49 RID: 249417 RVA: 0x0117D4A3 File Offset: 0x0117B6A3
		public static SceneItemBuffModel GetOrCreateInstance()
		{
			if (SceneItemBuffModel._Instance == null)
			{
				SceneItemBuffModel.CreateInstance();
			}
			return SceneItemBuffModel._Instance;
		}

		// Token: 0x0603CE4A RID: 249418 RVA: 0x0117D4B7 File Offset: 0x0117B6B7
		public static bool CreateInstance()
		{
			if (SceneItemBuffModel._Instance != null)
			{
				return true;
			}
			SceneItemBuffModel._Instance = new SceneItemBuffModel();
			return true;
		}

		// Token: 0x0603CE4B RID: 249419 RVA: 0x0117D4CD File Offset: 0x0117B6CD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CE4C RID: 249420 RVA: 0x0117D4CF File Offset: 0x0117B6CF
		public static void ResetStaticDefaultValue()
		{
			SceneItemBuffModel._Instance = null;
		}

		// Token: 0x0603CE4D RID: 249421 RVA: 0x0117D4D7 File Offset: 0x0117B6D7
		static SceneItemBuffModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemBuffModel.CreateStaticDefaultValue), new Action(SceneItemBuffModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402047F RID: 132223
		private readonly Dictionary<int, Dictionary<long, List<int>>> SceneItemBuffCacheMap = new Dictionary<int, Dictionary<long, List<int>>>();

		// Token: 0x04020480 RID: 132224
		[Nullable(2)]
		private static SceneItemBuffModel _Instance;
	}
}
