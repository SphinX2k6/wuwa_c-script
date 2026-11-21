using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020043B2 RID: 17330
	[NullableContext(1)]
	[Nullable(0)]
	public class MingSuInstance
	{
		// Token: 0x0602BC8F RID: 179343 RVA: 0x00C4B988 File Offset: 0x00C49B88
		public MingSuInstance(int id)
		{
			this.DragonPoolId = id;
			this.DragonPoolConfig = ConfigDragonPoolById.GetConfig(this.DragonPoolId, true);
			this.DragonPoolState = 0;
			this.DragonPoolLevel = 0;
			this.HadCoreCount = 0;
		}

		// Token: 0x0602BC90 RID: 179344 RVA: 0x00C4B9BE File Offset: 0x00C49BBE
		public virtual void SetDragonPoolLevel(int level)
		{
			this.DragonPoolLevel = level;
		}

		// Token: 0x0602BC91 RID: 179345 RVA: 0x00C4B9C7 File Offset: 0x00C49BC7
		public int GetDragonPoolLevel()
		{
			return this.DragonPoolLevel;
		}

		// Token: 0x0602BC92 RID: 179346 RVA: 0x00C4B9D0 File Offset: 0x00C49BD0
		public void SetDragonPoolState(int finishedLevel)
		{
			int dragonPoolMaxLevel = this.GetDragonPoolMaxLevel();
			this.DragonPoolState = ((finishedLevel >= dragonPoolMaxLevel) ? 2 : 1);
		}

		// Token: 0x0602BC93 RID: 179347 RVA: 0x00C4B9F2 File Offset: 0x00C49BF2
		public int GetDragonPoolState()
		{
			return this.DragonPoolState;
		}

		// Token: 0x0602BC94 RID: 179348 RVA: 0x00C4B9FA File Offset: 0x00C49BFA
		public void SetHadCoreCount(int count)
		{
			this.HadCoreCount = count;
		}

		// Token: 0x0602BC95 RID: 179349 RVA: 0x00C4BA03 File Offset: 0x00C49C03
		public int GetHadCoreCount()
		{
			return this.HadCoreCount;
		}

		// Token: 0x0602BC96 RID: 179350 RVA: 0x00C4BA0C File Offset: 0x00C49C0C
		public int GetDragonPoolMaxLevel()
		{
			return this.DragonPoolConfig.Value.GetGoalArray().Length;
		}

		// Token: 0x0602BC97 RID: 179351 RVA: 0x00C4BA30 File Offset: 0x00C49C30
		public int GetNeedCoreCount(int level)
		{
			int[] goalArray = this.DragonPoolConfig.Value.GetGoalArray();
			if (level >= goalArray.Length)
			{
				return 0;
			}
			return goalArray[level];
		}

		// Token: 0x0602BC98 RID: 179352 RVA: 0x00C4BA5C File Offset: 0x00C49C5C
		public bool IsMaxLevel()
		{
			return this.GetDragonPoolLevel() >= this.GetDragonPoolMaxLevel();
		}

		// Token: 0x0602BC99 RID: 179353 RVA: 0x00C4BA70 File Offset: 0x00C49C70
		public int[] GetGoalList()
		{
			return this.DragonPoolConfig.Value.GetGoalArray();
		}

		// Token: 0x0602BC9A RID: 179354 RVA: 0x00C4BA90 File Offset: 0x00C49C90
		public int GetRewardId(int level)
		{
			return this.DragonPoolConfig.Value.GetDropIdsArray()[level];
		}

		// Token: 0x0602BC9B RID: 179355 RVA: 0x00C4BAB4 File Offset: 0x00C49CB4
		public int GetCoreId()
		{
			return this.DragonPoolConfig.Value.CoreId;
		}

		// Token: 0x0602BC9C RID: 179356 RVA: 0x00C4BAD4 File Offset: 0x00C49CD4
		public virtual void SetLevelGainList(int levelGain)
		{
		}

		// Token: 0x0602BC9D RID: 179357 RVA: 0x00C4BAD6 File Offset: 0x00C49CD6
		public void SetDropItemList(ItemDict[] items)
		{
			this.DropItemList = items;
		}

		// Token: 0x0602BC9E RID: 179358 RVA: 0x00C4BADF File Offset: 0x00C49CDF
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public ItemDict[] GetDropItemList()
		{
			return this.DropItemList;
		}

		// Token: 0x040179B2 RID: 96690
		public readonly int DragonPoolId;

		// Token: 0x040179B3 RID: 96691
		protected int DragonPoolState;

		// Token: 0x040179B4 RID: 96692
		protected int DragonPoolLevel;

		// Token: 0x040179B5 RID: 96693
		protected int HadCoreCount;

		// Token: 0x040179B6 RID: 96694
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected ItemDict[] DropItemList;

		// Token: 0x040179B7 RID: 96695
		protected readonly DragonPool? DragonPoolConfig;
	}
}
