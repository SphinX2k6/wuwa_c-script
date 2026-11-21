using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData
{
	// Token: 0x02003F98 RID: 16280
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineComponentData
	{
		// Token: 0x060292C6 RID: 168646 RVA: 0x00B8FFE0 File Offset: 0x00B8E1E0
		public QuestMultiLineComponentData(int configId)
		{
			this.Config = QuestMultiLineConfig.GetComponentConfigById(configId);
		}

		// Token: 0x1700533E RID: 21310
		// (get) Token: 0x060292C7 RID: 168647 RVA: 0x00B8FFF4 File Offset: 0x00B8E1F4
		public int Id
		{
			get
			{
				return this.Config.Value.Id;
			}
		}

		// Token: 0x1700533F RID: 21311
		// (get) Token: 0x060292C8 RID: 168648 RVA: 0x00B90014 File Offset: 0x00B8E214
		public IntVector2D? Location
		{
			get
			{
				return this.Config.Value.Location;
			}
		}

		// Token: 0x17005340 RID: 21312
		// (get) Token: 0x060292C9 RID: 168649 RVA: 0x00B90034 File Offset: 0x00B8E234
		public string TipsTitle
		{
			get
			{
				return this.Config.Value.TipsTitle;
			}
		}

		// Token: 0x17005341 RID: 21313
		// (get) Token: 0x060292CA RID: 168650 RVA: 0x00B90054 File Offset: 0x00B8E254
		public string TipsDesc
		{
			get
			{
				return this.Config.Value.TipsDesc;
			}
		}

		// Token: 0x17005342 RID: 21314
		// (get) Token: 0x060292CB RID: 168651 RVA: 0x00B90074 File Offset: 0x00B8E274
		public int Type
		{
			get
			{
				return this.Config.Value.Type;
			}
		}

		// Token: 0x17005343 RID: 21315
		// (get) Token: 0x060292CC RID: 168652 RVA: 0x00B90094 File Offset: 0x00B8E294
		public int FightingArea
		{
			get
			{
				return this.Config.Value.Location.Value.X;
			}
		}

		// Token: 0x17005344 RID: 21316
		// (get) Token: 0x060292CD RID: 168653 RVA: 0x00B900C4 File Offset: 0x00B8E2C4
		public int StatusType
		{
			get
			{
				return this.Config.Value.StatusType;
			}
		}

		// Token: 0x17005345 RID: 21317
		// (get) Token: 0x060292CE RID: 168654 RVA: 0x00B900E4 File Offset: 0x00B8E2E4
		public string[] ComponentIcon
		{
			get
			{
				return this.Config.Value.ComponentIcon();
			}
		}

		// Token: 0x17005346 RID: 21318
		// (get) Token: 0x060292CF RID: 168655 RVA: 0x00B90104 File Offset: 0x00B8E304
		public string[] MultiPersonAvatar
		{
			get
			{
				return this.Config.Value.MultiPersonAvatar();
			}
		}

		// Token: 0x17005347 RID: 21319
		// (get) Token: 0x060292D0 RID: 168656 RVA: 0x00B90124 File Offset: 0x00B8E324
		public string TipsArea
		{
			get
			{
				return this.Config.Value.TipsArea;
			}
		}

		// Token: 0x17005348 RID: 21320
		// (get) Token: 0x060292D1 RID: 168657 RVA: 0x00B90144 File Offset: 0x00B8E344
		public string TipsStatusDesc
		{
			get
			{
				return this.Config.Value.TipsStatusDesc;
			}
		}

		// Token: 0x17005349 RID: 21321
		// (get) Token: 0x060292D2 RID: 168658 RVA: 0x00B90164 File Offset: 0x00B8E364
		public int[] BranchFinishQuestNode
		{
			get
			{
				return this.Config.Value.BranchFinishQuestNode();
			}
		}

		// Token: 0x1700534A RID: 21322
		// (get) Token: 0x060292D3 RID: 168659 RVA: 0x00B90184 File Offset: 0x00B8E384
		public string OnGoingDesc
		{
			get
			{
				return this.Config.Value.OnGoingDesc;
			}
		}

		// Token: 0x1700534B RID: 21323
		// (get) Token: 0x060292D4 RID: 168660 RVA: 0x00B901A4 File Offset: 0x00B8E3A4
		public string ComponentQualityFrame
		{
			get
			{
				return this.Config.Value.ComponentQualityFrame;
			}
		}

		// Token: 0x1700534C RID: 21324
		// (get) Token: 0x060292D5 RID: 168661 RVA: 0x00B901C4 File Offset: 0x00B8E3C4
		public string ComponentQualityFrameHold
		{
			get
			{
				return this.Config.Value.ComponentQualityFrameHold;
			}
		}

		// Token: 0x1700534D RID: 21325
		// (get) Token: 0x060292D6 RID: 168662 RVA: 0x00B901E4 File Offset: 0x00B8E3E4
		public string HeadIconBgInTip
		{
			get
			{
				return this.Config.Value.HeadIconBgInTip;
			}
		}

		// Token: 0x1700534E RID: 21326
		// (get) Token: 0x060292D7 RID: 168663 RVA: 0x00B90204 File Offset: 0x00B8E404
		public string TipsQualityBg
		{
			get
			{
				return this.Config.Value.TipsQualityBg;
			}
		}

		// Token: 0x1700534F RID: 21327
		// (get) Token: 0x060292D8 RID: 168664 RVA: 0x00B90224 File Offset: 0x00B8E424
		public IntVector2D[] AnimMovePoint
		{
			get
			{
				return this.Config.Value.AnimMovePoint();
			}
		}

		// Token: 0x17005350 RID: 21328
		// (get) Token: 0x060292D9 RID: 168665 RVA: 0x00B90244 File Offset: 0x00B8E444
		public int MoveSpeed
		{
			get
			{
				return this.Config.Value.MoveSpeed;
			}
		}

		// Token: 0x17005351 RID: 21329
		// (get) Token: 0x060292DA RID: 168666 RVA: 0x00B90264 File Offset: 0x00B8E464
		public int PathSpeed
		{
			get
			{
				return this.Config.Value.PathSpeed;
			}
		}

		// Token: 0x17005352 RID: 21330
		// (get) Token: 0x060292DB RID: 168667 RVA: 0x00B90284 File Offset: 0x00B8E484
		public string HeadLoopEffect
		{
			get
			{
				return this.Config.Value.HeadLoopEffect;
			}
		}

		// Token: 0x040166BD RID: 91837
		private readonly QuestTimeComponentConfig? Config;
	}
}
