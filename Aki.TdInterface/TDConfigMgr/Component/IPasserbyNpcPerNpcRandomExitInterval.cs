using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200064D RID: 1613
	public class IPasserbyNpcPerNpcRandomExitInterval : IPasserbyNpcExitIntervalBase
	{
		// Token: 0x060021DE RID: 8670 RVA: 0x0005DE00 File Offset: 0x0005C000
		private IPasserbyNpcPerNpcRandomExitInterval_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcPerNpcRandomExitInterval 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcPerNpcRandomExitInterval_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcPerNpcRandomExitInterval_SetValue());
			}
			return result;
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0005DE38 File Offset: 0x0005C038
		public static IPasserbyNpcPerNpcRandomExitInterval Create([Nullable(2)] IPasserbyNpcPerNpcRandomExitInterval instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcPerNpcRandomExitInterval
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0005DE4B File Offset: 0x0005C04B
		public static IPasserbyNpcPerNpcRandomExitInterval CreateFromSetValue([Nullable(2)] IPasserbyNpcPerNpcRandomExitInterval_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcPerNpcRandomExitInterval
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0005DE5E File Offset: 0x0005C05E
		public new IPasserbyNpcPerNpcRandomExitInterval_SetValue ToSetValue()
		{
			return new IPasserbyNpcPerNpcRandomExitInterval_SetValue
			{
				Type = this.Type,
				MoveOrder = this.MoveOrder,
				MaxInterval = this.MaxInterval,
				MinInterval = this.MinInterval
			};
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x0005DE95 File Offset: 0x0005C095
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x0005DEC0 File Offset: 0x0005C0C0
		public override EPasserbyNpcExitIntervalType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcExitIntervalType.PerNpcRandom;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x0005DED0 File Offset: 0x0005C0D0
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x0005DF31 File Offset: 0x0005C131
		public virtual IPasserbyNpcNearSplineStartFirstExitOrder MoveOrder
		{
			get
			{
				if (this._MoveOrderInited)
				{
					return this._MoveOrderCache;
				}
				this._MoveOrderInited = true;
				if (this.FbInstance != null)
				{
					this._MoveOrderCache = IPasserbyNpcNearSplineStartFirstExitOrder.Create(this.FbInstance.MoveOrder);
				}
				else
				{
					IPasserbyNpcPerNpcRandomExitInterval_SetValue pocoInterface = this.PocoInterface;
					this._MoveOrderCache = ((pocoInterface != null) ? pocoInterface.MoveOrder : null);
				}
				return this._MoveOrderCache;
			}
			set
			{
				this.GetOrCreatePoco().MoveOrder = value;
				this._MoveOrderInited = false;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x0005DF46 File Offset: 0x0005C146
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x0005DF75 File Offset: 0x0005C175
		public virtual float MaxInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxInterval;
			}
			set
			{
				this.GetOrCreatePoco().MaxInterval = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0005DF83 File Offset: 0x0005C183
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x0005DFB2 File Offset: 0x0005C1B2
		public virtual float MinInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinInterval;
			}
			set
			{
				this.GetOrCreatePoco().MinInterval = value;
			}
		}

		// Token: 0x040017DB RID: 6107
		[Nullable(2)]
		protected new IPasserbyNpcPerNpcRandomExitInterval FbInstance;

		// Token: 0x040017DC RID: 6108
		[Nullable(2)]
		protected new IPasserbyNpcPerNpcRandomExitInterval_SetValue PocoInterface;

		// Token: 0x040017DD RID: 6109
		private IPasserbyNpcNearSplineStartFirstExitOrder _MoveOrderCache;

		// Token: 0x040017DE RID: 6110
		private bool _MoveOrderInited;
	}
}
