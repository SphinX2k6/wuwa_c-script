using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044A9 RID: 17577
	public class IRangeLimitingConditionT
	{
		// Token: 0x17007A3A RID: 31290
		// (get) Token: 0x060195AC RID: 103852 RVA: 0x0039E7CA File Offset: 0x0039C9CA
		// (set) Token: 0x060195AD RID: 103853 RVA: 0x0039E7D2 File Offset: 0x0039C9D2
		public ERangeLimitingPriority Priority { get; set; }

		// Token: 0x17007A3B RID: 31291
		// (get) Token: 0x060195AE RID: 103854 RVA: 0x0039E7DB File Offset: 0x0039C9DB
		// (set) Token: 0x060195AF RID: 103855 RVA: 0x0039E7E3 File Offset: 0x0039C9E3
		public IVectorInfoT Point { get; set; }

		// Token: 0x17007A3C RID: 31292
		// (get) Token: 0x060195B0 RID: 103856 RVA: 0x0039E7EC File Offset: 0x0039C9EC
		// (set) Token: 0x060195B1 RID: 103857 RVA: 0x0039E7F4 File Offset: 0x0039C9F4
		public int Range { get; set; }

		// Token: 0x17007A3D RID: 31293
		// (get) Token: 0x060195B2 RID: 103858 RVA: 0x0039E7FD File Offset: 0x0039C9FD
		// (set) Token: 0x060195B3 RID: 103859 RVA: 0x0039E805 File Offset: 0x0039CA05
		public string RangeEffectPath { get; set; }

		// Token: 0x17007A3E RID: 31294
		// (get) Token: 0x060195B4 RID: 103860 RVA: 0x0039E80E File Offset: 0x0039CA0E
		// (set) Token: 0x060195B5 RID: 103861 RVA: 0x0039E816 File Offset: 0x0039CA16
		public float OverRangeCountdown { get; set; }

		// Token: 0x17007A3F RID: 31295
		// (get) Token: 0x060195B6 RID: 103862 RVA: 0x0039E81F File Offset: 0x0039CA1F
		// (set) Token: 0x060195B7 RID: 103863 RVA: 0x0039E827 File Offset: 0x0039CA27
		public int WarningRange { get; set; }

		// Token: 0x17007A40 RID: 31296
		// (get) Token: 0x060195B8 RID: 103864 RVA: 0x0039E830 File Offset: 0x0039CA30
		// (set) Token: 0x060195B9 RID: 103865 RVA: 0x0039E838 File Offset: 0x0039CA38
		public bool RequiresSecondConfirmation { get; set; }

		// Token: 0x17007A41 RID: 31297
		// (get) Token: 0x060195BA RID: 103866 RVA: 0x0039E841 File Offset: 0x0039CA41
		// (set) Token: 0x060195BB RID: 103867 RVA: 0x0039E849 File Offset: 0x0039CA49
		public List<int> RangeEntities { get; set; }

		// Token: 0x17007A42 RID: 31298
		// (get) Token: 0x060195BC RID: 103868 RVA: 0x0039E852 File Offset: 0x0039CA52
		// (set) Token: 0x060195BD RID: 103869 RVA: 0x0039E85A File Offset: 0x0039CA5A
		public List<int> WarningRangeEntities { get; set; }

		// Token: 0x17007A43 RID: 31299
		// (get) Token: 0x060195BE RID: 103870 RVA: 0x0039E863 File Offset: 0x0039CA63
		// (set) Token: 0x060195BF RID: 103871 RVA: 0x0039E86B File Offset: 0x0039CA6B
		public IWarningPreformT WarningPreform { get; set; }

		// Token: 0x17007A44 RID: 31300
		// (get) Token: 0x060195C0 RID: 103872 RVA: 0x0039E874 File Offset: 0x0039CA74
		// (set) Token: 0x060195C1 RID: 103873 RVA: 0x0039E87C File Offset: 0x0039CA7C
		public List<int> AcceptableDungeonIds { get; set; }

		// Token: 0x17007A45 RID: 31301
		// (get) Token: 0x060195C2 RID: 103874 RVA: 0x0039E885 File Offset: 0x0039CA85
		// (set) Token: 0x060195C3 RID: 103875 RVA: 0x0039E88D File Offset: 0x0039CA8D
		public bool OnlyFailOnceOutsideDungeon { get; set; }

		// Token: 0x17007A46 RID: 31302
		// (get) Token: 0x060195C4 RID: 103876 RVA: 0x0039E896 File Offset: 0x0039CA96
		// (set) Token: 0x060195C5 RID: 103877 RVA: 0x0039E89E File Offset: 0x0039CA9E
		public byte NullMask { get; set; }

		// Token: 0x060195C6 RID: 103878 RVA: 0x0039E8A8 File Offset: 0x0039CAA8
		public IRangeLimitingConditionT()
		{
			this.Priority = ERangeLimitingPriority.Low;
			this.Point = null;
			this.Range = 0;
			this.RangeEffectPath = null;
			this.OverRangeCountdown = 0f;
			this.WarningRange = 0;
			this.RequiresSecondConfirmation = false;
			this.RangeEntities = null;
			this.WarningRangeEntities = null;
			this.WarningPreform = null;
			this.AcceptableDungeonIds = null;
			this.OnlyFailOnceOutsideDungeon = false;
			this.NullMask = 0;
		}
	}
}
