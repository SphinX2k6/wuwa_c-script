using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200116B RID: 4459
	public class IPhoneMessageProgressTypeBase
	{
		// Token: 0x06006316 RID: 25366 RVA: 0x000EEADC File Offset: 0x000ECCDC
		private IPhoneMessageProgressTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhoneMessageProgressTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhoneMessageProgressTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhoneMessageProgressTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x000EEB14 File Offset: 0x000ECD14
		public static IPhoneMessageProgressTypeBase Create([Nullable(2)] IPhoneMessageProgressTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageProgressTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x000EEB27 File Offset: 0x000ECD27
		public static IPhoneMessageProgressTypeBase CreateFromSetValue([Nullable(2)] IPhoneMessageProgressTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhoneMessageProgressTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x000EEB3A File Offset: 0x000ECD3A
		public IPhoneMessageProgressTypeBase_SetValue ToSetValue()
		{
			return new IPhoneMessageProgressTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x0600631A RID: 25370 RVA: 0x000EEB4D File Offset: 0x000ECD4D
		// (set) Token: 0x0600631B RID: 25371 RVA: 0x000EEB78 File Offset: 0x000ECD78
		public virtual EPhoneMessageProgressType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneMessageProgressType.CompleteMessage;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003B67 RID: 15207
		[Nullable(2)]
		protected IPhoneMessageProgressTypeBase FbInstance;

		// Token: 0x04003B68 RID: 15208
		[Nullable(2)]
		protected IPhoneMessageProgressTypeBase_SetValue PocoInterface;
	}
}
