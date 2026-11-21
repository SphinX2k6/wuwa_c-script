using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200447C RID: 17532
	public class IQuestScheduleSubTitleT
	{
		// Token: 0x170079B6 RID: 31158
		// (get) Token: 0x06019363 RID: 103267 RVA: 0x0039911E File Offset: 0x0039731E
		// (set) Token: 0x06019364 RID: 103268 RVA: 0x00399126 File Offset: 0x00397326
		public string TidTitle { get; set; }

		// Token: 0x170079B7 RID: 31159
		// (get) Token: 0x06019365 RID: 103269 RVA: 0x0039912F File Offset: 0x0039732F
		// (set) Token: 0x06019366 RID: 103270 RVA: 0x00399137 File Offset: 0x00397337
		public TQuestScheduleUnion QuestScheduleType { get; set; }

		// Token: 0x170079B8 RID: 31160
		// (get) Token: 0x06019367 RID: 103271 RVA: 0x00399140 File Offset: 0x00397340
		// (set) Token: 0x06019368 RID: 103272 RVA: 0x00399148 File Offset: 0x00397348
		public IConditionGroupT ShowConditions { get; set; }

		// Token: 0x170079B9 RID: 31161
		// (get) Token: 0x06019369 RID: 103273 RVA: 0x00399151 File Offset: 0x00397351
		// (set) Token: 0x0601936A RID: 103274 RVA: 0x00399159 File Offset: 0x00397359
		public int CustomIcon { get; set; }

		// Token: 0x170079BA RID: 31162
		// (get) Token: 0x0601936B RID: 103275 RVA: 0x00399162 File Offset: 0x00397362
		// (set) Token: 0x0601936C RID: 103276 RVA: 0x0039916A File Offset: 0x0039736A
		public IProgressBarT ProgressBar { get; set; }

		// Token: 0x170079BB RID: 31163
		// (get) Token: 0x0601936D RID: 103277 RVA: 0x00399173 File Offset: 0x00397373
		// (set) Token: 0x0601936E RID: 103278 RVA: 0x0039917B File Offset: 0x0039737B
		public List<IConditionTextT> ConditionText { get; set; }

		// Token: 0x170079BC RID: 31164
		// (get) Token: 0x0601936F RID: 103279 RVA: 0x00399184 File Offset: 0x00397384
		// (set) Token: 0x06019370 RID: 103280 RVA: 0x0039918C File Offset: 0x0039738C
		public bool BlankTitleStillShow { get; set; }

		// Token: 0x170079BD RID: 31165
		// (get) Token: 0x06019371 RID: 103281 RVA: 0x00399195 File Offset: 0x00397395
		// (set) Token: 0x06019372 RID: 103282 RVA: 0x0039919D File Offset: 0x0039739D
		public List<ICustomPlaceholderBindingProgressT> CustomPlaceholderBindingProgressList { get; set; }

		// Token: 0x170079BE RID: 31166
		// (get) Token: 0x06019373 RID: 103283 RVA: 0x003991A6 File Offset: 0x003973A6
		// (set) Token: 0x06019374 RID: 103284 RVA: 0x003991AE File Offset: 0x003973AE
		public byte NullMask { get; set; }

		// Token: 0x06019375 RID: 103285 RVA: 0x003991B8 File Offset: 0x003973B8
		public IQuestScheduleSubTitleT()
		{
			this.TidTitle = null;
			this.QuestScheduleType = null;
			this.ShowConditions = null;
			this.CustomIcon = 0;
			this.ProgressBar = null;
			this.ConditionText = null;
			this.BlankTitleStillShow = false;
			this.CustomPlaceholderBindingProgressList = null;
			this.NullMask = 0;
		}
	}
}
