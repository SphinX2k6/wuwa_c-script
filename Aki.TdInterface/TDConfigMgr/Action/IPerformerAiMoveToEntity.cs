using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD0 RID: 7376
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerformerAiMoveToEntity : IPerformerAiMoveConfig
	{
		// Token: 0x06009E5F RID: 40543 RVA: 0x0016A3C8 File Offset: 0x001685C8
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

		// Token: 0x06009E60 RID: 40544 RVA: 0x0016A400 File Offset: 0x00168600
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

		// Token: 0x06009E61 RID: 40545 RVA: 0x0016A413 File Offset: 0x00168613
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

		// Token: 0x06009E62 RID: 40546 RVA: 0x0016A426 File Offset: 0x00168626
		public new IPerformerAiMoveToEntity_SetValue ToSetValue()
		{
			return new IPerformerAiMoveToEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x06009E63 RID: 40547 RVA: 0x0016A445 File Offset: 0x00168645
		// (set) Token: 0x06009E64 RID: 40548 RVA: 0x0016A470 File Offset: 0x00168670
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

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x06009E65 RID: 40549 RVA: 0x0016A47E File Offset: 0x0016867E
		// (set) Token: 0x06009E66 RID: 40550 RVA: 0x0016A4A9 File Offset: 0x001686A9
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

		// Token: 0x04005FB7 RID: 24503
		[Nullable(2)]
		protected new IPerformerAiMoveToEntity FbInstance;

		// Token: 0x04005FB8 RID: 24504
		[Nullable(2)]
		protected new IPerformerAiMoveToEntity_SetValue PocoInterface;
	}
}
