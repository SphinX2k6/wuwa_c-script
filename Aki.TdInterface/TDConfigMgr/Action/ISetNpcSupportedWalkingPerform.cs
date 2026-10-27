using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E38 RID: 7736
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcSupportedWalkingPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600A57F RID: 42367 RVA: 0x00176E10 File Offset: 0x00175010
		private ISetNpcSupportedWalkingPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcSupportedWalkingPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcSupportedWalkingPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcSupportedWalkingPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x00176E48 File Offset: 0x00175048
		public static ISetNpcSupportedWalkingPerform Create([Nullable(2)] ISetNpcSupportedWalkingPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcSupportedWalkingPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x00176E5B File Offset: 0x0017505B
		public static ISetNpcSupportedWalkingPerform CreateFromSetValue([Nullable(2)] ISetNpcSupportedWalkingPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcSupportedWalkingPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x00176E6E File Offset: 0x0017506E
		public new ISetNpcSupportedWalkingPerform_SetValue ToSetValue()
		{
			return new ISetNpcSupportedWalkingPerform_SetValue
			{
				Type = this.Type,
				Initiator = this.Initiator,
				Target = this.Target
			};
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600A583 RID: 42371 RVA: 0x00176E99 File Offset: 0x00175099
		// (set) Token: 0x0600A584 RID: 42372 RVA: 0x00176EC4 File Offset: 0x001750C4
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

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600A585 RID: 42373 RVA: 0x00176ED4 File Offset: 0x001750D4
		// (set) Token: 0x0600A586 RID: 42374 RVA: 0x00176F35 File Offset: 0x00175135
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
					ISetNpcSupportedWalkingPerform_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600A587 RID: 42375 RVA: 0x00176F4A File Offset: 0x0017514A
		// (set) Token: 0x0600A588 RID: 42376 RVA: 0x00176F75 File Offset: 0x00175175
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

		// Token: 0x040062F5 RID: 25333
		[Nullable(2)]
		protected new ISetNpcSupportedWalkingPerform FbInstance;

		// Token: 0x040062F6 RID: 25334
		[Nullable(2)]
		protected new ISetNpcSupportedWalkingPerform_SetValue PocoInterface;

		// Token: 0x040062F7 RID: 25335
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x040062F8 RID: 25336
		private bool _InitiatorInited;
	}
}
