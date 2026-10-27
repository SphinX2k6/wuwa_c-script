using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006630 RID: 26160
	public class FishingLevelUpData
	{
		// Token: 0x06041943 RID: 268611 RVA: 0x00FE7BA4 File Offset: 0x00FE5DA4
		public FishingLevelUpData(int lastExp, int currentExp)
		{
			this.InitExpMaxList();
			this.AddExp = currentExp - lastExp;
			this.LastLevel = this.GetLevelByExp(lastExp);
			this.CurrentLevel = this.GetLevelByExp(currentExp);
			this.LastExp = lastExp - this.ExpMaxList[this.LastLevel - 1];
		}

		// Token: 0x06041944 RID: 268612 RVA: 0x00FE7C08 File Offset: 0x00FE5E08
		private void InitExpMaxList()
		{
			FishingConfig instance = FishingConfig.Instance;
			IReadOnlyList<FishingReputation> readOnlyList = (instance != null) ? instance.GetAllFishingReputation() : null;
			if (readOnlyList != null)
			{
				foreach (FishingReputation fishingReputation in readOnlyList)
				{
					this.ExpMaxList.Add(fishingReputation.Exp);
				}
			}
		}

		// Token: 0x06041945 RID: 268613 RVA: 0x00FE7C70 File Offset: 0x00FE5E70
		private int GetLevelByExp(int exp)
		{
			int result = 0;
			int i = 0;
			int count = this.ExpMaxList.Count;
			while (i < count)
			{
				int num = this.ExpMaxList[i];
				if (exp < num)
				{
					return result;
				}
				result = i + 1;
				i++;
			}
			return result;
		}

		// Token: 0x06041946 RID: 268614 RVA: 0x00FE7CB0 File Offset: 0x00FE5EB0
		public int GetMaxExpByLevel(int level)
		{
			if (level >= this.ExpMaxList.Count)
			{
				return this.ExpMaxList[this.ExpMaxList.Count - 1] - this.ExpMaxList[this.ExpMaxList.Count - 2];
			}
			if (level <= 0)
			{
				return 0;
			}
			return this.ExpMaxList[level] - this.ExpMaxList[level - 1];
		}

		// Token: 0x06041947 RID: 268615 RVA: 0x00FE7D1E File Offset: 0x00FE5F1E
		public bool IsLevelUp()
		{
			return this.CurrentLevel > this.LastLevel;
		}

		// Token: 0x06041948 RID: 268616 RVA: 0x00FE7D2E File Offset: 0x00FE5F2E
		public bool IsCurrentLevelMax()
		{
			return this.CurrentLevel == this.ExpMaxList.Count;
		}

		// Token: 0x040221D6 RID: 139734
		public readonly int AddExp;

		// Token: 0x040221D7 RID: 139735
		public readonly int LastExp;

		// Token: 0x040221D8 RID: 139736
		public readonly int LastLevel;

		// Token: 0x040221D9 RID: 139737
		public int CurrentLevel;

		// Token: 0x040221DA RID: 139738
		[Nullable(1)]
		private readonly List<int> ExpMaxList = new List<int>();
	}
}
