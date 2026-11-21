using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004458 RID: 17496
	public class IQuestScheduleChildQuestCompletedT
	{
		// Token: 0x1700795A RID: 31066
		// (get) Token: 0x060191BE RID: 102846 RVA: 0x00395079 File Offset: 0x00393279
		// (set) Token: 0x060191BF RID: 102847 RVA: 0x00395081 File Offset: 0x00393281
		public EQuestScheduleType Type { get; set; }

		// Token: 0x1700795B RID: 31067
		// (get) Token: 0x060191C0 RID: 102848 RVA: 0x0039508A File Offset: 0x0039328A
		// (set) Token: 0x060191C1 RID: 102849 RVA: 0x00395092 File Offset: 0x00393292
		public int ChildQuestId { get; set; }

		// Token: 0x1700795C RID: 31068
		// (get) Token: 0x060191C2 RID: 102850 RVA: 0x0039509B File Offset: 0x0039329B
		// (set) Token: 0x060191C3 RID: 102851 RVA: 0x003950A3 File Offset: 0x003932A3
		public bool ShowTracking { get; set; }

		// Token: 0x1700795D RID: 31069
		// (get) Token: 0x060191C4 RID: 102852 RVA: 0x003950AC File Offset: 0x003932AC
		// (set) Token: 0x060191C5 RID: 102853 RVA: 0x003950B4 File Offset: 0x003932B4
		public bool ShowComplete { get; set; }

		// Token: 0x1700795E RID: 31070
		// (get) Token: 0x060191C6 RID: 102854 RVA: 0x003950BD File Offset: 0x003932BD
		// (set) Token: 0x060191C7 RID: 102855 RVA: 0x003950C5 File Offset: 0x003932C5
		public bool OnlyShowWhileRunning { get; set; }

		// Token: 0x1700795F RID: 31071
		// (get) Token: 0x060191C8 RID: 102856 RVA: 0x003950CE File Offset: 0x003932CE
		// (set) Token: 0x060191C9 RID: 102857 RVA: 0x003950D6 File Offset: 0x003932D6
		public List<TVarRefUnion> Vars { get; set; }

		// Token: 0x17007960 RID: 31072
		// (get) Token: 0x060191CA RID: 102858 RVA: 0x003950DF File Offset: 0x003932DF
		// (set) Token: 0x060191CB RID: 102859 RVA: 0x003950E7 File Offset: 0x003932E7
		public int CustomIcon { get; set; }

		// Token: 0x17007961 RID: 31073
		// (get) Token: 0x060191CC RID: 102860 RVA: 0x003950F0 File Offset: 0x003932F0
		// (set) Token: 0x060191CD RID: 102861 RVA: 0x003950F8 File Offset: 0x003932F8
		public ITitlePreStateT TitlePreState { get; set; }

		// Token: 0x17007962 RID: 31074
		// (get) Token: 0x060191CE RID: 102862 RVA: 0x00395101 File Offset: 0x00393301
		// (set) Token: 0x060191CF RID: 102863 RVA: 0x00395109 File Offset: 0x00393309
		public byte NullMask { get; set; }

		// Token: 0x060191D0 RID: 102864 RVA: 0x00395114 File Offset: 0x00393314
		public IQuestScheduleChildQuestCompletedT()
		{
			this.Type = EQuestScheduleType.None;
			this.ChildQuestId = 0;
			this.ShowTracking = false;
			this.ShowComplete = false;
			this.OnlyShowWhileRunning = false;
			this.Vars = null;
			this.CustomIcon = 0;
			this.TitlePreState = null;
			this.NullMask = 0;
		}
	}
}
