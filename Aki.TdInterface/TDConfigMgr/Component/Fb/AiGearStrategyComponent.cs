using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E2B RID: 3627
	public class AiGearStrategyComponent : IComponentBase
	{
		// Token: 0x0600522B RID: 21035 RVA: 0x000CB329 File Offset: 0x000C9529
		public static AiGearStrategyComponent Create(IAiGearStrategyComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AiGearStrategyComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x000CB348 File Offset: 0x000C9548
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

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x0600522D RID: 21037 RVA: 0x000CB380 File Offset: 0x000C9580
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x0600522E RID: 21038 RVA: 0x000CB396 File Offset: 0x000C9596
		public virtual IAiGearStrategy StrategyType
		{
			get
			{
				if (this._StrategyTypeInited)
				{
					return this._StrategyTypeCache;
				}
				this._StrategyTypeInited = true;
				this._StrategyTypeCache = ComponentReadHelper.ReadAiGearStrategyComponent_StrategyType(this.Instance);
				return this._StrategyTypeCache;
			}
		}

		// Token: 0x04002EE8 RID: 12008
		private IAiGearStrategyComponent Instance;

		// Token: 0x04002EE9 RID: 12009
		private IAiGearStrategy _StrategyTypeCache;

		// Token: 0x04002EEA RID: 12010
		private bool _StrategyTypeInited;
	}
}
