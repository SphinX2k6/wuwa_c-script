using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200621A RID: 25114
	public class TConnectorLogicUnion
	{
		// Token: 0x1700BB23 RID: 47907
		// (get) Token: 0x0602AC45 RID: 175173 RVA: 0x005D791F File Offset: 0x005D5B1F
		// (set) Token: 0x0602AC46 RID: 175174 RVA: 0x005D7927 File Offset: 0x005D5B27
		public TConnectorLogic Type { get; set; }

		// Token: 0x1700BB24 RID: 47908
		// (get) Token: 0x0602AC47 RID: 175175 RVA: 0x005D7930 File Offset: 0x005D5B30
		// (set) Token: 0x0602AC48 RID: 175176 RVA: 0x005D7938 File Offset: 0x005D5B38
		public object Value { get; set; }

		// Token: 0x0602AC49 RID: 175177 RVA: 0x005D7941 File Offset: 0x005D5B41
		public TConnectorLogicUnion()
		{
			this.Type = TConnectorLogic.NONE;
			this.Value = null;
		}

		// Token: 0x0602AC4A RID: 175178 RVA: 0x005D7957 File Offset: 0x005D5B57
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AC4B RID: 175179 RVA: 0x005D7969 File Offset: 0x005D5B69
		public IConnectorPointToPointPathAdvanceT AsIConnectorPointToPointPathAdvance()
		{
			return this.As<IConnectorPointToPointPathAdvanceT>();
		}

		// Token: 0x0602AC4C RID: 175180 RVA: 0x005D7971 File Offset: 0x005D5B71
		public static TConnectorLogicUnion FromIConnectorPointToPointPathAdvance(IConnectorPointToPointPathAdvanceT _iconnectorpointtopointpathadvance)
		{
			return new TConnectorLogicUnion
			{
				Type = TConnectorLogic.IConnectorPointToPointPathAdvance,
				Value = _iconnectorpointtopointpathadvance
			};
		}

		// Token: 0x0602AC4D RID: 175181 RVA: 0x005D7986 File Offset: 0x005D5B86
		public IConnectorRangeT AsIConnectorRange()
		{
			return this.As<IConnectorRangeT>();
		}

		// Token: 0x0602AC4E RID: 175182 RVA: 0x005D798E File Offset: 0x005D5B8E
		public static TConnectorLogicUnion FromIConnectorRange(IConnectorRangeT _iconnectorrange)
		{
			return new TConnectorLogicUnion
			{
				Type = TConnectorLogic.IConnectorRange,
				Value = _iconnectorrange
			};
		}

		// Token: 0x0602AC4F RID: 175183 RVA: 0x005D79A4 File Offset: 0x005D5BA4
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
