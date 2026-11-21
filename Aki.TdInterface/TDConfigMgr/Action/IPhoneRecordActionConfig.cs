using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EF1 RID: 7921
	public class IPhoneRecordActionConfig
	{
		// Token: 0x0600A895 RID: 43157 RVA: 0x0017EFF4 File Offset: 0x0017D1F4
		private IPhoneRecordActionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhoneRecordActionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhoneRecordActionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhoneRecordActionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x0017F02C File Offset: 0x0017D22C
		public static IPhoneRecordActionConfig Create([Nullable(2)] IPhoneRecordActionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneRecordActionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x0017F03F File Offset: 0x0017D23F
		public static IPhoneRecordActionConfig CreateFromSetValue([Nullable(2)] IPhoneRecordActionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhoneRecordActionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A898 RID: 43160 RVA: 0x0017F052 File Offset: 0x0017D252
		public IPhoneRecordActionConfig_SetValue ToSetValue()
		{
			return new IPhoneRecordActionConfig_SetValue
			{
				PhoneMessageId = this.PhoneMessageId,
				DialogProgress = this.DialogProgress
			};
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600A899 RID: 43161 RVA: 0x0017F074 File Offset: 0x0017D274
		// (set) Token: 0x0600A89A RID: 43162 RVA: 0x0017F0AE File Offset: 0x0017D2AE
		public virtual int? PhoneMessageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhoneMessageId;
				}
				IPhoneRecordActionConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PhoneMessageId;
			}
			set
			{
				this.GetOrCreatePoco().PhoneMessageId = value;
			}
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600A89B RID: 43163 RVA: 0x0017F0BC File Offset: 0x0017D2BC
		// (set) Token: 0x0600A89C RID: 43164 RVA: 0x0017F0F6 File Offset: 0x0017D2F6
		public virtual int? DialogProgress
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DialogProgress;
				}
				IPhoneRecordActionConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DialogProgress;
			}
			set
			{
				this.GetOrCreatePoco().DialogProgress = value;
			}
		}

		// Token: 0x04006552 RID: 25938
		[Nullable(2)]
		protected IPhoneRecordActionConfig FbInstance;

		// Token: 0x04006553 RID: 25939
		[Nullable(2)]
		protected IPhoneRecordActionConfig_SetValue PocoInterface;
	}
}
