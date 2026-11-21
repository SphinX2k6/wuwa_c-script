using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FAE RID: 16302
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotResultInfo
	{
		// Token: 0x06029421 RID: 168993 RVA: 0x00B9769E File Offset: 0x00B9589E
		public PlotResultInfo()
		{
			this.FlowListName = "";
			this.FlowId = new int?(0);
			this.StateId = new int?(0);
			this.FlowIncId = new long?(0L);
			this.ResultCode = EPlotResultCode.Success;
		}

		// Token: 0x06029422 RID: 168994 RVA: 0x00B976DD File Offset: 0x00B958DD
		public void Reset()
		{
			this.ResultCode = EPlotResultCode.Success;
		}

		// Token: 0x17005379 RID: 21369
		// (get) Token: 0x06029423 RID: 168995 RVA: 0x00B976E8 File Offset: 0x00B958E8
		public string FormatId
		{
			get
			{
				if (this.FormatIdInner == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
					defaultInterpolatedStringHandler.AppendFormatted(this.FlowListName);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int?>(this.FlowId);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int?>(this.StateId);
					this.FormatIdInner = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				return this.FormatIdInner;
			}
		}

		// Token: 0x0401674C RID: 91980
		[Nullable(2)]
		public string FlowListName;

		// Token: 0x0401674D RID: 91981
		public int? FlowId;

		// Token: 0x0401674E RID: 91982
		public int? StateId;

		// Token: 0x0401674F RID: 91983
		public long? FlowIncId;

		// Token: 0x04016750 RID: 91984
		public EPlotResultCode ResultCode;

		// Token: 0x04016751 RID: 91985
		[Nullable(2)]
		private string FormatIdInner;
	}
}
