using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D53 RID: 15699
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueArchiveInfoData
	{
		// Token: 0x17005239 RID: 21049
		// (get) Token: 0x06028353 RID: 164691 RVA: 0x00B43137 File Offset: 0x00B41337
		public int ShowIndex
		{
			get
			{
				return this.Index + 1;
			}
		}

		// Token: 0x06028354 RID: 164692 RVA: 0x00B43144 File Offset: 0x00B41344
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

		// Token: 0x04015D87 RID: 89479
		public int SlotId;

		// Token: 0x04015D88 RID: 89480
		public int Index;

		// Token: 0x04015D89 RID: 89481
		public bool HasData;

		// Token: 0x04015D8A RID: 89482
		public int InstId;

		// Token: 0x04015D8B RID: 89483
		public int SeasonId;

		// Token: 0x04015D8C RID: 89484
		public List<int> RoleIds = new List<int>();

		// Token: 0x04015D8D RID: 89485
		[Nullable(2)]
		public RoguelikeInfo RoguelikeInfo;
	}
}
