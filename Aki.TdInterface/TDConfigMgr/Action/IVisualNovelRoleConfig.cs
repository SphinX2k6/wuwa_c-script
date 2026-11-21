using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F2 RID: 8946
	public class IVisualNovelRoleConfig
	{
		// Token: 0x0600C2FE RID: 49918 RVA: 0x001C0408 File Offset: 0x001BE608
		private IVisualNovelRoleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelRoleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelRoleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelRoleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600C2FF RID: 49919 RVA: 0x001C0440 File Offset: 0x001BE640
		public static IVisualNovelRoleConfig Create([Nullable(2)] IVisualNovelRoleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelRoleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C300 RID: 49920 RVA: 0x001C0453 File Offset: 0x001BE653
		public static IVisualNovelRoleConfig CreateFromSetValue([Nullable(2)] IVisualNovelRoleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelRoleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C301 RID: 49921 RVA: 0x001C0468 File Offset: 0x001BE668
		public IVisualNovelRoleConfig_SetValue ToSetValue()
		{
			return new IVisualNovelRoleConfig_SetValue
			{
				Expression = this.Expression,
				VisualEffect = this.VisualEffect,
				HideAvatar = this.HideAvatar,
				HidePortrait = this.HidePortrait,
				CustomLayer = this.CustomLayer
			};
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x0600C302 RID: 49922 RVA: 0x001C04B8 File Offset: 0x001BE6B8
		// (set) Token: 0x0600C303 RID: 49923 RVA: 0x001C04F2 File Offset: 0x001BE6F2
		public virtual int? Expression
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Expression;
				}
				IVisualNovelRoleConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Expression;
			}
			set
			{
				this.GetOrCreatePoco().Expression = value;
			}
		}

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x0600C304 RID: 49924 RVA: 0x001C0500 File Offset: 0x001BE700
		// (set) Token: 0x0600C305 RID: 49925 RVA: 0x001C053A File Offset: 0x001BE73A
		public virtual EAvgVisualEffect? VisualEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualEffect;
				}
				IVisualNovelRoleConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VisualEffect;
			}
			set
			{
				this.GetOrCreatePoco().VisualEffect = value;
			}
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x0600C306 RID: 49926 RVA: 0x001C0548 File Offset: 0x001BE748
		// (set) Token: 0x0600C307 RID: 49927 RVA: 0x001C0582 File Offset: 0x001BE782
		public virtual bool? HideAvatar
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideAvatar;
				}
				IVisualNovelRoleConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideAvatar;
			}
			set
			{
				this.GetOrCreatePoco().HideAvatar = value;
			}
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x0600C308 RID: 49928 RVA: 0x001C0590 File Offset: 0x001BE790
		// (set) Token: 0x0600C309 RID: 49929 RVA: 0x001C05CA File Offset: 0x001BE7CA
		public virtual bool? HidePortrait
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HidePortrait;
				}
				IVisualNovelRoleConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HidePortrait;
			}
			set
			{
				this.GetOrCreatePoco().HidePortrait = value;
			}
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x0600C30A RID: 49930 RVA: 0x001C05D8 File Offset: 0x001BE7D8
		// (set) Token: 0x0600C30B RID: 49931 RVA: 0x001C0612 File Offset: 0x001BE812
		public virtual int? CustomLayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomLayer;
				}
				IVisualNovelRoleConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CustomLayer;
			}
			set
			{
				this.GetOrCreatePoco().CustomLayer = value;
			}
		}

		// Token: 0x04007457 RID: 29783
		[Nullable(2)]
		protected IVisualNovelRoleConfig FbInstance;

		// Token: 0x04007458 RID: 29784
		[Nullable(2)]
		protected IVisualNovelRoleConfig_SetValue PocoInterface;
	}
}
