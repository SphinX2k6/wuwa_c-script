using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001955 RID: 6485
	public class IAirPassageMoveLimit
	{
		// Token: 0x060089F1 RID: 35313 RVA: 0x00148418 File Offset: 0x00146618
		private IAirPassageMoveLimit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAirPassageMoveLimit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAirPassageMoveLimit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAirPassageMoveLimit_SetValue());
			}
			return result;
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x00148450 File Offset: 0x00146650
		public static IAirPassageMoveLimit Create([Nullable(2)] IAirPassageMoveLimit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirPassageMoveLimit
			{
				FbInstance = instance
			};
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x00148463 File Offset: 0x00146663
		public static IAirPassageMoveLimit CreateFromSetValue([Nullable(2)] IAirPassageMoveLimit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAirPassageMoveLimit
			{
				PocoInterface = value
			};
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x00148476 File Offset: 0x00146676
		public IAirPassageMoveLimit_SetValue ToSetValue()
		{
			return new IAirPassageMoveLimit_SetValue
			{
				DirectionAngleLimit = this.DirectionAngleLimit,
				EdgeLimitCurveFactor = this.EdgeLimitCurveFactor
			};
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x060089F5 RID: 35317 RVA: 0x00148495 File Offset: 0x00146695
		// (set) Token: 0x060089F6 RID: 35318 RVA: 0x001484C4 File Offset: 0x001466C4
		public virtual float DirectionAngleLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DirectionAngleLimit;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DirectionAngleLimit;
			}
			set
			{
				this.GetOrCreatePoco().DirectionAngleLimit = value;
			}
		}

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x060089F7 RID: 35319 RVA: 0x001484D2 File Offset: 0x001466D2
		// (set) Token: 0x060089F8 RID: 35320 RVA: 0x00148501 File Offset: 0x00146701
		public virtual float EdgeLimitCurveFactor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EdgeLimitCurveFactor;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.EdgeLimitCurveFactor;
			}
			set
			{
				this.GetOrCreatePoco().EdgeLimitCurveFactor = value;
			}
		}

		// Token: 0x0400576E RID: 22382
		[Nullable(2)]
		protected IAirPassageMoveLimit FbInstance;

		// Token: 0x0400576F RID: 22383
		[Nullable(2)]
		protected IAirPassageMoveLimit_SetValue PocoInterface;
	}
}
