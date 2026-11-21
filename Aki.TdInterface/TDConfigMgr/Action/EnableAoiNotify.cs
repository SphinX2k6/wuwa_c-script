using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A1 RID: 6049
	public class EnableAoiNotify : ActionParams
	{
		// Token: 0x06008301 RID: 33537 RVA: 0x00139BA8 File Offset: 0x00137DA8
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

		// Token: 0x06008302 RID: 33538 RVA: 0x00139BE0 File Offset: 0x00137DE0
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

		// Token: 0x06008303 RID: 33539 RVA: 0x00139BF3 File Offset: 0x00137DF3
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

		// Token: 0x06008304 RID: 33540 RVA: 0x00139C06 File Offset: 0x00137E06
		public EnableAoiNotify_SetValue ToSetValue()
		{
			return new EnableAoiNotify_SetValue
			{
				State = this.State
			};
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x06008305 RID: 33541 RVA: 0x00139C19 File Offset: 0x00137E19
		// (set) Token: 0x06008306 RID: 33542 RVA: 0x00139C44 File Offset: 0x00137E44
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

		// Token: 0x0400503E RID: 20542
		[Nullable(2)]
		protected new EnableAoiNotify FbInstance;

		// Token: 0x0400503F RID: 20543
		[Nullable(2)]
		protected EnableAoiNotify_SetValue PocoInterface;
	}
}
