using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B5C RID: 7004
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemData
	{
		// Token: 0x060095F3 RID: 38387 RVA: 0x0015A8A8 File Offset: 0x00158AA8
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

		// Token: 0x060095F4 RID: 38388 RVA: 0x0015A8E0 File Offset: 0x00158AE0
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

		// Token: 0x060095F5 RID: 38389 RVA: 0x0015A8F3 File Offset: 0x00158AF3
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

		// Token: 0x060095F6 RID: 38390 RVA: 0x0015A906 File Offset: 0x00158B06
		public IItemData_SetValue ToSetValue()
		{
			return new IItemData_SetValue
			{
				ItemId = this.ItemId,
				Count = this.Count
			};
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x060095F7 RID: 38391 RVA: 0x0015A925 File Offset: 0x00158B25
		// (set) Token: 0x060095F8 RID: 38392 RVA: 0x0015A950 File Offset: 0x00158B50
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

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x060095F9 RID: 38393 RVA: 0x0015A95E File Offset: 0x00158B5E
		// (set) Token: 0x060095FA RID: 38394 RVA: 0x0015A989 File Offset: 0x00158B89
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

		// Token: 0x04005BBB RID: 23483
		[Nullable(2)]
		protected IItemData FbInstance;

		// Token: 0x04005BBC RID: 23484
		[Nullable(2)]
		protected IItemData_SetValue PocoInterface;
	}
}
