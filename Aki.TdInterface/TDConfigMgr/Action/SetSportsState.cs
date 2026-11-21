using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002447 RID: 9287
	public class SetSportsState : ActionParams
	{
		// Token: 0x0600CA33 RID: 51763 RVA: 0x001CDEB0 File Offset: 0x001CC0B0
		private SetSportsState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetSportsState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetSportsState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetSportsState_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA34 RID: 51764 RVA: 0x001CDEE8 File Offset: 0x001CC0E8
		public static SetSportsState Create([Nullable(2)] SetSportsState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSportsState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA35 RID: 51765 RVA: 0x001CDEFB File Offset: 0x001CC0FB
		public static SetSportsState CreateFromSetValue([Nullable(2)] SetSportsState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetSportsState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA36 RID: 51766 RVA: 0x001CDF0E File Offset: 0x001CC10E
		public SetSportsState_SetValue ToSetValue()
		{
			return new SetSportsState_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0600CA37 RID: 51767 RVA: 0x001CDF21 File Offset: 0x001CC121
		// (set) Token: 0x0600CA38 RID: 51768 RVA: 0x001CDF48 File Offset: 0x001CC148
		public virtual ISportConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				SetSportsState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x040077F4 RID: 30708
		[Nullable(2)]
		protected new SetSportsState FbInstance;

		// Token: 0x040077F5 RID: 30709
		[Nullable(2)]
		protected SetSportsState_SetValue PocoInterface;
	}
}
