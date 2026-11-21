using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001903 RID: 6403
	public class IActorLookAtEntityData : IActorLookAtLockable
	{
		// Token: 0x06008657 RID: 34391 RVA: 0x0013FB9C File Offset: 0x0013DD9C
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

		// Token: 0x06008658 RID: 34392 RVA: 0x0013FBD4 File Offset: 0x0013DDD4
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

		// Token: 0x06008659 RID: 34393 RVA: 0x0013FBE7 File Offset: 0x0013DDE7
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

		// Token: 0x0600865A RID: 34394 RVA: 0x0013FBFA File Offset: 0x0013DDFA
		public new IActorLookAtEntityData_SetValue ToSetValue()
		{
			return new IActorLookAtEntityData_SetValue
			{
				Type = this.Type,
				Lock = this.Lock,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x0600865B RID: 34395 RVA: 0x0013FC25 File Offset: 0x0013DE25
		// (set) Token: 0x0600865C RID: 34396 RVA: 0x0013FC50 File Offset: 0x0013DE50
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

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x0600865D RID: 34397 RVA: 0x0013FC60 File Offset: 0x0013DE60
		// (set) Token: 0x0600865E RID: 34398 RVA: 0x0013FC9A File Offset: 0x0013DE9A
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

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x0600865F RID: 34399 RVA: 0x0013FCA8 File Offset: 0x0013DEA8
		// (set) Token: 0x06008660 RID: 34400 RVA: 0x0013FCD3 File Offset: 0x0013DED3
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

		// Token: 0x04005534 RID: 21812
		[Nullable(2)]
		protected new IActorLookAtEntityData FbInstance;

		// Token: 0x04005535 RID: 21813
		[Nullable(2)]
		protected new IActorLookAtEntityData_SetValue PocoInterface;
	}
}
