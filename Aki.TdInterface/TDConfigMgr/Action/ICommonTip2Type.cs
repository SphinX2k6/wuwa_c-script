using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200190E RID: 6414
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTip2Type
	{
		// Token: 0x06008977 RID: 35191 RVA: 0x00144814 File Offset: 0x00142A14
		private ICommonTip2Type_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTip2Type 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTip2Type_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTip2Type_SetValue());
			}
			return result;
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x0014484C File Offset: 0x00142A4C
		public static ICommonTip2Type Create([Nullable(2)] ICommonTip2Type instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTip2Type
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x0014485F File Offset: 0x00142A5F
		public static ICommonTip2Type CreateFromSetValue([Nullable(2)] ICommonTip2Type_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTip2Type
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x00144872 File Offset: 0x00142A72
		public ICommonTip2Type_SetValue ToSetValue()
		{
			return new ICommonTip2Type_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x0600897B RID: 35195 RVA: 0x00144885 File Offset: 0x00142A85
		// (set) Token: 0x0600897C RID: 35196 RVA: 0x001448B0 File Offset: 0x00142AB0
		public virtual ECommonTip2Type Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTip2Type.PrepareCountdown;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005620 RID: 22048
		[Nullable(2)]
		protected ICommonTip2Type FbInstance;

		// Token: 0x04005621 RID: 22049
		[Nullable(2)]
		protected ICommonTip2Type_SetValue PocoInterface;
	}
}
