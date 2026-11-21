using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060EC RID: 24812
	public class ITriggerComponentT
	{
		// Token: 0x1700B89C RID: 47260
		// (get) Token: 0x0602A092 RID: 172178 RVA: 0x005BD12B File Offset: 0x005BB32B
		// (set) Token: 0x0602A093 RID: 172179 RVA: 0x005BD133 File Offset: 0x005BB333
		public bool Disabled { get; set; }

		// Token: 0x1700B89D RID: 47261
		// (get) Token: 0x0602A094 RID: 172180 RVA: 0x005BD13C File Offset: 0x005BB33C
		// (set) Token: 0x0602A095 RID: 172181 RVA: 0x005BD144 File Offset: 0x005BB344
		public IEntityMatchT Match { get; set; }

		// Token: 0x1700B89E RID: 47262
		// (get) Token: 0x0602A096 RID: 172182 RVA: 0x005BD14D File Offset: 0x005BB34D
		// (set) Token: 0x0602A097 RID: 172183 RVA: 0x005BD155 File Offset: 0x005BB355
		public int MaxTriggerTimes { get; set; }

		// Token: 0x1700B89F RID: 47263
		// (get) Token: 0x0602A098 RID: 172184 RVA: 0x005BD15E File Offset: 0x005BB35E
		// (set) Token: 0x0602A099 RID: 172185 RVA: 0x005BD166 File Offset: 0x005BB366
		public int MatchTypeCount { get; set; }

		// Token: 0x1700B8A0 RID: 47264
		// (get) Token: 0x0602A09A RID: 172186 RVA: 0x005BD16F File Offset: 0x005BB36F
		// (set) Token: 0x0602A09B RID: 172187 RVA: 0x005BD177 File Offset: 0x005BB377
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B8A1 RID: 47265
		// (get) Token: 0x0602A09C RID: 172188 RVA: 0x005BD180 File Offset: 0x005BB380
		// (set) Token: 0x0602A09D RID: 172189 RVA: 0x005BD188 File Offset: 0x005BB388
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700B8A2 RID: 47266
		// (get) Token: 0x0602A09E RID: 172190 RVA: 0x005BD191 File Offset: 0x005BB391
		// (set) Token: 0x0602A09F RID: 172191 RVA: 0x005BD199 File Offset: 0x005BB399
		public ITriggerExitConfigT ExitConfig { get; set; }

		// Token: 0x1700B8A3 RID: 47267
		// (get) Token: 0x0602A0A0 RID: 172192 RVA: 0x005BD1A2 File Offset: 0x005BB3A2
		// (set) Token: 0x0602A0A1 RID: 172193 RVA: 0x005BD1AA File Offset: 0x005BB3AA
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700B8A4 RID: 47268
		// (get) Token: 0x0602A0A2 RID: 172194 RVA: 0x005BD1B3 File Offset: 0x005BB3B3
		// (set) Token: 0x0602A0A3 RID: 172195 RVA: 0x005BD1BB File Offset: 0x005BB3BB
		public bool ChangeRoleTrigger { get; set; }

		// Token: 0x1700B8A5 RID: 47269
		// (get) Token: 0x0602A0A4 RID: 172196 RVA: 0x005BD1C4 File Offset: 0x005BB3C4
		// (set) Token: 0x0602A0A5 RID: 172197 RVA: 0x005BD1CC File Offset: 0x005BB3CC
		public bool ClientPrePerformance { get; set; }

		// Token: 0x1700B8A6 RID: 47270
		// (get) Token: 0x0602A0A6 RID: 172198 RVA: 0x005BD1D5 File Offset: 0x005BB3D5
		// (set) Token: 0x0602A0A7 RID: 172199 RVA: 0x005BD1DD File Offset: 0x005BB3DD
		public bool OnlineDisableTip { get; set; }

		// Token: 0x1700B8A7 RID: 47271
		// (get) Token: 0x0602A0A8 RID: 172200 RVA: 0x005BD1E6 File Offset: 0x005BB3E6
		// (set) Token: 0x0602A0A9 RID: 172201 RVA: 0x005BD1EE File Offset: 0x005BB3EE
		public bool OnlineAutoExit { get; set; }

		// Token: 0x1700B8A8 RID: 47272
		// (get) Token: 0x0602A0AA RID: 172202 RVA: 0x005BD1F7 File Offset: 0x005BB3F7
		// (set) Token: 0x0602A0AB RID: 172203 RVA: 0x005BD1FF File Offset: 0x005BB3FF
		public byte NullMask { get; set; }

		// Token: 0x0602A0AC RID: 172204 RVA: 0x005BD208 File Offset: 0x005BB408
		public ITriggerComponentT()
		{
			this.Disabled = false;
			this.Match = null;
			this.MaxTriggerTimes = 0;
			this.MatchTypeCount = 0;
			this.Condition = null;
			this.Actions = null;
			this.ExitConfig = null;
			this.MatchRoleOption = null;
			this.ChangeRoleTrigger = false;
			this.ClientPrePerformance = false;
			this.OnlineDisableTip = false;
			this.OnlineAutoExit = false;
			this.NullMask = 0;
		}
	}
}
