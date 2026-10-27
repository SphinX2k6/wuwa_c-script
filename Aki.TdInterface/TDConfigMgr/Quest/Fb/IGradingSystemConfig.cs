using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012DC RID: 4828
	public class IGradingSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E55 RID: 28245 RVA: 0x0010AAD9 File Offset: 0x00108CD9
		[NullableContext(1)]
		public static IGradingSystemConfig Create(IGradingSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGradingSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x06006E56 RID: 28246 RVA: 0x0010AAF8 File Offset: 0x00108CF8
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x06006E57 RID: 28247 RVA: 0x0010AB05 File Offset: 0x00108D05
		public virtual int GradingSystemId
		{
			get
			{
				return this.Instance.GradingSystemId;
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06006E58 RID: 28248 RVA: 0x0010AB14 File Offset: 0x00108D14
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IGradingSystemVar> Vars
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IGradingSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IGradingSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x04003F34 RID: 16180
		private IGradingSystemConfig Instance;

		// Token: 0x04003F35 RID: 16181
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IGradingSystemVar> _VarsCache;

		// Token: 0x04003F36 RID: 16182
		private bool _VarsInited;
	}
}
