using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D09 RID: 7433
	public class IItemData
	{
		// Token: 0x06009DD5 RID: 40405 RVA: 0x0016B454 File Offset: 0x00169654
		private IItemData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemData_SetValue());
			}
			return result;
		}

		// Token: 0x06009DD6 RID: 40406 RVA: 0x0016B48C File Offset: 0x0016968C
		public static IItemData Create([Nullable(2)] IItemData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DD7 RID: 40407 RVA: 0x0016B49F File Offset: 0x0016969F
		public static IItemData CreateFromSetValue([Nullable(2)] IItemData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x0016B4B2 File Offset: 0x001696B2
		public IItemData_SetValue ToSetValue()
		{
			return new IItemData_SetValue
			{
				ItemId = this.ItemId,
				Count = this.Count
			};
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x06009DD9 RID: 40409 RVA: 0x0016B4D1 File Offset: 0x001696D1
		// (set) Token: 0x06009DDA RID: 40410 RVA: 0x0016B4FC File Offset: 0x001696FC
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

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x06009DDB RID: 40411 RVA: 0x0016B50A File Offset: 0x0016970A
		// (set) Token: 0x06009DDC RID: 40412 RVA: 0x0016B535 File Offset: 0x00169735
		public virtual int Count
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

		// Token: 0x04006054 RID: 24660
		[Nullable(2)]
		protected IItemData FbInstance;

		// Token: 0x04006055 RID: 24661
		[Nullable(2)]
		protected IItemData_SetValue PocoInterface;
	}
}
