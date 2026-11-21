using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004948 RID: 18760
	public class IInteractRewardParamT
	{
		// Token: 0x170082BA RID: 33466
		// (get) Token: 0x0601BDBD RID: 114109 RVA: 0x003EFC6A File Offset: 0x003EDE6A
		// (set) Token: 0x0601BDBE RID: 114110 RVA: 0x003EFC72 File Offset: 0x003EDE72
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x170082BB RID: 33467
		// (get) Token: 0x0601BDBF RID: 114111 RVA: 0x003EFC7B File Offset: 0x003EDE7B
		// (set) Token: 0x0601BDC0 RID: 114112 RVA: 0x003EFC83 File Offset: 0x003EDE83
		public int RewardId { get; set; }

		// Token: 0x170082BC RID: 33468
		// (get) Token: 0x0601BDC1 RID: 114113 RVA: 0x003EFC8C File Offset: 0x003EDE8C
		// (set) Token: 0x0601BDC2 RID: 114114 RVA: 0x003EFC94 File Offset: 0x003EDE94
		public int FirstRewardId { get; set; }

		// Token: 0x170082BD RID: 33469
		// (get) Token: 0x0601BDC3 RID: 114115 RVA: 0x003EFC9D File Offset: 0x003EDE9D
		// (set) Token: 0x0601BDC4 RID: 114116 RVA: 0x003EFCA5 File Offset: 0x003EDEA5
		public int RewardEntityId { get; set; }

		// Token: 0x170082BE RID: 33470
		// (get) Token: 0x0601BDC5 RID: 114117 RVA: 0x003EFCAE File Offset: 0x003EDEAE
		// (set) Token: 0x0601BDC6 RID: 114118 RVA: 0x003EFCB6 File Offset: 0x003EDEB6
		public ILevelPlayInteractResetOptionT Reset { get; set; }

		// Token: 0x170082BF RID: 33471
		// (get) Token: 0x0601BDC7 RID: 114119 RVA: 0x003EFCBF File Offset: 0x003EDEBF
		// (set) Token: 0x0601BDC8 RID: 114120 RVA: 0x003EFCC7 File Offset: 0x003EDEC7
		public List<IActionInfoT> RewardCompleteActions { get; set; }

		// Token: 0x170082C0 RID: 33472
		// (get) Token: 0x0601BDC9 RID: 114121 RVA: 0x003EFCD0 File Offset: 0x003EDED0
		// (set) Token: 0x0601BDCA RID: 114122 RVA: 0x003EFCD8 File Offset: 0x003EDED8
		public List<IActionInfoT> FirstCompleteActions { get; set; }

		// Token: 0x170082C1 RID: 33473
		// (get) Token: 0x0601BDCB RID: 114123 RVA: 0x003EFCE1 File Offset: 0x003EDEE1
		// (set) Token: 0x0601BDCC RID: 114124 RVA: 0x003EFCE9 File Offset: 0x003EDEE9
		public byte NullMask { get; set; }

		// Token: 0x0601BDCD RID: 114125 RVA: 0x003EFCF2 File Offset: 0x003EDEF2
		public IInteractRewardParamT()
		{
			this.Type = ELevelPlayRewardType.None;
			this.RewardId = 0;
			this.FirstRewardId = 0;
			this.RewardEntityId = 0;
			this.Reset = null;
			this.RewardCompleteActions = null;
			this.FirstCompleteActions = null;
			this.NullMask = 0;
		}
	}
}
