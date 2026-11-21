using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580F RID: 22543
	public class IFollowShooterJellyFishConfigT
	{
		// Token: 0x1700A329 RID: 41769
		// (get) Token: 0x0602478C RID: 149388 RVA: 0x00503083 File Offset: 0x00501283
		// (set) Token: 0x0602478D RID: 149389 RVA: 0x0050308B File Offset: 0x0050128B
		public EFollowShooterType Type { get; set; }

		// Token: 0x1700A32A RID: 41770
		// (get) Token: 0x0602478E RID: 149390 RVA: 0x00503094 File Offset: 0x00501294
		// (set) Token: 0x0602478F RID: 149391 RVA: 0x0050309C File Offset: 0x0050129C
		public float ResetRange { get; set; }

		// Token: 0x1700A32B RID: 41771
		// (get) Token: 0x06024790 RID: 149392 RVA: 0x005030A5 File Offset: 0x005012A5
		// (set) Token: 0x06024791 RID: 149393 RVA: 0x005030AD File Offset: 0x005012AD
		public float ShineRadius { get; set; }

		// Token: 0x1700A32C RID: 41772
		// (get) Token: 0x06024792 RID: 149394 RVA: 0x005030B6 File Offset: 0x005012B6
		// (set) Token: 0x06024793 RID: 149395 RVA: 0x005030BE File Offset: 0x005012BE
		public int ShineEffect { get; set; }

		// Token: 0x1700A32D RID: 41773
		// (get) Token: 0x06024794 RID: 149396 RVA: 0x005030C7 File Offset: 0x005012C7
		// (set) Token: 0x06024795 RID: 149397 RVA: 0x005030CF File Offset: 0x005012CF
		public List<IFollowShooterMontageT> MontageList { get; set; }

		// Token: 0x1700A32E RID: 41774
		// (get) Token: 0x06024796 RID: 149398 RVA: 0x005030D8 File Offset: 0x005012D8
		// (set) Token: 0x06024797 RID: 149399 RVA: 0x005030E0 File Offset: 0x005012E0
		public byte NullMask { get; set; }

		// Token: 0x06024798 RID: 149400 RVA: 0x005030E9 File Offset: 0x005012E9
		public IFollowShooterJellyFishConfigT()
		{
			this.Type = EFollowShooterType.JellyFish;
			this.ResetRange = 0f;
			this.ShineRadius = 0f;
			this.ShineEffect = 0;
			this.MontageList = null;
			this.NullMask = 0;
		}
	}
}
