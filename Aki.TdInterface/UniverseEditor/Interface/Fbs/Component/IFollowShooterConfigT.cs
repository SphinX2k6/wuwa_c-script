using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200529E RID: 21150
	public class IFollowShooterConfigT
	{
		// Token: 0x17009B1C RID: 39708
		// (get) Token: 0x060227AE RID: 141230 RVA: 0x004C7C82 File Offset: 0x004C5E82
		// (set) Token: 0x060227AF RID: 141231 RVA: 0x004C7C8A File Offset: 0x004C5E8A
		public EFollowShooterType Type { get; set; }

		// Token: 0x060227B0 RID: 141232 RVA: 0x004C7C93 File Offset: 0x004C5E93
		public IFollowShooterConfigT()
		{
			this.Type = EFollowShooterType.JellyFish;
		}
	}
}
