using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012E5 RID: 4837
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E7A RID: 28282 RVA: 0x0010AF3C File Offset: 0x0010913C
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

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06006E7B RID: 28283 RVA: 0x0010AF5B File Offset: 0x0010915B
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06006E7C RID: 28284 RVA: 0x0010AF68 File Offset: 0x00109168
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

		// Token: 0x04003F4D RID: 16205
		private IRoleTowerSystemConfig Instance;

		// Token: 0x04003F4E RID: 16206
		private List<IRoleTowerSystemVar> _VarsCache;

		// Token: 0x04003F4F RID: 16207
		private bool _VarsInited;
	}
}
