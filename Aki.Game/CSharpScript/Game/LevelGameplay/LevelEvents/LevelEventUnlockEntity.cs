using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BB1 RID: 27569
	public class LevelEventUnlockEntity : LevelEventBase
	{
		// Token: 0x0604431D RID: 279325 RVA: 0x010CECD8 File Offset: 0x010CCED8
		public LevelEventUnlockEntity(int id) : base(id)
		{
		}

		// Token: 0x0604431E RID: 279326 RVA: 0x010CECE4 File Offset: 0x010CCEE4
		[NullableContext(1)]
		public override void ExecuteAction(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (context.Type.GetValueOrDefault() == EGeneralContextType.Entity)
			{
				EntityContext entityContext = context as EntityContext;
				if (entityContext != null && entityContext.ClientExecuteActions)
				{
					foreach (int num in (inParams as UnlockEntity).EntityIds)
					{
						EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
						LevelTagComponent levelTagComponent;
						if (entityByPbDataId == null)
						{
							levelTagComponent = null;
						}
						else
						{
							WorldEntity entity = entityByPbDataId.Entity;
							levelTagComponent = ((entity != null) ? entity.GetComponent<LevelTagComponent>() : null);
						}
						LevelTagComponent levelTagComponent2 = levelTagComponent;
						if (levelTagComponent2 == null)
						{
							global::Log instance = global::Log.Instance;
							ELogModule module = ELogModule.Plot;
							ELogAuthor author = ELogAuthor.CH;
							string message = "找不对对应的实体";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", num);
							instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
						else
						{
							levelTagComponent2.RemoveServerTagByIdLocal(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.锁定"], "LevelEventUnlockEntity");
						}
					}
					return;
				}
			}
			base.FinishExecute(true, false, true);
		}
	}
}
