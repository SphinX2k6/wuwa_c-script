using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C88 RID: 3208
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcAwakeShow
	{
		// Token: 0x06004931 RID: 18737 RVA: 0x000B8BD8 File Offset: 0x000B6DD8
		[NullableContext(0)]
		public static INpcAwakeShow Create(INpcAwakeShow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcAwakeShow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06004932 RID: 18738 RVA: 0x000B8BF7 File Offset: 0x000B6DF7
		public virtual IMontageId RegisteredMontageId
		{
			get
			{
				if (this._RegisteredMontageIdInited)
				{
					return this._RegisteredMontageIdCache;
				}
				this._RegisteredMontageIdInited = true;
				this._RegisteredMontageIdCache = IMontageId.Create(this.Instance.RegisteredMontageId);
				return this._RegisteredMontageIdCache;
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x000B8C2B File Offset: 0x000B6E2B
		public virtual string MaterialDa
		{
			get
			{
				return this.Instance.MaterialDa;
			}
		}

		// Token: 0x04002939 RID: 10553
		private INpcAwakeShow Instance;

		// Token: 0x0400293A RID: 10554
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x0400293B RID: 10555
		private bool _RegisteredMontageIdInited;
	}
}
