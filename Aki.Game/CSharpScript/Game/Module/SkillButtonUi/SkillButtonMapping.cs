using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C0A RID: 19466
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonMapping<[Nullable(2)] T>
	{
		// Token: 0x06032613 RID: 206355 RVA: 0x00BBA750 File Offset: 0x00BB8950
		public void Add(IEnumerable<T> keys, SkillButtonData skillButtonData)
		{
			foreach (T key in keys)
			{
				HashSet<SkillButtonData> hashSet;
				if (this.SkillButtonMap.TryGetValue(key, out hashSet))
				{
					hashSet.Add(skillButtonData);
				}
				else
				{
					hashSet = new HashSet<SkillButtonData>();
					hashSet.Add(skillButtonData);
					this.SkillButtonMap[key] = hashSet;
				}
			}
		}

		// Token: 0x06032614 RID: 206356 RVA: 0x00BBA7C8 File Offset: 0x00BB89C8
		public void AddSingle(T key, SkillButtonData skillButtonData)
		{
			HashSet<SkillButtonData> hashSet;
			if (this.SkillButtonMap.TryGetValue(key, out hashSet))
			{
				hashSet.Add(skillButtonData);
				return;
			}
			hashSet = new HashSet<SkillButtonData>();
			hashSet.Add(skillButtonData);
			this.SkillButtonMap[key] = hashSet;
		}

		// Token: 0x06032615 RID: 206357 RVA: 0x00BBA80C File Offset: 0x00BB8A0C
		public void RemoveSingle(T key, SkillButtonData skillButtonData)
		{
			HashSet<SkillButtonData> hashSet;
			if (this.SkillButtonMap.TryGetValue(key, out hashSet))
			{
				hashSet.Remove(skillButtonData);
			}
		}

		// Token: 0x06032616 RID: 206358 RVA: 0x00BBA834 File Offset: 0x00BB8A34
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> Get(T key)
		{
			HashSet<SkillButtonData> result;
			if (!this.SkillButtonMap.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06032617 RID: 206359 RVA: 0x00BBA854 File Offset: 0x00BB8A54
		public void Clear()
		{
			this.SkillButtonMap.Clear();
		}

		// Token: 0x0401ACF0 RID: 109808
		private readonly Dictionary<T, HashSet<SkillButtonData>> SkillButtonMap = new Dictionary<T, HashSet<SkillButtonData>>();
	}
}
