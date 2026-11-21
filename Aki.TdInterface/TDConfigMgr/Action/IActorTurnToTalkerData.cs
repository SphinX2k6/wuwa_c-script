using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001921 RID: 6433
	public class IActorTurnToTalkerData : IActorTurnToData
	{
		// Token: 0x060086F1 RID: 34545 RVA: 0x00140D04 File Offset: 0x0013EF04
		private IActorTurnToTalkerData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorTurnToTalkerData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorTurnToTalkerData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorTurnToTalkerData_SetValue());
			}
			return result;
		}

		// Token: 0x060086F2 RID: 34546 RVA: 0x00140D3C File Offset: 0x0013EF3C
		public static IActorTurnToTalkerData Create([Nullable(2)] IActorTurnToTalkerData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToTalkerData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086F3 RID: 34547 RVA: 0x00140D4F File Offset: 0x0013EF4F
		public static IActorTurnToTalkerData CreateFromSetValue([Nullable(2)] IActorTurnToTalkerData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorTurnToTalkerData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086F4 RID: 34548 RVA: 0x00140D62 File Offset: 0x0013EF62
		public new IActorTurnToTalkerData_SetValue ToSetValue()
		{
			return new IActorTurnToTalkerData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x060086F5 RID: 34549 RVA: 0x00140D75 File Offset: 0x0013EF75
		// (set) Token: 0x060086F6 RID: 34550 RVA: 0x00140DA0 File Offset: 0x0013EFA0
		public override EActorTurnToMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorTurnToMode.Talker;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400557C RID: 21884
		[Nullable(2)]
		protected new IActorTurnToTalkerData FbInstance;

		// Token: 0x0400557D RID: 21885
		[Nullable(2)]
		protected new IActorTurnToTalkerData_SetValue PocoInterface;
	}
}
