using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EC5 RID: 7877
	[NullableContext(1)]
	[Nullable(0)]
	public class IStopNewMoveWithSplineAtEndPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600A89C RID: 43164 RVA: 0x0017CA28 File Offset: 0x0017AC28
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

		// Token: 0x0600A89D RID: 43165 RVA: 0x0017CA60 File Offset: 0x0017AC60
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

		// Token: 0x0600A89E RID: 43166 RVA: 0x0017CA73 File Offset: 0x0017AC73
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

		// Token: 0x0600A89F RID: 43167 RVA: 0x0017CA86 File Offset: 0x0017AC86
		public new IStopNewMoveWithSplineAtEndPoint_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineAtEndPoint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600A8A0 RID: 43168 RVA: 0x0017CA99 File Offset: 0x0017AC99
		// (set) Token: 0x0600A8A1 RID: 43169 RVA: 0x0017CAC4 File Offset: 0x0017ACC4
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

		// Token: 0x0400646F RID: 25711
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtEndPoint FbInstance;

		// Token: 0x04006470 RID: 25712
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtEndPoint_SetValue PocoInterface;
	}
}
