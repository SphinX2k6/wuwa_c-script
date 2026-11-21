using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001434 RID: 5172
	public class IFlipperSystemConfig : IEnableSystemConfig
	{
		// Token: 0x0600751F RID: 29983 RVA: 0x001196C8 File Offset: 0x001178C8
		public static IFlipperSystemConfig Create(IFlipperSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x06007520 RID: 29984 RVA: 0x001196E7 File Offset: 0x001178E7
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x06007521 RID: 29985 RVA: 0x001196F4 File Offset: 0x001178F4
		public virtual List<IFlipperSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IFlipperSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IFlipperSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x040042D4 RID: 17108
		private IFlipperSystemConfig Instance;

		// Token: 0x040042D5 RID: 17109
		private List<IFlipperSystemVar> _VarsCache;

		// Token: 0x040042D6 RID: 17110
		private bool _VarsInited;
	}
}
