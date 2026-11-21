using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D04 RID: 3332
	public class ITimelineTrackControlData
	{
		// Token: 0x06004BE9 RID: 19433 RVA: 0x000BE3EA File Offset: 0x000BC5EA
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

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06004BEA RID: 19434 RVA: 0x000BE409 File Offset: 0x000BC609
		public virtual ETrackControlMode Type
		{
			get
			{
				return (ETrackControlMode)this.Instance.Type;
			}
		}

		// Token: 0x04002AEF RID: 10991
		private ITimelineTrackControlData Instance;
	}
}
