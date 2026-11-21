using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED5 RID: 7893
	public class IPerformerAiMoveConfig
	{
		// Token: 0x0600A805 RID: 43013 RVA: 0x0017DF6C File Offset: 0x0017C16C
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

		// Token: 0x0600A806 RID: 43014 RVA: 0x0017DFA4 File Offset: 0x0017C1A4
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

		// Token: 0x0600A807 RID: 43015 RVA: 0x0017DFB7 File Offset: 0x0017C1B7
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

		// Token: 0x0600A808 RID: 43016 RVA: 0x0017DFCA File Offset: 0x0017C1CA
		public IPerformerAiMoveConfig_SetValue ToSetValue()
		{
			return new IPerformerAiMoveConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600A809 RID: 43017 RVA: 0x0017DFDD File Offset: 0x0017C1DD
		// (set) Token: 0x0600A80A RID: 43018 RVA: 0x0017E008 File Offset: 0x0017C208
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

		// Token: 0x04006510 RID: 25872
		[Nullable(2)]
		protected IPerformerAiMoveConfig FbInstance;

		// Token: 0x04006511 RID: 25873
		[Nullable(2)]
		protected IPerformerAiMoveConfig_SetValue PocoInterface;
	}
}
