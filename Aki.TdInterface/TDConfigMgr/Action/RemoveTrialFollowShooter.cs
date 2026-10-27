using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002156 RID: 8534
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveTrialFollowShooter : ActionParams
	{
		// Token: 0x0600BBD2 RID: 48082 RVA: 0x001B16F8 File Offset: 0x001AF8F8
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

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x001B1730 File Offset: 0x001AF930
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

		// Token: 0x0600BBD4 RID: 48084 RVA: 0x001B1743 File Offset: 0x001AF943
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

		// Token: 0x0600BBD5 RID: 48085 RVA: 0x001B1756 File Offset: 0x001AF956
		public RemoveTrialFollowShooter_SetValue ToSetValue()
		{
			return new RemoveTrialFollowShooter_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x0600BBD6 RID: 48086 RVA: 0x001B1769 File Offset: 0x001AF969
		// (set) Token: 0x0600BBD7 RID: 48087 RVA: 0x001B1794 File Offset: 0x001AF994
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

		// Token: 0x04007041 RID: 28737
		[Nullable(2)]
		protected new RemoveTrialFollowShooter FbInstance;

		// Token: 0x04007042 RID: 28738
		[Nullable(2)]
		protected RemoveTrialFollowShooter_SetValue PocoInterface;
	}
}
