using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039BE RID: 14782
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBattleItemData
	{
		// Token: 0x06026153 RID: 155987 RVA: 0x00AAED53 File Offset: 0x00AACF53
		public static TrapDefenseBattleItemData Create(TrapDefenseItem config)
		{
			return new TrapDefenseBattleItemData
			{
				Config = config
			};
		}

		// Token: 0x17004DC3 RID: 19907
		// (get) Token: 0x06026154 RID: 155988 RVA: 0x00AAED61 File Offset: 0x00AACF61
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17004DC4 RID: 19908
		// (get) Token: 0x06026155 RID: 155989 RVA: 0x00AAED6E File Offset: 0x00AACF6E
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17004DC5 RID: 19909
		// (get) Token: 0x06026156 RID: 155990 RVA: 0x00AAED7B File Offset: 0x00AACF7B
		public string Icon
		{
			get
			{
				return this.Config.Icon;
			}
		}

		// Token: 0x17004DC6 RID: 19910
		// (get) Token: 0x06026157 RID: 155991 RVA: 0x00AAED88 File Offset: 0x00AACF88
		public int Type
		{
			get
			{
				return this.Config.ItemType;
			}
		}

		// Token: 0x17004DC7 RID: 19911
		// (get) Token: 0x06026158 RID: 155992 RVA: 0x00AAED95 File Offset: 0x00AACF95
		public int ExploreToolId
		{
			get
			{
				return this.Config.ExploreToolId;
			}
		}

		// Token: 0x17004DC8 RID: 19912
		// (get) Token: 0x06026159 RID: 155993 RVA: 0x00AAEDA2 File Offset: 0x00AACFA2
		public bool IsUseSkill
		{
			get
			{
				return this.Config.SkillIndex >= 0;
			}
		}

		// Token: 0x17004DC9 RID: 19913
		// (get) Token: 0x0602615A RID: 155994 RVA: 0x00AAEDB5 File Offset: 0x00AACFB5
		public int SkillIndex
		{
			get
			{
				return this.Config.SkillIndex;
			}
		}

		// Token: 0x0602615B RID: 155995 RVA: 0x00AAEDC2 File Offset: 0x00AACFC2
		public void UpdateByServerData(int count, int limitCount)
		{
			this.InventoryCount = count;
			this.LimitCount = limitCount;
			EventSystem.Instance.Emit(EEventName.TrapDefenseInventoryDataUpdate);
		}

		// Token: 0x04014E86 RID: 85638
		public TrapDefenseItem Config;

		// Token: 0x04014E87 RID: 85639
		public int InventoryCount;

		// Token: 0x04014E88 RID: 85640
		public int LimitCount = 1;
	}
}
