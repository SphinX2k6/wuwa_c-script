using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200063D RID: 1597
	public class IPasserbyNpcLiftMove : IPasserbyNpcMoveBase
	{
		// Token: 0x0600218E RID: 8590 RVA: 0x0005D504 File Offset: 0x0005B704
		private IPasserbyNpcLiftMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcLiftMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcLiftMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcLiftMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x0005D53C File Offset: 0x0005B73C
		public static IPasserbyNpcLiftMove Create([Nullable(2)] IPasserbyNpcLiftMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcLiftMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x0005D54F File Offset: 0x0005B74F
		public static IPasserbyNpcLiftMove CreateFromSetValue([Nullable(2)] IPasserbyNpcLiftMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcLiftMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x0005D562 File Offset: 0x0005B762
		public new IPasserbyNpcLiftMove_SetValue ToSetValue()
		{
			return new IPasserbyNpcLiftMove_SetValue
			{
				Type = this.Type,
				NpcLiftConfig = this.NpcLiftConfig
			};
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x0005D581 File Offset: 0x0005B781
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x0005D5AC File Offset: 0x0005B7AC
		public override EPasserbyNpcMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcMoveType.Spline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x0005D5BC File Offset: 0x0005B7BC
		// (set) Token: 0x06002195 RID: 8597 RVA: 0x0005D61D File Offset: 0x0005B81D
		public virtual IPasserbyNpcRideLiftLeaveOnArrivalMove NpcLiftConfig
		{
			get
			{
				if (this._NpcLiftConfigInited)
				{
					return this._NpcLiftConfigCache;
				}
				this._NpcLiftConfigInited = true;
				if (this.FbInstance != null)
				{
					this._NpcLiftConfigCache = IPasserbyNpcRideLiftLeaveOnArrivalMove.Create(this.FbInstance.NpcLiftConfig);
				}
				else
				{
					IPasserbyNpcLiftMove_SetValue pocoInterface = this.PocoInterface;
					this._NpcLiftConfigCache = ((pocoInterface != null) ? pocoInterface.NpcLiftConfig : null);
				}
				return this._NpcLiftConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().NpcLiftConfig = value;
				this._NpcLiftConfigInited = false;
			}
		}

		// Token: 0x040017B5 RID: 6069
		[Nullable(2)]
		protected new IPasserbyNpcLiftMove FbInstance;

		// Token: 0x040017B6 RID: 6070
		[Nullable(2)]
		protected new IPasserbyNpcLiftMove_SetValue PocoInterface;

		// Token: 0x040017B7 RID: 6071
		private IPasserbyNpcRideLiftLeaveOnArrivalMove _NpcLiftConfigCache;

		// Token: 0x040017B8 RID: 6072
		private bool _NpcLiftConfigInited;
	}
}
