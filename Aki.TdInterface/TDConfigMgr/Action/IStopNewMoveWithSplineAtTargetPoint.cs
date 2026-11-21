using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002102 RID: 8450
	public class IStopNewMoveWithSplineAtTargetPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600B37E RID: 45950 RVA: 0x00192B98 File Offset: 0x00190D98
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

		// Token: 0x0600B37F RID: 45951 RVA: 0x00192BD0 File Offset: 0x00190DD0
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

		// Token: 0x0600B380 RID: 45952 RVA: 0x00192BE3 File Offset: 0x00190DE3
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

		// Token: 0x0600B381 RID: 45953 RVA: 0x00192BF6 File Offset: 0x00190DF6
		public new IStopNewMoveWithSplineAtTargetPoint_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineAtTargetPoint_SetValue
			{
				Type = this.Type,
				PointId = this.PointId
			};
		}

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600B382 RID: 45954 RVA: 0x00192C15 File Offset: 0x00190E15
		// (set) Token: 0x0600B383 RID: 45955 RVA: 0x00192C40 File Offset: 0x00190E40
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

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600B384 RID: 45956 RVA: 0x00192C4E File Offset: 0x00190E4E
		// (set) Token: 0x0600B385 RID: 45957 RVA: 0x00192C79 File Offset: 0x00190E79
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

		// Token: 0x04006A64 RID: 27236
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtTargetPoint FbInstance;

		// Token: 0x04006A65 RID: 27237
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtTargetPoint_SetValue PocoInterface;
	}
}
