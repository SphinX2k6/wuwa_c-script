using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001429 RID: 5161
	public class IKurotatoSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060074F2 RID: 29938 RVA: 0x0011913C File Offset: 0x0011733C
		public static IKurotatoSystemConfig Create(IKurotatoSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x060074F3 RID: 29939 RVA: 0x0011915B File Offset: 0x0011735B
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x060074F4 RID: 29940 RVA: 0x00119168 File Offset: 0x00117368
		public virtual List<IKurotatoSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IKurotatoSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IKurotatoSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x040042B5 RID: 17077
		private IKurotatoSystemConfig Instance;

		// Token: 0x040042B6 RID: 17078
		private List<IKurotatoSystemVar> _VarsCache;

		// Token: 0x040042B7 RID: 17079
		private bool _VarsInited;
	}
}
