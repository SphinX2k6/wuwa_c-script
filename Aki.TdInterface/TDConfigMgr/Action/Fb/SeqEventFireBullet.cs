using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A88 RID: 10888
	public class SeqEventFireBullet : ActionParams
	{
		// Token: 0x0600EF45 RID: 61253 RVA: 0x0022CB28 File Offset: 0x0022AD28
		[NullableContext(1)]
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

		// Token: 0x17004BF7 RID: 19447
		// (get) Token: 0x0600EF46 RID: 61254 RVA: 0x0022CB47 File Offset: 0x0022AD47
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x040083A8 RID: 33704
		private ISeqEventFireBullet Instance;
	}
}
