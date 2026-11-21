using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DF1 RID: 11761
	public class SheriffUnlockClue : ActionParams
	{
		// Token: 0x0600FFC5 RID: 65477 RVA: 0x0024D699 File Offset: 0x0024B899
		public static SheriffUnlockClue Create(ISheriffUnlockClue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockClue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005091 RID: 20625
		// (get) Token: 0x0600FFC6 RID: 65478 RVA: 0x0024D6B8 File Offset: 0x0024B8B8
		public virtual int ClueId
		{
			get
			{
				return this.Instance.ClueId;
			}
		}

		// Token: 0x04008B9F RID: 35743
		private ISheriffUnlockClue Instance;
	}
}
