using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E06 RID: 3590
	public class IBuffArea : IEffectAreaMode
	{
		// Token: 0x0600515A RID: 20826 RVA: 0x000C97E4 File Offset: 0x000C79E4
		public static IBuffArea Create(IBuffArea? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBuffArea
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x000C9803 File Offset: 0x000C7A03
		public override EEffectAreaType Type
		{
			get
			{
				return (EEffectAreaType)this.Instance.Type;
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x000C9810 File Offset: 0x000C7A10
		public virtual List<IBuffAreaStateConfig> BuffConfigs
		{
			get
			{
				if (this._BuffConfigsInited)
				{
					return this._BuffConfigsCache;
				}
				this._BuffConfigsInited = true;
				int buffConfigsLength = this.Instance.BuffConfigsLength;
				this._BuffConfigsCache = new List<IBuffAreaStateConfig>(buffConfigsLength);
				for (int i = 0; i < buffConfigsLength; i++)
				{
					this._BuffConfigsCache.Add(IBuffAreaStateConfig.Create(this.Instance.BuffConfigs(i)));
				}
				return this._BuffConfigsCache;
			}
		}

		// Token: 0x04002E67 RID: 11879
		private IBuffArea Instance;

		// Token: 0x04002E68 RID: 11880
		private List<IBuffAreaStateConfig> _BuffConfigsCache;

		// Token: 0x04002E69 RID: 11881
		private bool _BuffConfigsInited;
	}
}
