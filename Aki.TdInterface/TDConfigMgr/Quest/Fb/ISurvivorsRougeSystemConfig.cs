using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001427 RID: 5159
	public class ISurvivorsRougeSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060074EA RID: 29930 RVA: 0x0011903C File Offset: 0x0011723C
		public static ISurvivorsRougeSystemConfig Create(ISurvivorsRougeSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x0011905B File Offset: 0x0011725B
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x060074EC RID: 29932 RVA: 0x00119068 File Offset: 0x00117268
		public virtual List<ISurvivorsRougeSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<ISurvivorsRougeSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(ISurvivorsRougeSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x040042AF RID: 17071
		private ISurvivorsRougeSystemConfig Instance;

		// Token: 0x040042B0 RID: 17072
		private List<ISurvivorsRougeSystemVar> _VarsCache;

		// Token: 0x040042B1 RID: 17073
		private bool _VarsInited;
	}
}
