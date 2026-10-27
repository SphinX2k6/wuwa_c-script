using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ABA RID: 2746
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomNpcRule : IRefreshRule
	{
		// Token: 0x06003F47 RID: 16199 RVA: 0x000A1B21 File Offset: 0x0009FD21
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

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06003F48 RID: 16200 RVA: 0x000A1B40 File Offset: 0x0009FD40
		public override ERefreshRule Type
		{
			get
			{
				return (ERefreshRule)this.Instance.Type;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06003F49 RID: 16201 RVA: 0x000A1B50 File Offset: 0x0009FD50
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

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06003F4A RID: 16202 RVA: 0x000A1BB9 File Offset: 0x0009FDB9
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

		// Token: 0x04002323 RID: 8995
		private IRandomNpcRule Instance;

		// Token: 0x04002324 RID: 8996
		private List<IFixedDateTime> _DateTimeListCache;

		// Token: 0x04002325 RID: 8997
		private bool _DateTimeListInited;

		// Token: 0x04002326 RID: 8998
		[Nullable(2)]
		private IProbabilityRefreshGroup _ProbabilityRefreshGroupCache;

		// Token: 0x04002327 RID: 8999
		private bool _ProbabilityRefreshGroupInited;
	}
}
