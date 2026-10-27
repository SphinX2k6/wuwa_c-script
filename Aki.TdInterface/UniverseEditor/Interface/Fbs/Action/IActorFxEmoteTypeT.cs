using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060C3 RID: 24771
	public class IActorFxEmoteTypeT
	{
		// Token: 0x1700B68A RID: 46730
		// (get) Token: 0x0602A4B6 RID: 173238 RVA: 0x005D4532 File Offset: 0x005D2732
		// (set) Token: 0x0602A4B7 RID: 173239 RVA: 0x005D453A File Offset: 0x005D273A
		public EActorFxEmoteType Type { get; set; }

		// Token: 0x0602A4B8 RID: 173240 RVA: 0x005D4543 File Offset: 0x005D2743
		public IActorFxEmoteTypeT()
		{
			this.Type = EActorFxEmoteType.Play;
		}
	}
}
