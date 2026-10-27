using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B11 RID: 27409
	public class LevelEventDisableEntityLookAt : LevelEventBase
	{
		// Token: 0x0604408C RID: 278668 RVA: 0x010B8AD6 File Offset: 0x010B6CD6
		public LevelEventDisableEntityLookAt(int id) : base(id)
		{
		}

		// Token: 0x0604408D RID: 278669 RVA: 0x010B8AE0 File Offset: 0x010B6CE0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CWZ, "LevelEventDisableEntityLookAt 参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			DisableEntityLookAt disableEntityLookAt = inParams as DisableEntityLookAt;
			AiModel instance = AiModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.DisableEntityLookAt(disableEntityLookAt.Key);
		}
	}
}
