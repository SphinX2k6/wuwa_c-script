using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED9 RID: 7897
	public class IPerformerAiMoveToPlayer : IPerformerAiMoveConfig
	{
		// Token: 0x0600A817 RID: 43031 RVA: 0x0017E128 File Offset: 0x0017C328
		private IPerformerAiMoveToPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerformerAiMoveToPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerformerAiMoveToPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerformerAiMoveToPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x0600A818 RID: 43032 RVA: 0x0017E160 File Offset: 0x0017C360
		public static IPerformerAiMoveToPlayer Create([Nullable(2)] IPerformerAiMoveToPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerAiMoveToPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A819 RID: 43033 RVA: 0x0017E173 File Offset: 0x0017C373
		public static IPerformerAiMoveToPlayer CreateFromSetValue([Nullable(2)] IPerformerAiMoveToPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerformerAiMoveToPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x0017E186 File Offset: 0x0017C386
		public new IPerformerAiMoveToPlayer_SetValue ToSetValue()
		{
			return new IPerformerAiMoveToPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600A81B RID: 43035 RVA: 0x0017E199 File Offset: 0x0017C399
		// (set) Token: 0x0600A81C RID: 43036 RVA: 0x0017E1C4 File Offset: 0x0017C3C4
		public override EPerformerAiMoveToType Type
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

		// Token: 0x04006517 RID: 25879
		[Nullable(2)]
		protected new IPerformerAiMoveToPlayer FbInstance;

		// Token: 0x04006518 RID: 25880
		[Nullable(2)]
		protected new IPerformerAiMoveToPlayer_SetValue PocoInterface;
	}
}
