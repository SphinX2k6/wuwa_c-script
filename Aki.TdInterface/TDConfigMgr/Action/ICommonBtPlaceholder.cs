using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001906 RID: 6406
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtPlaceholder
	{
		// Token: 0x0600893F RID: 35135 RVA: 0x001441E0 File Offset: 0x001423E0
		private ICommonBtPlaceholder_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtPlaceholder 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtPlaceholder_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtPlaceholder_SetValue());
			}
			return result;
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x00144218 File Offset: 0x00142418
		public static ICommonBtPlaceholder Create([Nullable(2)] ICommonBtPlaceholder instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtPlaceholder
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x0014422B File Offset: 0x0014242B
		public static ICommonBtPlaceholder CreateFromSetValue([Nullable(2)] ICommonBtPlaceholder_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtPlaceholder
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x0014423E File Offset: 0x0014243E
		public ICommonBtPlaceholder_SetValue ToSetValue()
		{
			return new ICommonBtPlaceholder_SetValue
			{
				Id = this.Id,
				Name = this.Name,
				Value = this.Value,
				RefTaskIds = this.RefTaskIds
			};
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x06008943 RID: 35139 RVA: 0x00144275 File Offset: 0x00142475
		// (set) Token: 0x06008944 RID: 35140 RVA: 0x001442A0 File Offset: 0x001424A0
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x06008945 RID: 35141 RVA: 0x001442AE File Offset: 0x001424AE
		// (set) Token: 0x06008946 RID: 35142 RVA: 0x001442D9 File Offset: 0x001424D9
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x06008947 RID: 35143 RVA: 0x001442E7 File Offset: 0x001424E7
		// (set) Token: 0x06008948 RID: 35144 RVA: 0x0014430E File Offset: 0x0014250E
		public virtual ICommonBtOverrideTaskInfoBase Value
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Value;
				}
				ICommonBtPlaceholder_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Value;
			}
			set
			{
				this.GetOrCreatePoco().Value = value;
			}
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x06008949 RID: 35145 RVA: 0x0014431C File Offset: 0x0014251C
		// (set) Token: 0x0600894A RID: 35146 RVA: 0x00144343 File Offset: 0x00142543
		public virtual List<int> RefTaskIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefTaskIds;
				}
				ICommonBtPlaceholder_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RefTaskIds;
			}
			set
			{
				this.GetOrCreatePoco().RefTaskIds = value;
			}
		}

		// Token: 0x04005608 RID: 22024
		[Nullable(2)]
		protected ICommonBtPlaceholder FbInstance;

		// Token: 0x04005609 RID: 22025
		[Nullable(2)]
		protected ICommonBtPlaceholder_SetValue PocoInterface;
	}
}
