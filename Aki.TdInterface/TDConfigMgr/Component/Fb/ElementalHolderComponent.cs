using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E26 RID: 3622
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalHolderComponent : IComponentBase
	{
		// Token: 0x060051ED RID: 20973 RVA: 0x000C9E82 File Offset: 0x000C8082
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

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x000C9EA4 File Offset: 0x000C80A4
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

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x060051EF RID: 20975 RVA: 0x000C9EDC File Offset: 0x000C80DC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x000C9EF2 File Offset: 0x000C80F2
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

		// Token: 0x04002F2F RID: 12079
		private IElementalHolderComponent Instance;

		// Token: 0x04002F30 RID: 12080
		[Nullable(2)]
		private IElementalAbilityConfig _AbilityConfigCache;

		// Token: 0x04002F31 RID: 12081
		private bool _AbilityConfigInited;
	}
}
