using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BCA RID: 3018
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcDeathInteract
	{
		// Token: 0x06004568 RID: 17768 RVA: 0x000AFC9B File Offset: 0x000ADE9B
		[NullableContext(1)]
		public static INpcDeathInteract Create(INpcDeathInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcDeathInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x000AFCBA File Offset: 0x000ADEBA
		public virtual IMontageId Montage
		{
			get
			{
				if (this._MontageInited)
				{
					return this._MontageCache;
				}
				this._MontageInited = true;
				this._MontageCache = IMontageId.Create(this.Instance.Montage);
				return this._MontageCache;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x000AFCEE File Offset: 0x000ADEEE
		public virtual string MaterialDa
		{
			get
			{
				return this.Instance.MaterialDa;
			}
		}

		// Token: 0x04002779 RID: 10105
		private INpcDeathInteract Instance;

		// Token: 0x0400277A RID: 10106
		private IMontageId _MontageCache;

		// Token: 0x0400277B RID: 10107
		private bool _MontageInited;
	}
}
