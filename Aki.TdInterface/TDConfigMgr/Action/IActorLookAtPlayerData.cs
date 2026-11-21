using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001909 RID: 6409
	public class IActorLookAtPlayerData : IActorLookAtLockable
	{
		// Token: 0x06008679 RID: 34425 RVA: 0x0013FF5C File Offset: 0x0013E15C
		private IActorLookAtPlayerData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtPlayerData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtPlayerData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtPlayerData_SetValue());
			}
			return result;
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x0013FF94 File Offset: 0x0013E194
		public static IActorLookAtPlayerData Create([Nullable(2)] IActorLookAtPlayerData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtPlayerData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600867B RID: 34427 RVA: 0x0013FFA7 File Offset: 0x0013E1A7
		public static IActorLookAtPlayerData CreateFromSetValue([Nullable(2)] IActorLookAtPlayerData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtPlayerData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x0013FFBA File Offset: 0x0013E1BA
		public new IActorLookAtPlayerData_SetValue ToSetValue()
		{
			return new IActorLookAtPlayerData_SetValue
			{
				Type = this.Type,
				Lock = this.Lock
			};
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x0600867D RID: 34429 RVA: 0x0013FFD9 File Offset: 0x0013E1D9
		// (set) Token: 0x0600867E RID: 34430 RVA: 0x00140004 File Offset: 0x0013E204
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

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x0600867F RID: 34431 RVA: 0x00140014 File Offset: 0x0013E214
		// (set) Token: 0x06008680 RID: 34432 RVA: 0x0014004E File Offset: 0x0013E24E
		public override bool? Lock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Lock;
				}
				IActorLookAtPlayerData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005542 RID: 21826
		[Nullable(2)]
		protected new IActorLookAtPlayerData FbInstance;

		// Token: 0x04005543 RID: 21827
		[Nullable(2)]
		protected new IActorLookAtPlayerData_SetValue PocoInterface;
	}
}
