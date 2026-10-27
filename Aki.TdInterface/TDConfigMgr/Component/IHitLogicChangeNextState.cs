using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000428 RID: 1064
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeNextState : IHitLogicType
	{
		// Token: 0x06001573 RID: 5491 RVA: 0x00043340 File Offset: 0x00041540
		private IHitLogicChangeNextState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicChangeNextState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicChangeNextState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicChangeNextState_SetValue());
			}
			return result;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00043378 File Offset: 0x00041578
		public static IHitLogicChangeNextState Create([Nullable(2)] IHitLogicChangeNextState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeNextState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0004338B File Offset: 0x0004158B
		public static IHitLogicChangeNextState CreateFromSetValue([Nullable(2)] IHitLogicChangeNextState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicChangeNextState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0004339E File Offset: 0x0004159E
		public new IHitLogicChangeNextState_SetValue ToSetValue()
		{
			return new IHitLogicChangeNextState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x000433B1 File Offset: 0x000415B1
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x000433DC File Offset: 0x000415DC
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

		// Token: 0x04001094 RID: 4244
		[Nullable(2)]
		protected new IHitLogicChangeNextState FbInstance;

		// Token: 0x04001095 RID: 4245
		[Nullable(2)]
		protected new IHitLogicChangeNextState_SetValue PocoInterface;
	}
}
