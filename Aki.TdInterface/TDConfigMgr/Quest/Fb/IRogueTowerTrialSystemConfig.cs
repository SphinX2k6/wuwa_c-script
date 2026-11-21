using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001436 RID: 5174
	public class IRogueTowerTrialSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06007527 RID: 29991 RVA: 0x001197C8 File Offset: 0x001179C8
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

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x06007528 RID: 29992 RVA: 0x001197E7 File Offset: 0x001179E7
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x06007529 RID: 29993 RVA: 0x001197F4 File Offset: 0x001179F4
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

		// Token: 0x040042DA RID: 17114
		private IRogueTowerTrialSystemConfig Instance;

		// Token: 0x040042DB RID: 17115
		private List<IRogueTowerTrialSystemVar> _VarsCache;

		// Token: 0x040042DC RID: 17116
		private bool _VarsInited;
	}
}
