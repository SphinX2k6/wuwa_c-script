using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E10 RID: 7696
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAreaTimeUnLock : ISetAreaTimeBase
	{
		// Token: 0x0600A4A5 RID: 42149 RVA: 0x00175528 File Offset: 0x00173728
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

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x00175560 File Offset: 0x00173760
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

		// Token: 0x0600A4A7 RID: 42151 RVA: 0x00175573 File Offset: 0x00173773
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

		// Token: 0x0600A4A8 RID: 42152 RVA: 0x00175586 File Offset: 0x00173786
		public new ISetAreaTimeUnLock_SetValue ToSetValue()
		{
			return new ISetAreaTimeUnLock_SetValue
			{
				Type = this.Type,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600A4A9 RID: 42153 RVA: 0x001755A5 File Offset: 0x001737A5
		// (set) Token: 0x0600A4AA RID: 42154 RVA: 0x001755D0 File Offset: 0x001737D0
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

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600A4AB RID: 42155 RVA: 0x001755DE File Offset: 0x001737DE
		// (set) Token: 0x0600A4AC RID: 42156 RVA: 0x00175605 File Offset: 0x00173805
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

		// Token: 0x04006290 RID: 25232
		[Nullable(2)]
		protected new ISetAreaTimeUnLock FbInstance;

		// Token: 0x04006291 RID: 25233
		[Nullable(2)]
		protected new ISetAreaTimeUnLock_SetValue PocoInterface;
	}
}
