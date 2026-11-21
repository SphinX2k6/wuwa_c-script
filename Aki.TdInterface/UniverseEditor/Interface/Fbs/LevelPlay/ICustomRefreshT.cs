using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048B8 RID: 18616
	public class ICustomRefreshT
	{
		// Token: 0x1700817F RID: 33151
		// (get) Token: 0x0601B845 RID: 112709 RVA: 0x003E471F File Offset: 0x003E291F
		// (set) Token: 0x0601B846 RID: 112710 RVA: 0x003E4727 File Offset: 0x003E2927
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17008180 RID: 33152
		// (get) Token: 0x0601B847 RID: 112711 RVA: 0x003E4730 File Offset: 0x003E2930
		// (set) Token: 0x0601B848 RID: 112712 RVA: 0x003E4738 File Offset: 0x003E2938
		public IConditionGroupT PreCondition { get; set; }

		// Token: 0x17008181 RID: 33153
		// (get) Token: 0x0601B849 RID: 112713 RVA: 0x003E4741 File Offset: 0x003E2941
		// (set) Token: 0x0601B84A RID: 112714 RVA: 0x003E4749 File Offset: 0x003E2949
		public int CompletedRefreshTime { get; set; }

		// Token: 0x17008182 RID: 33154
		// (get) Token: 0x0601B84B RID: 112715 RVA: 0x003E4752 File Offset: 0x003E2952
		// (set) Token: 0x0601B84C RID: 112716 RVA: 0x003E475A File Offset: 0x003E295A
		public int ChildDestroyRefreshTime { get; set; }

		// Token: 0x17008183 RID: 33155
		// (get) Token: 0x0601B84D RID: 112717 RVA: 0x003E4763 File Offset: 0x003E2963
		// (set) Token: 0x0601B84E RID: 112718 RVA: 0x003E476B File Offset: 0x003E296B
		public int AwardedRefreshTime { get; set; }

		// Token: 0x17008184 RID: 33156
		// (get) Token: 0x0601B84F RID: 112719 RVA: 0x003E4774 File Offset: 0x003E2974
		// (set) Token: 0x0601B850 RID: 112720 RVA: 0x003E477C File Offset: 0x003E297C
		public byte NullMask { get; set; }

		// Token: 0x0601B851 RID: 112721 RVA: 0x003E4785 File Offset: 0x003E2985
		public ICustomRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.PreCondition = null;
			this.CompletedRefreshTime = 0;
			this.ChildDestroyRefreshTime = 0;
			this.AwardedRefreshTime = 0;
			this.NullMask = 0;
		}
	}
}
