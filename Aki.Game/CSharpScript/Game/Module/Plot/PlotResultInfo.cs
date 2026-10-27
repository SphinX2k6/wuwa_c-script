using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FE4 RID: 20452
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotResultInfo
	{
		// Token: 0x06034598 RID: 214424 RVA: 0x00C4D656 File Offset: 0x00C4B856
		public PlotResultInfo()
		{
			this.FlowListName = "";
			this.FlowId = new int?(0);
			this.StateId = new int?(0);
			this.FlowIncId = new long?(0L);
			this.ResultCode = EPlotResultCode.Success;
		}

		// Token: 0x06034599 RID: 214425 RVA: 0x00C4D695 File Offset: 0x00C4B895
		public void Reset()
		{
			this.ResultCode = EPlotResultCode.Success;
		}

		// Token: 0x17007FC5 RID: 32709
		// (get) Token: 0x0603459A RID: 214426 RVA: 0x00C4D6A0 File Offset: 0x00C4B8A0
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

		// Token: 0x0401BD71 RID: 114033
		[Nullable(2)]
		public string FlowListName;

		// Token: 0x0401BD72 RID: 114034
		public int? FlowId;

		// Token: 0x0401BD73 RID: 114035
		public int? StateId;

		// Token: 0x0401BD74 RID: 114036
		public long? FlowIncId;

		// Token: 0x0401BD75 RID: 114037
		public EPlotResultCode ResultCode;

		// Token: 0x0401BD76 RID: 114038
		[Nullable(2)]
		private string FormatIdInner;
	}
}
