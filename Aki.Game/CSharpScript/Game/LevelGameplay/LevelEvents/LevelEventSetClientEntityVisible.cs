using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B72 RID: 27506
	public class LevelEventSetClientEntityVisible : LevelEventBase
	{
		// Token: 0x0604423A RID: 279098 RVA: 0x010C8CDC File Offset: 0x010C6EDC
		public LevelEventSetClientEntityVisible(int id) : base(id)
		{
		}

		// Token: 0x0604423B RID: 279099 RVA: 0x010C8CE8 File Offset: 0x010C6EE8
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
