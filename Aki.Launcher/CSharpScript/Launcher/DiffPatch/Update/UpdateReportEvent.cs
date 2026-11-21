using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x0200020D RID: 525
	[NullableContext(1)]
	[Nullable(0)]
	public class UpdateReportEvent : IDiffUpdateReportEvent
	{
		// Token: 0x06000DA8 RID: 3496 RVA: 0x000541BB File Offset: 0x000523BB
		public UpdateReportEvent(string eventPrefix)
		{
			this.EventPrefix = eventPrefix;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000541CC File Offset: 0x000523CC
		public void Start(HotPatchLog log, [Nullable(2)] string suffixTag = null)
		{
			string text;
			if (suffixTag == null)
			{
				text = this.EventPrefix + "_" + log.s_step_id + "_start";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
				defaultInterpolatedStringHandler.AppendFormatted(this.EventPrefix);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted(suffixTag);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted(log.s_step_id);
				defaultInterpolatedStringHandler.AppendLiteral("_start");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string s_step_id = text;
			log.s_step_id = s_step_id;
			HotPatchLogReport.Instance.Report(log);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00054264 File Offset: 0x00052464
		public void End(HotPatchLog log, [Nullable(2)] string suffixTag = null)
		{
			string text;
			if (suffixTag == null)
			{
				text = this.EventPrefix + "_" + log.s_step_id + "_end";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 3);
				defaultInterpolatedStringHandler.AppendFormatted(this.EventPrefix);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted(suffixTag);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted(log.s_step_id);
				defaultInterpolatedStringHandler.AppendLiteral("_end");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string s_step_id = text;
			log.s_step_id = s_step_id;
			HotPatchLogReport.Instance.Report(log);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000542FC File Offset: 0x000524FC
		public void Event(HotPatchLog log, [Nullable(2)] string suffixTag = null)
		{
			string text;
			if (suffixTag == null)
			{
				text = this.EventPrefix + "_" + log.s_step_id + "_event";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
				defaultInterpolatedStringHandler.AppendFormatted(this.EventPrefix);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted(suffixTag);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted(log.s_step_id);
				defaultInterpolatedStringHandler.AppendLiteral("_event");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string s_step_id = text;
			log.s_step_id = s_step_id;
			HotPatchLogReport.Instance.Report(log);
		}

		// Token: 0x040008A7 RID: 2215
		private readonly string EventPrefix;
	}
}
