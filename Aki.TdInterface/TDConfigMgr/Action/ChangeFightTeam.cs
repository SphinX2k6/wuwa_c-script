using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200162B RID: 5675
	public class ChangeFightTeam : ActionParams
	{
		// Token: 0x06008025 RID: 32805 RVA: 0x001313F0 File Offset: 0x0012F5F0
		private ChangeFightTeam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeFightTeam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeFightTeam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeFightTeam_SetValue());
			}
			return result;
		}

		// Token: 0x06008026 RID: 32806 RVA: 0x00131428 File Offset: 0x0012F628
		public static ChangeFightTeam Create([Nullable(2)] ChangeFightTeam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeFightTeam
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008027 RID: 32807 RVA: 0x0013143B File Offset: 0x0012F63B
		public static ChangeFightTeam CreateFromSetValue([Nullable(2)] ChangeFightTeam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeFightTeam
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008028 RID: 32808 RVA: 0x0013144E File Offset: 0x0012F64E
		public ChangeFightTeam_SetValue ToSetValue()
		{
			return new ChangeFightTeam_SetValue
			{
				TeamIndex = this.TeamIndex
			};
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x06008029 RID: 32809 RVA: 0x00131464 File Offset: 0x0012F664
		// (set) Token: 0x0600802A RID: 32810 RVA: 0x0013149E File Offset: 0x0012F69E
		public virtual int? TeamIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeamIndex;
				}
				ChangeFightTeam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TeamIndex;
			}
			set
			{
				this.GetOrCreatePoco().TeamIndex = value;
			}
		}

		// Token: 0x04004A07 RID: 18951
		[Nullable(2)]
		protected new ChangeFightTeam FbInstance;

		// Token: 0x04004A08 RID: 18952
		[Nullable(2)]
		protected ChangeFightTeam_SetValue PocoInterface;
	}
}
