using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050B2 RID: 20658
	public class IDoubleViewBossStateViewStyleT
	{
		// Token: 0x17009624 RID: 38436
		// (get) Token: 0x0602130F RID: 135951 RVA: 0x0049C835 File Offset: 0x0049AA35
		// (set) Token: 0x06021310 RID: 135952 RVA: 0x0049C83D File Offset: 0x0049AA3D
		public EBossStateViewStyle Type { get; set; }

		// Token: 0x17009625 RID: 38437
		// (get) Token: 0x06021311 RID: 135953 RVA: 0x0049C846 File Offset: 0x0049AA46
		// (set) Token: 0x06021312 RID: 135954 RVA: 0x0049C84E File Offset: 0x0049AA4E
		public EDoubleViewSlot Slot { get; set; }

		// Token: 0x17009626 RID: 38438
		// (get) Token: 0x06021313 RID: 135955 RVA: 0x0049C857 File Offset: 0x0049AA57
		// (set) Token: 0x06021314 RID: 135956 RVA: 0x0049C85F File Offset: 0x0049AA5F
		public IMarkMainStateTextTargetT MainStateTextTarget { get; set; }

		// Token: 0x17009627 RID: 38439
		// (get) Token: 0x06021315 RID: 135957 RVA: 0x0049C868 File Offset: 0x0049AA68
		// (set) Token: 0x06021316 RID: 135958 RVA: 0x0049C870 File Offset: 0x0049AA70
		public int BindMonsterEntityId { get; set; }

		// Token: 0x17009628 RID: 38440
		// (get) Token: 0x06021317 RID: 135959 RVA: 0x0049C879 File Offset: 0x0049AA79
		// (set) Token: 0x06021318 RID: 135960 RVA: 0x0049C881 File Offset: 0x0049AA81
		public byte NullMask { get; set; }

		// Token: 0x06021319 RID: 135961 RVA: 0x0049C88A File Offset: 0x0049AA8A
		public IDoubleViewBossStateViewStyleT()
		{
			this.Type = EBossStateViewStyle.DoubleView;
			this.Slot = EDoubleViewSlot.Left;
			this.MainStateTextTarget = null;
			this.BindMonsterEntityId = 0;
			this.NullMask = 0;
		}
	}
}
