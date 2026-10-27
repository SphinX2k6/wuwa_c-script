using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D64 RID: 7524
	[NullableContext(1)]
	[Nullable(0)]
	public class IPromptStyleDefault : IPromptStyleBase
	{
		// Token: 0x0600A15B RID: 41307 RVA: 0x0016F9C4 File Offset: 0x0016DBC4
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

		// Token: 0x0600A15C RID: 41308 RVA: 0x0016F9FC File Offset: 0x0016DBFC
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

		// Token: 0x0600A15D RID: 41309 RVA: 0x0016FA0F File Offset: 0x0016DC0F
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

		// Token: 0x0600A15E RID: 41310 RVA: 0x0016FA22 File Offset: 0x0016DC22
		public new IPromptStyleDefault_SetValue ToSetValue()
		{
			return new IPromptStyleDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600A15F RID: 41311 RVA: 0x0016FA35 File Offset: 0x0016DC35
		// (set) Token: 0x0600A160 RID: 41312 RVA: 0x0016FA60 File Offset: 0x0016DC60
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

		// Token: 0x0400611B RID: 24859
		[Nullable(2)]
		protected new IPromptStyleDefault FbInstance;

		// Token: 0x0400611C RID: 24860
		[Nullable(2)]
		protected new IPromptStyleDefault_SetValue PocoInterface;
	}
}
