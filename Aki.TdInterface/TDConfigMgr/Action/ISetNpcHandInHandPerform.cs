using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002065 RID: 8293
	public class ISetNpcHandInHandPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600AFFF RID: 45055 RVA: 0x0018C304 File Offset: 0x0018A504
		private ISetNpcHandInHandPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcHandInHandPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcHandInHandPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcHandInHandPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x0018C33C File Offset: 0x0018A53C
		public static ISetNpcHandInHandPerform Create([Nullable(2)] ISetNpcHandInHandPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHandInHandPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B001 RID: 45057 RVA: 0x0018C34F File Offset: 0x0018A54F
		public static ISetNpcHandInHandPerform CreateFromSetValue([Nullable(2)] ISetNpcHandInHandPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcHandInHandPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B002 RID: 45058 RVA: 0x0018C362 File Offset: 0x0018A562
		public new ISetNpcHandInHandPerform_SetValue ToSetValue()
		{
			return new ISetNpcHandInHandPerform_SetValue
			{
				Type = this.Type,
				Initiator = this.Initiator,
				Follower = this.Follower
			};
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600B003 RID: 45059 RVA: 0x0018C38D File Offset: 0x0018A58D
		// (set) Token: 0x0600B004 RID: 45060 RVA: 0x0018C3B8 File Offset: 0x0018A5B8
		public override ENpcGroupPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600B005 RID: 45061 RVA: 0x0018C3C8 File Offset: 0x0018A5C8
		// (set) Token: 0x0600B006 RID: 45062 RVA: 0x0018C429 File Offset: 0x0018A629
		public virtual IHandInHandInitiator Initiator
		{
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				if (this.FbInstance != null)
				{
					this._InitiatorCache = IHandInHandInitiator.Create(this.FbInstance.Initiator);
				}
				else
				{
					ISetNpcHandInHandPerform_SetValue pocoInterface = this.PocoInterface;
					this._InitiatorCache = ((pocoInterface != null) ? pocoInterface.Initiator : null);
				}
				return this._InitiatorCache;
			}
			set
			{
				this.GetOrCreatePoco().Initiator = value;
				this._InitiatorInited = false;
			}
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600B007 RID: 45063 RVA: 0x0018C43E File Offset: 0x0018A63E
		// (set) Token: 0x0600B008 RID: 45064 RVA: 0x0018C469 File Offset: 0x0018A669
		public virtual int Follower
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Follower;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Follower;
			}
			set
			{
				this.GetOrCreatePoco().Follower = value;
			}
		}

		// Token: 0x040068B5 RID: 26805
		[Nullable(2)]
		protected new ISetNpcHandInHandPerform FbInstance;

		// Token: 0x040068B6 RID: 26806
		[Nullable(2)]
		protected new ISetNpcHandInHandPerform_SetValue PocoInterface;

		// Token: 0x040068B7 RID: 26807
		private IHandInHandInitiator _InitiatorCache;

		// Token: 0x040068B8 RID: 26808
		private bool _InitiatorInited;
	}
}
