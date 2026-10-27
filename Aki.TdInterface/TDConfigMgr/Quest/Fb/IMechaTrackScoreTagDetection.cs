using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001354 RID: 4948
	public class IMechaTrackScoreTagDetection : IMechaTrackScoreDetectionType
	{
		// Token: 0x06007154 RID: 29012 RVA: 0x00111311 File Offset: 0x0010F511
		[NullableContext(1)]
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

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x06007155 RID: 29013 RVA: 0x00111330 File Offset: 0x0010F530
		public override EMechaTrackScoreDetectionType Type
		{
			get
			{
				return (EMechaTrackScoreDetectionType)this.Instance.Type;
			}
		}

		// Token: 0x04004172 RID: 16754
		private IMechaTrackScoreTagDetection Instance;
	}
}
