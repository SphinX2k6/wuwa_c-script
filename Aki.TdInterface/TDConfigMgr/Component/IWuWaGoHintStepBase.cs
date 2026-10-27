using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000801 RID: 2049
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoHintStepBase
	{
		// Token: 0x06002C7F RID: 11391 RVA: 0x00073860 File Offset: 0x00071A60
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

		// Token: 0x06002C80 RID: 11392 RVA: 0x00073898 File Offset: 0x00071A98
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

		// Token: 0x06002C81 RID: 11393 RVA: 0x000738AB File Offset: 0x00071AAB
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

		// Token: 0x06002C82 RID: 11394 RVA: 0x000738BE File Offset: 0x00071ABE
		public IWuWaGoHintStepBase_SetValue ToSetValue()
		{
			return new IWuWaGoHintStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x000738D1 File Offset: 0x00071AD1
		// (set) Token: 0x06002C84 RID: 11396 RVA: 0x000738FC File Offset: 0x00071AFC
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

		// Token: 0x04001D77 RID: 7543
		[Nullable(2)]
		protected IWuWaGoHintStepBase FbInstance;

		// Token: 0x04001D78 RID: 7544
		[Nullable(2)]
		protected IWuWaGoHintStepBase_SetValue PocoInterface;
	}
}
