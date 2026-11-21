using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721A RID: 29210
	public class IMonsterNpcInteractConfigBaseT
	{
		// Token: 0x1700D5D0 RID: 54736
		// (get) Token: 0x06032D42 RID: 208194 RVA: 0x006DD1BA File Offset: 0x006DB3BA
		// (set) Token: 0x06032D43 RID: 208195 RVA: 0x006DD1C2 File Offset: 0x006DB3C2
		public EMonsterNpcInteractType Type { get; set; }

		// Token: 0x06032D44 RID: 208196 RVA: 0x006DD1CB File Offset: 0x006DB3CB
		public IMonsterNpcInteractConfigBaseT()
		{
			this.Type = EMonsterNpcInteractType.TriggerHook;
		}
	}
}
