using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018BC RID: 6332
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientFollowShooterResetToPlayer : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x060087DD RID: 34781 RVA: 0x00141C84 File Offset: 0x0013FE84
		private IClientFollowShooterResetToPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientFollowShooterResetToPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientFollowShooterResetToPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientFollowShooterResetToPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x00141CBC File Offset: 0x0013FEBC
		public static IClientFollowShooterResetToPlayer Create([Nullable(2)] IClientFollowShooterResetToPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterResetToPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x060087DF RID: 34783 RVA: 0x00141CCF File Offset: 0x0013FECF
		public static IClientFollowShooterResetToPlayer CreateFromSetValue([Nullable(2)] IClientFollowShooterResetToPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientFollowShooterResetToPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x00141CE2 File Offset: 0x0013FEE2
		public new IClientFollowShooterResetToPlayer_SetValue ToSetValue()
		{
			return new IClientFollowShooterResetToPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x060087E1 RID: 34785 RVA: 0x00141CF5 File Offset: 0x0013FEF5
		// (set) Token: 0x060087E2 RID: 34786 RVA: 0x00141D20 File Offset: 0x0013FF20
		public override EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400556E RID: 21870
		[Nullable(2)]
		protected new IClientFollowShooterResetToPlayer FbInstance;

		// Token: 0x0400556F RID: 21871
		[Nullable(2)]
		protected new IClientFollowShooterResetToPlayer_SetValue PocoInterface;
	}
}
