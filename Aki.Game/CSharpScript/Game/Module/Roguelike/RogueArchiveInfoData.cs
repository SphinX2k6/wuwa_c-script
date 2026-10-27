using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D8A RID: 19850
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueArchiveInfoData
	{
		// Token: 0x17007E89 RID: 32393
		// (get) Token: 0x060334E6 RID: 210150 RVA: 0x00BF9B3B File Offset: 0x00BF7D3B
		public int ShowIndex
		{
			get
			{
				return this.Index + 1;
			}
		}

		// Token: 0x060334E7 RID: 210151 RVA: 0x00BF9B48 File Offset: 0x00BF7D48
		public void Update(RogueArchiveInfo archiveInfo)
		{
			this.SlotId = archiveInfo.SlotId;
			this.HasData = archiveInfo.HasData;
			this.InstId = archiveInfo.InstId;
			this.SeasonId = archiveInfo.SeasonId;
			this.RoleIds = new List<int>(archiveInfo.RoleIds);
			if (archiveInfo.RoguelikeInstInfo != null)
			{
				this.RoguelikeInfo = new RoguelikeInfo(archiveInfo.RoguelikeInstInfo);
			}
			else
			{
				this.RoguelikeInfo = null;
			}
			if (this.RoguelikeInfo != null && archiveInfo.Attributes != null)
			{
				foreach (int num in archiveInfo.Attributes.Keys)
				{
					int num2 = archiveInfo.Attributes.ContainsKey(num) ? archiveInfo.Attributes[num] : 0;
					if (num2 != 0)
					{
						this.RoguelikeInfo.AttributeDict[Convert.ToInt32(num)] = num2;
					}
				}
			}
		}

		// Token: 0x0401B3B4 RID: 111540
		public int SlotId;

		// Token: 0x0401B3B5 RID: 111541
		public int Index;

		// Token: 0x0401B3B6 RID: 111542
		public bool HasData;

		// Token: 0x0401B3B7 RID: 111543
		public int InstId;

		// Token: 0x0401B3B8 RID: 111544
		public int SeasonId;

		// Token: 0x0401B3B9 RID: 111545
		public List<int> RoleIds = new List<int>();

		// Token: 0x0401B3BA RID: 111546
		[Nullable(2)]
		public RoguelikeInfo RoguelikeInfo;
	}
}
