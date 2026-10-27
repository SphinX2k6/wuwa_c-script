using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D88 RID: 19848
	[NullableContext(1)]
	[Nullable(0)]
	public class AffixEntry
	{
		// Token: 0x060334E2 RID: 210146 RVA: 0x00BF994C File Offset: 0x00BF7B4C
		public AffixEntry(AffixEntry affixEntry)
		{
			this.Id = new int?(affixEntry.Id);
			this.IsUnlock = new bool?(affixEntry.IsUnlock);
			this.ElementDict = new Dictionary<int, int>();
			if (affixEntry.ElementDict != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in affixEntry.ElementDict)
				{
					int value = keyValuePair.Value;
					if (value != 0)
					{
						this.ElementDict.Add(keyValuePair.Key, value);
					}
				}
			}
		}

		// Token: 0x060334E3 RID: 210147 RVA: 0x00BF99EC File Offset: 0x00BF7BEC
		public List<ElementInfo> GetSortElementInfoArrayByCount(bool bIgnoreTotal = false)
		{
			int num = 9;
			List<ElementInfo> list = new List<ElementInfo>();
			foreach (KeyValuePair<int, int> keyValuePair in this.ElementDict)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (!bIgnoreTotal || key != num)
				{
					list.Add(new ElementInfo(key, value, null));
				}
			}
			list.Sort((ElementInfo a, ElementInfo b) => b.Count - a.Count);
			return list;
		}

		// Token: 0x060334E4 RID: 210148 RVA: 0x00BF9A94 File Offset: 0x00BF7C94
		public string GetAffixDesc()
		{
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RogueAffix? rogueAffix = (instance != null) ? instance.GetRogueAffixConfig(this.Id.Value) : null;
			RoguelikeModel instance2 = RoguelikeModel.Instance;
			string result;
			if (instance2 == null || instance2.GetDescModel() != EDescModel.SIMPLE)
			{
				if ((result = ((rogueAffix != null) ? rogueAffix.GetValueOrDefault().AffixDesc : null)) == null)
				{
					return "";
				}
			}
			else
			{
				result = (((rogueAffix != null) ? rogueAffix.GetValueOrDefault().AffixDescSimple : null) ?? "");
			}
			return result;
		}

		// Token: 0x0401B3AF RID: 111535
		public int? Id;

		// Token: 0x0401B3B0 RID: 111536
		public bool? IsUnlock;

		// Token: 0x0401B3B1 RID: 111537
		public readonly Dictionary<int, int> ElementDict;
	}
}
