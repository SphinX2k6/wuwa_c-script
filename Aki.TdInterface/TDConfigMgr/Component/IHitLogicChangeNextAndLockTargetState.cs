using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200047F RID: 1151
	public class IHitLogicChangeNextAndLockTargetState : IHitLogicType
	{
		// Token: 0x06001703 RID: 5891 RVA: 0x00046F88 File Offset: 0x00045188
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

		// Token: 0x06001704 RID: 5892 RVA: 0x00046FC0 File Offset: 0x000451C0
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

		// Token: 0x06001705 RID: 5893 RVA: 0x00046FD3 File Offset: 0x000451D3
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

		// Token: 0x06001706 RID: 5894 RVA: 0x00046FE6 File Offset: 0x000451E6
		public new IHitLogicChangeNextAndLockTargetState_SetValue ToSetValue()
		{
			return new IHitLogicChangeNextAndLockTargetState_SetValue
			{
				Type = this.Type,
				TargetState = this.TargetState
			};
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00047005 File Offset: 0x00045205
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x00047030 File Offset: 0x00045230
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

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x0004703E File Offset: 0x0004523E
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00047069 File Offset: 0x00045269
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

		// Token: 0x040011B2 RID: 4530
		[Nullable(2)]
		protected new IHitLogicChangeNextAndLockTargetState FbInstance;

		// Token: 0x040011B3 RID: 4531
		[Nullable(2)]
		protected new IHitLogicChangeNextAndLockTargetState_SetValue PocoInterface;
	}
}
