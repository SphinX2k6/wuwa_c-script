using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF1 RID: 3825
	public class IDollGrabStageAudioState
	{
		// Token: 0x06005617 RID: 22039 RVA: 0x000D3598 File Offset: 0x000D1798
		public static IDollGrabStageAudioState Create(IDollGrabStageAudioState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabStageAudioState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x000D35B7 File Offset: 0x000D17B7
		public virtual string Group
		{
			get
			{
				return this.Instance.Group;
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06005619 RID: 22041 RVA: 0x000D35C4 File Offset: 0x000D17C4
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x0400314E RID: 12622
		private IDollGrabStageAudioState Instance;
	}
}
