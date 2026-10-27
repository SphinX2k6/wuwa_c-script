using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001029 RID: 4137
	[NullableContext(1)]
	[Nullable(0)]
	public class INewHandInItemsProjectionMachine : INewHandInItemsBase
	{
		// Token: 0x06005C48 RID: 23624 RVA: 0x000DF8FC File Offset: 0x000DDAFC
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

		// Token: 0x06005C49 RID: 23625 RVA: 0x000DF934 File Offset: 0x000DDB34
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

		// Token: 0x06005C4A RID: 23626 RVA: 0x000DF947 File Offset: 0x000DDB47
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

		// Token: 0x06005C4B RID: 23627 RVA: 0x000DF95A File Offset: 0x000DDB5A
		public new INewHandInItemsProjectionMachine_SetValue ToSetValue()
		{
			return new INewHandInItemsProjectionMachine_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				ItemId = this.ItemId
			};
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06005C4C RID: 23628 RVA: 0x000DF985 File Offset: 0x000DDB85
		// (set) Token: 0x06005C4D RID: 23629 RVA: 0x000DF9B0 File Offset: 0x000DDBB0
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

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06005C4E RID: 23630 RVA: 0x000DF9BE File Offset: 0x000DDBBE
		// (set) Token: 0x06005C4F RID: 23631 RVA: 0x000DF9E9 File Offset: 0x000DDBE9
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

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06005C50 RID: 23632 RVA: 0x000DF9F7 File Offset: 0x000DDBF7
		// (set) Token: 0x06005C51 RID: 23633 RVA: 0x000DFA22 File Offset: 0x000DDC22
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

		// Token: 0x04003785 RID: 14213
		[Nullable(2)]
		protected new INewHandInItemsProjectionMachine FbInstance;

		// Token: 0x04003786 RID: 14214
		[Nullable(2)]
		protected new INewHandInItemsProjectionMachine_SetValue PocoInterface;
	}
}
