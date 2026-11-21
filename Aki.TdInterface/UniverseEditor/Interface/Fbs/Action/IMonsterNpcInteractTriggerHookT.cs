using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007220 RID: 29216
	public class IMonsterNpcInteractTriggerHookT
	{
		// Token: 0x1700D5D6 RID: 54742
		// (get) Token: 0x06032D62 RID: 208226 RVA: 0x006DD490 File Offset: 0x006DB690
		// (set) Token: 0x06032D63 RID: 208227 RVA: 0x006DD498 File Offset: 0x006DB698
		public EMonsterNpcInteractType Type { get; set; }

		// Token: 0x1700D5D7 RID: 54743
		// (get) Token: 0x06032D64 RID: 208228 RVA: 0x006DD4A1 File Offset: 0x006DB6A1
		// (set) Token: 0x06032D65 RID: 208229 RVA: 0x006DD4A9 File Offset: 0x006DB6A9
		public int HookEntityId { get; set; }

		// Token: 0x06032D66 RID: 208230 RVA: 0x006DD4B2 File Offset: 0x006DB6B2
		public IMonsterNpcInteractTriggerHookT()
		{
			this.Type = EMonsterNpcInteractType.TriggerHook;
			this.HookEntityId = 0;
		}
	}
}
