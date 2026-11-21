using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005949 RID: 22857
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScratchTicketRewardPool : IExtractionPoolHandler<int[]>
	{
		// Token: 0x0603851B RID: 230683 RVA: 0x00FBEC1A File Offset: 0x00FBCE1A
		public bool HasItem()
		{
			return this.pool.Count > 0;
		}

		// Token: 0x0603851C RID: 230684 RVA: 0x00FBEC2C File Offset: 0x00FBCE2C
		public int[] GetItem()
		{
			if (this.pool.Count == 0 || this.total <= 0)
			{
				return null;
			}
			int num = Random.Shared.Next(0, this.total);
			int num2 = 0;
			foreach (KeyValuePair<int, int> keyValuePair in this.pool)
			{
				num2 += keyValuePair.Value;
				if (num < num2)
				{
					int key = keyValuePair.Key;
					int value = keyValuePair.Value;
					this.total--;
					if (value <= 1)
					{
						this.pool.Remove(key);
					}
					else
					{
						this.pool[key] = value - 1;
					}
					return new int[]
					{
						key,
						value
					};
				}
			}
			return null;
		}

		// Token: 0x0603851D RID: 230685 RVA: 0x00FBED10 File Offset: 0x00FBCF10
		public void PutItem(int[] item)
		{
			this.pool.Add(item[0], item[1]);
			this.total += item[1];
		}

		// Token: 0x0603851E RID: 230686 RVA: 0x00FBED33 File Offset: 0x00FBCF33
		public void Clear()
		{
			this.pool.Clear();
			this.total = 0;
		}

		// Token: 0x0401DA8D RID: 121485
		private Dictionary<int, int> pool = new Dictionary<int, int>();

		// Token: 0x0401DA8E RID: 121486
		private int total;
	}
}
