using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200086B RID: 2155
	[NullableContext(1)]
	[Nullable(0)]
	public class RefreshGroupComponent : IComponentBase
	{
		// Token: 0x06002FBB RID: 12219 RVA: 0x0007B190 File Offset: 0x00079390
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

		// Token: 0x06002FBC RID: 12220 RVA: 0x0007B1C8 File Offset: 0x000793C8
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

		// Token: 0x06002FBD RID: 12221 RVA: 0x0007B1DB File Offset: 0x000793DB
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

		// Token: 0x06002FBE RID: 12222 RVA: 0x0007B1F0 File Offset: 0x000793F0
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

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x0007B24C File Offset: 0x0007944C
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x0007B286 File Offset: 0x00079486
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

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x0007B294 File Offset: 0x00079494
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x0007B2BE File Offset: 0x000794BE
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

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x0007B2CC File Offset: 0x000794CC
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x0007B2F3 File Offset: 0x000794F3
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

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x0007B301 File Offset: 0x00079501
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x0007B328 File Offset: 0x00079528
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

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x0007B336 File Offset: 0x00079536
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x0007B35D File Offset: 0x0007955D
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

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x0007B36C File Offset: 0x0007956C
		// (set) Token: 0x06002FCA RID: 12234 RVA: 0x0007B3CD File Offset: 0x000795CD
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

		// Token: 0x04001F78 RID: 8056
		[Nullable(2)]
		protected new RefreshGroupComponent FbInstance;

		// Token: 0x04001F79 RID: 8057
		[Nullable(2)]
		protected new RefreshGroupComponent_SetValue PocoInterface;

		// Token: 0x04001F7A RID: 8058
		private IStateChangeConfig _StateChangeConfigCache;

		// Token: 0x04001F7B RID: 8059
		private bool _StateChangeConfigInited;
	}
}
