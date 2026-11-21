using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000481 RID: 1153
	public class IHitLogicChangeNextState : IHitLogicType
	{
		// Token: 0x0600170D RID: 5901 RVA: 0x00047088 File Offset: 0x00045288
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

		// Token: 0x0600170E RID: 5902 RVA: 0x000470C0 File Offset: 0x000452C0
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

		// Token: 0x0600170F RID: 5903 RVA: 0x000470D3 File Offset: 0x000452D3
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

		// Token: 0x06001710 RID: 5904 RVA: 0x000470E6 File Offset: 0x000452E6
		public new IHitLogicChangeNextState_SetValue ToSetValue()
		{
			return new IHitLogicChangeNextState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x000470F9 File Offset: 0x000452F9
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x00047124 File Offset: 0x00045324
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

		// Token: 0x040011B6 RID: 4534
		[Nullable(2)]
		protected new IHitLogicChangeNextState FbInstance;

		// Token: 0x040011B7 RID: 4535
		[Nullable(2)]
		protected new IHitLogicChangeNextState_SetValue PocoInterface;
	}
}
