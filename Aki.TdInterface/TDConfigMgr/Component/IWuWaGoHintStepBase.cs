using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008A4 RID: 2212
	public class IWuWaGoHintStepBase
	{
		// Token: 0x06002FAF RID: 12207 RVA: 0x0007ABC4 File Offset: 0x00078DC4
		private IWuWaGoHintStepBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoHintStepBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoHintStepBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoHintStepBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x0007ABFC File Offset: 0x00078DFC
		public static IWuWaGoHintStepBase Create([Nullable(2)] IWuWaGoHintStepBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoHintStepBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x0007AC0F File Offset: 0x00078E0F
		public static IWuWaGoHintStepBase CreateFromSetValue([Nullable(2)] IWuWaGoHintStepBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoHintStepBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x0007AC22 File Offset: 0x00078E22
		public IWuWaGoHintStepBase_SetValue ToSetValue()
		{
			return new IWuWaGoHintStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x0007AC35 File Offset: 0x00078E35
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x0007AC60 File Offset: 0x00078E60
		public virtual EWuWaGoHintStepType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoHintStepType.Move;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001F83 RID: 8067
		[Nullable(2)]
		protected IWuWaGoHintStepBase FbInstance;

		// Token: 0x04001F84 RID: 8068
		[Nullable(2)]
		protected IWuWaGoHintStepBase_SetValue PocoInterface;
	}
}
