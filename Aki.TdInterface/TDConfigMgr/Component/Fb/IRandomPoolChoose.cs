using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EAB RID: 3755
	public class IRandomPoolChoose : IMonsterChooseType
	{
		// Token: 0x060054B5 RID: 21685 RVA: 0x000D0817 File Offset: 0x000CEA17
		public static IRandomPoolChoose Create(IRandomPoolChoose? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomPoolChoose
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x060054B6 RID: 21686 RVA: 0x000D0836 File Offset: 0x000CEA36
		public override EMonsterChooseType Type
		{
			get
			{
				return (EMonsterChooseType)this.Instance.Type;
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x060054B7 RID: 21687 RVA: 0x000D0844 File Offset: 0x000CEA44
		public virtual List<IRandomPoolConfig> RandomPoolConfigs
		{
			get
			{
				if (this._RandomPoolConfigsInited)
				{
					return this._RandomPoolConfigsCache;
				}
				this._RandomPoolConfigsInited = true;
				int randomPoolConfigsLength = this.Instance.RandomPoolConfigsLength;
				this._RandomPoolConfigsCache = new List<IRandomPoolConfig>(randomPoolConfigsLength);
				for (int i = 0; i < randomPoolConfigsLength; i++)
				{
					this._RandomPoolConfigsCache.Add(IRandomPoolConfig.Create(this.Instance.RandomPoolConfigs(i)));
				}
				return this._RandomPoolConfigsCache;
			}
		}

		// Token: 0x0400306A RID: 12394
		private IRandomPoolChoose Instance;

		// Token: 0x0400306B RID: 12395
		private List<IRandomPoolConfig> _RandomPoolConfigsCache;

		// Token: 0x0400306C RID: 12396
		private bool _RandomPoolConfigsInited;
	}
}
