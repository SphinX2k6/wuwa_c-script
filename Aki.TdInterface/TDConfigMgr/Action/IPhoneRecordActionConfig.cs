using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CE2 RID: 7394
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhoneRecordActionConfig
	{
		// Token: 0x06009EB5 RID: 40629 RVA: 0x0016AD94 File Offset: 0x00168F94
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

		// Token: 0x06009EB6 RID: 40630 RVA: 0x0016ADCC File Offset: 0x00168FCC
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

		// Token: 0x06009EB7 RID: 40631 RVA: 0x0016ADDF File Offset: 0x00168FDF
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

		// Token: 0x06009EB8 RID: 40632 RVA: 0x0016ADF2 File Offset: 0x00168FF2
		public IPhoneRecordActionConfig_SetValue ToSetValue()
		{
			return new IPhoneRecordActionConfig_SetValue
			{
				PhoneMessageId = this.PhoneMessageId,
				DialogProgress = this.DialogProgress
			};
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x06009EB9 RID: 40633 RVA: 0x0016AE14 File Offset: 0x00169014
		// (set) Token: 0x06009EBA RID: 40634 RVA: 0x0016AE4E File Offset: 0x0016904E
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

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x06009EBB RID: 40635 RVA: 0x0016AE5C File Offset: 0x0016905C
		// (set) Token: 0x06009EBC RID: 40636 RVA: 0x0016AE96 File Offset: 0x00169096
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

		// Token: 0x04005FDF RID: 24543
		[Nullable(2)]
		protected IPhoneRecordActionConfig FbInstance;

		// Token: 0x04005FE0 RID: 24544
		[Nullable(2)]
		protected IPhoneRecordActionConfig_SetValue PocoInterface;
	}
}
