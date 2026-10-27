using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CCE RID: 7374
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerformerAiMoveConfig
	{
		// Token: 0x06009E57 RID: 40535 RVA: 0x0016A30C File Offset: 0x0016850C
		private IPerformerAiMoveConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerformerAiMoveConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerformerAiMoveConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerformerAiMoveConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x0016A344 File Offset: 0x00168544
		public static IPerformerAiMoveConfig Create([Nullable(2)] IPerformerAiMoveConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerAiMoveConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E59 RID: 40537 RVA: 0x0016A357 File Offset: 0x00168557
		public static IPerformerAiMoveConfig CreateFromSetValue([Nullable(2)] IPerformerAiMoveConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerformerAiMoveConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x0016A36A File Offset: 0x0016856A
		public IPerformerAiMoveConfig_SetValue ToSetValue()
		{
			return new IPerformerAiMoveConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x06009E5B RID: 40539 RVA: 0x0016A37D File Offset: 0x0016857D
		// (set) Token: 0x06009E5C RID: 40540 RVA: 0x0016A3A8 File Offset: 0x001685A8
		public virtual EPerformerAiMoveToType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPerformerAiMoveToType.Position;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005FB4 RID: 24500
		[Nullable(2)]
		protected IPerformerAiMoveConfig FbInstance;

		// Token: 0x04005FB5 RID: 24501
		[Nullable(2)]
		protected IPerformerAiMoveConfig_SetValue PocoInterface;
	}
}
