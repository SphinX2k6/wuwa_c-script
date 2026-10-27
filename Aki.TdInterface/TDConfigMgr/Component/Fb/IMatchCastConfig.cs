using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B30 RID: 2864
	[NullableContext(1)]
	[Nullable(0)]
	public class IMatchCastConfig
	{
		// Token: 0x06004224 RID: 16932 RVA: 0x000A9783 File Offset: 0x000A7983
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

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06004225 RID: 16933 RVA: 0x000A97A2 File Offset: 0x000A79A2
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x000A97AF File Offset: 0x000A79AF
		public virtual string Spline
		{
			get
			{
				return this.Instance.Spline;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06004227 RID: 16935 RVA: 0x000A97BC File Offset: 0x000A79BC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IMatchSequence> MatchSequence
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x000A9836 File Offset: 0x000A7A36
		[Nullable(2)]
		public virtual string SpeedCurve
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SpeedCurve;
			}
		}

		// Token: 0x0400254F RID: 9551
		private IMatchCastConfig Instance;

		// Token: 0x04002550 RID: 9552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMatchSequence> _MatchSequenceCache;

		// Token: 0x04002551 RID: 9553
		private bool _MatchSequenceInited;
	}
}
