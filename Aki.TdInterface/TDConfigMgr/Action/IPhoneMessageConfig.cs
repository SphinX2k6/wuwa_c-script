using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EEF RID: 7919
	public class IPhoneMessageConfig
	{
		// Token: 0x0600A88D RID: 43149 RVA: 0x0017EF28 File Offset: 0x0017D128
		private IPhoneMessageConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhoneMessageConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhoneMessageConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhoneMessageConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A88E RID: 43150 RVA: 0x0017EF60 File Offset: 0x0017D160
		public static IPhoneMessageConfig Create([Nullable(2)] IPhoneMessageConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A88F RID: 43151 RVA: 0x0017EF73 File Offset: 0x0017D173
		public static IPhoneMessageConfig CreateFromSetValue([Nullable(2)] IPhoneMessageConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhoneMessageConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A890 RID: 43152 RVA: 0x0017EF86 File Offset: 0x0017D186
		public IPhoneMessageConfig_SetValue ToSetValue()
		{
			return new IPhoneMessageConfig_SetValue
			{
				IsJumpToFirstOption = this.IsJumpToFirstOption
			};
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600A891 RID: 43153 RVA: 0x0017EF9C File Offset: 0x0017D19C
		// (set) Token: 0x0600A892 RID: 43154 RVA: 0x0017EFD6 File Offset: 0x0017D1D6
		public virtual bool? IsJumpToFirstOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsJumpToFirstOption;
				}
				IPhoneMessageConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsJumpToFirstOption;
			}
			set
			{
				this.GetOrCreatePoco().IsJumpToFirstOption = value;
			}
		}

		// Token: 0x0400654F RID: 25935
		[Nullable(2)]
		protected IPhoneMessageConfig FbInstance;

		// Token: 0x04006550 RID: 25936
		[Nullable(2)]
		protected IPhoneMessageConfig_SetValue PocoInterface;
	}
}
