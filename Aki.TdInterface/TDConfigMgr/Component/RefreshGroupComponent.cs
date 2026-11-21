using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090E RID: 2318
	public class RefreshGroupComponent : IComponentBase
	{
		// Token: 0x060032F7 RID: 13047 RVA: 0x00082678 File Offset: 0x00080878
		private RefreshGroupComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RefreshGroupComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RefreshGroupComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RefreshGroupComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x000826B0 File Offset: 0x000808B0
		public static RefreshGroupComponent Create([Nullable(2)] RefreshGroupComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RefreshGroupComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000826C3 File Offset: 0x000808C3
		public static RefreshGroupComponent CreateFromSetValue([Nullable(2)] RefreshGroupComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RefreshGroupComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x000826D8 File Offset: 0x000808D8
		public new RefreshGroupComponent_SetValue ToSetValue()
		{
			return new RefreshGroupComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				EntityIds = this.EntityIds,
				RefreshContent = this.RefreshContent,
				RefreshRule = this.RefreshRule,
				StateChangeConfig = this.StateChangeConfig
			};
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x060032FB RID: 13051 RVA: 0x00082734 File Offset: 0x00080934
		// (set) Token: 0x060032FC RID: 13052 RVA: 0x0008276E File Offset: 0x0008096E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RefreshGroupComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x060032FD RID: 13053 RVA: 0x0008277C File Offset: 0x0008097C
		// (set) Token: 0x060032FE RID: 13054 RVA: 0x000827A6 File Offset: 0x000809A6
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

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x060032FF RID: 13055 RVA: 0x000827B4 File Offset: 0x000809B4
		// (set) Token: 0x06003300 RID: 13056 RVA: 0x000827DB File Offset: 0x000809DB
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				RefreshGroupComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06003301 RID: 13057 RVA: 0x000827E9 File Offset: 0x000809E9
		// (set) Token: 0x06003302 RID: 13058 RVA: 0x00082810 File Offset: 0x00080A10
		public virtual IRefreshContent RefreshContent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshContent;
				}
				RefreshGroupComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RefreshContent;
			}
			set
			{
				this.GetOrCreatePoco().RefreshContent = value;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06003303 RID: 13059 RVA: 0x0008281E File Offset: 0x00080A1E
		// (set) Token: 0x06003304 RID: 13060 RVA: 0x00082845 File Offset: 0x00080A45
		public virtual IRefreshRule RefreshRule
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshRule;
				}
				RefreshGroupComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RefreshRule;
			}
			set
			{
				this.GetOrCreatePoco().RefreshRule = value;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x00082854 File Offset: 0x00080A54
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x000828B5 File Offset: 0x00080AB5
		[Nullable(2)]
		public virtual IStateChangeConfig StateChangeConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._StateChangeConfigInited)
				{
					return this._StateChangeConfigCache;
				}
				this._StateChangeConfigInited = true;
				if (this.FbInstance != null)
				{
					this._StateChangeConfigCache = IStateChangeConfig.Create(this.FbInstance.StateChangeConfig);
				}
				else
				{
					RefreshGroupComponent_SetValue pocoInterface = this.PocoInterface;
					this._StateChangeConfigCache = ((pocoInterface != null) ? pocoInterface.StateChangeConfig : null);
				}
				return this._StateChangeConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().StateChangeConfig = value;
				this._StateChangeConfigInited = false;
			}
		}

		// Token: 0x0400218A RID: 8586
		[Nullable(2)]
		protected new RefreshGroupComponent FbInstance;

		// Token: 0x0400218B RID: 8587
		[Nullable(2)]
		protected new RefreshGroupComponent_SetValue PocoInterface;

		// Token: 0x0400218C RID: 8588
		private IStateChangeConfig _StateChangeConfigCache;

		// Token: 0x0400218D RID: 8589
		private bool _StateChangeConfigInited;
	}
}
