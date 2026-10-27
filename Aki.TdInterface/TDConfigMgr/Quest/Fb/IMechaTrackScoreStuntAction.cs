using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001351 RID: 4945
	public class IMechaTrackScoreStuntAction : IMechaTrackScoreDetectionType
	{
		// Token: 0x06007148 RID: 29000 RVA: 0x001111CB File Offset: 0x0010F3CB
		[NullableContext(1)]
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

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x06007149 RID: 29001 RVA: 0x001111EA File Offset: 0x0010F3EA
		public override EMechaTrackScoreDetectionType Type
		{
			get
			{
				return (EMechaTrackScoreDetectionType)this.Instance.Type;
			}
		}

		// Token: 0x0400416B RID: 16747
		private IMechaTrackScoreStuntAction Instance;
	}
}
