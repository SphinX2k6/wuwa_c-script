using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B1 RID: 1457
	public class InhaledItemComponent : IComponentBase
	{
		// Token: 0x06001DAC RID: 7596 RVA: 0x00054B84 File Offset: 0x00052D84
		private InhaledItemComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("InhaledItemComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			InhaledItemComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new InhaledItemComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00054BBC File Offset: 0x00052DBC
		public static InhaledItemComponent Create([Nullable(2)] InhaledItemComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InhaledItemComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00054BCF File Offset: 0x00052DCF
		public static InhaledItemComponent CreateFromSetValue([Nullable(2)] InhaledItemComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new InhaledItemComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00054BE4 File Offset: 0x00052DE4
		public new InhaledItemComponent_SetValue ToSetValue()
		{
			return new InhaledItemComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				InhaledStrength = this.InhaledStrength,
				InhaledInterruptionRecoveryTime = this.InhaledInterruptionRecoveryTime,
				InhaledPerformance = this.InhaledPerformance,
				InhaledPerResult = this.InhaledPerResult
			};
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00054C40 File Offset: 0x00052E40
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x00054C7A File Offset: 0x00052E7A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				InhaledItemComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00054C88 File Offset: 0x00052E88
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x00054CB2 File Offset: 0x00052EB2
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00054CC0 File Offset: 0x00052EC0
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x00054CEB File Offset: 0x00052EEB
		public virtual int InhaledStrength
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InhaledStrength;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InhaledStrength;
			}
			set
			{
				this.GetOrCreatePoco().InhaledStrength = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00054CFC File Offset: 0x00052EFC
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x00054D36 File Offset: 0x00052F36
		public virtual int? InhaledInterruptionRecoveryTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InhaledInterruptionRecoveryTime;
				}
				InhaledItemComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InhaledInterruptionRecoveryTime;
			}
			set
			{
				this.GetOrCreatePoco().InhaledInterruptionRecoveryTime = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00054D44 File Offset: 0x00052F44
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x00054DA5 File Offset: 0x00052FA5
		public virtual IInhaledPerformance InhaledPerformance
		{
			get
			{
				if (this._InhaledPerformanceInited)
				{
					return this._InhaledPerformanceCache;
				}
				this._InhaledPerformanceInited = true;
				if (this.FbInstance != null)
				{
					this._InhaledPerformanceCache = IInhaledPerformance.Create(this.FbInstance.InhaledPerformance);
				}
				else
				{
					InhaledItemComponent_SetValue pocoInterface = this.PocoInterface;
					this._InhaledPerformanceCache = ((pocoInterface != null) ? pocoInterface.InhaledPerformance : null);
				}
				return this._InhaledPerformanceCache;
			}
			set
			{
				this.GetOrCreatePoco().InhaledPerformance = value;
				this._InhaledPerformanceInited = false;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x00054DBA File Offset: 0x00052FBA
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x00054DE1 File Offset: 0x00052FE1
		public virtual IInhaledPerResultType InhaledPerResult
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InhaledPerResult;
				}
				InhaledItemComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InhaledPerResult;
			}
			set
			{
				this.GetOrCreatePoco().InhaledPerResult = value;
			}
		}

		// Token: 0x0400154E RID: 5454
		[Nullable(2)]
		protected new InhaledItemComponent FbInstance;

		// Token: 0x0400154F RID: 5455
		[Nullable(2)]
		protected new InhaledItemComponent_SetValue PocoInterface;

		// Token: 0x04001550 RID: 5456
		private IInhaledPerformance _InhaledPerformanceCache;

		// Token: 0x04001551 RID: 5457
		private bool _InhaledPerformanceInited;
	}
}
