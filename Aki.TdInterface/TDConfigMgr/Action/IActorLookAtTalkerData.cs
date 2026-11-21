using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200190D RID: 6413
	public class IActorLookAtTalkerData : IActorLookAtLockable
	{
		// Token: 0x0600868F RID: 34447 RVA: 0x00140200 File Offset: 0x0013E400
		private IActorLookAtTalkerData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtTalkerData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtTalkerData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtTalkerData_SetValue());
			}
			return result;
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x00140238 File Offset: 0x0013E438
		public static IActorLookAtTalkerData Create([Nullable(2)] IActorLookAtTalkerData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtTalkerData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x0014024B File Offset: 0x0013E44B
		public static IActorLookAtTalkerData CreateFromSetValue([Nullable(2)] IActorLookAtTalkerData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtTalkerData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x0014025E File Offset: 0x0013E45E
		public new IActorLookAtTalkerData_SetValue ToSetValue()
		{
			return new IActorLookAtTalkerData_SetValue
			{
				Type = this.Type,
				Lock = this.Lock
			};
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x06008693 RID: 34451 RVA: 0x0014027D File Offset: 0x0013E47D
		// (set) Token: 0x06008694 RID: 34452 RVA: 0x001402A8 File Offset: 0x0013E4A8
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

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x06008695 RID: 34453 RVA: 0x001402B8 File Offset: 0x0013E4B8
		// (set) Token: 0x06008696 RID: 34454 RVA: 0x001402F2 File Offset: 0x0013E4F2
		public override bool? Lock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Lock;
				}
				IActorLookAtTalkerData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400554D RID: 21837
		[Nullable(2)]
		protected new IActorLookAtTalkerData FbInstance;

		// Token: 0x0400554E RID: 21838
		[Nullable(2)]
		protected new IActorLookAtTalkerData_SetValue PocoInterface;
	}
}
