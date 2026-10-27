using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ACA RID: 23242
	public class ITrampleComponentT
	{
		// Token: 0x1700AF25 RID: 44837
		// (get) Token: 0x06027A21 RID: 162337 RVA: 0x00573D7E File Offset: 0x00571F7E
		// (set) Token: 0x06027A22 RID: 162338 RVA: 0x00573D86 File Offset: 0x00571F86
		public bool Disabled { get; set; }

		// Token: 0x1700AF26 RID: 44838
		// (get) Token: 0x06027A23 RID: 162339 RVA: 0x00573D8F File Offset: 0x00571F8F
		// (set) Token: 0x06027A24 RID: 162340 RVA: 0x00573D97 File Offset: 0x00571F97
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700AF27 RID: 44839
		// (get) Token: 0x06027A25 RID: 162341 RVA: 0x00573DA0 File Offset: 0x00571FA0
		// (set) Token: 0x06027A26 RID: 162342 RVA: 0x00573DA8 File Offset: 0x00571FA8
		public ITrampleRayDetectionT RayDetectionCondition { get; set; }

		// Token: 0x1700AF28 RID: 44840
		// (get) Token: 0x06027A27 RID: 162343 RVA: 0x00573DB1 File Offset: 0x00571FB1
		// (set) Token: 0x06027A28 RID: 162344 RVA: 0x00573DB9 File Offset: 0x00571FB9
		public IEntityMatchT Match { get; set; }

		// Token: 0x1700AF29 RID: 44841
		// (get) Token: 0x06027A29 RID: 162345 RVA: 0x00573DC2 File Offset: 0x00571FC2
		// (set) Token: 0x06027A2A RID: 162346 RVA: 0x00573DCA File Offset: 0x00571FCA
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700AF2A RID: 44842
		// (get) Token: 0x06027A2B RID: 162347 RVA: 0x00573DD3 File Offset: 0x00571FD3
		// (set) Token: 0x06027A2C RID: 162348 RVA: 0x00573DDB File Offset: 0x00571FDB
		public float DownTime { get; set; }

		// Token: 0x1700AF2B RID: 44843
		// (get) Token: 0x06027A2D RID: 162349 RVA: 0x00573DE4 File Offset: 0x00571FE4
		// (set) Token: 0x06027A2E RID: 162350 RVA: 0x00573DEC File Offset: 0x00571FEC
		public float StayTime { get; set; }

		// Token: 0x1700AF2C RID: 44844
		// (get) Token: 0x06027A2F RID: 162351 RVA: 0x00573DF5 File Offset: 0x00571FF5
		// (set) Token: 0x06027A30 RID: 162352 RVA: 0x00573DFD File Offset: 0x00571FFD
		public float UpTime { get; set; }

		// Token: 0x1700AF2D RID: 44845
		// (get) Token: 0x06027A31 RID: 162353 RVA: 0x00573E06 File Offset: 0x00572006
		// (set) Token: 0x06027A32 RID: 162354 RVA: 0x00573E0E File Offset: 0x0057200E
		public bool IsResetGear { get; set; }

		// Token: 0x1700AF2E RID: 44846
		// (get) Token: 0x06027A33 RID: 162355 RVA: 0x00573E17 File Offset: 0x00572017
		// (set) Token: 0x06027A34 RID: 162356 RVA: 0x00573E1F File Offset: 0x0057201F
		public IEnterLeaveRadiusT ShowLandTipRadius { get; set; }

		// Token: 0x1700AF2F RID: 44847
		// (get) Token: 0x06027A35 RID: 162357 RVA: 0x00573E28 File Offset: 0x00572028
		// (set) Token: 0x06027A36 RID: 162358 RVA: 0x00573E30 File Offset: 0x00572030
		public bool StopTeleControlMove { get; set; }

		// Token: 0x1700AF30 RID: 44848
		// (get) Token: 0x06027A37 RID: 162359 RVA: 0x00573E39 File Offset: 0x00572039
		// (set) Token: 0x06027A38 RID: 162360 RVA: 0x00573E41 File Offset: 0x00572041
		public ICountDownTextTipT TrampleTipOption { get; set; }

		// Token: 0x1700AF31 RID: 44849
		// (get) Token: 0x06027A39 RID: 162361 RVA: 0x00573E4A File Offset: 0x0057204A
		// (set) Token: 0x06027A3A RID: 162362 RVA: 0x00573E52 File Offset: 0x00572052
		public List<IActionInfoT> EnterActions { get; set; }

		// Token: 0x1700AF32 RID: 44850
		// (get) Token: 0x06027A3B RID: 162363 RVA: 0x00573E5B File Offset: 0x0057205B
		// (set) Token: 0x06027A3C RID: 162364 RVA: 0x00573E63 File Offset: 0x00572063
		public List<IActionInfoT> ExitActions { get; set; }

		// Token: 0x1700AF33 RID: 44851
		// (get) Token: 0x06027A3D RID: 162365 RVA: 0x00573E6C File Offset: 0x0057206C
		// (set) Token: 0x06027A3E RID: 162366 RVA: 0x00573E74 File Offset: 0x00572074
		public byte NullMask { get; set; }

		// Token: 0x06027A3F RID: 162367 RVA: 0x00573E80 File Offset: 0x00572080
		public ITrampleComponentT()
		{
			this.Disabled = false;
			this.Condition = null;
			this.RayDetectionCondition = null;
			this.Match = null;
			this.MatchRoleOption = null;
			this.DownTime = 0f;
			this.StayTime = 0f;
			this.UpTime = 0f;
			this.IsResetGear = false;
			this.ShowLandTipRadius = null;
			this.StopTeleControlMove = false;
			this.TrampleTipOption = null;
			this.EnterActions = null;
			this.ExitActions = null;
			this.NullMask = 0;
		}
	}
}
