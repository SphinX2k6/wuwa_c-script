using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E4 RID: 8420
	public class ISportConfig
	{
		// Token: 0x0600B2C2 RID: 45762 RVA: 0x00191518 File Offset: 0x0018F718
		private ISportConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISportConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISportConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISportConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x00191550 File Offset: 0x0018F750
		public static ISportConfig Create([Nullable(2)] ISportConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISportConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x00191563 File Offset: 0x0018F763
		public static ISportConfig CreateFromSetValue([Nullable(2)] ISportConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISportConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x00191576 File Offset: 0x0018F776
		public ISportConfig_SetValue ToSetValue()
		{
			return new ISportConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600B2C6 RID: 45766 RVA: 0x00191589 File Offset: 0x0018F789
		// (set) Token: 0x0600B2C7 RID: 45767 RVA: 0x001915B4 File Offset: 0x0018F7B4
		public virtual ESportStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESportStateType.Slide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006A07 RID: 27143
		[Nullable(2)]
		protected ISportConfig FbInstance;

		// Token: 0x04006A08 RID: 27144
		[Nullable(2)]
		protected ISportConfig_SetValue PocoInterface;
	}
}
