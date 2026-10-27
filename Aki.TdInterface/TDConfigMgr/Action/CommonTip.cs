using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001516 RID: 5398
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonTip : ActionParams
	{
		// Token: 0x06007A9E RID: 31390 RVA: 0x00124A54 File Offset: 0x00122C54
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

		// Token: 0x06007A9F RID: 31391 RVA: 0x00124A8C File Offset: 0x00122C8C
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

		// Token: 0x06007AA0 RID: 31392 RVA: 0x00124A9F File Offset: 0x00122C9F
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

		// Token: 0x06007AA1 RID: 31393 RVA: 0x00124AB2 File Offset: 0x00122CB2
		public CommonTip_SetValue ToSetValue()
		{
			return new CommonTip_SetValue
			{
				TipOption = this.TipOption,
				Duration = this.Duration,
				Token = this.Token
			};
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x06007AA2 RID: 31394 RVA: 0x00124ADD File Offset: 0x00122CDD
		// (set) Token: 0x06007AA3 RID: 31395 RVA: 0x00124B04 File Offset: 0x00122D04
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

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x06007AA4 RID: 31396 RVA: 0x00124B14 File Offset: 0x00122D14
		// (set) Token: 0x06007AA5 RID: 31397 RVA: 0x00124B4E File Offset: 0x00122D4E
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

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x06007AA6 RID: 31398 RVA: 0x00124B5C File Offset: 0x00122D5C
		// (set) Token: 0x06007AA7 RID: 31399 RVA: 0x00124B83 File Offset: 0x00122D83
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

		// Token: 0x04004701 RID: 18177
		[Nullable(2)]
		protected new CommonTip FbInstance;

		// Token: 0x04004702 RID: 18178
		[Nullable(2)]
		protected CommonTip_SetValue PocoInterface;
	}
}
