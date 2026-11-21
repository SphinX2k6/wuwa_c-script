using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001991 RID: 6545
	public class IBattleTeam : ITeamType
	{
		// Token: 0x06008B2D RID: 35629 RVA: 0x0014A504 File Offset: 0x00148704
		private IBattleTeam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBattleTeam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBattleTeam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBattleTeam_SetValue());
			}
			return result;
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x0014A53C File Offset: 0x0014873C
		public static IBattleTeam Create([Nullable(2)] IBattleTeam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleTeam
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B2F RID: 35631 RVA: 0x0014A54F File Offset: 0x0014874F
		public static IBattleTeam CreateFromSetValue([Nullable(2)] IBattleTeam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBattleTeam
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B30 RID: 35632 RVA: 0x0014A562 File Offset: 0x00148762
		public new IBattleTeam_SetValue ToSetValue()
		{
			return new IBattleTeam_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x06008B31 RID: 35633 RVA: 0x0014A575 File Offset: 0x00148775
		// (set) Token: 0x06008B32 RID: 35634 RVA: 0x0014A5A0 File Offset: 0x001487A0
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

		// Token: 0x040057F0 RID: 22512
		[Nullable(2)]
		protected new IBattleTeam FbInstance;

		// Token: 0x040057F1 RID: 22513
		[Nullable(2)]
		protected new IBattleTeam_SetValue PocoInterface;
	}
}
