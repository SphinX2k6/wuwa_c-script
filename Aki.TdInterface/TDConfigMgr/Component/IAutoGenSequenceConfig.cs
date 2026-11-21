using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000208 RID: 520
	public class IAutoGenSequenceConfig
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x00026E2C File Offset: 0x0002502C
		private IAutoGenSequenceConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAutoGenSequenceConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAutoGenSequenceConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAutoGenSequenceConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00026E64 File Offset: 0x00025064
		public static IAutoGenSequenceConfig Create([Nullable(2)] IAutoGenSequenceConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAutoGenSequenceConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00026E77 File Offset: 0x00025077
		public static IAutoGenSequenceConfig CreateFromSetValue([Nullable(2)] IAutoGenSequenceConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAutoGenSequenceConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00026E8A File Offset: 0x0002508A
		public IAutoGenSequenceConfig_SetValue ToSetValue()
		{
			return new IAutoGenSequenceConfig_SetValue
			{
				SequencePath = this.SequencePath,
				SequenceConfig = this.SequenceConfig,
				Count = this.Count
			};
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00026EB5 File Offset: 0x000250B5
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00026EDC File Offset: 0x000250DC
		[Nullable(2)]
		public virtual string SequencePath
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SequencePath;
				}
				IAutoGenSequenceConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SequencePath;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SequencePath = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00026EEC File Offset: 0x000250EC
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00026F4D File Offset: 0x0002514D
		public virtual PlayLevelSequence SequenceConfig
		{
			get
			{
				if (this._SequenceConfigInited)
				{
					return this._SequenceConfigCache;
				}
				this._SequenceConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SequenceConfigCache = PlayLevelSequence.Create(this.FbInstance.SequenceConfig);
				}
				else
				{
					IAutoGenSequenceConfig_SetValue pocoInterface = this.PocoInterface;
					this._SequenceConfigCache = ((pocoInterface != null) ? pocoInterface.SequenceConfig : null);
				}
				return this._SequenceConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SequenceConfig = value;
				this._SequenceConfigInited = false;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00026F62 File Offset: 0x00025162
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00026F8D File Offset: 0x0002518D
		public virtual int Count
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Count;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Count;
			}
			set
			{
				this.GetOrCreatePoco().Count = value;
			}
		}

		// Token: 0x0400094B RID: 2379
		[Nullable(2)]
		protected IAutoGenSequenceConfig FbInstance;

		// Token: 0x0400094C RID: 2380
		[Nullable(2)]
		protected IAutoGenSequenceConfig_SetValue PocoInterface;

		// Token: 0x0400094D RID: 2381
		private PlayLevelSequence _SequenceConfigCache;

		// Token: 0x0400094E RID: 2382
		private bool _SequenceConfigInited;
	}
}
