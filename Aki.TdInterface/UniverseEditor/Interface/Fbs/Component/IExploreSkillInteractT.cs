using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E4 RID: 20964
	public class IExploreSkillInteractT
	{
		// Token: 0x1700997B RID: 39291
		// (get) Token: 0x06022050 RID: 139344 RVA: 0x004B880D File Offset: 0x004B6A0D
		// (set) Token: 0x06022051 RID: 139345 RVA: 0x004B8815 File Offset: 0x004B6A15
		public string ExploreSkillUiResource { get; set; }

		// Token: 0x1700997C RID: 39292
		// (get) Token: 0x06022052 RID: 139346 RVA: 0x004B881E File Offset: 0x004B6A1E
		// (set) Token: 0x06022053 RID: 139347 RVA: 0x004B8826 File Offset: 0x004B6A26
		public TExploreSkillInteractOptionUnion Option { get; set; }

		// Token: 0x1700997D RID: 39293
		// (get) Token: 0x06022054 RID: 139348 RVA: 0x004B882F File Offset: 0x004B6A2F
		// (set) Token: 0x06022055 RID: 139349 RVA: 0x004B8837 File Offset: 0x004B6A37
		public int PlayerStateRestritionId { get; set; }

		// Token: 0x1700997E RID: 39294
		// (get) Token: 0x06022056 RID: 139350 RVA: 0x004B8840 File Offset: 0x004B6A40
		// (set) Token: 0x06022057 RID: 139351 RVA: 0x004B8848 File Offset: 0x004B6A48
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700997F RID: 39295
		// (get) Token: 0x06022058 RID: 139352 RVA: 0x004B8851 File Offset: 0x004B6A51
		// (set) Token: 0x06022059 RID: 139353 RVA: 0x004B8859 File Offset: 0x004B6A59
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009980 RID: 39296
		// (get) Token: 0x0602205A RID: 139354 RVA: 0x004B8862 File Offset: 0x004B6A62
		// (set) Token: 0x0602205B RID: 139355 RVA: 0x004B886A File Offset: 0x004B6A6A
		public TExploreSkillSearchTargetCfgUnion SearchTargetCfg { get; set; }

		// Token: 0x17009981 RID: 39297
		// (get) Token: 0x0602205C RID: 139356 RVA: 0x004B8873 File Offset: 0x004B6A73
		// (set) Token: 0x0602205D RID: 139357 RVA: 0x004B887B File Offset: 0x004B6A7B
		public IIgnoresCollisionCfgT IgnoresCollisionCfg { get; set; }

		// Token: 0x17009982 RID: 39298
		// (get) Token: 0x0602205E RID: 139358 RVA: 0x004B8884 File Offset: 0x004B6A84
		// (set) Token: 0x0602205F RID: 139359 RVA: 0x004B888C File Offset: 0x004B6A8C
		public List<string> SelfInteractBlockDetectionKeys { get; set; }

		// Token: 0x17009983 RID: 39299
		// (get) Token: 0x06022060 RID: 139360 RVA: 0x004B8895 File Offset: 0x004B6A95
		// (set) Token: 0x06022061 RID: 139361 RVA: 0x004B889D File Offset: 0x004B6A9D
		public byte NullMask { get; set; }

		// Token: 0x06022062 RID: 139362 RVA: 0x004B88A8 File Offset: 0x004B6AA8
		public IExploreSkillInteractT()
		{
			this.ExploreSkillUiResource = null;
			this.Option = null;
			this.PlayerStateRestritionId = 0;
			this.MatchRoleOption = null;
			this.Condition = null;
			this.SearchTargetCfg = null;
			this.IgnoresCollisionCfg = null;
			this.SelfInteractBlockDetectionKeys = null;
			this.NullMask = 0;
		}
	}
}
