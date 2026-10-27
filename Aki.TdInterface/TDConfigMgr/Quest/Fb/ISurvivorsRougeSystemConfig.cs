using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012E1 RID: 4833
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E6A RID: 28266 RVA: 0x0010AD3C File Offset: 0x00108F3C
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

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x06006E6B RID: 28267 RVA: 0x0010AD5B File Offset: 0x00108F5B
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x06006E6C RID: 28268 RVA: 0x0010AD68 File Offset: 0x00108F68
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

		// Token: 0x04003F41 RID: 16193
		private ISurvivorsRougeSystemConfig Instance;

		// Token: 0x04003F42 RID: 16194
		private List<ISurvivorsRougeSystemVar> _VarsCache;

		// Token: 0x04003F43 RID: 16195
		private bool _VarsInited;
	}
}
