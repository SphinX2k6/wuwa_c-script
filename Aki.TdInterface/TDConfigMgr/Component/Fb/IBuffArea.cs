using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D0D RID: 3341
	[NullableContext(1)]
	[Nullable(0)]
	public class IBuffArea : IEffectAreaMode
	{
		// Token: 0x06004C47 RID: 19527 RVA: 0x000BE23C File Offset: 0x000BC43C
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

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x000BE25B File Offset: 0x000BC45B
		public override EEffectAreaType Type
		{
			get
			{
				return (EEffectAreaType)this.Instance.Type;
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06004C49 RID: 19529 RVA: 0x000BE268 File Offset: 0x000BC468
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

		// Token: 0x04002BAA RID: 11178
		private IBuffArea Instance;

		// Token: 0x04002BAB RID: 11179
		private List<IBuffAreaStateConfig> _BuffConfigsCache;

		// Token: 0x04002BAC RID: 11180
		private bool _BuffConfigsInited;
	}
}
