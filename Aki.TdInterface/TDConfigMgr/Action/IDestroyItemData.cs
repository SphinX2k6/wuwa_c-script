using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B13 RID: 6931
	public class IDestroyItemData : IItemData
	{
		// Token: 0x06009325 RID: 37669 RVA: 0x001584B0 File Offset: 0x001566B0
		private IDestroyItemData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDestroyItemData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDestroyItemData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDestroyItemData_SetValue());
			}
			return result;
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x001584E8 File Offset: 0x001566E8
		public static IDestroyItemData Create([Nullable(2)] IDestroyItemData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyItemData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x001584FB File Offset: 0x001566FB
		public static IDestroyItemData CreateFromSetValue([Nullable(2)] IDestroyItemData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDestroyItemData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x0015850E File Offset: 0x0015670E
		public new IDestroyItemData_SetValue ToSetValue()
		{
			return new IDestroyItemData_SetValue
			{
				ItemId = this.ItemId,
				Count = this.Count,
				IsAll = this.IsAll
			};
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x06009329 RID: 37673 RVA: 0x00158539 File Offset: 0x00156739
		// (set) Token: 0x0600932A RID: 37674 RVA: 0x00158564 File Offset: 0x00156764
		public override int ItemId
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

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x0600932B RID: 37675 RVA: 0x00158572 File Offset: 0x00156772
		// (set) Token: 0x0600932C RID: 37676 RVA: 0x0015859D File Offset: 0x0015679D
		public override int Count
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Count;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Count;
			}
			set
			{
				this.GetOrCreatePoco().Count = value;
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x0600932D RID: 37677 RVA: 0x001585AB File Offset: 0x001567AB
		// (set) Token: 0x0600932E RID: 37678 RVA: 0x001585D6 File Offset: 0x001567D6
		public virtual bool IsAll
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAll;
				}
				return this.PocoInterface != null && this.PocoInterface.IsAll;
			}
			set
			{
				this.GetOrCreatePoco().IsAll = value;
			}
		}

		// Token: 0x04005B85 RID: 23429
		[Nullable(2)]
		protected new IDestroyItemData FbInstance;

		// Token: 0x04005B86 RID: 23430
		[Nullable(2)]
		protected new IDestroyItemData_SetValue PocoInterface;
	}
}
