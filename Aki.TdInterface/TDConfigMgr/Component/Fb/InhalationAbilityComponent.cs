using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E5C RID: 3676
	public class InhalationAbilityComponent : IComponentBase
	{
		// Token: 0x06005321 RID: 21281 RVA: 0x000CD44F File Offset: 0x000CB64F
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

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x000CD470 File Offset: 0x000CB670
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

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06005323 RID: 21283 RVA: 0x000CD4A8 File Offset: 0x000CB6A8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x000CD4C0 File Offset: 0x000CB6C0
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

		// Token: 0x04002F7B RID: 12155
		private IInhalationAbilityComponent Instance;

		// Token: 0x04002F7C RID: 12156
		private List<IInhalationConfig> _InhalationConfigsCache;

		// Token: 0x04002F7D RID: 12157
		private bool _InhalationConfigsInited;
	}
}
