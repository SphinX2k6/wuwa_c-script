using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012EC RID: 4844
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlagChallengeSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E97 RID: 28311 RVA: 0x0010B2C8 File Offset: 0x001094C8
		public static IFlagChallengeSystemConfig Create(IFlagChallengeSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlagChallengeSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x06006E98 RID: 28312 RVA: 0x0010B2E7 File Offset: 0x001094E7
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x06006E99 RID: 28313 RVA: 0x0010B2F4 File Offset: 0x001094F4
		public virtual List<IFlagChallengeSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IFlagChallengeSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IFlagChallengeSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x04003F60 RID: 16224
		private IFlagChallengeSystemConfig Instance;

		// Token: 0x04003F61 RID: 16225
		private List<IFlagChallengeSystemVar> _VarsCache;

		// Token: 0x04003F62 RID: 16226
		private bool _VarsInited;
	}
}
