using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019AB RID: 6571
	public class IBubbleRangeCylinderConfig
	{
		// Token: 0x06008BB1 RID: 35761 RVA: 0x0014B2FC File Offset: 0x001494FC
		private IBubbleRangeCylinderConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBubbleRangeCylinderConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBubbleRangeCylinderConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBubbleRangeCylinderConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x0014B334 File Offset: 0x00149534
		public static IBubbleRangeCylinderConfig Create([Nullable(2)] IBubbleRangeCylinderConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleRangeCylinderConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x0014B347 File Offset: 0x00149547
		public static IBubbleRangeCylinderConfig CreateFromSetValue([Nullable(2)] IBubbleRangeCylinderConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBubbleRangeCylinderConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x0014B35A File Offset: 0x0014955A
		public IBubbleRangeCylinderConfig_SetValue ToSetValue()
		{
			return new IBubbleRangeCylinderConfig_SetValue
			{
				InnerConfig = this.InnerConfig,
				OuterConfig = this.OuterConfig
			};
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x06008BB5 RID: 35765 RVA: 0x0014B37C File Offset: 0x0014957C
		// (set) Token: 0x06008BB6 RID: 35766 RVA: 0x0014B3DD File Offset: 0x001495DD
		public virtual IBubbleCylinderConfig InnerConfig
		{
			get
			{
				if (this._InnerConfigInited)
				{
					return this._InnerConfigCache;
				}
				this._InnerConfigInited = true;
				if (this.FbInstance != null)
				{
					this._InnerConfigCache = IBubbleCylinderConfig.Create(this.FbInstance.InnerConfig);
				}
				else
				{
					IBubbleRangeCylinderConfig_SetValue pocoInterface = this.PocoInterface;
					this._InnerConfigCache = ((pocoInterface != null) ? pocoInterface.InnerConfig : null);
				}
				return this._InnerConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().InnerConfig = value;
				this._InnerConfigInited = false;
			}
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x06008BB7 RID: 35767 RVA: 0x0014B3F4 File Offset: 0x001495F4
		// (set) Token: 0x06008BB8 RID: 35768 RVA: 0x0014B455 File Offset: 0x00149655
		public virtual IBubbleCylinderConfig OuterConfig
		{
			get
			{
				if (this._OuterConfigInited)
				{
					return this._OuterConfigCache;
				}
				this._OuterConfigInited = true;
				if (this.FbInstance != null)
				{
					this._OuterConfigCache = IBubbleCylinderConfig.Create(this.FbInstance.OuterConfig);
				}
				else
				{
					IBubbleRangeCylinderConfig_SetValue pocoInterface = this.PocoInterface;
					this._OuterConfigCache = ((pocoInterface != null) ? pocoInterface.OuterConfig : null);
				}
				return this._OuterConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().OuterConfig = value;
				this._OuterConfigInited = false;
			}
		}

		// Token: 0x04005829 RID: 22569
		[Nullable(2)]
		protected IBubbleRangeCylinderConfig FbInstance;

		// Token: 0x0400582A RID: 22570
		[Nullable(2)]
		protected IBubbleRangeCylinderConfig_SetValue PocoInterface;

		// Token: 0x0400582B RID: 22571
		private IBubbleCylinderConfig _InnerConfigCache;

		// Token: 0x0400582C RID: 22572
		private bool _InnerConfigInited;

		// Token: 0x0400582D RID: 22573
		private IBubbleCylinderConfig _OuterConfigCache;

		// Token: 0x0400582E RID: 22574
		private bool _OuterConfigInited;
	}
}
