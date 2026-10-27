using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053CF RID: 21455
	[NullableContext(1)]
	[Nullable(0)]
	public class MingSuInstance
	{
		// Token: 0x06036D48 RID: 224584 RVA: 0x00CFC8BC File Offset: 0x00CFAABC
		public MingSuInstance(int id)
		{
			this.DragonPoolId = id;
			this.DragonPoolConfig = ConfigDragonPoolById.GetConfig(this.DragonPoolId, true);
			this.DragonPoolState = 0;
			this.DragonPoolLevel = 0;
			this.HadCoreCount = 0;
		}

		// Token: 0x06036D49 RID: 224585 RVA: 0x00CFC8F2 File Offset: 0x00CFAAF2
		public virtual void SetDragonPoolLevel(int level)
		{
			this.DragonPoolLevel = level;
		}

		// Token: 0x06036D4A RID: 224586 RVA: 0x00CFC8FB File Offset: 0x00CFAAFB
		public int GetDragonPoolLevel()
		{
			return this.DragonPoolLevel;
		}

		// Token: 0x06036D4B RID: 224587 RVA: 0x00CFC904 File Offset: 0x00CFAB04
		public void SetDragonPoolState(int finishedLevel)
		{
			int dragonPoolMaxLevel = this.GetDragonPoolMaxLevel();
			this.DragonPoolState = ((finishedLevel >= dragonPoolMaxLevel) ? 2 : 1);
		}

		// Token: 0x06036D4C RID: 224588 RVA: 0x00CFC926 File Offset: 0x00CFAB26
		public int GetDragonPoolState()
		{
			return this.DragonPoolState;
		}

		// Token: 0x06036D4D RID: 224589 RVA: 0x00CFC92E File Offset: 0x00CFAB2E
		public void SetHadCoreCount(int count)
		{
			this.HadCoreCount = count;
		}

		// Token: 0x06036D4E RID: 224590 RVA: 0x00CFC937 File Offset: 0x00CFAB37
		public int GetHadCoreCount()
		{
			return this.HadCoreCount;
		}

		// Token: 0x06036D4F RID: 224591 RVA: 0x00CFC940 File Offset: 0x00CFAB40
		public int GetDragonPoolMaxLevel()
		{
			return this.DragonPoolConfig.Value.GetGoalArray().Length;
		}

		// Token: 0x06036D50 RID: 224592 RVA: 0x00CFC964 File Offset: 0x00CFAB64
		public int GetNeedCoreCount(int level)
		{
			int[] goalArray = this.DragonPoolConfig.Value.GetGoalArray();
			if (level >= goalArray.Length)
			{
				return 0;
			}
			return goalArray[level];
		}

		// Token: 0x06036D51 RID: 224593 RVA: 0x00CFC990 File Offset: 0x00CFAB90
		public bool IsMaxLevel()
		{
			return this.GetDragonPoolLevel() >= this.GetDragonPoolMaxLevel();
		}

		// Token: 0x06036D52 RID: 224594 RVA: 0x00CFC9A4 File Offset: 0x00CFABA4
		public int[] GetGoalList()
		{
			return this.DragonPoolConfig.Value.GetGoalArray();
		}

		// Token: 0x06036D53 RID: 224595 RVA: 0x00CFC9C4 File Offset: 0x00CFABC4
		public int GetRewardId(int level)
		{
			return this.DragonPoolConfig.Value.GetDropIdsArray()[level];
		}

		// Token: 0x06036D54 RID: 224596 RVA: 0x00CFC9E8 File Offset: 0x00CFABE8
		public int GetCoreId()
		{
			return this.DragonPoolConfig.Value.CoreId;
		}

		// Token: 0x06036D55 RID: 224597 RVA: 0x00CFCA08 File Offset: 0x00CFAC08
		public virtual void SetLevelGainList(int levelGain)
		{
		}

		// Token: 0x06036D56 RID: 224598 RVA: 0x00CFCA0A File Offset: 0x00CFAC0A
		public void SetDropItemList(ItemDict[] items)
		{
			this.DropItemList = items;
		}

		// Token: 0x06036D57 RID: 224599 RVA: 0x00CFCA13 File Offset: 0x00CFAC13
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public ItemDict[] GetDropItemList()
		{
			return this.DropItemList;
		}

		// Token: 0x0401CF1A RID: 118554
		public readonly int DragonPoolId;

		// Token: 0x0401CF1B RID: 118555
		protected int DragonPoolState;

		// Token: 0x0401CF1C RID: 118556
		protected int DragonPoolLevel;

		// Token: 0x0401CF1D RID: 118557
		protected int HadCoreCount;

		// Token: 0x0401CF1E RID: 118558
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected ItemDict[] DropItemList;

		// Token: 0x0401CF1F RID: 118559
		protected readonly DragonPool? DragonPoolConfig;
	}
}
