using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001344 RID: 4932
	public class IWarningPreform
	{
		// Token: 0x06006F09 RID: 28425 RVA: 0x00107970 File Offset: 0x00105B70
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

		// Token: 0x06006F0A RID: 28426 RVA: 0x001079A8 File Offset: 0x00105BA8
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

		// Token: 0x06006F0B RID: 28427 RVA: 0x001079BB File Offset: 0x00105BBB
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

		// Token: 0x06006F0C RID: 28428 RVA: 0x001079CE File Offset: 0x00105BCE
		public IWarningPreform_SetValue ToSetValue()
		{
			return new IWarningPreform_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x06006F0D RID: 28429 RVA: 0x001079E1 File Offset: 0x00105BE1
		// (set) Token: 0x06006F0E RID: 28430 RVA: 0x00107A08 File Offset: 0x00105C08
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

		// Token: 0x04004222 RID: 16930
		[Nullable(2)]
		protected IWarningPreform FbInstance;

		// Token: 0x04004223 RID: 16931
		[Nullable(2)]
		protected IWarningPreform_SetValue PocoInterface;
	}
}
