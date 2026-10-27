using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C31 RID: 3121
	public class ITimelineTrackControlData
	{
		// Token: 0x06004779 RID: 18297 RVA: 0x000B403A File Offset: 0x000B223A
		[NullableContext(1)]
		public static ITimelineTrackControlData Create(ITimelineTrackControlData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimelineTrackControlData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x000B4059 File Offset: 0x000B2259
		public virtual ETrackControlMode Type
		{
			get
			{
				return (ETrackControlMode)this.Instance.Type;
			}
		}

		// Token: 0x0400289A RID: 10394
		private ITimelineTrackControlData Instance;
	}
}
