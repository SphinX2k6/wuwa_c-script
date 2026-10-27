using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001782 RID: 6018
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAtEntityData : IActorLookAtLockable
	{
		// Token: 0x06007F67 RID: 32615 RVA: 0x0013093C File Offset: 0x0012EB3C
		private IActorLookAtEntityData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtEntityData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtEntityData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtEntityData_SetValue());
			}
			return result;
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x00130974 File Offset: 0x0012EB74
		public static IActorLookAtEntityData Create([Nullable(2)] IActorLookAtEntityData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtEntityData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F69 RID: 32617 RVA: 0x00130987 File Offset: 0x0012EB87
		public static IActorLookAtEntityData CreateFromSetValue([Nullable(2)] IActorLookAtEntityData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtEntityData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x0013099A File Offset: 0x0012EB9A
		public new IActorLookAtEntityData_SetValue ToSetValue()
		{
			return new IActorLookAtEntityData_SetValue
			{
				Type = this.Type,
				Lock = this.Lock,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x06007F6B RID: 32619 RVA: 0x001309C5 File Offset: 0x0012EBC5
		// (set) Token: 0x06007F6C RID: 32620 RVA: 0x001309F0 File Offset: 0x0012EBF0
		public override EActorLookAtMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorLookAtMode.Talker;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x06007F6D RID: 32621 RVA: 0x00130A00 File Offset: 0x0012EC00
		// (set) Token: 0x06007F6E RID: 32622 RVA: 0x00130A3A File Offset: 0x0012EC3A
		public override bool? Lock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Lock;
				}
				IActorLookAtEntityData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Lock;
			}
			set
			{
				this.GetOrCreatePoco().Lock = value;
			}
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x06007F6F RID: 32623 RVA: 0x00130A48 File Offset: 0x0012EC48
		// (set) Token: 0x06007F70 RID: 32624 RVA: 0x00130A73 File Offset: 0x0012EC73
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

		// Token: 0x040050FE RID: 20734
		[Nullable(2)]
		protected new IActorLookAtEntityData FbInstance;

		// Token: 0x040050FF RID: 20735
		[Nullable(2)]
		protected new IActorLookAtEntityData_SetValue PocoInterface;
	}
}
