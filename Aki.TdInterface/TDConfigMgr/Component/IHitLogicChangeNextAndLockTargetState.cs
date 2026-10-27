using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000426 RID: 1062
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeNextAndLockTargetState : IHitLogicType
	{
		// Token: 0x06001569 RID: 5481 RVA: 0x00043240 File Offset: 0x00041440
		private IHitLogicChangeNextAndLockTargetState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicChangeNextAndLockTargetState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicChangeNextAndLockTargetState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicChangeNextAndLockTargetState_SetValue());
			}
			return result;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00043278 File Offset: 0x00041478
		public static IHitLogicChangeNextAndLockTargetState Create([Nullable(2)] IHitLogicChangeNextAndLockTargetState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeNextAndLockTargetState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0004328B File Offset: 0x0004148B
		public static IHitLogicChangeNextAndLockTargetState CreateFromSetValue([Nullable(2)] IHitLogicChangeNextAndLockTargetState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicChangeNextAndLockTargetState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0004329E File Offset: 0x0004149E
		public new IHitLogicChangeNextAndLockTargetState_SetValue ToSetValue()
		{
			return new IHitLogicChangeNextAndLockTargetState_SetValue
			{
				Type = this.Type,
				TargetState = this.TargetState
			};
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x000432BD File Offset: 0x000414BD
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x000432E8 File Offset: 0x000414E8
		public override EHitLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitLogicType.ChangeNextState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x000432F6 File Offset: 0x000414F6
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x00043321 File Offset: 0x00041521
		public virtual string TargetState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TargetState;
			}
			set
			{
				this.GetOrCreatePoco().TargetState = value;
			}
		}

		// Token: 0x04001090 RID: 4240
		[Nullable(2)]
		protected new IHitLogicChangeNextAndLockTargetState FbInstance;

		// Token: 0x04001091 RID: 4241
		[Nullable(2)]
		protected new IHitLogicChangeNextAndLockTargetState_SetValue PocoInterface;
	}
}
