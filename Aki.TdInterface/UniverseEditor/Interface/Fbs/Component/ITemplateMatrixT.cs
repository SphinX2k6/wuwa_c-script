using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A56 RID: 23126
	public class ITemplateMatrixT
	{
		// Token: 0x1700AE04 RID: 44548
		// (get) Token: 0x0602757A RID: 161146 RVA: 0x0056A10F File Offset: 0x0056830F
		// (set) Token: 0x0602757B RID: 161147 RVA: 0x0056A117 File Offset: 0x00568317
		public ESpawnConfigType Type { get; set; }

		// Token: 0x1700AE05 RID: 44549
		// (get) Token: 0x0602757C RID: 161148 RVA: 0x0056A120 File Offset: 0x00568320
		// (set) Token: 0x0602757D RID: 161149 RVA: 0x0056A128 File Offset: 0x00568328
		public IVector2T MatrixSize { get; set; }

		// Token: 0x1700AE06 RID: 44550
		// (get) Token: 0x0602757E RID: 161150 RVA: 0x0056A131 File Offset: 0x00568331
		// (set) Token: 0x0602757F RID: 161151 RVA: 0x0056A139 File Offset: 0x00568339
		public List<ITemplateMatrixRowT> TemplateMatrix { get; set; }

		// Token: 0x1700AE07 RID: 44551
		// (get) Token: 0x06027580 RID: 161152 RVA: 0x0056A142 File Offset: 0x00568342
		// (set) Token: 0x06027581 RID: 161153 RVA: 0x0056A14A File Offset: 0x0056834A
		public IVectorInfoT EntityInterval { get; set; }

		// Token: 0x1700AE08 RID: 44552
		// (get) Token: 0x06027582 RID: 161154 RVA: 0x0056A153 File Offset: 0x00568353
		// (set) Token: 0x06027583 RID: 161155 RVA: 0x0056A15B File Offset: 0x0056835B
		public bool IsInitHide { get; set; }

		// Token: 0x1700AE09 RID: 44553
		// (get) Token: 0x06027584 RID: 161156 RVA: 0x0056A164 File Offset: 0x00568364
		// (set) Token: 0x06027585 RID: 161157 RVA: 0x0056A16C File Offset: 0x0056836C
		public List<IGroupDestroyListenConfigT> GroupDestroyListenConfigs { get; set; }

		// Token: 0x1700AE0A RID: 44554
		// (get) Token: 0x06027586 RID: 161158 RVA: 0x0056A175 File Offset: 0x00568375
		// (set) Token: 0x06027587 RID: 161159 RVA: 0x0056A17D File Offset: 0x0056837D
		public List<IChildEntityStateControlT> ChildEntityStateControls { get; set; }

		// Token: 0x1700AE0B RID: 44555
		// (get) Token: 0x06027588 RID: 161160 RVA: 0x0056A186 File Offset: 0x00568386
		// (set) Token: 0x06027589 RID: 161161 RVA: 0x0056A18E File Offset: 0x0056838E
		public List<IActionInfoT> OnNonGroupEntityDestroy { get; set; }

		// Token: 0x1700AE0C RID: 44556
		// (get) Token: 0x0602758A RID: 161162 RVA: 0x0056A197 File Offset: 0x00568397
		// (set) Token: 0x0602758B RID: 161163 RVA: 0x0056A19F File Offset: 0x0056839F
		public IChangeTemplateInstanceStateConfigT NonGroupDestroyChangeInstanceStateConfig { get; set; }

		// Token: 0x1700AE0D RID: 44557
		// (get) Token: 0x0602758C RID: 161164 RVA: 0x0056A1A8 File Offset: 0x005683A8
		// (set) Token: 0x0602758D RID: 161165 RVA: 0x0056A1B0 File Offset: 0x005683B0
		public byte NullMask { get; set; }

		// Token: 0x0602758E RID: 161166 RVA: 0x0056A1BC File Offset: 0x005683BC
		public ITemplateMatrixT()
		{
			this.Type = ESpawnConfigType.TemplateMatrix;
			this.MatrixSize = null;
			this.TemplateMatrix = null;
			this.EntityInterval = null;
			this.IsInitHide = false;
			this.GroupDestroyListenConfigs = null;
			this.ChildEntityStateControls = null;
			this.OnNonGroupEntityDestroy = null;
			this.NonGroupDestroyChangeInstanceStateConfig = null;
			this.NullMask = 0;
		}
	}
}
