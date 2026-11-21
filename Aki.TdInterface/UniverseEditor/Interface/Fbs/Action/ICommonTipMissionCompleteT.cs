using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B0D RID: 27405
	public class ICommonTipMissionCompleteT
	{
		// Token: 0x1700C943 RID: 51523
		// (get) Token: 0x0602F1EC RID: 193004 RVA: 0x0066D0C0 File Offset: 0x0066B2C0
		// (set) Token: 0x0602F1ED RID: 193005 RVA: 0x0066D0C8 File Offset: 0x0066B2C8
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C944 RID: 51524
		// (get) Token: 0x0602F1EE RID: 193006 RVA: 0x0066D0D1 File Offset: 0x0066B2D1
		// (set) Token: 0x0602F1EF RID: 193007 RVA: 0x0066D0D9 File Offset: 0x0066B2D9
		public string TidMainText { get; set; }

		// Token: 0x1700C945 RID: 51525
		// (get) Token: 0x0602F1F0 RID: 193008 RVA: 0x0066D0E2 File Offset: 0x0066B2E2
		// (set) Token: 0x0602F1F1 RID: 193009 RVA: 0x0066D0EA File Offset: 0x0066B2EA
		public string TidSubText { get; set; }

		// Token: 0x0602F1F2 RID: 193010 RVA: 0x0066D0F3 File Offset: 0x0066B2F3
		public ICommonTipMissionCompleteT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
