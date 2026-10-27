using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200054A RID: 1354
	[NullableContext(1)]
	[Nullable(0)]
	public class InhaledItemComponent : IComponentBase
	{
		// Token: 0x06001BB0 RID: 7088 RVA: 0x0004FDC8 File Offset: 0x0004DFC8
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

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0004FE00 File Offset: 0x0004E000
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

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0004FE13 File Offset: 0x0004E013
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

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0004FE28 File Offset: 0x0004E028
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

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0004FE84 File Offset: 0x0004E084
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0004FEBE File Offset: 0x0004E0BE
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

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0004FECC File Offset: 0x0004E0CC
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0004FEF6 File Offset: 0x0004E0F6
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

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0004FF04 File Offset: 0x0004E104
		// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x0004FF2F File Offset: 0x0004E12F
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

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x0004FF40 File Offset: 0x0004E140
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x0004FF7A File Offset: 0x0004E17A
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

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x0004FF88 File Offset: 0x0004E188
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x0004FFE9 File Offset: 0x0004E1E9
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

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x0004FFFE File Offset: 0x0004E1FE
		// (set) Token: 0x06001BBF RID: 7103 RVA: 0x00050025 File Offset: 0x0004E225
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

		// Token: 0x040013E4 RID: 5092
		[Nullable(2)]
		protected new InhaledItemComponent FbInstance;

		// Token: 0x040013E5 RID: 5093
		[Nullable(2)]
		protected new InhaledItemComponent_SetValue PocoInterface;

		// Token: 0x040013E6 RID: 5094
		private IInhaledPerformance _InhaledPerformanceCache;

		// Token: 0x040013E7 RID: 5095
		private bool _InhaledPerformanceInited;
	}
}
