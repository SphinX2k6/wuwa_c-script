using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002043 RID: 8259
	public class ISetAreaTimeUnLock : ISetAreaTimeBase
	{
		// Token: 0x0600AF4D RID: 44877 RVA: 0x0018AF30 File Offset: 0x00189130
		private ISetAreaTimeUnLock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetAreaTimeUnLock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetAreaTimeUnLock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetAreaTimeUnLock_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF4E RID: 44878 RVA: 0x0018AF68 File Offset: 0x00189168
		public static ISetAreaTimeUnLock Create([Nullable(2)] ISetAreaTimeUnLock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAreaTimeUnLock
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF4F RID: 44879 RVA: 0x0018AF7B File Offset: 0x0018917B
		public static ISetAreaTimeUnLock CreateFromSetValue([Nullable(2)] ISetAreaTimeUnLock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetAreaTimeUnLock
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF50 RID: 44880 RVA: 0x0018AF8E File Offset: 0x0018918E
		public new ISetAreaTimeUnLock_SetValue ToSetValue()
		{
			return new ISetAreaTimeUnLock_SetValue
			{
				Type = this.Type,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0600AF51 RID: 44881 RVA: 0x0018AFAD File Offset: 0x001891AD
		// (set) Token: 0x0600AF52 RID: 44882 RVA: 0x0018AFD8 File Offset: 0x001891D8
		public override ESetAreaTime Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetAreaTime.Lock;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0600AF53 RID: 44883 RVA: 0x0018AFE6 File Offset: 0x001891E6
		// (set) Token: 0x0600AF54 RID: 44884 RVA: 0x0018B00D File Offset: 0x0018920D
		public virtual List<int> AreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				ISetAreaTimeUnLock_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x04006867 RID: 26727
		[Nullable(2)]
		protected new ISetAreaTimeUnLock FbInstance;

		// Token: 0x04006868 RID: 26728
		[Nullable(2)]
		protected new ISetAreaTimeUnLock_SetValue PocoInterface;
	}
}
