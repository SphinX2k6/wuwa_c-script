using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012E3 RID: 4835
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E72 RID: 28274 RVA: 0x0010AE3C File Offset: 0x0010903C
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

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06006E73 RID: 28275 RVA: 0x0010AE5B File Offset: 0x0010905B
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06006E74 RID: 28276 RVA: 0x0010AE68 File Offset: 0x00109068
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

		// Token: 0x04003F47 RID: 16199
		private IKurotatoSystemConfig Instance;

		// Token: 0x04003F48 RID: 16200
		private List<IKurotatoSystemVar> _VarsCache;

		// Token: 0x04003F49 RID: 16201
		private bool _VarsInited;
	}
}
