using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x02000208 RID: 520
	[NullableContext(1)]
	[Nullable(0)]
	public class UpdateReportEvent : IDiffUpdateReportEvent
	{
		// Token: 0x06000D67 RID: 3431 RVA: 0x000516C7 File Offset: 0x0004F8C7
		public UpdateReportEvent(string eventPrefix)
		{
			this.EventPrefix = eventPrefix;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000516D8 File Offset: 0x0004F8D8
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

		// Token: 0x06000D69 RID: 3433 RVA: 0x00051770 File Offset: 0x0004F970
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

		// Token: 0x06000D6A RID: 3434 RVA: 0x00051808 File Offset: 0x0004FA08
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

		// Token: 0x04000866 RID: 2150
		private readonly string EventPrefix;
	}
}
