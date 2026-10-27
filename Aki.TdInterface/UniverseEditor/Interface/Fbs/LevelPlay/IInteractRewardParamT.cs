using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E0 RID: 17632
	public class IInteractRewardParamT
	{
		// Token: 0x17007C7B RID: 31867
		// (get) Token: 0x0601A5EC RID: 108012 RVA: 0x003C3A5E File Offset: 0x003C1C5E
		// (set) Token: 0x0601A5ED RID: 108013 RVA: 0x003C3A66 File Offset: 0x003C1C66
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x17007C7C RID: 31868
		// (get) Token: 0x0601A5EE RID: 108014 RVA: 0x003C3A6F File Offset: 0x003C1C6F
		// (set) Token: 0x0601A5EF RID: 108015 RVA: 0x003C3A77 File Offset: 0x003C1C77
		public int RewardId { get; set; }

		// Token: 0x17007C7D RID: 31869
		// (get) Token: 0x0601A5F0 RID: 108016 RVA: 0x003C3A80 File Offset: 0x003C1C80
		// (set) Token: 0x0601A5F1 RID: 108017 RVA: 0x003C3A88 File Offset: 0x003C1C88
		public int FirstRewardId { get; set; }

		// Token: 0x17007C7E RID: 31870
		// (get) Token: 0x0601A5F2 RID: 108018 RVA: 0x003C3A91 File Offset: 0x003C1C91
		// (set) Token: 0x0601A5F3 RID: 108019 RVA: 0x003C3A99 File Offset: 0x003C1C99
		public int RewardEntityId { get; set; }

		// Token: 0x17007C7F RID: 31871
		// (get) Token: 0x0601A5F4 RID: 108020 RVA: 0x003C3AA2 File Offset: 0x003C1CA2
		// (set) Token: 0x0601A5F5 RID: 108021 RVA: 0x003C3AAA File Offset: 0x003C1CAA
		public ILevelPlayInteractResetOptionT Reset { get; set; }

		// Token: 0x17007C80 RID: 31872
		// (get) Token: 0x0601A5F6 RID: 108022 RVA: 0x003C3AB3 File Offset: 0x003C1CB3
		// (set) Token: 0x0601A5F7 RID: 108023 RVA: 0x003C3ABB File Offset: 0x003C1CBB
		public List<IActionInfoT> RewardCompleteActions { get; set; }

		// Token: 0x17007C81 RID: 31873
		// (get) Token: 0x0601A5F8 RID: 108024 RVA: 0x003C3AC4 File Offset: 0x003C1CC4
		// (set) Token: 0x0601A5F9 RID: 108025 RVA: 0x003C3ACC File Offset: 0x003C1CCC
		public List<IActionInfoT> FirstCompleteActions { get; set; }

		// Token: 0x17007C82 RID: 31874
		// (get) Token: 0x0601A5FA RID: 108026 RVA: 0x003C3AD5 File Offset: 0x003C1CD5
		// (set) Token: 0x0601A5FB RID: 108027 RVA: 0x003C3ADD File Offset: 0x003C1CDD
		public byte NullMask { get; set; }

		// Token: 0x0601A5FC RID: 108028 RVA: 0x003C3AE6 File Offset: 0x003C1CE6
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
