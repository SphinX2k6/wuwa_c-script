using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A4B RID: 6731
	public class IClientFollowShooterResetToPlayer : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x06008F17 RID: 36631 RVA: 0x00151674 File Offset: 0x0014F874
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

		// Token: 0x06008F18 RID: 36632 RVA: 0x001516AC File Offset: 0x0014F8AC
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

		// Token: 0x06008F19 RID: 36633 RVA: 0x001516BF File Offset: 0x0014F8BF
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

		// Token: 0x06008F1A RID: 36634 RVA: 0x001516D2 File Offset: 0x0014F8D2
		public new IClientFollowShooterResetToPlayer_SetValue ToSetValue()
		{
			return new IClientFollowShooterResetToPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x06008F1B RID: 36635 RVA: 0x001516E5 File Offset: 0x0014F8E5
		// (set) Token: 0x06008F1C RID: 36636 RVA: 0x00151710 File Offset: 0x0014F910
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
					return EClientFollowShooterLeisureInteractType.PlayAnimation;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040059C2 RID: 22978
		[Nullable(2)]
		protected new IClientFollowShooterResetToPlayer FbInstance;

		// Token: 0x040059C3 RID: 22979
		[Nullable(2)]
		protected new IClientFollowShooterResetToPlayer_SetValue PocoInterface;
	}
}
