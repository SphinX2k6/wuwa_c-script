using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000422 RID: 1058
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeCountDownState : IHitLogicType
	{
		// Token: 0x06001559 RID: 5465 RVA: 0x000430C8 File Offset: 0x000412C8
		private IHitLogicChangeCountDownState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicChangeCountDownState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicChangeCountDownState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicChangeCountDownState_SetValue());
			}
			return result;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00043100 File Offset: 0x00041300
		public static IHitLogicChangeCountDownState Create([Nullable(2)] IHitLogicChangeCountDownState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeCountDownState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00043113 File Offset: 0x00041313
		public static IHitLogicChangeCountDownState CreateFromSetValue([Nullable(2)] IHitLogicChangeCountDownState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicChangeCountDownState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00043126 File Offset: 0x00041326
		public new IHitLogicChangeCountDownState_SetValue ToSetValue()
		{
			return new IHitLogicChangeCountDownState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x00043139 File Offset: 0x00041339
		// (set) Token: 0x0600155E RID: 5470 RVA: 0x00043164 File Offset: 0x00041364
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

		// Token: 0x0400108A RID: 4234
		[Nullable(2)]
		protected new IHitLogicChangeCountDownState FbInstance;

		// Token: 0x0400108B RID: 4235
		[Nullable(2)]
		protected new IHitLogicChangeCountDownState_SetValue PocoInterface;
	}
}
