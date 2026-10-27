using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006DA0 RID: 28064
	public class LevelEventSetClientEntityVisibleSave : LevelEventBase
	{
		// Token: 0x060447FC RID: 280572 RVA: 0x010E4983 File Offset: 0x010E2B83
		public LevelEventSetClientEntityVisibleSave(int id) : base(id)
		{
		}

		// Token: 0x060447FD RID: 280573 RVA: 0x010E498C File Offset: 0x010E2B8C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SetEntityClientVisibleSave setEntityClientVisibleSave = inParams as SetEntityClientVisibleSave;
			if (setEntityClientVisibleSave == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CH, "参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (context.Type.GetValueOrDefault() == EGeneralContextType.Entity)
			{
				EntityContext entityContext = context as EntityContext;
				if (entityContext != null && entityContext.ClientExecuteActions)
				{
					if (setEntityClientVisibleSave.EntityIds == null || setEntityClientVisibleSave.EntityIds.Count == 0)
					{
						global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CH, "目标Entity未配置", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					foreach (int num in setEntityClientVisibleSave.EntityIds)
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
							instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
						else
						{
							CreatureController.Instance.SetEntityEnable(worldEntity, setEntityClientVisibleSave.Visible, "LevelEventSetClientEntityVisible", false);
						}
					}
					return;
				}
			}
			global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.FZX, "不是场景引用的帧事件", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
