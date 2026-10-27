using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014D2 RID: 5330
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeFightTeam : ActionParams
	{
		// Token: 0x06007958 RID: 31064 RVA: 0x001227A4 File Offset: 0x001209A4
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

		// Token: 0x06007959 RID: 31065 RVA: 0x001227DC File Offset: 0x001209DC
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

		// Token: 0x0600795A RID: 31066 RVA: 0x001227EF File Offset: 0x001209EF
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

		// Token: 0x0600795B RID: 31067 RVA: 0x00122802 File Offset: 0x00120A02
		public ChangeFightTeam_SetValue ToSetValue()
		{
			return new ChangeFightTeam_SetValue
			{
				TeamIndex = this.TeamIndex
			};
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x0600795C RID: 31068 RVA: 0x00122818 File Offset: 0x00120A18
		// (set) Token: 0x0600795D RID: 31069 RVA: 0x00122852 File Offset: 0x00120A52
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

		// Token: 0x0400466C RID: 18028
		[Nullable(2)]
		protected new ChangeFightTeam FbInstance;

		// Token: 0x0400466D RID: 18029
		[Nullable(2)]
		protected ChangeFightTeam_SetValue PocoInterface;
	}
}
