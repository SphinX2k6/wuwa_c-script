using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001430 RID: 5168
	public class IMotorFightSystemConfig : IEnableSystemConfig
	{
		// Token: 0x0600750F RID: 29967 RVA: 0x001194C8 File Offset: 0x001176C8
		public static IMotorFightSystemConfig Create(IMotorFightSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorFightSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x06007510 RID: 29968 RVA: 0x001194E7 File Offset: 0x001176E7
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x06007511 RID: 29969 RVA: 0x001194F4 File Offset: 0x001176F4
		public virtual List<IMotorFightSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IMotorFightSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IMotorFightSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x040042C8 RID: 17096
		private IMotorFightSystemConfig Instance;

		// Token: 0x040042C9 RID: 17097
		private List<IMotorFightSystemVar> _VarsCache;

		// Token: 0x040042CA RID: 17098
		private bool _VarsInited;
	}
}
