using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED5 RID: 24277
	public class ISceneItemLifeCycleComponentT
	{
		// Token: 0x1700B35E RID: 45918
		// (get) Token: 0x06028B18 RID: 166680 RVA: 0x0058FF7B File Offset: 0x0058E17B
		// (set) Token: 0x06028B19 RID: 166681 RVA: 0x0058FF83 File Offset: 0x0058E183
		public bool Disabled { get; set; }

		// Token: 0x1700B35F RID: 45919
		// (get) Token: 0x06028B1A RID: 166682 RVA: 0x0058FF8C File Offset: 0x0058E18C
		// (set) Token: 0x06028B1B RID: 166683 RVA: 0x0058FF94 File Offset: 0x0058E194
		public ICreateStageConfigT CreateStageConfig { get; set; }

		// Token: 0x1700B360 RID: 45920
		// (get) Token: 0x06028B1C RID: 166684 RVA: 0x0058FF9D File Offset: 0x0058E19D
		// (set) Token: 0x06028B1D RID: 166685 RVA: 0x0058FFA5 File Offset: 0x0058E1A5
		public IDestroyStageConfigT DestroyStageConfig { get; set; }

		// Token: 0x1700B361 RID: 45921
		// (get) Token: 0x06028B1E RID: 166686 RVA: 0x0058FFAE File Offset: 0x0058E1AE
		// (set) Token: 0x06028B1F RID: 166687 RVA: 0x0058FFB6 File Offset: 0x0058E1B6
		public byte NullMask { get; set; }

		// Token: 0x06028B20 RID: 166688 RVA: 0x0058FFBF File Offset: 0x0058E1BF
		public ISceneItemLifeCycleComponentT()
		{
			this.Disabled = false;
			this.CreateStageConfig = null;
			this.DestroyStageConfig = null;
			this.NullMask = 0;
		}
	}
}
