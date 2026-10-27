using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000D0 RID: 208
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalHolderComponent : IComponentBase
	{
		// Token: 0x06000394 RID: 916 RVA: 0x0001C2D8 File Offset: 0x0001A4D8
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

		// Token: 0x06000395 RID: 917 RVA: 0x0001C310 File Offset: 0x0001A510
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

		// Token: 0x06000396 RID: 918 RVA: 0x0001C323 File Offset: 0x0001A523
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

		// Token: 0x06000397 RID: 919 RVA: 0x0001C336 File Offset: 0x0001A536
		public new ElementalHolderComponent_SetValue ToSetValue()
		{
			return new ElementalHolderComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AbilityConfig = this.AbilityConfig
			};
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0001C364 File Offset: 0x0001A564
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0001C39E File Offset: 0x0001A59E
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0001C3AC File Offset: 0x0001A5AC
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0001C3D6 File Offset: 0x0001A5D6
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0001C3E4 File Offset: 0x0001A5E4
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0001C445 File Offset: 0x0001A645
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

		// Token: 0x04000492 RID: 1170
		[Nullable(2)]
		protected new ElementalHolderComponent FbInstance;

		// Token: 0x04000493 RID: 1171
		[Nullable(2)]
		protected new ElementalHolderComponent_SetValue PocoInterface;

		// Token: 0x04000494 RID: 1172
		private IElementalAbilityConfig _AbilityConfigCache;

		// Token: 0x04000495 RID: 1173
		private bool _AbilityConfigInited;
	}
}
