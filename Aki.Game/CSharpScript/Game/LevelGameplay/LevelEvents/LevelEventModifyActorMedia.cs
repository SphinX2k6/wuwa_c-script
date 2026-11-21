using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CB8 RID: 23736
	public class LevelEventModifyActorMedia : LevelEventBase
	{
		// Token: 0x0603A2AF RID: 238255 RVA: 0x01068497 File Offset: 0x01066697
		public LevelEventModifyActorMedia(int id) : base(id)
		{
		}

		// Token: 0x0603A2B0 RID: 238256 RVA: 0x010684A0 File Offset: 0x010666A0
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
