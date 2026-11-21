using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001907 RID: 6407
	public class IActorLookAtOtherActor : IActorLookAtLockable
	{
		// Token: 0x0600866D RID: 34413 RVA: 0x0013FE04 File Offset: 0x0013E004
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

		// Token: 0x0600866E RID: 34414 RVA: 0x0013FE3C File Offset: 0x0013E03C
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

		// Token: 0x0600866F RID: 34415 RVA: 0x0013FE4F File Offset: 0x0013E04F
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

		// Token: 0x06008670 RID: 34416 RVA: 0x0013FE62 File Offset: 0x0013E062
		public new IActorLookAtOtherActor_SetValue ToSetValue()
		{
			return new IActorLookAtOtherActor_SetValue
			{
				Type = this.Type,
				Lock = this.Lock,
				ActorIndex = this.ActorIndex
			};
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x06008671 RID: 34417 RVA: 0x0013FE8D File Offset: 0x0013E08D
		// (set) Token: 0x06008672 RID: 34418 RVA: 0x0013FEB8 File Offset: 0x0013E0B8
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

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x06008673 RID: 34419 RVA: 0x0013FEC8 File Offset: 0x0013E0C8
		// (set) Token: 0x06008674 RID: 34420 RVA: 0x0013FF02 File Offset: 0x0013E102
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

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x06008675 RID: 34421 RVA: 0x0013FF10 File Offset: 0x0013E110
		// (set) Token: 0x06008676 RID: 34422 RVA: 0x0013FF3B File Offset: 0x0013E13B
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

		// Token: 0x0400553D RID: 21821
		[Nullable(2)]
		protected new IActorLookAtOtherActor FbInstance;

		// Token: 0x0400553E RID: 21822
		[Nullable(2)]
		protected new IActorLookAtOtherActor_SetValue PocoInterface;
	}
}
