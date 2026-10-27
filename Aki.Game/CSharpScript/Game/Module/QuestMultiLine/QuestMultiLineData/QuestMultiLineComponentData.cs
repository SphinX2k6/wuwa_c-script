using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData
{
	// Token: 0x02004FCF RID: 20431
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineComponentData
	{
		// Token: 0x06034458 RID: 214104 RVA: 0x00C46828 File Offset: 0x00C44A28
		public QuestMultiLineComponentData(int configId)
		{
			this.Config = QuestMultiLineConfig.GetComponentConfigById(configId);
		}

		// Token: 0x17007F8E RID: 32654
		// (get) Token: 0x06034459 RID: 214105 RVA: 0x00C4683C File Offset: 0x00C44A3C
		public int Id
		{
			get
			{
				return this.Config.Value.Id;
			}
		}

		// Token: 0x17007F8F RID: 32655
		// (get) Token: 0x0603445A RID: 214106 RVA: 0x00C4685C File Offset: 0x00C44A5C
		public IntVector2D? Location
		{
			get
			{
				return this.Config.Value.Location;
			}
		}

		// Token: 0x17007F90 RID: 32656
		// (get) Token: 0x0603445B RID: 214107 RVA: 0x00C4687C File Offset: 0x00C44A7C
		public string TipsTitle
		{
			get
			{
				return this.Config.Value.TipsTitle;
			}
		}

		// Token: 0x17007F91 RID: 32657
		// (get) Token: 0x0603445C RID: 214108 RVA: 0x00C4689C File Offset: 0x00C44A9C
		public string TipsDesc
		{
			get
			{
				return this.Config.Value.TipsDesc;
			}
		}

		// Token: 0x17007F92 RID: 32658
		// (get) Token: 0x0603445D RID: 214109 RVA: 0x00C468BC File Offset: 0x00C44ABC
		public int Type
		{
			get
			{
				return this.Config.Value.Type;
			}
		}

		// Token: 0x17007F93 RID: 32659
		// (get) Token: 0x0603445E RID: 214110 RVA: 0x00C468DC File Offset: 0x00C44ADC
		public int FightingArea
		{
			get
			{
				return this.Config.Value.Location.Value.X;
			}
		}

		// Token: 0x17007F94 RID: 32660
		// (get) Token: 0x0603445F RID: 214111 RVA: 0x00C4690C File Offset: 0x00C44B0C
		public int StatusType
		{
			get
			{
				return this.Config.Value.StatusType;
			}
		}

		// Token: 0x17007F95 RID: 32661
		// (get) Token: 0x06034460 RID: 214112 RVA: 0x00C4692C File Offset: 0x00C44B2C
		public string[] ComponentIcon
		{
			get
			{
				return this.Config.Value.ComponentIcon();
			}
		}

		// Token: 0x17007F96 RID: 32662
		// (get) Token: 0x06034461 RID: 214113 RVA: 0x00C4694C File Offset: 0x00C44B4C
		public string[] MultiPersonAvatar
		{
			get
			{
				return this.Config.Value.MultiPersonAvatar();
			}
		}

		// Token: 0x17007F97 RID: 32663
		// (get) Token: 0x06034462 RID: 214114 RVA: 0x00C4696C File Offset: 0x00C44B6C
		public string TipsArea
		{
			get
			{
				return this.Config.Value.TipsArea;
			}
		}

		// Token: 0x17007F98 RID: 32664
		// (get) Token: 0x06034463 RID: 214115 RVA: 0x00C4698C File Offset: 0x00C44B8C
		public string TipsStatusDesc
		{
			get
			{
				return this.Config.Value.TipsStatusDesc;
			}
		}

		// Token: 0x17007F99 RID: 32665
		// (get) Token: 0x06034464 RID: 214116 RVA: 0x00C469AC File Offset: 0x00C44BAC
		public int[] BranchFinishQuestNode
		{
			get
			{
				return this.Config.Value.BranchFinishQuestNode();
			}
		}

		// Token: 0x17007F9A RID: 32666
		// (get) Token: 0x06034465 RID: 214117 RVA: 0x00C469CC File Offset: 0x00C44BCC
		public string OnGoingDesc
		{
			get
			{
				return this.Config.Value.OnGoingDesc;
			}
		}

		// Token: 0x17007F9B RID: 32667
		// (get) Token: 0x06034466 RID: 214118 RVA: 0x00C469EC File Offset: 0x00C44BEC
		public string ComponentQualityFrame
		{
			get
			{
				return this.Config.Value.ComponentQualityFrame;
			}
		}

		// Token: 0x17007F9C RID: 32668
		// (get) Token: 0x06034467 RID: 214119 RVA: 0x00C46A0C File Offset: 0x00C44C0C
		public string ComponentQualityFrameHold
		{
			get
			{
				return this.Config.Value.ComponentQualityFrameHold;
			}
		}

		// Token: 0x17007F9D RID: 32669
		// (get) Token: 0x06034468 RID: 214120 RVA: 0x00C46A2C File Offset: 0x00C44C2C
		public string HeadIconBgInTip
		{
			get
			{
				return this.Config.Value.HeadIconBgInTip;
			}
		}

		// Token: 0x17007F9E RID: 32670
		// (get) Token: 0x06034469 RID: 214121 RVA: 0x00C46A4C File Offset: 0x00C44C4C
		public string TipsQualityBg
		{
			get
			{
				return this.Config.Value.TipsQualityBg;
			}
		}

		// Token: 0x17007F9F RID: 32671
		// (get) Token: 0x0603446A RID: 214122 RVA: 0x00C46A6C File Offset: 0x00C44C6C
		public IntVector2D[] AnimMovePoint
		{
			get
			{
				return this.Config.Value.AnimMovePoint();
			}
		}

		// Token: 0x17007FA0 RID: 32672
		// (get) Token: 0x0603446B RID: 214123 RVA: 0x00C46A8C File Offset: 0x00C44C8C
		public int MoveSpeed
		{
			get
			{
				return this.Config.Value.MoveSpeed;
			}
		}

		// Token: 0x17007FA1 RID: 32673
		// (get) Token: 0x0603446C RID: 214124 RVA: 0x00C46AAC File Offset: 0x00C44CAC
		public int PathSpeed
		{
			get
			{
				return this.Config.Value.PathSpeed;
			}
		}

		// Token: 0x17007FA2 RID: 32674
		// (get) Token: 0x0603446D RID: 214125 RVA: 0x00C46ACC File Offset: 0x00C44CCC
		public string HeadLoopEffect
		{
			get
			{
				return this.Config.Value.HeadLoopEffect;
			}
		}

		// Token: 0x0401BCE8 RID: 113896
		private readonly QuestTimeComponentConfig? Config;
	}
}
