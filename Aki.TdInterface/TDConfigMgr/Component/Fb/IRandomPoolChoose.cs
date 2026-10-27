using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DAF RID: 3503
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomPoolChoose : IMonsterChooseType
	{
		// Token: 0x06004F90 RID: 20368 RVA: 0x000C4FC7 File Offset: 0x000C31C7
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

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06004F91 RID: 20369 RVA: 0x000C4FE6 File Offset: 0x000C31E6
		public override EMonsterChooseType Type
		{
			get
			{
				return (EMonsterChooseType)this.Instance.Type;
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06004F92 RID: 20370 RVA: 0x000C4FF4 File Offset: 0x000C31F4
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

		// Token: 0x04002DA4 RID: 11684
		private IRandomPoolChoose Instance;

		// Token: 0x04002DA5 RID: 11685
		private List<IRandomPoolConfig> _RandomPoolConfigsCache;

		// Token: 0x04002DA6 RID: 11686
		private bool _RandomPoolConfigsInited;
	}
}
