using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B3E RID: 27454
	public class LevelEventLog : LevelEventBase
	{
		// Token: 0x06044159 RID: 278873 RVA: 0x010BE871 File Offset: 0x010BCA71
		public LevelEventLog(int id) : base(id)
		{
		}

		// Token: 0x0604415A RID: 278874 RVA: 0x010BE87C File Offset: 0x010BCA7C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			Aki.TDConfigMgr.Action.Log log = inParams as Aki.TDConfigMgr.Action.Log;
			if (log == null)
			{
				return;
			}
			string level = log.Level;
			if (level == "Warn")
			{
				global::Log.Instance.Warn(ELogModule.LevelEvent, ELogAuthor.YZH, log.Content, default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (level == "Info")
			{
				global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.YZH, log.Content, default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!(level == "Error"))
			{
				return;
			}
			global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YZH, log.Content, default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
