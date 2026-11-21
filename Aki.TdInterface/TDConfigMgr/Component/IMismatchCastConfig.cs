using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000559 RID: 1369
	public class IMismatchCastConfig
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x00050D90 File Offset: 0x0004EF90
		private IMismatchCastConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMismatchCastConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMismatchCastConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMismatchCastConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00050DC8 File Offset: 0x0004EFC8
		public static IMismatchCastConfig Create([Nullable(2)] IMismatchCastConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMismatchCastConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00050DDB File Offset: 0x0004EFDB
		public static IMismatchCastConfig CreateFromSetValue([Nullable(2)] IMismatchCastConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMismatchCastConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00050DEE File Offset: 0x0004EFEE
		public IMismatchCastConfig_SetValue ToSetValue()
		{
			return new IMismatchCastConfig_SetValue
			{
				MismatchSequence = this.MismatchSequence
			};
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x00050E04 File Offset: 0x0004F004
		// (set) Token: 0x06001BCD RID: 7117 RVA: 0x00050E97 File Offset: 0x0004F097
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IMismatchSequence> MismatchSequence
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._MismatchSequenceInited)
				{
					return this._MismatchSequenceCache;
				}
				this._MismatchSequenceInited = true;
				if (this.FbInstance != null)
				{
					List<IMismatchSequence> mismatchSequence = this.FbInstance.MismatchSequence;
					if (mismatchSequence != null)
					{
						this._MismatchSequenceCache = new List<IMismatchSequence>(mismatchSequence.Count);
						for (int i = 0; i < mismatchSequence.Count; i++)
						{
							this._MismatchSequenceCache.Add(IMismatchSequence.Create(mismatchSequence[i]));
						}
					}
				}
				else
				{
					IMismatchCastConfig_SetValue pocoInterface = this.PocoInterface;
					this._MismatchSequenceCache = ((pocoInterface != null) ? pocoInterface.MismatchSequence : null);
				}
				return this._MismatchSequenceCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().MismatchSequence = value;
				this._MismatchSequenceInited = false;
			}
		}

		// Token: 0x0400144A RID: 5194
		[Nullable(2)]
		protected IMismatchCastConfig FbInstance;

		// Token: 0x0400144B RID: 5195
		[Nullable(2)]
		protected IMismatchCastConfig_SetValue PocoInterface;

		// Token: 0x0400144C RID: 5196
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMismatchSequence> _MismatchSequenceCache;

		// Token: 0x0400144D RID: 5197
		private bool _MismatchSequenceInited;
	}
}
