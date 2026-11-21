using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014A1 RID: 5281
	public class IMechaTrackScoreStuntAction : IMechaTrackScoreDetectionType
	{
		// Token: 0x060077E8 RID: 30696 RVA: 0x0011F737 File Offset: 0x0011D937
		public static IMechaTrackScoreStuntAction Create(IMechaTrackScoreStuntAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreStuntAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x060077E9 RID: 30697 RVA: 0x0011F756 File Offset: 0x0011D956
		public override EMechaTrackScoreDetectionType Type
		{
			get
			{
				return (EMechaTrackScoreDetectionType)this.Instance.Type;
			}
		}

		// Token: 0x040044E7 RID: 17639
		private IMechaTrackScoreStuntAction Instance;
	}
}
