using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200108B RID: 4235
	public class IEntityStateCondition
	{
		// Token: 0x06005D54 RID: 23892 RVA: 0x000E2904 File Offset: 0x000E0B04
		private IEntityStateCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityStateCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityStateCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityStateCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x000E293C File Offset: 0x000E0B3C
		public static IEntityStateCondition Create([Nullable(2)] IEntityStateCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityStateCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x000E294F File Offset: 0x000E0B4F
		public static IEntityStateCondition CreateFromSetValue([Nullable(2)] IEntityStateCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityStateCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x000E2962 File Offset: 0x000E0B62
		public IEntityStateCondition_SetValue ToSetValue()
		{
			return new IEntityStateCondition_SetValue
			{
				EntityId = this.EntityId,
				State = this.State
			};
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06005D58 RID: 23896 RVA: 0x000E2981 File Offset: 0x000E0B81
		// (set) Token: 0x06005D59 RID: 23897 RVA: 0x000E29AC File Offset: 0x000E0BAC
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x06005D5A RID: 23898 RVA: 0x000E29BA File Offset: 0x000E0BBA
		// (set) Token: 0x06005D5B RID: 23899 RVA: 0x000E29E5 File Offset: 0x000E0BE5
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x0400381A RID: 14362
		[Nullable(2)]
		protected IEntityStateCondition FbInstance;

		// Token: 0x0400381B RID: 14363
		[Nullable(2)]
		protected IEntityStateCondition_SetValue PocoInterface;
	}
}
