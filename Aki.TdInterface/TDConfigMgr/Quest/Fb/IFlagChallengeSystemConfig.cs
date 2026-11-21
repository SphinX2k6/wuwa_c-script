using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001432 RID: 5170
	public class IFlagChallengeSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06007517 RID: 29975 RVA: 0x001195C8 File Offset: 0x001177C8
		public static IFlagChallengeSystemConfig Create(IFlagChallengeSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlagChallengeSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x06007518 RID: 29976 RVA: 0x001195E7 File Offset: 0x001177E7
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x06007519 RID: 29977 RVA: 0x001195F4 File Offset: 0x001177F4
		public virtual List<IFlagChallengeSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IFlagChallengeSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IFlagChallengeSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x040042CE RID: 17102
		private IFlagChallengeSystemConfig Instance;

		// Token: 0x040042CF RID: 17103
		private List<IFlagChallengeSystemVar> _VarsCache;

		// Token: 0x040042D0 RID: 17104
		private bool _VarsInited;
	}
}
