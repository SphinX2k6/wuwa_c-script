using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F5D RID: 20317
	public class ICheckIsInDragActorPlayT
	{
		// Token: 0x17009135 RID: 37173
		// (get) Token: 0x0601F9DF RID: 129503 RVA: 0x00465B8C File Offset: 0x00463D8C
		// (set) Token: 0x0601F9E0 RID: 129504 RVA: 0x00465B94 File Offset: 0x00463D94
		public ECondition Type { get; set; }

		// Token: 0x17009136 RID: 37174
		// (get) Token: 0x0601F9E1 RID: 129505 RVA: 0x00465B9D File Offset: 0x00463D9D
		// (set) Token: 0x0601F9E2 RID: 129506 RVA: 0x00465BA5 File Offset: 0x00463DA5
		public bool IsIn { get; set; }

		// Token: 0x0601F9E3 RID: 129507 RVA: 0x00465BAE File Offset: 0x00463DAE
		public ICheckIsInDragActorPlayT()
		{
			this.Type = ECondition.CompareVar;
			this.IsIn = false;
		}
	}
}
