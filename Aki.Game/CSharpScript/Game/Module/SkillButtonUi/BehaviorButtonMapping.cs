using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BAB RID: 15275
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorButtonMapping<T>
	{
		// Token: 0x0602726F RID: 160367 RVA: 0x00AF48A4 File Offset: 0x00AF2AA4
		public void Add(IEnumerable<T> keys, BehaviorButtonData skillButtonData)
		{
			foreach (T key in keys)
			{
				HashSet<BehaviorButtonData> hashSet;
				if (this.BehaviorButtonMap.TryGetValue(key, out hashSet))
				{
					hashSet.Add(skillButtonData);
				}
				else
				{
					hashSet = new HashSet<BehaviorButtonData>();
					hashSet.Add(skillButtonData);
					this.BehaviorButtonMap[key] = hashSet;
				}
			}
		}

		// Token: 0x06027270 RID: 160368 RVA: 0x00AF491C File Offset: 0x00AF2B1C
		public void AddSingle(T key, BehaviorButtonData skillButtonData)
		{
			HashSet<BehaviorButtonData> hashSet;
			if (this.BehaviorButtonMap.TryGetValue(key, out hashSet))
			{
				hashSet.Add(skillButtonData);
				return;
			}
			hashSet = new HashSet<BehaviorButtonData>();
			hashSet.Add(skillButtonData);
			this.BehaviorButtonMap[key] = hashSet;
		}

		// Token: 0x06027271 RID: 160369 RVA: 0x00AF4960 File Offset: 0x00AF2B60
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<BehaviorButtonData> Get(T key)
		{
			HashSet<BehaviorButtonData> result;
			if (!this.BehaviorButtonMap.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06027272 RID: 160370 RVA: 0x00AF4980 File Offset: 0x00AF2B80
		public IEnumerable<T> GetAllKey()
		{
			return this.BehaviorButtonMap.Keys;
		}

		// Token: 0x06027273 RID: 160371 RVA: 0x00AF498D File Offset: 0x00AF2B8D
		public void Clear()
		{
			this.BehaviorButtonMap.Clear();
		}

		// Token: 0x04015570 RID: 87408
		private readonly Dictionary<T, HashSet<BehaviorButtonData>> BehaviorButtonMap = new Dictionary<T, HashSet<BehaviorButtonData>>();
	}
}
