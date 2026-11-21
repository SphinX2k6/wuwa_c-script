using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000603 RID: 1539
	public class INpcUiInteractType
	{
		// Token: 0x0600200E RID: 8206 RVA: 0x0005A244 File Offset: 0x00058444
		private INpcUiInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0005A27C File Offset: 0x0005847C
		public static INpcUiInteractType Create([Nullable(2)] INpcUiInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0005A28F File Offset: 0x0005848F
		public static INpcUiInteractType CreateFromSetValue([Nullable(2)] INpcUiInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0005A2A2 File Offset: 0x000584A2
		public INpcUiInteractType_SetValue ToSetValue()
		{
			return new INpcUiInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x0005A2B5 File Offset: 0x000584B5
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x0005A2E0 File Offset: 0x000584E0
		public virtual ENpcUiInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040016DC RID: 5852
		[Nullable(2)]
		protected INpcUiInteractType FbInstance;

		// Token: 0x040016DD RID: 5853
		[Nullable(2)]
		protected INpcUiInteractType_SetValue PocoInterface;
	}
}
