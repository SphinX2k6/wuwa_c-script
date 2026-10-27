using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A1 RID: 22689
	public class ISceneActorRefGroupT
	{
		// Token: 0x1700A9DD RID: 43485
		// (get) Token: 0x06026460 RID: 156768 RVA: 0x00546AF0 File Offset: 0x00544CF0
		// (set) Token: 0x06026461 RID: 156769 RVA: 0x00546AF8 File Offset: 0x00544CF8
		public string EntityState { get; set; }

		// Token: 0x1700A9DE RID: 43486
		// (get) Token: 0x06026462 RID: 156770 RVA: 0x00546B01 File Offset: 0x00544D01
		// (set) Token: 0x06026463 RID: 156771 RVA: 0x00546B09 File Offset: 0x00544D09
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06026464 RID: 156772 RVA: 0x00546B12 File Offset: 0x00544D12
		public ISceneActorRefGroupT()
		{
			this.EntityState = null;
			this.Actions = null;
		}
	}
}
