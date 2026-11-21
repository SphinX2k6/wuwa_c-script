using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200166F RID: 5743
	public class CommonTip : ActionParams
	{
		// Token: 0x06008169 RID: 33129 RVA: 0x0013367C File Offset: 0x0013187C
		private CommonTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CommonTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CommonTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CommonTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x001336B4 File Offset: 0x001318B4
		public static CommonTip Create([Nullable(2)] CommonTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CommonTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x001336C7 File Offset: 0x001318C7
		public static CommonTip CreateFromSetValue([Nullable(2)] CommonTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CommonTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x001336DA File Offset: 0x001318DA
		public CommonTip_SetValue ToSetValue()
		{
			return new CommonTip_SetValue
			{
				TipOption = this.TipOption,
				Duration = this.Duration,
				Token = this.Token
			};
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x0600816D RID: 33133 RVA: 0x00133705 File Offset: 0x00131905
		// (set) Token: 0x0600816E RID: 33134 RVA: 0x0013372C File Offset: 0x0013192C
		public virtual ICommonTipType TipOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TipOption;
				}
				CommonTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TipOption;
			}
			set
			{
				this.GetOrCreatePoco().TipOption = value;
			}
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x0600816F RID: 33135 RVA: 0x0013373C File Offset: 0x0013193C
		// (set) Token: 0x06008170 RID: 33136 RVA: 0x00133776 File Offset: 0x00131976
		public virtual int? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				CommonTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x06008171 RID: 33137 RVA: 0x00133784 File Offset: 0x00131984
		// (set) Token: 0x06008172 RID: 33138 RVA: 0x001337AB File Offset: 0x001319AB
		[Nullable(2)]
		public virtual string Token
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Token;
				}
				CommonTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Token;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Token = value;
			}
		}

		// Token: 0x04004A9D RID: 19101
		[Nullable(2)]
		protected new CommonTip FbInstance;

		// Token: 0x04004A9E RID: 19102
		[Nullable(2)]
		protected CommonTip_SetValue PocoInterface;
	}
}
