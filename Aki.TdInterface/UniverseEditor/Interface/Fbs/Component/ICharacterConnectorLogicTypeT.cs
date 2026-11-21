using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AF RID: 21679
	public class ICharacterConnectorLogicTypeT
	{
		// Token: 0x17009A91 RID: 39569
		// (get) Token: 0x0602224B RID: 139851 RVA: 0x004B4C53 File Offset: 0x004B2E53
		// (set) Token: 0x0602224C RID: 139852 RVA: 0x004B4C5B File Offset: 0x004B2E5B
		public ECharacterConnectorLogicType Type { get; set; }

		// Token: 0x17009A92 RID: 39570
		// (get) Token: 0x0602224D RID: 139853 RVA: 0x004B4C64 File Offset: 0x004B2E64
		// (set) Token: 0x0602224E RID: 139854 RVA: 0x004B4C6C File Offset: 0x004B2E6C
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x0602224F RID: 139855 RVA: 0x004B4C75 File Offset: 0x004B2E75
		public ICharacterConnectorLogicTypeT()
		{
			this.Type = ECharacterConnectorLogicType.Range;
			this.EffectConfig = null;
		}
	}
}
