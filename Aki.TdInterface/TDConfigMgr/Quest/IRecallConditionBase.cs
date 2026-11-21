using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001204 RID: 4612
	public class IRecallConditionBase
	{
		// Token: 0x06006773 RID: 26483 RVA: 0x000F8704 File Offset: 0x000F6904
		private IRecallConditionBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallConditionBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallConditionBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallConditionBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x000F873C File Offset: 0x000F693C
		public static IRecallConditionBase Create([Nullable(2)] IRecallConditionBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x000F874F File Offset: 0x000F694F
		public static IRecallConditionBase CreateFromSetValue([Nullable(2)] IRecallConditionBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallConditionBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x000F8762 File Offset: 0x000F6962
		public IRecallConditionBase_SetValue ToSetValue()
		{
			return new IRecallConditionBase_SetValue
			{
				Type = this.Type,
				Operation = this.Operation
			};
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06006777 RID: 26487 RVA: 0x000F8781 File Offset: 0x000F6981
		// (set) Token: 0x06006778 RID: 26488 RVA: 0x000F87AC File Offset: 0x000F69AC
		public virtual ERecallConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERecallConditionType.ByEntityType;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06006779 RID: 26489 RVA: 0x000F87BA File Offset: 0x000F69BA
		// (set) Token: 0x0600677A RID: 26490 RVA: 0x000F87E5 File Offset: 0x000F69E5
		public virtual ERecallOperation Operation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Operation;
				}
				if (this.PocoInterface == null)
				{
					return ERecallOperation.Include;
				}
				return this.PocoInterface.Operation;
			}
			set
			{
				this.GetOrCreatePoco().Operation = value;
			}
		}

		// Token: 0x04003DFA RID: 15866
		[Nullable(2)]
		protected IRecallConditionBase FbInstance;

		// Token: 0x04003DFB RID: 15867
		[Nullable(2)]
		protected IRecallConditionBase_SetValue PocoInterface;
	}
}
