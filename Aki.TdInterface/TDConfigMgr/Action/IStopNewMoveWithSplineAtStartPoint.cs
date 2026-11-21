using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002100 RID: 8448
	public class IStopNewMoveWithSplineAtStartPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600B376 RID: 45942 RVA: 0x00192ADC File Offset: 0x00190CDC
		private IStopNewMoveWithSplineAtStartPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStopNewMoveWithSplineAtStartPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStopNewMoveWithSplineAtStartPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStopNewMoveWithSplineAtStartPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x00192B14 File Offset: 0x00190D14
		public static IStopNewMoveWithSplineAtStartPoint Create([Nullable(2)] IStopNewMoveWithSplineAtStartPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtStartPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x00192B27 File Offset: 0x00190D27
		public static IStopNewMoveWithSplineAtStartPoint CreateFromSetValue([Nullable(2)] IStopNewMoveWithSplineAtStartPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtStartPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B379 RID: 45945 RVA: 0x00192B3A File Offset: 0x00190D3A
		public new IStopNewMoveWithSplineAtStartPoint_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineAtStartPoint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600B37A RID: 45946 RVA: 0x00192B4D File Offset: 0x00190D4D
		// (set) Token: 0x0600B37B RID: 45947 RVA: 0x00192B78 File Offset: 0x00190D78
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

		// Token: 0x04006A61 RID: 27233
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtStartPoint FbInstance;

		// Token: 0x04006A62 RID: 27234
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtStartPoint_SetValue PocoInterface;
	}
}
