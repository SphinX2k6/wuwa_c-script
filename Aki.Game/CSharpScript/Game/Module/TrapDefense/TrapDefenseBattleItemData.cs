using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A16 RID: 18966
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBattleItemData
	{
		// Token: 0x060313C3 RID: 201667 RVA: 0x00B6AD57 File Offset: 0x00B68F57
		public static TrapDefenseBattleItemData Create(TrapDefenseItem config)
		{
			return new TrapDefenseBattleItemData
			{
				Config = config
			};
		}

		// Token: 0x17007A16 RID: 31254
		// (get) Token: 0x060313C4 RID: 201668 RVA: 0x00B6AD65 File Offset: 0x00B68F65
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17007A17 RID: 31255
		// (get) Token: 0x060313C5 RID: 201669 RVA: 0x00B6AD72 File Offset: 0x00B68F72
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17007A18 RID: 31256
		// (get) Token: 0x060313C6 RID: 201670 RVA: 0x00B6AD7F File Offset: 0x00B68F7F
		public string Icon
		{
			get
			{
				return this.Config.Icon;
			}
		}

		// Token: 0x17007A19 RID: 31257
		// (get) Token: 0x060313C7 RID: 201671 RVA: 0x00B6AD8C File Offset: 0x00B68F8C
		public int Type
		{
			get
			{
				return this.Config.ItemType;
			}
		}

		// Token: 0x17007A1A RID: 31258
		// (get) Token: 0x060313C8 RID: 201672 RVA: 0x00B6AD99 File Offset: 0x00B68F99
		public int ExploreToolId
		{
			get
			{
				return this.Config.ExploreToolId;
			}
		}

		// Token: 0x17007A1B RID: 31259
		// (get) Token: 0x060313C9 RID: 201673 RVA: 0x00B6ADA6 File Offset: 0x00B68FA6
		public bool IsUseSkill
		{
			get
			{
				return this.Config.SkillIndex >= 0;
			}
		}

		// Token: 0x17007A1C RID: 31260
		// (get) Token: 0x060313CA RID: 201674 RVA: 0x00B6ADB9 File Offset: 0x00B68FB9
		public int SkillIndex
		{
			get
			{
				return this.Config.SkillIndex;
			}
		}

		// Token: 0x060313CB RID: 201675 RVA: 0x00B6ADC6 File Offset: 0x00B68FC6
		public void UpdateByServerData(int count, int limitCount)
		{
			this.InventoryCount = count;
			this.LimitCount = limitCount;
			EventSystem.Instance.Emit(EEventName.TrapDefenseInventoryDataUpdate);
		}

		// Token: 0x0401A52F RID: 107823
		public TrapDefenseItem Config;

		// Token: 0x0401A530 RID: 107824
		public int InventoryCount;

		// Token: 0x0401A531 RID: 107825
		public int LimitCount = 1;
	}
}
