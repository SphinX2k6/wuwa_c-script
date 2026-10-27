using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200218F RID: 8591
	[NullableContext(1)]
	[Nullable(0)]
	public class SeqEventFireBullet : ActionParams
	{
		// Token: 0x0600BCBE RID: 48318 RVA: 0x001B2F3C File Offset: 0x001B113C
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

		// Token: 0x0600BCBF RID: 48319 RVA: 0x001B2F74 File Offset: 0x001B1174
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

		// Token: 0x0600BCC0 RID: 48320 RVA: 0x001B2F87 File Offset: 0x001B1187
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

		// Token: 0x0600BCC1 RID: 48321 RVA: 0x001B2F9A File Offset: 0x001B119A
		public SeqEventFireBullet_SetValue ToSetValue()
		{
			return new SeqEventFireBullet_SetValue
			{
				BulletId = this.BulletId
			};
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0600BCC2 RID: 48322 RVA: 0x001B2FAD File Offset: 0x001B11AD
		// (set) Token: 0x0600BCC3 RID: 48323 RVA: 0x001B2FD9 File Offset: 0x001B11D9
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

		// Token: 0x040070AC RID: 28844
		[Nullable(2)]
		protected new SeqEventFireBullet FbInstance;

		// Token: 0x040070AD RID: 28845
		[Nullable(2)]
		protected SeqEventFireBullet_SetValue PocoInterface;
	}
}
