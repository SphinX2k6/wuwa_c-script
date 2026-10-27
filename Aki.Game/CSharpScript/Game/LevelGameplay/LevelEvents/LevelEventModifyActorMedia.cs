using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B40 RID: 27456
	public class LevelEventModifyActorMedia : LevelEventBase
	{
		// Token: 0x0604415D RID: 278877 RVA: 0x010BEA1B File Offset: 0x010BCC1B
		public LevelEventModifyActorMedia(int id) : base(id)
		{
		}

		// Token: 0x0604415E RID: 278878 RVA: 0x010BEA24 File Offset: 0x010BCC24
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ModifyActorMedia modifyActorMedia = inParams as ModifyActorMedia;
			if (modifyActorMedia == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.BB, "参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.BB, "此LevelEvent只能配置在SceneActorRefComponent中", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.Value);
			if (entity == null || !entity.Valid)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.BB;
				string message = "状态控制entity不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityContext.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			SceneItemReferenceComponent component = entity.GetComponent<SceneItemReferenceComponent>();
			if (component != null)
			{
				component.HandleActorMedia(modifyActorMedia);
			}
		}
	}
}
