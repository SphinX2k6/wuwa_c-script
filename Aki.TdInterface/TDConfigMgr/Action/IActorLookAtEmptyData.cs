using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001901 RID: 6401
	public class IActorLookAtEmptyData : IActorLookAtLockable
	{
		// Token: 0x0600864D RID: 34381 RVA: 0x0013FA8C File Offset: 0x0013DC8C
		private IActorLookAtEmptyData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtEmptyData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtEmptyData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtEmptyData_SetValue());
			}
			return result;
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x0013FAC4 File Offset: 0x0013DCC4
		public static IActorLookAtEmptyData Create([Nullable(2)] IActorLookAtEmptyData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtEmptyData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600864F RID: 34383 RVA: 0x0013FAD7 File Offset: 0x0013DCD7
		public static IActorLookAtEmptyData CreateFromSetValue([Nullable(2)] IActorLookAtEmptyData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtEmptyData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008650 RID: 34384 RVA: 0x0013FAEA File Offset: 0x0013DCEA
		public new IActorLookAtEmptyData_SetValue ToSetValue()
		{
			return new IActorLookAtEmptyData_SetValue
			{
				Type = this.Type,
				Lock = this.Lock
			};
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x06008651 RID: 34385 RVA: 0x0013FB09 File Offset: 0x0013DD09
		// (set) Token: 0x06008652 RID: 34386 RVA: 0x0013FB34 File Offset: 0x0013DD34
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

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x06008653 RID: 34387 RVA: 0x0013FB44 File Offset: 0x0013DD44
		// (set) Token: 0x06008654 RID: 34388 RVA: 0x0013FB7E File Offset: 0x0013DD7E
		public override bool? Lock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Lock;
				}
				IActorLookAtEmptyData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005530 RID: 21808
		[Nullable(2)]
		protected new IActorLookAtEmptyData FbInstance;

		// Token: 0x04005531 RID: 21809
		[Nullable(2)]
		protected new IActorLookAtEmptyData_SetValue PocoInterface;
	}
}
