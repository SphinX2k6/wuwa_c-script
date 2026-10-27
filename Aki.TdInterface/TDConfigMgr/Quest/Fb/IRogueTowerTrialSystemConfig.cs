using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012F0 RID: 4848
	[NullableContext(1)]
	[Nullable(0)]
	public class IRogueTowerTrialSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006EA7 RID: 28327 RVA: 0x0010B4C8 File Offset: 0x001096C8
		public static IRogueTowerTrialSystemConfig Create(IRogueTowerTrialSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueTowerTrialSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x06006EA8 RID: 28328 RVA: 0x0010B4E7 File Offset: 0x001096E7
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x06006EA9 RID: 28329 RVA: 0x0010B4F4 File Offset: 0x001096F4
		public virtual List<IRogueTowerTrialSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IRogueTowerTrialSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IRogueTowerTrialSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x04003F6C RID: 16236
		private IRogueTowerTrialSystemConfig Instance;

		// Token: 0x04003F6D RID: 16237
		private List<IRogueTowerTrialSystemVar> _VarsCache;

		// Token: 0x04003F6E RID: 16238
		private bool _VarsInited;
	}
}
