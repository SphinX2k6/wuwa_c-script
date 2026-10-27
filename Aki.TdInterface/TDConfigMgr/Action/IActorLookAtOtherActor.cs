using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001786 RID: 6022
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAtOtherActor : IActorLookAtLockable
	{
		// Token: 0x06007F7D RID: 32637 RVA: 0x00130BA4 File Offset: 0x0012EDA4
		private IActorLookAtOtherActor_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtOtherActor 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtOtherActor_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtOtherActor_SetValue());
			}
			return result;
		}

		// Token: 0x06007F7E RID: 32638 RVA: 0x00130BDC File Offset: 0x0012EDDC
		public static IActorLookAtOtherActor Create([Nullable(2)] IActorLookAtOtherActor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtOtherActor
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F7F RID: 32639 RVA: 0x00130BEF File Offset: 0x0012EDEF
		public static IActorLookAtOtherActor CreateFromSetValue([Nullable(2)] IActorLookAtOtherActor_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtOtherActor
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F80 RID: 32640 RVA: 0x00130C02 File Offset: 0x0012EE02
		public new IActorLookAtOtherActor_SetValue ToSetValue()
		{
			return new IActorLookAtOtherActor_SetValue
			{
				Type = this.Type,
				Lock = this.Lock,
				ActorIndex = this.ActorIndex
			};
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x06007F81 RID: 32641 RVA: 0x00130C2D File Offset: 0x0012EE2D
		// (set) Token: 0x06007F82 RID: 32642 RVA: 0x00130C58 File Offset: 0x0012EE58
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

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x06007F83 RID: 32643 RVA: 0x00130C68 File Offset: 0x0012EE68
		// (set) Token: 0x06007F84 RID: 32644 RVA: 0x00130CA2 File Offset: 0x0012EEA2
		public override bool? Lock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Lock;
				}
				IActorLookAtOtherActor_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x06007F85 RID: 32645 RVA: 0x00130CB0 File Offset: 0x0012EEB0
		// (set) Token: 0x06007F86 RID: 32646 RVA: 0x00130CDB File Offset: 0x0012EEDB
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x04005107 RID: 20743
		[Nullable(2)]
		protected new IActorLookAtOtherActor FbInstance;

		// Token: 0x04005108 RID: 20744
		[Nullable(2)]
		protected new IActorLookAtOtherActor_SetValue PocoInterface;
	}
}
