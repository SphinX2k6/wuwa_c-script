using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200465F RID: 18015
	public class ITrackLevelPlayT
	{
		// Token: 0x17007E2D RID: 32301
		// (get) Token: 0x0601A6AC RID: 108204 RVA: 0x003C2C93 File Offset: 0x003C0E93
		// (set) Token: 0x0601A6AD RID: 108205 RVA: 0x003C2C9B File Offset: 0x003C0E9B
		public ETrackType Type { get; set; }

		// Token: 0x17007E2E RID: 32302
		// (get) Token: 0x0601A6AE RID: 108206 RVA: 0x003C2CA4 File Offset: 0x003C0EA4
		// (set) Token: 0x0601A6AF RID: 108207 RVA: 0x003C2CAC File Offset: 0x003C0EAC
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17007E2F RID: 32303
		// (get) Token: 0x0601A6B0 RID: 108208 RVA: 0x003C2CB5 File Offset: 0x003C0EB5
		// (set) Token: 0x0601A6B1 RID: 108209 RVA: 0x003C2CBD File Offset: 0x003C0EBD
		public int LevelPlayId { get; set; }

		// Token: 0x17007E30 RID: 32304
		// (get) Token: 0x0601A6B2 RID: 108210 RVA: 0x003C2CC6 File Offset: 0x003C0EC6
		// (set) Token: 0x0601A6B3 RID: 108211 RVA: 0x003C2CCE File Offset: 0x003C0ECE
		public IVectorInfoT OutOfRangeTrackPos { get; set; }

		// Token: 0x17007E31 RID: 32305
		// (get) Token: 0x0601A6B4 RID: 108212 RVA: 0x003C2CD7 File Offset: 0x003C0ED7
		// (set) Token: 0x0601A6B5 RID: 108213 RVA: 0x003C2CDF File Offset: 0x003C0EDF
		public List<IConditionTrackPosT> ConditionTrackPosList { get; set; }

		// Token: 0x17007E32 RID: 32306
		// (get) Token: 0x0601A6B6 RID: 108214 RVA: 0x003C2CE8 File Offset: 0x003C0EE8
		// (set) Token: 0x0601A6B7 RID: 108215 RVA: 0x003C2CF0 File Offset: 0x003C0EF0
		public ELevelPlayTrackSwitchRule TrackSwitchRule { get; set; }

		// Token: 0x17007E33 RID: 32307
		// (get) Token: 0x0601A6B8 RID: 108216 RVA: 0x003C2CF9 File Offset: 0x003C0EF9
		// (set) Token: 0x0601A6B9 RID: 108217 RVA: 0x003C2D01 File Offset: 0x003C0F01
		public byte NullMask { get; set; }

		// Token: 0x0601A6BA RID: 108218 RVA: 0x003C2D0A File Offset: 0x003C0F0A
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
