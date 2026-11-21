using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C00 RID: 3072
	public class IMismatchCastConfig
	{
		// Token: 0x06004687 RID: 18055 RVA: 0x000B3950 File Offset: 0x000B1B50
		public static IMismatchCastConfig Create(IMismatchCastConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMismatchCastConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x000B3970 File Offset: 0x000B1B70
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int mismatchSequenceLength = this.Instance.MismatchSequenceLength;
				this._MismatchSequenceCache = new List<IMismatchSequence>(mismatchSequenceLength);
				for (int i = 0; i < mismatchSequenceLength; i++)
				{
					this._MismatchSequenceCache.Add(IMismatchSequence.Create(this.Instance.MismatchSequence(i)));
				}
				return this._MismatchSequenceCache;
			}
		}

		// Token: 0x0400279B RID: 10139
		private IMismatchCastConfig Instance;

		// Token: 0x0400279C RID: 10140
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMismatchSequence> _MismatchSequenceCache;

		// Token: 0x0400279D RID: 10141
		private bool _MismatchSequenceInited;
	}
}
