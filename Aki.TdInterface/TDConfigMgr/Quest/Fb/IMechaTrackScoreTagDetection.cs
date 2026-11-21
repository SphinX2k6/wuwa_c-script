using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014A4 RID: 5284
	public class IMechaTrackScoreTagDetection : IMechaTrackScoreDetectionType
	{
		// Token: 0x060077F4 RID: 30708 RVA: 0x0011F87D File Offset: 0x0011DA7D
		public static IMechaTrackScoreTagDetection Create(IMechaTrackScoreTagDetection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreTagDetection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x060077F5 RID: 30709 RVA: 0x0011F89C File Offset: 0x0011DA9C
		public override EMechaTrackScoreDetectionType Type
		{
			get
			{
				return (EMechaTrackScoreDetectionType)this.Instance.Type;
			}
		}

		// Token: 0x040044EE RID: 17646
		private IMechaTrackScoreTagDetection Instance;
	}
}
