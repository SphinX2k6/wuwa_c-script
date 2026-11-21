using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E6 RID: 8422
	public class ISpringArmFixConfig
	{
		// Token: 0x0600B2CA RID: 45770 RVA: 0x001915D4 File Offset: 0x0018F7D4
		private ISpringArmFixConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpringArmFixConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpringArmFixConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpringArmFixConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x0019160C File Offset: 0x0018F80C
		public static ISpringArmFixConfig Create([Nullable(2)] ISpringArmFixConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpringArmFixConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x0019161F File Offset: 0x0018F81F
		public static ISpringArmFixConfig CreateFromSetValue([Nullable(2)] ISpringArmFixConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpringArmFixConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2CD RID: 45773 RVA: 0x00191632 File Offset: 0x0018F832
		public ISpringArmFixConfig_SetValue ToSetValue()
		{
			return new ISpringArmFixConfig_SetValue
			{
				LeftRightFix = this.LeftRightFix,
				ForwardBackFix = this.ForwardBackFix,
				UpDownFix = this.UpDownFix
			};
		}

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0600B2CE RID: 45774 RVA: 0x00191660 File Offset: 0x0018F860
		// (set) Token: 0x0600B2CF RID: 45775 RVA: 0x0019169A File Offset: 0x0018F89A
		public virtual bool? LeftRightFix
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeftRightFix;
				}
				ISpringArmFixConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LeftRightFix;
			}
			set
			{
				this.GetOrCreatePoco().LeftRightFix = value;
			}
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600B2D0 RID: 45776 RVA: 0x001916A8 File Offset: 0x0018F8A8
		// (set) Token: 0x0600B2D1 RID: 45777 RVA: 0x001916E2 File Offset: 0x0018F8E2
		public virtual bool? ForwardBackFix
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardBackFix;
				}
				ISpringArmFixConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForwardBackFix;
			}
			set
			{
				this.GetOrCreatePoco().ForwardBackFix = value;
			}
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600B2D2 RID: 45778 RVA: 0x001916F0 File Offset: 0x0018F8F0
		// (set) Token: 0x0600B2D3 RID: 45779 RVA: 0x0019172A File Offset: 0x0018F92A
		public virtual bool? UpDownFix
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpDownFix;
				}
				ISpringArmFixConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UpDownFix;
			}
			set
			{
				this.GetOrCreatePoco().UpDownFix = value;
			}
		}

		// Token: 0x04006A0A RID: 27146
		[Nullable(2)]
		protected ISpringArmFixConfig FbInstance;

		// Token: 0x04006A0B RID: 27147
		[Nullable(2)]
		protected ISpringArmFixConfig_SetValue PocoInterface;
	}
}
