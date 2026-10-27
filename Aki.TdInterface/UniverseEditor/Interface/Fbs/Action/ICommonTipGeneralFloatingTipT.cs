using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200649C RID: 25756
	public class ICommonTipGeneralFloatingTipT
	{
		// Token: 0x1700BFAB RID: 49067
		// (get) Token: 0x0602CA40 RID: 182848 RVA: 0x0062101F File Offset: 0x0061F21F
		// (set) Token: 0x0602CA41 RID: 182849 RVA: 0x00621027 File Offset: 0x0061F227
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BFAC RID: 49068
		// (get) Token: 0x0602CA42 RID: 182850 RVA: 0x00621030 File Offset: 0x0061F230
		// (set) Token: 0x0602CA43 RID: 182851 RVA: 0x00621038 File Offset: 0x0061F238
		public string TidMainText { get; set; }

		// Token: 0x0602CA44 RID: 182852 RVA: 0x00621041 File Offset: 0x0061F241
		public ICommonTipGeneralFloatingTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
