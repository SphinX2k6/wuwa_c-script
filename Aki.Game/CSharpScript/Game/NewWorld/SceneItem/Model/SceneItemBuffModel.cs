using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x020071D8 RID: 29144
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SceneItemBuffModel : ModelBase
	{
		// Token: 0x06047541 RID: 292161 RVA: 0x0122344C File Offset: 0x0122164C
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

		// Token: 0x06047542 RID: 292162 RVA: 0x012234A8 File Offset: 0x012216A8
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

		// Token: 0x06047543 RID: 292163 RVA: 0x0122356E File Offset: 0x0122176E
		public bool RemoveAll(int targetEntityId)
		{
			return this.SceneItemBuffCacheMap.Remove(targetEntityId);
		}

		// Token: 0x06047544 RID: 292164 RVA: 0x0122357C File Offset: 0x0122177C
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

		// Token: 0x06047545 RID: 292165 RVA: 0x012235C4 File Offset: 0x012217C4
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

		// Token: 0x17009DF2 RID: 40434
		// (get) Token: 0x06047546 RID: 292166 RVA: 0x01223668 File Offset: 0x01221868
		public static SceneItemBuffModel Instance
		{
			get
			{
				return SceneItemBuffModel._Instance;
			}
		}

		// Token: 0x06047547 RID: 292167 RVA: 0x0122366F File Offset: 0x0122186F
		public static SceneItemBuffModel GetOrCreateInstance()
		{
			if (SceneItemBuffModel._Instance == null)
			{
				SceneItemBuffModel.CreateInstance();
			}
			return SceneItemBuffModel._Instance;
		}

		// Token: 0x06047548 RID: 292168 RVA: 0x01223683 File Offset: 0x01221883
		public static bool CreateInstance()
		{
			if (SceneItemBuffModel._Instance != null)
			{
				return true;
			}
			SceneItemBuffModel._Instance = new SceneItemBuffModel();
			return true;
		}

		// Token: 0x06047549 RID: 292169 RVA: 0x01223699 File Offset: 0x01221899
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604754A RID: 292170 RVA: 0x0122369B File Offset: 0x0122189B
		public static void ResetStaticDefaultValue()
		{
			SceneItemBuffModel._Instance = null;
		}

		// Token: 0x0604754B RID: 292171 RVA: 0x012236A3 File Offset: 0x012218A3
		static SceneItemBuffModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemBuffModel.CreateStaticDefaultValue), new Action(SceneItemBuffModel.ResetStaticDefaultValue));
		}

		// Token: 0x04025810 RID: 153616
		private readonly Dictionary<int, Dictionary<long, List<int>>> SceneItemBuffCacheMap = new Dictionary<int, Dictionary<long, List<int>>>();

		// Token: 0x04025811 RID: 153617
		[Nullable(2)]
		private static SceneItemBuffModel _Instance;
	}
}
