using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D1B RID: 23835
	public class IPatrolSplinePointT
	{
		// Token: 0x1700AF2D RID: 44845
		// (get) Token: 0x060279AC RID: 162220 RVA: 0x0056B3A2 File Offset: 0x005695A2
		// (set) Token: 0x060279AD RID: 162221 RVA: 0x0056B3AA File Offset: 0x005695AA
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700AF2E RID: 44846
		// (get) Token: 0x060279AE RID: 162222 RVA: 0x0056B3B3 File Offset: 0x005695B3
		// (set) Token: 0x060279AF RID: 162223 RVA: 0x0056B3BB File Offset: 0x005695BB
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700AF2F RID: 44847
		// (get) Token: 0x060279B0 RID: 162224 RVA: 0x0056B3C4 File Offset: 0x005695C4
		// (set) Token: 0x060279B1 RID: 162225 RVA: 0x0056B3CC File Offset: 0x005695CC
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700AF30 RID: 44848
		// (get) Token: 0x060279B2 RID: 162226 RVA: 0x0056B3D5 File Offset: 0x005695D5
		// (set) Token: 0x060279B3 RID: 162227 RVA: 0x0056B3DD File Offset: 0x005695DD
		public ESplineLine LineType { get; set; }

		// Token: 0x1700AF31 RID: 44849
		// (get) Token: 0x060279B4 RID: 162228 RVA: 0x0056B3E6 File Offset: 0x005695E6
		// (set) Token: 0x060279B5 RID: 162229 RVA: 0x0056B3EE File Offset: 0x005695EE
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700AF32 RID: 44850
		// (get) Token: 0x060279B6 RID: 162230 RVA: 0x0056B3F7 File Offset: 0x005695F7
		// (set) Token: 0x060279B7 RID: 162231 RVA: 0x0056B3FF File Offset: 0x005695FF
		public EPatrolMoveState MoveState { get; set; }

		// Token: 0x1700AF33 RID: 44851
		// (get) Token: 0x060279B8 RID: 162232 RVA: 0x0056B408 File Offset: 0x00569608
		// (set) Token: 0x060279B9 RID: 162233 RVA: 0x0056B410 File Offset: 0x00569610
		public ECharPositionStateType CharPositionState { get; set; }

		// Token: 0x1700AF34 RID: 44852
		// (get) Token: 0x060279BA RID: 162234 RVA: 0x0056B419 File Offset: 0x00569619
		// (set) Token: 0x060279BB RID: 162235 RVA: 0x0056B421 File Offset: 0x00569621
		public int MoveSpeed { get; set; }

		// Token: 0x1700AF35 RID: 44853
		// (get) Token: 0x060279BC RID: 162236 RVA: 0x0056B42A File Offset: 0x0056962A
		// (set) Token: 0x060279BD RID: 162237 RVA: 0x0056B432 File Offset: 0x00569632
		public int TurnSpeed { get; set; }

		// Token: 0x1700AF36 RID: 44854
		// (get) Token: 0x060279BE RID: 162238 RVA: 0x0056B43B File Offset: 0x0056963B
		// (set) Token: 0x060279BF RID: 162239 RVA: 0x0056B443 File Offset: 0x00569643
		public bool IgnorePoint { get; set; }

		// Token: 0x1700AF37 RID: 44855
		// (get) Token: 0x060279C0 RID: 162240 RVA: 0x0056B44C File Offset: 0x0056964C
		// (set) Token: 0x060279C1 RID: 162241 RVA: 0x0056B454 File Offset: 0x00569654
		public int StayTime { get; set; }

		// Token: 0x1700AF38 RID: 44856
		// (get) Token: 0x060279C2 RID: 162242 RVA: 0x0056B45D File Offset: 0x0056965D
		// (set) Token: 0x060279C3 RID: 162243 RVA: 0x0056B465 File Offset: 0x00569665
		public bool IsHide { get; set; }

		// Token: 0x1700AF39 RID: 44857
		// (get) Token: 0x060279C4 RID: 162244 RVA: 0x0056B46E File Offset: 0x0056966E
		// (set) Token: 0x060279C5 RID: 162245 RVA: 0x0056B476 File Offset: 0x00569676
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700AF3A RID: 44858
		// (get) Token: 0x060279C6 RID: 162246 RVA: 0x0056B47F File Offset: 0x0056967F
		// (set) Token: 0x060279C7 RID: 162247 RVA: 0x0056B487 File Offset: 0x00569687
		public bool IsEnableIk { get; set; }

		// Token: 0x1700AF3B RID: 44859
		// (get) Token: 0x060279C8 RID: 162248 RVA: 0x0056B490 File Offset: 0x00569690
		// (set) Token: 0x060279C9 RID: 162249 RVA: 0x0056B498 File Offset: 0x00569698
		public byte NullMask { get; set; }

		// Token: 0x060279CA RID: 162250 RVA: 0x0056B4A4 File Offset: 0x005696A4
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
			this.TurnSpeed = 0;
			this.IgnorePoint = false;
			this.StayTime = 0;
			this.IsHide = false;
			this.Actions = null;
			this.IsEnableIk = false;
			this.NullMask = 0;
		}
	}
}
