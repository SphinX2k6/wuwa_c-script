using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001151 RID: 4433
	public class INewHandInItemsBase
	{
		// Token: 0x06006216 RID: 25110 RVA: 0x000EC374 File Offset: 0x000EA574
		private INewHandInItemsBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INewHandInItemsBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INewHandInItemsBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INewHandInItemsBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x000EC3AC File Offset: 0x000EA5AC
		public static INewHandInItemsBase Create([Nullable(2)] INewHandInItemsBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewHandInItemsBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x000EC3BF File Offset: 0x000EA5BF
		public static INewHandInItemsBase CreateFromSetValue([Nullable(2)] INewHandInItemsBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INewHandInItemsBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x000EC3D2 File Offset: 0x000EA5D2
		public INewHandInItemsBase_SetValue ToSetValue()
		{
			return new INewHandInItemsBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x0600621A RID: 25114 RVA: 0x000EC3E5 File Offset: 0x000EA5E5
		// (set) Token: 0x0600621B RID: 25115 RVA: 0x000EC410 File Offset: 0x000EA610
		public virtual ENewHandInItemsType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewHandInItemsType.ProjectionMachine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003AB4 RID: 15028
		[Nullable(2)]
		protected INewHandInItemsBase FbInstance;

		// Token: 0x04003AB5 RID: 15029
		[Nullable(2)]
		protected INewHandInItemsBase_SetValue PocoInterface;
	}
}
