using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FB8 RID: 12216
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGemData
	{
		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x0601CFF8 RID: 118776 RVA: 0x008DB165 File Offset: 0x008D9365
		// (set) Token: 0x0601CFF9 RID: 118777 RVA: 0x008DB16D File Offset: 0x008D936D
		public List<EGemType> CurrentGemBag { get; set; } = new List<EGemType>();

		// Token: 0x0601CFFA RID: 118778 RVA: 0x008DB176 File Offset: 0x008D9376
		public void Reset()
		{
			this.CollectedGems.Clear();
			this.SpawnCounts.Clear();
			this.CurrentGemBag.Clear();
		}

		// Token: 0x0601CFFB RID: 118779 RVA: 0x008DB199 File Offset: 0x008D9399
		public Dictionary<EGemType, int> GetCurrentGem()
		{
			return this.CollectedGems;
		}

		// Token: 0x0601CFFC RID: 118780 RVA: 0x008DB1A1 File Offset: 0x008D93A1
		public int GetSpawnCount(EGemType type)
		{
			return this.SpawnCounts.GetValueOrDefault(type, 0);
		}

		// Token: 0x0601CFFD RID: 118781 RVA: 0x008DB1B0 File Offset: 0x008D93B0
		public void SetSpawnCount(EGemType type, int count)
		{
			this.SpawnCounts[type] = count;
		}

		// Token: 0x0601CFFE RID: 118782 RVA: 0x008DB1C0 File Offset: 0x008D93C0
		public void AddGem(EGemType type, int count)
		{
			int valueOrDefault = this.CollectedGems.GetValueOrDefault(type, 0);
			this.CollectedGems[type] = valueOrDefault + count;
		}

		// Token: 0x0601CFFF RID: 118783 RVA: 0x008DB1EA File Offset: 0x008D93EA
		public int GetGem(EGemType type)
		{
			return this.CollectedGems.GetValueOrDefault(type, 0);
		}

		// Token: 0x0601D000 RID: 118784 RVA: 0x008DB1F9 File Offset: 0x008D93F9
		public TetrisGemSnapshot CreateSnapshot()
		{
			return new TetrisGemSnapshot
			{
				CollectedGems = new Dictionary<EGemType, int>(this.CollectedGems),
				CurrentGemBag = this.CurrentGemBag.ToList<EGemType>(),
				SpawnCounts = new Dictionary<EGemType, int>(this.SpawnCounts)
			};
		}

		// Token: 0x0601D001 RID: 118785 RVA: 0x008DB234 File Offset: 0x008D9434
		public void RestoreFromSnapshot(in TetrisGemSnapshot snapshot)
		{
			this.CollectedGems.Clear();
			foreach (KeyValuePair<EGemType, int> keyValuePair in snapshot.CollectedGems)
			{
				this.CollectedGems.Add(keyValuePair.Key, keyValuePair.Value);
			}
			this.CurrentGemBag = snapshot.CurrentGemBag.ToList<EGemType>();
			this.SpawnCounts.Clear();
			foreach (KeyValuePair<EGemType, int> keyValuePair2 in snapshot.SpawnCounts)
			{
				this.SpawnCounts.Add(keyValuePair2.Key, keyValuePair2.Value);
			}
		}

		// Token: 0x0400F470 RID: 62576
		private readonly Dictionary<EGemType, int> CollectedGems = new Dictionary<EGemType, int>();

		// Token: 0x0400F471 RID: 62577
		private readonly Dictionary<EGemType, int> SpawnCounts = new Dictionary<EGemType, int>();
	}
}
