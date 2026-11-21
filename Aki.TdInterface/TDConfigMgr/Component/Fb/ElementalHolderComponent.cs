using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F22 RID: 3874
	public class ElementalHolderComponent : IComponentBase
	{
		// Token: 0x06005714 RID: 22292 RVA: 0x000D574A File Offset: 0x000D394A
		public static ElementalHolderComponent Create(IElementalHolderComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ElementalHolderComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06005715 RID: 22293 RVA: 0x000D576C File Offset: 0x000D396C
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

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x000D57A4 File Offset: 0x000D39A4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06005717 RID: 22295 RVA: 0x000D57BA File Offset: 0x000D39BA
		public virtual IElementalAbilityConfig AbilityConfig
		{
			get
			{
				if (this._AbilityConfigInited)
				{
					return this._AbilityConfigCache;
				}
				this._AbilityConfigInited = true;
				this._AbilityConfigCache = IElementalAbilityConfig.Create(this.Instance.AbilityConfig);
				return this._AbilityConfigCache;
			}
		}

		// Token: 0x040031F7 RID: 12791
		private IElementalHolderComponent Instance;

		// Token: 0x040031F8 RID: 12792
		[Nullable(2)]
		private IElementalAbilityConfig _AbilityConfigCache;

		// Token: 0x040031F9 RID: 12793
		private bool _AbilityConfigInited;
	}
}
