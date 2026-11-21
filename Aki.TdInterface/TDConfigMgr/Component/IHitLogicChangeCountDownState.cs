using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200047B RID: 1147
	public class IHitLogicChangeCountDownState : IHitLogicType
	{
		// Token: 0x060016F3 RID: 5875 RVA: 0x00046E10 File Offset: 0x00045010
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

		// Token: 0x060016F4 RID: 5876 RVA: 0x00046E48 File Offset: 0x00045048
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

		// Token: 0x060016F5 RID: 5877 RVA: 0x00046E5B File Offset: 0x0004505B
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

		// Token: 0x060016F6 RID: 5878 RVA: 0x00046E6E File Offset: 0x0004506E
		public new IHitLogicChangeCountDownState_SetValue ToSetValue()
		{
			return new IHitLogicChangeCountDownState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x00046E81 File Offset: 0x00045081
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x00046EAC File Offset: 0x000450AC
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

		// Token: 0x040011AC RID: 4524
		[Nullable(2)]
		protected new IHitLogicChangeCountDownState FbInstance;

		// Token: 0x040011AD RID: 4525
		[Nullable(2)]
		protected new IHitLogicChangeCountDownState_SetValue PocoInterface;
	}
}
