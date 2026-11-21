using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C4E RID: 7246
	public class IFollowShooterLeaveThrowInteractionPoint : IFollowShooterLeisureInteractType
	{
		// Token: 0x06009A1C RID: 39452 RVA: 0x00164DC4 File Offset: 0x00162FC4
		private IFollowShooterLeaveThrowInteractionPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowShooterLeaveThrowInteractionPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowShooterLeaveThrowInteractionPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowShooterLeaveThrowInteractionPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06009A1D RID: 39453 RVA: 0x00164DFC File Offset: 0x00162FFC
		public static IFollowShooterLeaveThrowInteractionPoint Create([Nullable(2)] IFollowShooterLeaveThrowInteractionPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterLeaveThrowInteractionPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A1E RID: 39454 RVA: 0x00164E0F File Offset: 0x0016300F
		public static IFollowShooterLeaveThrowInteractionPoint CreateFromSetValue([Nullable(2)] IFollowShooterLeaveThrowInteractionPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowShooterLeaveThrowInteractionPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A1F RID: 39455 RVA: 0x00164E22 File Offset: 0x00163022
		public new IFollowShooterLeaveThrowInteractionPoint_SetValue ToSetValue()
		{
			return new IFollowShooterLeaveThrowInteractionPoint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x06009A20 RID: 39456 RVA: 0x00164E35 File Offset: 0x00163035
		// (set) Token: 0x06009A21 RID: 39457 RVA: 0x00164E60 File Offset: 0x00163060
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

		// Token: 0x04005EAF RID: 24239
		[Nullable(2)]
		protected new IFollowShooterLeaveThrowInteractionPoint FbInstance;

		// Token: 0x04005EB0 RID: 24240
		[Nullable(2)]
		protected new IFollowShooterLeaveThrowInteractionPoint_SetValue PocoInterface;
	}
}
