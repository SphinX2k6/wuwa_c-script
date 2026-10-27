using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F7 RID: 8695
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffChangeCriminalState : ActionParams
	{
		// Token: 0x0600BEF5 RID: 48885 RVA: 0x001B7494 File Offset: 0x001B5694
		private SheriffChangeCriminalState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SheriffChangeCriminalState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SheriffChangeCriminalState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SheriffChangeCriminalState_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEF6 RID: 48886 RVA: 0x001B74CC File Offset: 0x001B56CC
		public static SheriffChangeCriminalState Create([Nullable(2)] SheriffChangeCriminalState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffChangeCriminalState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEF7 RID: 48887 RVA: 0x001B74DF File Offset: 0x001B56DF
		public static SheriffChangeCriminalState CreateFromSetValue([Nullable(2)] SheriffChangeCriminalState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SheriffChangeCriminalState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x001B74F2 File Offset: 0x001B56F2
		public SheriffChangeCriminalState_SetValue ToSetValue()
		{
			return new SheriffChangeCriminalState_SetValue
			{
				CriminalId = this.CriminalId,
				CriminalState = this.CriminalState
			};
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x0600BEF9 RID: 48889 RVA: 0x001B7511 File Offset: 0x001B5711
		// (set) Token: 0x0600BEFA RID: 48890 RVA: 0x001B753C File Offset: 0x001B573C
		public virtual int CriminalId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CriminalId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CriminalId;
			}
			set
			{
				this.GetOrCreatePoco().CriminalId = value;
			}
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x0600BEFB RID: 48891 RVA: 0x001B754A File Offset: 0x001B574A
		// (set) Token: 0x0600BEFC RID: 48892 RVA: 0x001B7575 File Offset: 0x001B5775
		public virtual ESheriffCriminalState CriminalState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CriminalState;
				}
				if (this.PocoInterface == null)
				{
					return (ESheriffCriminalState)0;
				}
				return this.PocoInterface.CriminalState;
			}
			set
			{
				this.GetOrCreatePoco().CriminalState = value;
			}
		}

		// Token: 0x040071DF RID: 29151
		[Nullable(2)]
		protected new SheriffChangeCriminalState FbInstance;

		// Token: 0x040071E0 RID: 29152
		[Nullable(2)]
		protected SheriffChangeCriminalState_SetValue PocoInterface;
	}
}
