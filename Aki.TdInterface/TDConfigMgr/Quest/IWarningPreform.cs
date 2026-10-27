using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001208 RID: 4616
	[NullableContext(1)]
	[Nullable(0)]
	public class IWarningPreform
	{
		// Token: 0x060068C8 RID: 26824 RVA: 0x000FA064 File Offset: 0x000F8264
		private IWarningPreform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWarningPreform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWarningPreform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWarningPreform_SetValue());
			}
			return result;
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x000FA09C File Offset: 0x000F829C
		public static IWarningPreform Create([Nullable(2)] IWarningPreform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreform
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x000FA0AF File Offset: 0x000F82AF
		public static IWarningPreform CreateFromSetValue([Nullable(2)] IWarningPreform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWarningPreform
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x000FA0C2 File Offset: 0x000F82C2
		public IWarningPreform_SetValue ToSetValue()
		{
			return new IWarningPreform_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x060068CC RID: 26828 RVA: 0x000FA0D5 File Offset: 0x000F82D5
		// (set) Token: 0x060068CD RID: 26829 RVA: 0x000FA0FC File Offset: 0x000F82FC
		public virtual IWarningPreformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				IWarningPreform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003EB4 RID: 16052
		[Nullable(2)]
		protected IWarningPreform FbInstance;

		// Token: 0x04003EB5 RID: 16053
		[Nullable(2)]
		protected IWarningPreform_SetValue PocoInterface;
	}
}
