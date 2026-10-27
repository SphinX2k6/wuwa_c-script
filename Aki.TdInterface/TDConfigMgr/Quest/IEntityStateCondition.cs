using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F61 RID: 3937
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityStateCondition
	{
		// Token: 0x06005780 RID: 22400 RVA: 0x000D5E98 File Offset: 0x000D4098
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

		// Token: 0x06005781 RID: 22401 RVA: 0x000D5ED0 File Offset: 0x000D40D0
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

		// Token: 0x06005782 RID: 22402 RVA: 0x000D5EE3 File Offset: 0x000D40E3
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

		// Token: 0x06005783 RID: 22403 RVA: 0x000D5EF6 File Offset: 0x000D40F6
		public IEntityStateCondition_SetValue ToSetValue()
		{
			return new IEntityStateCondition_SetValue
			{
				EntityId = this.EntityId,
				State = this.State
			};
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06005784 RID: 22404 RVA: 0x000D5F15 File Offset: 0x000D4115
		// (set) Token: 0x06005785 RID: 22405 RVA: 0x000D5F40 File Offset: 0x000D4140
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

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x06005786 RID: 22406 RVA: 0x000D5F4E File Offset: 0x000D414E
		// (set) Token: 0x06005787 RID: 22407 RVA: 0x000D5F79 File Offset: 0x000D4179
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

		// Token: 0x040034E9 RID: 13545
		[Nullable(2)]
		protected IEntityStateCondition FbInstance;

		// Token: 0x040034EA RID: 13546
		[Nullable(2)]
		protected IEntityStateCondition_SetValue PocoInterface;
	}
}
