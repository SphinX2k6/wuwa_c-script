using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DCA RID: 3530
	public class IPasserbyNpcPerNpcRandomExitInterval : IPasserbyNpcExitIntervalBase
	{
		// Token: 0x0600501B RID: 20507 RVA: 0x000C6FCE File Offset: 0x000C51CE
		public static IPasserbyNpcPerNpcRandomExitInterval Create(IPasserbyNpcPerNpcRandomExitInterval? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcPerNpcRandomExitInterval
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x0600501C RID: 20508 RVA: 0x000C6FED File Offset: 0x000C51ED
		public override EPasserbyNpcExitIntervalType Type
		{
			get
			{
				return (EPasserbyNpcExitIntervalType)this.Instance.Type;
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x000C6FFA File Offset: 0x000C51FA
		public virtual IPasserbyNpcNearSplineStartFirstExitOrder MoveOrder
		{
			get
			{
				if (this._MoveOrderInited)
				{
					return this._MoveOrderCache;
				}
				this._MoveOrderInited = true;
				this._MoveOrderCache = IPasserbyNpcNearSplineStartFirstExitOrder.Create(this.Instance.MoveOrder);
				return this._MoveOrderCache;
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x0600501E RID: 20510 RVA: 0x000C702E File Offset: 0x000C522E
		public virtual float MaxInterval
		{
			get
			{
				return this.Instance.MaxInterval;
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x0600501F RID: 20511 RVA: 0x000C703B File Offset: 0x000C523B
		public virtual float MinInterval
		{
			get
			{
				return this.Instance.MinInterval;
			}
		}

		// Token: 0x04002DA1 RID: 11681
		private IPasserbyNpcPerNpcRandomExitInterval Instance;

		// Token: 0x04002DA2 RID: 11682
		[Nullable(2)]
		private IPasserbyNpcNearSplineStartFirstExitOrder _MoveOrderCache;

		// Token: 0x04002DA3 RID: 11683
		private bool _MoveOrderInited;
	}
}
