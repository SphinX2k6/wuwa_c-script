using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058D7 RID: 22743
	public sealed class SolarSchoolPrizeDrawingData
	{
		// Token: 0x0603804E RID: 229454 RVA: 0x00FA90A8 File Offset: 0x00FA72A8
		public int GetDrawnCount(int groupId)
		{
			return this.DrawnMap.GetValueOrDefault(groupId, 0);
		}

		// Token: 0x0603804F RID: 229455 RVA: 0x00FA90B8 File Offset: 0x00FA72B8
		public int AddDrawn(int groupId, int delta)
		{
			int num = (int)Math.Clamp((long)this.GetDrawnCount(groupId) + (long)delta, 0L, 2147483647L);
			if (num == 0)
			{
				this.DrawnMap.Remove(groupId);
			}
			else
			{
				this.DrawnMap[groupId] = num;
			}
			return num;
		}

		// Token: 0x06038050 RID: 229456 RVA: 0x00FA90FF File Offset: 0x00FA72FF
		public int GetNoSCount()
		{
			return this.NoSCount;
		}

		// Token: 0x06038051 RID: 229457 RVA: 0x00FA9107 File Offset: 0x00FA7307
		public void IncNoSCount()
		{
			this.NoSCount++;
		}

		// Token: 0x06038052 RID: 229458 RVA: 0x00FA9117 File Offset: 0x00FA7317
		public void ResetNoSCount()
		{
			this.NoSCount = 0;
		}

		// Token: 0x06038053 RID: 229459 RVA: 0x00FA9120 File Offset: 0x00FA7320
		public void Clear()
		{
			this.DrawnMap.Clear();
			this.NoSCount = 0;
		}

		// Token: 0x0401D896 RID: 120982
		[Nullable(1)]
		private readonly Dictionary<int, int> DrawnMap = new Dictionary<int, int>();

		// Token: 0x0401D897 RID: 120983
		private int NoSCount;
	}
}
