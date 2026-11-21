using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A60 RID: 23136
	public class ILevelAISplinePointT
	{
		// Token: 0x1700A85A RID: 43098
		// (get) Token: 0x06025DB8 RID: 155064 RVA: 0x0053092A File Offset: 0x0052EB2A
		// (set) Token: 0x06025DB9 RID: 155065 RVA: 0x00530932 File Offset: 0x0052EB32
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700A85B RID: 43099
		// (get) Token: 0x06025DBA RID: 155066 RVA: 0x0053093B File Offset: 0x0052EB3B
		// (set) Token: 0x06025DBB RID: 155067 RVA: 0x00530943 File Offset: 0x0052EB43
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700A85C RID: 43100
		// (get) Token: 0x06025DBC RID: 155068 RVA: 0x0053094C File Offset: 0x0052EB4C
		// (set) Token: 0x06025DBD RID: 155069 RVA: 0x00530954 File Offset: 0x0052EB54
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700A85D RID: 43101
		// (get) Token: 0x06025DBE RID: 155070 RVA: 0x0053095D File Offset: 0x0052EB5D
		// (set) Token: 0x06025DBF RID: 155071 RVA: 0x00530965 File Offset: 0x0052EB65
		public ESplineLine LineType { get; set; }

		// Token: 0x1700A85E RID: 43102
		// (get) Token: 0x06025DC0 RID: 155072 RVA: 0x0053096E File Offset: 0x0052EB6E
		// (set) Token: 0x06025DC1 RID: 155073 RVA: 0x00530976 File Offset: 0x0052EB76
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700A85F RID: 43103
		// (get) Token: 0x06025DC2 RID: 155074 RVA: 0x0053097F File Offset: 0x0052EB7F
		// (set) Token: 0x06025DC3 RID: 155075 RVA: 0x00530987 File Offset: 0x0052EB87
		public EPatrolMoveState MoveState { get; set; }

		// Token: 0x1700A860 RID: 43104
		// (get) Token: 0x06025DC4 RID: 155076 RVA: 0x00530990 File Offset: 0x0052EB90
		// (set) Token: 0x06025DC5 RID: 155077 RVA: 0x00530998 File Offset: 0x0052EB98
		public ECharPositionStateType CharPositionState { get; set; }

		// Token: 0x1700A861 RID: 43105
		// (get) Token: 0x06025DC6 RID: 155078 RVA: 0x005309A1 File Offset: 0x0052EBA1
		// (set) Token: 0x06025DC7 RID: 155079 RVA: 0x005309A9 File Offset: 0x0052EBA9
		public int MoveSpeed { get; set; }

		// Token: 0x1700A862 RID: 43106
		// (get) Token: 0x06025DC8 RID: 155080 RVA: 0x005309B2 File Offset: 0x0052EBB2
		// (set) Token: 0x06025DC9 RID: 155081 RVA: 0x005309BA File Offset: 0x0052EBBA
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A863 RID: 43107
		// (get) Token: 0x06025DCA RID: 155082 RVA: 0x005309C3 File Offset: 0x0052EBC3
		// (set) Token: 0x06025DCB RID: 155083 RVA: 0x005309CB File Offset: 0x0052EBCB
		public bool IsEnableIk { get; set; }

		// Token: 0x1700A864 RID: 43108
		// (get) Token: 0x06025DCC RID: 155084 RVA: 0x005309D4 File Offset: 0x0052EBD4
		// (set) Token: 0x06025DCD RID: 155085 RVA: 0x005309DC File Offset: 0x0052EBDC
		public ILevelAiPointOffsetConfigT PointOffsetConfig { get; set; }

		// Token: 0x1700A865 RID: 43109
		// (get) Token: 0x06025DCE RID: 155086 RVA: 0x005309E5 File Offset: 0x0052EBE5
		// (set) Token: 0x06025DCF RID: 155087 RVA: 0x005309ED File Offset: 0x0052EBED
		public byte NullMask { get; set; }

		// Token: 0x06025DD0 RID: 155088 RVA: 0x005309F8 File Offset: 0x0052EBF8
		public ILevelAISplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.MoveState = EPatrolMoveState.None;
			this.CharPositionState = ECharPositionStateType.Ground;
			this.MoveSpeed = 0;
			this.Actions = null;
			this.IsEnableIk = false;
			this.PointOffsetConfig = null;
			this.NullMask = 0;
		}
	}
}
