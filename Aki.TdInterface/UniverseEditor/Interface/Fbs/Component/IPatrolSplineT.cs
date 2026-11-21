using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D18 RID: 23832
	public class IPatrolSplineT
	{
		// Token: 0x1700AF14 RID: 44820
		// (get) Token: 0x06027968 RID: 162152 RVA: 0x0056A786 File Offset: 0x00568986
		// (set) Token: 0x06027969 RID: 162153 RVA: 0x0056A78E File Offset: 0x0056898E
		public ESplineType Type { get; set; }

		// Token: 0x1700AF15 RID: 44821
		// (get) Token: 0x0602796A RID: 162154 RVA: 0x0056A797 File Offset: 0x00568997
		// (set) Token: 0x0602796B RID: 162155 RVA: 0x0056A79F File Offset: 0x0056899F
		public TPatrolCycleOptionUnion CycleOption { get; set; }

		// Token: 0x1700AF16 RID: 44822
		// (get) Token: 0x0602796C RID: 162156 RVA: 0x0056A7A8 File Offset: 0x005689A8
		// (set) Token: 0x0602796D RID: 162157 RVA: 0x0056A7B0 File Offset: 0x005689B0
		public bool IsNavigation { get; set; }

		// Token: 0x1700AF17 RID: 44823
		// (get) Token: 0x0602796E RID: 162158 RVA: 0x0056A7B9 File Offset: 0x005689B9
		// (set) Token: 0x0602796F RID: 162159 RVA: 0x0056A7C1 File Offset: 0x005689C1
		public float TurnSpeed { get; set; }

		// Token: 0x1700AF18 RID: 44824
		// (get) Token: 0x06027970 RID: 162160 RVA: 0x0056A7CA File Offset: 0x005689CA
		// (set) Token: 0x06027971 RID: 162161 RVA: 0x0056A7D2 File Offset: 0x005689D2
		public bool IsFloating { get; set; }

		// Token: 0x1700AF19 RID: 44825
		// (get) Token: 0x06027972 RID: 162162 RVA: 0x0056A7DB File Offset: 0x005689DB
		// (set) Token: 0x06027973 RID: 162163 RVA: 0x0056A7E3 File Offset: 0x005689E3
		public List<IPatrolPositionRefreshConfigT> PositionRefreshConfigs { get; set; }

		// Token: 0x1700AF1A RID: 44826
		// (get) Token: 0x06027974 RID: 162164 RVA: 0x0056A7EC File Offset: 0x005689EC
		// (set) Token: 0x06027975 RID: 162165 RVA: 0x0056A7F4 File Offset: 0x005689F4
		public List<IPatrolSplinePointT> Points { get; set; }

		// Token: 0x1700AF1B RID: 44827
		// (get) Token: 0x06027976 RID: 162166 RVA: 0x0056A7FD File Offset: 0x005689FD
		// (set) Token: 0x06027977 RID: 162167 RVA: 0x0056A805 File Offset: 0x00568A05
		public IPatrolRangeT PatrolRange { get; set; }

		// Token: 0x1700AF1C RID: 44828
		// (get) Token: 0x06027978 RID: 162168 RVA: 0x0056A80E File Offset: 0x00568A0E
		// (set) Token: 0x06027979 RID: 162169 RVA: 0x0056A816 File Offset: 0x00568A16
		public byte NullMask { get; set; }

		// Token: 0x0602797A RID: 162170 RVA: 0x0056A820 File Offset: 0x00568A20
		public IPatrolSplineT()
		{
			this.Type = ESplineType.Common;
			this.CycleOption = null;
			this.IsNavigation = false;
			this.TurnSpeed = 0f;
			this.IsFloating = false;
			this.PositionRefreshConfigs = null;
			this.Points = null;
			this.PatrolRange = null;
			this.NullMask = 0;
		}
	}
}
