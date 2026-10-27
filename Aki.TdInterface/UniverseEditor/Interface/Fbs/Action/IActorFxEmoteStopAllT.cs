using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B7 RID: 24759
	public class IActorFxEmoteStopAllT
	{
		// Token: 0x1700B67D RID: 46717
		// (get) Token: 0x0602A468 RID: 173160 RVA: 0x005D3DBA File Offset: 0x005D1FBA
		// (set) Token: 0x0602A469 RID: 173161 RVA: 0x005D3DC2 File Offset: 0x005D1FC2
		public EActorFxEmoteStopSubType Type { get; set; }

		// Token: 0x0602A46A RID: 173162 RVA: 0x005D3DCB File Offset: 0x005D1FCB
		public IActorFxEmoteStopAllT()
		{
			this.Type = EActorFxEmoteStopSubType.StopAll;
		}
	}
}
