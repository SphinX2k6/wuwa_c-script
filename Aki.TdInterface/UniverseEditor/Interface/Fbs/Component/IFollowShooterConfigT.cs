using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005806 RID: 22534
	public class IFollowShooterConfigT
	{
		// Token: 0x1700A31A RID: 41754
		// (get) Token: 0x06024748 RID: 149320 RVA: 0x005027F2 File Offset: 0x005009F2
		// (set) Token: 0x06024749 RID: 149321 RVA: 0x005027FA File Offset: 0x005009FA
		public EFollowShooterType Type { get; set; }

		// Token: 0x0602474A RID: 149322 RVA: 0x00502803 File Offset: 0x00500A03
		public IFollowShooterConfigT()
		{
			this.Type = EFollowShooterType.JellyFish;
		}
	}
}
