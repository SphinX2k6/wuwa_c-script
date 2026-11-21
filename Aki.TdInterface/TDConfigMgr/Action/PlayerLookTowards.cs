using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002372 RID: 9074
	public class PlayerLookTowards : ActionParams
	{
		// Token: 0x0600C5C0 RID: 50624 RVA: 0x001C55B0 File Offset: 0x001C37B0
		private PlayerLookTowards_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayerLookTowards 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayerLookTowards_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayerLookTowards_SetValue());
			}
			return result;
		}

		// Token: 0x0600C5C1 RID: 50625 RVA: 0x001C55E8 File Offset: 0x001C37E8
		public static PlayerLookTowards Create([Nullable(2)] PlayerLookTowards instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayerLookTowards
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C5C2 RID: 50626 RVA: 0x001C55FB File Offset: 0x001C37FB
		public static PlayerLookTowards CreateFromSetValue([Nullable(2)] PlayerLookTowards_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayerLookTowards
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C5C3 RID: 50627 RVA: 0x001C560E File Offset: 0x001C380E
		public PlayerLookTowards_SetValue ToSetValue()
		{
			return new PlayerLookTowards_SetValue
			{
				Target = this.Target
			};
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0600C5C4 RID: 50628 RVA: 0x001C5621 File Offset: 0x001C3821
		// (set) Token: 0x0600C5C5 RID: 50629 RVA: 0x001C5648 File Offset: 0x001C3848
		public virtual ICharacterLookAtData Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				PlayerLookTowards_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x040075A9 RID: 30121
		[Nullable(2)]
		protected new PlayerLookTowards FbInstance;

		// Token: 0x040075AA RID: 30122
		[Nullable(2)]
		protected PlayerLookTowards_SetValue PocoInterface;
	}
}
