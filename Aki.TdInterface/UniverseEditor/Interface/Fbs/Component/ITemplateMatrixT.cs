using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006063 RID: 24675
	public class ITemplateMatrixT
	{
		// Token: 0x1700B73C RID: 46908
		// (get) Token: 0x06029AF2 RID: 170738 RVA: 0x005B111B File Offset: 0x005AF31B
		// (set) Token: 0x06029AF3 RID: 170739 RVA: 0x005B1123 File Offset: 0x005AF323
		public ESpawnConfigType Type { get; set; }

		// Token: 0x1700B73D RID: 46909
		// (get) Token: 0x06029AF4 RID: 170740 RVA: 0x005B112C File Offset: 0x005AF32C
		// (set) Token: 0x06029AF5 RID: 170741 RVA: 0x005B1134 File Offset: 0x005AF334
		public IVector2T MatrixSize { get; set; }

		// Token: 0x1700B73E RID: 46910
		// (get) Token: 0x06029AF6 RID: 170742 RVA: 0x005B113D File Offset: 0x005AF33D
		// (set) Token: 0x06029AF7 RID: 170743 RVA: 0x005B1145 File Offset: 0x005AF345
		public List<ITemplateMatrixRowT> TemplateMatrix { get; set; }

		// Token: 0x1700B73F RID: 46911
		// (get) Token: 0x06029AF8 RID: 170744 RVA: 0x005B114E File Offset: 0x005AF34E
		// (set) Token: 0x06029AF9 RID: 170745 RVA: 0x005B1156 File Offset: 0x005AF356
		public IVectorInfoT EntityInterval { get; set; }

		// Token: 0x1700B740 RID: 46912
		// (get) Token: 0x06029AFA RID: 170746 RVA: 0x005B115F File Offset: 0x005AF35F
		// (set) Token: 0x06029AFB RID: 170747 RVA: 0x005B1167 File Offset: 0x005AF367
		public bool IsInitHide { get; set; }

		// Token: 0x1700B741 RID: 46913
		// (get) Token: 0x06029AFC RID: 170748 RVA: 0x005B1170 File Offset: 0x005AF370
		// (set) Token: 0x06029AFD RID: 170749 RVA: 0x005B1178 File Offset: 0x005AF378
		public List<IGroupDestroyListenConfigT> GroupDestroyListenConfigs { get; set; }

		// Token: 0x1700B742 RID: 46914
		// (get) Token: 0x06029AFE RID: 170750 RVA: 0x005B1181 File Offset: 0x005AF381
		// (set) Token: 0x06029AFF RID: 170751 RVA: 0x005B1189 File Offset: 0x005AF389
		public List<IChildEntityStateControlT> ChildEntityStateControls { get; set; }

		// Token: 0x1700B743 RID: 46915
		// (get) Token: 0x06029B00 RID: 170752 RVA: 0x005B1192 File Offset: 0x005AF392
		// (set) Token: 0x06029B01 RID: 170753 RVA: 0x005B119A File Offset: 0x005AF39A
		public List<IActionInfoT> OnNonGroupEntityDestroy { get; set; }

		// Token: 0x1700B744 RID: 46916
		// (get) Token: 0x06029B02 RID: 170754 RVA: 0x005B11A3 File Offset: 0x005AF3A3
		// (set) Token: 0x06029B03 RID: 170755 RVA: 0x005B11AB File Offset: 0x005AF3AB
		public IChangeTemplateInstanceStateConfigT NonGroupDestroyChangeInstanceStateConfig { get; set; }

		// Token: 0x1700B745 RID: 46917
		// (get) Token: 0x06029B04 RID: 170756 RVA: 0x005B11B4 File Offset: 0x005AF3B4
		// (set) Token: 0x06029B05 RID: 170757 RVA: 0x005B11BC File Offset: 0x005AF3BC
		public byte NullMask { get; set; }

		// Token: 0x06029B06 RID: 170758 RVA: 0x005B11C8 File Offset: 0x005AF3C8
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
