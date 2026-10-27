using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FF0 RID: 24560
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGemData
	{
		// Token: 0x0603E3A0 RID: 254880 RVA: 0x00F05CB6 File Offset: 0x00F03EB6
		public void Reset()
		{
			this.CollectedGems.Clear();
			this.SpawnCounts.Clear();
			this.CurrentGemBagInternal = new List<EGemType>();
		}

		// Token: 0x17009058 RID: 36952
		// (get) Token: 0x0603E3A1 RID: 254881 RVA: 0x00F05CD9 File Offset: 0x00F03ED9
		// (set) Token: 0x0603E3A2 RID: 254882 RVA: 0x00F05CE1 File Offset: 0x00F03EE1
		public List<EGemType> CurrentGemBag
		{
			get
			{
				return this.CurrentGemBagInternal;
			}
			set
			{
				this.CurrentGemBagInternal = value;
			}
		}

		// Token: 0x0603E3A3 RID: 254883 RVA: 0x00F05CEA File Offset: 0x00F03EEA
		public Dictionary<EGemType, int> GetCurrentGem()
		{
			return this.CollectedGems;
		}

		// Token: 0x0603E3A4 RID: 254884 RVA: 0x00F05CF4 File Offset: 0x00F03EF4
		public int GetSpawnCount(EGemType type)
		{
			int result;
			if (!this.SpawnCounts.TryGetValue(type, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0603E3A5 RID: 254885 RVA: 0x00F05D14 File Offset: 0x00F03F14
		public void SetSpawnCount(EGemType type, int count)
		{
			if (this.SpawnCounts.ContainsKey(type))
			{
				this.SpawnCounts[type] = count;
				return;
			}
			this.SpawnCounts.Add(type, count);
		}

		// Token: 0x0603E3A6 RID: 254886 RVA: 0x00F05D40 File Offset: 0x00F03F40
		public void AddGem(EGemType type, int count)
		{
			int num;
			if (!this.CollectedGems.TryGetValue(type, out num))
			{
				num = 0;
			}
			if (this.CollectedGems.ContainsKey(type))
			{
				this.CollectedGems[type] = num + 1;
				return;
			}
			this.CollectedGems.Add(type, num + 1);
		}

		// Token: 0x0603E3A7 RID: 254887 RVA: 0x00F05D8C File Offset: 0x00F03F8C
		public int GetGem(EGemType type)
		{
			int result;
			if (!this.CollectedGems.TryGetValue(type, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0603E3A8 RID: 254888 RVA: 0x00F05DAC File Offset: 0x00F03FAC
		public ITetrisGemSnapshot CreateSnapshot()
		{
			return new TetrisGemSnapshot
			{
				CollectedGems = new Dictionary<EGemType, int>(this.CollectedGems),
				CurrentGemBag = new List<EGemType>(this.CurrentGemBagInternal),
				SpawnCounts = new Dictionary<EGemType, int>(this.SpawnCounts)
			};
		}

		// Token: 0x0603E3A9 RID: 254889 RVA: 0x00F05DE8 File Offset: 0x00F03FE8
		public void RestoreFromSnapshot(ITetrisGemSnapshot snapshot)
		{
			this.CollectedGems.Clear();
			foreach (KeyValuePair<EGemType, int> keyValuePair in snapshot.CollectedGems)
			{
				this.CollectedGems.Add(keyValuePair.Key, keyValuePair.Value);
			}
			this.CurrentGemBagInternal = new List<EGemType>(snapshot.CurrentGemBag);
			this.SpawnCounts.Clear();
			foreach (KeyValuePair<EGemType, int> keyValuePair2 in snapshot.SpawnCounts)
			{
				this.SpawnCounts.Add(keyValuePair2.Key, keyValuePair2.Value);
			}
		}

		// Token: 0x0402080A RID: 133130
		private readonly Dictionary<EGemType, int> CollectedGems = new Dictionary<EGemType, int>();

		// Token: 0x0402080B RID: 133131
		private List<EGemType> CurrentGemBagInternal = new List<EGemType>();

		// Token: 0x0402080C RID: 133132
		private readonly Dictionary<EGemType, int> SpawnCounts = new Dictionary<EGemType, int>();
	}
}
