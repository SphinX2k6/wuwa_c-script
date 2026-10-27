using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B32 RID: 2866
	public class IMismatchCastConfig
	{
		// Token: 0x0600422E RID: 16942 RVA: 0x000A988C File Offset: 0x000A7A8C
		[NullableContext(1)]
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

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x000A98AC File Offset: 0x000A7AAC
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

		// Token: 0x04002553 RID: 9555
		private IMismatchCastConfig Instance;

		// Token: 0x04002554 RID: 9556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMismatchSequence> _MismatchSequenceCache;

		// Token: 0x04002555 RID: 9557
		private bool _MismatchSequenceInited;
	}
}
