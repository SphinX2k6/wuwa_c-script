using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F93 RID: 20371
	public class ICheckLevelPlayStateT
	{
		// Token: 0x170091B0 RID: 37296
		// (get) Token: 0x0601FBBF RID: 129983 RVA: 0x00469098 File Offset: 0x00467298
		// (set) Token: 0x0601FBC0 RID: 129984 RVA: 0x004690A0 File Offset: 0x004672A0
		public ECondition Type { get; set; }

		// Token: 0x170091B1 RID: 37297
		// (get) Token: 0x0601FBC1 RID: 129985 RVA: 0x004690A9 File Offset: 0x004672A9
		// (set) Token: 0x0601FBC2 RID: 129986 RVA: 0x004690B1 File Offset: 0x004672B1
		public int LevelId { get; set; }

		// Token: 0x170091B2 RID: 37298
		// (get) Token: 0x0601FBC3 RID: 129987 RVA: 0x004690BA File Offset: 0x004672BA
		// (set) Token: 0x0601FBC4 RID: 129988 RVA: 0x004690C2 File Offset: 0x004672C2
		public ECompare Compare { get; set; }

		// Token: 0x170091B3 RID: 37299
		// (get) Token: 0x0601FBC5 RID: 129989 RVA: 0x004690CB File Offset: 0x004672CB
		// (set) Token: 0x0601FBC6 RID: 129990 RVA: 0x004690D3 File Offset: 0x004672D3
		public ELevelPlayState State { get; set; }

		// Token: 0x0601FBC7 RID: 129991 RVA: 0x004690DC File Offset: 0x004672DC
		public ICheckLevelPlayStateT()
		{
			this.Type = ECondition.CompareVar;
			this.LevelId = 0;
			this.Compare = ECompare.Eq;
			this.State = ELevelPlayState.Close;
		}
	}
}
