using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006719 RID: 26393
	public class IActorFxEmoteStopAllT
	{
		// Token: 0x1700BFE8 RID: 49128
		// (get) Token: 0x0602CB49 RID: 183113 RVA: 0x0061DD62 File Offset: 0x0061BF62
		// (set) Token: 0x0602CB4A RID: 183114 RVA: 0x0061DD6A File Offset: 0x0061BF6A
		public EActorFxEmoteStopSubType Type { get; set; }

		// Token: 0x0602CB4B RID: 183115 RVA: 0x0061DD73 File Offset: 0x0061BF73
		public IActorFxEmoteStopAllT()
		{
			this.Type = EActorFxEmoteStopSubType.StopAll;
		}
	}
}
