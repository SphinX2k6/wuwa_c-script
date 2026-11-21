using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014A0 RID: 5280
	public class IMechaTrackScoreDetectionType
	{
		// Token: 0x060077E5 RID: 30693 RVA: 0x0011F703 File Offset: 0x0011D903
		public static IMechaTrackScoreDetectionType Create(IMechaTrackScoreDetectionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreDetectionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x060077E6 RID: 30694 RVA: 0x0011F722 File Offset: 0x0011D922
		public virtual EMechaTrackScoreDetectionType Type
		{
			get
			{
				return (EMechaTrackScoreDetectionType)this.Instance.Type;
			}
		}

		// Token: 0x040044E6 RID: 17638
		private IMechaTrackScoreDetectionType Instance;
	}
}
