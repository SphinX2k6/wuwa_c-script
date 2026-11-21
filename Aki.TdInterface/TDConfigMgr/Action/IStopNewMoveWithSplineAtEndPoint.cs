using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020FE RID: 8446
	public class IStopNewMoveWithSplineAtEndPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600B36E RID: 45934 RVA: 0x00192A20 File Offset: 0x00190C20
		private IStopNewMoveWithSplineAtEndPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStopNewMoveWithSplineAtEndPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStopNewMoveWithSplineAtEndPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStopNewMoveWithSplineAtEndPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600B36F RID: 45935 RVA: 0x00192A58 File Offset: 0x00190C58
		public static IStopNewMoveWithSplineAtEndPoint Create([Nullable(2)] IStopNewMoveWithSplineAtEndPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtEndPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B370 RID: 45936 RVA: 0x00192A6B File Offset: 0x00190C6B
		public static IStopNewMoveWithSplineAtEndPoint CreateFromSetValue([Nullable(2)] IStopNewMoveWithSplineAtEndPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtEndPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B371 RID: 45937 RVA: 0x00192A7E File Offset: 0x00190C7E
		public new IStopNewMoveWithSplineAtEndPoint_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineAtEndPoint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600B372 RID: 45938 RVA: 0x00192A91 File Offset: 0x00190C91
		// (set) Token: 0x0600B373 RID: 45939 RVA: 0x00192ABC File Offset: 0x00190CBC
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

		// Token: 0x04006A5E RID: 27230
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtEndPoint FbInstance;

		// Token: 0x04006A5F RID: 27231
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtEndPoint_SetValue PocoInterface;
	}
}
