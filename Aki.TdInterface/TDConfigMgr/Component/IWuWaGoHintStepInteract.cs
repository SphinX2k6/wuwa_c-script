using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000803 RID: 2051
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoHintStepInteract : IWuWaGoHintStepBase
	{
		// Token: 0x06002C87 RID: 11399 RVA: 0x0007391C File Offset: 0x00071B1C
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

		// Token: 0x06002C88 RID: 11400 RVA: 0x00073954 File Offset: 0x00071B54
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

		// Token: 0x06002C89 RID: 11401 RVA: 0x00073967 File Offset: 0x00071B67
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

		// Token: 0x06002C8A RID: 11402 RVA: 0x0007397A File Offset: 0x00071B7A
		public new IWuWaGoHintStepInteract_SetValue ToSetValue()
		{
			return new IWuWaGoHintStepInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x0007398D File Offset: 0x00071B8D
		// (set) Token: 0x06002C8C RID: 11404 RVA: 0x000739B8 File Offset: 0x00071BB8
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

		// Token: 0x04001D7A RID: 7546
		[Nullable(2)]
		protected new IWuWaGoHintStepInteract FbInstance;

		// Token: 0x04001D7B RID: 7547
		[Nullable(2)]
		protected new IWuWaGoHintStepInteract_SetValue PocoInterface;
	}
}
