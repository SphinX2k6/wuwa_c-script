using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200148C RID: 5260
	public class ILevelPlayTrackRadius
	{
		// Token: 0x0600777C RID: 30588 RVA: 0x0011E949 File Offset: 0x0011CB49
		public static ILevelPlayTrackRadius Create(ILevelPlayTrackRadius? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayTrackRadius
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x0600777D RID: 30589 RVA: 0x0011E968 File Offset: 0x0011CB68
		public virtual int TrackRadius
		{
			get
			{
				return this.Instance.TrackRadius;
			}
		}

		// Token: 0x0400449C RID: 17564
		private ILevelPlayTrackRadius Instance;
	}
}
