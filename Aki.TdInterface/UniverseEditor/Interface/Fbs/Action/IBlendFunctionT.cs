using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006884 RID: 26756
	public class IBlendFunctionT
	{
		// Token: 0x1700C4A4 RID: 50340
		// (get) Token: 0x0602DBD0 RID: 187344 RVA: 0x00640D89 File Offset: 0x0063EF89
		// (set) Token: 0x0602DBD1 RID: 187345 RVA: 0x00640D91 File Offset: 0x0063EF91
		public EViewTargetBlendFunction Type { get; set; }

		// Token: 0x1700C4A5 RID: 50341
		// (get) Token: 0x0602DBD2 RID: 187346 RVA: 0x00640D9A File Offset: 0x0063EF9A
		// (set) Token: 0x0602DBD3 RID: 187347 RVA: 0x00640DA2 File Offset: 0x0063EFA2
		public float BlendExp { get; set; }

		// Token: 0x1700C4A6 RID: 50342
		// (get) Token: 0x0602DBD4 RID: 187348 RVA: 0x00640DAB File Offset: 0x0063EFAB
		// (set) Token: 0x0602DBD5 RID: 187349 RVA: 0x00640DB3 File Offset: 0x0063EFB3
		public string CurveAsset { get; set; }

		// Token: 0x0602DBD6 RID: 187350 RVA: 0x00640DBC File Offset: 0x0063EFBC
		public IBlendFunctionT()
		{
			this.Type = EViewTargetBlendFunction.Linear;
			this.BlendExp = 0f;
			this.CurveAsset = null;
		}
	}
}
