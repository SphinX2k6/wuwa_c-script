using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;

namespace CSharpScript.Game.Module.TowerDefenseEvent
{
	// Token: 0x02004B02 RID: 19202
	public class TowerDefenseTrapTemplateInfo : TowerDefenseEventEntityModel, ITowerDefenseEventTrapBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17007AF7 RID: 31479
		// (get) Token: 0x06031B94 RID: 203668 RVA: 0x00B8C96E File Offset: 0x00B8AB6E
		// (set) Token: 0x06031B95 RID: 203669 RVA: 0x00B8C976 File Offset: 0x00B8AB76
		public int ConfigId { get; set; }

		// Token: 0x17007AF8 RID: 31480
		// (get) Token: 0x06031B96 RID: 203670 RVA: 0x00B8C97F File Offset: 0x00B8AB7F
		// (set) Token: 0x06031B97 RID: 203671 RVA: 0x00B8C987 File Offset: 0x00B8AB87
		public int PrevConfigId { get; set; }

		// Token: 0x17007AF9 RID: 31481
		// (get) Token: 0x06031B98 RID: 203672 RVA: 0x00B8C990 File Offset: 0x00B8AB90
		// (set) Token: 0x06031B99 RID: 203673 RVA: 0x00B8C998 File Offset: 0x00B8AB98
		public int TrapId { get; set; }

		// Token: 0x17007AFA RID: 31482
		// (get) Token: 0x06031B9A RID: 203674 RVA: 0x00B8C9A1 File Offset: 0x00B8ABA1
		// (set) Token: 0x06031B9B RID: 203675 RVA: 0x00B8C9A9 File Offset: 0x00B8ABA9
		public int Level { get; set; } = 1;

		// Token: 0x17007AFB RID: 31483
		// (get) Token: 0x06031B9C RID: 203676 RVA: 0x00B8C9B2 File Offset: 0x00B8ABB2
		// (set) Token: 0x06031B9D RID: 203677 RVA: 0x00B8C9BA File Offset: 0x00B8ABBA
		public int BranchId { get; set; }

		// Token: 0x17007AFC RID: 31484
		// (get) Token: 0x06031B9E RID: 203678 RVA: 0x00B8C9C3 File Offset: 0x00B8ABC3
		// (set) Token: 0x06031B9F RID: 203679 RVA: 0x00B8C9CB File Offset: 0x00B8ABCB
		public int DefaultCost { get; set; }

		// Token: 0x17007AFD RID: 31485
		// (get) Token: 0x06031BA0 RID: 203680 RVA: 0x00B8C9D4 File Offset: 0x00B8ABD4
		// (set) Token: 0x06031BA1 RID: 203681 RVA: 0x00B8C9DC File Offset: 0x00B8ABDC
		public int DeconstructReturn { get; set; }

		// Token: 0x17007AFE RID: 31486
		// (get) Token: 0x06031BA2 RID: 203682 RVA: 0x00B8C9E5 File Offset: 0x00B8ABE5
		// (set) Token: 0x06031BA3 RID: 203683 RVA: 0x00B8C9ED File Offset: 0x00B8ABED
		[Nullable(1)]
		public Vector2D GridSize { [NullableContext(1)] get; [NullableContext(1)] set; } = new Vector2D();

		// Token: 0x17007AFF RID: 31487
		// (get) Token: 0x06031BA4 RID: 203684 RVA: 0x00B8C9F6 File Offset: 0x00B8ABF6
		// (set) Token: 0x06031BA5 RID: 203685 RVA: 0x00B8C9FE File Offset: 0x00B8ABFE
		public ETowerDefenseEventTrapPlacementType PlacementType { get; set; } = ETowerDefenseEventTrapPlacementType.Ground;

		// Token: 0x17007B00 RID: 31488
		// (get) Token: 0x06031BA6 RID: 203686 RVA: 0x00B8CA07 File Offset: 0x00B8AC07
		// (set) Token: 0x06031BA7 RID: 203687 RVA: 0x00B8CA0F File Offset: 0x00B8AC0F
		public bool CanRotate { get; set; } = true;

		// Token: 0x17007B01 RID: 31489
		// (get) Token: 0x06031BA8 RID: 203688 RVA: 0x00B8CA18 File Offset: 0x00B8AC18
		// (set) Token: 0x06031BA9 RID: 203689 RVA: 0x00B8CA20 File Offset: 0x00B8AC20
		public int Degree { get; set; }

		// Token: 0x17007B02 RID: 31490
		// (get) Token: 0x06031BAA RID: 203690 RVA: 0x00B8CA29 File Offset: 0x00B8AC29
		// (set) Token: 0x06031BAB RID: 203691 RVA: 0x00B8CA31 File Offset: 0x00B8AC31
		public int GlobalDegree { get; set; }

		// Token: 0x06031BAC RID: 203692 RVA: 0x00B8CA3A File Offset: 0x00B8AC3A
		public override bool IsValid()
		{
			return false;
		}

		// Token: 0x06031BAD RID: 203693 RVA: 0x00B8CA3D File Offset: 0x00B8AC3D
		public bool IsInPreview()
		{
			return this.ConfigId > 0;
		}

		// Token: 0x06031BAE RID: 203694 RVA: 0x00B8CA48 File Offset: 0x00B8AC48
		public override void Reset()
		{
			base.Reset();
			this.ConfigId = 0;
			this.PrevConfigId = 0;
			this.TrapId = 0;
			this.Level = 1;
			this.BranchId = 0;
			this.DefaultCost = 0;
			this.DeconstructReturn = 0;
			this.GridSize.Set(0.0, 0.0);
			this.PlacementType = ETowerDefenseEventTrapPlacementType.Ground;
			this.CanRotate = true;
			this.Degree = 0;
		}

		// Token: 0x06031BAF RID: 203695 RVA: 0x00B8CABE File Offset: 0x00B8ACBE
		public void BeginInit(int configId)
		{
			this.PrevConfigId = this.ConfigId;
			this.ConfigId = configId;
		}

		// Token: 0x06031BB0 RID: 203696 RVA: 0x00B8CAD3 File Offset: 0x00B8ACD3
		public void EndInit()
		{
			this.Degree = (this.CanRotate ? this.GlobalDegree : 0);
		}

		// Token: 0x06031BB1 RID: 203697 RVA: 0x00B8CAEC File Offset: 0x00B8ACEC
		public bool IsTargetLevel(int configId)
		{
			return this.ConfigId == configId;
		}

		// Token: 0x06031BB2 RID: 203698 RVA: 0x00B8CAF8 File Offset: 0x00B8ACF8
		public void Rotate()
		{
			if (!this.CanRotate)
			{
				return;
			}
			this.GlobalDegree += 90;
			if (this.GlobalDegree > 180)
			{
				this.GlobalDegree -= 360;
			}
			this.Degree = this.GlobalDegree;
		}

		// Token: 0x06031BB3 RID: 203699 RVA: 0x00B8CB48 File Offset: 0x00B8AD48
		public bool GetConfigDirtyAndReset()
		{
			bool result = this.ConfigId != this.PrevConfigId;
			this.PrevConfigId = this.ConfigId;
			return result;
		}
	}
}
