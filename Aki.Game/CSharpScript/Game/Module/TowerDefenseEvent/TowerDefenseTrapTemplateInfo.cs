using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;

namespace CSharpScript.Game.Module.TowerDefenseEvent
{
	// Token: 0x02003AAA RID: 15018
	public class TowerDefenseTrapTemplateInfo : TowerDefenseEventEntityModel, ITowerDefenseEventTrapBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17004EA4 RID: 20132
		// (get) Token: 0x06026924 RID: 157988 RVA: 0x00AD09D2 File Offset: 0x00ACEBD2
		// (set) Token: 0x06026925 RID: 157989 RVA: 0x00AD09DA File Offset: 0x00ACEBDA
		public int ConfigId { get; set; }

		// Token: 0x17004EA5 RID: 20133
		// (get) Token: 0x06026926 RID: 157990 RVA: 0x00AD09E3 File Offset: 0x00ACEBE3
		// (set) Token: 0x06026927 RID: 157991 RVA: 0x00AD09EB File Offset: 0x00ACEBEB
		public int PrevConfigId { get; set; }

		// Token: 0x17004EA6 RID: 20134
		// (get) Token: 0x06026928 RID: 157992 RVA: 0x00AD09F4 File Offset: 0x00ACEBF4
		// (set) Token: 0x06026929 RID: 157993 RVA: 0x00AD09FC File Offset: 0x00ACEBFC
		public int TrapId { get; set; }

		// Token: 0x17004EA7 RID: 20135
		// (get) Token: 0x0602692A RID: 157994 RVA: 0x00AD0A05 File Offset: 0x00ACEC05
		// (set) Token: 0x0602692B RID: 157995 RVA: 0x00AD0A0D File Offset: 0x00ACEC0D
		public int Level { get; set; } = 1;

		// Token: 0x17004EA8 RID: 20136
		// (get) Token: 0x0602692C RID: 157996 RVA: 0x00AD0A16 File Offset: 0x00ACEC16
		// (set) Token: 0x0602692D RID: 157997 RVA: 0x00AD0A1E File Offset: 0x00ACEC1E
		public int BranchId { get; set; }

		// Token: 0x17004EA9 RID: 20137
		// (get) Token: 0x0602692E RID: 157998 RVA: 0x00AD0A27 File Offset: 0x00ACEC27
		// (set) Token: 0x0602692F RID: 157999 RVA: 0x00AD0A2F File Offset: 0x00ACEC2F
		public int DefaultCost { get; set; }

		// Token: 0x17004EAA RID: 20138
		// (get) Token: 0x06026930 RID: 158000 RVA: 0x00AD0A38 File Offset: 0x00ACEC38
		// (set) Token: 0x06026931 RID: 158001 RVA: 0x00AD0A40 File Offset: 0x00ACEC40
		public int DeconstructReturn { get; set; }

		// Token: 0x17004EAB RID: 20139
		// (get) Token: 0x06026932 RID: 158002 RVA: 0x00AD0A49 File Offset: 0x00ACEC49
		// (set) Token: 0x06026933 RID: 158003 RVA: 0x00AD0A51 File Offset: 0x00ACEC51
		[Nullable(1)]
		public Vector2D GridSize { [NullableContext(1)] get; [NullableContext(1)] set; } = new Vector2D();

		// Token: 0x17004EAC RID: 20140
		// (get) Token: 0x06026934 RID: 158004 RVA: 0x00AD0A5A File Offset: 0x00ACEC5A
		// (set) Token: 0x06026935 RID: 158005 RVA: 0x00AD0A62 File Offset: 0x00ACEC62
		public ETowerDefenseEventTrapPlacementType PlacementType { get; set; } = ETowerDefenseEventTrapPlacementType.Ground;

		// Token: 0x17004EAD RID: 20141
		// (get) Token: 0x06026936 RID: 158006 RVA: 0x00AD0A6B File Offset: 0x00ACEC6B
		// (set) Token: 0x06026937 RID: 158007 RVA: 0x00AD0A73 File Offset: 0x00ACEC73
		public bool CanRotate { get; set; } = true;

		// Token: 0x17004EAE RID: 20142
		// (get) Token: 0x06026938 RID: 158008 RVA: 0x00AD0A7C File Offset: 0x00ACEC7C
		// (set) Token: 0x06026939 RID: 158009 RVA: 0x00AD0A84 File Offset: 0x00ACEC84
		public int Degree { get; set; }

		// Token: 0x17004EAF RID: 20143
		// (get) Token: 0x0602693A RID: 158010 RVA: 0x00AD0A8D File Offset: 0x00ACEC8D
		// (set) Token: 0x0602693B RID: 158011 RVA: 0x00AD0A95 File Offset: 0x00ACEC95
		public int GlobalDegree { get; set; }

		// Token: 0x0602693C RID: 158012 RVA: 0x00AD0A9E File Offset: 0x00ACEC9E
		public override bool IsValid()
		{
			return false;
		}

		// Token: 0x0602693D RID: 158013 RVA: 0x00AD0AA1 File Offset: 0x00ACECA1
		public bool IsInPreview()
		{
			return this.ConfigId > 0;
		}

		// Token: 0x0602693E RID: 158014 RVA: 0x00AD0AAC File Offset: 0x00ACECAC
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

		// Token: 0x0602693F RID: 158015 RVA: 0x00AD0B22 File Offset: 0x00ACED22
		public void BeginInit(int configId)
		{
			this.PrevConfigId = this.ConfigId;
			this.ConfigId = configId;
		}

		// Token: 0x06026940 RID: 158016 RVA: 0x00AD0B37 File Offset: 0x00ACED37
		public void EndInit()
		{
			this.Degree = (this.CanRotate ? this.GlobalDegree : 0);
		}

		// Token: 0x06026941 RID: 158017 RVA: 0x00AD0B50 File Offset: 0x00ACED50
		public bool IsTargetLevel(int configId)
		{
			return this.ConfigId == configId;
		}

		// Token: 0x06026942 RID: 158018 RVA: 0x00AD0B5C File Offset: 0x00ACED5C
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

		// Token: 0x06026943 RID: 158019 RVA: 0x00AD0BAC File Offset: 0x00ACEDAC
		public bool GetConfigDirtyAndReset()
		{
			bool result = this.ConfigId != this.PrevConfigId;
			this.PrevConfigId = this.ConfigId;
			return result;
		}
	}
}
