using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F8 RID: 9208
	public class SeqEventFireBullet : ActionParams
	{
		// Token: 0x0600C86E RID: 51310 RVA: 0x001CA434 File Offset: 0x001C8634
		private SeqEventFireBullet_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SeqEventFireBullet 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SeqEventFireBullet_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SeqEventFireBullet_SetValue());
			}
			return result;
		}

		// Token: 0x0600C86F RID: 51311 RVA: 0x001CA46C File Offset: 0x001C866C
		public static SeqEventFireBullet Create([Nullable(2)] SeqEventFireBullet instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeqEventFireBullet
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C870 RID: 51312 RVA: 0x001CA47F File Offset: 0x001C867F
		public static SeqEventFireBullet CreateFromSetValue([Nullable(2)] SeqEventFireBullet_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SeqEventFireBullet
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C871 RID: 51313 RVA: 0x001CA492 File Offset: 0x001C8692
		public SeqEventFireBullet_SetValue ToSetValue()
		{
			return new SeqEventFireBullet_SetValue
			{
				BulletId = this.BulletId
			};
		}

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x0600C872 RID: 51314 RVA: 0x001CA4A5 File Offset: 0x001C86A5
		// (set) Token: 0x0600C873 RID: 51315 RVA: 0x001CA4D1 File Offset: 0x001C86D1
		public virtual long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x040076EE RID: 30446
		[Nullable(2)]
		protected new SeqEventFireBullet FbInstance;

		// Token: 0x040076EF RID: 30447
		[Nullable(2)]
		protected SeqEventFireBullet_SetValue PocoInterface;
	}
}
