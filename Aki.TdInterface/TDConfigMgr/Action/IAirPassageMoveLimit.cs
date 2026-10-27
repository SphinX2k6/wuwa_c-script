using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017CE RID: 6094
	[NullableContext(1)]
	[Nullable(0)]
	public class IAirPassageMoveLimit
	{
		// Token: 0x060082DF RID: 33503 RVA: 0x00138E30 File Offset: 0x00137030
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

		// Token: 0x060082E0 RID: 33504 RVA: 0x00138E68 File Offset: 0x00137068
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

		// Token: 0x060082E1 RID: 33505 RVA: 0x00138E7B File Offset: 0x0013707B
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

		// Token: 0x060082E2 RID: 33506 RVA: 0x00138E8E File Offset: 0x0013708E
		public IAirPassageMoveLimit_SetValue ToSetValue()
		{
			return new IAirPassageMoveLimit_SetValue
			{
				DirectionAngleLimit = this.DirectionAngleLimit,
				EdgeLimitCurveFactor = this.EdgeLimitCurveFactor
			};
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x060082E3 RID: 33507 RVA: 0x00138EAD File Offset: 0x001370AD
		// (set) Token: 0x060082E4 RID: 33508 RVA: 0x00138EDC File Offset: 0x001370DC
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

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x060082E5 RID: 33509 RVA: 0x00138EEA File Offset: 0x001370EA
		// (set) Token: 0x060082E6 RID: 33510 RVA: 0x00138F19 File Offset: 0x00137119
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

		// Token: 0x0400532A RID: 21290
		[Nullable(2)]
		protected IAirPassageMoveLimit FbInstance;

		// Token: 0x0400532B RID: 21291
		[Nullable(2)]
		protected IAirPassageMoveLimit_SetValue PocoInterface;
	}
}
