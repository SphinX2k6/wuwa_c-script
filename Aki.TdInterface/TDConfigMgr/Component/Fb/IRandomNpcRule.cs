using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B84 RID: 2948
	public class IRandomNpcRule : IRefreshRule
	{
		// Token: 0x06004371 RID: 17265 RVA: 0x000AB115 File Offset: 0x000A9315
		public static IRandomNpcRule Create(IRandomNpcRule? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomNpcRule
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x000AB134 File Offset: 0x000A9334
		public override ERefreshRule Type
		{
			get
			{
				return (ERefreshRule)this.Instance.Type;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06004373 RID: 17267 RVA: 0x000AB144 File Offset: 0x000A9344
		public virtual List<IFixedDateTime> DateTimeList
		{
			get
			{
				if (this._DateTimeListInited)
				{
					return this._DateTimeListCache;
				}
				this._DateTimeListInited = true;
				int dateTimeListLength = this.Instance.DateTimeListLength;
				this._DateTimeListCache = new List<IFixedDateTime>(dateTimeListLength);
				for (int i = 0; i < dateTimeListLength; i++)
				{
					this._DateTimeListCache.Add(IFixedDateTime.Create(this.Instance.DateTimeList(i)));
				}
				return this._DateTimeListCache;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06004374 RID: 17268 RVA: 0x000AB1AD File Offset: 0x000A93AD
		public virtual IProbabilityRefreshGroup ProbabilityRefreshGroup
		{
			get
			{
				if (this._ProbabilityRefreshGroupInited)
				{
					return this._ProbabilityRefreshGroupCache;
				}
				this._ProbabilityRefreshGroupInited = true;
				this._ProbabilityRefreshGroupCache = IProbabilityRefreshGroup.Create(this.Instance.ProbabilityRefreshGroup);
				return this._ProbabilityRefreshGroupCache;
			}
		}

		// Token: 0x0400253F RID: 9535
		private IRandomNpcRule Instance;

		// Token: 0x04002540 RID: 9536
		private List<IFixedDateTime> _DateTimeListCache;

		// Token: 0x04002541 RID: 9537
		private bool _DateTimeListInited;

		// Token: 0x04002542 RID: 9538
		[Nullable(2)]
		private IProbabilityRefreshGroup _ProbabilityRefreshGroupCache;

		// Token: 0x04002543 RID: 9539
		private bool _ProbabilityRefreshGroupInited;
	}
}
