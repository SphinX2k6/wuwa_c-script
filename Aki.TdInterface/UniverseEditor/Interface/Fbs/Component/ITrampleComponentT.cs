using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060D7 RID: 24791
	public class ITrampleComponentT
	{
		// Token: 0x1700B861 RID: 47201
		// (get) Token: 0x06029FAB RID: 171947 RVA: 0x005BB19B File Offset: 0x005B939B
		// (set) Token: 0x06029FAC RID: 171948 RVA: 0x005BB1A3 File Offset: 0x005B93A3
		public bool Disabled { get; set; }

		// Token: 0x1700B862 RID: 47202
		// (get) Token: 0x06029FAD RID: 171949 RVA: 0x005BB1AC File Offset: 0x005B93AC
		// (set) Token: 0x06029FAE RID: 171950 RVA: 0x005BB1B4 File Offset: 0x005B93B4
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B863 RID: 47203
		// (get) Token: 0x06029FAF RID: 171951 RVA: 0x005BB1BD File Offset: 0x005B93BD
		// (set) Token: 0x06029FB0 RID: 171952 RVA: 0x005BB1C5 File Offset: 0x005B93C5
		public ITrampleRayDetectionT RayDetectionCondition { get; set; }

		// Token: 0x1700B864 RID: 47204
		// (get) Token: 0x06029FB1 RID: 171953 RVA: 0x005BB1CE File Offset: 0x005B93CE
		// (set) Token: 0x06029FB2 RID: 171954 RVA: 0x005BB1D6 File Offset: 0x005B93D6
		public IEntityMatchT Match { get; set; }

		// Token: 0x1700B865 RID: 47205
		// (get) Token: 0x06029FB3 RID: 171955 RVA: 0x005BB1DF File Offset: 0x005B93DF
		// (set) Token: 0x06029FB4 RID: 171956 RVA: 0x005BB1E7 File Offset: 0x005B93E7
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700B866 RID: 47206
		// (get) Token: 0x06029FB5 RID: 171957 RVA: 0x005BB1F0 File Offset: 0x005B93F0
		// (set) Token: 0x06029FB6 RID: 171958 RVA: 0x005BB1F8 File Offset: 0x005B93F8
		public float DownTime { get; set; }

		// Token: 0x1700B867 RID: 47207
		// (get) Token: 0x06029FB7 RID: 171959 RVA: 0x005BB201 File Offset: 0x005B9401
		// (set) Token: 0x06029FB8 RID: 171960 RVA: 0x005BB209 File Offset: 0x005B9409
		public float StayTime { get; set; }

		// Token: 0x1700B868 RID: 47208
		// (get) Token: 0x06029FB9 RID: 171961 RVA: 0x005BB212 File Offset: 0x005B9412
		// (set) Token: 0x06029FBA RID: 171962 RVA: 0x005BB21A File Offset: 0x005B941A
		public float UpTime { get; set; }

		// Token: 0x1700B869 RID: 47209
		// (get) Token: 0x06029FBB RID: 171963 RVA: 0x005BB223 File Offset: 0x005B9423
		// (set) Token: 0x06029FBC RID: 171964 RVA: 0x005BB22B File Offset: 0x005B942B
		public bool IsResetGear { get; set; }

		// Token: 0x1700B86A RID: 47210
		// (get) Token: 0x06029FBD RID: 171965 RVA: 0x005BB234 File Offset: 0x005B9434
		// (set) Token: 0x06029FBE RID: 171966 RVA: 0x005BB23C File Offset: 0x005B943C
		public IEnterLeaveRadiusT ShowLandTipRadius { get; set; }

		// Token: 0x1700B86B RID: 47211
		// (get) Token: 0x06029FBF RID: 171967 RVA: 0x005BB245 File Offset: 0x005B9445
		// (set) Token: 0x06029FC0 RID: 171968 RVA: 0x005BB24D File Offset: 0x005B944D
		public bool StopTeleControlMove { get; set; }

		// Token: 0x1700B86C RID: 47212
		// (get) Token: 0x06029FC1 RID: 171969 RVA: 0x005BB256 File Offset: 0x005B9456
		// (set) Token: 0x06029FC2 RID: 171970 RVA: 0x005BB25E File Offset: 0x005B945E
		public TTrampleTipOptionUnion TrampleTipOption { get; set; }

		// Token: 0x1700B86D RID: 47213
		// (get) Token: 0x06029FC3 RID: 171971 RVA: 0x005BB267 File Offset: 0x005B9467
		// (set) Token: 0x06029FC4 RID: 171972 RVA: 0x005BB26F File Offset: 0x005B946F
		public List<IActionInfoT> EnterActions { get; set; }

		// Token: 0x1700B86E RID: 47214
		// (get) Token: 0x06029FC5 RID: 171973 RVA: 0x005BB278 File Offset: 0x005B9478
		// (set) Token: 0x06029FC6 RID: 171974 RVA: 0x005BB280 File Offset: 0x005B9480
		public List<IActionInfoT> ExitActions { get; set; }

		// Token: 0x1700B86F RID: 47215
		// (get) Token: 0x06029FC7 RID: 171975 RVA: 0x005BB289 File Offset: 0x005B9489
		// (set) Token: 0x06029FC8 RID: 171976 RVA: 0x005BB291 File Offset: 0x005B9491
		public byte NullMask { get; set; }

		// Token: 0x06029FC9 RID: 171977 RVA: 0x005BB29C File Offset: 0x005B949C
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
