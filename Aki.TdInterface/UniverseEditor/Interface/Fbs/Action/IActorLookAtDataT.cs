using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006737 RID: 26423
	public class IActorLookAtDataT
	{
		// Token: 0x1700C01A RID: 49178
		// (get) Token: 0x0602CC4B RID: 183371 RVA: 0x0061FE46 File Offset: 0x0061E046
		// (set) Token: 0x0602CC4C RID: 183372 RVA: 0x0061FE4E File Offset: 0x0061E04E
		public EActorLookAtMode Type { get; set; }

		// Token: 0x0602CC4D RID: 183373 RVA: 0x0061FE57 File Offset: 0x0061E057
		public IActorLookAtDataT()
		{
			this.Type = EActorLookAtMode.Talker;
		}
	}
}
