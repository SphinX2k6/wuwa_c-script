using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200142B RID: 5163
	public class IRoleTowerSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060074FA RID: 29946 RVA: 0x0011923C File Offset: 0x0011743C
		public static IRoleTowerSystemConfig Create(IRoleTowerSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x060074FB RID: 29947 RVA: 0x0011925B File Offset: 0x0011745B
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x060074FC RID: 29948 RVA: 0x00119268 File Offset: 0x00117468
		public virtual List<IRoleTowerSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IRoleTowerSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IRoleTowerSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x040042BB RID: 17083
		private IRoleTowerSystemConfig Instance;

		// Token: 0x040042BC RID: 17084
		private List<IRoleTowerSystemVar> _VarsCache;

		// Token: 0x040042BD RID: 17085
		private bool _VarsInited;
	}
}
