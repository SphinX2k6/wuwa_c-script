using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277D RID: 10109
	public class WaitUntilLevelSequenceReachMark : ActionParams
	{
		// Token: 0x0600DFF7 RID: 57335 RVA: 0x0020F7A5 File Offset: 0x0020D9A5
		public static WaitUntilLevelSequenceReachMark Create(IWaitUntilLevelSequenceReachMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WaitUntilLevelSequenceReachMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x0600DFF8 RID: 57336 RVA: 0x0020F7C4 File Offset: 0x0020D9C4
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x0600DFF9 RID: 57337 RVA: 0x0020F7D1 File Offset: 0x0020D9D1
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x040079D3 RID: 31187
		private IWaitUntilLevelSequenceReachMark Instance;
	}
}
