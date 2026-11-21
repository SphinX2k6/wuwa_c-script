using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004068 RID: 16488
	public class ITipActorTransformT
	{
		// Token: 0x17007043 RID: 28739
		// (get) Token: 0x06016B07 RID: 92935 RVA: 0x0033E400 File Offset: 0x0033C600
		// (set) Token: 0x06016B08 RID: 92936 RVA: 0x0033E408 File Offset: 0x0033C608
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17007044 RID: 28740
		// (get) Token: 0x06016B09 RID: 92937 RVA: 0x0033E411 File Offset: 0x0033C611
		// (set) Token: 0x06016B0A RID: 92938 RVA: 0x0033E419 File Offset: 0x0033C619
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17007045 RID: 28741
		// (get) Token: 0x06016B0B RID: 92939 RVA: 0x0033E422 File Offset: 0x0033C622
		// (set) Token: 0x06016B0C RID: 92940 RVA: 0x0033E42A File Offset: 0x0033C62A
		public IVectorInfoT Rot { get; set; }

		// Token: 0x06016B0D RID: 92941 RVA: 0x0033E433 File Offset: 0x0033C633
		public ITipActorTransformT()
		{
			this.Type = ETipsActorTransformType.Absolute;
			this.Pos = null;
			this.Rot = null;
		}
	}
}
