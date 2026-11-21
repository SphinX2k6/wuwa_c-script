using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001155 RID: 4437
	public class INewHandInItemsProjectionMachine : INewHandInItemsBase
	{
		// Token: 0x0600622A RID: 25130 RVA: 0x000EC5F4 File Offset: 0x000EA7F4
		private INewHandInItemsProjectionMachine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INewHandInItemsProjectionMachine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INewHandInItemsProjectionMachine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INewHandInItemsProjectionMachine_SetValue());
			}
			return result;
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x000EC62C File Offset: 0x000EA82C
		public static INewHandInItemsProjectionMachine Create([Nullable(2)] INewHandInItemsProjectionMachine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewHandInItemsProjectionMachine
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x000EC63F File Offset: 0x000EA83F
		public static INewHandInItemsProjectionMachine CreateFromSetValue([Nullable(2)] INewHandInItemsProjectionMachine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INewHandInItemsProjectionMachine
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x000EC652 File Offset: 0x000EA852
		public new INewHandInItemsProjectionMachine_SetValue ToSetValue()
		{
			return new INewHandInItemsProjectionMachine_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				ItemId = this.ItemId
			};
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x0600622E RID: 25134 RVA: 0x000EC67D File Offset: 0x000EA87D
		// (set) Token: 0x0600622F RID: 25135 RVA: 0x000EC6A8 File Offset: 0x000EA8A8
		public override ENewHandInItemsType Type
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

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06006230 RID: 25136 RVA: 0x000EC6B6 File Offset: 0x000EA8B6
		// (set) Token: 0x06006231 RID: 25137 RVA: 0x000EC6E1 File Offset: 0x000EA8E1
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

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06006232 RID: 25138 RVA: 0x000EC6EF File Offset: 0x000EA8EF
		// (set) Token: 0x06006233 RID: 25139 RVA: 0x000EC71A File Offset: 0x000EA91A
		public virtual int ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x04003AC0 RID: 15040
		[Nullable(2)]
		protected new INewHandInItemsProjectionMachine FbInstance;

		// Token: 0x04003AC1 RID: 15041
		[Nullable(2)]
		protected new INewHandInItemsProjectionMachine_SetValue PocoInterface;
	}
}
