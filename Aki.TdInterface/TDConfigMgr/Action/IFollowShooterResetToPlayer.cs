using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C52 RID: 7250
	public class IFollowShooterResetToPlayer : IFollowShooterLeisureInteractType
	{
		// Token: 0x06009A2C RID: 39468 RVA: 0x00164F3C File Offset: 0x0016313C
		private IFollowShooterResetToPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowShooterResetToPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowShooterResetToPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowShooterResetToPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x00164F74 File Offset: 0x00163174
		public static IFollowShooterResetToPlayer Create([Nullable(2)] IFollowShooterResetToPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterResetToPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x00164F87 File Offset: 0x00163187
		public static IFollowShooterResetToPlayer CreateFromSetValue([Nullable(2)] IFollowShooterResetToPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowShooterResetToPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x00164F9A File Offset: 0x0016319A
		public new IFollowShooterResetToPlayer_SetValue ToSetValue()
		{
			return new IFollowShooterResetToPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x06009A30 RID: 39472 RVA: 0x00164FAD File Offset: 0x001631AD
		// (set) Token: 0x06009A31 RID: 39473 RVA: 0x00164FD8 File Offset: 0x001631D8
		public override EFollowShooterLeisureInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005EB5 RID: 24245
		[Nullable(2)]
		protected new IFollowShooterResetToPlayer FbInstance;

		// Token: 0x04005EB6 RID: 24246
		[Nullable(2)]
		protected new IFollowShooterResetToPlayer_SetValue PocoInterface;
	}
}
