using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C8D RID: 23693
	public class LevelEventEnableEntityLookAt : LevelEventBase
	{
		// Token: 0x0603A1F3 RID: 238067 RVA: 0x01062D68 File Offset: 0x01060F68
		public LevelEventEnableEntityLookAt(int id) : base(id)
		{
		}

		// Token: 0x0603A1F4 RID: 238068 RVA: 0x01062D74 File Offset: 0x01060F74
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CWZ, "LevelEventEnableEntityLookAt 参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EnableEntityLookAt param = inParams as EnableEntityLookAt;
			AiModel instance = AiModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.EnableEntityLookAt(param);
		}
	}
}
