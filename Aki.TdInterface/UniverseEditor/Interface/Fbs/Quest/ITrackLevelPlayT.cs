using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004203 RID: 16899
	public class ITrackLevelPlayT
	{
		// Token: 0x170077FC RID: 30716
		// (get) Token: 0x06018F40 RID: 102208 RVA: 0x003975BB File Offset: 0x003957BB
		// (set) Token: 0x06018F41 RID: 102209 RVA: 0x003975C3 File Offset: 0x003957C3
		public ETrackType Type { get; set; }

		// Token: 0x170077FD RID: 30717
		// (get) Token: 0x06018F42 RID: 102210 RVA: 0x003975CC File Offset: 0x003957CC
		// (set) Token: 0x06018F43 RID: 102211 RVA: 0x003975D4 File Offset: 0x003957D4
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x170077FE RID: 30718
		// (get) Token: 0x06018F44 RID: 102212 RVA: 0x003975DD File Offset: 0x003957DD
		// (set) Token: 0x06018F45 RID: 102213 RVA: 0x003975E5 File Offset: 0x003957E5
		public int LevelPlayId { get; set; }

		// Token: 0x170077FF RID: 30719
		// (get) Token: 0x06018F46 RID: 102214 RVA: 0x003975EE File Offset: 0x003957EE
		// (set) Token: 0x06018F47 RID: 102215 RVA: 0x003975F6 File Offset: 0x003957F6
		public IVectorInfoT OutOfRangeTrackPos { get; set; }

		// Token: 0x17007800 RID: 30720
		// (get) Token: 0x06018F48 RID: 102216 RVA: 0x003975FF File Offset: 0x003957FF
		// (set) Token: 0x06018F49 RID: 102217 RVA: 0x00397607 File Offset: 0x00395807
		public List<IConditionTrackPosT> ConditionTrackPosList { get; set; }

		// Token: 0x17007801 RID: 30721
		// (get) Token: 0x06018F4A RID: 102218 RVA: 0x00397610 File Offset: 0x00395810
		// (set) Token: 0x06018F4B RID: 102219 RVA: 0x00397618 File Offset: 0x00395818
		public ELevelPlayTrackSwitchRule TrackSwitchRule { get; set; }

		// Token: 0x17007802 RID: 30722
		// (get) Token: 0x06018F4C RID: 102220 RVA: 0x00397621 File Offset: 0x00395821
		// (set) Token: 0x06018F4D RID: 102221 RVA: 0x00397629 File Offset: 0x00395829
		public byte NullMask { get; set; }

		// Token: 0x06018F4E RID: 102222 RVA: 0x00397632 File Offset: 0x00395832
		public ITrackLevelPlayT()
		{
			this.Type = ETrackType.Locations;
			this.GravityDirection = null;
			this.LevelPlayId = 0;
			this.OutOfRangeTrackPos = null;
			this.ConditionTrackPosList = null;
			this.TrackSwitchRule = ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack;
			this.NullMask = 0;
		}
	}
}
