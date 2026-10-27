using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DA RID: 21722
	public class ILevelAISplinePointT
	{
		// Token: 0x1700A020 RID: 40992
		// (get) Token: 0x06023D00 RID: 146688 RVA: 0x004F38B6 File Offset: 0x004F1AB6
		// (set) Token: 0x06023D01 RID: 146689 RVA: 0x004F38BE File Offset: 0x004F1ABE
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700A021 RID: 40993
		// (get) Token: 0x06023D02 RID: 146690 RVA: 0x004F38C7 File Offset: 0x004F1AC7
		// (set) Token: 0x06023D03 RID: 146691 RVA: 0x004F38CF File Offset: 0x004F1ACF
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700A022 RID: 40994
		// (get) Token: 0x06023D04 RID: 146692 RVA: 0x004F38D8 File Offset: 0x004F1AD8
		// (set) Token: 0x06023D05 RID: 146693 RVA: 0x004F38E0 File Offset: 0x004F1AE0
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700A023 RID: 40995
		// (get) Token: 0x06023D06 RID: 146694 RVA: 0x004F38E9 File Offset: 0x004F1AE9
		// (set) Token: 0x06023D07 RID: 146695 RVA: 0x004F38F1 File Offset: 0x004F1AF1
		public ESplineLine LineType { get; set; }

		// Token: 0x1700A024 RID: 40996
		// (get) Token: 0x06023D08 RID: 146696 RVA: 0x004F38FA File Offset: 0x004F1AFA
		// (set) Token: 0x06023D09 RID: 146697 RVA: 0x004F3902 File Offset: 0x004F1B02
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700A025 RID: 40997
		// (get) Token: 0x06023D0A RID: 146698 RVA: 0x004F390B File Offset: 0x004F1B0B
		// (set) Token: 0x06023D0B RID: 146699 RVA: 0x004F3913 File Offset: 0x004F1B13
		public EPatrolMoveState MoveState { get; set; }

		// Token: 0x1700A026 RID: 40998
		// (get) Token: 0x06023D0C RID: 146700 RVA: 0x004F391C File Offset: 0x004F1B1C
		// (set) Token: 0x06023D0D RID: 146701 RVA: 0x004F3924 File Offset: 0x004F1B24
		public ECharPositionStateType CharPositionState { get; set; }

		// Token: 0x1700A027 RID: 40999
		// (get) Token: 0x06023D0E RID: 146702 RVA: 0x004F392D File Offset: 0x004F1B2D
		// (set) Token: 0x06023D0F RID: 146703 RVA: 0x004F3935 File Offset: 0x004F1B35
		public int MoveSpeed { get; set; }

		// Token: 0x1700A028 RID: 41000
		// (get) Token: 0x06023D10 RID: 146704 RVA: 0x004F393E File Offset: 0x004F1B3E
		// (set) Token: 0x06023D11 RID: 146705 RVA: 0x004F3946 File Offset: 0x004F1B46
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A029 RID: 41001
		// (get) Token: 0x06023D12 RID: 146706 RVA: 0x004F394F File Offset: 0x004F1B4F
		// (set) Token: 0x06023D13 RID: 146707 RVA: 0x004F3957 File Offset: 0x004F1B57
		public bool IsEnableIk { get; set; }

		// Token: 0x1700A02A RID: 41002
		// (get) Token: 0x06023D14 RID: 146708 RVA: 0x004F3960 File Offset: 0x004F1B60
		// (set) Token: 0x06023D15 RID: 146709 RVA: 0x004F3968 File Offset: 0x004F1B68
		public ILevelAiPointOffsetConfigT PointOffsetConfig { get; set; }

		// Token: 0x1700A02B RID: 41003
		// (get) Token: 0x06023D16 RID: 146710 RVA: 0x004F3971 File Offset: 0x004F1B71
		// (set) Token: 0x06023D17 RID: 146711 RVA: 0x004F3979 File Offset: 0x004F1B79
		public byte NullMask { get; set; }

		// Token: 0x06023D18 RID: 146712 RVA: 0x004F3984 File Offset: 0x004F1B84
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
