using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006818 RID: 26648
	public class IAstrologyTextUiConfigT
	{
		// Token: 0x1700C3E4 RID: 50148
		// (get) Token: 0x0602D873 RID: 186483 RVA: 0x0063B55C File Offset: 0x0063975C
		// (set) Token: 0x0602D874 RID: 186484 RVA: 0x0063B564 File Offset: 0x00639764
		public ETextUiType Type { get; set; }

		// Token: 0x1700C3E5 RID: 50149
		// (get) Token: 0x0602D875 RID: 186485 RVA: 0x0063B56D File Offset: 0x0063976D
		// (set) Token: 0x0602D876 RID: 186486 RVA: 0x0063B575 File Offset: 0x00639775
		public string InitTipText { get; set; }

		// Token: 0x1700C3E6 RID: 50150
		// (get) Token: 0x0602D877 RID: 186487 RVA: 0x0063B57E File Offset: 0x0063977E
		// (set) Token: 0x0602D878 RID: 186488 RVA: 0x0063B586 File Offset: 0x00639786
		public string ProgressTipText { get; set; }

		// Token: 0x1700C3E7 RID: 50151
		// (get) Token: 0x0602D879 RID: 186489 RVA: 0x0063B58F File Offset: 0x0063978F
		// (set) Token: 0x0602D87A RID: 186490 RVA: 0x0063B597 File Offset: 0x00639797
		public string SkipText { get; set; }

		// Token: 0x1700C3E8 RID: 50152
		// (get) Token: 0x0602D87B RID: 186491 RVA: 0x0063B5A0 File Offset: 0x006397A0
		// (set) Token: 0x0602D87C RID: 186492 RVA: 0x0063B5A8 File Offset: 0x006397A8
		public string FinishText { get; set; }

		// Token: 0x1700C3E9 RID: 50153
		// (get) Token: 0x0602D87D RID: 186493 RVA: 0x0063B5B1 File Offset: 0x006397B1
		// (set) Token: 0x0602D87E RID: 186494 RVA: 0x0063B5B9 File Offset: 0x006397B9
		public List<string> InitDialogues { get; set; }

		// Token: 0x1700C3EA RID: 50154
		// (get) Token: 0x0602D87F RID: 186495 RVA: 0x0063B5C2 File Offset: 0x006397C2
		// (set) Token: 0x0602D880 RID: 186496 RVA: 0x0063B5CA File Offset: 0x006397CA
		public int SkipConfirmBoxId { get; set; }

		// Token: 0x1700C3EB RID: 50155
		// (get) Token: 0x0602D881 RID: 186497 RVA: 0x0063B5D3 File Offset: 0x006397D3
		// (set) Token: 0x0602D882 RID: 186498 RVA: 0x0063B5DB File Offset: 0x006397DB
		public string LoopAudioEvent { get; set; }

		// Token: 0x1700C3EC RID: 50156
		// (get) Token: 0x0602D883 RID: 186499 RVA: 0x0063B5E4 File Offset: 0x006397E4
		// (set) Token: 0x0602D884 RID: 186500 RVA: 0x0063B5EC File Offset: 0x006397EC
		public byte NullMask { get; set; }

		// Token: 0x0602D885 RID: 186501 RVA: 0x0063B5F8 File Offset: 0x006397F8
		public IAstrologyTextUiConfigT()
		{
			this.Type = ETextUiType.Astrology;
			this.InitTipText = null;
			this.ProgressTipText = null;
			this.SkipText = null;
			this.FinishText = null;
			this.InitDialogues = null;
			this.SkipConfirmBoxId = 0;
			this.LoopAudioEvent = null;
			this.NullMask = 0;
		}
	}
}
