using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CC RID: 29132
	public class IModifyActorMaterialT
	{
		// Token: 0x1700D550 RID: 54608
		// (get) Token: 0x06032ACC RID: 207564 RVA: 0x006D8948 File Offset: 0x006D6B48
		// (set) Token: 0x06032ACD RID: 207565 RVA: 0x006D8950 File Offset: 0x006D6B50
		public List<IActorRefT> ActorRefs { get; set; }

		// Token: 0x1700D551 RID: 54609
		// (get) Token: 0x06032ACE RID: 207566 RVA: 0x006D8959 File Offset: 0x006D6B59
		// (set) Token: 0x06032ACF RID: 207567 RVA: 0x006D8961 File Offset: 0x006D6B61
		public TModifyActorMaterialTypeUnion Config { get; set; }

		// Token: 0x06032AD0 RID: 207568 RVA: 0x006D896A File Offset: 0x006D6B6A
		public IModifyActorMaterialT()
		{
			this.ActorRefs = null;
			this.Config = null;
		}
	}
}
