using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BDE RID: 15326
	public class IAbsoluteTipActorTransformT
	{
		// Token: 0x1700691F RID: 26911
		// (get) Token: 0x0601510B RID: 86283 RVA: 0x0030DA8C File Offset: 0x0030BC8C
		// (set) Token: 0x0601510C RID: 86284 RVA: 0x0030DA94 File Offset: 0x0030BC94
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17006920 RID: 26912
		// (get) Token: 0x0601510D RID: 86285 RVA: 0x0030DA9D File Offset: 0x0030BC9D
		// (set) Token: 0x0601510E RID: 86286 RVA: 0x0030DAA5 File Offset: 0x0030BCA5
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006921 RID: 26913
		// (get) Token: 0x0601510F RID: 86287 RVA: 0x0030DAAE File Offset: 0x0030BCAE
		// (set) Token: 0x06015110 RID: 86288 RVA: 0x0030DAB6 File Offset: 0x0030BCB6
		public IVectorInfoT Rot { get; set; }

		// Token: 0x06015111 RID: 86289 RVA: 0x0030DABF File Offset: 0x0030BCBF
		public IAbsoluteTipActorTransformT()
		{
			this.Type = ETipsActorTransformType.Absolute;
			this.Pos = null;
			this.Rot = null;
		}
	}
}
