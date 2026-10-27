using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200198C RID: 6540
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroyItemData : IItemData
	{
		// Token: 0x06008C01 RID: 35841 RVA: 0x00148CA0 File Offset: 0x00146EA0
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

		// Token: 0x06008C02 RID: 35842 RVA: 0x00148CD8 File Offset: 0x00146ED8
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

		// Token: 0x06008C03 RID: 35843 RVA: 0x00148CEB File Offset: 0x00146EEB
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

		// Token: 0x06008C04 RID: 35844 RVA: 0x00148CFE File Offset: 0x00146EFE
		public new IDestroyItemData_SetValue ToSetValue()
		{
			return new IDestroyItemData_SetValue
			{
				ItemId = this.ItemId,
				Count = this.Count,
				IsAll = this.IsAll
			};
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x06008C05 RID: 35845 RVA: 0x00148D29 File Offset: 0x00146F29
		// (set) Token: 0x06008C06 RID: 35846 RVA: 0x00148D54 File Offset: 0x00146F54
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

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x06008C07 RID: 35847 RVA: 0x00148D62 File Offset: 0x00146F62
		// (set) Token: 0x06008C08 RID: 35848 RVA: 0x00148D8D File Offset: 0x00146F8D
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

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x06008C09 RID: 35849 RVA: 0x00148D9B File Offset: 0x00146F9B
		// (set) Token: 0x06008C0A RID: 35850 RVA: 0x00148DC6 File Offset: 0x00146FC6
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

		// Token: 0x0400573C RID: 22332
		[Nullable(2)]
		protected new IDestroyItemData FbInstance;

		// Token: 0x0400573D RID: 22333
		[Nullable(2)]
		protected new IDestroyItemData_SetValue PocoInterface;
	}
}
