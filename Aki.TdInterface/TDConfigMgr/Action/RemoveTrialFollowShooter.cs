using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B7 RID: 9143
	public class RemoveTrialFollowShooter : ActionParams
	{
		// Token: 0x0600C760 RID: 51040 RVA: 0x001C88AC File Offset: 0x001C6AAC
		private RemoveTrialFollowShooter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveTrialFollowShooter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveTrialFollowShooter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveTrialFollowShooter_SetValue());
			}
			return result;
		}

		// Token: 0x0600C761 RID: 51041 RVA: 0x001C88E4 File Offset: 0x001C6AE4
		public static RemoveTrialFollowShooter Create([Nullable(2)] RemoveTrialFollowShooter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveTrialFollowShooter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C762 RID: 51042 RVA: 0x001C88F7 File Offset: 0x001C6AF7
		public static RemoveTrialFollowShooter CreateFromSetValue([Nullable(2)] RemoveTrialFollowShooter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveTrialFollowShooter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C763 RID: 51043 RVA: 0x001C890A File Offset: 0x001C6B0A
		public RemoveTrialFollowShooter_SetValue ToSetValue()
		{
			return new RemoveTrialFollowShooter_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x0600C764 RID: 51044 RVA: 0x001C891D File Offset: 0x001C6B1D
		// (set) Token: 0x0600C765 RID: 51045 RVA: 0x001C8948 File Offset: 0x001C6B48
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04007676 RID: 30326
		[Nullable(2)]
		protected new RemoveTrialFollowShooter FbInstance;

		// Token: 0x04007677 RID: 30327
		[Nullable(2)]
		protected RemoveTrialFollowShooter_SetValue PocoInterface;
	}
}
