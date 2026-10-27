using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EC9 RID: 7881
	[NullableContext(1)]
	[Nullable(0)]
	public class IStopNewMoveWithSplineAtTargetPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600A8AC RID: 43180 RVA: 0x0017CBA0 File Offset: 0x0017ADA0
		private IStopNewMoveWithSplineAtTargetPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStopNewMoveWithSplineAtTargetPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStopNewMoveWithSplineAtTargetPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStopNewMoveWithSplineAtTargetPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8AD RID: 43181 RVA: 0x0017CBD8 File Offset: 0x0017ADD8
		public static IStopNewMoveWithSplineAtTargetPoint Create([Nullable(2)] IStopNewMoveWithSplineAtTargetPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtTargetPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8AE RID: 43182 RVA: 0x0017CBEB File Offset: 0x0017ADEB
		public static IStopNewMoveWithSplineAtTargetPoint CreateFromSetValue([Nullable(2)] IStopNewMoveWithSplineAtTargetPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtTargetPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x0017CBFE File Offset: 0x0017ADFE
		public new IStopNewMoveWithSplineAtTargetPoint_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineAtTargetPoint_SetValue
			{
				Type = this.Type,
				PointId = this.PointId
			};
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600A8B0 RID: 43184 RVA: 0x0017CC1D File Offset: 0x0017AE1D
		// (set) Token: 0x0600A8B1 RID: 43185 RVA: 0x0017CC48 File Offset: 0x0017AE48
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStopNewMoveWithSplineType.StopAtCurrentPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600A8B2 RID: 43186 RVA: 0x0017CC56 File Offset: 0x0017AE56
		// (set) Token: 0x0600A8B3 RID: 43187 RVA: 0x0017CC81 File Offset: 0x0017AE81
		public virtual int PointId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PointId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PointId;
			}
			set
			{
				this.GetOrCreatePoco().PointId = value;
			}
		}

		// Token: 0x04006475 RID: 25717
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtTargetPoint FbInstance;

		// Token: 0x04006476 RID: 25718
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtTargetPoint_SetValue PocoInterface;
	}
}
