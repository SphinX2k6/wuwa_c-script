using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CEA RID: 23786
	public class LevelEventSetClientEntityVisible : LevelEventBase
	{
		// Token: 0x0603A38C RID: 238476 RVA: 0x01072950 File Offset: 0x01070B50
		public LevelEventSetClientEntityVisible(int id) : base(id)
		{
		}

		// Token: 0x0603A38D RID: 238477 RVA: 0x0107295C File Offset: 0x01070B5C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SetEntityClientVisible setEntityClientVisible = inParams as SetEntityClientVisible;
			if (setEntityClientVisible == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CH, "参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (setEntityClientVisible.EntityIds == null || setEntityClientVisible.EntityIds.Count == 0)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CH, "目标Entity未配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (int num in setEntityClientVisible.EntityIds)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
				WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
				if (worldEntity == null || !worldEntity.Valid)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.CH;
					string message = "目标Entity不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", num);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					CreatureController.Instance.SetEntityEnable(worldEntity, setEntityClientVisible.Visible, "LevelEventSetClientEntityVisible", true);
				}
			}
		}
	}
}
