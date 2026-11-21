using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BFE RID: 3070
	public class IMatchCastConfig
	{
		// Token: 0x0600467D RID: 18045 RVA: 0x000B3847 File Offset: 0x000B1A47
		public static IMatchCastConfig Create(IMatchCastConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMatchCastConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x0600467E RID: 18046 RVA: 0x000B3866 File Offset: 0x000B1A66
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x000B3873 File Offset: 0x000B1A73
		public virtual string Spline
		{
			get
			{
				return this.Instance.Spline;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06004680 RID: 18048 RVA: 0x000B3880 File Offset: 0x000B1A80
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IMatchSequence> MatchSequence
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._MatchSequenceInited)
				{
					return this._MatchSequenceCache;
				}
				this._MatchSequenceInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int matchSequenceLength = this.Instance.MatchSequenceLength;
				this._MatchSequenceCache = new List<IMatchSequence>(matchSequenceLength);
				for (int i = 0; i < matchSequenceLength; i++)
				{
					this._MatchSequenceCache.Add(IMatchSequence.Create(this.Instance.MatchSequence(i)));
				}
				return this._MatchSequenceCache;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06004681 RID: 18049 RVA: 0x000B38FA File Offset: 0x000B1AFA
		[Nullable(2)]
		public virtual string SpeedCurve
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SpeedCurve;
			}
		}

		// Token: 0x04002797 RID: 10135
		private IMatchCastConfig Instance;

		// Token: 0x04002798 RID: 10136
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMatchSequence> _MatchSequenceCache;

		// Token: 0x04002799 RID: 10137
		private bool _MatchSequenceInited;
	}
}
