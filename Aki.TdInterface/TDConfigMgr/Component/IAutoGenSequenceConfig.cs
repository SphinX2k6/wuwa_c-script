using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001E1 RID: 481
	[NullableContext(1)]
	[Nullable(0)]
	public class IAutoGenSequenceConfig
	{
		// Token: 0x060007C0 RID: 1984 RVA: 0x0002574C File Offset: 0x0002394C
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

		// Token: 0x060007C1 RID: 1985 RVA: 0x00025784 File Offset: 0x00023984
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

		// Token: 0x060007C2 RID: 1986 RVA: 0x00025797 File Offset: 0x00023997
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

		// Token: 0x060007C3 RID: 1987 RVA: 0x000257AA File Offset: 0x000239AA
		public IAutoGenSequenceConfig_SetValue ToSetValue()
		{
			return new IAutoGenSequenceConfig_SetValue
			{
				SequencePath = this.SequencePath,
				SequenceConfig = this.SequenceConfig,
				Count = this.Count
			};
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x000257D5 File Offset: 0x000239D5
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x000257FC File Offset: 0x000239FC
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0002580C File Offset: 0x00023A0C
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0002586D File Offset: 0x00023A6D
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00025882 File Offset: 0x00023A82
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x000258AD File Offset: 0x00023AAD
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

		// Token: 0x040008C4 RID: 2244
		[Nullable(2)]
		protected IAutoGenSequenceConfig FbInstance;

		// Token: 0x040008C5 RID: 2245
		[Nullable(2)]
		protected IAutoGenSequenceConfig_SetValue PocoInterface;

		// Token: 0x040008C6 RID: 2246
		private PlayLevelSequence _SequenceConfigCache;

		// Token: 0x040008C7 RID: 2247
		private bool _SequenceConfigInited;
	}
}
