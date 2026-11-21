using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BBB RID: 15291
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonMapping<[Nullable(2)] T>
	{
		// Token: 0x060273C3 RID: 160707 RVA: 0x00AFF2D4 File Offset: 0x00AFD4D4
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

		// Token: 0x060273C4 RID: 160708 RVA: 0x00AFF34C File Offset: 0x00AFD54C
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

		// Token: 0x060273C5 RID: 160709 RVA: 0x00AFF390 File Offset: 0x00AFD590
		public void RemoveSingle(T key, SkillButtonData skillButtonData)
		{
			HashSet<SkillButtonData> hashSet;
			if (this.SkillButtonMap.TryGetValue(key, out hashSet))
			{
				hashSet.Remove(skillButtonData);
			}
		}

		// Token: 0x060273C6 RID: 160710 RVA: 0x00AFF3B8 File Offset: 0x00AFD5B8
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

		// Token: 0x060273C7 RID: 160711 RVA: 0x00AFF3D8 File Offset: 0x00AFD5D8
		public void Clear()
		{
			this.SkillButtonMap.Clear();
		}

		// Token: 0x0401564C RID: 87628
		private readonly Dictionary<T, HashSet<SkillButtonData>> SkillButtonMap = new Dictionary<T, HashSet<SkillButtonData>>();
	}
}
