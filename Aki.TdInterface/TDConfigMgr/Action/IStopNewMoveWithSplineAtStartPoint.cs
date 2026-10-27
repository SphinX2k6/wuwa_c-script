using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EC7 RID: 7879
	[NullableContext(1)]
	[Nullable(0)]
	public class IStopNewMoveWithSplineAtStartPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600A8A4 RID: 43172 RVA: 0x0017CAE4 File Offset: 0x0017ACE4
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

		// Token: 0x0600A8A5 RID: 43173 RVA: 0x0017CB1C File Offset: 0x0017AD1C
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

		// Token: 0x0600A8A6 RID: 43174 RVA: 0x0017CB2F File Offset: 0x0017AD2F
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

		// Token: 0x0600A8A7 RID: 43175 RVA: 0x0017CB42 File Offset: 0x0017AD42
		public new IStopNewMoveWithSplineAtStartPoint_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineAtStartPoint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600A8A8 RID: 43176 RVA: 0x0017CB55 File Offset: 0x0017AD55
		// (set) Token: 0x0600A8A9 RID: 43177 RVA: 0x0017CB80 File Offset: 0x0017AD80
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

		// Token: 0x04006472 RID: 25714
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtStartPoint FbInstance;

		// Token: 0x04006473 RID: 25715
		[Nullable(2)]
		protected new IStopNewMoveWithSplineAtStartPoint_SetValue PocoInterface;
	}
}
