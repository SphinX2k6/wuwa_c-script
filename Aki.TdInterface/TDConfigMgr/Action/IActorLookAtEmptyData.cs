using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001780 RID: 6016
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAtEmptyData : IActorLookAtLockable
	{
		// Token: 0x06007F5D RID: 32605 RVA: 0x0013082C File Offset: 0x0012EA2C
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

		// Token: 0x06007F5E RID: 32606 RVA: 0x00130864 File Offset: 0x0012EA64
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

		// Token: 0x06007F5F RID: 32607 RVA: 0x00130877 File Offset: 0x0012EA77
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

		// Token: 0x06007F60 RID: 32608 RVA: 0x0013088A File Offset: 0x0012EA8A
		public new IActorLookAtEmptyData_SetValue ToSetValue()
		{
			return new IActorLookAtEmptyData_SetValue
			{
				Type = this.Type,
				Lock = this.Lock
			};
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x06007F61 RID: 32609 RVA: 0x001308A9 File Offset: 0x0012EAA9
		// (set) Token: 0x06007F62 RID: 32610 RVA: 0x001308D4 File Offset: 0x0012EAD4
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

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x06007F63 RID: 32611 RVA: 0x001308E4 File Offset: 0x0012EAE4
		// (set) Token: 0x06007F64 RID: 32612 RVA: 0x0013091E File Offset: 0x0012EB1E
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

		// Token: 0x040050FA RID: 20730
		[Nullable(2)]
		protected new IActorLookAtEmptyData FbInstance;

		// Token: 0x040050FB RID: 20731
		[Nullable(2)]
		protected new IActorLookAtEmptyData_SetValue PocoInterface;
	}
}
