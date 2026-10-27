using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B3F RID: 27455
	public class LevelEventModifyActorMaterial : LevelEventBase
	{
		// Token: 0x0604415B RID: 278875 RVA: 0x010BE919 File Offset: 0x010BCB19
		public LevelEventModifyActorMaterial(int id) : base(id)
		{
		}

		// Token: 0x0604415C RID: 278876 RVA: 0x010BE924 File Offset: 0x010BCB24
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ModifyActorMaterial modifyActorMaterial = inParams as ModifyActorMaterial;
			if (modifyActorMaterial == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YZH, "参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YZH, "此LevelEvent只能配置在SceneActorRefComponent中", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.Value);
			if (entity == null || !entity.Valid)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.ZS;
				string message = "状态控制entity不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityContext.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
			if (((component != null) ? component.Owner : null) == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZS, "状态控制actor不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SceneItemReferenceComponent component2 = entity.GetComponent<SceneItemReferenceComponent>();
			if (component2 != null)
			{
				component2.HandleActorMaterial(modifyActorMaterial);
			}
		}
	}
}
