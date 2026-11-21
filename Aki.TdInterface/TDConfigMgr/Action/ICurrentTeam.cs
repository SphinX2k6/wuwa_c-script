using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ACD RID: 6861
	public class ICurrentTeam : ITeamType
	{
		// Token: 0x060091CB RID: 37323 RVA: 0x00155FCC File Offset: 0x001541CC
		private ICurrentTeam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICurrentTeam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICurrentTeam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICurrentTeam_SetValue());
			}
			return result;
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x00156004 File Offset: 0x00154204
		public static ICurrentTeam Create([Nullable(2)] ICurrentTeam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICurrentTeam
			{
				FbInstance = instance
			};
		}

		// Token: 0x060091CD RID: 37325 RVA: 0x00156017 File Offset: 0x00154217
		public static ICurrentTeam CreateFromSetValue([Nullable(2)] ICurrentTeam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICurrentTeam
			{
				PocoInterface = value
			};
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x0015602A File Offset: 0x0015422A
		public new ICurrentTeam_SetValue ToSetValue()
		{
			return new ICurrentTeam_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x060091CF RID: 37327 RVA: 0x0015603D File Offset: 0x0015423D
		// (set) Token: 0x060091D0 RID: 37328 RVA: 0x00156068 File Offset: 0x00154268
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

		// Token: 0x04005AED RID: 23277
		[Nullable(2)]
		protected new ICurrentTeam FbInstance;

		// Token: 0x04005AEE RID: 23278
		[Nullable(2)]
		protected new ICurrentTeam_SetValue PocoInterface;
	}
}
