using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DF5 RID: 11765
	public class SheriffUnlockEnding : ActionParams
	{
		// Token: 0x0600FFD3 RID: 65491 RVA: 0x0024D783 File Offset: 0x0024B983
		public static SheriffUnlockEnding Create(ISheriffUnlockEnding? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockEnding
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005097 RID: 20631
		// (get) Token: 0x0600FFD4 RID: 65492 RVA: 0x0024D7A2 File Offset: 0x0024B9A2
		public virtual int EndingId
		{
			get
			{
				return this.Instance.EndingId;
			}
		}

		// Token: 0x04008BA3 RID: 35747
		private ISheriffUnlockEnding Instance;
	}
}
