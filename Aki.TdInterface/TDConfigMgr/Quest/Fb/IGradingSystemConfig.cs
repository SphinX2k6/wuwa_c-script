using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001422 RID: 5154
	public class IGradingSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060074D5 RID: 29909 RVA: 0x00118DD9 File Offset: 0x00116FD9
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

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x060074D6 RID: 29910 RVA: 0x00118DF8 File Offset: 0x00116FF8
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x060074D7 RID: 29911 RVA: 0x00118E05 File Offset: 0x00117005
		public virtual int GradingSystemId
		{
			get
			{
				return this.Instance.GradingSystemId;
			}
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x060074D8 RID: 29912 RVA: 0x00118E14 File Offset: 0x00117014
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IGradingSystemVar> Vars
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x040042A2 RID: 17058
		private IGradingSystemConfig Instance;

		// Token: 0x040042A3 RID: 17059
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IGradingSystemVar> _VarsCache;

		// Token: 0x040042A4 RID: 17060
		private bool _VarsInited;
	}
}
