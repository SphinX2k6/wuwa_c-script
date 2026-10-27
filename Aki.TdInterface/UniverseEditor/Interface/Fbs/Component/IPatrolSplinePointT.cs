using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005714 RID: 22292
	public class IPatrolSplinePointT
	{
		// Token: 0x1700A60E RID: 42510
		// (get) Token: 0x0602549F RID: 152735 RVA: 0x005256C4 File Offset: 0x005238C4
		// (set) Token: 0x060254A0 RID: 152736 RVA: 0x005256CC File Offset: 0x005238CC
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700A60F RID: 42511
		// (get) Token: 0x060254A1 RID: 152737 RVA: 0x005256D5 File Offset: 0x005238D5
		// (set) Token: 0x060254A2 RID: 152738 RVA: 0x005256DD File Offset: 0x005238DD
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700A610 RID: 42512
		// (get) Token: 0x060254A3 RID: 152739 RVA: 0x005256E6 File Offset: 0x005238E6
		// (set) Token: 0x060254A4 RID: 152740 RVA: 0x005256EE File Offset: 0x005238EE
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700A611 RID: 42513
		// (get) Token: 0x060254A5 RID: 152741 RVA: 0x005256F7 File Offset: 0x005238F7
		// (set) Token: 0x060254A6 RID: 152742 RVA: 0x005256FF File Offset: 0x005238FF
		public ESplineLine LineType { get; set; }

		// Token: 0x1700A612 RID: 42514
		// (get) Token: 0x060254A7 RID: 152743 RVA: 0x00525708 File Offset: 0x00523908
		// (set) Token: 0x060254A8 RID: 152744 RVA: 0x00525710 File Offset: 0x00523910
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700A613 RID: 42515
		// (get) Token: 0x060254A9 RID: 152745 RVA: 0x00525719 File Offset: 0x00523919
		// (set) Token: 0x060254AA RID: 152746 RVA: 0x00525721 File Offset: 0x00523921
		public EPatrolMoveState MoveState { get; set; }

		// Token: 0x1700A614 RID: 42516
		// (get) Token: 0x060254AB RID: 152747 RVA: 0x0052572A File Offset: 0x0052392A
		// (set) Token: 0x060254AC RID: 152748 RVA: 0x00525732 File Offset: 0x00523932
		public ECharPositionStateType CharPositionState { get; set; }

		// Token: 0x1700A615 RID: 42517
		// (get) Token: 0x060254AD RID: 152749 RVA: 0x0052573B File Offset: 0x0052393B
		// (set) Token: 0x060254AE RID: 152750 RVA: 0x00525743 File Offset: 0x00523943
		public int MoveSpeed { get; set; }

		// Token: 0x1700A616 RID: 42518
		// (get) Token: 0x060254AF RID: 152751 RVA: 0x0052574C File Offset: 0x0052394C
		// (set) Token: 0x060254B0 RID: 152752 RVA: 0x00525754 File Offset: 0x00523954
		public bool IgnorePoint { get; set; }

		// Token: 0x1700A617 RID: 42519
		// (get) Token: 0x060254B1 RID: 152753 RVA: 0x0052575D File Offset: 0x0052395D
		// (set) Token: 0x060254B2 RID: 152754 RVA: 0x00525765 File Offset: 0x00523965
		public int StayTime { get; set; }

		// Token: 0x1700A618 RID: 42520
		// (get) Token: 0x060254B3 RID: 152755 RVA: 0x0052576E File Offset: 0x0052396E
		// (set) Token: 0x060254B4 RID: 152756 RVA: 0x00525776 File Offset: 0x00523976
		public bool IsHide { get; set; }

		// Token: 0x1700A619 RID: 42521
		// (get) Token: 0x060254B5 RID: 152757 RVA: 0x0052577F File Offset: 0x0052397F
		// (set) Token: 0x060254B6 RID: 152758 RVA: 0x00525787 File Offset: 0x00523987
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A61A RID: 42522
		// (get) Token: 0x060254B7 RID: 152759 RVA: 0x00525790 File Offset: 0x00523990
		// (set) Token: 0x060254B8 RID: 152760 RVA: 0x00525798 File Offset: 0x00523998
		public bool IsEnableIk { get; set; }

		// Token: 0x1700A61B RID: 42523
		// (get) Token: 0x060254B9 RID: 152761 RVA: 0x005257A1 File Offset: 0x005239A1
		// (set) Token: 0x060254BA RID: 152762 RVA: 0x005257A9 File Offset: 0x005239A9
		public byte NullMask { get; set; }

		// Token: 0x060254BB RID: 152763 RVA: 0x005257B4 File Offset: 0x005239B4
		public IPatrolSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.MoveState = EPatrolMoveState.None;
			this.CharPositionState = ECharPositionStateType.Ground;
			this.MoveSpeed = 0;
			this.IgnorePoint = false;
			this.StayTime = 0;
			this.IsHide = false;
			this.Actions = null;
			this.IsEnableIk = false;
			this.NullMask = 0;
		}
	}
}
