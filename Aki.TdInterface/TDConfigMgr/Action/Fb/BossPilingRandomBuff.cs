using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DEB RID: 11755
	public class BossPilingRandomBuff : ActionParams
	{
		// Token: 0x0600FFAD RID: 65453 RVA: 0x0024D3E4 File Offset: 0x0024B5E4
		public static BossPilingRandomBuff Create(IBossPilingRandomBuff? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BossPilingRandomBuff
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005085 RID: 20613
		// (get) Token: 0x0600FFAE RID: 65454 RVA: 0x0024D403 File Offset: 0x0024B603
		public virtual int BuffPoolId
		{
			get
			{
				return this.Instance.BuffPoolId;
			}
		}

		// Token: 0x04008B8F RID: 35727
		private IBossPilingRandomBuff Instance;
	}
}
