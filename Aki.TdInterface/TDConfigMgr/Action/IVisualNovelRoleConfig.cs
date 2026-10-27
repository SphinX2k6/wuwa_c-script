using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A1 RID: 8353
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelRoleConfig
	{
		// Token: 0x0600B7BA RID: 47034 RVA: 0x001A99DC File Offset: 0x001A7BDC
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

		// Token: 0x0600B7BB RID: 47035 RVA: 0x001A9A14 File Offset: 0x001A7C14
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

		// Token: 0x0600B7BC RID: 47036 RVA: 0x001A9A27 File Offset: 0x001A7C27
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

		// Token: 0x0600B7BD RID: 47037 RVA: 0x001A9A3A File Offset: 0x001A7C3A
		public IVisualNovelRoleConfig_SetValue ToSetValue()
		{
			return new IVisualNovelRoleConfig_SetValue
			{
				Expression = this.Expression,
				VisualEffect = this.VisualEffect,
				HideAvatar = this.HideAvatar,
				HidePortrait = this.HidePortrait
			};
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600B7BE RID: 47038 RVA: 0x001A9A74 File Offset: 0x001A7C74
		// (set) Token: 0x0600B7BF RID: 47039 RVA: 0x001A9AAE File Offset: 0x001A7CAE
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

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600B7C0 RID: 47040 RVA: 0x001A9ABC File Offset: 0x001A7CBC
		// (set) Token: 0x0600B7C1 RID: 47041 RVA: 0x001A9AF6 File Offset: 0x001A7CF6
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

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600B7C2 RID: 47042 RVA: 0x001A9B04 File Offset: 0x001A7D04
		// (set) Token: 0x0600B7C3 RID: 47043 RVA: 0x001A9B3E File Offset: 0x001A7D3E
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

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600B7C4 RID: 47044 RVA: 0x001A9B4C File Offset: 0x001A7D4C
		// (set) Token: 0x0600B7C5 RID: 47045 RVA: 0x001A9B86 File Offset: 0x001A7D86
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

		// Token: 0x04006E41 RID: 28225
		[Nullable(2)]
		protected IVisualNovelRoleConfig FbInstance;

		// Token: 0x04006E42 RID: 28226
		[Nullable(2)]
		protected IVisualNovelRoleConfig_SetValue PocoInterface;
	}
}
