using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED7 RID: 7895
	public class IPerformerAiMoveToEntity : IPerformerAiMoveConfig
	{
		// Token: 0x0600A80D RID: 43021 RVA: 0x0017E028 File Offset: 0x0017C228
		private IPerformerAiMoveToEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerformerAiMoveToEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerformerAiMoveToEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerformerAiMoveToEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600A80E RID: 43022 RVA: 0x0017E060 File Offset: 0x0017C260
		public static IPerformerAiMoveToEntity Create([Nullable(2)] IPerformerAiMoveToEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerAiMoveToEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x0017E073 File Offset: 0x0017C273
		public static IPerformerAiMoveToEntity CreateFromSetValue([Nullable(2)] IPerformerAiMoveToEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerformerAiMoveToEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x0017E086 File Offset: 0x0017C286
		public new IPerformerAiMoveToEntity_SetValue ToSetValue()
		{
			return new IPerformerAiMoveToEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600A811 RID: 43025 RVA: 0x0017E0A5 File Offset: 0x0017C2A5
		// (set) Token: 0x0600A812 RID: 43026 RVA: 0x0017E0D0 File Offset: 0x0017C2D0
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

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600A813 RID: 43027 RVA: 0x0017E0DE File Offset: 0x0017C2DE
		// (set) Token: 0x0600A814 RID: 43028 RVA: 0x0017E109 File Offset: 0x0017C309
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04006513 RID: 25875
		[Nullable(2)]
		protected new IPerformerAiMoveToEntity FbInstance;

		// Token: 0x04006514 RID: 25876
		[Nullable(2)]
		protected new IPerformerAiMoveToEntity_SetValue PocoInterface;
	}
}
