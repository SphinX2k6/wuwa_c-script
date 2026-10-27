using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBA RID: 3002
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcAwakeShow
	{
		// Token: 0x060044D8 RID: 17624 RVA: 0x000AEB14 File Offset: 0x000ACD14
		[NullableContext(1)]
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

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x000AEB33 File Offset: 0x000ACD33
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

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x000AEB67 File Offset: 0x000ACD67
		public virtual string MaterialDa
		{
			get
			{
				return this.Instance.MaterialDa;
			}
		}

		// Token: 0x040026F1 RID: 9969
		private INpcAwakeShow Instance;

		// Token: 0x040026F2 RID: 9970
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x040026F3 RID: 9971
		private bool _RegisteredMontageIdInited;
	}
}
