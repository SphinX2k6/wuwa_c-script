using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001788 RID: 6024
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAtPlayerData : IActorLookAtLockable
	{
		// Token: 0x06007F89 RID: 32649 RVA: 0x00130CFC File Offset: 0x0012EEFC
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

		// Token: 0x06007F8A RID: 32650 RVA: 0x00130D34 File Offset: 0x0012EF34
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

		// Token: 0x06007F8B RID: 32651 RVA: 0x00130D47 File Offset: 0x0012EF47
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

		// Token: 0x06007F8C RID: 32652 RVA: 0x00130D5A File Offset: 0x0012EF5A
		public new IActorLookAtPlayerData_SetValue ToSetValue()
		{
			return new IActorLookAtPlayerData_SetValue
			{
				Type = this.Type,
				Lock = this.Lock
			};
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x06007F8D RID: 32653 RVA: 0x00130D79 File Offset: 0x0012EF79
		// (set) Token: 0x06007F8E RID: 32654 RVA: 0x00130DA4 File Offset: 0x0012EFA4
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

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x06007F8F RID: 32655 RVA: 0x00130DB4 File Offset: 0x0012EFB4
		// (set) Token: 0x06007F90 RID: 32656 RVA: 0x00130DEE File Offset: 0x0012EFEE
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

		// Token: 0x0400510C RID: 20748
		[Nullable(2)]
		protected new IActorLookAtPlayerData FbInstance;

		// Token: 0x0400510D RID: 20749
		[Nullable(2)]
		protected new IActorLookAtPlayerData_SetValue PocoInterface;
	}
}
