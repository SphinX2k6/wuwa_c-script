using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D1F RID: 7455
	public class ILeisureInteractType
	{
		// Token: 0x06009E57 RID: 40535 RVA: 0x0016C418 File Offset: 0x0016A618
		private ILeisureInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILeisureInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILeisureInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILeisureInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x0016C450 File Offset: 0x0016A650
		public static ILeisureInteractType Create([Nullable(2)] ILeisureInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILeisureInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E59 RID: 40537 RVA: 0x0016C463 File Offset: 0x0016A663
		public static ILeisureInteractType CreateFromSetValue([Nullable(2)] ILeisureInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILeisureInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x0016C476 File Offset: 0x0016A676
		public ILeisureInteractType_SetValue ToSetValue()
		{
			return new ILeisureInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x06009E5B RID: 40539 RVA: 0x0016C489 File Offset: 0x0016A689
		// (set) Token: 0x06009E5C RID: 40540 RVA: 0x0016C4B4 File Offset: 0x0016A6B4
		public virtual ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006096 RID: 24726
		[Nullable(2)]
		protected ILeisureInteractType FbInstance;

		// Token: 0x04006097 RID: 24727
		[Nullable(2)]
		protected ILeisureInteractType_SetValue PocoInterface;
	}
}
