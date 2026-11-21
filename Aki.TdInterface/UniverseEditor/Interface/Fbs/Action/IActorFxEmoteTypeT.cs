using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006725 RID: 26405
	public class IActorFxEmoteTypeT
	{
		// Token: 0x1700BFF5 RID: 49141
		// (get) Token: 0x0602CB97 RID: 183191 RVA: 0x0061E4DA File Offset: 0x0061C6DA
		// (set) Token: 0x0602CB98 RID: 183192 RVA: 0x0061E4E2 File Offset: 0x0061C6E2
		public EActorFxEmoteType Type { get; set; }

		// Token: 0x0602CB99 RID: 183193 RVA: 0x0061E4EB File Offset: 0x0061C6EB
		public IActorFxEmoteTypeT()
		{
			this.Type = EActorFxEmoteType.Play;
		}
	}
}
