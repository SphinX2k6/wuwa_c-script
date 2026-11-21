using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EF3 RID: 7923
	public class IPhoneSystemInteractBase
	{
		// Token: 0x0600A89F RID: 43167 RVA: 0x0017F114 File Offset: 0x0017D314
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

		// Token: 0x0600A8A0 RID: 43168 RVA: 0x0017F14C File Offset: 0x0017D34C
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

		// Token: 0x0600A8A1 RID: 43169 RVA: 0x0017F15F File Offset: 0x0017D35F
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

		// Token: 0x0600A8A2 RID: 43170 RVA: 0x0017F172 File Offset: 0x0017D372
		public IPhoneSystemInteractBase_SetValue ToSetValue()
		{
			return new IPhoneSystemInteractBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600A8A3 RID: 43171 RVA: 0x0017F185 File Offset: 0x0017D385
		// (set) Token: 0x0600A8A4 RID: 43172 RVA: 0x0017F1B0 File Offset: 0x0017D3B0
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

		// Token: 0x04006556 RID: 25942
		[Nullable(2)]
		protected IPhoneSystemInteractBase FbInstance;

		// Token: 0x04006557 RID: 25943
		[Nullable(2)]
		protected IPhoneSystemInteractBase_SetValue PocoInterface;
	}
}
