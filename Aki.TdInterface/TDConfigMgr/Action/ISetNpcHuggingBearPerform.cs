using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002069 RID: 8297
	public class ISetNpcHuggingBearPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600B019 RID: 45081 RVA: 0x0018C650 File Offset: 0x0018A850
		private ISetNpcHuggingBearPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcHuggingBearPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcHuggingBearPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcHuggingBearPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600B01A RID: 45082 RVA: 0x0018C688 File Offset: 0x0018A888
		public static ISetNpcHuggingBearPerform Create([Nullable(2)] ISetNpcHuggingBearPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHuggingBearPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x0018C69B File Offset: 0x0018A89B
		public static ISetNpcHuggingBearPerform CreateFromSetValue([Nullable(2)] ISetNpcHuggingBearPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcHuggingBearPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x0018C6AE File Offset: 0x0018A8AE
		public new ISetNpcHuggingBearPerform_SetValue ToSetValue()
		{
			return new ISetNpcHuggingBearPerform_SetValue
			{
				Type = this.Type,
				Initiator = this.Initiator,
				Target = this.Target,
				NpcType = this.NpcType
			};
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600B01D RID: 45085 RVA: 0x0018C6E5 File Offset: 0x0018A8E5
		// (set) Token: 0x0600B01E RID: 45086 RVA: 0x0018C710 File Offset: 0x0018A910
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

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600B01F RID: 45087 RVA: 0x0018C720 File Offset: 0x0018A920
		// (set) Token: 0x0600B020 RID: 45088 RVA: 0x0018C781 File Offset: 0x0018A981
		public virtual IPlayerInitiator Initiator
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
					this._InitiatorCache = IPlayerInitiator.Create(this.FbInstance.Initiator);
				}
				else
				{
					ISetNpcHuggingBearPerform_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0600B021 RID: 45089 RVA: 0x0018C796 File Offset: 0x0018A996
		// (set) Token: 0x0600B022 RID: 45090 RVA: 0x0018C7C1 File Offset: 0x0018A9C1
		public virtual int Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600B023 RID: 45091 RVA: 0x0018C7CF File Offset: 0x0018A9CF
		// (set) Token: 0x0600B024 RID: 45092 RVA: 0x0018C7FA File Offset: 0x0018A9FA
		public virtual ENpcGroupPerformNpcType NpcType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NpcType;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformNpcType.LevelBCommonMale;
				}
				return this.PocoInterface.NpcType;
			}
			set
			{
				this.GetOrCreatePoco().NpcType = value;
			}
		}

		// Token: 0x040068C4 RID: 26820
		[Nullable(2)]
		protected new ISetNpcHuggingBearPerform FbInstance;

		// Token: 0x040068C5 RID: 26821
		[Nullable(2)]
		protected new ISetNpcHuggingBearPerform_SetValue PocoInterface;

		// Token: 0x040068C6 RID: 26822
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x040068C7 RID: 26823
		private bool _InitiatorInited;
	}
}
