using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D07 RID: 7431
	public class IInteractType
	{
		// Token: 0x06009DCD RID: 40397 RVA: 0x0016B398 File Offset: 0x00169598
		private IInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06009DCE RID: 40398 RVA: 0x0016B3D0 File Offset: 0x001695D0
		public static IInteractType Create([Nullable(2)] IInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DCF RID: 40399 RVA: 0x0016B3E3 File Offset: 0x001695E3
		public static IInteractType CreateFromSetValue([Nullable(2)] IInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DD0 RID: 40400 RVA: 0x0016B3F6 File Offset: 0x001695F6
		public IInteractType_SetValue ToSetValue()
		{
			return new IInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x06009DD1 RID: 40401 RVA: 0x0016B409 File Offset: 0x00169609
		// (set) Token: 0x06009DD2 RID: 40402 RVA: 0x0016B434 File Offset: 0x00169634
		public virtual EInteractOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractOption.Flow;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006051 RID: 24657
		[Nullable(2)]
		protected IInteractType FbInstance;

		// Token: 0x04006052 RID: 24658
		[Nullable(2)]
		protected IInteractType_SetValue PocoInterface;
	}
}
