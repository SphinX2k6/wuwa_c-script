using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D62 RID: 3426
	[NullableContext(1)]
	[Nullable(0)]
	public class InhalationAbilityComponent : IComponentBase
	{
		// Token: 0x06004E05 RID: 19973 RVA: 0x000C1D0B File Offset: 0x000BFF0B
		public static InhalationAbilityComponent Create(IInhalationAbilityComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InhalationAbilityComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06004E06 RID: 19974 RVA: 0x000C1D2C File Offset: 0x000BFF2C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06004E07 RID: 19975 RVA: 0x000C1D64 File Offset: 0x000BFF64
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x000C1D7C File Offset: 0x000BFF7C
		public virtual List<IInhalationConfig> InhalationConfigs
		{
			get
			{
				if (this._InhalationConfigsInited)
				{
					return this._InhalationConfigsCache;
				}
				this._InhalationConfigsInited = true;
				int inhalationConfigsLength = this.Instance.InhalationConfigsLength;
				this._InhalationConfigsCache = new List<IInhalationConfig>(inhalationConfigsLength);
				for (int i = 0; i < inhalationConfigsLength; i++)
				{
					this._InhalationConfigsCache.Add(IInhalationConfig.Create(this.Instance.InhalationConfigs(i)));
				}
				return this._InhalationConfigsCache;
			}
		}

		// Token: 0x04002CBB RID: 11451
		private IInhalationAbilityComponent Instance;

		// Token: 0x04002CBC RID: 11452
		private List<IInhalationConfig> _InhalationConfigsCache;

		// Token: 0x04002CBD RID: 11453
		private bool _InhalationConfigsInited;
	}
}
