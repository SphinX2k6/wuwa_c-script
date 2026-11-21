using System;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FFC RID: 24572
	public class NpcElementalDetectableComponent : BaseElementalDetectableComponent
	{
		// Token: 0x17006F7C RID: 28540
		// (get) Token: 0x0603B081 RID: 241793 RVA: 0x010B1235 File Offset: 0x010AF435
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17006F7D RID: 28541
		// (get) Token: 0x0603B082 RID: 241794 RVA: 0x010B1238 File Offset: 0x010AF438
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17006F7E RID: 28542
		// (get) Token: 0x0603B083 RID: 241795 RVA: 0x010B123B File Offset: 0x010AF43B
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}
	}
}
