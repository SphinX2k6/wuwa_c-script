using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D08 RID: 7432
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x06009F7F RID: 40831 RVA: 0x0016C510 File Offset: 0x0016A710
		private IPlayerNewSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerNewSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerNewSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerNewSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x0016C548 File Offset: 0x0016A748
		public static IPlayerNewSplineStopTarget Create([Nullable(2)] IPlayerNewSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerNewSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x0016C55B File Offset: 0x0016A75B
		public static IPlayerNewSplineStopTarget CreateFromSetValue([Nullable(2)] IPlayerNewSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerNewSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x0016C56E File Offset: 0x0016A76E
		public new IPlayerNewSplineStopTarget_SetValue ToSetValue()
		{
			return new IPlayerNewSplineStopTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x06009F83 RID: 40835 RVA: 0x0016C581 File Offset: 0x0016A781
		// (set) Token: 0x06009F84 RID: 40836 RVA: 0x0016C5AC File Offset: 0x0016A7AC
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006041 RID: 24641
		[Nullable(2)]
		protected new IPlayerNewSplineStopTarget FbInstance;

		// Token: 0x04006042 RID: 24642
		[Nullable(2)]
		protected new IPlayerNewSplineStopTarget_SetValue PocoInterface;
	}
}
