using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055AE RID: 21934
	public class FishingLevelUpData
	{
		// Token: 0x06036608 RID: 222728 RVA: 0x00F2EC5C File Offset: 0x00F2CE5C
		public FishingLevelUpData(int lastExp, int currentExp)
		{
			this.InitExpMaxList();
			this.AddExp = currentExp - lastExp;
			this.LastLevel = this.GetLevelByExp(lastExp);
			this.CurrentLevel = this.GetLevelByExp(currentExp);
			this.LastExp = lastExp - this.ExpMaxList[this.LastLevel - 1];
		}

		// Token: 0x06036609 RID: 222729 RVA: 0x00F2ECC0 File Offset: 0x00F2CEC0
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

		// Token: 0x0603660A RID: 222730 RVA: 0x00F2ED28 File Offset: 0x00F2CF28
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

		// Token: 0x0603660B RID: 222731 RVA: 0x00F2ED68 File Offset: 0x00F2CF68
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

		// Token: 0x0603660C RID: 222732 RVA: 0x00F2EDD6 File Offset: 0x00F2CFD6
		public bool IsLevelUp()
		{
			return this.CurrentLevel > this.LastLevel;
		}

		// Token: 0x0603660D RID: 222733 RVA: 0x00F2EDE6 File Offset: 0x00F2CFE6
		public bool IsCurrentLevelMax()
		{
			return this.CurrentLevel == this.ExpMaxList.Count;
		}

		// Token: 0x0401CB07 RID: 117511
		public readonly int AddExp;

		// Token: 0x0401CB08 RID: 117512
		public readonly int LastExp;

		// Token: 0x0401CB09 RID: 117513
		public readonly int LastLevel;

		// Token: 0x0401CB0A RID: 117514
		public int CurrentLevel;

		// Token: 0x0401CB0B RID: 117515
		[Nullable(1)]
		private readonly List<int> ExpMaxList = new List<int>();
	}
}
