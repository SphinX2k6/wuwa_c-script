using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002426 RID: 9254
	public class SetHeadIconVisible : ActionParams
	{
		// Token: 0x0600C968 RID: 51560 RVA: 0x001CC448 File Offset: 0x001CA648
		private SetHeadIconVisible_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetHeadIconVisible 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetHeadIconVisible_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetHeadIconVisible_SetValue());
			}
			return result;
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x001CC480 File Offset: 0x001CA680
		public static SetHeadIconVisible Create([Nullable(2)] SetHeadIconVisible instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetHeadIconVisible
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C96A RID: 51562 RVA: 0x001CC493 File Offset: 0x001CA693
		public static SetHeadIconVisible CreateFromSetValue([Nullable(2)] SetHeadIconVisible_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetHeadIconVisible
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x001CC4A6 File Offset: 0x001CA6A6
		public SetHeadIconVisible_SetValue ToSetValue()
		{
			return new SetHeadIconVisible_SetValue
			{
				HeadStyleConfig = this.HeadStyleConfig,
				Visible = this.Visible
			};
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0600C96C RID: 51564 RVA: 0x001CC4C5 File Offset: 0x001CA6C5
		// (set) Token: 0x0600C96D RID: 51565 RVA: 0x001CC4EC File Offset: 0x001CA6EC
		public virtual IHeadStyle HeadStyleConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HeadStyleConfig;
				}
				SetHeadIconVisible_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HeadStyleConfig;
			}
			set
			{
				this.GetOrCreatePoco().HeadStyleConfig = value;
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x0600C96E RID: 51566 RVA: 0x001CC4FA File Offset: 0x001CA6FA
		// (set) Token: 0x0600C96F RID: 51567 RVA: 0x001CC525 File Offset: 0x001CA725
		public virtual bool Visible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Visible;
				}
				return this.PocoInterface != null && this.PocoInterface.Visible;
			}
			set
			{
				this.GetOrCreatePoco().Visible = value;
			}
		}

		// Token: 0x04007780 RID: 30592
		[Nullable(2)]
		protected new SetHeadIconVisible FbInstance;

		// Token: 0x04007781 RID: 30593
		[Nullable(2)]
		protected SetHeadIconVisible_SetValue PocoInterface;
	}
}
