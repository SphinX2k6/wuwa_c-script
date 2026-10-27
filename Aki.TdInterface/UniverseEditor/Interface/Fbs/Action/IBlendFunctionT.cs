using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006213 RID: 25107
	public class IBlendFunctionT
	{
		// Token: 0x1700BB1E RID: 47902
		// (get) Token: 0x0602B477 RID: 177271 RVA: 0x005F619D File Offset: 0x005F439D
		// (set) Token: 0x0602B478 RID: 177272 RVA: 0x005F61A5 File Offset: 0x005F43A5
		public EViewTargetBlendFunction Type { get; set; }

		// Token: 0x1700BB1F RID: 47903
		// (get) Token: 0x0602B479 RID: 177273 RVA: 0x005F61AE File Offset: 0x005F43AE
		// (set) Token: 0x0602B47A RID: 177274 RVA: 0x005F61B6 File Offset: 0x005F43B6
		public float BlendExp { get; set; }

		// Token: 0x1700BB20 RID: 47904
		// (get) Token: 0x0602B47B RID: 177275 RVA: 0x005F61BF File Offset: 0x005F43BF
		// (set) Token: 0x0602B47C RID: 177276 RVA: 0x005F61C7 File Offset: 0x005F43C7
		public string CurveAsset { get; set; }

		// Token: 0x0602B47D RID: 177277 RVA: 0x005F61D0 File Offset: 0x005F43D0
		public IBlendFunctionT()
		{
			this.Type = EViewTargetBlendFunction.Linear;
			this.BlendExp = 0f;
			this.CurveAsset = null;
		}
	}
}
