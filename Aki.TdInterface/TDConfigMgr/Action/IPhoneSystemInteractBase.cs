using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CE4 RID: 7396
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhoneSystemInteractBase
	{
		// Token: 0x06009EBF RID: 40639 RVA: 0x0016AEB4 File Offset: 0x001690B4
		private IPhoneSystemInteractBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhoneSystemInteractBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhoneSystemInteractBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhoneSystemInteractBase_SetValue());
			}
			return result;
		}

		// Token: 0x06009EC0 RID: 40640 RVA: 0x0016AEEC File Offset: 0x001690EC
		public static IPhoneSystemInteractBase Create([Nullable(2)] IPhoneSystemInteractBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneSystemInteractBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EC1 RID: 40641 RVA: 0x0016AEFF File Offset: 0x001690FF
		public static IPhoneSystemInteractBase CreateFromSetValue([Nullable(2)] IPhoneSystemInteractBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhoneSystemInteractBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x0016AF12 File Offset: 0x00169112
		public IPhoneSystemInteractBase_SetValue ToSetValue()
		{
			return new IPhoneSystemInteractBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x06009EC3 RID: 40643 RVA: 0x0016AF25 File Offset: 0x00169125
		// (set) Token: 0x06009EC4 RID: 40644 RVA: 0x0016AF50 File Offset: 0x00169150
		public virtual EPhoneSystemInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneSystemInteractType.SendPhoneMessage;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005FE3 RID: 24547
		[Nullable(2)]
		protected IPhoneSystemInteractBase FbInstance;

		// Token: 0x04005FE4 RID: 24548
		[Nullable(2)]
		protected IPhoneSystemInteractBase_SetValue PocoInterface;
	}
}
