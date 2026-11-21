using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F75 RID: 8053
	public class IPromptStyleDefault : IPromptStyleBase
	{
		// Token: 0x0600AB47 RID: 43847 RVA: 0x00183DE8 File Offset: 0x00181FE8
		private IPromptStyleDefault_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPromptStyleDefault 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPromptStyleDefault_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPromptStyleDefault_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x00183E20 File Offset: 0x00182020
		public static IPromptStyleDefault Create([Nullable(2)] IPromptStyleDefault instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleDefault
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x00183E33 File Offset: 0x00182033
		public static IPromptStyleDefault CreateFromSetValue([Nullable(2)] IPromptStyleDefault_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPromptStyleDefault
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB4A RID: 43850 RVA: 0x00183E46 File Offset: 0x00182046
		public new IPromptStyleDefault_SetValue ToSetValue()
		{
			return new IPromptStyleDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600AB4B RID: 43851 RVA: 0x00183E59 File Offset: 0x00182059
		// (set) Token: 0x0600AB4C RID: 43852 RVA: 0x00183E84 File Offset: 0x00182084
		public override EPromptStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPromptStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006697 RID: 26263
		[Nullable(2)]
		protected new IPromptStyleDefault FbInstance;

		// Token: 0x04006698 RID: 26264
		[Nullable(2)]
		protected new IPromptStyleDefault_SetValue PocoInterface;
	}
}
