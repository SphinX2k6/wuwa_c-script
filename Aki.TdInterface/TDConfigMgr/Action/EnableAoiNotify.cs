using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001634 RID: 5684
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableAoiNotify : ActionParams
	{
		// Token: 0x06007C23 RID: 31779 RVA: 0x0012AAFC File Offset: 0x00128CFC
		private EnableAoiNotify_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableAoiNotify 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableAoiNotify_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableAoiNotify_SetValue());
			}
			return result;
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x0012AB34 File Offset: 0x00128D34
		public static EnableAoiNotify Create([Nullable(2)] EnableAoiNotify instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableAoiNotify
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x0012AB47 File Offset: 0x00128D47
		public static EnableAoiNotify CreateFromSetValue([Nullable(2)] EnableAoiNotify_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableAoiNotify
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x0012AB5A File Offset: 0x00128D5A
		public EnableAoiNotify_SetValue ToSetValue()
		{
			return new EnableAoiNotify_SetValue
			{
				State = this.State
			};
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x06007C27 RID: 31783 RVA: 0x0012AB6D File Offset: 0x00128D6D
		// (set) Token: 0x06007C28 RID: 31784 RVA: 0x0012AB98 File Offset: 0x00128D98
		public virtual EAoiNotifyState State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return EAoiNotifyState.Open;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04004C4A RID: 19530
		[Nullable(2)]
		protected new EnableAoiNotify FbInstance;

		// Token: 0x04004C4B RID: 19531
		[Nullable(2)]
		protected EnableAoiNotify_SetValue PocoInterface;
	}
}
