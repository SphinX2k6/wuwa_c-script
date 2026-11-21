using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA1 RID: 7073
	public class IEntityHandInHandInitiator : IHandInHandInitiatorType
	{
		// Token: 0x06009641 RID: 38465 RVA: 0x0015DCD0 File Offset: 0x0015BED0
		private IEntityHandInHandInitiator_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityHandInHandInitiator 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityHandInHandInitiator_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityHandInHandInitiator_SetValue());
			}
			return result;
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x0015DD08 File Offset: 0x0015BF08
		public static IEntityHandInHandInitiator Create([Nullable(2)] IEntityHandInHandInitiator instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityHandInHandInitiator
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x0015DD1B File Offset: 0x0015BF1B
		public static IEntityHandInHandInitiator CreateFromSetValue([Nullable(2)] IEntityHandInHandInitiator_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityHandInHandInitiator
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x0015DD2E File Offset: 0x0015BF2E
		public new IEntityHandInHandInitiator_SetValue ToSetValue()
		{
			return new IEntityHandInHandInitiator_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x06009645 RID: 38469 RVA: 0x0015DD4D File Offset: 0x0015BF4D
		// (set) Token: 0x06009646 RID: 38470 RVA: 0x0015DD78 File Offset: 0x0015BF78
		public override EHandInHandInitiatorType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHandInHandInitiatorType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x06009647 RID: 38471 RVA: 0x0015DD86 File Offset: 0x0015BF86
		// (set) Token: 0x06009648 RID: 38472 RVA: 0x0015DDB1 File Offset: 0x0015BFB1
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

		// Token: 0x04005CDA RID: 23770
		[Nullable(2)]
		protected new IEntityHandInHandInitiator FbInstance;

		// Token: 0x04005CDB RID: 23771
		[Nullable(2)]
		protected new IEntityHandInHandInitiator_SetValue PocoInterface;
	}
}
