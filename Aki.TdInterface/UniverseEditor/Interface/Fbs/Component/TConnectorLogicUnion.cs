using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BFB RID: 23547
	public class TConnectorLogicUnion
	{
		// Token: 0x1700B1D5 RID: 45525
		// (get) Token: 0x06028655 RID: 165461 RVA: 0x0058F9D7 File Offset: 0x0058DBD7
		// (set) Token: 0x06028656 RID: 165462 RVA: 0x0058F9DF File Offset: 0x0058DBDF
		public TConnectorLogic Type { get; set; }

		// Token: 0x1700B1D6 RID: 45526
		// (get) Token: 0x06028657 RID: 165463 RVA: 0x0058F9E8 File Offset: 0x0058DBE8
		// (set) Token: 0x06028658 RID: 165464 RVA: 0x0058F9F0 File Offset: 0x0058DBF0
		public object Value { get; set; }

		// Token: 0x06028659 RID: 165465 RVA: 0x0058F9F9 File Offset: 0x0058DBF9
		public TConnectorLogicUnion()
		{
			this.Type = TConnectorLogic.NONE;
			this.Value = null;
		}

		// Token: 0x0602865A RID: 165466 RVA: 0x0058FA0F File Offset: 0x0058DC0F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602865B RID: 165467 RVA: 0x0058FA21 File Offset: 0x0058DC21
		public IConnectorPointToPointPathAdvanceT AsIConnectorPointToPointPathAdvance()
		{
			return this.As<IConnectorPointToPointPathAdvanceT>();
		}

		// Token: 0x0602865C RID: 165468 RVA: 0x0058FA29 File Offset: 0x0058DC29
		public static TConnectorLogicUnion FromIConnectorPointToPointPathAdvance(IConnectorPointToPointPathAdvanceT _iconnectorpointtopointpathadvance)
		{
			return new TConnectorLogicUnion
			{
				Type = TConnectorLogic.IConnectorPointToPointPathAdvance,
				Value = _iconnectorpointtopointpathadvance
			};
		}

		// Token: 0x0602865D RID: 165469 RVA: 0x0058FA3E File Offset: 0x0058DC3E
		public IConnectorRangeT AsIConnectorRange()
		{
			return this.As<IConnectorRangeT>();
		}

		// Token: 0x0602865E RID: 165470 RVA: 0x0058FA46 File Offset: 0x0058DC46
		public static TConnectorLogicUnion FromIConnectorRange(IConnectorRangeT _iconnectorrange)
		{
			return new TConnectorLogicUnion
			{
				Type = TConnectorLogic.IConnectorRange,
				Value = _iconnectorrange
			};
		}

		// Token: 0x0602865F RID: 165471 RVA: 0x0058FA5C File Offset: 0x0058DC5C
		public static int Pack(FlatBufferBuilder builder, TConnectorLogicUnion _o)
		{
			TConnectorLogic type = _o.Type;
			if (type == TConnectorLogic.IConnectorPointToPointPathAdvance)
			{
				return IConnectorPointToPointPathAdvance.Pack(builder, _o.AsIConnectorPointToPointPathAdvance()).Value;
			}
			if (type != TConnectorLogic.IConnectorRange)
			{
				return 0;
			}
			return IConnectorRange.Pack(builder, _o.AsIConnectorRange()).Value;
		}
	}
}
