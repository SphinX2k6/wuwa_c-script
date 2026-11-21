using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002432 RID: 9266
	public class SetNpcGroupPerform : ActionParams
	{
		// Token: 0x0600C99C RID: 51612 RVA: 0x001CCA38 File Offset: 0x001CAC38
		private SetNpcGroupPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetNpcGroupPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetNpcGroupPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetNpcGroupPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600C99D RID: 51613 RVA: 0x001CCA70 File Offset: 0x001CAC70
		public static SetNpcGroupPerform Create([Nullable(2)] SetNpcGroupPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetNpcGroupPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C99E RID: 51614 RVA: 0x001CCA83 File Offset: 0x001CAC83
		public static SetNpcGroupPerform CreateFromSetValue([Nullable(2)] SetNpcGroupPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetNpcGroupPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C99F RID: 51615 RVA: 0x001CCA96 File Offset: 0x001CAC96
		public SetNpcGroupPerform_SetValue ToSetValue()
		{
			return new SetNpcGroupPerform_SetValue
			{
				Key = this.Key,
				PerformType = this.PerformType,
				IsWaitActionFinish = this.IsWaitActionFinish
			};
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x0600C9A0 RID: 51616 RVA: 0x001CCAC1 File Offset: 0x001CACC1
		// (set) Token: 0x0600C9A1 RID: 51617 RVA: 0x001CCAEC File Offset: 0x001CACEC
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x0600C9A2 RID: 51618 RVA: 0x001CCAFA File Offset: 0x001CACFA
		// (set) Token: 0x0600C9A3 RID: 51619 RVA: 0x001CCB21 File Offset: 0x001CAD21
		public virtual ISetNpcGroupPerformType PerformType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformType;
				}
				SetNpcGroupPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformType;
			}
			set
			{
				this.GetOrCreatePoco().PerformType = value;
			}
		}

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x0600C9A4 RID: 51620 RVA: 0x001CCB30 File Offset: 0x001CAD30
		// (set) Token: 0x0600C9A5 RID: 51621 RVA: 0x001CCB6A File Offset: 0x001CAD6A
		public virtual bool? IsWaitActionFinish
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsWaitActionFinish;
				}
				SetNpcGroupPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsWaitActionFinish;
			}
			set
			{
				this.GetOrCreatePoco().IsWaitActionFinish = value;
			}
		}

		// Token: 0x0400779C RID: 30620
		[Nullable(2)]
		protected new SetNpcGroupPerform FbInstance;

		// Token: 0x0400779D RID: 30621
		[Nullable(2)]
		protected SetNpcGroupPerform_SetValue PocoInterface;
	}
}
