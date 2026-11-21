using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CB6 RID: 23734
	public class LevelEventLog : LevelEventBase
	{
		// Token: 0x0603A2AB RID: 238251 RVA: 0x010682ED File Offset: 0x010664ED
		public LevelEventLog(int id) : base(id)
		{
		}

		// Token: 0x0603A2AC RID: 238252 RVA: 0x010682F8 File Offset: 0x010664F8
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
