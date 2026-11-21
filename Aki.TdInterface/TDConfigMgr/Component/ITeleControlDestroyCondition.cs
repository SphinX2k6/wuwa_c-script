using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F5 RID: 2037
	public class ITeleControlDestroyCondition
	{
		// Token: 0x06002BA5 RID: 11173 RVA: 0x00072594 File Offset: 0x00070794
		private ITeleControlDestroyCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleControlDestroyCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleControlDestroyCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleControlDestroyCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000725CC File Offset: 0x000707CC
		public static ITeleControlDestroyCondition Create([Nullable(2)] ITeleControlDestroyCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlDestroyCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000725DF File Offset: 0x000707DF
		public static ITeleControlDestroyCondition CreateFromSetValue([Nullable(2)] ITeleControlDestroyCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleControlDestroyCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000725F2 File Offset: 0x000707F2
		public ITeleControlDestroyCondition_SetValue ToSetValue()
		{
			return new ITeleControlDestroyCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x00072605 File Offset: 0x00070805
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x00072630 File Offset: 0x00070830
		public virtual ETeleControlDestroyCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleControlDestroyCondition.LetGo;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001D41 RID: 7489
		[Nullable(2)]
		protected ITeleControlDestroyCondition FbInstance;

		// Token: 0x04001D42 RID: 7490
		[Nullable(2)]
		protected ITeleControlDestroyCondition_SetValue PocoInterface;
	}
}
