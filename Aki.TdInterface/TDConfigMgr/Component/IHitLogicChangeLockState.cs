using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000424 RID: 1060
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeLockState : IHitLogicType
	{
		// Token: 0x06001561 RID: 5473 RVA: 0x00043184 File Offset: 0x00041384
		private IHitLogicChangeLockState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicChangeLockState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicChangeLockState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicChangeLockState_SetValue());
			}
			return result;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000431BC File Offset: 0x000413BC
		public static IHitLogicChangeLockState Create([Nullable(2)] IHitLogicChangeLockState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeLockState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x000431CF File Offset: 0x000413CF
		public static IHitLogicChangeLockState CreateFromSetValue([Nullable(2)] IHitLogicChangeLockState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicChangeLockState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000431E2 File Offset: 0x000413E2
		public new IHitLogicChangeLockState_SetValue ToSetValue()
		{
			return new IHitLogicChangeLockState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x000431F5 File Offset: 0x000413F5
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x00043220 File Offset: 0x00041420
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

		// Token: 0x0400108D RID: 4237
		[Nullable(2)]
		protected new IHitLogicChangeLockState FbInstance;

		// Token: 0x0400108E RID: 4238
		[Nullable(2)]
		protected new IHitLogicChangeLockState_SetValue PocoInterface;
	}
}
