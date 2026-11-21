using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000D8 RID: 216
	public class ElementalHolderComponent : IComponentBase
	{
		// Token: 0x06000398 RID: 920 RVA: 0x0001CC4C File Offset: 0x0001AE4C
		private ElementalHolderComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ElementalHolderComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ElementalHolderComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ElementalHolderComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001CC84 File Offset: 0x0001AE84
		public static ElementalHolderComponent Create([Nullable(2)] ElementalHolderComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ElementalHolderComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001CC97 File Offset: 0x0001AE97
		public static ElementalHolderComponent CreateFromSetValue([Nullable(2)] ElementalHolderComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ElementalHolderComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0001CCAA File Offset: 0x0001AEAA
		public new ElementalHolderComponent_SetValue ToSetValue()
		{
			return new ElementalHolderComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AbilityConfig = this.AbilityConfig
			};
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0001CD12 File Offset: 0x0001AF12
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ElementalHolderComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0001CD20 File Offset: 0x0001AF20
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0001CD4A File Offset: 0x0001AF4A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0001CD58 File Offset: 0x0001AF58
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x0001CDB9 File Offset: 0x0001AFB9
		public virtual IElementalAbilityConfig AbilityConfig
		{
			get
			{
				if (this._AbilityConfigInited)
				{
					return this._AbilityConfigCache;
				}
				this._AbilityConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AbilityConfigCache = IElementalAbilityConfig.Create(this.FbInstance.AbilityConfig);
				}
				else
				{
					ElementalHolderComponent_SetValue pocoInterface = this.PocoInterface;
					this._AbilityConfigCache = ((pocoInterface != null) ? pocoInterface.AbilityConfig : null);
				}
				return this._AbilityConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().AbilityConfig = value;
				this._AbilityConfigInited = false;
			}
		}

		// Token: 0x040004B6 RID: 1206
		[Nullable(2)]
		protected new ElementalHolderComponent FbInstance;

		// Token: 0x040004B7 RID: 1207
		[Nullable(2)]
		protected new ElementalHolderComponent_SetValue PocoInterface;

		// Token: 0x040004B8 RID: 1208
		private IElementalAbilityConfig _AbilityConfigCache;

		// Token: 0x040004B9 RID: 1209
		private bool _AbilityConfigInited;
	}
}
