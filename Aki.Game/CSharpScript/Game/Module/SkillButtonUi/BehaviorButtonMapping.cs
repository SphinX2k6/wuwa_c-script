using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004BFA RID: 19450
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorButtonMapping<T>
	{
		// Token: 0x060324C9 RID: 206025 RVA: 0x00BB0290 File Offset: 0x00BAE490
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

		// Token: 0x060324CA RID: 206026 RVA: 0x00BB0308 File Offset: 0x00BAE508
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

		// Token: 0x060324CB RID: 206027 RVA: 0x00BB034C File Offset: 0x00BAE54C
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

		// Token: 0x060324CC RID: 206028 RVA: 0x00BB036C File Offset: 0x00BAE56C
		public IEnumerable<T> GetAllKey()
		{
			return this.BehaviorButtonMap.Keys;
		}

		// Token: 0x060324CD RID: 206029 RVA: 0x00BB0379 File Offset: 0x00BAE579
		public void Clear()
		{
			this.BehaviorButtonMap.Clear();
		}

		// Token: 0x0401AC16 RID: 109590
		private readonly Dictionary<T, HashSet<BehaviorButtonData>> BehaviorButtonMap = new Dictionary<T, HashSet<BehaviorButtonData>>();
	}
}
