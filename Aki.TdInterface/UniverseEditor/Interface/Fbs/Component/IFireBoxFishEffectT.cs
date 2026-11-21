using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C1 RID: 22465
	public class IFireBoxFishEffectT
	{
		// Token: 0x1700A265 RID: 41573
		// (get) Token: 0x06024447 RID: 148551 RVA: 0x004FBF4F File Offset: 0x004FA14F
		// (set) Token: 0x06024448 RID: 148552 RVA: 0x004FBF57 File Offset: 0x004FA157
		public EGraph3dEffectType Type { get; set; }

		// Token: 0x1700A266 RID: 41574
		// (get) Token: 0x06024449 RID: 148553 RVA: 0x004FBF60 File Offset: 0x004FA160
		// (set) Token: 0x0602444A RID: 148554 RVA: 0x004FBF68 File Offset: 0x004FA168
		public string Effect { get; set; }

		// Token: 0x0602444B RID: 148555 RVA: 0x004FBF71 File Offset: 0x004FA171
		public IFireBoxFishEffectT()
		{
			this.Type = EGraph3dEffectType.FireBoxFish;
			this.Effect = null;
		}
	}
}
