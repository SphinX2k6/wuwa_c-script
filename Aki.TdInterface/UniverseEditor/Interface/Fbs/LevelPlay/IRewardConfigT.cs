using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004546 RID: 17734
	public class IRewardConfigT
	{
		// Token: 0x17007DC9 RID: 32201
		// (get) Token: 0x0601AAF5 RID: 109301 RVA: 0x003CE74F File Offset: 0x003CC94F
		// (set) Token: 0x0601AAF6 RID: 109302 RVA: 0x003CE757 File Offset: 0x003CC957
		public List<int> RewardNodeIds { get; set; }

		// Token: 0x17007DCA RID: 32202
		// (get) Token: 0x0601AAF7 RID: 109303 RVA: 0x003CE760 File Offset: 0x003CC960
		// (set) Token: 0x0601AAF8 RID: 109304 RVA: 0x003CE768 File Offset: 0x003CC968
		public List<int> TreasureBoxIds { get; set; }

		// Token: 0x17007DCB RID: 32203
		// (get) Token: 0x0601AAF9 RID: 109305 RVA: 0x003CE771 File Offset: 0x003CC971
		// (set) Token: 0x0601AAFA RID: 109306 RVA: 0x003CE779 File Offset: 0x003CC979
		public List<int> CompleteRewardIds { get; set; }

		// Token: 0x17007DCC RID: 32204
		// (get) Token: 0x0601AAFB RID: 109307 RVA: 0x003CE782 File Offset: 0x003CC982
		// (set) Token: 0x0601AAFC RID: 109308 RVA: 0x003CE78A File Offset: 0x003CC98A
		public byte NullMask { get; set; }

		// Token: 0x0601AAFD RID: 109309 RVA: 0x003CE793 File Offset: 0x003CC993
		public IRewardConfigT()
		{
			this.RewardNodeIds = null;
			this.TreasureBoxIds = null;
			this.CompleteRewardIds = null;
			this.NullMask = 0;
		}
	}
}
