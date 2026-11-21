using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200587B RID: 22651
	public class IGodKingFrequencyControllerComponentT
	{
		// Token: 0x1700A420 RID: 42016
		// (get) Token: 0x06024B9A RID: 150426 RVA: 0x0050B703 File Offset: 0x00509903
		// (set) Token: 0x06024B9B RID: 150427 RVA: 0x0050B70B File Offset: 0x0050990B
		public bool Disabled { get; set; }

		// Token: 0x1700A421 RID: 42017
		// (get) Token: 0x06024B9C RID: 150428 RVA: 0x0050B714 File Offset: 0x00509914
		// (set) Token: 0x06024B9D RID: 150429 RVA: 0x0050B71C File Offset: 0x0050991C
		public List<int> StatueEntityIdList { get; set; }

		// Token: 0x1700A422 RID: 42018
		// (get) Token: 0x06024B9E RID: 150430 RVA: 0x0050B725 File Offset: 0x00509925
		// (set) Token: 0x06024B9F RID: 150431 RVA: 0x0050B72D File Offset: 0x0050992D
		public int InitialAttachStatue { get; set; }

		// Token: 0x1700A423 RID: 42019
		// (get) Token: 0x06024BA0 RID: 150432 RVA: 0x0050B736 File Offset: 0x00509936
		// (set) Token: 0x06024BA1 RID: 150433 RVA: 0x0050B73E File Offset: 0x0050993E
		public int GodKingFrequencyEntity { get; set; }

		// Token: 0x1700A424 RID: 42020
		// (get) Token: 0x06024BA2 RID: 150434 RVA: 0x0050B747 File Offset: 0x00509947
		// (set) Token: 0x06024BA3 RID: 150435 RVA: 0x0050B74F File Offset: 0x0050994F
		public string AttachSocket { get; set; }

		// Token: 0x1700A425 RID: 42021
		// (get) Token: 0x06024BA4 RID: 150436 RVA: 0x0050B758 File Offset: 0x00509958
		// (set) Token: 0x06024BA5 RID: 150437 RVA: 0x0050B760 File Offset: 0x00509960
		public float FlySpeed { get; set; }

		// Token: 0x1700A426 RID: 42022
		// (get) Token: 0x06024BA6 RID: 150438 RVA: 0x0050B769 File Offset: 0x00509969
		// (set) Token: 0x06024BA7 RID: 150439 RVA: 0x0050B771 File Offset: 0x00509971
		public float MaxFlyTime { get; set; }

		// Token: 0x1700A427 RID: 42023
		// (get) Token: 0x06024BA8 RID: 150440 RVA: 0x0050B77A File Offset: 0x0050997A
		// (set) Token: 0x06024BA9 RID: 150441 RVA: 0x0050B782 File Offset: 0x00509982
		public byte NullMask { get; set; }

		// Token: 0x06024BAA RID: 150442 RVA: 0x0050B78C File Offset: 0x0050998C
		public IGodKingFrequencyControllerComponentT()
		{
			this.Disabled = false;
			this.StatueEntityIdList = null;
			this.InitialAttachStatue = 0;
			this.GodKingFrequencyEntity = 0;
			this.AttachSocket = null;
			this.FlySpeed = 0f;
			this.MaxFlyTime = 0f;
			this.NullMask = 0;
		}
	}
}
