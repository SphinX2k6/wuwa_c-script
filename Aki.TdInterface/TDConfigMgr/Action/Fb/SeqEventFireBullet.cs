using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D7C RID: 11644
	public class SeqEventFireBullet : ActionParams
	{
		// Token: 0x0600FDFB RID: 65019 RVA: 0x0024A834 File Offset: 0x00248A34
		public static SeqEventFireBullet Create(ISeqEventFireBullet? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeqEventFireBullet
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FB1 RID: 20401
		// (get) Token: 0x0600FDFC RID: 65020 RVA: 0x0024A853 File Offset: 0x00248A53
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x04008AAC RID: 35500
		private ISeqEventFireBullet Instance;
	}
}
