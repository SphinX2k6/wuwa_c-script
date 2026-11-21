using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C32 RID: 7218
	public class IFlowTeam : ITeamType
	{
		// Token: 0x0600998C RID: 39308 RVA: 0x00163DE8 File Offset: 0x00161FE8
		private IFlowTeam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowTeam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowTeam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowTeam_SetValue());
			}
			return result;
		}

		// Token: 0x0600998D RID: 39309 RVA: 0x00163E20 File Offset: 0x00162020
		public static IFlowTeam Create([Nullable(2)] IFlowTeam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTeam
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600998E RID: 39310 RVA: 0x00163E33 File Offset: 0x00162033
		public static IFlowTeam CreateFromSetValue([Nullable(2)] IFlowTeam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowTeam
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600998F RID: 39311 RVA: 0x00163E46 File Offset: 0x00162046
		public new IFlowTeam_SetValue ToSetValue()
		{
			return new IFlowTeam_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x06009990 RID: 39312 RVA: 0x00163E59 File Offset: 0x00162059
		// (set) Token: 0x06009991 RID: 39313 RVA: 0x00163E84 File Offset: 0x00162084
		public override ETeamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeamType.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005E6D RID: 24173
		[Nullable(2)]
		protected new IFlowTeam FbInstance;

		// Token: 0x04005E6E RID: 24174
		[Nullable(2)]
		protected new IFlowTeam_SetValue PocoInterface;
	}
}
