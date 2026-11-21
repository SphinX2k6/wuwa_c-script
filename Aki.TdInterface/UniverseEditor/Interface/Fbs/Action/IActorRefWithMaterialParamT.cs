using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006758 RID: 26456
	public class IActorRefWithMaterialParamT
	{
		// Token: 0x1700C05F RID: 49247
		// (get) Token: 0x0602CD65 RID: 183653 RVA: 0x00621C47 File Offset: 0x0061FE47
		// (set) Token: 0x0602CD66 RID: 183654 RVA: 0x00621C4F File Offset: 0x0061FE4F
		public IActorRefT ActorRef { get; set; }

		// Token: 0x1700C060 RID: 49248
		// (get) Token: 0x0602CD67 RID: 183655 RVA: 0x00621C58 File Offset: 0x0061FE58
		// (set) Token: 0x0602CD68 RID: 183656 RVA: 0x00621C60 File Offset: 0x0061FE60
		public string MaterialParam { get; set; }

		// Token: 0x0602CD69 RID: 183657 RVA: 0x00621C69 File Offset: 0x0061FE69
		public IActorRefWithMaterialParamT()
		{
			this.ActorRef = null;
			this.MaterialParam = null;
		}
	}
}
