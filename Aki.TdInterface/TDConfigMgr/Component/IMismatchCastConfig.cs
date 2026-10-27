using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F8 RID: 1272
	[NullableContext(1)]
	[Nullable(0)]
	public class IMismatchCastConfig
	{
		// Token: 0x060019E6 RID: 6630 RVA: 0x0004C24C File Offset: 0x0004A44C
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

		// Token: 0x060019E7 RID: 6631 RVA: 0x0004C284 File Offset: 0x0004A484
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

		// Token: 0x060019E8 RID: 6632 RVA: 0x0004C297 File Offset: 0x0004A497
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

		// Token: 0x060019E9 RID: 6633 RVA: 0x0004C2AA File Offset: 0x0004A4AA
		public IMismatchCastConfig_SetValue ToSetValue()
		{
			return new IMismatchCastConfig_SetValue
			{
				MismatchSequence = this.MismatchSequence
			};
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x0004C2C0 File Offset: 0x0004A4C0
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x0004C353 File Offset: 0x0004A553
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IMismatchSequence> MismatchSequence
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().MismatchSequence = value;
				this._MismatchSequenceInited = false;
			}
		}

		// Token: 0x040012EA RID: 4842
		[Nullable(2)]
		protected IMismatchCastConfig FbInstance;

		// Token: 0x040012EB RID: 4843
		[Nullable(2)]
		protected IMismatchCastConfig_SetValue PocoInterface;

		// Token: 0x040012EC RID: 4844
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMismatchSequence> _MismatchSequenceCache;

		// Token: 0x040012ED RID: 4845
		private bool _MismatchSequenceInited;
	}
}
