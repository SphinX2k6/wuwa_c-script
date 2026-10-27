using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021BB RID: 8635
	[NullableContext(1)]
	[Nullable(0)]
	public class SetHeadIconVisible : ActionParams
	{
		// Token: 0x0600BDAE RID: 48558 RVA: 0x001B4E10 File Offset: 0x001B3010
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

		// Token: 0x0600BDAF RID: 48559 RVA: 0x001B4E48 File Offset: 0x001B3048
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

		// Token: 0x0600BDB0 RID: 48560 RVA: 0x001B4E5B File Offset: 0x001B305B
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

		// Token: 0x0600BDB1 RID: 48561 RVA: 0x001B4E6E File Offset: 0x001B306E
		public SetHeadIconVisible_SetValue ToSetValue()
		{
			return new SetHeadIconVisible_SetValue
			{
				HeadStyleConfig = this.HeadStyleConfig,
				Visible = this.Visible
			};
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0600BDB2 RID: 48562 RVA: 0x001B4E8D File Offset: 0x001B308D
		// (set) Token: 0x0600BDB3 RID: 48563 RVA: 0x001B4EB4 File Offset: 0x001B30B4
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

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0600BDB4 RID: 48564 RVA: 0x001B4EC2 File Offset: 0x001B30C2
		// (set) Token: 0x0600BDB5 RID: 48565 RVA: 0x001B4EED File Offset: 0x001B30ED
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

		// Token: 0x04007138 RID: 28984
		[Nullable(2)]
		protected new SetHeadIconVisible FbInstance;

		// Token: 0x04007139 RID: 28985
		[Nullable(2)]
		protected SetHeadIconVisible_SetValue PocoInterface;
	}
}
