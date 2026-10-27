using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001350 RID: 4944
	public class IMechaTrackScoreDetectionType
	{
		// Token: 0x06007145 RID: 28997 RVA: 0x00111197 File Offset: 0x0010F397
		[NullableContext(1)]
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

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x06007146 RID: 28998 RVA: 0x001111B6 File Offset: 0x0010F3B6
		public virtual EMechaTrackScoreDetectionType Type
		{
			get
			{
				return (EMechaTrackScoreDetectionType)this.Instance.Type;
			}
		}

		// Token: 0x0400416A RID: 16746
		private IMechaTrackScoreDetectionType Instance;
	}
}
