using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008A6 RID: 2214
	public class IWuWaGoHintStepInteract : IWuWaGoHintStepBase
	{
		// Token: 0x06002FB7 RID: 12215 RVA: 0x0007AC80 File Offset: 0x00078E80
		private IWuWaGoHintStepInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoHintStepInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoHintStepInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoHintStepInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x0007ACB8 File Offset: 0x00078EB8
		public static IWuWaGoHintStepInteract Create([Nullable(2)] IWuWaGoHintStepInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoHintStepInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x0007ACCB File Offset: 0x00078ECB
		public static IWuWaGoHintStepInteract CreateFromSetValue([Nullable(2)] IWuWaGoHintStepInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoHintStepInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x0007ACDE File Offset: 0x00078EDE
		public new IWuWaGoHintStepInteract_SetValue ToSetValue()
		{
			return new IWuWaGoHintStepInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x0007ACF1 File Offset: 0x00078EF1
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x0007AD1C File Offset: 0x00078F1C
		public override EWuWaGoHintStepType Type
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

		// Token: 0x04001F86 RID: 8070
		[Nullable(2)]
		protected new IWuWaGoHintStepInteract FbInstance;

		// Token: 0x04001F87 RID: 8071
		[Nullable(2)]
		protected new IWuWaGoHintStepInteract_SetValue PocoInterface;
	}
}
