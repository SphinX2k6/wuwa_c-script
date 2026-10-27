using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D5 RID: 24789
	public class IActorLookAtDataT
	{
		// Token: 0x1700B6AF RID: 46767
		// (get) Token: 0x0602A56A RID: 173418 RVA: 0x005D5E9E File Offset: 0x005D409E
		// (set) Token: 0x0602A56B RID: 173419 RVA: 0x005D5EA6 File Offset: 0x005D40A6
		public EActorLookAtMode Type { get; set; }

		// Token: 0x0602A56C RID: 173420 RVA: 0x005D5EAF File Offset: 0x005D40AF
		public IActorLookAtDataT()
		{
			this.Type = EActorLookAtMode.Talker;
		}
	}
}
